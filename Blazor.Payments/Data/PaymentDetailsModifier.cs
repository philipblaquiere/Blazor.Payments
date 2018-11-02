using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentDetailsModifier
	{
		public PaymentDetailsModifier(
			PaymentCurrencyAmount[] additionalDisplayItems,
			string supportedMethods,
			PaymentItem total,
			string supportedTypes)
		{
			this.additionalDisplayItems = additionalDisplayItems;
			this.supportedMethods = supportedMethods;
			this.total = total;
			data = new { supportedTypes };
		}
		public PaymentCurrencyAmount[] additionalDisplayItems { get; set; }
		public string supportedMethods { get; set; }
		public PaymentItem total { get; set; }
		public object data { get; set; }
	}
}
