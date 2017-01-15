Feature: EN_E_PrintOption
	Ensure EN_E_PrintOption functionality covered

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_E_PrintOption
@18472
Scenario Outline: Test Case 18472: Print Options
	# Enquiry System -Action HP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0030047974"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"	
		And In ENS01080 I enter Holding Print Extract details as "<FormatType>"
		And In ENS01081 I Enter Extract reference as "<Reference>"
	Then I expect to be in the "ENS01001" Screen
	When I enter the following details as the locatActions "<SearchAction>"  "<SearchHolder1>"	
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"	
		And In ENS01080 I enter Holding Print Extract details as "<FormatType1>"
		And In ENS01081 I Enter Extract reference as "<Reference1>"
	Then I expect to be in the "ENS01001" Screen
	When I enter the following details as the locatActions "<SearchAction>"  "<SearchHolder2>"	
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"	
		And In ENS01082 I Enter Extract reference as "<Reference2>"
	Then I expect to be in the "ENS01001" Screen
	When I enter the following details as the locatActions "<SearchAction>"  "<SearchHolder3>"
		And I enter the following details as the locatActions "<Action2>"  "<LocateArgument>"	
		And In ENS01084 I Enter Issuer Statement Extract details as "<StatementDefinition>" "<Reference3>"
	Then I expect to be in the "ENS01001" Screen
	When I enter the following details as the locatActions "<SearchAction>"  "<SearchHolder4>"
		And I enter the following details as the locatActions "<Action3>"  "<LocateArgument>"	
		And In ENS01085 I continue with the following details:
		| HolderIdentifier | Destination           | Reference    | OpsInitials | RunFrom | RunTO | ClassCode |
		|                  | <StatementDefinition> | <Reference4> |             |         |       |           |
	Then I expect to be in the "ENS01001" Screen

Examples: 

	| Test | Action | LocateArgument | FormatType | Reference | FormatType1 | Reference1 | Action1 | Reference2 | Action2 | Reference3 | StatementDefinition | Action3 | Reference4 | SearchAction | SearchHolder1 | SearchHolder2 | SearchHolder3 | SearchHolder4 |
	| All  | HP     |                | R          | 1111      | H           | 1112       | PP      | 1113       | IS      | 1115       | S                   | FS      | 1116       | S            | I0030047974   | I0030048032   | I0030049756   | N0060000052   |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_PrintOption
@18480
Scenario Outline: Test Case 18480: 04_Marking History (MP Action)
	# Enquiry System -Action MP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009906408"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"	
		And In ENS01089 I enter Marking Print Extract details as "<Reference>" "<MarkingNbr>"
	Then I expect to be in the "ENS01001" Screen
Examples: 

	| Action | LocateArgument | Reference | MarkingNbr   |
	| MP     |                | 1115      | 00123456ST02 |
