using Blazor.Payments.Data.Extensions;

namespace Blazor.Payments.Data
{
	internal class UrlPaymentMethod : UrlBasedSupportedMethods
	{
		public UrlPaymentMethod(SupportedMethodsType supportedMethodType = SupportedMethodsType.Custom)
		{
			SupportedMethods = supportedMethodType.GetUrl();
		}

		protected override object Data { get; set; } = new object { };

		protected override string SupportedMethods { get; set; }
	}
}
