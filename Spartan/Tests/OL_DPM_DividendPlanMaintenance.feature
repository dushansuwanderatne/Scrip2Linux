@setup_feature
Feature: OL_DPM_DividendPlanMaintenance
	Ensure DPM. Dividend Plan Maintenance functionality covered

@CPU_AUTO
@OL_DPM_DividendPlanMaintenance
@OL_Online
@winformsTest
Scenario: Add Dividend Intention -Partial
	# Dividend Intention -Partial
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I Go to Dividend Plan Maintenance Menu
		And I select "DIVIT" Transaction
	When I update the "partial" Dividend Intention as below:
			| Field      | Value       |
			| HIN        | I0100007762 |
			| Tran No    | 156         |
			| Tran Date  | 13/04/15    |
			| DRP Option | P           |
			| DRP Level  | 100         |
		And I go to the Enquiry system for "I0100007762"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DI    |
			| Locate Argument |       |
		Then In ENS01060 I should see holder Dividend Intention Details as below:
		| Field         | Value                                                                        |
		| HIN           | I0100007762                                                                  |
		| DRP Intention | DRP5  5   FP DRP       13/04/15            4402       156    P        100  N |

@winformsTest
@OL_Online
@CPU_AUTO
@OL_DPM_DividendPlanMaintenance
Scenario: Add Dividend Intention -Full
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I Go to Dividend Plan Maintenance Menu
		And I select "DIVIT" Transaction
	When I update the "full" Dividend Intention as below:
			| Field      | Value       |
			| HIN        | I0100007754 |
			| Tran No    | 157         |
			| Tran Date  | 13/04/15    |
			| DRP Option | F           |
		And I go to the Enquiry system for "I0100007754"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DI    |
			| Locate Argument |       |
		Then In ENS01060 I should see holder Dividend Intention Details as below:
		| Field         | Value                                                                        |
		| HIN           | I0100007754                                                                  |
		| DRP Intention | DRP5  5   FP DRP       13/04/15            4402       157    F             N |

@winformsTest
@OL_Online
@ANZ_AUTO
@21093
@21094
@OL_DPM_DividendPlanMaintenance
Scenario Outline: DividendplanIntention_Transactions
###Test Case 21093: 01 - OLS015 | Dividend and plan Intention Transactions - Add Dividend Plan Intention to a Holder ####
###Test Case 21094: 02 - OLS015 | Dividend and plan Intention Transactions - Modify Plan Intention for a Holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS01511 I continue with the following details:
		| Action   | SearchData   |
		| <Action> | <SearchData> |
		And In OLS01511 I continue with the following details:
		| Action    | SearchData    |
		| <Action1> | <SearchData1> |
		And In OLS01501 I continue with the following details:
		| TransNumber   | Date   | BspOpt1   | BspOpt2   | BspOpt3   | BspOpt4   | BspOpt5   | BspLev1   | BspLev2   | BspLev3   | BspLev4   | BspLev5   | DrpOpt1   | DrpOpt2   | DrpOpt3   | DrpOpt4   | DrpOpt5   | DrpLev1   | DrpLev2   | DrpLev3   | DrpLev4   | DrpLev5   | SourceOption   |
		| <TransNumber> | <Date> | <BspOpt1> | <BspOpt2> | <BspOpt3> | <BspOpt4> | <BspOpt5> | <BspLev1> | <BspLev2> | <BspLev3> | <BspLev4> | <BspLev5> | <DrpOpt1> | <DrpOpt2> | <DrpOpt3> | <DrpOpt4> | <DrpOpt5> | <DrpLev1> | <DrpLev2> | <DrpLev3> | <DrpLev4> | <DrpLev5> | <SourceOption> |
		And In OLS01502 I continue with the following details:
		| Confirm   |
		| <Confirm> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <SearchData>
		And I enter the following details as the Locate action "<Action2>" "<LocateArgument>"
	Then In ENS01060 I verify the following details:
	| BspLine1   | BspLine2   | BspLine3   | BspLine4   | BspLine5   | SourceOption   | DrpLine1  | DrpLine2   | DrpLine3   | DrpLine4   | DrpLine5   |
	| <BspLine1> | <BspLine2> | <BspLine3> | <BspLine4> | <BspLine5> | <SourceOption> | <DrpLine1> | <DrpLine2> | <DrpLine3> | <DrpLine4> | <DrpLine5> |

		
	Examples: 
		| Test  | SelCode | Action | SearchData  | Action1 | SearchData1 | TransNumber | Date | BspOpt1 | BspOpt2 | BspOpt3 | BspOpt4 | BspOpt5 | BspLev1 | BspLev2 | BspLev3 | BspLev4 | BspLev5 | DrpOpt1 | DrpOpt2 | DrpOpt3 | DrpOpt4 | DrpOpt5 | DrpLev1 | DrpLev2 | DrpLev3 | DrpLev4 | DrpLev5 | SourceOption | Confirm | Action2 | LocateArgument | BspLine1                                                                     | BspLine2 | BspLine3 | BspLine4 | BspLine5                               | DrpLine1                                                                     | DrpLine2                               | DrpLine3                               | DrpLine4                               | DrpLine5                               |
		| Test2 | DIVIT   | s      | X0049846177 | U       |             | 42421       |      | F       |         |         |         |         |         |         |         |         |         | N       |         |         |         |         | 20      |         |         |         |         | C            |         | DI      |                | BOP1  1   BOP                                                              Y |          |          |          | BOP5  5   BONUS PLAN   NON PARTICIPANT | 42421    N         20  N                                                     | DPN2  2   DRP PLAN     NON PARTICIPANT | DPN3  3   DRP PLAN     NON PARTICIPANT | DPN4  4   DRP PLAN     NON PARTICIPANT | DPN5  5   DRP PLAN     NON PARTICIPANT |
		| Test3 | DIVIT   | s      | X0027783953 | U       |             | 42422       |      | F       |         |         |         |         |         |         |         |         |         | P       |         |         |         |         | 50      |         |         |         |         | C            |         | DI      |                | BOP1  1   BOP                                                              Y |          |          |          | BOP5  5   BONUS PLAN   NON PARTICIPANT | 42422    P         50  N                                                     | DPN2  2   DRP PLAN     NON PARTICIPANT | DPN3  3   DRP PLAN     NON PARTICIPANT | DPN4  4   DRP PLAN     NON PARTICIPANT | DPN5  5   DRP PLAN     NON PARTICIPANT |
		
@winformsTest		
@OL_Online		
@ANZ_AUTO
@21097
@OL_DPM_DividendPlanMaintenance
Scenario Outline: Testcase21097_DPI_ErrorValidation
###Test Case 21097: 04 - OLS015 | Dividend and plan Intention Transactions - Error validations for OLS01501 ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS01511 I continue with the following details:
		| Action   | SearchData   |
		| <Action> | <SearchData> |
		And In OLS01511 I continue with the following details:
		| Action    | SearchData    |
		| <Action1> | <SearchData1> |
		And In OLS01501 I continue with the following details:
		| TransNumber   | Date   | BspOpt1   | BspOpt2   | BspOpt3   | BspOpt4   | BspOpt5   | BspLev1   | BspLev2   | BspLev3   | BspLev4   | BspLev5   | DrpOpt1   | DrpOpt2   | DrpOpt3   | DrpOpt4   | DrpOpt5   | DrpLev1   | DrpLev2   | DrpLev3   | DrpLev4   | DrpLev5   | SourceOption   |
		| <TransNumber> | <Date> | <BspOpt1> | <BspOpt2> | <BspOpt3> | <BspOpt4> | <BspOpt5> | <BspLev1> | <BspLev2> | <BspLev3> | <BspLev4> | <BspLev5> | <DrpOpt1> | <DrpOpt2> | <DrpOpt3> | <DrpOpt4> | <DrpOpt5> | <DrpLev1> | <DrpLev2> | <DrpLev3> | <DrpLev4> | <DrpLev5> | <SourceOption> |
	Then I should see the below ErrorMessage "<ErrorMessage>"		                                                                    

	Examples: 
		| Test  | SelCode | Action | SearchData  | Action1 | SearchData1 | TransNumber | Date | BspOpt1 | BspOpt2 | BspOpt3 | BspOpt4 | BspOpt5 | BspLev1 | BspLev2 | BspLev3 | BspLev4 | BspLev5 | DrpOpt1 | DrpOpt2 | DrpOpt3 | DrpOpt4 | DrpOpt5 | DrpLev1 | DrpLev2 | DrpLev3 | DrpLev4 | DrpLev5 | SourceOption | ErrorMessage                                       |
		| Test1 | DIVIT   | s      | X0023842165 | U       |             | 42423       |      | K       |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         | D            | Participation Option not valid for this plan       |
		| Test2 | DIVIT   | s      | X0023842165 | U       |             | 42423       |      | P       |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         | D            | A level MUST be entered for <P>artial participants |
		| Test3 | DIVIT   | s      | X0023842165 | U       |             | 42423       |      | W       |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         | D            | Invalid action - CANNOT withdraw this holder as    |
		| Test4 | DIVIT   | s      | X0023842165 | U       |             | 42423       |      | F       |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         | B            | Invalid action - to remove a holder from a plan    |
#		| Test5 | DIVIT   | s      | X0023842165 | U       |             |             |      |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |         |              | This field must be entered                         |

@winformsTest
@OL_Online
@ANZ_AUTO
@21334
@OL_DPM_DividendPlanMaintenance
Scenario Outline: Testcase21334_MNYIN_Transaction
###Test Case 21334: 01 - OLS050 and OLS051 | Plan Monetary Amount Changes  - Add MNYIN (Plan Money Increase) to a holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS05001 I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyPlan   | Buyer   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyPlan> | <Buyer> |
		And In OLS05002 I continue with the following details:
		| BuyPlan   | BuyPlanDesc   | BuyClass   | BuyClassDesc   | Buyer   | BuyDate   |
		| <BuyPlan> | <BuyPlanDesc> | <BuyClass> | <BuyClassDesc> | <Buyer> | <BuyDate> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <Buyer>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples: 
		| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyPlan | Buyer       | BuyPlanDesc | BuyClass | BuyClassDesc       | BuyDate    | Action | LocateArgument | CertificateLine1       | CertificateLine2                                                                    | CertificateLine3                                                                    | CertificateLine4                                                                     | CertificateLine5                                                                     | CertificateLine6                                                                    | CertificateLine7                                                                     | CertificateLine8                                                                    | CertificateLine9                             | CertificateLine10 |
		| Test1 | MNYIN   | 42423       |           | 500        | DRP1    | X0041248408 | DRP         | Z        | DRP RESIDUAL (ORD) |            | C      | /Z             | Z  /DRP RESIDUAL (ORD) |  500.00                                                                             | **** Total for MONEY L/OVER           500.00                                        |                                                                                      |                                                                                      |                                                                                     |                                                                                      |                                                                                     |                                              |                   |
		| Test2 | MNYIN   | 42424       |           | 1500.30    | DRP1    | I0012680295 | DRP         | Z        | DRP RESIDUAL (ORD) | 20/07/2015 | C      | /Z             | Z  /DRP RESIDUAL (ORD) | *MR MONEY L/OVER 18/12/08         10.20    *MR MONEY L/OVER 01/07/09           3.20 | *MR MONEY L/OVER 18/12/09         11.77-   *MR MONEY L/OVER 01/07/10           0.52 | *MR MONEY L/OVER 17/12/10         12.46    *MR MONEY L/OVER 01/07/11          10.36- | *MR MONEY L/OVER 16/12/11          7.11    *MR MONEY L/OVER 02/07/12           0.78- | *MR MONEY L/OVER 19/12/12         10.07-   *MR MONEY L/OVER 01/07/13          26.42 | *MR MONEY L/OVER 16/12/13          1.20-   *MR MONEY L/OVER 01/07/14          20.96- | *MR MONEY L/OVER 16/12/14         14.44    *MR MONEY L/OVER 20/07/15        1500.30 | **** Total for MONEY L/OVER          1519.51 |                   |

@winformsTest
@OL_Online
@ANZ_AUTO
@21335
@OL_DPM_DividendPlanMaintenance
Scenario Outline: Testcase21335_MNYDN_Transaction
###Test Case 21335: 02 - OLS050 and OLS051 | Plan Monetary Amount Changes  - Add MNYDN (Plan Money Decrease) to holder ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS05101 I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | SellPlan   | Seller   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <SellPlan> | <Seller> |
		And In OLS05102 I continue with the following details:
		| SellPlan   | SellPlanDesc   | SellClass   | SellClassDesc   | Seller   | SellDate   |
		| <SellPlan> | <SellPlanDesc> | <SellClass> | <SellClassDesc> | <Seller> | <SellDate> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <Seller>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01007 I should see Holding details as:
	| Last6Lines1   | Last6Lines2   | Last6Lines3   | Last6Lines4   | Last6Lines5   |
	| <Last6Lines1> | <Last6Lines2> | <Last6Lines3> | <Last6Lines4> | <Last6Lines5> |

	Examples: 
		| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | SellPlan | Seller      | SellPlanDesc | SellClass | SellClassDesc      | SellDate | Action | LocateArgument | Last6Lines1                                                              | Last6Lines2 | Last6Lines3 | Last6Lines4 | Last6Lines5 |
		| Test1 | MNYDN   | 42426       |           | 100.00     | DRP1     | I0060200335 | DRP          | Z         | DRP RESIDUAL (ORD) |          | H      | /Z             | *Z  /DRP RESIDUAL (ORD)      *MR        200.00                    200.00 |             |             |             |             |
		| Test2 | MNYDN   | 42427       |           | 320.50     | DRP1     | X0042573612 | DRP          | Z         | DRP RESIDUAL (ORD) |          | H      | /Z             | *Z  /DRP RESIDUAL (ORD)      *MR        886.32                    886.32 |             |             |             |             |    

@winformsTest
@OL_Online
@ANZ_AUTO
@21470
@OL_DPM_DividendPlanMaintenance
Scenario Outline: Testcase21470_MNYIN_ErrorValidation
###Test Case 21470: 03 - OLS050 and OLS051 | Plan Monetary Amount Changes  - Error Validations ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS05001 I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyPlan   | Buyer   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyPlan> | <Buyer> |
	Then I should see the below ErrorMessage "<ErrorMessage>"	

	Examples: 
		| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyPlan | Buyer       | ErrorMessage                                   |
		| Test1 | MNYIN   | 42428       |           | 80.50      | BOS1    |             | This plan is NOT a valid one for this company. |
		| Test2 | MNYIN   | 42428       |           | 80.50      | DRP1    | L0330468009 | Holder not an active participate in this plan  |

@winformsTest
@OL_Online
@ANZ_AUTO
@21470
@OL_DPM_DividendPlanMaintenance
Scenario Outline: Testcase21470_MNYDN_ErrorValidation
###Test Case 21470: 03 - OLS050 and OLS051 | Plan Monetary Amount Changes  - Error Validations ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS05101 I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | SellPlan   | Seller   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <SellPlan> | <Seller> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
		| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | SellPlan | Seller      | ErrorMessage                                       |
		| Test1 | MNYDN   | 42428       |           | 562000     | DRP1     | X0042573612 | There is not enough money for this holder.         |
		| Test2 | MNYDN   | 42428       |           | 10         | DRP1     | X0055926867 | This holder does not have any money on this class. |

@winformsTest
@OL_Online
@ANZ_AUTO
@21216
@OL_DPM_DividendPlanMaintenance
Scenario Outline: Testcase21216_ELCIN_Transaction
###Test Case 21216: 01 - OLS055 and OLS056 | Employee Loan Change Transactions - Add ELCIN Transaction for Loan and Refund Classes ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS05501 I continue with the following details:
		| TransNumber   | LodgeDate   | TotalUnits   | BuyClass   | Buyer   |
		| <TransNumber> | <LodgeDate> | <TotalUnits> | <BuyClass> | <Buyer> |
		And In OLS05502 I continue with the following details:
		| BuyClass   | BuyClassDesc   | BuyDate   | Buyer   |
		| <BuyClass> | <BuyClassDesc> | <BuyDate> | <Buyer> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <Buyer>
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01012 I should see Register details as:
	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |


	Examples: 
		| Test  | SelCode | TransNumber | LodgeDate | TotalUnits | BuyClass | Buyer       | BuyClassDesc                 | BuyDate    | Action | LocateArgument | CertificateLine1                 | CertificateLine2                                                                    | CertificateLine3                             | CertificateLine4                             | CertificateLine5                        | CertificateLine6                             | CertificateLine7 | CertificateLine8 | CertificateLine9 | CertificateLine10 |
		| Test1 | ELCIN   | 42429       |           | 250        | LLM      | I0032794041 | EMPLOYEE LOAN LANDMARK MONEY | 26/08/2015 | C      | /LLM           | LLM/EMPLOYEE LOAN LANDMARK MONEY |                                                                                     |                                              |                                              |                                         |                                              |                  |                  |                  |                   |
		| Test2 | ELCIN   | 42430       |           | 561        | LAR      | I0030123603 | EMPLOYEE LOAN AU REFUND      | 27/07/2015 | C      | /LAR           | LAR/EMPLOYEE LOAN AU REFUND      | *MR MONEY L/OVER 16/07/15        540.00    *MR MONEY L/OVER 19/07/15          32.00 | *MR MONEY L/OVER 27/07/15       1122.00      | **** Total for MONEY L/OVER          1694.00 | *MR 00000002     02/03/06          0.00 | **** Total for 00000002                 0.00 |                  |                  |                  |                   |
#		| Test3 | ELCIN   | 42431       |           | 230        | LLM      | X0010793068 | EMPLOYEE LOAN LANDMARK MONEY | 26/08/2015 | C      | /LLM           | LLM/EMPLOYEE LOAN LANDMARK MONEY |                                                                                     | **** Total for LOAN                   460.00 |                                              |                                         |                                              |                  |                  |                  |                   |
#		| Test4 | ELCIN   | 42432       |           | 100        | LAR      | X0010963591 | EMPLOYEE LOAN AU REFUND      | 27/07/2015 | C      | /LAR           | LAR/EMPLOYEE LOAN AU REFUND      | *MR MONEY L/OVER 23/07/15        350.00    *MR MONEY L/OVER 27/07/15         100.00 | **** Total for MONEY L/OVER           450.00 |                                              |                                         |                                              |                  |                  |                  |                   |
###commented the above two tests. need to fix the data

#@OL_Online
#@ANZ_AUTO
#@21229
#@OL_DPM_DividendPlanMaintenance
#Scenario Outline: Testcase21229_ELCDN_Transaction
####Test Case 21229: 02 - OLS055 and OLS056 | Employee Loan Change Transactions - Add ELCDN Transaction for Loan and Refund Classes ####
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "WES_AUTO"
#		And In MNS00101 I click on: "online data entry system" within the System Menu
#		And In OLS00101 I Click on: "dividend plan maintenance" with in the online data entry system menu
#		And In SELTRN20 I continue with the following details:
#		| SelCode   |
#		| <SelCode> |
#
#	Examples: 
#		| Test  | SelCode |
#		| Test1 | ELCDN   |







