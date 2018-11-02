using Blazor.Payments.Data;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Payments
{
	internal static class PaymentJSInterop
	{	
		public static Task<bool> CanMakePayment()
		{
			return JSRuntime.Current.InvokeAsync<bool>(
				   "blazorPaymentsInterop.canMakePayment");
		}

		public static async Task Show(PaymentMethod[] paymentMethods, PaymentDetailsBase paymentDetails, PaymentOptions paymentOptions)
		{
			await JSRuntime.Current.InvokeAsync<object>(
				"blazorPaymentsInterop.showPayment",
				paymentMethods,
				paymentDetails,
				paymentOptions);
		}

	}
}
