namespace Blazor.Payments.Data
{
	public abstract class UrlBasedSupportedMethods : PaymentMethodBase
	{
		protected abstract object Data { get; set; }

		public UrlBasedSupportedMethods AddData(object data)
		{
			Data = data;

			return this;
		}

		public UrlBasedSupportedMethods AddUrl(string url)
		{
			SupportedMethods = url;

			return this;
		}

		public PaymentMethod Build()
		{
			return new PaymentMethod(SupportedMethods, Data);
		}
	}
}
