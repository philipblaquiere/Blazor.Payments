using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentOptionsContext
	{
		public PaymentOptionsContext(
			bool requestShipping = false,
			bool requestPayerEmail = false,
			bool requestPayerPhone = false,
			bool requestPayerName = false,
			PaymentShippingType shippingType = default)
		{
			this.Shipping = requestShipping;
			this.PayerEmail = requestPayerEmail;
			this.PayerPhone = requestPayerPhone;
			this.PayerName = requestPayerName;
			this.ShippingType = shippingType;
		}

		internal bool Shipping { get; set; }
		internal bool PayerEmail { get; set; }
		internal bool PayerPhone { get; set; }
		internal bool PayerName { get; set; }
		internal PaymentShippingType ShippingType { get; set; }
	}
}
