using Blazor.Payments.Data.Extensions;

namespace Blazor.Payments.Data
{
	public class PaymentOptions
	{
		public PaymentOptions(
			bool requestShipping = false,
			bool requestPayerEmail = false,
			bool requestPayerPhone = false,
			bool requestPayerName = false,
			PaymentShippingType shippingType = default)
		{
			RequestShipping = requestShipping;
			RequestPayerEmail = requestPayerEmail;
			RequestPayerPhone = requestPayerPhone;
			RequestPayerName = requestPayerName;
			ShippingType = shippingType.GetString();
		}

		public bool RequestShipping { get; set;  }
		public bool RequestPayerEmail { get; set; }
		public bool RequestPayerPhone { get; set; } 
		public bool RequestPayerName { get; set; }
		public string ShippingType { get; set; }
	}
}
