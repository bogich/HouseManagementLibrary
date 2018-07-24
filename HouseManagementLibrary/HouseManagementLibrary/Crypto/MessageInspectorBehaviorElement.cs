using System;
using System.ServiceModel.Configuration;

namespace HouseManagementLibrary.Crypto
{
	public class MessageInspectorBehaviorElement : BehaviorExtensionElement
	{
		public override Type BehaviorType => typeof(MessageInspectorBehavior);

		protected override object CreateBehavior()
		{
			return new MessageInspectorBehavior();
		}
	}
}