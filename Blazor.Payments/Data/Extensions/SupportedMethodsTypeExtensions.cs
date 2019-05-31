using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data.Extensions
{
	public static class SupportedMethodsTypeExtensions
	{
		public static string GetUrl(this SupportedMethodsType supportedMethod)
		{
			switch (supportedMethod)
			{
				case SupportedMethodsType.ApplePay:
					return "https://apple.com/apple-pay";
				case SupportedMethodsType.SamsungPay:
					return "https://spay.samsung.com";
				case SupportedMethodsType.GooglePay:
					return "https://google.com/pay";
				case SupportedMethodsType.Facebook:
					return "fb";
				default:
					return "";
			}
		}
	}
}
