Feature: PaymentsSystem
	Ensure PaymentsSystem Actions functionality covered

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Setup1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX   |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   |
		| <BuildRequired> | <ReconAccount> |
		And In DIVX1050 I setup the Dividend Control Update as:		
		| PlanScalebackApply   | StatementScripSeq   |
		| <PlanScalebackApply> | <StatementScripSeq> |
		And In DIVX1052 I setup the Dividend Control Update as:	
		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   |
		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |

Examples: 
		| Test     | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | Option2 | PlanScalebackApply | StatementScripSeq | CostShares | CertAllotDate | PlanStartRef | OverrideMnyClassInd | OverrideMnyBFClass | OverrideMnyCFClass | MinPartOption | MaxRestriction | TranTypeCode | TradeRef | DeductionCode1 | DeductionCodeInd1 | DeductionCode2 | DeductionCodeInd2 | DeductionCode3 | DeductionCodeInd3 | IntNbrDays1 | IntNbrDays2 | SubPayCodeX1 | PaymentsPerYear |
		| Payment1 |      | N       | 0010         | IN     | 0010 AUTOMATION TEST | D               | N                | Y                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     |         | Ordinary |         | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | Y              | ORD       | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | 1.10000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           | AUD          | B         | Y             | N              | Y               | Y            | 1.0             |              | N          |            | N            | T            | 9999            | N            | N                | S       | AUD          |               |           | 2               | GBP         | 0.66              | AUD->GBP          | N                  | Y             | GBR         |             | 99                | N                   | NZD         | 1.15              | AUD->NZD          | M                  |               | NZL         |             |                   |                     | N             |              | EX      |                    |                   |            |               |              |                     |                    |                    |               |                |              |          |                |                   |                |                   |                |                   |             |             | DIV1         | 1               |
		| Payment2 |      | N       | 0011         | IN     | 0011 AUTOMATION TEST | D               | N                | N                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | Y                 | 1       |         | DRP1          |               | I9999999104  | Y                 |          |          | Y          | Y          |                | I                |         |         | Ordinary |         | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | Y              | 01        | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | 1.10000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           | AUD          | B         | Y             | N              | Y               | Y            | 1.0             |              | N          |            | N            | T            | 9999            | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | N             |              | EX      | N                  | A                 |            |               |              | N                   |                    |                    | N             | N              |              |          |                | Y                 |                | Y                 |                | Y                 |             |             | DIV1         | 1               |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case DFA Setup
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And In PAS01000 I setup the Payment Account Number Details as:	
		| Action   | PayAccountNumber   | PaymentDesc   | PaymentDate   | PaymentType   | ImputationRate   | BaseCurrency   | DualCurrency   | PaidCurrency   | CombinedPayment   | ReconciliationAcct   | ReconBYCshare   | AccurateReconciled   | WebReporting   | DissenterAccountInd   | ReplaceAllowedInd   |
		| <Action> | <PayAccountNumber> | <PaymentDesc> | <PaymentDate> | <PaymentType> | <ImputationRate> | <BaseCurrency> | <DualCurrency> | <PaidCurrency> | <CombinedPayment> | <ReconciliationAcct> | <ReconBYCshare> | <AccurateReconciled> | <WebReporting> | <DissenterAccountInd> | <ReplaceAllowedInd> |
		And In PAS01004 I setup the Payment Account Number Details as:	
		| LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   |
		| <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> |
		And In PAS01005 I setup the Payment Account Number Details as:	
		| UnclaimedMoneyReport   | UnclaimedMoniesFileRecipientType   | PaymentAccountBalanced   | ReportGroup   | DepartmentCode   |
		| <UnclaimedMoneyReport> | <UnclaimedMoniesFileRecipientType> | <PaymentAccountBalanced> | <ReportGroup> | <DepartmentCode> |
		And In PAS01002 I setup the Payment Account Number Details as:	
		| AustTaxFlag   | AiirConvRateAus   | FinancialYear   | SubCoyCode   | InvestmentType   | NZTaxFlag   | ConversionRateNZ   | GbrTaxFlag   | ConversionRateGbr   | USTaxFlag   | ConversionRateUS   | USTaxYear   | IrlTaxFlag   | ConversionRateIrl   |  IrlTaxYear   | ZafTaxFlag   | ConversionRateZaf   | ZafTaxYear   | LastBatchChequeNbr   | LastBankTapeNbr   |
		| <AustTaxFlag> | <AiirConvRateAus> | <FinancialYear> | <SubCoyCode> | <InvestmentType> | <NZTaxFlag> | <ConversionRateNZ> | <GbrTaxFlag> | <ConversionRateGbr> | <USTaxFlag> | <ConversionRateUS> | <USTaxYear> | <IrlTaxFlag> | <ConversionRateIrl> |  <IrlTaxYear> | <ZafTaxFlag> | <ConversionRateZaf> | <ZafTaxYear> | <LastBatchChequeNbr> | <LastBankTapeNbr> |


Examples: 
		| Test  | Action | PayAccountNumber | PaymentDesc           | PaymentDate | PaymentType | ImputationRate | BaseCurrency | DualCurrency | PaidCurrency | CombinedPayment | ReconciliationAcct | ReconBYCshare | AccurateReconciled | WebReporting | DissenterAccountInd | ReplaceAllowedInd | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | UnclaimedMoneyReport | UnclaimedMoniesFileRecipientType | PaymentAccountBalanced | ReportGroup | DepartmentCode | AustTaxFlag | AiirConvRateAus | FinancialYear | SubCoyCode | InvestmentType | NZTaxFlag | ConversionRateNZ | GbrTaxFlag | ConversionRateGbr | USTaxFlag | ConversionRateUS | USTaxYear | IrlTaxFlag | ConversionRateIrl | IrlTaxYear | ZafTaxFlag | ConversionRateZaf | ZafTaxYear | LastBatchChequeNbr | LastBankTapeNbr |
		| Test1 | A      | 00020            | 00012 AUTOMATION TEST |             | D           | 30             | AUD          | N            |              | N               |                    | Y             | Y                  | Y            | Y                   | Y                 | 1                | 1                | 1               | 1               |                 | M              | A       | N                    |                                  |                        |             |                | N           |                 |               |            |                | N         |                  | N          |                   | N         |                  |           | N          |                   |            | N          |                   |            |                    |                 |

@winformsTest
@DIV_A
@PaymentsSystem
@FullSmokeTest
Scenario Outline: Test Case Dividend Setup-BSP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action    | ReinitiateSearch   | PaymentDate   | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action    | ReinitiateSearch   | PaymentDate   | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch1> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |		
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   |
		| <BuildRequired> | <ReconAccount> |
		And In DIVX1050 I setup the Dividend Control Update as:		
		| PlanScalebackApply   | StatementScripSeq   |
		| <PlanScalebackApply> | <StatementScripSeq> |
		And In DIVX1052 I setup the Dividend Control Update as:	
		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   |
		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply    | DcrProcessInd    | FgnChqApplyInd    | OrideFCThresInd    | CoyNamePrint    | OrideFCThresAmt    | DidcStartRef    | DISortFlag    | DCTapeDate    | SeparateBulk    | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply1> | <DcrProcessInd1> | <FgnChqApplyInd1> | <OrideFCThresInd1> | <CoyNamePrint1> | <OrideFCThresAmt1> | <DidcStartRef1> | <DISortFlag1> | <DCTapeDate1> | <SeparateBulk1> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   |
		| <BuildRequired> | <ReconAccount1> |
		And In DIVX1050 I setup the Dividend Control Update as:		
		| PlanScalebackApply   | StatementScripSeq   |
		| <PlanScalebackApply> | <StatementScripSeq> |
		And In DIVX1052 I setup the Dividend Control Update as:	
		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   |
		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |

Examples: 
		| Test     | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PlanScalebackApply | StatementScripSeq | CostShares | CertAllotDate | PlanStartRef | OverrideMnyClassInd | OverrideMnyBFClass | OverrideMnyCFClass | MinPartOption | MaxRestriction | TranTypeCode | TradeRef | DeductionCode1 | DeductionCodeInd1 | DeductionCode2 | DeductionCodeInd2 | DeductionCode3 | DeductionCodeInd3 | Option2 | Option3 | DIDCApply1 | DcrProcessInd1 | FgnChqApplyInd1 | OrideFCThresInd1 | CoyNamePrint1 | OrideFCThresAmt1 | DidcStartRef1 | DISortFlag1 | DCTapeDate1 | SeparateBulk1 | ReconAccount1 | ReinitiateSearch1 | IntNbrDays1 | IntNbrDays2 | SubPayCodeX1 | PaymentsPerYear |
		| Payment3 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00012            | A       |      | N       | 0012         | IN     | 0012 AUTOMATION TEST | D               | N                | N                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | Y                 | 1       |         | BSP1          |               | I9999999104  | Y                 |          |          | Y          | N          |                | I                |         |         | Ordinary |         | B       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | C0000000004         |                  |                  | N              | 01        | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | 1.1            |        |             |           | 30             |        |             |           |                |        |             |           | AUD          |           |               |                |                 |              |                 |              |            |            |              |              | 99              | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00012        | N                  | A                 | 0.33       |               |              |                     |                    |                    | N             | N              |              |          |                | Y                 |                | Y                 |                | Y                 | D       | EX      | D          | Y              | Y               | N                | Y             |                  | 999           |             |             | N             | 00112         | 00112             |             |             | DIV1         | 1               |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Interest Payment Setup
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action    | ReinitiateSearch   | PaymentDate   | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   |  SubPayCodeX   |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> |  <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   |
		| <BuildRequired> | <ReconAccount> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
Examples: 
		| Test     | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | Option2 | SubPayCodeX1 | PaymentsPerYear |
		| Payment4 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00013            | A       |      | N       | 0013         | IN     | 0013 AUTOMATION TEST | I               | N                | N                    | N                | N                | Y                   | INT1    | I       |         |         |             |             |          |                |            |           | N           |             |               |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | N          |            |                |                  | INT     |         | Interest |         | 30          |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | N               | N                | A            | N               | AUS         | I9999999104         |                  |                  | N              | INT       | INT1       | I           | (Interest)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 0.00000000      | R                |                  |              |                 |                 |                   | Y   | N   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | 1.1            |        |             |           |                |        |             |           |                |        |             |           | AUD          | B         | Y             | Y              | Y               | Y            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00013        | EX      | INT1         | 1               |

@winformsTest
@DIV_A
@DIV_Setup1
@PaymentsSystem
Scenario Outline: Test Case Distribution Payment Setup1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1016 I setup the Dividend Control Update as:
		| LoanClass1   | LoanClass2   | Percentage   |
		| <LoanClass1> | <LoanClass2> | <Percentage> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX   |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1042 I setup the Dividend Control Update as:
		| EmpHowPayCode   |
		| <EmpHowPayCode> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   |
		| <BuildRequired> | <ReconAccount> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |

Examples: 
		| Test     | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1             | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | Option2 | LoanClass1 | LoanClass2 | Percentage | EmpHowPayCode | SubPayCodeX1 | PaymentsPerYear |
		| Payment6 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00015            | A       |      | N       | 0015         | IN     | 0015 AUTOMATION TEST | D               | N                |                      | N                |                  | Y                   | DIS1    | S       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     |         | Ordinary            |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | N               |                  | A            | N               | AUS         | I9999999104         |                  |                  | N              | ORD       | DIS1       | S           | (Distribution)  | $1.10 payment rate | 1.10000000   | 0.00000000      | 0.00000000      | R                |                  |              |                 |                 |                   | N   | N   | N   | N   | N   | N   | N   | N   | N   | N    | Y    | N    | Y    | Y    | N    | 0.1            |        |             |           | 0.5            |        |             |           | 0.5            |        |             |           | AUD          | B         | Y             | Y              | Y               | N            | 1.0             | 9999         | N          |            | N            | T            | 9999            | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00015        | EX      |            |            |            |               | DIS1         | 1               |
		| Payment7 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00016            | A       |      | N       | 0016         | IN     | 0016 AUTOMATION TEST | D               | Y                |                      | N                |                  | Y                   | DIS1    | S       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | LON     |         | Employee Loan Class |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | N               |                  | A            | N               | AUS         | I9999999104         |                  |                  | N              | LON       | DIS1       | S           | (Distribution)  | $1.10 payment rate | 1.10000000   | 0.00000000      | 0.00000000      | R                |                  |              |                 |                 |                   | N   | N   | N   | N   | N   | N   | N   | N   | N   | N    | Y    | N    | Y    | Y    | N    | 0.1            |        |             |           | 0.5            |        |             |           | 0.5            |        |             |           | AUD          | B         | Y             | Y              | Y               | N            | 1.0             | 9999         | N          |            | N            | T            | 9999            | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00016        | EX      | LNM        |            | 50.0000000 | 80            | DIS1         | 1               |

@winformsTest
@DIV_A		
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-Dual Tax 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |


Examples: 
		| Test     | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | PaymentsPerYear |
		| Payment9 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00018            | A       |      | N       | 0018         | IN     | 0018 AUTOMATION TEST | D               | N                |                      | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     |         | Ordinary |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         | USA              | I9999999104      | N              | ORD       | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1         | 1.10000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           | AUD          | B         | Y             | Y              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00018        |                 |                 | EX      | 1               |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-Multiple Classes 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2    | SubPayCode    | PaymentType    | TypeDescription    | PaymentRateDesc1    | PaymentRate1    | AdditionalRate1    | ReportableRate1    | CompBrkdwnMethod    | PaymentRateDesc2    | PaymentRate2    | AdditionalRate2    | ReportableRate2    | CompBrkdwnMethod2    |
		| <ClassCat2A> | <SubPayCodeA> | <PaymentTypeA> | <TypeDescriptionA> | <PaymentRateDesc1A> | <PaymentRate1A> | <AdditionalRate1A> | <ReportableRate1A> | <CompBrkdwnMethodA> | <PaymentRateDesc2A> | <PaymentRate2A> | <AdditionalRate2A> | <ReportableRate2A> | <CompBrkdwnMethod2A> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    |
		| <ComponentRate11> | <Group11> | <InputGroup11> | <Sequence11> | <ComponentRate22> | <Group22> | <InputGroup22> | <Sequence22> | <ComponentRate33> | <Group33> | <InputGroup33> | <Sequence33> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |

Examples: 
		| Test      | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2    | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate11 | Group11 | InputGroup11 | Sequence11 | ComponentRate22 | Group22 | InputGroup22 | Sequence22 | ComponentRate33 | Group33 | InputGroup33 | Sequence33 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | SubPayCodeX1 | PaymentsPerYear | ClassCat2A | SubPayCodeA | PaymentTypeA | TypeDescriptionA | PaymentRateDesc1A  | PaymentRate1A | AdditionalRate1A | ReportableRate1A | CompBrkdwnMethodA | PaymentRateDesc2A | PaymentRate2A | AdditionalRate2A | ReportableRate2A | CompBrkdwnMethod2A |
		| Payment10 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00019            | A       |      | N       | 0019         | IN     | 0019 AUTOMATION TEST | D               | N                |                      | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     | OR7     | Ordinary | Ordinary-7 |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999104         |                  |                  | N              | ORD       | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 | R                 | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1        | 1.10000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           | 1.10000000      |         |              |            | 30.00000000     |         |              |            |                 |         |              |            | AUD          | B         | Y             | Y              | Y               | N            | 1.00            | 99           | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00019        |                 |                 | EX      | DIV1         | 1               | OR7        | DIV1        | D            | (Dividend)       | $1.10 payment rate | 1.10000000    | 0.00000000       | 30.00000000      | R                 |                   |               |                  |                  |                    |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-DRP-Multiple Classes-NoDFA
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2    | SubPayCode    | PaymentType    | TypeDescription    | PaymentRateDesc1    | PaymentRate1    | AdditionalRate1    | ReportableRate1    | CompBrkdwnMethod    | PaymentRateDesc2    | PaymentRate2    | AdditionalRate2    | ReportableRate2    | CompBrkdwnMethod2    |
		| <ClassCat2A> | <SubPayCodeA> | <PaymentTypeA> | <TypeDescriptionA> | <PaymentRateDesc1A> | <PaymentRate1A> | <AdditionalRate1A> | <ReportableRate1A> | <CompBrkdwnMethodA> | <PaymentRateDesc2A> | <PaymentRate2A> | <AdditionalRate2A> | <ReportableRate2A> | <CompBrkdwnMethod2A> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    |
		| <ComponentRate11> | <Group11> | <InputGroup11> | <Sequence11> | <ComponentRate22> | <Group22> | <InputGroup22> | <Sequence22> | <ComponentRate33> | <Group33> | <InputGroup33> | <Sequence33> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1050 I setup the Dividend Control Update as:		
		| PlanScalebackApply   | StatementScripSeq   |
		| <PlanScalebackApply> | <StatementScripSeq> |
		And In DIVX1052 I setup the Dividend Control Update as:	
		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   | CatCostShare1   | CatCostShare2   |
		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> | <CatCostShare1> | <CatCostShare2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |


Examples: 
		| Test      | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1       | ClsDsc2       | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate11 | Group11 | InputGroup11 | Sequence11 | ComponentRate22 | Group22 | InputGroup22 | Sequence22 | ComponentRate33 | Group33 | InputGroup33 | Sequence33 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | PlanScalebackApply | StatementScripSeq | CostShares | CertAllotDate | PlanStartRef | OverrideMnyClassInd | OverrideMnyBFClass | OverrideMnyCFClass | MinPartOption | MaxRestriction | TranTypeCode | TradeRef | DeductionCode1 | DeductionCodeInd1 | DeductionCode2 | DeductionCodeInd2 | DeductionCode3 | DeductionCodeInd3 | PaymentsPerYear | ClassCat2A | SubPayCodeA | PaymentTypeA | TypeDescriptionA | PaymentRateDesc1A  | PaymentRate1A | AdditionalRate1A | ReportableRate1A | CompBrkdwnMethodA | PaymentRateDesc2A | PaymentRate2A | AdditionalRate2A | ReportableRate2A | CompBrkdwnMethod2A | CatCostShare1 | CatCostShare2 |
		| Payment11 |      | N       | 0020         | IN     | 0020 AUTOMATION TEST | D               | N                |                      | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | Y                 | 1       | 4       | DRP1          | DRP4          | I9999999104  | Y                 |          |          | Y          | N          |                | I                |         |         | Ordinary - 01 | Ordinary - 04 |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | N              | 01        | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | Y   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1         | .60000000      |        |             |           | .50000000      |        |             |           | 30.00000000    |        |             |           | .60000000       |         |              |            | .50000000       |         |              |            | 30.00000000     |         |              |            | AUD          | B         | Y             | N              | Y               | N            | 1.0             | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | N             |              |                 |                 | EX      | N                  | A                 |            |               |              |                     |                    |                    | N             | N              |              |          |                | Y                 |                | Y                 |                | Y                 | 1               | 04         | DIV1        | D            | (Dividend)       | $1.10 payment rate | 1.10000000    | 0.00000000       | 30.00000000      | R                 |                   |               |                  |                  |                    |               |               |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-DRP-Multiple Classes-DFA
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action    | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1050 I setup the Dividend Control Update as:		
		| PlanScalebackApply   | StatementScripSeq   |
		| <PlanScalebackApply> | <StatementScripSeq> |
		And In DIVX1052 I setup the Dividend Control Update as:	
		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   |
		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |

Examples: 
		| Test      | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1       | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | PlanScalebackApply | StatementScripSeq | CostShares | CertAllotDate | PlanStartRef | OverrideMnyClassInd | OverrideMnyBFClass | OverrideMnyCFClass | MinPartOption | MaxRestriction | TranTypeCode | TradeRef | DeductionCode1 | DeductionCodeInd1 | DeductionCode2 | DeductionCodeInd2 | DeductionCode3 | DeductionCodeInd3 | PaymentsPerYear |
		| Payment12 |      | N       | 0021         | IN     | 0021 AUTOMATION TEST | D               | N                |                      | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | N                 | N                   | Y                 | 3       |         | DRP3          |               | I9999999104  | Y                 |          |          | Y          | N          |                | I                |         |         | Ordinary - 03 |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | N              | 03        | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1         | 1.10000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           | AUD          | B         | Y             | Y              | Y               | N            | 1.0             | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00021        |                 |                 | EX      |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00021            | A       | N                  | A                 | 0.33       |               |              |                     |                    |                    | N             | N              |              |          |                | Y                 |                | Y                 |                | Y                 | 1               |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Distribution Payment Setup-Payment13
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch    | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch1> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch    | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch2> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |		 
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2    | SubPayCode    | PaymentType    | TypeDescription    | PaymentRateDesc1    | PaymentRate1    | AdditionalRate1    | ReportableRate1    | CompBrkdwnMethod    | PaymentRateDesc2    | PaymentRate2    | AdditionalRate2    | ReportableRate2    | CompBrkdwnMethod2    |
		| <ClassCat2A> | <SubPayCodeA> | <PaymentTypeA> | <TypeDescriptionA> | <PaymentRateDesc1A> | <PaymentRate1A> | <AdditionalRate1A> | <ReportableRate1A> | <CompBrkdwnMethodA> | <PaymentRateDesc2A> | <PaymentRate2A> | <AdditionalRate2A> | <ReportableRate2A> | <CompBrkdwnMethod2A> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1    | Rn2    | Rn3    | Rn4    | Rn5    | Rn6    | Rn7    | Rn8    | Rn9    | Rn10    | Rn11    | Rn12    | Rn13    | Rn14    | Rn15    | SubPayCodeX     |
		| <Rn1A> | <Rn2A> | <Rn3A> | <Rn4A> | <Rn5A> | <Rn6A> | <Rn7A> | <Rn8A> | <Rn9A> | <Rn10A> | <Rn11A> | <Rn12A> | <Rn13A> | <Rn14A> | <Rn15A> | <SubPayCodeX1A> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    |
		| <ComponentRate1A> | <Group1A> | <InputGroup1A> | <Sequence1A> | <ComponentRate2A> | <Group2A> | <InputGroup2A> | <Sequence2A> | <ComponentRate3A> | <Group3A> | <InputGroup3A> | <Sequence3A> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    |
		| <ComponentRate1B> | <Group1B> | <InputGroup1B> | <Sequence1B> | <ComponentRate2B> | <Group2B> | <InputGroup2B> | <Sequence2B> | <ComponentRate3B> | <Group3B> | <InputGroup3B> | <Sequence3B> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    |
		| <ComponentRate1C> | <Group1C> | <InputGroup1C> | <Sequence1C> | <ComponentRate2C> | <Group2C> | <InputGroup2C> | <Sequence2C> | <ComponentRate3C> | <Group3C> | <InputGroup3C> | <Sequence3C> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |	
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |		

Examples: 
		| Test  | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2      | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2   | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | ClassCat2A | SubPayCodeA | PaymentTypeA | TypeDescriptionA | PaymentRateDesc1A  | PaymentRate1A | AdditionalRate1A | ReportableRate1A | CompBrkdwnMethodA | PaymentRateDesc2A  | PaymentRate2A | AdditionalRate2A | ReportableRate2A | CompBrkdwnMethod2A | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | Rn1A | Rn2A | Rn3A | Rn4A | Rn5A | Rn6A | Rn7A | Rn8A | Rn9A | Rn10A | Rn11A | Rn12A | Rn13A | Rn14A | Rn15A | SubPayCodeX1A | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate1A | Group1A | InputGroup1A | Sequence1A | ComponentRate2A | Group2A | InputGroup2A | Sequence2A | ComponentRate3A | Group3A | InputGroup3A | Sequence3A | ComponentRate1B | Group1B | InputGroup1B | Sequence1B | ComponentRate2B | Group2B | InputGroup2B | Sequence2B | ComponentRate3B | Group3B | InputGroup3B | Sequence3B | ComponentRate1C | Group1C | InputGroup1C | Sequence1C | ComponentRate2C | Group2C | InputGroup2C | Sequence2C | ComponentRate3C | Group3C | InputGroup3C | Sequence3C | PaymentsPerYear | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Action | ReinitiateSearch | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action2 | ReinitiateSearch1 | ReinitiateSearch2 | Option2 |
		| Test1 |      | N       | 0022         | IN     | 0022 AUTOMATION TEST | D               | N                | N                    | Y                | 2                | Y                   | DIS1    | S       | DIV1    | D       |             |             |          |                |            |           | N           |             |               |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     | OR7     | Ordinary | Ordinary - 7 |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999104         |                  |                  | N              | ORD       | DIS1       | S           | (Distribution)  | $1.10 payment rate | 1.10000000   | 0.00000000      | 0.00000000      | R                | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                 | OR7        | DIS1        | S            | (Distribution)   | $1.10 payment rate | 1.10000000    | 0.00000000       | 0.00000000       | R                 | $1.10 payment rate | 1.10000000    | 0.00000000       | 30.00000000      | R                  | N   | N   | N   | N   | N   | N   | N   | N   | N   | N    | Y    | Y    | Y    | N    | N    | DIS1         | Y    | Y    | N    | N    | N    | N    | N    | N    | N    | N     | N     | N     | N     | N     | N     | DIV1          | .30000000      |        |             |           | .40000000      |        |             |           | .40000000      |        |             |           | .30000000       |         |              |            | .40000000       |         |              |            | .40000000       |         |              |            | 1.10000000      |         |              |            | 30.00000000     |         |              |            |                 |         |              |            | 1.10000000      |         |              |            | 30.00000000     |         |              |            |                 |         |              |            | 2               | AUD          | B         | Y             | N              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00022        | 0022B           | 0022A           | S      | 00022            |              | 1                | 1                | 1               | 1               |                 | M              | C       | A       | 0022A             | 0022B             | EX      |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-Payment14
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
		And I update Payment Account Number Details as:
		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |		 
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   | ComponentRate4   | Group4   | InputGroup4   | Sequence4   | ComponentRate5   | Group5   | InputGroup5   | Sequence5   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> | <ComponentRate4> | <Group4> | <InputGroup4> | <Sequence4> | <ComponentRate5> | <Group5> | <InputGroup5> | <Sequence5> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1050 I setup the Dividend Control Update as:		
		| PlanScalebackApply   | StatementScripSeq   |
		| <PlanScalebackApply> | <StatementScripSeq> |
		And In DIVX1052 I setup the Dividend Control Update as:	
		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   |
		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |


Examples: 
		| Test  | Action | ReinitiateSearch | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | PaymentsPerYear | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1 | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1 | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate4 | Group4 | InputGroup4 | Sequence4 | ComponentRate5 | Group5 | InputGroup5 | Sequence5 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | PlanScalebackApply | StatementScripSeq | CostShares | CertAllotDate | PlanStartRef | OverrideMnyClassInd | OverrideMnyBFClass | OverrideMnyCFClass | MinPartOption | MaxRestriction | TranTypeCode | TradeRef | DeductionCode1 | DeductionCodeInd1 | DeductionCode2 | DeductionCodeInd2 | DeductionCode3 | DeductionCodeInd3 | Option2 |
		| Test1 | S      | 00023            |              | 1                | 1                | 1               | 1               |                 | M              | C       | A       |      | N       | 0023         | IN     | 0023 AUTOMATION TEST | D               | N                | N                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 | 1               | N                 | N                   | Y                 | 4       |         | DRP4          |               | I9999999104  | Y                 |          |          | Y          | N          |                | I                |         |         | DRP     |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | N              | 04        | DIV1       | D           | (Dividend)      | $1.10 cents      | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | Y   | Y   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1         | .30000000      |        |             |           | .40000000      |        |             |           | .40000000      |        |             |           | 30.00000000    |        |             |           |                |        |             |           | AUD          | B         | Y             | Y              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            |  N               | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00023        |                 |                 | N                  | A                 | .330000    |               |              |                     |                    |                    | N             | N              |              |          |                | Y                 |                | Y                 |                | Y                 | EX      |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-Payment16
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1030 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | 
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | 
		And In DIVX1031 I setup the Dividend Control Update as:
		| Seq1   | Seq2   | Seq3   | Seq4   | Seq5   | Action   | ControlHolderID   | ChargeCode   |
		| <Seq1> | <Seq2> | <Seq3> | <Seq4> | <Seq5> | <Action> | <ControlHolderID> | <ChargeCode> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2    | SubPayCode    | PaymentType    | TypeDescription    | PaymentRateDesc1    | PaymentRate1    | AdditionalRate1    | ReportableRate1    | CompBrkdwnMethod    | PaymentRateDesc2    | PaymentRate2    | AdditionalRate2    | ReportableRate2    | CompBrkdwnMethod2    |
		| <ClassCat2A> | <SubPayCodeA> | <PaymentTypeA> | <TypeDescriptionA> | <PaymentRateDesc1A> | <PaymentRate1A> | <AdditionalRate1A> | <ReportableRate1A> | <CompBrkdwnMethodA> | <PaymentRateDesc2A> | <PaymentRate2A> | <AdditionalRate2A> | <ReportableRate2A> | <CompBrkdwnMethod2A> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1    | Rn2    | Rn3    | Rn4    | Rn5    | Rn6    | Rn7    | Rn8    | Rn9    | Rn10    | Rn11    | Rn12    | Rn13    | Rn14    | Rn15    | SubPayCodeX     |
		| <Rn1A> | <Rn2A> | <Rn3A> | <Rn4A> | <Rn5A> | <Rn6A> | <Rn7A> | <Rn8A> | <Rn9A> | <Rn10A> | <Rn11A> | <Rn12A> | <Rn13A> | <Rn14A> | <Rn15A> | <SubPayCodeX1A> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   | ComponentRate4   | Group4   | InputGroup4   | Sequence4   | ComponentRate5   | Group5   | InputGroup5   | Sequence5   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> | <ComponentRate4> | <Group4> | <InputGroup4> | <Sequence4> | <ComponentRate5> | <Group5> | <InputGroup5> | <Sequence5> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    | ComponentRate4    | Group4    | InputGroup4    | Sequence4    | ComponentRate5    | Group5    | InputGroup5    | Sequence5    |
		| <ComponentRate1A> | <Group1A> | <InputGroup1A> | <Sequence1A> | <ComponentRate2A> | <Group2A> | <InputGroup2A> | <Sequence2A> | <ComponentRate3A> | <Group3A> | <InputGroup3A> | <Sequence3A> | <ComponentRate4A> | <Group4A> | <InputGroup4A> | <Sequence4A> | <ComponentRate5A> | <Group5A> | <InputGroup5A> | <Sequence5A> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1048 I setup the Dividend Control Update as:
		| BulkCode   |
		| <BulkCode> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |

Examples: 
		| Test  | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | PaymentsPerYear | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1        | ClsDsc2    | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | Seq1 | Seq2 | Seq3 | Seq4 | Seq5 | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1 | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | ClassCat2A | SubPayCodeA | PaymentTypeA | TypeDescriptionA | PaymentRateDesc1A | PaymentRate1A | AdditionalRate1A | ReportableRate1A | CompBrkdwnMethodA | PaymentRateDesc2A | PaymentRate2A | AdditionalRate2A | ReportableRate2A | CompBrkdwnMethod2A | Rn1A | Rn2A | Rn3A | Rn4A | Rn5A | Rn6A | Rn7A | Rn8A | Rn9A | Rn10A | Rn11A | Rn12A | Rn13A | Rn14A | Rn15A | SubPayCodeX1A | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate4 | Group4 | InputGroup4 | Sequence4 | ComponentRate5 | Group5 | InputGroup5 | Sequence5 | ComponentRate1A | Group1A | InputGroup1A | Sequence1A | ComponentRate2A | Group2A | InputGroup2A | Sequence2A | ComponentRate3A | Group3A | InputGroup3A | Sequence3A | ComponentRate4A | Group4A | InputGroup4A | Sequence4A | ComponentRate5A | Group5A | InputGroup5A | Sequence5A | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BulkCode | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | Action | ControlHolderID | ChargeCode |
		| Test1 |      | N       | 0025         | IN     | 0025 AUTOMATION TEST | D               | N                | N                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     | FP      | Ordinary class | fully paid |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | Y               | AUS         | I9999999104         |                  |                  | N              | N   | N   | Y   | N   | N   | N   |     |     |     |      |      |      |      |      |      | 1    |      |      |      |      | ORD       | DIV1       | D           | (Dividend)      | 0.05             | 0.05000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | FP         | DIV1        | D            | (Dividend)       | 0.02              | 0.02000000    | 0.00000000       | 30.00000000      | R                 |                   |               |                  |                  |                    | Y    | Y    | N    | N    | N    | N    | N    | N    | N    | N     | N     | N     | N     | N     | N     | DIV1          | 0.05000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           |                |        |             |           |                |        |             |           | 0.02000000      |         |              |            | 30.00000000     |         |              |            |                 |         |              |            |                 |         |              |            |                 |         |              |            | AUD          | B         | Y             | N              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | 88       | N             |              |                 |                 | EX      | 1      | C0000000002     | M00L       |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Dividend Payment Setup-Payment17
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   | ComponentRate4   | Group4   | InputGroup4   | Sequence4   | ComponentRate5   | Group5   | InputGroup5   | Sequence5   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> | <ComponentRate4> | <Group4> | <InputGroup4> | <Sequence4> | <ComponentRate5> | <Group5> | <InputGroup5> | <Sequence5> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |	
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2    | SubPayCode    | PaymentType    | TypeDescription    | PaymentRateDesc1    | PaymentRate1    | AdditionalRate1    | ReportableRate1    | CompBrkdwnMethod    | PaymentRateDesc2    | PaymentRate2    | AdditionalRate2    | ReportableRate2    | CompBrkdwnMethod2    |
		| <ClassCat2A> | <SubPayCodeA> | <PaymentTypeA> | <TypeDescriptionA> | <PaymentRateDesc1A> | <PaymentRate1A> | <AdditionalRate1A> | <ReportableRate1A> | <CompBrkdwnMethodA> | <PaymentRateDesc2A> | <PaymentRate2A> | <AdditionalRate2A> | <ReportableRate2A> | <CompBrkdwnMethod2A> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1    | Rn2    | Rn3    | Rn4    | Rn5    | Rn6    | Rn7    | Rn8    | Rn9    | Rn10    | Rn11    | Rn12    | Rn13    | Rn14    | Rn15    | SubPayCodeX    |
		| <Rn1A> | <Rn2A> | <Rn3A> | <Rn4A> | <Rn5A> | <Rn6A> | <Rn7A> | <Rn8A> | <Rn9A> | <Rn10A> | <Rn11A> | <Rn12A> | <Rn13A> | <Rn14A> | <Rn15A> | <SubPayCodeX2> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    | ComponentRate4    | Group4    | InputGroup4    | Sequence4    | ComponentRate5    | Group5    | InputGroup5    | Sequence5    |
		| <ComponentRate1A> | <Group1A> | <InputGroup1A> | <Sequence1A> | <ComponentRate2A> | <Group2A> | <InputGroup2A> | <Sequence2A> | <ComponentRate3A> | <Group3A> | <InputGroup3A> | <Sequence3A> | <ComponentRate4A> | <Group4A> | <InputGroup4A> | <Sequence4A> | <ComponentRate5A> | <Group5A> | <InputGroup5A> | <Sequence5A> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency    | DIDCApply    | DcrProcessInd    | FgnChqApplyInd    | OrideFCThresInd    | CoyNamePrint    | OrideFCThresAmt    | DidcStartRef    | DISortFlag    | DCTapeDate    | SeparateBulk    | ChequesApply    | ChequesStartRef    | TaxDescPrint    | ChqNumPreprinted    | MCApply    | PaidCurrency    | MCAllConvRate    | MCAllDesc    | NbrMultCurrency    | MCCurrency1    | MCConversionRate1    | MCConversionDesc1    | DirectCreditApply1    | ChequesApply1    | MCDomCode11    | MCDomCode12    | MCStartRefNumber1    | MCChqNumPreprinted1    | MCCurrency2    | MCConversionRate2    | MCConversionDesc2    | DirectCreditApply2    | ChequesApply2    | MCDomCode21    | MCDomCode22    | MCStartRefNumber2    | MCChqNumPreprinted2    |
		| <BaseCurrencyA> | <DIDCApplyA> | <DcrProcessIndA> | <FgnChqApplyIndA> | <OrideFCThresIndA> | <CoyNamePrintA> | <OrideFCThresAmtA> | <DidcStartRefA> | <DISortFlagA> | <DCTapeDateA> | <SeparateBulkA> | <ChequesApplyA> | <ChequesStartRefA> | <TaxDescPrintA> | <ChqNumPreprintedA> | <MCApplyA> | <PaidCurrencyA> | <MCAllConvRateA> | <MCAllDescA> | <NbrMultCurrencyA> | <MCCurrency1A> | <MCConversionRate1A> | <MCConversionDesc1A> | <DirectCreditApply1A> | <ChequesApply1A> | <MCDomCode11A> | <MCDomCode12A> | <MCStartRefNumber1A> | <MCChqNumPreprinted1A> | <MCCurrency2A> | <MCConversionRate2A> | <MCConversionDesc2A> | <DirectCreditApply2A> | <ChequesApply2A> | <MCDomCode21A> | <MCDomCode22A> | <MCStartRefNumber2A> | <MCChqNumPreprinted2A> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |

Examples: 
		| Test  | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | PaymentsPerYear | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate4 | Group4 | InputGroup4 | Sequence4 | ComponentRate5 | Group5 | InputGroup5 | Sequence5 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | ClassCat2A | SubPayCodeA | PaymentTypeA | TypeDescriptionA | PaymentRateDesc1A | PaymentRate1A | AdditionalRate1A | ReportableRate1A | CompBrkdwnMethodA | PaymentRateDesc2A | PaymentRate2A | AdditionalRate2A | ReportableRate2A | CompBrkdwnMethod2A | Rn1A | Rn2A | Rn3A | Rn4A | Rn5A | Rn6A | Rn7A | Rn8A | Rn9A | Rn10A | Rn11A | Rn12A | Rn13A | Rn14A | Rn15A | SubPayCodeX2 | ComponentRate1A | Group1A    | InputGroup1A | Sequence1A | ComponentRate2A | Group2A | InputGroup2A | Sequence2A | ComponentRate3A | Group3A | InputGroup3A | Sequence3A | ComponentRate4A | Group4A | InputGroup4A | Sequence4A | ComponentRate5A | Group5A | InputGroup5A | Sequence5A | BaseCurrencyA | DIDCApplyA | DcrProcessIndA | FgnChqApplyIndA | OrideFCThresIndA | CoyNamePrintA | OrideFCThresAmtA | DidcStartRefA | DISortFlagA | DCTapeDateA | SeparateBulkA | ChequesApplyA | ChequesStartRefA | TaxDescPrintA | ChqNumPreprintedA | MCApplyA | PaidCurrencyA | MCAllConvRateA | MCAllDescA | NbrMultCurrencyA | MCCurrency1A | MCConversionRate1A | MCConversionDesc1A | DirectCreditApply1A | ChequesApply1A | MCDomCode11A | MCDomCode12A | MCStartRefNumber1A | MCChqNumPreprinted1A | MCCurrency2A | MCConversionRate2A | MCConversionDesc2A | DirectCreditApply2A | ChequesApply2A | MCDomCode21A | MCDomCode22A | MCStartRefNumber2A | MCChqNumPreprinted2A |  Option3 |
		| Test1 |      | N       | 0026         | IN     | 0026 AUTOMATION TEST | D               | N                | N                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 |                 | N                 | Y                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     |         | Ordinary |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999104         |                  |                  | N              | ORD       | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | Y   | Y   | N   | N   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1         | 1.10000000     |        |             |           | 30.00000000    |        |             |           |                |        |             |           |                |        |             |           |                |        |             |           | AUD          | B         | Y             | N              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | N             |              |                 |                 | Z       | ORD        | DIV1        | D            | (Dividend)       | Ten cents         | .10000000     | 0.00000000       | 0.00000000       | R                 |                   |               |                  |                  |                    | N    | N    | Y    | N    | N    | N    | N    | N    | N    | N     | N     | N     | N     | N     | N     | DIV1         | .10000000       |            |               |           |                 |         |              |            |                 |         |              |            |                 |         |              |            |                 |         |              |            | ZAR           | N          |                |                 |                  |               |                  |               |             |             |               | T             | 99               | N             | N                 | N        |               |                |            |                  |              |                    |                    |                     |                |              |              |                    |                      |              |                    |                    |                     |                |              |              |                    |                      |  EX      |

@winformsTest
@DIV_A
@PaymentsSystem
Scenario Outline: Test Case Capital Payment Setup
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option   |
		| <Option> |
		And In DIVX1005 I setup the Dividend Control Update as:
		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
		And In DIVX1008 I setup the Dividend Control Update as:
		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
		And In DIVX1010 I setup the Dividend Control Update as:
		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
		And In DIVX1012 I setup the Dividend Control Update as:
		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
		And In DIVX1019 I setup the Dividend Control Update as:
		| ReduceRefClass   |
		| <ReduceRefClass> |
		And In DIVX1013 I setup the Dividend Control Update as:
		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1022 I setup the Dividend Control Update as:
		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
		And In DIVX1024 I setup the Dividend Control Update as:
		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
		And In DIVX1033 I setup the Dividend Control Update as:
		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
		And In DIVX1034 I setup the Dividend Control Update as:
		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
		And In DIVX1035 I setup the Dividend Control Update as:
		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   | ComponentRate4   | Group4   | InputGroup4   | Sequence4   | ComponentRate5   | Group5   | InputGroup5   | Sequence5   |
		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> | <ComponentRate4> | <Group4> | <InputGroup4> | <Sequence4> | <ComponentRate5> | <Group5> | <InputGroup5> | <Sequence5> |
		And In DIVX1040 I setup the Dividend Control Update as:
		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
		And In DIVX1060 I setup the Dividend Control Update as:
		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |

Examples: 
		| Test      | More | Preload | InputDivCode | Option | DividendDescription              | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | PaymentsPerYear | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ReduceRefClass | ClsDsc1 | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1 | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate4 | Group4 | InputGroup4 | Sequence4 | ComponentRate5 | Group5 | InputGroup5 | Sequence5 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 |
		| Payment18 |      | N       | 0030         | IN     | CAPITAL PAYMENT FOR REFUND CLASS | C               | N                | N                    | N                |                  | Y                   | CAP1    | C       |         |         |             |             |          |                |            |           | N           |             |               |                |                 |                 | N                 | N                   |                   |         |         |               |               |              |                   |          |          | Y          |            |                |                  | REF     |         | Y              | refund  |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | N               | N                | A            | N               | AUS         | I9999999104         |                  |                  | N              | REF       | CAP1       | C           | (Capital)       | 0.2              | .20000000    | 0.00000000      | 0.00000000      | R                |                  |              |                 |                 |                   | N   | N   | N   | Y   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | CAP1         | .20000000      |        |             |           |                |        |             |           |                |        |             |           |                |        |             |           |                |        |             |           | AUD          | B         | Y             | N              |                 | N            |                 | 99           | N          |            | N            | T            | 99              | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | N             |              |                 |                 | EX      |
		| Payment19 |      | N       | 0027         | IN     | CAPITAL PAYMENT FOR REFUND CLASS | C               | N                | N                    | N                |                  | Y                   | CAP1    | C       |         |         |             |             |          |                |            |           | N           |             |               |                |                 |                 | N                 | N                   |                   |         |         |               |               |              |                   |          |          | Y          |            |                |                  | REF     |         | N              | refund  |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | N               | N                | A            | N               | AUS         | I9999999104         |                  |                  | N              | REF       | CAP1       | C           | (Capital)       | 0.2              | .20000000    | 0.00000000      | 0.00000000      | R                |                  |              |                 |                 |                   | N   | N   | N   | Y   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | CAP1         | .20000000      |        |             |           |                |        |             |           |                |        |             |           |                |        |             |           |                |        |             |           | AUD          | B         | Y             | N              |                 | N            |                 | 99           | N          |            | N            | T            | 99              | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | N             |              |                 |                 | EX      |

#@ignore
#@DIV_A
#@PaymentsSystem
#Scenario Outline: Test Case Capital Payment Setup-EndtoEnd
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
#		And I update Payment Account Number Details as:
#		| Action    | ReinitiateSearch   | PaymentDate   | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
#		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
#		And In DIVX1001 I setup the Dividend Control Update as:
#		| More   | Preload   | InputDivCode   |
#		| <More> | <Preload> | <InputDivCode> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option   |
#		| <Option> |
#		And In DIVX1005 I setup the Dividend Control Update as:
#		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
#		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
#		And In DIVX1008 I setup the Dividend Control Update as:
#		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
#		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
#		And In DIVX1010 I setup the Dividend Control Update as:
#		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
#		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
#		And In DIVX1012 I setup the Dividend Control Update as:
#		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
#		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
#		And In DIVX1013 I setup the Dividend Control Update as:
#		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
#		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option1> |
#		And In DIVX1022 I setup the Dividend Control Update as:
#		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
#		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
#		And In DIVX1024 I setup the Dividend Control Update as:
#		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
#		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
#		And In DIVX1033 I setup the Dividend Control Update as:
#		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
#		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
#		And In DIVX1034 I setup the Dividend Control Update as:
#		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX   |
#		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
#		And In DIVX1035 I setup the Dividend Control Update as:
#		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
#		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
#		And In DIVX1040 I setup the Dividend Control Update as:
#		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
#		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
#		And In DIVX1060 I setup the Dividend Control Update as:
#		| BuildRequired   | ReconAccount   |
#		| <BuildRequired> | <ReconAccount> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 600     | error        | DONE            | EXIT            |            |             |
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection1> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 600     | error        | DONE            | EXIT            |            |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   |
#		| <NightlyRunInd> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName                | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_END_CALC_0014_D_DIV_A |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection2> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName                 | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_PAY_COMBINE_0014_DIV_A |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   | Action    |
#		| <NightlyRunInd> | <Action3> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            |            |             |
#Examples: 
#		| Test     | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | Option2 | Selection | Selection1 | NightlyRunInd | Selection2 | Action3 | SubPayCodeX1 | PaymentsPerYear |
#		| Payment5 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00014            | A       |      | N       | 0014         | IN     | 0014 AUTOMATION TEST | C               | N                | N                    | N                |                  | Y                   | CAP1    | C       |         |         |             |             |          |                |            |           | N           |             |               |                |                 | N                 | N                   |                   |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     |         | Ordinary |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | N               |                  | A            | N               | AUS         | I9999999104         |                  |                  | N              | ORD       | CAP1       | C           | (Capital)       | $1.10 payment rate | 1.10000000   | 0.00000000      | 0.00000000      | R                |                  |              |                 |                 |                   | N   | N   | N   | Y   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | 1.1            |        |             |           |                |        |             |           |                |        |             |           | AUD          | B         | Y             | Y              | Y               | Y            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00014        | EX      | APPS      | CALC       | Y             | BULD       | CONFIRM | CAP1         | 1               |

#@ignore
#@DIV_A
#@PaymentsSystem
#Scenario Outline: Test Case Dividend Payment Setup EndtoEnd
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
#		And I update Payment Account Number Details as:
#		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
#		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
#		And In DIVX1001 I setup the Dividend Control Update as:
#		| More   | Preload   | InputDivCode   |
#		| <More> | <Preload> | <InputDivCode> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option   |
#		| <Option> |
#		And In DIVX1005 I setup the Dividend Control Update as:
#		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
#		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
#		And In DIVX1008 I setup the Dividend Control Update as:
#		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
#		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
#		And In DIVX1010 I setup the Dividend Control Update as:
#		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
#		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
#		And In DIVX1012 I setup the Dividend Control Update as:
#		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
#		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
#		And In DIVX1013 I setup the Dividend Control Update as:
#		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
#		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option1> |
#		And In DIVX1022 I setup the Dividend Control Update as:
#		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
#		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
#		And In DIVX1024 I setup the Dividend Control Update as:
#		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
#		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
#		And In DIVX1033 I setup the Dividend Control Update as:
#		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
#		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
#		And In DIVX1033 I setup the Dividend Control Update as:
#		| ClassCat2    | SubPayCode    | PaymentType    | TypeDescription    | PaymentRateDesc1    | PaymentRate1    | AdditionalRate1    | ReportableRate1    | CompBrkdwnMethod    | PaymentRateDesc2    | PaymentRate2    | AdditionalRate2    | ReportableRate2    | CompBrkdwnMethod2    |
#		| <ClassCat2A> | <SubPayCodeA> | <PaymentTypeA> | <TypeDescriptionA> | <PaymentRateDesc1A> | <PaymentRate1A> | <AdditionalRate1A> | <ReportableRate1A> | <CompBrkdwnMethodA> | <PaymentRateDesc2A> | <PaymentRate2A> | <AdditionalRate2A> | <ReportableRate2A> | <CompBrkdwnMethod2A> |
#		And In DIVX1034 I setup the Dividend Control Update as:
#		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
#		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
#		And In DIVX1035 I setup the Dividend Control Update as:
#		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   | ComponentRate4   | Group4   | InputGroup4   | Sequence4   | ComponentRate5   | Group5   | InputGroup5   | Sequence5   |
#		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> | <ComponentRate4> | <Group4> | <InputGroup4> | <Sequence4> | <ComponentRate5> | <Group5> | <InputGroup5> | <Sequence5> |
#		And In DIVX1035 I setup the Dividend Control Update as:
#		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    | ComponentRate4    | Group4    | InputGroup4    | Sequence4    | ComponentRate5    | Group5    | InputGroup5    | Sequence5    |
#		| <ComponentRate1A> | <Group1A> | <InputGroup1A> | <Sequence1A> | <ComponentRate2A> | <Group2A> | <InputGroup2A> | <Sequence2A> | <ComponentRate3A> | <Group3A> | <InputGroup3A> | <Sequence3A> | <ComponentRate4A> | <Group4A> | <InputGroup4A> | <Sequence4A> | <ComponentRate5A> | <Group5A> | <InputGroup5A> | <Sequence5A> |
#		And In DIVX1040 I setup the Dividend Control Update as:
#		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
#		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
#		And In DIVX1060 I setup the Dividend Control Update as:
#		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
#		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
#		And In DIVX1050 I setup the Dividend Control Update as:		
#		| PlanScalebackApply   | StatementScripSeq   |
#		| <PlanScalebackApply> | <StatementScripSeq> |
#		And In DIVX1052 I setup the Dividend Control Update as:	
#		| CostShares   | CertAllotDate   | PlanStartRef   | OverrideMnyClassInd   | OverrideMnyBFClass   | OverrideMnyCFClass   | MinPartOption   | MaxRestriction   | TranTypeCode   | TradeRef   | DeductionCode1   | DeductionCodeInd1   | DeductionCode2   | DeductionCodeInd2   | DeductionCode3   | DeductionCodeInd3   | CatCostShare1   | CatCostShare2   |
#		| <CostShares> | <CertAllotDate> | <PlanStartRef> | <OverrideMnyClassInd> | <OverrideMnyBFClass> | <OverrideMnyCFClass> | <MinPartOption> | <MaxRestriction> | <TranTypeCode> | <TradeRef> | <DeductionCode1> | <DeductionCodeInd1> | <DeductionCode2> | <DeductionCodeInd2> | <DeductionCode3> | <DeductionCodeInd3> | <CatCostShare1> | <CatCostShare2> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   | CostSharesKnownInd   | KnowBefPayDateInd   |
#		| <Selection> | <CostSharesKnownInd> | <KnowBefPayDateInd> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 240     | error        | DONE            | EXIT            |            |             |
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection1> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 240     | error        | DONE            | EXIT            |            |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   |
#		| <NightlyRunInd> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName                | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_END_CALC_0024_D_DIV_A |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection    | CostShares1     | CostShares2     |
#		| <Selection3> | <CatCostShare1> | <CatCostShare1> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            |            |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   |
#		| <NightlyRunInd> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName              |DivJobName1				|
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_DIVLST_0024_D_DIV_A | DIV_PLNALT_0024_D_DIV_A |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection    |    
#		| <Selection4> | 
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName                 | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_PAY_COMBINE_0024_DIV_A |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   | Action    |
#		| <NightlyRunInd> | <Action3> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            |            |             |
#
#
#Examples: 
#		| Test      | Action | ReinitiateSearch | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | PaymentsPerYear | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1       | ClsDsc2       | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2 | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | ClassCat2A | SubPayCodeA | PaymentTypeA | TypeDescriptionA | PaymentRateDesc1A  | PaymentRate1A | AdditionalRate1A | ReportableRate1A | CompBrkdwnMethodA | PaymentRateDesc2A | PaymentRate2A | AdditionalRate2A | ReportableRate2A | CompBrkdwnMethod2A | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate4 | Group4 | InputGroup4 | Sequence4 | ComponentRate5 | Group5 | InputGroup5 | Sequence5 | ComponentRate1A | Group1A | InputGroup1A | Sequence1A | ComponentRate2A | Group2A | InputGroup2A | Sequence2A | ComponentRate3A | Group3A | InputGroup3A | Sequence3A | ComponentRate4A | Group4A | InputGroup4A | Sequence4A | ComponentRate5A | Group5A> | InputGroup5A | Sequence5A | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | PlanScalebackApply | StatementScripSeq | CostShares | CertAllotDate | PlanStartRef | OverrideMnyClassInd | OverrideMnyBFClass | OverrideMnyCFClass | MinPartOption | MaxRestriction | TranTypeCode | TradeRef | DeductionCode1 | DeductionCodeInd1 | DeductionCode2 | DeductionCodeInd2 | DeductionCode3 | DeductionCodeInd3 | CatCostShare1 | CatCostShare2 | Option2 | CostSharesKnownInd | KnowBefPayDateInd | Selection1 | Selection | NightlyRunInd | Selection3 | Selection4 | Action3 |
#		| Payment15 | S      | 00024            |              | 1                | 1                | 1               | 1               |                 | M              | C       | A       |      | N       | 0024         | IN     | 0024 AUTOMATION TEST | D               | N                | N                    | N                |                  | Y                   | DIV1    | D       |         |         |             |             |          |                |            |           | N           |             | N             |                |                 |                 | N                 | N                   | Y                 | 4       | 5       | DRP4          | DRP5          | I9999999104  | Y                 |          |          | Y          | N          |                | I                |         |         | Ordinary - 04 | Ordinary - 05 |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | N              | 04        | DIV1       | D           | (Dividend)      | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                |                  |              |                 |                 |                   | 05         | DIV1        | D            | (Dividend)       | $1.10 payment rate | 1.10000000    | 0.00000000       | 30.00000000      | R                 |                   |               |                  |                  |                    | Y   | Y   | N   | Y   | N   | N   | N   | N   | N   | N    | N    | N    | N    | N    | N    | DIV1         | .70000000      |        |             |           | .40000000      |        |             |           | 30.00000000    |        |             |           |                |        |             |           |                |        |             |           | .40000000       |         |              |            | .70000000       |         |              |            | 30.00000000     |         |              |            |                 |         |              |            |                 |          |              |            | AUD          | B         | Y             | Y              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00024        |                 |                 | N                  | A                 | .165000    |               |              |                     |                    |                    | N             | N              |              |          |                | Y                 |                | Y                 |                | Y                 | .165000       | .165000       | EX      | Y                  |                   | calc       | apps      | Y             | allt       | buld       | CONFIRM |

#@ignore
#@DIV_A
#@PaymentsSystem
#Scenario Outline: Test Case Distribution Payment Setup EndtoEnd
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
#		And I update Payment Account Number Details as:
#		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
#		| <Action> | <ReinitiateSearch> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
#		And I update Payment Account Number Details as:
#		| Action   | ReinitiateSearch   | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
#		| <Action> | <ReinitiateSearch1> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "define enquire on payment account" within the system Menu
#		And I update Payment Account Number Details as:
#		| Action   | ReinitiateSearch    | PaymentDate    | LineSelectionXOC   | LineSelectionXRC   | LineSelectionOD   | LineSelectionRD   | LineSelectionFC   | DcrReplaceType   | Action1   | Action2   |
#		| <Action> | <ReinitiateSearch2> | <PaymentDate1> | <LineSelectionXOC> | <LineSelectionXRC> | <LineSelectionOD> | <LineSelectionRD> | <LineSelectionFC> | <DcrReplaceType> | <Action1> | <Action2> |	
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
#		And In DIVX1001 I setup the Dividend Control Update as:
#		| More   | Preload   | InputDivCode   |
#		| <More> | <Preload> | <InputDivCode> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option   |
#		| <Option> |
#		And In DIVX1005 I setup the Dividend Control Update as:
#		| DividendDescription   | CorporateAction   | EmployeeDividend   | ElectronicStatements   | MultiplePayments   | NumberOFPayments   | AutomatedJobRelease   |
#		| <DividendDescription> | <CorporateAction> | <EmployeeDividend> | <ElectronicStatements> | <MultiplePayments> | <NumberOFPayments> | <AutomatedJobRelease> |
#		And In DIVX1008 I setup the Dividend Control Update as:
#		| SubPay1   | PayTyp1   | SubPay2   | PayTyp2   |
#		| <SubPay1> | <PayTyp1> | <SubPay2> | <PayTyp2> |
#		And In DIVX1010 I setup the Dividend Control Update as:
#		| BCRunNumber   | PaymentDate   | ListDate   | BooksCloseDate   | PaidTODate   | XtrFilnam   | RoundOption   | RndMultiple   | MandAllotment   | PlanDomRuleInd   | PlanTaxCodeRule   | PaymentsPerYear   |
#		| <BCRunNumber> | <PaymentDate> | <ListDate> | <BooksCloseDate> | <PaidTODate> | <XtrFilnam> | <RoundOption> | <RndMultiple> | <MandAllotment> | <PlanDomRuleInd> | <PlanTaxCodeRule> | <PaymentsPerYear> |
#		And In DIVX1012 I setup the Dividend Control Update as:
#		| AtoEftLgePayApply   | DividendSourceApply   | DividendPlanApply   | Selcat1   | Selcat2   | DividendPlan1   | DividendPlan2   | PlanHolderID   | DrpPrefOverBspInd   | Selreg11   | Selreg12   | HidTOPrint   | DeferBuild   | BuildDeferDate   | EomSelectionCode   | Selcls1   | Selcls2   |
#		| <AtoEftLgePayApply> | <DividendSourceApply> | <DividendPlanApply> | <Selcat1> | <Selcat2> | <DividendPlan1> | <DividendPlan2> | <PlanHolderID> | <DrpPrefOverBspInd> | <Selreg11> | <Selreg12> | <HidTOPrint> | <DeferBuild> | <BuildDeferDate> | <EomSelectionCode> | <Selcls1> | <Selcls2> |
#		And In DIVX1013 I setup the Dividend Control Update as:
#		| ClsDsc1   | ClsDsc2   | IntNbrDays1   | IntNbrDays2   |
#		| <ClsDsc1> | <ClsDsc2> | <IntNbrDays1> | <IntNbrDays2> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option1> |
#		And In DIVX1022 I setup the Dividend Control Update as:
#		| PaymentListingHead   | PaymentSequence   | ChequeAdviceSeq   | ReturnMailApply   | UnissuedChqApply   | TfnPrintFlag   | DeductionsApply   |
#		| <PaymentListingHead> | <PaymentSequence> | <ChequeAdviceSeq> | <ReturnMailApply> | <UnissuedChqApply> | <TfnPrintFlag> | <DeductionsApply> |
#		And In DIVX1024 I setup the Dividend Control Update as:
#		| TaxCtryCode   | TaxHolderIdentifier   | OtherTaxCtryCode   | OtherTaxHolderID   | FundDistTaxInd   |
#		| <TaxCtryCode> | <TaxHolderIdentifier> | <OtherTaxCtryCode> | <OtherTaxHolderID> | <FundDistTaxInd> |
#		And In DIVX1033 I setup the Dividend Control Update as:
#		| ClassCat2   | SubPayCode   | PaymentType   | TypeDescription   | PaymentRateDesc1   | PaymentRate1   | AdditionalRate1   | ReportableRate1   | CompBrkdwnMethod   | PaymentRateDesc2   | PaymentRate2   | AdditionalRate2   | ReportableRate2   | CompBrkdwnMethod2   |
#		| <ClassCat2> | <SubPayCode> | <PaymentType> | <TypeDescription> | <PaymentRateDesc1> | <PaymentRate1> | <AdditionalRate1> | <ReportableRate1> | <CompBrkdwnMethod> | <PaymentRateDesc2> | <PaymentRate2> | <AdditionalRate2> | <ReportableRate2> | <CompBrkdwnMethod2> |
#		And In DIVX1034 I setup the Dividend Control Update as:
#		| Rn1   | Rn2   | Rn3   | Rn4   | Rn5   | Rn6   | Rn7   | Rn8   | Rn9   | Rn10   | Rn11   | Rn12   | Rn13   | Rn14   | Rn15   | SubPayCodeX    |
#		| <Rn1> | <Rn2> | <Rn3> | <Rn4> | <Rn5> | <Rn6> | <Rn7> | <Rn8> | <Rn9> | <Rn10> | <Rn11> | <Rn12> | <Rn13> | <Rn14> | <Rn15> | <SubPayCodeX1> |
#		And In DIVX1034 I setup the Dividend Control Update as:
#		| Rn1    | Rn2    | Rn3    | Rn4    | Rn5    | Rn6    | Rn7    | Rn8    | Rn9    | Rn10    | Rn11    | Rn12   | Rn13    | Rn14    | Rn15    | SubPayCodeX    |
#		| <Rn1a> | <Rn2a> | <Rn3a> | <Rn4a> | <Rn5a> | <Rn6a> | <Rn7a> | <Rn8a> | <Rn9a> | <Rn10a> | <Rn11a> | <Rn12a> | <Rn13a> | <Rn14a> | <Rn15a>| <SubPayCodeX2> |
#		And In DIVX1035 I setup the Dividend Control Update as:
#		| ComponentRate1   | Group1   | InputGroup1   | Sequence1   | ComponentRate2   | Group2   | InputGroup2   | Sequence2   | ComponentRate3   | Group3   | InputGroup3   | Sequence3   |
#		| <ComponentRate1> | <Group1> | <InputGroup1> | <Sequence1> | <ComponentRate2> | <Group2> | <InputGroup2> | <Sequence2> | <ComponentRate3> | <Group3> | <InputGroup3> | <Sequence3> |
#		And In DIVX1035 I setup the Dividend Control Update as:
#		| ComponentRate1    | Group1    | InputGroup1    | Sequence1    | ComponentRate2    | Group2    | InputGroup2    | Sequence2    | ComponentRate3    | Group3    | InputGroup3    | Sequence3    |
#		| <ComponentRate11> | <Group11> | <InputGroup11> | <Sequence11> | <ComponentRate22> | <Group22> | <InputGroup22> | <Sequence22> | <ComponentRate33> | <Group33> | <InputGroup33> | <Sequence33> |
#		And In DIVX1040 I setup the Dividend Control Update as:
#		| BaseCurrency   | DIDCApply   | DcrProcessInd   | FgnChqApplyInd   | OrideFCThresInd   | CoyNamePrint   | OrideFCThresAmt   | DidcStartRef   | DISortFlag   | DCTapeDate   | SeparateBulk   | ChequesApply   | ChequesStartRef   | TaxDescPrint   | ChqNumPreprinted   | MCApply   | PaidCurrency   | MCAllConvRate   | MCAllDesc   | NbrMultCurrency   | MCCurrency1   | MCConversionRate1   | MCConversionDesc1   | DirectCreditApply1   | ChequesApply1   | MCDomCode11   | MCDomCode12   | MCStartRefNumber1   | MCChqNumPreprinted1   | MCCurrency2   | MCConversionRate2   | MCConversionDesc2   | DirectCreditApply2   | ChequesApply2   | MCDomCode21   | MCDomCode22   | MCStartRefNumber2   | MCChqNumPreprinted2   |
#		| <BaseCurrency> | <DIDCApply> | <DcrProcessInd> | <FgnChqApplyInd> | <OrideFCThresInd> | <CoyNamePrint> | <OrideFCThresAmt> | <DidcStartRef> | <DISortFlag> | <DCTapeDate> | <SeparateBulk> | <ChequesApply> | <ChequesStartRef> | <TaxDescPrint> | <ChqNumPreprinted> | <MCApply> | <PaidCurrency> | <MCAllConvRate> | <MCAllDesc> | <NbrMultCurrency> | <MCCurrency1> | <MCConversionRate1> | <MCConversionDesc1> | <DirectCreditApply1> | <ChequesApply1> | <MCDomCode11> | <MCDomCode12> | <MCStartRefNumber1> | <MCChqNumPreprinted1> | <MCCurrency2> | <MCConversionRate2> | <MCConversionDesc2> | <DirectCreditApply2> | <ChequesApply2> | <MCDomCode21> | <MCDomCode22> | <MCStartRefNumber2> | <MCChqNumPreprinted2> |
#		And In DIVX1060 I setup the Dividend Control Update as:
#		| BuildRequired   | ReconAccount   | PaymentAccount1   | PaymentAccount2   |
#		| <BuildRequired> | <ReconAccount> | <PaymentAccount1> | <PaymentAccount2> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option2> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   | CostSharesKnownInd   | KnowBefPayDateInd   |
#		| <Selection> | <CostSharesKnownInd> | <KnowBefPayDateInd> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 240     | error        | DONE            | EXIT            |            |             |
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection1> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 240     | error        | DONE            | EXIT            |            |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   |
#		| <NightlyRunInd> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName                | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_END_CALC_0017_D_DIV_A |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "payment job release monitor" within the system Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection2> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName                 | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            | DIV_PAY_COMBINE_0017_DIV_A |             |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   | Action    |
#		| <NightlyRunInd> | <Action3> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit URR report for Dividend Job
#		| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX | DivJobName | DivJobName1 |
#		| completion   | 800     | error        | DONE            | EXIT            |            |             |
#
#		
#
#Examples: 
#		| Test     | PaymentDate1 | LineSelectionXOC | LineSelectionXRC | LineSelectionOD | LineSelectionRD | LineSelectionFC | DcrReplaceType | Action1 | Action | ReinitiateSearch | Action2 | More | Preload | InputDivCode | Option | DividendDescription  | CorporateAction | EmployeeDividend | ElectronicStatements | MultiplePayments | NumberOFPayments | AutomatedJobRelease | SubPay1 | PayTyp1 | SubPay2 | PayTyp2 | BCRunNumber | PaymentDate | ListDate | BooksCloseDate | PaidTODate | XtrFilnam | RoundOption | RndMultiple | MandAllotment | PlanDomRuleInd | PlanTaxCodeRule | AtoEftLgePayApply | DividendSourceApply | DividendPlanApply | Selcat1 | Selcat2 | DividendPlan1 | DividendPlan2 | PlanHolderID | DrpPrefOverBspInd | Selreg11 | Selreg12 | HidTOPrint | DeferBuild | BuildDeferDate | EomSelectionCode | Selcls1 | Selcls2 | ClsDsc1  | ClsDsc2 | IntNbrDays1 | IntNbrDays2 | Option1 | PaymentListingHead       | PaymentSequence | ChequeAdviceSeq | ReturnMailApply | UnissuedChqApply | TfnPrintFlag | DeductionsApply | TaxCtryCode | TaxHolderIdentifier | OtherTaxCtryCode | OtherTaxHolderID | FundDistTaxInd | ClassCat2 | SubPayCode | PaymentType | TypeDescription | PaymentRateDesc1   | PaymentRate1 | AdditionalRate1 | ReportableRate1 | CompBrkdwnMethod | PaymentRateDesc2   | PaymentRate2 | AdditionalRate2 | ReportableRate2 | CompBrkdwnMethod2 | Rn1 | Rn2 | Rn3 | Rn4 | Rn5 | Rn6 | Rn7 | Rn8 | Rn9 | Rn10 | Rn11 | Rn12 | Rn13 | Rn14 | Rn15 | SubPayCodeX1 | Rn1a | Rn2a | Rn3a | Rn4a | Rn5a | Rn6a | Rn7a | Rn8a | Rn9a | Rn10a | Rn11a | Rn12a | Rn13a | Rn14a | Rn15a | SubPayCodeX2 | ComponentRate1 | Group1 | InputGroup1 | Sequence1 | ComponentRate2 | Group2 | InputGroup2 | Sequence2 | ComponentRate3 | Group3 | InputGroup3 | Sequence3 | ComponentRate11 | Group11 | InputGroup11 | Sequence11 | ComponentRate22 | Group22 | InputGroup22 | Sequence22 | ComponentRate33 | Group33 | InputGroup33 | Sequence33 | BaseCurrency | DIDCApply | DcrProcessInd | FgnChqApplyInd | OrideFCThresInd | CoyNamePrint | OrideFCThresAmt | DidcStartRef | DISortFlag | DCTapeDate | SeparateBulk | ChequesApply | ChequesStartRef | TaxDescPrint | ChqNumPreprinted | MCApply | PaidCurrency | MCAllConvRate | MCAllDesc | NbrMultCurrency | MCCurrency1 | MCConversionRate1 | MCConversionDesc1 | DirectCreditApply1 | ChequesApply1 | MCDomCode11 | MCDomCode12 | MCStartRefNumber1 | MCChqNumPreprinted1 | MCCurrency2 | MCConversionRate2 | MCConversionDesc2 | DirectCreditApply2 | ChequesApply2 | MCDomCode21 | MCDomCode22 | MCStartRefNumber2 | MCChqNumPreprinted2 | BuildRequired | ReconAccount | PaymentAccount1 | PaymentAccount2 | Option2 | ReinitiateSearch1 | ReinitiateSearch2 | PaymentsPerYear | Selection | CostSharesKnownInd | KnowBefPayDateInd | Selection1 | Selection2 | Action3 | NightlyRunInd |
#		| Payment8 |              | 1                | 1                | 1               | 1               |                 | M              | C       | S      | 00017            | A       |      | N       | 0017         | IN     | 0017 AUTOMATION TEST | D               | N                |                      | Y                | 2                | Y                   | DIS1    | S       | DIV1    | D       |             |             |          |                |            |           | N           |             |               |                |                 | N                 | N                   | N                 |         |         |               |               |              |                   |          |          | Y          |            |                |                  | ORD     |         | Ordinary |         |             |             | D       | DIVIDEND PAYMENT LISTING | A               | A               | Y               | Y                | A            | N               | AUS         | I9999999112         |                  |                  | N              | ORD       | DIS1       | S           | (Distribution)  | $1.10 payment rate | 1.10000000   | 0.00000000      | 0.00000000      | R                | $1.10 payment rate | 1.10000000   | 0.00000000      | 30.00000000     | R                 | N   | N   | N   | N   | N   | N   | N   | N   | N   | N    | Y    | N    | Y    | Y    | N    | DIS1         | Y    | Y    | N    | N    | N    | N    | N    | N    | N    | N     | N     | N     | N     | N     | N     | DIV1         | .30000000      |        |             |           | .40000000      |        |             |           | .40000000      |        |             |           | 1.10000000      |         |              |            | 30.00000000     |         |              |            |                 |         |              |            | AUD          | B         | Y             | Y              | Y               | N            | 1.00            | 999          | N          |            | N            | T            | 999             | N            | N                | N       |              |               |           |                 |             |                   |                   |                    |               |             |             |                   |                     |             |                   |                   |                    |               |             |             |                   |                     | Y             | 00017        | 0017A           | 0017B           | EX      | 0017A             | 0017B             | 1               | apps      |                    |                   | calc       | buld       | CONFIRM | Y             |


#Scenario Outline: Dividendfilecompare
#		Given I copy DIV output files to local
#		| ReportHeading   | FileName   | COY   | DividendName   |
#		| <ReportHeading> | <FileName> | <COY> | <DividendName> |
#		When I parse the files from VMS or Linux
#		And I compare the files from VMS and Linux goldcopy
#
#	Examples: 
#	| ReportHeading | FileName | COY     | DividendName |
#	| DIV1          | div1     | CPU_LNX | div1         |

