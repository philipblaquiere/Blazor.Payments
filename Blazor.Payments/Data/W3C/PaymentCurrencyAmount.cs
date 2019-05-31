using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentCurrencyAmount
	{
		public PaymentCurrencyAmount(
			string currency,
			string value)
		{
			this.currency = currency;
			this.value = value;
		}

		public string currency { get; set; }
		public string value { get; set;  }
	}
}
