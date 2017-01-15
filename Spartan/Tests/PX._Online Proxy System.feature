Feature: PX_Online Proxy system
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@winformsTest
@Proxy_System
Scenario Outline: Test Case Proxy End to End -TO SAV
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And In PXS00106 I enter Proxy Details as "<MeetingNumber>" "<Action>"
		And In PXS00107 I enter proxy Details as "<MeetingHeading>" "<MeetingDate>"
		And In PXS00101 I enter proxy details:
		| Selection   |
		| <Selection> |
		#PCU
		And In PXS00201 I enter Proxy System Control Setup details:
		| ATMeetingFlag   | Chairman   | NbrRes   | SchemeMeetingInd   | InternetMeeting   | AlgorithmNumber   | RemResOpenVotes   | ClassVotesInd   | SameClasses   | DirectVotingInd   | ProcessingCutoff   | ManualProcessCutOff   | NomNotPresent   |
		| <ATMeetingFlag> | <Chairman> | <NbrRes> | <SchemeMeetingInd> | <InternetMeeting> | <AlgorithmNumber> | <RemResOpenVotes> | <ClassVotesInd> | <SameClasses> | <DirectVotingInd> | <ProcessingCutoff> | <ManualProcessCutOff> | <NomNotPresent> |
		And In PXS00202 I enter Proxy System Control Setup details:
		| SpecialCondInd   | MinBalanceYN  | RunUpto   | MaxVotesYN   | MaxVotes   | GroupApply   | SpecialCalcInd   | AllCalc   | CorpRepNotingNum   | PreEncodedNotInp |
		| <SpecialCondInd> |<MinBalanceYN> | <RunUpto> | <MaxVotesYN> | <MaxVotes> | <GroupApply> | <SpecialCalcInd> | <AllCalc> | <CorpRepNotingNum> | <PreEncodedNotInp> |
		And In PXS00203 I enter Proxy System Control Setup details:
		| IntermediaryOnlineProcessing   | ImoOverVoteProcessingCutOff   | ImoCosmosCompanyMeetingID   | ActivateAutoScheduledJobs   | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport |
		| <IntermediaryOnlineProcessing> | <ImoOverVoteProcessingCutOff> | <ImoCosmosCompanyMeetingID> | <ActivateAutoScheduledJobs> | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport |
		And In PXS00211 I enter Proxy System Control Setup details:
		| BriefDesc   | LongDesc   | VotingFrmDesc   | ClassCode   | ClassGroup   | ExcClass   | OtherReqdInd   | ClassCodeB1   | ClassCodeB2   | ClassCodeB3   | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | ExcClassCodesInd   | ExcClassCode   | RemResTickBox   | NomOveRes   | UnitsUpdMethod  |
		| <BriefDesc> | <LongDesc> | <VotingFrmDesc> | <ClassCode> | <ClassGroup> | <ExcClass> | <OtherReqdInd> | <ClassCodeB1> | <ClassCodeB2> | <ClassCodeB3> | ExcClassB1 | ExcClassB2 | ExcClassB3 |<Rounding>| <ExcClassCodesInd> | <ExcClassCode> | <RemResTickBox> | <NomOveRes> | <UnitsUpdMethod>| 
		And In PXS00211 I enter Proxy System Control Setup details:
		| BriefDesc    | LongDesc    | VotingFrmDesc    | ClassCode    | ClassGroup		| ExcClass	 | OtherReqdInd   | ClassCodeB1   | ClassCodeB2   | ClassCodeB3   | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | ExcClassCodesInd   | ExcClassCode   | RemResTickBox   | NomOveRes   | UnitsUpdMethod  |
		| <BriefDesc2> | <LongDesc2> | <VotingFrmDesc2> | <ClassCode2> | <ClassGroup>	| <ExcClass> | <OtherReqdInd2> | <ClassCodeB1> | <ClassCodeB2> | <ClassCodeB3> | ExcClassB1 | ExcClassB2 | ExcClassB3 |<Rounding>| <ExcClassCodesInd> | <ExcClassCode> | <RemResTickBox> | <NomOveRes2> | <UnitsUpdMethod2>| 
		And I Transmit
		And I Transmit
		#MNP
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection1> |
		And In NOMSCH01 I continue with the following details:
		| Action1st   | Code   | Name   | Status   | Type   | Current   |
		| <Action1st> | <Code> | <Name> | <Status> | <Type> | <Current> |
		And In NOMSCH01 I continue with the following details:
		| Action1st    | Code    | Name    | Status    | Type    | Current    |
		| <Action1st1> | <Code1> | <Name1> | <Status1> | <Type1> | <Current1> |
		And I PressESC
		#PET
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection2> |
		And In PXS02001 I continue with the following details:
		| RefNum   | ProxyType   | Holder   | SPFlag   | Noma   | Nomb   | FailingA   | PerA   | R01   | R02   | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm |
		| <RefNum> | <ProxyType> | <Holder> | <SPFlag> | <Noma> | <Nomb> | <FailingA> | <PerA> | <R01> | <R02> |<For01> | <For02> | <Against01> | <Against02> | <OpenTicked01> | <OpenTicked02> | <Abstain01> | <Abstain02> | <Exclude01> | <Exclude02> | <ClassEntitlement> | <ResDesc1> | <ResDesc2> | <ClassEntitlement1> | <ClassEntitlement2> | <TotalEntered1> | <TotalEntered2> | <Difference1> | <Difference2> | <Description1> | <Description2> | <Confirm> |
		And In PXS02001 I continue with the following details:
		| RefNum    | ProxyType    | Holder    | SPFlag    | Noma    | Nomb    | FailingA    | PerA    | R01    | R02    | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm |
		| <RefNumU> | <ProxyTypeU> | <HolderU> | <SPFlagU> | <NomaU> | <NombU> | <FailingAU> | <PerAU> | <R01U> | <R02U> |<For01U> | <For02U> | <Against01U> | <Against02U> | <OpenTicked01U> | <OpenTicked02U> | <Abstain01U> | <Abstain02U> | <Exclude01U> | <Exclude02U> | <ClassEntitlementU> | <ResDesc1U> | <ResDesc2U> | <ClassEntitlement1U> | <ClassEntitlement2U> | <TotalEntered1U> | <TotalEntered2U> | <Difference1U> | <Difference2U> | <Description1U> | <Description2U> | <ConfirmU> |
		And I PressESC		
		#PHV
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection3> |
		And In PXS04001 I verify the Proxy Holder Vote Details as:
		| Action    | HolderSearchKey   | NomPersonA   | NomPersonB   | PercentA   | ResolutionLine1   | ResolutionLine2   |
		| <Action1> | <HolderSearchKey> | <NomPersonA> | <NomPersonB> | <PercentA> | <ResolutionLine1> | <ResolutionLine2> |
		And In PXS04001 I verify the Proxy Holder Vote Details as:
		| Action    | HolderSearchKey    | NomPersonA    | NomPersonB    | PercentA    | ResolutionLine1    | ResolutionLine2    |
		| <Action1> | <HolderSearchKey2> | <NomPersonA2> | <NomPersonB2> | <PercentA2> | <ResolutionLine12> | <ResolutionLine22> |
		And I PressESC
		#PAL
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection4> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the Proxy report
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 360     | error        | DONE            | EXIT            |
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And In PXS00106 I Go to Proxy Meeting:
		 | Selection    | MeetingNumber   | Action    |
		 | <Selection5> | <MeetingNumber> | <Action2> |
		#SAV
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection6> |
		And In PXS00109 I continue with the following:
		| Confirm1    | FinalConfirm   |
		| <Confirm1> | <FinalConfirm> |
		And I continue to the report submit page
		And In JOBSUB90 I submit the Proxy report
			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
			| completion   | 360     | error        | DONE            | EXIT            |

	Examples: 
	| Test  | COY      | MeetingNumber | Action | MeetingHeading                  | MeetingDate | Selection | ATMeetingFlag | Chairman | NbrRes | SchemeMeetingInd | InternetMeeting | AlgorithmNumber | RemResOpenVotes | ClassVotesInd | SameClasses | DirectVotingInd | ProcessingCutoff | ManualProcessCutOff | NomNotPresent | SpecialCondInd | MinBalanceYN | RunUpto | MaxVotesYN | MaxVotes | GroupApply | SpecialCalcInd | AllCalc | CorpRepNotingNum | PreEncodedNotInp | IntermediaryOnlineProcessing | ImoOverVoteProcessingCutOff | ImoCosmosCompanyMeetingID | ActivateAutoScheduledJobs | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport | BriefDesc | BriefDesc2 | LongDesc | LongDesc2 | VotingFrmDesc       | VotingFrmDesc2      | ClassCode | ClassCode2 | ClassGroup | ClassGroup2 | ExcClass | ExcClass2 | OtherReqdInd | OtherReqdInd2 | ClassCodeB1 | ClassCodeB2 | ClassCodeB3 | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | Rounding2 | ExcClassCodesInd | ExcClassCodesInd2 | ExcClassCode | ExcClassCode2 | RemResTickBox | RemResTickBox2 | NomOveRes | NomOveRes2 | UnitsIssuedOS | UnitsIssuedOS2 | UnitsUpdMethod | UnitsUpdMethod2 | Selection1 | Action1st | Code | Name     | Status | Type | Current | Action1st1 | Code1 | Name1    | Status1 | Type1 | Current1 | Selection2 | RefNum | ProxyType | Holder      | SPFlag | Noma | Nomb | FailingA | PerA | R01 | R02 | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm | RefNumU | ProxyTypeU | HolderU     | SPFlagU | NomaU | NombU | FailingAU | PerAU | R01U | R02U | For01U | For02U | Against01U | Against02U | OpenTicked01U | OpenTicked02U | Abstain01U | Abstain02U | Exclude01U | Exclude02U | ClassEntitlementU | ResDesc1U | ResDesc2U | ClassEntitlement1U | ClassEntitlement2U | TotalEntered1U | TotalEntered2U | Difference1U | Difference2U | Description1U | Description2U | ConfirmU | Selection3 | Action1 | HolderSearchKey | NomPersonA | NomPersonB | PercentA | ResolutionLine1                                                                | ResolutionLine2                                                                | HolderSearchKey2 | NomPersonA2 | NomPersonB2 | PercentA2 | ResolutionLine12                                                     | ResolutionLine22                                                     | Selection4 | Selection5 | Action2 | Confirm1 | FinalConfirm | Selection6 |
	| Test1 | CPU_AUTO | 2             | A      | TEST AUTOMATION-TO SAV          | 01/08/2015  | PIN       | N             | CHM      | 2      | N                | N               |                 | N               | Y             | N           | N               | N                | N                   | A             | N              |              |         |            |          |            | N              |         |                  | N                | N                            |                             |                           | N                         |                         |                       |               |             |                     |                     |                     |                         |                         |                         |                        |                        |                        |                  | R1        | R2         | RES1     | RES2      | Resolution Number 1 | Resolution Number 2 | FP        | FP         |            |             |          |           | N            | N             |             |             |             |            |            |            |          |           |                  |                   |              |               |               |                | N         | N          |               |                | A              |                 | mnp        | A         | DS1  | TEST DS1 | N      | B    | Y       | A          | DS2   | TEST DS2 | N       | N     | Y        | pet        | 20     | FAB       | X0044132095 | P      | CHM  | DS2  |          | 50   | F   | F   |       |       |           |           |              |              |           |           |           |           |                  |          |          |                   |                   |               |               |             |             |              |              |         | 21      | UNFA       | X0055123268 |         | CHM   |       |           |       |      |      | 200    | 200    | 200        | 200        | 200           | 200           | 200        | 200        | 200        | 200        | 3500              | R1        | R2        | 3500               | 3500               | 1000           | 1000           | 2500         | 2500         | LESS          | LESS          | C        | PHV        | S       | X0044132095     | CHM        | DS2        | 50       | R1          F           60           60                                 120.00 | R2          F           60           60                                 120.00 | X0055123268      | CHM         |             |           | R1 .         200          200          200          200          200 | R2 .         200          200          200          200          200 | PAL        | PX         | P       | Y        | SURE         | SAV        |

@winformsTest
@Proxy_System
Scenario Outline: Test Case Proxy End to End -SAV TO PST
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And In PXS00106 I Go to Proxy Meeting:
		 | Selection    | MeetingNumber   | Action    |
		 | <Selection5> | <MeetingNumber> | <Action2> |
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection7> |
		#At meeting to Y
		And In PXS00201 I Change At Meeting details:
		| ATMeetingFlag1   |
		| <ATMeetingFlag1> |	
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection8> |
		#AET -SET
		And In PXS01500 I Add Attendee list details:
		| Selection    | AttendeeNum   | HolderName   | AttendeeName   | AttendeeNumber   |
		| <Selection9> | <AttendeeNum> | <HolderName> | <AttendeeName> | <AttendeeNumber> |
		#AET -NET(SRN)
		And In PXS01500 I Add Attendee list details:
		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
		| <Selection10> | <AttendeeNum1> | <HolderName1> | <AttendeeName1> | <AttendeeNumber1> |
		#AET -NET(NAME)
		And In PXS01500 I Add Attendee list details:
		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
		| <Selection11> | <AttendeeNum2> | <HolderName2> | <AttendeeName2> | <AttendeeNumber2> |
		#AET -VET
		And In PXS01500 I Add Attendee list details:
		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
		| <Selection12> | <AttendeeNum3> | <HolderName3> | <AttendeeName3> | <AttendeeNumber3> |
		#AET -VET(CHM)	
		And In PXS01500 I Add Attendee list details:
		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
		| <Selection14> | <AttendeeNum4> | <HolderName4> | <AttendeeName4> | <AttendeeNumber4> |
		And I PressESC
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection13> |
		#PAT
		And In PXS04501 I verify Proxy Attendee details:
		| Action    | HolderSearchKey    | HolderSearchHin   | SearchNomCode   | HolderIdentifier   | StatusLit   | NomPersonCode   | AtdType   | AtdNumber   | GroupCode   | PresentYN   | ResolutionLine1    | ResolutionLine2    |
		| <Action3> | <HolderSearchKey1> | <HolderSearchHin> | <SearchNomCode> | <HolderIdentifier> | <StatusLit> | <NomPersonCode> | <AtdType> | <AtdNumber> | <GroupCode> | <PresentYN> | <ResolutionLine1A> | <ResolutionLine2A> |
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection13> |
		#PAT		
		And In PXS04501 I verify Proxy Attendee details:
		| Action    | HolderSearchKey     | HolderSearchHin    | SearchNomCode    | HolderIdentifier    | StatusLit    | NomPersonCode    | AtdType    | AtdNumber    | GroupCode    | PresentYN    | ResolutionLine1     | ResolutionLine2     |
		| <Action3> | <HolderSearchKey13> | <HolderSearchHin3> | <SearchNomCode3> | <HolderIdentifier3> | <StatusLit3> | <NomPersonCode3> | <AtdType3> | <AtdNumber3> | <GroupCode3> | <PresentYN3> | <ResolutionLine1A3> | <ResolutionLine2A3> |
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection15> |
		#PRE
		And In PXS00500 I run Pre Close Registration Report:
		| ReportType   | PrintHolderID   | ReportSeq   | VotingLevel   | Res1to20Dsc1   | Res1to20Dsc2   | 
		| <ReportType> | <PrintHolderID> | <ReportSeq> | <VotingLevel> | <Res1to20Dsc1> | <Res1to20Dsc2> | 
		And I continue to the report submit page
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection16> |
		#SCR
		And In PXS00103 I continue with the following details:
		| PasswordInput   |
		| <PasswordInput> |
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection17> |
		#PST
		And In PXS00500 I run Post Close Registration Report:
		| ReportType    | PrintHolderID    | ReportSeq    | VotingLevel    | Res1to20Dsc1    | Res1to20Dsc2    | VoteInd    |
		| <ReportTypeP> | <PrintHolderIDP> | <ReportSeqP> | <VotingLevelP> | <Res1to20Dsc1P> | <Res1to20Dsc2P> | <VoteIndP> |
		And I continue to the report submit page
		
			
	Examples: 
	| Test  | COY      | MeetingNumber | Action | MeetingHeading          | MeetingDate | Selection | ATMeetingFlag | Chairman | NbrRes | SchemeMeetingInd | InternetMeeting | AlgorithmNumber | RemResOpenVotes | ClassVotesInd | SameClasses | DirectVotingInd | ProcessingCutoff | ManualProcessCutOff | NomNotPresent | SpecialCondInd | MinBalanceYN | RunUpto | MaxVotesYN | MaxVotes | GroupApply | SpecialCalcInd | AllCalc | CorpRepNotingNum | PreEncodedNotInp | IntermediaryOnlineProcessing | ImoOverVoteProcessingCutOff | ImoCosmosCompanyMeetingID | ActivateAutoScheduledJobs | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport | BriefDesc | BriefDesc2 | LongDesc | LongDesc2 | VotingFrmDesc       | VotingFrmDesc2      | ClassCode | ClassCode2 | ClassGroup | ClassGroup2 | ExcClass | ExcClass2 | OtherReqdInd | OtherReqdInd2 | ClassCodeB1 | ClassCodeB2 | ClassCodeB3 | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | Rounding2 | ExcClassCodesInd | ExcClassCodesInd2 | ExcClassCode | ExcClassCode2 | RemResTickBox | RemResTickBox2 | NomOveRes | NomOveRes2 | UnitsIssuedOS | UnitsIssuedOS2 | UnitsUpdMethod | UnitsUpdMethod2 | Selection1 | Action1st | Code | Name     | Status | Type | Current | Action1st1 | Code1 | Name1    | Status1 | Type1 | Current1 | Selection2 | RefNum | ProxyType | Holder      | SPFlag | Noma | Nomb | FailingA | PerA | R01 | R02 | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm | RefNumU | ProxyTypeU | HolderU     | SPFlagU | NomaU | NombU | FailingAU | PerAU | R01U | R02U | For01U | For02U | Against01U | Against02U | OpenTicked01U | OpenTicked02U | Abstain01U | Abstain02U | Exclude01U | Exclude02U | ClassEntitlementU | ResDesc1U | ResDesc2U | ClassEntitlement1U | ClassEntitlement2U | TotalEntered1U | TotalEntered2U | Difference1U | Difference2U | Description1U | Description2U | ConfirmU | Selection3 | Action1 | HolderSearchKey | NomPersonA | NomPersonB | PercentA | ResolutionLine1                                                                | ResolutionLine2                                                                | HolderSearchKey2 | NomPersonA2 | NomPersonB2 | PercentA2 | ResolutionLine12                                                     | ResolutionLine22                                                     | Selection4 | Selection5 | Action2 | Confirm1 | FinalConfirm | Selection6 | ATMeetingFlag1 | Selection7 | Selection8 | Selection9 | AttendeeNum | HolderName  | AttendeeName | AttendeeNumber | Selection10 | AttendeeNum1 | HolderName1 | AttendeeName1 | AttendeeNumber1 | Selection11 | AttendeeNum2 | HolderName2 | AttendeeName2 | AttendeeNumber2 | Selection12 | AttendeeNum3 | HolderName3 | AttendeeName3 | AttendeeNumber3 | Selection13 | Action3 | HolderSearchKey1 | HolderSearchHin | SearchNomCode | HolderIdentifier | StatusLit          | NomPersonCode | AtdType | AtdNumber | GroupCode | PresentYN | ResolutionLine1A                                                             | ResolutionLine2A                                                             | HolderSearchKey13 | HolderSearchHin3 | SearchNomCode3 | HolderIdentifier3 | StatusLit3       | NomPersonCode3 | AtdType3 | AtdNumber3 | GroupCode3 | PresentYN3 | ResolutionLine1A3                                                            | ResolutionLine2A3                                                            | Selection14 | AttendeeNum4 | HolderName4 | AttendeeName4 | AttendeeNumber4 | Selection15 | ReportType | PrintHolderID | ReportSeq | VotingLevel | Res1to20Dsc1 | Res1to20Dsc2 | Selection16 | PasswordInput | Selection17 | ReportTypeP | PrintHolderIDP | ReportSeqP | VotingLevelP | Res1to20Dsc1P | Res1to20Dsc2P | VoteIndP |
	| Test1 | CPU_AUTO | 3             | A      | TEST AUTOMATION-SAV-PST | 01/08/2015  | PIN       | N             | CHM      | 2      | N                | N               |                 | N               | Y             | N           | N               | N                | N                   | A             | N              |              |         |            |          |            | N              |         |                  | N                | N                            |                             |                           | N                         |                         |                       |               |             |                     |                     |                     |                         |                         |                         |                        |                        |                        |                  | R1        | R2         | RES1     | RES2      | Resolution Number 1 | Resolution Number 2 | FP        | FP         |            |             |          |           | N            | N             |             |             |             |            |            |            |          |           |                  |                   |              |               |               |                | N         | N          |               |                | A              |                 | mnp        | A         | DS1  | TEST DS1 | N      | B    | Y       | A          | DS2   | TEST DS2 | N       | N     | Y        | pet        | 20     | FAB       | X0044132095 | P      | CHM  | DS2  |          | 50   | F   | F   |       |       |           |           |              |              |           |           |           |           |                  |          |          |                   |                   |               |               |             |             |              |              |         | 21      | UNFA       | X0055123268 |         | CHM   |       |           |       |      |      | 200    | 200    | 200        | 200        | 200           | 200           | 200        | 200        | 200        | 200        | 3500              | R1        | R2        | 3500               | 3500               | 1000           | 1000           | 2500         | 2500         | LESS          | LESS          | C        | PHV        | S       | X0044132095     | CHM        | DS2        | 50       | R1          F           60           60                                 120.00 | R2          F           60           60                                 120.00 | X0055123268      | CHM         |             |           | R1 .         200          200          200          200          200 | R2 .         200          200          200          200          200 | PAL        | PX         | P       | Y        | SURE         | SAV        | Y              | PCU        | AET        | SET        | 1           | I0030047974 |              |                | NET         |              |             | I0100003091   | 2               | NET         |              |             | DS2           | 3               | VET         | 4            |             | MARY JONES    |                 | PAT         | S       |                  | I0030047974     |               | I0030047974      | Voting Shareholder |               |         | 1         |           | Y         | R1 .          1318        0          0       0          0       1       1318 | R2 .          1318        0          0       0          0       1       1318 |                   |                  | DS2            |                   | Nominated Person | DS2            | N        | 3          |            | Y          | R1 .            30        1         30       0          0       0          0 | R2 .            30        1         30       0          0       0          0 | NET         |              |             | CHM           | 5               | PRE         | F          | Y             | A         |             |              |              | SCR         |               | PST         | F           | Y              | A          |              |               |               | N        |


# Commented this test case -if we want to run full end to end proxy test we can use this in future #
#Scenario Outline: Test Case Proxy End to End -To PST
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I enter Proxy Details as "<MeetingNumber>" "<Action>"
#		And In PXS00107 I enter proxy Details as "<MeetingHeading>" "<MeetingDate>"
#		And In PXS00101 I enter proxy details:
#		| Selection   |
#		| <Selection> |
#		#PCU
#		And In PXS00201 I enter Proxy System Control Setup details:
#		| ATMeetingFlag   | Chairman   | NbrRes   | SchemeMeetingInd   | InternetMeeting   | AlgorithmNumber   | RemResOpenVotes   | ClassVotesInd   | SameClasses   | DirectVotingInd   | ProcessingCutoff   | ManualProcessCutOff   | NomNotPresent   |
#		| <ATMeetingFlag> | <Chairman> | <NbrRes> | <SchemeMeetingInd> | <InternetMeeting> | <AlgorithmNumber> | <RemResOpenVotes> | <ClassVotesInd> | <SameClasses> | <DirectVotingInd> | <ProcessingCutoff> | <ManualProcessCutOff> | <NomNotPresent> |
#		And In PXS00202 I enter Proxy System Control Setup details:
#		| SpecialCondInd   | MinBalanceYN  | RunUpto   | MaxVotesYN   | MaxVotes   | GroupApply   | SpecialCalcInd   | AllCalc   | CorpRepNotingNum   | PreEncodedNotInp |
#		| <SpecialCondInd> |<MinBalanceYN> | <RunUpto> | <MaxVotesYN> | <MaxVotes> | <GroupApply> | <SpecialCalcInd> | <AllCalc> | <CorpRepNotingNum> | <PreEncodedNotInp> |
#		And In PXS00203 I enter Proxy System Control Setup details:
#		| IntermediaryOnlineProcessing   | ImoOverVoteProcessingCutOff   | ImoCosmosCompanyMeetingID   | ActivateAutoScheduledJobs   | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport |
#		| <IntermediaryOnlineProcessing> | <ImoOverVoteProcessingCutOff> | <ImoCosmosCompanyMeetingID> | <ActivateAutoScheduledJobs> | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport |
#		And In PXS00211 I enter Proxy System Control Setup details:
#		| BriefDesc   | LongDesc   | VotingFrmDesc   | ClassCode   | ClassGroup   | ExcClass   | OtherReqdInd   | ClassCodeB1   | ClassCodeB2   | ClassCodeB3   | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | ExcClassCodesInd   | ExcClassCode   | RemResTickBox   | NomOveRes   | UnitsUpdMethod  |
#		| <BriefDesc> | <LongDesc> | <VotingFrmDesc> | <ClassCode> | <ClassGroup> | <ExcClass> | <OtherReqdInd> | <ClassCodeB1> | <ClassCodeB2> | <ClassCodeB3> | ExcClassB1 | ExcClassB2 | ExcClassB3 |<Rounding>| <ExcClassCodesInd> | <ExcClassCode> | <RemResTickBox> | <NomOveRes> | <UnitsUpdMethod>| 
#		And In PXS00211 I enter Proxy System Control Setup details:
#		| BriefDesc    | LongDesc    | VotingFrmDesc    | ClassCode    | ClassGroup		| ExcClass	 | OtherReqdInd   | ClassCodeB1   | ClassCodeB2   | ClassCodeB3   | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | ExcClassCodesInd   | ExcClassCode   | RemResTickBox   | NomOveRes   | UnitsUpdMethod  |
#		| <BriefDesc2> | <LongDesc2> | <VotingFrmDesc2> | <ClassCode2> | <ClassGroup>	| <ExcClass> | <OtherReqdInd2> | <ClassCodeB1> | <ClassCodeB2> | <ClassCodeB3> | ExcClassB1 | ExcClassB2 | ExcClassB3 |<Rounding>| <ExcClassCodesInd> | <ExcClassCode> | <RemResTickBox> | <NomOveRes2> | <UnitsUpdMethod2>| 
#		And I Transmit
#		And I Transmit
#		#MNP
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection1> |
#		And In NOMSCH01 I continue with the following details:
#		| Action1st   | Code   | Name   | Status   | Type   | Current   |
#		| <Action1st> | <Code> | <Name> | <Status> | <Type> | <Current> |
#		And In NOMSCH01 I continue with the following details:
#		| Action1st    | Code    | Name    | Status    | Type    | Current    |
#		| <Action1st1> | <Code1> | <Name1> | <Status1> | <Type1> | <Current1> |
#		And I PressESC
#		#PET
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection2> |
#		And In PXS02001 I continue with the following details:
#		| RefNum   | ProxyType   | Holder   | SPFlag   | Noma   | Nomb   | FailingA   | PerA   | R01   | R02   | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm |
#		| <RefNum> | <ProxyType> | <Holder> | <SPFlag> | <Noma> | <Nomb> | <FailingA> | <PerA> | <R01> | <R02> |<For01> | <For02> | <Against01> | <Against02> | <OpenTicked01> | <OpenTicked02> | <Abstain01> | <Abstain02> | <Exclude01> | <Exclude02> | <ClassEntitlement> | <ResDesc1> | <ResDesc2> | <ClassEntitlement1> | <ClassEntitlement2> | <TotalEntered1> | <TotalEntered2> | <Difference1> | <Difference2> | <Description1> | <Description2> | <Confirm> |
#		And In PXS02001 I continue with the following details:
#		| RefNum    | ProxyType    | Holder    | SPFlag    | Noma    | Nomb    | FailingA    | PerA    | R01    | R02    | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm |
#		| <RefNumU> | <ProxyTypeU> | <HolderU> | <SPFlagU> | <NomaU> | <NombU> | <FailingAU> | <PerAU> | <R01U> | <R02U> |<For01U> | <For02U> | <Against01U> | <Against02U> | <OpenTicked01U> | <OpenTicked02U> | <Abstain01U> | <Abstain02U> | <Exclude01U> | <Exclude02U> | <ClassEntitlementU> | <ResDesc1U> | <ResDesc2U> | <ClassEntitlement1U> | <ClassEntitlement2U> | <TotalEntered1U> | <TotalEntered2U> | <Difference1U> | <Difference2U> | <Description1U> | <Description2U> | <ConfirmU> |
#		And I PressESC		
#		#PHV
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection3> |
#		And In PXS04001 I verify the Proxy Holder Vote Details as:
#		| Action    | HolderSearchKey   | NomPersonA   | NomPersonB   | PercentA   | ResolutionLine1   | ResolutionLine2   |
#		| <Action1> | <HolderSearchKey> | <NomPersonA> | <NomPersonB> | <PercentA> | <ResolutionLine1> | <ResolutionLine2> |
#		And In PXS04001 I verify the Proxy Holder Vote Details as:
#		| Action    | HolderSearchKey    | NomPersonA    | NomPersonB    | PercentA    | ResolutionLine1    | ResolutionLine2    |
#		| <Action1> | <HolderSearchKey2> | <NomPersonA2> | <NomPersonB2> | <PercentA2> | <ResolutionLine12> | <ResolutionLine22> |
#		And I PressESC
#		#PAL
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection4> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the Proxy report
#			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
#			| completion   | 360     | error        | DONE            | EXIT            |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I Go to Proxy Meeting:
#		 | Selection    | MeetingNumber   | Action    |
#		 | <Selection5> | <MeetingNumber> | <Action2> |
#		#SAV
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection6> |
#		And In PXS00109 I continue with the following:
#		| Confirm1    | FinalConfirm   |
#		| <Confirm1> | <FinalConfirm> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the Proxy report
#			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
#			| completion   | 360     | error        | DONE            | EXIT            |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I Go to Proxy Meeting:
#		 | Selection    | MeetingNumber   | Action    |
#		 | <Selection5> | <MeetingNumber> | <Action2> |
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection7> |
#		#At meeting to Y
#		And In PXS00201 I Change At Meeting details:
#		| ATMeetingFlag1   |
#		| <ATMeetingFlag1> |	
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection8> |
#		#AET -SET
#		And In PXS01500 I Add Attendee list details:
#		| Selection    | AttendeeNum   | HolderName   | AttendeeName   | AttendeeNumber   |
#		| <Selection9> | <AttendeeNum> | <HolderName> | <AttendeeName> | <AttendeeNumber> |
#		#AET -NET(SRN)
#		And In PXS01500 I Add Attendee list details:
#		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
#		| <Selection10> | <AttendeeNum1> | <HolderName1> | <AttendeeName1> | <AttendeeNumber1> |
#		#AET -NET(NAME)
#		And In PXS01500 I Add Attendee list details:
#		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
#		| <Selection11> | <AttendeeNum2> | <HolderName2> | <AttendeeName2> | <AttendeeNumber2> |
#		#AET -VET
#		And In PXS01500 I Add Attendee list details:
#		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
#		| <Selection12> | <AttendeeNum3> | <HolderName3> | <AttendeeName3> | <AttendeeNumber3> |
#		#AET -VET(CHM)	
#		And In PXS01500 I Add Attendee list details:
#		| Selection     | AttendeeNum    | HolderName    | AttendeeName    | AttendeeNumber    |
#		| <Selection14> | <AttendeeNum4> | <HolderName4> | <AttendeeName4> | <AttendeeNumber4> |
#		And I PressESC
#		And In PXS00101 I select proxy details Menu:
#		| Selection1    |
#		| <Selection13> |
#		#PAT
#		And In PXS04501 I verify Proxy Attendee details:
#		| Action    | HolderSearchKey    | HolderSearchHin   | SearchNomCode   | HolderIdentifier   | StatusLit   | NomPersonCode   | AtdType   | AtdNumber   | GroupCode   | PresentYN   | ResolutionLine1    | ResolutionLine2    |
#		| <Action3> | <HolderSearchKey1> | <HolderSearchHin> | <SearchNomCode> | <HolderIdentifier> | <StatusLit> | <NomPersonCode> | <AtdType> | <AtdNumber> | <GroupCode> | <PresentYN> | <ResolutionLine1A> | <ResolutionLine2A> |
#		And In PXS00101 I select proxy details Menu:
#		| Selection1    |
#		| <Selection13> |
#		#PAT		
#		And In PXS04501 I verify Proxy Attendee details:
#		| Action    | HolderSearchKey     | HolderSearchHin    | SearchNomCode    | HolderIdentifier    | StatusLit    | NomPersonCode    | AtdType    | AtdNumber    | GroupCode    | PresentYN    | ResolutionLine1     | ResolutionLine2     |
#		| <Action3> | <HolderSearchKey13> | <HolderSearchHin3> | <SearchNomCode3> | <HolderIdentifier3> | <StatusLit3> | <NomPersonCode3> | <AtdType3> | <AtdNumber3> | <GroupCode3> | <PresentYN3> | <ResolutionLine1A3> | <ResolutionLine2A3> |
#		And In PXS00101 I select proxy details Menu:
#		| Selection1    |
#		| <Selection15> |
#		#PRE
#		And In PXS00500 I run Pre Close Registration Report:
#		| ReportType   | PrintHolderID   | ReportSeq   | VotingLevel   | Res1to20Dsc1   | Res1to20Dsc2   | 
#		| <ReportType> | <PrintHolderID> | <ReportSeq> | <VotingLevel> | <Res1to20Dsc1> | <Res1to20Dsc2> | 
#		And I continue to the report submit page
#		And In PXS00101 I select proxy details Menu:
#		| Selection1    |
#		| <Selection16> |
#		#SCR
#		And In PXS00103 I continue with the following details:
#		| PasswordInput   |
#		| <PasswordInput> |
#		And In PXS00101 I select proxy details Menu:
#		| Selection1    |
#		| <Selection17> |
#		#PST
#		And In PXS00500 I run Post Close Registration Report:
#		| ReportType    | PrintHolderID    | ReportSeq    | VotingLevel    | Res1to20Dsc1    | Res1to20Dsc2    | VoteInd    |
#		| <ReportTypeP> | <PrintHolderIDP> | <ReportSeqP> | <VotingLevelP> | <Res1to20Dsc1P> | <Res1to20Dsc2P> | <VoteIndP> |
#		And I continue to the report submit page
#		
#			
#	Examples: 
#	| Test  | COY     | MeetingNumber | Action | MeetingHeading           | MeetingDate | Selection | ATMeetingFlag | Chairman | NbrRes | SchemeMeetingInd | InternetMeeting | AlgorithmNumber | RemResOpenVotes | ClassVotesInd | SameClasses | DirectVotingInd | ProcessingCutoff | ManualProcessCutOff | NomNotPresent | SpecialCondInd | MinBalanceYN | RunUpto | MaxVotesYN | MaxVotes | GroupApply | SpecialCalcInd | AllCalc | CorpRepNotingNum | PreEncodedNotInp | IntermediaryOnlineProcessing | ImoOverVoteProcessingCutOff | ImoCosmosCompanyMeetingID | ActivateAutoScheduledJobs | ActivationFromDateRange | ActivationTODateRange | AutoTopReport | CutoffPoint | EntitlementClasses1 | EntitlementClasses2 | EntitlementClasses3 | EntitlementClassGroups1 | EntitlementClassGroups2 | EntitlementClassGroups3 | EntitlementOtherClass1 | EntitlementOtherClass2 | EntitlementOtherClass3 | AutoPalsavReport | BriefDesc | BriefDesc2 | LongDesc | LongDesc2 | VotingFrmDesc       | VotingFrmDesc2      | ClassCode | ClassCode2 | ClassGroup | ClassGroup2 | ExcClass | ExcClass2 | OtherReqdInd | OtherReqdInd2 | ClassCodeB1 | ClassCodeB2 | ClassCodeB3 | ExcClassB1 | ExcClassB2 | ExcClassB3 | Rounding | Rounding2 | ExcClassCodesInd | ExcClassCodesInd2 | ExcClassCode | ExcClassCode2 | RemResTickBox | RemResTickBox2 | NomOveRes | NomOveRes2 | UnitsIssuedOS | UnitsIssuedOS2 | UnitsUpdMethod | UnitsUpdMethod2 | Selection1 | Action1st | Code | Name     | Status | Type | Current | Action1st1 | Code1 | Name1    | Status1 | Type1 | Current1 | Selection2 | RefNum | ProxyType | Holder      | SPFlag | Noma | Nomb | FailingA | PerA | R01 | R02 | For01 | For02 | Against01 | Against02 | OpenTicked01 | OpenTicked02 | Abstain01 | Abstain02 | Exclude01 | Exclude02 | ClassEntitlement | ResDesc1 | ResDesc2 | ClassEntitlement1 | ClassEntitlement2 | TotalEntered1 | TotalEntered2 | Difference1 | Difference2 | Description1 | Description2 | Confirm | RefNumU | ProxyTypeU | HolderU     | SPFlagU | NomaU | NombU | FailingAU | PerAU | R01U | R02U | For01U | For02U | Against01U | Against02U | OpenTicked01U | OpenTicked02U | Abstain01U | Abstain02U | Exclude01U | Exclude02U | ClassEntitlementU | ResDesc1U | ResDesc2U | ClassEntitlement1U | ClassEntitlement2U | TotalEntered1U | TotalEntered2U | Difference1U | Difference2U | Description1U | Description2U | ConfirmU | Selection3 | Action1 | HolderSearchKey | NomPersonA | NomPersonB | PercentA | ResolutionLine1                                                                | ResolutionLine2                                                                | HolderSearchKey2 | NomPersonA2 | NomPersonB2 | PercentA2 | ResolutionLine12                                                     | ResolutionLine22                                                     | Selection4 | Selection5 | Action2 | Confirm1 | FinalConfirm | Selection6 | ATMeetingFlag1 | Selection7 | Selection8 | Selection9 | AttendeeNum | HolderName  | AttendeeName | AttendeeNumber | Selection10 | AttendeeNum1 | HolderName1 | AttendeeName1 | AttendeeNumber1 | Selection11 | AttendeeNum2 | HolderName2 | AttendeeName2 | AttendeeNumber2 | Selection12 | AttendeeNum3 | HolderName3 | AttendeeName3 | AttendeeNumber3 | Selection13 | Action3 | HolderSearchKey1 | HolderSearchHin | SearchNomCode | HolderIdentifier | StatusLit          | NomPersonCode | AtdType | AtdNumber | GroupCode | PresentYN | ResolutionLine1A                                                             | ResolutionLine2A                                                             | HolderSearchKey13 | HolderSearchHin3 | SearchNomCode3 | HolderIdentifier3 | StatusLit3       | NomPersonCode3 | AtdType3 | AtdNumber3 | GroupCode3 | PresentYN3 | ResolutionLine1A3                                                            | ResolutionLine2A3                                                            | Selection14 | AttendeeNum4 | HolderName4 | AttendeeName4 | AttendeeNumber4 | Selection15 | ReportType | PrintHolderID | ReportSeq | VotingLevel | Res1to20Dsc1 | Res1to20Dsc2 | VoteInd | Selection16 | PasswordInput | Selection17 |
#	| Test1 | CPU_AUTO | 4             | A      | TEST AUTOMATION-PST-POLL | 01/08/2015  | PIN       | N             | CHM      | 2      | N                | N               |                 | N               | Y             | N           | N               | N                | N                   | A             | N              |              |         |            |          |            | N              |         |                  | N                | N                            |                             |                           | N                         |                         |                       |               |             |                     |                     |                     |                         |                         |                         |                        |                        |                        |                  | R1        | R2         | RES1     | RES2      | Resolution Number 1 | Resolution Number 2 | FP        | FP         |            |             |          |           | N            | N             |             |             |             |            |            |            |          |           |                  |                   |              |               |               |                | N         | N          |               |                | A              |                 | mnp        | A         | DS1  | TEST DS1 | N      | B    | Y       | A          | DS2   | TEST DS2 | N       | N     | Y        | pet        | 20     | FAB       | X0044132095 | P      | CHM  | DS2  |          | 50   | F   | F   |       |       |           |           |              |              |           |           |           |           |                  |          |          |                   |                   |               |               |             |             |              |              |         | 21      | UNFA       | X0055123268 |         | CHM   |       |           |       |      |      | 200    | 200    | 200        | 200        | 200           | 200           | 200        | 200        | 200        | 200        | 3500              | R1        | R2        | 3500               | 3500               | 1000           | 1000           | 2500         | 2500         | LESS          | LESS          | C        | PHV        | S       | X0044132095     | CHM        | DS2        | 50       | R1          F           60           60                                 120.00 | R2          F           60           60                                 120.00 | X0055123268      | CHM         |             |           | R1 .         200          200          200          200          200 | R2 .         200          200          200          200          200 | PAL        | PX         | P       | Y        | SURE         | SAV        | Y              | PCU        | AET        | SET        | 1           | I0030047974 |              |                | NET         |              |             | I0100003091   | 2               | NET         |              |             | DS2           | 3               | VET         | 4            |             | MARY JONES    |                 | PAT         | S       |                  | I0030047974     |               | I0030047974      | Voting Shareholder |               |         | 1         |           | Y         | R1 .          1318        0          0       0          0       1       1318 | R2 .          1318        0          0       0          0       1       1318 |                   |                  | DS2            |                   | Nominated Person | DS2            | N        | 3          |            | Y          | R1 .            30        1         30       0          0       0          0 | R2 .            30        1         30       0          0       0          0 | NET         |              |             | CHM           | 5               | PRE         | F          | Y             | A         |             |              |              |         | SCR         |               | PST         |

@winformsTest
@Proxy_System
Scenario Outline: Test Case Proxy End to End -PST TO POLL
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And In PXS00106 I Go to Proxy Meeting:
		 | Selection    | MeetingNumber   | Action    |
		 | <Selection5> | <MeetingNumber> | <Action2> |
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection18> |
		#PUP-PRU
		And In PXS00301 I Change Poll Resolution Update:
		| Selection     | Consolidate   | R1   | R2   | C1   | C2   |
		| <Selection19> | <Consolidate> | <R1> | <R2> | <C1> | <C2> |
		#PUP-PVE-Number
		And In PXS03600 I Add Poll Voting Entry:
		| Selection     | EntryType   | SearchType   | AtdNumber   | For01   | For02   | Against01   | Against02   | Abstain01   | Abstain02   | Action    | Search   |
		| <Selection20> | <EntryType> | <SearchType> | <AtdNumber> | <For01> | <For02> | <Against01> | <Against02> | <Abstain01> | <Abstain02> | <Action4> | <Search> |
		#PUP-PVE-Name
		And In PXS03600 I Add Poll Voting Entry:
		| Selection      | EntryType    | SearchType    | AtdNumber    | For01    | For02    | Against01    | Against02    | Abstain01    | Abstain02    | Action     | Search    |
		| <Selection20A> | <EntryTypeA> | <SearchTypeA> | <AtdNumberA> | <For01A> | <For02A> | <Against01A> | <Against02A> | <Abstain01A> | <Abstain02A> | <Action4A> | <SearchA> |
		And I PressESC
		And In PXS00101 I select proxy details Menu:
		| Selection1    |
		| <Selection22> |
		#PR -can use the same binding
		And In PXS00500 I run Post Close Registration Report:
		| ReportType     | PrintHolderID     | ReportSeq     | VotingLevel     | Res1to20Dsc1     | Res1to20Dsc2     | VoteInd     |
		| <ReportTypePR> | <PrintHolderIDPR> | <ReportSeqPR> | <VotingLevelPR> | <Res1to20Dsc1PR> | <Res1to20Dsc2PR> | <VoteIndPR> |
		And I continue to the report submit page


	Examples: 
	| Test  | COY      | Selection5 | MeetingNumber | Action2 | Selection18 | Selection19 | Consolidate | R1 | R2 | C1 | C2 | Selection20 | EntryType | SearchType | AtdNumber | For01 | For02 | Against01 | Against02 | Abstain01 | Abstain02 | Action4 | Search | Selection20A | EntryTypeA | SearchTypeA | AtdNumberA | For01A | For02A | Against01A | Against02A | Abstain01A | Abstain02A | Action4A | SearchA                 | Selection22 | ReportTypePR | PrintHolderIDPR | ReportSeqPR | VotingLevelPR | Res1to20Dsc1PR | Res1to20Dsc2PR | VoteIndPR |
	| Test1 | CPU_AUTO | PX         | 4             | P       | PUP         | PRU         | N           | Y  | Y  | Y  | Y  | PVE         | V         | N          | 5         | 50    | 50    | 50        | 50        | 50        | 50        | 50      |        | PVE          | V          | A           |            | 100    | 100    | 100        | 100        | 100        | 100        | S        | MS LECDE YIQII A'PAOGHF | PR          | F            | Y               | A           |               |                |                | Y         |

@winformsTest
@Proxy_System
@FullSmokeTest
@SmokeTestChangeProxy
Scenario Outline: Test Case 21044: 05_CDP Change/Delete Proxy
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And In PXS00106 I Go to Proxy Meeting:
		 | Selection    | MeetingNumber   | Action    |
		 | <Selection5> | <MeetingNumber> | <Action2> |
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection2> |
		#CDP-C
		And In PXS02101 I Update Proxy transaction maintenance details:
		| RefNum   | HolderIdentifier   | Action   | SPFlag   | Noma   | PerA   | Nomb   | FailingA   | R01   | R02   |
		| <RefNum> | <HolderIdentifier> | <Action> | <SPFlag> | <Noma> | <PerA> | <Nomb> | <FailingA> | <R01> | <R02> |
		#CDP-D
		And In PXS02101 I Update Proxy transaction maintenance details:
		| RefNum    | HolderIdentifier    | Action    | SPFlag    | Noma    | PerA    | Nomb    | FailingA    | R01    | R02    |
		| <RefNumD> | <HolderIdentifierD> | <ActionD> | <SPFlagD> | <NomaD> | <PerAD> | <NombD> | <FailingAD> | <R01D> | <R02D> |


	Examples: 
	| Test  | COY      | Selection5 | MeetingNumber | Action2 | Selection2 | RefNum | HolderIdentifier | Action | SPFlag | Noma | PerA | Nomb | FailingA | R01 | R02 | RefNumD | HolderIdentifierD | ActionD | SPFlagD | NomaD | PerAD | NombD | FailingAD | R01D | R02D |
	| Test1 | CPU_AUTO | PX         | 1             | P       | CDP        | 20     |                  | C      | P      | CHM  | 60   | SEC  |          | F   | A   | 20      |                   | D       |         |       |       |       |           |      |      |
#
#@Proxy_System
#@ignore
#Scenario Outline: Test Case Run-Compare PAL-SAV Report
#	Given I have connected to WinForms on "vms"
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I Go to Proxy Meeting:
#		 | Selection    | MeetingNumber   | Action    |
#		 | <Selection5> | <MeetingNumber> | <Action2> |
#		#PAL
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection2> |
#		And I continue to the report submit pages
#		And In JOBSUB90 I submit the Proxy report
#			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
#			| completion   | 360     | error        | DONE            | EXIT            |
#		When I copy VMS Proxy output to local
#		| ReportHeading   | MeetingNumberDirVMS   | ReportType   |
#		| <ReportHeading> | <MeetingNumberDirVMS> | <ReportType> |
#	Given I have connected to WinForms on "vms"
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I Go to Proxy Meeting:
#		 | Selection    | MeetingNumber   | Action    |
#		 | <Selection5> | <MeetingNumber> | <Action2> |
#		#SAV
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection6> |
#		And In PXS00109 I continue with the following:
#		| Confirm1    | FinalConfirm   |
#		| <Confirm1> | <FinalConfirm> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the Proxy report
#			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
#			| completion   | 360     | error        | DONE            | EXIT            | 
#		When I copy VMS Proxy output to local
#		| ReportHeading   | MeetingNumberDirVMS   | ReportType    |
#		| <ReportHeading> | <MeetingNumberDirVMS> | <ReportType1> |
#	
#	Given I have connected to WinForms on "linux"
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I Go to Proxy Meeting:
#		 | Selection    | MeetingNumber   | Action    |
#		 | <Selection5> | <MeetingNumber> | <Action2> |
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection2> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the Proxy report
#			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
#			| completion   | 360     | error        | DONE            | EXIT            |
#		When I copy Linux Proxy output to local
#		| ReportHeading   | MeetingNumberDirLnx   | ReportType   |
#		| <ReportHeading> | <MeetingNumberDirLnx> | <ReportType> |
#	Given I have connected to WinForms on "linux"
#	When In SELCOY01 I select the company as "<COY>"
#		And In PXS00106 I Go to Proxy Meeting:
#		 | Selection    | MeetingNumber   | Action    |
#		 | <Selection5> | <MeetingNumber> | <Action2> |
#		#SAV
#		And In PXS00101 I select proxy details Menu:
#		| Selection1   |
#		| <Selection6> |
#		And In PXS00109 I continue with the following:
#		| Confirm1    | FinalConfirm   |
#		| <Confirm1> | <FinalConfirm> |
#		And I continue to the report submit page
#		And In JOBSUB90 I submit the Proxy report
#			| PassCriteria | timeout | FailCriteria | PassCriteriaLNX | FailCriteriaLNX |
#			| completion   | 360     | error        | DONE            | EXIT            | 
#		When I copy Linux Proxy output to local
#		| ReportHeading   | MeetingNumberDirLnx   | ReportType   |
#		| <ReportHeading> | <MeetingNumberDirLnx> | <ReportType1> |
#	Then I expect the same number of files returned from VMS and Linux
# 	
#	Examples:
#	| ReportHeading | COY      | Selection5 | MeetingNumber | Action2 | Selection2 | MeetingNumberDirVMS | MeetingNumberDirLnx | ReportType | Selection6 | Confirm1 | FinalConfirm | ReportType1 |
#	| Test1         | CPU_AUTO | PX         | 5             | P       | PAL        | .PRX5               | prx5                | PAL        | SAV        | Y        | SURE         | SAV         |

@winformsTest
@Proxy_System
Scenario Outline: Test Case 29210: 04_DEL Delete Shareholder/Nominated Person Entry
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And In PXS00106 I Go to Proxy Meeting:
		 | Selection    | MeetingNumber   | Action    |
		 | <Selection5> | <MeetingNumber> | <Action2> |
		And In PXS00101 I select proxy details Menu:
		| Selection1   |
		| <Selection1> |
		And In PXS01500 I continue with the following details:
		| Selection    |
		| <Selection2> |
		#AET-DEL-S
		And In PXS01512 I Delete Entry:
		| AttendeeNumber   | AttendeeType   | Confirm   |
		| <AttendeeNumber> | <AttendeeType> | <Confirm> |
		And In PXS01500 I continue with the following details:
		| Selection    |
		| <Selection2> |		
		#AET-DEL-N		
		And In PXS01512 I Delete Entry:
		| AttendeeNumber    | AttendeeType    | Confirm   |
		| <AttendeeNumberN> | <AttendeeTypeN> | <Confirm> |
		And In PXS01500 I continue with the following details:
		| Selection    |
		| <Selection2> |		
		#AET-DEL-V	
		And In PXS01512 I Delete Entry:
		| AttendeeNumber    | AttendeeType    | Confirm   |
		| <AttendeeNumberV> | <AttendeeTypeV> | <Confirm> |
	
Examples: 
	| Test  | COY     | Selection5 | MeetingNumber | Action2 | Selection1 | Selection2 | AttendeeNumber | AttendeeType | Confirm | AttendeeNumberN | AttendeeTypeN | AttendeeNumberV | AttendeeTypeV |
	| Test1 | CPU_AUTO | PX         | 6             | P       | AET        | DEL        | 1              | S            | Y       | 2               | N             | 3               | V             |

@winformsTest
@Proxy_System
Scenario Outline: Test Case 29361: 03_DPE Delete Poll Entry
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
	And In PXS00106 I Go to Proxy Meeting:
	| Selection    | MeetingNumber   | Action    |
    | <Selection5> | <MeetingNumber> | <Action2> |
	And In PXS00101 I select proxy details Menu:
    | Selection1   |
    | <Selection1> |
	And In PXS00102 I continue with the following details:
	| Selection    |
    | <Selection2> |
	#DPE - A
	And In PXS03800 I continue with the following details:
    | SearchType  |
    | <SearchType>|
	And In PXS03801 I continue with the following details:
	| Action	  | Search      | Action1    | 
	| <Action>    | <Search>    | <Action1>  |
	

Examples: 
    | Test  | COY      | Selection5 | MeetingNumber | Action2 | Selection1 | Selection2 | SearchType | Action | Search   | Action1 |
    | Test1 | CPU_AUTO | PX         | 7             | P       | PUP        | DPE        | A          | S      | A'PAOGHF | U       |

