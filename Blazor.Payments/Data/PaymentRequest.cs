using System.Threading.Tasks;
using Blazor.Payments.Contracts;
using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public class PaymentRequest : IPaymentRequest
	{
		private PaymentMethod[] _paymentMethods;
		private PaymentDetailsInit _paymentDetails;
		private PaymentOptions _paymentOptions;

		public PaymentRequest(
			PaymentMethod[] paymentMethods,
			PaymentDetailsInit paymentDetails,
			PaymentOptions paymentOptions = null)
		{
			_paymentMethods = paymentMethods;
			_paymentDetails = paymentDetails;
			_paymentOptions = paymentOptions;
		}

		public Task Show()
		{
			return PaymentJSInterop.Show(
				_paymentMethods,
				_paymentDetails,
				_paymentOptions);
		}
	}
}
