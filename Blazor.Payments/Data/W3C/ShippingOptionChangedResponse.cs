using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class ShippingOptionChangedResponse
	{
		public ShippingOptionChangedResponse(
			PaymentShippingOptions[] shippingOptions,
			PaymentItem total)
		{
			this.shippingOptions = shippingOptions;
			this.total = total;
		}

		public PaymentShippingOptions[] shippingOptions { get; set; }
		public PaymentItem total { get; set; }
	}
}
