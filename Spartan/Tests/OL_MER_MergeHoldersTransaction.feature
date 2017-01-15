Feature: OL_MER_MergeHoldersTransaction
	Ensure MER. Merge Holders Transaction functionality covered

@winformsTest
@OL_Online
@OL_MER_MergeHoldersTransaction
@CPU_AUTO
@MergeHolder
@FullSmokeTest
Scenario: Holder Merge
	# Merge from Holder to Holder
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I Go to Merge Holder Transaction Menu
		And I select "MERGE" Transaction
	When I merge holder as below:
			| Field       | Value       |
			| Tran No     | 158         |
			| From Holder | I0100007592 |
			| To Holder   | I0100007690 |
	When I go to the Enquiry system for "I0100007690"
	Then In ENS01034 I should see Static History for holder "I0100007690" as below:
			| Field            | Value            |
			| Transaction Code | MRGTO            |
			| Transaction Desc | MERGED HOLDER TO |
			| Reference        | I0100007592      |
			| Source           | WINFRM           |
	When I enter the following details as the Locate action:
			| Field           | Value       |
			| Action          | S           |
			| Locate Argument | I0100007592 |
	Then In ENS01001 I should see the holder Details as below:
			| Field    | Value                          |
			| From HIN | I0100007592                    |
			| Note     | <* Merged on 22 Apr 2015    *> |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PD    |
			| Locate Argument |       |
		Then I expect to see error with text "There are no payment details for this holder."

@winformsTest
@OL_Online
@ANZ_AUTO
@21617
@OL_MER_MergeHoldersTransaction
Scenario Outline: TestCase21617_MergeHolders_ErrorValidation
###Test Case 21617: 04 - OLS033 Merge Holders - Holders with different TFN/ABN can't be merged ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "merge holders transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03301 I continue with the following details:
		| TranNumber   | FromNameKey   | FromCertID   |
		| <TranNumber> | <FromNameKey> | <FromCertID> |
		And In OLS03302 I continue with the following details:
		| TONameKey   |
		| <TONameKey> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | SelCode | TranNumber | FromNameKey | FromCertID | TONameKey   | ErrorMessage                                  |
	| Test1 | MERGE   | 42409      | I0010448603 |            | I0010455774 | Tax File Numbers/ABNs or Codes DIFFERENT.     |
	| Test2 | MERGE   | 42409      | I0010041121 |            | I0010058813 | Holders Vesting differ - merge cannot proceed |

#@OL_Online
#@ignore
#@ANZ_AUTO
#@21717
#@OL_MER_MergeHoldersTransaction
#Scenario Outline: TestCase21717_MergeHolders
####Test Case 21717: 01 - OLS033 Merge Holders - Merge Holders Scenario 1 ####
#### Cannot add all the enquiry scenarios to this tests. Memory issue. Test is not running ###
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And In MNS00101 I click on: "online data entry system" within the System Menu
#		And In OLS00101 I Click on: "merge holders transaction" with in the online data entry system menu
#		And In SELTRN20 I continue with the following details:
#		| SelCode   |
#		| <SelCode> |
#		And In OLS03301 I continue with the following details:
#		| TranNumber   | FromNameKey   | FromCertID   |
#		| <TranNumber> | <FromNameKey> | <FromCertID> |
#		And In OLS03302 I continue with the following details:
#		| TONameKey   | Action   |
#		| <TONameKey> | <Action> |
#		And In OLS03303 I continue with the following details:
#		| Action1   |
#		| <Action1> |
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "ANZ_AUTO"
#		And I go to the Enquiry system and Search <TONameKey>
#		And I enter the following details as the Locate action "<Action2>" "<LocateArgument>"
#	Then In ENS01012 I should see Register details as:
#	| CertificateLine1   | CertificateLine2   | CertificateLine3   | CertificateLine4   | CertificateLine5   | CertificateLine6   | CertificateLine7   | CertificateLine8   | CertificateLine9   | CertificateLine10   |
#	| <CertificateLine1> | <CertificateLine2> | <CertificateLine3> | <CertificateLine4> | <CertificateLine5> | <CertificateLine6> | <CertificateLine7> | <CertificateLine8> | <CertificateLine9> | <CertificateLine10> |
#	When I enter the following details as the Locate action "<Action3>" "<LocateArgument1>"
#	Then In ENS01006 I should see Noting details as "<NotingNbr>" "<Key>" "<HIN>" "<Type>" "<Comment>" "<Noting1>" "<Noting2>" "<Noting3>" "<Noting4>" "<Noting5>" "<Noting6>" "<Noting7>" "<Noting8>" "<Run>" "<Tran>"
#	When I enter the following details as the Locate action "<Action4>" "<LocateArgument1>"
#	Then In ENS01003 I verify the following details:
#	| NotingNumber   | RegisterCode   | PowerDated   | PowerNoted   | AtsJointlyFlag   | AtsSeverallyFlag   | AtsAnytwoFlag   | PptBuyFlag   | PptSellFlag   | PptVoteFlag   | PptAppsubFlag   | StampedINComment   | LodgedBYComment   |
#	| <NotingNumber> | <RegisterCode> | <PowerDated> | <PowerNoted> | <AtsJointlyFlag> | <AtsSeverallyFlag> | <AtsAnytwoFlag> | <PptBuyFlag> | <PptSellFlag> | <PptVoteFlag> | <PptAppsubFlag> | <StampedINComment> | <LodgedBYComment> |
#	When I enter the following details as the Locate action "<Action5>" "<LocateArgument1>"
#	Then In ENS01060 I verify the following details:
#	| BspLine1   | BspLine2   | BspLine3   | BspLine4   | BspLine5   | SourceOption   | DrpLine1  | DrpLine2   | DrpLine3   | DrpLine4   | DrpLine5   |
#	| <BspLine1> | <BspLine2> | <BspLine3> | <BspLine4> | <BspLine5> | <SourceOption> | <DrpLine> | <DrpLine2> | <DrpLine3> | <DrpLine4> | <DrpLine5> |
#	When I enter the following details as the Locate action "<Action6>" "<LocateArgument2>"
#
#
#	Examples: 
#	| Test  | SelCode | TranNumber | FromNameKey | FromCertID | TONameKey   | Action | Action1 | Action2 | LocateArgument | CertificateLine1                 | CertificateLine2                                                                     | CertificateLine3                                                                    | CertificateLine4                                                                    | CertificateLine5                                                                     | CertificateLine6                                                                    | CertificateLine7                                                                     | CertificateLine8                             | CertificateLine9 | CertificateLine10 | Action3 | LocateArgument1 | NotingNbr | Key                    | HIN         | Type | Comment            | Noting1                | Noting2 | Noting3 | Noting4 | Noting5 | Noting6 | Noting7 | Noting8 | Run | Tran | Action4 | NotingNumber | RegisterCode | PowerDated | PowerNoted | AtsJointlyFlag | AtsSeverallyFlag | AtsAnytwoFlag | PptBuyFlag | PptSellFlag | PptVoteFlag | PptAppsubFlag | StampedINComment | LodgedBYComment | Action5 | BspLine1                               | BspLine2 | BspLine3 | BspLine4 | BspLine5 | SourceOption | DrpLine1                                                                     | DrpLine2                                                                     | DrpLine3                                                                     | DrpLine4                                                                     | DrpLine5                                                                     | Action6 | LocateArgument2 |
#	| Test1 | MERGE   | 42410      | I0060155119 |            | I0013820082 | S      |         | C       | /DPM           | DPM/DRP RESIDUAL FREE/SHARE SAVE | *MR MONEY L/OVER 01/07/09         12.49    *MR MONEY L/OVER 18/12/09          10.01- | *MR MONEY L/OVER 01/07/10          9.88    *MR MONEY L/OVER 17/12/10           5.62 | *MR MONEY L/OVER 01/07/11          4.35-   *MR MONEY L/OVER 16/12/11           0.17 | *MR MONEY L/OVER 02/07/12          4.90    *MR MONEY L/OVER 19/12/12           5.23- | *MR MONEY L/OVER 01/07/13          7.56-   *MR MONEY L/OVER 16/12/13           4.63 | *MR MONEY L/OVER 01/07/14         16.20    *MR MONEY L/OVER 16/12/14          17.32- | **** Total for MONEY L/OVER             9.42 |                  |                   | N1      |                 | 1         | GWEYH       GAIOLEKIMO | I0013820082 | IND  | TEST NOTING  MERGE | TESTING TESTING TESTIN |         |         |         |         |         |         |         |     |      | P1      | 1            |              | No date    | No date    | N              | N                | N             | N          | N           | N           | N             |                  |                 | DI      | BOP1  1   BOP          NON PARTICIPANT |          |          |          |          | D            | DRP1  1   DRP          16/05/00            0000   1019442    F             N | DPN2  2   DRP PLAN     16/05/00            0000   1019443    F             N | DPN3  3   DRP PLAN     17/11/00            0000   1019444    F             N | DPN4  4   DRP PLAN     22/05/01            0000   1019445    F             N | DPN5  5   DRP PLAN     22/05/01            0000   1019446    F             N |         |                 |

@winformsTest
@OL_Online
@ANZ_AUTO
@21717
@OL_MER_MergeHoldersTransaction
Scenario Outline: TestCase21717_MergeHolder_Transaction
###Test Case 21717: 01 - OLS033 Merge Holders - Merge Holders Scenario 1 ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "merge holders transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03301 I continue with the following details:
		| TranNumber   | FromNameKey   | FromCertID   |
		| <TranNumber> | <FromNameKey> | <FromCertID> |
		And In OLS03302 I continue with the following details:
		| TONameKey   | Action   |
		| <TONameKey> | <Action> |
		And In OLS03303 I continue with the following details:
		| Action1   |
		| <Action1> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <FromNameKey>
		And I enter the following details as the Locate action "<Action2>" "<LocateArgument>"
	Then In ENS01052 I verify the merge details:
		| HolderTO    |
		| <TONameKey> |

	Examples: 
	| Test  | SelCode | TranNumber | FromNameKey | FromCertID | TONameKey   | Action | Action1 | Action2 | LocateArgument |
	| Test1 | MERGE   | 42410      | I0060155119 |            | I0013820082 | S      |         | >       |                |

@winformsTest	        
@OL_Online
@ANZ_AUTO
@21718
@OL_MER_MergeHoldersTransaction
Scenario Outline: TestCase21718_MergeHolder_Transaction
###Test Case 21718: 02 - OLS033 Merge Holders - Merge Holders Scenario 2 ####
###Test Case 21719: 03 - OLS033 Merge Holders - Merge Holders Scenario 3 ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "merge holders transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03301 I continue with the following details:
		| TranNumber   | FromNameKey   | FromCertID   |
		| <TranNumber> | <FromNameKey> | <FromCertID> |
		And In OLS03302 I continue with the following details:
		| TONameKey   | Action   |
		| <TONameKey> | <Action> |
		And In OLS03303 I continue with the following details:
		| Action1   |
		| <Action1> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <FromNameKey>
		And I enter the following details as the Locate action "<Action2>" "<LocateArgument>"
	Then In ENS01052 I verify the merge details:
		| HolderTO    |
		| <TONameKey> |

	Examples: 
	| Test  | SelCode | TranNumber | FromNameKey | FromCertID | TONameKey   | Action | Action1 | Action2 | LocateArgument |
	| Test1 | MERGE   | 42411      | I0011877672 | 80334317   | I0011071856 | S      | UPDATE  | >       |                |
	| Test2 | MERGE   | 42412      | C0923981274 |            | C9856465789 | S      | UPDATE  | >       |                |

@winformsTest
@OL_Online
@ANZ_AUTO
@24960
@OL_MER_MergeHoldersTransaction
Scenario Outline: TestCase24960_MergeHolders_ErrorValidation
###Test Case 24960: 08 - OLS033 Merge Holders - Holder can't be merged when participating in a dividend ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "merge holders transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03301 I continue with the following details:
		| TranNumber   | FromNameKey   | FromCertID   |
		| <TranNumber> | <FromNameKey> | <FromCertID> |
	Then I should see the below ErrorMessage "<ErrorMessage>"

	Examples: 
	| Test  | SelCode | TranNumber | FromNameKey | FromCertID | TONameKey   | ErrorMessage                                                     |
	| Test1 | MERGE   | 42413      | I0000000892 |            | I0010455774 | Holder "I0000000892" is currently participating in dividend LNX2 |

@winformsTest
@OL_Online	
@ANZ_AUTO
@25223
@OL_MER_MergeHoldersTransaction
@FullSmokeTest
Scenario Outline: TestCase25223_MergeHolder_Transaction
###Test Case 25223: 10 - OLS033 Merge Holders - Merge Holders Scenario 4 ####
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And In MNS00101 I click on: "online data entry system" within the System Menu
		And In OLS00101 I Click on: "merge holders transaction" with in the online data entry system menu
		And In SELTRN20 I continue with the following details:
		| SelCode   |
		| <SelCode> |
		And In OLS03301 I continue with the following details:
		| TranNumber   | FromNameKey   | FromCertID   |
		| <TranNumber> | <FromNameKey> | <FromCertID> |
		And In OLS03302 I continue with the following details:
		| TONameKey   | Action   |
		| <TONameKey> | <Action> |
		And In OLS03303 I continue with the following details:
		| Action1   |
		| <Action1> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "ANZ_AUTO"
		And I go to the Enquiry system and Search <TONameKey>
		And I enter the following details as the Locate action "<Action2>" "<LocateArgument>"
	Then In ENSESS25 I verify the following details:
	| DetailLine1   | DetailLine2   | DetailLine3   | DetailLine4   | DetailLine5   | DetailLine6   | DetailLine7   | DetailLine8   | DetailLine9   | DetailLine10   |
	| <DetailLine1> | <DetailLine2> | <DetailLine3> | <DetailLine4> | <DetailLine5> | <DetailLine6> | <DetailLine7> | <DetailLine8> | <DetailLine9> | <DetailLine10> |

	Examples: 
	| Test  | SelCode | TranNumber | FromNameKey | FromCertID | TONameKey   | Action | Action1 | Action2 | LocateArgument | DetailLine1                                                                                                                     | DetailLine2 | DetailLine3 | DetailLine4 | DetailLine5 | DetailLine6 | DetailLine7 | DetailLine8 | DetailLine9 | DetailLine10 |
	| Test1 | MERGE   | 42414      | I0010269512 |            | I0010315573 | S      | UPDATE  | ESOT    | /DSI           | 12J EE  12/11/12     VC8  P11  HK Def        1100  01/01   12/11/14        1100           0           0           0        1100 |             |             |             |             |             |             |             |             |              |





