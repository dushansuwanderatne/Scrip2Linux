Feature: Allotment
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@winformsTest
Scenario Outline: Allotment_Test1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And In MNS00101 I click on: "system parameter setups" within the System Menu
		And In SPS00101 I click on: "allotment system parameters" within the system Menu
		And In ALS01001 I continue with the following details:
		| AllotmentNum   |
		| <AllotmentNum> |
		And In ALS01010 I continue with the following details:
		| RepDate   | PrintHolderID   | BCRunNumber   | XtrFilname   | AllotmentType   | ProcessType   | ReturnMail   |
		| <RepDate> | <PrintHolderID> | <BCRunNumber> | <XtrFilname> | <AllotmentType> | <ProcessType> | <ReturnMail> |
		And In ALS01020 I continue with the following details:
		| Selcls1   | Selcls2   | Selreg01   | Selreg02   | DeductSelcls   | ScripReq   | FirstAltClass   | SecondAltClass   | TranTypeCode   | CertInd   | AllotmentRegister   | NspRequiredInd   | EomSelectionCode   |
		| <Selcls1> | <Selcls2> | <Selreg01> | <Selreg02> | <DeductSelcls> | <ScripReq> | <FirstAltClass> | <SecondAltClass> | <TranTypeCode> | <CertInd> | <AllotmentRegister> | <NspRequiredInd> | <EomSelectionCode> |
		And In ALS01025 I continue with the following details:
		| ScripSeq   | ScripComment40A   | ScripComment40B   |
		| <ScripSeq> | <ScripComment40A> | <ScripComment40B> |
		And In ALS01028 I continue with the following details:
		| CNAllotmentDate   | BuildDeferDate   |
		| <CNAllotmentDate> | <BuildDeferDate> |
		And In ALS01030 I continue with the following details:
		| OrderNumber   | OpsInitials   | Description   |
		| <OrderNumber> | <OpsInitials> | <Description> |
		And In BILCTL99 I continue with the following details:
		| ServiceProvider   | ServiceCode   |
		| <ServiceProvider> | <ServiceCode> |
	Then In ALS01040 I verify the following details:
	| FirstAltClass   | FirstAltClassDesc   |
	| <FirstAltClass> | <FirstAltClassDesc> |
	When I Exit from System Setup Menu
	When I continue with the following details for Allotments in nhk_menu:
	| COY   | passCriteria1                     | failCriteria1 | passCriteria2         | passCriteria3                  | passCriteria4   | passCriteria5 | passCriteriaLnx1      | passCriteriaLnx2        | passCriteriaLnx3         | 
	| <COY> | SCRIP (Dec System) Utilities Menu |               | OPS Housekeeping MENU | OPS Setup special process MENU | ALLOTMENT SETUP |               | NHK - SCRIP Utilities | OPSM - Ops Housekeeping | SSTP - Sub System Setups |
	When I release Allotment jobs:
	| JobName1               | COY      | passCriteria1 | failCriteria1 | passCriteria2 | passCriteria3                 | AllotmentName | passCriteria4 | PassCriteria | timeout | FailCriteria | JobName2                       | JobName3                  | passCriteria6                         | passCriteria7                    | JobNameLnx1           | passCriteriaJobLnx1 | PassCriteriaLinux | FailCriteriaLinux | JobNameLnx2                   | JobNameLnx3              |
	| ALT1_CALC_QBE_AUTO.COM | qbe_auto | qbe_auto      |               | qbe_auto.alt1 | /NOTIFYALT1_CALC_QBE_AUTO.COM | alt1          | started       | completion   | 300     | error        | ALT1_CHESS_NOTICE_QBE_AUTO.COM | ALT1_COMBINE_QBE_AUTO.COM | /NOTIFYALT1_CHESS_NOTICE_QBE_AUTO.COM | /NOTIFYALT1_COMBINE_QBE_AUTO.COM | alt1_calc_qbe_auto.sh | queue default       | DONE              | EXIT              | alt1_chess_notice_qbe_auto.sh | alt1_combine_qbe_auto.sh |
	#Given I copy output files to local
	#| ReportHeading   | FileName | fileLocationVMS | COY   | CurrentCOY |
	#| <ReportHeading> | alt1     | [.alt1]         | <COY> | <COY>      |
	#When I parse the files from VMS or Linux
	#	And I compare the files from VMS and Linux goldcopy		
	##### Run URR ######
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action   |
		| <NightlyRunInd> | <Action> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 3600    | error        |

Examples: 
	| ReportHeading | AllotmentNum | RepDate    | PrintHolderID | BCRunNumber | XtrFilname | AllotmentType | ProcessType | ReturnMail | Selcls1 | Selcls2 | Selreg01 | Selreg02 | DeductSelcls | ScripReq | FirstAltClass | SecondAltClass | TranTypeCode | CertInd | AllotmentRegister | NspRequiredInd | EomSelectionCode | ScripSeq | ScripComment40A | ScripComment40B | CNAllotmentDate | BuildDeferDate | OrderNumber | OpsInitials | Description    | ServiceProvider | ServiceCode | FirstAltClassDesc          | NightlyRunInd | Action  | COY      |
	| Test1         | 1            | 16/06/2016 | Y             | 9999        |            | T             | O           | Y          | EC1     |         | NSW      |          | N            | Y        | ENT           |                |              | 0       | LR                |                | I                | A        |                 |                 |                 |                | 5555        | NDF         | Allotment List | CTS             | ******      | QBE ENTITLEMENT MARCH 2012 | Y             | CONFIRM | QBE_AUTO |


