

DROP VIEW tr_get_contracts_for_transact_syncing_v

-- get contracts for Transact syncing
DECLARE @SQLCommand NVARCHAR(max)
-- sp_help tr_get_contracts_for_transact_syncing_v
-- USAGE: SELECT * FROM tr_get_contracts_for_transact_syncing_v ORDER BY contract_nbr

SET @SQLCommand = '
	CREATE VIEW tr_get_contracts_for_transact_syncing_v
	 AS
		SELECT 
				s1_contract.contract_nbr,			
				s1_contract.contract_id							AS contract_no, 

				s1_contract.alt_price							AS alt_price,						
				s1_contract.alt_price_uom						AS alt_price_uom,
				s1_contract.alternate_ship_mode_code			AS alt_ship_mode,	
				s1_contract.area_unit_nbr						AS area_unit_nbr,
				s1_contract.area_uom_code						AS area_uom_code,

				s1_contract.broker_contract						AS broker_contract,
				s1_contract.broker_id							AS broker_id,
				s1_contract.broker_paid_by_status				AS paid_by_status,
		
				s1_contract.commodity_id						AS commodity_id,
				s1_contract.currency_code						AS contract_currency_code,
				s1_contract.contract_date						AS contract_date,
				s1_contract.grade								AS contract_grade,	
				s1_contract.plc_id								AS contract_location,
				s1_contract.quantity							AS contract_quantity,
				s1_contract.quantity_uom						AS contract_quantity_uom,						
				s1_contract.contract_type						AS contract_type,
				s1_contract.vendor_customer_id					AS contract_vendor_customer_id,
				s1_contract.schedule_code						AS discount_schedule_code,
				ft.code											AS freight_term,

				s1_contract.grade_govern_nbr					AS grade_govern_nbr,						
				s1_contract.last_print_date						AS last_print_date,					
				s1_contract.load_based_flag						AS load_based_flag,						
				s1_contract.market_month						AS market_option_month,
				s1_contract.number_of_loads						AS number_of_loads,	
				s1_contract.term_code							AS payment_terms_code,
				s1_contract.pickup_flag							AS pickup_flag,						

				s1_contract.pricing_type_code					AS pricing_type_code,
				s1_contract.product_disc_prem_date				AS product_discount_date,
				s1_contract.product_disc_prem_date_status		AS product_discount_date_type,
				s1_contract.sched_ship_end_date					AS ship_end_date,
				s1_contract.sched_ship_start_date				AS ship_start_date,
				s1_contract.ship_mode_code						AS ship_mode_code,	
				s1_contract.storage								AS storage,

				plc.alternate_id								AS vendor_customer_id,
				s1_contract.weight_govern_nbr					AS weight_govern_nbr
									


		
				--cad.accrual_nbr, 

				--cad.accrual_flag,						
				--s1_contract.additional_contract_desc			AS additional_contract_desc,
				--REPLACE(CAST(s1_contract.additional_note AS varchar(4000)),char(13) + char(10),''<BR>'') 
				--												AS additional_note,
				--s1_contract.alt_basis_price,						
				--s1_contract.alt_futures_price,						
					
				
				--CASE cad.accrual_flag 
				--	WHEN ''Y'' 
				--	THEN cad.accrual_amount 
				--	ELSE 
				--		CASE cad.budget_flag WHEN ''Y'' 
				--		THEN cad.budget_amount 
				--		ELSE cad.standard_rate
				--	END 
				--END												AS amount,
				--s1_contract.broker_contract						AS broker_contract,
				--br.alternate_vendor_id							AS alt_broker_id,	-- The actual join to the br table is from s1_contract.broker_id
				--brc.name										AS broker_name,		-- The actual join to the brc table is from s1_contract.broker_id and s1_contract.broker_contact_id
				--cad.budget_flag									AS contract_accrual_budget_flag,						
				--cad.calculate_on_type,						
				--s1_contract.commodity_note_code					AS commodity_note_code,
				--s1_contract.confirm_pricing_flag,						
				--cad.currency_code								AS contract_accrual_currency_code,



				--s1_contract.contract_format_code,
				--pcd.auto_increment_flag,						
				--CASE pcd.auto_increment_flag 
				--	WHEN ''N'' 
				--	THEN s1_contract.contract_id 
				--	ELSE null 
				--END												AS contract_no,
				--s1_contract.contract_reference,						
				--s1_contract.contract_schedule					AS contract_schedule,
				--cad.cost_category_code,						
				--s1_contract.cross_application_flag				AS cross_apply,
				--s1_contract.hold_flag							AS defer_pay_flag,
				--s1_contract.delivery_point_id					AS delivery_point_id,
				----convert(varchar,s1_contract.dp_from_date,102)AS dp_from_date,
				--s1_contract.dp_from_date						AS dp_from_date,
				----convert(varchar,s1_contract.dp_to_date,102)AS dp_to_date,
				--s1_contract.dp_to_date							AS dp_to_date,

				--CASE 						
				--	WHEN s1_contract.contract_status IN (''D'',''S'')						
				--	THEN ''Y''						
				--	ELSE ''N''						
				--END												AS dpr,
				--s1_contract.farm_gate_deduction					AS farm_gate_deduction,
				--s1_contract.fob_point,						
				--CAST(null AS decimal(10,5))						AS fx_futures,
				--''N''											AS load_based_flag,
				--CASE s1_contract.contract_type 
				--	WHEN ''P/C'' 
				--	THEN vd.alternate_ticket_vendor_id 
				--	ELSE cd.alternate_customer_id 
				--END												AS location,
				--CASE 
				--	WHEN cad.adjusted_rate = 0.0 THEN ''N'' 
				--	WHEN cad.adjusted_rate is null THEN cast(null as char(1)) 
				--	ELSE ''Y'' 
				--END												AS market_zone_adjustment_flag,
				--s1_contract.iv_pricing_point_code				AS market_zone_code,

				--s1_contract.mf_01 miscellaneousfield1,
				--s1_contract.mf_02 miscellaneousfield2,
				--s1_contract.mf_03 miscellaneousfield3,
				--s1_contract.mf_04 miscellaneousfield4,
				--s1_contract.mf_05 miscellaneousfield5,
				--s1_contract.mf_06 miscellaneousfield6,
				--s1_contract.mf_07 miscellaneousfield7,
				--s1_contract.mf_08 miscellaneousfield8,
				--s1_contract.mf_09 miscellaneousfield9,
				--s1_contract.mf_10 miscellaneousfield10,
				--s1_contract.mf_11 miscellaneousfield11,
				--s1_contract.mf_12 miscellaneousfield12,
				--s1_contract.mf_13 miscellaneousfield13,
				--s1_contract.mf_14 miscellaneousfield14,
				--s1_contract.mf_15 miscellaneousfield15,
				--s1_contract.mf_16 miscellaneousfield16,
				--s1_contract.mf_17 miscellaneousfield17,
				--s1_contract.mf_18 miscellaneousfield18,
				--s1_contract.mf_19 miscellaneousfield19,
				--s1_contract.mf_20 miscellaneousfield20,
				--s1_contract.mf_21 miscellaneousfield21,
				--s1_contract.mf_22 miscellaneousfield22,
				--s1_contract.mf_23 miscellaneousfield23,
				--s1_contract.mf_24 miscellaneousfield24,

				--s1_contract.spec_org_flag						AS multiple_orig_dest,
				--s1_contract.workback_flag						AS mz_flag,
				--s1_contract.remarks								AS notes,
				----  cast(null as dec(1,0))						AS number_of_loads,
								----CONVERT(varchar,s1_contract.product_disc_prem_date,102)	
				----												AS product_discount_date,

				--s1_contract.od_description						AS product_origin_destination,
				--s1_contract.protein_table_nbr					AS protein_table_nbr,
				--CASE s1_contract.contract_type 
				--	WHEN ''P/C'' 
				--	THEN ''S'' 
				--	ELSE ''P'' 
				--END 											AS purchase_sale_other,
				--cad.rate_type									AS cad_rate_type,						
				--s1_contract.settlement_relationship				AS settlement_split_relationship,


				--s1_contract.shipment_note,						
				--s1_contract.signed_flag,						
				--tx.description									AS tax_schedule_description,
				--s1_contract.city								AS title_passes_city,
				--s1_contract.state_province_code					AS title_passes_state,
				--t.name											AS trader_name,
				--cad.uom_code									AS cad_uom_code,						
				---- cast(null as char(10)) vehicle_type,			AS vehicle_type,
				--CASE cad.rate_type 
				--	WHEN ''V'' 
				--	THEN v.description 
				--	ELSE CAST(null AS char(50)) 
				--END												AS vehicle_type,

				--cad.vendor_id,						
				


                FROM 
					s1_contract 
					JOIN s1_name_and_address plc 
						ON s1_contract.plc_id = plc.name_and_address_id
                    LEFT OUTER JOIN s1_freight_term ft 
						ON s1_contract.freight_term_serial_nbr = ft.serial_nbr

      --              JOIN s1_plc_contract_disposition pcd 
						--ON s1_contract.plc_id = pcd.plc_id 
						--AND s1_contract.contract_type = pcd.disposition_type_code 
						--AND s1_contract.pricing_type_code = pcd.contract_type_code
      --              LEFT OUTER JOIN s1_vendor_data vd 
						--ON s1_contract.vendor_customer_id = vd.vendor_id
      --              LEFT OUTER JOIN s1_customer_data cd 
						--ON s1_contract.vendor_customer_id = cd.customer_id
      --              JOIN s1_trader t 
						--ON s1_contract.trader_id = t.trader_id
      --              LEFT OUTER JOIN s1_vendor_data br 
						--ON s1_contract.broker_id = br.vendor_id
      --              LEFT OUTER JOIN s1_contact_person brc
						--ON s1_contract.broker_id = brc.name_and_address_id 
						--AND s1_contract.broker_contact_id = brc.contact_person_id
      --              LEFT OUTER JOIN s1_tax_schedule tx 
						--ON s1_contract.tax_schedule_id = tx.schedule_id
      --              LEFT OUTER JOIN s1_contract_accrual_default cad 
						--ON s1_contract.contract_nbr = cad.contract_nbr
      --              LEFT OUTER JOIN s1_commodity_vehicle cv 
						--ON cad.commodity_id = cv.commodity_id 
						--AND cad.commodity_vehicle_code = cv.commodity_vehicle_code
      --              LEFT OUTER JOIN s1_vehicle v 
						--ON cv.vehicle_code = v.vehicle_code
				WHERE 
					s1_contract.contract_type		<> ''OTH'' AND
					s1_contract.pricing_type_code	<> ''HLD'' AND
					s1_contract.contract_id			> 0 AND
					s1_contract.load_based_flag		= ''N'' AND
					s1_contract.new_load_based_flag = ''N'' AND
					s1_contract.contract_status not in (''X'',''C'') AND
					s1_contract.printed_flag		= ''Y''

			-- CREATE VIEW END '

Execute sp_executesql @SQLCommand



