using System.Collections.Generic;
using System.Linq;
using Blazor.Payments.Data.Extensions;

namespace Blazor.Payments.Data
{
	public class BasicCardPaymentMethod : StandardizedSupportedMethods
	{
		public BasicCardPaymentMethod()
		{
			SupportedMethods = "basic-card";
			SupportedNetworks = new List<string>();
			SupportedTypes = new List<string>();
		}

		protected override string SupportedMethods { get; set; }

		protected IList<string> SupportedNetworks { get; set; }

		protected IList<string> SupportedTypes { get; set; }

		public BasicCardPaymentMethod AddSupportedNetwork(SupportedNetworkType network)
		{
			this.SupportedNetworks.Add(network.GetString());

			return this;
		}

		public BasicCardPaymentMethod AddSupportedType(SupportedTypesType type)
		{
			this.SupportedTypes.Add(type.GetString());

			return this;
		}

		public PaymentMethod Build()
		{
			return new PaymentMethod(
				this.SupportedMethods,
				this.SupportedNetworks.ToArray(),
				this.SupportedTypes.ToArray());
		}
	}
}
