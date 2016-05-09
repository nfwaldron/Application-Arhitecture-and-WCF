using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;

namespace ProjectX.ApplicationService.Host
{
    public class MessageBehaviorExtensionElement : BehaviorExtensionElement
    {
        public MessageBehaviorExtensionElement()
        {
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(MessageBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new MessageBehavior();
        }
    }
}