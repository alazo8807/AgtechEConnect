using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgtechEConnect.Core.Models
{
	/// <summary>
	/// Contract tr get contracts for transact syncing view repository entity.
	/// </summary>
	[Table("dba.tr_get_contracts_for_transact_syncing_v")]
	public class Contract
	{
		/// <summary>
		/// Contract Internal No."
		/// </summary>
		/// <value>Integer value representing the contract internal (key) no.</value>
		[Key, Column("contract_nbr")]
		public int ContractId { get; set; }

		/// <summary>
		/// Contract number, public
		/// </summary>
		/// <value>Integer value representing the public contract Id </value>
		[Column("contract_no")]
		public int ContractNo { get; set; }

		/// <summary>
		/// Alt. Price, Contract Alternate Price
		/// </summary>
		/// <value>Decimal (nullable) value representing the Contract Alternate Price </value>
		[Column("alt_price")]
		public decimal? AltPrice { get; set; }

		/// <summary>
		/// Price UOM, Contract Price Unit of Measure Code
		/// </summary>
		/// <value>String representing the Contract Price Unit of Measure Code </value>
		[Column("alt_price_uom")]
		public string AltPriceUomCode { get; set; }

		/// <summary>
		/// Alternate ship mode code
		/// </summary>
		/// <value>String representing the Contract Alternate Ship Mode Description</value>
		[Column("alt_ship_mode")]
		public string AlternateShipModeCode { get; set; }

		/// <summary>
		/// area unit nbr.
		/// </summary>
		/// <value>Decimal (nullable) value representing the contract area unit nbr </value>
		[Column("area_unit_nbr")]
		public decimal? AreaUnitNumber { get; set; }

		/// <summary>
		/// Area Unit of Measure Code
		/// </summary>
		/// <value>String representing the contract area unit of measure code </value>
		[Column("area_uom_code")]
		public string AreaUomCode { get; set; }

		/// <summary>
		/// Broker Reference, Broker Reference (Contract)
		/// </summary>
		/// <value>String representing the contract broker reference </value>
		[Column("broker_contract")]
		public string BrokerContract { get; set; }

		/// <summary>
		/// Broker Id., Contract Broker Identification
		/// </summary>
		/// <value>String representing the contract broker identification </value>
		[Column("broker_id")]
		public string BrokerId { get; set; }

		/// <summary>
		/// Commodity Id., Contract Commodity Identifier
		/// </summary>
		/// <value>String representing the Contract Commodity Identifier </value>
		[Column("commodity_id")]
		public string CommodityId { get; set; }

		/// <summary>
		/// Contract Date, Contract Date
		/// </summary>
		/// <value>DateTime (nullable) value representing the contract date </value>
		[Column("contract_date")]
		public DateTime? ContractDate { get; set; }

		/// <summary>
		/// Contract Quantity.
		/// </summary>
		/// <value>Decimal value representing the contract quantity </value>
		[Column("contract_quantity")]
		public decimal ContractQuantity { get; set; }

		/// <summary>
		/// contract type (pricing_type_code)
		/// </summary>
		/// <value>String representing the Contract Type</value>
		[Column("contract_type")]
		public string ContractType { get; set; }

		/// <summary>
		/// contract vendor customer id (s1_contract.vendor_customer_id)
		/// </summary>
		/// <value>String value representing the contract vendor customer id </value> 
		[Column("contract_vendor_customer_id")]
		public string ContractVendorCustomerId { get; set; }

		[ForeignKey("ContractVendorCustomerId")]
		public NameAndAddress ContractVendorCustomer { get; set; }

		/// <summary>
		/// discount schedule code (schedule_code)
		/// </summary>
		/// <value>String representing the discount schedule code </value>
		[Column("discount_schedule_code")]
		public string DiscountScheduleCode { get; set; }

		/// <summary>
		/// freight_term (ft.code)
		/// </summary>
		/// <value>String representing the freight term code </value>
		[Column("freight_term")]
		public string FreightTermCode { get; set; }

		/// <summary>
		/// Grade, Contract Grade
		/// </summary>
		/// <value>String representing the contract grade </value>
		[Column("contract_grade")]
		public string ContractGrade { get; set; }

		/// <summary>
		/// Grade Govern Number, Contract Grade Govern Number
		/// </summary>
		/// <value>String representing the contract grade govern nbr</value>
		[Column("grade_govern_nbr")]
		public string ContractGradeGovernNumber { get; set; }

		/// <summary>
		/// Last Print Date
		/// </summary>
		/// <value>DateTime (nullable) value representing the last print date </value>
		[Column("last_print_date")]
		public DateTime? LastPrintDate { get; set; }

		/// <summary>
		/// load based flag (N)
		/// </summary>
		/// <value>String representing the load based flag</value>
		[Column("load_based_flag")]
		public string LoadBasedFlag { get; set; }

		/// <summary>
		/// Location Id., the contract location Identifier
		/// </summary>
		/// <value>String representing the contract location identifier </value>
		[Column("contract_location")]
		public string LocationId { get; set; }

		/// <summary>
		/// Market Option Month Code  (s1_contract.market_month)
		/// </summary>
		/// <value>String representing the market option month code </value>
		[Column("market_option_month")]
		public string MarketOptionMonth { get; set; }

		///// <summary>
		///// Market Zone Adjustment Flag  
		///// CASE 
		/////     WHEN cad.adjusted_rate = 0.0 THEN 'N' 
		/////     WHEN cad.adjusted_rate is null THEN cast(null as char(1)) 
		/////     ELSE 'Y'
		///// END AS market_zone_adjustment_flag,
		///// </summary>
		///// <value>String representing the market option month code </value>
		//[Column("market_zone_adjustment_flag")]
		//public string MarketZoneAdjustmentFlag { get; set; }

		///// <summary>
		///// market zone code (s1_contract.iv_pricing_point_code)
		///// </summary>
		///// <value>String representing the market zone code </value>
		//[Column("market_zone_code")]
		//public string MarketZoneCode { get; set; }

		///// <summary>
		///// multiple orig dest (s1_contract.spec_org_flag)
		///// </summary>
		///// <value>String representing the multiple orig dest flag </value>
		//[Column("multiple_orig_dest")]
		//public string MultipleOrigDestFlag { get; set; }

		///// <summary>
		///// market zone flag (s1_contract.workback_flag)
		///// </summary>
		///// <value>String representing the multiple orig dest flag </value>
		//[Column("mz_flag")]
		//public string MarketZoneFlag { get; set; }

		///// <summary>
		///// contract notes (s1_contract.remarks)
		///// </summary>
		///// <value>String representing the contract notes </value>
		//[Column("notes")]
		//public string ContractNotes { get; set; }

		/// <summary>
		/// paid by status(s1_contract.broker_paid_by_status)
		/// </summary>
		/// <value>String representing the paid by status</value>
		[Column("paid_by_status")]
		public string PaidByStatus { get; set; }

		/// <summary>
		/// payment terms code(s1_contract.term_code)
		/// </summary>
		/// <value>String representing the payment terms code</value>
		[Column("payment_terms_code")]
		public string PaymentTermsCode { get; set; }

		/// <summary>
		/// pickup_flag (s1_contract.pickup_flag)
		/// </summary>
		/// <value>String representing the pickup flag </value>
		[Column("pickup_flag")]
		public string PickupFlag { get; set; }

		/// <summary>
		/// product_discount_date (CONVERT(varchar,s1_contract.product_disc_prem_date,102)	)
		/// </summary>
		/// <value>DateTime (nullable) value representing the product discount date </value>
		[Column("product_discount_date")]
		public DateTime? ProductDiscountDate { get; set; }

		/// <summary>
		/// product discount date type (s1_contract.product_disc_prem_date_status)
		/// </summary>
		/// <value>String representing the product discount date type </value>
		[Column("product_discount_date_type")]
		public string ProductDiscountDateType { get; set; }

		///// <summary>
		///// product origin destination (s1_contract.od_description)
		///// </summary>
		///// <value>String representing the product origin destination description </value>
		//[Column("product_origin_destination")]
		//public string ProductOriginDestinationDescription { get; set; }

		//      /// <summary>
		//      /// protein_table_nbr (s1_contract.protein_table_nbr)
		//      /// </summary>
		//      /// <value>Integer (nullable) representing the protein table nbr </value>
		//      [Column("protein_table_nbr")]
		//      public int? ProteinTableNumber { get; set; }

		//      /// <summary>
		//      /// Purchase Sale Other Code 
		//      /// CASE s1_contract.contract_type 
		//      ///     WHEN 'P/C' 
		/////			THEN 'S' 
		/////			ELSE 'P' 
		///// END AS pso
		//      /// </summary>
		//      /// <value>String representing the protein table nbr </value>
		//      [Column("purchase_sale_other")]
		//      public string PurchaseSaleOtherCode { get; set; }

		/// <summary>
		/// Quantity UOM Code, Contract Quantity UOM Code
		/// </summary>
		/// <value>String value representing the contract quantity uom code</value>
		[Column("contract_quantity_uom")]
		public string ContractQtyUomCode { get; set; }

		/// <summary>
		/// ship_end_date (s1_contract.sched_ship_end_date)
		/// </summary>
		/// <value>DateTime value representing the ship end date </value>
		[Column("ship_end_date")]
		public DateTime ShipEndDate { get; set; }

		/// <summary>
		/// ship_start_date (s1_contract.sched_ship_start_date)
		/// </summary>
		/// <value>DateTime value representing the ship start date </value>
		[Column("ship_start_date")]
		public DateTime ShipStartDate { get; set; }

		/// <summary>
		/// Shp Mode Code (s1_contract.ship_mode_code)
		/// </summary>
		/// <value>String value representing the ship mode code </value>
		[Column("ship_mode_code")]
		public string ShipModeCode { get; set; }

		///// <summary>
		///// Shipment Note (s1_contract.shipment_note)
		///// </summary>
		///// <value>String value representing the shipment_note </value>
		//[Column("shipment_note")]
		//public string ShipmentNote { get; set; }

		///// <summary>
		///// Signed Flag (s1_contract.signed_flag,)
		///// </summary>
		///// <value>String value representing the signed flag </value>
		//[Column("signed_flag")]
		//public string SignedFlag { get; set; }

		/// <summary>
		/// Storage (s1_contract.storage,)
		/// </summary>
		/// <value>String value representing the storage </value>
		[Column("storage")]
		public string Storage { get; set; }

		///// <summary>
		///// tax schedule description (tx.description)
		///// </summary>
		///// <value>String value representing the tax schedule description </value>
		//[Column("tax_schedule_description")]
		//public string TaxScheduleDescription { get; set; }

		///// <summary>
		///// title passes city (s1_contract.city)
		///// </summary>
		///// <value>String value representing the title passes city </value>
		//[Column("title_passes_city")]
		//public string TitlePassesCity { get; set; }

		///// <summary>
		///// title passes state (s1_contract.state_province_code)
		///// </summary>
		///// <value>String value representing the title passes state </value>
		//[Column("title_passes_state")]
		//public string TitlePassesState { get; set; }

		///// <summary>
		///// trader name (t.name)
		///// </summary>
		///// <value>String value representing the trader name </value> 
		//[Column("trader_name")]
		//public string TraderName { get; set; }

		///// <summary>
		///// cad uom code (cad.uom_code)
		///// </summary>
		///// <value>String value representing the cad uom code </value> 
		//[Column("cad_uom_code")]
		//public string CadUomCode { get; set; }

		///// <summary>
		///// vehicle type 
		///// CASE cad.rate_type 
		/////     WHEN ''V'' 
		/////			THEN v.description
		/////           ELSE CAST(null AS char(50)) 
		///// END AS vehicle type,
		///// </summary>
		///// <value>String value representing the vehicle type </value> 
		//[Column("vehicle_type")]
		//public string vehicle_type { get; set; }

		/// <summary>
		/// vendor customer id (plc.alternate_id)
		/// </summary>
		/// <value>String value representing the vendor customer id </value> 
		[Column("vendor_customer_id")]
		public string VendorCustomerId { get; set; }

		///// <summary>
		///// vendor id (cad.vendor_id)
		///// </summary>
		///// <value>String value representing the vendor id </value> 
		//[Column("vendor_id")]
		//public string VendorId { get; set; }

		/// <summary>
		/// weight govern nbr (s1_contract.weight_govern_nbr)
		/// </summary>
		/// <value>String value representing the weight govern nbr </value> 
		[Column("weight_govern_nbr")]
		public string WeightGovernNumber { get; set; }
	}
}
