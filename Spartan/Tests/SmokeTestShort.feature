Feature: SmokeTestShort
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@winformsTest
@EnquiryTest
@SmokeTest
@FullSmokeTest
Scenario: Test Case 17348: 01_Employee Search (EA,ED,ES,ESS) -ED
	# Enquiry System -Action ED
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0070036924"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ED    |
			| Locate Argument |       |
	Then In ENSESS01 I should see full holder Employee Details as below:
		| Field                  | Value                    |
		| HIN                    | I0070036924              |
		| Type                   | IND                      |
		| Name                   | TRANSACTION CODE TEST 2, |
		| Address1               | TEST AUTOMATION          |
		| Address2               | ABBOTSFORD               |
		| Postcode               | 3000                     |
		| AutoForfeit            | Y                        |
		| BirthDate              | 01/01/2001               |
		| Leavercode             | EEE                      |
		| LeaverCodeDesc         | E DEFAULT                |
		| BlackoutRestricted     | Y                        |
		| BlackoutRestrictedCode | DE                       |
		| BlackoutRestrictedDesc | DESIGNATED EMPLOYEES     |
		| PayrollID              | AUS                      |
		| EmployeeID             | 0070036924               |
		| SubPayrollID           |                          |
		| EmployeeUniqueID       | 70036924                 |
		| EmployeeStatus         | E                        |
		| EmployeeStatusDesc     | CURRENT EMPLOYEE         |
		| EffectiveDate          | 11/05/2015               |
		| LeaverPack             | N                        |
		| LeaverPackSentDate     | No date                  |
		| TerminationDate        | 01/01/2015               |
		| TerminationDesc        | 15/05/2015               |
		| PreferredName          | SALMAN                   |
		| LocationCode           | AUS                      |
		| BusinessUnit           | AUS                      |
		| JobBand                | AUS                      |
		| CostCentre             | MEL                      |
		| EmployeeFlag1          | D                        |
		| EmployeeFlag2          | F                        |
		| GSPEmployee            | N                        |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PID   |
			| Locate Argument |       |
	Then In ENSESS17 I should see Payroll Identifier Parameters as below:
		| Field       | Value                             |
		| PayrollID   | AUS                               |
		| PayrollDesc | AUSTRALIA NAB EMPLOYEES           |
		| PayeeName1  | COMPUTERSHARE TECHNOLOGY SERVICES |
		| PayeeName2  | COMPUTERSHARE TECHNOLOGY SERVICES |
		| Name        | COMPUTERSHARE TECHNOLOGIES        |
		| Address1    | 452 JHONSTON ST, ABBOTSFOED       |
		| Address2    | 452 JHONSTON ST, ABBOTSFOED       |
		| Address3    | 452 JHONSTON ST, ABBOTSFOED       |
		| Address4    | 452 JHONSTON ST, ABBOTSFOED       |
		| Address5    | 452 JHONSTON ST, ABBOTSFOED       |
		| Address6    | 452 JHONSTON ST, ABBOTSFOED       |
		| Postcode    | 3000                              |

@winformsTest
@SmokeTest
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 34316: 2_GRT. Manual Grant of Options -EX
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And I go to the Grant Options Menu for "<MenuItem>"
		And I go to the Manual Grant of Options Menu "<RegisterCode>"
		And In EOL00901 I Add Grant details as "<AppropDate>" "<TransNumber>" "<TotalUnits>" "<GrantCountry>" "<SearchName>"
	Then In EOL00905 I should see Buyer details as "<ClassCode>" "<RegisterCode>" "<RegisterDesc>" "<RegisterType1>" "<Units1>" "<Money1>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS26 I should see Future Vesting Details as "<ClassCode>" "<PlanDesc>" "<LineF1>" "<LineF2>" "<LineF3>" "<LineF4>"
	When I enter the following details as the locatActions "<Action2>"  "<LocateArgument>"
	Then In ENSESS25 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<TLine1>" "<TLine2>" "<TLine3>" 

Examples: 
	| Test  | ClassCode | MenuItem | RegisterCode | AppropDate | TransNumber | TotalUnits | GrantCountry | SearchName  | RegisterDesc | RegisterType1 | Units1 | Money1  | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2 | BLine3                                                                                                    | BLine4 | Action1 | LineF1                                                                                                        | LineF2 | LineF3 | LineF4 | Action2 | TLine1                                                                                                                          | TLine2                                                                       | TLine3                                                                       |
	| Test1 | OPT       | EX       | 14A          | 01/02/2014 | 3132002     | 1000       |              | I0032044964 | 14A BONUS    | Bonus Optn    | 1000   | 5000.00 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 14A EX   01/02/2014 HK Def         1000        1000           0        1000           0           0           0           0 |        | ** Totals        1000        1000           0        1000           0           0           0           0 |        | ESOTF   | 14A EX   01/02/2014     D01       HK Def        1000           01/02/2019           0           0        1000 |        |        |        | ESOT    | 14A EX  01/02/14     D01       HK Def        1000  01/     01/01/15         250           0           0           0        1000 | 02/     01/04/15         250           0           0           0        1000 | 03/     01/07/15         250           0           0           0        1000 |

@winformsTest
@SmokeTest
@ESSPurchase
@FullSmokeTest
Scenario Outline: Deferred Plan Manual Purchase EP
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### Add Savings ####
		And In EOL00113 I click on "awards" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		And In EOL00114 I continue with the following values:
		| Selection    |
		| <Selection1> |
		And In EOL00901 I Add Savings amount as:
		| TransNumber   | TransDate   | TotalMoney   | TotalUnits   | PaymentFrequency   | ResidualInd   | GrantCountry   | RetentionDate   | TaxRetentionDate   | SearchName   |
		| <TransNumber> | <TransDate> | <TotalMoney> | <TotalUnits> | <PaymentFrequency> | <ResidualInd> | <GrantCountry> | <RetentionDate> | <TaxRetentionDate> | <SearchName> |
		And In EOL00905 I continue with the following values:
		| RegisterType1   | Money1   | PaymentFrequency   | RetentionDate    | TaxRetentionDate    |
		| <RegisterType1> | <Money1> | <PaymentFrequency> | <RetentionDate1> | <TaxRetentionDate1> |
		And I Escape to the Main Menu from Employee Processing
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### Add Payments #####
		And In EOL00113 I click on "payments" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		And In EOL00120 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In EOL01901 I Add Manual Payment as:
		| TransNumber    | PaymentFrequency    | AccumPeriod   | PaymentNumber   | PaymentStatus   | Eol01901ReceiptCurrency   | PaymentDate   | PaymentAmount   | EmployerPymtAmt   | Eol01901ExchangeRate   | SearchName   |
		| <TransNumberM> | <PaymentFrequencyM> | <AccumPeriod> | <PaymentNumber> | <PaymentStatus> | <Eol01901ReceiptCurrency> | <PaymentDate> | <PaymentAmount> | <EmployerPymtAmt> | <Eol01901ExchangeRate> | <SearchName> |
		And In EOL01902 I verify the following values:
		| AccumPeriod   | PaymentNumber   | PaymentFrequency   | RegisterType   | PaymentAmount   | Eol01902EmpBaseCurr   |
		| <AccumPeriod> | <PaymentNumber> | <PaymentFrequency> | <RegisterType> | <PaymentAmount> | <Eol01902EmpBaseCurr> |
		And I Escape to the Main Menu from Employee Processing
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### Release to Dealing System ####		
		And In EOL00113 I click on "releases" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		And In EOL00106 I continue with the following values:
		| Selection    |
		| <Selection3> |
		And In EOLBLK05 I continue with the following values:
		| PayFreq1   | AccumPeriodFrom1   | AccumPeriodTO1   | PayFreq2   | AccumPeriodFrom2   | AccumPeriodTO2   | PayFreq3   | AccumPeriodFrom3   | AccumPeriodTO3   | ReleaseMode   |
		| <PayFreq1> | <AccumPeriodFrom1> | <AccumPeriodTO1> | <PayFreq2> | <AccumPeriodFrom2> | <AccumPeriodTO2> | <PayFreq3> | <AccumPeriodFrom3> | <AccumPeriodTO3> | <ReleaseMode> |
		And In EOLBLK04 I continue with the following values:
		| ConfirmRelType   |
		| <ConfirmRelType> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I Escape to the Main Menu from Employee Processing
		#### Bulk Processing ####
		And I go to the Bulk Processing System and select Bulk code as:
		| BulkCode   |
		| <BulkCode> |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection   |
		| <MenuSelection> |
		#### Change Bulk Status ####
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode   | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus   |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatus> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement   | ConfirmFinalPrice   |
		| <ConfirmSettlement> | <ConfirmFinalPrice> |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection1> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode1> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatus1> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement   | ConfirmFinalPrice   |
		| <ConfirmSettlement> | <ConfirmFinalPrice> |		
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection2> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate   |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode1> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatus2> | <AwardDate> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement   | ConfirmFinalPrice   |
		| <ConfirmSettlement> | <ConfirmFinalPrice> |
		And In OLSB0404 I verify the following values:
		| TotalCount   | TotalUnits   | SettlementDate   | FinalPrice   | UnitsCalc   | CostOFShares   | TotalCost   | ResidueKept   | ResidueRefunded   | TaxONCharges   | AccumCharges   |
		| <TotalCount> | <TotalUnits1> | <SettlementDate> | <FinalPrice> | <UnitsCalc> | <CostOFShares> | <TotalCost> | <ResidueKept> | <ResidueRefunded> | <TaxONCharges> | <AccumCharges> |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection5> |
		#### Generate Cheques ####
		And In OLSB0105 I continue with the following values:
		| BulkCurrency   | SettlementFrom   | SettlementTO   |
		| <BulkCurrency> | <SettlementFrom> | <SettlementTO> |
		And In OLSB0106 I continue with the following values:
		| BulkID1   | Currency1   | SettlementDate1   | ProcessBulkInd1   | BulkID2   | Currency2   | SettlementDate2   | ProcessBulkInd2   | BulkID3   | Currency3   | SettlementDate3   | ProcessBulkInd3   |
		| <BulkID1> | <Currency1> | <SettlementDate1> | <ProcessBulkInd1> | <BulkID2> | <Currency2> | <SettlementDate2> | <ProcessBulkInd2> | <BulkID3> | <Currency3> | <SettlementDate3> | <ProcessBulkInd3> |
		And In OLSB0104 I verify the following values:
		| HomeBankDesc   | AusTraceAccount   |
		| <HomeBankDesc> | <AusTraceAccount> |
		And In OLSB0101 I continue with the following values:
		| PaymentAccount   | OrderNO   | Ident   | NbrBulks   | SettlementFrom   | SettlementTO   | PaymentDate    | AddConvRateInd   |
		| <PaymentAccount> | <OrderNO> | <Ident> | <NbrBulks> | <SettlementFrom> | <SettlementTO> | <PaymentDate1> | <AddConvRateInd> |
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I PressESC
		#### Force Bulk Settlement ####
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection6> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection3> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode     | ChargeCode1    | ChargeCode2    | ChargeCode3    | ChargeDesc1    | ChargeDesc2    | ChargeDesc3    | ConfirmStatus    | AwardDate    |
		| <SettlementDateS> | <TradeDateS> | <TradeTimeS> | <IndicativePriceS> | <FinalPriceS> | <RegisterCode1S> | <ChargeCode1S> | <ChargeCode2S> | <ChargeCode3S> | <ChargeDesc1S> | <ChargeDesc2S> | <ChargeDesc3S> | <ConfirmStatus3> | <AwardDateS> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement   | ConfirmFinalPrice   |
		| <ConfirmSettlement> | <ConfirmFinalPrice> |
		#### Bulk Transaction Enquiry ####	
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection7> |
		And In BLKSCH01 I continue with the following values:
		| BulkID   | Status   | RegisterCode   | TransCount   | TransTotal   | SettlementDate    |
		| <BulkID> | <Status> | <RegisterCode> | <TransCount> | <TransTotal> | <SettlementDate3> |
		And In OLSB1010 I verify the following values:
		| BulkID   | StatusDesc   | BulkCount   | BulkUnits   | TransUnits   | BulkMoney   | TransMoney   | TranTypeParent   | HolderID     | RegisterCode   |
		| <BulkID> | <StatusDesc> | <BulkCount> | <BulkUnits> | <TransUnits> | <BulkMoney> | <TransMoney> | <TranTypeParent> | <SearchName> | <RegisterCode> |
		#### Bulk Process Enquiry ####	
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection8> |
		And In BLKSCH01 I continue with the following values:
		| BulkID   | Status   | RegisterCode   | TransCount   | TransTotal   | SettlementDate    |
		| <BulkID> | <Status> | <RegisterCode> | <TransCount> | <TransTotal> | <SettlementDate3> |
		And In BLKSCH02 I verify the following values:
		| BulkType   | BulkTypeDesc   | ClassCode   | TotalCount   | BulkTransUnits   | BulkTransMoney   | RegisterCode   | SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | ActionM   |
		| <BulkType> | <BulkTypeDesc> | <ClassCode> | <TotalCount> | <BulkTransUnits> | <BulkTransMoney> | <RegisterCode> | <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <ActionM> |
		And In BLKSCH03 I verify the following values:
		| FinalPrice   | UnitsCalc   | CostOFShares   | TotalCost   | ResidueKept   | ResidueRefunded   | PaymentAccount   | BankType   | BankCode   | AccountNumber   |
		| <FinalPrice> | <UnitsCalc> | <CostOFShares> | <TotalCost> | <ResidueKept> | <ResidueRefunded> | <PaymentAccount> | <BankType> | <BankCode> | <AccountNumber> |
		And I Escape to the Main Menu from Bulk Processing
		#### Holder Enquiry ####		
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |

Examples: 
	| Test  | COY      | ClassCode | Selection | RegisterCode | Selection1 | TransNumber | TransDate  | TotalMoney | TotalUnits | PaymentFrequency | ResidualInd | GrantCountry | RetentionDate | TaxRetentionDate | SearchName  | RegisterType1 | Money1  | RetentionDate1 | TaxRetentionDate1 | Selection2 | TransNumberM | PaymentFrequencyM | AccumPeriod | PaymentNumber | PaymentStatus | Eol01901ReceiptCurrency | PaymentDate | PaymentAmount | EmployerPymtAmt | Eol01901ExchangeRate | RegisterType | Eol01902EmpBaseCurr | Selection3 | PayFreq1 | AccumPeriodFrom1 | AccumPeriodTO1 | PayFreq2 | AccumPeriodFrom2 | AccumPeriodTO2 | PayFreq3 | AccumPeriodFrom3 | AccumPeriodTO3 | ReleaseMode | ConfirmRelType | BulkCode | Selection4 | MenuSelection | SettlementDate | TradeDate  | TradeTime | IndicativePrice | FinalPrice | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3 | ConfirmStatus | ConfirmSettlement | ConfirmFinalPrice | MenuSelection1 | ConfirmStatus1 | MenuSelection2 | ConfirmStatus2 | AwardDate  | RegisterCode1 | TotalCount | TotalUnits1 | UnitsCalc | CostOFShares | TotalCost | ResidueKept | ResidueRefunded | TaxONCharges | AccumCharges | Selection5 | BulkCurrency | SettlementFrom | SettlementTO | BulkID1 | Currency1 | SettlementDate1 | ProcessBulkInd1 | BulkID2 | Currency2 | SettlementDate2 | ProcessBulkInd2 | BulkID3 | Currency3 | SettlementDate3 | ProcessBulkInd3 | HomeBankDesc | AusTraceAccount | PaymentAccount | OrderNO | Ident | NbrBulks | PaymentDate1 | AddConvRateInd | Selection6 | MenuSelection3 | SettlementDateS | TradeDateS | TradeTimeS | IndicativePriceS | FinalPriceS | RegisterCode1S | ChargeCode1S | ChargeCode2S | ChargeCode3S | ChargeDesc1S | ChargeDesc2S | ChargeDesc3S | ConfirmStatus3 | AwardDateS | Selection7 | BulkID | Status  | TransCount | TransTotal | StatusDesc | BulkCount | BulkUnits | TransUnits | BulkMoney | TransMoney | TranTypeParent | Selection8 | BulkType | BulkTypeDesc | BulkTransUnits | BulkTransMoney | ActionM | BankType | BankCode | AccountNumber | Action | LocateArgument | CertificateLine1                 | CertificateLine2                        | CertificateLine3                             | CertificateLine4 | CertificateLine5 | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | CPU_AUTO | DEP       | EP        | 13A          | ASA        | 67350       | 01/07/2013 | 2500       |            | M                |             |              |               |                  | I0030313364 | Partnership   | 2500.00 | Unchanged      | Unchanged         | MAN        | 67351        | M                 | 1           | 1             | C             |                         | 02/07/2013  | 250.00        |                 |                      | Part         | AUD                 | RPH        | M        | 1                | 1              |          |                  |                |          |                  |                | B           | AWP            | DEP      | CBS        | B             | 03/07/2013     | 03/07/2013 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | B             | 03/07/2013        | 10                | A              | A              | C              | C              | 12/07/2013 |               | 1          | 250.00      | 25        | 250.00       | 250.00    |             |                 |              |              | GCB        | AUD          | 03/07/2013     | 03/07/2013   |         | AUD       | 03/07/2013      | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | DP13A          | 5555    | NDF   | 1        |              | N              | FBS        | S              |                 |            |            |                  |             |                |              |              |              |              |              |              | S              |            | BTQ        |        | SETTLED | 1          | 250.00     | Settled    | 1         | 25        | 25         | 250.00    | 250.00     | ESAWP          | BPE        | P        | PURCHASE     | 25             | 250.00         | M       |          |          |               | C      | /DEP/13A       | DEP/DEFERRED EMP SHARE PLAN - AU | 13A 20130712EP   12/07/13            25 | **** Total for 20130712EP                 25 |                  |                  |                  |                  |                  |                  |                   |

@winformsTest
@ESSPurchase
@SmokeTest
Scenario Outline: Options Plan Bulk Purchase EE
### input file: ESSUPLOPT.CSV ###
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### INT. Health & Integrity Check ####
		And In EOL00107 I Click on "grant options" Menu
		And In EOL00137 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		And In EOL00109 I continue with the following values:
		| Selection    |
		| <Selection1> |
		And In EOL00116 I continue with the following values:
		| AppropDate   |
		| <AppropDate> |
		And In EOL00501 I continue with the following values:
		| InputFilename   | NameSelection   | PCSelection   | AddressMatching   | AllowBlankAddress   | UpdateAddrDetails   | UpdateEmpDetails   | AutoGenEmpUnqID   | ClearEmpUnqID   | UpdateContactDets   | UploadTfn   | UpdateMandates   | UpdateDrp   | RunTrnedt   | CreateNewAccounts   | ReportFullTotals   | AutoFtpReportsInd   |
		| <InputFilename> | <NameSelection> | <PCSelection> | <AddressMatching> | <AllowBlankAddress> | <UpdateAddrDetails> | <UpdateEmpDetails> | <AutoGenEmpUnqID> | <ClearEmpUnqID> | <UpdateContactDets> | <UploadTfn> | <UpdateMandates> | <UpdateDrp> | <RunTrnedt> | <CreateNewAccounts> | <ReportFullTotals> | <AutoFtpReportsInd> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600     | error        |
	When I read Timestamps from the Health and Integrity file as:
		| COY   | FileName   |
		| <COY> | <FileName> |
		And I Escape to the Main Menu from Employee Processing
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "grant options" Menu
		And In EOL00137 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		#### UPL. Bulk Upload Process ####
		And In EOL00109 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In EOL00116 I continue with the following values:
		| AppropDate   |
		| <AppropDate> |
		And In EOL00601 I continue with the following values:
		| Timestamp   | ReportFullTotals   | AutoFtpReportsInd   | Confirm   |
		| <Timestamp> | <ReportFullTotals> | <AutoFtpReportsInd> | <Confirm> |
		And In EOL00602 I continue with the following values:
		| ReportHeading   | ReportDate   | ReportSequence   |
		| <ReportHeading> | <ReportDate> | <ReportSequence> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600     | error        |
		And I Escape to the Main Menu from Employee Processing
		#### Holder Enquiry ####		
		And I go to the Enquiry system and Search <HolderID1>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2A> | <CertificateLine3A> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |
	When I enter the following details as the locatActions "<Action1>"  "<HolderID2>"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2B> | <CertificateLine3B> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |	

Examples: 
	| Test  | COY      | ClassCode | Selection | RegisterCode | Selection1 | AppropDate | InputFilename | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Selection2 | Timestamp | Confirm | ReportHeading       | ReportDate | ReportSequence | HolderID1   | Action | LocateArgument | CertificateLine1A         | CertificateLine2A                       | CertificateLine3A                            | CertificateLine4A | CertificateLine5A | CertificateLine6A | CertificateLine7A | CertificateLine8A | CertificateLine9A | CertificateLine10A | Action1 | HolderID2   | CertificateLine2B                       | CertificateLine3B                            |
	| Test1 | CPU_AUTO | OPT       | EE        | 10B          | INT        | 04/06/2010 | ESSUPLOPT.CSV | F             | N           | Y               | N                 | N                 | Y                | N               | N             | Y                 | N         | N              | N         | Y         | N                 | F                | Y                 |          | UPL        |           | C       | Bulk Upload Process |            | A              | I0030024354 | C      | /OPT/10B/EE    | OPT/EMPLOYEE OPTIONS PLAN | 10B 20100604EE   04/06/10          1000 | **** Total for 20100604EE               1000 |                   |                   |                   |                   |                   |                   |                    | S       | I0013454361 | 10B 20100604EE   04/06/10          2000 | **** Total for 20100604EE               2000 |


@winformsTest
@SmokeTest
@OL_Online
@FullSmokeTest
Scenario Outline: TestCase25506_PAYMV
###Test Case 25506: 07 - OLS100, 101, 102, 103, 105 and 107 | Payment Transactions - PAYMV Cannot move payment to the original holder ####
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
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Test  | Selection | SelCode | TransNumber | TransDate  | PayAccountNumber | PaymentMethod | PayRefNumber | PaymentAmount | NewHolderNameKey | PayOrigHolderIdent | ErrorMessage             |
	| Test1 | PAY       | PAYMV   | 42371       | 08/04/2016 | INT15            | D             | 850902       | 5045.41       | I0130398871      | I0130398871        | Holder ID's are the same |

@winformsTest
@SmokeTest
@OL_STD_StandardTransactions
@FullSmokeTest
Scenario Outline: Test Case 30262 OLSCRT CONSOLIDATE CERTIFICATE Transaction
##Test Case 30262: 01 - OLSCRT | CONSC - CONSOLIDATE CERTIFICATE Transaction - Combine shares on one certificate ####
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
		| <TransferUnits> | <BuyTransDate1> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SellHolderID>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holdings details as below "<Line1>" "<Line2>" "<Line3>" "<Line4>"	

Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | Action | LocateArgument | Line1                                                                    | Line2 | Line3 | Line4 | SellBroker | BuyReference | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 |
	| Test1 | CONSC   | 422321      | 2550       | ORD       |            | C0000465932  | VIC     | W152444   | W152445   | W152446   | W152447   | W152448   | 300        | 500        | 500        | 500        | 750        |               |              |           |                  |                  |                  |                  |                  | H      | /ORD           | *ORD/ORDINARY SHARES         VIC          3300                      3300 |       |       |       |            |              |                  |                  |                    |                    |             |               |            |                   |                    |                  | 

@AESSPlanSales
@TS_TradingSystem
@SmokeTest
@FullSmokeTest
Scenario Outline: Deferred Real Time Sale SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		#And I go to "Company Options" Control Code Menu
		#And In HKS01516 I set the Multi-Cert Flag to "<Multi-Cert>"
		And I go to "Trading Control Codes" Control Code Menu
		And In TRD24000 I select the Trade Control Code "<tradeControlCode>"
		And In TRD24001 I perform a Change for On Market Trade "<OnMarketTrade>", "<BrokerCode>", "<BrokerAccountID>", "<ConnectionCode>", "<RealTimeTrading>" and Top Up "<TopupPercentage>", "<SellSelected>" and Remaining Balance Options "<Option>", "<TranType>", "<Class>", "<Reg>" and World Link Number "<WorldLinkNumber>"
		And I go to the Trading system Sales and trade control code "<tradeControlCode>"
		And In TRS00501 I Add Postal Transaction Entry details as "<SearchName>" 
		And In TRS00502 I Add Postal Transaction Entry details as "<SellOption>" "<Units>" "<PaymentMethod>" "<PrefCurrency>" "<NotificationReqdInd>" "<Balance>" "<AvailBalance>"	
		And In TRS00507 I Add Postal Transaction Entry details as "<SellAll01>" "<Units01>" "<SellAll02>" "<Units02>" "<SellAll03>" "<Units03>" "<SellAll04>" "<Units04>" "<SellAll05>" "<Units05>" "<SellAll06>" "<Units06>" "<SellAll07>" "<Units07>" "<SellAll08>" "<Units08>" "<SellAll09>" "<Units09>"
		And In TRS00511 I Add Postal Transaction Entry details as "<DurationType>" "<EstMarketValue>"
		And In TRS00513 I Add Postal Transaction Entry details as "<Cover01>" "<Cover02>" "<Cover03>" "<Cover04>" "<Cover05>" "<Cover06>" "<Cover07>" "<Cover08>" "<Cover09>" "<Cover10>" "<Cover11>" "<Cover12>" "<Cover13>" "<Cover14>" "<Cover15>"
		And In TRS00504 I Verify Postal Transaction Entry details as "<UnitsSell>" "<EstMarketValue>" "<MarketValue>" "<PurchResidueAmt>" "<FederalTaxWithheld>" "<LoanAmt>" "<ChargeAmount1>" "<ChargeAmount2>" "<ChargeAmount3>" "<TotalGst>" "<EstimatedProceeds>"
		And In TRS00512 I Add Postal Transaction Entry details as "<OverrideEmailInd>" "<EmailAddress>"
		And In TRS00503 I Add Postal Transaction Entry details as "<ConfirmUnits>" "<ConfirmWarningFlag5>"
		And In TRD00401 I Change Order Status to "<MenuSelection>" "<ConfirmStatus>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<SettlementDate>" "<FinalPrice>"
	Then In TRD004CS I Verify Change Order Status details1 as "<UnitsTraded>" "<TotalCost>" "<FinalPrice>" "<TradePrice>" "<PriceATAudit>" "<GrossAmount>" "<PurchaseResidue>" "<HolderCharges1>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>"
		And In TRD004CS I Verify Change Order Status details2 as "<LocalChqCount>" "<LocalChqNettAmount>" "<ForeignChqCount>" "<ForeignChqNettAmt>" "<WireCount>" "<WireNettAmount>" "<DirectBankingCount>" "<DirectBankNettAmt>" "<EmployerCount>" "<EmployerNettAmount>" "<CompanyCharges>" "<CompanyTax>" "<HolderCharges>" "<HolderTax>" "<ReportCharges>" "<ReportTax>" "<BankType>" "<BranchNumber>" "<AccountNumber>"
	When In TRD00101 I Run the Generate Output Job as "<PaymentAccount1>" "<OrderNO>" "<Ident>" "<ClassCode>" "<NbrTrades>" "<TradeGrossAmount>" "<TradeFrom>" "<TradeTO>" "<SettlementFrom>" "<SettlementTO>"
		And I wait for  GenerateOutput job to complete
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 240     | error        | DONE            | EXIT            |
		And In TRD00401 I Force Settle the Order as "<MenuSelection1>" "<ConfirmStatus1>"
	Then In TRS01010 I Verify Transaction Enquiry details as "<TradingID>" "<Status>" "<Price>" "<ClassCode>" "<TransCount>" "<TransTotal>" "<MoneyTotal>" "<SettlementDate>" "<ApplyTaxInd>" "<PaymentMethod>" "<PaymentMethodDesc>" "<Currency>" "<SellUnits>" "<OrderType>" "<TradeUnits>" "<TransMoney>"
		And In TRDSCH02 I Verify Transaction Enquiry details as "<TradingID>" "<BulkType>" "<BulkTypeDesc>" "<StatusDesc>" "<TotalCount>" "<OrderTransUnits>" "<TotalMoney>" "<TradeDate>" "<ReqdSettlementDate>" "<ActualSettlementDate>" "<FinalPrice>" "<ReconciliationCode>" "<CshtrnReference>" "<MinimumDeal>" "<MaximumDeal>" "<CutOffTime>" "<CounterpartyClass>" "<CounterRegisterCode>" "<OrderType1>"
		And In TRDSCHCS I Verify Transaction Enquiry details1 as "<UnitsTraded>" "<TotalCost>" "<FinalPrice>" "<PriceATAudit>" "<GrossAmount>" "<PurchaseResidue>" "<HolderCharges1>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>"
		And In TRDSCHCS I Verify Transaction Enquiry details2 as "<LocalChqCount>" "<LocalChqNettAmount>" "<ForeignChqCount>" "<ForeignChqNettAmt>" "<WireCount>" "<WireNettAmount>" "<DirectBankingCount>" "<DirectBankNettAmt>" "<EmployerCount>" "<EmployerNettAmount>" "<CompanyCharges>" "<CompanyTax>" "<HolderCharges>" "<HolderTax>" "<ReportCharges>" "<ReportTax>" "<BankType>" "<BranchNumber>" "<AccountNumber>"
		And I go the Main Menu From Trading System
	#Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the Locate action:
				| Field           | Value |
				| Action          | TH    |
				| Locate Argument | /ATS  |	 
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<Units1>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"
Examples: 
		| SaleType    | COY       | OnMarketTrade | BrokerCode | BrokerAccountID | ConnectionCode | RealTimeTrading | TopupPercentage | SellSelected | Option | TranType | Class | Reg | WorldLinkNumber | SearchName  | SellOption | Units | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance    | AvailBalance | DurationType | EstMarketValue | UnitsSell | MarketValue | PurchResidueAmt | FederalTaxWithheld | LoanAmt | ChargeAmount1 | ChargeAmount2 | ChargeAmount3 | TotalGst | EstimatedProceeds | OverrideEmailInd | EmailAddress                    | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | TotalUnits | UnitsTraded | TotalCost | FinalPrice | TradePrice | PriceATAudit | GrossAmount | PurchaseResidue | HolderCharges1 | LoanAmount | OptionCost | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | LocalChqCount | LocalChqNettAmount | ForeignChqCount | ForeignChqNettAmt | WireCount | WireNettAmount | DirectBankingCount | DirectBankNettAmt | EmployerCount | EmployerNettAmount | CompanyCharges | CompanyTax | HolderCharges | HolderTax | ReportCharges | ReportTax | PaymentAccount | BankType | BranchNumber | AccountNumber | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits | OrderType     | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal        | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1                                                                                            | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | PaymentDate | CurrencyDesc | PaymentMethod1 | TotalCharges | GstTaxTotal | BankCode | PayeeAccountNumber | AccountName     | Cover01 | Cover02 | Cover03 | Cover04 | Cover05 | Cover06 | Cover07 | Cover08 | Cover09 | Cover10 | Cover11 | Cover12 | Cover13 | Cover14 | Cover15 | Units1     | SellAll01 | Units01 | SellAll02 | Units02 | SellAll03 | Units03 | SellAll04 | Units04 | SellAll05 | Units05 | SellAll06 | Units06 | SellAll07 | Units07 | SellAll08 | Units08 | SellAll09 | Units09 | RemainingBalance | RemBalIndDesc | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits | TransMoney |
		| SelltoCover | NAB2_AUTO | M             | 3383       | CLS.GAP         | ORMSAUUAT      | Y               | 0.00            | Y            | C      | ESTSC    | ORD   | VIC | 123451234       | I0035312021 | C          |       | W             |              | E                   | 688.000000 | 688.000000   | 1            | 30.00          | 5.000000  | 150.00      |                 |                    |         | .45           | 100.00        | 10.00         | 10.05    | 29.50             | N                | RI.W.WI._test@computershare.com |              | Y                   | C             | C             | 20/08/2015 | 10          | 00          | 20/08/2015     | 688.000000 | 5.000000    | 150.00    | 30.000000  | 30.000000  | 30.000000    | 150.00      |                 | 110.45         |            |            | 10.05 |             | 29.50      | .45            | 100.00         | 10.00          |                |                |                |               |                    |                 |                   | 1         | 29.50          |                    |                   |               |                    |                |            | 110.45        | 10.05     |               |           |                |          |              |               | TSSAL           | ATS3    | NDF   | ATS       | 1         | 688.000000       |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 688.000000 | 29.50      | Y           | Wire              | USD      | 5.000000  | Sell to Cover | S        | SALE         | Settled    | 1          | 688.000000      | 29.50      | 20/08/2015         | 20/08/2015           | ESSOPT             | 1540            | 1.000000    | 99999999999.000000 | 10:00      | ORD               | VIC                 | Market     | ATS Sale     ATSR0000003  79269000 20/08/15 Set            5.000000         29.50      30.000000 |       |       |       |       | 01     |                | 20/08/2015  | US DOLLAR    | Wire           | 110.45       | 10.05       |          | 12345678           | TEST AUTOMATION | Y       | Y       | Y       | Y       | Y       | Y       | Y       |         |         |         |         |         |         |         |         | 688.000000 |           |         |           |         |           |         |           |         |           |         |           |         |           |         |           |         |           |         | 683.000000       | Issuer        | I0035312021      | ORD             | ATSR             | 688.000000 | 7050.50    |

@SmokeTest
@FullSmokeTest
@ReportingGold
@ReportSmokeTest
Scenario Outline:ESS_Employee_Extract_Report_SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "employee extract report" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   |
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> |
		And In ERS01010 I continue with the following details:
		| HolderIdentifier   |
		| <HolderIdentifier> |
		And In ERS01011 I continue with the following details:
		| StaticDetails   |
		| <StaticDetails> |
		And In ERS01012 I continue with the following details:
		| ExtraIdentifier   | HomePhone   | EmailAddress   |
		| <ExtraIdentifier> | <HomePhone> | <EmailAddress> |
		And In ERS01028 I continue with the following details:
		| HolderStatus   | DeceasedFlag   | ExceptionFlag   | StopTradeFlag   | DivIntentionFlag   |
		| <HolderStatus> | <DeceasedFlag> | <ExceptionFlag> | <StopTradeFlag> | <DivIntentionFlag> |
		And In ERS01013 I continue with the following details:			
		| Selcls1   | Selcls2   | Selgrp1   | Selgrp2   | Exd1   | UnitBalanceFrom   | UnitBalanceTO   | HolderTotalsOnly   | Selgrp3   | Selgrp4   | Selgrp5   | Selgrp6   | TransDateFrom   | TransDateTO   |
		| <Selcls1> | <Selcls2> | <Selgrp1> | <Selgrp2> | <Exd1> | <UnitBalanceFrom> | <UnitBalanceTO> | <HolderTotalsOnly> | <Selgrp3> | <Selgrp4> | <Selgrp5> | <Selgrp6> | <TransDateFrom> | <TransDateTO> |
		And In ERS01016 I continue with the following details:	
		| ClassCode   | RegisterCode   | RegisterType   | AwardDate   |
		| <ClassCode> | <RegisterCode> | <RegisterType> | <AwardDate> |
		And In ERS01017 I continue with the following details:
		| Select   | FieldSeparator   | TextDelimiterReq   |
		| <Select> | <FieldSeparator> | <TextDelimiterReq> |
		And In ERS01003 I continue with the following details:
		| ReportDate   | ReportSeq   |
		| <ReportDate> | <ReportSeq> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Selcls1 | Selcls2 | Selgrp1 | Selgrp2 | Exd1 | UnitBalanceFrom | UnitBalanceTO | HolderTotalsOnly | ClassCode | RegisterCode | RegisterType | AwardDate | Select | FieldSeparator | TextDelimiterReq | ReportDate | ReportSeq | Selgrp3 | Selgrp4 | Selgrp5 | Selgrp6 | TransDateFrom | TransDateTO | company    |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |         |         |      |                 | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |         |         |         |         |               |             | CPU_AUTO_R |