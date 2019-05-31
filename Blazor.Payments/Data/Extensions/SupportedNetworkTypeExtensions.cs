using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data.Extensions
{
	public static class SupportedNetworkTypeExtensions
	{
		public static string GetString(this SupportedNetworkType type)
		{
			switch (type)
			{
				case SupportedNetworkType.Amex:
					return "amex";
				case SupportedNetworkType.CarteBancaire:
					return "cartebancaire";
				case SupportedNetworkType.Diners:
					return "diners";
				case SupportedNetworkType.Discover:
					return "discover";
				case SupportedNetworkType.JCB:
					return "jcb";
				case SupportedNetworkType.Mastercard:
					return "mastercard";
				case SupportedNetworkType.MIR:
					return "mir";
				case SupportedNetworkType.UnionPay:
					return "unionpay";
				case SupportedNetworkType.Visa:
					return "visa";
				case SupportedNetworkType.All:
				default:
					return "";
			}
		}
	}
}
