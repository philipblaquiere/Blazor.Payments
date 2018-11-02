using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data.Extensions
{
	public static class ProcessPaymentResultTypeExtensions
	{
		public static string GetString(this PaymentCompleteType type)
		{
			switch (type)		
			{
				case PaymentCompleteType.Success:
					return "success";
				case PaymentCompleteType.Fail:
					return "fail";
				case PaymentCompleteType.Unknown:
				default:
					return "unknown";
			}
		}
	}
}
