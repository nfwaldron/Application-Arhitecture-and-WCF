using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Configuration;

namespace WcfService123
{
    public class ConsoleOutputBehaviorExtensionElement : BehaviorExtensionElement
    {
        public ConsoleOutputBehaviorExtensionElement()
        {
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(ConsoleOutputBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new ConsoleOutputBehavior();
        }
    }
}