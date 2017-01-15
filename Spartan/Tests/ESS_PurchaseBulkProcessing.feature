Feature: ESS_PurchaseBulkProcessing
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers 

@ESSPurchase
Scenario Outline: Deferred Plan Manual Purchase EP
#### Using Matching: Y / Using Unmatched: N / Matching Upfront: Y ####
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
	| Test1 | CPU_AUTO | DEP       | EP        | 13A          | ASA        | 67350       | 01/07/2013 | 2500       |            | M                |             |              |               |                  | I0100019183 | Partnership   | 2500.00 | Unchanged      | Unchanged         | MAN        | 67351        | M                 | 1           | 1             | C             |                         | 02/07/2013  | 250.00        |                 |                      | Part         | AUD                 | RPH        | M        | 1                | 1              |          |                  |                |          |                  |                | B           | AWP            | DEP      | CBS        | B             | 03/07/2013     | 03/07/2013 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | B             | 03/07/2013        | 10                | A              | A              | C              | C              | 12/07/2013 |               | 1          | 250.00      | 25        | 250.00       | 250.00    |             |                 |              |              | GCB        | AUD          | 03/07/2013     | 03/07/2013   |         | AUD       | 03/07/2013      | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | DP13A          | 5555    | NDF   | 1        |              | N              | FBS        | S              |                 |            |            |                  |             |                |              |              |              |              |              |              | S              |            | BTQ        |        | SETTLED | 1          | 250.00     | Settled    | 1         | 25        | 25         | 250.00    | 250.00     | ESAWP          | BPE        | P        | PURCHASE     | 25             | 250.00         | M       |          |          |               | C      | /DEP/13A       | DEP/DEFERRED EMP SHARE PLAN - AU | 13A 20130712EP   12/07/13            25 | **** Total for 20130712EP                 25 |                  |                  |                  |                  |                  |                  |                   |


@ESSPurchase
Scenario Outline: Exempt Plan Manual Purchase EP
#### Using Matching: Y / Using Unmatched: N / Matching Upfront: Y ####
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
	| Test1 | CPU_AUTO | EXA       | EP        | 13A          | ASA        | 67355       | 01/07/2013 | 2500       |            | M                |             |              |               |                  | I0100019035 | Partnership   | 2500.00 | Unchanged      | Unchanged         | MAN        | 67356        | M                 | 1           | 1             | C             |                         | 02/07/2013  | 250.00        |                 |                      | Part         | AUD                 | RPH        | M        | 1                | 1              |          |                  |                |          |                  |                | B           | AWP            | EXP      | CBS        | B             | 03/07/2013     | 03/07/2013 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | B             | 03/07/2013        | 10                | A              | A              | C              | C              | 12/07/2013 |               | 1          | 250.00      | 25        | 250.00       | 250.00    |             |                 |              |              | GCB        | AUD          | 03/07/2013     | 03/07/2013   |         | AUD       | 03/07/2013      | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | EXA13          | 5555    | NDF   | 1        |              | N              | FBS        | S              |                 |            |            |                  |             |                |              |              |              |              |              |              | S              |            | BTQ        |        | SETTLED | 1          | 250.00     | Settled    | 1         | 25        | 25         | 250.00    | 250.00     | ESAWP          | BPE        | P        | PURCHASE     | 25             | 250.00         | M       | WBC      | 033-033  | 55665566      | C      | /EXA/13A       | EXA/EXEMPT EMP SHARE PLAN - AU   | 13A 20130712EP   12/07/13            25 | **** Total for 20130712EP                 25 |                  |                  |                  |                  |                  |                  |                   |


@ESSPurchase
Scenario Outline: Deferred Plan Manual Purchase EB/EN
#### Using Matching: Y / Using Unmatched: Y / Matching Upfront: N ####
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
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument1>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1P> | <CertificateLine2P> | <CertificateLine3P> | <CertificateLine4P> | <CertificateLine5P> | <CertificateLine6P> | <CertificateLine7P> | <CertificateLine8P> | <CertificateLine9P> | <CertificateLine10P> |

Examples: 
	| Test  | COY      | ClassCode | Selection | RegisterCode | Selection1 | TransNumber | TransDate  | TotalMoney | TotalUnits | PaymentFrequency | ResidualInd | GrantCountry | RetentionDate | TaxRetentionDate | SearchName  | RegisterType1 | Money1  | RetentionDate1 | TaxRetentionDate1 | Selection2 | TransNumberM | PaymentFrequencyM | AccumPeriod | PaymentNumber | PaymentStatus | Eol01901ReceiptCurrency | PaymentDate | PaymentAmount | EmployerPymtAmt | Eol01901ExchangeRate | RegisterType | Eol01902EmpBaseCurr | Selection3 | PayFreq1 | AccumPeriodFrom1 | AccumPeriodTO1 | PayFreq2 | AccumPeriodFrom2 | AccumPeriodTO2 | PayFreq3 | AccumPeriodFrom3 | AccumPeriodTO3 | ReleaseMode | ConfirmRelType | BulkCode | Selection4 | MenuSelection | SettlementDate | TradeDate  | TradeTime | IndicativePrice | FinalPrice | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3 | ConfirmStatus | ConfirmSettlement | ConfirmFinalPrice | MenuSelection1 | ConfirmStatus1 | MenuSelection2 | ConfirmStatus2 | AwardDate  | RegisterCode1 | TotalCount | TotalUnits1 | UnitsCalc | CostOFShares | TotalCost | ResidueKept | ResidueRefunded | TaxONCharges | AccumCharges | Selection5 | BulkCurrency | SettlementFrom | SettlementTO | BulkID1 | Currency1 | SettlementDate1 | ProcessBulkInd1 | BulkID2 | Currency2 | SettlementDate2 | ProcessBulkInd2 | BulkID3 | Currency3 | SettlementDate3 | ProcessBulkInd3 | HomeBankDesc | AusTraceAccount | PaymentAccount | OrderNO | Ident | NbrBulks | PaymentDate1 | AddConvRateInd | Selection6 | MenuSelection3 | SettlementDateS | TradeDateS | TradeTimeS | IndicativePriceS | FinalPriceS | RegisterCode1S | ChargeCode1S | ChargeCode2S | ChargeCode3S | ChargeDesc1S | ChargeDesc2S | ChargeDesc3S | ConfirmStatus3 | AwardDateS | Selection7 | BulkID | Status  | TransCount | TransTotal | StatusDesc | BulkCount | BulkUnits | TransUnits | BulkMoney | TransMoney | TranTypeParent | Selection8 | BulkType | BulkTypeDesc | BulkTransUnits | BulkTransMoney | ActionM | BankType | BankCode | AccountNumber | Action | LocateArgument | CertificateLine1      | CertificateLine2                        | CertificateLine3                             | CertificateLine4                        | CertificateLine5                             | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 | LocateArgument1 | CertificateLine1P         | CertificateLine2P                       | CertificateLine3P                            | CertificateLine4P | CertificateLine5P | CertificateLine6P | CertificateLine7P | CertificateLine8P | CertificateLine9P | CertificateLine10P |
	| Test1 | CPU_AUTO | DMA       | EB        | 14A          | ASA        | 67360       | 01/07/2014 | 1000       |            | Y                |             |              |               |                  | I0100007444 | Bonus         | 1000.00 | Unchanged      | Unchanged         | MAN        | 67361        | Y                 | 1           | 1             | C             |                         | 01/07/2014  | 1000.00       |                 |                      | Bonus        | AUD                 | RPH        | Y        | 1                | 1              |          |                  |                |          |                  |                | B           | ABO            | ABO      | CBS        | B             | 02/07/2014     | 02/07/2014 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | B             | 02/07/2014        | 10                | A              | A              | C              | C              | 01/07/2014 |               | 1          | 1000.00     | 100       | 1000.00      | 1000.00   |             |                 |              |              | GCB        | AUD          | 02/07/2014     | 02/07/2014   |         | AUD       | 02/07/2014      | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | DMA14          | 5555    | NDF   | 1        |              | N              | FBS        | S              |                 |            |            |                  |             |                |              |              |              |              |              |              | S              |            | BTQ        |        | SETTLED | 1          | 1000.00    | Settled    | 1         | 100       | 100        | 1000.00   | 1000.00    | ESABO          | BPE        | P        | PURCHASE     | 100            | 1000.00        | M       | WBC      | 033-033  | 55665566      | C      | /DMA/14A       | DMA/AMP COMPANY EB/EN | 14A 20140701EB   01/07/14           100 | **** Total for 20140701EB                100 | 14A 20140701EN   01/07/14             0 | **** Total for 20140701EN                  0 |                  |                  |                  |                  |                   | /PHA/14A        | PHA/PHANTOM ESAP MATCHING | 14A 20140701EN   01/07/14           100 | **** Total for 20140701EN                100 |                   |                   |                   |                   |                   |                   |                    |


@ESSPurchase
Scenario Outline: Deferred Plan Manual Purchase EP/EM
#### Using Matching: Y / Using Unmatched: Y / Matching Upfront: N ####
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
	| Test  | COY      | ClassCode | Selection | RegisterCode | Selection1 | TransNumber | TransDate  | TotalMoney | TotalUnits | PaymentFrequency | ResidualInd | GrantCountry | RetentionDate | TaxRetentionDate | SearchName  | RegisterType1 | Money1  | RetentionDate1 | TaxRetentionDate1 | Selection2 | TransNumberM | PaymentFrequencyM | AccumPeriod | PaymentNumber | PaymentStatus | Eol01901ReceiptCurrency | PaymentDate | PaymentAmount | EmployerPymtAmt | Eol01901ExchangeRate | RegisterType | Eol01902EmpBaseCurr | Selection3 | PayFreq1 | AccumPeriodFrom1 | AccumPeriodTO1 | PayFreq2 | AccumPeriodFrom2 | AccumPeriodTO2 | PayFreq3 | AccumPeriodFrom3 | AccumPeriodTO3 | ReleaseMode | ConfirmRelType | BulkCode | Selection4 | MenuSelection | SettlementDate | TradeDate  | TradeTime | IndicativePrice | FinalPrice | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3 | ConfirmStatus | ConfirmSettlement | ConfirmFinalPrice | MenuSelection1 | ConfirmStatus1 | MenuSelection2 | ConfirmStatus2 | AwardDate  | RegisterCode1 | TotalCount | TotalUnits1 | UnitsCalc | CostOFShares | TotalCost | ResidueKept | ResidueRefunded | TaxONCharges | AccumCharges | Selection5 | BulkCurrency | SettlementFrom | SettlementTO | BulkID1 | Currency1 | SettlementDate1 | ProcessBulkInd1 | BulkID2 | Currency2 | SettlementDate2 | ProcessBulkInd2 | BulkID3 | Currency3 | SettlementDate3 | ProcessBulkInd3 | HomeBankDesc | AusTraceAccount | PaymentAccount | OrderNO | Ident | NbrBulks | PaymentDate1 | AddConvRateInd | Selection6 | MenuSelection3 | SettlementDateS | TradeDateS | TradeTimeS | IndicativePriceS | FinalPriceS | RegisterCode1S | ChargeCode1S | ChargeCode2S | ChargeCode3S | ChargeDesc1S | ChargeDesc2S | ChargeDesc3S | ConfirmStatus3 | AwardDateS | Selection7 | BulkID | Status  | TransCount | TransTotal | StatusDesc | BulkCount | BulkUnits | TransUnits | BulkMoney | TransMoney | TranTypeParent | Selection8 | BulkType | BulkTypeDesc | BulkTransUnits | BulkTransMoney | ActionM | BankType | BankCode | AccountNumber | Action | LocateArgument | CertificateLine1        |  CertificateLine2                        | CertificateLine3                             | CertificateLine4                        | CertificateLine5                             | CertificateLine6 | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
	| Test1 | CPU_AUTO | EDP       | EP        | 14A          | ASA        | 67370       | 01/07/2014 | 1000       |            | M                |             |              |               |                  | I0100007401 | Partnership   | 1000.00 |                |                   | MAN        | 67371        | M                 | 1           | 1             | C             |                         | 01/07/2014  | 1000.00       |                 |                      | Part         | AUD                 | RPH        | M        | 1                | 1              |          |                  |                |          |                  |                | B           | AWP            | EDP      | CBS        | B             | 02/07/2014     | 02/07/2014 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | B             | 02/07/2014        | 10                | A              | A              | C              | C              | 01/07/2014 |               | 1          | 1000.00     | 100       | 1000.00      | 1000.00   |             |                 |              |              | GCB        | AUD          | 02/07/2014     | 02/07/2014   |         | AUD       | 02/07/2014      | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | EDP14          | 5555    | NDF   | 1        |              | N              | FBS        | S              |                 |            |            |                  |             |                |              |              |              |              |              |              | S              |            | BTQ        |        | SETTLED | 1          | 1000.00    | Settled    | 1         | 100       | 100        | 1000.00   | 1000.00    | ESAWP          | BPE        | P        | PURCHASE     | 100            | 1000.00        | M       | WBC      | 033-033  | 55665566      | C      | /EDP/14A       | EDP/EXPAT DEFERRED PLAN | 14A 20140701EM   01/07/14            11  | **** Total for 20140701EM                 11 | 14A 20140701EP   01/07/14           100 | **** Total for 20140701EP                100 |                  |                  |                  |                  |                   | 



@ESSPurchase
Scenario Outline: Deferred Plan Bulk Purchase EP
#### Using Matching: Y / Using Unmatched: N / Matching Upfront: Y ####
#### Input file in CPU_AUTO: ESSUPL_ESS.CSV;1  ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		#### INT. Health & Integrity Check ####
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
		And In EOL00113 I click on "awards" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		#### UPL. Bulk Upload Process ####
		And In EOL00114 I continue with the following values:
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
		| <Selection3> |
		And In EOL01901 I Add Manual Payment as:
		| TransNumber    | PaymentFrequency    | AccumPeriod    | PaymentNumber    | PaymentStatus    | Eol01901ReceiptCurrency    | PaymentDate    | PaymentAmount    | EmployerPymtAmt    | Eol01901ExchangeRate    | SearchName    |
		| <TransNumber1> | <PaymentFrequency1> | <AccumPeriod1> | <PaymentNumber1> | <PaymentStatus1> | <Eol01901ReceiptCurrency1> | <PaymentDate1> | <PaymentAmount1> | <EmployerPymtAmt1> | <Eol01901ExchangeRate1> | <SearchName1> |
		And In EOL01902 I verify the following values:
		| AccumPeriod    | PaymentNumber    | PaymentFrequency    | RegisterType    | PaymentAmount    | Eol01902EmpBaseCurr    |
		| <AccumPeriod1> | <PaymentNumber1> | <PaymentFrequency1> | <RegisterType1> | <PaymentAmount1> | <Eol01902EmpBaseCurr1> |
		And In EOL01901 I Add Manual Payment as:
		| TransNumber    | PaymentFrequency    | AccumPeriod    | PaymentNumber    | PaymentStatus    | Eol01901ReceiptCurrency    | PaymentDate    | PaymentAmount    | EmployerPymtAmt    | Eol01901ExchangeRate    | SearchName    |
		| <TransNumber2> | <PaymentFrequency2> | <AccumPeriod2> | <PaymentNumber2> | <PaymentStatus2> | <Eol01901ReceiptCurrency2> | <PaymentDate2> | <PaymentAmount2> | <EmployerPymtAmt2> | <Eol01901ExchangeRate2> | <SearchName2> |
		And In EOL01902 I verify the following values:
		| AccumPeriod    | PaymentNumber    | PaymentFrequency    | RegisterType    | PaymentAmount    | Eol01902EmpBaseCurr    |
		| <AccumPeriod2> | <PaymentNumber2> | <PaymentFrequency2> | <RegisterType2> | <PaymentAmount2> | <Eol01902EmpBaseCurr2> |
		And In EOL01901 I Add Manual Payment as:
		| TransNumber    | PaymentFrequency    | AccumPeriod    | PaymentNumber    | PaymentStatus    | Eol01901ReceiptCurrency    | PaymentDate    | PaymentAmount    | EmployerPymtAmt    | Eol01901ExchangeRate    | SearchName    |
		| <TransNumber3> | <PaymentFrequency3> | <AccumPeriod3> | <PaymentNumber3> | <PaymentStatus3> | <Eol01901ReceiptCurrency3> | <PaymentDate3> | <PaymentAmount3> | <EmployerPymtAmt3> | <Eol01901ExchangeRate3> | <SearchName3> |
		And In EOL01902 I verify the following values:
		| AccumPeriod    | PaymentNumber    | PaymentFrequency    | RegisterType    | PaymentAmount    | Eol01902EmpBaseCurr    |
		| <AccumPeriod3> | <PaymentNumber3> | <PaymentFrequency3> | <RegisterType3> | <PaymentAmount3> | <Eol01902EmpBaseCurr3> |
		And I Escape to the Main Menu from Employee Processing
		#### Release to Dealing System ####		
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "releases" Menu
		And In EOL00115 I select the Register Type as:
		| Selection   |
		| <Selection> |
		And In EOL00103 I select the RegisterCode as:
		| RegisterCode   |
		| <RegisterCode> |
		And In EOL00106 I continue with the following values:
		| Selection    |
		| <Selection4> |
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
		#### Bulk Processing ####
		And I go to the Bulk Processing System and select Bulk code as:
		| BulkCode   |
		| <BulkCode> |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection5> |
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
		| <Selection5> |
		And In OLSB0401 I change the Bulk Status as:
		| MenuSelection   |
		| <MenuSelection1> |
		And In OLSB0402 I change the Bulk Status as:
		| SettlementDate   | TradeDate   | TradeTime   | IndicativePrice   | FinalPrice   | RegisterCode    | ChargeCode1   | ChargeCode2   | ChargeCode3   | ChargeDesc1   | ChargeDesc2   | ChargeDesc3   | ConfirmStatus    |
		| <SettlementDate> | <TradeDate> | <TradeTime> | <IndicativePrice> | <FinalPrice> | <RegisterCode1> | <ChargeCode1> | <ChargeCode2> | <ChargeCode3> | <ChargeDesc1> | <ChargeDesc2> | <ChargeDesc3> | <ConfirmStatus1> |
		And In OLSB0403 I continue with the following values:
		| ConfirmSettlement   | ConfirmFinalPrice   |
		| <ConfirmSettlement> | <ConfirmFinalPrice> |		
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection5> |
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
		| TotalCount   | TotalUnits    | SettlementDate   | FinalPrice   | UnitsCalc   | CostOFShares   | TotalCost   | ResidueKept   | ResidueRefunded   | TaxONCharges   | AccumCharges   |
		| <TotalCount> | <TotalUnits1> | <SettlementDate> | <FinalPrice> | <UnitsCalc> | <CostOFShares> | <TotalCost> | <ResidueKept> | <ResidueRefunded> | <TaxONCharges> | <AccumCharges> |
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection6> |
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
		| <PaymentAccount> | <OrderNO> | <Ident> | <NbrBulks> | <SettlementFrom> | <SettlementTO> | <PaymentDate> | <AddConvRateInd> |
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		And I PressESC
		#### Force Bulk Settlement ####
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection7> |
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
		| <Selection8> |
		And In BLKSCH01 I continue with the following values:
		| BulkID   | Status   | RegisterCode   | TransCount   | TransTotal   | SettlementDate    |
		| <BulkID> | <Status> | <RegisterCode> | <TransCount> | <TransTotal> | <SettlementDate3> |
		And In OLSB1010 I verify the following values:
		| BulkID   | StatusDesc   | BulkCount   | BulkUnits   | TransUnits   | BulkMoney   | TransMoney   | TranTypeParent   | HolderID     | RegisterCode   |
		| <BulkID> | <StatusDesc> | <BulkCount> | <BulkUnits> | <TransUnits> | <BulkMoney> | <TransMoney> | <TranTypeParent> | <HolderID1>  | <RegisterCode> |
		And In OLSB1010 I continue with the following values:
		| EnquiryAction   |
		| <EnquiryAction> |
		And In OLSB1010 I verify the following values:
		| BulkID   | StatusDesc   | BulkCount   | BulkUnits    | TransUnits    | BulkMoney    | TransMoney    | TranTypeParent   | HolderID    | RegisterCode   |
		| <BulkID> | <StatusDesc> | <BulkCount> | <BulkUnits1> | <TransUnits1> | <BulkMoney1> | <TransMoney1> | <TranTypeParent> | <HolderID2> | <RegisterCode> |
		And In OLSB1010 I continue with the following values:
		| EnquiryAction   |
		| <EnquiryAction> |
		And In OLSB1010 I verify the following values:
		| BulkID   | StatusDesc   | BulkCount   | BulkUnits    | TransUnits    | BulkMoney    | TransMoney    | TranTypeParent   | HolderID    | RegisterCode   |
		| <BulkID> | <StatusDesc> | <BulkCount> | <BulkUnits2> | <TransUnits2> | <BulkMoney2> | <TransMoney2> | <TranTypeParent> | <HolderID3> | <RegisterCode> |
		And I PressESC
		And In OLSBLK02 I continue with the following values:
		| Selection    |
		| <Selection9> |
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
		And I go to the Enquiry system and Search <HolderID1>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1A> | <CertificateLine2A> | <CertificateLine3A> | <CertificateLine4A> | <CertificateLine5A> | <CertificateLine6A> | <CertificateLine7A> | <CertificateLine8A> | <CertificateLine9A> | <CertificateLine10A> |
	When I enter the following details as the locatActions "<Action1>"  "<HolderID2>"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1B> | <CertificateLine2B> | <CertificateLine3B> | <CertificateLine4B> | <CertificateLine5B> | <CertificateLine6B> | <CertificateLine7B> | <CertificateLine8B> | <CertificateLine9B> | <CertificateLine10B> |
	When I enter the following details as the locatActions "<Action1>"  "<HolderID3>"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1    | CertificateLine2    | CertificateLine3    | CertificateLine4    | CertificateLine5    | CertificateLine6    | CertificateLine7    | CertificateLine8    | CertificateLine9    | CertificateLine10    |
	| <CertificateLine1C> | <CertificateLine2C> | <CertificateLine3C> | <CertificateLine4C> | <CertificateLine5C> | <CertificateLine6C> | <CertificateLine7C> | <CertificateLine8C> | <CertificateLine9C> | <CertificateLine10C> |


Examples: 
	| Test  | COY      | ClassCode | Selection | RegisterCode | Selection1 | AppropDate | InputFilename  | NameSelection | PCSelection | AddressMatching | AllowBlankAddress | UpdateAddrDetails | UpdateEmpDetails | AutoGenEmpUnqID | ClearEmpUnqID | UpdateContactDets | UploadTfn | UpdateMandates | UpdateDrp | RunTrnedt | CreateNewAccounts | ReportFullTotals | AutoFtpReportsInd | FileName | Selection2 | Timestamp | Confirm | ReportHeading       | ReportDate | ReportSequence | Selection3 | TransNumber1 | PaymentFrequency1 | AccumPeriod1 | PaymentNumber1 | PaymentStatus1 | Eol01901ReceiptCurrency1 | PaymentDate1 | PaymentAmount1 | EmployerPymtAmt1 | Eol01901ExchangeRate1 | SearchName1 | RegisterType1 | Eol01902EmpBaseCurr1 | TransNumber2 | PaymentFrequency2 | AccumPeriod2 | PaymentNumber2 | PaymentStatus2 | Eol01901ReceiptCurrency2 | PaymentDate2 | PaymentAmount2 | EmployerPymtAmt2 | Eol01901ExchangeRate2 | SearchName2 | RegisterType2 | Eol01902EmpBaseCurr2 | TransNumber3 | PaymentFrequency3 | AccumPeriod3 | PaymentNumber3 | PaymentStatus3 | Eol01901ReceiptCurrency3 | PaymentDate3 | PaymentAmount3 | EmployerPymtAmt3 | Eol01901ExchangeRate3 | SearchName3 | RegisterType3 | Eol01902EmpBaseCurr3 | Selection4 | PayFreq1 | AccumPeriodFrom1 | AccumPeriodTO1 | PayFreq2 | AccumPeriodFrom2 | AccumPeriodTO2 | PayFreq3 | AccumPeriodFrom3 | AccumPeriodTO3 | ReleaseMode | ConfirmRelType | BulkCode | Selection5 | MenuSelection | SettlementDate | TradeDate  | TradeTime | IndicativePrice | FinalPrice | ChargeCode1 | ChargeCode2 | ChargeCode3 | ChargeDesc1 | ChargeDesc2 | ChargeDesc3 | ConfirmStatus | ConfirmStatus1 | ConfirmStatus2 | ConfirmSettlement | ConfirmFinalPrice | RegisterCode1 | MenuSelection1 | MenuSelection2 | AwardDate  | TotalCount | TotalUnits1 | UnitsCalc | CostOFShares | TotalCost | ResidueKept | ResidueRefunded | TaxONCharges | AccumCharges | Selection6 | BulkCurrency | SettlementFrom | SettlementTO | BulkID1 | Currency1 | SettlementDate1 | ProcessBulkInd1 | BulkID2 | Currency2 | SettlementDate2 | ProcessBulkInd2 | BulkID3 | Currency3 | SettlementDate3 | ProcessBulkInd3 | HomeBankDesc | AusTraceAccount | PaymentAccount | OrderNO | Ident | NbrBulks | PaymentDate | AddConvRateInd | MenuSelection3 | SettlementDateS | TradeDateS | TradeTimeS | IndicativePriceS | FinalPriceS | RegisterCode1S | ChargeCode1S | ChargeCode2S | ChargeCode3S | ChargeDesc1S | ChargeDesc2S | ChargeDesc3S | ConfirmStatus3 | AwardDateS | Selection7 | Selection8 | BulkID | Status  | TransCount | TransTotal | StatusDesc | BulkCount | BulkUnits | TransUnits | BulkMoney | TransMoney | TranTypeParent | HolderID1   | EnquiryAction | BulkUnits1 | TransUnits1 | BulkMoney1 | TransMoney1 | HolderID2   | BulkUnits2 | TransUnits2 | BulkMoney2 | TransMoney2 | HolderID3   | Selection9 | BulkType | BulkTypeDesc | BulkTransUnits | BulkTransMoney | ActionM | BankType | BankCode | AccountNumber | Action | LocateArgument | CertificateLine1A                | CertificateLine2A                       | CertificateLine3A                            | CertificateLine4A                       | CertificateLine5A                            | CertificateLine6A | CertificateLine7A | CertificateLine8A | CertificateLine9A | CertificateLine10A | Action1 | CertificateLine1B                | CertificateLine2B                       | CertificateLine3B                            | CertificateLine4B | CertificateLine5B | CertificateLine6B | CertificateLine7B | CertificateLine8B | CertificateLine9B | CertificateLine10B | CertificateLine1C                | CertificateLine2C                       | CertificateLine3C                            | CertificateLine4C | CertificateLine5C | CertificateLine6C | CertificateLine7C | CertificateLine8C | CertificateLine9C | CertificateLine10C |
	| Test1 | CPU_AUTO | DEP       | EP        | 12A          | INT        | 12/07/2012 | ESSUPL_ESS.CSV | F             | N           | Y               | N                 | N                 | Y                | N               | N             | Y                 | N         | N              | N         | Y         | N                 | F                | Y                 |          | UPL        |           | C       | Bulk Upload Process |            | A              | MAN        | 67380        | M                 | 1            | 1              | C              |                          | 12/07/2012   | 150.00         |                  |                       | I0030238206 | Part          | AUD                  | 67381        | M                 | 1            | 1              | C              |                          | 12/07/2012   | 250.00         |                  |                       | I0030303521 | Part          | AUD                  | 67382        | M                 | 1            | 1              | C              |                          | 12/07/2012   | 300.00         |                  |                       | I0030303539 | Part          | AUD                  | RPH        | M        | 1                | 1              |          |                  |                |          |                  |                | B           | AWP            | DEP      | CBS        | B             | 16/07/2012     | 16/07/2012 | 1000      | 10.00000        | 10.00000   |             |             |             |             |             |             | B             | A              | C              | 16/07/2012        | 10.00000          |               | A              | C              | 12/07/2012 | 3          | 700.00      | 70        | 700.00       | 700.00    |             |                 |              |              | GCB        | AUD          | 16/07/2012     | 16/07/2012   |         | AUD       | 16/07/2012      | Y               |         |           |                 |                 |         |           |                 |                 |              |                 | DP12A          | 5555    | NDF   | 1        |             | N              | S              |                 |            |            |                  |             |                |              |              |              |              |              |              | S              |            | FBS        | BTQ        |        | SETTLED | 3          | 700.00     | Settled    | 3         | 70        | 15         | 700.00    | 150.00     | ESAWP          | I0030238206 | F             | 70         | 25          | 700.00     | 250.00      | I0030303521 | 70         | 30          | 700.00     | 300.00      | I0030303539 | BPE        | P        | PURCHASE     | 70             | 700.00         | M       |          |          |               | C      | /DEP/12A       | DEP/DEFERRED EMP SHARE PLAN - AU | 12A 20120712EB   12/07/12           450 | **** Total for 20120712EB                450 | 12A 20120712EP   12/07/12            15 | **** Total for 20120712EP                 15 |                   |                   |                   |                   |                    | S       | DEP/DEFERRED EMP SHARE PLAN - AU | 12A 20120712EP   12/07/12            25 | **** Total for 20120712EP                 25 |                   |                   |                   |                   |                   |                   |                    | DEP/DEFERRED EMP SHARE PLAN - AU | 12A 20120712EP   12/07/12            30 | **** Total for 20120712EP                 30 |                   |                   |                   |                   |                   |                   |                    |




	
	
	
	  




































































































































