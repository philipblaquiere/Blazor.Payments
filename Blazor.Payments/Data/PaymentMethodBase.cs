using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public abstract class PaymentMethodBase
	{
		protected abstract string SupportedMethods { get; set; }
	}
}
