Feature: OL_STD_StandardTransactions
	Ensure MER. Merge Holders Transaction functionality covered

@winformsTest
@OL_Online	
@ANZ_AUTO
@30264
@OL_STD_StandardTransactions
Scenario Outline: Test Case 30264 OLSCRT CONSOLIDATE CERTIFICATE Transaction
###Test Case 30264: 02 - OLSCRT | CONSC - CONSOLIDATE CERTIFICATE Transaction - Combine shares on multiple certificates ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReference> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | Action | LocateArgument | SellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | BuyReference | Line1                                                                    | Line2 | Line3 | Line4 |
	| Test1 | CONSC   | 42322       | 1350       | ORD       |            | C0000465933  | VIC     | W152450   | W152451   | W152452   |           |           | 1000       | 125        | 225        |            |            | 1                | 1                | 1250               | 100                |               |              |           |                  |                  |                  |                  |                  | H      | /ORD           |            |                    |                  |              | *ORD/ORDINARY SHARES         VIC          1350                      1350 |       |       |       |

@winformsTest
@OL_Online
@ANZ_AUTO
@29166
@OL_STD_StandardTransactions
Scenario Outline: Test Case 29166 DBENC CERT DECD BENEFICALLY ENTITLED Transaction
###Test Case 29166: 01 - OLSCRT | DBENC - CERT DECD BENEFICALLY ENTITLED Transaction - Deceased Estates partial certificate Transfer to beneficiary using DBENC ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And I Transmit
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 | SellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 |
	| Test1 | DBENC   | 42323       | 500        | ORD       |            | C0000465926  | VIC     | W152436   |           |           |           |           | 500        |            |            |            |            | VIC    |           | C0000465923   |              | 400           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    | 100         | 11445566      |            | S                 | H      | /ORD           | *ORD/ORDINARY SHARES         VIC           200                       200 |       |       |       |            |                    |                  |

@winformsTest
@OL_Online
@ANZ_AUTO
@29177
@OL_STD_StandardTransactions
Scenario Outline: Test Case 29177 DBENC CERT DECD BENEFICALLY ENTITLED Transaction
###Test Case 29177: 02 - OLSCRT | DBENC - CERT DECD BENEFICALLY ENTITLED Transaction - Deceased Estates full certificate Transfer to beneficial using DBENC ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following values:
		| TransferUnits   |
		| <TransferUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 | SellBroker |
	| Test1 | DBENC   | 42324       | 2000       | ORD       |            | C0000465917  | VIC     | W152432   | W152439   |           |           |           | 1500       | 500        |            |            |            | VIC    |           | C0000465924   |              |               | H      | /ORD           | *ORD/ORDINARY SHARES         VIC          2000                      2000 |       |       |       |            |

@winformsTest
@OL_Online
@ANZ_AUTO
@29209
@OL_STD_StandardTransactions
Scenario Outline: Test Case 29209 DBENC CERT DECD BENEFICALLY ENTITLED Transaction Error Validations
###Test Case 29209: 03 - OLSCRT | DBENC - CERT DECD BENEFICALLY ENTITLED Transaction - Error Validations for OLSCRTSC ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
	Then I should see the below ErrorMessage "<ErrorMessage>"


	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | ErrorMessage                                        | SellBroker |
	| Test1 | DBENC   | 42325       | 0          |           |            |              |         | This field may not be zero                          |            |
	| Test2 | DBENC   | 42325       | 10         | ABC       |            |              |         | Company class not on file                           |            |
	| Test3 | DBENC   | 42325       | 10         | ORD       |            |              |         | 2223 Broker code not on SRCCDE file                 | 2223       |
	| Test4 | DBENC   | 42325       | 10         | A12       |            |              |         | Class Type "I" cannot be traded on this trans code  |            |
	| Test5 | DBENC   | 42325       | 100        | ORD       | W0987      |              |         | There are NO certificates which start with  W000987 |            |
	| Test6 | DBENC   | 42325       | 10         | ORD       |            |              | ABC     | Register code not on file                           |            |
	| Test7 | DBENC   | 42325       | 10         | ORD       |            | C0987        |         | Must enter sell register code                       |            |

@winformsTest
@OL_Online
@ANZ_AUTO
@29318
@OL_STD_StandardTransactions
Scenario Outline: Test Case 29318 DBENC CERT DECD BENEFICALLY ENTITLED Transaction Error Validations
###Test Case 29318: 04 - OLSCRT | DBENC - CERT DECD BENEFICALLY ENTITLED Transaction - Error Validations for OLSCRTTC ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | ErrorMessage                                                    |
	| Test1 | DBENC   | 42325       | 1000       | ORD       |            | C0000465920  | VIC     |            | W152495   |           |           |           |           | 3000       |            |            |            |            |        |           |               |              | This certificate is NOT on file for nominated                   |
	| Test2 | DBENC   | 42325       | 1000       | ORD       |            | C0000465920  | VIC     |            | CK        |           |           |           |           | 1000       |            |            |            |            |        |           |               |              | Certificate number must be > zero                               |
	| Test3 | DBENC   | 42325       | 1000       | ORD       |            | C0000465920  | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    |           |               |              | Certificate units (        350) do NOT add up to total units.   |
	| Test4 | DBENC   | 42325       | 1000       | ORD       |            | C0000465920  | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | OOO    |           |               |              | OOO/Register code not on file                                   |
	| Test5 | DBENC   | 42325       | 1000       | ORD       |            | C0000465920  | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    | 5         |               |              | 5 Broker code not on SRCCDE file                                |
	| Test6 | DBENC   | 42325       | 1000       | ORD       |            | C0000465920  | VIC     |            | W152434   |           |           |           |           | 1000       |            |            |            |            | VIC    |           |               |              | There are only         350 units remaining on this certificate. |

@winformsTest
@OL_Online
@ANZ_AUTO
@29740
@OL_STD_StandardTransactions
@FullSmokeTest
Scenario Outline: Test Case 29740 DSURC CERT DECD SURVIVORSHIP Transaction
###Test Case 29740: 01 - OLSCRT | DSURC - CERT DECD SURVIVORSHIP Transaction - Deceased Estates full certificate transfer with splits to survivor using DSURC ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1       | BuyInstructions2        | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 | BuySplitUnits1to53 | BuySplitNbr1to53 |
	| Test1 | DSURC   | 42326       | 3200       | ORD       |            | C0000465921  | VIC     |            | W152435   |           |           |           |           | 3200       |            |            |            |            | VIC    |           | C0000465927   |              | 3200          |              |           | TESTING FORWARDIN INS1 | TESTING FORWARDING INS2 |                  |                  |                  | 2                | 2                | 1000               | 600                |             |               |            | B                 | H      | /ORD           | *ORD/ORDINARY SHARES         VIC          3200                      3200 |       |       |      |                    |                  | 

@winformsTest
@OL_Online
@ANZ_AUTO
@29831
@OL_STD_StandardTransactions
Scenario Outline: Test Case 29831  DTNSC- CERT DECD Transmission
###Test Case 29831: 01 - OLSCRT | DTNSC- CERT DECD Transmission - Deceased Estates full certificate transfer with splits to seller ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
		And IN OLSCRTRE I continue with the following details:	
		| BuyInstructions1A   | BuyInstructions2A   | BuyInstructions3A   | BuyInstructions4A   | BuyInstructions5A   | BuySplitNbr1to51A   | BuySplitNbr1to52A   | BuySplitNbr1to53A   | BuySplitNbr1to54A   | BuySplitNbr1to55A   | BuySplitUnits1to51A   | BuySplitUnits1to52A   | BuySplitUnits1to53A   | BuySplitUnits1to54A   | BuySplitUnits1to55A   |
		| <BuyInstructions1A> | <BuyInstructions2A> | <BuyInstructions3A> | <BuyInstructions4A> | <BuyInstructions5A> | <BuySplitNbr1to51A> | <BuySplitNbr1to52A> | <BuySplitNbr1to53A> | <BuySplitNbr1to54A> | <BuySplitNbr1to55A> | <BuySplitUnits1to51A> | <BuySplitUnits1to52A> | <BuySplitUnits1to53A> | <BuySplitUnits1to54A> | <BuySplitUnits1to55A> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
	

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | BuyInstructions1A | BuyInstructions2A | BuyInstructions3A | BuyInstructions4A | BuyInstructions5A | BuySplitNbr1to51A | BuySplitNbr1to52A | BuySplitNbr1to53A | BuySplitNbr1to54A | BuySplitNbr1to55A | BuySplitUnits1to51A | BuySplitUnits1to52A | BuySplitUnits1to53A | BuySplitUnits1to54A | BuySplitUnits1to55A | Action | LocateArgument | CertificateLine1    | CertificateLine2                         | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | DTNSC   | 42327       | 550        | ORD       | W152441    | C0000465930  | VIC     |            | W152441   |           |           |           |           | 550        |            |            |            |            | VIC    |           | C0000465919   |              | 300           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |             |               | 250        | S                 |                    |                  | Forward Test 1    | Forward Test 2    | Forward Test 3    |                   |                   | 2                 | 2                 | 1                 |                   |                   | 75                  | 25                  | 50                  |                     |                     | C      | /ORD           | ORD/ORDINARY SHARES | *VIC  W152493     14/06/16           300 |                  |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@29845
@OL_STD_StandardTransactions
Scenario Outline: Test Case 29845  DTNSC- CERT DECD Transmission
###Test Case 29845: 02 - OLSCRT | DTNSC- CERT DECD Transmission - Deceased Estates multiple certificate transfer ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following values:
		| TransferUnits   |
		| <TransferUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | Action | LocateArgument | CertificateLine1    | CertificateLine2                         | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | DTNSC   | 42328       | 750        | ORD       |            | C0000465920  | VIC     |            | W152434   | W152440   |           |           |           | 350        | 400        |            |            |            | VIC    |           | C0000465929   |              |               | C      | /ORD           | ORD/ORDINARY SHARES | *VIC  W152494     14/06/16           750 |                  |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@30403
@OL_STD_StandardTransactions
Scenario Outline: TestCase 30403 RIBAL REISSUE BALANCE Transaction
###Test Case 30403: 01 - OLSCRT | RIBAL - RE-ISSUE BALANCE Transaction - Reissue single new certificate with shares on a certificate ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following values:
		| TransferUnits   |
		| <TransferUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"
	
	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 |
	| Test1 | RIBAL   | 42329       | 2890       | ORD       |            | C0000465934  | VIC     |            | W152453   |           |           |           |           | 2890       |            |            |            |            |        |           |               | 99996        |               | H      | /ORD           | *ORD/ORDINARY SHARES         VIC          2890                      2890 |       |       |       |

@winformsTest
@OL_Online
@ANZ_AUTO
@30405
@OL_STD_StandardTransactions
Scenario Outline: TestCase 30405 RIBAL REISSUE BALANCE Transaction
###Test Case 30405: 02 - OLSCRT | RIBAL - RE-ISSUE BALANCE Transaction - Reissue multiple new certificate with shares on multiple certificates ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 |
	| Test1 | RIBAL   | 42330       | 4200       | ORD       |            | C0000465935  | VIC     |            | W152454   | W152455   | W152456   |           |           | 1000       | 1200       | 2000       |            |            |        |           |               | 88885        |               |              |           |                  |                  |                  |                  |                  | 1                | 1                | 1000               | 1200               |             |               |            |                   | 2000               | 1                | H      | /ORD           | *ORD/ORDINARY SHARES         VIC          4200                      4200 |       |       |       |


@winformsTest
@OL_Online
@ANZ_AUTO
@29867
@OL_STD_StandardTransactions
Scenario Outline: TestCase 29867 SPLIT CERTIFICATE  Transaction
###Test Case 29867: 01 - OLSCRT | SPLIT - SPLIT CERTIFICATE  Transaction - Split all the shares on multiple certificates ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTSP I continue with the following details:
		| BuySplitNumber1   | BuySplitNumber2   | BuySplitNumber3   | BuySplitNumber4   | BuySplitNumber5   | BuySplitNumber6   | BuySplitUnits1   | BuySplitUnits2   | BuySplitUnits3   | BuySplitUnits4   | BuySplitUnits5   | BuySplitUnits6   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   |
		| <BuySplitNumber1> | <BuySplitNumber2> | <BuySplitNumber3> | <BuySplitNumber4> | <BuySplitNumber5> | <BuySplitNumber6> | <BuySplitUnits1> | <BuySplitUnits2> | <BuySplitUnits3> | <BuySplitUnits4> | <BuySplitUnits5> | <BuySplitUnits6> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | BuySplitNumber1 | BuySplitNumber2 | BuySplitNumber3 | BuySplitNumber4 | BuySplitNumber5 | BuySplitNumber6 | BuySplitUnits1 | BuySplitUnits2 | BuySplitUnits3 | BuySplitUnits4 | BuySplitUnits5 | BuySplitUnits6 | BuyInstructions1              | BuyInstructions2 | BuyInstructions3 | Action | LocateArgument | CertificateLine1    | CertificateLine2                                                                    | CertificateLine3                                                                     | CertificateLine4                                                                     | CertificateLine5                                                                     | CertificateLine6                                                                     | CertificateLine7                                                                     | CertificateLine8                                                                     | CertificateLine9                                                                     | CertificateLine10 |
	| Test1 | SPLIT   | 42331       | 3200       | ORD       |            | C0000465918  | VIC     |            | W152433   | W152442   |           |           |           | 2500       | 700        |            |            |            |        |           |               | 96963        | 1               | 2               | 2               | 3               | 5               | 1               | 1000           | 500            | 200            | 100            | 50             | 250            | Testing the Split transaction |                  |                  | C      | /ORD           | ORD/ORDINARY SHARES | VIC  W152433     11/08/15             0    VIC  W152442     11/08/15              0 | *VIC  W152495     14/06/16          1000   *VIC  W152496     14/06/16            500 | *VIC  W152497     14/06/16           500   *VIC  W152498     14/06/16            200 | *VIC  W152499     14/06/16           200   *VIC  W152500     14/06/16            100 | *VIC  W152501     14/06/16           100   *VIC  W152502     14/06/16            100 | *VIC  W152503     14/06/16            50   *VIC  W152504     14/06/16             50 | *VIC  W152505     14/06/16            50   *VIC  W152506     14/06/16             50 | *VIC  W152507     14/06/16            50   *VIC  W152508     14/06/16            250 |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@30116
@OL_STD_StandardTransactions
Scenario Outline: TestCase 30116 SPLIT CERTIFICATE  Transaction
###Test Case 30116: 02 - OLSCRT | SPLIT - SPLIT CERTIFICATE  Transaction - Split partial shares on a certificate ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And I Transmit
		And IN OLSCRTSP I continue with the following details:
		| BuySplitNumber1   | BuySplitNumber2   | BuySplitNumber3   | BuySplitNumber4   | BuySplitNumber5   | BuySplitNumber6   | BuySplitUnits1   | BuySplitUnits2   | BuySplitUnits3   | BuySplitUnits4   | BuySplitUnits5   | BuySplitUnits6   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   |
		| <BuySplitNumber1> | <BuySplitNumber2> | <BuySplitNumber3> | <BuySplitNumber4> | <BuySplitNumber5> | <BuySplitNumber6> | <BuySplitUnits1> | <BuySplitUnits2> | <BuySplitUnits3> | <BuySplitUnits4> | <BuySplitUnits5> | <BuySplitUnits6> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | BuySplitNumber1 | BuySplitNumber2 | BuySplitNumber3 | BuySplitNumber4 | BuySplitNumber5 | BuySplitNumber6 | BuySplitUnits1 | BuySplitUnits2 | BuySplitUnits3 | BuySplitUnits4 | BuySplitUnits5 | BuySplitUnits6 | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | Action | LocateArgument | CertificateLine1    | CertificateLine2                                                                    | CertificateLine3                         | CertificateLine4                             | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | SPLIT   | 42332       | 500        | ORD       |            | C0000465931  | VIC     |            | W152443   |           |           |           |           | 500        |            |            |            |            |        |           |               |              | 2               |                 |                 |                 |                 |                 | 250            |                |                |                |                |                |                  |                  |                  | C      | /ORD           | ORD/ORDINARY SHARES | VIC  W152443     11/08/15           400   *VIC  W152509     14/06/16            250 | *VIC  W152510     14/06/16           250 | **** Class Total ***                     900 |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@30569
@OL_STD_StandardTransactions
Scenario Outline: TestCase 30569 TRNSM TRANSMISSION Transaction
###Test Case 30569: 01 - OLSCRT | TRNSM - TRANSMISSION Transaction - Transmit full certificate with splits ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 |
	| Test1 | TRNSM   | 42333       | 900        | ORD       | W152466    | C0000465938  |         |            | W152466   |           |           |           |           | 900        |            |            |            |            | VIC    |           | C0000465942   |              |               |              |           | TEST1            | TEST2            | TEST3            |                  |                  | 1                | 2                | 100                | 300                |             |               |            |                   | 200                | 1                | H      | /ORD           | *ORD/ORDINARY SHARES         VIC           900                       900 |       |       |       |


@winformsTest
@OL_Online
@ANZ_AUTO
@30575
@OL_STD_StandardTransactions
Scenario Outline: TestCase 30575 RNSM TRANSMISSION Transaction
###Test Case 30575: 02 - OLSCRT | TRNSM - TRANSMISSION Transaction - Transmit particial certificate ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTWH I continue with the following details:
		| Action   |
		| <Action> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And I Transmit
		And IN OLSCRTBF I continue with the following values:
		| TransferUnits   |
		| <TransferUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action1>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | Action | Action1 | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 |
	| Test1 | TRNSM   | 42334       | 500        | ORD       |            | C0000465939  | VIC     | 59999      | W152467   |           |           |           |           | 500        |            |            |            |            | VIC    | 59999     | C0000465943   | 78878878     |               | Y      | H       | /ORD           | *ORD/ORDINARY SHARES         VIC           500                       500 |       |       |       |


@winformsTest
@OL_Online
@ANZ_AUTO
@30527
@OL_STD_StandardTransactions
Scenario Outline: TestCase 30527 TRNFR TRANSFER Transaction
###Test Case 30527: 01 - OLSCRT | TRNFR - TRANSFER Transaction- Tranfer partial certificates from one to another certificated holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellCert6   | SellCert7   | SellCert8   | SellCert9   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | SellUnits6   | SellUnits7   | SellUnits8   | SellUnits9   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellCert6> | <SellCert7> | <SellCert8> | <SellCert9> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <SellUnits6> | <SellUnits7> | <SellUnits8> | <SellUnits9> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
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
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellCert6 | SellCert7 | SellCert8 | SellCert9 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | SellUnits6 | SellUnits7 | SellUnits8 | SellUnits9 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | Action | LocateArgument | CertificateLine1                 | CertificateLine2                         | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | TRNFR   | 42335       | 400        | E12       | 20000003   | C0000465936  | VIC     |            | 20000003  |           |           |           |           |           |           |           |           | 400        |            |            |            |            |            |            |            |            | VIC    |           | C0000465940   |              | 300           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    | 100         | 659876        |            |                   |                    |                  | C      | /E12           | E12/CAPITAL NOTES 3 SH OFFER ENT | *VIC 20000004     00/00/00           300 |                  |                  |                  |                  |                  |                  |                  |                   |


@winformsTest
@OL_Online
@ANZ_AUTO
@30528
@OL_STD_StandardTransactions
Scenario Outline: Test Case 30528: 02 - OLSCRT | TRNFR - TRANSFER Transaction- Transfer full shares to another certificated holder
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellCert6   | SellCert7   | SellCert8   | SellCert9   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | SellUnits6   | SellUnits7   | SellUnits8   | SellUnits9   |BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellCert6> | <SellCert7> | <SellCert8> | <SellCert9> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <SellUnits6> | <SellUnits7> | <SellUnits8> | <SellUnits9> |<BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And I Transmit
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action1>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"


	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellCert6 | SellCert7 | SellCert8 | SellCert9 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | SellUnits6 | SellUnits7 | SellUnits8 | SellUnits9 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | Action1 | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 |
	| Test1 | TRNFR   | 8820        | 1400       | ORD       |            | C0000465937  | VIC     |            | W152457   | W152458   | W152459   | W152460   | W152461   | W152462   | W152463   | W152464   | W152465   | 200        | 200        | 100        | 100        | 100        | 100        | 100        | 250        | 250        | VIC    |           | C0000465941   |              |               |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |             |               |            |                   |                    |                  | H       | /ORD           | *ORD/ORDINARY SHARES         VIC          1400                      1400 |       |       |       |


@winformsTest
@OL_Online
@CPU_AUTO
@31904
@OL_STD_StandardTransactions
Scenario Outline: TestCase 31904 Verify Lost Scrip Replacement Transaction
##Test Case 31904: 01 - OLS027  Verify Lost Scrip Replacement Transaction (LSTSC) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS02701 I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReg   | SellBroker   | SellCertID   | SellHolderID   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReg> | <SellBroker> | <SellCertID> | <SellHolderID> |
		And In OLS02702 I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellUnits1   | SellUnits2   | SellUnits3   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellUnits1> | <SellUnits2> | <SellUnits3> |
		And In OLS02703 I continue with the following details:
		| BuyTradeReference   | BuySplitNumber1   | BuySplitNumber2   | BuySplitNumber3   | BuySplitNumber4   | BuySplitNumber5   | BuySplitUnits1   | BuySplitUnits2   | BuySplitUnits3   | BuySplitUnits4   | BuySplitUnits5   |
		| <BuyTradeReference> | <BuySplitNumber1> | <BuySplitNumber2> | <BuySplitNumber3> | <BuySplitNumber4> | <BuySplitNumber5> | <BuySplitUnits1> | <BuySplitUnits2> | <BuySplitUnits3> | <BuySplitUnits4> | <BuySplitUnits5> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
	
	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReg | SellBroker | SellCertID | SellHolderID | SellCert1 | SellCert2 | SellCert3 | SellUnits1 | SellUnits2 | SellUnits3 | BuyTradeReference | BuySplitNumber1 | BuySplitNumber2 | BuySplitNumber3 | BuySplitNumber4 | BuySplitNumber5 | BuySplitUnits1 | BuySplitUnits2 | BuySplitUnits3 | BuySplitUnits4 | BuySplitUnits5 | Action | LocateArgument | CertificateLine1               | CertificateLine2                                                                    | CertificateLine3                                                                    | CertificateLine4                                                                    | CertificateLine5                                                                    | CertificateLine6                                                                      | CertificateLine7                         | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | LSTSC   | 42336       | 100        | FP        | VIC     |            |            | C0000001701  | 431       |           |           | 100        |            |            |                   | 1               |                 |                 |                 |                 | 100            |                |                |                |                | C      | /FP            | FP /ORDINARY FULLY PAID SHARES | VIC 00000427     08/07/15           100 8  VIC 00000428     08/07/15            100 | VIC 00000429     08/07/15           100    VIC 00000430     08/07/15            100 | VIC 00000431     08/07/15             0 8  VIC 00000432     08/07/15            100 | VIC 00000433     08/07/15           100    VIC 00000434     08/07/15            100 | VIC 00000435     08/07/15           100 8  VIC 00000436     08/07/15            100 8 | *VIC 00000447     22/04/15           100 |                  |                  |                   |

@winformsTest
@OL_Online
@CPU_AUTO
@32413
@OL_STD_StandardTransactions
Scenario Outline: TestCase 32413 Verify Lost Scrip Replacement Transaction
###Test Case 32413: 02 - OLS027  Verify Lost Scrip Replacement Transaction (LSTSC) > certificate is NOT lost Warning Message ####
###Test Case 32723: 06 - OLS027  Verify Lost Scrip Replacement Transaction (LSTSC) > Warning "There are 0 units remaining on this certificate" ###
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS02701 I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReg   | SellBroker   | SellCertID   | SellHolderID   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReg> | <SellBroker> | <SellCertID> | <SellHolderID> |
		And In OLS02702 I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellUnits1   | SellUnits2   | SellUnits3   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellUnits1> | <SellUnits2> | <SellUnits3> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReg | SellBroker | SellCertID | SellHolderID | SellCert1 | SellCert2 | SellCert3 | SellUnits1 | SellUnits2 | SellUnits3 | ErrorMessage                                                    |
	| Test1 | LSTSC   | 42337       | 100        | FP        | VIC     |            | 432        |              | 432       |           |           | 100        |            |            | This certificate is NOT lost - cannot be replaced.              |
	| Test2 | LSTSC   | 42337       | 100        | FP        | VIC     |            |            | C0000001701  | 431       |           |           | 100        |            |            | There are                0 units remaining on this certificate. |

