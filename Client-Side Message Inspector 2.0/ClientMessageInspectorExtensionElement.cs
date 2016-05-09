using System;
using System.ServiceModel.Configuration;

namespace ProjectXWPF
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