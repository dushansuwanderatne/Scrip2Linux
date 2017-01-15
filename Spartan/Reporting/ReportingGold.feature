Feature: ReportingGold

@TopHoldersReport_Gold
@QBE_AUTO_R
@25592
@ReportGoldcopyOther
@ReportingGold
Scenario:Top_Holders_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "top holders list" within the Reporting System Menu
	And In RSS02010 I continue with the following details:
	| ReportDate | ASATRun |
	| 20/07/2015 | 5190    |
	And In RSS02020 I continue with the following details:
	| Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | ClgCon | GroupIDX | TopSHLimit | ReportType | ReportRun1 | ReportRun1 | UseGroupCodes | PrintGrpDetails | HolderIDTOPrint | NameAddressTOPrint | HtcFlag | HT | SystemInfoFree6 | SystemInfoFree4 | SystemInfoFree7 | SystemInfoFree5 |
	| DCP  | DMZ  | EDL  | EMP  |      |      |      |      |      |       | 5      |          | 100        | S          |            |            | Y             |                 | Y               | F                  | A       |    |                 |                 |                 |                 |
	And In RSS10060 I continue with the following details:
	| ClsgrpOutputOption |
	|          A         |		
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

@LikeHoldersSummaryReport_Gold
@QBE_AUTO_R
@28503
@ReportGoldcopyOther
@ReportingGold
Scenario:Like_Holders_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "like holders summary" within the Reporting System Menu
	And In RSS05500 I continue with the following details:
	| Selection | Cls1 | Match | UseInputFile |
	| B         | DCV  | A     | N            |
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
@QBE_AUTO_R
@28977
@ReportGoldcopyOther
@ReportingGold
Scenario:Significant_Trade_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "shareholder movement reporting" within the Reporting System Menu
	And In RSS18010 I click on: "significant trade report" within the Shareholder Movement Reporting Menu
	And In RSS18000 I continue with the following details:
	| PreloadDefaults |
	| N               |
	And In RSS18001 I continue with the following details:
	| ReportHeading            | Cls1 | Cls2 | Cls3 | NadTOPrint | MovementLevel | HolderLimit | ReportType | 
	| Significant Trade Report | DEA  | DCP  | ENT  | N          | 150           | 100         | D          | 
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

@PlanDetailReport_Gold
@QBE_AUTO_R
@28979
@ReportGoldcopyOther
@ReportingGold
Scenario:Plan_Detail_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "plan reporting" within the Reporting System Menu
	And In RSS07001 I continue with the following details:
	| Selection |
	| PD        |
	And In RSS07500 I continue with the following details:
	| PlanSelection1 | PlanSelection2 | PlanPartType | BalanceSelection |  ReportType |
	| BSP1           | DRP1           | P            | W                |    F        |  
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

@BrokerApplicationReport_Gold
@QBE_AUTO_R
@28981
@ReportGoldcopyOther
@ReportingGold
#### Bug 69724:Reports -Broker_Application_Report -Files are different in VMS and Linux ####
Scenario Outline:Broker_Application_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "broker reporting" within the Reporting System Menu
	And In RSS09000 I click on: "broker application report" within the Broker Analysis Menu
	And In RSS09002 I continue with the following details:
	| RepDate   | BrokerCode1   | BrokerCode2   | Brokercode3   | BrokerCode4   | BrokerCode5   | Cls1   | Cls2  | Cls3  | ClgCon  | RunFrom   | RunTO   | BrokerReportSeq   | PrintUnknown   | ReportType   | PrintHin   | BrokerCommission   | CommissionFrom1   | CommissionTo1   | CommPerc   | ChequesRequired   | ChequeDate | ChequeFormat |
	| <RepDate> | <BrokerCode1> | <BrokerCode2> | <Brokercode3> | <BrokerCode4> | <BrokerCode5> | <Cls1> | <Cls2> | <Cls3> | <ClgCon> |  <RunFrom> | <RunTO> | <BrokerReportSeq> | <PrintUnknown> | <ReportType> | <PrintHin> | <BrokerCommission> | <CommissionFrom1> | <CommissionTo1> | <CommPerc> | <ChequesRequired> | <ChequeDate> | <ChequeFormat> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples:
| ReportHeading | RepDate   | BrokerCode1 | BrokerCode2 | Brokercode3 | BrokerCode4 | BrokerCode5 | Cls1 | Cls2 | Cls3 | ClgCon | RunFrom | RunTO | BrokerReportSeq | PrintUnknown | ReportType | PrintHin | BrokerCommission | CommissionFrom1 | CommissionTo1 | CommPerc | ChequesRequired | ChequeDate | ChequeFormat |
| Iteration1    | 3/09/2015 |             |             |             |             |             | ENT  |      |      |        | 1       | 5208  | c               | Y            | F          | Y        | N                | 1               | 10            | 60       |                 | 1/1/2000   | 2            |
#| Iteration3 |           | 4094        | 4125        | 6381        | 21008       | 62571       | DEV  |      |      | 7      | 5037    | 5208  | c               | Y            | F          | N        | Y                | 1               | 10            | 60       | N               |            |              |
#| Iteration4 |           | 4094        | 62571       |             |             |             | ENT  | EVP  | LNN  | 1      | 1       | 5208  | B               | N            | B          | Y        | Y                | 1               | 10            | 60       | Y               | 1/1/2000   | 5            |
																																																																											   



@TransactionActivityReport_Gold
@QBE_AUTO_R
@28980
@ReportGoldcopyOther
@ReportingGold
### Test Data is incorrect. Reports have not generated ###
Scenario Outline:Transaction_Activity_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "control reporting" within the Reporting System Menu
	And In RSS13000 I click on: "transaction activity reporting" within the Control Reporting Menu
	And In RSS23001 I continue with the following details:
	| Client | Company  | UserName | StartDate  | EndDate      | OrigSystem | ServProvider | ServCode | Department | Branch | TransCode1   | TransCode2   | BrokerCode | AccessCode | ReportType   |
	| CRS    | QBE_AUTO_R |          | 01/07/2011 | 25/08/2011 | TEST       |              |          | SCRPDV     |        | <TransCode1> | <TransCode2> |            |            | <ReportType> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy
  
  Examples: 
  | ReportHeading | ReportType | TransCode1 | TransCode2 |
  | ReportTypeS   | S          | NACHG      | ESCVP      |
#  | ReportTypeD   | D          | EVADD      |            |


@ShareholderMovementReport_Gold
@QBE_AUTO_R
@29320
@ReportGoldcopyOther
@ReportingGold
Scenario:Shareholder_Movement_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "shareholder movement reporting" within the Reporting System Menu
	And In RSS18010 I click on: "shareholder movement report" within the Shareholder Movement Reporting Menu
	And In RSS19000 I continue with the following details:
	| PreloadDefaults |
	| N               |
	And In RSS19001 I continue with the following details:
	| Cls1 | Cls2 | Cls3 | Clg | Htc | BalanceLimit | RunFrom | RunTO |
	| EBS  | LNN  | DEA  | 1   |     | 5000         | 1       | 5206  |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

@BrokerTradingAnalysisReport_Gold
@QBE_AUTO_R
@29873
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Broker_Trading_Analysis_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "broker reporting" within the Reporting System Menu
	And In RSS09000 I click on: "broker trading analysis" within the Broker Analysis Menu
	And In RSS09001 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | Level   | Sequence   | BrokerCode   | Selection   | RunFrom   | RunTO   | TransGroupFrom   | TransGroupTO   |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <Level> | <Sequence> | <BrokerCode> | <Selection> | <RunFrom> | <RunTO> | <TransGroupFrom> | <TransGroupTO> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples:
| ReportHeading | Cls1 | Cls2 | Cls3 | Cls4 | Level | Sequence | BrokerCode | Selection | RunFrom | RunTO | TransGroupFrom | TransGroupTO |
| Iteration1    |      |      |      |      | 500   | A        |            | S         | 1       | 5208  |                |              |
| Iteration2    | DCP  | DEA  | EBR  | ENT  | 200   | D        | 62571      | A         | 5144    | 5170  | 1              | 5            |


@TransactionSummaryReport_Gold
@QBE_AUTO_R
@28489
@ReportGoldcopyOther
@ReportingGold
#### need to stop this report once its passed. as it is taking 17mins to complete the job ###
Scenario Outline:Transaction_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "control reporting" within the Reporting System Menu
	And In RSS13000 I click on: "transaction summary reporting" within the Control Reporting Menu
	And In RSS13003 I continue with the following details:
	| Companies   | OutputFormat   | DateFrom   | DateTO   |
	| <ReportType> | <OutputFormat> | <DateFrom> | <DateTO> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 1200    | error        |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples:
| ReportHeading | ReportType | OutputFormat | DateFrom | DateTO |
| ReportTypeC   | C          | F            | 0111     | 0416   |
| ReportTypeA   | A          | T            | 1214     | 0215   |


@SignificantHolderReport_Gold
@QBE_AUTO_R
@30546
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Significant_Holder_Report_Goldcopy
#### Bug 86315:Reports -Significant_Holder_Report -Files are different in VMS and Linux ###
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "shareholder movement reporting" within the Reporting System Menu
	And In RSS18010 I click on: "significant holder report" within the Shareholder Movement Reporting Menu
	And In RSS01500 I continue with the following details:
	| PreloadDefaults |
	| N               | 
	And In RSS01501 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | ClgCon   | Selection   | GroupEssTrustees   | HighestBalanceLevel   | MovementSelection   | MovementLevel   | ReportingPeriod | RunFrom | RunTO | NameAddressTOPrint | Sequence | HolderLimit | HolderIDTOPrint | Order | IncEntrepot | PrintGrpDetails |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <ClgCon> | <Selection> | <GroupEssTrustees> | <HighestBalanceLevel> | <MovementSelection> | <MovementLevel> |<ReportingPeriod> | <RunFrom> | <RunTO> | <NameAddressTOPrint> | <Sequence> | <HolderLimit> | <HolderIDTOPrint> | <Order> | <IncEntrepot> | <PrintGrpDetails> | 
	And In RSS10060 I continue with the following details:
	|ClsgrpOutputOption|
	|<ClsgrpOutputOption>|
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 800    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy
	
Examples:
	| ReportHeading | Cls1 | Cls2 | Cls3 | Cls4 | ClgCon | Selection | GroupEssTrustees | HighestBalanceLevel | MovementSelection | MovementLevel | ReportingPeriod | RunTO | RunFrom | NameAddressTOPrint | Sequence | HolderLimit | HolderIDTOPrint | Order | IncEntrepot | PrintGrpDetails | ClsgrpOutputOption |
	| Broad         |      |      |      |      | 1      | M         | N                |                     | N                 | 500           | R               | 5208  | 5132    | F                  | A        | Y           | Y               | A     | Y           | Y               |     S               |
	| Filtered      | ASA  | DEA  | DCV  | DCP  |        | H         |                  | 500                 |                   |               | M               |       |         | F                  | D        | Y           | N               | B     | Y           |                 |      A              |

 
@PrintMasterCodesReport_Gold
@QBE_AUTO_R
@30732
@ReportGoldcopyOther
@ReportingGold
### Bug 70007:Reports -Print_Master_Codes_Report -Files are different in VMS and Linux ###
### Bug 100089:Reports -Missing closing bracket in Linux (PRN File Header record) ###
Scenario:Print_Master_Codes_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "control reporting" within the Reporting System Menu
	And In RSS13000 I click on: "print master codes" within the Control Reporting Menu
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

@HolderTypeSummaryReport_Gold
@QBE_AUTO_R
@31339
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Holder_Type_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "summary reporting" within the Reporting System Menu
	And In RSS01010 I click on: "holder type summary" within the Summary Reporting Menu
	And In RSS01015 I continue with the following details:
	| Preload   | WildString   |
	| <Preload> | <WildString> |
	And In RSS01020 I continue with the following details:
	| ReportDesc   | ASATRun   | ReportDate   | InputFile   | InputFilename   | 
	| <ReportDesc> | <ASATRun> | <ReportDate> | <InputFile> | <InputFilename> | 
	And In RSS01030 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | Cls5   | Cls6   | Cls7   | Cls8   | Cls9   | Cls10   | Clg1   | Clg2   | Clg3   | GroupIDX1   | GroupIDX2   | GroupIDX3   | Reg1   | Reg2   | Reg3   | ReportingPeriod   | MandatoryDCInd   |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <Cls5> | <Cls6> | <Cls7> | <Cls8> | <Cls9> | <Cls10> | <Clg1> | <Clg2> | <Clg3> | <GroupIDX1> | <GroupIDX2> | <GroupIDX3> | <Reg1> | <Reg2> | <Reg3> | <ReportingPeriod> | <MandatoryDCInd> |  
	And In RSS10060 I continue with the following details:
	| ClsgrpOutputOption   | ComboDescription   |
	| <ClsgrpOutputOption> | <ComboDescription> |
	And In RSS01040 I continue with the following details:
	| Runits18From   | Runits18TO   | Runits916From   | Runits916TO   | UseClassPrice   | PriceMethod   | ClassPriceA   |
	| <Runits18From> | <Runits18TO> | <Runits916From> | <Runits916TO> | <UseClassPrice> | <PriceMethod> | <ClassPriceA> |
	And In RSS01050 I continue with the following details:
	| LocalFlag   | PCFrom1   | PCTo1   | PCFrom2   | PCTo2   | DomcodeFlag   | DC1   | DC2   |
	| <LocalFlag> | <PCFrom1> | <PCTo1> | <PCFrom1> | <PCTo1> | <DomcodeFlag> | <DC1> | <DC2> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | ReportDesc          | Preload | WildString | ASATRun | ReportDate | InputFile | InputFilename | Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | Clg1 | Clg2 | Clg3 | GroupIDX1 | GroupIDX2 | GroupIDX3 | Reg1 | Reg2 | Reg3 | ClsgrpOutputOption | ComboDescription | Runits18From | Runits18TO  | Runits916From | Runits916TO | UseClassPrice | PriceMethod | ClassPriceA | LocalFlag | PCFrom1 | PCTo1 | PCFrom2 | PCTo2 | DomcodeFlag | DC1 | DC2 | ReportingPeriod | MandatoryDCInd |
	| Iteration1    | Holder Type Summary | N       |            |         |            | N         | N             | ASA  | DCP  | DCV  | DEA  | EBL  | EBR  | EBS  | LNN  | EDR  | ENT   |      |      |      |           |           |           |      |      |      | A                  |                  |              |             |               |             | N             |             |             | A         |         |       |         |       | A           |     |     |                 |                |
	| Iteration2    | Holder Type Summary | N       |            |         |            | N         | Y             | ASA  | DCP  | LNN  |      |      |      |      |      |      |       | 1    |      |      |           |           |           |      |      |      | C                  | COMBO1           | 1000         | 99999999999 |               |             | Y             | U           | 10.00       | I         | 3000    | 3020  |         |       | A           |     |     |                 |                |
	| Iteration3    | Holder Type Summary | N       |            | 5195    |            | N         | Y             |      |      |      |      |      |      |      |      |      |       | 5    | 9    |      |           |           |           | nsw  |      |      | C                  | COMBO2           | 1            | 99999999999 |               |             | Y             | R           |             | E         |         |       |         |       | E           |     |     |                 |                |
	

@LocalDomicileSummaryReport_Gold
@QBE_AUTO_R
@31592
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Local_Domicile_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "summary reporting" within the Reporting System Menu
	And In RSS01010 I click on: "local domicile summary" within the Summary Reporting Menu
	And In RSS01015 I continue with the following details:
	| Preload   | WildString   |
	| <Preload> | <WildString> |
	And In RSS01020 I continue with the following details:
	| ReportDesc   | ASATRun   | ReportDate   | InputFile   | InputFilename   | 
	| <ReportDesc> | <ASATRun> | <ReportDate> | <InputFile> | <InputFilename> | 
	And In RSS01030 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | Cls5   | Cls6   | Cls7   | Cls8   | Cls9   | Cls10   | Clg1   | Clg2   | Clg3   | GroupIDX1   | GroupIDX2   | GroupIDX3   | Reg1   | Reg2   | Reg3   | LocalDomicile   | ReportingPeriod   | MandatoryDCInd   |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <Cls5> | <Cls6> | <Cls7> | <Cls8> | <Cls9> | <Cls10> | <Clg1> | <Clg2> | <Clg3> | <GroupIDX1> | <GroupIDX2> | <GroupIDX3> | <Reg1> | <Reg2> | <Reg3> | <LocalDomicile> | <ReportingPeriod> | <MandatoryDCInd> |
	And In RSS10060 I continue with the following details:
	| ClsgrpOutputOption   |
	| <ClsgrpOutputOption> |
	And In RSS01040 I continue with the following details:
	| Runits18From   | Runits18TO   | Runits916From   | Runits916TO   | UseClassPrice   | PriceMethod   | ClassPriceA   | ClassPriceB   | ClassPriceC   | ClassPriceD   |
	| <Runits18From> | <Runits18TO> | <Runits916From> | <Runits916TO> | <UseClassPrice> | <PriceMethod> | <ClassPriceA> | <ClassPriceB> | <ClassPriceC> | <ClassPriceD> |
	And In RSS01050 I continue with the following details:
	| HtcFlag   | HT1   | HT2   | HT3   | LocalDomicileFlag   | DomicileSequence   | DomcodeFlag   |
	| <HtcFlag> | <HT1> | <HT2> | <HT3> | <LocalDomicileFlag> | <DomicileSequence> | <DomcodeFlag> | 
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

Examples: 
	| ReportHeading | ReportDesc             | Preload | WildString | ASATRun | ReportDate | InputFile | InputFilename | Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | Clg1 | Clg2 | Clg3 | GroupIDX1 | GroupIDX2 | GroupIDX3 | Reg1 | Reg2 | Reg3 | ClsgrpOutputOption | Runits18From | Runits18TO  | Runits916From | Runits916TO | UseClassPrice | HtcFlag | HT1 | HT2 | HT3 | LocalDomicileFlag | DomicileSequence | LocalDomicile | MandatoryDCInd | ReportingPeriod | DomcodeFlag | PriceMethod | ClassPriceA | ClassPriceB | ClassPriceC | ClassPriceD |
	| Itereation1   | Local/Domicile Summary | N       |            |         |            | N         | N             | DMZ  | E01  | E02  | E03  | EBS  | EC1  | EC2  | EL1  | ENT  | EVM   |      |      |      |           |           |           |      |      |      | A                  | 1000         | 99999999999 |               |             | N             | A       |     |     |     | A                 | A                | AUD           |                |                 |             |             |             |             |             |             |
	| Itereation2   | Local/Domicile Summary | N       |            |         |            | N         | Y             | ASA  | DCP  | LNN  |      |      |      |      |      |      |       | 1    |      |      |           |           |           |      |      |      | A                  | 100          | 550         | 551           | 800         | Y             | E       | CNT | DEC |     | L                 | D                | AUD           |                |                 |             |             | 10.00       | 10.00       | 10.00       | 10.00       |
	| Itereation3   | Local/Domicile Summary | N       |            | 5170    |            | N         | Y             | DCV  | ENT  |      |      |      |      |      |      |      |       | 1    | 5    |      |           |           |           | nsw  |      |      | A                  |              |             |               |             | N             | I       | COY | ESP | JNT | D                 | A                | AUD           |                |                 |             |             |             |             |             |             |

@RangeOfUnitsSummaryReport_Gold
@QBE_AUTO_R
@31614
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Range_Of_Units_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "summary reporting" within the Reporting System Menu
	And In RSS01010 I click on: "range of units summary" within the Summary Reporting Menu
	And In RSS01015 I continue with the following details:
         | Preload   | WildString |
         | <Preload> |            |
    And In RSS01020 I continue with the following details:
	| ReportDesc   | ASATRun   | ReportDate   | InputFile   | 
	| <ReportDesc> | <ASATRun> | <ReportDate> | <InputFile> |
	And In RSS01030 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | Cls5   | Cls6   | Cls7   | Cls8   | Cls9   | Cls10   | Clg1   | Clg2   | Clg3   | GroupIDX1   | GroupIDX2   | GroupIDX3   | Reg1   | Reg2   | Reg3   | ReportingPeriod   | MandatoryDCInd |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <Cls5> | <Cls6> | <Cls7> | <Cls8> | <Cls9> | <Cls10> | <Clg1> | <Clg2> | <Clg3> | <GroupIDX1> | <GroupIDX2> | <GroupIDX3> | <Reg1> | <Reg2> | <Reg3> | <ReportingPeriod> | <MandatoryDCInd> |
	And In RSS10060 I continue with the following details:
	| ClsgrpOutputOption   | ComboDescription   |
	| <ClsgrpOutputOption> | <ComboDescription> |  
	And In RSS01040 I continue with the following details:
	| Runits18From   | Runits18TO   | Runits916From   | Runits916TO   | Runits916From2   | Runits916TO2   | UseClassPrice   | PriceMethod   | ClassPriceA  |
	| <Runits18From> | <Runits18TO> | <Runits916From> | <Runits916TO> | <Runits916From2> | <Runits916TO2> | <UseClassPrice> | <PriceMethod> | <ClassPriceA> |
	And In RSS01050 I continue with the following details:
	| HtcFlag   | HT1   | HT2   | HT3   | LocalFlag   | DomcodeFlag   | PCFrom1   | PCTo1   | DC1   | DC2   |
	| <HtcFlag> | <HT1> | <HT2> | <HT3> | <LocalFlag> | <DomcodeFlag> | <PCFrom1> | <PCTo1> | <DC1> | <DC2> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

 Examples: 
   | ReportHeading | ReportDesc             | Preload | ASATRun | ReportDate | InputFile | Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | Clg1 | Clg2 | Clg3 | GroupIDX1 | GroupIDX2 | GroupIDX3 | Reg1 | Reg2 | Reg3 | ClsgrpOutputOption | ComboDescription | Runits18From | Runits18TO  | Runits916From | Runits916TO | Runits916From2 | Runits916TO2 | UseClassPrice | HtcFlag | HT1 | HT2 | HT3 | LocalFlag | PCFrom1 | PCTo1 | DomcodeFlag | DC1 | DC2 | PriceMethod | ClassPriceA | ReportingPeriod | MandatoryDCInd |
   | Itereation1   | Range of Units Summary | N       |         |            | N         | LNN  | DCV  | ENT  | EBR  | OMT  |      |      |      |      |       | 5    |      |      |           |           |           |      |      |      | A                  |                  | 1000         | 99999999999 |               |             |                |              |               | A       |     |     |     | A         |         |       | A           |     |     |             |             |                 |                |
   | Itereation2   | Range of Units Summary | N       | 5186    | 12/08/2015 | N         | DCP  |      |      |      |      |      |      |      |      |       |      |      |      | 0000106841 |           |           |      |      |      | C                  | Combo1           | 100          | 550         | 551           | 99999999999 |                |              | Y             | E       | CNT | DEC |     | I         | 3014    | 3078  | E           |     |     | U           | 13.50       |                 |                |
   | Itereation3   | Range of Units Summary | N       |         |            | N         | DCV  | ENT  |      |      |      |      |      |      |      |       | 1    | 5    |      |            |           |           |      |      |      | C                  | Combo3           | 100          | 550         | 551           | 800         | 801            | 99999999999  |               | I       | COY | ESP | JNT | E         |         |       | I           | GBR |     |             |             |                 |                |
   

@HoldersubscriptionsSummaryReport_Gold
@QBE_AUTO_R
@31882
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Holder_Subscriptions_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "summary reporting" within the Reporting System Menu
	And In RSS01010 I click on: "holder subscriptions summary" within the Summary Reporting Menu
	And In RSS01015 I continue with the following details:
         | Preload | WildString |
         | <Preload>    |            |
    And In RSS01020 I continue with the following details:
	| ReportDesc   | ASATRun   | ReportDate   | InputFile   | 
	| <ReportDesc> | <ASATRun> | <ReportDate> | <InputFile> |
	And In RSS01030 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | Cls5   | Cls6   | Cls7   | Cls8   | Cls9   | Cls10   | Clg1   | Clg2   | Clg3   | GroupIDX1   | GroupIDX2   | GroupIDX3   | ReportingPeriod   | RunFrom   | RunTO   | MandatoryDCInd   |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <Cls5> | <Cls6> | <Cls7> | <Cls8> | <Cls9> | <Cls10> | <Clg1> | <Clg2> | <Clg3> | <GroupIDX1> | <GroupIDX2> | <GroupIDX3> | <ReportingPeriod> | <RunFrom> | <RunTO> | <MandatoryDCInd> |
	And In RSS10060 I continue with the following details:
	| ClsgrpOutputOption   | ComboDescription   |
	| <ClsgrpOutputOption> | <ComboDescription> |  
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples: 
   | ReportHeading | ReportDesc                   | Preload | ASATRun | ReportDate | InputFile | Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | Clg1 | Clg2 | Clg3 | GroupIDX1  | GroupIDX2 | GroupIDX3 | ReportingPeriod | RunFrom | RunTO | ClsgrpOutputOption | ComboDescription | MandatoryDCInd |
   | Itereation1   | Holder Subscriptions Summary | N       |         |            | N         | EBS  | ASA  | DMY  | LTR  |      |      |      |      |      |       |      |      |      |            |           |           | R               | 4500    | 5212  | A                  |                  |                |
   | Itereation3   | Holder Subscriptions Summary | N       |         | 03/03/2014 | N         |      |      |      |      |      |      |      |      |      |       | 5    | 7    |      |            |           |           | Q               |         |       | S                  |                  |                |
   | Itereation4   | Holder Subscriptions Summary | N       | 4800    |            | N         | EBS  | LNN  | E01  |      |      |      |      |      |      |       | 1    | 5    | 7    | 0000106841 |           |           | D               |         |       | C                  | Combination8     |                |
   
@PaymentElectionsSummaryReport_Gold
@QBE_AUTO_R
@31067
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Payment_Elections_Summary_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "summary reporting" within the Reporting System Menu
	And In RSS01010 I click on: "payment elections summary" within the Summary Reporting Menu
	And In RSS01015 I continue with the following details:
         | Preload | WildString |
         | <Preload>    |            |
    And In RSS01020 I continue with the following details:
	| ReportDesc   | ASATRun   | ReportDate   | InputFile   | 
	| <ReportDesc> | <ASATRun> | <ReportDate> | <InputFile> |
	And In RSS01030 I continue with the following details:
	| Cls1   | Cls2   | Cls3   | Cls4   | Cls5   | Cls6   | Cls7   | Cls8   | Cls9   | Cls10   | Clg1   | Clg2   | Clg3   | GroupIDX1   | GroupIDX2   | GroupIDX3   | MandatoryDCInd   | MandDCDom1   | MandDCDom2   | MandDCDom3   | ReportingPeriod   |
	| <Cls1> | <Cls2> | <Cls3> | <Cls4> | <Cls5> | <Cls6> | <Cls7> | <Cls8> | <Cls9> | <Cls10> | <Clg1> | <Clg2> | <Clg3> | <GroupIDX1> | <GroupIDX2> | <GroupIDX3> | <MandatoryDCInd> | <MandDCDom1> | <MandDCDom2> | <MandDCDom3> | <ReportingPeriod> |
	And In RSS10060 I continue with the following details:
	| ClsgrpOutputOption   | ComboDescription   |
	| <ClsgrpOutputOption> | <ComboDescription> |  
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples: 
   | ReportHeading | ReportDesc                | Preload | ASATRun | ReportDate | InputFile | Cls1 | Cls2 | Cls3 | Cls4 | Cls5 | Cls6 | Cls7 | Cls8 | Cls9 | Cls10 | Clg1 | Clg2 | Clg3 | GroupIDX1  | GroupIDX2 | GroupIDX3 | MandatoryDCInd | MandDCDom1 | MandDCDom2 | MandDCDom3 | ClsgrpOutputOption | ComboDescription | ReportingPeriod |
   | Itereation1   | Payment Elections Summary | N       |         |            | N         | CAS  | DM1  | DMZ  | E10  | E20  | EBS  | EC1  | EMS  | ET1  | LTL   |      |      |      |            |           |           | N              |            |            |            | A                  |                  |                 |
   | Itereation3   | Payment Elections Summary | N       |         |            | N         | DSA  | LNN  |      |      |      |      |      |      |      |       | 5    | 1    | 9    | 0000106841 |           |           | Y              | GBR        | USA        |            | C                  | COMBO1           |                 |
   | Itereation4   | Payment Elections Summary | N       | 5145    |            | N         |      |      |      |      |      |      |      |      |      |       | 1    | 5    | 7    | 0000106841 |           |           | Y              | NZL        |            |            | S                  |                  |                 |


@ChequeExtractReport_Gold
@WES_AUTO_R
@36949
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Cheque_Extract_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "cheque extract reporting" within the Reporting System Menu
	And In RSS11000 I continue with the following details:
	| Preload |
	| N       |
	And In RSS11001 I continue with the following details:
	| OutstandingUnpres | UseInputFile | PayAccountNumber1 | PayAccountNumber2 | PayAccountNumber3 | PayAccountNumber4 | PayAccountNumber5 | PayAccountNumber6 | DividendType1 | DividendType2 | PaymentCurr1 |PaymentAmountFrom | PaymentAmountTO | TaxSelectionYN |
	|<OutstandingUnpres>|<UseInputFile>|<PayAccountNumber1>|<PayAccountNumber2>|<PayAccountNumber3>|<PayAccountNumber4>|<PayAccountNumber5>|<PayAccountNumber6>|<DividendType1>|<DividendType2>|<PaymentCurr1>|<PaymentAmountFrom>|<PaymentAmountTO>|<TaxSelectionYN>|
	And In RSS11010 I continue with the following details:
	| ReturnedMail   | PaymentRangeInd   | PaymentStatus1   | PaymentStatus2   | PaymentTransTypes1   | PaymentTransTypes2   | PaymentTransTypes3   | PaymentTransTypes4   | PaymentTransTypes5   | PaymentTransTypes6   | PaymentTransTypes7   | PaymentTransTypes8   | PaymentTransTypes9   | PaymentMethod1   | PaymentMethod2   | PayRefNumberFrom   | PayRefNumberTO   | PresentedDateFrom   | PresentedDateTO   | TaxSelection1   | TaxSelection2   | TaxSelection3   |
	| <ReturnedMail> | <PaymentRangeInd> | <PaymentStatus1> | <PaymentStatus2> | <PaymentTransTypes1> | <PaymentTransTypes2> | <PaymentTransTypes3> | <PaymentTransTypes4> | <PaymentTransTypes5> | <PaymentTransTypes6> | <PaymentTransTypes7> | <PaymentTransTypes8> | <PaymentTransTypes9> | <PaymentMethod1> | <PaymentMethod2> | <PayRefNumberFrom> | <PayRefNumberTO> | <PresentedDateFrom> | <PresentedDateTO> | <TaxSelection1> | <TaxSelection2> | <TaxSelection3> |
	And In RSS11006 I continue with the following details:
	| ExtractHoldersPI   | RptDirectCreditInd   | RptDirectCredit1   | RptDirectCredit2   | RptDirectCredit3   |
	| <ExtractHoldersPI> | <RptDirectCreditInd> | <RptDirectCredit1> | <RptDirectCredit2> | <RptDirectCredit3> |
	And In RSS11002 I click on: "<MenuOption>" within the Cheque Extract Output Menu
	And In RSS11009 I continue with the following details:
	| PrintFlag1   | PrintFlag2   | PrintFlag3   | PrintFlag4   | Sequence   |
	| <PrintFlag2> | <PrintFlag2> | <PrintFlag3> | <PrintFlag4> | <Sequence> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy 

Examples: 
   | ReportHeading | ReportDesc            | Preload | OutstandingUnpres | UseInputFile | PayAccountNumber1 | DividendType1 | DividendType2 | PaymentCurr1 | PaymentAmountFrom | PaymentAmountTO | TaxSelectionYN | ASATRun | ReportDate | InputFile | ReturnedMail | PaymentRangeInd | PaymentStatus1 | PaymentStatus2 | PaymentTransTypes1 | PaymentTransTypes2 | PaymentTransTypes3 | PaymentTransTypes4 | PaymentTransTypes5 | PaymentTransTypes6 | PaymentTransTypes7 | PaymentTransTypes8 | PaymentTransTypes9 | PaymentMethod1 | PaymentMethod2 | PayRefNumberFrom | PayRefNumberTO | PresentedDateFrom | PresentedDateTO | TaxSelection1 | TaxSelection2 | TaxSelection3 | ExtractHoldersPI | RptDirectCreditInd | RptDirectCredit1 | RptDirectCredit2 | RptDirectCredit3 | MenuOption         | PrintFlag1 | PrintFlag2 | PrintFlag3 | PrintFlag4 | Sequence |
   | Itereation1   | Cheque_Extract_Report | N       | N                 | N            |                   |               |               |              |                   |                 | N              |         |            | N         | A            |                 |                |                |                    |                    |                    |                    |                    |                    |                    |                    |                    |                |                |                  |                |                   |                 |               |               |               | Y                | A                  |                  |                  |                  | Full               | Y          | Y          | Y          | Y          | C        |
   | Itereation3   | Cheque_Extract_Report | N       | N                 | N            |                   | D             | C             |              |                   |                 | Y              |         |            | N         | A            |                 |                |                | DCRFA              | DCRFM              | DESCQ              | DFREV              | PAYAD              | PAYMV              | PRREV              | PRSNT              | RCHQR              | C              | D              |                  |                | 01/01/2000        | 31/12/2014      | N             | R             | Z             | Y                | A                  |                  |                  |                  | Summary            | Y          | Y          | Y          | Y          | C        |
   | Itereation4   | Cheque_Extract_Report | N       | N                 | N            |                   |               |               |              |                   |                 | N              | 5145    |            | N         | A            |                 | P              | PE             |                    |                    |                    |                    |                    |                    |                    |                    |                    |                |                | 500000           | 1105688        |                   |                 |               |               |               | Y                | S                  | 10               | 20               | 30               | TotalsOnly         |            |            |            |            | C        |
   | Itereation6   | Cheque_Extract_Report | N       | N                 | N            |                   |               |               | AUD          | 1000.00           | 3000.00         | N              |         |            | N         | L            |                 | C              |                |                    |                    |                    |                    |                    |                    |                    |                    |                    | C              |                |                  |                | 01/01/2002        | 31/12/2005      |               |               |               | Y                | S                  | 10               | 20               | 20               | ResidentTaxListing | Y          | Y          | Y          | Y          | A        |

@PrintControlCodesReport_Gold
@WES_AUTO_R
@34416
@ReportGoldcopyOther
@ReportingGold
Scenario:Print_Control_Report_Goldcopy
### Bug 100089:Reports -Missing closing bracket in Linux (PRN File Header record) ###
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "control reporting" within the Reporting System Menu
	And In RSS13000 I click on: "print control codes" within the Control Reporting Menu
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading | FileName |
		| Filtered      |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy 


@OtherHolderAttributesWithDECustomisedReport_Gold
@WES_AUTO_R
@32005
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Other_Holder_Attributes_With_DE_Customised_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "extract reporting" within the Reporting System Menu
	And In RSS10001 I continue with the following details:
	| Preload   |
	| <Preload> |
	And In RSS10010 I click on: "other holder attributes" within the Extract Reporting Menu
	And In RSS10042 I continue with the following details:
	| ShellHoldersOption   | ShellCntrolOption   |
	| <ShellHoldersOption> | <ShellCntrolOption> |
	And In RSS10010 I click on: "schedule job" within the Extract Reporting Menu
	And In RSS10097 I continue
	And In RSS10022 I click on: "customised data extract" within the Output Format Menu 
	And In RSS10034 I continue with the following details:
	| RegAddress   | HolderCat   | HolderIdentifier   |
	| <RegAddress> | <HolderCat> | <HolderIdentifier> |
	And In RSS10035 I continue with the following details:
	| HolderTypeCode   | HolderOtherTaxCode   | TfnDesc   |
	| <HolderTypeCode> | <HolderOtherTaxCode> | <TfnDesc> |
	And In RSS10039 I continue with the following details:
	| ExtraIdentifier   | HomePhone   | WorkPhone   | FaxNumber   | MobilePhone   | CommMethods   |
	| <ExtraIdentifier> | <HomePhone> | <WorkPhone> | <FaxNumber> | <MobilePhone> | <CommMethods> |
	And In RSS10036 I continue with the following details:
	| BalanceDetails   | ForeignChequeInd   | PayeeDetails   | ResidencyInd   | DirectCredit   | PlanDetails   |
	| <BalanceDetails> | <ForeignChequeInd> | <PayeeDetails> | <ResidencyInd> | <DirectCredit> | <PlanDetails> |
	And In RSS10048 I continue with the following details:
	| DetailRecordOutput   |
	| <DetailRecordOutput> |
	And In RSS10046 I continue with the following details:
	| WebProxyMailing   |
	| <WebProxyMailing> |
	And In RSS10041 I continue with the following details:
	| IncludeDetails   | EmpIDInd   | PayIDInd   | EmployeeUniqueIDInd   | LocCodesInd   | BusUnitsInd   | JobBandsInd   | CostCentreInd   | EmpCommMethodsInd   |
	| <IncludeDetails> | <EmpIDInd> | <PayIDInd> | <EmployeeUniqueIDInd> | <LocCodesInd> | <BusUnitsInd> | <JobBandsInd> | <CostCentreInd> | <EmpCommMethodsInd> |
	And In RSS10037 I continue with the following details:
	| FieldSeparator   |
	| <FieldSeparator> |
	And In RSS10028 I continue with the following details:
	| ReportSeq   |
	| <ReportSeq> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy 

Examples: 
   | ReportHeading | ReportDesc                     | Preload | ShellHoldersOption | ShellCntrolOption | RegAddress | HolderCat | HolderIdentifier | HolderTypeCode | HolderOtherTaxCode | TfnDesc | ExtraIdentifier | HomePhone | WorkPhone | FaxNumber | MobilePhone | CommMethods | BalanceDetails | PlanDetails | DetailRecordOutput | WebProxyMailing | IncludeDetails | EmpIDInd | PayIDInd | EmployeeUniqueIDInd | LocCodesInd | BusUnitsInd | JobBandsInd | CostCentreInd | EmpCommMethodsInd | FieldSeparator | ReportSeq | ForeignChequeInd | PayeeDetails | ResidencyInd | DirectCredit | 
   | Itereation1   | Other_Holder_Attributes_Report | N       |                    |                   | Y          | Y         | Y                | Y              | Y                  | Y       | Y               | Y         | Y         | Y         | Y           | N           | N              |    N         | H                  | N               | Y              | N        | N        | N                   | Y           | Y           | Y           | Y             | Y                 | S              | H         | N                | N            | N            | N            | 
   | Itereation2   | Other_Holder_Attributes_Report | N       | I                  |                   | N          | Y         | Y                | N              | N                  | Y       | Y               | N         | N         | N         | Y           | Y           | N              |     N        | H                  | N               | Y              | Y        | N        | Y                   | Y           | Y           | N           | Y             | Y                 | S              | H         | N                | N            | N            | N            | 
   | Itereation3   | Other_Holder_Attributes_Report | N       | I                  |                   | N          | Y         | Y                | N              | Y                  | Y       | Y               | Y         | N         | N         | Y           | Y           | N              |      N       | H                  | N               | N              |          |          |                     |             |             |             |               |                   | S              | H         | N                | N            | N            | N            | 


@PaymentInstructionWithDECustomisedReport_Gold
@WES_AUTO_R
@32758
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Payment_Instruction_With_DE_Customised_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "extract reporting" within the Reporting System Menu
	And In RSS10001 I continue with the following details:
	| Preload   |
	| <Preload> |  
	And In RSS10010 I click on: "payment instruction" within the Extract Reporting Menu
	And In RSS10029 I continue with the following details:
	| BulkPayInd   | BulkPay   | DirectCreditInd   | DirectCredit   | ForeignChequeInd   | ForeignCurrency1   | ForeignCurrency2   | ThirdPartyInd   | ThirdPartyPCInd   | PCFrom1   | PCTo1   | ThirdPartyDCInd   | DomCodes1   | WireInd   |
	| <BulkPayInd> | <BulkPay> | <DirectCreditInd> | <DirectCredit> | <ForeignChequeInd> | <ForeignCurrency1> | <ForeignCurrency2> | <ThirdPartyInd> | <ThirdPartyPCInd> | <PCFrom1> | <PCTo1> | <ThirdPartyDCInd> | <DomCodes1> | <WireInd> |
	And In RSS10010 I click on: "schedule job" within the Extract Reporting Menu
	And In RSS10097 I continue
	And In RSS10022 I click on: "customised data extract" within the Output Format Menu 
	And In RSS10034 I continue with the following details:
	| RegAddress   | HolderCat   | HolderIdentifier   |
	| <RegAddress> | <HolderCat> | <HolderIdentifier> |
	And In RSS10035 I continue with the following details:
	| HolderTypeCode   | HolderOtherTaxCode   | TfnDesc   |
	| <HolderTypeCode> | <HolderOtherTaxCode> | <TfnDesc> |
	And In RSS10039 I continue with the following details:
	| ExtraIdentifier   | HomePhone   | WorkPhone   | FaxNumber   | MobilePhone   | CommMethods   |
	| <ExtraIdentifier> | <HomePhone> | <WorkPhone> | <FaxNumber> | <MobilePhone> | <CommMethods> |
	And In RSS10036 I continue with the following details:
	| BalanceDetails   | GroupTotals   | ClassTotals   | PlanDetails   | DirectCredit    | BankAccountNbr   | BankAccountName   | BankID   | BankNamadd   | PayeeDetails   | PayeeAddress   | PayeePcodeDomicile   | ForeignChequeInd    | ResidencyInd | Class   | ReportClassORGroup   | ClassGroup   |
	| <BalanceDetails> | <GroupTotals> | <ClassTotals> | <PlanDetails> | <DirectCredits> | <BankAccountNbr> | <BankAccountName> | <BankID> | <BankNamadd> | <PayeeDetails> | <PayeeAddress> | <PayeePcodeDomicile> | <ForeignChequeInds> | N            | <Class> | <ReportClassORGroup> | <ClassGroup> |
	And In RSS10048 I continue with the following details:
	| DetailRecordOutput   |
	| <DetailRecordOutput> |
	And In RSS10046 I continue with the following details:
	| WebProxyMailing   |
	| <WebProxyMailing> |
	And In RSS10041 I continue with the following details:
	| IncludeDetails   | EmpIDInd   | PayIDInd   | EmployeeUniqueIDInd   | LocCodesInd   | BusUnitsInd   | JobBandsInd   | CostCentreInd   | EmpCommMethodsInd   |
	| <IncludeDetails> | <EmpIDInd> | <PayIDInd> | <EmployeeUniqueIDInd> | <LocCodesInd> | <BusUnitsInd> | <JobBandsInd> | <CostCentreInd> | <EmpCommMethodsInd> |
	And In RSS10037 I continue with the following details:
	| FieldSeparator   |
	| <FieldSeparator> |
	And In RSS10028 I continue with the following details:
	| ReportSeq   |
	| <ReportSeq> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples: 
   | ReportHeading | ReportDesc                         | Preload | BulkPayInd | BulkPay | DirectCreditInd | DirectCredit | ForeignChequeInd | ForeignCurrency1 | ForeignCurrency2 | ThirdPartyInd | ThirdPartyPCInd | PCFrom1 | PCTo1 | ThirdPartyDCInd | DomCodes1 | RegAddress | HolderCat | HolderIdentifier | BalanceDetails | WireInd | ExtraIdentifier | HomePhone | WorkPhone | FaxNumber | MobilePhone | CommMethods | GroupTotals | PlanDetails | DirectCredits | BankAccountNbr | BankAccountName | BankID | BankNamadd | PayeeDetails | PayeeAddress | PayeePcodeDomicile | ForeignChequeInds | DetailRecordOutput | WebProxyMailing | IncludeDetails | EmpIDInd | PayIDInd | EmployeeUniqueIDInd | LocCodesInd | BusUnitsInd | JobBandsInd | CostCentreInd | EmpCommMethodsInd | FieldSeparator | ReportSeq | HolderTypeCode | HolderOtherTaxCode | TfnDesc | ClassTotals | Class | ReportClassORGroup | ClassGroup |
   | Itereation1   | Payment_Instruction_Extract_Report | N       | A          |         | A               |              | A                |                  |                  | A             |                 |         |       |                 |           | N          | N         | Y                | Y              |         | N               | N         | N         | N         | N           | N           | N           | N           | Y             | Y              | Y               | Y      | Y          | Y            | Y            | Y                  | Y                 | H                  | N               | Y              | Y        | N        | Y                   | Y           | Y           | N           | Y             | Y                 | S              | H         | Y              | Y                  | Y       | Y           | CLI   |                    |            |
   | Itereation2   | Payment_Instruction_Extract_Report | N       | S          | 99      | S               | 10           | S                | NZD              | USD              | A             | I               | 2000    | 3000  | E               | GBR       | N          | N         | Y                | N              |         | N               | N         | N         | N         | N           | N           | N           | N           | N             | N              | N               | N      | N          | Y            | Y            | Y                  | Y                 | H                  | N               | Y              | Y        | N        | Y                   | Y           | Y           | N           | Y             | Y                 | S              | H         | Y              | Y                  | Y       |             |       |                    |            |
   | Itereation3   | Payment_Instruction_Extract_Report | N       | A          |         | S               | 10           | S                | NZD              | USD              | A             | E               | 3100    | 3500  | I               | NZL       | N          | N         | Y                | Y              |         | N               | N         | N         | N         | N           | N           | Y           | N           | Y             | N              | Y               | N      | N          | N            | N            | N                  | N                 | H                  | N               | Y              | Y        | N        | Y                   | Y           | Y           | N           | Y             | Y                 | S              | H         | Y              | Y                  | Y       | N           |       | G                  | 1          |


@TaxSelectionWithDECustomisedReport_Gold
@WES_AUTO_R
@35325
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Tax_selection_With_DE_Customised_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "extract reporting" within the Reporting System Menu
	And In RSS10001 I continue with the following details:
	| Preload   |
	| <Preload> |  
	And In RSS10010 I click on: "tax selection" within the Extract Reporting Menu
	And In RSS10032 I continue with the following details:
	| TaxCodeFlag   | NzlIrds   | NzlExempt   | TfnFlag   | TfnQuotedFlag   | ExemptCode   | TfnNotQuotedFlag   | JointIncompleteInd   | TinType1   | TinType2   | TinType3   | TinStatusNbr   | TinExpiryDateFrom   | TinExpiryDateTO   | TinCertifiedInd   |
	| <TaxCodeFlag> | <NzlIrds> | <NzlExempt> | <TfnFlag> | <TfnQuotedFlag> | <ExemptCode> | <TfnNotQuotedFlag> | <JointIncompleteInd> | <TinType1> | <TinType2> | <TinType3> | <TinStatusNbr> | <TinExpiryDateFrom> | <TinExpiryDateTO> | <TinCertifiedInd> |
	And In RSS10043 I continue with the following details:
	| IRLCustodianRefOpt   | IRLCustodianRef   | IRLIntermediary   | IRLInternalStatusOpt   | IRLInternalStatus   | CountryResidenceOpt   | CountryResidence   | EntityTypeOpt   | EntityType   | IRLTaxReference   | IRLDateOFBirth   | CertFileRef   | CertDwtRef   | DwtExpiryOpt   | DwtExpiryDate   | IRLCertificationStatus   |
	| <IRLCustodianRefOpt> | <IRLCustodianRef> | <IRLIntermediary> | <IRLInternalStatusOpt> | <IRLInternalStatus> | <CountryResidenceOpt> | <CountryResidence> | <EntityTypeOpt> | <EntityType> | <IRLTaxReference> | <IRLDateOFBirth> | <CertFileRef> | <CertDwtRef> | <DwtExpiryOpt> | <DwtExpiryDate> | <IRLCertificationStatus> |
	And In RSS10044 I continue with the following details:
	| ZAFCustodianRefOpt   | ZAFCustodianRef   | ZAFIntermediary   | ZAFInternalStatusOpt   | ZAFInternalStatus   | TaxDomicileOpt   | TaxDomicile1   | TaxDomicile2   | TaxDomicile3   | NaturePersonOpt   | NaturePerson1   | ZAFTaxReference   | IDNO   | ZAFDateOFBirth   | ExemptionCodeOpt   | ExemptionCode   | PassportCtryIssOpt   | PassportCtryIss   | ZAFCertificationStatus   |
	| <ZAFCustodianRefOpt> | <ZAFCustodianRef> | <ZAFIntermediary> | <ZAFInternalStatusOpt> | <ZAFInternalStatus> | <TaxDomicileOpt> | <TaxDomicile1> | <TaxDomicile2> | <TaxDomicile3> | <NaturePersonOpt> | <NaturePerson1> | <ZAFTaxReference> | <IDNO> | <ZAFDateOFBirth> | <ExemptionCodeOpt> | <ExemptionCode> | <PassportCtryIssOpt> | <PassportCtryIss> | <ZAFCertificationStatus> |
	And In RSS10010 I click on: "schedule job" within the Extract Reporting Menu
	And In RSS10097 I continue
	And In RSS10022 I click on: "customised data extract" within the Output Format Menu 
	And In RSS10034 I continue with the following details:
	| RegAddress   | HolderCat   | HolderIdentifier   |
	| <RegAddress> | <HolderCat> | <HolderIdentifier> |
	And In RSS10035 I continue with the following details:
	| HolderTypeCode   | HolderOtherTaxCode   | TfnDesc   |
	| <HolderTypeCode> | <HolderOtherTaxCode> | <TfnDesc> |
	And In RSS10039 I continue with the following details:
	| ExtraIdentifier   | HomePhone   | WorkPhone   | FaxNumber   | MobilePhone   | CommMethods   |
	| <ExtraIdentifier> | <HomePhone> | <WorkPhone> | <FaxNumber> | <MobilePhone> | <CommMethods> |
	And In RSS10036 I continue with the following details:
	| BalanceDetails   | GroupTotals   | ClassTotals   | PlanDetails   | DirectCredit    | BankAccountNbr   | BankAccountName   | BankID   | BankNamadd   | PayeeDetails   | PayeeAddress   | PayeePcodeDomicile   | ForeignChequeInd    | ResidencyInd | Class   | ReportClassORGroup   | ClassGroup   |
	| <BalanceDetails> | <GroupTotals> | <ClassTotals> | <PlanDetails> | <DirectCredits> | <BankAccountNbr> | <BankAccountName> | <BankID> | <BankNamadd> | <PayeeDetails> | <PayeeAddress> | <PayeePcodeDomicile> | <ForeignChequeInds> | N            | <Class> | <ReportClassORGroup> | <ClassGroup> |
	And In RSS10048 I continue with the following details:
	| DetailRecordOutput   |
	| <DetailRecordOutput> |
	And In RSS10046 I continue with the following details:
	| WebProxyMailing   |
	| <WebProxyMailing> |
	And In RSS10041 I continue with the following details:
	| IncludeDetails   | EmpIDInd   | PayIDInd   | EmployeeUniqueIDInd   | LocCodesInd   | BusUnitsInd   | JobBandsInd   | CostCentreInd   | EmpCommMethodsInd   |
	| <IncludeDetails> | <EmpIDInd> | <PayIDInd> | <EmployeeUniqueIDInd> | <LocCodesInd> | <BusUnitsInd> | <JobBandsInd> | <CostCentreInd> | <EmpCommMethodsInd> |
	And In RSS10037 I continue with the following details:
	| FieldSeparator   |
	| <FieldSeparator> |
	And In RSS10028 I continue with the following details:
	| ReportSeq   |
	| <ReportSeq> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples:
	 | ReportHeading | ReportDesc                   | Preload | TaxCodeFlag | NzlIrds | NzlExempt | TfnFlag | TfnQuotedFlag | ExemptCode | TfnNotQuotedFlag | JointIncompleteInd | TinType1 | TinType2 | TinType3 | TinStatusNbr | TinExpiryDateFrom | TinExpiryDateTO | TinCertifiedInd | IRLCustodianRefOpt | IRLCustodianRef | IRLIntermediary | IRLInternalStatusOpt | IRLInternalStatus | CountryResidenceOpt | CountryResidence1 | CountryResidence2 | CountryResidence3 | EntityTypeOpt | EntityType | IRLTaxReference | IRLDateOFBirth | CertFileRef | CertDwtRef | DwtExpiryOpt | DwtExpiryDate | IRLCertificationStatus | ZAFCustodianRefOpt | ZAFCustodianRef | ZAFIntermediary | ZAFInternalStatusOpt | ZAFInternalStatus | TaxDomicileOpt | TaxDomicile1 | TaxDomicile2 | TaxDomicile3 | NaturePersonOpt | NaturePerson1 | NaturePerson2 | NaturePerson3 | ZAFTaxReference | IDNO | ZAFDateOFBirth | ExemptionCodeOpt | ExemptionCode | PassportCtryIssOpt | PassportCtryIss | ZAFCertificationStatus | RegAddress | HolderCat | HolderIdentifier | HolderTypeCode | HolderOtherTaxCode | TfnDesc | ExtraIdentifier | HomePhone | WorkPhone | FaxNumber | MobilePhone | CommMethods | BalanceDetails | GroupTotals | ClassTotals | PlanDetails | DirectCredit | BankAccountNbr | BankAccountName | BankID | BankNamadd | PayeeDetails | PayeeAddress | PayeePcodeDomicile | ForeignChequeInd | ResidencyInd | Class | ReportClassORGroup | ClassGroup | DetailRecordOutput | WebProxyMailing | IncludeDetails | EmpIDInd | PayIDInd | EmployeeUniqueIDInd | LocCodesInd | BusUnitsInd | JobBandsInd | CostCentreInd | EmpCommMethodsInd | FieldSeparator | ReportSeq |
	 | Itereation1   | Tax_Selection_Extract_Report | N       |             | N       | N         | Q       | A             |            |                  | I                  |          |          |          |              |                   |                 |                 |                    |                 |                 |                      |                   |                     |                   |                   |                   |               |            |                 |                |             |            |              |               |                        |                    |                 |                 |                      |                   |                |              |              |              |                 |               |               |               |                 |      |                |                  |               |                    |                 |                        | N          | N         | Y                | Y              | N                  | N       | N               | N         | N         | N         | N           | N           | N              | Y           | Y           | N           | Y            | Y              | Y               | Y      | Y          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | N                 | G              | H         |
	 | Itereation2   | Tax_Selection_Extract_Report | N       |             | N       | N         |         |               |            |                  |                    | E        | Q        | S        |              |                   |                 |                 |                    |                 |                 |                      |                   |                     |                   |                   |                   |               |            |                 |                |             |            |              |               |                        |                    |                 |                 |                      |                   |                |              |              |              |                 |               |               |               |                 |      |                |                  |               |                    |                 |                        | N          | N         | Y                | N              | N                  | N       | N               | N         | N         | N         | N           | N           | N              | N           | N           | N           | N            | N              | Y               | Y      | Y          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | N                   | Y           | Y           | Y           | N             | N                 | G              | H         |
	 | Itereation3   | Tax_Selection_Extract_Report | N       |             | N       | N         |         |               |            |                  |                    |          |          |          |              |                   |                 |                 |                    |                 |                 |                      |                   | S                   | IRL               | AUS               |                   | S             | IND        | N               |                |             |            |              |               |                        |                    |                 |                 |                      |                   |                |              |              |              |                 |               |               |               |                 |      |                |                  |               |                    |                 |                        | N          | N         | Y                | Y              | N                  | N       | N               | N         | N         | N         | N           | Y           | N              | Y           | N           | N           | N            | N              | N               | N      | N          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | N             | N                 | G              | H         |
	 | Itereation4   | Tax_Selection_Extract_Report | N       |             | N       | N         |         |               |            |                  |                    |          |          |          |              |                   |                 |                 | B                  |                 | N               | A                    |                   | A                   |                   |                   |                   |               |            | Q               |                |             |            |              |               | CRT                    |                    |                 |                 |                      |                   |                |              |              |              |                 |               |               |               |                 |      |                |                  |               |                    |                 |                        | N          | N         | Y                | Y              | N                  | N       | N               | N         | N         | N         | N           | Y           | N              | Y           | N           | N           | N            | N              | N               | N      | N          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | N             | N                 | G              | H         |
	 | Itereation5   | Tax_Selection_Extract_Report | N       |             | N       | N         |         |               |            |                  |                    |          |          |          |              |                   |                 |                 |                    |                 |                 |                      |                   |                     |                   |                   |                   |               |            |                 |                |             |            |              |               |                        |                    |                 |                 |                      |                   | S              | AGF          | ZAF          | AUS          | A               |               |               |               | Q               |      |                |                  |               |                    |                 |                        | N          | N         | Y                | Y              | N                  | N       | N               | N         | N         | N         | N           | Y           | N              | Y           | N           | N           | N            | N              | N               | N      | N          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | N                   | Y           | Y           | Y           | N             | N                 | G              | H         |
	 | Itereation6   | Tax_Selection_Extract_Report | N       |             | N       | N         |         |               |            |                  |                    |          |          |          |              |                   |                 |                 |                    |                 |                 |                      |                   |                     |                   |                   |                   |               |            |                 |                |             |            |              |               |                        | B                  |                 |                 | B                    |                   | S              | ZAF          |              |              | S               | T             | I             | B             |                 |      |                | B                |               |                    |                 | CRT                    | N          | N         | Y                | Y              | N                  | N       | N               | N         | N         | N         | N           | Y           | N              | Y           | N           | N           | N            | N              | N               | N      | N          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | N             | N                 | G              | H         |
	 | Itereation7   | Tax_Selection_Extract_Report | N       | A           | Y       | N         | Q       | A             | I          |                  | I                  |          |          |          |              |                   |                 |                 |                    |                 |                 |                      |                   |                     |                   |                   |                   |               |            |                 |                |             |            |              |               |                        |                    |                 |                 |                      |                   |                |              |              |              |                 |               |               |               |                 |      |                |                  |               |                    |                 |                        | N          | N         | Y                | Y              | N                  | N       | N               | N         | N         | N         | N           | Y           | N              | Y           | N           | N           | N            | N              | N               | N      | N          | N            | H            | N                  | Y                | Y            | N     | Y                  | Y          | H                  | N               | Y              | Y        | Y        | N                   | Y           | Y           | Y           | N             | N                 | G              | H         |

@TaxSelectionLabelsReport_Gold
@WES_AUTO_R
@33779
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Tax_selection_LB_Labels_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "extract reporting" within the Reporting System Menu
	And In RSS10001 I continue with the following details:
	| Preload   |
	| <Preload> | 
	And In RSS10010 I click on: "schedule job" within the Extract Reporting Menu
	And In RSS10097 I continue
	And In RSS10022 I click on: "labels" within the Output Format Menu 
	And In RSS10023 I continue with the following details:
	| PrintAsx   |
	| <PrintAsx> |
	And In RSS10028 I continue with the following details:
	| ReportSeq   |
	| <ReportSeq> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples:
	 | ReportHeading | ReportDesc                             | Preload | PrintAsx | ReportSeq |
	 | Itereation1   | Tax_Selection_With_LB_Labels_Report    | N       | N        | H         |
	 | Itereation2   | Tax_Selection_Without_LB_Labels_Report | N       | Y        | H         |


@ElectronicCommunicationWithCustomisedExtractReport_Gold
@WES_AUTO_R
@334777
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Electronic_Communication_Customised_Extract_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "WES_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "extract reporting" within the Reporting System Menu
	And In RSS10001 I continue with the following details:
	| Preload   |
	| <Preload> | 
	And In RSS10010 I click on: "electronic communication" within the Extract Reporting Menu
	And In RSS10050 I continue with the following details:
	| IndFlag   | Email   | RtnDateInd   | RtnDateFrom   | RtnDateTO   | PubSelection1   | 1Methods1   | 2Methods1   | 3Methods1   | PubSelection2   | 1Methods2   | 2Methods2   | 3Methods2   | PubSelection3   | 1Methods3   | 2Methods3   | 3Methods3   | PubSelection7   | 1Methods7   | 2Methods7   | 3Methods7   | PubSelection8   | 1Methods8   | 2Methods8   | 3Methods8   | PubSelection9   | 1Methods9   | 2Methods9   | 3Methods9   |
	| <IndFlag> | <Email> | <RtnDateInd> | <RtnDateFrom> | <RtnDateTO> | <PubSelection1> | <1Methods1> | <2Methods1> | <3Methods1> | <PubSelection2> | <1Methods2> | <2Methods2> | <3Methods2> | <PubSelection3> | <1Methods3> | <2Methods3> | <3Methods3> | <PubSelection7> | <1Methods7> | <2Methods7> | <3Methods7> | <PubSelection8> | <1Methods8> | <2Methods8> | <3Methods8> | <PubSelection9> | <1Methods9> | <2Methods9> | <3Methods9> |
	And In RSS10010 I click on: "schedule job" within the Extract Reporting Menu
	And In RSS10097 I continue
	And In RSS10022 I click on: "customised data extract" within the Output Format Menu
	And In RSS10034 I continue with the following details:
	| RegAddress   | HolderCat   | HolderIdentifier   |
	| <RegAddress> | <HolderCat> | <HolderIdentifier> |
	And In RSS10035 I continue with the following details:
	| HolderTypeCode   | HolderOtherTaxCode   | TfnDesc   |
	| <HolderTypeCode> | <HolderOtherTaxCode> | <TfnDesc> |
	And In RSS10039 I continue with the following details:
	| ExtraIdentifier   | HomePhone   | WorkPhone   | FaxNumber   | MobilePhone   | CommMethods   |
	| <ExtraIdentifier> | <HomePhone> | <WorkPhone> | <FaxNumber> | <MobilePhone> | <CommMethods> |
	And In RSS10036 I continue with the following details:
	| BalanceDetails   | PlanDetails   | DirectCredit   | ResidencyInd   | PayeeDetails   | ForeignChequeInd   |
	| <BalanceDetails> | <PlanDetails> | <DirectCredit> | <ResidencyInd> | <PayeeDetails> | <ForeignChequeInd> |
	And In RSS10048 I continue with the following details:
	| DetailRecordOutput   |
	| <DetailRecordOutput> |
	And In RSS10046 I continue with the following details:
	| WebProxyMailing   |
	| <WebProxyMailing> |
	And In RSS10041 I continue with the following details:
	| IncludeDetails   | EmpIDInd   | PayIDInd   | EmployeeUniqueIDInd   | LocCodesInd   | BusUnitsInd   | JobBandsInd   | CostCentreInd   | EmpCommMethodsInd   |
	| <IncludeDetails> | <EmpIDInd> | <PayIDInd> | <EmployeeUniqueIDInd> | <LocCodesInd> | <BusUnitsInd> | <JobBandsInd> | <CostCentreInd> | <EmpCommMethodsInd> |
	And In RSS10037 I continue with the following details:
	| FieldSeparator   |
	| <FieldSeparator> |
	And In RSS10028 I continue with the following details:
	| ReportSeq   |
	| <ReportSeq> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 600    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples:
	 | ReportHeading | ReportDesc                                         | Preload | IndFlag | Email | RtnDateInd | RtnDateFrom | RtnDateTO | PubSelection1 | 1Methods1 | 2Methods1 | 3Methods1 | PubSelection3 | 1Methods3 | 2Methods3 | 3Methods3 | PubSelection2 | 1Methods2 | 2Methods2 | 3Methods2 | PubSelection7 | 1Methods7 | 2Methods7 | 3Methods7 | PubSelection8 | 1Methods8 | 2Methods8 | 3Methods8 | PubSelection9 | 1Methods9 | 2Methods9 | 3Methods9 | RegAddress | HolderCat | HolderIdentifier | HolderTypeCode | HolderOtherTaxCode | TfnDesc | ExtraIdentifier | HomePhone | WorkPhone | FaxNumber | MobilePhone | CommMethods | BalanceDetails | DetailRecordOutput | WebProxyMailing | IncludeDetails | EmpIDInd | PayIDInd | EmployeeUniqueIDInd | LocCodesInd | BusUnitsInd | JobBandsInd | CostCentreInd | EmpCommMethodsInd | FieldSeparator | ReportSeq | PlanDetails | DirectCredit | ResidencyInd | PayeeDetails | ForeignChequeInd |
	 | Itereation1   | Electronic_Communication_Customised_Extract_Report | N       | A       | A     | A          |             |           | A             |           |           |           | A             |           |           |           | A             |           |           |           | A             |           |           |           | A             |           |           |           | A             |           |           |           | Y          | Y         | Y                | Y              | Y                  | N       | Y               | Y         | Y         | Y         | Y           | Y           | N              | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | Y                 |                | P         | N           | N            | N            | N            | N                |
	 | Itereation2   | Electronic_Communication_Customised_Extract_Report | N       | O       | A     | B          |             |           | B             |           |           |           | B             |           |           |           | A             |           |           |           | A             |           |           |           | B             |           |           |           | B             |           |           |           | N          | Y         | Y                | Y              | Y                  | Y       | Y               | Y         | Y         | Y         | N           | Y           | N              | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | Y                 |                | D         | N           | N            | N            | N            | N                |
	 | Itereation3   | Electronic_Communication_Customised_Extract_Report | N       | O       | B     | A          |             |           | S             | E         | M         |           | S             | F         | O         |           | A             |           |           |           | A             |           |           |           | S             | T         |           |           | S             | A         |           |           | Y          | Y         | Y                | Y              | Y                  | N       | Y               | Y         | Y         | Y         | Y           | Y           | N              | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | Y                 |                | H         | N           | N            | N            | N            | N                |
	 | Itereation4   | Electronic_Communication_Customised_Extract_Report | N       | O       | A     | S          | 1/04/2015   | 25/9/2015 | E             | T         | P         |           | E             | T         |           |           | A             |           |           |           | A             |           |           |           | E             | T         |           |           | E             | T         |           |           | Y          | Y         | Y                | Y              | Y                  | Y       | Y               | Y         | Y         | Y         | Y           | Y           | N              | H                  | N               | Y              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | Y                 |                | H         | N           | N            | N            | N            | N                |
	 | Itereation5   | Electronic_Communication_Customised_Extract_Report | N       | A       | B     | A          |             |           | S             | E         | T         | P         | A             |           |           |           | A             |           |           |           | A             |           |           |           | A             |           |           |           | A             |           |           |           | N          | Y         | Y                | Y              | Y                  | N       | Y               | Y         | Y         | Y         | Y           | Y           | N              | H                  | N               | N              |          |          |                     |             |             |             |               |                   |                | P         | N           | N            | N            | N            | N                |
	 

@NameAndAddressWithCustomisedExtractReport_Gold
@QBE_AUTO_R
@29480
@ReportGoldcopyOther
@ReportingGold
Scenario Outline:Name_And_Address_Customised_Extract_Report_Goldcopy
	Given I have connected to WinForms
	And In SELCOY01 I select the company: "QBE_AUTO_R"
	And In MNS00101 I click on: "reporting system" within the System Menu
	And In RSS00101 I click on: "extract reporting" within the Reporting System Menu
	And In RSS10001 I continue with the following details:
	| Preload   |
	| <Preload> | 
	And In RSS10010 I click on: "name address" within the Extract Reporting Menu
	And In RSS10016 I continue with the following details:
	| StaticSelOnly   | NASearchPattern1   | NASearchRegexpInd1   | NASearchLocation1   | NASearchPattern2   | NASearchRegexpInd2   | NASearchLocation2   | NASearchPattern3   | NASearchRegexpInd3   | NASearchLocation3   | NASearchConnector   | PostcodeFlag   | PCFrom1   | PCTo1   | PCFrom2   | PCTo2   | PCFrom3   | PCTo3   | PCFrom4   | PCTo4   | DomcodeFlag   | DomCodes1   | DomCodes2   | DomCodes3   | BrokerNum   | NameKeyAlphaFrom   | NameKeyAlphaTO   | Dpid   | ResidencyInd   |
	| <StaticSelOnly> | <NASearchPattern1> | <NASearchRegexpInd1> | <NASearchLocation1> | <NASearchPattern2> | <NASearchRegexpInd2> | <NASearchLocation2> | <NASearchPattern3> | <NASearchRegexpInd3> | <NASearchLocation3> | <NASearchConnector> | <PostcodeFlag> | <PCFrom1> | <PCTo1> | <PCFrom2> | <PCTo2> | <PCFrom3> | <PCTo3> | <PCFrom4> | <PCTo4> | <DomcodeFlag> | <DomCodes1> | <DomCodes2> | <DomCodes3> | <BrokerNum> | <NameKeyAlphaFrom> | <NameKeyAlphaTO> | <Dpid> | <ResidencyInd> |
	And In RSS10010 I click on: "schedule job" within the Extract Reporting Menu
	And In RSS10097 I continue
	And In RSS10022 I click on: "customised data extract" within the Output Format Menu
	And In RSS10034 I continue with the following details:
	| RegAddress   | HolderCat   | HolderIdentifier   |
	| <RegAddress> | <HolderCat> | <HolderIdentifier> |
	And In RSS10035 I continue with the following details:
	| HolderTypeCode   | HolderOtherTaxCode   | TfnDesc   |
	| <HolderTypeCode> | <HolderOtherTaxCode> | <TfnDesc> |
	And In RSS10039 I continue with the following details:
	| ExtraIdentifier   | HomePhone   | WorkPhone   | FaxNumber   | MobilePhone   | CommMethods   |
	| <ExtraIdentifier> | <HomePhone> | <WorkPhone> | <FaxNumber> | <MobilePhone> | <CommMethods> |
	And In RSS10036 I continue with the following details:
	| BalanceDetails   | PlanDetails   | DirectCredit   | ResidencyInd   | PayeeDetails   | ForeignChequeInd   |
	| <BalanceDetails> | <PlanDetails> | <DirectCredit> | <ResidencyInd> | <PayeeDetails> | <ForeignChequeInd> |
	And In RSS10048 I continue with the following details:
	| DetailRecordOutput   |
	| <DetailRecordOutput> |
	And In RSS10046 I continue with the following details:
	| WebProxyMailing   |
	| <WebProxyMailing> |
	And In RSS10041 I continue with the following details:
	| IncludeDetails   | EmpIDInd   | PayIDInd   | EmployeeUniqueIDInd   | LocCodesInd   | BusUnitsInd   | JobBandsInd   | CostCentreInd   | EmpCommMethodsInd   |
	| <IncludeDetails> | <EmpIDInd> | <PayIDInd> | <EmployeeUniqueIDInd> | <LocCodesInd> | <BusUnitsInd> | <JobBandsInd> | <CostCentreInd> | <EmpCommMethodsInd> |
	And In RSS10037 I continue with the following details:
	| FieldSeparator   |
	| <FieldSeparator> |
	And In RSS10028 I continue with the following details:
	| ReportSeq   |
	| <ReportSeq> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300    | error         |
		Then I copy output files to local
		| ReportHeading   | FileName |
		| <ReportHeading> |          |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples:
	 | ReportHeading | ReportDesc                                 | Preload | StaticSelOnly | NASearchPattern1 | NASearchRegexpInd1 | NASearchLocation1 | NASearchPattern2 | NASearchRegexpInd2 | NASearchLocation2 | NASearchPattern3 | NASearchRegexpInd3 | NASearchLocation3 | NASearchConnector | PostcodeFlag | PCFrom1 | PCTo1 | PCFrom2 | PCTo2 | PCFrom3 | PCTo3 | PCFrom4 | PCTo4 | DomcodeFlag | DomCodes1 | DomCodes2 | DomCodes3 | BrokerNum | NameKeyAlphaFrom | NameKeyAlphaTO | Dpid | RegAddress | HolderCat | HolderIdentifier | HolderTypeCode | HolderOtherTaxCode | TfnDesc | ExtraIdentifier | HomePhone | WorkPhone | FaxNumber | MobilePhone | CommMethods | BalanceDetails | DetailRecordOutput | WebProxyMailing | IncludeDetails | EmpIDInd | PayIDInd | EmployeeUniqueIDInd | LocCodesInd | BusUnitsInd | JobBandsInd | CostCentreInd | EmpCommMethodsInd | FieldSeparator | ReportSeq | PlanDetails | DirectCredit | ResidencyInd | PayeeDetails | ForeignChequeInd |
	 | Itereation1   | Name_And_Address_Customised_Extract_Report | N       | Y             |                  |                    |                   |                  |                    |                   |                  |                    |                   |                   |              |         |       |         |       |         |       |         |       |             |           |           |           |           |                  |                |      | Y          | Y         | Y                | Y              | Y                  | N       | Y               | Y         | Y         | Y         | Y           | Y           | N              | H                  | N               | N              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | Y                 |                | P         | N           | N            | N            | N            | N                |
	 | Itereation2   | Name_And_Address_Customised_Extract_Report | N       | N             | Ewfupid          | R                  | F                 | Rimceqil         | R                  | F                 | Cify             | R                  | F                 | A                 | I            | 5000    | 5001  |         |       |         |       |         |       | I           | AUS       | GBR       | USA       | 62571     | P                | S              | A    | N          | Y         | Y                | Y              | Y                  | Y       | Y               | Y         | Y         | Y         | N           | Y           | N              | H                  | N               | N              | Y        | Y        | Y                   | Y           | Y           | Y           | Y             | Y                 |                | D         | N           | N            | N            | N            | N                |
