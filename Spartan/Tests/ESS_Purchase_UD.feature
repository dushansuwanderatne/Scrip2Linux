Feature: ESS_Purchase_UD
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers 

@winformsTest
@ESSPurchase
@ESSPurchaseUD
Scenario Outline: Deferred Plan Bulk Multiple Registers EP
#### Using Matching: Y / Using Unmatched: N / Matching Upfront: Y ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### Add Savings ####
		And In EOL00113 I click on "multiple awards health integrity" Menu
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
		#### UPL. Bulk Upload Process ####
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "multiple awards bulk uploads" Menu
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
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### Add Payments #####
		And In EOL00113 I click on "payments" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode1> |
		And In EOL00120 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In EOL01901 I Add Manual Payment as:
		| TransNumber    | PaymentFrequency    | AccumPeriod    | PaymentNumber    | PaymentStatus    | Eol01901ReceiptCurrency    | PaymentDate    | PaymentAmount    | EmployerPymtAmt    | Eol01901ExchangeRate    | SearchName    |
		| <TransNumber1> | <PaymentFrequency1> | <AccumPeriod1> | <PaymentNumber1> | <PaymentStatus1> | <Eol01901ReceiptCurrency1> | <PaymentDate1> | <PaymentAmount1> | <EmployerPymtAmt1> | <Eol01901ExchangeRate1> | <SearchName1> |
		And In EOL01902 I verify the following values:
		| AccumPeriod    | PaymentNumber    | PaymentFrequency    | RegisterType    | PaymentAmount    | Eol01902EmpBaseCurr    |
		| <AccumPeriod1> | <PaymentNumber1> | <PaymentFrequency1> | <RegisterType1> | <PaymentAmount1> | <Eol01902EmpBaseCurr1> |
		And EscapeFromCurrentScreen
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode    |
		| <RegisterCode2> |
		And In EOL00120 I continue with the following values:
		| Selection    |
		| <Selection2> |				
		And In EOL01901 I Add Manual Payment as:
		| TransNumber    | PaymentFrequency    | AccumPeriod    | PaymentNumber    | PaymentStatus    | Eol01901ReceiptCurrency    | PaymentDate    | PaymentAmount    | EmployerPymtAmt    | Eol01901ExchangeRate    | SearchName    |
		| <TransNumber2> | <PaymentFrequency1> | <AccumPeriod1> | <PaymentNumber1> | <PaymentStatus1> | <Eol01901ReceiptCurrency1> | <PaymentDate2> | <PaymentAmount2> | <EmployerPymtAmt1> | <Eol01901ExchangeRate1> | <SearchName2> |
		And In EOL01902 I verify the following values:
		| AccumPeriod    | PaymentNumber    | PaymentFrequency    | RegisterType    | PaymentAmount    | Eol01902EmpBaseCurr    |
		| <AccumPeriod1> | <PaymentNumber1> | <PaymentFrequency1> | <RegisterType1> | <PaymentAmount2> | <Eol01902EmpBaseCurr1> |
		And I Escape to the Main Menu from Employee Processing
		#### Release to Dealing System ####		
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "releases" Menu		
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode    |
		| <RegisterCode1> |
		And In EOL00106 I continue with the following values:
		| Selection    |
		| <Selection3> |
		And In EOLBLK05 I continue with the following values:
		| PayFreq1    | AccumPeriodFrom1   | AccumPeriodTO1   | PayFreq2   | AccumPeriodFrom2   | AccumPeriodTO2   | PayFreq3   | AccumPeriodFrom3   | AccumPeriodTO3   | ReleaseMode   |
		| <PayFreq1> | <AccumPeriodFrom1> | <AccumPeriodTO1> | <PayFreq2> | <AccumPeriodFrom2> | <AccumPeriodTO2> | <PayFreq3> | <AccumPeriodFrom3> | <AccumPeriodTO3> | <ReleaseMode> |
		And In EOLBLK04 I continue with the following values:
		| ConfirmRelType   |
		| <ConfirmRelType> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I Escape to the Main Menu from Employee Processing
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "releases" Menu		
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode2> |
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
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection1> |
		#### Change Bulk Status ####
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDateA> | <TradeDateA> | <TradeTimeA> | <IndicativePriceA> | <FinalPriceA> | <RegisterCodeA> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusA> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateA> | <FinalPriceA>     |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection2> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDateA> | <TradeDateA> | <TradeTimeA> | <IndicativePriceA> | <FinalPriceA> | <RegisterCodeB> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusB> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateA> | <FinalPriceA>     |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection3> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate   |
		| <SettlementDateA> | <TradeDateA> | <TradeTimeA> | <IndicativePriceA> | <FinalPriceA> | <RegisterCodeB> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusC> | <AwardDate1> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateA> | <FinalPriceA>     |
	Then In OLSB0404 I verify the following values:
		| TotalCount   | TotalUnits    | SettlementDate    | FinalPrice    | UnitsCalc    | CostOFShares    | TotalCost    | ResidueKept   | ResidueRefunded   | TaxONCharges   | AccumCharges   |
		| <TotalCount> | <TotalUnits1> | <SettlementDateA> | <FinalPriceA> | <UnitsCalc1> | <CostOFShares1> | <TotalCost1> | <ResidueKept> | <ResidueRefunded> | <TaxONCharges> | <AccumCharges> |
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo2> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection1> |
		#### Change Bulk Status ####
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDateB> | <TradeDateB> | <TradeTimeA> | <IndicativePriceA> | <FinalPriceA> | <RegisterCode1> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusA> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateB> | <FinalPriceA>     |
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo2> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection2> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDateB> | <TradeDateB> | <TradeTimeA> | <IndicativePriceA> | <FinalPriceA> | <RegisterCodeB> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusB> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateB> | <FinalPriceA>     |
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo2> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection3> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate    |
		| <SettlementDateB> | <TradeDateB> | <TradeTimeA> | <IndicativePriceA> | <FinalPriceA> | <RegisterCodeB> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusC> | <AwardDate2> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateB> | <FinalPriceA>     |
	Then In OLSB0404 I verify the following values:
		| TotalCount   | TotalUnits    | SettlementDate    | FinalPrice    | UnitsCalc    | CostOFShares    | TotalCost    | ResidueKept   | ResidueRefunded   | TaxONCharges   | AccumCharges   |
		| <TotalCount> | <TotalUnits2> | <SettlementDateB> | <FinalPriceA> | <UnitsCalc2> | <CostOFShares2> | <TotalCost2> | <ResidueKept> | <ResidueRefunded> | <TaxONCharges> | <AccumCharges> |
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection5> |
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
		| <PaymentAccount> | <OrderNO> | <Ident> | <NbrBulks> | <SettlementFrom1> | <SettlementTO1> | <PaymentDate> | <AddConvRateInd> |
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I PressESC
		#### Force Bulk Settlement ####
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection6> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection4> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate    |
		| <SettlementDate1> | <TradeDateS> | <TradeTimeS> | <IndicativePriceS> | <FinalPriceS> | <RegisterCodeB> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusD> | <AwardDateS> |
		And I PressESC
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection6> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection4> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate    |
		| <SettlementDate1> | <TradeDateS> | <TradeTimeS> | <IndicativePriceS> | <FinalPriceS> | <RegisterCodeB> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatusD> | <AwardDateS> |
		And I Escape to the Main Menu from Bulk Processing
		#### Holder Enquiry ####	
		And I go to the Enquiry system and Search <HolderID1>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2A> | <CertificateLine3A> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |
	When I enter the following details as the locatActions "<Action1>"  "<HolderID2>"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument1>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2B> | <CertificateLine3B> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |


Examples: 
	| Test  | COY      | ClassCode | InputFilename     | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Confirm | ReportHeading       | ReportDate | ReportSequence | Selection | RegisterCode1 | Selection2 | TransNumber1 | PaymentFrequency1 | AccumPeriod1 | PaymentNumber1 | PaymentStatus1 | Eol01901ReceiptCurrency1 | PaymentDate1 | PaymentAmount1 | EmployerPymtAmt1 | Eol01901ExchangeRate1 | SearchName1 | Eol01902EmpBaseCurr1 | RegisterType1 | TransNumber2 | PaymentAmount2 | SearchName2 | Selection3 | PayFreq1 | AccumPeriodFrom1 | AccumPeriodTO1 | PayFreq2 | AccumPeriodFrom2 | AccumPeriodTO2 | PayFreq3 | AccumPeriodFrom3 | AccumPeriodTO3 | ReleaseMode | ConfirmRelType | RegisterCode2 | PaymentDate2 | BulkCode | Selection4 | MenuSelection1 | SettlementDateA | TradeDateA | TradeTimeA | IndicativePriceA | FinalPriceA | RegisterCodeA | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3 | ConfirmStatusA | MenuSelection2 | RegisterCodeB | ConfirmStatusB | MenuSelection3 | AwardDate1 | ConfirmStatusC | TotalCount | TotalUnits1 | UnitsCalc1 | CostOFShares1 | TotalCost1 | ResidueKept | ResidueRefunded | TaxONCharges | AccumCharges | BulkNo1 | BulkNo2 | SettlementDateB | TradeDateB | AwardDate2 | TotalUnits2 | UnitsCalc2 | CostOFShares2 | TotalCost2 | Selection5 | BulkCurrency | SettlementFrom | SettlementTO | BulkID1 | Currency1 | SettlementDate1 | ProcessBulkInd1 | BulkID2 | Currency2 | SettlementDate2 | ProcessBulkInd2 | BulkID3 | Currency3 | SettlementDate3 | ProcessBulkInd3 | HomeBankDesc | AusTraceAccount | PaymentAccount | OrderNO | Ident | NbrBulks | SettlementFrom1 | SettlementTO1 | PaymentDate | AddConvRateInd | Selection6 | MenuSelection4 | TradeDateS | TradeTimeS | IndicativePriceS | FinalPriceS | ConfirmStatusD | AwardDateS | HolderID1   | Action | LocateArgument | CertificateLine1A                | CertificateLine2A                       | CertificateLine3A                            | CertificateLine4A | CertificateLine5A | CertificateLine6A | CertificateLine7A | CertificateLine8A | CertificateLine9A | CertificateLine10A | Action1 | HolderID2   | LocateArgument1 | CertificateLine2B                       | CertificateLine3B                            |
	| Test1 | CPU_AUTO | DEP       | ESSUPLDEPEPUD.CSV | F             | N           | Y               | N                 |                   |                  |                 |               |                   |           |                |           |           |                   | F                | Y                 |          | Y       | Bulk Upload Process |            | A              | EP        | 12A           | MAN        | 68400        | M                 | 1            | 1              | C              |                          | 12/07/2012   | 150.00         |                  |                       | I0100019001 | AUD                  | Part          | 68401        | 200.00         | I0013420891 | RPH        | M        | 1                | 1              |          |                  |                |          |                  |                | B           | AWP            | 13A           | 12/07/2013   | DEP      | CBS        | B              | 03/01/2013      | 03/01/2013 | 1000       | 10.00000         | 10.00000    | 13A           |             |             |             |             |             |             | B              | A              |               | A              | C              | 12/07/2013 | C              | 1          | 200.00      | 20         | 200.00        | 200.00     |             |                 |              |              | 1       | 2       | 12/07/2012      | 12/07/2012 | 12/07/2012 | 150.00      | 15         | 150.00        | 150.00     | GCB        | AUD          |                |              |         | AUD       |                 | Y               |         | AUD       |                 | Y               |         |           |                 |                 |              |                 | DP12A          | 5555    | NDF   | 2        | 12/07/2012      | 03/01/2013    |             | N              | FBS        | S              |            |            |                  |             | S              |            | I0100019001 | C      | /DEP/12A       | DEP/DEFERRED EMP SHARE PLAN - AU | 12A 20120712EP   12/07/12            15 | **** Total for 20120712EP                 15 |                   |                   |                   |                   |                   |                   |                    | S       | I0013420891 | /DEP/13A        | 13A 20130712EP   12/07/13            20 | **** Total for 20130712EP                 20 |


@winformsTest
@ESSPurchase
Scenario Outline: Deferred Plan Bulk Multiple Registers EF
#### Using Matching: Y / Using Unmatched: N / Matching Upfront: Y ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### multiple awards health integrity ####
		And In EOL00113 I click on "multiple awards health integrity" Menu
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
		#### UPL. Bulk Upload Process ####
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "multiple awards bulk uploads" Menu
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
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument1>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2B> | <CertificateLine3B> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |


Examples: 
	| Test  | COY      | ClassCode | InputFilename     | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Timestamp | Confirm | ReportHeading       | ReportDate | ReportSequence | HolderID1   | Action | LocateArgument | CertificateLine1A                | CertificateLine2A                       | CertificateLine3A                            | CertificateLine4A | CertificateLine5A | CertificateLine6A | CertificateLine7A | CertificateLine8A | CertificateLine9A | CertificateLine10A | Action1 | HolderID2   | LocateArgument1 | CertificateLine2B                       | CertificateLine3B                            |
	| Test1 | CPU_AUTO | DEP       | ESSUPLDEPEFUD.CSV | F             | N           | Y               | N                 |                   |                  |                 |               |                   |           |                |           |           |                   | F                | Y                 |          |           | Y       | Bulk Upload Process |            | A              | I0030047346 | C      | /DEP/12A/EF    | DEP/DEFERRED EMP SHARE PLAN - AU | 12A 20120712EF   12/07/12           200 | **** Total for 20120712EF                200 |                   |                   |                   |                   |                   |                   |                    | S       | I0013692343 | /DEP/13A/EF     | 13A 20130712EF   12/07/13           250 | **** Total for 20130712EF                250 |


@winformsTest
@ESSPurchase
Scenario Outline: Deferred Plan Bulk Multiple Registers EB
#### Using Matching: Y / Using Unmatched: N / Matching Upfront: Y ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### multiple awards health integrity ####
		And In EOL00113 I click on "multiple awards health integrity" Menu
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
		#### UPL. Bulk Upload Process ####
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "multiple awards bulk uploads" Menu
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
		#### Release to Dealing System 12A ####		
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "releases" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode1> |
		And In EOL00106 I continue with the following values:
		| Selection    |
		| <Selection1> |
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
		#### Release to Dealing System 13A ####		
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "releases" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode2> |
		And In EOL00106 I continue with the following values:
		| Selection    |
		| <Selection1> |
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
		| <Selection2> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection   |
		| <MenuSelection> |
		#### Change Bulk Status ####
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus   |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode2> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <MenuSelection> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDate>  | <FinalPrice>      |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection1> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus   |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <MenuSelection1> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDate>  | <FinalPrice>      |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection2> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode   | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate    |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <MenuSelection2> | <AwardDate1> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDate>  | <FinalPrice>      |
	Then In OLSB0404 I verify the following values:
		| TotalCount   | TotalUnits    | SettlementDate   | FinalPrice   | UnitsCalc    | CostOFShares    | TotalCost    | ResidueKept   | ResidueRefunded   | TaxONCharges   | AccumCharges   |
		| <TotalCount> | <TotalUnits1> | <SettlementDate> | <FinalPrice> | <UnitsCalc1> | <CostOFShares1> | <TotalCost1> | <ResidueKept> | <ResidueRefunded> | <TaxONCharges> | <AccumCharges> |
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection3> |
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
		| PaymentAccount    | OrderNO   | Ident   | NbrBulks   | SettlementFrom    | SettlementTO    | PaymentDate   | AddConvRateInd   |
		| <PaymentAccount1> | <OrderNO> | <Ident> | <NbrBulks> | <SettlementFrom1> | <SettlementTO1> | <PaymentDate> | <AddConvRateInd> |
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I PressESC
		#### Change Bulk Status ####
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection   |
		| <MenuSelection> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus   |
		| <SettlementDateb> | <TradeDate2> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode1> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <MenuSelection> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateb> | <FinalPrice>      |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection1> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDateb> | <TradeDate2> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <MenuSelection1> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateb> | <FinalPrice>      |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection2> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection2> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode   | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    | AwardDate    |
		| <SettlementDateb> | <TradeDate2> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <MenuSelection2> | <AwardDate2> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement | ConfirmFinalPrice |
		| <SettlementDateb> | <FinalPrice>      |
	Then In OLSB0404 I verify the following values:
		| TotalCount   | TotalUnits    | SettlementDate    | FinalPrice   | UnitsCalc    | CostOFShares    | TotalCost    | ResidueKept   | ResidueRefunded   | TaxONCharges   | AccumCharges   |
		| <TotalCount> | <TotalUnits2> | <SettlementDateb> | <FinalPrice> | <UnitsCalc2> | <CostOFShares2> | <TotalCost2> | <ResidueKept> | <ResidueRefunded> | <TaxONCharges> | <AccumCharges> |
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection3> |
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
		| PaymentAccount    | OrderNO   | Ident   | NbrBulks   | SettlementFrom    | SettlementTO    | PaymentDate   | AddConvRateInd   |
		| <PaymentAccount2> | <OrderNO> | <Ident> | <NbrBulks> | <SettlementFrom1> | <SettlementTO1> | <PaymentDate> | <AddConvRateInd> |
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I PressESC
		#### Force Bulk Settlement ####
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In BLKSCH01 I Select the bulk
		| BulkNo    |
		| <BulkNo1> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection3> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1    | ChargeCode2    | ChargeCode3    | ChargeDesc1    | ChargeDesc2    | ChargeDesc3    | ConfirmStatus    | AwardDate     |
		| <SettlementDateS> | <TradeDateS> | <TradeTimeS> | <IndicativePriceS> | <FinalPriceS> | <RegisterCodeS> | <ChargeCode1S> | <ChargeCode2S> | <ChargeCode3S> | <ChargeDesc1S> | <ChargeDesc2S> | <ChargeDesc3S> | <MenuSelection3> | <AwardDate1S> |
		And I PressESC
		#### Force Bulk Settlement ####
	When In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection4> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection    |
		| <MenuSelection3> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate    | TradeDate    | TradeTime    | IndicativePrice    | FinalPrice    | RegisterCode    | ChargeCode1    | ChargeCode2    | ChargeCode3    | ChargeDesc1    | ChargeDesc2    | ChargeDesc3    | ConfirmStatus    | AwardDate     |
		| <SettlementDateS> | <TradeDateS> | <TradeTimeS> | <IndicativePriceS> | <FinalPriceS> | <RegisterCodeS> | <ChargeCode1S> | <ChargeCode2S> | <ChargeCode3S> | <ChargeDesc1S> | <ChargeDesc2S> | <ChargeDesc3S> | <MenuSelection3> | <AwardDate1S> |
		And I Escape to the Main Menu from Bulk Processing
		#### Holder Enquiry ####	
		And I go to the Enquiry system and Search <HolderID1>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2A> | <CertificateLine3A> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |
	When I enter the following details as the locatActions "<Action1>"  "<HolderID2>"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument1>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2B> | <CertificateLine3B> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |


Examples: 
	| Test  | COY      | ClassCode | InputFilename     | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Timestamp | Confirm | ReportHeading       | ReportDate | ReportSequence | Selection | RegisterCode1 | Selection1 | PayFreq1 | AccumPeriodFrom1 | AccumPeriodTO1 | PayFreq2 | AccumPeriodFrom2 | AccumPeriodTO2 | PayFreq3 | AccumPeriodFrom3 | AccumPeriodTO3 | ReleaseMode | ConfirmRelType | RegisterCode2 | BulkCode | Selection2 | BulkNo1 | MenuSelection | SettlementDate | TradeDate  | TradeTime | IndicativePrice | FinalPrice | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3 | MenuSelection1 | RegisterCode | MenuSelection2 | AwardDate1 | TotalCount | TotalUnits1 | UnitsCalc1 | CostOFShares1 | TotalCost1 | ResidueKept | ResidueRefunded | TaxONCharges | AccumCharges | Selection3 | BulkCurrency | SettlementFrom | SettlementTO | BulkID | Currency1 | SettlementDate1 | ProcessBulkInd1 | BulkID2 | Currency2 | SettlementDate2 | ProcessBulkInd2 | BulkID3 | Currency3 | SettlementDate3 | ProcessBulkInd3 | HomeBankDesc | AusTraceAccount | PaymentAccount1 | OrderNO | Ident | NbrBulks | SettlementFrom1 | SettlementTO1 | PaymentDate | AddConvRateInd | BulkID1 | SettlementDateb | TradeDate2 | AwardDate2 | TotalUnits2 | UnitsCalc2 | CostOFShares2 | TotalCost2 | PaymentAccount2 | Selection4 | MenuSelection3 | SettlementDateS | TradeDateS | TradeTimeS | IndicativePriceS | FinalPriceS | RegisterCodeS | ChargeCode1S | ChargeCode2S | ChargeCode3S | ChargeDesc1S | ChargeDesc2S | ChargeDesc3S | AwardDate1S | HolderID1   | Action | LocateArgument | CertificateLine1A                | CertificateLine2A                       | CertificateLine3A                            | CertificateLine4A | CertificateLine5A | CertificateLine6A | CertificateLine7A | CertificateLine8A | CertificateLine9A | CertificateLine10A | Action1 | HolderID2   | LocateArgument1 | CertificateLine2B                       | CertificateLine3B                            |
	| Test1 | CPU_AUTO | DEP       | ESSUPLDEPEBUD.CSV | F             | N           | Y               | N                 |                   |                  |                 |               |                   |           |                |           |           |                   | F                | Y                 |          | Y         | A       | Bulk Upload Process |            | A              | EB        | 12A           | RPH        |          |                  |                |          |                  |                |          |                  |                | B           | ABO            | 13A           | DEB      | CBS        | 1       | B             | 12/07/2013     | 12/07/2013 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | A              |              | C              | 12/07/2013 | 1          | 1500.00     | 150        | 1500.00       | 1500.00    |             |                 |              |              | GCB        | AUD          |                |              |        | AUD       |                 | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | DP13A           | 5555    | NDF   | 1        |                 |               |             | N              |         | 12/07/2012      | 12/07/2012 | 12/07/2012 | 1000.00     | 100        | 1000.00       | 1000.00    | DP12A           | FBS        | S              |                 |            |            |                  |             |               |              |              |              |              |              |              |             | I0030041194 | C      | /DEP/12A/EB    | DEP/DEFERRED EMP SHARE PLAN - AU | 12A 20120712EB   12/07/12           100 | **** Total for 20120712EB                100 |                   |                   |                   |                   |                   |                   |                    | S       | I8800233462 | /DEP/13A/EB     | 13A 20130712EB   12/07/13           150 | **** Total for 20130712EB                150 |


@winformsTest
@ESSPurchase
Scenario Outline: Options Plan Bulk Multiple Registers EE
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### multiple awards health integrity ####
		And In EOL00107 I Click on "multiple grant health integrity" Menu
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
		#### UPL. Bulk Upload Process ####
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "multiple grant bulk uploads" Menu
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
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument1>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2B> | <CertificateLine3B> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |


Examples: 
	| Test  | COY      | ClassCode | InputFilename     | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Timestamp | Confirm | ReportHeading       | ReportDate | ReportSequence | HolderID1   | Action | LocateArgument | CertificateLine1A                | CertificateLine2A                       | CertificateLine3A                            | CertificateLine4A | CertificateLine5A | CertificateLine6A | CertificateLine7A | CertificateLine8A | CertificateLine9A | CertificateLine10A | Action1 | HolderID2   | LocateArgument1 | CertificateLine2B                       | CertificateLine3B                            |
	| Test1 | CPU_AUTO | OPT       | ESSUPLOPTUD.CSV   | F             | N           | Y               | N                 |                   |                  |                 |               |                   |           |                |           |           |                   | F                | Y                 |          |           | Y       | Bulk Upload Process |            | A              | I0030066804 | C      | /OPT/10B/EE    | OPT/EMPLOYEE OPTIONS PLAN        | 10B 20100604EE   04/06/10          1000 | **** Total for 20100604EE               1000 |                   |                   |                   |                   |                   |                   |                    | S       | I0030160380 | /OPT/10A/EE     | 10A 20100604EE   04/06/10          2000 | **** Total for 20100604EE               2000 |

@winformsTest
@ESSPurchase
Scenario Outline: Loan Plan Bulk Multiple Registers ER
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### multiple awards health integrity ####
		And In EOL00113 I click on "multiple awards health integrity" Menu
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
		#### UPL. Bulk Upload Process ####
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "multiple awards bulk uploads" Menu
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
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |
	When I enter the following details as the locatActions "<Action1>"  "<HolderID2>"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument1>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2    | Line3    | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2A> | <Line3A> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |

Examples: 
	| Test  | COY      | ClassCode | InputFilename   | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Timestamp | Confirm | ReportHeading       | ReportDate | ReportSequence | HolderID1   | Action | LocateArgument | Line1                              | Line2                                                                                | Line3                                                       | Line4 | Line5 | Line6 | Line7 | Line8 | Line9 | Line10 | Action1 | HolderID2   | LocateArgument1 | Line2A                                                                               | Line3A                                                      |
	| Test1 | CPU_AUTO | LON       | ESSUPLLONUD.CSV | F             | N           | Y               | N                 |                   |                  |                 |               |                   |           |                |           |           |                   | F                | Y                 |          |           | Y       | Bulk Upload Process |            | A              | I0100007584 | ESLB   | /LON/12A       | LON STF SHARE OWNERSHIP PLAN(LOAN) | 12A 0000015906 01/01/2012        100        500.00         500.00     No           0 | *Plan Total              100*       500.00*        500.00 * |       |       |       |       |       |       |        | S       | I0030195469 | /LON/13A        | 13A 0000015907 01/01/2013        150        600.00         600.00     No           0 | *Plan Total              150*       600.00*        600.00 * |






	
	       

























































