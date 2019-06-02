using Blazor.Payments.Data.Extensions;

namespace Blazor.Payments.Data
{
	public class PaymentComplete
	{
		public PaymentComplete() : this(PaymentCompleteType.Unknown)
		{
		}

		public PaymentComplete(PaymentCompleteType paymentComplete)
		{
			result = paymentComplete.GetString();
		}

		public string result { get; set; }
	}
}
