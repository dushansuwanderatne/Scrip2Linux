Feature: SmokeTestFull
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTestTemp
@ReportGoldcopyOther
@ReportingGold
@FullSmokeTest
@SmokeTestReports
Scenario:Top_Holders_Report_SmokeTest
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "CPU_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "top holders list" within the Reporting System Menu
	And In RSS02010 I continue with the following details:
	| ReportDate | ASATRun |
	| 20/07/2015 | 5190    |
	And In RSS02020 I continue with the following details:
	| Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | ClgCon | GroupIDX | TopSHLimit | ReportType | ReportRun1 | ReportRun1 | UseGroupCodes | PrintGrpDetails | HolderIDTOPrint | NameAddressTOPrint | HtcFlag | HT | SystemInfoFree6 | SystemInfoFree4 | SystemInfoFree7 | SystemInfoFree5 |
	|      |      |      |      |      |      |      |      |      |       |        |          | 100        | S          |            |            | Y             |                 | Y               | F                  | A       |    |                 |                 |                 |                 |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


@SignificantTradeReport_Gold
@ReportGoldcopyOther
@ReportingGold
@FullSmokeTest
@SmokeTestTemp
@SmokeTestTemp
Scenario:Significant_Trade_Report_SmokeTest
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "CPU_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "shareholder movement reporting" within the Reporting System Menu
	And In RSS18010 I click on: "significant trade report" within the Shareholder Movement Reporting Menu
	And In RSS18000 I continue with the following details:
	| PreloadDefaults |
	| N               |
	And In RSS18001 I continue with the following details:
	| ReportHeading            | Cls1 | Cls2 | Cls3 | NadTOPrint | MovementLevel | HolderLimit | ReportType |
	| Significant Trade Report | DEP  |EXA   |      | N          | 150           | 100         | D          |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

@FullSmokeTest
@SmokeTestReportsESSPurchaseRecon
@ReportingGold
@SmokeTestReports
@SmokeTestTemp
Scenario Outline:ESS_Purchase_Reconciliation_Report_SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "purchase reconciliation report" within the ESS Reporting Menu
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
		And In ERS01004 I continue with the following details:
		| Selcls1   | Selcls2   | Selreg1   | Selreg2   | RegType1   | RegType2   | DateFrom   | DateTO   | SummaryDetailInd   | ContributionTypeInd   | ContractedSvgsInd   | SvgsContribDiffInd   | DispResidualsInd   | DispUnitBalanceInd   | DispSharePriceInd   | DispShareCostInd   | DispUnitsAllocInd   | Ers01004RecContribDetsInd   | SelGrp1   | SelGrp2   |
		| <Selcls1> | <Selcls2> | <Selreg1> | <Selreg2> | <RegType1> | <RegType2> | <DateFrom> | <DateTO> | <SummaryDetailInd> | <ContributionTypeInd> | <ContractedSvgsInd> | <SvgsContribDiffInd> | <DispResidualsInd> | <DispUnitBalanceInd> | <DispSharePriceInd> | <DispShareCostInd> | <DispUnitsAllocInd> | <Ers01004RecContribDetsInd> | <SelGrp1> | <SelGrp2> |
		And In ERS01003 I continue with the following details:
		| ReportDate   | ReportSeq   |
		| <ReportDate> | <ReportSeq> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Selcls1 | Selcls2 | Selreg1 | Selreg2 | RegType1 | RegType2 | DateFrom   | DateTO     | SummaryDetailInd | ContributionTypeInd | ContractedSvgsInd | SvgsContribDiffInd | DispResidualsInd | DispUnitBalanceInd | DispSharePriceInd | DispShareCostInd | DispUnitsAllocInd | Ers01004RecContribDetsInd | ReportDate | ReportSeq | SelGrp1 | SelGrp2 |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         | 11A     |         | EP       |          | 01/01/2010 | 01/01/2015 | S                | B                   | Y                 | Y                  | Y                | Y                  | Y                 | Y                | Y                 | N                         |            | A         | 3       | 7       |
	
	
@ReportGoldcopyESS
@ESSEmployeeOptionPlanStatement_Gold
@CPU_AUTO_R
@ReportingGold
@FullSmokeTest
@SmokeTestReports
@SmokeTestTemp
Scenario Outline:ESS_Employee_Option_Plan_Statement_SmokeTest
### Bug 72963:Reports -ESS_Employee_Option_Plan_Statement -job is looping in Linux ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "employee option plan statement" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   |
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> |
		And In ERS01043 I continue with the following details:
		| Class1   | Class2   | Selgrp1   | Selgrp2   | Reg1   | Reg2   | StatementType   | RunRangeTO   | StatementRunFrom   | TransDateFrom   | TransDateTO   | MarketValuePrice   | MarketValueDate   | StmtDsplayDateFrom   | StmtDsplayDateTO   | NilHoldingsInd   |
		| <Class1> | <Class2> | <Selgrp1> | <Selgrp2> | <Reg1> | <Reg2> | <StatementType> | <RunRangeTO> | <StatementRunFrom> | <TransDateFrom> | <TransDateTO> | <MarketValuePrice> | <MarketValueDate> | <StmtDsplayDateFrom> | <StmtDsplayDateTO> | <NilHoldingsInd> |
		And In ERS01044 I continue with the following details:	
		| Confirm   |
		| <Confirm> |	
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | Class1 | Class2 | Selgrp1 | Selgrp2 | Reg1 | Reg2 | StatementType | RunRangeTO | StatementRunFrom | TransDateFrom | TransDateTO | MarketValuePrice | MarketValueDate | StmtDsplayDateFrom | StmtDsplayDateTO | NilHoldingsInd | ReportDate | ReportSeq | Confirm |
	| Test6         | N       |            |            |            |             |             |        |        |    2    |         |      |      | G             | 4405       |                  |               |             | 10               | 01/01/2014      | 01/07/2013         | 30/06/2014       | Y              |            | A         |         |

@TS_TradingSystem
@OptionsPlanSales
@30522
@FullSmokeTest
@SmokeTestTradingOptionsdReal
Scenario Outline: Options Real Time Sale SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to "Company Options" Control Code Menu
		And In HKS01516 I set the Multi-Cert Flag to "<Multi-Cert>"
		And I go to "Trading Control Codes" Control Code Menu
		And In TRD24000 I select the Trade Control Code "<tradeControlCode>"
		And In TRD24001 I perform a Change for On Market Trade "<OnMarketTrade>", "<BrokerCode>", "<BrokerAccountID>", "<ConnectionCode>", "<RealTimeTrading>" and Top Up "<TopupPercentage>", "<SellSelected>" and Remaining Balance Options "<Option>", "<TranType>", "<Class>", "<Reg>" and World Link Number "<WorldLinkNumber>"
		And I go to the Trading system Sales and trade control code "<tradeControlCode>"
		And In TRS00701 I Add Postal Transaction Entry details as "<TransNumber>" "<SearchName>" 
	#Then In TRS00711 I Verify Certificate Selection details as "<CertID1>" "<Register1>" "<OptionPrice1>" "<CertBalance1>" "<AvailBal1>" "<CertID2>" "<Register2>" "<OptionPrice2>" "<CertBalance2>" "<AvailBal2>"
	When In TRS00702 I Add Postal Transaction Entry details as "<SellOption>" "<RemainingBalInd>" "<PaymentMethod>" "<PrefCurrency>" "<NotificationReqdInd>" "<Balance>" "<AvailBalance>"		
		And In TRS00707 I Add Postal Transaction Entry details as "<SellAll01>" "<ExerciseUnits01>" "<Units01>" "<SellAll02>" "<ExerciseUnits02>" "<Units02>" "<SellAll03>" "<ExerciseUnits03>" "<Units03>" "<SellAll04>" "<ExerciseUnits04>" "<Units04>"
		And In TRS00511 I Add Postal Transaction Entry details as "<DurationType>" "<EstMarketValue>"
		And In TRS00704 I Verify Postal Transaction Entry details as "<UnitsExercise>" "<UnitsSell>" "<EstMarketValue>" "<MarketValue>" "<PurchResidueAmt>" "<FederalTaxWithheld>" "<OptionCost>" "<ChargeAmount1>" "<ChargeAmount2>" "<ChargeAmount3>" "<TotalGst>" "<EstimatedProceeds>"
		And In TRS00703 I Add Postal Transaction Entry details as "<ExerciseUnits>" "<ConfirmUnits>" "<ConfirmWarningFlag5>"
		And In TRD00401 I Change Order Status to "<MenuSelection>" "<ConfirmStatus>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<SettlementDate>" "<FinalPrice>"
	Then In TRD004CS I Verify Change Order Status details1 as "<UnitsTraded>" "<TotalCost>" "<FinalPrice>" "<TradePrice>" "<PriceATAudit>" "<GrossAmount>" "<PurchaseResidue>" "<HolderCharges1>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>"
		And In TRD004CS I Verify Change Order Status details2 as "<LocalChqCount>" "<LocalChqNettAmount>" "<ForeignChqCount>" "<ForeignChqNettAmt>" "<WireCount>" "<WireNettAmount>" "<DirectBankingCount>" "<DirectBankNettAmt>" "<EmployerCount>" "<EmployerNettAmount>" "<CompanyCharges>" "<CompanyTax>" "<HolderCharges>" "<HolderTax>" "<ReportCharges>" "<ReportTax>" "<BankType>" "<BranchNumber>" "<AccountNumber>"
	When In TRD00101 I Run the Generate Output Job as "<PaymentAccount1>" "<OrderNO>" "<Ident>" "<ClassCode>" "<NbrTrades>" "<TradeGrossAmount>" "<TradeFrom>" "<TradeTO>" "<SettlementFrom>" "<SettlementTO>"
		And I wait for  GenerateOutput job to complete
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 240     | error        | DONE            | EXIT            |		
		And In TRD00401 I Apply Exercise Transaction as "<MenuSelection2>" "<ConfirmStatus2>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<SettlementDate>" "<FinalPrice>"
		And In TRD00401 I Force Settle the Order as "<MenuSelection1>" "<ConfirmStatus1>"
	Then In TRS01010 I Verify Transaction Enquiry details as "<TradingID>" "<Status>" "<Price>" "<ClassCode>" "<TransCount>" "<TransTotal>" "<MoneyTotal>" "<SettlementDate>" "<ApplyTaxInd>" "<PaymentMethod>" "<PaymentMethodDesc>" "<Currency>" "<SellUnits>" "<OrderType>" "<TradeUnits>" "<TransMoney>"
		And In TRDSCH02 I Verify Transaction Enquiry details as "<TradingID>" "<BulkType>" "<BulkTypeDesc>" "<StatusDesc>" "<TotalCount>" "<OrderTransUnits>" "<TotalMoney>" "<TradeDate>" "<ReqdSettlementDate>" "<ActualSettlementDate>" "<FinalPrice>" "<ReconciliationCode>" "<CshtrnReference>" "<MinimumDeal>" "<MaximumDeal>" "<CutOffTime>" "<CounterpartyClass>" "<CounterRegisterCode>" "<OrderType1>"
		And In TRDSCHCS I Verify Transaction Enquiry details1 as "<UnitsTraded>" "<TotalCost>" "<FinalPrice>" "<PriceATAudit>" "<GrossAmount>" "<PurchaseResidue>" "<HolderCharges1>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>"
		And In TRDSCHCS I Verify Transaction Enquiry details2 as "<LocalChqCount>" "<LocalChqNettAmount>" "<ForeignChqCount>" "<ForeignChqNettAmt>" "<WireCount>" "<WireNettAmount>" "<DirectBankingCount>" "<DirectBankNettAmt>" "<EmployerCount>" "<EmployerNettAmount>" "<CompanyCharges>" "<CompanyTax>" "<HolderCharges>" "<HolderTax>" "<ReportCharges>" "<ReportTax>" "<BankType>" "<BranchNumber>" "<AccountNumber>"
		And I go the Main Menu From Trading System
	#Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<OrderTransUnits>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"

Examples: 
		| ExerciseType                     | COY     | Multi-Cert | OnMarketTrade | BrokerCode | BrokerAccountID | ConnectionCode | RealTimeTrading | TopupPercentage | SellSelected | Option | TranType | Class | Reg | WorldLinkNumber | TransNumber | SearchName  | SellAll01 | ExerciseUnits01 | Units01 | SellAll02 | ExerciseUnits02 | Units02 | SellAll03 | ExerciseUnits03 | Units03 | SellAll04 | ExerciseUnits04 | Units04 | SellOption | RemainingBalInd | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance     | AvailBalance | DurationType | EstMarketValue | UnitsExercise | UnitsSell   | MarketValue | PurchResidueAmt | FederalTaxWithheld | OptionCost | LoanAmt | ChargeAmount1 | ChargeAmount2 | ChargeAmount3 | TotalGst | EstimatedProceeds | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | TotalUnits  | UnitsTraded | TotalCost | FinalPrice | TradePrice | PriceATAudit | GrossAmount | PurchaseResidue | HolderCharges1 | LoanAmount | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | LocalChqCount | LocalChqNettAmount | ForeignChqCount | ForeignChqNettAmt | WireCount | WireNettAmount | DirectBankingCount | DirectBankNettAmt | EmployerCount | EmployerNettAmount | CompanyCharges | CompanyTax | HolderCharges | HolderTax | ReportCharges | ReportTax | PaymentAccount | BankType | BranchNumber | AccountNumber | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal  | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits   | OrderType     | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal        | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1 | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | PaymentDate | CurrencyDesc       | PaymentMethod1 | TotalCharges | GstTaxTotal | MenuSelection2 | ConfirmStatus2 | Action1 | LocateArgument1 | BankCode | PayeeAccountNumber | AccountName | RemainingBalance | RemBalIndDesc    | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits  | TransMoney |
		| ExerciseSelected_Test3           | NAB2_AUTO | N          | M             | 3383       | CLS.GAP         | ORMSAUUAT      | Y               | 0.00            |              | C      | ESOXR    | ORD   | VIC | 123451234       |             | I0036534591 |           | 699             |         |           |                 |         |           |                 |         |           |                 |         | A          |                 | E             |              | N                   | 4000.000000 | 4000.000000  | 1            | 30.00          | 699.000000    | 699.000000  | 20970.00    |                 |                    | 13281.00   |         | 62.91         | 100.00        |               | 16.29    | 7509.80           |              |                     | C             | C             | 20/08/2015 | 10          | 00          | 20/08/2015     | 699.000000  | 699.000000  | 20970.00  | 30.000000  | 30.000000  | 30.000000    | 20970.00    |                 | 162.91         |            | 16.29 |             | 7509.80    | 62.91          | 100.00         |                |                |                |                |               |                    |                 |                   |           |                |                    |                   | 1             | 7509.80            |                |            | 162.91        | 16.29     |               |           |                |          |              |               | TSSAL           | OPT3    | NDF   | OPT       | 1         | 699.000000       |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 699.000000  | 7509.80    | Y           | Employer          | AUD      | 699.000000  | Sell Specific | S        | SALE         | Settled    | 1          | 699.000000      | 7509.80    | 20/08/2015         | 20/08/2015           | ESSOPT             |                 | 1.000000    | 99999999999.000000 | 10:00      | ORD               | VIC                 | Market     |       |       |       |       |       | 01     |                | 20/08/2015  | AUSTRALIAN DOLLAR  | Employer       | 162.91       | 16.29       | R              | R              | TH      | /OPT            |          |                    |             |                  |                  |                  |                 | ROPT             | 699.000000  | 7509.80    |
		
@TS_TradingSystem
@LoanPlanSales
@30881
@FullSmokeTest
@SmokeTestTradingLoanReal
Scenario Outline: Loan Real Time Sale SmokeTest
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
	Then In TRS01010 I Verify Transaction Enquiry details as "<TradingID>" "<Status>" "<Price>" "<ClassCode>" "<TransCount>" "<TransTotal>" "<MoneyTotal>" "<SettlementDate>" "<ApplyTaxInd>" "<PaymentMethod>" "<PaymentMethodDesc>" "<Currency>" "<SellUnits>" "<OrderType>" "<TradeUnits>" "<TradeMoney>"
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
				| Locate Argument | /ELA  |	 
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<TotalUnits>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"

Examples: 
		| SaleType          | COY     | OnMarketTrade | BrokerCode | BrokerAccountID | ConnectionCode | RealTimeTrading | TopupPercentage | SellSelected | Option | TranType | Class | Reg | WorldLinkNumber | SearchName  | SellOption | Units | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance     | AvailBalance | DurationType | EstMarketValue | UnitsSell   | MarketValue | PurchResidueAmt | FederalTaxWithheld | LoanAmt | ChargeAmount1 | ChargeAmount2 | ChargeAmount3 | TotalGst | EstimatedProceeds | OverrideEmailInd | EmailAddress               | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | TotalUnits  | UnitsTraded | TotalCost | FinalPrice | TradePrice | PriceATAudit | GrossAmount | PurchaseResidue | HolderCharges1 | LoanAmount | OptionCost | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | LocalChqCount | LocalChqNettAmount | ForeignChqCount | ForeignChqNettAmt | WireCount | WireNettAmount | DirectBankingCount | DirectBankNettAmt | EmployerCount | EmployerNettAmount | CompanyCharges | CompanyTax | HolderCharges | HolderTax | ReportCharges | ReportTax | PaymentAccount | BankType | BranchNumber | AccountNumber | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal  | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits   | OrderType     | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal        | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1                                                                                            | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | PaymentDate | CurrencyDesc       | PaymentMethod1 | TotalCharges | GstTaxTotal | BankCode | PayeeAccountNumber     | AccountName               | Cover01 | Cover02 | Cover03 | Cover04 | Cover05 | Cover06 | Cover07 | Cover08 | Cover09 | Cover10 | Cover11 | Cover12 | Cover13 | Cover14 | Cover15 | UnitsTraded1 | SellAll01 | Units01 | SellAll02 | Units02 | SellAll03 | Units03 | SellAll04 | Units04 | SellAll05 | Units05 | SellAll06 | Units06 | SellAll07 | Units07 | SellAll08 | Units08 | SellAll09 | Units09 | RemainingBalance | RemBalIndDesc | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits  | TradeMoney |
		| SellAll           | NAB2_AUTO | M             | 3383       | CLS.GAP         | ORMSAUUAT      | Y               | 0.00            | Y            | C      | ESTSC    | ORD   | VIC | 123451234       | I0036534036 | A          |       | C             | AUD          | E                   | 1500.000000 | 1500.000000  | 1            | 30.00          | 1500.000000 | 45000.00    |                 |                    | 3000.00 | 135.00        | 100.00        | 15.00         | 23.50    | 41726.50          | N                | REAL-TIME-HOLDER1@TEST.COM | 1500.000000  |                     | C             | C             | 20/08/2015 | 10          | 00          | 20/08/2015     | 1500.000000 | 1500.000000 | 45000.00  | 30.000000  | 30.000000  | 30.000000    | 45000.00    |                 | 250.00         | 3000.00    |            | 23.50 |             | 41726.50   | 135.00         | 100.00         |                |                | 15.00          |                | 1             | 41726.50           |                 |                   |           |                |                    |                   |               |                    |                |            | 250.00        | 23.50     |               |           |                |          |              |               | TSSAL           | ELA1    | NDF   | ELA       | 1         | 1500.000000      |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 1500.000000 | 41726.50   | Y           | Cheque Loc        | AUD      | 1500.000000 | Sell All      | S        | SALE         | Settled    | 1          | 1500.000000     | 41726.50   | 20/08/2015         | 20/08/2015           | ESSOPT             | 1562            | 1.000000    | 99999999999.000000 | 10:00      | ORD               | VIC                 | Market     | ELA Sale     RELA0000002  79269002 20/08/15 Set         1500.000000      41726.50      30.000000 |       |       |       |       | 01     |                | 20/08/2015  | AUSTRALIAN DOLLAR  | Cheque/Unpres  | 250.00       | 23.50       |          |                        |                           |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         | 1500.000000  |           |         |           |         |           |         |           |         |           |         |           |         |           |         |           |         |           |         |                  |               |                  |                 | RELA             | 1500.000000 | 41726.50   |


@TS_TradingSystem
@RightsPlanSales
@31035
@FullSmokeTest
@SmokeTestTradingRightsReal
Scenario Outline: Rights Real Time Sale SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to "Company Options" Control Code Menu
		And In HKS01516 I set the Multi-Cert Flag to "<Multi-Cert>"
		And I go to "Trading Control Codes" Control Code Menu
		And In TRD24000 I select the Trade Control Code "<tradeControlCode>"
		And In TRD24001 I perform a Change for On Market Trade "<OnMarketTrade>", "<BrokerCode>", "<BrokerAccountID>", "<ConnectionCode>", "<RealTimeTrading>" and Top Up "<TopupPercentage>", "<SellSelected>" and Remaining Balance Options "<Option>", "<TranType>", "<Class>", "<Reg>" and World Link Number "<WorldLinkNumber>"
		And I go to the Trading system Sales and trade control code "<tradeControlCode>"
		And In TRS00701 I Add Postal Transaction Entry details as "<TransNumber>" "<SearchName>" 
	#Then In TRS00711 I Verify Certificate Selection details as "<CertID1>" "<Register1>" "<OptionPrice1>" "<CertBalance1>" "<AvailBal1>" "<CertID2>" "<Register2>" "<OptionPrice2>" "<CertBalance2>" "<AvailBal2>"
	When In TRS00702 I Add Postal Transaction Entry details as "<SellOption>" "<RemainingBalInd>" "<PaymentMethod>" "<PrefCurrency>" "<NotificationReqdInd>" "<Balance>" "<AvailBalance>"		
		And In TRS00707 I Add Postal Transaction Entry details as "<SellAll01>" "<ExerciseUnits01>" "<Units01>" "<SellAll02>" "<ExerciseUnits02>" "<Units02>" "<SellAll03>" "<ExerciseUnits03>" "<Units03>" "<SellAll04>" "<ExerciseUnits04>" "<Units04>"
		And In TRS00511 I Add Postal Transaction Entry details as "<DurationType>" "<EstMarketValue>"
		And In TRS00704 I Verify Postal Transaction Entry details as "<UnitsExercise>" "<UnitsSell>" "<EstMarketValue>" "<MarketValue>" "<PurchResidueAmt>" "<FederalTaxWithheld>" "<OptionCost>" "<ChargeAmount1>" "<ChargeAmount2>" "<ChargeAmount3>" "<TotalGst>" "<EstimatedProceeds>"
		And In TRS00703 I Add Postal Transaction Entry details as "<ExerciseUnits>" "<ConfirmUnits>" "<ConfirmWarningFlag5>"
		And In TRD00401 I Change Order Status to "<MenuSelection>" "<ConfirmStatus>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<SettlementDate>" "<FinalPrice>"
	Then In TRD004CS I Verify Change Order Status details1 as "<UnitsTraded>" "<TotalCost>" "<FinalPrice>" "<TradePrice>" "<PriceATAudit>" "<GrossAmount>" "<PurchaseResidue>" "<HolderCharges1>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>"
		And In TRD004CS I Verify Change Order Status details2 as "<LocalChqCount>" "<LocalChqNettAmount>" "<ForeignChqCount>" "<ForeignChqNettAmt>" "<WireCount>" "<WireNettAmount>" "<DirectBankingCount>" "<DirectBankNettAmt>" "<EmployerCount>" "<EmployerNettAmount>" "<CompanyCharges>" "<CompanyTax>" "<HolderCharges>" "<HolderTax>" "<ReportCharges>" "<ReportTax>" "<BankType>" "<BranchNumber>" "<AccountNumber>"
	When In TRD00101 I Run the Generate Output Job as "<PaymentAccount1>" "<OrderNO>" "<Ident>" "<ClassCode>" "<NbrTrades>" "<TradeGrossAmount>" "<TradeFrom>" "<TradeTO>" "<SettlementFrom>" "<SettlementTO>"
		And I wait for  GenerateOutput job to complete
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 240     | error        | DONE            | EXIT            |
		And In TRD00401 I Apply Exercise Transaction as "<MenuSelection2>" "<ConfirmStatus2>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<SettlementDate>" "<FinalPrice>"
		And In TRD00401 I Force Settle the Order as "<MenuSelection1>" "<ConfirmStatus1>"
	Then In TRS01010 I Verify Transaction Enquiry details as "<TradingID>" "<Status>" "<Price>" "<ClassCode>" "<TransCount>" "<TransTotal>" "<MoneyTotal>" "<SettlementDate>" "<ApplyTaxInd>" "<PaymentMethod>" "<PaymentMethodDesc>" "<Currency>" "<SellUnits>" "<OrderType>" "<TradeUnits>" "<TransMoney>"
		And In TRDSCH02 I Verify Transaction Enquiry details as "<TradingID>" "<BulkType>" "<BulkTypeDesc>" "<StatusDesc>" "<TotalCount>" "<OrderTransUnits>" "<TotalMoney>" "<TradeDate>" "<ReqdSettlementDate>" "<ActualSettlementDate>" "<FinalPrice>" "<ReconciliationCode>" "<CshtrnReference>" "<MinimumDeal>" "<MaximumDeal>" "<CutOffTime>" "<CounterpartyClass>" "<CounterRegisterCode>" "<OrderType1>"
		And In TRDSCHCS I Verify Transaction Enquiry details1 as "<UnitsTraded>" "<TotalCost>" "<FinalPrice>" "<PriceATAudit>" "<GrossAmount>" "<PurchaseResidue>" "<HolderCharges1>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>"
		And In TRDSCHCS I Verify Transaction Enquiry details2 as "<LocalChqCount>" "<LocalChqNettAmount>" "<ForeignChqCount>" "<ForeignChqNettAmt>" "<WireCount>" "<WireNettAmount>" "<DirectBankingCount>" "<DirectBankNettAmt>" "<EmployerCount>" "<EmployerNettAmount>" "<CompanyCharges>" "<CompanyTax>" "<HolderCharges>" "<HolderTax>" "<ReportCharges>" "<ReportTax>" "<BankType>" "<BranchNumber>" "<AccountNumber>"
		And I go the Main Menu From Trading System
	#Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<TradeUnits>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"

Examples: 
		| ExerciseType          | COY       | Multi-Cert | OnMarketTrade | BrokerCode | BrokerAccountID | ConnectionCode | RealTimeTrading | TopupPercentage | SellSelected | Option | TranType | Class | Reg | WorldLinkNumber | TransNumber | SearchName  | SellAll01 | ExerciseUnits01 | Units01 | SellAll02 | ExerciseUnits02 | Units02 | SellAll03 | ExerciseUnits03 | Units03 | SellAll04 | ExerciseUnits04 | Units04 | SellOption | RemainingBalInd | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance     | AvailBalance | DurationType | EstMarketValue | UnitsExercise | UnitsSell  | MarketValue | PurchResidueAmt | FederalTaxWithheld | OptionCost | LoanAmt | ChargeAmount1 | ChargeAmount2 | ChargeAmount3 | TotalGst | EstimatedProceeds | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | TotalUnits  | UnitsTraded | TotalCost | FinalPrice | TradePrice | PriceATAudit | GrossAmount | PurchaseResidue | HolderCharges1 | LoanAmount | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | LocalChqCount | LocalChqNettAmount | ForeignChqCount | ForeignChqNettAmt | WireCount | WireNettAmount | DirectBankingCount | DirectBankNettAmt | EmployerCount | EmployerNettAmount | CompanyCharges | CompanyTax | HolderCharges | HolderTax | ReportCharges | ReportTax | PaymentAccount | BankType | BranchNumber | AccountNumber | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal  | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits  | OrderType    | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal        | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1 | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | PaymentDate | CurrencyDesc | PaymentMethod1 | TotalCharges | GstTaxTotal | MenuSelection2 | ConfirmStatus2 | Action1 | LocateArgument1 | BankCode | PayeeAccountNumber | AccountName | RemainingBalance | RemBalIndDesc | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits  | TransMoney |
		| ExercisePartial_Test5 | NAB2_AUTO | N          | M             | 3383       | CLS.GAP         | ORMSAUUAT      | Y               | 0.00            |              | C      | ESOXR    | ORD   | VIC | 123451234       |             | I0036535547 |           |                 |         |           |                 |         |           |                 |         |           | 1000            | 899     | P          | C               | C             | USD          | N                   | 4000.000000 | 3900.000000  | 1            | 30.00          | 1000.000000   | 899.000000 | 26970.00    |                 |                    |            |         | 80.91         | 100.00        | 40.00         | 18.09    | 26731.00          |              |                     | C             | C             | 20/08/2015 | 10          | 00          | 20/08/2015     | 1000.000000 | 899.000000  | 26970.00  | 30.000000  | 30.000000  | 30.000000    | 26970.00    |                 | 220.91         |            | 18.09 |             | 26731.00   | 80.91          | 100.00         |                |                |                | 40.00          |               |                    | 1               | 26731.00          |           |                |                    |                   |               |                    |                |            | 220.91        | 18.09     |               |           |                |          |              |               | TSSAL           | RGT5    | NDF   | PRS       | 1         | 1000.000000      |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 1000.000000 | 26731.00   | Y           | Cheque For        | USD      | 899.000000 | Sell Partial | S        | SALE         | Settled    | 1          | 1000.000000     | 26731.00   | 20/08/2015         | 20/08/2015           | ESSOPT             |                 | 1.000000    | 99999999999.000000 | 10:00      | ORD               | VIC                 | Market     |       |       |       |       |       | 01     |                | 20/08/2015  | US DOLLAR    | Foreign/Unpres | 220.91       | 18.09       | R              | R              | TH      | /PRS            |          |                    |             | 101.000000       | Issuer        | I0036535547      | ORD             | RPRS             | 1000.000000 | 26731.00   |


@TS_TradingSystem
@InvestorPlanSales
@31188
@FullSmokeTest
@SmokeTestTradingORDReal
Scenario Outline: Investor Trade Real Time Sale SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		#And I go to "Company Options" Control Code Menu
		#And In HKS01516 I set the Multi-Cert Flag to "<Multi-Cert>"
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
				| Locate Argument | /ORD  |	 
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<TradeUnits>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"

Examples: 
		| SaleType    | COY      | SearchName  | SellOption | Units | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance    | AvailBalance | DurationType | EstMarketValue | UnitsSell  | MarketValue | PurchResidueAmt | FederalTaxWithheld | LoanAmt | ChargeAmount1 | ChargeAmount2 | ChargeAmount3 | TotalGst | EstimatedProceeds | OverrideEmailInd | EmailAddress                        | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | TotalUnits | UnitsTraded | TotalCost | FinalPrice | TradePrice | PriceATAudit | GrossAmount | PurchaseResidue | HolderCharges1 | LoanAmount | OptionCost | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | LocalChqCount | LocalChqNettAmount | ForeignChqCount | ForeignChqNettAmt | WireCount | WireNettAmount | DirectBankingCount | DirectBankNettAmt | EmployerCount | EmployerNettAmount | CompanyCharges | CompanyTax | HolderCharges | HolderTax | ReportCharges | ReportTax | PaymentAccount | BankType | BranchNumber | AccountNumber | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits  | OrderType    | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal           | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1                                                                                            | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | PaymentDate | CurrencyDesc      | PaymentMethod1 | TotalCharges | GstTaxTotal | BankCode | PayeeAccountNumber | AccountName | Cover01 | Cover02 | Cover03 | Cover04 | Cover05 | Cover06 | Cover07 | Cover08 | Cover09 | Cover10 | Cover11 | Cover12 | Cover13 | Cover14 | Cover15 | Units1     | SellAll01 | Units01 | SellAll02 | Units02 | SellAll03 | Units03 | SellAll04 | Units04 | SellAll05 | Units05 | SellAll06 | Units06 | SellAll07 | Units07 | SellAll08 | Units08 | SellAll09 | Units09 | RemainingBalance | RemBalIndDesc | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits | TransMoney |
		| SellPartial | NAB2_AUTO  | I0035535926 | P          | 40    | D             | AUD          | E                   | 782.000000 | 782.000000   | 1            | 30.00          | 40.000000  | 1200.00     |                 |                    |         | 3.60          | 100.00        | 10.00         | 10.36    | 1076.04           | N                | TIWUQI.KOD._test@computershare.com  | 40.000000    | Y                   | C             | C             | 20/08/2015 | 10          | 00          | 20/08/2015     | 40.000000  | 40.000000   | 1200.00   | 30.000000  | 30.000000  | 30.000000    | 1200.00     |                 | 113.60         |            |            | 10.36 |             | 1076.04    | 3.60           | 100.00         |                | 10.00          |                |                |               |                    |                 |                   |           |                | 1                  | 1076.04           |               |                    |                |            | 113.60        | 10.36     |               |           |                |          |              |               | ITNAB           | ORD2    | NDF   | ORD       | 1         | 40.000000        |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 40.000000  | 1076.04    | Y           | Dir-Credit        | AUD      | 40.000000  | Sell Partial | S        | SALE         | Settled    | 1          | 40.000000       | 1076.04    | 20/08/2015         | 20/08/2015           | INVMSW             | 1533            | 1.000000    | 99999999999999.999900 | 10:00      | ORD               | VIC                 | Market     | ORD Sale     RORD0000003  79269012 20/08/15 Set           40.000000       1076.04      30.000000 |       |       |       |       | 01     |                | 20/08/2015  | AUSTRALIAN DOLLAR | Direct Banking | 113.60       | 10.36       | 083-054  | 000000000234567800 | T C C CIW   |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         | 40.000000  |           |         |           |         |           |         |           |         |           |         |           |         |           |         |           |         |           |         |                  |               |                  |                 | RORD             | 40.000000  | 1076.04    |


@TS_TradingSystem
@OptionsTransfers
@FullSmokeTest
@SmokeTestTradingOptionsTransfer
Scenario Outline: Options Transfers SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to "Company Options" Control Code Menu
		And In HKS01516 I set the Multi-Cert Flag to "<Multi-Cert>"
		And I go to "Trading Control Codes" Control Code Menu
		And In TRD24000 I select the Trade Control Code "<tradeControlCode>"
		And In TRD24001 I perform a Change for Remaining Balance Options "<Option>" "<TranType>" "<Class>" "<Reg>"
		And I go to the Trading system Transfers and trade control code "<tradeControlCode>"
		And In TRS00701 I Add Postal Transaction Entry details as "<TransNumber>" "<SearchName>" 
		And In TRS00702 I Add Postal Transaction Entry details as "<TransferOption>" "<RemainingBalInd>" "<PaymentMethod>" "<PrefCurrency>" "<NotificationReqdInd>" "<Balance>" "<AvailBalance>"		
		And In TRS00707 I Add Postal Transaction Entry details as "<SellAll01>" "<ExerciseUnits01>" "<Units01>" "<SellAll02>" "<ExerciseUnits02>" "<Units02>" "<SellAll03>" "<ExerciseUnits03>" "<Units03>" "<SellAll04>" "<ExerciseUnits04>" "<Units04>"
		And In TRS00703 I Add Postal Transaction Entry details as "<ExerciseUnits>" "<ConfirmUnits>" "<ConfirmWarningFlag5>"
		And In TRD00401 I Change Transfer Order Status to "<MenuSelection>" "<ConfirmStatus>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<FinalPrice>"
	When In TRD00101 I Run the Generate Output Job as "<PaymentAccount1>" "<OrderNO>" "<Ident>" "<ClassCode>" "<NbrTrades>" "<TradeGrossAmount>" "<TradeFrom>" "<TradeTO>" "<SettlementFrom>" "<SettlementTO>"
		And I wait for  GenerateOutput job to complete
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 240     | error        | DONE            | EXIT            |
		And In TRD00401 I Force Settle the Order as "<MenuSelection1>" "<ConfirmStatus1>"
	Then In TRS01010 I Verify Transaction Enquiry details as "<TradingID>" "<Status>" "<Price>" "<ClassCode>" "<TransCount>" "<TransTotal>" "<MoneyTotal>" "<SettlementDate>" "<ApplyTaxInd>" "<PaymentMethod>" "<PaymentMethodDesc>" "<Currency>" "<SellUnits>" "<OrderType>" "<TradeUnits>" "<TransMoney>"
		And In TRDSCH02 I Verify Transaction Enquiry details as "<TradingID>" "<BulkType>" "<BulkTypeDesc>" "<StatusDesc>" "<TotalCount>" "<OrderTransUnits>" "<TotalMoney>" "<TradeDate>" "<ReqdSettlementDate>" "<ActualSettlementDate>" "<FinalPrice>" "<ReconciliationCode>" "<CshtrnReference>" "<MinimumDeal>" "<MaximumDeal>" "<CutOffTime>" "<CounterpartyClass>" "<CounterRegisterCode>" "<OrderType1>"
		And I go the Main Menu From Trading System
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<TradeUnits>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"

Examples: 
		| ExerciseType                | COY     | Multi-Cert | Option | TranType | Class | Reg | TransNumber | SearchName  | SellAll01 | ExerciseUnits01 | Units01 | SellAll02 | ExerciseUnits02 | Units02 | SellAll03 | ExerciseUnits03 | Units03 | SellAll04 | ExerciseUnits04 | Units04 | TransferOption | RemainingBalInd | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance     | AvailBalance | ExerciseUnits | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | FinalPrice | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal  | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits   | OrderType     | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal           | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1 | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | UnitsSell   | GrossAmount | PurchaseResidue | LoanAmount | OptionCost | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | PaymentDate | PaymentAccount | CurrencyDesc | PaymentMethod1 | HolderCharges | HolderTax | CompanyCharges | CompanyTax | ReportCharges | ReportTax | TotalCharges | GstTaxTotal | Action1 | LocateArgument1 | BankCode | PayeeAccountNumber | AccountName | RemainingBalance | RemBalIndDesc    | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits  | TradeMoney |
		| HoldAll_Multi_N_Test1       | NAB2_AUTO | N          | C      | ESOXH    | ORD   | VIC |             | I0036534427 | Y         |                 |         |           |                 |         |           |                 |         |           |                 |         | A              | C               |               |              | N                   | 4000.000000 | 4000.000000  |               |              |                     | A             | A             | 20/08/2015 | 10          | 00          |                | 30.000000  | TSSAL           | TOP1    | NDF   | OPT       | 1         | 1000.000000      |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 1000.000000 | 10881.20   | Y           |                   | AUD      | 1000.000000 | Transfer All  | T        | TRADE        | Settled    | 1          | 1000.000000     | 10881.20   | 20/08/2015         | 20/08/2015           |                    |                 | 1.000000    | 99999999999999.990000 |            |                   |                     |            |       |       |       |       |       | 01     |                | 1000.000000 | 30000.00    |                 |            | 19000.00   | 10.80 |             | 19118.80   | 90.00          | 18.00          |                |                |                |                |             |                |              |                | 108.00        | 10.80     |                |            |               |           | 108.00       | 10.80       | TH      | /OPT            |          |                    |             | 1000.000000      | Issuer           | I0036534427      | ORD             | TOPT             | 1000.000000 |            |



@TS_TradingSystem
@RightsTransfers
@FullSmokeTest
@SmokeTestTradingRightsTransfer
Scenario Outline: Rights Transfers SmokeTest
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to "Company Options" Control Code Menu
		And In HKS01516 I set the Multi-Cert Flag to "<Multi-Cert>"
		And I go to "Trading Control Codes" Control Code Menu
		And In TRD24000 I select the Trade Control Code "<tradeControlCode>"
		And In TRD24001 I perform a Change for Remaining Balance Options "<Option>" "<TranType>" "<Class>" "<Reg>"
		And I go to the Trading system Transfers and trade control code "<tradeControlCode>"
		And In TRS00701 I Add Postal Transaction Entry details as "<TransNumber>" "<SearchName>" 
		And In TRS00702 I Add Postal Transaction Entry details as "<TransferOption>" "<RemainingBalInd>" "<PaymentMethod>" "<PrefCurrency>" "<NotificationReqdInd>" "<Balance>" "<AvailBalance>"		
		And In TRS00707 I Add Postal Transaction Entry details as "<SellAll01>" "<ExerciseUnits01>" "<Units01>" "<SellAll02>" "<ExerciseUnits02>" "<Units02>" "<SellAll03>" "<ExerciseUnits03>" "<Units03>" "<SellAll04>" "<ExerciseUnits04>" "<Units04>"
		And In TRS00703 I Add Postal Transaction Entry details as "<ExerciseUnits>" "<ConfirmUnits>" "<ConfirmWarningFlag5>"
		And In TRD00401 I Change Transfer Order Status to "<MenuSelection>" "<ConfirmStatus>" "<TradeDate>" "<TradeTimeHH>" "<TradeTimeMM>" "<FinalPrice>"
	When In TRD00101 I Run the Generate Output Job as "<PaymentAccount1>" "<OrderNO>" "<Ident>" "<ClassCode>" "<NbrTrades>" "<TradeGrossAmount>" "<TradeFrom>" "<TradeTO>" "<SettlementFrom>" "<SettlementTO>"
		And I wait for  GenerateOutput job to complete
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 240     | error        | DONE            | EXIT            |
		And In TRD00401 I Force Settle the Order as "<MenuSelection1>" "<ConfirmStatus1>"
	Then In TRS01010 I Verify Transaction Enquiry details as "<TradingID>" "<Status>" "<Price>" "<ClassCode>" "<TransCount>" "<TransTotal>" "<MoneyTotal>" "<SettlementDate>" "<ApplyTaxInd>" "<PaymentMethod>" "<PaymentMethodDesc>" "<Currency>" "<SellUnits>" "<OrderType>" "<TradeUnits>" "<TransMoney>"
		And In TRDSCH02 I Verify Transaction Enquiry details as "<TradingID>" "<BulkType>" "<BulkTypeDesc>" "<StatusDesc>" "<TotalCount>" "<OrderTransUnits>" "<TotalMoney>" "<TradeDate>" "<ReqdSettlementDate>" "<ActualSettlementDate>" "<FinalPrice>" "<ReconciliationCode>" "<CshtrnReference>" "<MinimumDeal>" "<MaximumDeal>" "<CutOffTime>" "<CounterpartyClass>" "<CounterRegisterCode>" "<OrderType1>"
		And I go the Main Menu From Trading System
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSTRD48 I should see trading history summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"	
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And In ENSTRDSH I Verify Trade History details1 as "<TradeUnits>" "<UnitsSell>" "<FinalPrice>" "<GrossAmount>" "<PurchaseResidue>" "<LoanAmount>" "<OptionCost>" "<Gst>" "<TaxWithheld>" "<NettAmount>" "<ChargeAmount01>" "<ChargeAmount02>" "<ChargeAmount03>" "<ChargeAmount04>" "<ChargeAmount05>" "<ChargeAmount06>" "<PaymentDate>" "<PaymentAccount>" 
		And In ENSTRDSH I Verify Trade History details2 as "<PrefCurrency>" "<CurrencyDesc>" "<PaymentMethod1>" "<HolderCharges>" "<HolderTax>" "<CompanyCharges>" "<CompanyTax>" "<ReportCharges>" "<ReportTax>" "<TotalCharges>" "<GstTaxTotal>" "<BankCode>" "<PayeeAccountNumber>" "<AccountName>" "<RemainingBalance>" "<RemBalIndDesc>" "<TransfereeHolder>" "<TransfereeClass>"

Examples: 
		| ExerciseType                | COY     | Multi-Cert | Option | TranType | Class | Reg | TransNumber | SearchName  | SellAll01 | ExerciseUnits01 | Units01 | SellAll02 | ExerciseUnits02 | Units02 | SellAll03 | ExerciseUnits03 | Units03 | SellAll04 | ExerciseUnits04 | Units04 | TransferOption | RemainingBalInd | PaymentMethod | PrefCurrency | NotificationReqdInd | Balance     | AvailBalance | ExerciseUnits | ConfirmUnits | ConfirmWarningFlag5 | MenuSelection | ConfirmStatus | TradeDate  | TradeTimeHH | TradeTimeMM | SettlementDate | FinalPrice | PaymentAccount1 | OrderNO | Ident | ClassCode | NbrTrades | TradeGrossAmount | TradeFrom | TradeTO | SettlementFrom | SettlementTO | MenuSelection1 | ConfirmStatus1 | TradingID | Status  | Price     | TransCount | TransTotal  | MoneyTotal | ApplyTaxInd | PaymentMethodDesc | Currency | SellUnits   | OrderType     | BulkType | BulkTypeDesc | StatusDesc | TotalCount | OrderTransUnits | TotalMoney | ReqdSettlementDate | ActualSettlementDate | ReconciliationCode | CshtrnReference | MinimumDeal | MaximumDeal           | CutOffTime | CounterpartyClass | CounterRegisterCode | OrderType1 | Line1 | Line2 | Line3 | Line4 | Line5 | Action | LocateArgument | UnitsSell   | GrossAmount | PurchaseResidue | LoanAmount | OptionCost | Gst   | TaxWithheld | NettAmount | ChargeAmount01 | ChargeAmount02 | ChargeAmount03 | ChargeAmount04 | ChargeAmount05 | ChargeAmount06 | PaymentDate | PaymentAccount | CurrencyDesc | PaymentMethod1 | HolderCharges | HolderTax | CompanyCharges | CompanyTax | ReportCharges | ReportTax | TotalCharges | GstTaxTotal | Action1 | LocateArgument1 | BankCode | PayeeAccountNumber | AccountName | RemainingBalance | RemBalIndDesc    | TransfereeHolder | TransfereeClass | tradeControlCode | TradeUnits  | TradeMoney |
		| HoldSpec_Multi_N_Test2      | NAB2_AUTO | N          | C      | ESOXH    | ORD   | VIC |             | I0036535768 |           |                 |         |           | 999             |         |           |                 |         |           |                 |         | S              | C               |               |              | N                   | 4000.000000 | 3900.000000  |               |              |                     | A             | A             | 20/08/2015 | 10          | 00          |                | 30.000000  | TSSAL           | TRT2    | NDF   | PRS       | 1         | 999.000000       |           |         | 20/08/2015     | 20/08/2015   | S              | S              |           | Settled | 30.000000 | 1          | 999.000000  | 29851.30   | Y           |                   | AUD      | 999.000000  | Tran Specific | T        | TRADE        | Settled    | 1          | 999.000000      | 29851.30   | 20/08/2015         | 20/08/2015           |                    |                 | 1.000000    | 99999999999999.990000 |            |                   |                     |            |       |       |       |       |       | 01     |                | 999.000000  | 29970.00    |                 |            |            | 10.79 |             | 118.70     | 89.91          | 18.00          |                |                |                |                |             |                |              |                | 107.91        | 10.79     |                |            |               |           | 107.91       | 10.79       | TH      | /PRS            |          |                    |             | 999.000000       | Issuer           | I0036535768      | ORD             | TPRS             | 999.000000  |            |

@winformsTest
@OL_Online
@CPU_AUTO
@35812
@OL_HKT_HousekeepingTransactions
@FullSmokeTest
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
		| Test1 | IRCHG   | 42415       | I0030047974 | FP        | VIC             | VICTORIA        | NSW             | NEW SOUTH WALES | R      | /FP            | FP /ORDINARY FULLY PAID SHARES    | NSW UNCERTIF'D   18/02/00 CTFXI  909/10141589            500  X0007165048                 |                  |                  |                  |                  |                  |                  |                  |                   |


@winformsTest
@OL_Online
@CPU_AUTO
@31324
@OL_HKT_HousekeepingTransactions
@FullSmokeTest
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
		| Test2 | BCCHG   | X0053284990      | 3664      | 11948885       | S         | 3383          | 1543          | FP        | VIC          | 3383        | 1543        | R      | /FP            | >       |                   | E00029344        3383 | E00029344        1543 |                   |                   |


@winformsTest
@OL_Online
@ANZ_AUTO
@21093
@21094
@OL_DPM_DividendPlanMaintenance
@FullSmokeTest
Scenario Outline: DividendplanIntention_Transactions
###Test Case 21093: 01 - OLS015 | Dividend and plan Intention Transactions - Add Dividend Plan Intention to a Holder ####
###Test Case 21094: 02 - OLS015 | Dividend and plan Intention Transactions - Modify Plan Intention for a Holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS01511 I continue with the following details:
		| Action   | SearchData   |
		| <Action> | <SearchData> |
		And In OLS01511 I continue with the following details:
		| Action    | SearchData    |
		| <Action1> | <SearchData1> |
		And In OLS01501 I continue with the following details:
		| TransNumber   | Date   | BspOpt1   | BspOpt2   | BspOpt3   | BspOpt4   | BspOpt5   | BspLev1   | BspLev2   | BspLev3   | BspLev4   | BspLev5   | DrpOpt1   | DrpOpt2   | DrpOpt3   | DrpOpt4   | DrpOpt5   | DrpLev1   | DrpLev2   | DrpLev3   | DrpLev4   | DrpLev5   | SourceOption   |
		| <TransNumber> | <Date> | <BspOpt1> | <BspOpt2> | <BspOpt3> | <BspOpt4> | <BspOpt5> | <BspLev1> | <BspLev2> | <BspLev3> | <BspLev4> | <BspLev5> | <DrpOpt1> | <DrpOpt2> | <DrpOpt3> | <DrpOpt4> | <DrpOpt5> | <DrpLev1> | <DrpLev2> | <DrpLev3> | <DrpLev4> | <DrpLev5> | <SourceOption> |
		And In OLS01502 I continue with the following details:
		| Confirm   |
		| <Confirm> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SearchData>
		And I enter the following details as the Locate action "<Action2>" "<LocateArgument>"
	Then In ENS01060 I verify the following details:
	| BspLine1   | BspLine2   | BspLine3   | BspLine4   | BspLine5   | SourceOption   | DrpLine1  | DrpLine2   | DrpLine3   | DrpLine4   | DrpLine5   |
	| <BspLine1> | <BspLine2> | <BspLine3> | <BspLine4> | <BspLine5> | <SourceOption> | <DrpLine1> | <DrpLine2> | <DrpLine3> | <DrpLine4> | <DrpLine5> |

		
	Examples: 
		| Test  | SelCode | Action | SearchData  | Action1 | SearchData1 | TransNumber | Date | BspOpt1 | BspOpt2 | BspOpt3 | BspOpt4 | BspOpt5 | BspLev1 | BspLev2 | BspLev3 | BspLev4 | BspLev5 | DrpOpt1 | DrpOpt2 | DrpOpt3 | DrpOpt4 | DrpOpt5 | DrpLev1 | DrpLev2 | DrpLev3 | DrpLev4 | DrpLev5 | SourceOption | Confirm | Action2 | LocateArgument | BspLine1                                                                     | BspLine2 | BspLine3 | BspLine4 | BspLine5                               | DrpLine1                                                                     | DrpLine2                               | DrpLine3                               | DrpLine4                               | DrpLine5                               |
		| Test1 | DIVIT   | s      | X0012230125 | U       |             | 42420       |      | P       |         |         |         |         | 30      |         |         |         |         | F       |         |         |         |         |         |         |         |         |         | D            |         | DI      |                | BOP1  1   BOP                                                              Y |          |          |          | BOP5  5   BONUS PLAN   NON PARTICIPANT | DRP1  1   DRP          20/07/15            7929      9865    F             N | DPN2  2   DRP PLAN     NON PARTICIPANT | DPN3  3   DRP PLAN     NON PARTICIPANT | DPN4  4   DRP PLAN     NON PARTICIPANT | DPN5  5   DRP PLAN     NON PARTICIPANT |


@winformsTest
@OL_Online
@ANZ_AUTO
@21334
@OL_DPM_DividendPlanMaintenance
@FullSmokeTest
Scenario Outline: Testcase21334_MNYIN_Transaction
###Test Case 21334: 01 - OLS050 and OLS051 | Plan Monetary Amount Changes  - Add MNYIN (Plan Money Increase) to a holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS05001 I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyPlan   | Buyer   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyPlan> | <Buyer> |
		And In OLS05002 I continue with the following details:
		| BuyPlan   | BuyPlanDesc   | BuyClass   | BuyClassDesc   | Buyer   | BuyDate   |
		| <BuyPlan> | <BuyPlanDesc> | <BuyClass> | <BuyClassDesc> | <Buyer> | <BuyDate> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <Buyer>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples: 
		| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyPlan | Buyer       | BuyPlanDesc | BuyClass | BuyClassDesc       | BuyDate    | Action | LocateArgument | CertificateLine1       | CertificateLine2                                                                    | CertificateLine3                                                                    | CertificateLine4                                                                     | CertificateLine5                                                                     | CertificateLine6                                                                    | CertificateLine7                                                                     | CertificateLine8                                                                    | CertificateLine9                             | CertificateLine10 |
		| Test3 | MNYIN   | 42425       |           | 66.66      | DRP1    | X0012230125 | DRP         | Z        | DRP RESIDUAL (ORD) | 19/07/2015 | C      | /Z             | Z  /DRP RESIDUAL (ORD) | *MR MONEY L/OVER 19/07/15         66.66                                             | **** Total for MONEY L/OVER            66.66                                        |                                                                                      |                                                                                      |                                                                                     |                                                                                      |                                                                                     |                                              |                   |


@winformsTest
@NAB2_AUTO
@35219
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 35219: 1_LPE. Lapse Options - Employee Initiated
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "lapse cancellation processing" Menu
		And In EOL00132 I Click on "lapse options employee initiated" Menu
		And In EOL02801 I Perform Options Lapse Transaction as "<TransNumber>" "<TransDate>" "<LapseCancelAll>" "<TotalUnits>" "<SearchName>" "<Unvested1>" "<Vested1>" "<Unvested2>" "<Vested2>" "<TotalUnvested>" "<TotalVested>" "<GrandTotal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| Test        | ClassCode | TransNumber | TransDate  | LapseCancelAll | TotalUnits | SearchName  | Unvested1 | Vested1 | Unvested2 | Vested2 | TotalUnvested | TotalVested | GrandTotal | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3 | BLine4                                                                                                    |
	| OPT-Partial | OPT       | 312020      | 20/08/2015 | N              | 500        | I0036135191 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |


@winformsTest
@NAB2_AUTO
@35313
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 35313: 1_RVE. ESS Option Exercise Reversal
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BeforeLine1>" "<BeforeLine2>" "<BeforeLine3>" "<BeforeLine4>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "ess option exercise reversal" Menu
		And In EOL00401 I perform Exercise Reversal Transaction as "<Selection>" "<RegisterCode>" "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| Test   | ClassCode | Selection | RegisterCode | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | SearchName  | Action | LocateArgument | PlanDesc                       | BeforeLine1                                                                                                                 | BeforeLine2 | BeforeLine3                                                                                               | BeforeLine4 | BLine1                                                                                                                      | BLine2 | BLine3                                                                                                    | BLine4 |
	| OPT-EE | OPT       | EE        | 13A          | 312041      | 1000       | 7841           | 79269020         | I0035984992 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000           0           0           0           0        1000           0           0 |             | ** Totals        1000           0           0           0           0        1000           0           0 |             | 13A EE   01/01/2013 HK Def         1000        1000           0        1000           0           0           0           0 |        | ** Totals        1000        1000           0        1000           0           0           0           0 |        |


@winformsTest
@NAB2_AUTO
@35346
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 35346: 1_ADD. Add Holder Event
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL03301 I Add Event details as "<EventNumber>" "<Selection>" "<Selection1>" "<TransNumber>" "<SearchName>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<CurrentBal1>" "<CurrentBal2>" "<SelectionInd1>" "<SelectionInd2>" "<TotEventUnits>" "<TotCurrentBal>" "<TotEventUnits1>" "<TotCurrentBal1>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test         | ClassCode | EventNumber | Selection | Selection1 | TransNumber | SearchName  | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | CurrentBal1 | CurrentBal2 | SelectionInd1 | SelectionInd2 | TotEventUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | TotEventUnits1 | TotCurrentBal1 | Line1                                                                            | Line2                                                                            | Line3 | Line4 | Line5 | Action1 |
	| Options Plan | OPT       | 4           | UPD       | ADD        | 312045      | I0033504021 | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000        | 1000        | Y             | Y             | 2000          | 2000          | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | 2000           | 2000           | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       | ESEH    |


@winformsTest
@NAB2_AUTO
@36805
@EP_EmployeePlanProcessing
@FullSmokeTest
@SmokeTestTemp
#Options Plan
Scenario Outline: Test Case 36805: 6_ELA. Add Holder Election Details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03401 I Select Holder as "<TransNumber>" "<SearchName>"
		And In EOL03401 I Add/Modify Event Election Details as "<DisposalChoice>" "<ExerciseUnits>" "<PartialUnits>" "<PymtMthd>" "<CurrencyCode>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<ExerciseBal1>" "<ExerciseBal2>" "<CurrentBal1>" "<CurrentBal2>" "<TotEventUnits>" "<TotExerciseUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test                   | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | DisposalChoice | ExerciseUnits | PartialUnits | PymtMthd | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | ExerciseBal1 | ExerciseBal2 | CurrentBal1 | CurrentBal2 | TotEventUnits | TotExerciseUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                                                                           | Line2                                                                                                                   | Line3 | Line4 | Line5 | CurrencyCode |
	| OPT-Exer-Sell All1     | OPT       | 4           | UPD       | ELA      | 24729       | I0035120696 | A              | 2000          |              | D        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Direct Credit         | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Direct Credit |       |       |       |              |


@winformsTest
@EnquiryTest
@NAB_AUTO
@16961
@EN_E_DisplayActions
@FullSmokeTest
@SmokeTestTemp
Scenario Outline: Test Case 16961: 04_A action with Extra Details_Dot
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | .     |
			| Locate Argument |       |
	Then In ENS01052 I should see NameAddress Extra Details as below "<HIN>" "<HolderOnDate>" "<HolderOffDate>" "<HolderAddedDate>" "<Version>" "<RunLastChange>" "<LastBalDump>" "<LastPaymentDump>" "<MergeTo>" "<MergeFrom>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENS01052 I should see NameAddress Extra Details as below "<HIN>" "<HolderOnDate>" "<HolderOffDate>" "<HolderAddedDate>" "<Version>" "<RunLastChange>" "<LastBalDump>" "<LastPaymentDump>" "<MergeTo>" "<MergeFrom>"

Examples: 
		| HIN         | HolderOnDate | HolderOffDate | HolderAddedDate | Version | RunLastChange | LastBalDump | LastPaymentDump | MergeTo     | MergeFrom |
		| I0030124936 | 24/06/1996   | 23/07/2001    | 24/06/1996      | 6       | 5284          | 0           | 0               | I0033340800 |           |


