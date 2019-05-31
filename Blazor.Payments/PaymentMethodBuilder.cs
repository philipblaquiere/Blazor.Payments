using Blazor.Payments.Data;

namespace Blazor.Payments
{
	public class PaymentMethodBuilder
	{
		public UrlBasedSupportedMethods CreateUrlPaymentMethod(SupportedMethodsType supportedMethods = SupportedMethodsType.Custom)
		{
			var context = new UrlPaymentMethod(supportedMethods);

			return context;
		}

		public BasicCardPaymentMethod CreateBasicCardPaymentMethod()
		{
			var context = new BasicCardPaymentMethod();

			return context;
		}
	}
}
