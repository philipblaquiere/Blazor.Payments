using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentResponse
	{
		public string requestId { get; set; }
		public string methodName { get; set; }
		public PaymentResponseDetails details { get; set; }
		public PaymentAddress shippingAddress { get; set; }
		public string shippingOption { get; set; }
		public string payerName { get; set; }
		public string payerEmail { get; set; }
		public string payerPhone { get; set; }
	}
}
