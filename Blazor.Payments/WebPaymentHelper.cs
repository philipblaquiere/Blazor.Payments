using System.Threading.Tasks;

namespace Blazor.Payments
{
	public static class WebPaymentHelper
	{
		public static Task<bool> CanMakePayment()
		{
			return PaymentJSInterop.CanMakePayment();
		}
	}
}
