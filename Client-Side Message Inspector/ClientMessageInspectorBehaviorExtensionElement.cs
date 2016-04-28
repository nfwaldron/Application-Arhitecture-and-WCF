using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    class ClientMessageInspectorBehaviorExtensionElement : BehaviorExtensionElement
    {
        public ClientMessageInspectorBehaviorExtensionElement()
        {

        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(ClientMessageInspectorBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new ClientMessageInspectorBehavior();
        }

    }
}
