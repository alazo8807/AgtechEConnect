
IF EXISTS (SELECT * 
             FROM sysobjects
            WHERE name = 'dte_name_and_address_contact_v'
              AND xtype = 'V'
           )
    DROP VIEW dte_name_and_address_contact_v
GO

CREATE VIEW dte_name_and_address_contact_v
AS
	SELECT 
		naa.name_and_address_id,
		naa.short_name,
		naa.full_name,
		naa.address_line_1,
		naa.address_line_2,
		naa.city,
		naa.state_province_code,
		naa.zip_postal_code,
		naa.country_code,
		naa.phone_format_flag,
		cp.contact_person_id,
		cp.name						AS contact_name,
		cp.phone_nbr,
		cp.phone_ext,
		cp.toll_free_phone_nbr,
		cp.mobile_phone_nbr,
		cp.fax_nbr,
		cp.e_mail,
		cp.web_address

	FROM
		s1_name_and_address		AS naa
		JOIN s1_contact_person	AS cp
			ON cp.name_and_address_id = naa.name_and_address_id 
			AND cp.contact_person_id = 1 
			AND cp.inactive_flag <> 'Y'
GO


