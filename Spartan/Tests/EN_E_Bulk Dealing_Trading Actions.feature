Feature: EN_E_Bulk Dealing_Trading Actions
	Ensure N_E_Bulk Dealing_Trading Actions functionality covered

@winformsTest
@EnquiryTest
@CPU_AUTO 
@EN_Bulk_Dealing_Trading_Actions 
@18006
@FullSmokeTest
Scenario: Test Case 18006: 01_DLH Dealing History Transaction Action
	# Enquiry System -Action DLH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007487"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DLH   |
			| Locate Argument |       |
	Then In ENS01048 I should see Dealing History details as below:
			| Field | Value                                                                           |
			| HIN   | I0100007487                                                                     |
			| Line1 | DEP 10A              DEP0001410   11747803  12/07/10  15:31            DLGAD  P |
			| Line2 | DLGRG                                                                           |
			| Line3 | DEP0001414   11759202  12/08/10  11:23            DLGAD  P                      |
			| Line4 | DLGRG                                                                           |
			| Line5 | DEP0001420   11806120  13/09/10  12:20            DLGAD  P                      |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	Then In ENS01048 I should see Dealing History details as below:
			| Field | Value                                                                        |
			| HIN   | I0100007487                                                                  |
			| Line1 | DEP 10A              DEP0001440   11848312                             DLGRG |
			| Line2 | DEP0001445   11858873  14/02/11  12:54            DLGAD  P                   |
			| Line3 | DLGRG                                                                        |
			| Line4 | DEP0001450   11906721  15/03/11  12:02            DLGAD  P                   |
			| Line5 | DLGRG                                                                        |

@winformsTest
@EnquiryTest
@Bug
@CPU_AUTO 
@EN_E_Bulk_Dealing_Trading_Actions 
@17994
Scenario: Test Case 17994: 01_Pending Transactions -PT
	# Enquiry System -Action PT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007487"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PT    |
			| Locate Argument |       |
	Then In ENSTRD47 I should see Pending Trading Transactions as below:
			| Field          | Value                                                      |
			| HIN            | I0100007487                                                |
			| Pending Trade1 | DEP Sale         2DEF0004629 12606658           100.000000 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENSTRD57 I should see Reservation Extra Details as below:
			| Field | Value                                   |
			| Line1 | 23/04/15                Audited    0000 |

@winformsTest
@EnquiryTest
@CPU_AUTO 
@EN_E_Bulk_Dealing_Trading_Actions 
@ViewTradeHistDetails
Scenario: View Trading History Details
	# Enquiry System -Action THD
	Given I have connected to WinForms
 	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007479"
		And I enter the following details as the Locate action:
			| Field           | Value                            |
			| Action          | THD                              |
			| Locate Argument | I0100007479/1DEF0000122/00003030 |
	Then In ENSTRDSH I expect to see the following in the Trade history screen for "Sell Partial"
		| Field           | Value             |
		| Holder          | I0100007479       |
		| Sell Units      | 200.000000        |
		| Final Price     | 10.000000         |
		| Gross Amount    | 2000.00           |
		| Charges         | 84.50             |
		| Net Amount      | 1908.55           |
		| Payment Date    | 03/03/2015        |
		| Currency        | AUD               |
		| Currency Desc   | AUSTRALIAN DOLLAR |
		| Trade Date      | 03/03/2015        |
		| Settlement Date | 03/03/2015        |

@winformsTest
@EnquiryTest
@CPU_AUTO 
@EN_E_Bulk_Dealing_Trading_Actions 
@17994
Scenario: Test Case 17994: 01_Pending Transactions -PEND)
	# Enquiry System -Action PEND
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007487"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PEND  |
			| Locate Argument |       |
	Then In ENS01047 I should see Pending Transactions as below:
			| Field               | Value                                                                              |
			| HIN                 | I0100007487                                                                        |
			| Pending Transaction | DEP 10A 20100712EM   2DEF0004629  12606658 23/04/15                        100-  R |

@winformsTest
@EnquiryTest
@CPU_AUTO 
@18013 
@EN_E_Bulk_Dealing_Trading_Actions
Scenario Outline: Test Case 18013: 02_TH Trading History Transaction Action
	# Enquiry System -Action TH
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | TH    |
			| Locate Argument |       |	   
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	 	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"				
	Then In ENSTRDSH  I should see Trading History as "<HIN>" "<Type>" "<ID>" "<Tran>" "<TradingStatus>" "<Units>" "<Money>" "<Class>" "<UnitsSold>" "<FinalPrice>" "<GrossAmount>" "<PurchaseRes>" "<Loan>" "<Options>" "<Charges>" "<GST>" "<TAX>" "<NetAmount>"
		And In ENSTRDSH  I should see Trading History Charge details as "<TradeDate>" "<SettlementDate>" "<ChargeCode1>" "<ChargeCode2>" "<ChargeCode3>" "<ChargeCode4>" "<ChargeCode5>" "<ChargeCode6>" "<ChargeDesc1>" "<ChargeDesc2>" "<ChargeDesc3>" "<ChargeDesc4>" "<ChargeDesc5>" "<ChargeDesc6>" "<Charge1>" "<Charge2>" "<Charge3>" "<PaidByFlag1>" "<PaidByFlag2>"
		And In ENSTRDSH  I should see Trading History Payment details as "<PaymentDate>" "<PayRefNumber>" "<PaymentAccount>" "<CurrencyCode>" "<CurrencyDesc>" "<PaymentMethod>" "<BankCode>" "<AccountNbr>" "<AccountName>"
		And In ENSTRDSH  I should see Trading History Summary of Charges as "<PaidbyHolder>" "<GSTTaxApply>" "<PaidbyCoy>" "<ReportOnly>" "<TotalCharges>" "<TotalGST>"
		And In ENSTRDSH  I should see Trading History Remaining Balance Details as "<RemBal>" "<RemBalDesc>" "<ToHolder>" "<TransferClass>" "<TransferReg>" "<TransferCertID>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENSTRDSC I should see Certificate details as "<Register>" "<CertificateID>" "<Units>" "<AwardPrice>" "<FinalPrice>" "<GainLoss>"

Examples: 
		| HIN         | Line1                                                                                            | Line2                                                                                            | Line3                                                                                            | Line4                                                                                            | Line5                                                                                            | Action | LocateArgument | Type | ID          | Tran     | TradingStatus | Units        | Money     | Class | UnitsSold    | FinalPrice | GrossAmount | PurchaseRes | Loan   | Options   | Charges | GST    | TAX | NetAmount | TradeDate  | SettlementDate | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeCode4 | ChargeCode5 | ChargeCode6 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3    | ChargeDesc4    | ChargeDesc5    | ChargeDesc6    | Charge1 | Charge2 | Charge3 | PaidByFlag1 | PaidByFlag2 | PaymentDate | PayRefNumber | PaymentAccount | CurrencyCode | CurrencyDesc      | PaymentMethod  | PaidbyHolder | GSTTaxApply | PaidbyCoy | ReportOnly | TotalCharges | TotalGST | Register | CertificateID | AwardPrice | GainLoss  | COY       | BankCode | AccountNbr         | AccountName         | RemBal    | RemBalDesc | ToHolder    | TransferClass | TransferReg | TransferCertID |
		| I0100007479 | DEP Sale     1DEF0000122  00003030 03/03/15 Set          200.000000       1908.55      10.000000 |                                                                                                  |                                                                                                  |                                                                                                  |                                                                                                  | 01     |                | EMP  | 1DEF0000122 | 3030     | Settled       | 200.000000   | 1908.55   | DEP   | 200.000000   | 10.000000  | 2000.00     |             |        |           | 84.50   | 6.95   |     | 1908.55   | 03/03/2015 | 03/03/2015     | CBRC        | CPMC        | CWIR        | CDCR        | CLCQ        | CFCQ        | Broker      | Commission  | Wire           | Direct Banking | Local Cheque   | Foreign Cheque | 9.50    | 60.00   | 15.00   | A           | A           | 03/03/2015  | 3739         | TSSAL          | AUD          | AUSTRALIAN DOLLAR | Cheque/Unpres  | 84.50        | 6.95        |           |            | 84.50        | 6.95     | 02A      | 20020603EM    | 2.002400   | 1599.52   | CPU_AUTO |          |                    |                     |           |            |             |               |             |                |
		| I0030244044 | OPT Sale     OPTE0000001  00554592 07/03/13 Set        66667.000000     177792.25      10.229375 | DEP Sale     2DEF0003814  12338085 07/03/13 Set          206.000000       2096.87      10.360000 | OPT Sale     OPTM0000006  00577482 17/12/12 Set        20000.000000      22878.09       8.703051 | OPT Sale     OPTM0000005  00577481 07/12/12 Set        10000.000000      12302.83       8.789620 | DEP Sale     2DEF0003677  12259206 07/12/12 Set          685.000000       5919.71       8.710000 | 01     |                | IND  | OPTE0000001 | 554592   | Settled       | 66667.000000 | 177792.25 | OPT   | 66667.000000 | 10.229375  | 681961.74   |             |        | 502669.18 | 1363.92 | 136.39 |     | 177792.25 | 04/03/2013 | 07/03/2013     | CBPB        | CWIR        | CDCR        | CLCQ        | CFCQ        |             | Broker      | Wire        | Direct Banking | Local Cheque   | Foreign Cheque |                | 1363.92 |         |         | A           | A           | 07/03/2013  | 6588         | TSSAL          | AUD          | AUSTRALIAN DOLLAR | Direct Banking | 1363.92      | 136.39      |           |            | 1363.92      | 136.39   | 09A      | 20090130EE    | 7.540000   | 179292.56 | CPU_AUTO | 124-001  | 000000000010345679 | YI KIBYAF & KI VIBC |           |            |             |               |             |                |
		| I0030153839 | ELA Sale     3ELA0000528  57006712 04/02/11 Set           10.000000         14.34      24.640000 |                                                                                                  |                                                                                                  |                                                                                                  |                                                                                                  | 01     |                | STF  | 3ELA0000528 | 57006712 | Settled       | 28.000000    | 14.34     | ELA   | 10.000000    | 24.640000  | 246.40      |             | 168.56 |           | 63.50   |        |     | 14.34     | 01/02/2011 | 04/02/2011     | CBRK        | CPMM        | CWIR        | CDCR        | CLCQ        | CFCQ        | Broker      | Commission  | Wire           | Direct Banking | Local Cheque   | Foreign Cheque | 9.50    | 53.50   | .50     | A           | A           | 04/02/2011  | 80513        | TSSAL          | AUD          | AUSTRALIAN DOLLAR | Cheque/Unpres  | 63.50        |             |           |            | 63.50        |          | 99A      | 19991112ER    | 24.010000  | 17.64     | NAB_AUTO |          |                    |                     | 18.000000 | Issuer     | I0030153839 | ORD           | VIC         | UC             |

@winformsTest
@EnquiryTest
@CPU_AUTO 
@18015 
@EN_E_Bulk_Dealing_Trading_Actions
Scenario Outline: Test Case 18015: 03_THD Trading  History Details Action
	# Enquiry System -Action THD
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>" 	
	Then In ENSTRDSH  I should see Trading History as "<HIN>" "<Type>" "<ID>" "<Tran>" "<TradingStatus>" "<Units>" "<Money>" "<Class>" "<UnitsSold>" "<FinalPrice>" "<GrossAmount>" "<PurchaseRes>" "<Loan>" "<Options>" "<Charges>" "<GST>" "<TAX>" "<NetAmount>"
		And In ENSTRDSH  I should see Trading History Charge details as "<TradeDate>" "<SettlementDate>" "<ChargeCode1>" "<ChargeCode2>" "<ChargeCode3>" "<ChargeCode4>" "<ChargeCode5>" "<ChargeCode6>" "<ChargeDesc1>" "<ChargeDesc2>" "<ChargeDesc3>" "<ChargeDesc4>" "<ChargeDesc5>" "<ChargeDesc6>" "<Charge1>" "<Charge2>" "<Charge3>" "<PaidByFlag1>" "<PaidByFlag2>"
		And In ENSTRDSH  I should see Trading History Payment details as "<PaymentDate>" "<PayRefNumber>" "<PaymentAccount>" "<CurrencyCode>" "<CurrencyDesc>" "<PaymentMethod>" "<BankCode>" "<AccountNbr>" "<AccountName>"
		And In ENSTRDSH  I should see Trading History Summary of Charges as "<PaidbyHolder>" "<GSTTaxApply>" "<PaidbyCoy>" "<ReportOnly>" "<TotalCharges>" "<TotalGST>"
		And In ENSTRDSH  I should see Trading History Remaining Balance Details as "<RemBal>" "<RemBalDesc>" "<ToHolder>" "<TransferClass>" "<TransferReg>" "<TransferCertID>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENSTRDSC I should see Certificate details as "<Register>" "<CertificateID>" "<Units>" "<AwardPrice>" "<FinalPrice>" "<GainLoss>"

Examples: 
		| HIN         | Action | LocateArgument                   | Type | ID          | Tran     | TradingStatus | Units        | Money     | Class | UnitsSold    | FinalPrice | GrossAmount | PurchaseRes | Loan   | Options   | Charges | GST    | TAX | NetAmount | TradeDate  | SettlementDate | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeCode4 | ChargeCode5 | ChargeCode6 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3    | ChargeDesc4    | ChargeDesc5    | ChargeDesc6    | Charge1 | Charge2 | Charge3 | PaidByFlag1 | PaidByFlag2 | PaymentDate | PayRefNumber | PaymentAccount | CurrencyCode | CurrencyDesc      | PaymentMethod  | PaidbyHolder | GSTTaxApply | PaidbyCoy | ReportOnly | TotalCharges | TotalGST | Register | CertificateID | AwardPrice | GainLoss  | COY      | BankCode | AccountNbr         | AccountName         | RemBal    | RemBalDesc | ToHolder    | TransferClass | TransferReg | TransferCertID |
		| I0100007479 | THD    | I0100007479/1DEF0000122/00003030 | EMP  | 1DEF0000122 | 3030     | Settled       | 200.000000   | 1908.55   | DEP   | 200.000000   | 10.000000  | 2000.00     |             |        |           | 84.50   | 6.95   |     | 1908.55   | 03/03/2015 | 03/03/2015     | CBRC        | CPMC        | CWIR        | CDCR        | CLCQ        | CFCQ        | Broker      | Commission  | Wire           | Direct Banking | Local Cheque   | Foreign Cheque | 9.50    | 60.00   | 15.00   | A           | A           | 03/03/2015  | 3739         | TSSAL          | AUD          | AUSTRALIAN DOLLAR | Cheque/Unpres  | 84.50        | 6.95        |           |            | 84.50        | 6.95     | 02A      | 20020603EM    | 2.002400   | 1599.52   | CPU_AUTO |          |                    |                     |           |            |             |               |             |                |
		| I0030244044 | THD    | I0030244044/OPTE0000001/00554592 | IND  | OPTE0000001 | 554592   | Settled       | 66667.000000 | 177792.25 | OPT   | 66667.000000 | 10.229375  | 681961.74   |             |        | 502669.18 | 1363.92 | 136.39 |     | 177792.25 | 04/03/2013 | 07/03/2013     | CBPB        | CWIR        | CDCR        | CLCQ        | CFCQ        |             | Broker      | Wire        | Direct Banking | Local Cheque   | Foreign Cheque |                | 1363.92 |         |         | A           | A           | 07/03/2013  | 6588         | TSSAL          | AUD          | AUSTRALIAN DOLLAR | Direct Banking | 1363.92      | 136.39      |           |            | 1363.92      | 136.39   | 09A      | 20090130EE    | 7.540000   | 179292.56 | CPU_AUTO | 124-001  | 000000000010345679 | YI KIBYAF & KI VIBC |           |            |             |               |             |                |
		| I0030153839 | THD    | I0030153839/3ELA0000528/57006712 | STF  | 3ELA0000528 | 57006712 | Settled       | 28.000000    | 14.34     | ELA   | 10.000000    | 24.640000  | 246.40      |             | 168.56 |           | 63.50   |        |     | 14.34     | 01/02/2011 | 04/02/2011     | CBRK        | CPMM        | CWIR        | CDCR        | CLCQ        | CFCQ        | Broker      | Commission  | Wire           | Direct Banking | Local Cheque   | Foreign Cheque | 9.50    | 53.50   | .50     | A           | A           | 04/02/2011  | 80513        | TSSAL          | AUD          | AUSTRALIAN DOLLAR | Cheque/Unpres  | 63.50        |             |           |            | 63.50        |          | 99A      | 19991112ER    | 24.010000  | 17.64     | NAB_AUTO |          |                    |                     | 18.000000 | Issuer     | I0030153839 | ORD           | VIC         | UC             |


