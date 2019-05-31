using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentDetailsUpdate : PaymentDetailsBase
	{
		public PaymentDetailsUpdate(
			PaymentItem total,
			PaymentItem[] displayItems,
			PaymentShippingOptions[] shippingOptions,
			PaymentDetailsModifier[] modifiers = null,
			AddressErrors shippingAddressErrors = null,
			string error = null) : base(displayItems, shippingOptions, modifiers)
		{
			this.error = error;
			this.total = total;
			this.shippingAddressErrors = shippingAddressErrors;
		}

		public string error { get; set; }
		public PaymentItem total { get; set;  }
		public AddressErrors shippingAddressErrors { get; set;  }
	}
}
