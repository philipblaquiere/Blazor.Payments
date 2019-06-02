using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public enum PaymentShippingType
	{
		None = 0,
		Shipping = 1,
		Delivery = 2,
		Pickup = 3
	}
}
