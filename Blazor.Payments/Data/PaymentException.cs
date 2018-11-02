using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentException
	{
		public int code { get; set; }
		public string message { get; set; }
		public string name { get; set; }
	}
}
