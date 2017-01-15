Feature: EN_E_NegativeTest
	Ensure EN_E_NegativeTest Actions functionality covered

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@CPU_AUTO
@18017
Scenario Outline: Test Case 18017: 04_Transaction history error messages (TH,DLH)
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | LocateArgument | ErrorMessage                                                                      |
		| TH     | X0012160437    | here is no trading history for holder <X0012160437>                               |
		| THD    | X0012160437    | There is no TRADE History matching trade ID <            > /Bulk Trans <        > |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@CPU_AUTO
@18000
Scenario Outline: Test Case 18000: 03_Pending Actions (PT/PEND) Specific Error messages
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | LocateArgument | ErrorMessage                                         |
		| PT     | X0012160437    | There are no pending trades for holder <X0012160437> |
		| PEND   | X0012160437    | There are no pending deals for this holder.          |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@DIV_A
@17473
Scenario Outline: Test Case 17473: 03_Disbursement Types -Error Message
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		 | Action | HIN         | LocateArgument | ErrorMessage                                  |
		 | DSC    | I0000001295 |                | There are no payment details for this holder. |
		 | DS     | I0030163672 |                | There are no payment details for this holder. |
		 | DSO    | I0030163672 |                | There are no payment details for this holder. |
		 | DSP    | I0030163672 |                | There are no payment details for this holder. |
		 | LDS    | I0030163672 |                | Please enter Account number/Ref number        |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@CPU_AUTO
@ViewDivPlanIntentionsError
Scenario: View Dividend Plan Intentions -Error message
	# Enquiry System -Action DI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DI    |
			| Locate Argument |       |
	Then I should not see Dividend Plan Intentions

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@CPU_AUTO
@WireInstructionsError
Scenario: View Wire Instructions -Error message
	# Enquiry System -Action WR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
	Then I should not see Wire Instructions

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@16785
Scenario Outline: Test Case 16785: 06_A Action for Error Messages
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | HIN         | LocateArgument | ErrorMessage                                       |
  	    | H      | I0031748046 |                | There are no holdings for this holder.             |
		| HE     | I0031748046 |                | There are no extra details record for this holder. |
		| PD     | I0031748046 |                | There are no payment details for this holder.      |
		| PI     | I0031748046 |                | There is no payee instruction for this holder.     |
		| R      | I0031748046 |                | This holder has no register details.               |
		| C      | I0036199024 |                | This holder has no certificates.                   |
		| MJ     | I0036136464 | USD03          | There are no payment transactions for this holder  |
		| DH     | I0031748046 |                | There is no Dividend History for this holder.      |
		| N      | C9999999164 |                | There are no notings present for this holder       |
		| N1     | C9999999164 |                | This holder does not hold this noting.  To see the |
		| D1     | C9999999164 |                | This holder does not hold this noting.  To see the |
		| P1     | C9999999164 |                | This holder does not hold this noting.  To see the |
		| CY     | C9999999164 |                | There are no Charity Elections for this holder.    |
		| CA     | C9999999164 |                | There is no custodian access-code for this holder  |
		| WR     | I0036470810 |                | There isn't a wire instruction for this holder.    |
		| CH     | I0036470810 |                | There Is No CUM History Details For This Holder.   |
		| EA     | C0009913176 |                | There are NO employee details for this holder      |
		| ED     | C0009913176 |                | There are NO employee details for this holder      |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@16785
Scenario Outline: 16785_FailedTests
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | HIN         | LocateArgument | ErrorMessage                                   | COY       |
		| ESAT   | I0033314515 | /PRS           | This action only valid for AESS Schemes.       | NAB_AUTO  |
		| PID    | C0009913176 |                | PID action only valid from ED screen.          | NAB_AUTO  |
		| ESAH   | I0033314515 | /OPT           | This action only valid for AESS Schemes.       | NAB_AUTO  |
		| ESFR   | I0033314515 | /OPT           | Forfeiture not applicable for Employee status. | NAB_AUTO  |
		| SH     | I0036199024 |                | There are no static details for this holder.   | NAB2_AUTO |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17345ss
Scenario Outline: Test Case 17345: 03_Error Messages
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | HIN         | LocateArgument | ErrorMessage                                        |
		| AS     | I0070036916 | I0070036916    | The holder does not have Acceptance Status Details. |
		| PM     | I0070036916 | I0070036916    | There is no corporate action Pending                |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17126
Scenario Outline: Test Case 17126: 03_Error messages where holder has no tax details
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | HIN         | LocateArgument | ErrorMessage                                 | COY       |
		| IR     | I0070036916 | I0070036916    | There are no IRL Tax details for this holder | NAB_AUTO |
		| ZA     | I0070036916 | I0070036916    | There are no ZAF Tax details for this holder | NAB_AUTO |
		| UT     | X0012160437 | X0012160437    | Invalid Action. Not a USA tax company        | CPU_AUTO |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17986
Scenario Outline: Test Case 17986: 02_Main Menu Error Messages
	# Enquiry System -Action SL
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	When I enter following details in Service Level Reporting Details as "<ServiceProvide>" "<ServiceCode>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Test  | ServiceProvide | ServiceCode | ErrorMessage                               |
	| Test1 | ABC            | SPECLS      | Service provider not on file               |
	| Test2 | CTS            | DEF         | Service code for this Provider not on file |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17988
Scenario Outline: Test Case 17988: 02_LD action Error messages
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| LocateArgument | Action | ErrorMessage                                             |
	| ZAF            | LD     | There is no holder with this domicile/post code on file. |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17990_1
Scenario Outline: Test Case 17990: 02_Markings/Certificates Error messages (LC,LCC,LE,LEC)-Test1
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Action | LocateArgument | ErrorMessage                |
	| LC     | 99999999       | No certificate match found. |
	| LCC    | 99999999       | No certificate match found. |
	| LE     | 99999999       | No certificate match found. |
	| LEC    | 99999999       | No certificate match found. |
	| LCM    | 99999999       | No marking match found      |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17990_2
Scenario Outline: Test Case 17990: 02_Markings/Certificates Error messages (LC,LCC,LE,LEC)-Test2
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Action | LocateArgument | ErrorMessage                                   |
	| LC     |                | Please enter Certificate/Class/Register/Holder |
	| LCC    |                | Please enter Certificate/Class/Register/Holder |
	| LE     |                | Please enter Certificate/Class/Register/Holder |
	| LEC    |                | Please enter Certificate/Class/Register/Holder |
	| LCM    |                | Please enter Certificate/Class/Register/Holder |  

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17993
Scenario Outline: Test Case 17993: 04_Markings/Certificates Error messages (LC,LCC,LCM,LE,LEC,LEM)
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Action | LocateArgument | ErrorMessage               |
	| LC     | ORD            | Invalid certificate number |
	| LCC    | VIC            | Invalid certificate number |
	| LE     | I0033870752    | Invalid certificate number |
	| LEC    | 12A            | Invalid certificate number |
	| LCM    | NSW            | Invalid certificate number |
	| lem    | CEN            | Invalid certificate number |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@CPU_AUTO
@18038
#NAB_AUTO is not a FASTER company
Scenario Outline: Test Case 18038: 03_Faster FIN Error Messages for Faster company
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>" 
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
		And I enter Fin Password as "<Password>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| LocateArgument | Action | ErrorMessage                                     | Password | COY       |
	| X0012160437    | FIN    | Current holder is not a FASTER SCRIPLESS holder. | TEST     | CPU_AUTO |
#	| I9999999139    | FIN    | Invalid Password -check M.CLIENT                 | ABCD     | NAB_AUTO |
	 
@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@CPU_AUTO
@18037
Scenario Outline: Test Case 18037: 02_Faster FIN Error Message for Non-Faster company
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>" 
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Action | ErrorMessage                              | COY      | LocateArgument |
	| FIN    | Action only available for FASTER  company | NAB_AUTO |                |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17368
Scenario Outline: Test Case 17368: 03_Error Messages -ESLT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Message       | Action | HIN         | LocateArgument | ErrorMessage                                                |
		| ErrorMessage1 | ESLT   | I0033314515 | /ELA           | Please enter an ESS Loan Scheme.  Format: /Scheme/Reg Code. |
		| ErrorMessag2  | ESLT   | I0033314515 | /ELA/90A       | Invalid Register.                                           |
		| ErrorMessag3  | ESLT   | I0033314515 |                | Please enter an ESS Loan Scheme.  Format: /Scheme/Reg Code. |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@17371
Scenario Outline: Test Case 17371: 03_Error messages_ESOB_ESOT_RSOTF_ESLP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Message | Action | HIN         | LocateArgument | ErrorMessage                                           |
		| Error1  | ESOB   | I0033870752 | /ATS           | This action only valid for Option type plans.          |
		| Error2  | ESOB   | I0033870752 | /ESO           | This action only valid for Option type plans.          |
		| Error3  | ESOB   | I0033870752 | /ELA           | This action only valid for Option type plans.          |
		| Error4  | ESOT   | I0033870752 | /ATS           | This action only valid for Option type plans.          |
		| Error5  | ESOT   | I0033870752 | /ESO           | This action only valid for Option type plans.          |
		| Error6  | ESOT   | I0033870752 | /ELA           | This action only valid for Option type plans.          |
		| Error7  | ESOTF  | I0033870752 | /ATS           | This action only valid for Option type plans.          |
		| Error8  | ESOTF  | I0033870752 | /ESO           | This action only valid for Option type plans.          |
		| Error9  | ESOTF  | I0033870752 | /ELA           | This action only valid for Option type plans.          |
		| Error10 | ESLP   | I0033314515 | /ELA           | This action only valid for Option and AESS type plans. |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@18084
Scenario Outline: Test Case 18084: 03_Error messages for Payments and reference (LP)
	# Enquiry System -Action LD
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>" 
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
	| Message | Action | ErrorMessage                                          | COY       | LocateArgument |
	| Error1  | LP     | Please enter Account number/Cheque number             | NAB_AUTO |                |
	| Error2  | LP     | Enter account number,reference number,payment method. | NAB_AUTO | DV122/313823D  |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@18085
Scenario Outline: Test Case 18085: 04_Error messages for Payments and reference (LHR)
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <X0019115721>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Message | Action | HIN         | LocateArgument | ErrorMessage                                |
		| Error1  | LHR    | X0019115721 |                | Must enter a reference or TOTR or TETR here |
		| Error2  | LHR    | X0019115721 | 987654321      | No transactions with this trade reference   |


#@EN_E_NegativeTest
#@QBE_AUTO
#@18144
##need to create new data -5/10/2015 -DS
#Scenario: Test Case 18144: 04.1_EH & ESHT Action Error Messages
#	# Enquiry System -Action ESHT
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "QBE_AUTO"
#		And I go to the Enquiry system for "I5500008549"
#		And I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | ESHT  |
#			| Locate Argument | /LNN  |
#	Then I expect to be in the "ENSESS18" Screen
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | 1     |
#			| Locate Argument |       |
#	Then I expect to see error with text "No Extra Details for this Award."
	
@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@QBE_AUTO
@18203
Scenario: Test Case 18203: 04.2_LEH Action Error Messages
	# Enquiry System -Action LEH	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I8800303631"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | LEH   |
			| Locate Argument |       |
	Then I expect to see error with text "Enter Run Nbr/Trans Nbr in format rrrr/tttttttt."

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@18149
Scenario Outline: Test Case 18149: 02_Error message for LEML Action
	# Enquiry System -Action LEML	
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | LocateArgument          | ErrorMessage                   |
		| LEML   | TE@COMPUTERSHARE.COM.AU | No matches on email lookup for |
		| LMEL   |                         | Invalid Action                 |

@winformsTest
@EnquiryTest
@DataChange
@EN_E_NegativeTest
@NAB_AUTO
@18165
Scenario: Test Case 18165: 01_Company Notice and Comms (NOT action)
	# Enquiry System -Action NOT
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "NAB_AUTO"
		And I go to "company notice" Control Code Menu
		And In HKS01901 I removed Company notices
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | NOT   |
			| Locate Argument |       |
	Then I expect to see error with text "There is no current NOTICE for this company."

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@QBE_AUTO
@18300
Scenario: Test Case 18300: 08_Events Error messages
	#Action -EETD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500007470"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EETD  |
			| Locate Argument | /EBS  |
	Then I expect to see error with text "Holder has no Events for this history selection."

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@18426_1
Scenario Outline: Test Case 18426: 01_Certs with Last Txn details Error Messages_Test1
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | HIN         | LocateArgument | ErrorMessage                                   |
		| E      | C0009913176 |                | This holder has no certificates.               |
		| EC     | C0009913176 |                | This holder has no certificates.               |
		| EB     | C0009913176 |                | No certificates with balances for this holder. |
		| EM     | C0009913176 |                | This holder has no markings.                   |
		| EMB    | C0009913176 |                | No markings with units for this holder         |
		| ECB    | C0009913176 |                | No certificates with balances for this holder. |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@18426_2
Scenario Outline: Test Case 18426: 02_Certs with Last Txn details Error Messages_Test2
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I should see the below ErrorMessage "<ErrorMessage>"

Examples: 
		| Action | HIN         | LocateArgument | ErrorMessage                                   |
		| EB     | I0070036924 |                | Invalid action for uncertificated holder       |
		| EC     | I0070036924 |                | Invalid action for uncertificated holder       |
		| EM     | I0070036924 |                | Invalid action for uncertificated holder       |
		| EMB    | I0070036924 |                | Invalid action for uncertificated holder       |
		| ECB    | I0070036924 |                | Invalid action for uncertificated holder       |

@winformsTest
@EnquiryTest
@EN_E_NegativeTest
@NAB_AUTO
@16851
Scenario: Test Case 16851: 03_R action comparison- ErrorMessage
	# Enquiry System -Action HE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0031748046"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | R     |
			| Locate Argument |       |
	Then I expect to see error with text "This holder has no register details."