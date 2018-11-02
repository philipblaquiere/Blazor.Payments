using Blazor.Payments.Contracts;
using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public class PaymentRequestContext
	{
		public PaymentRequestContext(
			PaymentMethod[] paymentMethods,
			PaymentDetailsInit paymentDetails,
			PaymentOptions paymentOptions)
		{
			PaymentMethods = paymentMethods;
			PaymentDetails = paymentDetails;
			PaymentOptions = paymentOptions;
		}

		public PaymentMethod[] PaymentMethods { get; }
		public PaymentDetailsInit PaymentDetails { get; }
		public PaymentOptions PaymentOptions { get; }
	}
}
