Feature: OL_ST_SessionTotals
	Ensure OL_ST_SessionTotals Transaction functionality covered

@winformsTest
@OL_Online
@CPU_AUTO
@32413
@OL_ST_SessionTotals
@FullSmokeTest
Scenario Outline: TestCase 34645 Session Totals Verify Run Status Enquiry
###Test Case 34645: 01 -  Session Totals - Verify Run Status Enquiry ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And IN OLS00101 I continue with the following details:		
		| Selection   |
		| <Selection> |
		And IN SESTOT01 I continue with the following details:		
		| Option   | SessionNumber   |
		| <Option> | <SessionNumber> |
		And IN RUNSTS01 I continue with the following details:	
		| RunDate1   | Class1   | Class2   | Class3   | Class4   | Class5   | Desc1   | Desc2   | Desc3   | Desc4   | Desc5   | Constant11   | Constant12   | Constant13   | Constant14   | Constant15   | Ranges1   | Ranges2   | Ranges3   | Ranges4   | Ranges5   |
		| <RunDate1> | <Class1> | <Class2> | <Class3> | <Class4> | <Class5> | <Desc1> | <Desc2> | <Desc3> | <Desc4> | <Desc5> | <Constant11> | <Constant12> | <Constant13> | <Constant14> | <Constant15> | <Ranges1> | <Ranges2> | <Ranges3> | <Ranges4> | <Ranges5> |

	Examples: 
	| Test  | Selection | Option | RunDate1 | Class1 | Class2 | Class3 | Class4 | Class5 | Desc1                     | Desc2 | Desc3 | Desc4                          | Desc5 | Constant11     | Constant12     | Constant13     | Constant14     | Constant15     | Ranges1                    | Ranges2                    | Ranges3 | Ranges4                    | Ranges5                    | SessionNumber |
	| Test1 | ST        | r      |          | 001    |        |        | 002    |        | STONES - GEN REINVESTMENT |       |       | STONES ANZSEC BRK FRM REINVEST |       | Start of run.> | Current......> | Issued Capital | Start of run.> | Current......> | 00000000    (NS)      (NS) | 00000000    (NS)      (NS) | 0       | 00000000    (NS)      (NS) | 00000000    (NS)      (NS) |               |

@winformsTest
@OL_Online
@CPU_AUTO
@32413
@OL_ST_SessionTotals
Scenario Outline: TestCase 34646 Sessions Total Select a Session Number
###Test Case 34646: 02 - Sessions Total - Select a Session Number ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And IN OLS00101 I continue with the following details:		
		| Selection   |
		| <Selection> |
		And IN SESTOT01 I continue with the following details:		
		| Option   | SessionNumber   |
		| <Option> | <SessionNumber> |
		And IN SESTOT01 I verify the following details:
		| SessionNumber   |
		| <SessionNumber> |

	Examples: 
	| Test  | Selection | Option | SessionNumber |
	| Test1 | ST        | s      | 0099          |
	| Test2 | ST        | s      | 0141          |
	| Test3 | ST        | s      | 2244          |
	| Test4 | ST        | s      | 0551          |

@winformsTest
@OL_Online
@CPU_AUTO
@35090
@OL_ST_SessionTotals
Scenario Outline: Test Case 35090 Sessions Total Verify error
###Test Case 35090: 06 - Sessions Total - Verify error is given when no records for session is available
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And IN OLS00101 I continue with the following details:		
		| Selection   |
		| <Selection> |
		And IN SESTOT01 I continue with the following details:		
		| Option   | SessionNumber   |
		| <Option> | <SessionNumber> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | Selection | Option | SessionNumber | ErrorMessage                     |
	| Test1 | ST        | d      | 0044          | There are NO records on file for |

@winformsTest
@OL_Online
@CPU_AUTO
@34648
@OL_ST_SessionTotals
@FullSmokeTest
Scenario Outline: TestCase 34648 Display Session Totals
###Test Case 34648: 04 - Sessions Total - Display Session Totals ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And IN OLS00101 I continue with the following details:		
		| Selection   |
		| <Selection> |
		And IN SESTOT01 I continue with the following details:		
		| Option   | SessionNumber   |
		| <Option> | <SessionNumber> |
		And IN SESTOT01 I verify the following details:
		| SessionNumber   |
		| <SessionNumber> |
		And I PressESC
		And In OLS00101 I Click on: "static detail" with in the online data entry system menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS01201 I Change Holder Name as:
		| Action3   | TransNbrI   | HnaLineCh1to30R   |
		| <Action3> | <TransNbrI> | <HnaLineCh1to30R> |
		And I PressESC
		And I PressESC
		And IN OLS00101 I continue with the following details:		
		| Selection   |
		| <Selection> |
		And IN SESTOT01 I continue with the following details:		
		| Option    | SessionNumber   |
		| <Option1> | <SessionNumber> |
		And IN SESTOT02 I verify with the following details:
		| TransCode1   | TransDesc1   | Units1   | Entries1   | TransCode2   | TransDesc2   | Units2   | Entries2   |
		| <TransCode1> | <TransDesc1> | <Units1> | <Entries1> | <TransCode2> | <TransDesc2> | <Units2> | <Entries2> |

	Examples: 
	| Test  | Selection | Option | SessionNumber | Action | UpdateOption | Action1 | UpdateOption1 | Action3 | TransNbrI | HnaLineCh1to30R        | Option1 | TransCode1 | TransDesc1                    | Units1 | Entries1 | TransCode2 | TransDesc2          | Units2 | Entries2 |
	| Test1 | ST        | s      | 0014          | F      |              | U       | NA            | M       | 42338     | Display Session Totals | d       | RXAUD      | NAME & ADDRESS (AUDIT MODIFY) |        | 1        |            | End of transactions |        | 1        |


