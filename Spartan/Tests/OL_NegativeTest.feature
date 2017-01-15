Feature: OL_NegativeTest
	Ensure OL_NegativeTest functionality covered

@winformsTest
@OL_NegativeTest
@17477
@NAB_AUTO
Scenario Outline: Test Case 18133: 05 - Search by Holder not on Files
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Static Details Menu
		And OLS01101 I Search the holder as "<SearchData>"
	#Then I should see the below ErrorMessage "Enter a Holder ID or Holder Name for a search"
	Then I should see the below ErrorMessage "<ErrorMessage>"		

Examples: 
		| Test  | ErrorMessage                                   | SearchData |
		| Test1 | Enter a Holder ID or Holder Name for a search  |            |
		| Test2 | The code you are searching for is not on file. | C19        |
		| Test3 | The code you are searching for is not on file. | C345345    |
		| Test4 | The code you are searching for is not on file. | ^&$%&^     |

@winformsTest
@OL_NegativeTest
@20162
@CPU_AUTO
@FullSmokeTest
Scenario: Test Case 20162: 01 - Charity Election(CY) - Add when Company is not enable for charity
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option as below:
		| Field        | Value       |
		| Action       | S           |
		| UpdateOption | X0028384483 |
		And In OLS01101 I enter following details as the update option as below:
		| Field        | Value |
		| Action       | U     |
		| UpdateOption | CY    |
	Then I expect to see error with text "This company does NOT process Charity Elections."

@winformsTest
@OL_NegativeTest
@20164
@ANZ_AUTO
Scenario: Test Case 20164: 02 - Charity Election (CY) -Add  to a holder without any holdings
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option as below:
		| Field        | Value       |
		| Action       | S           |
		| UpdateOption | I7777777704 |
		And In OLS01101 I enter following details as the update option as below:
		| Field        | Value |
		| Action       | U     |
		| UpdateOption | CY    |
	Then I expect to see error with text "This holder does not hold any class(es) that can"

@winformsTest
@OL_NegativeTest
@20168
@ANZ_AUTO
Scenario Outline: Test Case 20168: 03 - Charity Election(CY) - Error messages related to class on OLS03501 form
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01101 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS03501 I Enter Action Details as "<Action2>" "<ActionClass>"
	Then I should see the below ErrorMessage "<ErrorMessage>"
Examples: 
		| Test  | Action | UpdateOption | Action1 | UpdateOption1 | Action2 | ActionClass | ErrorMessage                                            |
		| Test1 | S      | X0058145238  | U       | CY            | A       | EXS         | Class not enabled for Charity Elections.                |
		| Test2 | S      | X0058145238  | U       | CY            | A       | DEF         | Holder does not have/had shares in the nominated class. |
		| Test3 | S      | X0058145238  | U       | CY            | A       | ORD         | Charity Election already exists for this class.         |
		| Test4 | S      | X0058145238  | U       | CY            | A       | AAA         | Class does not exist on CLSCDE.                         |
		| Test5 | S      | X0058145238  | U       | CY            | A       |             | Class must be entered.                                  |
		| Test6 | S      | X0058145238  | U       | CY            | U       |             | Class must be entered.                                  |
		| Test7 | S      | I0012857535  | U       | CY            | U       | ORD         | Charity Election does not exist for the entered class.  |

#@OL_NegativeTest
#@20454
#@NAB_AUTO
#Scenario Outline: Test Case 20454: 01 - Load,Change & Generated FIN - Error messages validation for invlaid Company & Holder
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company as "<COY>"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 		   
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#	Then I should see the below ErrorMessage "<ErrorMessage>"		
#Examples: 
#		| Test  | COY      | Action | UpdateOption | Action1 | UpdateOption1 | ErrorMessage                                 |
#		| Test1 | NAB_AUTO | S      | X0054356552  | U       | FG            | Invalid Update Option - use one of : NA, AH, |
#		| Test2 | NAB_AUTO | S      | X0054356552  | U       | FL            | Invalid Update Option - use one of : NA, AH, |
#		| Test3 | NAB_AUTO | S      | X0054356552  | U       | FC            | Invalid Update Option - use one of : NA, AH, |
#		| Test4 | ANZ_AUTO | S      | X0046311183  | U       | FG            | Invalid Update Option - use one of : NA, AH, |
#		| Test5 | ANZ_AUTO | S      | X0046311183  | U       | FL            | Invalid Update Option - use one of : NA, AH, |
#		| Test6 | ANZ_AUTO | S      | X0046311183  | U       | FC            | Invalid Update Option - use one of : NA, AH, |

@winformsTest
@OL_NegativeTest
@20457
@ANZ_AUTO
Scenario Outline: Test Case 20457: 08 - Load, Change & Generate FIN - Error Validation for Load CSN FIN (OLS01630)
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 	
		And In OLS01630 I Enter CSN FIN Details as "<Tran>" "<HIN>" "<LoadFIN>" "<ValidateFIN>"
	Then I should see the below ErrorMessage "<ErrorMessage>"	

Examples: 
		| UpdateOption | Action | Action1 | UpdateOption1 | Tran  | LoadFIN | ValidateFIN | ErrorMessage                          |
		| L0332849123  | S      | U       | FL            | 29300 | 123     |             | New FIN does not equal re-entered FIN |
		| L0332849123  | S      | U       | FL            | 29300 |         | 236         | New FIN does not equal re-entered FIN |
		| L0332849123  | S      | U       | FL            | 29300 | 235     | 236         | New FIN does not equal re-entered FIN |

@winformsTest
@OL_NegativeTest
@20459
@ANZ_AUTO
Scenario Outline: Test Case 20459: 05 - Load, Change & Generate FIN - Error Validation for Change FIN (OLS01610)
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
		And In OLS01610 I Change FIN details as "<Tran>" "<OldFIN>" "<NewFIN>" "<ValidateFIN>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Test  | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | OldFIN | NewFIN | ValidateFIN | ErrorMessage                         |
		| Test1 | L0332187643  | S      | U       | FC            | 29300 |        |        |             | Old FIN number invalid               |
		| Test2 | L0332187643  | S      | U       | FC            | 29300 | 112    | 1      |             | FIN does not match verification.     |
		| Test3 | L0332187643  | S      | U       | FC            | 29300 | 112    |        | 123         | New FIN number is zero               |
		| Test4 | L0332187643  | S      | U       | FC            | 29300 | 112    | 112    | 123         | FIN does not match verification.     |
		| Test5 | L0332187643  | S      | U       | FC            | 29300 | 112    | 112    |             | FIN does not match verification.     |
		| Test6 | L0332187643  | S      | U       | FC            | 29300 | 55     | 112    | 112         | Old FIN number invalid               |

#@ignore
#@OL_NegativeTest
#@20460
#@ANZ_AUTO
#Scenario Outline: Test Case 20460: 06 - Load, Change & Generate FIN - Error Validation for Generate New FIN (OLS01620)
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Static Details Menu
#		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
#		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
#		And In OLS01620 I Generate new FIN as "<Tran>" "<GenerateFIN>"
#	Then I should see the below ErrorMessage "<ErrorMessage>"
#
#Examples: 
#		| Test  | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | GenerateFIN | ErrorMessage              |
#		| Test1 | L0331621781  | S      | U       | FG            | 29300 |             | Please enter either: N, Y |
#		| Test2 | L0331621781  | S      | U       | FG            | 29300 | X           | Please enter either: N, Y |  

@winformsTest
@OL_NegativeTest
@20733
@ANZ_AUTO
Scenario Outline: Test Case 20733: 02 - Overseas Wire Instruction (WR) - Error Validation for Form OLS04204
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>" 
		And In OLS04204 I add Wire Instructions as "<Tran>" "<CountryCode>" "<SWIFTCode>" "<AccountNumber>" "<AccountName>" "<PaymentCurrency>" "<BankCode>" "<BankName>" "<BankAddress1>" "<BankAddress2>" "<BankAddress3>" "<BankAddress4>" "<Phone>"
	Then I should see the below ErrorMessage "<ErrorMessage>"
Examples: 
		| Test  | CountryCode | UpdateOption | Action | Action1 | UpdateOption1 | Tran  | SWIFTCode   | AccountNumber          | AccountName | PaymentCurrency | BankCode | BankName | BankAddress1 | BankAddress2 | BankAddress3 | BankAddress4 | ErrorMessage                                 |
		| Test1 | GB          | X0044348586  | S      | U       | WR            | 29607 |             |                        |             | GBP             |          |          |              |              |              |              | BIC must be entered                          |
		| Test2 | GB          | X0044348586  | S      | U       | WR            | 29607 | 123         |                        |             | GBP             |          |          |              |              |              |              | SWIFT code must be 8 or 11 characters        |
		| Test3 | GB          | X0044348586  | S      | U       | WR            | 29607 | RBSGB121    |                        |             | GBP             |          |          |              |              |              |              | SWIFT code contains invalid characters       |
		| Test4 | GB          | X0044348586  | S      | U       | WR            | 29607 | RBOSGB12345 |24234234                |             | GBP             |          |          |              |              |              |              | IBAN validation cannot be performed          |
		| Test5 | GB          | X0044348586  | S      | U       | WR            | 29607 | RBOSGB12345 |                        |             | GBP             | 123546   |          |              |              |              |              | Bank code not on file                        |
		| Test6 | GB          | X0044348586  | S      | U       | WR            | 29607 | RBOSGB12345 |                        |             | GBP             | 111111   |          |              |              |              |              | IBAN must be entered                         |
### Test4 needs a find new data. 


@winformsTest
@OL_NegativeTest
@20707
@WES_AUTO
Scenario Outline: Test Case 20707: 01 - Unconfirmed Deceased (UD) - not allowed with Holder Type COY
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In Online Data Entry System I enter search option as "<Action>" "<UpdateOption>" 
		And In Online Data Entry System I enter search option as "<Action1>" "<UpdateOption1>"
	Then I should see the below ErrorMessage "<ErrorMessage>"
Examples: 
		| UpdateOption | Action | Action1 | UpdateOption1 | ErrorMessage                                    |
		| X0032957455  | S      | U       | UD            | Cannot perform this transaction for COY Holders |
		| I0130613497  | S      | U       | UD            | Cannot perform this transaction for COY Holders |

@winformsTest	
@CPU_AUTO
@30716
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 30716: 03 - OLS030 | Verify Lost SRN Replacement (ISLST) Warning Message
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "uncertificated transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLS03001 I continue with the following details:
		| TranNumber   | FromNameKey   |
		| <TranNumber> | <FromNameKey> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

 Examples: 
		| Test  | SelCode | TranNumber | FromNameKey | ErrorMessage                                           |
		| Test1 | ISLST   | 12222      | X0065502925 | Holder "X0065502925" is not an Issuer Sponsored holder |
		| Test2 | ISLST   | 12222      | C0000001698 | Holder "C0000001698" is not an Issuer Sponsored holder |

@winformsTest	
@WES_AUTO
@19400
@OL_SDM_StaticDetailMaintenance
Scenario Outline:Test Case 19400: 05 - Confirmed Deceased (CD) - Error Validations for Deceased Status (OLS06801)
Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS06801 I enter below for negative tests
		| KnownName1   | KnownStatus1   | TransNumber |
		| <KnownName1> | <KnownStatus1> | <Trans>     |

	Then I should see the below ErrorMessage "<ErrorMessage>"
Examples: 
		| Action | UpdateOption | Action1 | UpdateOption1 | Trans | KnownStatus1 | ErrorMessage                                           |
		| S      | I0131544880  | U       | CD            | 2222  | S            | Please enter either: <space>, C, U                     |
		| S      | I0131544880  | U       | CD            | 2222  |              | Please reverse Unconfirmed Deceased with a UD transaction. |



@winformsTest	
@WES_AUTO
@20606
@OL_SDM_StaticDetailMaintenance
Scenario Outline:Test Case 20606: 02 - ZAF Taxpayer Details(ZA) - Error Message Validations OLS02901
    Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "<Action>" "<UpdateOption>"
		And In OLS01102 I enter following details as the update option "<Action1>" "<UpdateOption1>"
		And In OLS02901 I enter Nature Of Person as follows
		| INNatureOFPerson   |
		| <INNatureOFPerson> |
	    And In OLS02901 I enter all the following details 
		| TransNumber   | CustodianReference   | IntermediaryInd   | OtherStatus   | TaxCode   | TradingName1   | BenAddrName   | BenAddrLine1   | BenAddrLine2   | BenAddrLine3   | BenAddrLine4   | BenAddrLine5   | BenAddrPC   | TaxReference   | TaxRefType   | IDReference   | IDReferenceType   | DateBirth   | Phone   | Email   | RetName   | RetLine1   | RetLine2   | RetLine3   | RetLine4   | RetLine5   | RetAddrPC   | ExemptionCode   | ExemptionCodeDesc   | CtryOFIssue   | CertStatus   | CertStatusDesc   | DecName   | DecCapCode   | DecCapacity   | DecDate   | UndName   | UndCapCode   | UndCapacity   | UndDate   | SigDate   |   
		| <TransNumber> | <CustodianReference> | <IntermediaryInd> | <OtherStatus> | <TaxCode> | <TradingName1> | <BenAddrName> | <BenAddrLine1> | <BenAddrLine2> | <BenAddrLine3> | <BenAddrLine4> | <BenAddrLine5> | <BenAddrPC> | <TaxReference> | <TaxRefType> | <IDReference> | <IDReferenceType> | <DateBirth> | <Phone> | <Email> | <RetName> | <RetLine1> | <RetLine2> | <RetLine3> | <RetLine4> | <RetLine5> | <RetAddrPC> | <ExemptionCode> | <ExemptionCodeDesc> | <CtryOFIssue> | <CertStatus> | <CertStatusDesc> | <DecName> | <DecCapCode> | <DecCapacity> | <DecDate> | <UndName> | <UndCapCode> | <UndCapacity> | <UndDate> | <SigDate> |

	Then I should see the below ErrorMessage "<ErrorMessage>"

 Examples: 
 		| Action | UpdateOption | Action1 | UpdateOption1 | INNatureOFPerson | TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | TradingName1 | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | TaxReference | TaxRefType | IDReference | IDReferenceType | DateBirth  | Phone | Email | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | ExemptionCode | ExemptionCodeDesc | CtryOFIssue | CertStatus | CertStatusDesc | DecName | DecCapCode | DecCapacity | DecDate    | UndName | UndCapCode | UndCapacity | UndDate    | SigDate | ErrorMessage                                       |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             |         |              |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Country of Tax Residence must be entered           |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | ABC     |              |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Domicile/Tax code not on file                      |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 | ABC         | NZL     |              |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Internal Status entered in not a valid status      |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    | A               |             | NZL     |              |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Please enter either: <space>, N, Y                 |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Tax Reference must be populated                    |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Tax Reference Type must be populated if            |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | ABC        |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Unknown Tax Reference Type supplied                |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | AV11111      | TFN        |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Tax Reference must be numeric                      |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Date of Birth must be populated                    |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 | 01/01/1980 |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Declaration Name must be populated                 |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 | 01/01/1980 |       |       |         |          |          |          |          |          |           |               |                   |             |            |                | Test    |            |             |            |         |            |             |            |         | Declaration Date must be populated                 |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 | 01/01/1980 |       |       |         |          |          |          |          |          |           |               |                   |             |            |                | Test    | IPL        |             | 01/01/2015 |         |            |             |            |         | Declaration Capacity entered in not valid          |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 | 01/01/1980 |       |       |         |          |          |          |          |          |           | K             |                   |             |            |                | Test    |            |             | 01/01/2015 |         |            |             |            |         | Exemption Code entered in not valid                |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 | 01/01/1980 |       |       |         |          |          |          |          |          |           |               |                   | KKK         |            |                | Test    |            |             | 01/01/2015 |         |            |             |            |         | The Country of Issue entered is not valid          |
 		| S      | I0010342449  | U       | ZA            | I                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           | 11111        | TFN        |             |                 | 01/01/1980 |       |       |         |          |          |          |          |          |           |               |                   |             | UNM        |                | Test    |            |             | 01/01/2015 |         |            |             |            |         | Certification Status entered in not a valid status |
 		| S      | I0010342449  | U       | ZA            | P                | 8010        |                    |                 |             | NZL     |              |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                |         |            |             |            |         |            |             |            |         | Trading Name is mandatory when the                 |
 		| S      | I0010342449  | U       | ZA            | P                | 8010        |                    |                 |             | NZL     | Test         |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                | Test    |            |             | 01/01/2015 |         |            |             |            |         | Undertaking Name must be populated                 |
 		| S      | I0010342449  | U       | ZA            | P                | 8010        |                    |                 |             | NZL     | Test         |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                | Test    |            |             | 01/01/2015 | UTest   |            |             |            |         | Undertaking Date must be populated                 |
 		| S      | I0010342449  | U       | ZA            | P                | 8010        |                    |                 |             | NZL     | Test         |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                | Test    |            |             | 01/01/2015 | UTest   | OPO        |             |            |         | Undertaking Capacity entered in not valid          |
 		| S      | I0010342449  | U       | ZA            | P                | 8010        |                    |                 |             | NZL     | Test         |             |              |              |              |              |              |           |              |            |             |                 |            |       |       |         |          |          |          |          |          |           |               |                   |             |            |                | Test    |            |             | 01/01/2015 | UTest   |            |             | 01/02/2015 |         | Signature Date must be populated                   |


@winformsTest	
@WES_AUTO
@19657
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 19657: 03 - IRL Taxpayer Details (IR) - Error Message Validations OLS02801
 	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Static Details Menu
		And In OLS01101 I enter following details as the update option "S" "I0010342449"
		And In OLS01102 I enter following details as the update option "U" "IR"
		And In OLS02801 I enter Enity Type "<EnityType>"
		And In OLS02801 I enter all the following details 
		| TransNumber   | CustodianReference   | IntermediaryInd   | OtherStatus   | TaxCode   | MailAddrName   | MailAddrLine1   | MailAddrLine2   | MailAddrLine3   | MailAddrLine4   | MailAddrLine5   | MailAddrPostcode   | BenAddrName   | BenAddrLine1   | BenAddrLine2   | BenAddrLine3   | BenAddrLine4   | BenAddrLine5   | BenAddrPC   | RetName   | RetLine1   | RetLine2   | RetLine3   | RetLine4   | RetLine5   | RetAddrPC   | TaxReference   | TaxRefType   | DateBirth   | PrevName   | DwtExpiryCcyy   | SigName   | SigCapType   | SigDate   | SigPhone   | CertFileRef   | CertStatus   | CertDwtRef   |
		| <TransNumber> | <CustodianReference> | <IntermediaryInd> | <OtherStatus> | <TaxCode> | <MailAddrName> | <MailAddrLine1> | <MailAddrLine2> | <MailAddrLine3> | <MailAddrLine4> | <MailAddrLine5> | <MailAddrPostcode> | <BenAddrName> | <BenAddrLine1> | <BenAddrLine2> | <BenAddrLine3> | <BenAddrLine4> | <BenAddrLine5> | <BenAddrPC> | <RetName> | <RetLine1> | <RetLine2> | <RetLine3> | <RetLine4> | <RetLine5> | <RetAddrPC> | <TaxReference> | <TaxRefType> | <DateBirth> | <PrevName> | <DwtExpiryCcyy> | <SigName> | <SigCapType> | <SigDate> | <SigPhone> | <CertFileRef> | <CertStatus> | <CertDwtRef> |

	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| EnityType | TransNumber | CustodianReference | IntermediaryInd | OtherStatus | TaxCode | MailAddrName | MailAddrLine1 | MailAddrLine2 | MailAddrLine3 | MailAddrLine4 | MailAddrLine5 | MailAddrPostcode | BenAddrName | BenAddrLine1 | BenAddrLine2 | BenAddrLine3 | BenAddrLine4 | BenAddrLine5 | BenAddrPC | RetName | RetLine1 | RetLine2 | RetLine3 | RetLine4 | RetLine5 | RetAddrPC | TaxReference | TaxRefType | DateBirth | PrevName | DwtExpiryCcyy | SigName | SigCapType | SigDate    | SigPhone | CertFileRef | CertStatus | CertDwtRef | ErrorMessage                                       |
		| IND       | 9006        |                    |                 |             |         |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Country of Tax Residence must be entered           |
		| IND       | 9006        |                    |                 |             | OOO     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Domicile/Tax code not on file                      |
		| IND       | 9006        | 111                |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Custodian Ref not found                            |
		| IND       | 9006        |                    |                 | PPP         | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Internal Status entered in not a valid status      |
		| IND       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Tax Reference must be populated                    |
		| IND       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      |            |           |          |               |         |            |            |          |             |            |            | Tax Reference Type must be populated if            |
		| IND       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | MMM        |           |          |               |         |            |            |          |             |            |            | Tax Reference Type must be TFN                     |
		| IND       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | TFN        |           |          |               |         |            |            |          |             |            |            | Date of Birth must be populated                    |
		| IND       | 9006        |                    |                 |             | NZL     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | TFN        |           |          |               |         |            |            |          |             |            |            | Tax Reference Type must be IRD                     |
		| IND       | 9006        |                    |                 |             | NZL     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | A111111      | IRD        |           |          |               |         |            |            |          |             |            |            | Tax Reference must be numeric                      |
		| IND       | 9006        |                    |                 |             | NZL     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | IRD        |           |          |               |         |            |            |          |             |            |            | Internal Status or Certification Status            |
		| IND       | 9006        |                    |                 |             | USA     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | A111111      | TFN        |           |          |               |         |            |            |          |             |            |            | Tax Reference Type must be TRN                     |
		| COY       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Internal Status or Certification Status            |
		| COY       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             | MMM        |            | Certification Status entered in not a valid status |
		| COY       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          | 2015          |         |            | 31/05/2015 |          |             | UNC        |            | DWT Expiry Date not 5 years from Signatory Date    |
		| PRT       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Tax Reference must be populated                    |
		| PRT       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | TFN        |           |          |               |         |            |            |          |             |            |            | Signatory Name must be populated                   |
		| PRT       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | TFN        |           |          |               | Test    |            |            |          |             |            |            | Signatory Capacity must be populated               |
		| PRT       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           | 1111111      | TFN        |           |          |               | Test    | PPP        |            |          |             |            |            | Capacity Type entered in not a valid type          |
		| TST       | 9006        |                    |                 |             | AUS     |              |               |               |               |               |               |                  |             |              |              |              |              |              |           |         |          |          |          |          |          |           |              |            |           |          |               |         |            |            |          |             |            |            | Tax Reference must be populated                    |


@winformsTest	
@WES_AUTO
@29743
@OL_SDM_StaticDetailMaintenance
Scenario Outline: Test Case 29743: 02 - OLSCRT | DSURC - CERT DECD SURVIVORSHIP Transaction- Error Validations for OLSCRTBF
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "standard transactions" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And IN OLSCRTSC I continue with the following details:
		| TransNumber   | TotalUnits   | SellClass   | SellCertID   | SellHolderID   | SellReg   | SellBroker   |
		| <TransNumber> | <TotalUnits> | <SellClass> | <SellCertID> | <SellHolderID> | <SellReg> | <SellBroker> |
		And IN OLSCRTTC I continue with the following details:
		| SellCert1   | SellCert2   | SellCert3   | SellCert4   | SellCert5   | SellUnits1   | SellUnits2   | SellUnits3   | SellUnits4   | SellUnits5   | BuyReg   | BuyBroker   | BuySearchName   | BuyReference   |
		| <SellCert1> | <SellCert2> | <SellCert3> | <SellCert4> | <SellCert5> | <SellUnits1> | <SellUnits2> | <SellUnits3> | <SellUnits4> | <SellUnits5> | <BuyReg> | <BuyBroker> | <BuySearchName> | <BuyReference> |
		And IN OLSCRTBF I continue with the following details:
		| TransferUnits   | BuyTransDate   | BuyCertID   | BuyInstructions1   | BuyInstructions2   | BuyInstructions3   | BuyInstructions4   | BuyInstructions5   | BuySplitNbr1to51   | BuySplitNbr1to52   | BuySplitUnits1to51   | BuySplitUnits1to52   | HoldBalance   | MarkingNumber   | ReissueBal   | ReissTOSellBroker   | BuySplitUnits1to53   | BuySplitNbr1to53   |
		| <TransferUnits> | <BuyTransDate> | <BuyCertID> | <BuyInstructions1> | <BuyInstructions2> | <BuyInstructions3> | <BuyInstructions4> | <BuyInstructions5> | <BuySplitNbr1to51> | <BuySplitNbr1to52> | <BuySplitUnits1to51> | <BuySplitUnits1to52> | <HoldBalance> | <MarkingNumber> | <ReissueBal> | <ReissTOSellBroker> | <BuySplitUnits1to53> | <BuySplitNbr1to53> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | SelCode | TransNumber | TotalUnits | SellClass | SellCertID | SellHolderID | SellReg | SellBroker | SellCert1 | SellCert2 | SellCert3 | SellCert4 | SellCert5 | SellUnits1 | SellUnits2 | SellUnits3 | SellUnits4 | SellUnits5 | BuyReg | BuyBroker | BuySearchName | BuyReference | TransferUnits | BuyTransDate | BuyCertID | BuyInstructions1 | BuyInstructions2 | BuyInstructions3 | BuyInstructions4 | BuyInstructions5 | BuySplitNbr1to51 | BuySplitNbr1to52 | BuySplitUnits1to51 | BuySplitUnits1to52 | HoldBalance | MarkingNumber | ReissueBal | ReissTOSellBroker | BuySplitUnits1to53 | BuySplitNbr1to53 | ErrorMessage                              |
	| Test1 | DSURC   | 8815        | 350        | ORD       | W152434    |              | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    |           | C0000465922   |              | 500           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |             |               |            |                   |                    |                  | Transfer units + hold units + reissue bal |
	| Test2 | DSURC   | 8815        | 350        | ORD       | W152434    |              | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    |           | C0000465922   |              | 300           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    | 50          |               |            |                   |                    |                  | Must enter a value                        |
	| Test3 | DSURC   | 8815        | 350        | ORD       | W152434    |              | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    |           | C0000465922   |              | 300           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    | 50          | dfadsfa       |            |                   |                    |                  | Invalid certificate number                |
	| Test4 | DSURC   | 8815        | 350        | ORD       | W152434    |              | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    |           | C0000465922   |              | 300           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |             |               | 50         |                   | 50                 | 1                | Cannot enter splits when reissue balance. |
	| Test5 | DSURC   | 8815        | 350        | ORD       | W152434    |              | VIC     |            | W152434   |           |           |           |           | 350        |            |            |            |            | VIC    |           | C0000465922   |              | 350           |              |           |                  |                  |                  |                  |                  |                  |                  |                    |                    |             |               |            | S                 | 50                 | 1                | Split units do NOT add to buy units.      |


