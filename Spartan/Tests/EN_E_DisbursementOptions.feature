Feature: EN_E_DisbursementOptions
	Ensure EN_E_DisbursementOptions functionality covered

@winformsTest
@EnquiryTest
@CPU_AUTO
@17471
@EN_E_DisbursementOptions
Scenario: Test Case 17471: 02_Disbursement Types – DSR actions
	# Enquiry System -Action DSR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "X0026378389"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DSR   |
			| Locate Argument |       |
	Then In ENSDIS01 I should see Disbursements details as below:
			| Field          | Value                          |
			| HIN            | X0026378389                    |
			| Type           | JNT                            |
			| Key            | YSONHESLT   KIFUP VIMY  NIXGAB |
			| NameAddress1   | MR KIFUP VIMY YSONHESLT +      |
			| NameAddress2   | MRS RIMCEQIL KZUNABGO          |
			| PI             | DC/AUD                         |
			| Date           | 17/09/13                       |
			| Method         | Reinv                          |
			| Reference      | 00701256                       |
			| PaidAmount     | 16.10                          |
			| PaidCurrency   | AUD                            |
			| BaseCurrency   | AUD                            |
			| Status         | Presented                      |
			| PressDate      | 17/09/13                       |
			| PaymentAccount | SEP13                          |
			| PayType        | DIVIDEND                       |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 01    |
			| Locate Argument |       |
	Then In ENSDIV02 I should see Dividend History Brief as below:
			| Field          | Value                      |
			| HIN            | X0026378389                |
			| PaymentCode    | DIVP                       |
			| ASXCAType      | D                          |
			| DivDesc        | (DIVIDEND)                 |
			| PaymentDate    | 17/09/2013                 |
			| Source         | D                          |
			| PayAccount     | SEP13                      |
			| ReferenceNbr   | 701256                     |
			| TaxCodeAUS     |                            |
			| TaxCode        |                            |
			| CalcCurrency   | AUD                        |
			| Gross          | 16.10                      |
			| Net            | 16.10                      |
			| PaidCurreny    | AUD                        |
			| PaymentDetail1 | ** Reinvestment Details ** |
			| PaymentDetail2 | Cert #...: UNCERT'D        |
			| PaymentDetail3 | Reg......: VIC             |
			| PaymentDetail4 | MONEY b/f:       0.00      |
			| PaymentDetail5 | MONEY c/f:       6.36      |
			| PaymentDetail6 | Allotted.:          1      |
			| PaymentDetail7 | Price....:   9.740000      |
			| SubPayCode     | DIVP                       |
			| SubPaymentType | D                          |
			| SubPayDesc     | (DIVIDEND)                 |
			| SubPayGross    | 16.10                      |
			| SubPayTax      |                            |
			| SubPayNett     | 16.10                      | 
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 01    |
			| Locate Argument |       |	
	Then In ENSDIV03 I should see Dividend History Component as below:				
			| Field            | Value                |
			| HIN              | X0026378389          |
			| PaymentCode      | DIVP                 |
			| Source           | D                    |
			| SubPayCode       | DIVP                 |
			| SubPaymentType   | D                    |
			| SubPayDesc       | (DIVIDEND)           |
			| PaymentAccount   | SEP13                |
			| PaymentDate      | 17/09/2013           |
			| ComponentDesc1   | AUS Franking Credit  |
			| ComponentAmount1 | 1.38                 |
			| ComponentDesc2   | AUS Franked (Dividen |
			| ComponentAmount2 | 3.22                 |
			| ComponentDesc3   | AUS Unfranked Foreig |
			| ComponentAmount3 | 12.88                |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | CT    |
			| Locate Argument |       |			
	Then In ENSDIV04 I should see Dividend Sub Payment Summary as below:				
			| Field             | Value       |
			| HIN               | X0026378389 |
			| PaymentCode       | DIVP        |
			| Source            | D           |
			| SubPayCode        | DIVP        |
			| PaymentAccount    | SEP13       |
			| SubPaymentType    | D           |
			| SubPayDesc        | (DIVIDEND)  |
			| SubPaymentAccount | SEP13       |
			| PaymentDate       | 17/09/2013  |
			| Class             | FP          |
			| CatCode           | 5           |
			| ASXCode           | CPU         |
			| DetailUnits       | 115         |
			| PaymentRate       | 0.14000000   |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSDIV05 I should see Dividend History Class Components as below:
			| Field            | Value                |
			| HIN              | X0026378389          |
			| PaymentCode      | DIVP                 |
			| Source           | D                    |
			| SubPayCode       | DIVP                 |
			| PaymentAccount   | SEP13                |
			| SubPaymentType   | D                    |
			| SubPayDesc       | (DIVIDEND)           |
			| Class            | FP                   |
			| CatCode          | 5                    |
			| ASXCode          | CPU                  |
			| ComponentDesc1   | AUS Franking Credit  |
			| ComponentAmount1 | 1.38                 |
			| ComponentDesc2   | AUS Franked (Dividen |
			| ComponentAmount2 | 3.22                 |
			| ComponentDesc3   | AUS Unfranked Foreig |
			| ComponentAmount3 | 12.88                |
		And I close Winforms

@winformsTest
@EnquiryTest
@DIV_A
@17467
@EN_E_DisbursementOptions
Scenario Outline: Test Case 17467: 01_Disbursement Types –actions
	# Enquiry System -Action DSC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSDIS01 I should see Disbursements details as "<Date>" "<Method>" "<Reference>" "<PaidAmount>" "<PaidCurrency>" "<BaseCurrency>" "<Status>" "<PaymentAccount>" "<PayType>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 02    |
			| Locate Argument |       |	
	Then In ENSDIV02 I should see Dividend History Brief as	"<PaymentCode>"	"<ASXCAType>" "<DivDesc>" "<PaymentDate>" "<Source>" "<PayAccount>" "<ReferenceNbr>" "<CalcCurrency>" "<Gross>" "<Net>" "<PaidCurreny>" "<PaymentDetail1>" "<SubPayCode>" "<SubPaymentType>" "<SubPayDesc>"	"<SubPayGross>" "<SubPayNett>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 01    |
			| Locate Argument |       |	
	Then In ENSDIV03 I should see Dividend History Component as "<PaymentCode>" "<Source>" "<SubPayCode>" "<SubPaymentType>" "<SubPayDesc>" "<PayAccount>" "<PaymentDate>" "<ComponentDesc1>" "<ComponentAmount1>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | CT    |
			| Locate Argument |       |			
	Then In ENSDIV04 I should see Dividend Sub Payment Summary as "<PaymentCode>" "<Source>" "<SubPayCode>" "<PayAccount>" "<SubPaymentType>" "<SubPayDesc>" "<PaymentDate>" "<Class>" "<DetailUnits>" "<PaymentRate>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
		Then In ENSDIV05 I should see Dividend History Class Components as "<PaymentCode>" "<Source>" "<SubPayCode>" "<PayAccount>" "<SubPaymentType>" "<SubPayDesc>" "<PaymentDate>" "<Class>" "<ClassDesc>" "<ComponentDesc1>" "<ComponentAmount1>"
		And I close Winforms

Examples: 
		| Action | LocateArgument | HIN         | Date     | Method | Reference | PaidAmount | PaidCurrency | BaseCurrency | Status      | PaymentAccount | PayType      | PaymentCode | ASXCAType | DivDesc       | PaymentDate | Source | PayAccount | ReferenceNbr | CalcCurrency | Gross     | Net       | PaidCurreny | PaymentDetail1                 | SubPayCode | SubPaymentType | SubPayDesc        | SubPayGross | SubPayNett | ComponentDesc1       | ComponentAmount1 | Class | DetailUnits | PaymentRate | ClassDesc                 |
		| DSC    |                | X0010703719 | 06/06/16 | Chq    | 00001458  | 200.00     | AUD          | AUD          | Unpresented | NBK01          | DIVIDEND     | 0111        | D         | (DIVIDEND)    | 22/05/2015  | D      | DV100      | 2466         | AUD          | 20000.00  | 20000.00  | AUD         | ** Paid directly by cheque **  | DIV1       | D              | (DIVIDEND)        | 20000.00    | 20000.00   | AUS Franked (Dividen | 20000.00         | FP    | 2000        | 10.00000000 | ORDINARY SECURITY         |
		| DSF    |                | I0030012071 | 06/06/16 | F/Chq  | 00000578  | 600.00     | JPY          | AUD          | Unpresented | NBK01          | DIVIDEND     | 0111        | D         | (DIVIDEND)    | 22/05/2015  | D      | DV100      | 533          | AUD          | 60000.00  | 60000.00  | JPY         | *** Paid by Foreign Cheque *** | DIV1       | D              | (DIVIDEND)        | 60000.00    | 60000.00   | AUS Franked (Dividen | 60000.00         | FP    | 6000        | 10.00000000 | ORDINARY SECURITY         |
		| DS     |                | I0030002911 | 06/06/16 | Chq    | 00000001  | 1408.04    | GBP          | AUD          | Unpresented | NBKG1          | DIVIDEND     | 0111        | D         | (DIVIDEND)    | 22/05/2015  | D      | DV100      | 367          | AUD          | 213340.00 | 213340.00 | GBP         | *** Paid by Foreign Cheque *** | DIV1       | D              | (DIVIDEND)        | 213340.00   | 213340.00  | AUS Franked (Dividen | 213340.00        | FP    | 21334       | 10.00000000 | ORDINARY SECURITY         |

@winformsTest
@EnquiryTest
@DIV_A
@17471
@EN_E_DisbursementOptions
Scenario: Test Case 17471: 02_Disbursement Types – DSD actions
	# Enquiry System -Action DSD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system for "X0010703719"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DSD   |
			| Locate Argument |       |
	Then In ENSDIS01 I should see Disbursements details as below:
			| Field          | Value                          |
			| HIN            | X0010703719                    |
			| Type           | COY                            |
			| Key            | XE          NOZBERI&ASSOCIATES |
			| NameAddress1   | X E NOZBERI & ASSOCIATES PTY   |
			| NameAddress2   | LTD,                           |
			| PI             |                                |
			| Date           | 05/12/05                       |
			| Method         | D/Cr                           |
			| Reference      | 00008738                       |
			| PaidAmount     | 100.00                         |
			| PaidCurrency   | AUD                            |
			| BaseCurrency   | AUD                            |
			| Status         | Failed                         |
			| PressDate      | 14/03/08                       |
			| PaymentAccount | SAD03                          |
			| PayType        | DIVIDEND                       |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 01    |
			| Locate Argument |       |
	Then In ENS01011 I should see Manual Journal as below:
			| Field                | Value                                                                                                           |
			| Name Key             | XE          NOZBERI&ASSOCIATES                                                                                  |
			| HIN                  | X0010703719                                                                                                     |
			| Name                 | X E NOZBERI & ASSOCIATES PTY                                                                                    |
			| Address              | LTD,                                                                                                            |
			| Pay Account Number   | SAD03                                                                                                           |
			| Pay Account Desc     | DECEMBER 2005 DIVIDEND TEST - DRP                                                                               |
			| Transaction Details1 | 00008738D           3342/00000022 14/03/08  DCRFM/DIRECT CREDIT FAILURE (MANUAL)  P Dasari-------------(WINFRM) |
			| Transaction Details2 |                                                                                                                 |
		And I close Winforms


#@DIV_A
#@17486
#@EN_E_DisbursementOptions
#Scenario Outline: Test Case 17486: 02_Disbursements -Action 
#	# Enquiry System -Action DSO/DSP
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And I go to the Enquiry system and Search <HIN>
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENSDIS01 I should see Disbursements details as "<Date>" "<Method>" "<Reference>" "<PaidAmount>" "<PaidCurrency>" "<BaseCurrency>" "<Status>" "<PaymentAccount>" "<PayType>"
#	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
#	Then In ENS01011 I should see Manual Journal as "<HIN>" "<PayAccountNbr>" "<PayAccountDesc>" "<Tran1>" "<Tran2>"
#		And I close Winforms
#Examples: 
#		| Action | LocateArgument | HIN         | Date     | Method | Reference | PaidAmount | PaidCurrency | BaseCurrency | Status     | PaymentAccount | PayType  | PayAccountNbr | PayAccountDesc | Tran1                                                                                                           | Tran2                                                                                                           | Action1 | LocateArgument1 |
#		| DSO    |                | I0030142471 | 03/03/15 | Chq    | 00000002  | 0.70       | AUD          | AUD          | Client Rec | USD03          | DIVIDEND | MIT0R         | TEST MIT       | 00000002  00000101  3735/00000100 17/06/13  REPCP/REPLACEMENT CHEQUE WITH PRINT   B Chirgwin-----------(WINFRM) | 00080000            3528/00000001 28/10/10  RPTAX/REPAY WITHOLDING TAX            B Chirgwin-----------(WINFRM) | 03      |                 |
#		| DSP    |                | I0030001575 | 30/10/06 | D/Cr   | 99999999  | 4.40       | AUD          | AUD          | R/Pending  | REC01          | INTEREST | REC01         | TEST RECN      | 00000034  99999999D 3206/09887789 Pending/  REDCR/REPLACE PAYMENT WITH DCREDIT    UNKNOWN MESSAGE ID --(WINFRM) |                                                                                                                 | 01      |                 |
#
#@DIV_A
#Scenario Outline: Test Case 17488*: 04_ Disbursements -action
#	# Enquiry System -Action LDS
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "NAB_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENSDIS01 I should see Disbursements details as "<Date>" "<Method>" "<Reference>" "<PaidAmount>" "<PaidCurrency>" "<BaseCurrency>" "<Status>" "<PaymentAccount>" "<PayType>"
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | 01    |
#			| Locate Argument |       |	
#	Then In ENSDIV02 I should see Dividend History Brief as	"<PaymentCode>"	"<ASXCAType>" "<DivDesc>" "<PaymentDate>" "<Source>" "<PayAccount>" "<ReferenceNbr>" "<CalcCurrency>" "<Gross>" "<Net>" "<PaidCurreny>" "<PaymentDetail1>" "<SubPayCode>" "<SubPaymentType>" "<SubPayDesc>"	"<SubPayGross>" "<SubPayNett>"
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | 01    |
#			| Locate Argument |       |	
#	Then In ENSDIV03 I should see Dividend History Component as "<PaymentCode>" "<Source>" "<SubPayCode>" "<SubPaymentType>" "<SubPayDesc>" "<PaymentAccount>" "<PaymentDate>" "<ComponentDesc1>" "<ComponentAmount1>"
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | CT    |
#			| Locate Argument |       |			
#	Then In ENSDIV04 I should see Dividend Sub Payment Summary as "<PaymentCode>" "<Source>" "<SubPayCode>" "<PaymentAccount>" "<SubPaymentType>" "<SubPayDesc>" "<PaymentDate>" "<Class>" "<DetailUnits>" "<PaymentRate>"
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | 1     |
#			| Locate Argument |       |
#		Then In ENSDIV05 I should see Dividend History Class Components as "<PaymentCode>" "<Source>" "<SubPayCode>" "<PaymentAccount>" "<SubPaymentType>" "<SubPayDesc>" "<PaymentDate>" "<Class>" "<ClassDesc>" "<ComponentDesc1>" "<ComponentAmount1>"
#
#Examples: 
#		| Action | LocateArgument  | Date     | Method | Reference | PaidAmount | PaidCurrency | BaseCurrency | Status     | PaymentAccount | PayType      | PaymentCode | ASXCAType | DivDesc       | PaymentDate | Source | PayAccount | ReferenceNbr | CalcCurrency | Gross     | Net       | PaidCurreny | PaymentDetail1                 | SubPayCode | SubPaymentType | SubPayDesc        | SubPayGross | SubPayNett | ComponentDesc1       | ComponentAmount1 | Class | DetailUnits | PaymentRate | ClassDesc                 |
#		| LDS    | DIV141/638668   | 07/04/09 | Chq    | 00739492  | 17.86      | AUD          | AUD          | Presented  | DRP09          | CAPITAL REPY | DRP1        | C         | (CAPITAL REPY | 07/04/2009  | D      | DRP09      | 739492       | AUD          | 17.86     | 17.86     | AUD         | ** Paid directly by cheque **  | DRP1       | C              | (CAPITAL REPYMNT) | 17.86       | 17.86      | Residual Payment (DR | 17.86            | RES   | 1786        | 0.01000000  | Company class not on file |
#
#
#@DIV_A
#Scenario Outline: Test Case 18199: 01_DSP action - Pending Replacements, Notes and Employee Disposal
#	# Enquiry System -Action DSP
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And I go to the Enquiry system and Search <HIN>
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENSDIS01 I should see Disbursements details as "<Date>" "<Method>" "<Reference>" "<PaidAmount>" "<PaidCurrency>" "<BaseCurrency>" "<Status>" "<PaymentAccount>" "<PayType>"
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | PH1   |
#			| Locate Argument |       |
#	Then In ENSPND01 I should see Payment Replacement step summary as "<HIN>" "<PaymentAccount>" "<PayReference>" "<PayMethodTo>" "<PaidAmount>" "<PaidCurrency>"
#	Then In ENSPND01 I should see Payment Replacement Steps as "<Step1>" "<Step2>" "<Step3>" "<Step4>" "<Step5>" "<Step6>" "<Step7>" "<Step8>" "<Step9>" "<Step10>" "<Step11>" "<Step12>" "<Step13>"
#	Then In ENSPND01 I should see Payment Replacement Step Status as "<StepStatus1>" "<StepStatus2>" "<StepStatus3>" "<StepStatus4>" "<StepStatus5>" "<StepStatus6>" "<StepStatus7>" "<StepStatus8>" "<StepStatus9>" "<StepStatus10>" "<StepStatus11>" "<StepStatus12>" "<StepStatus13>"
#	Then In ENSPND01 I should see Payment Replacement Audit Dates as "<AuditDate1>" "<AuditDate2>" "<AuditDate3>" "<AuditDate4>" "<AuditDate5>" "<AuditDate6>" "<AuditDate7>" "<AuditDate8>" "<AuditDate9>" "<AuditDate10>" "<AuditDate11>" "<AuditDate12>" "<AuditDate13>"
#	Then In ENSPND01 I should see Payment Replacement Note Description as "<Note1>" "<Not2>" "<Note3>" "<Note4>" "<Note5>" "<Note6>" "<Note7>" "<Note8>" "<Note9>" "<Note10>" "<Note11>" "<Note12>" "<Note13>"	
#	When In ENSPND01 I enter the following details as the Locate action:
#			| Field  | Value |
#			| Action | N     |
#			| Step   | 2     |
#	Then In ENSPND02 I should see Payment Replacement Step Notes as "<HIN>" "<StepCode>" "<Notetext1>" "<Notetext2>" "<AuditUser>" "<AuditDate>"
#
#Examples: 
#	| HIN         | Action | LocateArgument | Date     | Method | Reference | PaidAmount | PaidCurrency | BaseCurrency | Status    | PaymentAccount | PayType  | PayReference | PayMethodTo | Step1     | Step2     | Step3    | Step4     | Step5      | Step6      | Step7   | Step8     | Step9     | Step10     | Step11     | Step12     | Step13     | StepStatus1 | StepStatus2 | StepStatus3 | StepStatus4 | StepStatus5 | StepStatus6 | StepStatus7 | StepStatus8 | StepStatus9 | StepStatus10 | StepStatus11 | StepStatus12 | StepStatus13 | AuditDate1 | AuditDate2 | AuditDate3 | AuditDate4 | AuditDate5 | AuditDate6 | AuditDate7 | AuditDate8 | AuditDate9 | AuditDate10 | AuditDate11 | AuditDate12 | AuditDate13 | Note1                                              | Not2 | Note3 | Note4 | Note5 | Note6 | Note7 | Note8 | Note9 | Note10 | Note11 | Note12 | Note13 | StepCode  | Notetext1                                                 | Notetext2              | AuditUser  | AuditDate  |
#	| I0000001333 | DSP    |                | 07/07/13 | Chq    | 00000001  | 1.00       | AUD          | AUD          | R/Pending | 0707D          | DIVIDEND | 1            | ***         | STARTSTEP | PAYMETHOD | DECEASED | STOPTRADE | ADDRCHANGE | RETURNMAIL | FEEPAID | DISSENTER | UNCLAIMED | REPPAYDATE | STOPCHQREQ | STPCONFIRM | HIVALUESTP | Complete    | On Hold     | Complete    | Complete    | Complete    | Complete    | Complete    | Complete    | Complete    | Complete     | ~            | ~            | ~            | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015 | 09/06/2015  |             |             |             | Payment method unresolved. Release hold for Direct |      |       |       |       |       |       |       |       |        |        |        |        | PAYMETHOD | Payment method unresolved. Release hold for Direct Credit | or Override for Cheque | R Kothakon | 09/06/2015 |
#
#	
#@BHP_AUTO
#Scenario Outline: Test Case 20186: 02_Pending Replacements where DIV Type is E
#	# Enquiry System -Action DS
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "BHP_AUTO"
#		And I go to the Enquiry system and Search <HIN>
#		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
#	Then In ENSDIS01 I should see Disbursements details Part1 as "<Date1>" "<Date2>" "<Date3>" "<Date4>" "<Date5>" "<Method1>" "<Method2>" "<Method3>" "<Method4>" "<Method5>" "<Reference1>" "<Reference2>" "<Reference3>" "<Reference4>" "<Reference5>"
#	Then In ENSDIS01 I should see Disbursements details Part2 as "<PaidAmount1>" "<PaidAmount2>" "<PaidAmount3>" "<PaidAmount4>" "<PaidAmount5>" "<PaidCurrency1>" "<PaidCurrency2>" "<PaidCurrency3>" "<PaidCurrency4>" "<PaidCurrency5>" "<BaseCurrency1>" "<BaseCurrency2>" "<BaseCurrency3>" "<BaseCurrency4>" "<BaseCurrency5>"   
#	Then In ENSDIS01 I should see Disbursements details Part3 as "<Status1>" "<Status2>" "<Status3>" "<Status4>" "<Status5>" "<PaymentAccount1>" "<PaymentAccount2>" "<PaymentAccount3>" "<PaymentAccount4>" "<PaymentAccount5>" "<PayType1>" "<PayTyp2>" "<PayType3>" "<PayType4>" "<PayType5>"
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | 01    |
#			| Locate Argument |       |
#	Then In ENSSPLED I should see Dividend History Part1 as "<HIN>" "<Type>" "<EmpStatus>" "<PayrollID>" "<Class>" "<TotalUnits>" "<PayAccount>" "<Reference>" "<PayMethod>" "<BulkID>" "<BulkTran>" "<TradeDate>" "<SettleDate>" "<Price>" "<CostShares>" "<Charges>" "<TotalProceeds>" "<AmtPaid>" "<Commission>" 
#	Then In ENSSPLED I should see Dividend History Part2 as "<Register1>" "<Register2>" "<Units1>" "<Units2>" "<Proceeds1>" "<Proceeds2>" "<Income1>" "<Income2>"
#		 
#Examples: 
#	| HIN         | Action | LocateArgument | Date1    | Date2    | Date3    | Date4    | Date5    | Method1 | Method2 | Method3 | Method4 | Method5 | Reference1 | Reference2 | Reference3 | Reference4 | Reference5 | PaidAmount1 | PaidAmount2 | PaidAmount3 | PaidAmount4 | PaidAmount5 | PaidCurrency1 | PaidCurrency2 | PaidCurrency3 | PaidCurrency4 | PaidCurrency5 | BaseCurrency1 | BaseCurrency2 | BaseCurrency3 | BaseCurrency4 | BaseCurrency5 | Status1    | Status2    | Status3    | Status4    | Status5    | PaymentAccount1 | PaymentAccount2 | PaymentAccount3 | PaymentAccount4 | PaymentAccount5 | PayType1     | PayTyp2      | PayType3     | PayType4     | PayType5     | Type | EmpStatus | PayrollID   | Class | TotalUnits | PayAccount | Reference | PayMethod | BulkID     | BulkTran | TradeDate  | SettleDate | Price     | CostShares | Charges | TotalProceeds | AmtPaid  | Commission | Register1 | Register2 | Units1 | Units2 | Proceeds1 | Proceeds2 | Income1 | Income2 |
#	| I0204152349 | DS     |                | 07/07/09 | 17/03/09 | 22/02/09 | 25/09/08 | 18/03/08 | Chq     | Chq     | Chq     | Chq     | Chq     | 01000261   | 00001481   | 01000144   | 00001512   | 00001316   | 11424.89    | 271.63      | 2558.43     | 125.25      | 45.01       | AUD           | ZAR           | AUD           | ZAR           | ZAR           | AUD           | ZAR           | AUD           | ZAR           | ZAR           | Client Rec | Client Rec | Client Rec | Client Rec | Client Rec | JSE07           | JSE09           | JSE08           | JSEE8           | 08JSX           | CAPITAL REPY | CAPITAL REPY | CAPITAL REPY | CAPITAL REPY | CAPITAL REPY | IND  | LEAVER    | ZARRICHARDS | JSE   | 65         | JSE07      | 1000261   | Cheque    | JSA0001280 | 551082   | 02/07/2009 | 07/07/2009 | 181.00000 | 11765.00   | 340.11  | 11424.89      | 11424.89 | 340.11     | 07A       | 08A       | 39     | 26     | 6854.95   | 4569.94   | 6854.95 | 4569.94 |
#
#
#@DIV_A
#Scenario: Test Case 20195: 03_Error messages - Pending Replacements
#	# Enquiry System -Action Error
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And I go to the Enquiry system for "I0000001333"
#		And I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | DDA   |
#			| Locate Argument |       |	
#	Then I expect to see error with text "Invalid Action."
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | DSF   |
#			| Locate Argument |       |	
#	Then I expect to see error with text "There are no payment details for this holder."
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | DSP   |
#			| Locate Argument |       |		
#	Then I expect to be in the "ENSDIS01" Screen
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | 01    |
#			| Locate Argument |       |	
#	Then I expect to be in the "ENS01011" Screen	
#	When I PressESC
#	Then I expect to be in the "ENSDIS01" Screen	
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | PH01  |
#			| Locate Argument |       |	
#	Then I expect to be in the "ENSPND01" Screen		
#	When In ENSPND01 I enter the following details as the Locate action:
#			| Field  | Value |
#			| Action | X     |
#			| Step   |       |	
#	Then I expect to see error with text "Invalid Action."
#	When In ENSPND01 I enter the following details as the Locate action:
#			| Field  | Value |
#			| Action | N     |
#			| Step   | 1     |	
#	Then I expect to see error with text "Selection specified does not have a note"	
#	When In ENSPND01 I enter the following details as the Locate action:
#			| Field  | Value |
#			| Action | N     |
#			| Step   | 15    |
#	Then I expect to see error with text "Selection specified does not exist"	
#	
#	
#	
#	
#	
#	
#	
#	
#	
#	
#	
#
# 
#
#
#
#
