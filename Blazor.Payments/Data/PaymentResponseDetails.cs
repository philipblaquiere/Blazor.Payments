using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentResponseDetails
	{
		public PaymentAddress billingAddress { get; set; }
		public string cardNumber { get; set; }
		public string cardSecurityCode { get; set; }
		public string cardholderName { get; set; }
		public string expiryMonth { get; set; }
		public string expiryYear { get; set; }
	}
}
