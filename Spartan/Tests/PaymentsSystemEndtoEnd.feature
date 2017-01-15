Feature: PaymentsSystemEndtoEnd
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@ignore
#@PaymentsSystem_EndtoEnd
#Scenario Outline: DividendRegresionTest
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		And I go to Define Payment Account menu
#		And In PAS01001 I change the payment account details as:
#		| ReinitiateSearch                                                                                                       | PaymentDate |
#		| REGI,REGND,REGEA,REGEM,REGEO,REGNZ,NZRED,NZEA1,NZEM1,NZEO1,REGGB,GBRED,GBEA1,GBEM1,GBEO1,REGUS,USRED,USEA1,USEM1,USEO1 |             |
#
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
#		And In DIVX1001 I setup the Dividend Control Update as:
#		| More   | Preload   | InputDivCode   |
#		| <More> | <Preload> | <InputDivCode> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option1> |
#		And In DIVX1010 I setup the Dividend parameters as:
#		| PaymentDate | AutomatedJobRelease |
#		|             | Y                   |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option2> |
#		And In DIVX1022 I setup the Dividend parameters as:
#		| PaymentDate |
#		|             |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option3> |
#	When I Exit from System Setup Menu
#		And I continue with the following details for Divdends in nhk_menu:
#		| COY   | VMSpassCriteria1         | VMSfailCriteria1 | VMSpassCriteria2      | VMSpassCriteria3 | VMSpassCriteria4 | failCriteria1 | LinuxpassCriteria1    | LinuxpassCriteria2      | LinuxpassCriteria3       | LinuxpassCriteria4 | InputDivCode   |
#		| <COY> | Top Level Utilities MENU |                  | OPS Housekeeping MENU | Dividend         | DIVIDEND SETUP   |               | NHK - SCRIP Utilities | OPSM - Ops Housekeeping | SSTP - Sub System Setups | DIVIDEND SETUP     | <InputDivCode> |
#		And I release Dividends jobs:
#		| COY   | failCriteria1 | VMSpassCriteria1 | DividendName | VMSpassCriteria2 | VMSJobName1              | VMSpassCriteria3                | VMSpassCriteria | VMSJobName2               | VMSpassCriteria4                 | VMSJobName3                  | VMSpassCriteria5                    | VMSJobName4                      | VMSpassCriteria6                        | VMSJobName5                  | VMSpassCriteria7                    | VMSJobName6                  | VMSpassCriteria8                    | VMSJobName7                 | VMSpassCriteria9                   | VMSJobName8               | VMSpassCriteria10                | VMSJobName9                   | VMSpassCriteria11                    | VMSJobName10                | VMSpassCriteria12                  | VMSJobName11                  | VMSpassCriteria13                    | VMSJobName12                | VMSpassCriteria14                  | VMSJobName13                   | VMSpassCriteria15                     | VMSJobName14                    | VMSpassCriteria16                      | timeout   | PassCriteria   | FailCriteria   | LinuxPassCriteria | PassCriteriaLinux | FailCriteriaLinux | LinuxJobName13                |
#		| <COY> |               | sad_a            | divregn      | divregn          | DIV_SPLIT_REGN_SAD_A.COM | /NOTIFYDIV_SPLIT_REGN_SAD_A.COM | started         | DIV_CALC_REGN_D_SAD_A.COM | /NOTIFYDIV_CALC_REGN_D_SAD_A.COM | DIV_CHEQUES_REGN_D_SAD_A.COM | /NOTIFYDIV_CHEQUES_REGN_D_SAD_A.COM | DIV_CHEQUES_REGN_D_USD_SAD_A.COM | /NOTIFYDIV_CHEQUES_REGN_D_USD_SAD_A.COM | DIV_ADVICES_REGN_D_SAD_A.COM | /NOTIFYDIV_ADVICES_REGN_D_SAD_A.COM | DIV_DCREDIT_REGN_D_SAD_A.COM | /NOTIFYDIV_DCREDIT_REGN_D_SAD_A.COM | DIV_NILMNY_REGN_D_SAD_A.COM | /NOTIFYDIV_NILMNY_REGN_D_SAD_A.COM | DIV_RECN_REGN_D_SAD_A.COM | /NOTIFYDIV_RECN_REGN_D_SAD_A.COM | DIV_RECN_REGN_D_USD_SAD_A.COM | /NOTIFYDIV_RECN_REGN_D_USD_SAD_A.COM | DIV_DIVLST_REGN_D_SAD_A.COM | /NOTIFYDIV_DIVLST_REGN_D_SAD_A.COM | DIV_END_CALC_REGN_D_SAD_A.COM | /NOTIFYDIV_END_CALC_REGN_D_SAD_A.COM | DIV_DIVBLD_REGN_D_SAD_A.COM | /NOTIFYDIV_DIVBLD_REGN_D_SAD_A.COM | DIV_PAY_COMBINE_REGN_SAD_A.COM | /NOTIFYDIV_PAY_COMBINE_REGN_SAD_A.COM | DIV_DIVHIS_BUILD_REGN_SAD_A.COM | /NOTIFYDIV_DIVHIS_BUILD_REGN_SAD_A.COM | <timeout> | <PassCriteria> | <FailCriteria> | queue default     | DONE              | EXIT              | div_pay_combine_regn_sad_a.sh |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "sad_a"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   | Action   |
#		| <NightlyRunInd> | <Action> |
#	When I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |
#		And I Submit Post URR Job
#		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
#		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#		Then I copy URR files to local
#		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
#		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
#		And I parse the files from VMS or Linux
#		And I compare the files from VMS and Linux goldcopy
#
#	Examples: 
#	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | NightlyRunInd | timeout  | PassCriteria | FailCriteria | PostURRJob | Action  | OtherFile1 | OtherFile2 | fileLocationVMS1 | OnlyCorporateActionFiles |
#	| Test1         |      | Y       | REGN         | IN      | D       | EX      | sad_a | Y             | 1200     | completion   | error        |            | CONFIRM | Y          | N          | [.divregn]       | Y                        |


@PaymentsSystem_EndtoEnd
@PaymentsSystem_EndtoEnd1
Scenario Outline: DividendRegresionTest1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch                                                                                                       | PaymentDate |
		| REGI,REGND,REGEA,REGEM,REGEO,REGNZ,NZRED,NZEA1,NZEM1,NZEO1,REGGB,GBRED,GBEA1,GBEM1,GBEO1,REGUS,USRED,USEA1,USEM1,USEO1 |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####		
	And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | CostSharesKnownInd | COY   | InputDivCode   |
		| <Selection> | Y                  | <COY> | <InputDivCode> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDivCode   |
		| <Selection1> | <COY> | <InputDivCode> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | CostShares   | InputDivCode   | COY   |
		| <Selection3> | <CostShares> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Exit from System Setup Menu
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		And I release the Divhis Build and Pay Combine job as:                                                 
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild |   
		| <COY> | <InputDivCode> | <timeout>  | <PassCriteria> | <FailCriteria> | N          | Y           |   
	Given I have connected to WinForms                                                                       
	When In SELCOY01 I select the company: "SAD_A"                                                           
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout  | FailCriteria | Selection2 | CostShares | NightlyRunInd | Selection3 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection |fileLocationVLnx1 | OtherFileLnx1 |
	| Test1         |      | Y       | regn         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200     | error        | ALLT       | 0.500000   | Y             | BULD       | CONFIRM | Y          | [.divregn]       | N          | Y                        | APPS      |divregn           | Y             |
	

@PaymentsSystem_EndtoEnd2
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest2
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch                                                                                                      | PaymentDate |
		| REGD,REGDD,REDEA,REDEM,REDEO,REDNZ,NZRD,NZEA2,NZEM2,NZEO2,REDGB,GBRD2,GBEA2,GBEM2,GBEO2,REDUS,USRD2,USEA2,USEM2,USEO2 |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####		
	And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | CostSharesKnownInd |COY   | InputDivCode   |
		| <Selection> | Y                  |<COY> | <InputDivCode> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDivCode   |
		| <Selection1> | <COY> | <InputDivCode> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
		And In SPS00102 I click on: "payment job release monitor" within the system Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | CostShares   |COY   | InputDivCode   |
		| <Selection2> | <CostShares> |<COY> | <InputDivCode> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | CostShares   | InputDivCode   | COY   |
		| <Selection3> | <CostShares> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Exit from System Setup Menu
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		And I release the Divhis Build and Pay Combine job as:                                                 
		| COY   | InputDivCode   | timeout   | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild | PassCriteriaLinux | FailCriteriaLinux |
		| <COY> | <InputDivCode> | <timeout> | <PassCriteria> | <FailCriteria> | Y          | Y           |                   |                   |
	Given I have connected to WinForms                                                                       
	When In SELCOY01 I select the company: "SAD_A"                                                           
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | Selection2 | CostShares | NightlyRunInd | Selection3 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | seconds |
	| Test2         |      | Y       | regd         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | ALLT       | 0.500000   | Y             | buld       | CONFIRM | Y          | [.divregd]       | N          | Y                        | APPS      | 30      |

@PaymentsSystem_EndtoEnd3
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest3
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| CP001            |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   |InputDivCode   | COY   |
		| <Selection> |<InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu							
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Exit from System Setup Menu
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild |
		| <COY> | <InputDivCode> | <timeout>  | <PassCriteria> | <FailCriteria> | N          | Y           |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy

	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | seconds |
	| Test3         |      | Y       | pdcp         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divpdcp]       | N          | Y                        | APPS      | 30      |

@PaymentsSystem_EndtoEnd4
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest4
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| INTR1            |             |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Exit from System Setup Menu
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild |
		| <COY> | <InputDivCode> | <timeout>  | <PassCriteria> | <FailCriteria> | N          | Y           |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy
	
	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | seconds |
	| Test4         |      | Y       | pdin         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divpdin]       | N          | Y                        | APPS      | 30      |

@PaymentsSystem_EndtoEnd5
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest5
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| LOAN2            |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Exit from System Setup Menu
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild |
		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | Y          | Y           |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 | seconds |
	| Test5         |      | Y       | lon1         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divlon1]       | N          | Y                        | APPS      | 1600     | 30      |

#@ignore
#@PaymentsSystem_EndtoEnd6
#@PaymentsSystem_EndtoEnd
#Scenario Outline: DividendRegresionTest6
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		And I go to Define Payment Account menu
#		And In PAS01001 I change the payment account details as:
#		| ReinitiateSearch        | PaymentDate |
#		| REC01,DEPN1,EXAT1,FP001 |             |
#
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		#### Dividend Setup #####
#		And I go to Dividend Control Update Menu
#		And In DIVX1001 I setup the Dividend Control Update as:
#		| More   | Preload   | InputDivCode   |
#		| <More> | <Preload> | <InputDivCode> |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option1> |
#		And In DIVX1010 I setup the Dividend parameters as:
#		| PaymentDate | AutomatedJobRelease |
#		|             | Y                   |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option2> |
#		And In DIVX1022 I setup the Dividend parameters as:
#		| PaymentDate |
#		|             |
#		And In DIVX1020 I setup the Dividend Control Update as:
#		| Option    |
#		| <Option3> |
#	When I Go to the Mainmenu from System Setup Menu
#		#### Payment Automated job release -Releasing the payment jobs #####	
#		And I go to Payment Automated job release Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection   |
#		| <Selection> |	
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |		
#	When I Go to the Mainmenu from System Setup Menu
#		And I go to Payment Automated job release Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection    |
#		| <Selection1> |	
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |
#	When I Go to the Mainmenu from System Setup Menu
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   | Action   |
#		| <NightlyRunInd> | <Action> |
#	When I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |
#		And I Submit Post URR Job
#		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
#		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		And I go to Payment Automated job release Menu
#		And In DIS05010 I Enter Payment Automated Job Release details as:
#		| InputDividendCode |
#		| <InputDivCode>    |
#		And In DIS05030 I Enter Payment Automated Job Release details as:
#		| Selection    | COY   | InputDividendCode |
#		| <Selection2> | <COY> | <InputDivCode>    |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |
#	When I Exit from System Setup Menu
#		And I release the Divhis Build and Pay Combine job as:
#		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild |
#		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | Y          | Y           |
#		And I Submit Post URR Job
#		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
#		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   | Action   |
#		| <NightlyRunInd> | <Action> |
#	When I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |
#		And I Submit Post URR Job
#		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
#		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#		Then I copy URR files to local
#		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
#		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
#		And I parse the files from VMS or Linux
#		And I compare the files from VMS and Linux goldcopy
#
#
#	Examples: 
#	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 |
#	| Test6         |      | Y       | sucy         | IN      | D       | EX      | sad_a | CALC       | completion   | 800     | error        | Y             | BULD       | CONFIRM | Y          | [.divsucy]       | N          | Y                        | APPS      | 1600     |

#
#@ignore
#Scenario Outline: DeleteExisitngDIV
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SAD_A"
#		And In MNS00101 I click on: "system parameter setups" within the System Menu
#		And In SPS00101 I click on: "dividend payment parameters" within the system Menu
#		And In SPS00102 I click on: "dividend payment parameters" within the system Menu
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode1> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode2> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode3> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode4> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode5> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode6> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode7> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode8> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode    |
#		| D       | <InputDivCode9> |
#		And In DIVX1001 I delete the Dividend as:
#		| Preload | InputDivCode     |
#		| D       | <InputDivCode10> |
#
#	Examples:
#	| Test  | InputDivCode1 | InputDivCode2 | InputDivCode3 | InputDivCode4 | InputDivCode5 | InputDivCode6 | InputDivCode7 | InputDivCode8 | InputDivCode9 | InputDivCode10 |
#	| Test1 | FNDA          | FOXS          | FUND          | GPAH          | I101          | INT1          | INT2          | INTS          | IOFD          | JHI1           |
#	| Test2 | L75D          | LLCD          | LOAN          | MCN1          | MCN2          | MITY          | OSHT          | PLN6          | PREF          | S101           |
#	| Test3 | S102          | S103          | S104          | S105          | S106          | S107          | S108          | S109          | S110          | S131           |
#	| Test4 | S132          | S133          | S134          | S135          | S136          | S137          | S138          | S139          | S140          | S201           |
#	| Test5 | S202          | S301          | S302          | SAD1          | SAD2          | SAD3          | SHLD          | SPLT          | SUCY          | TFN1           |
#	| Test6 | USTX          | VICM          | WPL1          |               |               |               |               |               |               |                |
#

@PaymentsSystem_EndtoEnd7
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest7
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| CAPT1            |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	When I Exit from System Setup Menu
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild | PayCombine |
		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | N          | Y           | N          |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 | seconds | fileLocationVLnx1 | OtherFileLnx1 |
	| Test7         |      | Y       | capt         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divcapt]       | N          | Y                        | APPS      | 1600     | 30      | divcapt           | Y             |



@PaymentsSystem_EndtoEnd8
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest8
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| PDDS1            |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	When I Exit from System Setup Menu
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild | PayCombine |
		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | N          | Y           | N          |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 | seconds | fileLocationVLnx1 | OtherFileLnx1 |
	| Test8         |      | Y       | pdds         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divpdds]       | N          | Y                        | APPS      | 1600     | 30      | divpdds           | Y             |


@PaymentsSystem_EndtoEnd9
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest9
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| PDFX1            |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	When I Exit from System Setup Menu
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild | PayCombine |
		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | N          | Y           | N          |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 | seconds | fileLocationVLnx1 | OtherFileLnx1 |
	| Test9         |      | Y       | pdfx         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divpdfx]       | N          | Y                        | APPS      | 1600     | 30      | divpdfx           | Y             |



@PaymentsSystem_EndtoEnd10
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest10
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch | PaymentDate |
		| INTR1            |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	When I Exit from System Setup Menu
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild | PayCombine |
		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | N          | Y           | N          |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 | seconds | fileLocationVLnx1 | OtherFileLnx1 |
	| Test10        |      | Y       | pdin         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divpdin]       | N          | Y                        | APPS      | 1600     | 30      | divpdin           | Y             |


@PaymentsSystem_EndtoEnd11
@PaymentsSystem_EndtoEnd
Scenario Outline: DividendRegresionTest11
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Define Payment Account menu
		And In PAS01001 I change the payment account details as:
		| ReinitiateSearch  | PaymentDate |
		| MIT01,MIT02,MIT03 |             |

	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		#### Dividend Setup #####
		And I go to Dividend Control Update Menu
		And In DIVX1001 I setup the Dividend Control Update as:
		| More   | Preload   | InputDivCode   |
		| <More> | <Preload> | <InputDivCode> |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option1> |
		And In DIVX1010 I setup the Dividend parameters as:
		| PaymentDate | AutomatedJobRelease |
		|             | Y                   |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option2> |
		And In DIVX1022 I setup the Dividend parameters as:
		| PaymentDate |
		|             |
		And In DIVX1020 I setup the Dividend Control Update as:
		| Option    |
		| <Option3> |
	When I Go to the Mainmenu from System Setup Menu
		#### Payment Automated job release -Releasing the payment jobs #####	
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection   | InputDivCode   | COY   |
		| <Selection> | <InputDivCode> | <COY> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |		
	When I Go to the Mainmenu from System Setup Menu
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    |InputDivCode   | COY   |
		| <Selection1> |<InputDivCode> | <COY> |	
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
	When I Go to the Mainmenu from System Setup Menu
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		#After all the jobs completed there is a delay in Linux. VMS  works ok.
		And wait 
		| seconds |
		|<seconds>|
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And I go to Payment Automated job release Menu
		And In DIS05010 I Enter Payment Automated Job Release details as:
		| InputDividendCode |
		| <InputDivCode>    |
		And In DIS05030 I Enter Payment Automated Job Release details as:
		| Selection    | COY   | InputDividendCode |
		| <Selection2> | <COY> | <InputDivCode>    |
		And I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	When I Exit from System Setup Menu
		And I release the Divhis Build and Pay Combine job as:
		| COY   | InputDivCode   | timeout    | PassCriteria   | FailCriteria   | PlnCombine | DivHisBuild | PayCombine |
		| <COY> | <InputDivCode> | <timeout1> | <PassCriteria> | <FailCriteria> | N          | Y           | N          |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "SAD_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


	Examples: 
	| ReportHeading | More | Preload | InputDivCode | Option1 | Option2 | Option3 | COY   | Selection1 | PassCriteria | timeout | FailCriteria | NightlyRunInd | Selection2 | Action  | OtherFile1 | fileLocationVMS1 | OtherFile2 | OnlyCorporateActionFiles | Selection | timeout1 | seconds | fileLocationVLnx1 | OtherFileLnx1 |
	| Test11        |      | Y       | dis1         | IN      | D       | EX      | sad_a | CALC       | completion   | 1200    | error        | Y             | BULD       | CONFIRM | Y          | [.divdis1]       | N          | Y                        | APPS      | 1600     | 30      | divdis1           | Y             |

