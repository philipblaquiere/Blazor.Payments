using System.Collections.Generic;

namespace Blazor.Payments.Data
{
	public class PaymentRequestContext
	{
		public PaymentRequestContext(
			PaymentDetailsInit paymentDetails,
			PaymentOptions paymentOptions,
			IList<PaymentMethod> paymentMethods)
		{
			PaymentDetails = paymentDetails;
			PaymentOptions = paymentOptions;
			PaymentMethods = paymentMethods;
		}
		
		internal IList<PaymentMethod> PaymentMethods { get; set; }
		internal PaymentDetailsInit PaymentDetails { get; set; }
		internal PaymentOptions PaymentOptions { get; set; }
	}
}
