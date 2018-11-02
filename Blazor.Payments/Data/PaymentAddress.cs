using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class PaymentAddress
	{
		public string City { get; set; }
		public string Country { get; set; }
		public string DependentLocality { get; set; }
		public string LanguageCode { get; set; }
		public string Organization { get; set; }
		public string Phone { get; set; }
		public string PostalCode { get; set; }
		public string Recipient { get; set; }
		public string Region { get; set; }
		public string RegionCode { get; set; }
		public string SortingCode { get; set; }
		public string[] AddressLine { get; set; }
	}
}
