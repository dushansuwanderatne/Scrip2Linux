Feature: ESSReportingGold

@ReportGoldcopyESS 
@ESS_EmployeeExtractReport_Gold
@CPU_AUTO_R
@42419
@ReportingGold
Scenario Outline:ESS_Employee_Extract_Report_Goldcopy
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
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP     | EXA     |         |         |      | 1               | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |         |         |         |         |               |             | CPU_AUTO_R |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT     | EXA     | 3       | 7       |      | 1               | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |         |         |         |         |               |             | CPU_AUTO_R |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         | 3       | 7       |      | 1               | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |         |         |         |         |               |             | CPU_AUTO_R |
	| Test5         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | FP      | OPT     | 3       | 7       |      | 1               | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |         |         |         |         |               |             | CPU_AUTO_R |
	| Test6         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |  1      | 5       |      |                 | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |   6     |7        |8        |9        |               |             | QBE_AUTO_R |

@SmokeTestReportTest
Examples: 
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Selcls1 | Selcls2 | Selgrp1 | Selgrp2 | Exd1 | UnitBalanceFrom | UnitBalanceTO | HolderTotalsOnly | ClassCode | RegisterCode | RegisterType | AwardDate | Select | FieldSeparator | TextDelimiterReq | ReportDate | ReportSeq | Selgrp3 | Selgrp4 | Selgrp5 | Selgrp6 | TransDateFrom | TransDateTO | company    |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |         |         |      |                 | 99999999999   | N                | N         | N            | N            | N         | S      | ,              | Y                |            | A         |         |         |         |         |               |             | CPU_AUTO_R |




@ReportGoldcopyESS
@ESS_PurchaseReconciliationReport_Gold
@CPU_AUTO_R
@42420
@ReportingGold
Scenario Outline:ESS_Purchase_Reconciliation_Report_Goldcopy
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
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP     |         | 11A     |         | EP       |          | 01/01/2010 | 01/01/2015 | S                | B                   | Y                 | Y                  | Y                | Y                  | Y                 | Y                | Y                 | N                         |            | A         |         |         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP     | EXA     | 11A     | 12A     | EP       |          | 01/01/2015 | 01/04/2015 | S                | B                   | Y                 | Y                  | Y                | Y                  | Y                 | Y                | Y                 | N                         |            | A         |         |         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP     | EXA     | 11A     | 12A     | EP       |          | 01/01/2015 | 01/04/2015 | S                | B                   | Y                 | Y                  | Y                | Y                  | Y                 | Y                | Y                 | N                         |            | A         | 1       | 7       |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         | 11A     |         | EP       |          | 01/01/2010 | 01/01/2015 | S                | B                   | Y                 | Y                  | Y                | Y                  | Y                 | Y                | Y                 | N                         |            | A         | 3       | 7       |

@ReportGoldcopyESS
@ESS_ContributionFileReport_Gold
@CPU_AUTO_R
@42418
@ReportingGold
Scenario Outline:ESS_Contribution_File_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "contribution file report" within the ESS Reporting Menu
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
		And In ERS01009 I continue with the following details:
		| Selcls   | Selreg1   | Selreg2   | RegType1   | RegType2   | Participants   |
		| <Selcls> | <Selreg1> | <Selreg2> | <RegType1> | <RegType2> | <Participants> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Selcls | Selreg1 | Selreg2 | RegType1 | RegType2 | Participants | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP    |         |         |          |          | A            |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP    | 12A     |  11A    |          |          | A            |            | A         |


@ReportGoldcopyESS
@ESSLoanReport_Gold
@CPU_AUTO_R
@42421
@ReportingGold
Scenario Outline:ESS_Loan_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "loan report" within the ESS Reporting Menu
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
		And In ERS01005 I continue with the following details:			  
		| Class1   | Class2   | Ers01005Selgrp1   | Ers01005Selgrp2   | Reg1   | Reg2   | RunORDateRange   | RunRangeFrom   | RunRangeTO   | TransDateFrom   | TransDateTO   | LapseDate   | TotalsOnly   |
		| <Class1> | <Class2> | <Ers01005Selgrp1> | <Ers01005Selgrp2> | <Reg1> | <Reg2> | <RunORDateRange> | <RunRangeFrom> | <RunRangeTO> | <TransDateFrom> | <TransDateTO> | <LapseDate> | <TotalsOnly> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Class1 | Class2 | Ers01005Selgrp1 | Ers01005Selgrp2 | Reg1 | Reg2 | RunORDateRange | RunRangeFrom | RunRangeTO | TransDateFrom | TransDateTO | LapseDate | TotalsOnly | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |        |        |                 |                 |      |      | R              | 5000         | 7863       |               |             | N         | N          |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |        |        |                 |                 |      |      | D              |              |            |01/01/1997     |31/12/1997   | N         | N          |            | A         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | ELA    |        | 9               |                 |      |      | R              | 5000         | 7863       |               |             | N         | N          |            | A         |



@ReportGoldcopyESS
@ESSTransactionMovementReport_Gold
@CPU_AUTO_R
@42422
@ReportingGold
Scenario Outline:ESS_Transaction_Movement_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "transaction movement report" within the ESS Reporting Menu
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
		And In ERS01008 I continue with the following details:
		| Selcls1   | Selcls2   | Selgrp1   | Selgrp2   | Selreg1   | Selreg2   | RegType1   | RegType2   | RunORDateRange   | RunRangeFrom   | RunRangeTO   | TransDateFrom   | TransDateTO   | SummaryReportCsvInd   |
		| <Selcls1> | <Selcls2> | <Selgrp1> | <Selgrp2> | <Selreg1> | <Selreg2> | <RegType1> | <RegType2> | <RunORDateRange> | <RunRangeFrom> | <RunRangeTO> | <TransDateFrom> | <TransDateTO> | <SummaryReportCsvInd> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Selcls1 | Selcls2 | Selgrp1 | Selgrp2 | Selreg1 | Selreg2 | RegType1 | RegType2 | RunORDateRange | RunRangeFrom | RunRangeTO | TransDateFrom | TransDateTO | SummaryReportCsvInd | ReportDate | ReportSeq | company     |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |         |         |         |         |          |          | R              | 4400         | 4405       |               |             |                     |            | A         | CPU_AUTO_R  |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP     | OPT     |         |         |         |         |          |          | R              | 4400         | 4405       |               |             |                     |            | A         | CPU_AUTO_R  |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |         |         |         |         |          |          | D              |              |            | 01/01/2014    | 01/01/2015  |                     |            | A         | CPU_AUTO_R  |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP     | OPT     |         |         |         |         |          |          | D              |              |            | 01/01/2014    | 01/01/2015  |                     |            | A         | CPU_AUTO_R  |
	| Test5         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         | OPT     | 3       | 7       |         |         |          |          | R              | 4400         | 4405       |               |             |                     |            | A         | CPU_AUTO_R  |
	| Test6         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT     |         | 7       |         |         |         |          |          | D              |              |            | 01/01/2014    | 01/01/2015  |                     |            | A         | CPU_AUTO_R  |
	| Test7         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |         |         |         |         |          |          | R              | 7000         | 7860       |               |             |                     |            | A         | NAB2_AUTO_R |
	| Test8         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |         |         |         |         |         |         |          |          | R              | 4000         | 5214       |               |             |                     |            | A         | QBE_AUTO_R  |


@ReportGoldcopyESS
@ESSUnprocessedLeaverReport_Gold
@CPU_AUTO_R
@42423
@ReportingGold
Scenario Outline:ESS_Unprocessed_Leaver_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "unprocessed leaver report" within the ESS Reporting Menu
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
		And In ERS01041 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | RegCode1   | RegCode2   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |          |         |         |          |          |            | A         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          |         |         |  09A     |          |            | A         |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          |   7     |3        |          |          |            | A         |


@ReportGoldcopyESS
@ESSGrantReport_Gold
@NAB2_AUTO_R
@42434
@ReportingGold
Scenario Outline:ESS_Grant_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "grant report" within the ESS Reporting Menu
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
		And In ERS01039 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | RegCode1   | RegCode2   | ASATRunDateInd   | ASATRunNum   | ASATDate   | SummaryDetailInd   | NilHoldingsInd   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> | <ASATRunDateInd> | <ASATRunNum> | <ASATDate> | <SummaryDetailInd> | <NilHoldingsInd> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | ASATRunDateInd | ASATRunNum | ASATDate   | SummaryDetailInd | NilHoldingsInd | ReportDate | ReportSeq | company     |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | R              | 7862       |            | D                | Y              |            | A         | NAB2_AUTO_R |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          |         |         |          |          | R              | 7862       |            | D                | Y              |            | A         | NAB2_AUTO_R |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | D              |            | 01/01/2015 | D                | Y              |            | A         | NAB2_AUTO_R |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | PRS      |          |         |         | 13A      |          | D              |            | 01/01/2015 | D                | Y              |            | A         | NAB2_AUTO_R |
	| Test5         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DLC      |          | 2       |         |          |          | R              | 4407       |            | D                | Y              |            | A         | CPU_AUTO_R  |
	
@ReportGoldcopyESS
@ESSVestingReport_Gold
@NAB2_AUTO_R
@42435
@ReportingGold
Scenario Outline:ESS_Vesting_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "vesting report" within the ESS Reporting Menu
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
		And In ERS01040 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | RegCode1   | RegCode2   | VestingDateFrom   | VestingDateTO   | SummaryDetailInd   | TotalsReportInd   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> | <VestingDateFrom> | <VestingDateTO> | <SummaryDetailInd> | <TotalsReportInd> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | VestingDateFrom | VestingDateTO | SummaryDetailInd | TotalsReportInd | ReportDate | ReportSeq | company     |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | 01/01/2012      | 01/01/2015    | D                | Y               |            | A         | NAB2_AUTO_R |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | PRS      |          |         |         |          |          | 01/01/2014      | 01/01/2015    | D                | Y               |            | A         | NAB2_AUTO_R |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DLA      |DLC       | 2       |         |          |          | 01/01/2012      | 01/01/2015    | D                | Y               |            | A         | CPU_AUTO_R  |


@ReportGoldcopyESS
@ESSExerciseReport_Gold
@NAB2_AUTO_R
@42436
@ReportingGold
Scenario Outline:ESS_Exercise_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "exercise report" within the ESS Reporting Menu
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
		And In ERS01046 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | RegCode1   | RegCode2   | RunDateRangeInd   | RunRangeFrom   | RunRangeTO   | TranDateFrom   | TranDateTO   | SummaryDetailInd   | ExerciseStatusInd   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> | <RunDateRangeInd> | <RunRangeFrom> | <RunRangeTO> | <TranDateFrom> | <TranDateTO> | <SummaryDetailInd> | <ExerciseStatusInd> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | RunDateRangeInd | RunRangeFrom | RunRangeTO | TranDateFrom | TranDateTO | SummaryDetailInd | ExerciseStatusInd | ReportDate | ReportSeq | company     |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | R               | 7850         | 7862       |              |            | D                | B                 |            | A         | NAB2_AUTO_R |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | D               |              |            | 01/01/2010   | 01/01/2015 | B                | C                 |            | A         | NAB2_AUTO_R |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          |         |         |          |          | D               |              |            | 01/01/2010   | 01/01/2015 | B                | C                 |            | A         | NAB2_AUTO_R |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          | 2       |         |          |          | R               | 4000         | 4407       |              |            | D                | B                 |            | A         | CPU_AUTO_R  |


@ReportGoldcopyESS
@ESSCancellationExpiryReport_Gold
@NAB2_AUTO_R
@42438
@ReportingGold
Scenario Outline:ESS_Cancellation_Expiry_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "cancellation expiry report" within the ESS Reporting Menu
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
		And In ERS01042 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | RegCode1   | RegCode2   | RunDateRangeInd   | RunRangeFrom   | RunRangeTO   | TranDateFrom   | TranDateTO   |  CanExpTypeInd   |SummaryDetailInd   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> | <RunDateRangeInd> | <RunRangeFrom> | <RunRangeTO> | <TranDateFrom> | <TranDateTO> |  <CanExpTypeInd> |<SummaryDetailInd> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | RunDateRangeInd | RunRangeFrom | RunRangeTO | TranDateFrom | TranDateTO | SummaryDetailInd | CanExpTypeInd | ReportDate | ReportSeq | company     |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | R               | 7850         | 7862       |              |            | D                | B             |            | A         | nab2_auto_r |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | D               |              |            | 01/01/2010   | 01/01/2015 | B                | C             |            | A         | nab2_auto_r |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          |         |         |          |          | D               |              |            | 01/01/2010   | 01/01/2015 | B                | C             |            | A         | nab2_auto_r |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | OPT      |          |  7      |         |          |          | D               |              |            | 01/01/2010   | 01/01/2016 | B                | C             |            | A         | nab2_auto_r |


@ReportGoldcopyESS
@ESSPlanContributionsPurchasesAllocationsReport_Gold
@CPU_AUTO_R
@42440
@ReportingGold
Scenario Outline:ESS_Plan_Contributions_Purchases_Allocations_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "plan contributions purchases allocations report" within the ESS Reporting Menu
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
		And In ERS01023 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | RegCode1   | RegCode2   | TranDateFrom   | TranDateTO   | 
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> | <TranDateFrom> | <TranDateTO> |  
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | TranDateFrom | TranDateTO | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         |          |          | 01/01/2014   |01/01/2015  |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |          |         |         |          |          | 01/01/2014   |01/01/2015  |            | A         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |          |3        |7        |          |          | 01/01/2014   |01/01/2015  |            | A         |


@ReportGoldcopyESS
@ESSPlanWithdrawalsReport_Gold
@CPU_AUTO_R
@42441
@ReportingGold
#### Bug 73236:Reports -ESS_Plan_Withdrawals_Report-job abborted in Linux ###
Scenario Outline:ESS_Plan_Withdrawals_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "plan withdrawals report" within the ESS Reporting Menu
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
		And In ERS01024 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | TranDateFrom   | TranDateTO   | 
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <TranDateFrom> | <TranDateTO> |  
		And In ERS01003 I continue with the following details:
		| ReportDate   | ReportSeq   |
		| <ReportDate> | <ReportSeq> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600     | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | TranDateFrom | TranDateTO | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         | 01/01/2014   | 01/01/2015 |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      | EXA      |         |         | 01/01/2014   | 01/01/2015 |            | A         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |          | 3       | 7       | 01/01/2014   | 01/01/2015 |            | A         |
	

@ReportGoldcopyESS
@ESSDividendReport_Gold
@CPU_AUTO_R
@42442
@ReportingGold
### Bug 69242:Reports -ESS_Dividend_Report -Files are different in VMS and Linux ###
Scenario Outline:ESS_Dividend_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "dividend report" within the ESS Reporting Menu
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
		And In ERS01025 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | PayAcct1   | PayAcct2   | OneClassPerCatInd1   | TransDateFrom   | TransDateTO   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <PayAcct1> | <PayAcct2> | <OneClassPerCatInd1> | <TransDateFrom> | <TransDateTO> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | PayAcct1 | PayAcct2 | OneClassPerCatInd1 | TransDateFrom | TransDateTO | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |         |         | ORDTS    |          |                    | 01/01/2010    | 01/04/2015  |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |  EXA     |         |         | 13EDA    |          |                    | 01/01/2010    | 01/04/2015  |            | A         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          | 3       | 7       | 13EDA    |          |                    | 01/01/2010    | 01/04/2015  |            | A         |
	| Test4         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | EXA      |          | 3       | 7       | 13EDA    |          |                    | 01/01/2010    | 01/04/2015  |            | A         |

@ReportGoldcopyESS
@ESSUnallocatedReconciliationReport_Gold
@CPU_AUTO_R
@42443
@ReportingGold
### Bug 73234:Reports -ESS_Unallocated_Reconciliation_Report-Files are different in VMS and Linux ###
Scenario Outline:ESS_Unallocated_Reconciliation_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "unallocated reconciliation report" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
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
		And In ERS01026 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | TransDateFrom   | TransDateTO   | NfxdnSelection   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <TransDateFrom> | <TransDateTO> | <NfxdnSelection> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | TransDateFrom | TransDateTO | NfxdnSelection | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |          |         |         | 01/01/2014    | 01/01/2015  | S              |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |  7      |         | 01/01/2014    | 01/01/2015  | S              |            | A         |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | DEP      |          |  7      | 3       | 01/01/2014    | 01/01/2015  | S              |            | A         |


@ReportGoldcopyESS
@ESSTrusteeReconciliationReport_Gold
@CPU_AUTO_R
@42444
@ReportingGold
### Bug 73232:Bug 69273:Reports -ESS_Trustee_Reconciliation_Report-Files are different in VMS and Linux ###
Scenario Outline:ESS_Trustee_Reconciliation_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "trustee reconciliation report" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
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
		And In ERS01029 I continue with the following details:
		| ClsCode1   | ClsCode2   | ClsGrp1   | ClsGrp2   | TransDateFrom   | TransDateTO   | NfxupSelection   |
		| <ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <TransDateFrom> | <TransDateTO> | <NfxupSelection> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | TransDateFrom | TransDateTO | NfxupSelection |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | EXA      |  DEP     |         |         | 01/01/2014    | 01/01/2015  | S              |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |          |          |   7     |         | 01/01/2014    | 01/01/2015  | S              |
	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | EXA      |          |   7     |3         | 01/01/2014    | 01/01/2015  | S              |


@ReportGoldcopyESS
@ESSStaticWithholdingDetailsReport_Gold
@NAB2_AUTO_R
@42578
@ReportingGold
Scenario Outline:ESS_Static_Withholding_Details_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "static withholding details report" within the ESS Reporting Menu
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
		And In ERS01056 I continue with the following details:
		| EventType   | EventCode1   | EventCode2   | ReportDateFrom   | ReportDateTO   |
		| <EventType> | <EventCode1> | <EventCode2> | <ReportDateFrom> | <ReportDateTO> |
		And In ERS01057 I continue with the following details:
		| EventCode   | EventType1   | EventDate   | WithholdingTaxRate   | WithholdingTaxDesc   | MarketValueType   | ComplexHolderCode   |
		| <EventCode> | <EventType1> | <EventDate> | <WithholdingTaxRate> | <WithholdingTaxDesc> | <MarketValueType> | <ComplexHolderCode> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | EventType | EventCode1 | EventCode2 | ReportDateFrom | ReportDateTO | EventCode | EventType1 | EventDate | WithholdingTaxRate | WithholdingTaxDesc | MarketValueType | ComplexHolderCode | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |           |            |            |                |              | N         | N          | N         | N                  | N                  | N               | N                 |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  |           |            |            |                |              | Y         | Y          | Y         | Y                  | Y                  | Y               | Y                 |            | A         |


@ReportGoldcopyESS
@ESSWithholdingAssessmentReport_Gold
@NAB2_AUTO_R
@42579
@ReportingGold
Scenario Outline:ESS_Withholding_Assessment_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "withholding assessment report" within the ESS Reporting Menu
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
		And In ERS01058 I continue with the following details:
		| Selection   |
		| <Selection> |
		And In ERS01059 I continue with the following details:
		| MktValPrice   |
		| <MktValPrice> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | Selection | MktValPrice | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | 1         | 10          |            | A         |  
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | 11        | 10.50       |            | A         |  


@ReportGoldcopyESS
@ESSEventNotificationReport_Gold
@NAB2_AUTO_R
@42580
@ReportingGold
### Only V type events in VMS ###
Scenario Outline:ESS_Event_Notification_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "event notification report" within the ESS Reporting Menu
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
		And In ERS01054 I continue with the following details:
		| EventType   | EventCode   | EventDate   | EventTotals   | RegisterTotals   | RegisterTypeTotals   | CertificateBalances   |
		| <EventType> | <EventCode> | <EventDate> | <EventTotals> | <RegisterTotals> | <RegisterTypeTotals> | <CertificateBalances> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | EventType | EventCode | EventDate  | EventTotals | RegisterTotals | RegisterTypeTotals | CertificateBalances | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | V         | DS5       | 01/01/2020 | Y           | Y              | Y                  | Y                   |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | V         | DS1       | 01/01/2020 | Y           | Y              | Y                  | Y                   |            | A         |
#	| Test3         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | V         | DS7       | 30/06/2021 | Y           | Y              | Y                  | Y                   |            | A         |


@ReportGoldcopyESS
@ESSEventReconciliationReport_Gold
@NAB2_AUTO_R
@42581
@ReportingGold
Scenario Outline:ESS_Event_Reconciliation_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "event reconciliation report" within the ESS Reporting Menu
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
		And In ERS01055 I continue with the following details:
		| EventType   | EventCode1   | EventCode2   | ReportDateFrom   | ReportDateTO   | ModelPrice   | TotalsOnly   |
		| <EventType> | <EventCode1> | <EventCode2> | <ReportDateFrom> | <ReportDateTO> | <ModelPrice> | <TotalsOnly> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | EventType | EventCode1 | EventCode2 | ReportDateFrom | ReportDateTO | ModelPrice | TotalsOnly | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | V         |            |            | 01/01/2015     | 01/01/2020   |            | N          |            | A         |
	| Test2         | N       |            |            |            |             |             | Y                | N             | Y               | N         | Y            | N            |              |               |               |                  | V         | DS5        |            |                |              |            | N          |            | A         |


@ReportGoldcopyESS
@ESSVWAPReport_Gold
@NAB2_AUTO_R
@42582
@ReportingGold
Scenario Outline:ESS_VWAP_Report_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "vwap report" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01030 I continue with the following details:	
		| FinalSecurity   | VwapDateFrom   | VwapDateTO   |
		| <FinalSecurity> | <VwapDateFrom> | <VwapDateTO> |
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
	| ReportHeading | Preload | WildString | FinalSecurity | VwapDateFrom | VwapDateTO |
	| Test1         | N       |            |               |              |            |
	| Test2         | N       |            |               | 01/07/2013   |30/06/2014  |

@ReportGoldcopyESS
@ESSHousekeepingReport_Gold
@CPU_AUTO_R
@42583
@ReportingGold
### Bug 69273:Reports -ESS_Housekeeping_Report-Files are different in VMS and Linux ###
### Bug 58853:Returning different Future Matching End Date results beween each run ###
### 31/08/2016 Bug is not fix ### Test1 will Fail ###
Scenario Outline:ESS_Housekeeping_Report_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "ess housekeeping report" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01031 I continue with the following details:	
		| ClntCode1   | ClntCode2   | CoyCode1   | CoyCode2   | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | RegType1 | RegType2 | SelectedPlanType | SelectedTaxType |
		| <ClntCode1> | <ClntCode2> | <CoyCode1> | <CoyCode2> |<ClsCode1> | <ClsCode2> | <ClsGrp1> | <ClsGrp2> | <RegCode1> | <RegCode2> | <RegType1> | <RegType2> | <SelectedPlanType> | <SelectedTaxType> |
		And In ERS01036 I continue with the following details:	
		| CurrUnitBal   | NbrCurrCerts   | NbrNilCerts   | HolderID   | HolderName   |
		| <CurrUnitBal> | <NbrCurrCerts> | <NbrNilCerts> | <HolderID> | <HolderName> |
		And In ERS01032 I continue with the following details:	
		| PlanCode   | PlanDesc   | PlanTypeInd   | Div13aInd   | FinalSecurity   | CntryOFTax   | NorTrustInd   | MarketValueInd   | CntlAcct   | UnawAcct   | PaymtOptionInd   | PaymtCreatnInd   | BlkoutPeriodInd   | BlkoutCode   | LeaverPackInd   | ThirdPrtyPayee   | CoyPayee   | Comments   | TaxTypeInd   | UsePoolInd   | ForfType   | AutoForfInd   | AutoRemvlBulkCode   | AutoRemvlFromInd   | MatchWorkgCls   | PlanMtchgLimit   | PlanMtchgLimitPerd   | AutoPhntmTransfr   | RetirementAge   | FromOptionClass   | VsaXfrJurisdictCode   | SingleCertNbr   | DivReinvestInd   | DivPlanCat   | DivPlanConcept   | LapseDays   | NilCostOptionInd   | PhantomOptionInd   | ExpiryNoticeINUrr   | NbrDaysBefExpiry   | VestingNoticeINUrr   | NbrDaysBeforeVest   | ONMktPurchaseInd   | VsaXfrAllowed   | VsaJurisdictionCodes   | VsaClassCodes   | LoanLapseExcepts   | LoanLimitMax   | LoanLimitTypeInd   | LoanPaymntTypes   | LoanDivOption   | AllowWebTrfInd   |
		| <PlanCode> | <PlanDesc> | <PlanTypeInd> | <Div13aInd> | <FinalSecurity> | <CntryOFTax> | <NorTrustInd> | <MarketValueInd> | <CntlAcct> | <UnawAcct> | <PaymtOptionInd> | <PaymtCreatnInd> | <BlkoutPeriodInd> | <BlkoutCode> | <LeaverPackInd> | <ThirdPrtyPayee> | <CoyPayee> | <Comments> | <TaxTypeInd> | <UsePoolInd> | <ForfType> | <AutoForfInd> | <AutoRemvlBulkCode> | <AutoRemvlFromInd> | <MatchWorkgCls> | <PlanMtchgLimit> | <PlanMtchgLimitPerd> | <AutoPhntmTransfr> | <RetirementAge> | <FromOptionClass> | <VsaXfrJurisdictCode> | <SingleCertNbr> | <DivReinvestInd> | <DivPlanCat> | <DivPlanConcept> | <LapseDays> | <NilCostOptionInd> | <PhantomOptionInd> | <ExpiryNoticeINUrr> | <NbrDaysBefExpiry> | <VestingNoticeINUrr> | <NbrDaysBeforeVest> | <ONMktPurchaseInd> | <VsaXfrAllowed> | <VsaJurisdictionCodes> | <VsaClassCodes> | <LoanLapseExcepts> | <LoanLimitMax> | <LoanLimitTypeInd> | <LoanPaymntTypes> | <LoanDivOption> | <AllowWebTrfInd> |
		And In ERS01033 I continue with the following details:	
		| RegisterCode   | RegisterType   | RegisterDesc   | Comments1   | HoldingEndDate   | TaxEndDate   | FirstAwardDate   | IndividualDatesInd   | FloatingInd   | ExpiresAfter   | UnitRoundingInd   | ReleaseTypes   | AutoRemoveDays   | AessLimitType   | LimitMinimum   | LimitMaximum   | PaymentsCarrierInd   | MoneyRoundingInd   | ResidualsInd   | MaximumNbrRestarts   | PaymentAcct   | BaseCurrency   | AwardPayFreqDtls   | CalcTaxInd   | ForfeitureType   | ProRataMethod   | ForfeitureEndDate   | NonForfeitureStatus   | UsingMtchgInd   | UsingUnmatchedInd   | MtchgUpfrontInd   | FutrMtchgEndDate   | MtchgRatio   | AwdMtchgLimitPerd   | AwdMtchgLimit   | LoanBonusPerdDtls   | RecoursePlanInd   | FutureFloat   | ForfeitureFloat   | LeaverSchedule   | UsingVestingInd   | TaxStmtTypeInd   | TaxReportableInd   | FinRptExp   |
		| <RegisterCode> | <RegisterType> | <RegisterDesc> | <Comments1> | <HoldingEndDate> | <TaxEndDate> | <FirstAwardDate> | <IndividualDatesInd> | <FloatingInd> | <ExpiresAfter> | <UnitRoundingInd> | <ReleaseTypes> | <AutoRemoveDays> | <AessLimitType> | <LimitMinimum> | <LimitMaximum> | <PaymentsCarrierInd> | <MoneyRoundingInd> | <ResidualsInd> | <MaximumNbrRestarts> | <PaymentAcct> | <BaseCurrency> | <AwardPayFreqDtls> | <CalcTaxInd> | <ForfeitureType> | <ProRataMethod> | <ForfeitureEndDate> | <NonForfeitureStatus> | <UsingMtchgInd> | <UsingUnmatchedInd> | <MtchgUpfrontInd> | <FutrMtchgEndDate> | <MtchgRatio> | <AwdMtchgLimitPerd> | <AwdMtchgLimit> | <LoanBonusPerdDtls> | <RecoursePlanInd> | <FutureFloat> | <ForfeitureFloat> | <LeaverSchedule> | <UsingVestingInd> | <TaxStmtTypeInd> | <TaxReportableInd> | <FinRptExp> |
		And In ERS01034 I continue with the following details:
		| AwardDate   | AcqstnSharePrice   | AwardExchgRate   | IfrsFmv   | ExpiryDate   | VestingCode   | VestingStartDate   | PerformanceHurdles   | PerformanceCode   | CtlPayFreqDtls   | HlthIntgrtyModeInd   | EnabledStatusInd   | PriceUpdatedInd   | Comments2   | DisplayONWeb   |
		| <AwardDate> | <AcqstnSharePrice> | <AwardExchgRate> | <IfrsFmv> | <ExpiryDate> | <VestingCode> | <VestingStartDate> | <PerformanceHurdles> | <PerformanceCode> | <CtlPayFreqDtls> | <HlthIntgrtyModeInd> | <EnabledStatusInd> | <PriceUpdatedInd> | <Comments2> | <DisplayONWeb> |
		And In ERS01035 I continue with the following details:
		| PaymntFreq   | AccumnPeriod   | AccumnStaDate   | AccumnEndDate   | MaxNbrPaymnts   |
		| <PaymntFreq> | <AccumnPeriod> | <AccumnStaDate> | <AccumnEndDate> | <MaxNbrPaymnts> |
		And In ERS01037 I continue with the following details:
		| TrancheNbr   | TestNbr   | VstDesc   | VstTerm   | UnitRnd   | VstComments   | PeriodFRVstStart   | VestPerc   | VestDate   | PerformanceDesc   | TestDate   | TestPerc   | CancUnvest   |
		| <TrancheNbr> | <TestNbr> | <VstDesc> | <VstTerm> | <UnitRnd> | <VstComments> | <PeriodFRVstStart> | <VestPerc> | <VestDate> | <PerformanceDesc> | <TestDate> | <TestPerc> | <CancUnvest> |
		And In ERS01038 I continue with the following details:
		| LeaverSchedDesc   | LeaverCode   | LeaverCodeDesc   | EmployeeStatus   | EmployeeStatusDesc   | LeaverEffectInd   | MaintainRestrctInd   | PhantomLvrTypeInd   | OverrideExpiry   | OverridePeriod   | OverrideFromDate   | UnvNOChgInd   | UnvCancelImm   | UnvAccelVst   | UnvAccelPeriod   | UnvAccelFrmDate   | VstNOChgInd   | VstCancelImm   | VstIgnoreBlackout   | Comments3   |
		| <LeaverSchedDesc> | <LeaverCode> | <LeaverCodeDesc> | <EmployeeStatus> | <EmployeeStatusDesc> | <LeaverEffectInd> | <MaintainRestrctInd> | <PhantomLvrTypeInd> | <OverrideExpiry> | <OverridePeriod> | <OverrideFromDate> | <UnvNOChgInd> | <UnvCancelImm> | <UnvAccelVst> | <UnvAccelPeriod> | <UnvAccelFrmDate> | <VstNOChgInd> | <VstCancelImm> | <VstIgnoreBlackout> | <Comments3> |
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
	| ReportHeading | Preload | WildString | ClsCode1 | ClsCode2 | ClsGrp1 | ClsGrp2 | RegCode1 | RegCode2 | RegType1 | RegType2 | SelectedPlanType | SelectedTaxType | CurrUnitBal | NbrCurrCerts | NbrNilCerts | HolderID | HolderName | PlanCode | PlanDesc | PlanTypeInd | Div13aInd | FinalSecurity | CntryOFTax | NorTrustInd | MarketValueInd | CntlAcct | UnawAcct | PaymtOptionInd | PaymtCreatnInd | BlkoutPeriodInd | BlkoutCode | LeaverPackInd | ThirdPrtyPayee | CoyPayee | Comments | TaxTypeInd | UsePoolInd | ForfType | AutoForfInd | AutoRemvlBulkCode | AutoRemvlFromInd | MatchWorkgCls | PlanMtchgLimit | PlanMtchgLimitPerd | AutoPhntmTransfr | RetirementAge | FromOptionClass | VsaXfrJurisdictCode | SingleCertNbr | DivReinvestInd | DivPlanCat | DivPlanConcept | LapseDays | NilCostOptionInd | PhantomOptionInd | ExpiryNoticeINUrr | NbrDaysBefExpiry | VestingNoticeINUrr | NbrDaysBeforeVest | ONMktPurchaseInd | VsaXfrAllowed | VsaJurisdictionCodes | VsaClassCodes | LoanLapseExcepts | LoanLimitMax | LoanLimitTypeInd | LoanPaymntTypes | LoanDivOption | AllowWebTrfInd | RegisterCode | RegisterType | RegisterDesc | Comments1 | HoldingEndDate | TaxEndDate | FirstAwardDate | IndividualDatesInd | FloatingInd | ExpiresAfter | UnitRoundingInd | ReleaseTypes | AutoRemoveDays | AessLimitType | LimitMinimum | LimitMaximum | PaymentsCarrierInd | MoneyRoundingInd | ResidualsInd | MaximumNbrRestarts | PaymentAcct | BaseCurrency | AwardPayFreqDtls | CalcTaxInd | ForfeitureType | ProRataMethod | ForfeitureEndDate | NonForfeitureStatus | UsingMtchgInd | UsingUnmatchedInd | MtchgUpfrontInd | FutrMtchgEndDate | MtchgRatio | AwdMtchgLimitPerd | AwdMtchgLimit | LoanBonusPerdDtls | RecoursePlanInd | FutureFloat | ForfeitureFloat | LeaverSchedule | UsingVestingInd | TaxStmtTypeInd | TaxReportableInd | FinRptExp | AwardDate | AcqstnSharePrice | AwardExchgRate | IfrsFmv | ExpiryDate | VestingCode | VestingStartDate | PerformanceHurdles | PerformanceCode | CtlPayFreqDtls | HlthIntgrtyModeInd | EnabledStatusInd | PriceUpdatedInd | Comments2 | DisplayONWeb | PaymntFreq | AccumnPeriod | AccumnStaDate | AccumnEndDate | MaxNbrPaymnts | TrancheNbr | TestNbr | VstDesc | VstTerm | UnitRnd | VstComments | PeriodFRVstStart | VestPerc | VestDate | PerformanceDesc | TestDate | TestPerc | CancUnvest | LeaverSchedDesc | LeaverCode | LeaverCodeDesc | EmployeeStatus | EmployeeStatusDesc | LeaverEffectInd | MaintainRestrctInd | PhantomLvrTypeInd | OverrideExpiry | OverridePeriod | OverrideFromDate | UnvNOChgInd | UnvCancelImm | UnvAccelVst | UnvAccelPeriod | UnvAccelFrmDate | VstNOChgInd | VstCancelImm | VstIgnoreBlackout | Comments3 | ClntCode1 | ClntCode2 | CoyCode1 | CoyCode2 |
	| Test1         | N       |            |          |          |         |         |          |          |          |          |                  |                 | Y           | Y            | Y           | Y        | Y          | Y        | Y        | Y           | Y         | Y             | Y          | Y           | Y              | Y        | Y        | Y              | Y              | Y               | Y          | Y             | Y              | Y        | Y        | Y          | Y          | Y        | Y           | Y                 | Y                | Y             | Y              | Y                  | Y                | Y             | Y               | Y                   | Y             | Y              | Y          | Y              | Y         | Y                | Y                | Y                 | Y                | Y                  | Y                 | Y                | Y             | Y                    | Y             | Y                | Y            | Y                | Y               | Y             | Y              | Y            | Y            | Y            | Y         | Y              | Y          | Y              | Y                  | Y           | Y            | Y               | Y            | Y              | Y             | Y            | Y            | Y                  | Y                | Y            | Y                  | Y           | Y            | Y                | Y          | Y              | Y             | Y                 | Y                   | Y             | Y                 | Y               | Y                | Y          | Y                 | Y             | Y                 | Y               | Y           | Y               | Y              | Y               | Y              | Y                | Y         | Y         | Y                | Y              | Y       | Y          | Y           | Y                | Y                  | Y               | Y              | Y                  | Y                | Y               | Y         | Y            | Y          | Y            | Y             | Y             | Y             | Y          | Y       | Y       | Y       | Y       | Y           | Y                | Y        | Y        | Y               | Y        | Y        | Y          | Y               | Y          | Y              | Y              | Y                  | Y               | Y                  | Y                 | Y              | Y              | Y                | Y           | Y            | Y           | Y              | Y               | Y           | Y            | Y                 | Y         |           |           |          |          |
	| Test2         | N       |            |          |          |         |         |          |          |          |          |                  |                 | Y           | N            | N           | N        | N          | N        | N        | N           | N         | N             | N          | N           | N              | N        | N        | N              | N              | N               | N          | N             | N              | N        | N        | N          | N          | N        | N           | N                 | N                | N             | N              | N                  | N                | N             | N               | N                   | N             | N              | N          | N              | N         | N                | N                | N                 | N                | N                  | N                 | N                | N             | N                    | N             | N                | N            | N                | N               | N             | N              | N            | N            | N            | N         | N              | N          | N              | N                  | N           | N            | N               | N            | N              | N             | N            | N            | N                  | N                | N            | N                  | N           | N            | N                | N          | N              | N             | N                 | N                   | N             | N                 | N               | N                | N          | N                 | N             | N                 | N               | N           | N               | N              | N               | N              | N                | N         | N         | N                | N              | N       | N          | N           | N                | N                  | N               | N              | N                  | N                | N               | N         | N            | N          | N            | N             | N             | N             | N          | N       | N       | N       | N       | N           | N                | N        | N        | N               | N        | N        | N          | N               | N          | N              | N              | N                  | N               | N                  | N                 | N              | N              | N                | N           | N            | N           | N              | N               | N           | N            | N                 | N         |           |           |          |          |
	| Test3         | N       |            | DEP      | OPT      |         |         |          |          |          |          |                  |                 | Y           | Y            | Y           | Y        | Y          | Y        | Y        | Y           | Y         | Y             | Y          | Y           | Y              | Y        | Y        | Y              | Y              | Y               | Y          | Y             | Y              | Y        | Y        | Y          | Y          | Y        | Y           | Y                 | Y                | Y             | Y              | Y                  | Y                | Y             | Y               | Y                   | Y             | Y              | Y          | Y              | Y         | Y                | Y                | Y                 | Y                | Y                  | Y                 | Y                | Y             | Y                    | Y             | Y                | Y            | Y                | Y               | Y             | Y              | Y            | Y            | Y            | Y         | Y              | Y          | Y              | Y                  | Y           | Y            | Y               | Y            | Y              | Y             | Y            | Y            | Y                  | Y                | Y            | Y                  | Y           | Y            | Y                | Y          | Y              | Y             | Y                 | Y                   | Y             | Y                 | Y               | Y                | Y          | Y                 | Y             | Y                 | Y               | Y           | Y               | Y              | Y               | Y              | Y                | Y         | Y         | Y                | Y              | Y       | Y          | Y           | Y                | Y                  | Y               | Y              | Y                  | Y                | Y               | Y         | Y            | Y          | Y            | Y             | Y             | Y             | Y          | Y       | Y       | Y       | Y       | Y           | Y                | Y        | Y        | Y               | Y        | Y        | Y          | Y               | Y          | Y              | Y              | Y                  | Y               | Y                  | Y                 | Y              | Y              | Y                | Y           | Y            | Y           | Y              | Y               | Y           | Y            | Y                 | Y         |           |           |          |          |
	| Test4         | N       |            | DEP      | OPT      |  3      |    7    |          |          |          |          |                  |                 | Y           | Y            | Y           | Y        | Y          | Y        | Y        | Y           | Y         | Y             | Y          | Y           | Y              | Y        | Y        | Y              | Y              | Y               | Y          | Y             | Y              | Y        | Y        | Y          | Y          | Y        | Y           | Y                 | Y                | Y             | Y              | Y                  | Y                | Y             | Y               | Y                   | Y             | Y              | Y          | Y              | Y         | Y                | Y                | Y                 | Y                | Y                  | Y                 | Y                | Y             | Y                    | Y             | Y                | Y            | Y                | Y               | Y             | Y              | Y            | Y            | Y            | Y         | Y              | Y          | Y              | Y                  | Y           | Y            | Y               | Y            | Y              | Y             | Y            | Y            | Y                  | Y                | Y            | Y                  | Y           | Y            | Y                | Y          | Y              | Y             | Y                 | Y                   | Y             | Y                 | Y               | Y                | Y          | Y                 | Y             | Y                 | Y               | Y           | Y               | Y              | Y               | Y              | Y                | Y         | Y         | Y                | Y              | Y       | Y          | Y           | Y                | Y                  | Y               | Y              | Y                  | Y                | Y               | Y         | Y            | Y          | Y            | Y             | Y             | Y             | Y          | Y       | Y       | Y       | Y       | Y           | Y                | Y        | Y        | Y               | Y        | Y        | Y          | Y               | Y          | Y              | Y              | Y                  | Y               | Y                  | Y                 | Y              | Y              | Y                | Y           | Y            | Y           | Y              | Y               | Y           | Y            | Y                 | Y         |           |           |          |          |

@ReportGoldcopyESS
@ESS_ContributionFileReport_Gold
@CPU_AUTO_R
@42418
@ReportingGold
Scenario Outline:ESS_Contribution_File_Report_Detail_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "contribution file report" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   |
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> |
		And In ERS01010 I continue with the following values:
		| HolderIdentifier   | HolderCat   | HolderNumber   | RegAddress   | RegAddrCase   | HolderName   | Fullnames   | CaseFull   | FormattedFull   | NameDetailed   | CaseDetailed   | Surname   | FirstName   | SecondName   | ThirdName   | Title   | Initials   | Designator   | NameKey   | NameType   | HolderAddress   | HolderAddressCase   | IncludePcode   | PcodeDomicile   | Dpid   | Barcode   | AlternateID   | Ers01010PersonalUrl   |
		| <HolderIdentifier> | <HolderCat> | <HolderNumber> | <RegAddress> | <RegAddrCase> | <HolderName> | <Fullnames> | <CaseFull> | <FormattedFull> | <NameDetailed> | <CaseDetailed> | <Surname> | <FirstName> | <SecondName> | <ThirdName> | <Title> | <Initials> | <Designator> | <NameKey> | <NameType> | <HolderAddress> | <HolderAddressCase> | <IncludePcode> | <PcodeDomicile> | <Dpid> | <Barcode> | <AlternateID> | <Ers01010PersonalUrl> |
		And In ERS01011 I continue with the following details:
		| StaticDetails   |
		| <StaticDetails> |
		And In ERS01012 I continue with the following Values:
		| ExtraIdentifier   | HomePhone   |  WorkPhone   | FaxNumber   | MobilePhone   | EmailAddress   |ReturnedEmail   |
		| <ExtraIdentifier> | <HomePhone> |  <WorkPhone> | <FaxNumber> | <MobilePhone> | <EmailAddress> |<ReturnedEmail> |
		And In ERS01028 I continue with the following Values:
		| HolderStatus   | DeceasedFlag   | ExceptionFlag   | StopTradeFlag   | DivIntentionFlag   | VariableFlags   | VariableField   | TfnDescription   | Dates   | MailUnclaimedDate   | HolderONDate   | HolderOffDate   | HolderAddedDate   | PlanDetails   | DrpDetails   | DrpPlanDesc   | BspDetails   | BspPlanDesc   | DirectCredit   | BankID   | BankNamadd   | BankAccountNbr   | BankAccountName   |
		| <HolderStatus> | <DeceasedFlag> | <ExceptionFlag> | <StopTradeFlag> | <DivIntentionFlag> | <VariableFlags> | <VariableField> | <TfnDescription> | <Dates> | <MailUnclaimedDate> | <HolderONDate> | <HolderOffDate> | <HolderAddedDate> | <PlanDetails> | <DrpDetails> | <DrpPlanDesc> | <BspDetails> | <BspPlanDesc> | <DirectCredit> | <BankID> | <BankNamadd> | <BankAccountNbr> | <BankAccountName> |
		And In ERS01009 I continue with the following details:
		| Selcls   | Selreg1   | Selreg2   | RegType1   | RegType2   | Participants   |
		| <Selcls> | <Selreg1> | <Selreg2> | <RegType1> | <RegType2> | <Participants> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | HolderCat | HolderNumber | RegAddress | RegAddrCase | HolderName | Fullnames | CaseFull | FormattedFull | NameDetailed | CaseDetailed | Surname | FirstName | SecondName | ThirdName | Title | Initials | Designator | NameKey | NameType | HolderAddress | HolderAddressCase | IncludePcode | PcodeDomicile | Dpid | Barcode | AlternateID | Ers01010PersonalUrl | ExtraIdentifier | HomePhone | EmailAddress | WorkPhone | FaxNumber | MobilePhone | ReturnedEmail | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | VariableFlags | VariableField | TfnDescription | Dates | MailUnclaimedDate | HolderONDate | HolderOffDate | HolderAddedDate | PlanDetails | DrpDetails | DrpPlanDesc | BspDetails | BspPlanDesc | DirectCredit | BankID | BankNamadd | BankAccountNbr | BankAccountName | Selcls | Selreg1 | Selreg2 | RegType1 | RegType2 | Participants | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | Y                | Y         | Y            | Y          | M           | Y          | Y         | M        | Y             | Y            | M            | Y       | Y         | Y          | Y         | Y     | Y        | Y          | Y       | Y        | Y             | M                 | Y            | Y             | Y    | Y       | Y           | Y                   | Y               | Y         | Y            | Y         | Y         | Y           | Y             | Y            | Y            | Y             | Y             | Y                | Y             | Y             | Y              | Y     | Y                 | Y            | Y             | Y               | Y           | Y          |             | N          |             | Y            | Y      | Y          | Y              | Y               | DEP    |         |         |          |          | A            |            | A         |

@ReportGoldcopyESS
@ESSEmployeeLoanPlanStatement_Gold
@NAB2_AUTO_R
@42717
@ReportingGold
##### Bug 73199:Reports -ESS_Employee_Loan_Plan_Statement-job is looping in Linux ####
Scenario Outline:ESS_Employee_Loan_Plan_Statement_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "employee loan plan statement" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   |
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> |
		And In ERS01020 I continue with the following details:
		| Class1   | Class2   | Selgrp1   | Selgrp2   | RunRangeTO   | StatementRunFrom   | MarketValuePrice   | MarketValueDate   | ForeignExchangeRate   | StmtDsplayDateFrom   | StmtDsplayDateTO   |
		| <Class1> | <Class2> | <Selgrp1> | <Selgrp2> | <RunRangeTO> | <StatementRunFrom> | <MarketValuePrice> | <MarketValueDate> | <ForeignExchangeRate> | <StmtDsplayDateFrom> | <StmtDsplayDateTO> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | Class1 | Class2 | Selgrp1 | Selgrp2 | RunRangeTO | StatementRunFrom | MarketValuePrice | MarketValueDate | ForeignExchangeRate | StmtDsplayDateFrom | StmtDsplayDateTO | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             |        |        |         |         | 7862       |                  | 30               | 01/01/2014      |                     | 01/07/2013         | 30/06/2014       |            | A         |
	| Test2         | N       |            |            |            |             |             |ELA     |        |         |         | 7862       |                  | 30               | 01/01/2014      |                     | 01/07/2013         | 30/06/2014       |            | A         |
	| Test3         | N       |            |            |            |             |             |        |        |     9   |         | 7862       |                  | 30               | 01/01/2014      |                     | 01/07/2013         | 30/06/2014       |            | A         |


@ReportGoldcopyESS
@ESSEmployeeAESSPlanStatement_Gold
@CPU_AUTO_R
@42718
@ReportingGold
#####Bug 73198:Reports -ESS_Employee_AESS_Plan_Statement-job is looping in Linux ####
Scenario Outline:ESS_Employee_AESS_Plan_Statement_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "employee aess plan statement" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   |
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> |
		And In ERS01021 I continue with the following details:
		| Class1   | Class2   | Selgrp1   | Selgrp2   | Reg1   | Reg2   | RunRangeTO   | StatementRunFrom   | BFBalanceInd   | StatementDisplayInd   | Ers01021PymtTranInd   | MarketValuePrice   | MarketValueDate   | ForeignExchangeRate   | StmtDsplayDateFrom   | StmtDsplayDateTO   |
		| <Class1> | <Class2> | <Selgrp1> | <Selgrp2> | <Reg1> | <Reg2> | <RunRangeTO> | <StatementRunFrom> | <BFBalanceInd> | <StatementDisplayInd> | <Ers01021PymtTranInd> | <MarketValuePrice> | <MarketValueDate> | <ForeignExchangeRate> | <StmtDsplayDateFrom> | <StmtDsplayDateTO> |
		And In ERS01003 I continue with the following details:
		| ReportDate   | ReportSeq   |
		| <ReportDate> | <ReportSeq> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 1200    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | Class1 | Class2 | Selgrp1 | Selgrp2 | Reg1 | Reg2 | RunRangeTO | StatementRunFrom | BFBalanceInd | StatementDisplayInd | Ers01021PymtTranInd | MarketValuePrice | MarketValueDate | ForeignExchangeRate | StmtDsplayDateFrom | StmtDsplayDateTO | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             |        |        |         |         |      |      | 4405       |                  | C            | C                   | C                   | 10               | 01/01/2014      |                     | 01/07/2013         | 30/06/2014       |            | A         |
	| Test2         | N       |            |            |            |             |             | DEP    |        |         |         |      |      | 4405       |                  | C            | C                   | C                   | 10               | 01/01/2014      |                     | 01/07/2013         | 30/06/2014       |            | A         |
	| Test3         | N       |            |            |            |             |             | DEP    |        |    7    | 3       |      |      | 4405       |                  | C            | C                   | C                   | 10               | 01/01/2014      |                     | 01/07/2013         | 30/06/2014       |            | A         |


@ReportGoldcopyESS
@ESSEmployeeOptionPlanStatement_Gold
@CPU_AUTO_R
@42719
@ReportingGold
Scenario Outline:ESS_Employee_Option_Plan_Statement_Goldcopy
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
	| Test1         | N       |            |            |            |             |             |        |        |         |         |      |      | G             | 4405       |                  |               |             | 10               | 01/01/2014      | 01/07/2013         | 30/06/2014       | Y              |            | A         |         |
	| Test2         | N       |            |            |            |             |             |        |        |         |         |      |      | H             | 4405       |                  |               |             | 10               | 01/01/2014      | 01/07/2013         | 30/06/2014       |                |            | A         |         |
	| Test3         | N       |            |            |            |             |             |        |        |         |         |      |      | V             |            |                  | 01/07/2013    | 01/07/2013  | 10               | 01/01/2014      | 01/07/2013         | 30/06/2014       |                |            | A         | Y       |
	| Test4         | N       |            |            |            |             |             |        |        |         |         |      |      | E             |            |                  | 01/07/2013    | 01/07/2013  | 10               | 01/01/2014      | 01/07/2013         | 30/06/2014       |                |            | A         | Y       |
	| Test5         | N       |            |            |            |             |             | OPT    |        |         |         |      |      | G             | 4405       |                  |               |             | 10               | 01/01/2014      | 01/07/2013         | 30/06/2014       | Y              |            | A         |         |


@ReportGoldcopyESS
@ESSPre2010EmployeeTaxStatements_Gold
@CPU_AUTO_R
@42720
@ReportingGold
Scenario Outline:ESS_Pre2010_Employee_Tax_Statements_Goldcopy
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "pre 2010 employee tax statements" within the ESS Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   | UseHistClassesInd   | HistClass1   | HistClass2   |
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> | <UseHistClassesInd> | <HistClass1> | <HistClass2> |
		And In ERS01062 I continue with the following details:
		| Class1   | PayAcct1   | PayAcct2   | ClassPerCatInd11   | ClassPerCatInd12   | UseHistClassesInd | HistClass1   | HistClass2   | RunRangeTO   | StatementRunFrom   | TransDateFrom   | TransDateTO   | LoanDiscountPrice   | GenerateCsvInd   |
		| <Class1> | <PayAcct1> | <PayAcct2> | <ClassPerCatInd11> | <ClassPerCatInd12> | N                 | <HistClass1> | <HistClass2> | <RunRangeTO> | <StatementRunFrom> | <TransDateFrom> | <TransDateTO> | <LoanDiscountPrice> | <GenerateCsvInd> |
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
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | Class1 | PayAcct1 | PayAcct2 | ClassPerCatInd11 | ClassPerCatInd12 | UseHistClassesInd | HistClass1 | HistClass2 | RunRangeTO | StatementRunFrom | TransDateFrom | TransDateTO | LoanDiscountPrice | GenerateCsvInd | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |             |             | DEP    |          |          |                  |                  | N                 |            |            | 4406       |                  | 01/01/2007    | 30/06/2008  |                   | Y              |            | A         |
	| Test2         | N       |            |            |            |             |             | DEP    |          |          |                  |                  | N                 |            |            | 4406       |                  | 01/01/2007    | 30/06/2008  |                   | N              |            | A         |

#@ignore
#@ReportGoldcopyESS
#@ESSEmployeeTaxStatements_Gold
#@CPU_AUTO_R
#@42761 
#@ReportingGold
##Discuss wth Darryl. needs to run tax statements manually.
#Scenario Outline:ESS_Employee_Tax_Statements_Goldcopy 
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "CPU_A_R"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
#		And In ERS00100 I click on: "ess tax reporting" within the ESS Reporting Menu
#		And In ERS00110 I click on: "employee tax statements(standard)" within the ESS Tax Reporting Menu
#		And In ERS01001 I continue with the following details:	
#		| Preload   | WildString   |
#		| <Preload> | <WildString> |
#		And In ERS01002 I continue with the following details:
#		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   | UseHistClassesInd   | HistClass1   | HistClass2   |
#		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> | <UseHistClassesInd> | <HistClass1> | <HistClass2> |
#		And In ERS01022 I continue with the following details:
#		| Class1   | PayAcct1   | PayAcct2   | ClassPerCatInd1   | ClassPerCatInd2   | UseHistClassesInd   | HistClass1   | HistClass2   | ReportCgtInd   | TransDateFrom   | TransDateTO   | LoanDiscountPrice   | AmendmentInd   | Ers01022AmendTfnReqInd   | 
#		| <Class1> | <PayAcct1> | <PayAcct2> | <ClassPerCatInd1> | <ClassPerCatInd2> | <UseHistClassesInd> | <HistClass1> | <HistClass2> | <ReportCgtInd> | <TransDateFrom> | <TransDateTO> | <LoanDiscountPrice> | <AmendmentInd> | <Ers01022AmendTfnReqInd> | 
#		And In ERS01064 I continue with the following details:
#		| Confirm   |
#		| <Confirm> |
#		And In ERS01003 I continue with the following details:
#		| ReportDate   | ReportSeq   |
#		| <ReportDate> | <ReportSeq> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria | timeout | FailCriteria |
#		| completion   | 600    | error         |
#		Then I copy output files to local
#		| ReportHeading   | FileName |
#		| <ReportHeading> |          |
#		And I parse the files from VMS or Linux
#		And I compare the files from VMS and Linux goldcopy
#
#Examples: 
#	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | Class1 | PayAcct1 | PayAcct2 | ClassPerCatInd1 | ClassPerCatInd2 | UseHistClassesInd | HistClass1 | HistClass2 | ReportCgtInd | TransDateFrom | TransDateTO | LoanDiscountPrice | AmendmentInd | Ers01022AmendTfnReqInd | Confirm | ReportDate | ReportSeq |
#	| Test1         | N       |            |            |            |             |             | DEP    |          |          |                 |                 |                   |            |            | N            | 01/07/2013    | 30/06/2014  |                   | O            |                        | Y       |            | A         |
#	| Test2         | N       |            |            |            |             |             | OPT    |          |          |                 |                 |                   |            |            | N            | 01/07/2013    | 30/06/2014  |                   | O            |                        | Y       |            | A         |
#	| Test3         | N       |            |            |            |             |             | DEP    |          |          |                 |                 |                   |            |            | N            | 01/07/2013    | 30/06/2014  |                   | A            |   Y                    | Y       |            | A         |

@ReportGoldcopyESS
@ESSTaxReportingStatusReport_Gold
@CPU_AUTO_R
@42763
@ReportingGold
Scenario Outline:ESS_Tax_Reporting_Status_Report_Goldcopy 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "ess tax reporting" within the ESS Reporting Menu
		And In ERS00110 I click on: "ess tax reporting status report" within the ESS Tax Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01050 I continue with the following details:
		| CoyCode151   | CoyCode152   | CoyCode153   | FinYear   | TaxStatus1   | TaxStatus2   | TaxStatus3   |
		| <CoyCode151> | <CoyCode152> | <CoyCode153> | <FinYear> | <TaxStatus1> | <TaxStatus2> | <TaxStatus3> |
		And In ERS01003 I continue with the following details:
		| ReportDate   | ReportSeq   |
		| <ReportDate> | <ReportSeq> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName | ExternalFiles | ExternalFileLocation |
		| <ReportHeading> |          | Y             | cpm_doc              |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | CoyCode151 | CoyCode152  | CoyCode153 | FinYear | TaxStatus1 | TaxStatus2 | TaxStatus3 | ReportDate | ReportSeq |
	| Test1         | N       |            | CPU_AUTO_R | NAB2_AUTO_R |            | 2014    |            |            |            |            | A         |
	| Test2         | N       |            | CPU_AUTO_R |             |            | 2014    |            |            |            |            | A         |


@ReportGoldcopyESS
@ESSATOProviderReport_Gold
@CPU_AUTO_R
@42764
@ReportingGold
Scenario Outline:ESS_ATO_Provider_Report_Goldcopy 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "ess tax reporting" within the ESS Reporting Menu
		And In ERS00110 I click on: "ess ato provider report" within the ESS Tax Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01051 I continue with the following details:
		| CoyCode151   | CoyCode152   | CoyCode153   | 
		| <CoyCode151> | <CoyCode152> | <CoyCode153> | 
		And In ERS01003 I continue with the following details:
		| ReportDate   | ReportSeq   |
		| <ReportDate> | <ReportSeq> |		
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName | ExternalFiles | ExternalFileLocation |
		| <ReportHeading> |          | Y             | cpm_doc              |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | CoyCode151 | CoyCode152 | CoyCode153 | ReportDate | ReportSeq |
	| Test1         | N       |            |            |            |            |            | A         |
	| Test2         | N       |            | CPU_AUTO_R |            |            |            | A         |

@ReportGoldcopyESS
@ESSTFNWithholdingReport_Gold
@CPU_AUTO_R
@42765
@ReportingGold
Scenario Outline:ESS_TFN_Withholding_Report_Goldcopy 
### Bug 72953*:Reports -ESS_TFN_Withholding_Report -job is looping in Linux -Fixed ###
### Bug 99898:Reports -ESS_TFN_Withholding_Report Did not create the CSV files and .info file in company level in Linux ###
### Bug 101558:Reports -ESS_TFN_Withholding_Report -Differencs in the reports ### 
### Need to restore the company every time. FTP file hard coded names ###
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "ess reporting" within the Reporting System Menu
		And In ERS00100 I click on: "ess tax reporting" within the ESS Reporting Menu
		And In ERS00110 I click on: "ess tfn withholding report" within the ESS Tax Reporting Menu
		And In ERS01001 I continue with the following details:	
		| Preload   | WildString   |
		| <Preload> | <WildString> |
		And In ERS01002 I continue with the following details:
		| EmpStatus1   | EmpStatus2   | LeaverCode1   | LeaverCode2   | 
		| <EmpStatus1> | <EmpStatus2> | <LeaverCode1> | <LeaverCode2> | 
		And In ERS01052 I continue with the following details:
		| Class   | FinancialYear   |
		| <Class> | <FinancialYear> |
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
		Then I copy output files to local
		| ReportHeading   | FileName    |
		| <ReportHeading> | <FileName1> |
		Then I copy output files to local
		| ReportHeading   | FileName    |
		| <ReportHeading> | <FileName2> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | Class | FinancialYear | ReportDate | ReportSeq | FileName1                  | FileName2                    |
	| Test1         | N       |            |            |            |             |             | DEP   | 2014          |            | A         | WH_TFN_CPU_AUTO_R_DEP_2014 | ET_WRK_CPU_AUTO_R_DEP_O_2014 |
	| Test2         | N       |            |            |            |             |             | OPT   | 2014          |            | A         | WH_TFN_CPU_AUTO_R_OPT_2014 | ET_WRK_CPU_AUTO_R_OPT_O_2014 |



@ReportGoldcopyESS
@ESSTradeOrderTransactionReport
@NAB2_AUTO_R
@ReportingGold
Scenario Outline:ESS_Trade_Order_Transaction_Report
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "control reporting" within the Reporting System Menu
		And In RSS13000 I click on: "trading system reporting" within the Control Reporting Menu
		And In TRDRSP00 I click on: "trade order transaction report" with in the Trading System Reporting Menu
		And In TRDRSP11 I continue with the following details:	
		| Preload   |
		| <Preload> |
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
		And In TRDRSP01 I continue with the following details:
		| ClientCode1   | ClientCode2   | CompanyCode1   | CompanyCode2   | ClassCode1   | ClassCode2   | RegCode1   | RegCode2   | TrdCntrlCode1   | TrdCntrlCode2   | TrdCntrlCode3   | ReportNonCurrent   | TrdType   | RealTimeTrdInd   | TrdOrdStatus1   | TrdOrdStatus2   | CutOffDateFrom   | CutOffDateTO   | TrdDateFrom   | TrdDateTO   | StlDateFrom   | StlDateTO   | OrdNumFrom   | OrdNumTO   | FinalPriceFrom   | FinalPriceTO   | TotUnitRangeFrom   | TotUnitRangeTO   | TotMnyRangeFrom   | TotMnyRangeTO   | TranNumRangeFrom   | TranNumRangeTO   | PymtRefRangeFrom   | PymtRefRangeTO   |
		| <ClientCode1> | <ClientCode2> | <CompanyCode1> | <CompanyCode2> | <ClassCode1> | <ClassCode2> | <RegCode1> | <RegCode2> | <TrdCntrlCode1> | <TrdCntrlCode2> | <TrdCntrlCode3> | <ReportNonCurrent> | <TrdType> | <RealTimeTrdInd> | <TrdOrdStatus1> | <TrdOrdStatus2> | <CutOffDateFrom> | <CutOffDateTO> | <TrdDateFrom> | <TrdDateTO> | <StlDateFrom> | <StlDateTO> | <OrdNumFrom> | <OrdNumTO> | <FinalPriceFrom> | <FinalPriceTO> | <TotUnitRangeFrom> | <TotUnitRangeTO> | <TotMnyRangeFrom> | <TotMnyRangeTO> | <TranNumRangeFrom> | <TranNumRangeTO> | <PymtRefRangeFrom> | <PymtRefRangeTO> |
		And In TRDRSP03 I continue with the following details:
		| OrderType   | LimitPriceFrom   | LimitPriceTO   | OrdDurationType   | OrmsOrderStatus1   | OrmsOrderStatus2   | DateOrderSentFrom   | DateOrderSentTo   | BrokerCode   | BrokerAccount   | RecnCode   | PayAccount1   | PayAccount2   | ChgPaidBY1   | ChgPaidBY2   | ChgType1   | ChgType2   | PaymentMethod1   | PaymentMethod2   | PymtCurrCode1   | PymtCurrCode2   | ReportFormat   | CertDtlsInd   | ReversedTradeInd   |
		| <OrderType> | <LimitPriceFrom> | <LimitPriceTO> | <OrdDurationType> | <OrmsOrderStatus1> | <OrmsOrderStatus2> | <DateOrderSentFrom> | <DateOrderSentTo> | <BrokerCode> | <BrokerAccount> | <RecnCode> | <PayAccount1> | <PayAccount2> | <ChgPaidBY1> | <ChgPaidBY2> | <ChgType1> | <ChgType2> | <PaymentMethod1> | <PaymentMethod2> | <PymtCurrCode1> | <PymtCurrCode2> | <ReportFormat> | <CertDtlsInd> | <ReversedTradeInd> |
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
	| ReportHeading | Preload | HolderIdentifier | StaticDetails | ExtraIdentifier | HomePhone | EmailAddress | HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | ClientCode1 | ClientCode2 | CompanyCode1 | CompanyCode2 | ClassCode1 | ClassCode2 | RegCode1 | RegCode2 | TrdCntrlCode1 | TrdCntrlCode2 | TrdCntrlCode3 | ReportNonCurrent | TrdType | RealTimeTrdInd | TrdOrdStatus1 | TrdOrdStatus2 | CutOffDateFrom | CutOffDateTO | TrdDateFrom | TrdDateTO | StlDateFrom | StlDateTO | OrdNumFrom | OrdNumTO | FinalPriceFrom | FinalPriceTO   | TotUnitRangeFrom | TotUnitRangeTO | TotMnyRangeFrom | TotMnyRangeTO  | TranNumRangeFrom | TranNumRangeTO | PymtRefRangeFrom | PymtRefRangeTO | OrderType | LimitPriceFrom | LimitPriceTO   | OrdDurationType | OrmsOrderStatus1 | OrmsOrderStatus2 | DateOrderSentFrom | DateOrderSentTo | BrokerCode | BrokerAccount | RecnCode | PayAccount1 | PayAccount2 | ChgPaidBY1 | ChgPaidBY2 | ChgType1 | ChgType2 | PaymentMethod1 | PaymentMethod2 | PymtCurrCode1 | PymtCurrCode2 | ReportFormat | CertDtlsInd | ReversedTradeInd |
	| Test1         | N       | Y                | N             | N               | N         | N            | N            |              |               |               |                  | CRM         |             | NAB2_AUTO_R  |              |            |            |          |          |               |               |               | N                |         |                |               |               |                |              |             |           |             |           |            | 9999999  |                | 9999999.999999 |                  | 99999999999999 |                 | 99999999999.99 |                  | 99999999       |                  | 99999999       |           |                | 99999999999.99 |                 |                  |                  |                   |                 |            |               |          |             |             |            |            |          |          |                |                |               |               | B            | N           |                  |
	| Test2         | N       | Y                | N             | N               | N         | N            | N            |              |               |               |                  | CRM         |             | NAB2_AUTO_R  |              | ATS        |            |          |          |               |               |               | N                |         |                |               |               |                |              |             |           |             |           |            | 9999999  |                | 9999999.999999 |                  | 99999999999999 |                 | 99999999999.99 |                  | 99999999       |                  | 99999999       |           |                | 99999999999.99 |                 |                  |                  |                   |                 |            |               |ESSOPT    |             |             |            |            |          |          |                |                |               |               | C            | N           |                  |



@ReportGoldcopyESS
@ESSCompanyTradeOrderReport
@NAB2_AUTO_R
@ReportingGold
Scenario Outline:ESS_Company_Trade_Order_Report
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "control reporting" within the Reporting System Menu
		And In RSS13000 I click on: "trading system reporting" within the Control Reporting Menu
		And In TRDRSP00 I click on: "company trade order report" with in the Trading System Reporting Menu
		And In TRDRSP01 I continue with the following details:
		| ClientCode1   | ClientCode2   | CompanyCode1   | CompanyCode2   | ClassCode1   | ClassCode2   | RegCode1   | RegCode2   | TrdCntrlCode1   | TrdCntrlCode2   | TrdCntrlCode3   | ReportNonCurrent   | TrdType   | RealTimeTrdInd   | TrdOrdStatus1   | TrdOrdStatus2   | CutOffDateFrom   | CutOffDateTO   | TrdDateFrom   | TrdDateTO   | StlDateFrom   | StlDateTO   | OrdNumFrom   | OrdNumTO   | FinalPriceFrom   | FinalPriceTO   | TotUnitRangeFrom   | TotUnitRangeTO   | TotMnyRangeFrom   | TotMnyRangeTO   | TranNumRangeFrom   | TranNumRangeTO   | PymtRefRangeFrom   | PymtRefRangeTO   |
		| <ClientCode1> | <ClientCode2> | <CompanyCode1> | <CompanyCode2> | <ClassCode1> | <ClassCode2> | <RegCode1> | <RegCode2> | <TrdCntrlCode1> | <TrdCntrlCode2> | <TrdCntrlCode3> | <ReportNonCurrent> | <TrdType> | <RealTimeTrdInd> | <TrdOrdStatus1> | <TrdOrdStatus2> | <CutOffDateFrom> | <CutOffDateTO> | <TrdDateFrom> | <TrdDateTO> | <StlDateFrom> | <StlDateTO> | <OrdNumFrom> | <OrdNumTO> | <FinalPriceFrom> | <FinalPriceTO> | <TotUnitRangeFrom> | <TotUnitRangeTO> | <TotMnyRangeFrom> | <TotMnyRangeTO> | <TranNumRangeFrom> | <TranNumRangeTO> | <PymtRefRangeFrom> | <PymtRefRangeTO> |
		And In TRDRSP03 I continue with the following details:
		| OrderType   | LimitPriceFrom   | LimitPriceTO   | OrdDurationType   | OrmsOrderStatus1   | OrmsOrderStatus2   | DateOrderSentFrom   | DateOrderSentTo   | BrokerCode   | BrokerAccount   | RecnCode   | PayAccount1   | PayAccount2   | ChgPaidBY1   | ChgPaidBY2   | ChgType1   | ChgType2   | PaymentMethod1   | PaymentMethod2   | PymtCurrCode1   | PymtCurrCode2   | ReportFormat   | CertDtlsInd   | ReversedTradeInd   |
		| <OrderType> | <LimitPriceFrom> | <LimitPriceTO> | <OrdDurationType> | <OrmsOrderStatus1> | <OrmsOrderStatus2> | <DateOrderSentFrom> | <DateOrderSentTo> | <BrokerCode> | <BrokerAccount> | <RecnCode> | <PayAccount1> | <PayAccount2> | <ChgPaidBY1> | <ChgPaidBY2> | <ChgType1> | <ChgType2> | <PaymentMethod1> | <PaymentMethod2> | <PymtCurrCode1> | <PymtCurrCode2> | <ReportFormat> | <CertDtlsInd> | <ReversedTradeInd> |
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
	| ReportHeading | ClientCode1 | ClientCode2 | CompanyCode1 | CompanyCode2 | ClassCode1 | ClassCode2 | RegCode1 | RegCode2 | TrdCntrlCode1 | TrdCntrlCode2 | TrdCntrlCode3 | ReportNonCurrent | TrdType | RealTimeTrdInd | TrdOrdStatus1 | TrdOrdStatus2 | CutOffDateFrom | CutOffDateTO | TrdDateFrom | TrdDateTO | StlDateFrom | StlDateTO | OrdNumFrom | OrdNumTO | FinalPriceFrom | FinalPriceTO   | TotUnitRangeFrom | TotUnitRangeTO | TotMnyRangeFrom | TotMnyRangeTO  | TranNumRangeFrom | TranNumRangeTO | PymtRefRangeFrom | PymtRefRangeTO | OrderType | LimitPriceFrom | LimitPriceTO   | OrdDurationType | OrmsOrderStatus1 | OrmsOrderStatus2 | DateOrderSentFrom | DateOrderSentTo | BrokerCode | BrokerAccount | RecnCode | PayAccount1 | PayAccount2 | ChgPaidBY1 | ChgPaidBY2 | ChgType1 | ChgType2 | PaymentMethod1 | PaymentMethod2 | PymtCurrCode1 | PymtCurrCode2 | ReportFormat | CertDtlsInd | ReversedTradeInd |
	| Test1         | CRM         |             | NAB2_AUTO_R  |              |            |            |          |          |               |               |               | N                |         |                |               |               |                |              |             |           |             |           |            | 9999999  |                | 9999999.999999 |                  | 99999999999999 |                 | 99999999999.99 |                  |                |                  |                |           |                | 99999999999.99 |                 |                  |                  |                   |                 |            |               |          |             |             |            |            |          |          |                |                |               |               | B            |             |                  |
	| Test2         | CRM         |             | NAB2_AUTO_R  |              |            |            |          |          |               |               |               | N                |         |                |               |               |                |              |             |           |             |           |            | 9999999  |                | 9999999.999999 |                  | 99999999999999 |                 | 99999999999.99 |                  |                |                  |                |           |                | 99999999999.99 |                 |                  |                  |                   |                 |            |               |INVMSW    |             |             |            |            |          |          |                |                |               |               | C            |             |                  |
	| Test3         | CRM         |             | NAB2_AUTO_R  |CPU_AUTO_R    |            |            |          |          |               |               |               | N                |         |                |               |               |                |              |             |           |             |           |            | 9999999  |                | 9999999.999999 |                  | 99999999999999 |                 | 99999999999.99 |                  |                |                  |                |           |                | 99999999999.99 |                 |                  |                  |                   |                 |            |               |INVMSW    |             |             |            |            |          |          |                |                |               |               | C            |             |                  |


@ReportGoldcopyESS
@ESSTradeControlHousekeepingReport
@NAB2_AUTO_R
@ReportingGold
Scenario Outline:ESS_Trade_Control_Housekeeping_Report
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "control reporting" within the Reporting System Menu
		And In RSS13000 I click on: "trading system reporting" within the Control Reporting Menu
		And In TRDRSP00 I click on: "trade control housekeeping report" with in the Trading System Reporting Menu
		And In TRDRSP12 I continue with the following details:
		| ClassCode1   | ClassCode2   | TrdCntrlCode1   | TrdCntrlCode2   | TrdCntrlCode3   | TrdType   | ReportNonCurrent   | ReportEventBulks   | ApplyTransactions   | ONMarketTradeInd   | RealTimeTrdInd   | OnlineEntryInd   | WebEntryInd   | TransactionAuditInd   | ReconciliationCode1   | ReconciliationCode2   | ClientCode1   | ClientCode2   | CompanyCode1   | CompanyCode2   |
		| <ClassCode1> | <ClassCode2> | <TrdCntrlCode1> | <TrdCntrlCode2> | <TrdCntrlCode3> | <TrdType> | <ReportNonCurrent> | <ReportEventBulks> | <ApplyTransactions> | <ONMarketTradeInd> | <RealTimeTrdInd> | <OnlineEntryInd> | <WebEntryInd> | <TransactionAuditInd> | <ReconciliationCode1> | <ReconciliationCode2> | <ClientCode1> | <ClientCode2> | <CompanyCode1> | <CompanyCode2> |
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
	| ReportHeading | ClassCode1 | ClassCode2 | TrdCntrlCode1 | TrdCntrlCode2 | TrdCntrlCode3 | TrdType | ReportNonCurrent | ReportEventBulks | ApplyTransactions | ONMarketTradeInd | RealTimeTrdInd | OnlineEntryInd | WebEntryInd | TransactionAuditInd | ReconciliationCode1 | ReconciliationCode2 | ClientCode1 | ClientCode2 | CompanyCode1 | CompanyCode2 |
	| Test1         |            |            |               |               |               |         | N                | I                |                   |                  |                |                |             |                     |                     |                     |             |             |              |              |
	| Test2         | OPT        |            |               |               |               | S       | N                | I                |                   |                  |                |                |             |                     |                     |                     |             |             |              |              |
	| Test3         |            |            |               |               |               | T       | N                | I                |                   |                  |                |                |             |                     |                     |                     |             |             |              |              |


@ReportGoldcopyESS
@ESSCompanyTradeControlHousekeepingReport
@NAB2_AUTO_R
@ReportingGold
Scenario Outline:ESS_Company_Trade_Control_Housekeeping_Report
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "control reporting" within the Reporting System Menu
		And In RSS13000 I click on: "trading system reporting" within the Control Reporting Menu
		And In TRDRSP00 I click on: "company trade control housekeeping report" with in the Trading System Reporting Menu
		And In TRDRSP12 I continue with the following details:
		| ClassCode1   | ClassCode2   | TrdCntrlCode1   | TrdCntrlCode2   | TrdCntrlCode3   | TrdType   | ReportNonCurrent   | ReportEventBulks   | ApplyTransactions   | ONMarketTradeInd   | RealTimeTrdInd   | OnlineEntryInd   | WebEntryInd   | TransactionAuditInd   | ReconciliationCode1   | ReconciliationCode2   | ClientCode1   | ClientCode2   | CompanyCode1   | CompanyCode2   |
		| <ClassCode1> | <ClassCode2> | <TrdCntrlCode1> | <TrdCntrlCode2> | <TrdCntrlCode3> | <TrdType> | <ReportNonCurrent> | <ReportEventBulks> | <ApplyTransactions> | <ONMarketTradeInd> | <RealTimeTrdInd> | <OnlineEntryInd> | <WebEntryInd> | <TransactionAuditInd> | <ReconciliationCode1> | <ReconciliationCode2> | <ClientCode1> | <ClientCode2> | <CompanyCode1> | <CompanyCode2> |
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
	| ReportHeading | ClassCode1 | ClassCode2 | TrdCntrlCode1 | TrdCntrlCode2 | TrdCntrlCode3 | TrdType | ReportNonCurrent | ReportEventBulks | ApplyTransactions | ONMarketTradeInd | RealTimeTrdInd | OnlineEntryInd | WebEntryInd | TransactionAuditInd | ReconciliationCode1 | ReconciliationCode2 | ClientCode1 | ClientCode2 | CompanyCode1 | CompanyCode2 |
	| Test1         |            |            |               |               |               |         | N                | I                |                   |                  |                |                |             |                     |                     |                     |             |             | NAB2_AUTO_R  |              |
	| Test2         |            |            |               |               |               | T       | N                | I                |                   |                  |                |                |             |                     |                     |                     |             |             | NAB2_AUTO_R  | CPU_AUTO_R   |


@ReportGoldcopyESS
@ESScommissioncodehousekeepingreport
@NAB2_AUTO_R
@ReportingGold
Scenario Outline:ESS_Commission_Code_Housekeeping_Report
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "control reporting" within the Reporting System Menu
		And In RSS13000 I click on: "trading system reporting" within the Control Reporting Menu
		And In TRDRSP00 I click on: "commission code housekeeping report" with in the Trading System Reporting Menu
		And In TRDRSP13 I continue with the following details:
		| CommChgCode1   | CommChgCode2   | CommChgCode3   | ReportMasterCodes   | CommChgTypes1   | CommChgTypes2   | CommChgTypes3   | TestChargeCodesInd   | TestCalcDealInput   | TestCalcBulkInput   | TestCalcUnitInput   | ClientCode1   | ClientCode2   | CompanyCode1   | CompanyCode2   |
		| <CommChgCode1> | <CommChgCode2> | <CommChgCode3> | <ReportMasterCodes> | <CommChgTypes1> | <CommChgTypes2> | <CommChgTypes3> | <TestChargeCodesInd> | <TestCalcDealInput> | <TestCalcBulkInput> | <TestCalcUnitInput> | <ClientCode1> | <ClientCode2> | <CompanyCode1> | <CompanyCode2> |
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
	| ReportHeading | CommChgCode1 | CommChgCode2 | CommChgCode3 | ReportMasterCodes | CommChgTypes1 | CommChgTypes2 | CommChgTypes3 | TestChargeCodesInd | TestCalcDealInput | TestCalcBulkInput | TestCalcUnitInput | ClientCode1 | ClientCode2 | CompanyCode1 | CompanyCode2 |
	| Test1         |              |              |              | N                 |               |               |               | N                  |                   |                   |                   |             |             |              |              |
	| Test2         | C2UK         | C3UK         | C4UK         | N                 |               |               |               | N                  |                   |                   |                   |             |             |              |              |
	| Test3         |              |              |              | N                 | B             |               |               | N                  |                   |                   |                   |             |             |              |              |


@ReportGoldcopyESS
@ESScompanycommissioncodehousekeepingreport
@NAB2_AUTO_R
@ReportingGold
Scenario Outline:ESS_Company_Commission_Code_Housekeeping_Report
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO_R"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "control reporting" within the Reporting System Menu
		And In RSS13000 I click on: "trading system reporting" within the Control Reporting Menu
		And In TRDRSP00 I click on: "company commission code housekeeping report" with in the Trading System Reporting Menu
		And In TRDRSP13 I continue with the following details:
		| CommChgCode1   | CommChgCode2   | CommChgCode3   | ReportMasterCodes   | CommChgTypes1   | CommChgTypes2   | CommChgTypes3   | TestChargeCodesInd   | TestCalcDealInput   | TestCalcBulkInput   | TestCalcUnitInput   | ClientCode1   | ClientCode2   | CompanyCode1   | CompanyCode2   |
		| <CommChgCode1> | <CommChgCode2> | <CommChgCode3> | <ReportMasterCodes> | <CommChgTypes1> | <CommChgTypes2> | <CommChgTypes3> | <TestChargeCodesInd> | <TestCalcDealInput> | <TestCalcBulkInput> | <TestCalcUnitInput> | <ClientCode1> | <ClientCode2> | <CompanyCode1> | <CompanyCode2> |
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
	| ReportHeading | CommChgCode1 | CommChgCode2 | CommChgCode3 | ReportMasterCodes | CommChgTypes1 | CommChgTypes2 | CommChgTypes3 | TestChargeCodesInd | TestCalcDealInput | TestCalcBulkInput | TestCalcUnitInput | ClientCode1 | ClientCode2 | CompanyCode1 | CompanyCode2 |
	| Test1         |              |              |              | N                 |               |               |               | N                  |                   |                   |                   |             |             | CPU_AUTO_R   |              |
	| Test2         | CBNK         | CBNZ         | CBPB         | N                 |               |               |               | N                  |                   |                   |                   |             |             | CPU_AUTO_R   |              |
	| Test3         |              |              |              | N                 | B             | C             |               | N                  |                   |                   |                   |             |             | CPU_AUTO_R   |              |
	| Test4         |              |              |              | N                 | C             |               |               | N                  |                   |                   |                   |             |             | CPU_AUTO_R   | NAB2_AUTO_R  |


@ReportGoldcopyESS 
@ESS_EmployeeExtractReport_Gold
@CPU_AUTO_R
@42419
@ReportingGold
Scenario Outline:ESS_Employee_Extract_Report_Goldcopy_Detail
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
		And In ERS01010 I continue with the following values:
		| HolderIdentifier   | HolderCat   | HolderNumber   | RegAddress   | RegAddrCase   | HolderName   | Fullnames   | CaseFull   | FormattedFull   | NameDetailed   | CaseDetailed   | Surname   | FirstName   | SecondName   | ThirdName   | Title   | Initials   | Designator   | NameKey   | NameType   | HolderAddress   | HolderAddressCase   | IncludePcode   | PcodeDomicile   | Dpid   | Barcode   | AlternateID   | Ers01010PersonalUrl   |
		| <HolderIdentifier> | <HolderCat> | <HolderNumber> | <RegAddress> | <RegAddrCase> | <HolderName> | <Fullnames> | <CaseFull> | <FormattedFull> | <NameDetailed> | <CaseDetailed> | <Surname> | <FirstName> | <SecondName> | <ThirdName> | <Title> | <Initials> | <Designator> | <NameKey> | <NameType> | <HolderAddress> | <HolderAddressCase> | <IncludePcode> | <PcodeDomicile> | <Dpid> | <Barcode> | <AlternateID> | <Ers01010PersonalUrl> |
		And In ERS01011 I continue with the following details:
		| StaticDetails |
		| N             |
		And In ERS01012 I continue with the following Values:
		| ExtraIdentifier | HomePhone | WorkPhone | FaxNumber | MobilePhone | EmailAddress | ReturnedEmail |
		| Y               | Y         | Y         | Y         | Y           | Y            | Y             |
		And In ERS01028 I continue with the following Values:
		| HolderStatus | DeceasedFlag | ExceptionFlag | StopTradeFlag | DivIntentionFlag | VariableFlags | VariableField | TfnDescription | Dates | MailUnclaimedDate | HolderONDate | HolderOffDate | HolderAddedDate | PlanDetails | DrpDetails | DrpPlanDesc | BspDetails | BspPlanDesc | DirectCredit | BankID | BankNamadd | BankAccountNbr | BankAccountName |
		| Y            | Y            | Y             | Y             | Y                | Y             | Y             | Y              | Y     | Y                 | Y            | Y             | Y               | Y           | Y          | FP DRP      | N          | N           | Y            | Y      | Y          | Y              | Y               |
		And In ERS01013 I continue with the following details:			
		| Selcls1   | Selcls2   | Selgrp1   | Selgrp2   | Exd1   | UnitBalanceFrom   | UnitBalanceTO   | HolderTotalsOnly   | Selgrp3   | Selgrp4   | Selgrp5   | Selgrp6   | TransDateFrom   | TransDateTO   |
		| <Selcls1> | <Selcls2> | <Selgrp1> | <Selgrp2> | <Exd1> | <UnitBalanceFrom> | <UnitBalanceTO> | <HolderTotalsOnly> | <Selgrp3> | <Selgrp4> | <Selgrp5> | <Selgrp6> | <TransDateFrom> | <TransDateTO> |
		And In ERS01016 I continue with the following details:	
		| ClassCode | RegisterCode | RegisterType | AwardDate | ResidualXferDate | ResidualXferDate | ResidualXferAmount | HoldingEndDate | TaxEndDate | Ers01016ForfEndDate | Vwap | ShareCost | CurrentBalance | OriginalBalance | TotalCost | Usan | SavingsAmount | TotalSavings | PaymentFrequency | Residue | TaxAssessed | TerminationInd |
		| Y         | Y            | Y            | Y         | Y                | Y                | Y                  | Y              | Y          | Y                   | Y    | Y         | Y              | Y               | Y         | Y    | Y             | Y            | Y                | Y       | Y           | Y              |
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
	| ReportHeading | company    | Preload | WildString | EmpStatus1 | EmpStatus2 | LeaverCode1 | LeaverCode2 | HolderIdentifier | HolderCat | HolderNumber | RegAddress | RegAddrCase | HolderName | Fullnames | CaseFull | FormattedFull | NameDetailed | CaseDetailed | Surname | FirstName | SecondName | ThirdName | Title | Initials | Designator | NameKey | NameType | HolderAddress | HolderAddressCase | IncludePcode | PcodeDomicile | Dpid | Barcode | AlternateID | Ers01010PersonalUrl | Selcls1 | Selcls2 | Selgrp1 | Selgrp2 | Exd1 | UnitBalanceFrom | UnitBalanceTO | HolderTotalsOnly | Selgrp3 | Selgrp4 | Selgrp5 | Selgrp6 | TransDateFrom | TransDateTO | Select | FieldSeparator | TextDelimiterReq | ReportDate | ReportSeq |
	| Test1         | CPU_AUTO_R | N       |            |            |            |             |             | Y                | Y         | Y            | Y          | M           | Y          | Y         | M        | Y             | Y            | M            | Y       | Y         | Y          | Y         | Y     | Y        | Y          | Y       | Y        | Y             | M                 | Y            | Y             | Y    | Y       | Y           | Y                   |         |         |         |         |      |                 | 99999999999   | N                |         |         |         |         |               |             | S      | ,              | Y                |            | A         |
	| Test2         | CPU_AUTO_R | N       |            |            |            |             |             | Y                | Y         | Y            | Y          | M           | Y          | Y         | M        | Y             | Y            | M            | Y       | Y         | Y          | Y         | Y     | Y        | Y          | Y       | Y        | Y             | M                 | Y            | Y             | Y    | Y       | Y           | Y                   |         |         |         |         |      |                 | 99999999999   | Y                |         |         |         |         |               |             | S      | ,              | Y                |            | A         |
	| Test3         | CPU_AUTO_R | N       |            |            |            |             |             | Y                | Y         | Y            | Y          | M           | Y          | Y         | M        | Y             | Y            | M            | Y       | Y         | Y          | Y         | Y     | Y        | Y          | Y       | Y        | Y             | M                 | Y            | Y             | Y    | Y       | Y           | Y                   |         |         |         |         |      |                 | 99999999999   | Y                |         |         |         |         | 01/01/2012    |01/01/2015   | S      | ,              | Y                |            | A         |
	| Test4         | QBE_AUTO_R | N       |            |            |            |             |             | Y                | Y         | Y            | Y          | M           | Y          | Y         | M        | Y             | Y            | M            | Y       | Y         | Y          | Y         | Y     | Y        | Y          | Y       | Y        | Y             | M                 | Y            | Y             | Y    | Y       | Y           | Y                   |         |         |         |         |      |                 | 99999999999   | N                |         |         |         |         |               |             | S      | ,              | Y                |            | A         |

