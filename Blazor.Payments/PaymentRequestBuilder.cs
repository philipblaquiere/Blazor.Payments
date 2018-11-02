using System;
using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public static class PaymentRequestBuilder
	{
		public static PaymentRequestContext CreatePaymentRequest(
			PaymentMethod[] paymentMethods,
			PaymentDetailsInit paymentDetails,
			PaymentOptions paymentOptions)
		{
			return new PaymentRequestContext(
				paymentMethods,
				paymentDetails,
				paymentOptions);
		}

		public static PaymentRequestContext Configure(
			this PaymentRequestContext context, 
			Action<PaymentEventsInternalDelegate> configurationDelegate)
		{
			var paymentEventsDelegate = new PaymentEventsInternalDelegate();

			configurationDelegate(paymentEventsDelegate);

			PaymentEventsHandler.RegisterWebPaymentEventsDelegate(paymentEventsDelegate);

			return context;
		}

		public static PaymentRequest Build(this PaymentRequestContext context)
		{
			return new PaymentRequest(
				context.PaymentMethods,
				context.PaymentDetails,
				context.PaymentOptions);
		}
	}
}
