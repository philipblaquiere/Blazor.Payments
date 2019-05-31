using System.Threading.Tasks;
using Microsoft.JSInterop;
using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public static class PaymentEventsHandler
	{
		private static PaymentEventsInternalDelegate _webPaymentEventsDelegate;

		public static void RegisterWebPaymentEventsDelegate(PaymentEventsInternalDelegate webPaymentEventsDelegate)
		{
			_webPaymentEventsDelegate = webPaymentEventsDelegate;
		}

		[JSInvokable("OnShippingAddressChangedInterop")]
		public static async Task<PaymentDetailsUpdate> OnShippingAddressChangedInterop(PaymentAddress address)
		{
			if (_webPaymentEventsDelegate?.ShippingAddressChangedAsync != null)
			{
				return await _webPaymentEventsDelegate.ShippingAddressChangedAsync(address);
			}

			return null;
		}

		[JSInvokable("OnShippingOptionChangedInterop")]
		public static async Task<PaymentDetailsUpdate> OnShippingOptionChangedInterop(string selectedId)
		{
			if (_webPaymentEventsDelegate?.ShippingOptionChangedAsync != null)
			{
				return await _webPaymentEventsDelegate.ShippingOptionChangedAsync(selectedId);
			}

			return null;
		}

		[JSInvokable("OnPaymentResponseInterop")]
		public static async Task<PaymentComplete> OnPaymentResponseInterop(PaymentResponse paymentResponse)
		{
			if (_webPaymentEventsDelegate?.PaymentResponseAsync != null)
			{
				return await _webPaymentEventsDelegate.PaymentResponseAsync(paymentResponse);
			}

			return null;
		}

		[JSInvokable("OnPaymentExceptionInterop")]
		public static async Task OnPaymentExceptionInterop(PaymentException paymentException)
		{
			if (_webPaymentEventsDelegate?.PaymentExceptionAsync != null)
			{
				await _webPaymentEventsDelegate.PaymentExceptionAsync(paymentException);
			}
		}
	}
}
