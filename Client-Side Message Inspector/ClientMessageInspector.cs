using ProjectX.ApplicationService.Contracts.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectX
{
    public class ClientMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {

        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
                // Shared object that stores the user object once it's created
		UserDataContract myUser = MySharedObjects.MyUser;

            if (myUser!=null)
            {
                // Create the Message Header
                MessageHeader header = MessageHeader.CreateHeader("TokenHeader", "TokenNameSpace", myUser.Token);

                // Create buffered copy 
                MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue);
                request = buffer.CreateMessage();
				
		// Add the custom Message Header
                request.Headers.Add(header);

		//////// CUSTOM CODE FOR VIEWING THE MESSAGE ...just used to make sure that the actual request looks like you want it to ////////
				
                // Make a copy of the message for viewing
                Message msgCopy = buffer.CreateMessage();
                msgCopy.Headers.Add(header);

                // Get the XML content
                var strMessage = msgCopy.ToString();

                // Get the SOAP XML body content
                XmlDictionaryReader xrdr = msgCopy.GetReaderAtBodyContents();
                string bodyData = xrdr.ReadOuterXml();

                // Replace the body placeholder with the actual SOAP body.
                strMessage = strMessage.Replace("... stream ...", bodyData);
            }

            return null;
        }
    }
}
