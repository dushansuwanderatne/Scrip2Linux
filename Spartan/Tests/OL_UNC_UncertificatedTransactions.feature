Feature: OL_UNC_UncertificatedTransactions
	Ensure OL_UNC_UncertificatedTransactions functionality covered

@CPU_AUTO
@30562
@OL_UNC_UncertificatedTransactions
Scenario Outline: Test Case 30562: 01 - OLS030 | Verify Lost SRN Replacement (ISLST)
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLS03001 I continue with the following details:
		| TranNumber   | FromNameKey   |
		| <TranNumber> | <FromNameKey> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <FromNameKey>
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | .     |
			| Locate Argument |       |
	Then In ENS01052 I should see NameAddress Extra Details as below "<FromNameKey>" "<HolderOnDate>" "<HolderOffDate>" "<HolderAddedDate>" "<Version>" "<RunLastChange>" "<LastBalDump>" "<LastPaymentDump>" "<MergeTo>" "<MergeFrom>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | SH    |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	Then In ENS01035 I should see Static History as:
	| TranTypeCode   | TranTypeDesc   | Reference   |
	| <TranTypeCode> | <TranTypeDesc> | <Reference> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry System and Search for the NewSRN as:
		| NewSRN   |
		| <NewSRN> |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | R     |
			| Locate Argument | /FP   |
	Then In ENS01013 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

 Examples: 
		| Test  | SelCode | TranNumber | FromNameKey | TranTypeCode | TranTypeDesc          | Reference | NewSRN | CertificateLine1               | CertificateLine2                                                          | CertificateLine3                            | CertificateLine4                            | CertificateLine5                   | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | HolderOnDate | HolderOffDate | HolderAddedDate | Version | RunLastChange | LastBalDump | LastPaymentDump | MergeTo | MergeFrom |
		| Test1 | ISLST   | 12221      | I0030139798 | ISLFR        | REPLACE LOST SRN FROM |           |        | FP /ORDINARY FULLY PAID SHARES | VIC UNCERTIF'D   11/06/02 RTFXI 1353/10461026           1000  X0007543361 | 19/03/13 DRPAL 4141/12345377             13 | 17/09/13 DRPAL 4281/12485982             15 | **** Class Total ***          1028 |                  |                  |                  |                  |                   | 11/06/2002   | 22/04/2015    | 11/06/2002      | 8       | 4097          | 0           | 0               |         |           |



@ANZ_AUTO
@31579
@OL_UNC_UncertificatedTransactions
Scenario Outline: OLSCRT | Issuer Adjustment Transaction
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSA I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReference   | SellBroker   | TransDate   | SellSbn   | SellSearchName   | SellCertID   | SellHolderID   | SellReg   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReference> | <SellBroker> | <TransDate> | <SellSbn> | <SellSearchName> | <SellCertID> | <SellHolderID> | <SellReg> |
		And IN OLSCRTTA I continue with the following details:
		| BuyClass   | BuyBroker   | BuySbn   | BuyReg   | BuyReference   | BuySearchName   |
		| <BuyClass> | <BuyBroker> | <BuySbn> | <BuyReg> | <BuyReference> | <BuySearchName> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01013 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


 Examples: 
		| Test          | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate  | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | BuyClass | BuyBroker | BuySbn | BuyReg | BuyReference | BuySearchName | TransferUnits | BuyTransDate | CertificateLine1                 | CertificateLine2                                                                           | CertificateLine3                            | CertificateLine4                                                                           | CertificateLine5                                                        | CertificateLine6                                                                           | CertificateLine7                            | CertificateLine8                            | CertificateLine9                            | CertificateLine10                           | Action | LocateArgument | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 |
		| TestCase31579 | IAJST   | 42304       | 150        | ORD       | 44411         | 58872      | 11/08/2015 | 59999   | I0011043224    |            |              |         | E12      | 58872     | 59999  |        |              | I0011043224   | 150           |              | E12/CAPITAL NOTES 3 SH OFFER ENT | VIC 00189077     31/12/14 ENTIT 7776/55908494              1                               | 31/12/14 ENTIT 7776/55908495    99999999998 | 21/02/15 ASADJ 7825/56284376            250-                                               | 24/02/15 ASADJ 7828/56318442             50-                      SCRIP | *                 11/08/15 IAJST 7983/   42304            150      ***              WINFRM | *Certificate Balance   99999999849          | **** Class Total ***   99999999849          |                                             |                                             | R      | /E12           |           |                  |                  |                  |                  |                  |
		| TestCase31580 | IAJST   | 42305       | 100        | PA        | 78789         | 58872      | 11/08/2015 | 59999   | I0013224617    |            |              |         | ORD      | 58872     | 59999  |        |              | I0060158151   | 100           |              | ORD/ORDINARY SHARES              | VIC UNCERTIF'D   28/11/03 @03RI 3866/21275458             76                               | 31/01/05 ESCRS 4239/23028667            146 | *                 11/08/15 IAJST 7983/   42305            100  WXOXIW      QEJT  ER WINFRM | **** Class Total ***           322                                      |                                                                                            |                                             |                                             |                                             |                                             | R      | /ORD           |           |                  |                  |                  |                  |                  |
		| TestCase31581 | IAJST   | 42306       | 200        | PE        | 74745         | 58872      | 11/08/2015 | 59999   | I0011043216    |            |              |         | PE       |           |        | VIC    | 78888        | C0000465934   | 200           |              | PE /CAPITAL NOTES 2              | *VIC  S334455     11/08/15 IAJST 7983/   42306            200  XIFUXD      XOOBZBEY WINFRM |                                             |                                                                                            |                                                                         |                                                                                            |                                             |                                             |                                             |                                             | R      | /PE            | S334455   |                  |                  |                  |                  |                  |
		| TestCase31582 | IAJST   | 42307       | 665        | ORD       | 123123        | 59999      | 11/08/2015 |         |                | W152477    | C0000465948  | VIC     | ORD      |           | 59999  |        |              | I0010104751   |               |              | ORD/ORDINARY SHARES              | VIC UNCERTIF'D   27/03/98 @CONV 2160/13145560            658                               | 06/07/98 DRPAL 2237/13397451             15 | 21/12/98 DRPAL 2364/13778922             17                                                | 05/07/99 DRPAL 2509/14231896             17                             | 20/12/99 DRPAL 2639/14721515             18                                                | 03/07/00 DRPAL 2785/15222016             18 | 15/12/00 DRPAL 2952/15779523             18 | 02/07/01 DRPAL 3103/16257882             17 | 14/12/01 DRPAL 3248/16959142             17 | R      | /ORD           |           |                  |                  |                  |                  |                  |

@ANZ_AUTO
@31579
@OL_UNC_UncertificatedTransactions
Scenario Outline: OLSCRT | Issuer Adjustment and Off Market Transactions
#Process IAJUP transaction for I , N and L type holder for Class Type : S, W,U
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTUU I continue with the following details:
		| TransNumber   | TotalUnits   | BuyClass   | BuySbn   | BuySearchName   | BuyReference   | BuyBroker   | BuyTransDate   |
		| <TransNumber> | <TotalUnits> | <BuyClass> | <BuySbn> | <BuySearchName> | <BuyReference> | <BuyBroker> | <BuyTransDate> |
		And IN OLSCRTUX I continue with the following details:
		| ConfirmUnits   |
		| <ConfirmUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |



 Examples: 
		| Test            | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | Action | LocateArgument | CertificateLine1                   | CertificateLine2                                                                    | CertificateLine3                             | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
		| TestCase32152-1 | IAJUP   | 42308       | 250        | ORD      | L9999  | L03321966345  | TestRef1     | L9999     |              | 250          | C      | /ORD           | ORD/ORDINARY SHARES                | NZL UNCERTIF'D   11/08/15           250                                             | **** Total for UNCERTIF'D                250 |                  |                  |                  |                  |                  |                  |                   |
		| TestCase32152-2 | IAJUP   | 42309       | 300        | SGI      | 59999  | I0060172498   | TestRef2     | 58872     | 10/09/2015   | 300          | C      | /SGI           | SGI/STONES GEN NOTES APP - INTERNT | GBR 00000002     10/09/15           355                                             | **** Total for 00000002                  355 |                  |                  |                  |                  |                  |                  |                   |
		| TestCase32152-3 | IAJUP   | 42310       | 750        | ASA      | N9999  | N00002098256  | TestRef3     | N9999     | 20/09/2015   | 750          | C      | /ASA           | ASA/ASA STANDING PROXY - DONT DUMP | NZL UNCERTIF'D   11/08/15           640    NZL UNCERTIF'D   20/09/15            750 | **** Total for UNCERTIF'D               1390 |                  |                  |                  |                  |                  |                  |                   |


@ANZ_AUTO
@32153
@OL_UNC_UncertificatedTransactions
Scenario Outline: OLSCRT | Issuer Adjustment and Off Market Transactions-M Class Type
#Process IAJUP transaction fo M Class Type
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTUU I continue with the following details:
		| TransNumber   | TotalUnits   | BuyClass   | BuySbn   | BuySearchName   | BuyReference   | BuyBroker   | BuyTransDate   |
		| <TransNumber> | <TotalUnits> | <BuyClass> | <BuySbn> | <BuySearchName> | <BuyReference> | <BuyBroker> | <BuyTransDate> |
		And IN OLSCRTUX I continue with the following details:
		| ConfirmUnits   |
		| <ConfirmUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |



 Examples: 
		| Test          | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | Action | LocateArgument | CertificateLine1               | CertificateLine2                        | CertificateLine3                             | CertificateLine4                        | CertificateLine5                             | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
		| TestCase32153 | IAJUP   | 42311       | 58960      | CNR      | 59999  | I0060112908   | Money1       | 58872     |              | 58960        | C      | /CNR           | CNR/REFUND CAPITAL NOTES OFFER | *MR 00000007     11/08/15       1182.50 | **** Total for 00000007              1182.50 | *MR 00000010     11/08/15        589.60 | **** Total for 00000010               589.60 |                  |                  |                  |                  |                   |



@ANZ_AUTO
@32155
@OL_UNC_UncertificatedTransactions
Scenario Outline: OLSCRT | Issuer Adjustment and Off Market Transactions-I Class Type
#Process IAJUP transaction fo M Class Type
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTUU I continue with the following details:
		| TransNumber   | TotalUnits   | BuyClass   | BuySbn   | BuySearchName   | BuyReference   | BuyBroker   | BuyTransDate   |
		| <TransNumber> | <TotalUnits> | <BuyClass> | <BuySbn> | <BuySearchName> | <BuyReference> | <BuyBroker> | <BuyTransDate> |
		And I Transmit
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |



 Examples: 
		| Test          | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | TransferUnits | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | Action | LocateArgument | CertificateLine1             | CertificateLine2                        | CertificateLine3                             | CertificateLine4                        | CertificateLine5                             | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
		| TestCase32155 | IAJUP   | 42312       | 590        | S10      | 59999  | I0060112355   | 99665533     | 58872     |              | 58960        | 590           | 777888    | ForwardTest1     | ForwardTest2     |                  |                  |                  | C      | /S10           | S10/ISX0011 ACCEPTANCE CLASS | VIC 00125001     21/09/15           590 | **** Total for 00125001                  590 | VIC 00777888     11/08/15           590 | **** Total for 00777888                  590 |                  |                  |                  |                  |                   |




