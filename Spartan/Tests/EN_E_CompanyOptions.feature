Feature: EN_E_CompanyOptions
	Ensure EN_E_CompanyOptions functionality covered

@winformsTest
@EnquiryTest
@CPU_AUTO
@18423
@EN_E_CompanyOptions
Scenario: Test Case 18423: 01_Sub Systems (CCO Action)
	# Enquiry System -Action CCO
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | CCO   |
			| Locate Argument |       |
	Then I expect to be in the "HCC00101" Screen
	When In HCC00101 I enter the selection as "CTL"
	Then I expect to be in the "HCC00102" Screen
	When I PressESC
	Then I expect to be in the "HCC00101" Screen
	When In HCC00101 I enter the selection as "DC"
	Then I expect to be in the "HCC00103" Screen
	When I PressESC
		And I PressESC
	Then I expect to be in the "ENS01090" Screen

@winformsTest
@EnquiryTest
@CPU_AUTO
@18425
@EN_E_CompanyOptions
Scenario: Test Case 18425: 03_Sub Systems (BLK) - Bulk Transaction List
	# Enquiry System -Action BLK
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BLK   |
			| Locate Argument |       |
	Then I expect to be in the "OLSBLK01" Screen
	When In OLSBLK01 I enter the selection as "97B"
	Then I expect to be in the "OLSBLK02" Screen
	When In OLSBLK02 I enter the selection as "BTL"
	Then I expect to be in the "OLSB0601" Screen
	When I Transmit
	Then I expect to be in the "OLSB0603" Screen
	When I Transmit
	Then I expect to be in the "OLSB0604" Screen
	When I PressESC
	Then I expect to be in the "OLSBLK01" Screen

@winformsTest
@EnquiryTest
@ANZ_AUTO
@18455
@EN_E_CompanyOptions
Scenario: Test Case 18455: 04_Sub Systems (BLK) - Bulk Transaction Enquiry
	# Enquiry System -Action BLK
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BLK   |
			| Locate Argument |       |
	Then I expect to be in the "OLSBLK01" Screen
	When In OLSBLK01 I enter the selection as "DEF"
	Then I expect to be in the "OLSBLK02" Screen
	When In OLSBLK02 I enter the selection as "BTQ"
	Then I expect to be in the "BLKSCH01" Screen
	When In BLKSCH01 I enter the selection as "DEF0000794"
	Then I expect to be in the "OLSB1010" Screen
	When In OLSB1010 I enter the Action details as below:
			| Field  | Value |
			| Action | M     |
			| TranNo |       |
	Then I expect to be in the "OLSB1020" Screen
	When I PressESC
	Then I expect to be in the "OLSB1010" Screen
	When In OLSB1010 I enter the Action details as below:
			| Field  | Value  |
			| Action | S      |
			| TranNo | 578588 |
	Then I expect to be in the "OLSB1010" Screen
	When In OLSB1010 I enter the Action details as below:
			| Field  | Value |
			| Action | B     |
			| TranNo |       |
	Then I expect to be in the "OLSB1010" Screen
	When In OLSB1010 I enter the Action details as below:
			| Field  | Value |
			| Action | F     |
			| TranNo |       |
	Then I expect to be in the "OLSB1010" Screen
	When I PressESC
		And I PressESC
	Then I expect to be in the "OLSBLK01" Screen
	When In OLSBLK01 I enter the selection as "BFI"
	Then I expect to be in the "OLSBLK02" Screen
	When In OLSBLK02 I enter the selection as "BTQ"
	Then I expect to be in the "BLKSCH01" Screen
	When In BLKSCH01 I enter the selection as "BFI0001506"
	Then I expect to be in the "OLSB10T1" Screen

@winformsTest
@EnquiryTest
@ANZ_AUTO
@18456
@EN_E_CompanyOptions
Scenario: Test Case 18456: 05_Sub Systems (BLK) - Bulk Transaction Range Report
	# Enquiry System -Action BLK
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BLK   |
			| Locate Argument |       |
	Then I expect to be in the "OLSBLK01" Screen
	When In OLSBLK01 I enter the selection as "DEF"
	Then I expect to be in the "OLSBLK02" Screen
	When In OLSBLK02 I enter the selection as "BTR"
	Then I expect to be in the "BLKSCH01" Screen
	When In BLKSCH01 I enter the selection as "DEF0001031"
	Then I expect to be in the "OLSB0701" Screen
	When In OLSB0701 I enter Bulk Transaction Report details as below:
			| Field              | Value |
			| SharePriceFrom     | 1     |
			| SharePriceTo       | 10    |
			| SharePriceInterval | 1     |
			| MaxUnits           | 100   |
	Then I expect to be in the "JOBSUB03" Screen
	When In JOBSUB03 I enter Job Identification details as below:
			| Field            | Value |
			| OrderNbr         | 3000  |
			| OperatorInitials | NDF   |
	Then I expect to be in the "JOBSUB04" Screen
	When I Transmit
	Then I expect to be in the "JOBSUB05" Screen
	When In JOBSUB05 I enter Output Options as below:
			| Field       | Value |
			| PrintOption | N     |
	Then I expect to be in the "JOBSUB90" Screen
	When I Transmit
	Then I expect to be in the "BLK00101" Screen

@winformsTest
@EnquiryTest
@ANZ_AUTO
@18457
@EN_E_CompanyOptions
Scenario: Test Case 18457: 06_Sub Systems (BLK) - Bulk Order Processing
	# Enquiry System -Action BLK
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BLK   |
			| Locate Argument |       |
	Then I expect to be in the "OLSBLK01" Screen
	When In OLSBLK01 I enter the selection as "DEF"
	Then I expect to be in the "OLSBLK02" Screen
	When In OLSBLK02 I enter the selection as "BPE"
	Then I expect to be in the "BLKSCH01" Screen
	When In BLKSCH01 I enter the selection as "DEF0001018"
	Then I expect to be in the "BLKSCH02" Screen
	When In BLKSCH02 I enter the selection as "M"
	Then I expect to be in the "BLKSCH03" Screen
	When I PressESC
		And I PressESC
	Then I expect to be in the "OLSBLK02" Screen

@winformsTest
@EnquiryTest
@ANZ_AUTO
@18458
@EN_E_CompanyOptions
Scenario: Test Case 18458: 07_Sub Systems (BLK) - Bulk Reporting Options
	# Enquiry System -Action BLK
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BLK   |
			| Locate Argument |       |
	Then I expect to be in the "OLSBLK01" Screen
	When In OLSBLK01 I enter the selection as "BRO"
	Then I expect to be in the "OLSB0602" Screen
	When In OLSB0602 I enter Report Type as "S"
	Then I expect to be in the "OLSB0603" Screen
	When In JOBSUB03 I enter Job Identification details as below:
			| Field            | Value |
			| OrderNbr         | 3001  |
			| OperatorInitials | NDF   |
	Then I expect to be in the "OLSB0604" Screen

