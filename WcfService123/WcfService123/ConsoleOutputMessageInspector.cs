using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Xml;

namespace WcfService123
{
    public class ConsoleOutputMessageInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            // Declare variables
            string Service = "";
            //string UserToken = null;
            string ServiceCall = "";
            string Body = "";
			
			// Make a copy of the message for viewing
            MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue);
            Message msgCopy = buffer.CreateMessage();

            request = buffer.CreateMessage();

            // Get the XML content
            string strMessage = buffer.CreateMessage().ToString();

            // Get the SOAP XML body content
            XmlDictionaryReader xrdr = msgCopy.GetReaderAtBodyContents();
            string bodyData = xrdr.ReadOuterXml();

            // Replace the body placeholder with the actual SOAP body.
            strMessage = strMessage.Replace("... stream ...", bodyData);

            // Load the SOAP XML string into a new XML Document
            var doc = new XmlDocument();
            doc.LoadXml(strMessage);
			
			 // Get the values of the desired XML nodes
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name == "s:Header")
                {
                    var Service = string.Format("Service: {0}\n", node.FirstChild.InnerText);
                    var Service Call = string.Format("Service Call: {0}\n", node.LastChild.InnerText);
                }
                if (node.Name == "s:Body")
                {
                 var Body = node.InnerXml;
                }
            }
			
		///// OR..... //////
			
			
		// Check to see if XML file has custom header <TokenHeader>, and if it does grab the user token, the Service name and Service Call (contained in the header file)
		// and grab the XML message body
			
		// foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            // {
                // if (node.Name == "s:Header")
                // {
                    // if (node.FirstChild.Name != "TokenHeader")
                    // {
                        // Service = node.FirstChild.InnerText;
                        // ServiceCall = node.LastChild.InnerText;
                    // }
                    // else
                    // {
                        // UserToken = node.FirstChild.InnerText;
                        // Service = node.ChildNodes.Item(1).InnerText;
                        // ServiceCall = node.LastChild.InnerText;
                    // }

                // }

                // if (node.Name == "s:Body")
                // {
                    // Body = node.InnerXml;
                // }
            // }
			
	    // // Make call into database. BLL--> DAL --> Database
            // // insert into activity log table
            // bll.activitylog.insertintoactivitylog(service, servicecall, body, strmessage, usertoken);

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
