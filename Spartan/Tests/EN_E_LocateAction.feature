Feature: EN_E_LocateAction
	Ensure EN_E_LocateAction functionality covered

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
Scenario: View Holder Extra Details
	# Enquiry System -Action LHE /FE /BE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value     |
			| Action          | LHE       |
			| Locate Argument | 100200300 |
	Then In ENS01020 I should see holder extra details as below:
			| Field           | Value                                   |
			| Name Key        | CABCOEYH    YDIKUB                      |
			| HIN             | I0100007525                             |
			| Holder Type     | EMP                                     |
			| Extra Holder ID | 100200300                               |
			| Name            | YDIKUB CABCOEYH,                        |
			| Address1        | 3 UWBCUJAEM COURT                       |
			| Address2        | RABC KIMV VIC                           |
			| Address3        |                                         |
			| Address4        |                                         |
			| Address5        |                                         |
			| Home Tell       | 038100100                               |
			| Work Tell       | 035100100                               |
			| Fax             |                                         |
			| Mobile          | 0433100100                              |
			| Email           | YDIKUB.KEJKUIGP._test@computershare.com |
			| Return Email    |                                         |
			| Email Count     | 0                                       |
			| ABN1            |                                         |
			| ABN2            |                                         |
			| Type1           |                                         |
			| Type2           |                                         |
			| Flag1           |                                         |
			| Flag1 Desc      |                                         |
			| Flag2           |                                         |
			| Flag2 Desc      |                                         |
			| Flag3           |                                         |
			| Flag3 Desc      |                                         |
			| Flag4           |                                         |
			| Flag4 Desc      |                                         |
			| Flag5           | E4                                      |
			| Flag5 Desc      | AML CPM Multi Participant               |
			| Flag6           |                                         |
			| Flag6 Desc      |                                         |
			| Flag7           |                                         |
			| Flag7 Desc      |                                         |
			| Flag8           |                                         |
			| Flag8 Desc      |                                         |
			| Flag9           |                                         |
			| Flag9 Desc      |                                         |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | FE    |
			| Locate Argument |       |
	Then In ENS01020 I should see holder extra details as below:
			| Field           | Value                                    |
			| Name Key        | CDOGHIALAN  CDIGO                        |
			| HIN             | I0100007495                              |
			| Holder Type     | EMP                                      |
			| Extra Holder ID | 100200301                                |
			| Name            | MR CDIGO CDOGHIALAN                      |
			| Address1        | 98 CIEGHJAL STREET                       |
			| Address2        | CDOGHJALM SOUTH VIC                      |
			| Address3        |                                          |
			| Address4        |                                          |
			| Address5        |                                          |
			| Home Tell       | 038200200                                |
			| Work Tell       | 038201201                                |
			| Fax             |                                          |
			| Mobile          | 0433200200                               |
			| Email           | CDIGO.JKOMNIARAT._test@computershare.com |
			| Return Email    |                                          |
			| Email Count     | 0                                        |
			| ABN1            |                                          |
			| ABN2            |                                          |
			| Type1           |                                          |
			| Type2           |                                          |
			| Flag1           |                                          |
			| Flag1 Desc      |                                          |
			| Flag2           |                                          |
			| Flag2 Desc      |                                          |
			| Flag3           |                                          |
			| Flag3 Desc      |                                          |
			| Flag4           |                                          |
			| Flag4 Desc      |                                          |
			| Flag5           | E4                                       |
			| Flag5 Desc      | AML CPM Multi Participant                |
			| Flag6           |                                          |
			| Flag6 Desc      |                                          |
			| Flag7           |                                          |
			| Flag7 Desc      |                                          |
			| Flag8           |                                          |
			| Flag8 Desc      |                                          |
			| Flag9           |                                          |
			| Flag9 Desc      |                                          |
		When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BE    |
			| Locate Argument |       |	
	Then In ENS01020 I should see holder extra details as below:
			| Field           | Value                                   |
			| Name Key        | CABCOEYH    YDIKUB                      |
			| HIN             | I0100007525                             |
			| Holder Type     | EMP                                     |
			| Extra Holder ID | 100200300                               |
			| Name            | YDIKUB CABCOEYH,                        |
			| Address1        | 3 UWBCUJAEM COURT                       |
			| Address2        | RABC KIMV VIC                           |
			| Address3        |                                         |
			| Address4        |                                         |
			| Address5        |                                         |
			| Home Tell       | 038100100                               |
			| Work Tell       | 035100100                               |
			| Fax             |                                         |
			| Mobile          | 0433100100                              |
			| Email           | YDIKUB.KEJKUIGP._test@computershare.com |
			| Return Email    |                                         |
			| Email Count     | 0                                       |
			| ABN1            |                                         |
			| ABN2            |                                         |
			| Type1           |                                         |
			| Type2           |                                         |
			| Flag1           |                                         |
			| Flag1 Desc      |                                         |
			| Flag2           |                                         |
			| Flag2 Desc      |                                         |
			| Flag3           |                                         |
			| Flag3 Desc      |                                         |
			| Flag4           |                                         |
			| Flag4 Desc      |                                         |
			| Flag5           | E4                                      |
			| Flag5 Desc      | AML CPM Multi Participant               |
			| Flag6           |                                         |
			| Flag6 Desc      |                                         |
			| Flag7           |                                         |
			| Flag7 Desc      |                                         |
			| Flag8           |                                         |
			| Flag8 Desc      |                                         |
			| Flag9           |                                         |
			| Flag9 Desc      |                                         |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
@FullSmokeTest
Scenario: View Holder Markings-LC
	# Enquiry System -Action LC /LCC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value      |
			| Action          | LC         |
			| Locate Argument | 20020603EM |
	Then In ENS01040 I should see Duplicate Certificate details as below:
			| Field                | Value                                                                     |
			| Selected Certificate | 20020603EM                                                                |
			| Certificate Line1    | 20020603EM   DEP 02A I0010003610              0 0 CPUNEFOH    RIMUE       |
			| Certificate Line2    | 20020603EM   DEP 02A I0010013861              0 0 YICXFI      ZIUBAIVIBUA |
	When I enter the following details as the Locate action:
         | Field           | Value                          |
         | Action          | LCC                            |
         | Locate Argument | 20020603EM/DEP/02A/I0100007525 |
	Then In ENS01012 I should see Certificate details as below:
			| Field       | Value                                                                               |
			| HIN         | I0100007525                                                                         |
			| Page1 Line1 | DEP/DEFERRED EMP SHARE PLAN - AU                                                    |
			| Page1 Line2 | 02A 20020603EM   04/06/02             0    02A 20020604EP   04/06/02              0 |
			| Page1 Line3 | 02A 20020704EP   04/07/02             0    02A 20020805EP   05/08/02              0 |
			| Page2 Line1 | DEP/DEFERRED EMP SHARE PLAN - AU   Cont'd                                           |
			| Page2 Line2 | 08A 20090512EP   12/05/09             0    08A 20090612EP   12/06/09              0 |
			| Page2 Line3 | 09A 20090828EM   28/08/09             0    09A 20090914EP   14/09/09              0 |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
Scenario: View Holder Markings-LE
	# Enquiry System -Action LE /LEC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value      |
			| Action          | LE         |
			| Locate Argument | 20020603EM/DEP/02A/I0100007525 |
	Then In ENS01042 I should see Certificate Details as Cert1 "02A 20020603EM   04/06/02             0 | 07/07/04 ESTRS 1785/10764477           749-"  and Cert2 "02A 20020604EP   04/06/02             0 | 07/07/04 ESTRS 1785/10764477            63-"
	When I enter the following details as the Locate action:
			| Field           | Value      |
			| Action          | LEC         |
			| Locate Argument | 20020603EM/DEP/02A/I0100007525 |
	Then In ENS01042 I should see Certificate Details as Cert1 "02A 20020603EM   04/06/02             0 | 07/07/04 ESTRS 1785/10764477           749-"  and Cert2 "02A 20020604EP   04/06/02             0 | 07/07/04 ESTRS 1785/10764477            63-"

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
Scenario: View Domicile Code
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | LD    |
			| Locate Argument | GBP   |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                          |
			| HIN                 | I0030259823                    |
			| Type                | IND                            |
			| Post Code           | GBR                            |
			| TAX Code            |                                |
			| TFN Desc            | Non-Res                        |
			| ABN Desc            | Non-Res                        |
			| Group               |                                |
			| Var field           |                                |
			| Broker Code         | 60109                          |
			| Register            |                                |
			| Key Modifier        |                                |
			| DPID                |                                |
			| Alternate ID        |                                |
			| Key                 | APMO        KIFOP VITOD        |
			| Name                | MR KIFOP VITOD APMO,           |
			| Address1            | 25 YLICHBEL CLOSE              |
			| Address2            | YAMNUUY KIXGD YE471BI          |
			| Address3            | AWEGUJ RAXCHUY                 |
			| Address4            |                                |
			| Address5            |                                |
			| Deceased            | N                              |
			| Exception           |                                |
			| Suppress            | N                              |
			| Ret Mail            |                                |
			| A/Report            | R                              |
			| AR Nominated Text   | (Default)                      |
			| Birth Date          |                                |
			| Stop Trade          | N                              |
			| Div Source          | D                              |
			| Residency           |                                |
			| Var Flag1           |                                |
			| Var Flag2           |                                |
			| Var Flag3           |                                |
			| Var Flag4           |                                |
			| Var Flag5           |                                |
			| Warning1            | Overseas domicile              |
			| Warning2            | Payee instruction direct/bulk  |
			| Warning3            | Nil holding on trading classes |
			| Warning4            | Holder Extra details present   |
			| Warning5            | ESS Participant                |
			| Warning6            | Shareholder Review             |
			| Restrict Class info | * NOTICE 03/03/2014 *          |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | LD    |
			| Locate Argument | USA   |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                         |
			| HIN                 | I0030277988                   |
			| Type                | IND                           |
			| Post Code           | USA                           |
			| TAX Code            |                               |
			| TFN Desc            | Non-Res                       |
			| ABN Desc            | Non-Res                       |
			| Group               |                               |
			| Var field           |                               |
			| Broker Code         | 60109                         |
			| Register            |                               |
			| Key Modifier        |                               |
			| DPID                |                               |
			| Alternate ID        |                               |
			| Key                 | AESS        TEST  AUTOMAEVENT |
			| Name                | MR TEST AUTOMATION EVENT AESS |
			| Address1            | 12 GWOZQETZ ROAD              |
			| Address2            | ENNUBE NORTH VIC              |
			| Address3            |                               |
			| Address4            |                               |
			| Address5            |                               |
			| Deceased            | N                             |
			| Exception           |                               |
			| Suppress            | N                             |
			| Ret Mail            |                               |
			| A/Report            | R                             |
			| AR Nominated Text   | (Default)                     |
			| Birth Date          |                               |
			| Stop Trade          | N                             |
			| Div Source          | D                             |
			| Residency           |                               |
			| Var Flag1           |                               |
			| Var Flag2           |                               |
			| Var Flag3           |                               |
			| Var Flag4           |                               |
			| Var Flag5           |                               |
			| Warning1            | Overseas domicile             |
			| Warning2            | Payee instruction direct/bulk |
			| Warning3            | Holder Extra details present  |
			| Warning4            | ESS Participant               |
			| Warning5            | Shareholder Review            |
			| Warning6            |                               |
			| Restrict Class info | * NOTICE 03/03/2014 *         |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
Scenario: View Register Details -LR
	# Enquiry System -Action LR /LRC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value                          |
			| Action          | LR                             |
			| Locate Argument | 20020603EM/DEP/02A/I0100007550 |
	Then In ENS01013 I should see Register details as below:
			| Field | Value                                                                    |
			| HIN   | I0100007550                                                              |
			| Line1 | DEP/DEFERRED EMP SHARE PLAN - AU                                         |
			| Line2 | 02A 20020603EM   03/06/02 ESAWB 1338/10457471           1498             |
			| Line3 | 04/07/13 ESTTS 4218/  964437           1498-                      SCANAL |
			| Line4 | *Certificate Balance             0                                       |
			| Line5 | 02A 20020604EP   04/06/02 ESAWP 1341/10456518            210             |
			| Line6 | 04/07/13 ESTTS 4218/  964437            210-                      SCANAL |
	When I enter the following details as the Locate action:
			| Field           | Value                          |
			| Action          | LRC                            |
			| Locate Argument | 20020603EM/DEP/02A/I0100007550 |
	Then In ENS01013 I should see Register details as below:
			| Field         | Value                                                                                    |
			| HIN   | I0100007550                                                              |
			| Line1 | DEP/DEFERRED EMP SHARE PLAN - AU                                         |
			| Line2 | 02A 20020603EM   03/06/02 ESAWB 1338/10457471           1498             |
			| Line3 | 04/07/13 ESTTS 4218/  964437           1498-                      SCANAL |
			| Line4 | *Certificate Balance             0                                       |
			| Line5 | 02A 20020604EP   04/06/02 ESAWP 1341/10456518            210             |
			| Line6 | 04/07/13 ESTTS 4218/  964437            210-                      SCANAL |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
Scenario: View Transactions Online -LT
	# Enquiry System -Action LT/LS
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value         |
			| Action          | LT            |
			| Locate Argument | 4395/12606657 |
	Then In ENS01014 I should see Balance Transaction as below:
				| Field     | Value                                        |
				| Run       | 4395                                         |
				| Tran No   | 12606657                                     |
				| Tran Code | ESLAU                                        |
				| Tran Desc | LAPSE - AUTO - UNVEST                        |
				| HIN       | I0030213831                                  |
				| Line1     | DLA/09A 20091112EE           200000 28/02/15 |
				| Line2     | *        200000                              |
	When I enter the following details as the Locate action:
			| Field           | Value      |
			| Action          | LS         |
			| Locate Argument | 1253/84631 |
	Then In ENSSTM34 I should see Static Transaction details as below:
				| Field                  | Value                         |
				| Name Key               | RIXYE       KIXP        20000 |
				| HIN                    | I0100007550                   |
				| Holder Type            | EMP                           |
				| Name                   | MR KIXP RIXYE                 |
				| Address1               | 1 GIXRABISM DRIVE             |
				| Address2               | 2 GIXRABISM DRIVE             |
				| Address3               | 3 GIXRABISM DRIVE             |
				| Address4               | 4 GIXRABISM DRIVE             |
				| Address5               | GIOYPMIO VIC                  |
				| Date first Shareholder | 11/02/2000                    |
				| Date First             | 13/02/2001                    |
				| Run                    | 1253                          |
				| Tran No                | 84631                         |
				| Tran Date              | 15/01/2002                    |
				| Tran Code              | NAFLG                         |
				| Tran Desc              | NAME & ADDRESS (FLAG CHANGE)  |
				| Reference              |                               |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
@16960
@FullSmokeTest
Scenario: Test Case 16960: 06_Compare F6,F17,B6.B17
	# Enquiry System -Action F/B/Fx/Bx
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                          |
			| HIN                 | X0012160437                    |
			| Type                | COY                            |
			| Post Code           | 3150                           |
			| TAX Code            |                                |
			| TFN Desc            | TFN quoted                     |
			| ABN Desc            | Not quoted                     |
			| Group               |                                |
			| Var field           |                                |
			| Broker Code         | 1402                           |
			| Register            |                                |
			| Key Modifier        |                                |
			| DPID                | 87234156                       |
			| Alternate ID        |                                |
			| Key                 | A           DAJXUWORWILMNOGIJP |
			| Name                | A DAJXUW ORWILMNOGIJ PTY LTD,  |
			| Address1            | UNIT 9                         |
			| Address2            | 383 WIYZECNAQH ROAD            |
			| Address3            | WXAT CICILCUM VIC              |
			| Address4            |                                |
			| Address5            |                                |
			| Deceased            | N                              |
			| Exception           |                                |
			| Suppress            | N                              |
			| Ret Mail            |                                |
			| A/Report            | N                              |
			| AR Nominated Text   | (Nominated)                    |
			| Birth Date          |                                |
			| Stop Trade          | N                              |
			| Div Source          | D                              |
			| Residency           |                                |
			| Var Flag1           |                                |
			| Var Flag2           |                                |
			| Var Flag3           |                                |
			| Var Flag4           |                                |
			| Var Flag5           |                                |
			| Warning1            | Payee instruction direct/bulk  |
			| Warning2            | Nil holding on trading classes |
			| Warning3            | No Annual Report               |
			| Warning4            |                                |
			| Warning5            |                                |
			| Warning6            |                                |
			| Restrict Class info | * NOTICE 03/03/2014 *          |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | B     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                          |
			| HIN                 | X0012160437                    |
			| Type                | COY                            |
			| Post Code           | 3150                           |
			| TAX Code            |                                |
			| TFN Desc            | TFN quoted                     |
			| ABN Desc            | Not quoted                     |
			| Group               |                                |
			| Var field           |                                |
			| Broker Code         | 1402                           |
			| Register            |                                |
			| Key Modifier        |                                |
			| DPID                | 87234156                       |
			| Alternate ID        |                                |
			| Key                 | A           DAJXUWORWILMNOGIJP |
			| Name                | A DAJXUW ORWILMNOGIJ PTY LTD,  |
			| Address1            | UNIT 9                         |
			| Address2            | 383 WIYZECNAQH ROAD            |
			| Address3            | WXAT CICILCUM VIC              |
			| Address4            |                                |
			| Address5            |                                |
			| Deceased            | N                              |
			| Exception           |                                |
			| Suppress            | N                              |
			| Ret Mail            |                                |
			| A/Report            | N                              |
			| AR Nominated Text   | (Nominated)                    |
			| Birth Date          |                                |
			| Stop Trade          | N                              |
			| Div Source          | D                              |
			| Residency           |                                |
			| Var Flag1           |                                |
			| Var Flag2           |                                |
			| Var Flag3           |                                |
			| Var Flag4           |                                |
			| Var Flag5           |                                |
			| Warning1            | Payee instruction direct/bulk  |
			| Warning2            | Nil holding on trading classes |
			| Warning3            | No Annual Report               |
			| Warning4            |                                |
			| Warning5            |                                |
			| Warning6            |                                |
			| Restrict Class info | * NOTICE 03/03/2014 *          |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F6    |
			| Locate Argument |       |
	Then In ENS01033 I should see Six Holder names and Address as below:
			| Field         | Value                          |
			| HIN           | I9999999139                    |
			| Address Line1 | GLOBAL PAYMENTS CONTROL A/C,   |
			| Address Line2 | C/- COMPUTERSHARE LIMITED      |
			| Address Line3 | PO BOX 103 ABBOTSFORD VIC 3067 |
			| Address Line4 |                                |
			| Postcode      | 3000                           |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | B6    |
			| Locate Argument |       |
	Then In ENS01033 I should see Six Holder names and Address as below:
			| Field         | Value                         |
			| HIN           | X0012160437                   |
			| Address Line1 | A DAJXUW ORWILMNOGIJ PTY LTD, |
			| Address Line2 | UNIT 9                        |
			| Address Line3 | 383 WIYZECNAQH ROAD           |
			| Address Line4 | WXAT CICILCUM VIC             |
			| Postcode      | 3150                          |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@16955
Scenario Outline: Test Case 16955: 01_S action for holder Id
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder "<Type>" Holder Type as below
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<HolderID>" as below
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | B     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<HIN>" as below

Examples: 

		| HIN         | Type | HolderID    |
		| X0054356552 | COY  | X0054364873 |
		| C9999999164 | CNT  | I0030013930 |
		| I0035493034 | IND  | I0035499024 |
		| I0034882762 | JNT  | I0034926514 |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@16956
Scenario Outline: Test Case 16956: 02_Compare S action for holder Name
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01001 I should see Holder ID "<HIN>" as below
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<HolderID>" as below
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | B     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<HIN>" as below

Examples: 
		| HIN         | Action | LocateArgument                     | HolderID    |
		| X0031648505 | S      | US DIRECT CREDIT CONTROL A/C       | I0036136464 |
		| I0031170001 | S      | John                               | I0034597324 |
		| X0054356552 | S      | A&G                                | C9999999164 |
		| X0050420248 | S      | MR JOHN ANTHONY ADAMS +MRS GILLIAN | I0035990682 |
		| X0008697868 | S      | MR LESLIE GEORGE AFFORD +          | X0043167731 |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@16958
Scenario Outline: Test Case 16958: 04_Compare Forward/Backward actions on different screens-H
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<HIN>" as below
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | B     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<LocateArgument>" as below

Examples: 
		| HIN         | Action | LocateArgument | Line1                                                                   | Line2                                                                   | Line3                                                                   | Line4                                                                   |
		| I0035337890 | H      | X0040122044    | CEN/ENTITLEMENT CPS II 2013 VIC   99999999999               99999999999 | E11/NAB CAPITAL NOTES S/H O VIC   99999999999               99999999999 | HAI/CUM NATIONAL INCOME SEC VIC           156                       156 | NIS/NATIONAL INCOME SECURIT VIC           156                       156 |
		| X0058111708 | H      | I0970061592    | CEN/ENTITLEMENT CPS II 2013 VIC   99999999999               99999999999 | E11/NAB CAPITAL NOTES S/H O VIC   99999999999               99999999999 | E4 /ISX ENTITLEMENT CLASS   VIC            50                        50 | EVA/EVA SHARE OFFER         02A             0                         0 |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@16958
Scenario Outline: Test Case 16958: 04_Compare Forward/Backward actions on different screens-DH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIV01 I should see Dividend History as below "<PayDate>" "<PayMethod>" "<Code>" "<PayAccount>" "<PayType>" "<GrossAmount>" "<NettAmount>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<HIN>" as below
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | B     |
			| Locate Argument |       |
	Then In ENS01001 I should see Holder ID "<LocateArgument>" as below

Examples: 
		| HIN         | Action | LocateArgument | PayDate    | PayMethod     | Code | PayAccount | PayType | GrossAmount | NettAmount |
		| I0035337890 | DH     | X0040122044    | 16/02/2015 | DIRECT CREDIT | NIST | HA153      | PAYMENT | 158.26      | 158.26     |
		| X0058111708 | DH     | I0970061592    | 16/12/2014 | DIRECT CREDIT | DIVP | NZ152      | PAYMENT | 99.00       | 99.00      |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@16959
Scenario Outline: Test Case 16959: 05_Compare Action SS
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | SS    |
			| Locate Argument | Jones |
	Then In ENS01036 I should see Holder details as HIN "I0031170001" NameAddress "JOHN HAMILTON NOMINEES PTY LTD | <SUPERANNUATION FUND A/C>, | 12 ..." Postcode "3194"
	When I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01001 I should see Holder ID "<HIN>" as below


Examples: 
		| HIN         | Action | LocateArgument |
		| I0031170001 | 01     |                |
		| I0031178681 | 05     |                |
		| I0031188920 | 10     |                |
		| X0033311389 | 17     |                |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17017
Scenario: Test Case 17017: 01_Test LT Locate Transactions action
	# Enquiry System -Action LT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value         |
			| Action          | LT            |
			| Locate Argument | 7647/74354347 |
	Then In ENS01014 I should see Balance Transaction as below:
				| Field     | Value                                        |
				| Run       | 7647                                         |
				| Tran No   | 74354347                                     |
				| Tran Code | ESLAV                                        |
				| Tran Desc | LAPSE BY EXPIRY VESTED                       |
				| HIN       | I0070036924                                  |
				| Line1     | PRS/08E 20080530EE             1000 30/11/11 |
				| Line2     | *          1000                              |		

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17054
Scenario Outline: Test Case 17054: 02_'LS' Locate static transaction action-ENSSTM34
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSSTM34 I should see Static Transaction details as below "<Run>" "<Tran>" "<Date>" "<TranCode>" "<TranDesc>" "<Reference>"

Examples: 
		| TranCode | Action | LocateArgument | Run  | Tran    | Date       | TranDesc                    | Reference      |
		| DECAD    | LS     | 7646/4167434   | 7646 | 4167434 | 11/05/2015 | DECEASED NOTING (ADD)       | /0321457       |
		| PWRAD    | LS     | 7646/321459    | 7646 | 321459  | 11/05/2015 | POWER OF ATTORNEY (ADD)     |                |
#		| WRADD    | LS     | 7646/321461    | 7646 | 321461  | 11/05/2015 | WIRE INSTRUCTION (ADD)      | SyeA 000011314 |
		| INFAD    | LS     | 7646/321462    | 7646 | 321462  | 11/05/2015 | FREE FORM INFORMATION (ADD) |                |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17054
Scenario: Test Case 17054: 02_'LS' Locate static transaction action-ENSSTM06
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value       |
			| Action          | LS          |
			| Locate Argument | 7647/324325 |
	Then In ENSSTM06 I should see Static Transaction details as below:
			| Field           | Value                        |
			| TranCode        | EXCHG                        |
			| TranDesc        | EXTRA HOLDER DETAILS CHANGE  |
			| Run             | 7647                         |
			| TranNo          | 324325                       |
			| NameKey         | ST          TRANSACODE  TEST |
			| HIN             | I0070036916                  |
			| HolderType      | DEC                          |
			| PostCode        | 3000                         |
			| NameAddress1    | ESTATE LATE TRANSACTION CODE |
			| OldExtraID      | 123456789                    |
			| NewExtraID      | 123456789                    |
			| OldHomePh       | 03123456789                  |
			| NewHomePh       | 03123456789                  |
			| OldWorkPh       | 03987654213                  |
			| NewWorkPh       | 03987654213                  |
			| OldFax          | 03696854789                  |
			| NewFax          | 03696854789                  |
			| OldMobile       | 0430834786                   |
			| NewMobile       | 0430834786                   |
			| OldAbn          |                              |
			| NewAbn          |                              |
			| OldEmail1       | sam.syed@test.com            |
			| NewEmail1       | sam.syed@test.com            |
			| OldReturnDate   | No date                      |
			| NewReturnDate   | No date                      |
			| OldAmlDate      | No date                      |
			| NewAmlDate      | No date                      |
			| OldAmlTime      | :                            |
			| NewAmlTime      | :                            |
			| OldAmlFlag1     | AB                           |
			| NewAmlFlag1     | AB                           |
			| OldAmlFlag2     | W9                           |
			| NewAmlFlag2     | W9                           |
			| OldAmlFlag3     | EF                           |
			| NewAmlFlag3     | EF                           |
			| OldAmlFlag4     | Y                            |
			| NewAmlFlag4     | Y                            |
			| OldAmlFlag5     | E1                           |
			| NewAmlFlag5     | E1                           |
			| OldAmlFlag6     | FG                           |
			| NewAmlFlag6     | FG                           |
			| OldAmlFlag7     | AP                           |
			| NewAmlFlag7     | AP                           |
			| OldAmlFlag8     | TR                           |
			| NewAmlFlag8     | TR                           |
			| OldAmlFlag9     | N                            |
			| NewAmlFlag9     | N                            |
			| OldCommMethod1  |                              |
			| NewCommMethod1  | O                            |
			| OldCommMethod2  | O                            |
			| NewCommMethod2  | O                            |
			| OldCommMethod3  |                              |
			| NewCommMethod3  | O                            |
			| OldCommMethod4  |                              |
			| NewCommMethod4  | O                            |
			| OldCommMethod5  |                              |
			| NewCommMethod5  | O                            |
			| OldCommMethod6  |                              |
			| NewCommMethod6  | O                            |
			| OldCommMethod7  |                              |
			| NewCommMethod7  | O                            |
			| OldCommMethod8  |                              |
			| NewCommMethod8  | O                            |
			| OldCommMethod9  |                              |
			| NewCommMethod9  | O                            |
			| OldCommMethod10 |                              |
			| NewCommMethod10 |                              |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17054
Scenario: Test Case 17054: 02_'LS' Locate static transaction action-ENSSTM01
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value       |
			| Action          | LS          |
			| Locate Argument | 7647/658794 |
	Then In ENSSTM01 I should see Static Transaction details as below:
			| Field           | Value                        |
			| OldName         | ESTATE LATE TRANSACTION CODE |
			| OldAddressLine1 | TEST 1,                      |
			| OldAddressLine2 | C/- 452 JHONSTON ST,         |
			| OldAddressLine3 | ABBOTSFORD                   |
			| OldAddressLine4 | MELBOURNE                    |
			| NewName         | ESTATE LATE TRANSACTION CODE |
			| NewAddressLine1 | TEST 1,                      |
			| NewAddressLine2 | C/- 452 JHONSTON ST,         |
			| NewAddressLine3 | ABBOTSFORD                   |
			| NewAddressLine4 | MELBOURNE                    |
			| OldPostcode     | 3000                         |
			| NewPostcode     | 3000                         |
			| OldGroup        |                              |
			| NewGroup        |                              |
			| OldBrokerCode   |                              |
			| NewBrokerCode   | 60254                        |
			| OldAccessCode   |                              |
			| NewAccessCode   |                              |
			| OldKeyModifier  |                              |
			| NewKeyModifier  |                              |
			| OldVarField     |                              |
			| NewVarField     | EFG                          |
			| OldReturnMail   |                              |
			| NewReturnMail   | 01/15                        |
			| OldAlternateID  |                              |
			| NewAlternateID  | AC12345678                   |
			| OldTaxFile      | Not quoted                   |
			| NewTaxFile      | Not quoted                   |
			| OldBirthDay     |                              |
			| NewBirthDay     | 01/01/2015                   |
			| OldHolderType   | DEC                          |
			| NewHolderType   | DEC                          |
			| OldTaxCode      |                              |
			| NewTaxCode      |                              |
			| OldRegister     |                              |
			| NewRegister     |                              |
			| OldABN1         |                              |
			| NewABN1         |                              |
			| OldDeceased     | Y                            |
			| NewDeceased     | Y                            |
			| OldException    |                              |
			| NewException    | N                            |
			| OldSuppress     | N                            |
			| NewSuppress     | N                            |
			| OldStopTrade    | N                            |
			| NewStopTrade    | N                            |
			| OldAReport      | N                            |
			| NewAReport      | N                            |
			| OldARNom        | N                            |
			| NewARNom        | Y                            |
			| OldDivSource    | D                            |
			| NewDivSource    | D                            |
			| OldResidency    |                              |
			| NewResidency    |                              |
			| OldVarFlag1     |                              |
			| NewVarFlag1     | B                            |
			| OldVarFlag2     |                              |
			| NewVarFlag2     | W9                           |
			| OldVarFlag3     |                              |
			| NewVarFlag3     | W8                           |
			| OldVarFlag4     |                              |
			| NewVarFlag4     | D                            |
			| OldVarFlag5     |                              |
			| NewVarFlag5     | CU                           |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17055
Scenario: Test Case 17055: 03_'LES' Locate static transaction action for vesting performance-Test1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0070036924"
		And I enter the following details as the Locate action:
			| Field           | Value              |
			| Action          | LES                |
			| Locate Argument | 7646/00000002/0001 |
	Then In ENSESS33 I should see ESS Static Transactions as below:
			| Field               | Value                                               |
			| Run                 | 7646                                                |
			| Tran                | 2                                                   |
			| Sequesnce           | 1                                                   |
			| TransactionType     | EVELA                                               |
			| TransactionDesc     | ADD ESS EVENT ELECTION                              |
			| Name                | TRANSACTION CODE TEST 2,                            |
			| Address1            | TEST AUTOMATION                                     |
			| Address2            | ABBOTSFORD                                          |
			| Postcode            | 3000                                                |
			| HIN                 | I0070036924                                         |
			| EmployeeID          | 0070036924                                          |
			| PayrollID           | AUS                                                 |
			| EmployeeStatus      | E                                                   |
			| EmpStatusDesc       | CURRENT EMPLOYEE                                    |
			| LeaverCode          | EEE                                                 |
			| LeavercodeDesc      | E DEFAULT                                           |
			| Plan                | PRS                                                 |
			| PlanDesc            | PERFORMANCE RIGHTS                                  |
			| Reg                 | 08E                                                 |
			| RegDesc             | 2008 NZ MOTIVATION & RETENTION                      |
			| Cert                | 20080530EE                                          |
			| VertingDetailsLine1 | Before/       VP4                        30/11/2010 |
			| VertingDetailsLine2 | After/                                   30/11/2011 |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17055
Scenario: Test Case 17055: 03_'LES' Locate static transaction action for vesting performance-Test2
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0070036924"
		And I enter the following details as the Locate action:
			| Field           | Value              |
			| Action          | LES                |
			| Locate Argument | 7646/00000002/0002 |
	Then In ENSESS33 I should see ESS Static Transactions as below:
			| Field               | Value                          |
			| Run                 | 7647                           |
			| Tran                | 111111                         |
			| Sequesnce           | 1                              |
			| TransactionType     | EVELA                          |
			| TransactionDesc     | ADD ESS EVENT ELECTION         |
			| Name                | TRANSACTION CODE TEST 2,       |
			| Address1            | TEST AUTOMATION                |
			| Address2            | ABBOTSFORD                     |
			| Postcode            | 3000                           |
			| HIN                 | I0070036924                    |
			| EmployeeID          | 0070036924                     |
			| PayrollID           | AUS                            |
			| EmployeeStatus      | E                              |
			| EmpStatusDesc       | CURRENT EMPLOYEE               |
			| LeaverCode          | EEE                            |
			| LeavercodeDesc      | E DEFAULT                      |
			| Plan                | PRS                            |
			| PlanDesc            | PERFORMANCE RIGHTS             |
			| Reg                 | 08E                            |
			| RegDesc             | 2008 NZ MOTIVATION & RETENTION |
			| Cert                | 20080530EE                     |
			| VertingDetailsLine1 | Before/       VP4       006    |
			| VertingDetailsLine2 | After/                  007    |

#@EN_E_LocateAction
#@NAB_AUTO
#@16866
#@ignore
#Scenario: Test Case 16866: 01_Compare Hotkeys (F7)
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "NAB_AUTO"
#	 And I go to the Enquiry system for "I0070036924"
#	 And I Press F7
#	Then I expect to see error with text "You cannot use the hotkey when in the enquiry system"
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "NAB_AUTO"
#		And In TRDMNU03 I go to Create New Trade Screen selecting "1ARR" in the Trade Control
#		And I Press F7
#		And EscapeFromCurrentScreen
#	Then I expect to be in the "TRD00201" Screen

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@16868
Scenario Outline: Test Case 16868: 03_Compare matched company Name Filter
	Given I have connected to WinForms
	When In SELCOY01 I Enter the following details as the company selection "<CoyID>" "<CoyNameFilter>"
	Then In SELCOY20 I should see company UFD as: 
	| Ufd1   | Ufd2   | Ufd3   | Ufd4   | Ufd5   |
	| <Ufd1> | <Ufd2> | <Ufd3> | <Ufd4> | <Ufd5> |     

Examples: 
		| COY   | CoyID | CoyNameFilter | Ufd1   | Ufd2   | Ufd3   | Ufd4   | Ufd5   |
		| Test1 |       | LARGE         | LP0001 | LP0002 | LP0003 | LP0004 | LP0005 |
#		| Test2 |       | TEST          | AE_KW  | AE_PD1 | AE_PD2 | AE_PD3 | AE_PD4 |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17987
Scenario Outline: Test Case 17987: 01_Participant/Account/Domicile (LD Actions)
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01001 I should see holder details as "<HIN>" "<Type>" "<PostCode>" "<TFN>" "<ABN>" "<Name>"

Examples: 
	| LocateArgument | HIN         | Type | PostCode | TFN        | ABN        | Name                          | Action |
	| USA            | I0030013930 | ***  | USA      | Non-Res    | Non-Res    | MR THOMAS EGGLESTON ADKINS JR | LD     |
	| IRL            | C0009905753 | IND  | IRL      | Non-Res    | Non-Res    | MR PETER PATRICK BRANAGAN     | LD     |
	| IND            | C0009905753 | IND  | IRL      | Non-Res    | Non-Res    | MR PETER PATRICK BRANAGAN     | LD     |
	| GBP            | I0035337890 | IND  | GBR      | Non-Res    | Non-Res    | MRS AVRIL V APPLEYARD         | LD     |
	| 3000           | C0009913176 | IND  | 3000     | Not quoted | Not quoted | ARSHAD TEST 1,                | LD     |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17989
Scenario Outline: Test Case 17989: 01_Markings/Certs Action -ENS01012
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Certificate details as "<HIN>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>"

Examples: 
		| Action | LocateArgument | HIN         | Line1                       | Line2                                                                               | Line3                                                                               | Line4                                                                               | Line5                          | Line6                                   | Line7                              | Line8                                   | Line9                              | Line10                                  | Line11 | Line12 | Line13 |
		| LC     | 23512615       | I0033655983 | CEN/ENTITLEMENT CPS II 2013 | VIC 23512615     04/11/13   99999999849    VIC 87654321ST01 01/06/15             10 | VIC 87654321ST02 01/06/15            10    VIC 87654321ST03 01/06/15             10 | VIC 87654321ST04 01/06/15            10    VIC 87654321ST05 01/06/15             10 | DAM/EMPLOYEE TRUST HELD SHARES | VIC UNCERTIF'D   14/11/13          3225 | DBM/EMPLOYEE TRUST HELD SHARES     | VIC UNCERTIF'D   19/05/14          3545 | DCE/DUMMY EMP CLASS PROJECT MURRAY | VIC 00003538     04/11/13          3369 |        |        |        |
		| LCC    | 23512615       | I0033655983 | CEN/ENTITLEMENT CPS II 2013 | VIC 23512615     04/11/13   99999999849                                             | DAM/EMPLOYEE TRUST HELD SHARES                                                      | VIC UNCERTIF'D   14/11/13          3225                                             | DBM/EMPLOYEE TRUST HELD SHARES | VIC UNCERTIF'D   19/05/14          3545 | DCE/DUMMY EMP CLASS PROJECT MURRAY | VIC 00003538     04/11/13          3369 | DEM/EMPLOYEE TRUST HELD SHARES     | VIC UNCERTIF'D   06/06/13          3225 |        |        |        |
		| LCM    | 87654321       | I0033655983 | CEN/ENTITLEMENT CPS II 2013 | VIC 87654321ST01 01/06/15            10    VIC 87654321ST02 01/06/15             10 | VIC 87654321ST03 01/06/15            10    VIC 87654321ST04 01/06/15             10 | VIC 87654321ST05 01/06/15            10                                             |                                |                                         |                                    |                                         |                                    |                                         |        |        |        |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17989
Scenario Outline: Test Case 17989: 01_Markings/Certs Action -ENS01040
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01040 I should see Duplicate Certificate details as "<CertID>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>"

Examples: 
		| Action | LocateArgument | CertID     | Line1                                                                            | Line2                                                                     | Line3                                                                            | Line4                                                                     | Line5                                                                            | Line6                                                                     | Line7                                                                            | Line8                                                                     | Line9                                                                            | Line10                                                                    |
		| LC     | 20111109EB     | 20111109EB | 20111109EB   IDS 11H I0033655983            295 0 LEAHY       HELEN MAREE JACKSO | 20111109EB   IDS 11H I0033870752              0 0 SLAUGHTER   KATRINMARIE | 20111109EB   IDS 11H I0035535926             84 0 FAN         DENISEWA    MAN    | 20111109EB   IDS 11L I0035854282              0 0 OLOUGHLIN   TOMAS       |                                                                                  |                                                                           |                                                                                  |                                                                           |                                                                                  |                                                                           |
		| LCC    | 20111109EB     | 20111109EB | 20111109EB   IDS 11H I0033655983            295 0 LEAHY       HELEN MAREE JACKSO | 20111109EB   IDS 11H I0033870752              0 0 SLAUGHTER   KATRINMARIE | 20111109EB   IDS 11H I0035535926             84 0 FAN         DENISEWA    MAN    | 20111109EB   IDS 11L I0035854282              0 0 OLOUGHLIN   TOMAS       |                                                                                  |                                                                           |                                                                                  |                                                                           |                                                                                  |                                                                           |
		| LCM    | 12345678       | 12345678   | 12345678ST01 CEN VIC I0033655983             10 0 LEAHY       HELEN MAREE JACKSO | 12345678ST01 CEN VIC I0033870752             10 0 SLAUGHTER   KATRINMARIE | 12345678ST02 CEN VIC I0033655983             10 0 LEAHY       HELEN MAREE JACKSO | 12345678ST02 CEN VIC I0033870752             10 0 SLAUGHTER   KATRINMARIE | 12345678ST03 CEN VIC I0033655983             10 0 LEAHY       HELEN MAREE JACKSO | 12345678ST03 CEN VIC I0033870752             10 0 SLAUGHTER   KATRINMARIE | 12345678ST04 CEN VIC I0033655983             10 0 LEAHY       HELEN MAREE JACKSO | 12345678ST04 CEN VIC I0033870752             10 0 SLAUGHTER   KATRINMARIE | 12345678ST05 CEN VIC I0033655983             10 0 LEAHY       HELEN MAREE JACKSO | 12345678ST05 CEN VIC I0033870752             10 0 SLAUGHTER   KATRINMARIE |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@17989
@FullSmokeTest
Scenario: Test Case 17989: 01_Markings/Certs LC, LCM, LCC, LE Action -ENS01042
	# Enquiry System -Action LE /LEC/LEM
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value    |
			| Action          | LE       |
			| Locate Argument | 23512615 |
	Then In ENS01042 I should see Certificate Details as Cert1 "VIC 23512615     04/11/13   99999999849 | 01/06/15 MRKNG 7650/ 3265791            50-"  and Cert2 "VIC 87654321ST01 01/06/15            10 | 01/06/15 MRKNG 7650/ 3265791            10"
	When I enter the following details as the Locate action:
			| Field           | Value    |
			| Action          | LEC      |
			| Locate Argument | 23512615 |
	Then In ENS01042 I should see Certificate Details as Cert1 "VIC 23512615     04/11/13   99999999849 | 01/06/15 MRKNG 7650/ 3265791            50-"  and Cert2 "DAM/EMPLOYEE TRUST HELD SHARES"
	When I enter the following details as the Locate action:
			| Field           | Value    |
			| Action          | LEM      |
			| Locate Argument | 87654321 |
	Then In ENS01042 I should see Certificate Details as Cert1 "VIC 87654321ST01 01/06/15            10 | 01/06/15 MRKNG 7650/ 3265791            10"  and Cert2 "VIC 87654321ST02 01/06/15            10 | 01/06/15 MRKNG 7650/ 3265791            10"		

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@CPU_AUTO
@18036
Scenario Outline: Test Case 18036: 01_Faster FIN Details (FIN Action)
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
		And I enter Fin Password
	Then I should see the below ErrorMessage "<ErrorMessage>"
	#Then In ENS01056 I should see FIN details as: "<FIN>" #need to add test data.
Examples: 
	| LocateArgument | Action | FIN | ErrorMessage                                     |
	| N0060000052    | FIN    |     | Current holder is not a FASTER SCRIPLESS holder. |
	| L0331163805    | FIN    |     | Current holder is not a FASTER SCRIPLESS holder. |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTO
@18077
Scenario: Test Case 18077: 01_Payments and Reference Actions(LP)
	# Enquiry System -Action LP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value        |
			| Action          | LP           |
			| Locate Argument | DV122/933282 |
	Then In ENS01009 I should see Payment Details as below:
		| Field    | Value                                                                        |
		| Name Key | IQBAL       SAMAIR                                                           |
		| HIN      | I0035933662                                                                  |
		| Name     | MISS SAMAIRA IQBAL                                                           |
		| Address  | TEST AUTOMATION                                                              |
		| PD Line1 | DV122/ORD DIV@88C FF@30% RD16/11/11 PD19/12/11 R:00933282          51.92:Net |
		| PD Line2 | 51.92:Frk           0.00:Unf         22.25*TCr          Unpresented          |
		| PD Line3 |                                                                              |
		| PD Line4 |                                                                              |
		| PD Line5 |                                                                              |
		| PD Line6 |                                                                              |
		| PD Line7 |                                                                              |
		| PD Line8 |                                                                              |
		| PD Line9 |                                                                              |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENS01010 I should see Extra Payment Details as below:
			| Field         | Value       |
			| ExtraDetails1 | 51.92:Gross |
			| ExtraDetails2 | 0.00:Ded/T  |

@winformsTest
@EnquiryTest
@EN_E_LocateAction			
@NAB_AUTO
@18083
Scenario: Test Case 18083: 02_Payments and Reference Actions(LHR)
	# Enquiry System -Action LHR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "C0009906408"
		And I enter the following details as the Locate action:
			| Field           | Value    |
			| Action          | LHR      |
			| Locate Argument | 12345678 |
	Then In ENS01013 I should see Register details as below:
			| Field | Value                                                                                      |
			| HIN   | C0009906408                                                                                |
			| Line1 | ORD/ORDINARY FULLY PAID SHARES                                                             |
			| Line2 | VIC  A296042     08/05/15 CAPIN 7650/     123            100                       WINFRM |
			| Line3 |                                                                                            |
			| Line4 |                                                                                            |
			| Line5 |                                                                                            |
			| Line6 |                                                                                            |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENS01053 I should see Extra Register details as below:
			| Field | Value    |
			| Line1 | 12345678 |

#@EN_E_LocateAction
#@ANZ_AUTO
#@18065
#Scenario Outline: Test Case 18065: 01_CHESS Enquiry Actions
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENS01014 I should see Balance Transaction as "<SBN>" "<Line1>" "<Line2>"
#	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
#	Then I expect to be in the "ENS010LC" Screen
#Examples: 
#	| Action | LocateArgument | SBN   | Line1                                        | Line2           | Action1 | LocateArgument1 |
#	| LCI    | 58872/3520459  | 00001 | PE /VIC UNCERTIF'D              200 30/04/14 | *           200 | LCI     | 7760/TESTING         |

#@EN_E_LocateAction
#@BIX_LINUX
#@18066
#Scenario Outline: Test Case 18066: 02_CHESS Enquiry Actions
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "BIX_LINUX"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENS01062 I should see Pending Chess Transaction History as "<LocateArgument>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>"
#	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
#	Then In ENS01062 I should see Pending Chess Transaction History as "<LocateArgument>" "<Page2Line1>" "<Page2Line2>" "<Page2Line3>" "<Page2Line4>" "<Page2Line5>" "<Page2Line6>" "<Page2Line7>" "<Page2Line8>" "<Page2Line9>" "<Page2Line10>" "<Page2Line11>" "<Page2Line12>"
#	When I enter the following details as the locatActions "<Action2>"  "<LocateArgument1>"
#	Then In ENS01063 I should see Transaction Extra Details as "<ExtraLine1>" "<ExtraLine2>" "<ExtraLine3>" "<ExtraLine4>" "<ExtraLine5>" "<ExtraLine6>" "<ExtraLine7>" "<ExtraLine8>"
#
#Examples: 
#	| Action | LocateArgument | Line1                   | Line2                                                                                     | Line3                                                                                          | Line4                                                                                     | Line5                                                                                          | Line6                                                                                          | Line7                                                                                     | Line8                                                                                          | Line9                                                                                          | Line10                                                                                    | Line11                                                                                         | Line12                                                                                         | Action1 | LocateArgument1 | Page2Line1              | Page2Line2                                                                                | Page2Line3                                                                                     | Page2Line4                                                                                     | Page2Line5              | Page2Line6                                                                                | Page2Line7                                                                                     | Page2Line8                                                                                     | Page2Line9              | Page2Line10                                                                               | Page2Line11                                                                                    | Page2Line12                | Action2 | ExtraLine1 | ExtraLine2 | ExtraLine3 | ExtraLine4 | ExtraLine5 | ExtraLine6 | ExtraLine7 | ExtraLine8                                                                 |
#	| LCH    | X0005008883    | FP /BUYBACK PRICE $1.10 | 05/05/05  1/BIX001  RTKRQ  0004/10000103       100000  N  CHESS Pending         000000041 | 05/05/05  1/BIX001  RTKRQ  0004/10000103       100000  N  CHESS Ack/Pending     17401000000041 | 17/02/15  1/BIX001  RTKRQ  0019/10000172            1  N  CHESS Pending         000000092 | 17/02/15  1/BIX001  RTKRQ  0019/10000172            1  N  CHESS Ack/Pending     17401000000092 | 18/02/15  1/BIX001  CTKFA  0019/       0            1  N  Failed                0023055004OAEW | 18/02/15  1/BIX001  RTKRQ  0019/10000173            1  N  CHESS Pending         000000093 | 18/02/15  1/BIX001  RTKRQ  0019/10000173            1  N  CHESS Ack/Pending     17401000000093 | 19/02/15  1/BIX001  CTKFA  0019/       0            1  N  Failed                0023055104LS8Q | 23/02/15  1/BIX001  RTKRQ  0019/10000183            1  N  CHESS Pending         000000103 | 23/02/15  1/BIX001  RTKRQ  0019/10000183            1  N  CHESS Ack/Pending     17401000000103 | 24/02/15  1/BIX001  CTKFA  0019/       0            1  N  Failed                0023055604P3S7 | M       |                 | FP /BUYBACK PRICE $1.10 | 23/02/15  1/BIX001  RTKRQ  0019/10000187            1  N  CHESS Pending         000000107 | 23/02/15  1/BIX001  RTKRQ  0019/10000187            1  N  CHESS Ack/Pending     17401000000107 | 24/02/15  1/BIX001  CTKFA  0019/       0            1  N  Failed                0023055604P5FN | FP /BUYBACK PRICE $1.20 | 23/02/15  1/BIX003  RTKRQ  0019/10000184            1  N  CHESS Pending         000000104 | 23/02/15  1/BIX003  RTKRQ  0019/10000184            1  N  CHESS Ack/Pending     17401000000104 | 24/02/15  1/BIX003  CTKFA  0019/       0            1  N  Failed                0023055604P5ET | FP /BUYBACK PRICE $1.25 | 23/02/15  1/VIX004  RTKRQ  0019/10000185            1  N  CHESS Pending         000000105 | 23/02/15  1/VIX004  CTKRJ  0019/       0            1  N  CHESS Rejected        17401000000105 | /ASX Takeover Desc not set | >       | 7760       | 7760       | 7760       | 7760       | 7760       | 7760       | 7760       | 05069/Unknown error message                                           7760 |
#
#@EN_E_LocateAction
#@ANZ_AUTO
#@18068
#Scenario Outline: Test Case 18068: 03_CHESS Enquiry Actions_ENS01072
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENS01072 I should see Chess Balance Rejection details Part1 as "<Broker>" "<TradeRef>" "<CertId>" "<OverrideBasis>" "<TranType>" "<TranTypeDesc>" "<Class>" "<ClassDesc>" "<TotalUnits>" "<TransferUnits>" "<RejectReason>" "<ForeignGuar>" "<MessageType>" "<MovementReason>" "<Register>" "<BusDate>" "<Security>"
#		And In ENS01072 I should see Chess Balance Rejection details Part2 as "<SellHolder>" "<SellResidency>" "<SellAddress>" "<BuyHolder>" "<BuyResidency>" "<BuyAddress>" "<Message>"
#
#Examples: 
#	| Action | LocateArgument | Broker | TradeRef  | CertId   | OverrideBasis | TranType | TranTypeDesc                | Class | ClassDesc       | TotalUnits | TransferUnits | RejectReason | ForeignGuar | MessageType | MovementReason | Register | BusDate    | Security | SellHolder  | SellResidency | SellAddress      | BuyHolder   | BuyResidency | BuyAddress       | Message                                  | 
#	| LRJ    | 7500           | 21028  | P15064179 | Uncert'd |               | CTFIX    | ISSUER SP TO CHESS TRANSFER | ORD   | ORDINARY SHARES | 845        | 845           | J            |             | TRF         | C              |          | 08/05/2014 | ANZ      | I0013611386 | D             | Holder Not Found | X0065255332 | D            | Holder Not Found | Documentation not received within 5 days | 

#@EN_E_LocateAction
#@ANZ_AUTO
#@18068
#Scenario Outline: Test Case 18068: 03_CHESS Enquiry Actions_ENS01072_Forward
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
#	Then In ENS01072 I should see Chess Balance Rejection details Part1 as "<Broker>" "<TradeRef>" "<CertId>" "<OverrideBasis>" "<TranType>" "<TranTypeDesc>" "<Class>" "<ClassDesc>" "<TotalUnits>" "<TransferUnits>" "<RejectReason>" "<ForeignGuar>" "<MessageType>" "<MovementReason>" "<Register>" "<BusDate>" "<Security>"
#		And In ENS01072 I should see Chess Balance Rejection details Part2 as "<SellHolder>" "<SellResidency>" "<SellAddress>" "<BuyHolder>" "<BuyResidency>" "<BuyAddress>" "<Message>"
#
#Examples: 
#	| Action | LocateArgument | Broker | TradeRef  | CertId   | OverrideBasis | TranType | TranTypeDesc                  | Class | ClassDesc       | TotalUnits | TransferUnits | RejectReason | ForeignGuar | MessageType | MovementReason | Register | BusDate    | Security | SellHolder  | SellResidency | SellAddress      | BuyHolder   | BuyResidency | BuyAddress             | Message                       | Action1 | LocateArgument1 |
#	| LRJ    | 7500           | 1402   | 153329828 | Uncert'd |               | CCVIX    | ISSUER SP TO CHESS CONVERSION | ORD   | ORDINARY SHARES | 5          | 5             | H            |             | UCN         | C              |          | 14/05/2014 | ANZ      | I0031273935 | D             | Holder Not Found | X0042417661 | D            | MR BRENT WILSON THOMS, | Unable to locate sell details | F       |                 |


#@EN_E_LocateAction
#@ANZ_AUTO
#@18068
#Scenario Outline: Test Case 18068: 03_CHESS Enquiry Actions_ENS01067
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENS01067 I should see Chess Static Rejection Details as "<Broker>" "<TradeRef>" "<RejectReason>" "<TranType>" "<TranTypeDesc>" "<Run>" "<Trans>" "<BusDate>" "<SellHIN>" "<SellNameAddress>" "<SellPostcode>" "<SellTaxCode>"
#
#Examples: 
#	| Action | LocateArgument | Broker | TradeRef  | RejectReason                            | TranType | TranTypeDesc                  | Run  | Trans   | BusDate    | SellHIN     | SellNameAddress  | SellPostcode | SellTaxCode |
#	| LSR    | 7486/3181569   | 01442  | 705701824 | Overseas holder - Does not require TFN] | CTXRJ    | CHESS TAX NUMBER: AUTO REJECT | 7486 | 3181569 | 28/04/2014 | X0049430825 | Holder Not Found |              |             |
#
#@EN_E_LocateAction
#@ANZ_AUTO
#@18068
#Scenario Outline: Test Case 18068: 03_CHESS Enquiry Actions_ENS0106P
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENS0106P I should see Chess Static Rejection Details as "<Broker>" "<TradeRef>" "<RejectReason>" "<RejectDesc>" "<TranType>" "<TranTypeDesc>" "<Run>" "<Trans>" "<BusDate>" "<SellHIN>" "<SellNameAddress>" "<BulkSystem>" "<BSB>" "<AccountNbr>" "<AccountName>"
#
#Examples: 
#	| Action | LocateArgument | Broker | TradeRef  | RejectReason | RejectDesc                                                                   | TranType | TranTypeDesc       | Run  | Trans   | BusDate    | SellHIN     | SellNameAddress  | BulkSystem | BSB     | AccountNbr | AccountName                   |
#	| LSR    | 7486/3181604   | 4064   | 015628514 | D            | Cancellation Bank Account Details do not match recorded bank account details | CPREJ    | PAYEE INS:AUTO REJ | 7486 | 3181604 | 28/04/2014 | X0065622301 | Holder Not Found | 10         | 014-141 | 299568687  | SHAKELJOR CORPORATION PTY LTD |
#
#@EN_E_LocateAction
#@ANZ_AUTO
#@18068
#Scenario Outline: Test Case 18068: 03_CHESS Enquiry Actions_ENS0106E
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENS0106E I should see Chess Static Rejection Details as "<Broker>" "<TradeRef>" "<RejectReason>" "<TranType>" "<TranTypeDesc>" "<Run>" "<Trans>" "<BusDate>" "<SellHIN>" "<SellNameAddress>" "<Postcode>" "<Email>"
#
#Examples: 
#	| Action | LocateArgument | Broker | TradeRef  | RejectReason                            | TranType | TranTypeDesc           | Run  | Trans   | BusDate    | SellHIN     | SellNameAddress  | Postcode | Email                   |
#	| LSR    | 7486/3182402   | 2552   | 4B888NHX4 | Cancellation Email details do not match | CEREJ    | EMAIL ADDRESS:AUTO REJ | 7486 | 3182402 | 28/04/2014 | X0054658711 | Holder Not Found |          | DIYSUPER@ONEPATH.COM.AU |

@winformsTest
@EnquiryTest
@EN_E_LocateAction
@NAB_AUTOs
@17054
Scenario Outline: Test Case 17054: 02_'LS' Locate static transaction action-ENSSTM02
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSSTM02 I should see Static Transaction details:
	| AfterDetails1   | AfterDetails2   | AfterDetails3   | AfterDetails4   | AfterDetails5   | AfterDetails6   | AfterDetails7   | AfterDetails8   | AfterDetails9   | AfterDetails10   | BeforeDetails1   | BeforeDetails2   | BeforeDetails3   | BeforeDetails4   | BeforeDetails5   | BeforeDetails6   | BeforeDetails7   | BeforeDetails8   | BeforeDetails9   | BeforeDetails10   |
	| <AfterDetails1> | <AfterDetails2> | <AfterDetails3> | <AfterDetails4> | <AfterDetails5> | <AfterDetails6> | <AfterDetails7> | <AfterDetails8> | <AfterDetails9> | <AfterDetails10> | <BeforeDetails1> | <BeforeDetails2> | <BeforeDetails3> | <BeforeDetails4> | <BeforeDetails5> | <BeforeDetails6> | <BeforeDetails7> | <BeforeDetails8> | <BeforeDetails9> | <BeforeDetails10> |

Examples: 
		| TranCode | Action | LocateArgument | AfterDetails1  | AfterDetails2   | AfterDetails3           | AfterDetails4 | AfterDetails5                | AfterDetails6 | AfterDetails7 | AfterDetails8 | AfterDetails9 | AfterDetails10 | BeforeDetails1 | BeforeDetails2 | BeforeDetails3 | BeforeDetails4 | BeforeDetails5 | BeforeDetails6 | BeforeDetails7 | BeforeDetails8 | BeforeDetails9 | BeforeDetails10 |
		| WRADD    | LS     | 7646/321461    | Country...: NZ | Currency..: NZD | Swift Code: ANZBNZ22102 | A/C:126543789 | Nme:COMPUTERSHARE NZ ACCOUNT | ANZBNZ22102   | AUCKLAND      |               |               |                |                |                |                |                |                |                |                |                |                |                 |

