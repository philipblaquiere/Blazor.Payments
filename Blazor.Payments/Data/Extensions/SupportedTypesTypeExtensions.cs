using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data.Extensions
{
	public static class SupportedTypesTypeExtensions
	{
		public static string GetString(this SupportedTypesType type)
		{
			switch (type)
			{
				case SupportedTypesType.Credit:
					return "credit";
				case SupportedTypesType.Debit:
					return "debit";
				case SupportedTypesType.Prepaid:
					return "prepaid";
				default:
					return "";
			}
		}
	}
}
