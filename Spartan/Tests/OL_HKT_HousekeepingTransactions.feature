Feature: OL_HKT_HousekeepingTransactions
	Ensure OL_HKT_HousekeepingTransactions functionality covered

@winformsTest
@OL_Online
@CPU_AUTO
@31324
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase31324_BCCHG Transaction
###Test Case 31324: 01 - OLS037 BCCHG Transaction: Verify Broker Change ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03705 I continue with the following details:
		| HolderIdentifier   | RunNumber   | TransferNumber   | BuyORSell   | OldBrokerCode   | NewBrokerCode   |
		| <HolderIdentifier> | <RunNumber> | <TransferNumber> | <BuyORSell> | <OldBrokerCode> | <NewBrokerCode> |
		And In OLS03706 I verify the following details:
		| ClassCode   | RegisterCode   | TransferNumber   | CBrokerCode   | NBrokerCode   |
		| <ClassCode> | <RegisterCode> | <TransferNumber> | <CBrokerCode> | <NBrokerCode> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <HolderIdentifier>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
		And I enter the following details as the Locate action "<Action1>" "<LocateArgument>"
		And In ENS01053 I verify the following details:
		| ExtraCertDetails1   | ExtraCertDetails2   | ExtraCertDetails3   | ExtraCertDetails4   | ExtraCertDetails5   |
		| <ExtraCertDetails1> | <ExtraCertDetails2> | <ExtraCertDetails3> | <ExtraCertDetails4> | <ExtraCertDetails5> |
	Examples: 
		| Test  | SelCode | HolderIdentifier | RunNumber | TransferNumber | BuyORSell | OldBrokerCode | NewBrokerCode | ClassCode | RegisterCode | CBrokerCode | NBrokerCode | Action | LocateArgument | Action1 | ExtraCertDetails1 | ExtraCertDetails2     | ExtraCertDetails3     | ExtraCertDetails4 | ExtraCertDetails5 |
		| Test1 | BCCHG   | X0065527073      | 4388      | 12603865       | B         | 00001         | 2334          | FPD       | VIC          | 00001       | 2334        | R      | /FPD           | >       |                   | 2334                  |                       |                   |                   |

@winformsTest
@OL_Online
@CPU_AUTO
@31574
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase31574_BCCHG_ErrorValidation
###Test Case 31574: 02 - OLS037 BCCHG Transaction: Verify Broker Change Warnings ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03705 I continue with the following details:
		| HolderIdentifier   | RunNumber   | TransferNumber   | BuyORSell   | OldBrokerCode   | NewBrokerCode   |
		| <HolderIdentifier> | <RunNumber> | <TransferNumber> | <BuyORSell> | <OldBrokerCode> | <NewBrokerCode> |
	Then I should see the below ErrorMessage "<ErrorMessage>"
	
	Examples: 
		| Test  | SelCode | HolderIdentifier | RunNumber | TransferNumber | BuyORSell | OldBrokerCode | NewBrokerCode | ErrorMessage                          |
		| Test1 | BCCHG   | I0030129784      | 2367      | 111            | B         | 60109         | 59999         | No Buy trade for this run/transfer    |
		| Test2 | BCCHG   | I0030129784      | 2367      | 111            | S         | 60109         | 60109         | Current/New Broker Codes are the Same |
		| Test3 | BCCHG   | X0053284990      | 4544      | 11624109       | S         | 3383          | 1791          | No Sell trade for this run/transfer   |

@winformsTest
@OL_Online
@CPU_AUTO
@31575
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase31575_DTCHG_Transaction
###Test Case 31575: 03 - OLS037 DTCHG Transaction: Verify Date Change ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03707 I continue with the following details:
		| HolderNumber   | RunNumber   | TransferNumber   | BuyORSell   | CurTranDate   | NewTranDate   |
		| <HolderNumber> | <RunNumber> | <TransferNumber> | <BuyORSell> | <CurTranDate> | <NewTranDate> |
		And In OLS03708 I verify the following details:
		| ClassCode   | RegisterCode   | TransferNumber   | CurTranDate   | NewTranDate   |
		| <ClassCode> | <RegisterCode> | <TransferNumber> | <CurTranDate> | <NewTranDate> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01013 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

	Examples: 
		| Test  | SelCode | HolderNumber | RunNumber | TransferNumber | BuyORSell | CurTranDate | NewTranDate | ClassCode | RegisterCode | SearchName  | Action | LocateArgument | CertificateLine1                   | CertificateLine2                                                                          | CertificateLine3                                                                          | CertificateLine4                                                                          | CertificateLine5                                                                          | CertificateLine6                                                                          | CertificateLine7                                                         | CertificateLine8                   | CertificateLine9                                                                          | CertificateLine10                                                                         |
		| Test1 | DTCHG   | 65527073     | 4388      | 12603865       | B         | 18/02/14    | 19/02/14    | FPD       | VIC          | X0065527073 | R      | /FPD           | FPD/CUM ORDINARY FULLY PAID SHARES | VIC CUM BAL      19/02/14 CUMCR 4388/12603865           9200                              |                                                                                           |                                                                                           |                                                                                           |                                                                                           |                                                                          |                                    |                                                                                           |                                                                                           |
		| Test2 | DTCHG   | 30071590     | 4206      | 12391115       | S         | 19/06/13    | 20/07/14    | FP        | VIC          | I0030071590 | R      | /FP            | FP /ORDINARY FULLY PAID SHARES     | VIC UNCERTIF'D   16/01/01 RTFXI 1043/10236991            400  X0000132438                 | 20/07/14 CTFIX 4206/12391115            400- X0000694746          CHESS                   | **** Class Total ***             0                                                        |                                                                                           |                                                                                           |                                                                          |                                    |                                                                                           |                                                                                           |
		| Test3 | DTCHG   | 1701         | 4403      | 9999           | B         | 08/07/15    | 16/09/15    | FP        | VIC          | C0000001701 | R      | /FP            | FP /ORDINARY FULLY PAID SHARES     | VIC 00000427     16/09/15 CAPIN 4403/    9999            100                       WINFRM | VIC 00000428     16/09/15 CAPIN 4403/    9999            100                       WINFRM | VIC 00000429     16/09/15 CAPIN 4403/    9999            100                       WINFRM | VIC 00000430     16/09/15 CAPIN 4403/    9999            100                       WINFRM | VIC 00000431     16/09/15 CAPIN 4403/    9999            100                       WINFRM | 08/07/15 CTIND 4403/    7787              0  8/LOST Certificate   WINFRM | *Certificate Balance           100 | VIC 00000432     16/09/15 CAPIN 4403/    9999            100                       WINFRM | VIC 00000433     16/09/15 CAPIN 4403/    9999            100                       WINFRM |

@winformsTest
@OL_Online
@CPU_AUTO
@31576
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase31576_DTCHG_Transaction
###Test Case 31576: 04 - OLS037 DTCHG Transaction: Verify Date Change Warnings ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03707 I continue with the following details:
		| HolderNumber   | RunNumber   | TransferNumber   | BuyORSell   | CurTranDate   | NewTranDate   |
		| <HolderNumber> | <RunNumber> | <TransferNumber> | <BuyORSell> | <CurTranDate> | <NewTranDate> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
		| Test  | SelCode | HolderNumber | RunNumber | TransferNumber | BuyORSell | CurTranDate | NewTranDate | ErrorMessage                             |
		| Test1 | DTCHG   | 30273851     | 3196      | 11945041       | S         | 23/06/11    | 22/06/11    | No Sell trade for this run/transfer      |
		| Test2 | DTCHG   | 30273851     | 3657      | 11945041       | S         | 23/06/11    | 22/06/11    | This trade on file for Holder 0045776689 |

@winformsTest
@OL_Online
@CPU_AUTO
@31593
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase31593_RTCHG_Transaction
###Test Case 31593: 05 - OLS037 RTCHG Transaction: Verify REFERENCE/TOTR/TETR Change ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03703 I continue with the following details:
		| HolderNumber   | RunNumber   | TransferNumber   | BuyORSell   | TradeReference   | NewTradeReference   |
		| <HolderNumber> | <RunNumber> | <TransferNumber> | <BuyORSell> | <TradeReference> | <NewTradeReference> |
		And In OLS03704 I verify the following details:
		| ClassCode   | RegisterCode   | TransferNumber   | CTradeReference   | NTradeReference   |
		| <ClassCode> | <RegisterCode> | <TransferNumber> | <CTradeReference> | <NTradeReference> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <HolderIdentifier>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
		And I enter the following details as the Locate action "<Action1>" "<LocateArgument1>"
		And In ENS01053 I verify the following details:
		| ExtraCertDetails1   | ExtraCertDetails2   | ExtraCertDetails3   | ExtraCertDetails4   | ExtraCertDetails5   |
		| <ExtraCertDetails1> | <ExtraCertDetails2> | <ExtraCertDetails3> | <ExtraCertDetails4> | <ExtraCertDetails5> |

		
	Examples: 
		| Test  | SelCode | HolderNumber | RunNumber | TransferNumber | BuyORSell | TradeReference | NewTradeReference | ClassCode | RegisterCode | CTradeReference | NTradeReference | HolderIdentifier | Action | LocateArgument | Action1 | LocateArgument1 | ExtraCertDetails1 | ExtraCertDetails2                 | ExtraCertDetails3                 | ExtraCertDetails4                 | ExtraCertDetails5 |
		| Test1 | RTCHG   | 65527073     | 4388      | 12603865       | B         |                | DEP0001574        | FPD       | VIC          |                 | DEP0001574      | X0065527073      | R      | /FPD           | >       |                 |                   | DEP0001574                        |                                   |                                   |                   |
		| Test2 | RTCHG   | 30084098     | 4253      | 12469125       | S         | 008091023      | 004995029         | FP        | VIC          | 008091023       | 004995029       | I0030084098      | R      | /FP            | >       |                 |                   | X0000280011 004995029        3610 | X0000287130 007028247        4064 | X0053503641 004995029        1791 |                   |
		| Test3 | RTCHG   | 100003091    | 1422      | 100113         | S         | DPS0000796     | &@$*~`\/          | DEP       | 02A          | DPS0000796      | &@$*~`\/        | I0100003091      | R      | /DEP           | >       |                 |                   |                                   |                                   | &@$*~`\/                          |                   |

@winformsTest
@OL_Online
@CPU_AUTO
@31578
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase31578_RTCHG_ErrorValidation
###Test Case 31578: 06 - OLS037 RTCHG Transaction: Verify REFERENCE/TOTR/TETR  Warnings ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03703 I continue with the following details:
		| HolderNumber   | RunNumber   | TransferNumber   | BuyORSell   | TradeReference   | NewTradeReference   |
		| <HolderNumber> | <RunNumber> | <TransferNumber> | <BuyORSell> | <TradeReference> | <NewTradeReference> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
		| Test  | SelCode | HolderNumber | RunNumber | TransferNumber | BuyORSell | TradeReference | NewTradeReference | ErrorMessage                                                               |
		| Test1 | RTCHG   | 1701         | 4403      | 9999           | B         | 123            | 456               | Trade for this run/transfer is               (leading zeroes are required) |
		| Test2 | RTCHG   | 45776689     | 3657      | 11945041       | B         | E00029344      | 069333094         | No Buy trade for this run/transfer                                         |
		| Test3 | RTCHG   | 45776689     | 3657      | 11945041       | S         | E00029344      | 069333094         | Trade for this run/transfer is 069333094     (leading zeroes are required) |

@winformsTest
@OL_Online
@ANZ_AUTO
@35811
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase35811_DIVHS_MERGEReversal_Transaction
###Test Case 35811: 01 - OLS038 | DIVHS MERGE Reversal Transaction - Perform a DIVHIS Merge reversal transation ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03801 I continue with the following details:
		| FromHolderID   | PaymentDate   | DividendCode   | DividendSource   | PayMethod   | ReferenceNumber   | TOHolderID   |
		| <FromHolderID> | <PaymentDate> | <DividendCode> | <DividendSource> | <PayMethod> | <ReferenceNumber> | <TOHolderID> |
		And In OLS03802 I verify the following details:
		| PaymentDate   | DividendCode   | DividendSource   | PayMethod   | ReferenceNumber   |
		| <PaymentDate> | <DividendCode> | <DividendSource> | <PayMethod> | <ReferenceNumber> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <TOHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIV01 I should see Dividend History as below "<PayDate>" "<PayMethod1>" "<Code>" "<PayAccount>" "<PayType>" "<GrossAmount>" "<NettAmount>"

	Examples: 
		| Test  | SelCode | FromHolderID | PaymentDate | DividendCode | DividendSource | PayMethod | ReferenceNumber | TOHolderID  | Action | LocateArgument | PayDate    | PayMethod1    | Code | PayAccount | PayType | GrossAmount | NettAmount |
		| Test1 | DIVHS   | I8768767565  | 05/08/15    | SB02         | D              | D         | 51              | I0010164036 | DH     |                | 05/08/2015 | DIRECT CREDIT | SB02 | SB003      | PAYMENT | 960.00      | 960.00     |
		| Test2 | DIVHS   | I0060295654  | 05/08/15    | SB01         | D              | C         | 44              | X0007974477 | DH     |                |            |               |      |            |         |             |            |

@winformsTest
@OL_Online
@ANZ_AUTO
@35812
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase35811_DIVHS_MERGEReversal_ErrorValidation
###Test Case 35812: 02 - OLS038 | DIVHS MERGE Reversal Transaction - Error validations for DIVHIS Merge reversal transation ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03801 I continue with the following details:
		| FromHolderID   | PaymentDate   | DividendCode   | DividendSource   | PayMethod   | ReferenceNumber   | TOHolderID   |
		| <FromHolderID> | <PaymentDate> | <DividendCode> | <DividendSource> | <PayMethod> | <ReferenceNumber> | <TOHolderID> |
	Then I should see the below ErrorMessage "<ErrorMessage>"


	Examples: 
		| Test  | SelCode | FromHolderID | PaymentDate | DividendCode | DividendSource | PayMethod | ReferenceNumber | TOHolderID  | ErrorMessage                                |
		| Test1 | DIVHS   | X0007974477  |             |              |                |           |                 | X0007974234 | Invalid Holder Identifier - please re-enter |
		| Test2 | DIVHS   | X0007974477  |             |              |                |           |                 | X0007974477 | Cannot Reverse Merge Details to SAME holder |
		| Test3 | DIVHS   | X0007974477  | 05/08/15    |              |                |           |                 | I8768767565 | Holder Details NOT found on Divhis File     |
		| Test4 | DIVHS   | I8768767565  | 16/12/14    | A058         | D              | D         | 41654           | X0007974477 | Holder Details NOT found on Divhis File     |
		| Test5 | DIVHS   | I8768767565  | 16/12       |              |                |           |                 | X0007974477 | Payment date entered is invalid             |

@winformsTest
@OL_Online
@CPU_AUTO
@35812
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase29579_IRCHG_Transaction
###Test Case 29579: 01 - OLS034 IRCHG Transaction: Verify Issuer Register Code Change ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03402 I continue with the following details:
		| TransNumber   | FromNameKey   | ClassCode   |
		| <TransNumber> | <FromNameKey> | <ClassCode> |
		And In OLS03405 I continue with the following details:
		| FromNameKey   | ClassCode   | OldRegisterCode   | OldRegisterDesc   | NewRegisterCode   |
		| <FromNameKey> | <ClassCode> | <OldRegisterCode> | <OldRegisterDesc> | <NewRegisterCode> |
		And In OLS03408 I verify the following details:
		| FromNameKey   | ClassCode   | OldRegisterCode   | OldRegisterDesc   | NewRegisterCode   | NRegisterDesc   |
		| <FromNameKey> | <ClassCode> | <OldRegisterCode> | <OldRegisterDesc> | <NewRegisterCode> | <NRegisterDesc> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <FromNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01013 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

	Examples: 
		| Test  | SelCode | TransNumber | FromNameKey | ClassCode | OldRegisterCode | OldRegisterDesc | NewRegisterCode | NRegisterDesc   | Action | LocateArgument | CertificateLine1                  | CertificateLine2                                                                          | CertificateLine3 | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
		| Test2 | IRCHG   | 42416       | I0030261488 | OP4       | 11C             | 2011 AWARD      | VIC             | VICTORIA        | R      | /OP4           | OP4/OPT EX 3/6/13-3/5/16 @ $10.89 | VIC UNCERTIF'D   04/06/10 *ALOT 3377/  760000          25000                       WINFRM |                  |                  |                  |                  |                  |                  |                  |                   |
		| Test3 | IRCHG   | 42417       | I0030074483 | FP        | 12A             | 2012 AWARD      | VIC             | VICTORIA        | R      | /FP            | FP /ORDINARY FULLY PAID SHARES    | VIC UNCERTIF'D   26/02/01 RTFXI 1064/10246027           2000  X0007189320                 |                  |                  |                  |                  |                  |                  |                  |                   |
		| Test4 | IRCHG   | 42418       | I0030129105 | FP        | SA              | SOUTH AUSTRALIA | VIC             | VICTORIA        | R      | /FP            | FP /ORDINARY FULLY PAID SHARES    | VIC UNCERTIF'D   04/03/02 RTFXI 1286/10393868          80000  X0028386788                 |                  |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@OL_Online
@CPU_AUTO
@29494
@OL_HKT_HousekeepingTransactions
Scenario Outline: TestCase29494_IRCHG_ErrorValidation
###Test Case 29494: 02 - OLS034  Verify Issuer Register Code Change Transaction Warning Messages ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "housekeeping transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03402 I continue with the following details:
		| TransNumber   | FromNameKey   | ClassCode   |
		| <TransNumber> | <FromNameKey> | <ClassCode> |
	Then I should see the below ErrorMessage "<ErrorMessage>"


	Examples: 
		| Test  | SelCode | TransNumber | FromNameKey | ClassCode | ErrorMessage                          |
		| Test1 | IRCHG   | 42419       | I0030169841 | DLA       | Invalid transaction for ESS class DLA |
		| Test2 | IRCHG   | 42419       | I0100013878 | OPT       | Invalid transaction for ESS class OPT |
		| Test3 | IRCHG   | 42419       | I0030112547 | DLC       | Invalid transaction for ESS class DLC |
		| Test4 | IRCHG   | 42419       | X0012160437 | ORD       | CHESS Holders can NOT be Updated      |
		| Test5 | IRCHG   | 42419       | I0100002841 | DEP       | Invalid transaction for ESS class DEP |
		| Test6 | IRCHG   | 42419       | C9999999910 | 6YU       | Must enter uncertificated holder id   |
		| Test7 | IRCHG   | 42419       | I0030235568 | 6YU       | Invalid class code 6YU                |










