using System;
using System.Threading.Tasks;
using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public class PaymentEventsInternalDelegate
	{
		public Func<PaymentAddress, Task<PaymentDetailsUpdate>> ShippingAddressChangedAsync { get; set; }
		public Func<string, Task<PaymentDetailsUpdate>> ShippingOptionChangedAsync { get; set; }
		public Func<PaymentResponse, Task<PaymentComplete>> PaymentResponseAsync { get; set; }
		public Func<PaymentException, Task> PaymentExceptionAsync { get; set; }
	}
}
