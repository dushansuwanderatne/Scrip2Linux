Feature: OL_SDM_StaticDetailMaintenance	    
	Ensure SDM. Static Detail Maintenance functionality covered

@winformsTest
@OL_Online
@CPU_AUTO
@OL_SDM_StaticDetailMaintenance
Scenario: Update Employee Details -Change Employee to Leaver
# Update Employee Details -Change Employee to Leaver
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I search "I0100007801" in Static Details update Menu
	When I update Employee Details "employee status" as below:
		| Field          | Value      |
		| Action         | C          |
		| Tran No        | 155        |
		| Emp Status     | L          |
		| Leaver Code    | LLL        |
		| Effective Date | 01/01/2008 |
		And I go to the Enquiry system for "I0100007801"
	Then In ENSESS01 I should see the holder Employee Details as below:
		| Field           | Value            |
		| HIN             | I0100007801      |
		| Employee ID     | 0001020288       |
		| Preferred Name  | KUQKEIV NJUATTOD |
		| Business Unit   | CSUK             |
		| Employee Status | L                |
		| Leaver Code     | LLL              |
		| Effective Date  | 01/01/2008       |

@winformsTest
@OL_Online
@NAB_AUTO
@18129
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 18129: 01 - Search by Holder ID
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Static Details Menu
		And OLS01101 I Search the Holder as "<HIN>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<TaxCode>" "<KeyModifier>" "<AlternateID>"
	Then In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
	Then In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<ARReport>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
Examples: 
		| HIN         | Key                            | Type | Postcode | DPID     | Group | BrokerCode | VarField | Register | TaxCode | KeyModifier | AlternateID | Name                         | Address1                  | Address2                    | Address3                 | Address4                   | Address5      | Warning1      | Warning2                       | Warning3                       | Warning4                     | Warning5                      | Deceased | Exception | Suppress | StopTrade | RetMail | ARReport      | BirthDate  | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 |
		| X0054356552 | A&G         ROBERTSPTYLTA&G    | COY  | 3205     | 90304337 |       | 1442       | DEF      |          |         | A&G         | AB123456    | A & G ROBERTS PTY LTD        | TEST AUTOMATION           | ,C/-HEWISON&ASSOCIATES P/L  | LEVEL 4 102 ALBERT ROAD  | SOUTH MELBOURNE VIC        |               | Returned mail | Exception                      | Payee instruction direct/bulk  | Holder Extra details present | Shareholder Review            | N        | F         | N        | N         | 05/2015 | R (Nominated) | 01/01/2015 | B        | W9       | W8       | D        | CU       |
		| I0034882762 | AUTOMATION  GUY   KURZMAADALKU | JNT  | 4001     | 49937071 |       | 60254      |          |          |         |             |             | MR GUY KURZMANN &            | TEST AUTOMATION           | <ADAL KURZMANN S/FUND A/C>, | C/- ABN AMRO MORGANS MPS | GPO BOX 582                | BRISBANE QLD  | Exception     | Payee instruction direct/bulk  | Nil holding on trading classes | No Annual Report             |                               | N        | N         | N        | N         |         | N (Default)   |            | B        | W9       | W8       | D        | CU       |
		| C9999999164 | A/C         US    DIRECTCREDIT | CNT  | 3000     |          |       |            |          |          |         |             |             | US DIRECT CREDIT CONTROL A/C | TEST AUTOMATION           | SERVICES PTY LTD            | GPO BOX 2975             | MELBOURNE VIC              |               | Exception     | Nil holding on trading classes | No Annual Report               |                              |                               | N        | N         | N        | N         |         | N (Default)   |            | B        | W9       | W8       | D        | CU       |
		| I0035493034 | ABRAHAMS    LESLEYJANE         | IND  | 2830     | 34608673 |       | 60254      |          |          |         |             |             | MRS LESLEY JANE ABRAHAMS,    | TEST AUTOMATION           | 1R DELALAH DOWNS ROAD       | DUBBO NSW                |                            |               | Exception     | Payee instruction direct/bulk  | Noting:N1                      | Holder Extra details present | Communication Methods Present | N        | N         | N        | N         |         | N (Default)   |            | B        | W9       | W8       | D        | CU       |
		| I0035565469 | BOTHKAMP    AUSTRALIAPTYBOTHKA | COY  | 6005     | 48873037 |       | 60254      |          |          |         |             |             | BOTHKAMP AUSTRALIA PTY LTD   | <BOTHKAMP AUSTRALIA A/C>, | C/- KINGSTON ADMINISTRATION | SERVICES PTY LTD         | LEVEL 2/76 KINGS PARK ROAD | WEST PERTH WA | Exception     | Payee instruction direct/bulk  | Nil holding on trading classes | No Annual Report             |                               | N        | N         | N        | N         |         | N (Default)   |            | B        | W9       | W8       | D        | CU       |

@winformsTest
@OL_Online
@NAB_AUTO
@18130
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 18130: 02 - Search by Holder Name
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Static Details Menu
		And OLS01101 I Search the Holder as "<SearchString>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<TaxCode>" "<KeyModifier>" "<AlternateID>"

Examples: 
		| HIN         | Key                            | Type | Postcode | DPID     | Group | BrokerCode | VarField | Register | TaxCode | KeyModifier | AlternateID | SearchString           |
		| I0032734596 | MILDENHALL  CAROLI             | IND  | 3141     | 62415726 |       | 60254      |          |          |         |             |             | MILDENHALL             |
		| X0053349706 | XIE         ZHONG LI           | IND  | 2142     | 50945055 |       | 2662       |          |          |         |             |             | XIE                    |
		| C9999999147 | UK          DIRECTCREDIT       | CNT  | 3001     |          |       |            |          |          |         |             |             | UK                     |
		| I0031315280 | LAVERY      HUGH  JOHN  LAVERY | JNT  | 4064     | 31540343 |       | 60254      |          |          |         |             |             | MR HUGH JOHN LAVERY    |
		| I0035565469 | BOTHKAMP    AUSTRALIAPTYBOTHKA | COY  | 6005     | 48873037 |       | 60254      |          |          |         |             |             | BOTHKAMP AUSTRALIA PTY |

@winformsTest
@OL_Online
@NAB_AUTO
@18131
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 18131: 03 - Search by Holder ID not an exact match
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Static Details Menu
		And OLS01101 I Search the Holder as "<SearchString>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<TaxCode>" "<KeyModifier>" "<AlternateID>"

Examples: 
		| HIN         | Key                            | Type | Postcode | DPID     | Group | BrokerCode | VarField | Register | TaxCode | KeyModifier | AlternateID | SearchString |
		| X0051115481 | ICAITKEN    PTYLTD      AITKEN | COY  | 2536     | 71010325 |       | 4064       |          |          |         |             |             | I003488      |
		| X0053349706 | XIE         ZHONG LI           | IND  | 2142     | 50945055 |       | 2662       |          |          |         |             |             | X00543       |

@winformsTest
@NAB_AUTO
@18132
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 18132: 04 - Search by Holder Name not an exact match
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Static Details Menu
		And OLS01101 I Search the Holder as "<SearchString>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<TaxCode>" "<KeyModifier>" "<AlternateID>"

Examples: 
		| HIN         | Key                            | Type | Postcode | DPID     | Group | BrokerCode | VarField | Register | TaxCode | KeyModifier | AlternateID | SearchString      |
		| X0044473445 | CAROSELLI   JOHN               | IND  | 3060     | 45143877 |       | 1227       |          |          |         |             |             | CAROLINE          |
		| X0062631686 | ROBERTS     CHRISTJAMES        | IND  | 2120     | 64949418 |       | 1227       |          |          |         |             |             | ROBERTS           |
#		| I0034158126 | AUTOMATION22SCRIP              | IND  | 3068     |          |       | 60254      |          |          |         |             |             | AUTOMATION21SCRIP |
		| I0035136461 | DENNIS      GUY   MICHAE44     | IND  | 2119     | 54524031 |       | 60254      |          |          |         |             |             | DENNIS            |
		| I0035565469 | BOTHKAMP    AUSTRALIAPTYBOTHKA | COY  | 6005     | 48873037 |       | 60254      |          |          |         |             |             | BOTHKAMP          |
		| X0050621138 | MITCHELL    ALLAN       A&LMIT | JNT  | 4655     | 55126913 |       | 4094       |          |          |         |             |             | MISS              |

@winformsTest
@OL_Online
@NAB_AUTO
@OL_SDM_StaticDetailMaintenance
@17821
Scenario Outline: Test Case 17821: Payee Action - Direct Credits Type
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option as below:
		| Field        | Value |
		| Action       | P     |
		| UpdateOption |       |
	Then In OLS01103 I should see Holder Address Details as "<Key>" "<HIN>" "<Type>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01103 I should see Payee Details as "<BankSystem>" "<BSB>" "<AccountNbr>" "<AccountName>" "<PayeeAddress1>" "<PayeeAddress2>" "<PayeeAddress3>" "<PayeeAddress4>"
		And In OLS01103 I should see Holder Warnings as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"

Examples: 
		| Test | UpdateOption | Action | Key                      | HIN         | Type | Name                      | Address1               | Address2         | Address3                 | Address4       | Address5 | BankSystem | BSB       | AccountNbr | AccountName              | PayeeAddress1      | PayeeAddress2   | PayeeAddress3 | PayeeAddress4 | Warning1                      | Warning2                      | Warning3                      | Warning4                      | Warning5                      |
#		| USA  | I0036110961  | S      | BUITENWERF  MICHAE       | I0036110961 | IND  | MICHAEL BUITENWERF,       | 418 19TH ST SW         | ALTOONA 50009 IA | UNITED STATES OF AMERICA |                |          | 22         | 091408734 | 4521294381 | MICHAEL BUITENWERF       |                    |                 |               |               | OUTSTANDING PAYMENT           | Overseas domicile             | Payee instruction direct/bulk | Holder Extra/US Tax present   | Communication Methods Present |
		| AUS  | X0019091414  | S      | BULLUSS     ROBERT       | X0019091414 | IND  | MR ROBERT BULLUSS,        | 7 FINSBURY CLOSE       | ROWVILLE VIC     |                          |                |          | 10         | 083-214   | 19558733   | BULLUSS R                |                    |                 |               |               | Payee instruction direct/bulk | Holder Extra details present  | Communication Methods Present | No Annual Report              |                               |
		| GBR  | I0035337890  | S      | APPLEYARD   AVRIL V      | I0035337890 | IND  | MRS AVRIL V APPLEYARD     | 20 GRANGE PARK TERRACE | LEEDS            | WEST YORKSHIRE LS8 3BX   | UNITED KINGDOM |          | 30         | 05-00-65  | 10415411   | AVRIL VERONICA APPLEYARD | YORKSHIRE BANK PLC | 293 ROUNDHAY RD | LEEDS         |               | OUTSTANDING PAYMENT           | Overseas domicile             | Payee instruction direct/bulk | Holder Extra details present  | No Annual Report              |
#		| NZL  | I0030153839  | S      | BEGEJ       JEANNELORRAI | I0030153839 | STF  | MRS JEANNE LORRAINE BEGEJ | PO BOX 1022            | CHRISTCHURCH     | NEW ZEALAND              |                |          | 20         | 02-1235   | 14671-000  | BEGEJ J & JL             |                    |                 |               |               | Overseas domicile             | Payee instruction direct/bulk | Holder Extra details present  | Communication Methods Present | ESS Participant               |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case -Direct Credit -End to End
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	When In OLS01303 I Add Payee Instructions as "<TranNO>" "<InstructionType>" "<BSB1>" "<BSB2>" "<AccountNbr>" "<AccountName>" "<NZBank>" "<NZBranch>" "<NZAccountNbr>" "<NZSuffix>" "<SortCode1>" "<SortCode2>" "<SortCode3>" "<RoutingNbr>" "<AccountType>"
		And I PressESC
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Payee Details as "<BankSystem>" "<BSB>" "<AccountNbr>" "<AccountName>" "<PayeeAddress1>" "<PayeeAddress2>" "<PayeeAddress3>" "<PayeeAddress4>"
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	When In OLS01303 I Change Payee Instructions as "<ChangeModify>" "<NewTranNO>" "<InstructionType>" "<NewBSB1>" "<NewBSB2>" "<NewAccountNbr>" "<NewAccountName>" "<NewNZBank>" "<NewNZBranch>" "<NewNZAccountNbr>" "<NewNZSuffix>" "<NewSortCode1>" "<NewSortCode2>" "<NewSortCode3>" "<NewRoutingNbr>" "<NewAccountType>"
		And I PressESC	
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Payee Details as "<BankSystem>" "<NewBSB>" "<NewAccountNbr>" "<NewAccountName>" "<NewPayeeAddress1>" "<NewPayeeAddress2>" "<NewPayeeAddress3>" "<NewPayeeAddress4>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01303 I Delete Payee Instructions "<NewTranNO1>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then I should see the below ErrorMessage "There are no payee details for this holder"

Examples: 
		| Test  | UpdateOption | Action | TranNO | InstructionType | BSB1 | BSB2 | AccountNbr | AccountName              | BankSystem | BSB       | PayeeAddress1      | PayeeAddress2   | PayeeAddress3 | PayeeAddress4 | ChangeModify | NewTranNO | NewBSB1 | NewBSB2 | NewAccountNbr | NewAccountName    | NewBSB    | NewTranNO1 | NZBank | NZBranch | NZAccountNbr | NZSuffix | NewNZBank | NewNZBranch | NewNZAccountNbr | NewNZSuffix | SortCode1 | SortCode2 | SortCode3 | NewSortCode1 | NewSortCode2 | NewSortCode3 | RoutingNbr | AccountType | NewRoutingNbr | NewAccountType | NewPayeeAddress1               | NewPayeeAddress2        | NewPayeeAddress3       | NewPayeeAddress4 | Action1 | UpdateOption1 |
		| AUS-M | I0165168551  | S      | 10100  | A               | 062  | 192  | 343670     | AUTOMATION BANK ACCOUNT1 | 10         | 062-192   |                    |                 |               |               | M            | 10101     | 183     | 334     | 22067410      | NEW BANK ACCOUNT1 | 183-334   | 10102      |        |          |              |          |           |             |                 |             |           |           |           |              |              |              |            |             |               |                |                                |                         |                        |                  | U       | PI            |
		| AUS-C | I0030256514  | S      | 10200  | A               | 013  | 006  | 9901442    | AUTOMATION BANK ACCOUNT2 | 10         | 013-006   |                    |                 |               |               | C            | 10201     | 062     | 192     | 343670        | NEW BANK ACCOUNT2 | 062-192   | 10202      |        |          |              |          |           |             |                 |             |           |           |           |              |              |              |            |             |               |                |                                |                         |                        |                  | U       | PI            |
		| NZL-M | I0030297750  | S      | 10300  | N               |      |      | 14671-000  | AUTOMATION BANK ACCOUNT3 | 20         | 02-1235   |                    |                 |               |               | M            | 10301     |         |         | 4976-000      | NEW BANK ACCOUNT3 | 01-1839   | 10302      | 02     | 1235     | 14671        | 000      | 01        | 1839        | 4976            | 000         |           |           |           |              |              |              |            |             |               |                |                                |                         |                        |                  | U       | PI            |
		| NZL-C | X0025957083  | S      | 10400  | N               |      |      | 14671-000  | AUTOMATION BANK ACCOUNT4 | 20         | 02-1235   |                    |                 |               |               | C            | 10401     |         |         | 4976-000      | NEW BANK ACCOUNT4 | 01-1839   | 10402      | 02     | 1235     | 14671        | 000      | 01        | 1839        | 4976            | 000         |           |           |           |              |              |              |            |             |               |                |                                |                         |                        |                  | U       | PI            |
		| GBR-M | I0131736240  | S      | 10500  | G               |      |      | 10000400   | AUTOMATION BANK ACCOUNT5 | 30         | 05-00-65  | YORKSHIRE BANK PLC | 293 ROUNDHAY RD | LEEDS         |               | M            | 10501     |         |         | 10000401      | NEW BANK ACCOUNT5 | 16-08-88  | 10502      |        |          |              |          |           |             |                 |             | 05        | 00        | 65        | 16           | 08           | 88           |            |             |               |                | THE ROYAL BANK OF SCOTLAND PLC | P O BOX 966 CONSORT HSE | LOMBARD CENTRE EAST ST |                  | U       | PI            |
		| GBR-C | X0038768786  | S      | 10600  | G               |      |      | 10000400   | AUTOMATION BANK ACCOUNT6 | 30         | 05-00-65  | YORKSHIRE BANK PLC | 293 ROUNDHAY RD | LEEDS         |               | C            | 10601     |         |         | 10000401      | NEW BANK ACCOUNT6 | 16-08-88  | 10602      |        |          |              |          |           |             |                 |             | 05        | 00        | 65        | 16           | 08           | 88           |            |             |               |                | THE ROYAL BANK OF SCOTLAND PLC | P O BOX 966 CONSORT HSE | LOMBARD CENTRE EAST ST |                  | U       | PI            |
		| USA-M | X0037459194  | S      | 10700  | U               |      |      | 625991     | AUTOMATION BANK ACCOUNT7 | 22         | 011000536 |                    |                 |               |               | M            | 10701     |         |         | 11111111      | NEW BANK ACCOUNT7 | 011904315 | 10702      |        |          |              |          |           |             |                 |             |           |           |           |              |              |              | 011000536  | S           | 011904315     | C              |                                |                         |                        |                  | U       | PI            |
		| USA-C | I0030559762  | S      | 10800  | U               |      |      | 625991     | AUTOMATION BANK ACCOUNT8 | 22         | 011000536 |                    |                 |               |               | C            | 10801     |         |         | 11111111      | NEW BANK ACCOUNT7 | 011904315 | 10802      |        |          |              |          |           |             |                 |             |           |           |           |              |              |              | 011000536  | C           | 011904315     | S              |                                |                         |                        |                  | U       | PI            |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@17504
Scenario Outline: Test Case 17504: 01 - Payee Action : Third Party Type - Add, Change/Modify & Delete
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"		
	When In OLS01301 I Add Third Party Payee Instructions as "<TranNO>" "<InstructionType>" "<PayeeeAddress1>" "<PayeeeAddress2>" "<PayeeeAddress3>" "<PayeeeAddress4>" "<PayeeeAddress5>" "<PayeeeAddress6>" "<PayeePostcode>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Holder Payee Details as "<PayeeeAddress1>" "<PayeeeAddress2>" "<PayeeeAddress3>" "<PayeeeAddress4>" "<PayeeeAddress5>" "<PayeeeAddress6>" "<PayeePostcode>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"	
		And In OLS01301 I Change Third Party Payee Instructions as "<ChangeModify>" "<NewTranNO>" "<InstructionType>" "<NewPayeeeAddress1>" "<NewPayeeeAddress2>" "<NewPayeeeAddress3>" "<NewPayeeeAddress4>" "<NewPayeeeAddress5>" "<NewPayeeeAddress6>" "<NewPayeePostcode>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Holder Payee Details as "<NewPayeeeAddress1>" "<NewPayeeeAddress2>" "<NewPayeeeAddress3>" "<NewPayeeeAddress4>" "<NewPayeeeAddress5>" "<NewPayeeeAddress6>" "<NewPayeePostcode>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01303 I Delete Payee Instructions "<NewTranNO1>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then I should see the below ErrorMessage "There are no payee details for this holder"


Examples: 
		| UpdateOption | Action | Action1 | UpdateOption1 | TranNO | InstructionType | PayeeeAddress1   | PayeeeAddress2       | PayeeeAddress3       | PayeeeAddress4       | PayeeeAddress5 | PayeeeAddress6 | PayeePostcode | ChangeModify | NewTranNO | NewPayeeeAddress1 | NewPayeeeAddress2     | NewPayeeeAddress3     | NewPayeeeAddress4     | NewPayeeeAddress5 | NewPayeeeAddress6 | NewPayeePostcode | NewTranNO1 |
		| I0132235031  | S      | U       | PI            | 10900  | P               | TEST AUTOMATION  | 425 JOHNSTONE STREET | 426 JOHNSTONE STREET | 427 JOHNSTONE STREET | ABBORTSFORD    | VIC            | 3000          | M            | 10901     | TEST AUTOMATION1  | 426 JOHNSTONE STREET1 | 427 JOHNSTONE STREET1 | 428 JOHNSTONE STREET1 | ABBORTSFORD       | VIC               | 3210             | 10902      |
		| X0008462771  | S      | U       | PI            | 11100  | P               | TEST AUTOMATION1 | 425 JOHNSTONE STREET | 426 JOHNSTONE STREET | 427 JOHNSTONE STREET | ABBORTSFORD    | UNITED STATES  | USA           | C            | 11101     | TEST AUTOMATION2  | 426 JOHNSTONE STREET2 | 427 JOHNSTONE STREET2 | 428 JOHNSTONE STREET2 | ABBORTSFORD       | UNITED STATES     | USA              | 11102      |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@17819
Scenario Outline: Test Case 17819: 02 - Payee Action : Bulk Payment Type - Add, Change/Modify & Delete
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"		
	When In OLS01301 I Add Bulk Payment Instructions as "<TranNO>" "<InstructionType>" "<BankSystem>" "<AccountName>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Holder Bulk Payment Instructions as "<BankSystem>" "<AccountName>" "<PayeeAddress>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"	
		And In OLS01301 I Change Bulk Payment Instructions as "<ChangeModify>" "<NewTranNO>" "<InstructionType>" "<NewBankSystem>" "<NewAccountName>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Holder Bulk Payment Instructions as "<NewBankSystem>" "<NewAccountName>" "<PayeeAddress>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01303 I Delete Payee Instructions "<NewTranNO1>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then I should see the below ErrorMessage "There are no payee details for this holder"

Examples: 
		| UpdateOption | Action | Action1 | UpdateOption1 | TranNO | InstructionType | ChangeModify | NewTranNO | NewTranNO1 | BankSystem | AccountName      | NewBankSystem | NewAccountName   | PayeeAddress              |
		| I0132235031  | S      | U       | PI            | 11200  | B               | M            | 11201     | 11202      | 45         | TEST AUTOMATION1 | 99            | TEST AUTOMATION2 | **     BANK UNKNOWN    ** |
		| X0009219722  | S      | U       | PI            | 11300  | B               | C            | 11301     | 11302      | 45         | TEST AUTOMATION2 | 99            | TEST AUTOMATION3 | **     BANK UNKNOWN    ** |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@17820
Scenario Outline: Test Case 17820: 03 - Payee Action : Foreign Cheque Type - Add, Change/Modify & Delete
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	When In OLS01301 I Add Foreign Cheque Instructions as "<TranNO>" "<InstructionType>" "<Currency>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Holder Warnings as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"	
		And In OLS01301 I Change Foreign Cheque Instructions as "<ChangeModify>" "<NewTranNO>" "<InstructionType>" "<NewCurrency>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then In OLS01103 I should see Holder Warnings as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01303 I Delete Payee Instructions "<NewTranNO1>"
		And In OLS01101 I enter following details as the update option as below:
			| Field        | Value |
			| Action       | P     |
			| UpdateOption |       |
	Then I should see the below ErrorMessage "There are no payee details for this holder"


Examples: 
		| UpdateOption | Action | Action1 | UpdateOption1 | TranNO | InstructionType | ChangeModify | NewTranNO | NewTranNO1 | Currency | NewCurrency | Warning1                       | Warning2                       | Warning3          | Warning4          | Warning5         |
		| I0030414730  | S      | U       | PI            | 11400  | F               | M            | 11401     | 11402      | GBP      | USD         | Payee Instruction: Foreign Chq | Holder Extra details present   | No DPID allocated | No Annual Report  |                  |
#		| I0030405625  | S      | U       | PI            | 11500  | F               | M            | 11501     | 11502      | EUR      | CAD         | Unconfirmed Deceased           | Payee Instruction: Foreign Chq | Noting:D1         | No DPID allocated | No Annual Report |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@18296
#Scenario Outline: Test Case 18296: 04 - Free format notings (N1- N5) - Add, Change , Delete and Display
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	When In OLS01404 I Add Noting Details as "<TranNO>" "<Comment>" "<NotingLine1>" "<NotingLine2>" "<NotingLine3>" "<NotingLine4>" "<NotingLine5>" "<NotingLine6>" "<NotingLine7>" "<NotingLine8>" 
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#		And In OLS01101 I enter following details as the update option "<UpdateOption1>" "<Action2>" 
#	Then In OLS01113 I should see Noting details as "<NotingNbr>" "<UpdateOption>" "<Comment>" "<NotingLine1>" "<NotingLine2>" "<NotingLine3>" "<NotingLine4>" "<NotingLine5>" "<NotingLine6>" "<NotingLine7>" "<NotingLine8>" 
#	When I PressESC
#		And I PressESC
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	When In OLS01404 I Change Noting Details as "<NewTranNO>" "<NewComment>" "<NewNotingLine1>" "<NewNotingLine2>" "<NewNotingLine3>" "<NewNotingLine4>" "<NewNotingLine5>" "<NewNotingLine6>" "<NewNotingLine7>" "<NewNotingLine8>" 
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#		And In OLS01101 I enter following details as the update option "<UpdateOption1>" "<Action2>" 
#	Then In OLS01113 I should see Noting details as "<NotingNbr>" "<UpdateOption>" "<NewComment>" "<NewNotingLine1>" "<NewNotingLine2>" "<NewNotingLine3>" "<NewNotingLine4>" "<NewNotingLine5>" "<NewNotingLine6>" "<NewNotingLine7>" "<NewNotingLine8>" 
#	When I PressESC
#		And I PressESC
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"					
#	When In OLS01404 I Delete Noting Details as "<NewTranNO1>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#	Then I should see the below ErrorMessage "There are no notings present for this holder"
#
#Examples: 
#		| UpdateOption1 | Action | Action1 | UpdateOption | TranNO | Comment                                            | NotingLine1                    | NotingLine2                    | NotingLine3                    | NotingLine4                    | NotingLine5                    | NotingLine6                    | NotingLine7                    | NotingLine8                    | Action2 | NotingNbr | NewTranNO | NewComment                                     | NewNotingLine1                     | NewNotingLine2                     | NewNotingLine3                     | NewNotingLine4                     | NewNotingLine5                     | NewNotingLine6                     | NewNotingLine7                     | NewNotingLine8                     | NewTranNO1 |
#		| N1            | S      | U       | I0010426324  | 13600  | TESTING THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 | SCRIP PORT TO LINUX.TEST LINE2 | SCRIP PORT TO LINUX.TEST LINE3 | SCRIP PORT TO LINUX.TEST LINE4 | SCRIP PORT TO LINUX.TEST LINE5 | SCRIP PORT TO LINUX.TEST LINE6 | SCRIP PORT TO LINUX.TEST LINE7 | SCRIP PORT TO LINUX.TEST LINE8 |         | 1         | 13601     | NEW THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 NEW | SCRIP PORT TO LINUX.TEST LINE2 NEW | SCRIP PORT TO LINUX.TEST LINE3 NEW | SCRIP PORT TO LINUX.TEST LINE4 NEW | SCRIP PORT TO LINUX.TEST LINE5 NEW | SCRIP PORT TO LINUX.TEST LINE6 NEW | SCRIP PORT TO LINUX.TEST LINE7 NEW | SCRIP PORT TO LINUX.TEST LINE8 NEW | 13602      |
#		| N2            | S      | U       | I0010426324  | 13700  | TESTING THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 | SCRIP PORT TO LINUX.TEST LINE2 | SCRIP PORT TO LINUX.TEST LINE3 | SCRIP PORT TO LINUX.TEST LINE4 | SCRIP PORT TO LINUX.TEST LINE5 | SCRIP PORT TO LINUX.TEST LINE6 | SCRIP PORT TO LINUX.TEST LINE7 | SCRIP PORT TO LINUX.TEST LINE8 |         | 2         | 13701     | NEW THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 NEW | SCRIP PORT TO LINUX.TEST LINE2 NEW | SCRIP PORT TO LINUX.TEST LINE3 NEW | SCRIP PORT TO LINUX.TEST LINE4 NEW | SCRIP PORT TO LINUX.TEST LINE5 NEW | SCRIP PORT TO LINUX.TEST LINE6 NEW | SCRIP PORT TO LINUX.TEST LINE7 NEW | SCRIP PORT TO LINUX.TEST LINE8 NEW | 13702      |
#		| N3            | S      | U       | I0010426324  | 13800  | TESTING THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 | SCRIP PORT TO LINUX.TEST LINE2 | SCRIP PORT TO LINUX.TEST LINE3 | SCRIP PORT TO LINUX.TEST LINE4 | SCRIP PORT TO LINUX.TEST LINE5 | SCRIP PORT TO LINUX.TEST LINE6 | SCRIP PORT TO LINUX.TEST LINE7 | SCRIP PORT TO LINUX.TEST LINE8 |         | 3         | 13801     | NEW THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 NEW | SCRIP PORT TO LINUX.TEST LINE2 NEW | SCRIP PORT TO LINUX.TEST LINE3 NEW | SCRIP PORT TO LINUX.TEST LINE4 NEW | SCRIP PORT TO LINUX.TEST LINE5 NEW | SCRIP PORT TO LINUX.TEST LINE6 NEW | SCRIP PORT TO LINUX.TEST LINE7 NEW | SCRIP PORT TO LINUX.TEST LINE8 NEW | 13802      |
#		| N4            | S      | U       | I0010426324  | 13900  | TESTING THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 | SCRIP PORT TO LINUX.TEST LINE2 | SCRIP PORT TO LINUX.TEST LINE3 | SCRIP PORT TO LINUX.TEST LINE4 | SCRIP PORT TO LINUX.TEST LINE5 | SCRIP PORT TO LINUX.TEST LINE6 | SCRIP PORT TO LINUX.TEST LINE7 | SCRIP PORT TO LINUX.TEST LINE8 |         | 4         | 13901     | NEW THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 NEW | SCRIP PORT TO LINUX.TEST LINE2 NEW | SCRIP PORT TO LINUX.TEST LINE3 NEW | SCRIP PORT TO LINUX.TEST LINE4 NEW | SCRIP PORT TO LINUX.TEST LINE5 NEW | SCRIP PORT TO LINUX.TEST LINE6 NEW | SCRIP PORT TO LINUX.TEST LINE7 NEW | SCRIP PORT TO LINUX.TEST LINE8 NEW | 13902      |
#		| N5            | S      | U       | I0010426324  | 14100  | TESTING THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 | SCRIP PORT TO LINUX.TEST LINE2 | SCRIP PORT TO LINUX.TEST LINE3 | SCRIP PORT TO LINUX.TEST LINE4 | SCRIP PORT TO LINUX.TEST LINE5 | SCRIP PORT TO LINUX.TEST LINE6 | SCRIP PORT TO LINUX.TEST LINE7 | SCRIP PORT TO LINUX.TEST LINE8 |         | 5         | 14101     | NEW THE NOTING N1 FOR LINUX REGRESSION TESTING | SCRIP PORT TO LINUX.TEST LINE1 NEW | SCRIP PORT TO LINUX.TEST LINE2 NEW | SCRIP PORT TO LINUX.TEST LINE3 NEW | SCRIP PORT TO LINUX.TEST LINE4 NEW | SCRIP PORT TO LINUX.TEST LINE5 NEW | SCRIP PORT TO LINUX.TEST LINE6 NEW | SCRIP PORT TO LINUX.TEST LINE7 NEW | SCRIP PORT TO LINUX.TEST LINE8 NEW | 14102      |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@18494
#Scenario Outline: Test Case 18494: 04- Deceased Estate notings (D1-D5) - Add, Change ,Delete and Display
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	When In OLS01403 I Add Deceased Estate Noting Details Part1 as "<TranNO>" "<Register>" "<DeceasedName>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<WillSightedDate>" "<SmallEstate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>" "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>"
#		And In OLS01403 I Add Deceased Estate Noting Details Part2 as "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#		And In OLS01101 I enter following details as the update option "<UpdateOption1>" "<Action2>" 
#	Then In OLS01112 I should see Deceased Estate Noting details as "<DeceasedName>" "<DateOfDeath>" "<ProbateGrantedIn>" "<ProbateGrantedOn>" "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Executor1>" "<Executor2>" "<Executor3>" "<DeathCertSighted>" "<WillDated>" "<WillSightedDate>" "<SmallEstate>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#	When I PressESC
#		And I PressESC
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	When In OLS01403 I Change Deceased Estate Noting Details Part1 as "<NewTranNO>" "<NewRegister>" "<NewDeceasedName>" "<NewDateOfDeath>" "<NewDeathCertSighted>" "<NewWillDated>" "<NewWillSightedDate>" "<NewSmallEstate>" "<NewProbateGrantedIn>" "<NewProbateGrantedOn>" "<NewProbateightedDate>" "<NewReSealedIn>" "<NewReSealedOn>" "<NewSec183>" "<NewSec121A>" "<NewConfirmationID>"
#		And In OLS01403 I Change Deceased Estate Noting Details Part2 as "<NewExecutor1>" "<NewExecutor2>" "<NewExecutor3>" "<NewComment1>" "<NewComment2>" "<NewComment3>" "<NewLodged>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#		And In OLS01101 I enter following details as the update option "<UpdateOption1>" "<Action2>" 
#	Then In OLS01112 I should see Deceased Estate Noting details as "<NewDeceasedName>" "<NewDateOfDeath>" "<NewProbateGrantedIn>" "<NewProbateGrantedOn>" "<NewProbateightedDate>" "<NewReSealedIn>" "<NewReSealedOn>" "<NewSec183>" "<NewExecutor1>" "<NewExecutor2>" "<NewExecutor3>" "<NewDeathCertSighted>" "<NewWillDated>" "<NewWillSightedDate>" "<NewSmallEstate>" "<NewComment1>" "<NewComment2>" "<NewComment3>" "<NewLodged>"
#	When I PressESC
#		And I PressESC
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"					
#	When In OLS01403 I Delete Deceased Estate Noting Details as "<NewTranNO1>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#	Then I should see the below ErrorMessage "There are no notings present for this holder"
#
#
#Examples: 
#		| UpdateOption1 | Action | Action1 | UpdateOption | TranNO | Register | DeceasedName          | DateOfDeath | DeathCertSighted | WillDated | WillSightedDate | SmallEstate | ProbateGrantedIn | ProbateGrantedOn | ProbateightedDate | ReSealedIn | ReSealedOn | Sec183   | Sec121A | ConfirmationID | Executor1   | Executor2   | Executor3   | Comment1                    | Comment2                    | Comment3                    | Lodged                      | Action2 | NewTranNO | NewRegister | NewDeceasedName           | NewDateOfDeath | NewDeathCertSighted | NewWillDated | NewWillSightedDate | NewSmallEstate | NewProbateGrantedIn | NewProbateGrantedOn | NewProbateightedDate | NewReSealedIn | NewReSealedOn | NewSec183 | NewSec121A | NewConfirmationID | NewExecutor1    | NewExecutor2    | NewExecutor3    | NewComment1                     | NewComment2                     | NewComment3                     | NewLodged                       | NewTranNO1 |
#		| D1            | S      | U       | I0010426324  | 14200  | VIC      | TEST ECEANSED NAME D1 | 10/10/99    | 10/10/99         | 10/10/99  | 10/10/99        | N           | TEST             | 10/10/99         | 10/10/99          | TEST       | 10/10/99   | 10/10/99 | N       | Y              | EXECUTOR D1 | EXECUTOR D1 | EXECUTOR D1 | TESITNG THE COMMENTS FOR D1 | TESITNG THE COMMENTS FOR D1 | TESITNG THE COMMENTS FOR D1 | TESITNG THE COMMENTS FOR D1 |         | 14201     | VIC         | TEST ECEANSED NAME D1 NEW | 10/10/00       | 10/10/00            | 10/10/00     | 10/10/00           | N              | TEST NEW            | 10/10/00            | 10/10/00             | TEST NEW      | 10/10/00      | 10/10/00  | N          | Y                 | EXECUTOR D1 NEW | EXECUTOR D1 NEW | EXECUTOR D1 NEW | TESITNG THE COMMENTS FOR D1 NEW | TESITNG THE COMMENTS FOR D1 NEW | TESITNG THE COMMENTS FOR D1 NEW | TESITNG THE COMMENTS FOR D1 NEW | 14202      |
#		| D2            | S      | U       | I0010426324  | 14300  | VIC      | TEST ECEANSED NAME D2 | 10/10/99    | 10/10/99         | 10/10/99  | 10/10/99        | N           | TEST             | 10/10/99         | 10/10/99          | TEST       | 10/10/99   | 10/10/99 | N       | Y              | EXECUTOR D2 | EXECUTOR D2 | EXECUTOR D2 | TESITNG THE COMMENTS FOR D2 | TESITNG THE COMMENTS FOR D2 | TESITNG THE COMMENTS FOR D2 | TESITNG THE COMMENTS FOR D2 |         | 14301     | VIC         | TEST ECEANSED NAME D2 NEW | 10/10/00       | 10/10/00            | 10/10/00     | 10/10/00           | N              | TEST NEW            | 10/10/00            | 10/10/00             | TEST NEW      | 10/10/00      | 10/10/00  | N          | Y                 | EXECUTOR D2 NEW | EXECUTOR D2 NEW | EXECUTOR D2 NEW | TESITNG THE COMMENTS FOR D2 NEW | TESITNG THE COMMENTS FOR D2 NEW | TESITNG THE COMMENTS FOR D2 NEW | TESITNG THE COMMENTS FOR D2 NEW | 14302      |
#		| D3            | S      | U       | I0010426324  | 14400  | VIC      | TEST ECEANSED NAME D3 | 10/10/99    | 10/10/99         | 10/10/99  | 10/10/99        | N           | TEST             | 10/10/99         | 10/10/99          | TEST       | 10/10/99   | 10/10/99 | N       | Y              | EXECUTOR D3 | EXECUTOR D3 | EXECUTOR D3 | TESITNG THE COMMENTS FOR D3 | TESITNG THE COMMENTS FOR D3 | TESITNG THE COMMENTS FOR D3 | TESITNG THE COMMENTS FOR D3 |         | 14401     | VIC         | TEST ECEANSED NAME D3 NEW | 10/10/00       | 10/10/00            | 10/10/00     | 10/10/00           | N              | TEST NEW            | 10/10/00            | 10/10/00             | TEST NEW      | 10/10/00      | 10/10/00  | N          | Y                 | EXECUTOR D3 NEW | EXECUTOR D3 NEW | EXECUTOR D3 NEW | TESITNG THE COMMENTS FOR D3 NEW | TESITNG THE COMMENTS FOR D3 NEW | TESITNG THE COMMENTS FOR D3 NEW | TESITNG THE COMMENTS FOR D3 NEW | 14402      |
#		| D4            | S      | U       | I0010426324  | 14500  | VIC      | TEST ECEANSED NAME D4 | 10/10/99    | 10/10/99         | 10/10/99  | 10/10/99        | N           | TEST             | 10/10/99         | 10/10/99          | TEST       | 10/10/99   | 10/10/99 | N       | Y              | EXECUTOR D4 | EXECUTOR D4 | EXECUTOR D4 | TESITNG THE COMMENTS FOR D4 | TESITNG THE COMMENTS FOR D4 | TESITNG THE COMMENTS FOR D4 | TESITNG THE COMMENTS FOR D4 |         | 14501     | VIC         | TEST ECEANSED NAME D4 NEW | 10/10/00       | 10/10/00            | 10/10/00     | 10/10/00           | N              | TEST NEW            | 10/10/00            | 10/10/00             | TEST NEW      | 10/10/00      | 10/10/00  | N          | Y                 | EXECUTOR D4 NEW | EXECUTOR D4 NEW | EXECUTOR D4 NEW | TESITNG THE COMMENTS FOR D4 NEW | TESITNG THE COMMENTS FOR D4 NEW | TESITNG THE COMMENTS FOR D4 NEW | TESITNG THE COMMENTS FOR D4 NEW | 14502      |
#		| D5            | S      | U       | I0010426324  | 14600  | VIC      | TEST ECEANSED NAME D5 | 10/10/99    | 10/10/99         | 10/10/99  | 10/10/99        | N           | TEST             | 10/10/99         | 10/10/99          | TEST       | 10/10/99   | 10/10/99 | N       | Y              | EXECUTOR D5 | EXECUTOR D5 | EXECUTOR D5 | TESITNG THE COMMENTS FOR D5 | TESITNG THE COMMENTS FOR D5 | TESITNG THE COMMENTS FOR D5 | TESITNG THE COMMENTS FOR D5 |         | 14601     | VIC         | TEST ECEANSED NAME D5 NEW | 10/10/00       | 10/10/00            | 10/10/00     | 10/10/00           | N              | TEST NEW            | 10/10/00            | 10/10/00             | TEST NEW      | 10/10/00      | 10/10/00  | N          | Y                 | EXECUTOR D5 NEW | EXECUTOR D5 NEW | EXECUTOR D5 NEW | TESITNG THE COMMENTS FOR D5 NEW | TESITNG THE COMMENTS FOR D5 NEW | TESITNG THE COMMENTS FOR D5 NEW | TESITNG THE COMMENTS FOR D5 NEW | 14602      |


#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@18378
#Scenario Outline: Test Case 18378: 02 - Power of Attorney(P1-P3) - Add, Change ,Delete and Display
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	When In OLS01401 I Add Power of Attorney Noting Details Part1 as "<TranNO>" "<Register1>" "<Register2>" "<Donorname1>" "<Donorname2>" "<Attorneys1>" "<Attorneys2>" "<Attorneys3>" "<Attorneys4>" "<Attorneys5>" "<Powerdated>" "<PowerNoted>" "<Jointly>" "<Severally>" "<AnyTwo>" "<Other1>" "<Other2>"
#		And In OLS01401 I Add Power of Attorney Noting Details Part2 as "<Buy>" "<Sell>" "<Vote>" "<AppointSubstitute>" "<StampedIn>" "<Comment1>" "<Comment2>" "<LodgedBy>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#		And In OLS01101 I enter following details as the update option "<UpdateOption1>" "<Action2>" 
#	Then In OLS01110 I should see Power of Attorney Noting details Part1 as "<Donorname1>" "<Donorname2>" "<Attorneys1>" "<Attorneys2>" "<Attorneys3>" "<Attorneys4>" "<Attorneys5>" "<Powerdated>" "<PowerNoted>" "<Jointly>" "<Severally>" "<AnyTwo>" "<Other1>" "<Other2>"
#		And In OLS01110 I should see Power of Attorney Noting details Part2 as "<Buy>" "<Sell>" "<Vote>" "<AppointSubstitute>" "<StampedIn>" "<Comment1>" "<Comment2>" "<LodgedBy>"
#	When I PressESC
#		And I PressESC
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	When In OLS01401 I Change Power of Attorney Noting Details Part1 as "<NewTranNO>" "<NewRegister1>" "<NewRegister2>" "<NewDonorname1>" "<NewDonorname2>" "<NewAttorneys1>" "<NewAttorneys2>" "<NewAttorneys3>" "<NewAttorneys4>" "<NewAttorneys5>" "<NewPowerdated>" "<NewPowerNoted>" "<NewJointly>" "<NewSeverally>" "<NewAnyTwo>" "<NewOther1>" "<NewOther2>"
#		And In OLS01401 I Change Power of Attorney Noting Details Part2 as "<NewBuy>" "<NewSell>" "<NewVote>" "<NewAppointSubstitute>" "<NewStampedIn>" "<NewComment1>" "<NewComment2>" "<NewLodgedBy>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#		And In OLS01101 I enter following details as the update option "<UpdateOption1>" "<Action2>" 
#	Then In OLS01110 I should see Power of Attorney Noting details Part1 as "<NewDonorname1>" "<NewDonorname2>" "<NewAttorneys1>" "<NewAttorneys2>" "<NewAttorneys3>" "<NewAttorneys4>" "<NewAttorneys5>" "<NewPowerdated>" "<NewPowerNoted>" "<NewJointly>" "<NewSeverally>" "<NewAnyTwo>" "<NewOther1>" "<NewOther2>"
#		And In OLS01110 I should see Power of Attorney Noting details Part2 as "<NewBuy>" "<NewSell>" "<NewVote>" "<NewAppointSubstitute>" "<NewStampedIn>" "<NewComment1>" "<NewComment2>" "<NewLodgedBy>"
#	When I PressESC
#		And I PressESC
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"					
#	When In OLS01401 I Delete Power of Attorney Noting Details as "<NewTranNO1>"
#		And In OLS01101 I enter following details as the update option as below:
#			| Field        | Value |
#			| Action       | N     |
#			| UpdateOption |       |
#	Then I should see the below ErrorMessage "There are no notings present for this holder"
#
#Examples: 
#		| UpdateOption1 | Action | Action1 | UpdateOption | TranNO | Register1 | Register2 | Donorname1   | Donorname2   | Attorneys1            | Attorneys2            | Attorneys3            | Attorneys4            | Attorneys5            | Powerdated | PowerNoted | Jointly | Severally | AnyTwo | Other1                                      | Other2                                      | Buy | Sell | Vote | AppointSubstitute | StampedIn     | Comment1                                   | Comment2                               | LodgedBy                  | Action2 | NewTranNO | NewRegister1 | NewRegister2 | NewDonorname1    | NewDonorname2    | NewAttorneys1             | NewAttorneys2             | NewAttorneys3             | NewAttorneys4             | NewAttorneys5             | NewPowerdated | NewPowerNoted | NewJointly | NewSeverally | NewAnyTwo | NewOther1                                       | NewOther2                                       | NewBuy | NewSell | NewVote | NewAppointSubstitute | NewStampedIn      | NewComment1                                    | NewComment2                                | NewLodgedBy                   | NewTranNO1 |
#		| P1            | S      | U       | I0010426324  | 14700  | VIC       |           | TEST DONOR 1 | TEST DONOR 2 | ATTORNEYS LINE 1 TEST | ATTORNEYS LINE 2 TEST | ATTORNEYS LINE 3 TEST | ATTORNEYS LINE 4 TEST | ATTORNEYS LINE 5 TEST | 01/01/80   | 01/01/80   | N       | N         | N      | TESTING OTHER FILED TO MAXIMUM VALUES LINE1 | TESTING OTHER FILED TO MAXIMUM VALUES LINE2 | Y   | Y    | Y    | Y                 | TESTING OTHER | TESTIN GTHE COMMENT FIELD OF THE P1 LINE 1 | TESTING THE COMMENT FIELD OF P1 LINE 2 | TESTING FOR THE BLUE TEAM |         | 14701     | VIC          |              | NEW TEST DONOR 1 | NEW TEST DONOR 2 | NEW ATTORNEYS LINE 1 TEST | NEW ATTORNEYS LINE 2 TEST | NEW ATTORNEYS LINE 3 TEST | NEW ATTORNEYS LINE 4 TEST | NEW ATTORNEYS LINE 5 TEST | 01/01/81      | 01/01/81      | N          | N            | N         | NEW TESTING OTHER FILED TO MAXIMUM VALUES LINE1 | NEW TESTING OTHER FILED TO MAXIMUM VALUES LINE2 | Y      | Y       | Y       | Y                    | NEW TESTING OTHER | NEW TESTIN GTHE COMMENT FIELD OF THE P1 LINE 1 | NEW TESTING THE COMMENT FIELD OF P1 LINE 2 | NEW TESTING FOR THE BLUE TEAM | 14702      |
#		| P2            | S      | U       | I0010426324  | 14800  | VIC       |           | TEST DONOR 1 | TEST DONOR 2 | ATTORNEYS LINE 1 TEST | ATTORNEYS LINE 2 TEST | ATTORNEYS LINE 3 TEST | ATTORNEYS LINE 4 TEST | ATTORNEYS LINE 5 TEST | 01/01/80   | 01/01/80   | N       | N         | N      | TESTING OTHER FILED TO MAXIMUM VALUES LINE1 | TESTING OTHER FILED TO MAXIMUM VALUES LINE2 | Y   | Y    | Y    | Y                 | TESTING OTHER | TESTIN GTHE COMMENT FIELD OF THE P1 LINE 1 | TESTING THE COMMENT FIELD OF P1 LINE 2 | TESTING FOR THE BLUE TEAM |         | 14801     | VIC          |              | NEW TEST DONOR 1 | NEW TEST DONOR 2 | NEW ATTORNEYS LINE 1 TEST | NEW ATTORNEYS LINE 2 TEST | NEW ATTORNEYS LINE 3 TEST | NEW ATTORNEYS LINE 4 TEST | NEW ATTORNEYS LINE 5 TEST | 01/01/81      | 01/01/81      | N          | N            | N         | NEW TESTING OTHER FILED TO MAXIMUM VALUES LINE1 | NEW TESTING OTHER FILED TO MAXIMUM VALUES LINE2 | Y      | Y       | Y       | Y                    | NEW TESTING OTHER | NEW TESTIN GTHE COMMENT FIELD OF THE P1 LINE 1 | NEW TESTING THE COMMENT FIELD OF P1 LINE 2 | NEW TESTING FOR THE BLUE TEAM | 14802      |
#		| P3            | S      | U       | I0010426324  | 14900  | VIC       |           | TEST DONOR 1 | TEST DONOR 2 | ATTORNEYS LINE 1 TEST | ATTORNEYS LINE 2 TEST | ATTORNEYS LINE 3 TEST | ATTORNEYS LINE 4 TEST | ATTORNEYS LINE 5 TEST | 01/01/80   | 01/01/80   | N       | N         | N      | TESTING OTHER FILED TO MAXIMUM VALUES LINE1 | TESTING OTHER FILED TO MAXIMUM VALUES LINE2 | Y   | Y    | Y    | Y                 | TESTING OTHER | TESTIN GTHE COMMENT FIELD OF THE P1 LINE 1 | TESTING THE COMMENT FIELD OF P1 LINE 2 | TESTING FOR THE BLUE TEAM |         | 14901     | VIC          |              | NEW TEST DONOR 1 | NEW TEST DONOR 2 | NEW ATTORNEYS LINE 1 TEST | NEW ATTORNEYS LINE 2 TEST | NEW ATTORNEYS LINE 3 TEST | NEW ATTORNEYS LINE 4 TEST | NEW ATTORNEYS LINE 5 TEST | 01/01/81      | 01/01/81      | N          | N            | N         | NEW TESTING OTHER FILED TO MAXIMUM VALUES LINE1 | NEW TESTING OTHER FILED TO MAXIMUM VALUES LINE2 | Y      | Y       | Y       | Y                    | NEW TESTING OTHER | NEW TESTIN GTHE COMMENT FIELD OF THE P1 LINE 1 | NEW TESTING THE COMMENT FIELD OF P1 LINE 2 | NEW TESTING FOR THE BLUE TEAM | 14902      |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@18305
Scenario Outline: Test Case 18305: 05 - Free format noting (N1-N5) Update noting with no data change
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	When In OLS01404 I Change Noting as "<NewTranNO>"
	Then I should see the below ErrorMessage "Warning : No changes made to record."

Examples: 
		| UpdateOption1 | Action | Action1 | UpdateOption | NewTranNO |
		| N1            | S      | U       | I0010425832  | 15000     |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@18256
Scenario Outline: Test Case 18256: 03- Display Noting - Holder with N1-N5 Notings
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	Then In OLS01104 I should see Notings Display menu as "<P1>" "<P2>" "<P3>" "<D1>" "<D2>" "<D3>" "<D4>" "<D5>" "<N1>" "<N2>" "<N3>" "<N4>" "<N5>"

		       
Examples: 
		| Action1 | UpdateOption1 | Action | UpdateOption | P1                        | P2                        | P3                        | D1                             | D2                             | D3                             | D4                             | D5                             | N1                         | N2                         | N3                         | N4                         | N5                         |
		| N       |               | S      | I0010425832  | P1. Power of Attorney (1) | P2. Power of Attorney (2) | P3. Power of Attorney (3) | D1. Deceased Estate noting (1) | D2. Deceased Estate noting (2) | D3. Deceased Estate noting (3) | D4. Deceased Estate noting (4) | D5. Deceased Estate noting (5) | N1. Free format noting (1) | N2. Free format noting (2) | N3. Free format noting (3) | N4. Free format noting (4) | N5. Free format noting (5) |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@18496
Scenario Outline: Test Case 18496: 05 - Deceased Estate noting  - Update D1 noting with no data change
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01403 I change Deceased Estate Noting TranNo as "<Tran>"
	Then I should see the below ErrorMessage "Warning : No changes made to record."
Examples: 
		| Action | UpdateOption | Action1 | UpdateOption1 | Tran  |
		| S      | I0010425832  | U       | D1            | 30100 |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@18419
Scenario Outline: Test Case 18419: 04 - Power of Attorney - Update P1 noting with no data change
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01401 I change Power of Attorney Noting TranNo as "<Tran>"
	Then I should see the below ErrorMessage "Warning : No changes made to record."
Examples: 
		| Action | UpdateOption | Action1 | UpdateOption1 | Tran  |
		| S      | I0010425832  | U       | P1            | 30200 |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@18503
Scenario Outline: Test Case 18503: 01 - Display Noting - Holder without any Notings
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	Then I should see the below ErrorMessage "There are no notings present for this holder"
Examples: 
		| Action | UpdateOption | Action1 | UpdateOption1 |
		| S      | X0046311183  | N       |               |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18342
Scenario Outline: Test Case 18342: 01 - Add Holder with different Holder Types
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01202 I enter Holder details as "<HIN>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
	When I PressESC
		And OLS01101 I Search the Holder as "<HIN>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"


Examples: 
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name                          | Address1                     | Address2                    | Address3                    | Address4                    | Address5          | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key                            | DPID     | Register | Warning1                       | Warning2                       | Warning3                       | Warning4           | Warning5 | AReport |
		| I0180005285 | U      | AH           | CNT  | 6001     |         |       |          | 59999      |             |             | DIRECT CREDIT                 | CONTROL HOLDER               | C/- COMPUTERSHARE LIMITED   | PO BOX 103                  | ABBOTSFORD                  | VIC 3067          | N        |           | N        |         | A (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | CREDIT      DIRECT             |          |          | Nil holding on trading classes | Full Annual Report             |                                |                    |          | A       |
		| I0030242084 | U      | AH           | IND  | 5400     |         |       |          | 59999      |             |             | MR ANTHONY ABELA              | 13 ZAMBESI ROAD              | SEVEN HILLS                 | BOULIVARD                   | NSW                         | AUSTRALIA         | N        |           | N        |         | R (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | ABELA       ANTHON             |          |          | ** LIKE HOLDER PRESENT **      | Nil holding on trading classes | No DPID allocated              | Shareholder Review |          | R       |
		| I0035948449 | U      | AH           | JNT  | 5073     |         |       |          | 59999      |             |             | MR TEST BANSEMER +            | MRS TEST BANSEMER,           | 7 COURTABIE AVENUE          | ROSTREVOR SA                |                             |                   | N        |           | N        |         | A (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | BANSEMER    TEST               | 56416019 |          | Nil holding on trading classes | Full Annual Report             |                                |                    |          | A       |
		| I0033358113 | U      | AH           | COY  | 2059     |         |       |          | 59999      |             | 0034422877  | BISCIDALE PTY LTD             | <GORMAN SUPERANNUATION A/C>, | PO BOX 101                  | FREMANTLE WA                |                             |                   | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | BISCIDALE   PTYLTD      GORMAN | 61799222 |          | Nil holding on trading classes | No Annual Report               |                                |                    |          | N       |
		| I0027496415 | U      | AH           | COY  | 3205     |         |       |          | 59999      | 324234      | 0034469652  | BOTHKAMP AUSTRALIA PTY LTD    | <BOTHKAMP AUSTRALIA A/C>,    | C/- KINGSTON ADMINISTRATION | SERVICES PTY LTD            | LEVEL 2/76 KINGS PARK ROAD  | WEST PERTH WA     | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | BOTHKAMP    AUSTRALIAPTY324234 | 48873037 |          | ** LIKE HOLDER PRESENT **      | Nil holding on trading classes | No Annual Report               |                    |          | N       |
		| I0036044217 | U      | AH           | JNT  | NZL      | XXX     |       | 22       | 59999      | 643543      | 0034469654  | MRS SALLY BREMNER + MR THOMAS | CRAIG + MR GEOFFREY SAUNDERS | <CRAIG BREMNER FAMILY A/C>, | 10 WROXTON TERRACE MERIVALE | 10 WROXTON TERRACE MERIVALE | CHRISTCHURCH 8014 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | BREMNER     SALLY       643543 |          |          | Overseas domicile              | Non standard tax rates         | Nil holding on trading classes | No Annual Report   |          | N       |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18433
Scenario Outline: Test Case 18433: 02 - Add Holder : Esc validation - holder not saved
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01202 I enter Holder details as "<HIN>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
	When I PressESC
		And I PressESC
		And OLS01101 I Search the Holder as "<HIN>"
	Then I should see the below ErrorMessage "The code you are searching for is not on file."

Examples: 
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name               | Address1         | Address2                  | Address3   | Address4   | Address5 | Deceased | Exception | Suppress | RetMail | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | AReport |
		| I0970063382 | U      | AH           | IND  | 6001     |         |       |          | 59999      |             |             | MS NICOLA BROADLEY | CONTROL HOLDER   | C/- COMPUTERSHARE LIMITED | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         |       |           | N         | 39       | CR       | 22       | DC       | DC       | N       |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18439
Scenario Outline: Test Case 18439: 04 - Add Holder with Holder Extra
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01202 I enter Holder details as "<HIN>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
		And In OLS01801 I Add Holder Extra Details as "<Tran>" "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<ReturnedEmail>" "<EmailFailCount>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"
	When I PressESC
		And OLS01101 I Search the Holder as "<HIN>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption1>"
	Then In OLS01801 I should see Holder Extra Details as "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"


Examples: 
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name             | Address1 | Address2 | Address3   | Address4   | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key                | DPID     | Register | Warning1                       | Warning2                     | Warning3         | Warning4 | Warning5 | AReport | Tran  | ExtraHolderID | HomeTell   | WorkTell   | Fax        | Mobile     | Email                        | Flag1 | Flag2 | Flag3 | Flag4 | Flag5 | Flag6 | Flag7 | Flag8 | Flag9 | UpdateOption1 | ReturnedEmail | EmailFailCount |
		| I0032960367 | U      | AH           | IND  | 3067     |         |       |          | 59999      |             |             | MR EXTRA DETAILS | ADDRESS1 | ADDRESS2 | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | Y                  | N                | DETAILS     EXTRA  | 36577907 |          | Nil holding on trading classes | Holder Extra details present | No Annual Report |          |          | N       | 20100 | 200100        | 0385100100 | 0385100101 | 0385100102 | 0433123456 | AUTOMATION@COMPUTERSHARE.COM |       |       |       |       |       |       |       |       |       | HE            |               |                |


#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@18450
#Scenario Outline: Test Case 18450: 05 - Add Holder with TFN
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01202 I enter Holder details as "<HIN>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
#		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
#		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
#		And In TNS01102 I Add TFN details as "<Tran>" "<ExemptType>" "<TFN>" "<ABN>" "<TFNType>" "<ABNType>"
#	When I PressESC
#		And OLS01101 I Search the Holder as "<HIN>"
#	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
#		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
#		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
#		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Enquiry system and Search <HIN>
#		And I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | A     |
#			| Locate Argument |       |
#	Then In ENS01001 I should see holder details as "<HIN>" "<Type>" "<Postcode>" "<TFN1>" "<ABN1>" "<Name>"
#
#Examples: 
#		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name          | Address1 | Address2 | Address3 | Address4 | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key             | DPID | Register | Warning1                       | Warning2          | Warning3         | Warning4 | Warning5 | AReport | Tran  | ExemptType | TFN       | ABN | TFNType | ABNType | TFN1       | ABN1       |
#		| I0035990682 | U      | AH           | COY  | 3175     |         |       |          | 59999      |             |             | MR TFN UPDATE | ADDRESS1 | ADDRESS2 | ADDRESS3 | ADDRESS4 | ADDRESS5 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | Y         | N                  | N                | UPDATE      TFN |      |          | Nil holding on trading classes | No DPID allocated | No Annual Report |          |          | N       | 20200 | T          | 123456789 |     | T       |         | TFN quoted | Not quoted |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18441
Scenario Outline: Test Case 18441: 06 - Add Holder with Employee Details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01202 I enter Holder details as "<HIN>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
		And In EOL01701 I Add ESS Employee Details as "<TranNo>" "<EmployeeID>" "<EffectiveDate>" "<EmployeeStatus>" "<LeaverCode> "<PayrollID>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption1>"
		And In EOL01701 I should see ESS Employee Details as "<EmployeeID>" "<EffectiveDate>" "<EmployeeStatus>" "<LeaverCode> "<PayrollID>"
Examples: 
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name         | Address1 | Address2 | Address3 | Address4 | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key            | DPID | Register | Warning1                       | Warning2          | Warning3         | Warning4 | Warning5 | AReport | TranNo | EmployeeID | EffectiveDate | EmployeeStatus | LeaverCode | PayrollID | UpdateOption1 |
		| I0035493034 | U      | AH           | COY  | 3175     |         |       |          | 59999      |             |             | MR ED UPDATE | ADDRESS1 | ADDRESS2 | ADDRESS3 | ADDRESS4 | ADDRESS5 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | Y                | UPDATE      ED |      |          | Nil holding on trading classes | No DPID allocated | No Annual Report |          |          | N       | 20300  | 0000012345 | 01/01/2015    | E              | EEE        | 14        | ED            |

#
#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@18632
#Scenario Outline: Test Case 18632: 01 - Default Update Menu Option
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	Then In OLS01120 I should see Static Details menu options Part1 as "<AH>" "<NA>" "<HE>" "<UD>" "<CD>" "<PI>" "<WR>" "<CY>" "<ED>" "<VP>" "<UX>" "<IR>" "<ZA>"
#		And In OLS01120 I should see Static Details menu options Notings as "<D1>" "<D2>" "<D3>" "<D4>" "<D5>" "<P1>" "<P2>" "<P3>" "<N1>" "<N2>" "<N3>" "<N4>" "<N5>"
#		And In OLS01120 I should see Static Details menu options Part2 as "<CY>"
#	When I PressESC
#	Then I expect to be in the "OLS01101" Screen
#
#	
#Examples: 
#		| Action | UpdateOption | AH                | NA                           | HE                       | UD                       | CD                     | PI                     | WR                             | CY                   | ED                   | VP                                      | UX                                  | IR                       | ZA                       | D1                              | D2                              | D3                              | D4                              | D5                              | P1                        | P2                        | P3                        | N1                         | N2                         | N3                         | N4                         | N5                         | Action1 | UpdateOption1 |
#		| S      | I8600172876  | AH. Add Holder(s) | NA. Name and Address changes | HE. Holder Extra Details | UD. Unconfirmed Deceased | CD. Confirmed Deceased | PI. Payee Instructions | WR. Overseas Wire Instructions | CY. Charity Election | ED. Employee Details | VP. Vesting Performance Schedule Change | UX. US Taxpayer Details - Investors | IR. IRL Taxpayer Details | ZA. ZAF Taxpayer Details | D1. Deceased Estate notings (1) | D2. Deceased Estate notings (2) | D3. Deceased Estate notings (3) | D4. Deceased Estate notings (4) | D5. Deceased Estate notings (5) | P1. Power of Attorney (1) | P2. Power of Attorney (2) | P3. Power of Attorney (3) | N1. Free format noting (1) | N2. Free format noting (2) | N3. Free format noting (3) | N4. Free format noting (4) | N5. Free format noting (5) | U       |               |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18782
Scenario Outline: Test Case 18782: 02 - Update Menu Option - enable SC Option
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01801 I Add Holder Extra Details as "<Tran>" "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<ReturnedEmail>" "<EmailFailCount>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"
		And I PressESC		
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption2>"
	Then In OLS01120 I should see Static Details menu options Part1 as "<AH>" "<NA>" "<HE>" "<UD>" "<CD>" "<PI>" "<WR>" "<ED>" "<VP>" "<UX>" "<IR>" "<ZA>"
		And In OLS01120 I should see Static Details menu options Notings as "<D1>" "<D2>" "<D3>" "<D4>" "<D5>" "<P1>" "<P2>" "<P3>" "<N1>" "<N2>" "<N3>" "<N4>" "<N5>"
		And In OLS01120 I should see Static Details menu options Part2 as "<CY>"
		And In OLS01120 I should see Static Details menu options Part2 as "<SC>"
	When I PressESC
	Then I expect to be in the "OLS01101" Screen

	
Examples: 
		| Action | UpdateOption | AH                | NA                           | HE                       | UD                       | CD                     | PI                     | WR                             | CY                   | ED                   | VP                                      | UX                                  | IR                       | ZA                       | D1                              | D2                              | D3                              | D4                              | D5                              | P1                        | P2                        | P3                        | N1                         | N2                         | N3                         | N4                         | N5                         | Action1 | UpdateOption1 | Tran  | ExtraHolderID | HomeTell   | WorkTell   | Fax        | Mobile     | Email                 | Flag1 | Flag2 | Flag3 | Flag4 | Flag5 | Flag6 | Flag7 | Flag8 | Flag9 | SC                                    | UpdateOption2 | ReturnedEmail | EmailFailCount |
		| S      | X0009828133  | AH. Add Holder(s) | NA. Name and Address changes | HE. Holder Extra Details | UD. Unconfirmed Deceased | CD. Confirmed Deceased | PI. Payee Instructions | WR. Overseas Wire Instructions | CY. Charity Election | ED. Employee Details | VP. Vesting Performance Schedule Change | UX. US Taxpayer Details - Investors | IR. IRL Taxpayer Details | ZA. ZAF Taxpayer Details | D1. Deceased Estate notings (1) | D2. Deceased Estate notings (2) | D3. Deceased Estate notings (3) | D4. Deceased Estate notings (4) | D5. Deceased Estate notings (5) | P1. Power of Attorney (1) | P2. Power of Attorney (2) | P3. Power of Attorney (3) | N1. Free format noting (1) | N2. Free format noting (2) | N3. Free format noting (3) | N4. Free format noting (4) | N5. Free format noting (5) | U       | HE            | 20500 |               | 0385100100 | 0385100101 | 0385100102 | 0433100100 | AUTOMATION@CPU.COM.AU |       |       |       |       |       |       |       |       |       | SC. Shareholder Communication Methods |               |               |                |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@19920
Scenario Outline: Test Case 19920: 03 - Update Menu Option - enable FIN Options-Test1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	Then In OLS01120 I should see Static Details menu options Part1 as "<AH>" "<NA>" "<HE>" "<UD>" "<CD>" "<PI>" "<WR>" "<ED>" "<VP>" "<UX>" "<IR>" "<ZA>"
		And In OLS01120 I should see Static Details menu options Notings as "<D1>" "<D2>" "<D3>" "<D4>" "<D5>" "<P1>" "<P2>" "<P3>" "<N1>" "<N2>" "<N3>" "<N4>" "<N5>"
		And In OLS01120 I should see Static Details menu options Part2 as "<FC>"
		And In OLS01120 I should see Static Details menu options Part2 as "<FG>"
	When I PressESC
	Then I expect to be in the "OLS01101" Screen

	
Examples: 
		| UpdateOption | Action | AH                | NA                           | HE                       | UD                       | CD                     | PI                     | WR                             | CY                   | ED                   | VP                                      | UX                                  | IR                       | ZA                       | D1                              | D2                              | D3                              | D4                              | D5                              | P1                        | P2                        | P3                        | N1                         | N2                         | N3                         | N4                         | N5                         | Action1 | UpdateOption1 | FC             | FG                   |
		| N0330344571  | S      | AH. Add Holder(s) | NA. Name and Address changes | HE. Holder Extra Details | UD. Unconfirmed Deceased | CD. Confirmed Deceased | PI. Payee Instructions | WR. Overseas Wire Instructions | CY. Charity Election | ED. Employee Details | VP. Vesting Performance Schedule Change | UX. US Taxpayer Details - Investors | IR. IRL Taxpayer Details | ZA. ZAF Taxpayer Details | D1. Deceased Estate notings (1) | D2. Deceased Estate notings (2) | D3. Deceased Estate notings (3) | D4. Deceased Estate notings (4) | D5. Deceased Estate notings (5) | P1. Power of Attorney (1) | P2. Power of Attorney (2) | P3. Power of Attorney (3) | N1. Free format noting (1) | N2. Free format noting (2) | N3. Free format noting (3) | N4. Free format noting (4) | N5. Free format noting (5) | U       |               | FC. Change FIN | FG. Generate New FIN |

@winformsTest
@OL_Online
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@19920
Scenario Outline: Test Case 19920: 03 - Update Menu Option - enable FIN Options-Test2
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
	Then In OLS01120 I should see Static Details menu options Part1 as "<AH>" "<NA>" "<HE>" "<UD>" "<CD>" "<PI>" "<WR>" "<ED>" "<VP>" "<UX>" "<IR>" "<ZA>"
		And In OLS01120 I should see Static Details menu options Notings as "<D1>" "<D2>" "<D3>" "<D4>" "<D5>" "<P1>" "<P2>" "<P3>" "<N1>" "<N2>" "<N3>" "<N4>" "<N5>"
		And In OLS01120 I should see Static Details menu options Part2 as "<FL>"
	When I PressESC
	Then I expect to be in the "OLS01101" Screen

	
Examples: 
		| UpdateOption | Action | AH                | NA                           | HE                       | UD                       | CD                     | PI                     | WR                             | CY                   | ED                   | VP                                      | UX                                  | IR                       | ZA                       | D1                              | D2                              | D3                              | D4                              | D5                              | P1                        | P2                        | P3                        | N1                         | N2                         | N3                         | N4                         | N5                         | Action1 | UpdateOption1 | FL               |
		| N0330344571  | S      | AH. Add Holder(s) | NA. Name and Address changes | HE. Holder Extra Details | UD. Unconfirmed Deceased | CD. Confirmed Deceased | PI. Payee Instructions | WR. Overseas Wire Instructions | CY. Charity Election | ED. Employee Details | VP. Vesting Performance Schedule Change | UX. US Taxpayer Details - Investors | IR. IRL Taxpayer Details | ZA. ZAF Taxpayer Details | D1. Deceased Estate notings (1) | D2. Deceased Estate notings (2) | D3. Deceased Estate notings (3) | D4. Deceased Estate notings (4) | D5. Deceased Estate notings (5) | P1. Power of Attorney (1) | P2. Power of Attorney (2) | P3. Power of Attorney (3) | N1. Free format noting (1) | N2. Free format noting (2) | N3. Free format noting (3) | N4. Free format noting (4) | N5. Free format noting (5) | U       |               | FL. Load CSN FIN |


#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@18463
#Scenario Outline: Test Case 18463: 07 - Add Holder - Chess Holder Confirmation
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01202 I enter Holder details as "<HIN>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
#		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
#		And In OLS01230 I enter update
#		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
#	When I PressESC
#		And OLS01101 I Search the Holder as "<HIN>"
#	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode1>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
#		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
#		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
#		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
#
#
#Examples: 
#		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name                | Address1       | Address2                  | Address3   | Address4   | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key                | DPID | Register | Warning1                       | Warning2           | Warning3 | Warning4 | Warning5 | AReport | BrokerCode1 |
#		| X0051120892 | U      | AH           | CNT  | 6001     |         |       |          | 00001      |             |             | MR AUTOMATION TEST2 | CONTROL HOLDER | C/- COMPUTERSHARE LIMITED | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         | A (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | TEST2       AUTOMA |      |          | Nil holding on trading classes | Full Annual Report |          |          |          | A       | 2552        |


@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18447
Scenario Outline: Test Case 18447: 01 - Name & Address Change with different Holder Types
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01201 I Change Holder details as "<ModifyType>" "<Tran>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
	When I PressESC
		And OLS01101 I Search the Holder as "<HIN>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"


Examples: s
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name           | Address1       | Address2                  | Address3   | Address4   | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key                 | DPID     | Register | Warning1                      | Warning2           | Warning3 | Warning4 | Warning5 | AReport | Action1 | UpdateOption1 | ModifyType | Tran  |
		| I0030374649 | U      | NA           | IND  | 6001     |         |       |          | 57516      |             |             | CHNAGE DCREDIT | CONTROL HOLDER | C/- COMPUTERSHARE LIMITED | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         | A (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | DCREDIT     CHNAGE  | 36577907 |          | Payee instruction direct/bulk | Full Annual Report |          |          |          | A       | S       | I0030374649   | M          | 40100 |

@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@18457
Scenario Outline: Test Case 18457: 06 - Name & Address Change - with Holder Extra
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action2>" "<UpdateOption2>"
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01201 I Change Holder details as "<ModifyType>" "<Tran1>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
		And In OLS01801 I Change Holder Extra Details as "<ModifyType1>" "<Tran>" "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<ReturnedEmail>" "<EmailFailCount>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"
	When I PressESC
		And OLS01101 I Search the Holder as "<HIN>"
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption1>"
	Then In OLS01801 I should see Holder Extra Details as "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"


Examples: 
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name               | Address1 | Address2 | Address3   | Address4   | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key                | DPID     | Register | Warning1                      | Warning2                     | Warning3                     | Warning4                      | Warning5         | AReport | Tran  | ExtraHolderID | HomeTell   | WorkTell   | Fax        | Mobile     | Email                        | Flag1 | Flag2 | Flag3 | Flag4 | Flag5 | Flag6 | Flag7 | Flag8 | Flag9 | UpdateOption1 | UpdateOption2 | ModifyType | Tran1 | Action2 | ModifyType1 | ReturnedEmail | EmailFailCount |
		| I0131542810 | U      | NA           | IND  | 3067     |         |       |          | 57516      |             |             | MR EXTRA DETAILS   | ADDRESS1 | ADDRESS2 | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | Y                  | N                | DETAILS     EXTRA  | 36577907 |          | Payee instruction direct/bulk | Holder Extra details present | No Annual Report             |                               |                  | N       | 40102 | 200100        | 0385100100 | 0385100101 | 0385100102 | 0433123456 | AUTOMATION@COMPUTERSHARE.COM |       |       |       |       |       |       |       |       |       | HE            | I0131542810   | M          | 40101 | S       | M           |               |                |
		| I0131543514 | U      | NA           | IND  | 3067     |         |       |          | 57516      |             |             | MR EDETAILS CHANGE | ADDRESS1 | ADDRESS2 | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | Y                  | N                | CHANGE      EDETAI | 36577907 |          | Payee instruction direct/bulk | Plan participant             | Holder Extra details present | Communication Methods Present | No Annual Report | N       | 40104 | 200100        | 0385100100 | 0385100101 | 0385100102 | 0433123456 | AUTOMATION@COMPUTERSHARE.COM |       |       |       |       |       |       |       |       |       | HE            | I0131543514   | M          | 40103 | S       | C           |               |                |

@winformsTest
Scenario Outline: Test Case 18499: 07 - Name & Address Change - with Employee Details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action2>" "<UpdateOption2>"
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01201 I Change Holder details as "<ModifyType>" "<Tran1>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
		And In OLS01101 I enter following details as the update option "<Action3>" "<UpdateOption3>"	
		And In EOL01701 I Change ESS Employee Details as:
		| TranNo   | EmployeeID   | EffectiveDate   | EmployeeStatus   | LeaverCode   | PayrollID   | Action    |
		| <TranNo> | <EmployeeID> | <EffectiveDate> | <EmployeeStatus> | <LeaverCode> | <PayrollID> | <Action4> |
	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
	When In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption1>"
		And In EOL01701 I should see ESS Employee Details as "<EmployeeID>" "<EffectiveDate>" "<EmployeeStatus>" "<LeaverCode> "<PayrollID>"
Examples: 
		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name          | Address1 | Address2 | Address3 | Address4 | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key            | DPID | Register | Warning1                       | Warning2          | Warning3         | Warning4 | Warning5 | AReport | TranNo  | EmployeeID | EffectiveDate | EmployeeStatus | LeaverCode | PayrollID | UpdateOption1 | Action2 | UpdateOption2 | ModifyType1 | ModifyType | Tran1  | Action3 | UpdateOption3 | Action4 |
		| I0030264088 | U      | NA           | IND  | 3175     |         |       |          | 57516      |             |             | MR ED UPDATE1 | ADDRESS1 | ADDRESS2 | ADDRESS3 | ADDRESS4 | ADDRESS5 | N        |           | N        |         | N (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | Y                | UPDATE1     ED |      |          | Nil holding on trading classes | No DPID allocated | No Annual Report |          |          | N       | 765800  | 0000012345 | 01/01/2015    | E              | EEE        | 14        | ED            | S       | I0030264088   | M           | M          | 765801 | U       | ED            | C       |



##need to conform with Suj about the data and setps
#@WES_AUTO
#Scenario Outline: Test Case 18552: 09 - Name & Address Change for Chess Holder
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action2>" "<UpdateOption2>"
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01201 I Change Holder details as "<ModifyType>" "<Tran1>" "<Type>" "<Postcode>" "<Taxcode>" "<Group>" "<VarField>" "<BrokerCode>" "<KeyModifier>" "<AlternateID>" "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
#		And In OLS01202 I enter Holder Flags details as "<Deceased>" "<Exception>" "<Suppress>" "<RetMail>" "<AReport>" "<RefID>" "<BirthDate>" "<StopTrade>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
#		And In OLS01230 I enter update
#		And In OLS01210 I enter confirmation details as "<UpdateTFN>" "<UpdateExtraDetails>" "<UpdateEmpDetails>"
#	When I PressESC
#		And OLS01101 I Search the Holder as "<HIN>"
#	Then In OLS01102 I should see Holder Static Details as "<Key>" "<HIN>" "<Type>" "<Postcode>" "<DPID>" "<Group>" "<BrokerCode1>" "<VarField>" "<Register>" "<Taxcode>" "<KeyModifier>" "<AlternateID>"
#		And In OLS01102 I should see Holder Address Details as "<Name>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>"
#		And In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
#		And In OLS01102 I should see Holder Flags as "<Deceased>" "<Exception>" "<Suppress>" "<StopTrade>" "<RetMail>" "<AReport1>" "<BirthDate>" "<HVFFlag1>" "<HVFFlag2>" "<HVFFlag3>" "<HVFFlag4>" "<HVFFlag5>"
#
#
#Examples: 
#		| HIN         | Action | UpdateOption | Type | Postcode | Taxcode | Group | VarField | BrokerCode | KeyModifier | AlternateID | Name                | Address1       | Address2                  | Address3   | Address4   | Address5 | Deceased | Exception | Suppress | RetMail | AReport1      | RefID | BirthDate | StopTrade | HVFFlag1 | HVFFlag2 | HVFFlag3 | HVFFlag4 | HVFFlag5 | UpdateTFN | UpdateExtraDetails | UpdateEmpDetails | Key                | DPID | Register | Warning1                       | Warning2           | Warning3 | Warning4 | Warning5 | AReport | BrokerCode1 | ModifyType | Tran1 | Action2 | UpdateOption2 |
#		| X0007499078 | U      | NA           | CNT  | 6001     |         |       |          | 00001      |             |             | MR AUTOMATION TEST3 | CONTROL HOLDER | C/- COMPUTERSHARE LIMITED | PO BOX 103 | ABBOTSFORD | VIC 3067 | N        |           | N        |         | A (Nominated) |       |           | N         | 39       | CR       | 22       | DC       | DC       | N         | N                  | N                | TEST3       AUTOMA |      |          | Nil holding on trading classes | Full Annual Report |          |          |          | A       | 2552        | M          | 40500 | S       | X0007499078   |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20172
#Scenario Outline: Test Case 20172: 06 - Charity Election (CY) - Add , Change, Modify and Terminate
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#		And In OLS03501 I Enter Action Details as "<Action3>" "<ActionClass>"
#		And In OLS03502 I Update Charity Details as "<Tran>" "<ParticipationOption1>" "<ParticipationLevel1>" "<CharityCode1>"
#	Then I expect to be in the "SELCHA01" Screen
#	When In SELCHA01 I Enter Charity Code as "<CharityCode>"
#		And I Transmit
#	Then I expect to be in the "OLS03503" Screen
#	When I Transmit
#	Then In OLS03501 I should see Charity Election Update details as "<ActionClass>" "<ParticipationOption1>" "<ParticipationLevel1>" "<CharityCode>" "<ApplicationDate>" "<LastChangeDate>" "<Status>"
#	When In OLS03501 I Enter Action Details as "<Action1>" "<ActionClass>"
#	Then In OLS03502 I Should see Charity Election Update Details as "<ActionClass>" "<ParticipationOption1>" "<ParticipationLevel1>" "<CharityCode>" "<ApplicationDate>" "<LastChangeDate>"
#	When In OLS03502 I Change the Charity Election Details as "<Action4>" "<NewTran>" "<NewParticipationOption1>" "<NewParticipationLevel1>" "<NewCharityCode1>"
#	Then I expect to be in the "SELCHA01" Screen
#	When In SELCHA01 I Enter Charity Code as "<NewCharityCode>"
#		And I Transmit
#	Then I expect to be in the "OLS03503" Screen
#	When I Transmit
#	Then In OLS03501 I should see Charity Election Update details as "<ActionClass>" "<NewParticipationOption1>" "<NewParticipationLevel1>" "<NewCharityCode>" "<ApplicationDate>" "<LastChangeDate>" "<Status>"
#	When I PressESC
#	Then I expect to be in the "OLS01102" Screen
#	When In OLS01101 I enter following details as the update option "<Actio5>" "<UpdateOption3>"
#	When In OLS01101 I enter following details as the update option "<Actio6>" "<UpdateOption3>"
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
#	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#		And In OLS03501 I Enter Action Details as "<Action1>" "<ActionClass>"
#		And In OLS03502 I Terminate the Charity Election Details as "<NewTran1>"
#	Then I expect to be in the "OLS03503" Screen
#	When I Transmit
#	Then I expect to be in the "OLS03504" Screen
#	When I Transmit
#	Then In OLS03501 I should see Charity Election Update details as "<ActionClass>" "<NewParticipationOption1>" "<NewParticipationLevel1>" "<NewCharityCode>" "<ApplicationDate>" "<LastChangeDate>" "<Status1>"
#	When I PressESC
#	Then I expect to be in the "OLS01102" Screen
#	When In OLS01101 I enter following details as the update option "<Actio5>" "<UpdateOption3>"
#	When In OLS01101 I enter following details as the update option "<Actio6>" "<UpdateOption3>"
#	Then In OLS01102 I should see Holder Warning as "<NewWarning1>" "<NewWarning2>" "<NewWarning3>" "<NewWarning4>" "<NewWarning5>"
#Examples: 
#	| Action | UpdateOption | Action1 | UpdateOption1 | Action3 | ActionClass | Tran  | ParticipationOption1 | ParticipationLevel1 | CharityCode1 | CharityCode | ApplicationDate | LastChangeDate | Status  | NewTran | NewParticipationOption1 | NewParticipationLevel1 | NewCharityCode1 | NewCharityCode | Action4 | Actio5 | UpdateOption3 | Actio6 | Warning1                      | Warning2          | Warning3  | Warning4                     | Warning5                      | NewTran1 | Status1    | NewWarning1                   | NewWarning2 | NewWarning3                  | NewWarning4                   | NewWarning5       |
#	| S      | I0012216149  | U       | CY            | A       | ORD         | 37100 | P                    | 5                   | >            | BENS10      | 29/06/2015      | 29/06/2015     | PENDING | 37101   | P                       | 100                    | .               | NBCF10         | C       | B      |               | F      | Payee instruction direct/bulk | Charity Elections | Noting:N1 | Holder Extra details present | Communication Methods Present | 37102    | TERMINATED | Payee instruction direct/bulk | Noting:N1   | Holder Extra details present | Communication Methods Present | No DPID allocated |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@20171
Scenario Outline: Test Case 20171: 05 -Charity Election (CY) - Validation for Participation Option  field
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I change Charity Participation Fileds in Company Options as "<CharityDollars>" "<CharityPercentage>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS03501 I Enter Action Details as "<Action2>" "<ActionClass>"
		And In OLS03502 I Enter Charity Details as "<Tran>" "<ParticipationOption>"
	Then I should see the below ErrorMessage "<ErrorMessage>"


Examples: 
		| CharityDollars | CharityPercentage | Action | UpdateOption | Action1 | UpdateOption1 | Action2 | ActionClass | Tran  | ParticipationOption | ErrorMessage                             |
		| Y              | N                 | S      | X0051616189  | U       | CY            | A       | ORD         | 38100 | P                   | Participation Option (P)ercentage is not |
#		| Y              | N                 | S      | X0051616189  | U       | CY            | A       | ORD         | 38100 | D                   | At least one Election must be specified, |
#		| N              | Y                 | S      | X0051616189  | U       | CY            | A       | ORD         | 38100 | P                   | At least one Election must be specified, |
#		| N              | Y                 | S      | X0051616189  | U       | CY            | A       | ORD         | 38100 | D                   | Participation Option (D)ollars is not    |
#		| Y              | Y                 | S      | X0051616189  | U       | CY            | A       | ORD         | 38100 | P                   | At least one Election must be specified, |
		| Y              | Y                 | S      | X0051616189  | U       | CY            | A       | ORD         | 38100 | D                   | At least one Election must be specified, |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20218
#Scenario Outline: Test Case 20218: 07 - Charity Election (CY) - Updating already existing Charity Elections
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#		And In OLS03501 I Enter Action Details as "<Action2>" "<ActionClass>"
#	When In OLS03502 I Change the Charity Election Details as "<Action3>" "<NewTran>" "<NewParticipationOption1>" "<NewParticipationLevel1>" "<NewCharityCode1>"
#	Then I expect to be in the "SELCHA01" Screen
#	When In SELCHA01 I Enter Charity Code as "<NewCharityCode>"
#		And I Transmit
#	Then I expect to be in the "OLS03503" Screen
#	When I Transmit
#	Then In OLS03501 I should see Charity Election Change details as "<ActionClass>" "<NewParticipationOption1>" "<NewParticipationLevel1>" "<NewCharityCode>" "<ApplicationDate>" "<LastChangeDate>" "<Status>"
#	
#
#Examples: 
#		| Action | UpdateOption | Action1 | UpdateOption1 | Action2 | ActionClass | Action3 | NewTran | NewParticipationOption1 | NewParticipationLevel1 | NewCharityCode1 | NewCharityCode | ApplicationDate | LastChangeDate | Status  |
#		| S      | X0058145238  | U       | CY            | U       | ORD         | C       | 38200   | D                       | 21                     | >               | DART10         | 24/06/2015      |                | PENDING |

#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20320
#Scenario Outline: Test Case 20320: 03 - Share Holder Communication - Change and Modify
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
#		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	Then In OLS01901 I should see Shareholder Communication Methods Part1 as "<HIN>" "<Mobile>" "<Email>" "<EmailReturnedDate>" "<PostalMailReturned>" "<PublicationDessc1>" "<PublicationDessc2>" "<PublicationDessc3>" "<PublicationDessc4>" "<PublicationDessc5>" "<PublicationDessc6>" "<PublicationDessc7>" "<PublicationDessc8>" "<PublicationDessc9>
#	Then In OLS01901 I should see Shareholder Communication Methods Part2 as "<CommunicationMethods1>" "<CommunicationMethods2>" "<CommunicationMethods3>" "<CommunicationMethods4>" "<CommunicationMethods5>" "<CommunicationMethods6>" "<CommunicationMethods7>" "<CommunicationMethods8>" "<CommunicationMethods9>" "<HolderChoice1>" "<HolderChoice2>" "<HolderChoice3>" "<HolderChoice4>" "<HolderChoice5>" "<HolderChoice6>" "<HolderChoice7>" "<HolderChoice8>" "<HolderChoice9>"
#	When In OLS01901 I Change Holder Choices as "<Tran>" "<Action3>" "<NewHolderChoice1>" "<NewHolderChoice2>" "<NewHolderChoice3>" "<NewHolderChoice4>" "<NewHolderChoice5>" "<NewHolderChoice6>" "<NewHolderChoice7>" "<NewHolderChoice8>" "<NewHolderChoice9>"
#	When In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
#	Then In OLS01901 I should see Shareholder Communication Methods Part2 as "<CommunicationMethods1>" "<CommunicationMethods2>" "<CommunicationMethods3>" "<CommunicationMethods4>" "<CommunicationMethods5>" "<CommunicationMethods6>" "<CommunicationMethods7>" "<CommunicationMethods8>" "<CommunicationMethods9>" "<NewHolderChoice1>" "<NewHolderChoice2>" "<NewHolderChoice3>" "<NewHolderChoice4>" "<NewHolderChoice5>" "<NewHolderChoice6>" "<NewHolderChoice7>" "<NewHolderChoice8>" "<NewHolderChoice9>"
#
#
#Examples: 
#		| UpdateOption | Action1 | UpdateOption1 | HIN         | Mobile      | Email                               | EmailReturnedDate | PostalMailReturned | PublicationDessc1 | PublicationDessc2    | PublicationDessc3   | PublicationDessc4 | PublicationDessc5 | PublicationDessc6 | PublicationDessc7 | PublicationDessc8 | PublicationDessc9           | CommunicationMethods1 | CommunicationMethods2 | CommunicationMethods3 | CommunicationMethods4 | CommunicationMethods5 | CommunicationMethods6 | CommunicationMethods7 | CommunicationMethods8 | CommunicationMethods9 | HolderChoice1 | HolderChoice2 | HolderChoice3 | HolderChoice4 | HolderChoice5 | HolderChoice6 | HolderChoice7 | HolderChoice8 | HolderChoice9 | Action3 | NewHolderChoice1 | NewHolderChoice2 | NewHolderChoice3 | NewHolderChoice4 | NewHolderChoice5 | NewHolderChoice6 | NewHolderChoice7 | NewHolderChoice8 | NewHolderChoice9 | Action | Tran  |
#		| I0131408234  | U       | SC            | I0131408234 | 04987678962 | CEWG.CANPUZ@YAHOO.COM               | 26/06/2015        | 01/04/2015         | Company Reporting | Offer Communications | Company Information | New pubplication  | Not in use        | Not in use        | Company Marketing | Statements        | Notice of Meeting and Proxy | O E N                 | O E N                 | O E N                 | O E N                 |                       |                       |                       |                       |                       |               |               | E             |               |               |               |               |               |               | C       | E                |                  | O                |                  |                  |                  |                  | N                | E                | S      | 39100 |
#		| X0045877353  | U       | SC            | X0045877353 | 036435342   | DD_FGUJKLUP._test@computershare.com | 26/06/2015        | 01/03/2015         | Company Reporting | Offer Communications | Company Information | New pubplication  | Not in use        | Not in use        | Company Marketing | Statements        | Notice of Meeting and Proxy | O E N                 | O E N                 | O E N                 | O E N                 |                       |                       |                       |                       |                       | N             |               | E             |               |               |               |               | E             | E             | C       | E                |                  | O                |                  |                  |                  |                  | N                | E                | S      | 39101 |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@20454
Scenario Outline: Test Case 20454: 01 - Load,Change & Generated FIN - Error messages validation for invlaid Company & Holder
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 	
		And In OLS01630 I Enter CSN FIN Details as "<Tran>" "<HIN>" "<LoadFIN>" "<ValidateFIN>"
	Then I expect to be in the "OLS01102" Screen
#	When I go to the Fixups system
#		And In HLDADD00 I locate holder as "<HIN>"
#	Then In HLDADD01 I should see FIN details as "<PinNumber>"

Examples: 
		| UpdateOption | Action | Action1 | UpdateOption1 | Tran  | HIN         | LoadFIN | ValidateFIN | PinNumber |
		| L0000082767  | S      | U       | FL            | 29100 | L0000082767 | 9986    | 9986        | 9986      |
		| N0999999999  | S      | U       | FL            | 29101 | N0999999999 | 5432    | 5432        | 5432      |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20456
#Scenario Outline: Test Case 20456: 03 - Load, Change & Generate FIN -Change FIN
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#		And In OLS01610 I Change FIN details as "<Tran>" "<OldFIN>" "<NewFIN>" "<ValidateFIN>"
#	Then I expect to be in the "OLS01102" Screen
#	When I go to the Fixups system
#		And In HLDADD00 I locate holder as "<HIN>"
#	Then In HLDADD01 I should see FIN details as "<NewFIN>"
#
#Examples: 
#		| UpdateOption | Action | Action1 | UpdateOption1 | Tran  | OldFIN | NewFIN | ValidateFIN | HIN         |
#		| L0330344571  | S      | U       | FC            | 29102 | 8899   | 4561   | 4561        | L0330344571 |
#		| N0000206723  | S      | U       | FC            | 29103 | 4444   | 1234   | 1234        | N0000206723 |
#		| L0332196634  | S      | U       | FC            | 29104 |        | 2222   | 2222        | L0332196634 |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20503
#Scenario Outline: Test Case 20503: 04 - Load, Change & Generate FIN - Generate FIN-Test1
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#		And In OLS01620 I Generate new FIN as "<Tran>" "<GenerateFIN>"
#	Then I expect to be in the "OLS01102" Screen
#	When I go to the Fixups system
#		And In HLDADD00 I locate holder as "<UpdateOption>"
#	Then In HLDADD01 I should not see FIN details as "<OldFIN>"
#
#Examples: 
#		| UpdateOption | Action | Action1 | UpdateOption1 | Tran  | GenerateFIN | OldFIN |
#		| L0330468009  | S      | U       | FG            | 29105 | Y           | 5566   |
#		| N0000209825  | S      | U       | FG            | 29106 | Y           |        |
#
#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20503
#Scenario Outline: Test Case 20503: 04 - Load, Change & Generate FIN - Generate FIN-Test2
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#		And In OLS01620 I Generate new FIN as "<Tran>" "<GenerateFIN>"
#	Then I expect to be in the "OLS01102" Screen
#	When I go to the Fixups system
#		And In HLDADD00 I locate holder as "<UpdateOption>"
#	Then In HLDADD01 I should see FIN details as "<NewFIN>"
#
#Examples: 
#		| UpdateOption | Action | Action1 | UpdateOption1 | Tran  | GenerateFIN | NewFIN |
#		| L0333329972  | S      | U       | FG            | 29105 | N           | 4564   |


#@CPU_AUTO
#Scenario: Add Wire instructions -AU
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "CPU_AUTO"
#		And I search "I0100019060" in Static Details update Menu
#	When I update wire instructions add below:
#		| Field            | Value                |
#		| Tran No          | 153                  |
#		| Country          | AU                   |
#		| SWIFT Code       | ABOCAU2S             |
#		| Account Number   | 12345678             |
#		| Account Name     | MR SCRIP AUTOMATION2 |
#		| Payment Currency | AUD                  |
#		| Bank Code        | 013100               |
#		| Bank Name        | Automation Bank      |
#		| Bank Address1    | 425 Johnsotne Street |
#		| Bank Address2    | Abbotsford VIC       |
#		And I go to the Enquiry system for "I0100019060"
#	Then In ENS01075 I should see Wire Instructions as below:
#		| Field          | Value                |
#		| HIN            | I0100019060          |
#		| Country Code   | AU                   |
#		| Bank System    | 75                   |
#		| Routing Code   | 013100               |
#		| Swift Code     | ABOCAU2S             |
#		| Account Number | 12345678             |
#		| Account Name   | MR SCRIP AUTOMATION2 |
#		| Currency Code  | AUD                  |

#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20728
#Scenario Outline: Test Case 20728: 01 - Overseas Wire Instructions (WR) - Add , Display , Change, Modify and Delete
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#		And In OLS04204 I add Wire Instructions as "<Tran>" "<CountryCode>" "<SWIFTCode>" "<AccountNumber>" "<AccountName>" "<PaymentCurrency>" "<BankCode>" "<BankName>" "<BankAddress1>" "<BankAddress2>" "<BankAddress3>" "<BankAddress4>" "<Phone>"
#	Then I expect to be in the "OLS01102" Screen
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"	
#	When In Online Data Entry System I enter search option as "<Action2>" "<UpdateOption2>"
#	Then In OLS01106 I should see Holder Wire Instructions as "<CountryCode>" "<SWIFTCode>" "<AccountNumber>" "<AccountName>" "<PaymentCurrency>" "<BankCode>" "<BankName>" "<BankAddress1>" "<BankAddress2>" "<BankAddress3>" "<BankAddress4>"
#	When In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS04204 I Change Wire Instructions as "<ChangeModify>" "<NewTran>" "<NewCountryCode>" "<NewSWIFTCode>" "<NewAccountNumber>" "<NewAccountName>" "<NewPaymentCurrency>" "<NewBankCode>" "<NewBankName>" "<NewBankAddress1>" "<NewBankAddress2>" "<NewBankAddress3>" "<NewBankAddress4>" "<Phone>"
#	Then I expect to be in the "OLS01102" Screen
#	When In Online Data Entry System I enter search option as "<Action2>" "<UpdateOption2>"
#	Then In OLS01106 I should see Holder Wire Instructions as "<NewCountryCode>" "<NewSWIFTCode>" "<NewAccountNumber>" "<NewAccountName>" "<NewPaymentCurrency>" "<NewBankCode>" "<NewBankName>" "<NewBankAddress1>" "<NewBankAddress2>" "<NewBankAddress3>" "<NewBankAddress4>"
#	When In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS04204 I Delete Wire Instructions as "<ChangeModify1>" "<NewTran1>" "<ConfirmDelete>" 
#	Then I expect to be in the "OLS01102" Screen
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning4>" "<Warning5>" "<NewWarning6>"	
#	When In Online Data Entry System I enter search option as "<Action2>" "<UpdateOption2>"
#	Then I expect to see error with text "There are no wire details for this holder"
#
#
#Examples: 
#		| CountryCode | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | SWIFTCode   | AccountNumber          | AccountName                         | PaymentCurrency | BankCode | BankName                            | BankAddress1                        | BankAddress2                        | BankAddress3                        | BankAddress4                        | Action2 | UpdateOption2 | Warning1                      | Warning2         | Warning3                 | Warning4          | Warning5         | ChangeModify | NewTran | NewCountryCode | NewSWIFTCode | NewAccountNumber       | NewAccountName | NewPaymentCurrency | NewBankCode | NewBankName                         | NewBankAddress1      | NewBankAddress2      | NewBankAddress3      | NewBankAddress4      | ChangeModify1 | NewTran1 | ConfirmDelete | NewWarning6 | Phone |
#		| GB          | X0044348586  | S      | U       | WR            | 29307 | RBOSGB12345 | GB96MIDL40271522859882 | TESTING THE ACCOUNT NAME FOR WIREIN | GBP             | 12-34-56 | TEST BANK NAME TEST BANK NAMET NAME | TEST BANK ADDDRESS LINE1 MAX LENGTH | TEST BANK ADDDRESS LINE2 MAX LENGTH | TEST BANK ADDDRESS LINE3 MAX LENGTH | TEST BANK ADDDRESS LINE4 MAX LENGTH | W       |               | Payee instruction direct/bulk | Noting:P1        | Payee Instruction (Wire) | No DPID allocated | No Annual Report | C            | 29308   | GB             | DEUTGB22ZEQ  | GB96MIDL40271522859882 | UPDATED NAME   | USD                |             | UPDT BANK NAME TEST BANK NAMET NAME | UPDATE ADDRESS LINE1 | UPDATE ADDRESS LINE2 | UPDATE ADDRESS LINE3 | UPDATE ADDRESS LINE4 | D             | 29309    | Y             |             |       |
#		| US          | X0008646694  | S      | U       | WR            | 29407 | CETYUS66    | 123456                 | TESTING THE ACCOUNT NAME FOR WIREIN | USD             |          | TEST BANK NAME TEST BANK NAMET NAME | TEST BANK ADDDRESS LINE1 MAX LENGTH | TEST BANK ADDDRESS LINE2 MAX LENGTH | TEST BANK ADDDRESS LINE3 MAX LENGTH | TEST BANK ADDDRESS LINE4 MAX LENGTH | W       |               | Payee instruction direct/bulk | Plan participant | Payee Instruction (Wire) | No DPID allocated | No Annual Report | M            | 29408   | US             | PMFAUS66HKG  | 5566                   | UPDATED NAME   | USD                |             | UPDT BANK NAME TEST BANK NAMET NAME | UPDATE ADDRESS LINE1 | UPDATE ADDRESS LINE2 | UPDATE ADDRESS LINE3 | UPDATE ADDRESS LINE4 | D             | 29409    | Y             |             |       |
#
#@ANZ_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20728
#Scenario Outline: Test Case 20728: 01 - Overseas Wire Instructions (WR) - Add , Display , Change, Modify and Delete-TW
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#		And In OLS04204 I add Wire Instructions as "<Tran>" "<CountryCode>" "<SWIFTCode>" "<AccountNumber>" "<AccountName>" "<PaymentCurrency>" "<BankCode>" "<BankName>" "<BankAddress1>" "<BankAddress2>" "<BankAddress3>" "<BankAddress4>" "<Phone>"
#	Then I expect to be in the "OLS01102" Screen
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"	
#	When In Online Data Entry System I enter search option as "<Action2>" "<UpdateOption2>"
#	Then In OLS01106 I should see Holder Wire Instructions as "<CountryCode>" "<SWIFTCode>" "<AccountNumber>" "<AccountName>" "<PaymentCurrency>" "<BankCode>" "<BankName>" "<BankAddress1>" "<BankAddress2>" "<BankAddress3>" "<BankAddress4>"
#	When In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS04204 I Change Wire Instructions as "<ChangeModify>" "<NewTran>" "<NewCountryCode>" "<NewSWIFTCode>" "<NewAccountNumber>" "<NewAccountName>" "<NewPaymentCurrency>" "<NewBankCode>" "<NewBankName>" "<NewBankAddress1>" "<NewBankAddress2>" "<NewBankAddress3>" "<NewBankAddress4>" "<Phone>"
#	Then I expect to be in the "OLS01102" Screen
#	When In Online Data Entry System I enter search option as "<Action2>" "<UpdateOption2>"
#	Then In OLS01106 I should see Holder Wire Instructions as "<NewCountryCode>" "<NewSWIFTCode>" "<NewAccountNumber>" "<NewAccountName>" "<NewPaymentCurrency>" "<NewBankCode>" "<NewBankName>" "<NewBankAddress1>" "<NewBankAddress2>" "<NewBankAddress3>" "<NewBankAddress4>"
#	When In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS04204 I Delete Wire Instructions as "<ChangeModify1>" "<NewTran1>" "<ConfirmDelete>" 
#	Then I expect to be in the "OLS01102" Screen
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<NewWarning6>"	
#	When In Online Data Entry System I enter search option as "<Action2>" "<UpdateOption2>"
#	Then I expect to see error with text "There are no wire details for this holder"
#
#
#Examples: 
#		| CountryCode | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | SWIFTCode | AccountNumber | AccountName                         | PaymentCurrency | BankCode | BankName                            | BankAddress1                        | BankAddress2                        | BankAddress3                        | BankAddress4                        | Action2 | UpdateOption2 | Warning1                      | Warning2         | Warning3                     | Warning4                      | Warning5                 | ChangeModify | NewTran | NewCountryCode | NewSWIFTCode | NewAccountNumber | NewAccountName | NewPaymentCurrency | NewBankCode | NewBankName                         | NewBankAddress1      | NewBankAddress2      | NewBankAddress3      | NewBankAddress4      | ChangeModify1 | NewTran1 | ConfirmDelete | NewWarning6       | Phone     |
#		| TW          | X0008652619  | S      | U       | WR            | 29507 | AIACTWTP  | 123456        | TESTING THE ACCOUNT NAME FOR WIREIN | TWD             |          | TEST BANK NAME TEST BANK NAMET NAME | TEST BANK ADDDRESS LINE1 MAX LENGTH | TEST BANK ADDDRESS LINE2 MAX LENGTH | TEST BANK ADDDRESS LINE3 MAX LENGTH | TEST BANK ADDDRESS LINE4 MAX LENGTH | W       |               | Payee instruction direct/bulk | Plan participant | Holder Extra details present | Communication Methods Present | Payee Instruction (Wire) | M            | 29508   | TW             | AIACTWTP     | 5567             | UPDATED NAME   | TWD                |             | UPDT BANK NAME TEST BANK NAMET NAME | UPDATE ADDRESS LINE1 | UPDATE ADDRESS LINE2 | UPDATE ADDRESS LINE3 | UPDATE ADDRESS LINE4 | D             | 29509    | Y             | No DPID allocated | 234234234 |

@winformsTest
@OL_Online
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@FullSmokeTest
@20877
Scenario Outline: Test Case 20877: 01 - Holder Extra Details (HE) - Add ,Change/Modify, Delete Holder extra details to different holder types
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
		And In OLS01801 I Add Holder Extra Details as "<Tran>" "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<ReturnedEmail>" "<EmailFailCount>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"
	Then I expect to be in the "OLS01102" Screen
	When In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
	Then In OLS01801 I should see Holder Extra Details as "<ExtraHolderID>" "<HomeTell>" "<WorkTell>" "<Fax>" "<Mobile>" "<Email>" "<Flag1>" "<Flag2>" "<Flag3>" "<Flag4>" "<Flag5>" "<Flag6>" "<Flag7>" "<Flag8>" "<Flag9>"
		And In OLS01801 I should see Holder Extra Details Part2 as "<ReturnedEmail>" "<EmailFailCount>" "<Flag1Desc>" "<Flag2Desc>" "<Flag3Desc>" "<Flag4Desc>" "<Flag5Desc>" "<Flag6Desc>" "<Flag7Desc>" "<Flag8Desc>" "<Flag9Desc>"
	When In OLS01801 I Change Holder Extra Details as "<ModifyType>" "<NewTran>" "<NewExtraHolderID>" "<NewHomeTell>" "<NewWorkTell>" "<NewFax>" "<NewMobile>" "<NewEmail>" "<NewReturnedEmail>" "<NewEmailFailCount>" "<NewFlag1>" "<NewFlag2>" "<NewFlag3>" "<NewFlag4>" "<NewFlag5>" "<NewFlag6>" "<NewFlag7>" "<NewFlag8>" "<NewFlag9>"
	Then I expect to be in the "OLS01102" Screen
	When In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
	Then In OLS01801 I should see Holder Extra Details as "<NewExtraHolderID>" "<NewHomeTell>" "<NewWorkTell>" "<NewFax>" "<NewMobile>" "<NewEmail>" "<NewFlag1>" "<NewFlag2>" "<NewFlag3>" "<NewFlag4>" "<NewFlag5>" "<NewFlag6>" "<NewFlag7>" "<NewFlag8>" "<NewFlag9>"
		And In OLS01801 I should see Holder Extra Details Part2 as "<NewReturnedEmail>" "<NewEmailFailCount>" "<Flag1Desc>" "<Flag2Desc>" "<Flag3Desc>" "<Flag4Desc>" "<Flag5Desc>" "<Flag6Desc>" "<Flag7Desc>" "<Flag8Desc>" "<Flag9Desc>"
	When In OLS01801 I Delete Holder Extra Details as "<NewModifyType>" "<NewTran1>" "<ConfirmDelete>"
	Then I expect to be in the "OLS01102" Screen
Examples: 
	 | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | ExtraHolderID        | HomeTell             | WorkTell             | Fax                  | Mobile               | Email                        | ReturnedEmail | EmailFailCount | Flag1 | Flag2 | Flag3 | Flag4 | Flag5 | Flag6 | Flag7 | Flag8 | Flag9 | Flag1Desc  | Flag2Desc   | Flag3Desc   | Flag4Desc  | Flag5Desc                 | Flag6Desc | Flag7Desc                      | Flag8Desc        | Flag9Desc       | ModifyType | NewTran | NewExtraHolderID     | NewHomeTell          | NewWorkTell          | NewFax               | NewMobile            | NewEmail                     | NewReturnedEmail | NewEmailFailCount | NewFlag1 | NewFlag2 | NewFlag3 | NewFlag4 | NewFlag5 | NewFlag6 | NewFlag7 | NewFlag8 | NewFlag9 | NewModifyType | NewTran1 | ConfirmDelete |
	 | X0040581421  | S      | U       | HE            | 29707 | EU888997662312312324 | +61 3 8978 65789 121 | +61 3 98334 44545466 | +61 3 8978 657895 51 | +61 409 876 778 1123 | TEST.HE@COMPUTERSHARE.COM.AU |               |                | T     | S2    | S3    | TT    | E4    |       | L2    | RM    | N     | RETIREMENT | TEST FLAG 2 | TEST FLAG 3 | TEST FLAG4 | AML CPM Multi Participant |           | 2012LH ID WITH RE-CON CAMPAIGN | RETURNED CHEQUES | PRIVACY OPT OUT | M          | 29708   | EU888997662312312325 | +61 3 8978 65789 122 | +61 3 98334 44545462 | +61 3 8978 657895 52 | +61 409 876 778 1122 | AUTO.HE@COMPUTERSHARE.COM.AU |                  |                   | T        | S2       | S3       | TT       | E4       |          | L2       | RM       | N        | D             | 29709    | Y             |

@winformsTest
@OL_Onlines
@CPU_AUTO
@OL_SDM_StaticDetailMaintenance
@FullSmokeTest
Scenario: Update Employee Details
# Update Employee Details -ESS Holders
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I search "I0100012669" in Static Details update Menu
	When I update Employee Details "employee id" as below:
		| Field          | Value       |
		| Action         | C           |
		| Tran No        | 154         |
		| Employee ID    | 0001020301  |
		| Start Date     | 01012003    |
		| Preferred Name | Automation3 |
		| Birth Date     | 01011982    |
		| Business Unit  | CTS         |
		And I go to the Enquiry system for "I0100012669"
	Then In ENSESS01 I should see the holder Employee Details as below:
		| Field           | Value       |
		| HIN             | I0100012669 |
		| Employee ID     | 0001020301  |
		| Preferred Name  | AUTOMATION3 |
		| Business Unit   | CTS         |
		| Employee Status | E           |
		| Leaver Code     | EEE         |
		| Effective Date  | 12/07/2004  |

#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20841
#Scenario Outline: Test Case 20841: 01 - Add Employee Details (ED action) - Add, Change, Delete Employee Details with different Employee Status & Holder Types
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In EOL01701 I Add ESS Employee Details Part1 as "<TranNo>" "<PayrollID>" "<EmployeeID>" "<SubPayrollID>" "<GenerateEmpUniqueID>" "<EmpUniqueID>" "<StartDate>" "<TermDate>" "<TermDesc>" "<PreferredName>" "<EmployeeStatus>" "<LeaverCode>" "<EffectiveDate>" "<BirthDate>" "<AutoForfeit>" "<BlackoutInd>" "<BlackoutCode>" "<LocationCode>"
#		And In EOL01701 I Add ESS Employee Details Part2 as "<BusinessUnit>" "<JobBand>" "<CostCentre>" "<EmpFlag1>" "<EmpFlag2>" "<Offers>" "<Statements>" "<SharePlanComm>" "<NoticeOfMeeting>"
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#	Then In EOL01701 I should see ESS Employee Details Part1 as "<NewTranNo>" "<PayrollID>" "<EmployeeID>" "<SubPayrollID>" "<GenerateEmpUniqueID>" "<EmpUniqueID>" "<StartDate>" "<TermDate>" "<TermDesc>" "<PreferredName>" "<EmployeeStatus>" "<LeaverCode>" "<EffectiveDate>" "<BirthDate>" "<AutoForfeit>" "<BlackoutInd>" "<BlackoutCode>" "<LocationCode>"
#		And In EOL01701 I should see ESS Employee Details Part2 as "<BusinessUnit>" "<JobBand>" "<CostCentre>" "<EmpFlag1>" "<EmpFlag2>" "<Offers>" "<Statements>" "<SharePlanComm>" "<NoticeOfMeeting>"
#	When In EOL01701 I Change ESS Employee Details Part1 as "<NewTranNo>" "<NewPayrollID>" "<NewEmployeeID>" "<NewSubPayrollID>" "<NewGenerateEmpUniqueID>" "<NewEmpUniqueID>" "<NewStartDate>" "<NewTermDate>" "<NewTermDesc>" "<NewPreferredName>" "<NewEmployeeStatus>" "<NewLeaverCode>" "<NewEffectiveDate>" "<NewBirthDate>" "<NewAutoForfeit>" "<NewBlackoutInd>" "<NewBlackoutCode>" "<NewLocationCode>"
#		And In EOL01701 I Change ESS Employee Details Part2 as "<NewBusinessUnit>" "<NewJobBand>" "<NewCostCentre>" "<NewEmpFlag1>" "<NewEmpFlag2>" "<NewOffers>" "<NewStatements>" "<NewSharePlanComm>" "<NewNoticeOfMeeting>"
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#	Then In EOL01701 I should see ESS Employee Details Part1 as "<NewTranNo1>" "<NewPayrollID>" "<NewEmployeeID>" "<NewSubPayrollID>" "<NewGenerateEmpUniqueID>" "<NewEmpUniqueID>" "<NewStartDate>" "<NewTermDate>" "<NewTermDesc>" "<NewPreferredName>" "<NewEmployeeStatus>" "<NewLeaverCode>" "<NewEffectiveDate>" "<NewBirthDate>" "<NewAutoForfeit>" "<NewBlackoutInd>" "<NewBlackoutCode>" "<NewLocationCode>"
#		And In EOL01701 I should see ESS Employee Details Part2 as "<NewBusinessUnit>" "<NewJobBand>" "<NewCostCentre>" "<NewEmpFlag1>" "<NewEmpFlag2>" "<NewOffers>" "<NewStatements>" "<NewSharePlanComm>" "<NewNoticeOfMeeting>"
#	When In EOL01701 I Delete ESS Employee Details as "<NewTranNo1>" "<ConfirmDelete>" 	
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<UpdateOption>"
#		And I enter the following details as the locatActions "<Action3>"  "<LocateArgument3>"
#	Then I expect to see error with text "There are NO employee details for this holder."
#Examples: 
#	| UpdateOption | Action | Action1 | UpdateOption1 | TranNo | PayrollID | EmployeeID | SubPayrollID | GenerateEmpUniqueID | EmpUniqueID | StartDate | TermDate | TermDesc | PreferredName | EmployeeStatus | LeaverCode | EffectiveDate | BirthDate  | AutoForfeit | BlackoutInd | BlackoutCode | LocationCode | BusinessUnit | JobBand | CostCentre | EmpFlag1 | EmpFlag2 | Offers | Statements | SharePlanComm | NoticeOfMeeting | NewTranNo | NewPayrollID | NewEmployeeID | NewSubPayrollID | NewGenerateEmpUniqueID | NewEmpUniqueID | NewStartDate | NewTermDate | NewTermDesc       | NewPreferredName | NewEmployeeStatus | NewLeaverCode | NewEffectiveDate | NewBirthDate | NewAutoForfeit | NewBlackoutInd | NewBlackoutCode | NewLocationCode | NewBusinessUnit | NewJobBand | NewCostCentre | NewEmpFlag1 | NewEmpFlag2 | NewOffers | NewStatements | NewSharePlanComm | NewNoticeOfMeeting | NewTranNo1 | ConfirmDelete | Action3 | LocateArgument3 | 
#	| I0030666186  | S      | U       | ED            | 29805  | 13        | EMP1234567 |              | N                   | 1479317458  | 01/02/15  |          |          | IDOG CIFGAJ   | E              | EEE        | 03/02/2015    | 03/02/2015 | Y           | N           |              | VIC          | MELY         | JB13    | 5090120    | 1        | 2        | E      | O          | O             | E               | 29806     | 13           | EMP1534987    | OUTSCOPE 49     | N                      | 1479317985     | 02/02/15     | 02/03/15    | EMPLOYEE START 02 | IDOG CIFGAJ      | L                 | LLL           | 03/04/2015       | 01/01/1985   | N              | N              | N               | VIC             | MELB            | JB13       | 5090120       | 3           | 4           | O         | O             | E                | E                  | 29807      | Y             | ED      |                 | 

#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20843
#Scenario Outline: Test Case 20843: 02 - Add Employee Details (ED action) - Not allowed with Holder Type 'CNT' and Chess Holders
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In EOL01701 I Add ESS Employee Details Part1 as "<TranNo>" "<PayrollID>" "<EmployeeID>" "<SubPayrollID>" "<GenerateEmpUniqueID>" "<EmpUniqueID>" "<StartDate>" "<TermDate>" "<TermDesc>" "<PreferredName>" "<EmployeeStatus>" "<LeaverCode>" "<EffectiveDate>" "<BirthDate>" "<AutoForfeit>" "<BlackoutInd>" "<BlackoutCode>" "<LocationCode>"
#		And In EOL01701 I Add ESS Employee Details Part2 as "<BusinessUnit>" "<JobBand>" "<CostCentre>" "<EmpFlag1>" "<EmpFlag2>" "<Offers>" "<Statements>" "<SharePlanComm>" "<NoticeOfMeeting>"
#	Then I expect to see error with text "Holder must be Certificated or Issuer Sponsored"
#		
#Examples: 		
#	| UpdateOption | Action | Action1 | UpdateOption1 | TranNo | PayrollID | EmployeeID | SubPayrollID | GenerateEmpUniqueID | EmpUniqueID | StartDate | TermDate | TermDesc | PreferredName | EmployeeStatus | LeaverCode | EffectiveDate | BirthDate | AutoForfeit | BlackoutInd | BlackoutCode | LocationCode | BusinessUnit | JobBand | CostCentre | EmpFlag1 | EmpFlag2 | Offers | Statements | SharePlanComm | NoticeOfMeeting |
#	| X0045468798  | S      | U       | ED            | 29905  |           | EMP1234575 |              |                     |             |           |          |          |               |                |            |               |           |             |             |              |              |              |         |            |          |          | O      | O          | O             | O               |  

#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20709
#Scenario Outline: Test Case 20709: 02 - Unconfirmed Deceased (UD) - with Holder Type IND
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS06801 I Add Unconfirmed Deceased details as "<Tran>" "<TranDate>" "<HolderStatus>"
#		And In OLS01403 I Add Deceased Estate Noting Update Part1 as "<Register>" "<DeceasedName>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<WillSightedDate>" "<SmallEstate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>" "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>"
#		And In OLS01403 I Add Deceased Estate Noting Details Part2 as "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#		And In OLS06803 I add New Registered Address Details as "<DeceasedEstatePack>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>" "<ThirdPartyPostcode>"
#		And In OLS06805 I add Forwarding Address Details as "<YourReference>" "<Dear>" "<ForwardingAddress1>" "<ForwardingAddress2>" "<ForwardingAddress3>" "<ForwardingAddress4>" "<ForwardingAddress5>" "<ForwardingAddress6>" "<ForwardingPostcode>" "<OverrideEstateSize>"
#	Then In OLS06807 I should see Deceased Estate Pack Selection options as "<Probate>" "<DeathCert>" "<Will>" "<Reseal>" "<A121>" "<B1071>" "<SmallEstate1>" "<ConfirmID>"
#	When In OLS06807 I add Deceased Estate Pack Selection options as "<PaymentInstructions>" "<LocateHoldings>" "<SpecificPOA>" "<SRNUnknown>" "<TFNUpdated>" "<ConfirmOfID>" "<LegalName>" "<NoTradingBlock>" "<ValueDOD>" "<CGTInfo>" "<TransactionHistory>" "<DivHistory>" "<PaymentReceived>" "<DateFirstShareholder>" "<LegalsMet>" "<OPSRequested>"
#	Then In OLS068CS I should see Unconfirmed Deceased Static Changes Summary as "<StaticAction1>" "<StaticAction2>" "<StaticAction3>" "<StaticAction4>" "<StaticAction5>" "<StaticAction6>" "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<ThirdPartyPostcode>"
#	Then In OLS01102 I should see Holder Address Details as "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>"
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
#	Then In OLS01102 I should see Holder UD Static details as "<Type>" "<Deceased>"
#	Given I have connected to WinForms	
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<UpdateOption>"
#		And I enter the following details as the locatActions "<Action2>"  "<LocateArgument2>"
#	Then I expect to see error with text "There is no payee instruction for this holder."
#		When I enter the following details as the locatActions "<Action3>"  "<LocateArgument2>"
#	Then In ENS01005 I should see holder Deceased Estate Notings Part1 as "<NotingNbr>" "<Key>" "<Register>" "<DeceasedName>" "<Run>" "<Tran1>" "<UpdateOption>" "<Type>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<SmallEstate>" "<WillSightedDate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>"
#	Then In ENS01005 I should see holder Deceased Estate Notings Part2 as  "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>" "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#Examples: 		
#	| Test  | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | TranDate   | HolderStatus | Register | DeceasedName     | DateOfDeath | DeathCertSighted | WillDated  | WillSightedDate | SmallEstate | ProbateGrantedIn | ProbateGrantedOn | ProbateightedDate | ReSealedIn | ReSealedOn | Sec183     | Sec121A | ConfirmationID | Executor1              | Executor2               | Executor3                | Comment1                           | Comment2                         | Comment3                                 | Lodged          | DeceasedEstatePack | Address1               | Address2               | Address3  | Address4 | Address5  | ThirdPartyPostcode | YourReference | Dear            | ForwardingAddress1 | ForwardingAddress2 | ForwardingAddress3 | ForwardingAddress4 | ForwardingAddress5 | ForwardingAddress6 | ForwardingPostcode | OverrideEstateSize | PaymentInstructions | LocateHoldings | SpecificPOA | SRNUnknown | TFNUpdated | ConfirmOfID | LegalName        | NoTradingBlock | ValueDOD | CGTInfo | TransactionHistory | DivHistory | PaymentReceived | DateFirstShareholder | LegalsMet | OPSRequested | Probate | DeathCert | Will | Reseal | A121 | B1071 | SmallEstate1 | ConfirmID | NewAddress1                  | NewAddress2 | StaticAction1                      | StaticAction2                  | StaticAction3                   | StaticAction4                      | StaticAction5                  | StaticAction6                   | Warning1             | Warning2                      | Warning3                     | Warning4          | Warning5                     | Type | Deceased | Action2 | LocateArgument2 | Action3 | NotingNbr | Key                      | Run  | Tran1   |
#	| Test1 | I0030434676  | S      | U       | UD            | 50704 | 08/07/2015 | U            | WA       | LADY CAMIHQV RIQ | 01/01/2012  | 01/01/2012       | 01/01/2012 | 01/01/2012      | Y           | 01/01/2012       | 01/01/2012       | 01/01/2012        | 01/01/2012 | 01/01/2012 | 01/01/2012 | Y       | Y              | UK TAX CONTROL ACCOUNT | MR MICHAEL NOEL ADAMSON | CABCOEYH    CIQIPERIINUA | NOTING ADDED VIA UDADD TRANSACTION | UNCONFIRMED DECEASED TRANSACTION | COMMENTS RELATING TO THE DECEASED HOLDER | MR PETAR ANDRIC | Y                  | 20 GRANGE PARK TERRACE | WEST YORKSHIRE LS8 3BX | MELBOURNE | VIC      | AUSTRALIA | 3978               | MRG87653      | MR PETAR ANDRIC | MR PETAR ANDRIC    | 67 VIMNEX ROAD     | NIBGSB             | MELBOURNE          | VIC                | AUSTRALIA          | 3103               | L                  | A                   | R              | A           | R          | A          | Y           | LADY CAMIHQV RIQ | Y              | Y        | Y       | 1                  | 1          | Y               | Y                    | Y         | Y            | Y       | Y         | Y    | Y      | Y    | Y     | N            | Y         | ESTATE LATE LADY CAMIHQV RIQ | CABCOEYH,   | - Update Holder Name and Address   | - Set Deceased flag to "Y"     | - Set holder type to "DEC"      | - Create Deceased Estate Noting D1 | - Estate Value Overridden to L | - Generate Deceased Estate Pack | Unconfirmed Deceased | Noting:D1/N3                  | Holder Extra details present | No DPID allocated | No Annual Report             | DEC  | Y        | PI      |                 | D1      | 1         | CABCOEYH    CAMIHQRIQ    | 6095 | 5120010 |
#	| Test2 | X0035704531  | S      | U       | UD            | 50501 | 08/07/2015 | U            | WA       | LADY CAMIHQV RIQ | 01/01/2012  | 01/01/2012       | 01/01/2012 | 01/01/2012      | N           | 01/01/2012       | 01/01/2012       | 01/01/2012        | 01/01/2012 | 01/01/2012 | 01/01/2012 | Y       | N              | UK TAX CONTROL ACCOUNT | MR MICHAEL NOEL ADAMSON | CABCOEYH    CIQIPERIINUA | NOTING ADDED VIA UDADD TRANSACTION | UNCONFIRMED DECEASED TRANSACTION | COMMENTS RELATING TO THE DECEASED HOLDER | MR PETAR ANDRIC | Y                  |                        |                        |           |          |           |                    | MRG87654      | MR PETAR ANDRIC | MR PETAR ANDRIC    | 67 VIMNEX ROAD     | NIBGSB             | MELBOURNE          | VIC                | AUSTRALIA          | 3103               | S                  | R                   | N              | N           |            | N          |             |                  | N              | N        | N       | 1                  | 1          | N               | N                    | N         | N            | Y       | Y         | Y    | Y      | Y    | Y     | N            | N         |                              |             | - Remove Payment Instruction       | - Set Deceased flag to "Y"     | - Set holder type to "DEC"      | - Create Deceased Estate Noting D1 | - Estate Value Overridden to S | - Generate Deceased Estate Pack | Unconfirmed Deceased | Noting:D1                     | No DPID allocated            | No Annual Report  |                              | DEC  | Y        | PI      |                 | D1      | 1         | CABCOEYH    CIQIPERIINUA | 6095 | 5120006 |

#@WES_AUTO
#@OL_SDM_StaticDetailMaintenance
#@20710
#Scenario Outline: Test Case 20710: 03 - Unconfirmed Deceased (UD) - with Holder Type JNT
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS06801 I Add Unconfirmed Deceased details as "<Tran>" "<TranDate>" "<HolderStatus>"
#		And In OLS01403 I Add Deceased Estate Noting Update Part1 as "<Register>" "<DeceasedName>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<WillSightedDate>" "<SmallEstate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>" "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>"
#		And In OLS01403 I Add Deceased Estate Noting Details Part2 as "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#		And In OLS06803 I add New Registered Address Details as "<DeceasedEstatePack>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>" "<ThirdPartyPostcode>"
#		And In OLS06805 I add Forwarding Address Details as "<YourReference>" "<Dear>" "<ForwardingAddress1>" "<ForwardingAddress2>" "<ForwardingAddress3>" "<ForwardingAddress4>" "<ForwardingAddress5>" "<ForwardingAddress6>" "<ForwardingPostcode>" "<OverrideEstateSize>"
#	Then In OLS06807 I should see Deceased Estate Pack Selection options as "<Probate>" "<DeathCert>" "<Will>" "<Reseal>" "<A121>" "<B1071>" "<SmallEstate1>" "<ConfirmID>"
#	When In OLS06807 I add Deceased Estate Pack Selection options as "<PaymentInstructions>" "<LocateHoldings>" "<SpecificPOA>" "<SRNUnknown>" "<TFNUpdated>" "<ConfirmOfID>" "<LegalName>" "<NoTradingBlock>" "<ValueDOD>" "<CGTInfo>" "<TransactionHistory>" "<DivHistory>" "<PaymentReceived>" "<DateFirstShareholder>" "<LegalsMet>" "<OPSRequested>"
#	Then In OLS068CS I should see Unconfirmed Deceased Static Changes Summary as "<StaticAction1>" "<StaticAction2>" "<StaticAction3>" "<StaticAction4>" "<StaticAction5>" "<StaticAction6>" "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<ThirdPartyPostcode>"
#	Then In OLS01102 I should see Holder Address Details as "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>"
#	Then In OLS01102 I should see Holder Warning as "<Warning1>" "<Warning2>" "<Warning3>" "<Warning4>" "<Warning5>"
#	Then In OLS01102 I should see Holder UD Static details as "<Type>" "<Deceased>"
#	Given I have connected to WinForms	
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<UpdateOption>"
#		When I enter the following details as the locatActions "<Action3>"  "<LocateArgument2>"
#	Then In ENS01005 I should see holder Deceased Estate Notings Part1 as "<NotingNbr>" "<Key>" "<Register>" "<DeceasedName>" "<Run>" "<Tran1>" "<UpdateOption>" "<Type>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<SmallEstate>" "<WillSightedDate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>"
#	Then In ENS01005 I should see holder Deceased Estate Notings Part2 as  "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>" "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
#		And In OLS06801 I Add Unconfirmed Deceased details as "<NewTran>" "<NewTranDate>" "<NewHolderStatus>"
#		And In OLS01403 I Add Deceased Estate Noting Update Part1 as "<Register>" "<DeceasedName>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<WillSightedDate>" "<SmallEstate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>" "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>"
#		And In OLS01403 I Add Deceased Estate Noting Details Part2 as "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#		And In OLS06803 I add New Registered Address Details as "<DeceasedEstatePack>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<Address5>" "<ThirdPartyPostcode>"
#		And In OLS06805 I add Forwarding Address Details as "<NewYourReference>" "<Dear>" "<ForwardingAddress1>" "<ForwardingAddress2>" "<ForwardingAddress3>" "<ForwardingAddress4>" "<ForwardingAddress5>" "<ForwardingAddress6>" "<ForwardingPostcode>" "<OverrideEstateSize>"
#	Then In OLS06807 I should see Deceased Estate Pack Selection options as "<Probate>" "<DeathCert>" "<Will>" "<Reseal>" "<A121>" "<B1071>" "<SmallEstate1>" "<ConfirmID>"
#	When In OLS06807 I add Deceased Estate Pack Selection options as "<PaymentInstructions>" "<LocateHoldings>" "<SpecificPOA>" "<SRNUnknown>" "<TFNUpdated>" "<ConfirmOfID>" "<LegalName>" "<NoTradingBlock>" "<ValueDOD>" "<CGTInfo>" "<TransactionHistory>" "<DivHistory>" "<PaymentReceived>" "<DateFirstShareholder>" "<LegalsMet>" "<OPSRequested>"
#	Then In OLS068CS I should see Unconfirmed Deceased Static Changes Summary as "<NewStaticAction1>" "<NewStaticAction2>" "<NewStaticAction3>" "<NewStaticAction4>" "<NewStaticAction5>" "<NewStaticAction6>" "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<ThirdPartyPostcode>"
#	Then In OLS01102 I should see Holder Address Details as "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>"
#	Then In OLS01102 I should see Holder Warning as "<NewWarning1>" "<NewWarning2>" "<NewWarning3>" "<NewWarning4>" "<NewWarning5>"
#	Then In OLS01102 I should see Holder UD Static details as "<NewType>" "<NewDeceased>"
#	Given I have connected to WinForms	
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<UpdateOption>"
#		And I enter the following details as the locatActions "<Action2>"  "<LocateArgument2>"
#	Then I expect to see error with text "There is no payee instruction for this holder."
#		When I enter the following details as the locatActions "<Action4>"  "<LocateArgument2>"
#	Then In ENS01005 I should see holder Deceased Estate Notings Part1 as "<NewNotingNbr>" "<Key>" "<Register>" "<DeceasedName>" "<Run>" "<NewTran1>" "<UpdateOption>" "<NewType>" "<DateOfDeath>" "<DeathCertSighted>" "<WillDated>" "<SmallEstate>" "<WillSightedDate>" "<ProbateGrantedIn>" "<ProbateGrantedOn>"
#	Then In ENS01005 I should see holder Deceased Estate Notings Part2 as  "<ProbateightedDate>" "<ReSealedIn>" "<ReSealedOn>" "<Sec183>" "<Sec121A>" "<ConfirmationID>" "<Executor1>" "<Executor2>" "<Executor3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>"
#
#Examples: 		
#	 | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | TranDate   | HolderStatus | Register | DeceasedName     | DateOfDeath | DeathCertSighted | WillDated  | WillSightedDate | SmallEstate | ProbateGrantedIn | ProbateGrantedOn | ProbateightedDate | ReSealedIn | ReSealedOn | Sec183     | Sec121A | ConfirmationID | Executor1              | Executor2               | Executor3                | Comment1                           | Comment2                         | Comment3                                 | Lodged          | DeceasedEstatePack | Address1 | Address2 | Address3 | Address4 | Address5 | ThirdPartyPostcode | YourReference | Dear            | ForwardingAddress1 | ForwardingAddress2 | ForwardingAddress3 | ForwardingAddress4 | ForwardingAddress5 | ForwardingAddress6 | ForwardingPostcode | OverrideEstateSize | PaymentInstructions | LocateHoldings | SpecificPOA | SRNUnknown | TFNUpdated | ConfirmOfID | LegalName | NoTradingBlock | ValueDOD | CGTInfo | TransactionHistory | DivHistory | PaymentReceived | DateFirstShareholder | LegalsMet | OPSRequested | Probate | DeathCert | Will | Reseal | A121 | B1071 | SmallEstate1 | ConfirmID | NewAddress1 | NewAddress2 | StaticAction1                      | StaticAction2                  | StaticAction3                   | StaticAction4 | StaticAction5 | StaticAction6 | Warning1             | Warning2                      | Warning3         | Warning4  | Warning5                     | Type | Deceased | Action2 | LocateArgument2 | Action3 | NotingNbr | Key                            | Run  | Tran1   | NewTran | NewTranDate | NewHolderStatus | NewYourReference | NewStaticAction1             | NewStaticAction2       | NewStaticAction3           | NewStaticAction4           | NewStaticAction5                   | NewStaticAction6               | NewWarning1          | NewWarning2      | NewWarning3  | NewWarning4                  | NewWarning5       | NewType | NewNotingNbr | NewTran1 | NewDeceased | Action4 |
#	 | X0012506007  | S      | U       | UD            | 50502 | 08/07/2015 | U            | WA       | LADY CAMIHQV RIQ | 01/01/2012  | 01/01/2012       | 01/01/2012 | 01/01/2012      | N           | 01/01/2012       | 01/01/2012       | 01/01/2012        | 01/01/2012 | 01/01/2012 | 01/01/2012 | Y       | N              | UK TAX CONTROL ACCOUNT | MR MICHAEL NOEL ADAMSON | CABCOEYH    CIQIPERIINUA | NOTING ADDED VIA UDADD TRANSACTION | UNCONFIRMED DECEASED TRANSACTION | COMMENTS RELATING TO THE DECEASED HOLDER | MR PETAR ANDRIC | Y                  |          |          |          |          |          |                    | MRG87655      | MR PETAR ANDRIC | MR PETAR ANDRIC    | 67 VIMNEX ROAD     | NIBGSB             | MELBOURNE          | VIC                | AUSTRALIA          | 3103               | L                  | R                   | N              | N           |            | N          |             |           | N              | N        | N       | 1                  | 1          | N               | N                    | N         | N            | Y       | Y         | Y    | Y      | Y    | Y     | N            | N         |             |             | - Create Deceased Estate Noting D1 | - Estate Value Overridden to L | - Generate Deceased Estate Pack |               |               |               | Unconfirmed Deceased | Payee instruction direct/bulk | Plan participant | Noting:D1 | Holder Extra details present | JNT  | N        | PI      |                 | D1      | 1         | BLOWP       LAFP  CDEXJRSUPERA | 6095 | 5120005 | 50503   | 08/07/2015  | U               | MRG87656         | - Remove Payment Instruction | - Remove Email address | - Set Deceased flag to "Y" | - Set holder type to "DEC" | - Create Deceased Estate Noting D2 | - Estate Value Overridden to L | Unconfirmed Deceased | Plan participant | Noting:D1/D2 | Holder Extra details present | No DPID allocated | DEC     | 2            | 5120009  | Y           | D2      |


#@WES_AUTO
#Scenario Outline: Test Case 20760: 05 - Unconfirmed Deceased (UD) - Reverse Transaction with Holder Type IND & JNT
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"	
#		And In OLS06801 I Change Unconfirmed Deceased details as "<Tran>" "<TranDate>" "<KnownStatus1>"
#	Then In OLS068CS I should see Unconfirmed Deceased Static Changes Summary as "<StaticAction1>" "<StaticAction2>" "<StaticAction3>" "<StaticAction4>" "<StaticAction5>" "<StaticAction6>" "<NewAddress1>" "<NewAddress2>" "<Address1>" "<Address2>" "<Address3>" "<Address4>" "<ThirdPartyPostcode>"
#
#Examples: 		
#	 | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | TranDate   | KnownStatus1 | StaticAction1                         | StaticAction2 | StaticAction3 | StaticAction4 | StaticAction5 | StaticAction6 | NewAddress1 | NewAddress2 | Address1 | Address2 | Address3 | Address4 | ThirdPartyPostcode |
#	 | I0030279930  | S      | U       | UD            | 50503 | 09/07/2015 |              | - Holder's Unconfirmed status cleared |               |               |               |               |               |             |             |          |          |          |          |                    |


@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@19369
Scenario Outline: Update Confirmed and Unconfiemd Deceased (CD) state - From U to C and C to U with Holder Type IND
	#Test Case 19369: 01 - Confirmed Deceased (CD) - From U to C with Holder Type IND
	#Test Case 19397: 03 - Confirmed Deceased (CD) - Reverse CD From C to U with Holder Type IND
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS06801 I enter or confirm the following details
		| KnownName1   | KnownStatus1   | KnownName2   | KnownStatus2   | KnownName3   | KnownStatus3   | KnownName4   | KnownStatus4   | KnownName1   | KnownStatus5   | TransNumber | NameAndAddress   | Postcode   | Warnings   | HolderIdentifier   | HolderType   | HolderNameKey   |
		| <KnownName1> | <KnownStatus1> | <KnownName2> | <KnownStatus2> | <KnownName3> | <KnownStatus3> | <KnownName4> | <KnownStatus4> | <KnownName1> | <KnownStatus5> | <Trans>     | <KnownName1> | <Postcode> | <Warnings> | <HolderIdentifier> | <HolderType> | <HolderNameKey> |
		And In OLS068CS I confirm the following details
		| Actions   | TransNumber | NameAndAddress   | Postcode   | HolderIdentifier   | HolderType   | DeceasedHolderName   |
		| <Actions> | <Trans>     | <NameAndAddress> | <Postcode> | <HolderIdentifier> | <HolderType> | <DeceasedHolderName> |
	Then In OLS01102 I confirm the following details
		| HolderNameKey   | HolderIdentifier   | HolderTypeCode | HnaLineCh1to30R | AusPostcode | HolderOtherTaxCode   | Dpid   | HolderGroupCode     | VariableField   | BrokerCode   | FastRegister   | HolderKeyModifier   | HolderAlternateId   | Warnings        | Array1Ln14   | Array1Ln16   | HstStopTrade   | HvfFlag1   | HvfFlag2   | ResidencyInd   | MailUnclaimedDate   | ArStatusDescription   | BirthDate   | Action    | UpdateOption    | Confirm   | SearchData   | SystemInfoFree6   | SystemInfoFree4   | SystemInfoFree7   | SystemInfoFree5   |
		| <HolderNameKey> | <HolderIdentifier> | <HolderType>   | <NameAndAddress>    | <Postcode>  | <HolderOtherTaxCode> | <Dpid> | <HolderGroupCode  > | <VariableField> | <BrokerCode> | <FastRegister> | <HolderKeyModifier> | <HolderAlternateId> | <WarningsAfter> | <Array1Ln14> | <Array1Ln16> | <HstStopTrade> | <HvfFlag1> | <HvfFlag2> | <ResidencyInd> | <MailUnclaimedDate> | <ArStatusDescription> | <BirthDate> | <Action2> | <UpdateOption2> | <Confirm> | <SearchData> | <SystemInfoFree6> | <SystemInfoFree4> | <SystemInfoFree7> | <SystemInfoFree5> |
    When I exit to main from online system 
	And I go to the Enquiry system and Search <UpdateOption>
	Then In ENS01001 form I verify the following
	 | HolderTypeCode | HnaLine      | Array1   | HstAnnualReport   |
	 | <HolderType>   | <KnownName1> | <Array1> | <HstAnnualReport> |
	 
 Examples: 
		| Test  | Action | UpdateOption | Action1 | UpdateOption1 | Trans | KnownName1                    | KnownStatus1 | KnownName2                | KnownStatus2 | KnownName3 | KnownStatus3 | KnownName4 | KnownStatus4 | KnownStatus5 | TransNumber | NameAndAddress                | Postcode | Warnings             | HolderIdentifier | HolderType | HolderNameKey                  | DeceasedHolderName              | HolderOtherTaxCode | Dpid | HolderGroupCode | VariableField | BrokerCode | FastRegister | HolderKeyModifier | HolderAlternateId | WarningsAfter        | Array1Ln14 | Array1Ln16 | HstStopTrade | HvfFlag1 | HvfFlag2 | ResidencyInd | MailUnclaimedDate | ArStatusDescription | BirthDate | Action2 | UpdateOption2 | Confirm | SearchData | SystemInfoFree6 | SystemInfoFree4 | SystemInfoFree7 | SystemInfoFree5 | Array1 | HstAnnualReport | Actions                                                    |
		| Test1 | S      | I0130608574  | U       | CD            | 1112  | ESTATE LATE GOFAL CIXCI IPQET | C            |                           |              |            |              |            |              |              | <Trans>     | ESTATE LATE GOFAL CIXCI IPQET | 2046     | Unconfirmed Deceased | I0130608574      | DEC        | IPQET       GOFAL CIXCI        | ESTATE LATE GOFAL CIXCI IPQET   |                    |      |                 |               | 57516      |              |                   | 0030608577        | Confirmed Deceased   | Y          |            |              |          |          |              |                   |                     |           |         |               |         |            |                 |                 |                 |                 | Y      | N               | - Holder's Unconfirmed status set to Confirmed Deceased    |
		| Test2 | S      | X0033414587  | U       | CD            | 1113  | DR BUXF I'QESTOPOL,           | C            |                           |              |            |              |            |              |              | <Trans>     | DR BUXF I'QESTOPOL,           | 3122     | Unconfirmed Deceased | X0033414587      | DEC        | IQESTOPOL   BUXF               | DR BUXF I'QESTOPOL              |                    |      |                 |               | 1226       |              |                   |                   | Confirmed Deceased   | Y          |            |              |          |          |              |                   |                     |           |         |               |         |            |                 |                 |                 |                 | Y      | N               | - Holder's Unconfirmed status set to Confirmed Deceased    |
		| Test3 | S      | I0030597036  | U       | CD            | 1114  | ESTATE LATE KIBU RIMUE        | U            |                           |              |            |              |            |              |              | <Trans>     | ESTATE LATE KIBU RIMUE        | 3169     | Confirmed Deceased   | I0030597036      | DEC        | ISOCWECH    KIBU  RIMUE        | ESTATE LATE KIBU RIMUE ISOCWECH |                    |      |                 |               | 57516      |              |                   |                   | Unconfirmed Deceased | Y          |            |              |          |          |              |                   |                     |           |         |               |         |            |                 |                 |                 |                 | Y      | N               | - Holder's Confirmed status reversed to Unconfirmed status |
		| Test4 | S      | X0026808014  | U       | CD            | 1115  | MR VUTCEIY EHFCIMR ISUCH,     | U            |                           |              |            |              |            |              |              | <Trans>     | MR VUTCEIY EHFCIMR ISUCH,     | 4105     | Confirmed Deceased   | X0026808014      | DEC        | ISUCH       VUTCEIEHFCIM       | MR VUTCEIY EHFCIMR ISUCH        |                    |      |                 |               | 1226       |              |                   | 0002136478        | Unconfirmed Deceased | Y          |            |              |          |          |              |                   |                     |           |         |               |         |            |                 |                 |                 |                 | Y      | N               | - Holder's Confirmed status reversed to Unconfirmed status |


@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@19394
Scenario Outline: Update Confirmed and Unconfiemd Deceased (CD) state - From U to C and C to U with Holder Type JNT
	#Test Case 19394: 02 - Confirmed Deceased (CD) - From U to C with Holder Type JNT
	#Test Case 19399: 04 - Confirmed Deceased (CD) - Reverse CD From C to U with Holder Type JNT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS06801 I enter or confirm the following details
		| KnownName1   | KnownStatus1   | KnownName2   | KnownStatus2   | KnownName3   | KnownStatus3   | KnownName4   | KnownStatus4   | KnownName1   | KnownStatus5   | TransNumber | NameAndAddress | Postcode   | Warnings        | HolderIdentifier   | HolderType   | HolderNameKey   |
		| <KnownName1> | <KnownStatus1> | <KnownName2> | <KnownStatus2> | <KnownName3> | <KnownStatus3> | <KnownName4> | <KnownStatus4> | <KnownName1> | <KnownStatus5> | <Trans>     | <KnownName1>   | <Postcode> | <Warnings> | <HolderIdentifier> | <HolderType> | <HolderNameKey> |
		And In OLS068CS I confirm the following details
		| Actions   | TransNumber | NameAndAddress   | Postcode   | HolderIdentifier   | HolderType   | DeceasedHolderName   |
		| <Actions> | <Trans>     | <NameAndAddress> | <Postcode> | <HolderIdentifier> | <HolderType> | <DeceasedHolderName> |
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And  In OLS06801 I enter or confirm the following details for second JNT holder
		| KnownName1   | KnownStatus1   | KnownName2   | KnownStatus2   | KnownName3   | KnownStatus3   | KnownName4   | KnownStatus4   | KnownName1   | KnownStatus5   | TransNumber | NameAndAddress   | Postcode   | Warnings   | HolderIdentifier   | HolderType   | HolderNameKey   |
		| <KnownName1> | <KnownStatus1> | <KnownName2> | <SeconHolStatus2> | <KnownName3> | <KnownStatus3> | <KnownName4> | <KnownStatus4> | <KnownName1> | <KnownStatus5> | <Trans2>     | <KnownName1> | <Postcode> | <WarningsAfter> | <HolderIdentifier> | <HolderType> | <HolderNameKey> |
		And In OLS068CS I confirm the following details
		| Actions   | TransNumber | NameAndAddress   | Postcode   | HolderIdentifier   | HolderType   | DeceasedHolderName   |
		| <Actions> | <Trans2>     | <NameAndAddress> | <Postcode> | <HolderIdentifier> | <HolderType> | <KnownName2> |
	Then In OLS01102 I confirm the following details
		| HolderNameKey   | HolderIdentifier   | HolderTypeCode | HnaLineCh1to30R  | AusPostcode | HolderOtherTaxCode   | Dpid   | HolderGroupCode     | VariableField   | BrokerCode   | FastRegister   | HolderKeyModifier   | HolderAlternateId   | Warnings        | Array1Ln14   | Array1Ln16   | HstStopTrade   | HvfFlag1   | HvfFlag2   | ResidencyInd   | MailUnclaimedDate   | ArStatusDescription   | BirthDate   | Action    | UpdateOption    | Confirm   | SearchData   | SystemInfoFree6   | SystemInfoFree4   | SystemInfoFree7   | SystemInfoFree5   |
		| <HolderNameKey> | <HolderIdentifier> | <HolderType>   | <NameAndAddress> | <Postcode>  | <HolderOtherTaxCode> | <Dpid> | <HolderGroupCode  > | <VariableField> | <BrokerCode> | <FastRegister> | <HolderKeyModifier> | <HolderAlternateId> | <FinalWarning> | <Array1Ln14> | <Array1Ln16> | <HstStopTrade> | <HvfFlag1> | <HvfFlag2> | <ResidencyInd> | <MailUnclaimedDate> | <ArStatusDescription> | <BirthDate> | <Action2> | <UpdateOption2> | <Confirm> | <SearchData> | <SystemInfoFree6> | <SystemInfoFree4> | <SystemInfoFree7> | <SystemInfoFree5> |
    When I exit to main from online system 
	And I go to the Enquiry system and Search <UpdateOption>
	Then In ENS01001 form I verify the following
	 | HolderTypeCode | HnaLine      | Array1   | HstAnnualReport   |
	 | <HolderType>   | <KnownName1> | <Array1> | <HstAnnualReport> |
	 
 Examples: 
		| Test  | Action | UpdateOption | Action1 | UpdateOption1 | Trans | Trans2 | KnownName1                   | KnownStatus1 | KnownName2                | KnownStatus2 | SeconHolStatus2 | KnownName3 | KnownStatus3 | KnownName4 | KnownStatus4 | KnownStatus5 | TransNumber | NameAndAddress               | Postcode | Warnings             | HolderIdentifier | HolderType | HolderNameKey                  | DeceasedHolderName         | HolderOtherTaxCode | Dpid | HolderGroupCode | VariableField | BrokerCode | FastRegister | HolderKeyModifier | HolderAlternateId | WarningsAfter        | FinalWarning         | Array1Ln14 | Array1Ln16 | HstStopTrade | HvfFlag1 | HvfFlag2 | ResidencyInd | MailUnclaimedDate | ArStatusDescription | BirthDate | Action2 | UpdateOption2 | Confirm | SearchData | SystemInfoFree6 | SystemInfoFree4 | SystemInfoFree7 | SystemInfoFree5 | Array1 | HstAnnualReport | Actions                                                    |
		| Test5 | S      | X0008253251  | U       | CD            | 1116  | 1117   | MR AH CEJV +                 | C            | MRS KZOKLAU KAAK-POU CEJV | U            | C               |            |              |            |              |              | <Trans>     | MR AH CEJV +                 | 4115     | Unconfirmed Deceased | X0008253251      | DEC        | AHCEJV                         | MR AH CEJV                 |                    |      |                 |               | 1402       |              |                   |                   | Unconfirmed Deceased | Confirmed Deceased   | Y          |            |              |          |          |              |                   |                     |           |         |               |         |            |                 |                 |                 |                 | Y      | N               | - Holder's Unconfirmed status set to Confirmed Deceased    |
		| Test6 | S      | X0008583846  | U       | CD            | 1118  | 1119    | MR VIACOXO RDOKWIR ROAVHIG + | U            | TEST AUTOMATION           | C            | U               |            |              |            |              |              | <Trans>     | MR VIACOXO RDOKWIR ROAVHIG + | 5118     | Confirmed Deceased   | X0008583846      | DEC        | ROAVHIG     VIACOXRDOKWIROAVHI | MR VIACOXO RDOKWIR ROAVHIG |                    |      |                 |               | 3383       |              |                   |                   | Unconfirmed Deceased | Unconfirmed Deceased | Y          |            |              |          |          |              |                   |                     |           |         |               |         |            |                 |                 |                 |                 | Y      | N               | - Holder's Confirmed status reversed to Unconfirmed status |
		

@winformsTest
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@20572
 	Scenario Outline: Test Case 20572: 01 - ZAF Taxpayer Details (ZA)  - Add , Change/Modify and Delete ZAF taxpayer details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS02901 I enter Nature Of Person as follows
		| INNatureOFPerson   |
		| <INNatureOFPerson> |
	    And In OLS02901 I enter all the following details 
		| TransNumber   | CustodianReference   | IntermediaryInd   | OtherStatus   | TaxCode   | TradingName1   | BenAddrName   | BenAddrLine1   | BenAddrLine2   | BenAddrLine3   | BenAddrLine4   | BenAddrLine5   | BenAddrPC   | TaxReference   | TaxRefType   | IDReference   | IDReferenceType   | DateBirth   | Phone   | Email   | RetName   | RetLine1   | RetLine2   | RetLine3   | RetLine4   | RetLine5   | RetAddrPC   | ExemptionCode   | ExemptionCodeDesc   | CtryOFIssue   | CertStatus   | CertStatusDesc   | DecName   | DecCapCode   | DecCapacity   | DecDate   | UndName   | UndCapCode   | UndCapacity   | UndDate   | SigDate   |   
		| <TransNumber> | <CustodianReference> | <IntermediaryInd> | <OtherStatus> | <TaxCode> | <TradingName1> | <BenAddrName> | <BenAddrLine1> | <BenAddrLine2> | <BenAddrLine3> | <BenAddrLine4> | <BenAddrLine5> | <BenAddrPC> | <TaxReference> | <TaxRefType> | <IDReference> | <IDReferenceType> | <DateBirth> | <Phone> | <Email> | <RetName> | <RetLine1> | <RetLine2> | <RetLine3> | <RetLine4> | <RetLine5> | <RetAddrPC> | <ExemptionCode> | <ExemptionCodeDesc> | <CtryOFIssue> | <CertStatus> | <CertStatusDesc> | <DecName> | <DecCapCode> | <DecCapacity> | <DecDate> | <UndName> | <UndCapCode> | <UndCapacity> | <UndDate> | <SigDate> | 
	Then In OLS02901 I verify TaxReference
		| TaxReference   |
		| <TaxReference> |
	When In OLS02901 I enter "<Action2>"
		And In OLS02901 I update all the following details 
		| UpdateTransNumber   | NewCustodianRef   | NewIntermediaryInd   | NewInternalStatus   | NewTradingName   | NewBenAdrLine1   | 
		| <UpdateTransNumber> | <NewCustodianRef> | <NewIntermediaryInd> | <NewInternalStatus> | <NewTradingName> | <NewBenAdrLine1> | 
    Then In OLS02901 I verify following
		| NewCustodianRef  |
		| <NewCustodianRef>| 
     When In OLS02901 I enter "<Action3>"
	     And In OLS02901 I confirm the deleteion with "<DelteTrans>" "<ConfirmDelete>"
	 Then I Verify No ZAF details available for the holder

 Examples: 
	| Action | UpdateOption | Action1 | UpdateOption1 | INNatureOFPerson | TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | TradingName1                   | BenAddrName                    | BenAddrLine1                   | BenAddrLine2                   | BenAddrLine3                   | BenAddrLine4                   | BenAddrLine5                   | BenAddrPC | TaxReference        | TaxRefType | IDReference          | IDReferenceType | DateBirth  | Phone                | Email                      | RetName                        | RetLine1                    | RetLine2                    | RetLine3                    | RetLine4                    | RetLine5                    | RetAddrPC | ExemptionCode | ExemptionCodeDesc | CtryOFIssue | CertStatus | CertStatusDesc | DecName                       | DecCapCode | DecCapacity | DecDate    | UndName                       | UndCapCode | UndCapacity | UndDate    | SigDate    | Action2 | NewCustodianRef | NewIntermediaryInd | NewInternalStatus | NewTradingName   | NewBenAdrLine1          | Action3 | UpdateTransNumber | DelteTrans | ConfirmDelete |
	| S      | X0036508281  | U       | ZA            | I                | 8004        |                    | Y               | REL         | AUS     | TEST THE TRADING NAME FOR TEST | TESTING THE BENEFICIAL NAME TE | TESTING THE BENEFICIALADDRESS1 | TESTING THE BENEFICIALADDRESS2 | TESTING THE BENEFICIALADDRESS3 | TESTING THE BENEFICIALADDRESS4 | TESTING THE BENEFICIALADDRESS5 | 6000      | 1132254564887879564 | TFN        | 65656565656565665665 | 002             | 01/01/1978 | 9855 669335645646556 | APIINDUTIRL@TESTING.COM.AU | TESTING THE POSTAL NAME TESTTT | TSTING POSTAL ADDRESS LINE1 | TSTING POSTAL ADDRESS LINE2 | TSTING POSTAL ADDRESS LINE3 | TSTING POSTAL ADDRESS LINE4 | TSTING POSTAL ADDRESS LINE5 | 6827      | C             |                   | AUS         | UNC        |                | TEST DECLARATN'S NAME TESTING | BEN        |             | 10/10/2014 | TEST UNDERTAKING NAME TESTING | BEN        |             | 20/10/2014 | 11/07/2015 | C       | X0033189290     | N                  | REJ               | New Trading Name | New Beneficial Address1 | D       | 8005              | 8006       | Y             |
	| S      | X0036528982  | U       | ZA            | B                | 8807        |                    |                 |             | USA     |                                |                                |                                |                                |                                |                                |                                |           | 5556664             | TRN        |                      |                 |            |                      |                            |                                |                             |                             |                             |                             |                             |           |               |                   |             |            |                | TEST Dec                      | BEN        |             | 04/04/2015 | Test Under                    | BEN        |             | 01/01/2015 | 11/07/2015 | M       |                 | Y                  | REL               |                  |                         | D       | 8008              | 8009       | Y             |


@winformsTest
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@19607
@FullSmokeTest
 	Scenario Outline: Test Case 19607: 01 - IRL Taxpayer Details (IRL)  - Add , Change/Modify and Delete IRL taxpayer details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS02801 I enter Enity Type "<EnityType>"
		And In OLS02801 I enter all the following details 
		| TransNumber   | CustodianReference   | IntermediaryInd   | OtherStatus   | TaxCode   | MailAddrName   | MailAddrLine1   | MailAddrLine2   | MailAddrLine3   | MailAddrLine4   | MailAddrLine5   | MailAddrPostcode   | BenAddrName   | BenAddrLine1   | BenAddrLine2   | BenAddrLine3   | BenAddrLine4   | BenAddrLine5   | BenAddrPC   | RetName   | RetLine1   | RetLine2   | RetLine3   | RetLine4   | RetLine5   | RetAddrPC   | TaxReference   | TaxRefType   | DateBirth   | PrevName   | DwtExpiryCcyy   | SigName   | SigCapType   | SigDate   | SigPhone   | CertFileRef   | CertStatus   | CertDwtRef   |
		| <TransNumber> | <CustodianReference> | <IntermediaryInd> | <OtherStatus> | <TaxCode> | <MailAddrName> | <MailAddrLine1> | <MailAddrLine2> | <MailAddrLine3> | <MailAddrLine4> | <MailAddrLine5> | <MailAddrPostcode> | <BenAddrName> | <BenAddrLine1> | <BenAddrLine2> | <BenAddrLine3> | <BenAddrLine4> | <BenAddrLine5> | <BenAddrPC> | <RetName> | <RetLine1> | <RetLine2> | <RetLine3> | <RetLine4> | <RetLine5> | <RetAddrPC> | <TaxReference> | <TaxRefType> | <DateBirth> | <PrevName> | <DwtExpiryCcyy> | <SigName> | <SigCapType> | <SigDate> | <SigPhone> | <CertFileRef> | <CertStatus> | <CertDwtRef> |
     Then In OLS02801 I verify TaxReference
		| TaxReference   |
		| <TaxReference> |
 	 When In OLS02801 I enter "<Action2>"
		And In OLS02801 I update all the following details 
		| UpdateTransNumber   | NewPrevName   | NewSigCapType   |    
		| <UpdateTransNumber> | <NewPrevName> | <NewSigCapType> | 
	Then In OLS02801 I verify following after update
		| NewPrevName   | NewSigCapType   |
		| <NewPrevName> | <NewSigCapType> | 
	When In OLS02801 I enter "D"
	    And In OLS02801 I confirm the deleteion with "<DelteTrans>" "Y"
	 Then I Verify No IRL details available for the holder

	
Examples: 
	| Action | UpdateOption | Action1 | UpdateOption1 | EnityType | TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName                   | MailAddrLine1                  | MailAddrLine2                  | MailAddrLine3                  | MailAddrLine4                  | MailAddrLine5                  | MailAddrPostcode | BenAddrName                   | BenAddrLine1                  | BenAddrLine2                  | BenAddrLine3                  | BenAddrLine4                  | BenAddrLine5                  | BenAddrPC | RetName                        | RetLine1                      | RetLine2                      | RetLine3                      | RetLine4                      | RetLine5                      | RetAddrPC | TaxReference | TaxRefType | DateBirth  | PrevName                       | DwtExpiryCcyy | SigName                        | SigCapType | SigDate    | SigPhone             | CertStatus | UpdateTransNumber | Action2 | DelteTrans | NewPrevName | NewSigCapType |
	| S      | I0010342449  | U       | IR            | IND       | 8808        | X0008646694        | N               | POI         | AUS     | TEST MAINLING NAME TEST TEST T | MAINLING ADDRESS LINE1 TESTING | MAINLING ADDRESS LINE2 TESTING | MAINLING ADDRESS LINE3 TESTING | MAINLING ADDRESS LINE4 TESTING | MAINLING ADDRESS LINE5 TESTING | 3000             | TEST BENEFICIARY NAME TESTING | BENEFICIAL ADDRESS LINE1 TEST | BENEFICIAL ADDRESS LINE2 TEST | BENEFICIAL ADDRESS LINE3 TEST | BENEFICIAL ADDRESS LINE4 TEST | BENEFICIAL ADDRESS LINE5 TEST | 3141      | TAX RETURN NAME TESITNG TESTIN | TAX RETURN ADDRESS LINE1 TEST | TAX RETURN ADDRESS LINE2 TEST | TAX RETURN ADDRESS LINE3 TEST | TAX RETURN ADDRESS LINE4 TEST | TAX RETURN ADDRESS LINE5 TEST | 3000      | 123456789    | TFN        | 01/01/1970 | TEST PREVIOUS NAME IND TESTING | 2020          | AUTHORISED SINGATORY TEST NAME | IND        | 09/05/2015 | 12345678911111111111 | UNC        | 8009              | C       | 8810       | NEWPREVNAME | SEC           |
	| S      | X0049136331  | U       | IR            | SAF       | 8812        |                    |                 |             | SDN     |                                |                                |                                |                                |                                |                                |                  |                               |                               |                               |                               |                               |                               |           |                                |                               |                               |                               |                               |                               |           | TESTTEST     | TRN        |            |                                | 2020          | AUTHORISED SINGATORY TEST NAME | TRE        | 31/03/2015 | 12345678911111111111 | UNC        | 8013              | M       | 8814       | NEWPREVNAME | AUT           |


@winformsTest
@ANZ_AUTO
@OL_SDM_StaticDetailMaintenance
@19609
@FullSmokeTest
 	Scenario: Test Case 19609: 02 - IRL Taxpayer Details (IR)-  Add 5 records to a holder for IRL Taxpayer details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0056379754"
		And In OLS01102 I enter following details as the update option "U" "IR"
		And In OLS02801 I enter Enity Type "IND"
		And In OLS02801 I enter all the following details 
		| TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		| 9001        | X0008646694        | N               | POI         | NZL     |              |               |               |               |               |               |                  | IND Entity  |              |              |              |              |              |           |         |          |          |          |          |          |           | 11111        | IRD        |           |          |               |         |            |         |          |             |            |            |
		And In OLS02801 I enter "A"
		And In OLS02801 I enter Enity Type "COY"
		And In OLS02801 I enter all the following details 
		| TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		| 9002        |                    |                 |             |         |              |               |               |               |               |               |                  | Coy Entity  |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         | AUT        |         |          |             |            |            |
		And In OLS02801 I enter "A"
		And In OLS02801 I enter Enity Type "PRT"
		And In OLS02801 I enter all the following details 
		| TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName  | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		| 9003        |                    |                 |             |         |              |               |               |               |               |               |                  | PRT Entity  |              |              |              |              |              |           |         |          |          |          |          |          |           | 22222        | IRD        |           |          |               | Test PRT | VPR        |         |          |             |            |            |
		And In OLS02801 I enter "A"
		And In OLS02801 I enter Enity Type "TST"
		And In OLS02801 I enter all the following details 
		| TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName  | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		| 9004        |                    |                 |             |         |              |               |               |               |               |               |                  | TST Entity  |              |              |              |              |              |           |         |          |          |          |          |          |           | 33333        | IRD        |           |          |               | Test TST | EXE        |         |          |             |            |            |
		And In OLS02801 I enter "A"
		And In OLS02801 I enter Enity Type "SAF"
		And In OLS02801 I enter all the following details 
		| TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName  | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		| 9005        |                    |                 |             |         |              |               |               |               |               |               |                  | TST SAF     |              |              |              |              |              |           |         |          |          |          |          |          |           | 44444        | IRD        |           |          |               | Test SAF | TRE        |         |          |             |            |            |
	Then In OLS02801 I verify following
		 | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName  | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		 |                    |                 |             |         |              |               |               |               |               |               |                  | TST SAF     |              |              |              |              |              |           |         |          |          |          |          |          |           | Quoted       | IRD        |           |          |               | TEST SAF | TRE        |         |          |             |            |            |
		And In OLS02801 I enter "B"  
		And In OLS02801 I verify following
		 | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName  | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		 |                    |                 |             |         |              |               |               |               |               |               |                  | TST ENTITY  |              |              |              |              |              |           |         |          |          |          |          |          |           | Quoted       | IRD        |           |          |               | TEST TST | EXE        |         |          |             |            |            |
		And In OLS02801 I enter "B"  
		And In OLS02801 I verify following
		 | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName  | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		 |                    |                 |             |         |              |               |               |               |               |               |                  | PRT ENTITY  |              |              |              |              |              |           |         |          |          |          |          |          |           | Quoted       | IRD        |           |          |               | TEST PRT | VPR        |         |          |             |            |            |
		And In OLS02801 I enter "B"  
		And In OLS02801 I verify following
		| CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		|                    |                 |             |         |              |               |               |               |               |               |                  | COY ENTITY  |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         | AUT        |         |          |             |            |            | 
		And In OLS02801 I enter "B"  
		And In OLS02801 I verify following
		| CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName | SigCapType | SigDate | SigPhone | CertFileRef | CertStatus | CertDwtRef |
		| X0008646694        | N               | POI         | NZL     |              |               |               |               |               |               |                  | IND ENTITY  |              |              |              |              |              |           |         |          |          |          |          |          |           | Quoted       | IRD        |           |          |               |         |            |         |          |             |            |            |

@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@19594
 	Scenario: Test Case 19594: 01 - US Taxpayer Details - Add, Change, Modify and Delete Investors for CDI with Forms: W-9, W-8BEN, W-8BEN-E
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In housekeeping US Tax Reporting Obligation is set as "C" "" "" "" ""
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131550499"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 9006      | I              | DR YUPOF XPOPGAH INV 1 | 03           | 99-1234567 | U09          | 31/12/2015   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "1"
		    | InvType                | InvName                | InvTinStatus           | InvW8Exp               | InvChpt3     | InvChpt4     |
	        | I                      | DR YUPOF XPOPGAH INV 1 | 03                     | 31/12/2015             |              |              |
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		       | TransNbrI | InvAccountType | InvName                | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		       | 9007      | E              | DR YUPOF XPOPGAH INV 2 | 02           | 98-9874561 | USA          | 31/12/2017   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "2"
		   | InvType   | InvName                | InvTinStatus           | InvW8Exp               | InvChpt3               | InvChpt4     |
		   | E         | DR YUPOF XPOPGAH INV 2 | 02                     | 31/12/2017             |                        |              |
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		   | TransNbrI | InvAccountType | InvName                | InvTinStatus | InvTin      | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		   | 9011      | I              | DR YUPOF XPOPGAH INV 3 | 12           | 123-65-9874 | U09          | 31/12/2016   | 19          | 27          | 01/01/1995   | USA              | FATCA W8B TEST  | PO BOX 363  | NAQFQSEKMI AUS |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "3"
	    | InvType | InvName                | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
	    | I       | DR YUPOF XPOPGAH INV 3 | 12           | 31/12/2016| 19       | 27       |
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		| TransNbrI | InvAccountType | InvName                | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		| 9012      | E              | DR YUPOF XPOPGAH INV 4 | 18           | 99-7894562 | NZL          | 31/12/2016   | 27          | 10          |              | USA              | FATCA W8BE TEST | PO BOX 364  | NAQFQSEKMI NSW | 98Q96B    | 99999     | SL        | 076       | Y                |                 |        |
		And In OLS03102 I verfiy following for row "4"
	    | InvType | InvName                | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
	    | E       | DR YUPOF XPOPGAH INV 4 | 18           | 31/12/2016 | 27       | 10       |
		And I exit to main from online system 
		#Verify in the enquiry system 
		And I go to the Enquiry system and Search I0131550499
	Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1               | InvTinStatus1 | InvW8Exp1  | InvChpt31 | InvChpt41 | InvType2 | InvName2               | InvTinStatus2 | InvW8Exp2  | InvChpt32 | InvChpt42 | InvType3 | InvName3               | InvTinStatus3 | InvW8Exp3  | InvChpt33 | InvChpt43 | InvType4 | InvName4               | InvTinStatus4 | InvW8Exp4  | InvChpt34 | InvChpt44 |
		| I        | DR YUPOF XPOPGAH INV 1 | 3             | 31/12/2015 |           |           | E        | DR YUPOF XPOPGAH INV 2 | 2             | 31/12/2017 |           |           | I        | DR YUPOF XPOPGAH INV 3 | 12            | 31/12/2016 | 19        | 27        | E        | DR YUPOF XPOPGAH INV 4 | 18            | 31/12/2016 | 27        | 10        |
	 And In  ENTUSA01 I enter action "1" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID   | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | I             | DR YUPOF XPOPGAH INV 1 | 3            | *****4567 | U09          | 31/12/2015       |          |          | No date      |            | Not Quoted |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "2" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID   | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | E             | DR YUPOF XPOPGAH INV 2 | 2            | *****4561 | USA          | 31/12/2017       |          |          | No date      |            | Not Quoted |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	 And In  ENTUSA01 I enter action "3" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | I             | DR YUPOF XPOPGAH INV 3 | 12           | *****9874 | U09          | 31/12/2016       | 19       | 27       | 01/01/1995   | USA        | Quoted   | PO BOX 363  | NAQFQSEKMI AUS |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "4" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | E             | DR YUPOF XPOPGAH INV 4 | 18           | *****4562 | NZL          | 31/12/2016       | 27       | 10       | No date      | USA        | Quoted   | PO BOX 364  | NAQFQSEKMI NSW | 98Q96B    | 99999     | SL        | 076       | Y                |
	 And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131550499"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                   | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 9013      | E              | DR YUPOF XPOPG INV CHNG 1 | 01           | 98-2541341 | USA          | 30/12/2016   |             |             |              |                  |                 | PO BOX 367  | NAQFQSEKMI GBR |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "1"
		 | InvType | InvName                   | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 | E       | DR YUPOF XPOPG INV CHNG 1 | 01           | 30/12/2016 |          |          |
		And In OLS03102 I enter action "2"
		And In OLS03103 I enter action "M"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                   | InvTinStatus | InvTin      | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 9014      | I              | DR YUPOF XPOPG INV CHNG 2 | 04           | 213-54-3652 | USA          | 30/12/2017   |             |             |              |                  |                 | PO BOX 366  | NAQFQSEKMI USA |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "2"
		 | InvType | InvName                   | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 | I       | DR YUPOF XPOPG INV CHNG 2 | 04           | 30/12/2017  |          |          |
		And In OLS03102 I enter action "3"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                   | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 9015      | I              | DR YUPOF XPOPG INV CHNG 3 | 10           | 99-5246312 | AUS          | 05/05/2016   | 19          | 27          | 02/02/1996   | GBR              | FATCA CHNG W8B  | PO BOX 362  | NAQFQSEKMI NSW |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "3"
		 | InvType | InvName                   | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 | I       | DR YUPOF XPOPG INV CHNG 3 | 10           | 05/05/2016 | 19       | 27       |
		 And In OLS03102 I enter action "4"
		And In OLS03103 I enter action "M"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                   | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 9016      | E              | DR YUPOF XPOPG INV CHNG 4 | 19           | 98-7895412 | U09          | 12/12/2017   | 10          | 08          |              | NZL              | TEST W8B CHANGE | PO BOX 365  | NAQFQSEKMI NZL | 8124H8    | 00000     | SP        | 036       |                  |                 |        |
		 And In OLS03102 I verfiy following for row "4"
		 | InvType | InvName                   | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 | E       | DR YUPOF XPOPG INV CHNG 4 | 19           | 12/12/2017 | 10       | 08       |
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131550499
	Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1                  | InvTinStatus1 | InvW8Exp1  | InvChpt31 | InvChpt41 | InvType2 | InvName2                  | InvTinStatus2 | InvW8Exp2  | InvChpt32 | InvChpt42 | InvType3 | InvName3                  | InvTinStatus3 | InvW8Exp3  | InvChpt33 | InvChpt43 | InvType4 | InvName4                  | InvTinStatus4 | InvW8Exp4  | InvChpt34 | InvChpt44 |
		| E        | DR YUPOF XPOPG INV CHNG 1 | 1             | 30/12/2016 |           |           | I        | DR YUPOF XPOPG INV CHNG 2 | 4             | 30/12/2017 |           |           | I        | DR YUPOF XPOPG INV CHNG 3 | 10            | 05/05/2016 | 19        | 27        | E        | DR YUPOF XPOPG INV CHNG 4 | 19            | 12/12/2017 | 10        | 08        |
	 And In  ENTUSA01 I enter action "1" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                   | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID   | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | E             | DR YUPOF XPOPG INV CHNG 1 | 1            | *****1341 | USA          | 30/12/2016       |          |          | No date      |            | Not Quoted | PO BOX 367  | NAQFQSEKMI GBR |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "2" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                   | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID   | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | I             | DR YUPOF XPOPG INV CHNG 2 | 4            | *****3652 | USA          | 30/12/2017       |          |          | No date      |            | Not Quoted | PO BOX 366  | NAQFQSEKMI USA |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	 And In  ENTUSA01 I enter action "3" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                   | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | I             | DR YUPOF XPOPG INV CHNG 3 | 10           | *****6312 | AUS          | 05/05/2016       | 19       | 27       | 02/02/1996   | GBR        | Quoted   | PO BOX 362  | NAQFQSEKMI NSW |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "4" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                   | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2    | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 | E             | DR YUPOF XPOPG INV CHNG 4 | 19           | *****5412 | U09          | 12/12/2017       | 10       | 08       | No date      | NZL        | Quoted   | PO BOX 365  | NAQFQSEKMI NZL | 8124H8    | 00000     | SP        | 036       | Y                |
	 And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131550499"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "9017"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "9050"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "9051"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "9052"
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131550499
	Then In ENS01001 I enter action "UT"
     And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1 | InvTinStatus1 | InvW8Exp1 | InvChpt31 | InvChpt41 | InvType2 | InvName2 | InvTinStatus2 | InvW8Exp2 | InvChpt32 | InvChpt42 | InvType3 | InvName3 | InvTinStatus3 | InvW8Exp3 | InvChpt33 | InvChpt43 | InvType4 | InvName4 | InvTinStatus4 | InvW8Exp4 | InvChpt34 | InvChpt44 |
		|          |          |               |           |           |           |          |          |               |           |           |           |          |          |               |           |           |           |          |          |               |           |           |           |



@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@19687
 	Scenario: Test Case 19687: 02 - US Taxpayer Details - Add, Change, Modify and Delete Investors for Chapter 61 with Forms: W-8BEN-E, ECI, IMY & EXP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In housekeeping US Tax Reporting Obligation is set as "H" "" "" "" ""
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0001311271"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 912332    |                | MR GIQNAXROJA NOMINEES INV01 | 18           | 99-1234567 | NZL          | 31/12/2015   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "1"
		    | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		    |         | MR GIQNAXROJA NOMINEES INV01 | 18           | 31/12/2015 |          |          |
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		    | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		    | 912333    |                | MR GIQNAXROJA NOMINEES INV02 | 13           | 99-7894562 | U09          | 20/12/2016   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "2"
		   | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		   |         | MR GIQNAXROJA NOMINEES INV02 | 13           | 20/12/2016 |          |          |
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		   | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		   | 912334    |                | MR GIQNAXROJA NOMINEES INV03 | 24           | 98-4561237 | AUS          | 31/12/2017   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |     
		And In OLS03102 I verfiy following for row "3"
	    | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
	    |        | MR GIQNAXROJA NOMINEES INV03 | 24           | 31/12/2017 |          |          |
		And In OLS03102 I enter action "A"
		And In OLS03103 I continue with following
		| TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		| 912335    |                | MR GIQNAXROJA NOMINEES INV04 | 14           | 99-9638527 | U09          | 30/12/2018   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "4"
	    | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
	    |         | MR GIQNAXROJA NOMINEES INV04 | 14           | 30/12/2018 |          |          |
		And I exit to main from online system 
		#Verify in the enquiry system 
		And I go to the Enquiry system and Search X0001311271
	Then In ENS01001 form I verify US Tax warning at position "2" value "US Tax details present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1                     | InvTinStatus1 | InvW8Exp1  | InvChpt31 | InvChpt41 | InvType2 | InvName2                     | InvTinStatus2 | InvW8Exp2  | InvChpt32 | InvChpt42 | InvType3 | InvName3                     | InvTinStatus3 | InvW8Exp3  | InvChpt33 | InvChpt43 | InvType4 | InvName4                     | InvTinStatus4 | InvW8Exp4  | InvChpt34 | InvChpt44 |
		|          | MR GIQNAXROJA NOMINEES INV01 | 18            | 31/12/2015 |           |           |          | MR GIQNAXROJA NOMINEES INV02 | 13            | 20/12/2016 |           |           |          | MR GIQNAXROJA NOMINEES INV03 | 24            | 31/12/2017 |           |           |          | MR GIQNAXROJA NOMINEES INV04 | 14            | 30/12/2018 |           |           |
		And In  ENTUSA01 I enter action "1" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES INV01 | 18           | *****4567 | NZL          | 31/12/2015       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "2" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES INV02 | 13           | *****4562 | U09          | 20/12/2016       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	 And In  ENTUSA01 I enter action "3" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES INV03 | 24           | *****1237 | AUS          | 31/12/2017       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "4" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES INV04 | 14           | *****8527 | U09          | 30/12/2018       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0001311271"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912336    |                | MR GIQNAXROJA NOMINEES MOD01 | 17           | 98-7895443 | W30          | 12/12/2017   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "1"
		 | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 |         | MR GIQNAXROJA NOMINEES MOD01 | 17           | 12/12/2017 |          |          |
		And In OLS03102 I enter action "2"
		And In OLS03103 I enter action "M"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 912337    |                | MR GIQNAXROJA NOMINEES MOD02 | 13           | 32-6547854 | U09          | 30/12/2017   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "2"
		 | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 |         | MR GIQNAXROJA NOMINEES MOD02 | 13           | 30/12/2017 |          |          |
		And In OLS03102 I enter action "3"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 912338    |                | MR GIQNAXROJA NOMINEES MOD03 | 21           | 99-5214789 | GBR          | 12/12/2015   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "3"
		 | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 |         | MR GIQNAXROJA NOMINEES MOD03 | 21           | 12/12/2015 |          |          |
		 And In OLS03102 I enter action "4"
		And In OLS03103 I enter action "M"
		And In OLS03103 I continue with following
		 | TransNbrI | InvAccountType | InvName                      | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
		 | 912339    |                | MR GIQNAXROJA NOMINEES MOD04 | 14           | 58-7452178 | U09          | 31/12/2019   |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 |        |
		And In OLS03102 I verfiy following for row "4"
		 | InvType | InvName                      | InvTinStatus | InvW8Exp   | InvChpt3 | InvChpt4 |
		 |         | MR GIQNAXROJA NOMINEES MOD04 | 14           | 31/12/2019 |          |          |
		And I exit to main from online system
		And I go to the Enquiry system and Search X0001311271
	Then In ENS01001 form I verify US Tax warning at position "2" value "US Tax details present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1                     | InvTinStatus1 | InvW8Exp1  | InvChpt31 | InvChpt41 | InvType2 | InvName2                     | InvTinStatus2 | InvW8Exp2  | InvChpt32 | InvChpt42 | InvType3 | InvName3                     | InvTinStatus3 | InvW8Exp3  | InvChpt33 | InvChpt43 | InvType4 | InvName4                     | InvTinStatus4 | InvW8Exp4  | InvChpt34 | InvChpt44 |
		|          | MR GIQNAXROJA NOMINEES MOD01 | 17            | 12/12/2017 |           |           |          | MR GIQNAXROJA NOMINEES MOD02 | 13            | 30/12/2017 |           |           |          | MR GIQNAXROJA NOMINEES MOD03 | 21            | 12/12/2015 |           |           |          | MR GIQNAXROJA NOMINEES MOD04 | 14            | 31/12/2019 |           |           |
		And In  ENTUSA01 I enter action "1" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES MOD01 | 17           | *****5443 | W30          | 12/12/2017      |          |          |              |            |          |             |             |           |           |           |           |                  |	
	  And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "2" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES MOD02 | 13           | *****7854 | U09          | 30/12/2017       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	 And In  ENTUSA01 I enter action "3" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES MOD03 | 21           | *****4789 | GBR          | 12/12/2015       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "4" 
	 And In ENTUSA03 I verify the following
	 | JntAccountTyp | InvName                      | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	 |               | MR GIQNAXROJA NOMINEES MOD04 | 14           | *****2178 | U09          | 31/12/2019       |          |          |              |            |          |             |             |           |           |           |           |                  |
	 And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0001311271"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "912340"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "912344"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "912342"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "D"
		And In OLS03103 I confirm deletion with TransactionNo "912343"
		And I exit to main from online system
		And I go to the Enquiry system and Search X0001311271
	Then In ENS01001 I enter action "UT"
     And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1 | InvTinStatus1 | InvW8Exp1 | InvChpt31 | InvChpt41 | InvType2 | InvName2 | InvTinStatus2 | InvW8Exp2 | InvChpt32 | InvChpt42 | InvType3 | InvName3 | InvTinStatus3 | InvW8Exp3 | InvChpt33 | InvChpt43 | InvType4 | InvName4 | InvTinStatus4 | InvW8Exp4 | InvChpt34 | InvChpt44 |
		|          |          |               |           |           |           |          |          |               |           |           |           |          |          |               |           |           |           |          |          |               |           |           |           |



@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@21050
# As Existing bug in Linux commenting the test case
 #	Scenario: Test Case 21050: 03 - US Taxpayer Details - Add, Change, Modify and Delete Investors for IGA with Forms: SC-IND, SC-ENTITY
	#Given I have connected to WinForms
	#When In SELCOY01 I select the company: "WES_AUTO"
	#	And In housekeeping US Tax Reporting Obligation is set as "I" "98Q96B" "99999" "SL" "036"
	#	And I go to the Static Details Menu
	#	And In OLS01101 I enter following details as the update option "S" "I0131111002"
	#	And In OLS01102 I enter following details as the update option "U" "UX"
	#	And In OLS03101 I enter action "A"
	#	And In OLS03103 I continue with following
	#	 | TransNbrI | InvAccountType | InvName         | InvTinStatus | InvTin      | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2     | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	#	 | 912349    | I              | MR LOJUAF INV01 | 10           | 123-65-9874 | AUS          |              |             | IN          |              | USA              |                 | PO BOX 725  | NORTH EMIFE SA. |           |           |           |           |                  |                 |        |
	#	And In OLS03101 I verfiy following for row "1"
	#	 | InvType       | InvName           | InvChpt4          |
	#	 | I             | MR LOJUAF INV01   | IN                |
	#	And In OLS03101 I enter action "A"
	#	And In OLS03103 I continue with following
	#	  | TransNbrI | InvAccountType | InvName           | InvTinStatus | InvTin      | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2     | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	#	  | 912350    | E              | MR B YANCEG INV01 | 10           | 123-65-7498 | AUS          |              |             | PF          |              | USA              |                 | PO BOX 748  | SOUTH EMIFE AUS | DSF324    | 99999     | SL        | 036       | Y                | N               |        |
	#	 And In OLS03101 I verfiy following for row "2"
	#	  | InvType       | InvName           | InvChpt4          |
	#	 | E             | MR B YANCEG INV01 | PF                |
	#	 And I exit to main from online system 
	#	#Verify in the enquiry system 
	#	And I go to the Enquiry system and Search I0131111002
	#Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
	#	And In ENS01001 I enter action "UT"
	#	And In  ENTUSA01 I verify the following investor details
	#	  | InvType1      | InvName1          | InvTinStatus1     | InvW8Exp1    | InvChpt31    | InvChpt41        | InvType2     | InvName2          | InvTinStatus2 | InvW8Exp2    | InvChpt32        | InvChpt42       | InvType3        | InvName3        | InvTinStatus3 | InvW8Exp3 | InvChpt33 | InvChpt43        | InvType4         | InvName4        | InvTinStatus4 | InvW8Exp4 | InvChpt34 | InvChpt44 |
	#	 | I             | MR LOJUAF INV01   |                   |              |              | IN               | E            | MR B YANCEG INV01 |               |              |                  | PF              |                 |                 |               |           |           |                  |                  |                 |               |           |           |  |
	#	And In  ENTUSA01 I enter action "1" 
	#	And In ENTUSA03 I verify the following
	#	 | JntAccountTyp | InvName           | InvTinStatus      | InvTin       | InvUSTaxCode | InvTinExpiryDate | InvChpt3     | InvChpt4          | InvBirthDate  | InvCountry   | InvTaxID         | InvAddress1     | InvAddress2     | InvGiinP1       | InvGiinP2     | InvGiinP3 | InvGiinP4 | InvGiinException |
	#	 | I             | MR LOJUAF INV01   | 10                | *****9874    | AUS          |                  |              | IN                |               | USA          |                  | PO BOX 725      | NORTH EMIFE SA. |                 |               |           |           |                  |
	#	And IN ENTUSA03 I press ESC
	#	And In  ENTUSA01 I enter action "2" 
	#	And In ENTUSA03 I verify the following
	#	 | JntAccountTyp | InvName           | InvTinStatus      | InvTin       | InvUSTaxCode | InvTinExpiryDate | InvChpt3     | InvChpt4          | InvBirthDate  | InvCountry   | InvTaxID         | InvAddress1     | InvAddress2     | InvGiinP1       | InvGiinP2     | InvGiinP3 | InvGiinP4 | InvGiinException |
	#	  | E             | MR B YANCEG INV01 | 10                | *****7498    | AUS          |                  |              | PF                |               | USA          |                  | PO BOX 748      | SOUTH EMIFE AUS | DSF324          | 99999         | SL        | 036       | Y                |
	#	And IN ENTUSA03 I press ESC 
	#	And I exit to main from enquiry system 
	# When I go to the Static Details Menu
	#	And In OLS01101 I enter following details as the update option "S" "I0131111002"
	#	And In OLS01102 I enter following details as the update option "U" "UX"
	#	And In OLS03101 I enter action "1"
	#	And In OLS03103 I enter action "C"
	#	And In OLS03103 I continue with following
	#	 | TransNbrI | InvAccountType | InvName           | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2     | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	#	 | 912351    |                | MR B YANCEG MOD01 | 40           | 99-2583691 | NZL          |              |             | IS          |              | NZL              |                 | PO BOX 726  | NORTH EMIFE AUS |           |           |           |           |                  |                 |        |
	#	And In OLS03101 I verfiy following for row "1"
	#	 | InvType       | InvName           | InvChpt4          |
	#	 | I             | MR B YANCEG MOD01 | IS                |
	#	And In OLS03101 I enter action "2"
	#	And In OLS03103 I enter action "M"
	#	And In OLS03103 I continue with following
	#	 | TransNbrI | InvAccountType | InvName           | InvTinStatus | InvTin     | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2   | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	#	 | 912352    | E              | MR B YANCEG MOD02 | 40           | 99-2581473 | NZL          |              |             | PF          |              | USA              |                 | PO BOX 897  | WEST USISA NY | 98Q96B    | 00000     | BR        | 036       | 036              | N               |        |
	#	And In OLS03101 I verfiy following for row "2"
 #       | InvType | InvName           | InvChpt4 |
 #       | E       | MR B YANCEG MOD02 | PF       |
	#	 And I exit to main from online system 
	#	#Verify in the enquiry system 
	#	And I go to the Enquiry system and Search I0131111002
	#	Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
	#	And In ENS01001 I enter action "UT"
	#	And In  ENTUSA01 I verify the following investor details
	#	| InvType1 | InvName1          | InvTinStatus1 | InvW8Exp1 | InvChpt31 | InvChpt41 | InvType2 | InvName2          | InvTinStatus2 | InvW8Exp2 | InvChpt32 | InvChpt42 | InvType3 | InvName3 | InvTinStatus3 | InvW8Exp3 | InvChpt33 | InvChpt43 | InvType4 | InvName4 | InvTinStatus4 | InvW8Exp4 | InvChpt34 | InvChpt44 |
	#	| I        | MR B YANCEG MOD01 |               |           |           | IS        | E        | MR B YANCEG MOD02 |               |           |           | PF        |          |          |               |           |           |           |          |          |               |           |           |           |
	#	And In  ENTUSA01 I enter action "1" 
	#	And In ENTUSA03 I verify the following
	#	| JntAccountTyp | InvName           | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2     | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	#	| I             | MR B YANCEG MOD01 | 40           | *****3691 | NZL          |                  |          | IS       |              | NZL        |          | PO BOX 726  | NORTH EMIFE AUS |           |           |           |           |                  |
	#	And IN ENTUSA03 I press ESC
	#	And In  ENTUSA01 I enter action "2" 
	#	And In ENTUSA03 I verify the following
	#	| JntAccountTyp | InvName           | InvTinStatus | InvTin    | InvUSTaxCode | InvTinExpiryDate | InvChpt3 | InvChpt4 | InvBirthDate | InvCountry | InvTaxID | InvAddress1 | InvAddress2   | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException |
	#	| E             | MR B YANCEG MOD02 | 40           | *****1473 | NZL          |                  |          | PF       |              | USA        |          | PO BOX 897  | WEST USISA NY | 98Q96B    | 00000     | BR        | 036       | N                |
	#	And IN ENTUSA03 I press ESC 
	#	And I exit to main from enquiry system 
	#	 And I exit to main from enquiry system 
	# When I go to the Static Details Menu
	#	And In OLS01101 I enter following details as the update option "S" "I0131111002"
	#	And In OLS01102 I enter following details as the update option "U" "UX"
	#	And In OLS03101 I enter action "1"
	#	And In OLS03103 I enter action "D"
	#	And In OLS03103 I confirm deletion with TransactionNo "912353"
	#	And In OLS03101 I enter action "1"
	#	And In OLS03103 I enter action "D"
	#	And In OLS03103 I confirm deletion with TransactionNo "912354"
	#    And I exit to main from online system
	#	And I go to the Enquiry system and Search I0131111002
	# Then In ENS01001 I enter action "UT"
 #    And In  ENTUSA01 I verify the following investor details
	#	| InvType1 | InvName1 | InvTinStatus1 | InvW8Exp1 | InvChpt31 | InvChpt41 | InvType2 | InvName2 | InvTinStatus2 | InvW8Exp2 | InvChpt32 | InvChpt42 | InvType3 | InvName3 | InvTinStatus3 | InvW8Exp3 | InvChpt33 | InvChpt43 | InvType4 | InvName4 | InvTinStatus4 | InvW8Exp4 | InvChpt34 | InvChpt44 |
	#	|          |          |               |           |           |           |          |          |               |           |           |           |          |          |               |           |           |           |          |          |               |           |           |           |



@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@21051
 	Scenario: Test Case 21051: 04 - US Taxpayer Details - Add, Change, Modify and Delete Beneficial Owner (W-8ECI & W-8IMY) for CDI with Forms: W-8BEN-E & W-8IMY
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In housekeeping US Tax Reporting Obligation is set as "C" "" "" "" ""
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0014741054"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912355    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "B" 
		And In OLS03105 I continue with following 
		| CntAccountType | CntName                | CntAddressLine1 | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | Country | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | Action | Ols03105Confirm |
		| E              | DR JUMMOEW VINCOV BO01 | 3 JMASI STREET  | JIASWIQVEZ      | TAS             | NEW YORK        | 3656        | USA     | 13        | 98-7894563     | U09       | 31/12/2015           | 10               |                  |                      | USA                    | TEST FATCA               | 98Q96B            | 00000     | BR        | 036       | Y                        |        |                 |
		And In OLS03104 I verfiy following for row "1"
		| CntName                | CntResCountry | CntCtznCountry | CntBen     |
		| DR JUMMOEW VINCOV BO01 | USA           | USA            | Beneficial |
		And In OLS03104 I enter action "U" 
		And In OLS03102 I enter action "2"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912356    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "B" 
		And In OLS03105 I continue with following 
		| CntAccountType | CntName               | CntAddressLine1       | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | Country | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | Action | Ols03105Confirm |
		| E              | DR JUMMOEW VINCOV BO2 | LORVEV VITMEOWU-BKUWX | 5 JMASI STREET  | NSW             | AUS             | 3978        | AUS     | 23        | 99-7894562     | GBR       | 31/12/2016           | 12               |  7               |                      | USA                    | FATCA TEST               | 98Q96B            | 00000     | BR        | 036       | Y                        |        |                 |
		And In OLS03104 I verfiy following for row "1"
		| CntName               | CntResCountry | CntCtznCountry | CntBen     |
		| DR JUMMOEW VINCOV BO2 | AUS           | USA            | Beneficial |
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search X0014741054
	Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I verify the following investor details
		| InvType1 | InvName1          | InvTinStatus1 | InvW8Exp1  | InvChpt31 | InvChpt41 | InvType2 | InvName2              | InvTinStatus2 | InvW8Exp2  | InvChpt32 | InvChpt42 | InvType3 | InvName3 | InvTinStatus3 | InvW8Exp3 | InvChpt33 | InvChpt43 | InvType4 | InvName4 | InvTinStatus4 | InvW8Exp4 | InvChpt34 | InvChpt44 |
		|          | DR JUMMOEW VINCOV | 18            | 31/12/2016 | 18        | 10        |          | LORVEV VITMEOWU-BKUWX | 21            | 31/12/2017 | 12        | 08        |          |          |               |           |           |           |          |          |               |           |           |           |
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName                | CntAddressLine1 | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | CntCountry | CntCitizenship | CntTaxIdentifier | CntTin    | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| DR JUMMOEW VINCOV BO01 | 3 JMASI STREET  | JIASWIQVEZ      | TAS             | NEW YORK        | 3656        | USA        | USA            | Quoted           | *****4563 | No date      | 13           | 10       |          | U09          | 31/12/2015   | 98Q96B    | 00000     | BR        | 036       | Y                |
	  And I press ESC
	  And I press ESC
	  And IN ENTUSA03 I press ESC
	  And In  ENTUSA01 I enter action "2" 
	  And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName               | CntAddressLine1       | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | CntCountry | CntCitizenship | CntTaxIdentifier | CntTin    | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| DR JUMMOEW VINCOV BO2 | LORVEV VITMEOWU-BKUWX | 5 JMASI STREET  | NSW             | AUS             | 3978        | AUS        | USA            | Quoted           | *****4562 | No date      | 23           | 12       |  07       | GBR          | 31/12/2016   | 98Q96B    | 00000     | BR        | 036       | Y                |
	 And I press ESC
	 And I press ESC
	 And IN ENTUSA03 I press ESC
	  And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0014741054"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912358    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1" 
		And In OLS03105 I enter action "C" ""
		And In OLS03105 I continue with following 
		| CntAccountType | CntName                 | CntAddressLine1 | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | Country | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | Action | Ols03105Confirm |
		| I              | DR JUMMOEW VINCOV MOD01 | C/- N N NEDRIT  | NZZ 303         | JIAZWIQVEZ      | XUPISHUG        | 3034        | AUS     | 13        | 58-7894562     | U09       | 30/11/2015           | 8                |                  |                      | AUS                    | TEST MOD FATCA           |                   |           |           |           |                          |        |                 |
		And In OLS03104 I verfiy following for row "1"
		| CntName                 | CntResCountry | CntCtznCountry | CntBen     |
		| DR JUMMOEW VINCOV MOD01 | AUS           | AUS            | Beneficial |
		And In OLS03104 I enter action "U" 
		And In OLS03102 I enter action "2"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912359    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1" 
		And In OLS03105 I enter action "M" ""
		And In OLS03105 I continue with following 
		| CntAccountType | CntName                | CntAddressLine1      | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | Country | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | Action | Ols03105Confirm |
		| I              | LORVEV VITMEOW MOD BO2 | C/3 QESP MUPQ VE MMN | 323 QIS STREET  | RETP GUPTUOYFI  | NSW             | 3876        | NZL     | 26        | 78-9874563     | AUS       | 12/12/2018           | 11               | 7                |                      | USA                    | TEST MOD BO              |                   |           |           |           |                          |        |                 |
		And In OLS03104 I verfiy following for row "1"
		| CntName                 | CntResCountry | CntCtznCountry | CntBen     |
		| LORVEV VITMEOW MOD BO2  | NZL           | USA            | Beneficial |
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search X0014741054
	Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName                 | CntAddressLine1 | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | CntCountry | CntCitizenship | CntTaxIdentifier | CntTin    | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| DR JUMMOEW VINCOV MOD01 | C/- N N NEDRIT  | NZZ 303         | JIAZWIQVEZ      | XUPISHUG        | 3034        | AUS        | AUS            | Quoted           | *****4562 | No date      | 13           | 08       |          | U09          | 30/11/2015   |           |           |           |           |                  |
		 And I press ESC
		 And I press ESC
		And IN ENTUSA03 I press ESC
		And In  ENTUSA01 I enter action "2" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName                | CntAddressLine1      | CntAddressLine2 | CntAddressLine3 | CntAddressLine4 | CntPostcode | CntCountry | CntCitizenship | CntTaxIdentifier | CntTin    | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| LORVEV VITMEOW MOD BO2 | C/3 QESP MUPQ VE MMN | 323 QIS STREET  | RETP GUPTUOYFI  | NSW             | 3876        | NZL        | USA            | Quoted           | *****4563 | No date      | 26           | 11       | 07       | AUS          | 12/12/2018   |           |           |           |           |                  |
		And I press ESC
		And I press ESC
		And IN ENTUSA03 I press ESC
		And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "X0014741054"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912372   |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1" 
		And In OLS03105 I enter action "D" "Y"
		And In OLS03104 I enter action "U" 
		And In OLS03102 I enter action "2"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912373  |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1" 
		And In OLS03105 I enter action "D" "Y"
		And In OLS03104 I enter action "U"
		And I exit to main from online system
		And I go to the Enquiry system and Search X0014741054
	Then In ENS01001 form I verify US Tax warning at position "2" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
		And I expect to see error with text "No Controlling Person or Beneficial Owner"
		And I press ESC
		And In  ENTUSA01 I enter action "2" 
		And In ENTUSA03 I enter "C"
		And I expect to see error with text "No Controlling Person or Beneficial Owner"
		And I press ESC




@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@21054
 	Scenario Outline: Test Case 21054: 06 - US Taxpayer Details - Add, Change, Modify and Delete Controlling Persons for IGA with Form: SC-ENT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In housekeeping US Tax Reporting Obligation is set as "I" "98Q96B" "99999" "SL" "036"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131604602"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03101 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		| TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912374    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "C"  
		And In OLS03105 I continue with following 
		| CntAccountType | CntName   | CntAddressLine1   | CntAddressLine2   | CntAddressLine3   | CntAddressLine4   | CntPostcode   | Country   | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | 
		|                | <CntName> | <CntAddressLine1> | <CntAddressLine2> | <CntAddressLine3> | <CntAddressLine4> | <CntPostcode> | <Country> |           |                |           |                      |                  |                  |                      |                        |                          |                   |           |           |           |                          |   
		And In OLS03104 I verfiy following for row "1"
		| CntName   | CntResCountry | CntCtznCountry | CntBen      |
		| <CntName> | <Country>     |                | Controlling |
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131604602
		Then In ENS01001 form I verify US Tax warning at position "3" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName   | CntAddressLine1   | CntAddressLine2   | CntAddressLine3   | CntAddressLine4   | CntPostcode   | CntCountry | CntCitizenship | CntTaxIdentifier | CntTin | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| <CntName> | <CntAddressLine1> | <CntAddressLine2> | <CntAddressLine3> | <CntAddressLine4> | <CntPostcode> | <Country>  |                |                  |        |              |              |          |          |              |              |           |           |           |           |                  |
		 And I press ESC
		 And I press ESC
		And IN ENTUSA03 I press ESC
	    And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131604602"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03101 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		| TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912375    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1"  
		And In OLS03105 I enter action "C" ""
		And In OLS03105 I continue with following 
		| CntAccountType | CntName      | CntAddressLine1      | CntAddressLine2      | CntAddressLine3      | CntAddressLine4      | CntPostcode      | Country      | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException |
		|                | <NewCntName> | <NewCntAddressLine1> | <NewCntAddressLine2> | <NewCntAddressLine3> | <NewCntAddressLine4> | <NewCntPostcode> | <NewCountry> |           |                |           |                      |                  |                  |                      |                        |                          |                   |           |           |           |                          |   
		And In OLS03104 I verfiy following for row "1"
		| CntName      | CntResCountry | CntCtznCountry | CntBen      |
		| <NewCntName> | <NewCountry>  |                | Controlling |
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131604602
		Then In ENS01001 form I verify US Tax warning at position "3" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName      | CntAddressLine1      | CntAddressLine2      | CntAddressLine3      | CntAddressLine4      | CntPostcode      | CntCountry   | CntCitizenship | CntTaxIdentifier | CntTin | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| <NewCntName> | <NewCntAddressLine1> | <NewCntAddressLine2> | <NewCntAddressLine3> | <NewCntAddressLine4> | <NewCntPostcode> | <NewCountry> |                |                  |        |              |              |          |          |              |              |           |           |           |           |                  |
		 And I press ESC
		 And I press ESC
		 And IN ENTUSA03 I press ESC
	  And I exit to main from enquiry system
	  When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131604602"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03101 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912376   |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1" 
		And In OLS03105 I enter action "D" "Y"
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131604602
	Then In ENS01001 form I verify US Tax warning at position "3" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
		And I expect to see error with text "No Controlling Person or Beneficial Owner"
		And I press ESC

Examples: 
		| CntAccountType | CntName           | CntAddressLine1       | CntAddressLine2            | CntAddressLine3 | CntAddressLine4 | CntPostcode | Country | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | NewCntName       | NewCntAddressLine1 | NewCntAddressLine2 | NewCntAddressLine3 | NewCntAddressLine4 | NewCntPostcode | NewCountry |
		|                | DR JUMMOEW VINCOV | LORVEV VITMEOWU-BKUWX | <VITMEOWU-BKUWX IQAP A/C>, | 3 JMASI STREET  | JIASWIQVEZ TAS  | 3877        | GBR     |           |                |           |                      |                  |                  |                      |                        |                          |                   |           |           |           |                          | REV SUXW ETNYIYQ | GIXPIDF-AHOCOK     | 14 VIZACJUDVG ROAD | SUZESUZV WA        | WA                 | 3455           | NZL        |
	


@winformsTest
@WES_AUTO
@OL_SDM_StaticDetailMaintenance
@21052
 	Scenario Outline: Test Case 21052: 05 - US Taxpayer Details - Add, Change, Modify and Delete Controlling Persons for CDI with Form: W-8EXP Form
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In housekeeping US Tax Reporting Obligation is set as "C" "" "" "" ""
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131604769"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		| TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912377   |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "C"  
		And In OLS03105 I continue with following 
		| CntAccountType | CntName   | CntAddressLine1   | CntAddressLine2   | CntAddressLine3   | CntAddressLine4   | CntPostcode   | Country   | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | 
		|                | <CntName> | <CntAddressLine1> | <CntAddressLine2> | <CntAddressLine3> | <CntAddressLine4> | <CntPostcode> | <Country> |           |                |           |                      |                  |                  |                      |                        |                          |                   |           |           |           |                          |   
		And In OLS03104 I verfiy following for row "1"
		| CntName   | CntResCountry | CntCtznCountry | CntBen      |
		| <CntName> | <Country>     |                | Controlling |
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131604769
		Then In ENS01001 form I verify US Tax warning at position "3" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName   | CntAddressLine1   | CntAddressLine2   | CntAddressLine3   | CntAddressLine4   | CntPostcode   | CntCountry | CntCitizenship | CntTaxIdentifier | CntTin | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| <CntName> | <CntAddressLine1> | <CntAddressLine2> | <CntAddressLine3> | <CntAddressLine4> | <CntPostcode> | <Country>  |                |                  |        |              |              |          |          |              |              |           |           |           |           |                  |
		 And I press ESC
		 And I press ESC
		And IN ENTUSA03 I press ESC
	    And I exit to main from enquiry system 
	 When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131604769"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
		| TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912378    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1"  
		And In OLS03105 I enter action "C" ""
		And In OLS03105 I continue with following 
		| CntAccountType | CntName      | CntAddressLine1      | CntAddressLine2      | CntAddressLine3      | CntAddressLine4      | CntPostcode      | Country      | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException |
		|                | <NewCntName> | <NewCntAddressLine1> | <NewCntAddressLine2> | <NewCntAddressLine3> | <NewCntAddressLine4> | <NewCntPostcode> | <NewCountry> |           |                |           |                      |                  |                  |                      |                        |                          |                   |           |           |           |                          |   
		And In OLS03104 I verfiy following for row "1"
		| CntName      | CntResCountry | CntCtznCountry | CntBen      |
		| <NewCntName> | <NewCountry>  |                | Controlling |
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131604769
		Then In ENS01001 form I verify US Tax warning at position "3" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
	    And In ENTUSA04 I enter "1"
		And In ENTUSA05 I verify the following
		| CntName      | CntAddressLine1      | CntAddressLine2      | CntAddressLine3      | CntAddressLine4      | CntPostcode      | CntCountry   | CntCitizenship | CntTaxIdentifier | CntTin | CntDobIncorp | CntTinStatus | CntChpt3 | CntChpt4 | CntUSTaxCode | CntW8ExpDate | CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | CntGiinException |
		| <NewCntName> | <NewCntAddressLine1> | <NewCntAddressLine2> | <NewCntAddressLine3> | <NewCntAddressLine4> | <NewCntPostcode> | <NewCountry> |                |                  |        |              |              |          |          |              |              |           |           |           |           |                  |
		 And I press ESC
		 And I press ESC
		 And IN ENTUSA03 I press ESC
	  And I exit to main from enquiry system
	  When I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0131604769"
		And In OLS01102 I enter following details as the update option "U" "UX"
		And In OLS03102 I enter action "1"
		And In OLS03103 I enter action "C"
		And In OLS03103 I continue with following
	    | TransNbrI | InvAccountType | InvName | InvTinStatus | InvTin | InvUSTaxCode | W8ExpiryDate | InvChapter3 | InvChapter4 | InvBirthDate | InvCountryIncorp | InvForeignTaxID | InvAddress1 | InvAddress2 | InvGiinP1 | InvGiinP2 | InvGiinP3 | InvGiinP4 | InvGiinException | InvWorstCaseInd | AddBen |
	    | 912379    |                |         |              |        |              |              |             |             |              |                  |                 |             |             |           |           |           |           |                  |                 | Y      |
		And In OLS03104 I enter action "1" 
		And In OLS03105 I enter action "D" "Y"
		And In OLS03104 I enter action "U" 
		And I exit to main from online system
		And I go to the Enquiry system and Search I0131604769
	Then In ENS01001 form I verify US Tax warning at position "3" value "Holder Extra/US Tax present"
		And In ENS01001 I enter action "UT"
		And In  ENTUSA01 I enter action "1" 
		And In ENTUSA03 I enter "C"
		And I expect to see error with text "No Controlling Person or Beneficial Owner"
		And I press ESC

Examples: 
		| CntAccountType | CntName           | CntAddressLine1       | CntAddressLine2            | CntAddressLine3 | CntAddressLine4 | CntPostcode | Country | TinStatus | Ols03105CntTin | USTaxCode | Ols03105CntW8ExpDate | Ols03105CntChpt3 | Ols03105CntChpt4 | Ols03105CntDobIncorp | Ols03105CntCitizenship | Ols03105CntTaxIdentifier | Ols03105CntGiinP1 | CntGiinP2 | CntGiinP3 | CntGiinP4 | Ols03105CntGiinException | NewCntName       | NewCntAddressLine1 | NewCntAddressLine2 | NewCntAddressLine3 | NewCntAddressLine4 | NewCntPostcode | NewCountry |
		|                | DR JUMMOEW VINCOV | LORVEV VITMEOWU-BKUWX | VITMEOWU-BKUWX IQAP A/C>   | 3 JMASI STREET  | JIASWIQVEZ TAS  | 3877        | AUS     |           | 99-7894645     |           |                      |                  |                  |                      |                        |                          |                   |           |           |           |                          | REV SUXW ETNYIYQ | GIXPIDF-AHOCOK     | 14 VIZACJUDVG ROAD | SUZESUZV WA        | WA                 | 3455           | NZL        |
	 