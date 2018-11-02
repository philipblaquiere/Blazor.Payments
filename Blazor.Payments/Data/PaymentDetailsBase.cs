namespace Blazor.Payments.Data
{
	public class PaymentDetailsBase
	{
		public PaymentDetailsBase()
		{
		}

		public PaymentDetailsBase(
			PaymentItem[] displayItems,
			PaymentShippingOptions[] shippingOptions,
			PaymentDetailsModifier[] modifiers)
		{
			this.displayItems = displayItems;
			this.shippingOptions = shippingOptions;
			this.modifiers = modifiers;
		}

		public PaymentItem[] displayItems { get; set; }
		public PaymentShippingOptions[] shippingOptions { get; set; }
		public PaymentDetailsModifier[] modifiers { get; set; }
	}
}
