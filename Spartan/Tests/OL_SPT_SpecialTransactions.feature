Feature: OL_SPT_SpecialTransactions
	Ensure OL_SPT_SpecialTransactions Transaction functionality covered

@winformsTest
@OL_Online
@CPU_AUTO
@30250
@OL_SPT_SpecialTransactions
Scenario Outline: Verify Certificate Indicator Settings Transaction Update
###Test Case 30250: 01 - OLS036  Verify Certificate Indicator Settings Transaction Update (CTIND) ####
###Test Case 30373: 02 - OLS036  Verify Certificate Indicator Settings Transaction Update (CTIND) - Certificate Search ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03601 I continue with the following details:
		| TranNumber   | SellClass   | SellReg   | SellBroker   | SellCertID   | SellHolderID   | TransDate   |
		| <TranNumber> | <SellClass> | <SellReg> | <SellBroker> | <SellCertID> | <SellHolderID> | <TransDate> |
		And In OLS03602 I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellInd   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellInd> |
		And I Transmit
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SellHolderID1>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
	

	Examples:
	| Test  | SelCode | TranNumber | SellClass | SellReg | SellBroker | SellCertID | SellHolderID | TransDate | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellInd | Action | LocateArgument | CertificateLine1               | CertificateLine2                                                                    | CertificateLine3                                                                    | CertificateLine4                                                                    | CertificateLine5                                                                    | CertificateLine6                                                                      | CertificateLine7                                                                    | CertificateLine8                             | CertificateLine9 | CertificateLine10 | SellHolderID1 |
	| Test1 | CTIND   | 42339      | FP        | VIC     |            |            | C0000001701  | 22/04/15  | 00000427  | 00000436  |           |           |           | 8       | C      | /FP            | FP /ORDINARY FULLY PAID SHARES | VIC 00000427     08/07/15           100 8  VIC 00000428     08/07/15            100 | VIC 00000429     08/07/15           100    VIC 00000430     08/07/15            100 | VIC 00000431     08/07/15           100 8  VIC 00000432     08/07/15            100 | VIC 00000433     08/07/15           100    VIC 00000434     08/07/15            100 | VIC 00000435     08/07/15           100 8  VIC 00000436     08/07/15            100 8 | **** Class Total ***                    1000                                        |                                              |                  |                   | C0000001701   |
 #   | Test2   | CTIND      | 42340     | FP      | VIC        |            | 00000434     |           | 22/04/15  | 00000434  |           |           |           |         | 9      | C              | /FP                            | FP /ORDINARY FULLY PAID SHARES                                                      | VIC 00000427     08/07/15           100    VIC 00000428     08/07/15            100 | VIC 00000429     08/07/15           100    VIC 00000430     08/07/15            100 | VIC 00000431     08/07/15           100 8  VIC 00000432     08/07/15            100 | VIC 00000433     08/07/15           100    VIC 00000434     08/07/15            100 9 | VIC 00000435     08/07/15           100 8  VIC 00000436     08/07/15            100 | **** Class Total ***                    1000 |                  |                   |               | C0000001701 |

@winformsTest
@OL_Online	
@CPU_AUTO
@30369
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30369 Verify CTIND Warning Messages for Certifcated Holders
###Test Case 30369: 04 - OLS036  Verify CTIND Warning Messages for Certifcated Holders ####
###Test Case 30359: 05 - OLS036  Verify CTIND Warning Messages for unCertifcated Holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03601 I continue with the following details:
		| TranNumber   | SellClass   | SellReg   | SellBroker   | SellCertID   | SellHolderID   | TransDate   |
		| <TranNumber> | <SellClass> | <SellReg> | <SellBroker> | <SellCertID> | <SellHolderID> | <TransDate> |
		And In OLS03602 I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellInd      |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellInd> |
	Then I should see the below ErrorMessage "<ErrorMessage>"


	Examples:
	| Test  | SelCode | TranNumber | SellClass | SellReg | SellBroker | SellCertID | SellHolderID | TransDate | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellInd | ErrorMessage                                      |
	| Test1 | CTIND   | 42341      | FP        | VIC     |            | 00000428   |              |           | 00000428  |           |           |           |           | 7       | Indicator 7 reserved for system use only (FASTER) |
	| Test2 | CTIND   | 42341      | FP        | VIC     |            | 00000433   |              |           | 00000433  |           |           |           |           | 1       | Flag code not on file                             |


@winformsTest
@OL_Online
@CPU_AUTO
@30359
@OL_SPT_SpecialTransactions
@FullSmokeTest
Scenario Outline: Test Case 30359 Verify CTIND Warning Messages for UnCertifcated Holders
###Test Case 30359: 05 - OLS036  Verify CTIND Warning Messages for unCertifcated Holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03601 I continue with the following details:
		| TranNumber   | SellClass   | SellReg   | SellBroker   | SellCertID   | SellHolderID   | TransDate   |
		| <TranNumber> | <SellClass> | <SellReg> | <SellBroker> | <SellCertID> | <SellHolderID> | <TransDate> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

		
	Examples:
	| Test  | SelCode | TranNumber | SellClass | SellReg | SellBroker | SellCertID | SellHolderID | TransDate | ErrorMessage                                    |
	| Test3 | CTIND   | 42342      | FP        | VIC     |            |            | I0030047974  |           | For an uncertificated holder, the class must be |

@winformsTest
@OL_Online
@CPU_AUTO
@30358
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30358 Verify CTIND Warning Messages for ESS Holders
###Test Case 30358: 06 - OLS036  Verify CTIND Warning Messages for ESS Certifcated Holders ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03601 I continue with the following details:
		| TranNumber   | SellClass   | SellReg   | SellBroker   | SellCertID   | SellHolderID   | TransDate   |
		| <TranNumber> | <SellClass> | <SellReg> | <SellBroker> | <SellCertID> | <SellHolderID> | <TransDate> |
		And In OLS03602 I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellInd      |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellInd> |
	Then I should see the below ErrorMessage "<ErrorMessage>"


	Examples:
	| Test  | SelCode | TranNumber | SellClass | SellReg | SellBroker | SellCertID | SellHolderID | TransDate | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellInd | ErrorMessage                                      |
	| Test1 | CTIND   | 42343      | DLA       | 12A     |            |            | I0030177436  |           |           |           |           |           |           | 8       | This certificate is NOT on file for nominated     |
	| Test2 | CTIND   | 42343      | DLA       | 12A     |            |            | I0030177436  |           |           |           |           |           |           | 1       | Flag code not on file                             |
	| Test3 | CTIND   | 42343      | DLA       | 12A     |            |            | I0030177436  |           |           |           |           |           |           | 7       | Indicator 7 reserved for system use only (FASTER) |

@winformsTest
@OL_Online
@ANZ_AUTO
@30908
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30908 ADJIN and ADJST Transactions Certificated Holder
###Test Case 30908: 01 - OLSCRT | ADJIN and ADJST Transactions - Process ADJIN transaction for Certificated Holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLSCRTBA I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyClass   | BuyBroker   | BuySearchName   | BuyReference   | BuyTransDate   | BuySbn   | BuyReg   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyClass> | <BuyBroker> | <BuySearchName> | <BuyReference> | <BuyTransDate> | <BuySbn> | <BuyReg> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits    | BuyTransDate    | BuyCertID    | BuyInstructions1    | BuyInstructions2    | BuyInstructions3    | BuyInstructions4    | BuyInstructions5    |
		| <TransferUnitsA> | <BuyTransDateA> | <BuyCertIDA> | <BuyInstructions1A> | <BuyInstructions2A> | <BuyInstructions3A> | <BuyInstructions4A> | <BuyInstructions5A> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

	Examples:
	| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyClass | BuyBroker | BuySearchName | BuyReference | BuyTransDate | BuySbn | BuyReg | TransferUnitsA | BuyTransDateA | BuyCertIDA | BuyInstructions1A | BuyInstructions2A | BuyInstructions3A | BuyInstructions4A | BuyInstructions5A | Action | LocateArgument | CertificateLine1    | CertificateLine2                                                                     | CertificateLine3                        | CertificateLine4                             | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | ADJIN   | 42344       |           | 780        | ORD      | 59999     | C0000465944   | 88996        | 11/08/2015   |        | VIC    | 780            |               | J98878     |                   |                   |                   |                   |                   | C      | /ORD           | ORD/ORDINARY SHARES | *VIC  J098878     11/08/15           780    VIC  W152468     11/08/15            850 | VIC  W152469     11/08/15           665 | **** Class Total ***                    2295 |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@30909
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30909 ADJIN and ADJST Transactions Uncertificated Holder
###Test Case 30909: 02 - OLSCRT | ADJIN and ADJST Transactions - Process ADJIN transaction for Uncertificated Holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLSCRTBA I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyClass   | BuyBroker   | BuySearchName   | BuyReference   | BuyTransDate   | BuySbn   | BuyReg   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyClass> | <BuyBroker> | <BuySearchName> | <BuyReference> | <BuyTransDate> | <BuySbn> | <BuyReg> |
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
	| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyClass | BuyBroker | BuySearchName | BuyReference | BuyTransDate | BuySbn | BuyReg | ConfirmUnits | Action | LocateArgument | CertificateLine1    | CertificateLine2                                                                    | CertificateLine3                                                                    | CertificateLine4                             | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | ADJIN   | 42345       |           | 556        | ORD      | 59999     | I0011980376   | 7878         | 11/08/2015   | 59999  |        | 556          | C      | /ORD           | ORD/ORDINARY SHARES | VIC UNCERTIF'D   07/12/00          1500    VIC UNCERTIF'D   28/11/03            273 | VIC UNCERTIF'D   13/07/09          1042    VIC UNCERTIF'D   11/08/15           1545 | **** Total for UNCERTIF'D               4360 |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@31045
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 31045 ADJIN and ADJST Transactions
###Test Case 31045: 03 - OLSCRT | ADJIN and ADJST Transactions - Transfer shares between different class for the same uncertificated holder using ADJST transaction ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
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
		| TransferUnits    | BuyTransDate    | BuyCertID    | BuyInstructions1    | BuyInstructions2    | BuyInstructions3    | BuyInstructions4    | BuyInstructions5    | UncertBuyReg   |
		| <TransferUnitsA> | <BuyTransDateA> | <BuyCertIDA> | <BuyInstructions1A> | <BuyInstructions2A> | <BuyInstructions3A> | <BuyInstructions4A> | <BuyInstructions5A> | <UncertBuyReg> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellSearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | BuyClass | BuyBroker | BuySbn | BuyReg | BuyReference | BuySearchName | TransferUnitsA | BuyTransDateA | BuyCertIDA | BuyInstructions1A | BuyInstructions2A | BuyInstructions3A | BuyInstructions4A | BuyInstructions5A | UncertBuyReg | Action | LocateArgument | CertificateLine1                  | CertificateLine2                        | CertificateLine3                             | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | SellCert1 | SellUnits1 | SellDate1 | SellCert2 | SellUnits2 | SellDate2 | SellCert3 | SellUnits3 | SellDate3 |
	| Test1 | ADJST   | 42346       | 100        | ORD       | 889965        | 59999      |           | 59999   | I0011980376    |            |              |         | O58      | 59999     | 59999  |        |              | I0011980376   | 100            | 11/08/2015    |            |                   |                   |                   |                   |                   | VIC          | C      | /O58           | O58/*OPT $17.60 20/05/06-19/05/10 | VIC UNCERTIF'D   11/08/15           100 | **** Total for UNCERTIF'D                100 |                  |                  |                  |                  |                  |                  |                   |           |            |           |           |            |           |           |            |           |

@winformsTest
@OL_Online
@ANZ_AUTO
@31046
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 31046 ADJIN and ADJST Transactions
###Test Case 31046: 04 - OLSCRT | ADJIN and ADJST Transactions - Transfer shares between different class for the same certificated holder using ADJST transaction ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSA I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReference   | SellBroker   | TransDate   | SellSbn   | SellSearchName   | SellCertID   | SellHolderID   | SellReg   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReference> | <SellBroker> | <TransDate> | <SellSbn> | <SellSearchName> | <SellCertID> | <SellHolderID> | <SellReg> |
		And IN OLSCRTTA I continue with the following details:
		| BuyClass   | BuyBroker   | BuySbn   | BuyReg   | BuyReference   | BuySearchName   | SellCert1   | SellUnits1   | SellDate1   | SellCert2   | SellUnits2   | SellDate2   | SellCert3   | SellUnits3   | SellDate3   |
		| <BuyClass> | <BuyBroker> | <BuySbn> | <BuyReg> | <BuyReference> | <BuySearchName> | <SellCert1> | <SellUnits1> | <SellDate1> | <SellCert2> | <SellUnits2> | <SellDate2> | <SellCert3> | <SellUnits3> | <SellDate3> |
		And I Transmit
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits    | BuyTransDate    | BuyCertID    | BuyInstructions1    | BuyInstructions2    | BuyInstructions3    | BuyInstructions4    | BuyInstructions5    |
		| <TransferUnitsA> | <BuyTransDateA> | <BuyCertIDA> | <BuyInstructions1A> | <BuyInstructions2A> | <BuyInstructions3A> | <BuyInstructions4A> | <BuyInstructions5A> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | BuyClass | BuyBroker | BuySbn | BuyReg | BuyReference | BuySearchName | SellCert1 | SellUnits1 | SellDate1  | TransferUnitsA | BuyTransDateA | BuyCertIDA | BuyInstructions1A | BuyInstructions2A | BuyInstructions3A | BuyInstructions4A | BuyInstructions5A | Action | LocateArgument | CertificateLine1    | CertificateLine2                        | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | SellCert2 | SellUnits2 | SellDate2 | SellCert3 | SellUnits3 | SellDate3 |
	| Test1 | ADJST   | 42347       | 120        | ORD       |               |            |           |         |                |            | C0000465947  | VIC     | E12      |           |        | VIC    |              | C0000465947   | W152471   | 120        | 11/08/2015 |                | 11/08/2015    | W152471    |                   |                   |                   |                   |                   | C      | /ORD           | ORD/ORDINARY SHARES | VIC  W152471     11/08/15           530 |                  |                  |                  |                  |                  |                  |                  |                   |           |            |           |           |            |           |

@winformsTest
@OL_Online
@ANZ_AUTO
@31231
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 31231 ADJIN and ADJST Transactions
###Test Case 31231: 05 - OLSCRT | ADJIN and ADJST Transactions - Transfer shares in same class from uncertificated to certificated holder using ADJST transaction ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
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
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellSearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | BuyClass | BuyBroker | BuySbn | BuyReg | BuyReference | BuySearchName | SellCert1 | SellUnits1 | SellDate1 | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | Action | LocateArgument | CertificateLine1    | CertificateLine2                                                                    | CertificateLine3                         | CertificateLine4                             | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | SellCert2 | SellUnits2 | SellDate2 | SellCert3 | SellUnits3 | SellDate3 |
	| Test1 | ADJST   | 42348       | 350        | ORD       |               | 59999      |           | 59999   | I0012747055    |            |              |         | ORD      |           |        | VIC    |              | C0000465945   |           |            |           | 350           | 11/08/2015   | U78954    |                  |                  |                  |                  |                  | C      | /ORD           | ORD/ORDINARY SHARES | VIC UNCERTIF'D   15/02/07          1182    VIC UNCERTIF'D   13/07/09           1042 | VIC UNCERTIF'D   14/06/16           350- | **** Total for UNCERTIF'D               1874 |                  |                  |                  |                  |                  |                   |           |            |           |           |            |           |

@winformsTest
@OL_Online
@ANZ_AUTO
@31232
@OL_SPT_SpecialTransactions
@FullSmokeTest
Scenario Outline: Test Case 31232 ADJIN and ADJST Transactions
###Test Case 31232: 06 - OLSCRT | ADJIN and ADJST Transactions - Transfer shares in different class from certificated to uncertificated holder using ADJST transaction ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSA I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReference   | SellBroker   | TransDate   | SellSbn   | SellSearchName   | SellCertID   | SellHolderID   | SellReg   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReference> | <SellBroker> | <TransDate> | <SellSbn> | <SellSearchName> | <SellCertID> | <SellHolderID> | <SellReg> |
		And IN OLSCRTTA I continue with the following details:
		| BuyClass   | BuyBroker   | BuySbn   | BuyReg   | BuyReference   | BuySearchName   | SellCert1   | SellUnits1   | SellDate1   | SellCert2   | SellUnits2   | SellDate2   | SellCert3   | SellUnits3   | SellDate3   |
		| <BuyClass> | <BuyBroker> | <BuySbn> | <BuyReg> | <BuyReference> | <BuySearchName> | <SellCert1> | <SellUnits1> | <SellDate1> | <SellCert2> | <SellUnits2> | <SellDate2> | <SellCert3> | <SellUnits3> | <SellDate3> |
		And IN OLSCRTBF I continue with the following values:
		| TransferUnits   |
		| <TransferUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"		

	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | BuyClass | BuyBroker | BuySbn | BuyReg | BuyReference | BuySearchName | SellCert1 | SellUnits1 | SellDate1  | SellCert2 | SellUnits2 | SellDate2  | SellCert3 | SellUnits3 | SellDate3  | TransferUnits | Action | LocateArgument | Line1                                                                   | Line2 | Line3 | Line4 |
	| Test1 | ADJST   | 73349       | 1185       | ORD       | 7474          |            |           |         |                | W152470    |              | VIC     | ORD      |           | 59999  |        |              | I0011980376   | W152470   | 885        | 11/08/2015 | W152472   | 150        | 11/08/2015 | W152473   | 150        | 11/08/2015 |               | H      | /ORD           | *ORD/ORDINARY SHARES         VIC          4989                      4989|       |       |       |
@winformsTest
@OL_Online
@ANZ_AUTO
@31235
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 31235 ADJIN and ADJST Transactions Error validations
###Test Case 31235: 07 -  OLSCRT | ADJIN and ADJST Transactions -Error validations for OLSCRTSA ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSA I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReference   | SellBroker   | TransDate   | SellSbn   | SellSearchName   | SellCertID   | SellHolderID   | SellReg   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReference> | <SellBroker> | <TransDate> | <SellSbn> | <SellSearchName> | <SellCertID> | <SellHolderID> | <SellReg> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | ErrorMessage                                              |
	| Test1 | ADJST   | 42350       | 100        | AAA       |               |            |           |         |                |            |              |         | Company class not on file                                 |
	| Test2 | ADJST   | 42350       | 100        | ORD       |               |            |           | 00001   | I0011980376    |            |              |         | This Broker Is Not Compatible With This HINs Type         |
	| Test3 | ADJST   | 42350       | 100        | ORD       |               |            |           | 98998   | I0011980376    |            |              |         | 98998 Broker code not on SRCCDE file                      |
	| Test4 | ADJST   | 42350       | 100        | ORD       |               |            |           |         |                | W11112     |              |         | There are NO certificates which start with  W011112       |
	| Test5 | ADJST   | 42350       | 100        | ORD       |               |            |           | 59999   | I0011980376    |            | I0011980376  | VIC     | Cannot enter both Certificated AND Uncertificated details |
	| Test6 | ADJST   | 42350       | 100        | ORD       |               |            |           |         |                |            |              |AAA      | Register code not on file                                 |

@winformsTest
@OL_Online
@ANZ_AUTO
@31235
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30147 CAPIN and CAPDN Transactions
###Test Case 30147: 01 - OLSCRT | CAPIN and CAPDN Transactions - Process CAPIN Transaction for Certificate Holders with Units for Class Types : W, S, U ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLSCRTBA I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyClass   | BuyBroker   | BuySearchName   | BuyReference   | BuyTransDate   | BuySbn   | BuyReg   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyClass> | <BuyBroker> | <BuySearchName> | <BuyReference> | <BuyTransDate> | <BuySbn> | <BuyReg> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate1> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <BuySearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01013 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

	Examples:
	| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyClass | BuyBroker | BuySearchName | BuyReference | BuyTransDate | BuySbn | BuyReg | TransferUnits | BuyTransDate1 | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | Action | LocateArgument | CertificateLine1                  | CertificateLine2                                                                           | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | CAPIN   | 42351       |           | 100        | DIR      | 59999     | C0000020922   | TEST01       | 04/09/2015   |        | WA     | 100           |               |           | SPLIT1           |                  |                  |                  |                  | 01               |                  | 100                |                    |             |               |            |                   |                    |                  | R      | /DIR           | DIR/DIRECTORS EXCLUSIONS 2014 AGM | *WA  00000045     04/09/15 CAPIN 6124/   42351            100                       WINFRM |                  |                  |                  |                  |                  |                  |                  |                   |
	| Test2 | CAPIN   | 42352       |           | 250        | FP       | 59999     | C0000020923   | TEST02       | 08/04/2016   |        | WA     | 250           |               |           | SPLIT2           |                  |                  |                  |                  | 01               |                  | 250                |                    |             |               |            |                   |                    |                  | R      | /FP            | FP /ORDINARY FULLY PAID SHARES    | *WA  00193511     08/04/16 CAPIN 6124/   42352            250                       WINFRM |                  |                  |                  |                  |                  |                  |                  |                   |
	| Test3 | CAPIN   | 42353       |           | 150        | DFP      | 59999     | C0000020924   | TEST03       | 08/04/2016   |        | WA     | 150           |               |           | SPLIT3           |                  |                  |                  |                  | 01               |                  | 150                |                    |             |               |            |                   |                    |                  | R      | /DFP           | DFP/DUMMY FOR SALE TEST           | *WA  00000002     08/04/16 CAPIN 6124/   42353            150                       WINFRM |                  |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@30304
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30304 CAPIN and CAPDN Transactions
###Test Case 30304: 02 - OLSCRT | CAPIN and CAPDN Transactions - Not able to Process CAPIN Transaction for Certificated Holders with Units for Class Type E ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLSCRTBA I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyClass   | BuyBroker   | BuySearchName   | BuyReference   | BuyTransDate   | BuySbn   | BuyReg   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyClass> | <BuyBroker> | <BuySearchName> | <BuyReference> | <BuyTransDate> | <BuySbn> | <BuyReg> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples:
	| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyClass | BuyBroker | BuySearchName | BuyReference | BuyTransDate | BuySbn | BuyReg | ErrorMessage                                                                                                                                               |
	| Test1 | CAPIN   | 42354       |           | 200        | CLI      | 59999     | C0000020925   | TEST02       | 07/09/2001   |        | WA     | The error message: "Non ESS transactions cannot be processed on ESS classes" which was intended for form "ONLSCH02" has removed all forms from your screen |

@winformsTest
@OL_Online
@ANZ_AUTO
@30428
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30428 CAPIN and CAPDN Transactions
###Test Case 30428: 04 - OLSCRT | CAPIN and CAPDN Transactions - Not able to Process CAPIN Transaction for Uncertificated Holders ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLSCRTBA I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyClass   | BuyBroker   | BuySearchName   | BuyReference   | BuyTransDate   | BuySbn   | BuyReg   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyClass> | <BuyBroker> | <BuySearchName> | <BuyReference> | <BuyTransDate> | <BuySbn> | <BuyReg> |
		And In ONLSCH02 I continue with the following details:
		| Action   |
		| <Action> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples:
	| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyClass | BuyBroker | BuySearchName | BuyReference | BuyTransDate | BuySbn | BuyReg | ErrorMessage                   | Action |
	| Test1 | CAPIN   | 42355       |           | 100        | DIR      | 59999     | I0030008944   | TEST01       | 08/04/2016   |        | WA     | Cannot select "I" type holders | U      |
	| Test2 | CAPIN   | 42355       |           | 100        | DIR      | 59999     | L0333316684   | TEST01       | 08/04/2016   |        | WA     | Cannot select "L" type holders | U      |
	| Test3 | CAPIN   | 42355       |           | 100        | DIR      | 59999     | N0060000000   | TEST01       | 08/04/2016   |        | WA     | Cannot select "N" type holders | U      |

@winformsTest
@OL_Online
@ANZ_AUTO
@30432
@OL_SPT_SpecialTransactions
Scenario Outline: Test Case 30432 CAPIN and CAPDN Transactions
###Test Case 30432: 05 - OLSCRT | CAPIN and CAPDN Transactions - Process CAPDN Transaction for Certificate Holders with Units for Class Types : W, S, U ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSA I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReference   | SellBroker   | TransDate   | SellSbn   | SellSearchName   | SellCertID   | SellHolderID   | SellReg   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReference> | <SellBroker> | <TransDate> | <SellSbn> | <SellSearchName> | <SellCertID> | <SellHolderID> | <SellReg> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> |
		And I Transmit
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SellSearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01013 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | Action | LocateArgument | CertificateLine1                  | CertificateLine2                                                                          | CertificateLine3                                                                           | CertificateLine4                   | CertificateLine5                   | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | CAPDN   | 42356       | 100        | DIR       | CAPDN1        | 59999      |           |         | C0000020928    | 00000039   |              | WA      | 00000039  |           |           |           |           | 100        |            |            |            |            | R      | /DIR           | DIR/DIRECTORS EXCLUSIONS 2014 AGM | WA  00000039     23/06/15 CAPIN 6112/ 3523423            540                       WINFRM | *                 08/04/16 CAPDN 6124/   42356            100-                      WINFRM | *Certificate Balance           440 | **** Class Total ***           440 |                  |                  |                  |                  |                   |
	| Test2 | CAPDN   | 42357       | 200        | FP        | CAPDN2        | 59999      |           |         | C0000020931    | 00193509   |              | WA      | 00193509  |           |           |           |           | 200        |            |            |            |            | R      | /FP            | FP /ORDINARY FULLY PAID SHARES    | WA  00193509     23/06/15 CAPIN 6113/ 3242342            240                       WINFRM | *                 08/04/16 CAPDN 6124/   42357            200-                      WINFRM | *Certificate Balance            40 | **** Class Total ***            40 |                  |                  |                  |                  |                   |
	| Test3 | CAPDN   | 42358       | 120        | DFP       | CAPDN3        | 59999      |           |         | C0000020931    | 00000001   |              | WA      | 00000001  |           |           |           |           | 120        |            |            |            |            | R      | /DFP           | DFP/DUMMY FOR SALE TEST           | WA  00000001     07/09/15 CAPIN 6113/ 3242343            150                       WINFRM | *                 08/04/16 CAPDN 6124/   42358            120-                      WINFRM | *Certificate Balance            30 | **** Class Total ***            30 |                  |                  |                  |                  |                   |
	| Test4 | CAPDN   | 42359       | 150        | PAY       | CAPDN4        | 59999      |           |         | C0000020928    | 10000004   |              | WA      | 10000004  |           |           |           |           | 150        |            |            |            |            | R      | /PAY           | PAY/CLTIP DIV PAYMENT CLASS       | WA  10000004     07/09/15 CAPIN 6112/ 3523424            220                       WINFRM | *                 08/04/16 CAPDN 6124/   42359            150-                      WINFRM | *Certificate Balance            70 | **** Class Total ***            70 |                  |                  |                  |                  |                   |
	
@winformsTest
@OL_Online	
@WES_AUTO
@30433
@OL_SPT_SpecialTransactions
Scenario Outline: TestCase30433 CAPIN and CAPDN Transactions
###Test Case 30433: 06 - OLSCRT | CAPIN and CAPDN Transactions - Process CAPDN Transaction for Uncertificated Holders with Units for Class Types : S, U ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "special transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSA I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellReference   | SellBroker   | TransDate   | SellSbn   | SellSearchName   | SellCertID   | SellHolderID   | SellReg   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellReference> | <SellBroker> | <TransDate> | <SellSbn> | <SellSearchName> | <SellCertID> | <SellHolderID> | <SellReg> |	 
		And IN OLSCRTUX I continue with the following details:
		| ConfirmUnits   |
		| <ConfirmUnits> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SellSearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples:
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellReference | SellBroker | TransDate | SellSbn | SellSearchName | SellCertID | SellHolderID | SellReg | ConfirmUnits | Action | LocateArgument | CertificateLine1                  | CertificateLine2                                                                     | CertificateLine3                                                                    | CertificateLine4                                                                    | CertificateLine5                                                                     | CertificateLine6                                                                    | CertificateLine7                                                                    | CertificateLine8                                                                    | CertificateLine9                         | CertificateLine10                            |
	| Test1 | CAPDN   | 42360       | 500        | FP        | CAPDN1        | 59999      |           | 59999   | I0134383933    |            |              |         | 500          | C      | /FP            | FP /ORDINARY FULLY PAID SHARES    | WA  UNCERTIF'D   23/11/07          1669    WA  UNCERTIF'D   31/03/08             59  | WA  UNCERTIF'D   02/06/08           425    WA  UNCERTIF'D   06/10/08            169 | WA  UNCERTIF'D   30/03/12            96    WA  UNCERTIF'D   28/09/12            112 | WA  UNCERTIF'D   28/03/13            77    WA  UNCERTIF'D   27/09/13            107  | WA  UNCERTIF'D   18/11/13            33-   WA  UNCERTIF'D   09/12/13           1649 | WA  UNCERTIF'D   02/04/14            87    WA  UNCERTIF'D   09/10/14            117 | WA  UNCERTIF'D   01/12/14            78-   WA  UNCERTIF'D   16/12/14             27 | WA  UNCERTIF'D   08/04/16           500- | **** Total for UNCERTIF'D               3983 |
	| Test2 | CAPDN   | 42361       | 200        | CGJ       | CAPDN2        | 59999      |           | 59999   | I8600109937    |            |              |         | 200          | C      | /CGJ           | CGJ/CGJ SHARES HELD HISTORY CLASS | WA  UNCERTIF'D   21/11/07         20156    WA  UNCERTIF'D   08/04/16            200- | **** Total for UNCERTIF'D              19956                                        |                                                                                     |                                                                                      |                                                                                     |                                                                                     |                                                                                     |                                          |                                              |
	| Test3 | CAPDN   | 42362       | 870        | FP        | CAPDN3        | 59999      |           | 59999   | I8600109937    |            |              |         | 870          | C      | /FP            | FP /ORDINARY FULLY PAID SHARES    | WA  UNCERTIF'D   15/08/01           880    WA  UNCERTIF'D   23/11/07           3397  | WA  UNCERTIF'D   02/06/08           894    WA  UNCERTIF'D   03/03/09            500 | WA  UNCERTIF'D   18/11/13            70-   WA  UNCERTIF'D   09/12/13           2830 | WA  UNCERTIF'D   01/12/14           145-   WA  UNCERTIF'D   08/04/16            870- | **** Total for UNCERTIF'D               7416                                        |                                                                                     |                                                                                     |                                          |                                              |



	                       







