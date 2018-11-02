using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentDetailsInit : PaymentDetailsBase
	{
		public PaymentDetailsInit(
			PaymentItem[] displayItems, 
			PaymentShippingOptions[] shippingOptions,
			PaymentItem total,
			string id = null,
			PaymentDetailsModifier[] modifiers = null) : base(displayItems, shippingOptions, modifiers)
		{
			this.id = id;
			this.total = total;
		}

		public string id { get; set; }
		public PaymentItem total { get; set; }
	}
}
