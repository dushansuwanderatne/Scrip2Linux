Feature: OL_UNC_UncertificatedTransactions-Test	    
	Ensure SDM. Static Detail Maintenance functionality covered
	DBENIb
@winformsTest
@OL_Online
@CPU_AUTO
@30562
@OL_UNC_UncertificatedTransactions
@FullSmokeTest
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
		| Test1 | ISLST   | 12221      | I0030139798 | #W215        | REPLACE LOST SRN FROM |           |        | FP /ORDINARY FULLY PAID SHARES | VIC UNCERTIF'D   11/06/02 RTFXI 1353/10461026           1000  X0007543361 | 19/03/13 DRPAL 4141/12345377             13 | 17/09/13 DRPAL 4281/12485982             15 | **** Class Total ***          1028 |                  |                  |                  |                  |                   | 11/06/2002   | 22/04/2015    | 11/06/2002      | 8       | 4097          | 0           | 0               |         |           |

@winformsTest
@OL_Online
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
		| BuyClass   | BuyBroker   | BuySbn   | BuyReg   | BuyReference   | BuySearchName   | SellCert1   | SellUnits1   | SellDate1   | SellCert2   | SellUnits2   | SellDate2   | SellCert3   | SellUnits3   | SellDate3   |
		| <BuyClass> | <BuyBroker> | <BuySbn> | <BuyReg> | <BuyReference> | <BuySearchName> | <SellCert1> | <SellUnits1> | <SellDate1> | <SellCert2> | <SellUnits2> | <SellDate2> | <SellCert3> | <SellUnits3> | <SellDate3> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


 Examples: 
		| Test          | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate  | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | BuyClass | BuyBroker | BuySbn | BuyReg | BuyReference | BuySearchName | TransferUnits | BuyTransDate | CertificateLine1                 | CertificateLine2                                                                     | CertificateLine3                                                                    | CertificateLine4                                                                    | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | Action | LocateArgument | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | BuySplitUnits1to53 | BuySplitNbr1to53 | SellCert1 | SellUnits1 | SellDate1 | SellCert2 | SellUnits2 | SellDate2 | SellCert3 | SellUnits3 | SellDate3 |
		| TestCase31579 | IAJST   | 42304       | 150        | ORD       | 44411         | 58872      | 11/08/2015 | 59999   | I0011043224    |            |              |         | E12      | 58872     | 59999  |        |              | I0011043224   | 150           |              | E12/CAPITAL NOTES 3 SH OFFER ENT | VIC 00189077     31/12/14   99999999999    VIC 00189077     21/02/15            250- | VIC 00189077     24/02/15            50-   VIC 00189077     00/00/00            150 | **** Total for 00189077          99999999849                                        |                  |                  |                  |                  |                  |                   | C      | /E12           |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |                    |                  |           |            |           |           |            |           |           |            |           |
		| TestCase31580 | IAJST   | 42305       | 100        | PA        | 78789         | 58872      | 11/08/2015 | 59999   | I0013224617    |            |              |         | ORD      | 58872     | 59999  |        |              | I0060158151   | 100           |              | ORD/ORDINARY SHARES              | VIC UNCERTIF'D   28/11/03            76    VIC UNCERTIF'D   31/01/05            146  | VIC UNCERTIF'D   00/00/00           100                                             | **** Total for UNCERTIF'D                322                                        |                  |                  |                  |                  |                  |                   | C      | /ORD           |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |                    |                  |           |            |           |           |            |           |           |            |           |
		| TestCase31581 | IAJST   | 42306       | 200        | PE        | 74745         | 58872      | 11/08/2015 | 59999   | I0011043216    |            |              |         | PE       |           |        | VIC    | 78888        | C0000465934   | 200           |              | PE /CAPITAL NOTES 2              | *VIC  S334455     00/00/00           200                                             |                                                                                     |                                                                                     |                  |                  |                  |                  |                  |                   | C      | /PE            | S334455   |                  |                  |                  |                  |                  |                  |                  |                    |                    |                    |                  |           |            |           |           |            |           |           |            |           |
		| TestCase31582 | IAJST   | 42307       | 665        | ORD       | 123123        | 59999      | 11/08/2015 |         |                | W152477    | C0000465948  | VIC     | ORD      |           | 59999  |        |              | I0010104751   |               |              | ORD/ORDINARY SHARES              | VIC UNCERTIF'D   27/03/98           658    VIC UNCERTIF'D   06/07/98             15  | VIC UNCERTIF'D   21/12/98            17    VIC UNCERTIF'D   05/07/99             17 | VIC UNCERTIF'D   20/12/99            18    VIC UNCERTIF'D   03/07/00             18 |                  |                  |                  |                  |                  |                   | C      | /ORD           |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |                    |                  |           |            |           |           |            |           |           |            |           |

@winformsTest
@OL_Online
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
		| TestCase32152-1 | IAJUP   | 42308       | 250        | ORD      | L9999  | L03321966345  | TestRef1     | L9999     |              | 250          | C      | /ORD           | ORD/ORDINARY SHARES                | NZL UNCERTIF'D   00/00/00           250                                             | **** Total for UNCERTIF'D                250 |                  |                  |                  |                  |                  |                  |                   |
		| TestCase32152-2 | IAJUP   | 42309       | 300        | SGI      | 59999  | I0060172498   | TestRef2     | 58872     | 10/09/2015   | 300          | C      | /SGI           | SGI/STONES GEN NOTES APP - INTERNT | GBR 00000002     10/09/15           355                                             | **** Total for 00000002                  355 |                  |                  |                  |                  |                  |                  |                   |
		| TestCase32152-3 | IAJUP   | 42310       | 750        | ASA      | N9999  | N00002098256  | TestRef3     | N9999     | 20/09/2015   | 750          | C      | /ASA           | ASA/ASA STANDING PROXY - DONT DUMP | NZL UNCERTIF'D   11/08/15           640    NZL UNCERTIF'D   20/09/15            750 | **** Total for UNCERTIF'D               1390 |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@32153
@OL_UNC_UncertificatedTransactions
@FullSmokeTest
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
		| TestCase32153 | IAJUP   | 42311       | 58960      | CNR      | 59999  | I0060112908   | Money1       | 58872     |              | 58960        | C      | /CNR           | CNR/REFUND CAPITAL NOTES OFFER | *MR 00000007     11/08/15       1182.50 | **** Total for 00000007              1182.50 | *MR 00000010     00/00/00        589.60 | **** Total for 00000010               589.60 |                  |                  |                  |                  |                   |
		
@winformsTest
@OL_Online
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
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |



 Examples: 
		| Test          | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | TransferUnits | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | Action | LocateArgument | CertificateLine1             | CertificateLine2                        | CertificateLine3                             | CertificateLine4                        | CertificateLine5                             | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | BuySplitUnits1to53 | BuySplitNbr1to53 |
		| TestCase32155 | IAJUP   | 42312       | 590        | S10      | 59999  | I0060112355   | 99665533     | 58872     |              | 58960        | 590           | 777888    | ForwardTest1     | ForwardTest2     |                  |                  |                  | C      | /S10           | S10/ISX0011 ACCEPTANCE CLASS | VIC 00125001     21/09/15           590 | **** Total for 00125001                  590 | VIC 00777888     00/00/00           590 | **** Total for 00777888                  590 |                  |                  |                  |                  |                   |                  |                  |                    |                    |                    |                  |

@winformsTest
@OL_Online
@ANZ_AUTO
@32186
@OL_UNC_UncertificatedTransactions
Scenario Outline:Test Case 32186 OLSCRT Issuer Adjustment and Off Market Transactions
#Test Case 32186: 04 ###Verify IAJUP transaction not allowed for Chess holders
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
	Then I should see the below ErrorMessage "<ErrorMessage>"

 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ErrorMessage                                      |
		| Test1 | IAJUP   | 42313       | 800        | ORD      | 20006  | X0000103730   |              |           |              | "X" type holder not permitted on this transaction |

@winformsTest
@OL_Online
@ANZ_AUTO
@32187
@OL_UNC_UncertificatedTransactions
Scenario Outline: Test Case 32187 OLSCRT Issuer Adjustment
###Test Case 32187 OLSCRT Issuer Adjustment and Off Market Transactions - Error validation for OLSCRTUU for IAJUP
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
	Then I should see the below ErrorMessage "<ErrorMessage>"

 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ErrorMessage                                            |
#		| Test1 | IAJUP   | 42314       | -100       |          |        |               |              |           |              | You cannot enter negative numbers                       |
		| Test2 | IAJUP   | 42314       | 100        | POO      |        |               |              |           |              | Class POO:Company class not on file                     |
		| Test3 | IAJUP   | 42314       | 100        | ORD      | 0001   |               |              |           |              | 0001 Broker code not on SRCCDE file                     |
		| Test4 | IAJUP   | 42314       | 100        | ORD      | VIC    | C0000465944   |              |           |              | VIC Broker code not on SRCCDE file                      |
		| Test5 | IAJUP   | 42314       | 100        | PRR      | 59999  | I0200001681   |              |           |              | Non ESS transactions cannot be processed on ESS classes |
		| Test6 | IAJUP   | 42314       | 100        | FPD      | 59999  | I0200001681   |              |           |              | Class Type "X" cannot be traded on this trans code      |

@winformsTest
@OL_Online
@ANZ_AUTO
@32237
@OL_UNC_UncertificatedTransactions
Scenario Outline: OLSCRT Error validation for OLSCRTUU for IAJDN
###Test Case 32237: 07
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
	Then I should see the below ErrorMessage "<ErrorMessage>"

 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ErrorMessage                             |
		| Test1 | IAJDN   | 42314       | 100        | PB       | 59999  | I0200001541   |              |           |              | No units for HIN/Class (I0200001541/PB ) |

@winformsTest
@OL_Online
@ANZ_AUTO
@32284
@OL_UNC_UncertificatedTransactions
Scenario Outline: Test Case 32284 OLSCRT Issuer Adjustment
###Test Case 32284: 08 - OLSCRT | Issuer Adjustment and Off Market Transactions - Process IAJDN transaction for Class Type : S, U
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
		| Test  | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | Action | LocateArgument | CertificateLine1                   | CertificateLine2                                                                    | CertificateLine3                             | CertificateLine4                             | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
		| Test1 | IAJDN   | 42315       | 50         | ORD      | L9999  | L0330468009   | DECRE1       | L9999     | 11/08/15     | 50           | C      | /ORD           | ORD/ORDINARY SHARES                | NZL UNCERTIF'D   11/08/15           400                                             | **** Total for UNCERTIF'D                400 |                                              |                  |                  |                  |                  |                  |                   |
		| Test2 | IAJDN   | 42316       | 240        | ASA      | N9999  | N00002098256  | DECRE2       | N9999     | 20/08/15     | 240          | C      | /ASA           | ASA/ASA STANDING PROXY - DONT DUMP | NZL UNCERTIF'D   11/08/15           640    NZL UNCERTIF'D   20/09/15            750 | NZL UNCERTIF'D   20/08/15           240-     | **** Total for UNCERTIF'D               1150 |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@32335
@OL_UNC_UncertificatedTransactions
@FullSmokeTest
Scenario Outline: Test Case 32335 OLSCRT Issuer Adjustment
###Test Case 32335: 09 - OLSCRT | Issuer Adjustment and Off Market Transactions - Process IAJDN transaction for Class Type :  I
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
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | SellCert1 | SellCert2 | SellUnits1 | SellUnits2 | Action | LocateArgument | CertificateLine1             | CertificateLine2                                                                     | CertificateLine3                             | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | SellCert3 | SellCert4 | SellCert5 | SellUnits3 | SellUnits4 | SellUnits5 |
		| Test1 | IAJDN   | 42317       | 25         | S10      | 59999  | I0060356297   | DEC3         | 58872     | 10/09/2015   | 50           | 00000001  |           | 25         |            | C      | /S10           | S10/ISX0011 ACCEPTANCE CLASS | VIC 00000001     11/08/15            90    VIC 00000001     10/09/15             25- | **** Total for 00000001                   65 |                  |                  |                  |                  |                  |                  |                   |           |           |           |            |            |            |

@winformsTest
@OL_Online
@ANZ_AUTO
@32424
@OL_UNC_UncertificatedTransactions
Scenario Outline: Test Case 32424 OLSCRT Issuer Adjustment
###Test Case 32424: 11 - OLSCRT | Issuer Adjustment and Off Market Transactions - Process IAJDN transaction for Class Type :  M
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
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
	

 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | BuyClass | BuySbn | BuySearchName | BuyReference | BuyBroker | BuyTransDate | ConfirmUnits | SellCert1  | SellCert2 | SellUnits1 | SellUnits2 | Action | LocateArgument | CertificateLine1        | CertificateLine2                                                                     | CertificateLine3                             | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | SellCert3 | SellCert4 | SellCert5 | SellUnits3 | SellUnits4 | SellUnits5 |
		| Test1 | IAJDN   | 42318       | 20000      | CNM      | 59999  | I0010052343   | DEC4         | 58872     |              |              | 60302609MD |           | 20000      |            | C      | /CNM           | CNM/CAPITAL NOTES MONEY | *MR 60302609MD   25/07/13       5000.00    *MR 60302609MD   00/00/00         200.00- | **** Total for 60302609MD            4800.00 |                  |                  |                  |                  |                  |                  |                   |           |           |           |            |            |            |

@winformsTest
@OL_Online
@ANZ_AUTO
@32459
@OL_UNC_UncertificatedTransactions
Scenario Outline: Test Case 32459 OLSCRT Issuer Adjustment
###Test Case 32459: 12 - OLSCRT | Issuer Adjustment and Off Market Transactions - Transfer units from uncertificated to uncertificated holder for S class
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		#Added a new binding without using the existing -need to change it later
		And IN OLSCRTUU I continue with the following values:
		| TransNumber   | TotalUnits   | SellClass   | SellSbn   | SellSearchName   | SellReference   | SellBroker   | BuySbn   | BuySearchName   | BuyReference   | BuyBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellSbn> | <SellSearchName> | <SellReference> | <SellBroker> | <BuySbn> | <BuySearchName> | <BuyReference> | <BuyBroker> |
		And IN OLSCRTUX I continue with the following details:
		| ConfirmUnits   |
		| <ConfirmUnits> |
		And In OLSCRTFI I continue with the following details:
		| BuyFwdInstruction1   | BuyFwdInstruction2   |
		| <BuyFwdInstruction1> | <BuyFwdInstruction2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellSearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
	When I enter the following details as the Locate action "<Action1>" "<LocateArgument1>"
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1b> | <CertificateLine2b> | <CertificateLine3b> | <CertificateLine4b> | <CertificateLine5b> | <CertificateLine6b> | <CertificateLine7b> | <CertificateLine8b> | <CertificateLine9b> | <CertificateLine10b> |

 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellSbn | SellSearchName | SellReference | SellBroker | BuySbn | BuySearchName | BuyReference | BuyBroker | ConfirmUnits | BuyFwdInstruction1 | BuyFwdInstruction2 | Action | LocateArgument | CertificateLine1    | CertificateLine2                                                                    | CertificateLine3                         | CertificateLine4                             | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | Action1 | LocateArgument1 | CertificateLine1b   | CertificateLine2b                                                                   | CertificateLine3b                                                                   | CertificateLine4b                            | CertificateLine5b | CertificateLine6b | CertificateLine7b | CertificateLine8b | CertificateLine9b | CertificateLine10b |
		| Test1 | OFMUU   | 42319       | 182        | ORD       | 59999   | I0010328021    | TRANF1        | 58872      | 59999  | I0010587107   | TOTRAN1      | 58872     | 182          | TEST1              | TEST2              | C      | /ORD           | ORD/ORDINARY SHARES | VIC UNCERTIF'D   27/03/98          1000    VIC UNCERTIF'D   28/11/03            182 | VIC UNCERTIF'D   00/00/00           182- | **** Total for UNCERTIF'D               1000 |                  |                  |                  |                  |                  |                   | S       | I0010587107     | ORD/ORDINARY SHARES | VIC UNCERTIF'D   27/03/98          1000    VIC UNCERTIF'D   28/11/03            182 | VIC UNCERTIF'D   13/07/09          1042    VIC UNCERTIF'D   00/00/00            182 | **** Total for UNCERTIF'D               2406 |                   |                   |                   |                   |                   |                    |

@winformsTest
@OL_Online
@ANZ_AUTO
@32486
@OL_UNC_UncertificatedTransactions
Scenario Outline: Test Case 32486 OLSCRT Issuer Adjustment
##Test Case 32486: 13 - OLSCRT | Issuer Adjustment and Off Market Transactions - Transfer units from I to L type holder for  W class ###
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTUU I continue with the following values:
		| TransNumber   | TotalUnits   | SellClass   | SellSbn   | SellSearchName   | SellReference   | SellBroker   | BuySbn   | BuySearchName   | BuyReference   | BuyBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellSbn> | <SellSearchName> | <SellReference> | <SellBroker> | <BuySbn> | <BuySearchName> | <BuyReference> | <BuyBroker> |
		And IN OLSCRTTU I continue with the following values:
		| SellCert1   | SellCert2   | SellUnits1   | SellUnits2   | BuySbn   | BuySearchName   | BuyReference   | BuyBroker   |
		| <SellCert1> | <SellCert2> | <SellUnits1> | <SellUnits2> | <BuySbn> | <BuySearchName> | <BuyReference> | <BuyBroker> |
		And IN OLSCRTBF I continue with the following values:
		| TransferUnits   |
		| <TransferUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellSearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
	When I enter the following details as the Locate action "<Action1>" "<LocateArgument1>"
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1b> | <CertificateLine2b> | <CertificateLine3b> | <CertificateLine4b> | <CertificateLine5b> | <CertificateLine6b> | <CertificateLine7b> | <CertificateLine8b> | <CertificateLine9b> | <CertificateLine10b> |
	
 Examples: 
		| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellSbn | SellSearchName | SellReference | SellBroker | BuySbn | BuySearchName | BuyReference | BuyBroker | SellCert1 | SellCert2 | SellUnits1 | SellUnits2 | TransferUnits | Action | LocateArgument | CertificateLine1               | CertificateLine2                                                                     | CertificateLine3                             | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | Action1 | LocateArgument1 | CertificateLine1b              | CertificateLine2b                       | CertificateLine3b                            | CertificateLine4b | CertificateLine5b | CertificateLine6b | CertificateLine7b | CertificateLine8b | CertificateLine9b | CertificateLine10b |
		| Test1 | OFMUU   | 42320       | 100        | GRP       | 59999   | I0010529999    | TRANS2        |            | L9999  | L0330468009   | TRAN2        | L9999     | 00000046  |           | 100        |            | 100           | C      | /GRP           | GRP/GEN REINVESTMENT VIA PAPER | VIC 00000046     31/03/14           300    VIC 00000046     00/00/00            100- | **** Total for 00000046                  200 |                  |                  |                  |                  |                  |                  |                   | S       | L0330468009     | GRP/GEN REINVESTMENT VIA PAPER | NZL 00000349     00/00/00           100 | **** Total for 00000349                  100 |                   |                   |                   |                   |                   |                   |                    |  


@winformsTest
@OL_Online
@ANZ_AUTO
@33707
@OL_UNC_UncertificatedTransactions
Scenario: Test Case 33707: 01 - OLSCRT | Deceased Estate Transactions - Deceased Estates Transfer to beneficiary using DBENI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| DBENI		|
		And IN OLSCRTUU I continue with the following values:
		| TransNumber | TotalUnits | SellClass | SellSbn | SellSearchName | SellReference | SellBroker | BuySbn | BuySearchName | BuyReference | BuyBroker |
		| 42322       | 1500       | O39       | 59999   | I0060160309    | BEN1          | 58872      | L9999  | L3242343246   | BENTO1       | L9999     |
		And IN OLSCRTUX I continue with the following details:
		| ConfirmUnits |
		| 1500         |
	Then I exit to main from online system 
		And I go to the Enquiry system and Search L3242343246
		And I enter the following details as the Locate action "C" "/o39"
		And In ENS01012 I should see Register details as:
 		| CertificateLine1                  | CertificateLine2                        | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
 		| O39/*OPT $16.33 25/10/04-24/10/08 | NZL UNCERTIF'D   00/00/00          1500 |                  |                  |                  |                  |                  |                  |                  |                   |
		And I go to the Enquiry system and Search I0060160309
		And I enter the following details as the Locate action "C" "/o39"
		And In ENS01012 I should see Register details as:
 		| CertificateLine1                  | CertificateLine2                                                                     | CertificateLine3                                                                     | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
 		| O39/*OPT $16.33 25/10/04-24/10/08 | VIC UNCERTIF'D   24/10/01           500    VIC UNCERTIF'D   28/10/04            500- | VIC UNCERTIF'D   11/08/15          1500    VIC UNCERTIF'D   00/00/00           1500- |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@33710
@OL_UNC_UncertificatedTransactions
Scenario: Test Case 33710: 03 - OLSCRT | Deceased Estate Transactions - Deceased Estates transmission to executor using DTNSI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| DTNSI		|
		And IN OLSCRTUU I continue with the following values:
		| TransNumber | TotalUnits | SellClass | SellSbn | SellSearchName | SellReference | SellBroker | BuySbn | BuySearchName | BuyReference | BuyBroker |
		| 42323       | 500        | SGI       | 59999   | I0060146705    | TRANS1        | 58872      | N9999  | N8888898776   | TRANSTO1     | N9999     |
		And IN OLSCRTTU I continue with the following values:
		| SellCert1 | SellCert2 | SellUnits1 | SellUnits2 |
		| 0000004   |           |  500       |            |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits |
		| 500			|
	Then I exit to main from online system 
		And I go to the Enquiry system and Search I0060146705 
		And I enter the following details as the Locate action "C" "/SGI"
		And In ENS01012 I should see Register details as:
 		| CertificateLine1                   | CertificateLine2                                                                     | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
 		| SGI/STONES GEN NOTES APP - INTERNT | VIC 00000004     11/08/15           878    VIC 00000004     00/00/00            500- |                  |                  |                  |                  |                  |                  |                  |                   |
		And I go to the Enquiry system and Search N8888898776 
		And I enter the following details as the Locate action "C" "/SGI"
		And In ENS01012 I should see Register details as:
 		| CertificateLine1                   | CertificateLine2                        | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
 		| SGI/STONES GEN NOTES APP - INTERNT | NZL 00000005     00/00/00           500 |                  |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@33709
@OL_UNC_UncertificatedTransactions
Scenario: Test Case 33709: 02 - OLSCRT | Deceased Estate Transactions - Deceased Estates Transfer to Suvivor using DSURI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| DSURI		|
		And IN OLSCRTUU I continue with the following values:
		| TransNumber | TotalUnits | SellClass | SellSbn | SellSearchName | SellReference | SellBroker | BuySbn | BuySearchName | BuyReference | BuyBroker |
		| 42324       | 2000       | ORD       | 59999   | I0010081483    | SURV1         | 58872      | 59999  | I0010088798   | SURVTO1      | 59999     |
		And IN OLSCRTUX I continue with the following details:
		| ConfirmUnits | BuyReg |
		| 2000         | VIC    |
		And In OLSCRTFI I continue with the following details:
		| BuyFwdInstruction1 | BuyFwdInstruction2 |
		| Test1              | Test2              |
	Then I exit to main from online system 
	When I go to the Enquiry system and Search I0010081483
		And I enter the following details as the Locate action "H" "/ORD"
	Then In ENS01007 I should see Holdings details as below "*ORD/ORDINARY SHARES         VIC          7175                      7175" " " " " " "
		When I go to the Enquiry system and Search I0010088798
		And I enter the following details as the Locate action "H" "/ORD"
	Then In ENS01007 I should see Holdings details as below "*ORD/ORDINARY SHARES         VIC          2000                      2000" " " " " " "
	


