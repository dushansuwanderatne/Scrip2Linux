Feature: UpdateReportRun

#@WES_URR
#@URRGold
#Scenario Outline:URR_WES
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_URR"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   |
#		| <NightlyRunInd> |
#	When I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria   | timeout   | FailCriteria   |
#		| <PassCriteria> | <timeout> | <FailCriteria> |
#		And I Submit Post URR Job
#		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
#		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
#		Then I copy output files to local
#		| ReportHeading   | FileName |
#		| <ReportHeading> |          |
#		And I parse the files from VMS or Linux
#		And I compare the files from VMS and Linux goldcopy
#		
#Examples: 
#	| ReportHeading | NightlyRunInd | COY     | timeout | PassCriteria | FailCriteria |
#	| Test1         | Y             | WES_URR | 3600    | completion   | error        |


#@URRGold
#Scenario Outline:DEMO_URR
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "CPU_URR"
#		And In MNS00101 I click on: "reporting system" within the System Menu
#		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
#		And In RSS25010 I Enter URR Parameter as:
#		| NightlyRunInd   |
#		| <NightlyRunInd> |
#		And I start Capture Rollback process 
#		| COY   |
#		| <COY> |
#	When I continue to the report submit page
#		And In JOBSUB90 I submit the report for VMS and Linux
#		| PassCriteria | timeout | FailCriteria |
#		| completion   | 3600    | error        |
#		And I stop Capture Rollback process 
#		| COY   |
#		| <COY> |
#		Then I copy output files to local
#		| ReportHeading   | FileName |
#		| <ReportHeading> |          |
#		#Then I copy output files to local
#		#| ReportHeading   | FileName         |
#		#| <ReportHeading> | ROLLBACK_EXTRACT |
#		And I parse the files from VMS or Linux
#		And I compare the files from VMS and Linux goldcopy
#
#
#Examples: 
#	| ReportHeading | NightlyRunInd | COY     |
#	| Test1         | Y             | CPU_URR |

@URRNightly
@CPU_URR
Scenario Outline:CPU_URR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_URR"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
		And I start Capture Rollback process 
		| COY   |
		| <COY> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		And I stop Capture Rollback process 
		| COY   |
		| <COY> |		
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


Examples: 
	| ReportHeading | NightlyRunInd | COY     | OtherFile1 | fileLocationVMS1 | OtherFile2 | fileLocationVMS2 | fileLocationVLnx1 | OtherFileLnx1 | fileLocationVLnx2 | OtherFileLnx2 | PassCriteria | timeout | FailCriteria | OnlyCorporateActionFiles |
	| Test1         | Y             | CPU_URR | Y          | [.prn_aus]       | Y          | [.prn_nzl]       | prn_aus           | Y             | prn_nzl           | Y             | completion   | 3600    | error        | N                        |


@URRNightly
@URRGold
@WES_URR
Scenario Outline:URR_WES_Full
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_URR"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
		And I start Capture Rollback process 
		| COY   |
		| <COY> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
		And I stop Capture Rollback process 
		| COY   |
		| <COY> |	
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy
		
Examples: 
	| ReportHeading | NightlyRunInd | COY     | timeout | PassCriteria | FailCriteria | OnlyCorporateActionFiles |
	| Test1         | Y             | WES_URR | 3600    | completion   | error        | N                        |




#### chnage cosmos download to Y ###
#Scenario Outline:ScripCntrol
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "SCRIP-CNTROL"
#	And In CFS00001 I continue as:
#	| MenuItem | SearchUfdsel                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
#	| SCC      | AFI,AGG,AIO,AMP,ANZ_GB,ARIU,AZJ_GB,BHP,BPT,CPU,CRM_TST,CSL,DMC_TST,DUE,FBUU_GB,FITQ,FLT_GB,FMS,FMS_TKO,GMG_GB,GSB,GSI,IAG_GB,IFMU,IHD,IML_TS1,IML_TS2,IML_TS3,IML_TS4,IVV,JHX,MACW,MGCU,MLAU,OGC,OSH,QBE_GB1,RMD,S32,SCRIP_AFG,SCRIP_BANK,SCRIP_CONTROL,SCRIP_GCM,SCRIP_MASTER,SCRIP_RECON,TCL,VCCQ_BAL,WBCW,WES_GB,WFD,WOR_GB,AELU_PAY,AMM,ANZ_PAY,ANZ_UCM,APE_PAY,BHP_PAY,BTD_STL1,BTD_STL2,BTD_STL3,BTD_STL4,BUX_PAY,CIX,CKF,COF_TKO,COH_PAY,CPU_PAY,CVW_PAY,FLT_PAY,HBS_PAY,IAG,IAG_PAY,IAG_TKO,NAB,NAB_PAY,PAN,PRO,PRY_PAY,QBE_PAY,RHL,ROC_TKO,TOX,WES_PAY,WFD_PAY,WIG_PAY,WOR_PAY,XYZ,XYZ_TKO, |
#
#Examples: 
#	| Test  |
#	| Test1 |

@FullSmokeTest
@SmokeTestFullURR
Scenario Outline:RunURR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |



Examples: 
	| ReportHeading | NightlyRunInd | COY   | PassCriteria | timeout | FailCriteria |
	| Test1         | Y             | DIV_A | completion   | 3600    | error        |



