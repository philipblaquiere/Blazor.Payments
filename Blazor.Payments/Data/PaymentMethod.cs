using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentMethod
	{
		public PaymentMethod(string[] supportedMethods) : this(supportedMethods, null) { }

		public PaymentMethod(
			string[] supportedMethods, 
			string[] supportedNetworks) : this(supportedMethods, supportedNetworks, null) {	}

		public PaymentMethod(
			string[] supportedMethods,
			string[] supportedNetworks,
			string[] supportedTypes) : this(supportedMethods, new { supportedNetworks, supportedTypes }) { }

		public PaymentMethod(
			string[] supportedMethods, 
			object data)
		{
			this.supportedMethods = supportedMethods;
			this.data = data;
		}

		public object data { get; set; }

		public string[] supportedMethods { get; set; }
	}
}
