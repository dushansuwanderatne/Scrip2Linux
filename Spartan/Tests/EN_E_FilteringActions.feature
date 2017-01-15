Feature: EN_E_FilteringActions
	Ensure EN_E_FilteringActions functionality covered

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_E_FilteringActions
Scenario: Set_Remove Class Filter
	# Enquiry System -Action SCF/RCF
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | SCF   |
			| Locate Argument |       |
		And In ENS01028 I set class code filter as below:
			| Field       | Value |
			| Class Code1 | Y     |
			| Class Code2 | Y     |
			| Class Code3 | Y     |
			| Class Code4 | Y     |
	Then In ENS01090 class code filter display as "* NOTICE 03/03/2014 *                    *Class: AC1|ARC|ARU|ASA"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | RCF   |
			| Locate Argument |       |
	Then In ENS01090 class code filter display as "* NOTICE 03/03/2014 *"

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_E_FilteringActions
Scenario: Set_Remove Holder Filter
	# Enquiry System -Action SHF/RHF
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | SHF   |
			| Locate Argument |       |
		And In ENS010HF I set holder filter as below:
			| Field              | Value |
			| Deceased           | Y     |
			| Plan Election      | Y     |
			| Joint Holdings     | Y     |
			| Designated Account | Y     |
			| Notings            | Y     |
		Then In ENS01001 class code filter display as "*Holder Filter: FAIL*"
		When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | RHF   |
			| Locate Argument |       |
		Then In ENS01001 class code filter display as ""

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_E_FilteringActions
Scenario: Restrict Run Range
	# Enquiry System -Action RRUN
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | RRUN  |
			| Locate Argument |       |
		And In ENS01029 I set Run Range Filter as below:
			| Field    | Value |
			| Run From | 4390  |
			| Run To   | 4398  | 
		And I go to the Enquiry system for "I0100007550"
	Then In ENS01013 I should not see Register details
	
