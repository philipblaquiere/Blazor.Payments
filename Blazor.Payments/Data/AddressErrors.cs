using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Payments.Data
{
	public class AddressErrors
	{
		/// <summary>
		/// Denotes that the address line has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's addressLine attribute's value.
		/// </summary>
		public string AddressLine { get; set; }

		/// <summary>
		/// Denotes that the city has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's city attribute's value.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Denotes that the country has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's country attribute's value.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		/// Denotes that the dependent locality has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's dependentLocality attribute's value.
		/// </summary>
		public string DependentLocality { get; set; }

		/// <summary>
		/// Denotes that the language code has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's languageCode attribute's value.
		/// </summary>
		public string LanguageCode { get; set; }

		/// <summary>
		/// Denotes that the organization has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's organization attribute's value.
		/// </summary>
		public string Organization { get; set; }

		/// <summary>
		/// Denotes that the phone number has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's phone attribute's value.
		/// </summary>
		public string Phone { get; set; }

		/// <summary>
		/// Denotes that the postal code has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's postalCode attribute's value.
		/// </summary>
		public string PostalCode { get; set; }

		/// <summary>
		/// Denotes that the recipient has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's addressLine attribute's value.
		/// </summary>
		public string Recipient { get; set; }

		/// <summary>
		/// Denotes that the region has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's region attribute's value.
		/// </summary>
		public string Region { get; set; }

		/// <summary>
		/// Denotes that the region code representation of the region has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's regionCode attribute's value.
		/// </summary>
		public string RegionCode { get; set; }

		/// <summary>
		/// The sorting code has a validation error. In the user agent's UI, this member corresponds to the input field that provided the PaymentAddress's sortingCode attribute's value.
		/// </summary>
		public string SortingCode { get; set; }
	}
}
