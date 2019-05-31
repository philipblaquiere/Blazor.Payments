using System;
using System.Collections.Generic;
using System.Linq;
using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public static class PaymentRequestBuilder
	{
		public static PaymentRequestContext CreateDefaultPaymentRequest(
			PaymentDetailsInit paymentDetails,
			PaymentOptions paymentOptions = null,
			PaymentMethod[] paymentMethods = null)
		{
			var paymentMethodList = new List<PaymentMethod>();

			if(paymentMethods != null && !paymentMethods.Any())
			{
				paymentMethodList.AddRange(paymentMethods);
			}

			if(paymentOptions == null)
			{
				paymentOptions = new PaymentOptions();
			}

			return new PaymentRequestContext(
				paymentDetails,
				paymentOptions,
				paymentMethodList);
		}

		public static PaymentRequestContext AddPaymentOptions(this PaymentRequestContext context, Func<PaymentOptionsBuilder, PaymentOptions> paymentOptionsBuilder)
		{
			var paymentOptions = paymentOptionsBuilder(new PaymentOptionsBuilder());

			if (paymentOptions != null)
			{
				context.PaymentOptions = paymentOptions;
			}

			return context;
		}

		public static PaymentRequestContext AddPaymentMethod(this PaymentRequestContext context, Func<PaymentMethodBuilder, PaymentMethod> paymentMethodBuilder)
		{
			var paymentMethod = paymentMethodBuilder(new PaymentMethodBuilder());

			if(paymentMethod != null)
			{
				context.PaymentMethods.Add(paymentMethod);
			}

			return context;
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
				context.PaymentMethods.ToArray(),
				context.PaymentDetails,
				context.PaymentOptions);
		}
	}
}
