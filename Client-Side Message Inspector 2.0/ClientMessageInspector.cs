using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Xml;

namespace ProjectXWPF
{
    public class ClientMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {

        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            // Shared object that stores the user object once it's created
            string token = ProjectX.ApplicationService.MySharedObjects.UserToken;

            // Create buffered copy 
            MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue);
            var cpy = buffer.CreateMessage();

            // Create an XML document from the copy of the request
            var message = cpy.ToString();
            XmlDictionaryReader xmlr = cpy.GetReaderAtBodyContents();
            string xmlBody = xmlr.ReadOuterXml();
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlBody);

            // Get a list of XML elements that match the provided argument "UserToken"
            var xmlList = xmlDoc.GetElementsByTagName("UserToken");

            // Select the UserToken element
            XmlNode userTokenNode = xmlList.Item(0);

            // Update the inner text of the node with the user token
            userTokenNode.InnerText = token;
            var xmlReader = new XmlTextReader(new StringReader(xmlDoc.OuterXml));

            request = Message.CreateMessage(request.Version, request.Headers.Action, xmlReader);
            
            return null;

        }
    }
}
