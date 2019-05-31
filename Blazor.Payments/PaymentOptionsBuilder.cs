using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public class PaymentOptionsBuilder
	{
		private PaymentOptionsContext context;

		public PaymentOptionsBuilder()
		{
			context = new PaymentOptionsContext();
		}

		public PaymentOptionsBuilder RequestShipping()
		{
			context.Shipping = true;

			return this;
		}

		public PaymentOptionsBuilder RequestPayerEmail()
		{
			context.PayerEmail = true;

			return this;
		}

		public PaymentOptionsBuilder RequestPayerName()
		{
			context.PayerName = true;

			return this;
		}

		public PaymentOptionsBuilder RequestPayerPhone()
		{
			context.PayerPhone = true;

			return this;
		}

		public PaymentOptionsBuilder ShippingOption(PaymentShippingType shippingType)
		{
			context.ShippingType = shippingType;

			return this;
		}

		public PaymentOptions Build()
		{
			return new PaymentOptions(
				context.Shipping,
				context.PayerEmail,
				context.PayerPhone,
				context.PayerName,
				context.ShippingType);
		}
	}
}
