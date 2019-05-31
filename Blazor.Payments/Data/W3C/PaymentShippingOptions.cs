using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentShippingOptions
	{
		public PaymentShippingOptions(
			string id,
			string label,
			PaymentCurrencyAmount amount,
			bool selected = false)
		{
			this.id = id;
			this.label = label;
			this.amount = amount;
			this.selected = selected;
		}

		public string id { get; set; }
		public string label { get; set;  }
		public PaymentCurrencyAmount amount { get; set; }
		public bool selected { get; set; }
	}
}
