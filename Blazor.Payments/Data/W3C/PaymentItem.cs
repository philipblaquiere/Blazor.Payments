using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentItem
	{
		public PaymentItem(
			string label,
			PaymentCurrencyAmount amount, 
			bool pending = false)
		{
			this.label = label;
			this.amount = amount;
			this.pending = pending;
		}

		public string label { get; set; }
		public PaymentCurrencyAmount amount { get; set; }
		public bool pending { get; set; }
	}
}
