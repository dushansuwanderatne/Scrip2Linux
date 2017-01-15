Feature: EN_PE_PaymentEnquirySystem
	Ensure EN_PE_PaymentEnquirySystem functionality covered

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_PE_PaymentEnquirySystem
@18380
@FullSmokeTest
Scenario: Test Case 18380: 01_Payment Enquiry System (PE Action)
	# Enquiry System -Action PE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Payment Enquiry System
		And I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | S     |
			| Locate Argument | 06FIN |
	Then In ENS02001 I should see Payment Enquiry details as below:
			| Field               | Value                                    |
			| PaymentAccountNbr   | 06FIN                                    |
			| PaymentDesc         | 06 FINAL DIV 7C UNFRANK RD8/9 PD 22/9/06 |
			| OriginalGrossAmount | 39285045.52                              |
			| OriginalNettAmount  | 39109408.52                              |
			| LowReferenceNbr     | 160448                                   |
			| HighReferenceNbr    | 90160450                                 |
			| NbrChqPresented     | 3                                        |
			| NbrChqCancelled     | 4                                        |
			| NbrDcPresented      | 573                                      |
			| NbrDcUnissued       |                                          |
			| NbrDcCancelled      | 2                                        |
			| NbrTotalPresented   | 576                                      |
			| NbrTotalUnissued    |                                          |
			| NbrTotalCancelled   | 6                                        |
			| NettChqPresented    | 1987.18                                  |
			| NettChqCancelled    | 555300.99                                |
			| NettDcPresented     | 9054923.04                               |
			| NettDcUnissued      |                                          |
			| NettDcCancelled     | 27019.77                                 |
			| NettTotalPresented  | 9056910.22                               |
			| NettTotalUnissued   |                                          |
			| NettTotalCancelled  | 582320.76                                |
	When I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | F     |
			| Locate Argument |       |
	Then In ENS02001 I should see Payment Enquiry details as below:
			| Field               | Value                                    |
			| PaymentAccountNbr   | 06FIN                                    |
			| PaymentDesc         | 06 FINAL DIV 7C UNFRANK RD8/9 PD 22/9/06 |
			| OriginalGrossAmount | 39285045.52                              |
			| OriginalNettAmount  | 39109408.52                              |
			| LowReferenceNbr     | 160448                                   |
			| HighReferenceNbr    | 90160450                                 |
			| NbrChqPresented     |                                          |
			| NbrChqCancelled     |                                          |
			| NbrDcPresented      | 10                                       |
			| NbrDcUnissued       |                                          |
			| NbrDcCancelled      |                                          |
			| NbrTotalPresented   | 10                                       |
			| NbrTotalUnissued    |                                          |
			| NbrTotalCancelled   |                                          |
			| NettChqPresented    |                                          |
			| NettChqCancelled    |                                          |
			| NettDcPresented     | 788.77                                   |
			| NettDcUnissued      |                                          |
			| NettDcCancelled     |                                          |
			| NettTotalPresented  | 788.77                                   |
			| NettTotalUnissued   |                                          |
			| NettTotalCancelled  |                                          |
	When I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | B     |
			| Locate Argument |       |
	Then In ENS02001 I should see Payment Enquiry details as below:
			| Field               | Value                                    |
			| PaymentAccountNbr   | 06FDE                                    |
			| PaymentDesc         | EMP DIV DEP/EXA 7C UF RD 8/09 PD 22/9/06 |
			| OriginalGrossAmount | 148659.77                                |
			| OriginalNettAmount  | 145466.77                                |
			| LowReferenceNbr     | 160461                                   |
			| HighReferenceNbr    | 160822                                   |
			| NbrChqPresented     |                                          |
			| NbrChqCancelled     |                                          |
			| NbrDcPresented      | 146                                      |
			| NbrDcUnissued       |                                          |
			| NbrDcCancelled      |                                          |
			| NbrTotalPresented   | 146                                      |
			| NbrTotalUnissued    |                                          |
			| NbrTotalCancelled   |                                          |
			| NettChqPresented    |                                          |
			| NettChqCancelled    | 3193.00                                  |
			| NettDcPresented     | 44687.89                                 |
			| NettDcUnissued      |                                          |
			| NettDcCancelled     |                                          |
			| NettTotalPresented  | 44687.89                                 |
			| NettTotalUnissued   |                                          |
			| NettTotalCancelled  | 3193.00                                  |

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_PE_PaymentEnquirySystem
@18384
Scenario: Test Case 18384: 03_Payment Enquiry System (PE) - Dual Currency -test1
	# Enquiry System -Action PE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Payment Enquiry System
		And I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | S     |
			| Locate Argument | 03FNZ |
	Then I expect to be in the "ENS02001" Screen
	When I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | D     |
			| Locate Argument |       |
	Then In ENS02002 I should see Dual Currency amounts as below:
			| Field              | Value    |
			| DualDcPresented    | 21279.15 |
			| DualDcCancelled    | 875.47   |
			| TotalDualPresented | 21279.15 |
			| TotalDualCancelled | 875.47   |

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_PE_PaymentEnquirySystem
@18384
Scenario: Test Case 18384: 03_Payment Enquiry System (PE) - Dual Currency -test2
	# Enquiry System -Action PE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Payment Enquiry System
		And I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | S     |
			| Locate Argument | 06FIN |
	Then I expect to be in the "ENS02001" Screen
	When I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | D     |
			| Locate Argument |       |
	Then I expect to see error with text "This account has NO dual currency."
		
@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_PE_PaymentEnquirySystem
@18488
Scenario: Test Case 18488: 03_Payment Enquiry System (PE) - Dual Currency - Error Message
	# Enquiry System -Action PE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Payment Enquiry System
		And I enter the following details in Payment Enquiry as the Locate action:
			| Field           | Value |
			| Action          | S     |
			| Locate Argument | X4VFR |
	Then I expect to see error with text "The code you are searching for is not on file."