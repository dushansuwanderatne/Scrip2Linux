Feature: OL_PAT_PaymentTransactions
	Ensure OL_PAT_PaymentTransactions Transaction functionality covered

@winformsTest
@OL_Online
@WES_AUTO
@25247
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25247_NEWPY
###Test Case 25247: 02 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - NEWPY add Payment for a Holder (Cheque, Direct Credit, Dividend Reinvestment, Foreign Cheque) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10201 I continue with the following details:
		| PayAccountNumber   |
		| <PayAccountNumber> |
		And In OLS10202 I continue with the following details:
		| PaymentMethod   | Amount1   | WitholdTax   | WHTaxInd   | Amount2   |
		| <PaymentMethod> | <Amount1> | <WitholdTax> | <WHTaxInd> | <Amount2> |
		And In OLS10203 I continue with the following details:
		| CalcNett   | Confirmation   | HolderNameKey   | Calc1   | Calc2   | Calc3   | CalcDual   |
		| <CalcNett> | <Confirmation> | <HolderNameKey> | <Calc1> | <Calc2> | <Calc3> | <CalcDual> |
		And In OLS10204 I continue with the following details:
		| TransNumber   | PayRefNumber   | TransDate   | Currency   |
		| <TransNumber> | <PayRefNumber> | <TransDate> | <Currency> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |


Examples: 
	| Test  | Selection | SelCode | PayAccountNumber | PaymentMethod | Amount1   | WitholdTax | WHTaxInd | Amount2   | Calc1     | Calc2     | Calc3     | CalcNett   | CalcDual  | Confirmation | HolderNameKey | TransNumber | PayRefNumber | TransDate  | Action | LocateArgument | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType  | Currency |
	| Test1 | PAY       | NEWPY   | CREA1            | C             | 456453.50 |            | N        |           |           |           |           | 456453.50  |           | Y            | X0025733959   | 42363       | 42363        | 08/04/2016 | LDS    | CREA1/42363/C  | 16/12/14    | Chq            | 00042363   | 456453.50  | AUD          | AUD          | R/Unpresented |          | CREA1          | CAPITAL REPY |          |
	| Test2 | PAY       | NEWPY   | ILA13            | D             | 987434.65 | 235        | Y        | 453424.34 | 987434.65 | 453424.34 | 423186.28 | 1440623.99 |           | Y            | I6700112096   | 42364       | 42364        | 08/04/2016 | LDS    | ILA13/42364/D  | 08/04/16    | D/Cr           | 00042364   | 1440623.99 | AUD          | AUD          | R/Presented   | 08/04/16 | ILA13          | DIVIDEND     |          |
	| Test3 | PAY       | NEWPY   | PARCZ            | F             | 345437.30 | 44         | Y        |           |           |           |           | 345393.30  |           | Y            | X0013350892   | 42365       | 42365        | 08/04/2016 | LDS    | PARCZ/42365/F  | 26/08/13    | F/Chq          | 00042365   | 345393.30  | USD          | AUD          | R/Unpresented |          | PARCZ          | INTEREST     | USD      |
	| Test4 | PAY       | NEWPY   | FAN11            | R             | 567657.20 |            | N        |           |           |           |           | 567657.20  | 713658.63 | Y            | I0030002890   | 42366       | 42366        | 08/04/2016 | LDS    | FAN11/42366/R  | 30/09/11    | Reinv          | 00042366   | 713658.63  | NZD          | AUD          | R/Presented   | 30/09/11 | FAN11          | CAPITAL REPY |          |

@winformsTest
@OL_Online
@WES_AUTO
@25450
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25450_PAYMV
###Test Case 25450: 05 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PAYMV Transaction (Cheque, Direct Credit, Dividend Reinvestment, Foreign Cheque) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10301 I continue with the following details:
		| TransNumber   | TransDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   | NewHolderNameKey   |
		| <TransNumber> | <TransDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> | <NewHolderNameKey> |
		And In OLS10302 I continue with the following details:
		| TransNumber   | TransDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   | NewHolderNameKey   | PayOrigHolderIdent   |
		| <TransNumber> | <TransDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> | <NewHolderNameKey> | <PayOrigHolderIdent> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <NewHolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |

	
Examples: 
	| Test  | Selection | SelCode | TransNumber | TransDate  | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | NewHolderNameKey | PayOrigHolderIdent | Action | LocateArgument | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType  |
	| Test1 | PAY       | PAYMV   | 42367       | 08/04/2016 | INT15            | D             | 921672       | 25266.21      | I0030373812      | I8600209176        | LDS    | INT15/921672/D | 02/04/15    | D/Cr           | 00921672   | 25266.21   | AUD          | AUD          | Presented     | 02/04/15 | INT15          | DIVIDEND     |
	| Test2 | PAY       | PAYMV   | 42368       | 08/04/2016 | 0703             | R             | 514166       | 25833.20      | X0001014935      | I0132036217        | LDS    | 0703/514166/R  | 30/03/07    | Reinv          | 00514166   | 25833.20   | AUD          | AUD          | Presented     | 30/03/07 | 0703           | DIVIDEND     |
	| Test3 | PAY       | PAYMV   | 42369       | 08/04/2016 | 0603             | C             | 1065407      | 17405.70      | I0130045456      | I0030007816        | LDS    | 0603/1065407/C | 08/03/06    | Chq            | 01065407   | 17405.70   | AUD          | AUD          | Presented     | 09/03/06 | 0603           | DIVIDEND     |
	| Test4 | PAY       | PAYMV   | 42370       | 08/04/2016 | CREA1            | F             | 75000        | 469890.00     | X0060466203      | I0030018290        | LDS    | CREA1/75000/F  | 16/12/14    | F/Chq          | 00075000   | 469890.00  | USD          | AUD          | R/Unpresented |          | CREA1          | CAPITAL REPY |

@winformsTest
@OL_Online
@WES_AUTO
@25511
@OL_PAT_PaymentTransactions
@FullSmokeTest
Scenario Outline: TestCase25511_PAYAD
###Test Case 25511: 08 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PAYAD Transaction (Cheque) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10701 I continue with the following details:
		| TransNumber   | TransDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   |
		| <TransNumber> | <TransDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> |
		And In OLS10704 I continue with the following details:
		| GrossAmount   | NewGrossAmount   |
		| <GrossAmount> | <NewGrossAmount> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |

Examples: 
	| Test  | Selection | SelCode | TransNumber | TransDate  | PayAccountNumber | PaymentMethod | PayRefNumber | GrossAmount | NewGrossAmount | HolderNameKey | Action | LocateArgument | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType  |
	| Test1 | PAY       | PAYAD   | 42372       | 08/04/2016 | CREA1            | C             | 987650       | 6780.50     | 98234.90       | I0030125959   | LDS    | CREA1/987650/C | 16/12/14    | Chq            | 00987650   | 98234.90   | AUD          | AUD          | R/Unpresented |          | CREA1          | CAPITAL REPY |

@winformsTest
@OL_Online
@WES_AUTO
@25588
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25588_PAYAD
###Test Case 25588: 09 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PAYAD Transaction - Cannot adjust for Presented Status ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10701 I continue with the following details:
		| TransNumber   | TransDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   |
		| <TransNumber> | <TransDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Test  | Selection | SelCode | TransNumber | TransDate  | PayAccountNumber | PaymentMethod | PayRefNumber | ErrorMessage                                     |
	| Test1 | PAY       | PAYAD   | 42373       | 08/04/2016 | CREA1            | D             | 01081530     | Cannot adjust a System created payment           |
	| Test2 | PAY       | PAYAD   | 42373       | 08/04/2016 | FIN10            | R             | 00004354     | Cannot use PAYAD for Payment Status of Presented |

@winformsTest
@OL_Online
@WES_AUTO
@25599
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25599_PAYAD_ForeignCheque
###Test Case 25599: 10 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PAYAD Transaction (Foreign Cheque) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10701 I continue with the following details:
		| TransNumber   | TransDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   |
		| <TransNumber> | <TransDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> |
		And In OLS10702 I continue with the following details:
		| NewFranked   | NewUnfranked   | NewWitholdTax   | NewWHTaxInd   | Franked   | Unfranked   | WitholdTax   | WHTaxInd   |
		| <NewFranked> | <NewUnfranked> | <NewWitholdTax> | <NewWHTaxInd> | <Franked> | <Unfranked> | <WitholdTax> | <WHTaxInd> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |


Examples: 
	| Test  | Selection | SelCode | TransNumber | TransDate  | PayAccountNumber | PaymentMethod | PayRefNumber | NewFranked | NewUnfranked | NewWitholdTax | NewWHTaxInd | Franked  | Unfranked | WitholdTax | WHTaxInd | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | PAYAD   | 42374       | 08/04/2016 | INT15            | F             | 00965723     | 24003.90   | 3405.50      | 45            | Y           | 87660.50 | 65530.80  | 55.00      | Y        | X0038438549   | LDS    | INT15/00965723/F | 02/04/15    | F/Chq          | 00965723   | 27364.40   | USD          | AUD          | R/Unpresented |          | INT15          | DIVIDEND    |
	| Test2 | PAY       | PAYAD   | 42375       | 08/04/2016 | FIN14            | F             | 00657655     | 98344.50   | 7603.50      | 68            | Y           | 87005.50 | 6549.40   | 55.00      | Y        | I0132211230   | LDS    | FIN14/00657655/F | 09/10/14    | F/Chq          | 00657655   | 105880.00  | USD          | AUD          | R/Unpresented |          | FIN14          | DIVIDEND    |

@winformsTest
@OL_Online
@WES_AUTO
@25606
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25606_PRSNT_ChequeFCheque
###Test Case 25606: 12 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PRSNT Transaction (Cheque, Foreign Cheque) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10001 I continue with the following details:
		| PayRefNumber   | PaymentAmount   | PresentedDate   | PayAccountNumber   | PaymentMethod   | TransNumber   |
		| <PayRefNumber> | <PaymentAmount> | <PresentedDate> | <PayAccountNumber> | <PaymentMethod> | <TransNumber> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |

Examples: 
	| Test  | Selection | SelCode | PayRefNumber | PaymentAmount | PresentedDate | PayAccountNumber | PaymentMethod | TransNumber | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType  |
	| Test1 | PAY       | PRSNT   | 01000000     | 2212.79       | 08/04/2016    | EXZ9A            | C             | 42376       | I0032536832   | LDS    | EXZ9A/01000000/C | 13/11/09    | Chq            | 01000000   | 2212.79    | AUD          | AUD          | Presented     | 08/04/16 | EXZ9A          | CAPITAL REPY |
	| Test2 | PAY       | PRSNT   | 01000003     | 763648.74     | 08/04/2016    | DFA11            | C             | 42377       | I0032536867   | LDS    | DFA11/01000003/C | 13/01/12    | Chq            | 01000003   | 763648.74  | AUD          | AUD          | Presented     |          | DFA11          | CAPITAL REPY |
	| Test3 | PAY       | PRSNT   | 00985455     | 65092.40      | 08/04/2016    | 08FLA            | F             | 42378       | I0030282001   | LDS    | 08FLA/00985455/F | 06/10/08    | F/Chq          | 00985455   | 65092.40   | USD          | AUD          | R/Presented   |          | 08FLA          | DIVIDEND     |
	| Test4 | PAY       | PRSNT   | 00000037     | 346.58        | 08/04/2016    | 0603S            | C             | 42379       | I0030487109   | LDS    | 0603S/00000037/C | 08/03/06    | Chq            | 00000037   | 346.58     | GBP          | AUD          | Presented     |          | 0603S          | DIVIDEND     |

@winformsTest
@OL_Online
@WES_AUTO
@25620
@25706
@OL_PAT_PaymentTransactions
Scenario Outline: PRSNT_Error Validations
###Test Case 25620: 13 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PRSNT Transaction Error Validations ####
###Test Case 25706: 14 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PRSNT Transaction not applicable for 'Presented' Payments ###
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10001 I continue with the following details:
		| PayRefNumber   | PaymentAmount   | PresentedDate   | PayAccountNumber   | PaymentMethod   | TransNumber   |
		| <PayRefNumber> | <PaymentAmount> | <PresentedDate> | <PayAccountNumber> | <PaymentMethod> | <TransNumber> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Test  | Selection | SelCode | PayRefNumber | PaymentAmount | PresentedDate | PayAccountNumber | PaymentMethod | TransNumber | ErrorMessage                                     |
	| Test1 | PAY       | PRSNT   | 7644885      | 4566666.76    | 14/05/2014    | TST50            | S             | 42380       | Please enter either: <space>, C, F               |
	| Test2 | PAY       | PRSNT   | 7644885      | 4566666.76    | 14/05/2014    | TST50            | C             | 42380       | Payment Account Number not on file               |
	| Test3 | PAY       | PRSNT   | 7644885      | 4566666.76    | 14/05/2014    | CREA1            | C             | 42380       | No cheque payment for this payment account #,    |
	| Test4 | PAY       | PRSNT   | 01059484     | 5274.75       | 31/12/2015    | 0603             | C             | 42380       | Cannot use PRSNT for Payment Status of Presented |


@winformsTest
@OL_Online	
@WES_AUTO
@25716
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25716_CANCL_Transaction
###Test Case 25716: 15 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - CANCL Transaction with 'Presented' Status ('D'irect Credit, 'R' Dividend Reinvestment) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10501 I continue with the following details:
		| TransNumber   | CancelledDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   |
		| <TransNumber> | <CancelledDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> |
		And I Transmit
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |


Examples: 
	| Test  | Selection | SelCode | TransNumber | CancelledDate | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status    | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | CANCL   | 42381       | 08/04/2016    | FIN12            | D             | 01051669     | 13593.55      | X0035932984   | LDS    | FIN12/01051669/D | 28/09/12    | D/Cr           | 01051669   | 13593.55   | AUD          | AUD          | Cancelled | 08/04/16 | FIN12          | DIVIDEND    |
	| Test2 | PAY       | CANCL   | 42382       | 08/04/2016    | CDVA1            | R             | 00157185     | 2198.50       | X0007785925   | LDS    | CDVA1/00157185/R | 16/12/14    | Reinv          | 00157185   | 2198.50    | AUD          | AUD          | Cancelled | 08/04/16 | CDVA1          | DIVIDEND    |

@winformsTest
@OL_Online
@WES_AUTO
@25720
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25720_CANCL_Transaction_Error
###Test Case 25720: 16 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - CANCL Transaction not applicable with 'Presented' Status ('C'heque, 'F'oreign Cheque) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10501 I continue with the following details:
		| TransNumber   | CancelledDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   |
		| <TransNumber> | <CancelledDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> |
	Then I should see the below ErrorMessage "<ErrorMessage>"


Examples: 
	| Test  | Selection | SelCode | TransNumber | CancelledDate | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | ErrorMessage                                     |
	| Test1 | PAY       | CANCL   | 42383       | 08/04/2016    | 0711             | C             | 01168241     | 37773.40      | Cannot use CANCL for Payment Status of Presented |
	| Test2 | PAY       | CANCL   | 42383       | 08/04/2016    | CREA1            | F             | 00544443     | 45150.50      | Cannot use CANCL for Payment Status of Presented |

@winformsTest
@OL_Online
@WES_AUTO
@25721
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25721_CANCL_Transaction
###Test Case 25721: 17 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - CANCL Transaction with 'Unpresented', 'Unissued', 'RepUnpresented'  Status ('C'heque, 'F'oreign Cheque, 'D'irect Credit) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10501 I continue with the following details:
		| TransNumber   | CancelledDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   |
		| <TransNumber> | <CancelledDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |

Examples: 
	| Test  | Selection | SelCode | TransNumber | CancelledDate | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status      | PresDate | PaymentAccount | PaymentType  |
	| Test1 | PAY       | CANCL   | 42384       | 08/04/2016    | 0803             | C             | 01202989     | 11514.10      | I0030064178   | LDS    | 0803/01202989/C  | 31/03/08    | Chq            | 01202989   | 11514.10   | AUD          | AUD          | Cancelled   | 08/04/16 | 0803           | DIVIDEND     |
	| Test2 | PAY       | CANCL   | 42385       | 08/04/2016    | CREA1            | F             | 00854645     | 655645.00     | X0061270302   | LDS    | CREA1/00854645/F | 16/12/14    | F/Chq          | 00854645   | 655645.00  | USD          | AUD          | R/Cancelled | 08/04/16 | CREA1          | CAPITAL REPY |
	| Test3 | PAY       | CANCL   | 42386       | 08/04/2016    | INT15            | D             | 00801033     | 89867.75      | I0030072839   | LDS    | INT15/00801033/D | 02/04/15    | D/Cr           | 00801033   | 89867.75   | AUD          | AUD          | Cancelled   | 08/04/16 | INT15          | DIVIDEND     |
	
@winformsTest
@OL_Online	
@ANZ_AUTO
@28040
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase28040_CNREV_Transaction
###Test Case 28040: 01 - OLS104 and OLS106 | Reversal Transactions - Add CNREV transaction  (OLS10601) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10601 I continue with the following details:
		| TransNumber   | ReversedDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   |
		| <TransNumber> | <ReversedDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> |		
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |

			    
Examples: 
	| Test  | Selection | SelCode | TransNumber | ReversedDate | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | CNREV   | 42387       | 08/04/2016   | NZL03            | C             | 00533349     | 6221.44       | I0012314027   | LDS    | NZL03/00533349/C | 15/12/03    | Chq            | 00533349   | 6221.44    | AUD          | AUD          | Unpresented   |          | NZL03          | INTEREST    |
	| Test2 | PAY       | CNREV   | 42388       | 08/04/2016   | R0608            | C             | 00011280     | 114.82        | I0012932529   | LDS    | R0608/00011280/C | 16/06/08    | Chq            | 00011280   | 114.82     | AUD          | AUD          | R/Unpresented |          | R0608          | INTEREST    |
	| Test3 | PAY       | CNREV   | 42389       | 08/04/2016   | A057             | D             | 75950        | 5160.11       | I0012932529   | LDS    | A057/75950/D     | 01/07/14    | D/Cr           | 00075950   | 5160.11    | AUD          | AUD          | Failed        | 01/01/15 | A057           | DIVIDEND    |
	| Test4 | PAY       | CNREV   | 42390       | 08/04/2016   | 03EMI            | R             | 511230       | 185.68        | I0060153124   | LDS    | 03EMI/511230/R   | 01/07/03    | Reinv          | 00511230   | 185.68     | AUD          | AUD          | Presented     | 01/07/03 | 03EMI          | DIVIDEND    |
	| Test5 | PAY       | CNREV   | 42391       | 08/04/2016   | SB001            | F             | 789456       | 590.00        | I0060153124   | LDS    | SB001/789456/F   | 05/08/15    | F/Chq          | 00789456   | 590.00     | USD          | AUD          | R/Unpresented |          | SB001          | DIVIDEND    |

@winformsTest
@OL_Online        
@ANZ_AUTO
@28041
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase28041_CNREV_Transaction_ErrorValidation
###Test Case 28041: 02 - OLS104 and OLS106 | Reversal Transactions - Error validations for CNREV transaction  (OLS10601) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10601 I continue with the following details:
		| TransNumber   | ReversedDate   | PayAccountNumber   | PaymentMethod   | PayRefNumber   | PaymentAmount   |
		| <TransNumber> | <ReversedDate> | <PayAccountNumber> | <PaymentMethod> | <PayRefNumber> | <PaymentAmount> |		
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | Selection | SelCode | TransNumber | ReversedDate | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | ErrorMessage                                         |
	| Test1 | PAY       | CNREV   | 42392       | 08/04/2016   | 02FES            | R             | 900996       | 222.18        | Cannot use CNREV for Payment Status of Presented     |
	| Test2 | PAY       | CNREV   | 42392       | 08/04/2016   | FES              | R             | 900996       | 222.18        | Payment Account Number not on file                   |
	| Test3 | PAY       | CNREV   | 42392       | 08/04/2016   | C2S14            | D             | 80079        | 608.97        | No payment for this method/reference on this account |
	| Test4 | PAY       | CNREV   | 42392       | 08/04/2016   | C2S14            | C             | 807956       | 608.97        | No payment for this method/reference on this account |
	| Test5 | PAY       | CNREV   | 42392       | 08/04/2016   | C2S14            | D             | 807956       | 608.97        | Cannot use CNREV on a REDCA transaction              |

@winformsTest
@OL_Online
@ANZ_AUTO
@28134
@28158
@OL_PAT_PaymentTransactions
Scenario Outline: DFREV_PRREV_Transaction
###Test Case 28134: 03 - OLS104 and OLS106 | Reversal Transactions - Add DFREV transaction  (OLS10401) ####
###Test Case 28158: 04 - OLS104 and OLS106 | Reversal Transactions - Add PRREV transaction  (OLS10401) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10401 I continue with the following details:
		| TransNumber   | ReversedDate   | PayAccountNumber   | PayRefNumber   | PaymentAmount   | PaymentMethod   |
		| <TransNumber> | <ReversedDate> | <PayAccountNumber> | <PayRefNumber> | <PaymentAmount> | <PaymentMethod> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |
     

	Examples: 
	| Test  | Selection | SelCode | TransNumber | ReversedDate | PayAccountNumber | PayRefNumber | PaymentAmount | HolderNameKey | Action | LocateArgument | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status        | PresDate | PaymentAccount | PaymentType | PaymentMethod |
	| Test1 | PAY       | DFREV   | 42393       | 08/04/2016   | JU210            | 820848       | 265.72        | X0048546650   | LDS    | JU210/820848/D | 15/06/10    | D/Cr           | 00820848   | 265.72     | AUD          | AUD          | Presented     | 15/06/10 | JU210          | DIVIDEND    |               |
	| Test2 | PAY       | DFREV   | 42394       | 08/04/2016   | MA210            | 820737       | 242.18        | X0048546650   | LDS    | MA210/820737/D | 15/03/10    | D/Cr           | 00820737   | 242.18     | AUD          | AUD          | R/Presented   | 09/04/10 | MA210          | DIVIDEND    |               |
	| Test3 | PAY       | PRREV   | 42395       | 08/04/2016   | A029             | 285888       | 174.00        | X0007819455   | LDS    | A029/285888/C  | 03/07/00    | Chq            | 00285888   | 174.00     | AUD          | AUD          | Unpresented   |          | A029           | DIVIDEND    | C             |
	| Test4 | PAY       | PRREV   | 42396       | 08/04/2016   | A049             | 55331        | 520.00        | X0046973186   | LDS    | A049/55331/C   | 01/07/10    | Chq            | 00055331   | 520.00     | AUD          | AUD          | R/Unpresented |          | A049           | DIVIDEND    |               |

@winformsTest
@OL_Online
@ANZ_AUTO
@28176
@OL_PAT_PaymentTransactions
Scenario Outline: DFREV_PRREV_Transaction_ErrorValidation
###Test Case 28176: 05 - OLS104 and OLS106 | Reversal Transactions - Error validations for DFREV transaction  (OLS10401) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS10401 I continue with the following details:
		| TransNumber   | ReversedDate   | PayAccountNumber   | PayRefNumber   | PaymentAmount   | PaymentMethod   |
		| <TransNumber> | <ReversedDate> | <PayAccountNumber> | <PayRefNumber> | <PaymentAmount> | <PaymentMethod> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | Selection | SelCode | TransNumber | ReversedDate | PayAccountNumber | PayRefNumber | PaymentAmount | PaymentMethod | ErrorMessage                                         |
	| Test1 | PAY       | DFREV   | 42397       | 08/04/2016   | C2S14            | 807956       | 608.97        |               | Cannot use DFREV for Payment Status of Cancelled     |
	| Test2 | PAY       | DFREV   | 42397       | 08/04/2016   | FEM13            | 78509        | 3570.84       |               | No direct credit payment for this payment account #, |
	| Test3 | PAY       | DFREV   | 42397       | 08/04/2016   | A49              | 117614       | 1705.60       |               | Payment Account Number not on file                   |
	| Test4 | PAY       | DFREV   | 42397       | 08/04/2016   | A049             | 117614       | 1705.60       |               | Cannot use DFREV for Payment Status of Presented     |
	| Test5 | PAY       | DFREV   | 42397       | 08/04/2016   | A049             | 17614        | 1705.60       |               | No direct credit payment for this payment account #, |
	| Test6 | PAY       | PRREV   | 42397       | 08/04/2016   | A049             | 117614       | 1705.60       |               | No cheque payment for this payment account #,        |
	| Test7 | PAY       | PRREV   | 42397       | 08/04/2016   | SB001            | 77           | 1120.00       | C             | Cannot use PRREV for Payment Status of Unpresented   |
	| Test8 | PAY       | PRREV   | 42397       | 08/04/2016   | SB001            | 77           | 1120.00       | F             | No direct credit payment for this payment account #, |
	| Test9 | PAY       | PRREV   | 42397       | 08/04/2016   | SB99             | 77           | 1120.00       | C             | Payment Account Number not on file                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@25379
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25379_DCRFM_Transaction
###Test Case 25379: 01 - OLS116 and OLS119 | Direct Credit Transactions - Add DCRFM transaction OLS11903 ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11901 I continue with the following details:
		| TransNumber   | FailedDate   | PayAccountNumber   | PayRefNumber   | PaymentAmt   |
		| <TransNumber> | <FailedDate> | <PayAccountNumber> | <PayRefNumber> | <PaymentAmt> |
		And In OLS11903 I verify with the following details:
		| SubPaymentCode   | PaymentTypeDesc   | SubpGrossAmt   | SubpTaxAmt   | SubpDednAmt   | SubpNettAmt   | TotGrossAmt   | TotTaxAmt   | TotDednAmt   | TotNettAmt   |
		| <SubPaymentCode> | <PaymentTypeDesc> | <SubpGrossAmt> | <SubpTaxAmt> | <SubpDednAmt> | <SubpNettAmt> | <TotGrossAmt> | <TotTaxAmt> | <TotDednAmt> | <TotNettAmt> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |

	Examples: 
	| Test  | Selection | SelCode | TransNumber | FailedDate | PayAccountNumber | PayRefNumber | PaymentAmt | HolderNameKey | SubPaymentCode | PaymentTypeDesc | SubpGrossAmt | SubpTaxAmt | SubpDednAmt | SubpNettAmt | TotGrossAmt | TotTaxAmt | TotDednAmt | TotNettAmt | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status   | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | DCRFM   | 42398       | 28/07/2015 | MA315            | 00812364     | 1202.10    | X0055596000   | CPSC           | DIVIDEND        | 1202.10      |            |             | 1202.10     | 1202.10     |           |            | 1202.10    | LDS    | MA315/00812364/D | 02/03/15    | D/Cr           | 00812364   | 1202.10    | AUD          | AUD          | Failed   | 28/07/15 | MA315          | DIVIDEND    |
	| Test2 | PAY       | DCRFM   | 42399       | 30/07/2015 | A054             | 99999995     | 827.92     | X0055596000   | ORDS           | DIVIDEND        | 827.92       |            |             | 827.92      | 827.92      |           |            | 827.92     | LDS    | A054/99999995/D  | 19/12/12    | D/Cr           | 99999995   | 827.92     | AUD          | AUD          | R/Failed | 30/07/15 | A054           | DIVIDEND    |

@winformsTest
@OL_Online
@ANZ_AUTO
@25453
@OL_PAT_PaymentTransactions
@FullSmokeTest
Scenario Outline: TestCase25453_DCRFM_Transaction
###Test Case 25453: 02 - OLS116 and OLS119 | Direct Credit Transactions - Add DCRFM transaction OLS11902 ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11901 I continue with the following details:
		| TransNumber   | FailedDate   | PayAccountNumber   | PayRefNumber   | PaymentAmt   |
		| <TransNumber> | <FailedDate> | <PayAccountNumber> | <PayRefNumber> | <PaymentAmt> |
		And In OLS11902 I verify with the following details:
		| TotGross   | TotNett   | TotTaxAmt   |
		| <TotGross> | <TotNett> | <TotTaxAmt> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |


	Examples: 
	| Test  | Selection | SelCode | TransNumber | FailedDate | PayAccountNumber | PayRefNumber | PaymentAmt | TotGross | TotNett | TotTaxAmt | HolderNameKey | Action | LocateArgument | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status   | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | DCRFM   | 42400       | 28/07/2015 | JU215            | 417417       | 1000       | 1000.00  | 1000.00 | 0.00      | X0007359454   | LDS    | JU215/417417/D | 28/01/15    | D/Cr           | 00417417   | 1000.00    | AUD          | AUD          | R/Failed | 28/07/15 | JU215          | DIVIDEND    |

@winformsTest
@OL_Online
@ANZ_AUTO
@25456
@25464
@25465
@OL_PAT_PaymentTransactions
Scenario Outline: DCRFM_ErrorValidation
###Test Case 25456: 03 - OLS116 and OLS119 | Direct Credit Transactions - Error Validations for DCRFM (OLS11901) ####
###Test Case 25464: 04 - OLS116 and OLS119 | Direct Credit Transactions -  DCRFM returns error for Cheque Payment ####
###Test Case 25465: 05 - OLS116 and OLS119 | Direct Credit Transactions - Add DCRFM transaction for Non Presented Direct Credit Payment ###
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11901 I continue with the following details:
		| TransNumber   | FailedDate   | PayAccountNumber   | PayRefNumber   | PaymentAmt   |
		| <TransNumber> | <FailedDate> | <PayAccountNumber> | <PayRefNumber> | <PaymentAmt> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | Selection | SelCode | TransNumber | FailedDate | PayAccountNumber | PayRefNumber | PaymentAmt | ErrorMessage                                         |
	| Test1 | PAY       | DCRFM   | 42401       | 10/10/2014 | 44               | 00099747     | 100.00     | Payment Account Number not on file                   |
	| Test2 | PAY       | DCRFM   | 42401       | 10/10/2014 | A058             | 00099747     | 100.00     | This payment is for     6376.40                      |
	| Test3 | PAY       | DCRFM   | 42401       | 28/07/2015 | A029             | 00250970     | 3480.00    | No direct credit payment for this payment account #, |
	| Test4 | PAY       | DCRFM   | 42401       | 29/05/2015 | 04FEM            | 00801233     | 1049.22    | Cannot use DCRFM for Payment Status of Cancelled     |
	| Test5 | PAY       | DCRFM   | 42401       | 29/05/2015 | A050             | 00100692     | 2285.12    | Cannot use DCRFM for Payment Status of Failed        |

@winformsTest
@OL_Online
@ANZ_AUTO
@25480
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25480_REDCR_Transaction
###Test Case 25480: 06 - OLS116 and OLS119 | Direct Credit Transactions - Add REDCR transaction (OLS011603) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11601 I continue with the following details:
		| TransNumber   | PayAccountNumber   | PaymentMethod   | PayOrigRef   | PaymentAmount   |
		| <TransNumber> | <PayAccountNumber> | <PaymentMethod> | <PayOrigRef> | <PaymentAmount> |
		And In OLS11603 I verify with the following details:
		| SubPaymentCode   | PaymentTypeDesc   | SubpGrossAmt   | SubpTaxAmt   | SubpDednAmt   | SubpNettAmt   | TotGrossAmt   | TotTaxAmt   | TotDednAmt   | TotNettAmt   |
		| <SubPaymentCode> | <PaymentTypeDesc> | <SubpGrossAmt> | <SubpTaxAmt> | <SubpDednAmt> | <SubpNettAmt> | <TotGrossAmt> | <TotTaxAmt> | <TotDednAmt> | <TotNettAmt> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |
	   

	Examples: 
	| Test  | Selection | SelCode | TransNumber | PayAccountNumber | PaymentMethod | PayOrigRef | PaymentAmount | SubPaymentCode | PaymentTypeDesc | SubpGrossAmt | SubpTaxAmt | SubpDednAmt | SubpNettAmt | TotGrossAmt | TotTaxAmt | TotDednAmt | TotNettAmt | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status      | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | REDCR   | 42402       | MA315            | D             | 00813897   | 601.05        | CPSC           | DIVIDEND        | 601.05       |            |             | 601.05      | 601.05      |           |            | 601.05     | X0058057207   | LDS    | MA315/00813897/D | 02/03/15    | D/Cr           | 00813897   | 601.05     | AUD          | AUD          | R/Pending   |          | MA315          | DIVIDEND    |
	| Test2 | PAY       | REDCR   | 42403       | JU212            | C             | 00001472   | 386.83        | CPSA           | DIVIDEND        | 386.83       |            |             | 386.83      | 386.83      |           |            | 386.83     | X0035388761   | LDS    | JU212/00001472/C | 15/06/12    | Chq            | 00001472   | 386.83     | AUD          | AUD          | R/Cancelled |          | JU212          | DIVIDEND    |


@winformsTest
@OL_Online
@ANZ_AUTO
@25709
@OL_PAT_PaymentTransactions
@FullSmokeTest
Scenario Outline: TestCase25709_REDCR_Transaction
###Test Case 25709: 07 - OLS116 and OLS119 | Direct Credit Transactions - Add REDCR transaction (OLS011602) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11601 I continue with the following details:
		| TransNumber   | PayAccountNumber   | PaymentMethod   | PayOrigRef   | PaymentAmount   |
		| <TransNumber> | <PayAccountNumber> | <PaymentMethod> | <PayOrigRef> | <PaymentAmount> |
		And In OLS11602 I verify the following details:
		| Class   | ClassCatUnits   | GrossAmt1   | GrossAmt2   | ImputedCredit   | TotalGross   | TotGross   | TotNett   | TotTaxAmt   |
		| <Class> | <ClassCatUnits> | <GrossAmt1> | <GrossAmt2> | <ImputedCredit> | <TotalGross> | <TotGross> | <TotNett> | <TotTaxAmt> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |
	
	Examples: 
	| Test  | Selection | SelCode | TransNumber | PayAccountNumber | PaymentMethod | PayOrigRef | PaymentAmount | Class | ClassCatUnits | GrossAmt1 | GrossAmt2 | ImputedCredit | TotalGross | TotGross | TotNett | TotTaxAmt | HolderNameKey | Action | LocateArgument   | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status    | PresDate | PaymentAccount | PaymentType  |
	| Test1 | PAY       | REDCR   | 42404       | AUSOS            | C             | 00567839   | 136.16        | OSE   | 40            | 140.85    |           |               | 140.85     | 140.85   | 140.85  | 0.00      | I0012146973   | LDS    | AUSOS/00567839/C | 17/12/03    | Chq            | 00567839   | 136.16     | AUD          | AUD          | Cancelled |          | AUSOS          | CAPITAL REPY |

@winformsTest
@OL_Online
@ANZ_AUTO
@25711
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase25711_REDCR_ErrorValidation
###Test Case 25711: 08 - OLS116 and OLS119 | Direct Credit Transactions - REDCR returns error for Cancelled Payments ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11601 I continue with the following details:
		| TransNumber   | PayAccountNumber   | PaymentMethod   | PayOrigRef   | PaymentAmount   |
		| <TransNumber> | <PayAccountNumber> | <PaymentMethod> | <PayOrigRef> | <PaymentAmount> |
	Then I should see the below ErrorMessage "<ErrorMessage>"
		
	Examples: 
	| Test  | Selection | SelCode | TransNumber | PayAccountNumber | PaymentMethod | PayOrigRef | PaymentAmount | ErrorMessage                                         |
	| Test1 | PAY       | REDCR   | 42405       | 04FEM            | D             | 00801233   | 1049.22       | Cannot use REDCR for Payment Status of Cancelled     |
	| Test2 | PAY       | REDCR   | 42405       | 044              | D             | 00101092   | 10.00         | Payment Account Number not on file                   |
	| Test3 | PAY       | REDCR   | 42405       | A055             | C             | 00101092   | 4899.76       | No payment for this method/reference on this account |
	| Test4 | PAY       | REDCR   | 42405       | A055             | D             | 00101091   | 4899.76       | No payment for this method/reference on this account |
	| Test5 | PAY       | REDCR   | 42405       | Ju215            | D             | 55664      | 778.79        | DIVHIS details for this Payment cannot be found.     |

@winformsTest
@OL_Online
@ANZ_AUTO
@25713
@OL_PAT_PaymentTransactions
@FullSmokeTest
Scenario Outline: TestCase25713_REDCR_Transactions
###Test Case 25713: 10 - OLS116 and OLS119 | Direct Credit Transactions - Warning for Direct Credit Details for REDCR (OLS11699) ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11601 I continue with the following details:
		| TransNumber   | PayAccountNumber   | PaymentMethod   | PayOrigRef   | PaymentAmount   |
		| <TransNumber> | <PayAccountNumber> | <PaymentMethod> | <PayOrigRef> | <PaymentAmount> |
		And In OLS11699 I continue with the following details:
		| ConfirmContinue   |
		| <ConfirmContinue> |
		And In OLS11602 I verify the following details:
		| Class   | ClassCatUnits   | GrossAmt1   | GrossAmt2   | ImputedCredit   | TotalGross   | TotGross   | TotNett   | TotTaxAmt   |
		| <Class> | <ClassCatUnits> | <GrossAmt1> | <GrossAmt2> | <ImputedCredit> | <TotalGross> | <TotGross> | <TotNett> | <TotTaxAmt> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <HolderNameKey>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSDIS01 I should see following details:
	| PaymentDate   | PaymentMethod    | RefNumberX   | PaidAmount   | PaidCurrency   | BaseCurrency   | Status   | PresDate   | PaymentAccount   | PaymentType   |
	| <PaymentDate> | <PaymentMethod1> | <RefNumberX> | <PaidAmount> | <PaidCurrency> | <BaseCurrency> | <Status> | <PresDate> | <PaymentAccount> | <PaymentType> |


	Examples: 
	| Test  | Selection | SelCode | TransNumber | PayAccountNumber | PaymentMethod | PayOrigRef | PaymentAmount | ConfirmContinue | Class | ClassCatUnits | GrossAmt1 | GrossAmt2 | ImputedCredit | TotalGross | TotGross | TotNett | TotTaxAmt | HolderNameKey | Action | LocateArgument  | PaymentDate | PaymentMethod1 | RefNumberX | PaidAmount | PaidCurrency | BaseCurrency | Status    | PresDate | PaymentAccount | PaymentType |
	| Test1 | PAY       | REDCR   | 42406       | A037             | D             | 00360230   | 778.79        | Y               | ORD   | 1657          | 778.79    |           | 333.77        | 778.79     | 778.79   | 778.79  | 0.00      | I0060170444   | LDS    | A037/00360230/D | 01/07/04    | D/Cr           | 00360230   | 778.79     | AUD          | AUD          | R/Pending |          | A037           | DIVIDEND    |


@winformsTest
@OL_Online
@ANZ_AUTO
@26694
@OL_PAT_PaymentTransactions
Scenario Outline: TestCase26694_REPCP_ErrorValidation
###Test Case 26694: 03 - OLS110, OLS120, and OLS124 | Replacement Cheque Transactions  -  Error validation on OLS11001 for REPCP ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11001 I continue with the following details:
		| RecnRequired   | ChequeFormat   | FileName   | Origin   |
		| <RecnRequired> | <ChequeFormat> | <FileName> | <Origin> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | Selection | SelCode | RecnRequired | ChequeFormat | Origin | FileName | ErrorMessage                                           |
	| Test1 | PAY       | REPCP   | N            | T            |        |          | Reconciliation has to be selected when using T format. |
	| Test2 | PAY       | REPCP   | Y            | T            |        |          | A Tape file name has to be input.                      |
	| Test3 | PAY       | REPCP   | Y            | S            | A      | TEST     | (S) format not available for this company.             |

#@OL_Online
#@ignore
#@ANZ_AUTO
#@26208
#@OL_PAT_PaymentTransactions
#Scenario Outline: TestCase26208_REPCP_Transaction
####Test Case 26208: 01 - OLS110, OLS120, and OLS124 | Replacement Cheque Transactions - Add REPCP transaction with Reconciliation (RCHQR) for Tape Cheque format ####
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And In MNS00101 I click on: "online data entry system" within the System Menu
#		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
#		And In OLS15001 I continue with the following details:
#		| Selection   |
#		| <Selection> |
#		And In SELTRN20 I continue with the following details:
#		| SelCode   |
#		| <SelCode> |
#		And In OLS11001 I continue with the following details:
#		| RecnRequired   | ChequeFormat   | FileName   | Origin   |
#		| <RecnRequired> | <ChequeFormat> | <FileName> | <Origin> |
#		And In OLS11010 I verify the following details:
#		| WarningLit   | FileName1   | MailFileName   |
#		| <WarningLit> | <FileName1> | <MailFileName> |
#		And In OLS11002 I continue with the following details:
#		| TransNumber   | ReplacementDate   | PayAccountNumber   | PaymentMethod   | PayOrigRef   | PaymentAmount   |
#		| <TransNumber> | <ReplacementDate> | <PayAccountNumber> | <PaymentMethod> | <PayOrigRef> | <PaymentAmount> |
#		And In OLS11004 I verify the following details:
#		| DividendCode   | PaymentDate   | SubPaymentCode   | PaymentTypeDesc   | SubpGrossAmt   | SubpTaxAmt   | SubpOtaxAmt   | SubpNettAmt   | TotGrossAmt   | TotTaxAmt   | TotOtaxAmt   | TotNettAmt   | BankCode   | AccountNumber   |
#		| <DividendCode> | <PaymentDate> | <SubPaymentCode> | <PaymentTypeDesc> | <SubpGrossAmt> | <SubpTaxAmt> | <SubpOtaxAmt> | <SubpNettAmt> | <TotGrossAmt> | <TotTaxAmt> | <TotOtaxAmt> | <TotNettAmt> | <BankCode> | <AccountNumber> |
#
#	Examples: 
#	| Test  | Selection | SelCode | RecnRequired | ChequeFormat | Origin | FileName | WarningLit                              | FileName1     | MailFileName       | TransNumber | ReplacementDate | PayAccountNumber | PaymentMethod | PayOrigRef | PaymentAmount | DividendCode | PaymentDate | SubPaymentCode | PaymentTypeDesc | SubpGrossAmt | SubpTaxAmt | SubpOtaxAmt | SubpNettAmt | TotGrossAmt | TotTaxAmt | TotOtaxAmt | TotNettAmt | BankCode | AccountNumber |
#	| Test1 | PAY       | REPCP   | Y            | T            |        | Test     | ** The name of the files created are ** | TESTAUTOM.TPE | MAIL_TESTAUTOM.TPE | 42407       | 11/08/2015      | SB003            | C             | 10092      | 400.00        | SB02         | 05/08/15    | DIV1           | DIVIDEND        | 400.00       |            |             | 400.00      | 400.00      |           |            | 400.00     | 013-100  | 210000        |

@winformsTest
@OL_Online
@ANZ_AUTO
@26701
@OL_PAT_PaymentTransactions
@FullSmokeTest
Scenario Outline: TestCase26701_REPCP_ErrorValidation
###Test Case 26701: 04 - OLS110, OLS120, and OLS124 | Replacement Cheque Transactions  -  Error validation on OLS11002 for REPCP ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
		And In OLS15001 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS11001 I continue with the following details:
		| RecnRequired   | ChequeFormat   | FileName   | Origin   |
		| <RecnRequired> | <ChequeFormat> | <FileName> | <Origin> |
		And I Transmit
		And In OLS11002 I continue with the following details:
		| TransNumber   | ReplacementDate   | PayAccountNumber   | PaymentMethod   | PayOrigRef   | PaymentAmount   |
		| <TransNumber> | <ReplacementDate> | <PayAccountNumber> | <PaymentMethod> | <PayOrigRef> | <PaymentAmount> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | Selection | SelCode | RecnRequired | ChequeFormat | Origin | FileName | TransNumber | ReplacementDate | PayAccountNumber | PaymentMethod | PayOrigRef | PaymentAmount | ErrorMessage                                         |
	| Test1 | PAY       | REPCP   | Y            | T            |        | Test1    | 42408       | 11/08/2015      | SB003            | C             | 10077      |               | Cannot use REPCP for Payment Status of Returned      |
	#| Test2 | PAY       | REPCP   | Y            | T            |        | Test2    | 42408       | 11/08/2015      | SB003            | C             | 10078      |               | This Payment is for 704.20                           |
	#| Test3 | PAY       | REPCP   | Y            | T            |        | Test3    | 42408       | 11/08/2015      | SB003            | D             | 10078      |               | No Payment for this method/reference on this account |
	#| Test4 | PAY       | REPCP   | Y            | T            |        | Test4    | 42408       | 11/08/2015      | SB003            | C             | 18         |               | No Payment for this method/reference on this account |  


#@ignore
#@OL_Online
#@DIV_AUTO
#@OL_PAT_PaymentTransactions
#Scenario Outline: GEDCR_DEMO
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_AUTO"
#		And In MNS00101 I click on: "online data entry system" within the System Menu
#		And In OLS00101 I Click on: "payment transactions" with in the online data entry system menu
#		And In OLS15001 I continue with the following details:
#		| Selection   |
#		| <Selection> |
#		And In SELTRN20 I continue with the following details:
#		| SelCode   |
#		| <SelCode> |
#		And In OLS20101 I continue with the following details:
#		| PayAccountNumber   |
#		| <PayAccountNumber> |
#
#
#	Examples: 
#	| Test  | Selection | SelCode | PayAccountNumber |
#	| Test1 | PAY       | RPLAC   | X0025954556      |