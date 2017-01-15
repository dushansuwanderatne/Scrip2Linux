Feature: ISX_Issue_System
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@ISXIssueSystem1
@ISXIssueSystem
Scenario Outline: ISXIssueSystem_Test1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01002 I update Issue Parameter Setup as
		| Action   | Action1   | OrderNumber   | OpsInitials   | RepDate   |
		| <Action> | <Action1> | <OrderNumber> | <OpsInitials> | <RepDate> |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action3> |
		And In ISX01005 I continue with the following details
		| Proceed   |  | Action    |
		| <Proceed> |  | <Action3> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action4> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action4> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action5> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action5> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action    |
		| <NightlyRunInd> | <Action6> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In HKS00201 I changed add the RundateTwo 
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "acceptance transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345353     | 2729.63    | ISX           | 0010        | M20       |                 | <HolderIdentifier1> | N             | B             |           | TEST1         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345354     | 1000.00    | ISX           | 0010        | M20       |                 | <HolderIdentifier2> | N             | M             |           | TEST2         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345355     | 39.16	   | ISX           | 0010        | M20       |                 | <HolderIdentifier3>  | N             | D             |           | TEST3         |             |
		And I exit to main from online system
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action |
		| <NightlyRunInd> |        |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	### Check AS Enquiry ####	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And I go to the Enquiry system and Search <HolderIdentifier1>
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier1>" "<ALine1>" "<ALine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier2>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier2>" "<ALine1>" "<BLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier3>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier3>" "<ALine1>" "<CLine2>"
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


Examples: 
	| ReportHeading | company  | Action | Action1 | RepDate    | OrderNumber | OpsInitials | Action3 | Proceed | NightlyRunInd | PassCriteria | timeout | FailCriteria | COY      | Action4 | ISXDir | Action5 | Action6 | SelCode | HolderIdentifier1 | HolderIdentifier2 | HolderIdentifier3 | Action7 | ALine1                                                                                  | ALine2                                                                                                                        | LocateArgument | Action8 | BLine2                                                                                                                        | CLine2                                                                                                                          | fileLocationVMS1 | OtherFile1 | OnlyCorporateActionFiles |
	| Test1         | ANZ_AUTO | 0010   | U       | 01/01/2020 | 5555        | NDF         | ICT     | PROCEED | Y             | completion   | 3600    | error        | ANZ_AUTO | ICN     | 0010   | ICB     | CONFIRM | RMNYI   | X0027783953       | C0000465917       | I0060071403       | AS      | ISX0010 NEW NORMAL ISX  ISSUE                                 Classes - E20,A20,M20,O20 | 19           3067                    3067           0           0        2729.63   Full Acceptance         0.00          0.00 |                | S       | 94            500                     500           0           0        1000.00   Accepted O/P          555.00          0.00 | 2620             44                      44           0           0          39.16   Full Acceptance         0.00          0.00 | [.ISX0010]       | Y          | Y                        |



@ISXIssueSystem2
@ISXIssueSystem
Scenario Outline: ISXIssueSystem_Test2
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01002 I update Issue Parameter Setup as
		| Action   | Action1   | OrderNumber   | OpsInitials   | RepDate   |
		| <Action> | <Action1> | <OrderNumber> | <OpsInitials> | <RepDate> |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action3> |
		And In ISX01005 I continue with the following details
		| Proceed   |  | Action    |
		| <Proceed> |  | <Action3> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action4> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action4> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action5> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action5> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action    |
		| <NightlyRunInd> | <Action6> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In HKS00201 I changed add the RundateTwo 
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "acceptance transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345359     | 1197.00    | ISX           | 0011        | M22       |                 | <HolderIdentifier1> | N             | B             |           | TEST1         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345360     | 13298.67   | ISX           | 0011        | M22       |                 | <HolderIdentifier2> | N             | L             |           | TEST2         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345361     | 131.67     | ISX           | 0011        | M22       |                 | <HolderIdentifier3>  | N             | D             |           | TEST3         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345362     | 665.00     | ISX           | 0011        | M22       |                 | <HolderIdentifier4>  | N             | D             |           | TEST4         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345363     | 767.74     | ISX           | 0011        | M22       |                 | <HolderIdentifier5>  | N             | D             |           | TEST5         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345364     | 66.50      | ISX           | 0011        | M22       |                 | <HolderIdentifier6>  | N             | D             |           | TEST6         |             |
		And I exit to main from online system
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action |
		| <NightlyRunInd> |        |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	### Check AS Enquiry ####	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And I go to the Enquiry system and Search <HolderIdentifier1>
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier1>" "<ALine1>" "<ALine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier2>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier2>" "<ALine1>" "<BLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier3>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier3>" "<ALine1>" "<CLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier4>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier4>" "<ALine1>" "<DLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier5>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier5>" "<ALine1>" "<ELine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier6>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier6>" "<ALine1>" "<FLine2>"
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


Examples: 
	| ReportHeading | company  | Action | Action1 | RepDate    | OrderNumber | OpsInitials | Action3 | Proceed | NightlyRunInd | PassCriteria | timeout | FailCriteria | COY      | Action4 | ISXDir | Action5 | Action6 | SelCode | HolderIdentifier1 | HolderIdentifier2 | HolderIdentifier3 | HolderIdentifier4 | HolderIdentifier5 | HolderIdentifier6 | Action7 | ALine1                                                                                          | ALine2                                                                                                                         | LocateArgument | Action8 | BLine2                                                                                                                         | CLine2                                                                                                                          | DLine2                                                                                                                           | ELine2                                                                                                                         | FLine2                                                                                                                           | fileLocationVMS1 | OtherFile1 | OnlyCorporateActionFiles |
	| Test1         | ANZ_AUTO | 0011   | U       | 01/01/2020 | 5555        | NDF         | ICT     | PROCEED | Y             | completion   | 3600    | error        | ANZ_AUTO | ICN     | 0011   | ICB     | CONFIRM | RMNYI   | I0012110405       | I0012745133       | X0051045513       | I0011894321       | X0021435911       | X0032747019       | AS      | ISX0011 NEW  ADDITIONAL , STANDARD ACC                        Classes - E22,A22,M22,AD1,MD1,O22 | 457           1008                     900         108           0        1197.00   Partial Accept          0.00          0.00 |                | S       | 510          13819                    9999        3820           0       13298.67   Full Acceptance         0.00          0.00 | 8854             99                      99           0           0         131.67   Full Acceptance         0.00          0.00 | 25937           1104                     498         606           0         665.00   Partial O/P             2.66          0.00 | 705            577                     577           0           0         767.74   Accepted O/P            0.33          0.00 | 13098             50                       0          50           0          66.50   Below Minimum          66.50          0.00 | [.ISX0011]       | Y          | Y                        |


@ISXIssueSystem3
@ISXIssueSystem
Scenario Outline: ISXIssueSystem_Test3
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01002 I update Issue Parameter Setup as
		| Action   | Action1   | OrderNumber   | OpsInitials   | RepDate   |
		| <Action> | <Action1> | <OrderNumber> | <OpsInitials> | <RepDate> |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action3> |
		And In ISX01005 I continue with the following details
		| Proceed   |  | Action    |
		| <Proceed> |  | <Action3> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action4> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action4> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action5> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action5> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action    |
		| <NightlyRunInd> | <Action6> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In HKS00201 I changed add the RundateTwo 
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "acceptance transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345372     | 10.52      | ISX           | 0012        | M23       |                 | <HolderIdentifier1> | N             | B             |           | TEST1         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345367     | 28.35      | ISX           | 0012        | M23       |                 | <HolderIdentifier2> | N             | L             |           | TEST2         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345368     | 73241.63   | ISX           | 0012        | M23       |                 | <HolderIdentifier3>  | N             | D             |           | TEST3         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345369     | 1252.38    | ISX           | 0012        | M23       |                 | <HolderIdentifier4>  | N             | D             |           | TEST4         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345370     | 876.4      | ISX           | 0012        | M23       |                 | <HolderIdentifier5>  | N             | D             |           | TEST5         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345371     | 525.9      | ISX           | 0012        | M23       |                 | <HolderIdentifier6>  | N             | D             |           | TEST6         |             |
		And I exit to main from online system
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action |
		| <NightlyRunInd> |        |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	### Check AS Enquiry ####	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And I go to the Enquiry system and Search <HolderIdentifier1>
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier1>" "<ALine1>" "<ALine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier2>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier2>" "<ALine1>" "<BLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier3>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier3>" "<ALine1>" "<CLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier4>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier4>" "<ALine1>" "<DLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier5>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier5>" "<ALine1>" "<ELine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier6>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier6>" "<ALine1>" "<FLine2>"
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


Examples: 
	| ReportHeading | company  | Action | Action1 | RepDate    | OrderNumber | OpsInitials | Action3 | Proceed | NightlyRunInd | PassCriteria | timeout | FailCriteria | COY      | Action4 | ISXDir | Action5 | Action6 | SelCode | HolderIdentifier1 | HolderIdentifier2 | HolderIdentifier3 | HolderIdentifier4 | HolderIdentifier5 | HolderIdentifier6 | Action7 | ALine1                                                                                    | ALine2                                                                                                                           | LocateArgument | Action8 | BLine2                                                                                                                           | CLine2                                                                                                                          | DLine2                                                                                                                           | ELine2                                                                                                                           | FLine2                                                                                                                           | fileLocationVMS1 | OtherFile1 | OnlyCorporateActionFiles |
	| Test3         | ANZ_AUTO | 0012   | U       | 01/01/2020 | 5555        | NDF         | ICT     | PROCEED | Y             | completion   | 3600    | error        | ANZ_AUTO | ICN     | 0012   | ICB     | CONFIRM | RMNYI   | I0012685262       | I0011136915       | I0013190097       | X0037133949       | X0007312733       | X0041231858       | AS      | ISX0012 NEW NORMAL RENOUNCEABLE , STD ACC                     Classes - E23,A23,M23,O23   | 58181             12                       0          12           0          10.52   Below Minimum          10.52          0.00 |                | S       | 58173            352                      32         320           0          28.35   Partial O/P             0.30          0.00 | 801          83571                    1500       82071           0       73241.63   Accepted O/P        71927.03          0.00  | 58157           1429                    1429           0           0        1252.38   Full Acceptance         0.00          0.00 | 58130           1507                    1000         507           0         876.40   Partial Accept          0.00          0.00 | 19238            600                     600           0           0         525.90   Accepted O/P            0.06          0.00 | [.ISX0012]       | Y          | Y                        |



@ISXIssueSystem4
@ISXIssueSystem
Scenario Outline: ISXIssueSystem_Test4
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01002 I update Issue Parameter Setup as
		| Action   | Action1   | OrderNumber   | OpsInitials   | RepDate   |
		| <Action> | <Action1> | <OrderNumber> | <OpsInitials> | <RepDate> |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action3> |
		And In ISX01005 I continue with the following details
		| Proceed   |  | Action    |
		| <Proceed> |  | <Action3> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   |
		| <NightlyRunInd> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action4> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action4> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
		And In ISX01001 I go to Issue Calculation Process 
		And In ISX01001 I continue with the following details
		| Action   |
		| <Action> |
		And In ISX01004 I continue with the following details
		| Action    |
		| <Action5> |
		And In ISX01005 I continue with the following details
		| Proceed   | Action    | COY   | ISXDir   |
		| <Proceed> | <Action5> | <COY> | <ISXDir> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria | timeout | FailCriteria |
		| completion   | 300     | error        |
	When I Go to the Mainmenu from System Setup Menu
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action    |
		| <NightlyRunInd> | <Action6> |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I check Active jobs 
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And In HKS00201 I changed add the RundateTwo 
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "acceptance transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345373     | 1492.40    | ISX           | 0013        | M24       |                 | <HolderIdentifier1> | N             | B             |           | TEST1         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier    | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345374     | 837.15     | ISX           | 0013        | M24       |                 | <HolderIdentifier2> | N             | L             |           | TEST2         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345375     | 546.00     | ISX           | 0013        | M24       |                 | <HolderIdentifier3>  | N             | D             |           | TEST3         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345376     | 565.20     | ISX           | 0013        | M24       |                 | <HolderIdentifier4>  | N             | D             |           | TEST4         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345377     | 12142.82   | ISX           | 0013        | M24       |                 | <HolderIdentifier5>  | N             | D             |           | TEST5         |             |
		And In OLS08601 I continue with the following details:
		| TransNumber | TotalMoney | SubsystemCode | SubsystemID | ClassCode | ReferenceNumber | HolderIdentifier     | ControlAccInd | PaymentSource | TransDate | CustomerRefNO | PaymentDate |
		| 5345378     | 7207.20    | ISX           | 0013        | M24       |                 | <HolderIdentifier6>  | N             | D             |           | TEST6         |             |
		And I exit to main from online system
		And In MNS00101 I click on: "reporting system" within the System Menu
		And In RSS00101 I click on: "schedule transaction reporting run" within the Reporting System Menu
		And In RSS25010 I Enter URR Parameter as:
		| NightlyRunInd   | Action |
		| <NightlyRunInd> |        |
	When I continue to the report submit page
		And In JOBSUB90 I submit the report for VMS and Linux
		| PassCriteria   | timeout   | FailCriteria   |
		| <PassCriteria> | <timeout> | <FailCriteria> |
		And I Submit Post URR Job
		| PostURRJob   | PassCriteria   | timeout   | FailCriteria   | COY   |
		| <PostURRJob> | <PassCriteria> | <timeout> | <FailCriteria> | <COY> |
	### Check AS Enquiry ####	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "<company>"
		And I go to the Enquiry system and Search <HolderIdentifier1>
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier1>" "<ALine1>" "<ALine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier2>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier2>" "<ALine1>" "<BLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier3>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier3>" "<ALine1>" "<CLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier4>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier4>" "<ALine1>" "<DLine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier5>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier5>" "<ALine1>" "<ELine2>"
	When I enter the following details as the Locate action "<Action8>" "<HolderIdentifier6>"
		And I enter the following details as the Locate action "<Action7>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HolderIdentifier6>" "<ALine1>" "<FLine2>"
		Then I copy URR files to local
		| ReportHeading   | FileName | OtherFile1   | fileLocationVMS1   | OtherFile2   | fileLocationVMS2   | fileLocationVLnx1   | OtherFileLnx1   | fileLocationVLnx2   | OtherFileLnx2   | OnlyCorporateActionFiles   |
		| <ReportHeading> |          | <OtherFile1> | <fileLocationVMS1> | <OtherFile2> | <fileLocationVMS2> | <fileLocationVLnx1> | <OtherFileLnx1> | <fileLocationVLnx2> | <OtherFileLnx2> | <OnlyCorporateActionFiles> |
		And I parse the files from VMS or Linux
		And I compare the files from VMS and Linux goldcopy


Examples: 
	| ReportHeading | company  | Action | Action1 | RepDate    | OrderNumber | OpsInitials | Action3 | Proceed | NightlyRunInd | PassCriteria | timeout | FailCriteria | COY      | Action4 | ISXDir | Action5 | Action6 | SelCode | HolderIdentifier1 | HolderIdentifier2 | HolderIdentifier3 | HolderIdentifier4 | HolderIdentifier5 | HolderIdentifier6 | Action7 | ALine1                                                                                            | ALine2                                                                                                                           | LocateArgument | Action8 | BLine2                                                                                                                           | CLine2                                                                                                                          | DLine2                                                                                                                           | ELine2                                                                                                                           | FLine2                                                                                                                           | fileLocationVMS1 | OtherFile1 | OnlyCorporateActionFiles |
	| Test4         | ANZ_AUTO | 0013   | U       | 01/01/2020 | 5555        | NDF         | ICT     | PROCEED | Y             | completion   | 3600    | error        | ANZ_AUTO | ICN     | 0013   | ICB     | CONFIRM | RMNYI   | X0053225195       | X0054003498       | I0012771479       | X0055483329       | I0012820305       | I0060049271       | AS      | ISX0013 NEW ADDITIONAL RENOUNCEABLE , NIL ACC                 Classes - E24,A24,M24,AD2,MD2,O24   | 1732            410                     410           0           0        1492.40   Full Acceptance         0.00          0.00  |                | S       | 1740            403                     230         173           0         837.15   Partial U/P             0.05-         0.00  | 2436            333                     150         183           0         546.00   Partial Accept          0.00          0.00 | 2444            155                     155           0           0         565.20   Accepted O/P            1.00          0.00  | 3148           3333                    3333           0           5       12142.82   Additional U/P          0.05-        10.70  | 2815           1979                    1979           0           1        7207.20   Additional O/P          1.49          3.64  | [.ISX0013]       | Y          | Y                        |






