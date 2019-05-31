namespace Blazor.Payments.Data.Extensions
{
	public static class PaymentShippingTypeExtensions
	{
		public static string GetString(this PaymentShippingType shippingType)
		{
			switch (shippingType)
			{
				case PaymentShippingType.Delivery:
					return "delivery";
				case PaymentShippingType.Pickup:
					return "pickup";
				case PaymentShippingType.Shipping:
					return "shipping";
				default:
					return "";
			}
		}
	}
}
