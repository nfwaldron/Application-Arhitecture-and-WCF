using ProjectX.ApplicationService.Contracts.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;
using System.Xml;

namespace ProjectX.ApplicationService.Host
{
    public class MessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            // Declare variables
            string Service = "";
            string UserToken = null;
            string ServiceCall = "";
            string Body = "";

            // Make a copy of the message for viewing / data manipulation
            MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue);
            Message msgCopy = buffer.CreateMessage();

            // A message can only be consumed once, so make sure you  return a copy
            request = buffer.CreateMessage();

            // Get the XML content
            var strMessage = msgCopy.ToString();

            // Get the SOAP XML body content
            XmlDictionaryReader xrdr = msgCopy.GetReaderAtBodyContents();
            string bodyData = xrdr.ReadOuterXml();

            // Replace the body placeholder with the actual SOAP body.
            strMessage = strMessage.Replace("... stream ...", bodyData);

            // Load the SOAP XML string into a new XML Document
            var doc = new XmlDocument();
            doc.LoadXml(strMessage);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name == "s:Header")
                {
                    if (node.FirstChild.Name != "TokenHeader")
                    {
                        Service = node.FirstChild.InnerText;
                        ServiceCall = node.LastChild.InnerText;
                    }
                    else
                    {
                        UserToken = node.FirstChild.InnerText;
                        Service = node.ChildNodes.Item(1).InnerText;
                        ServiceCall = node.LastChild.InnerText;
                    }
                }

                if (node.Name == "s:Body")
                {
                    Body = node.InnerXml;
                }
            }

            // The ExemptServiceCalls Class contains a list of services that we to NOT want to keep a record of.
            // The properties of this class are converted into a list.

            var serviceList = ExemptServiceCalls.GetExemptServices();

            // Query the list to see if it contains an exempt service call
            var containsExemptService = serviceList.Contains(ServiceCall);

            // If the class does not contain en exempt service call, enter it into the database
            if(containsExemptService == false)
            {
                // Insert Into Activity Log table
                BLL.ActivityLog.InsertIntoActivityLog(Service, ServiceCall, Body, strMessage, UserToken);
            }
            
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            MessageBuffer buffer = reply.CreateBufferedCopy(Int32.MaxValue);
            reply = buffer.CreateMessage();

            Console.WriteLine("Sending:\n{0}", buffer.CreateMessage().ToString());
        }
    }
}