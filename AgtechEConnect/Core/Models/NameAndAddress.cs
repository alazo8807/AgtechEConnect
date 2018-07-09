using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgtechEConnect.Core.Models
{
	/// <summary>
	/// Location entity.
	/// </summary>
	[Table("dba.dte_name_and_address_contact_v")]
	public class NameAndAddress
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public NameAndAddress()
		{
		}

		/// <summary>
		/// Id., The Identifier of the Name and Address
		/// </summary>
		/// <value>String representing the name and address identifier </value>
		[Key, Column("name_and_address_id")]
		public string Id { get; set; }

		/// <summary>
		/// Full Name, The full name of the Name and Address
		/// </summary>
		/// <value>String representing the full name </value>
		[Column("full_name")]
		public string FullName { get; set; }

		/// <summary>
		/// Address Line 1, The first line of the address of the Name and Address
		/// </summary>
		/// <value>String representing the first line of the address </value>
		[Column("address_line_1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Address Line 2, The second line of the address of the Name and Address
		/// </summary>
		/// <value>String representing the second line of the address </value>
		[Column("address_line_2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// City, The city of the Name and Address
		/// </summary>
		/// <value>String representing the city </value>
		[Column("city")]
		public string City { get; set; }

		/// <summary>
		/// State/Province, The state or province code of the Name and Address
		/// </summary>
		/// <value>String representing the state or province code of the Name and Address </value>
		[Column("state_province_code")]
		public string StateProvinceCode { get; set; }

		/// <summary>
		/// Country, The country code of the Name and Address
		/// </summary>
		/// <value>String representing the country code </value>
		[Column("country_code")]
		public string CountryCode { get; set; }

		/// <summary>
		/// ZIP/Postal, The ZIP or Postal Code of the Name and Address
		/// </summary>
		/// <value>String representing the zip or postal code </value>
		[Column("zip_postal_code")]
		public string ZipPostalCode { get; set; }

		/// <summary>
		/// Contact Name, Contact Person Name
		/// </summary>
		/// <value>String representing the contact person name </value>
		[Column("contact_name")]
		public string ContactName { get; set; }

		/// <summary>
		/// Phone, contact person phone number
		/// </summary>
		/// <value>String representing the contact person phone number </value>
		[Column("phone_nbr")]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// Ext., Contact Person phone extension number
		/// </summary>
		/// <value>String representing the contact person phone extension number </value>
		[Column("phone_ext")]
		public string PhoneExtension { get; set; }

		/// <summary>
		/// Fax, Contact Person fax number
		/// </summary>
		/// <value>String representing the contact person fax number </value>
		[Column("fax_nbr")]
		public string FaxNumber { get; set; }

		/// <summary>
		/// Toll Free, Contact Person toll-free phone number
		/// </summary>
		/// <value>String representing the contact person toll-free phone number </value>
		[Column("toll_free_phone_nbr")]
		public string TollFreePhoneNumber { get; set; }

		/// <summary>
		/// Mobile/Cell, Contact Person mobile phone number
		/// </summary>
		/// <value>String representing the contact person mobile phone number </value>
		[Column("mobile_phone_nbr")]
		public string MobilePhoneNumber { get; set; }

		/// <summary>
		/// E-mail, Contact Person e-mail address
		/// </summary>
		/// <value>String representing the contact person e-mail address </value>
		[Column("e_mail")]
		public string Email { get; set; }

		/// <summary>
		/// Get/set web address.
		/// </summary>
		[Column("web_address")]
		public string WebAddress { get; set; }
	}
}