Feature: EP_Employee Plan Processing_OptionsPlan

@winformsTest
@NAB2_AUTO
@34315
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 34315: 1_GRT. Manual Grant of -EE
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And I go to the Grant Options Menu for "<MenuItem>"
		And I go to the Manual Grant of Options Menu "<RegisterCode>"
		And In EOL00901 I Add Grant details as "<AppropDate>" "<TransNumber>" "<TotalUnits>" "<GrantCountry>" "<SearchName>"
	Then In EOL00905 I should see Buyer details as "<ClassCode>" "<RegisterCode>" "<RegisterDesc>" "<RegisterType1>" "<Units1>" "<Money1>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS26 I should see Future Vesting Details as "<ClassCode>" "<PlanDesc>" "<LineF1>" "<LineF2>" "<LineF3>" "<LineF4>"
	When I enter the following details as the locatActions "<Action2>"  "<LocateArgument>"
	Then In ENSESS25 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<TLine1>" "<TLine2>" "<TLine3>" 

Examples: 
	| Test         | ClassCode | MenuItem | RegisterCode | AppropDate | TransNumber | TotalUnits | GrantCountry | SearchName  | RegisterDesc              | RegisterType1 | Units1 | Money1   | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                            | BLine3                                                                                                    | BLine4                                                                                                          | Action1 | LineF1                                                                                                        | LineF2                                         | LineF3 | LineF4 | Action2 | TLine1                                                                                                                          | TLine2                                                                       | TLine3                                                                                                                                |
	| Options Plan | OPT       | EE       | 9B3          | 16/01/2009 | 312002      | 1000       |              | I0031971926 | 2009 EXECUTIVE OPTIONS T3 | Options       | 1000   | 19890.00 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 9B3 EE   16/01/2009 HK Def         1000        1000          39         961           0           0           0           0 |                                                                                                                                   | ** Totals        1000        1000          39         961           0           0           0           0 |                                                                                                                 | ESOTF   | 9B3 EE   16/01/2009     VE7  PE7  HK Def        1000  01/02    16/01/2014           0          39           0 | 16/07/2014           0           0        1000 |        |        | ESOT    | 9B3 EE  16/01/09     VE7  PE7  HK Def        1000  01/01   16/01/14           0           0           0           0        1000 | 01/02   16/01/14         961           0           0           0        1000 |                                                                                                                                       |
	| Rights Plan  | PRS       | EE       | 33A          | 01/01/2013 | 3120133     | 1000       |              | I0036463481 | 2013 EE                   | Options       | 1000   |          | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 12P EE   12/12/2012 HK Def         1000           0           0           0           0        1000           0           0 |33A EE   01/01/2013 HK Def         1000        1000           0        1000           0           0           0           0        |                                                                                                           |** Totals        2000        1000           0        1000           0        1000           0           0        | ESOTF   | 33A EE   01/01/2013     VE3       HK Def        1000           28/09/2029           0           0        1000 |                                                |        |        | ESOT    | 12P EE  12/12/12     VW4  PW4  HK Def        1000  01/01   19/12/14        1000           0           0           0        1000 | 20/08/15           0        1000           0           0           0         | 33A EE  01/01/13     VE3       HK Def        1000  01/     16/01/13        1000           0           0           0        1000       |

@winformsTest
@NAB2_AUTO
@34613
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 34613: 14_RVA. Reversal of Grant
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And I go to the Grant Options Menu for "<MenuItem>"
		And I go to the Reversal of Grant Menu "<RegisterCode>"
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| PlanType   | MenuItem | ClassCode | RegisterCode | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | SearchName  | Action | LocateArgument | PlanDesc                       | BLine1 | BLine2                                                                                                    | BLine3 | BLine4 |
	| Options-EX | EX       | OPT       | 14A          | 312003      | 1000       | 7832           | 2001001          | I0033315341 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 |        | ** Totals           0           0           0           0           0           0           0           0 |        |        |
	| Options-EE | EE       | OPT       | 13A          | 312005      | 1000       | 7832           | 2001000          | I0032666981 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 |        | ** Totals           0           0           0           0           0           0           0           0 |        |        |
	| Rights-EE  | EE       | PRS       | 33A          | 3120134     | 1000       | 7837           | 3210000          | I0036471867 | ESOB   | /PRS           | PERFORMANCE RIGHTS             |        | ** Totals           0           0           0           0           0           0           0           0 |        |        |


@winformsTest
@NAB2_AUTO
@34786
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 35091: 2_ESLVP_Leaver Processing
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "leaver processing" Menu
		And In EOL02702 I perform Leaver Processing as "<Selection>" "<TransNumber>" "<SearchName>" "<Confirm>" "<IgnoreBlackoutInd>" "<NOChangeUvst1>" "<CancelImmUvst1>" "<VestNbrUvst1>" "<VestDateUvst1>" "<NOChangeVst1>" "<CancelImmVst1>" "<ExpiryDate1>" "<NOChangeUvst2>" "<CancelImmUvst2>" "<VestNbrUvst2>" "<VestDateUvst2>" "<NOChangeVst2>" "<CancelImmVst2>" "<ExpiryDate2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS31 I should see Updated Leaver Processing details as "<ClassCode>" "<PlanDesc>" "<LLine1>" "<LLine2>" "<LLine3>"

Examples: 
	| Test         | Selection | TransNumber | SearchName  | Confirm | IgnoreBlackoutInd | NOChangeUvst1 | CancelImmUvst1 | VestNbrUvst1 | VestDateUvst1 | NOChangeVst1 | CancelImmVst1 | ExpiryDate1 | NOChangeUvst2 | CancelImmUvst2 | VestNbrUvst2 | VestDateUvst2 | NOChangeVst2 | CancelImmVst2 | ExpiryDate2 | ClassCode | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3                                                                                                          | BLine4                                                                                                    | Action1 | LLine1                                                                               | LLine2                                                                               | LLine3 |
	| Options Plan | ESLVP     | 312006      | I0033433093 | Y       |                   |               |                |              |               | 900          | 100           | 23/02/2017  | 500           | 100            | 400          | 01/01/2016    |              |               | 23/02/2017  | OPT       | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 Ind Lvr        1000         900           0         900           0           0           0         100 | 14A EX   01/02/2014 Ind Lvr        1000         900         400         500           0           0           0         100 |                                                                                                                 | ** Totals        2000        1800         400        1400           0           0           0         200 | ESLP    | 13A EE   01/01/2013  Ind Lvr   20/08/2015   25/11/2014              7835    00312006 | 14A EX   01/02/2014  Ind Lvr   20/08/2015   25/11/2014              7835    00312006 |        |
	| Rights Plan  | ESLVP     | 312009      | I0036136464 | Y       |                   |               |                |              |               | 500          | 500           | 23/02/2017  |               |                |              |               |              |               |             | PRS       | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 33A EE   01/01/2013 Ind Lvr        1000         500           0         500           0           0           0         500 |                                                                                                                             |** Totals        1000         500           0         500           0           0           0         500        |                                                                                                           | ESLP    | 33A EE   01/01/2013  Ind Lvr   20/08/2015   07/01/2015              7835    00312009 |                                                                                      |        |

@winformsTest
@NAB2_AUTO
@35109
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35109: 17_ESLRV. Leaver Processing Reversal
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "leaver processing" Menu
		And In EOL00401 I Perform Leaver Processing Reversal as "<Selection>" "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS31 I should see Updated Leaver Processing details as "<ClassCode>" "<PlanDesc>" "<LLine1>" "<LLine2>" "<LLine3>"

Examples: 
	| Test         | Selection | ClassCode | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | SearchName  | Action | LocateArgument | PlanDesc                       | LLine1                                 | LLine2                                 | LLine3 |
	| Options Plan | ESLRV     | OPT       | 312008      | 0          | 7835           | 04431000         | I0033458380 | ESLP   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013  HK Def    Pending | 14A EX   01/02/2014  HK Def    Pending |        |
	| Rights Plan  | ESLRV     | PRS       | 312011      | 500        | 7836           | 00072347         | I0970033092 | ESLP   | /PRS           | PERFORMANCE RIGHTS             | 33A EE   01/01/2013  HK Def    Pending |                                        |        |

@winformsTest
@NAB2_AUTO
@35219
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35219: 1_LPE. Lapse Options - Employee Initiated
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "lapse cancellation processing" Menu
		And In EOL00132 I Click on "lapse options employee initiated" Menu
		And In EOL02801 I Perform Options Lapse Transaction as "<TransNumber>" "<TransDate>" "<LapseCancelAll>" "<TotalUnits>" "<SearchName>" "<Unvested1>" "<Vested1>" "<Unvested2>" "<Vested2>" "<TotalUnvested>" "<TotalVested>" "<GrandTotal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| Test        | ClassCode | TransNumber | TransDate  | LapseCancelAll | TotalUnits | SearchName  | Unvested1 | Vested1 | Unvested2 | Vested2 | TotalUnvested | TotalVested | GrandTotal | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3 | BLine4                                                                                                    |
	| OPT-Full    | OPT       | 312021      | 20/08/2015 | Y              |            | I0035882642 |           |         |           |         |               | 2000        | 2000       | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |
	| PRS-Partial | PRS       | 3433029     | 20/08/2015 | N              | 500        | I0036358181 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 | 33A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| PRS-Full    | PRS       | 312030      | 20/08/2015 | Y              |            | I0035986693 |           |         |           |         |               | 2000        | 2000       | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 | 33A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |


@winformsTest
@NAB2_AUTO
@35227
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35227: 2_LPC. Lapse Options - Company  Initiated
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "lapse cancellation processing" Menu
		And In EOL00132 I Click on "lapse options company initiated" Menu
		And In EOL02801 I Perform Options Lapse Transaction as "<TransNumber>" "<TransDate>" "<LapseCancelAll>" "<TotalUnits>" "<SearchName>" "<Unvested1>" "<Vested1>" "<Unvested2>" "<Vested2>" "<TotalUnvested>" "<TotalVested>" "<GrandTotal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"

Examples: 
	| Test        | ClassCode | TransNumber | TransDate  | LapseCancelAll | TotalUnits | SearchName  | Unvested1 | Vested1 | Unvested2 | Vested2 | TotalUnvested | TotalVested | GrandTotal | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3 | BLine4                                                                                                    |
	| OPT-Partial | OPT       | 312022      | 20/08/2015 | N              | 500        | I0035886516 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| OPT-Full    | OPT       | 312023      | 20/08/2015 | Y              |            | I0036474483 |           |         |           |         |               | 2000        | 2000       | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |
	| PRS-Partial | PRS       | 312031      | 20/08/2015 | N              | 500        | I0035592890 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 | 33A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| PRS-Full    | PRS       | 312033      | 20/08/2015 | Y              |            | I0035881433 |           |         |           |         |               | 2000        | 2000       | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 | 33A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |

@winformsTest
@NAB2_AUTO
@35239
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35239: 3_CLE. Cancel Options - Employee Initiated
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "lapse cancellation processing" Menu
		And In EOL00132 I Click on "cancel options employee initiated" Menu
		And In EOL02801 I Perform Options Lapse Transaction as "<TransNumber>" "<TransDate>" "<LapseCancelAll>" "<TotalUnits>" "<SearchName>" "<Unvested1>" "<Vested1>" "<Unvested2>" "<Vested2>" "<TotalUnvested>" "<TotalVested>" "<GrandTotal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"

Examples: 
	| Test        | ClassCode | TransNumber | TransDate  | LapseCancelAll | TotalUnits | SearchName  | Unvested1 | Vested1 | Unvested2 | Vested2 | TotalUnvested | TotalVested | GrandTotal | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3 | BLine4                                                                                                    |
	| OPT-Partial | OPT       | 312024      | 20/08/2015 | N              | 500        | I0036156112 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| OPT-Full    | OPT       | 3452025     | 20/08/2015 | Y              |            | I0033925506 |           |         |           |         |               | 2000        | 2000       | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |
	| PRS-Partial | PRS       | 3453335     | 20/08/2015 | N              | 500        | I0035729593 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 | 33A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| PRS-Full    | PRS       | 312035      | 20/08/2015 | Y              |            | I0036463902 |           |         |           |         |               | 2000        | 2000       | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 | 33A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |

@winformsTest
@NAB2_AUTO
@35259
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35259: 4_CLC. Cancel Options - Company  Initiated
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "lapse cancellation processing" Menu
		And In EOL00132 I Click on "cancel options employee initiated" Menu
		And In EOL02801 I Perform Options Lapse Transaction as "<TransNumber>" "<TransDate>" "<LapseCancelAll>" "<TotalUnits>" "<SearchName>" "<Unvested1>" "<Vested1>" "<Unvested2>" "<Vested2>" "<TotalUnvested>" "<TotalVested>" "<GrandTotal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| Test        | ClassCode | TransNumber | TransDate  | LapseCancelAll | TotalUnits | SearchName  | Unvested1 | Vested1 | Unvested2 | Vested2 | TotalUnvested | TotalVested | GrandTotal | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3 | BLine4                                                                                                    |
	| OPT-Partial | OPT       | 312026      | 20/08/2015 | N              | 500        | I0035512543 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| OPT-Full    | OPT       | 312027      | 20/08/2015 | Y              |            | I0035544836 |           |         |           |         |               | 2000        | 2000       | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |
	| PRS-Partial | PRS       | 312036      | 20/08/2015 | N              | 500        | I0036450258 |           | 250     |           | 250     |               | 500         | 500        | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000         750           0         750           0           0           0         250 | 33A EE   01/01/2013 HK Def         1000         750           0         750           0           0           0         250 |        | ** Totals        2000        1500           0        1500           0           0           0         500 |
	| PRS-Full    | PRS       | 312037      | 20/08/2015 | Y              |            | I0036151595 |           |         |           |         |               | 2000        | 2000       | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000           0           0           0           0           0           0        1000 | 33A EE   01/01/2013 HK Def         1000           0           0           0           0           0           0        1000 |        | ** Totals        2000           0           0           0           0           0           0        2000 |

@winformsTest
@NAB2_AUTO
@35261
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35261: 5_RVL. Lapse/Cancel Options Reversal
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "lapse cancellation processing" Menu
		And In EOL00132 I Click on "lapsecancel options reversal" Menu
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| ClassCode | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | Action | LocateArgument | PlanDesc                       | BLine1                                                                                                                      | BLine2                                                                                                                      | BLine3 | BLine4                                                                                                    | SearchName  |
	| OPT       | 312028      | 100        | 7838           | 482351           | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 13A EE   01/01/2013 HK Def         1000         925           0         925           0           0           0          75 | 14A EX   01/02/2014 HK Def         1000         775           0         775           0           0           0         225 |        | ** Totals        2000        1700           0        1700           0           0           0         300 | I0036356791 |
	| PRS       | 312039      | 100        | 7840           | 34827            | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000         850           0         850           0           0           0         150 | 33A EE   01/01/2013 HK Def         1000         850           0         850           0           0           0         150 |        | ** Totals        2000        1700           0        1700           0           0           0         300 | I0035153918 |

@winformsTest
@NAB2_AUTO
@35313
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35313: 1_RVE. ESS Option Exercise Reversal
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BeforeLine1>" "<BeforeLine2>" "<BeforeLine3>" "<BeforeLine4>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "ess option exercise reversal" Menu
		And In EOL00401 I perform Exercise Reversal Transaction as "<Selection>" "<RegisterCode>" "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<ClassCode>" "<PlanDesc>" "<BLine1>" "<BLine2>" "<BLine3>" "<BLine4>"


Examples: 
	| Test   | ClassCode | Selection | RegisterCode | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | SearchName  | Action | LocateArgument | PlanDesc                       | BeforeLine1                                                                                                                 | BeforeLine2 | BeforeLine3                                                                                               | BeforeLine4 | BLine1                                                                                                                      | BLine2 | BLine3                                                                                                    | BLine4 |
	| OPT-EX | OPT       | EX        | 14A          | 312042      | 250        | 7841           | 79269023         | I0036108011 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 14A EX   01/02/2014 HK Def         1000         750           0         750           0         250           0           0 |             | ** Totals        1000         750           0         750           0         250           0           0 |             | 14A EX   01/02/2014 HK Def         1000        1000           0        1000           0           0           0           0 |        | ** Totals        1000        1000           0        1000           0           0           0           0 |        |
	| PRS-EE | PRS       | EE        | 33A          | 312043      | 500        | 7841           | 79269026         | I0034097925 | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 33A EE   01/01/2013 HK Def         1000         500           0         500           0         500           0           0 |             | ** Totals        1000         500           0         500           0         500           0           0 |             | 33A EE   01/01/2013 HK Def         1000        1000           0        1000           0           0           0           0 |        | ** Totals        1000        1000           0        1000           0           0           0           0 |        |
	| PRS-EX | PRS       | EX        | 14A          | 312044      | 200        | 7841           | 79269030         | I0036453991 | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 14A EX   01/02/2014 HK Def         1000         800           0         800           0         200           0           0 |             | ** Totals        1000         800           0         800           0         200           0           0 |             | 14A EX   01/02/2014 HK Def         1000        1000           0        1000           0           0           0           0 |        | ** Totals        1000        1000           0        1000           0           0           0           0 |        |

@winformsTest
@NAB2_AUTO
@35346
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35346: 1_ADD. Add Holder Event
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL03301 I Add Event details as "<EventNumber>" "<Selection>" "<Selection1>" "<TransNumber>" "<SearchName>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<CurrentBal1>" "<CurrentBal2>" "<SelectionInd1>" "<SelectionInd2>" "<TotEventUnits>" "<TotCurrentBal>" "<TotEventUnits1>" "<TotCurrentBal1>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test         | ClassCode | EventNumber | Selection | Selection1 | TransNumber | SearchName  | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | CurrentBal1 | CurrentBal2 | SelectionInd1 | SelectionInd2 | TotEventUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | TotEventUnits1 | TotCurrentBal1 | Line1                                                                            | Line2                                                                            | Line3 | Line4 | Line5 | Action1 |
	| Rights Plan  | PRS       | 4           | UPD       | ADD        | 312049      | I0036026898 | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000        | 1000        | Y             | Y             | 2000          | 2000          | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | 2000           | 2000           | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       | ESEH    |

@winformsTest
@NAB2_AUTO
@35347
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35347: 2_CHG. Change Holder Event
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03304 I Modify Event details as "<TransNumber>" "<SearchName>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<CurrentBal1>" "<CurrentBal2>" "<SelectionInd1>" "<SelectionInd2>" "<TotEventUnits>" "<TotCurrentBal>" "<TotEventUnits1>" "<TotCurrentBal1>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test         | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | CurrentBal1 | CurrentBal2 | SelectionInd1 | SelectionInd2 | TotEventUnits | TotCurrentBal | TotEventUnits1 | TotCurrentBal1 | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                  | Line2                                                                            | Line3 | Line4 | Line5 |
	| Options Plan | OPT       | 3           | UPD       | CHG      | 3532047     | I0036028394 | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000        | 1000        | Y             | N             | 2000          | 2000          | 1000           | 1000           | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Deleted   Deleted     Unknown | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       |
	| Rights Plan  | PRS       | 4           | UPD       | CHG      | 312050      | I0035735658 | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000        | 1000        | Y             | N             | 2000          | 2000          | 1000           | 1000           | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Deleted   Deleted     Unknown | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       |

@winformsTest
@NAB2_AUTO
@35348
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35348: 3_DEL. Delete Holder Event
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03307 I Delete Event details as "<TransNumber>" "<SearchName>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<CurrentBal1>" "<CurrentBal2>" "<TotEventUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"
Examples: 
	| Test         | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | CurrentBal1 | CurrentBal2 | TotEventUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                            | Line2                                                                            | Line3 | Line4 | Line5 |
	| Options Plan | OPT       | 3           | UPD       | DEL      | 312048      | I0036461438 | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000        | 1000        | 2000          | 2000          | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Deleted   Deleted     Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Deleted   Deleted     Not Actioned    E |       |       |       |
	| Rights Plan  | PRS       | 4           | UPD       | DEL      | 312051      | I0036380021 | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000        | 1000        | 2000          | 2000          | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Deleted   Deleted     Not Actioned    E | V/DS6  21A  EE   01/01/2020  01/05/2015  Deleted   Deleted     Not Actioned    E |       |       |       |

@winformsTest
@NAB2_AUTO
@36805
@EP_EmployeePlanProcessing
#Options Plan
Scenario Outline: Test Case 36805: 6_ELA. Add Holder Election Details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03401 I Select Holder as "<TransNumber>" "<SearchName>"
		And In EOL03401 I Add/Modify Event Election Details as "<DisposalChoice>" "<ExerciseUnits>" "<PartialUnits>" "<PymtMthd>" "<CurrencyCode>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<ExerciseBal1>" "<ExerciseBal2>" "<CurrentBal1>" "<CurrentBal2>" "<TotEventUnits>" "<TotExerciseUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test                   | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | DisposalChoice | ExerciseUnits | PartialUnits | PymtMthd | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | ExerciseBal1 | ExerciseBal2 | CurrentBal1 | CurrentBal2 | TotEventUnits | TotExerciseUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                                                                           | Line2                                                                                                                   | Line3 | Line4 | Line5 | CurrencyCode |
	| OPT-Exer-Sell All2     | OPT       | 3           | UPD       | ELA      | 24730       | I0036337826 | A              | 1500          |              | C        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 500          |             |             | 2000          | 1500             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Local Cheque          | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Local Cheque  |       |       |       |              |
	| OPT-Exer-Sell Partial  | OPT       | 3           | UPD       | ELA      | 24731       | I0035099786 | P              | 1000          | 750          | F        | 21A           |               | 20150501EE |            | 1000        |             | 1000         |              | 750         |             | 1000          | 1000             | 750           | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |                                                                                         |             |             |             | ESEH    | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell Partial   Foreign Cheque    USD |                                                                                                                         |       |       |       | USD          |
	| OPT-Exer & Hold        | OPT       | 3           | UPD       | ELA      | 24732       | I0036451840 | T              | 1000          |              |          | 21A           |               | 20150501EX |            | 1000        |             | 1000         |              |             |             | 1000          | 1000             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No |                                                                                         |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Hold All                             |                                                                                                                         |       |       |       |              |
	| OPT-Exer-Sell to Cover | OPT       | 3           | UPD       | ELA      | 24733       | I0035265678 | C              | 2000          |              | W        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-STC            Wire Payment          | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-STC            Wire Payment  |       |       |       |              |
	| OPT-NO Action          | OPT       | 3           | UPD       | ELA      | 24734       | I0036246634 | L              |               |              |          | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        |              |              |             |             | 2000          |                  |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                                 | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                         |       |       |       |              |
	| PRS-Exer-Sell All1     | PRS       | 4           | UPD       | ELA      | 24735       | I0035120696 | A              | 2000          |              | D        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Direct Credit         | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Direct Credit |       |       |       |              |
	| PRS-Exer-Sell All2     | PRS       | 4           | UPD       | ELA      | 24736       | I0036337826 | A              | 1500          |              | C        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 500          |             |             | 2000          | 1500             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Local Cheque          | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Local Cheque  |       |       |       |              |
	| PRS-Exer-Sell Partial  | PRS       | 4           | UPD       | ELA      | 24737       | I0035099786 | P              | 1000          | 750          | F        | 21A           |               | 20150501EX |            | 1000        |             | 1000         |              | 750         |             | 1000          | 1000             | 750           | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No |                                                                                         |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell Partial   Foreign Cheque    USD |                                                                                                                         |       |       |       | USD          |
	| PRS-Exer & Hold        | PRS       | 4           | UPD       | ELA      | 246738      | I0036451840 | T              | 1000          |              |          | 21A           |               | 20150501EE |            | 1000        |             | 1000         |              |             |             | 1000          | 1000             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |                                                                                         |             |             |             | ESEH    | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Hold All                             |                                                                                                                         |       |       |       |              |
#	| PRS-Exer-Sell to Cover | PRS       | 4           | UPD       | ELA      | 24739       | I0035265678 | C              | 2000          |              | W        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-STC            Wire Payment          | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-STC            Wire Payment  |       |       |       |              |
	| PRS-NO Action          | PRS       | 4           | UPD       | ELA      | 24740       | I0036246634 | L              |               |              |          | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        |              |              |             |             | 2000          |                  |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                                 | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                         |       |       |       |              |

@winformsTest
@NAB2_AUTO
@39699
@EP_EmployeePlanProcessing
#Options Plan
Scenario Outline: Test Case 39699: 7_ELC. Change Holder Election Details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03401 I Select Holder as "<TransNumber>" "<SearchName>"
		And In EOL03401 I Add/Modify Event Election Details as "<DisposalChoice>" "<ExerciseUnits>" "<PartialUnits>" "<PymtMthd>" "<CurrencyCode>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<ExerciseBal1>" "<ExerciseBal2>" "<CurrentBal1>" "<CurrentBal2>" "<TotEventUnits>" "<TotExerciseUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test    | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | DisposalChoice | ExerciseUnits | PartialUnits | PymtMthd | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | ExerciseBal1 | ExerciseBal2 | CurrentBal1 | CurrentBal2 | TotEventUnits | TotExerciseUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                                                                           | Line2                                                                                                                           | Line3 | Line4 | Line5 | CurrencyCode |
	| OPT-A-L | OPT       | 3           | UPD       | ELC      | 24741       | I0900513534 | L              |               |              |          | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        |              |              |             |             | 2000          |                  |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                                 | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                                 |       |       |       |              |
	| OPT-C-P | OPT       | 3           | UPD       | ELC      | 24742       | I0036186062 | P              | 2000          | 500          | C        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         | 500         |             | 2000          | 2000             | 500           | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell Partial   Local Cheque          | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell Partial   Local Cheque          |       |       |       |              |
	| OPT-P-C | OPT       | 3           | UPD       | ELC      | 24743       | I0035618635 | C              | 2000          |              | F        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-STC            Foreign Cheque    GBP | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-STC            Foreign Cheque    GBP |       |       |       | GBP          |
	| OPT-L-A | OPT       | 3           | UPD       | ELC      | 24744       | I0036127643 | A              | 1001          |              | D        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1            |             |             | 2000          | 1001             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Direct Credit         | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Direct Credit         |       |       |       |              |
	| OPT-L-T | OPT       | 3           | UPD       | ELC      | 24745       | I0036126141 | T              | 1500          |              |          | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 500          |             |             | 2000          | 1500             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Hold All                             | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Hold All                             |       |       |       |              |
	| PRS-A-L | PRS       | 4           | UPD       | ELC      | 24746       | I0900513534 | T              | 2000          |              |          | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Hold All                             | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Hold All                             |       |       |       |              |
	| PRS-P-L | PRS       | 4           | UPD       | ELC      | 24747       | I0036186062 | L              |               |              |          | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        |              |              |             |             | 2000          |                  |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                                 | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      No Action                                 |       |       |       |              |
	| PRS-L-P | PRS       | 4           | UPD       | ELC      | 24748       | I0035618635 | P              | 500           | 400          | F        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 500          |              | 400         |             | 2000          | 500              | 400           | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell Partial   Foreign Cheque    USD | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell Partial   Foreign Cheque    USD |       |       |       | USD          |
	| PRS-T-A | PRS       | 4           | UPD       | ELC      | 24749       | I0036127643 | A              | 2000          |              | C        | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Local Cheque          | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Received    Not Actioned    E      Exer-Sell All       Local Cheque          |       |       |       |              |

@winformsTest
@NAB2_AUTO
@39742
@EP_EmployeePlanProcessing
#Options Plan
Scenario Outline: Test Case 39742: 8_ELD. Delete Holder Election Details
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03407 I Delete Event details as "<TransNumber>" "<SearchName>" "<DisposalChoice>" "<DisposalChoiceDesc>" "<PymtMthd>" "<PymtMthdDesc>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<ExerciseBal1>" "<ExerciseBal2>" "<CurrentBal1>" "<CurrentBal2>" "<TotEventUnits>" "<TotExerciseUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | DisposalChoice | DisposalChoiceDesc        | PymtMthd | PymtMthdDesc              | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | ExerciseBal1 | ExerciseBal2 | CurrentBal1 | CurrentBal2 | TotEventUnits | TotExerciseUnits | TotCurrentBal | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                            | Line2                                                                            | Line3 | Line4 | Line5 |
	| OPT-A | OPT       | 3           | UPD       | ELD      | 24750       | I0036003847 | A              | Exercise and Sell All     | C        | Cheque                    | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E |       |       |       |
	| OPT-P | OPT       | 3           | UPD       | ELD      | 24751       | I0035152041 | P              | Exercise and Sell Partial | D        | Direct Credit - Permanent | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         | 100         |             | 2000          | 2000             | 100           | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E |       |       |       |
	| PRS-A | PRS       | 4           | UPD       | ELD      | 24752       | I0036003847 | A              | Exercise and Sell All     | C        | Cheque                    | 21A           | 21A           | 20150501EE | 20150501EX | 1000        | 1000        | 1000         | 1000         |             |             | 2000          | 2000             |               | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E |       |       |       |
	| PRS-P | PRS       | 4           | UPD       | ELD      | 24753       | I0035152041 | P              | Exercise and Sell Partial | D        | Direct Credit - Permanent | 21A           |               | 20150501EE |            | 1000        |             | 1000         |              | 500         |             | 1000          | 1000             | 500           | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |                                                                                         |             |             |             | ESEH    | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Deleted     Not Actioned    E |                                                                                  |       |       |       |

@winformsTest
@NAB2_AUTO
@40651
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 40651: 5_TAX. Update Holder Tax/International Assignee Details-Add/Delete-I Type Event-DEP
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL02901 I Add Event Tax Details for I type as "<TransNumber>" "<SearchName>" "<UpdtAllCert>" "<WitholdingTaxRate>" "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | UpdtAllCert | WitholdingTaxRate | RegisterCode1 | CertID1    | WthldgTaxRate1 | RegisterCode2 | CertID2    | WthldgTaxRate2 | Action | LocateArgument | SchemeName                     | DetailLine1                                                      | DetailLine2                                                      | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                  | Line2                                                                  | Line3 | Line4 | Line5 |
	| OPT-Y | OPT       | 4           | UPD       | TAX      | 24754       | I0035711538 | Y           | 45.000000         | 21A           | 20150501EE | 45.000000      | 21A           | 20150501EX | 45.000000      | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  30/06/2021  DS7    I           45.000000 | 21A  EE     01/05/2015  30/06/2021  DS7    I           45.000000 |             |             |             | ESEH    | I/DS7  21A  EX   30/06/2021  01/05/2015  Current   Unknown     Unknown | I/DS7  21A  EE   30/06/2021  01/05/2015  Current   Unknown     Unknown |       |       |       |
	| OPT-N | OPT       | 4           | UPD       | TAX      | 24755       | I0036268832 | N           |                   | 21A           | 20150501EE | 45.000000      | 21A           | 20150501EX | 45.000000      | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  30/06/2021  DS7    I           45.000000 | 21A  EE     01/05/2015  30/06/2021  DS7    I           45.000000 |             |             |             | ESEH    | I/DS7  21A  EX   30/06/2021  01/05/2015  Current   Unknown     Unknown | I/DS7  21A  EE   30/06/2021  01/05/2015  Current   Unknown     Unknown |       |       |       |
	| PRS-Y | PRS       | 5           | UPD       | TAX      | 24756       | I0035711538 | Y           | 45.000000         | 21A           | 20150501EE | 45.000000      | 21A           | 20150501EX | 45.000000      | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  30/06/2021  DS8    I           45.000000 | 21A  EE     01/05/2015  30/06/2021  DS8    I           45.000000 |             |             |             | ESEH    | I/DS8  21A  EX   30/06/2021  01/05/2015  Current   Unknown     Unknown | I/DS8  21A  EE   30/06/2021  01/05/2015  Current   Unknown     Unknown |       |       |       |
	| PRS-N | PRS       | 5           | UPD       | TAX      | 24757       | I0036268832 | N           |                   | 21A           | 20150501EE | 45.000000      | 21A           | 20150501EX | 45.000000      | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  30/06/2021  DS8    I           45.000000 | 21A  EE     01/05/2015  30/06/2021  DS8    I           45.000000 |             |             |             | ESEH    | I/DS8  21A  EX   30/06/2021  01/05/2015  Current   Unknown     Unknown | I/DS8  21A  EE   30/06/2021  01/05/2015  Current   Unknown     Unknown |       |       |       |

@winformsTest
@NAB2_AUTO
@39986
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 39986: 10_TAX. Update Holder Tax/International Assignee Details-T Type
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL02901 I Add Event Tax Details as "<TransNumber>" "<SearchName>" "<UpdtAllCert>" "<WitholdingTaxRate>" "<WitholdingTaxCode>" "<MarketValueType>" "<ComplexHolderCode>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	#Then In  EOL02904 I Verify Event Tax details as "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | UpdtAllCert | WitholdingTaxRate | WitholdingTaxCode | MarketValueType | ComplexHolderCode | WthldgTaxRate1 | WthldgTaxCode1 | MktValueType1 | CmplxHldrCode1 | WthldgTaxRate2 | WthldgTaxCode2 | MktValueType2 | CmplxHldrCode2 | RegisterCode1 | CertID1    | RegisterCode2 | CertID2    | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1 | Line2 | Line3 | Line4 | Line5 |
	| OPT-Y | OPT       | 5           | UPD       | TAX      | 24758       | I0031346100 | Y           | 45.000000         | AUS-RES           | F               |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | F             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/07/2021  DS9    T           45.000000          F          No | 21A  EE     01/05/2015  01/07/2021  DS9    T           45.000000          F          No |             |             |             | ESEH    |       |       |       |       |       |
	| OPT-N | OPT       | 5           | UPD       | TAX      | 24759       | I0036114436 | N           |                   |                   |                 |                   | 45.000000      | AUS-RES        | M             |                | 42.500000      | AUS-RES        | F             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/07/2021  DS9    T           42.500000          F          No | 21A  EE     01/05/2015  01/07/2021  DS9    T           45.000000          M          No |             |             |             | ESEH    |       |       |       |       |       |
	| PRS-Y | PRS       | 6           | UPD       | TAX      | 24760       | I0031346100 | Y           | 45.000000         | AUS-RES           | F               |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | F             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/07/2021  ES9    T           45.000000          F          No | 21A  EE     01/05/2015  01/07/2021  ES9    T           45.000000          F          No |             |             |             | ESEH    |       |       |       |       |       |
	| PRS-N | PRS       | 6           | UPD       | TAX      | 24761       | I0036114436 | N           |                   |                   |                 |                   | 45.000000      | AUS-RES        | M             |                | 42.500000      | AUS-RES        | F             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/07/2021  ES9    T           42.500000          F          No | 21A  EE     01/05/2015  01/07/2021  ES9    T           45.000000          M          No |             |             |             | ESEH    |       |       |       |       |       |

@winformsTest
@NAB2_AUTO
@35795
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35795: 5_DTX. Delete Holder Tax/International Assignee Details
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL02901 I Delete Event Tax Details as "<TransNumber>" "<SearchName>" "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test    | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | RegisterCode1 | CertID1    | WthldgTaxRate1 | WthldgTaxCode1 | MktValueType1 | CmplxHldrCode1 | RegisterCode2 | CertID2    | WthldgTaxRate2 | WthldgTaxCode2 | MktValueType2 | CmplxHldrCode2 | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Line1                                                                            | Line2                                                                            | Line3 | Line4 | Line5 | Action1 |
	| OPT-V   | OPT       | 3           | UPD       | DTX      | 312057      | I0035738461 | 21A           | 20150501EE | 45.000000      | AUS-RES        | F             |                | 21A           | 20150501EX | 40.000000      | AUS-RES        | M             |                | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS5    V            0.000000                     No |             |             |             | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       | ESEH    |
	| PRS-V   | PRS       | 4           | UPD       | DTX      | 312058      | I0035738461 | 21A           | 20150501EE | 45.000000      | AUS-RES        | F             |                | 21A           | 20150501EX | 45.000000      | AUS-RES        | F             |                | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V            0.000000                     No | 21A  EE     01/05/2015  01/01/2020  DS6    V            0.000000                     No |             |             |             | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       | ESEH    |
	| OPT-I-N | OPT       | 4           | UPD       | DTX      | 247544      | I0036470810 | 21A           | 20150501EE | 45.000000      |                |               |                | 21A           | 20150501EX | 40.000000      |                |               |                | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  30/06/2021  DS7    I            0.000000                        | 21A  EE     01/05/2015  30/06/2021  DS7    I            0.000000                        |             |             |             | I/DS7  21A  EX   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           | I/DS7  21A  EE   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           |       |       |       | ESEH    |
	| OPT-I-Y | OPT       | 4           | UPD       | DTX      | 247555      | I0034820503 | 21A           | 20150501EE | 45.000000      |                |               |                | 21A           | 20150501EX | 45.000000      |                |               |                | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  30/06/2021  DS7    I            0.000000                        | 21A  EE     01/05/2015  30/06/2021  DS7    I            0.000000                        |             |             |             | I/DS7  21A  EX   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           | I/DS7  21A  EE   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           |       |       |       | ESEH    |
	| PRS-I-Y | PRS       | 5           | UPD       | DTX      | 247566      | I0036470810 | 21A           | 20150501EE | 45.000000      |                |               |                | 21A           | 20150501EX | 45.000000      |                |               |                | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  30/06/2021  DS8    I            0.000000                        | 21A  EE     01/05/2015  30/06/2021  DS8    I            0.000000                        |             |             |             | I/DS8  21A  EX   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           | I/DS8  21A  EE   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           |       |       |       | ESEH    |
	| PRS-I-N | PRS       | 5           | UPD       | DTX      | 247577      | I0034820503 | 21A           | 20150501EE | 45.000000      |                |               |                | 21A           | 20150501EX | 42.500000      |                |               |                | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  30/06/2021  DS8    I            0.000000                        | 21A  EE     01/05/2015  30/06/2021  DS8    I            0.000000                        |             |             |             | I/DS8  21A  EX   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           | I/DS8  21A  EE   30/06/2021  01/05/2015  Deleted   Unknown     Unknown           |       |       |       | ESEH    |
	| OPT-T-N | OPT       | 5           | UPD       | DTX      | 24762       | I0036140411 | 21A           | 20150501EE | 40.000000      | AUS-RES        | V             |                | 21A           | 20150501EX | 45.000000      | AUS-RES        | M             |                | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/07/2021  DS9    T            0.000000                     No | 21A  EE     01/05/2015  01/07/2021  DS9    T            0.000000                     No |             |             |             |                                                                                  |                                                                                  |       |       |       | ESEH    |
	| OPT-T-Y | OPT       | 5           | UPD       | DTX      | 24763       | I0036140712 | 21A           | 20150501EE | 42.500000      | AUS-RES        | F             |                | 21A           | 20150501EX | 42.500000      | AUS-RES        | F             |                | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/07/2021  DS9    T            0.000000                     No | 21A  EE     01/05/2015  01/07/2021  DS9    T            0.000000                     No |             |             |             |                                                                                  |                                                                                  |       |       |       | ESEH    |
    | PRS-T-N | PRS       | 6           | UPD       | DTX      | 24764       | I0036140411 | 21A           | 20150501EE | 40.000000      | AUS-RES        | V             |                | 21A           | 20150501EX | 45.000000      | AUS-RES        | M             |                | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/07/2021  ES9    T            0.000000                     No | 21A  EE     01/05/2015  01/07/2021  ES9    T            0.000000                     No |             |             |             |                                                                                  |                                                                                  |       |       |       | ESEH    |
	| PRS-T-Y | PRS       | 6           | UPD       | DTX      | 244765      | I0036140712 | 21A           | 20150501EE | 42.500000      | AUS-RES        | F             |                | 21A           | 20150501EX | 42.500000      | AUS-RES        | F             |                | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/07/2021  ES9    T            0.000000                     No | 21A  EE     01/05/2015  01/07/2021  ES9    T            0.000000                     No |             |             |             |                                                                                  |                                                                                  |       |       |       | ESEH    |

@winformsTest
@NAB2_AUTO
@35794
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35794: 4_TAX. Update Holder Tax/International Assignee Details-V Type
#Options Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL02901 I Add Event Tax Details as "<TransNumber>" "<SearchName>" "<UpdtAllCert>" "<WitholdingTaxRate>" "<WitholdingTaxCode>" "<MarketValueType>" "<ComplexHolderCode>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	#Then In  EOL02904 I Verify Event Tax details as "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"

Examples: 
	| Test           | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | UpdtAllCert | WitholdingTaxRate | WitholdingTaxCode | MarketValueType | ComplexHolderCode | WthldgTaxRate1 | WthldgTaxCode1 | MktValueType1 | CmplxHldrCode1 | WthldgTaxRate2 | WthldgTaxCode2 | MktValueType2 | CmplxHldrCode2 | RegisterCode1 | CertID1    | RegisterCode2 | CertID2    | Action | LocateArgument | SchemeName                     | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3 | DetailLine4 | DetailLine5 | Action1 | Line1                                                                            | Line2                                                                            | Line3 | Line4 | Line5 |
	| Options Plan-Y | OPT       | 3           | UPD       | TAX      | 312053      | I0034480826 | Y           | 45.000000         | AUS-RES           | F               |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | F             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V           45.000000          F          No | 21A  EE     01/05/2015  01/01/2020  DS5    V           45.000000          F          No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       |
	| Rights Plan-Y  | PRS       | 4           | UPD       | TAX      | 312054      | I0034480826 | Y           | 45.000000         | AUS-RES           | M               |                   | 45.000000      | AUS-RES        | M             |                | 45.000000      | AUS-RES        | M             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V           45.000000          M          No | 21A  EE     01/05/2015  01/01/2020  DS6    V           45.000000          M          No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       |
	| Options Plan-N | OPT       | 3           | UPD       | TAX      | 312055      | I0036400668 | N           |                   |                   |                 |                   | 45.000000      | AUS-RES        | F             |                | 40.000000      | AUS-RES        | M             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 21A  EX     01/05/2015  01/01/2020  DS5    V           40.000000          M          No | 21A  EE     01/05/2015  01/01/2020  DS5    V           45.000000          F          No |             |             |             | ESEH    | V/DS5  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS5  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       |
	| Rights Plan -N | PRS       | 4           | UPD       | TAX      | 312056      | I0036400668 | N           |                   |                   |                 |                   | 45.000000      | AUS-RES        | F             |                | 40.000000      | AUS-RES        | M             |                | 21A           | 20150501EE | 21A           | 20150501EX | EETD   | /PRS           | PERFORMANCE RIGHTS             | 21A  EX     01/05/2015  01/01/2020  DS6    V           40.000000          M          No | 21A  EE     01/05/2015  01/01/2020  DS6    V           45.000000          F          No |             |             |             | ESEH    | V/DS6  21A  EX   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E | V/DS6  21A  EE   01/01/2020  01/05/2015  Current   Not Recvd   Not Actioned    E |       |       |       |

@winformsTest
@NAB2_AUTO
@31216
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35988: Product Backlog Item 31216:AWL. Manual Award
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "awards" Menu
		And In EOL00901 I Add Award details as "<RegisterCode>" "<Selection>" "<AppropDate>" "<TransNumber>" "<TotalMoney>" "<TotalUnits>" "<SearchName>" "<RegisterType1>" "<Units1>" "<Money1>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |


Examples: 
	| Test  | ClassCode | RegisterCode | Selection | AppropDate | TransNumber | TotalMoney | TotalUnits | SearchName  | RegisterType1 | Units1 | Money1 | Action | LocateArgument | Line1                              | Line2                                                                                | Line3                                                       | Line4 | Line5 | Line6 | Line7 | Line8 | Line9 | Line10 |
	| Test1 | ELA       | 99A          | AWL       | 12/11/1999 | 312059      | 500.00     | 500        | I0036377208 | Loan          | 500    | 500.00 | ESLB   | /ELA           | ELA STF SHARE OWNERSHIP PLAN(LOAN) | 99A 0000035642 12/11/1999        500        500.00         500.00     No           0 | *Plan Total              500*       500.00*        500.00 * |       |       |       |       |       |       |        |


@NAB2_AUTO
@35989
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 35989: Product Backlog Item 31217:RVA. Reversal Of Award
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "awards" Menu
		And In EOL00401 I go to Reveral Transaction Menu "<RegisterCode>" "<Selection>" 
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |

Examples: 
	| Test  | ClassCode | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | SearchName  | Action | LocateArgument | Line1                              | Line2                                                                                | Line3                                                                                | Line4                                                       | Line5 | RegisterCode | Selection | TotalMoney | Line6 | Line7 | Line8 | Line9 | Line10 |
	| Test1 | ELA       | 312060      | 500        | 7846           | 24723            | I0035112715 | ESLB   | /ELA           | ELA STF SHARE OWNERSHIP PLAN(LOAN) | 97A 0000035583 14/11/1997        500        500.00         500.00     No           0 | 99A 0000035582 12/11/1999          0          0.00           0.00     No           0 | *Plan Total              500*       500.00*        500.00 * |       | 99A          | RVA       |            |       |       |       |       |        |

@winformsTest
@NAB2_AUTO
@36029
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 36029: Product Backlog Item 31987:RMN. Manual Regular Payment
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection>" 
		And In EOL01901 I Add Manual Payment Details as "<TransNumber>" "<PaymentDate>" "<PaymentAmount>" "<SearchName>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS20 I should see Loan Transactions as "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"

Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | PaymentDate | PaymentAmount | SearchName  | Action | LocateArgument | Line1                              | Line2                                                                                | Line3                                                       | Line4 | Line5 | Action1 | LocateArgument1 | DLine1                                                | DLine2                                               | DLine3                           | DLine4 | DLine5 | Line6 | Line7 | Line8 | Line9 | Line10 |
	| Test1 | ELA       | 99A          | RMN       | 24724       | 01/01/2014  | 100.00        | I0036108282 | ESLB   | /ELA           | ELA STF SHARE OWNERSHIP PLAN(LOAN) | 99A 0000035584 12/11/1999        500       1000.00         900.00     No           0 | *Plan Total              500*      1000.00*        900.00 * |       |       | ESLT    | /ELA/99A        | 12/11/1999 ESAWL  7847/00024239/0001         1000.00- | 01/01/2014 ESRPY  7849/00024724/0001          100.00 | * Loan Total            900.00-* |        |        |       |       |       |       |        |

@winformsTest
@NAB2_AUTO
@36030
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 36030: Product Backlog Item 31988:AMN. Manual Adhoc Payment
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO" 
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection>" 
		And In EOL01901 I Add Manual Payment Details as "<TransNumber>" "<PaymentDate>" "<PaymentAmount>" "<SearchName>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS20 I should see Loan Transactions as "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"

Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | PaymentDate | PaymentAmount | SearchName  | Action | LocateArgument | Line1                              | Line2                                                                                | Line3                                                       | Line4 | Line5 | Action1 | LocateArgument1 | DLine1                                                | DLine2                                               | DLine3                           | DLine4 | DLine5 | Line6 | Line7 | Line8 | Line9 | Line10 |
	| Test1 | ELA       | 99A          | AMN       | 234525      | 01/01/2014  | 100.00        | I0035310258 | ESLB   | /ELA           | ELA STF SHARE OWNERSHIP PLAN(LOAN) | 99A 0000035585 12/11/1999        500       1000.00         900.00     No           0 | *Plan Total              500*      1000.00*        900.00 * |       |       | ESLT    | /ELA/99A        | 12/11/1999 ESAWL  7847/00024240/0001         1000.00- | 01/01/2014 ESAPY  7849/00234525/0001          100.00 | * Loan Total            900.00-* |        |        |       |       |       |       |        |

@winformsTest
@NAB2_AUTO
@36032
@EP_EmployeePlanProcessing
#Loan Plan
Scenario Outline: Test Case 36032: Product Backlog Item 31990:RVM. Payment Reversal
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL00401 I go to Reveral Transaction Menu "<RegisterCode>" "<Selection>" 
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "NAB2_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |

Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | TotalMoney | RvsalRunNumber | RvsalTransNumber | SearchName  | Action | LocateArgument | Line1                              | Line2                                                                                | Line3                                                       | Line4 | Line5 | Action1 | LocateArgument1 | DLine1                                                | DLine2                                                                            | DLine3                                                                            | DLine4                                                                            | DLine5                                                                            | TotalUnits | Line6 | Line7 | Line8 | Line9 | Line10 |
	| Test1 | ELA       | 99A          | RVM       | 244726      | 200.00     | 7849           | 00005401         | I0036384956 | ESLB   | /ELA           | ELA STF SHARE OWNERSHIP PLAN(LOAN) | 99A 0000035586 12/11/1999        500       1000.00         800.00     No           0 | *Plan Total              500*      1000.00*        800.00 * |       |       | ESLT    | /ELA/99A        | 12/11/1999 ESAWL  7847/00024241/0001         1000.00- | 01/01/2014 ESRPY  7847/00024242/0001          100.00                              | 01/01/2014 ESRPY  7849/00005400/0001          100.00                              | 01/05/2014 ESAPY  7849/00005401/0001          200.00                7850/02134324 | 01/05/2014 ESRVM  7850/02134324/0001          200.00-               7849/00005401 |            |       |       |       |       |        |
	| Test2 | ELA       | 99A          | RVM       | 244727      | 100.00     | 7847           | 00000340         | I0036475412 | ESLB   | /ELA           | ELA STF SHARE OWNERSHIP PLAN(LOAN) | 99A 0000035587 12/11/1999        500       1000.00        1000.00     No           0 | *Plan Total              500*      1000.00*       1000.00 * |       |       | ESLT    | /ELA/99A        | 12/11/1999 ESAWL  7847/00000339/0001         1000.00- | 01/01/2014 ESAPY  7847/00000340/0001          100.00                7850/00004327 | 01/01/2014 ESRVM  7850/00004327/0001          100.00-               7847/00000340 | * Loan Total           1000.00-*                                                  |                                                                                   |            |       |       |       |       |        |

@winformsTest
@CPU_AUTO
@40288
@EP_EmployeePlanProcessing
#AESS Plan
@FullSmokeTest
Scenario Outline: Test Case 40288: 1_Add/Change/Delete Holder Event-DEP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03301 I Add AESS Event details as "<TransNumber>" "<SearchName>" "<SelectionInd1>" "<SelectionInd2>" "<SelectionInd3>" "<SelectionInd4>" "<SelectionInd8>" "<SelectionInd9>" "<SelectionInd10>" "<2SelectionInd1>" "<2SelectionInd2>" "<2SelectionInd3>" "<TotEventUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem1>"
		And In EOL03304 I Change AESS Event details as "<TransNumber1>" "<SearchName>" "<CSelectionInd1>" "<CSelectionInd2>" "<CSelectionInd3>" "<CSelectionInd4>" "<CSelectionInd8>" "<CSelectionInd9>" "<CSelectionInd10>" "<C2SelectionInd1>" "<C2SelectionInd2>" "<C2SelectionInd3>" "<CTotEventUnits>" "<CTotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<CDetailLine1>" "<CDetailLine2>" "<CDetailLine3>" "<CDetailLine4>" "<CDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<CLine1>" "<CLine2>" "<CLine3>" "<CLine4>" "<CLine5>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem2>"
		And In EOL03307 I Delete Event details as "<TransNumber2>" "<SearchName>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<CurrentBal1>" "<CurrentBal2>" "<CTotEventUnits>" "<CTotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DDetailLine1>" "<DDetailLine2>" "<DDetailLine3>" "<DDetailLine4>" "<DDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"


Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | SelectionInd1 | SelectionInd2 | SelectionInd3 | SelectionInd4 | SelectionInd8 | SelectionInd9 | SelectionInd10 | 2SelectionInd1 | 2SelectionInd2 | 2SelectionInd3 | TotEventUnits | TotCurrentBal | Action | LocateArgument | SchemeName                   | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3                                                                             | DetailLine4                                                                             | DetailLine5                                                                             | Action1 | Line1                                                                            | Line2                                                                            | Line3                                                                            | Line4                                                                            | Line5                                                                            | MenuItem1 | TransNumber1 | CSelectionInd1 | CSelectionInd2 | CSelectionInd3 | CSelectionInd4 | CSelectionInd8 | CSelectionInd9 | CSelectionInd10 | C2SelectionInd1 | C2SelectionInd2 | C2SelectionInd3 | CTotEventUnits | CTotCurrentBal | CDetailLine1                                                                            | CDetailLine2                                                                            | CDetailLine3                                                                            | CDetailLine4                                                                            | CDetailLine5                                                                            | CLine1                                                                           | CLine2                                                                           | CLine3                                                                           | CLine4                                                                 | CLine5                                                                 | MenuItem2 | TransNumber2 | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | CurrentBal1 | CurrentBal2 | DDetailLine1                                                                            | DDetailLine2                                                                            | DDetailLine3                                                                            | DDetailLine4                                                                            | DDetailLine5                                                                            | DLine1                                                                           | DLine2                                                                           | DLine3                                                                           | DLine4                                                                 | DLine5                                                                 |
	| Test1 | DEP       | 3           | UPD       | ADD      | 4452123     | I0100002841 | Y             | Y             | Y             | Y             | Y             | Y             | Y              | Y              | Y              | Y              | 366           | 366           | EETD   | /DEP           | DEFERRED EMP SHARE PLAN - AU | 12A  EP     12/06/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     13/05/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/04/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/03/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/02/2013  01/01/2020  EV1    V            0.000000                     No | ESEH    | V/EV1  12A  EP   01/01/2020  12/06/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  13/05/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/04/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/03/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/02/2013  Current   Not Recvd   Not Actioned    E | CHG       | 4451235      | N              | N              | N              | N              | N              | N              | N               | N               | N               | N               | 87             | 87             | 12A  EP     12/06/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     13/05/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/04/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/03/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/02/2013  01/01/2020  EV1    V            0.000000                     No | V/EV1  12A  EP   01/01/2020  12/06/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  13/05/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/04/2013  Current   Not Recvd   Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/03/2013  Deleted   Deleted     Unknown | V/EV1  12A  EP   01/01/2020  12/02/2013  Deleted   Deleted     Unknown | DEL       | 4451236      | 12A           | 12A           | 20121012EP | 20121113EP | 13          | 14          | 13          | 14          | 12A  EP     12/06/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     13/05/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/04/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/03/2013  01/01/2020  EV1    V            0.000000                     No | 12A  EP     12/02/2013  01/01/2020  EV1    V            0.000000                     No | V/EV1  12A  EP   01/01/2020  12/06/2013  Deleted   Deleted     Not Actioned    E | V/EV1  12A  EP   01/01/2020  13/05/2013  Deleted   Deleted     Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/04/2013  Deleted   Deleted     Not Actioned    E | V/EV1  12A  EP   01/01/2020  12/03/2013  Deleted   Deleted     Unknown | V/EV1  12A  EP   01/01/2020  12/02/2013  Deleted   Deleted     Unknown |

@winformsTest
@CPU_AUTO
@40379
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 40379: 2_TAX. Update Holder Tax/International Assignee Details-Add/Delete-V Type Event-DEP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03301 I Add AESS Event details as "<TransNumber>" "<SearchName>" "<SelectionInd1>" "<SelectionInd2>" "<SelectionInd3>" "<SelectionInd4>" "<SelectionInd8>" "<SelectionInd9>" "<SelectionInd10>" "<2SelectionInd1>" "<2SelectionInd2>" "<2SelectionInd3>" "<TotEventUnits>" "<TotCurrentBal>"
		And I PressESC
	Then I expect to be in the "EOL00135" Screen
	When In EOL00135 I select "<Selection1>" 
	When In EOL02901 I Add Event Tax Details as "<TransNumber1>" "<SearchName>" "<UpdtAllCert>" "<WitholdingTaxRate>" "<WitholdingTaxCode>" "<MarketValueType>" "<ComplexHolderCode>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
		And I PressESC
	Then I expect to be in the "EOL00135" Screen
	When In EOL00135 I select "<Selection2>" 
		And In EOL02901 I Delete Event Tax Details as "<TransNumbe2>" "<SearchName>" "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DDetailLine1>" "<DDetailLine2>" "<DDetailLine3>" "<DDetailLine4>" "<DDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | SelectionInd1 | SelectionInd2 | SelectionInd3 | SelectionInd4 | SelectionInd8 | SelectionInd9 | SelectionInd10 | 2SelectionInd1 | 2SelectionInd2 | 2SelectionInd3 | TotEventUnits | TotCurrentBal | Selection1 | TransNumber1 | UpdtAllCert | WitholdingTaxRate | WitholdingTaxCode | MarketValueType | ComplexHolderCode | WthldgTaxRate1 | WthldgTaxCode1 | MktValueType1 | CmplxHldrCode1 | WthldgTaxRate2 | WthldgTaxCode2 | MktValueType2 | CmplxHldrCode2 | Selection2 | TransNumbe2 | RegisterCode1 | CertID1    | RegisterCode2 | CertID2    | Action | LocateArgument | SchemeName                   | DDetailLine1                                                                            | DDetailLine2                                                                            | DDetailLine3                                                                            | DDetailLine4                                                                            | DDetailLine5                                                                            | Action1 | DLine1                                                                           | DLine2                                                                           | DLine3                                                                           | DLine4                                                                           | DLine5                                                                           |
	| Test1 | DEP       | 5           | UPD       | ADD      | 6451234     | I0030277988 | Y             | Y             | Y             | Y             | Y             | Y             | Y              | Y              |                |                | 1145          | 1145          | TAX        | 6451235      | Y           | 45.000000         | AUS-RES           | F               |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | F             |                | DTX        | 6451236     | 11A           | 20120213EM | 13A           | 20130712EM | EETD   | /DEP           | DEFERRED EMP SHARE PLAN - AU | 13A  EP     12/02/2014  01/01/2020  EV3    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV3    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV3    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV3    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV3    V            0.000000                     No | ESEH    | V/EV3  13A  EP   01/01/2020  12/02/2014  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  13/01/2014  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  12/12/2013  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  12/11/2013  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  14/10/2013  Current   Not Recvd   Not Actioned    E |
	| Test2 | DEP       | 5           | UPD       | ADD      | 4651234     | I0030227875 | Y             | Y             | Y             | Y             | Y             | Y             | Y              |                |                |                | 822           | 822           | TAX        | 4651235      | N           |                   |                   |                 |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | F             |                | DTX        | 7451237     | 13A           | 20130712EM | 13A           | 20130712EP | EETD   | /DEP           | DEFERRED EMP SHARE PLAN - AU | 13A  EP     12/02/2014  01/01/2020  EV3    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV3    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV3    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV3    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV3    V            0.000000                     No | ESEH    | V/EV3  13A  EP   01/01/2020  12/02/2014  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  13/01/2014  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  12/12/2013  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  12/11/2013  Current   Not Recvd   Not Actioned    E | V/EV3  13A  EP   01/01/2020  14/10/2013  Current   Not Recvd   Not Actioned    E |

@winformsTest
@CPU_AUTO
@40391
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 40391: 3_Add/Change/Delete Holder Election Details-DEP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03301 I Add AESS Event details as "<TransNumber>" "<SearchName>" "<SelectionInd1>" "<SelectionInd2>" "<SelectionInd3>" "<SelectionInd4>" "<SelectionInd8>" "<SelectionInd9>" "<SelectionInd10>" "<2SelectionInd1>" "<2SelectionInd2>" "<2SelectionInd3>" "<TotEventUnits>" "<TotCurrentBal>"
		And I PressESC
	Then I expect to be in the "EOL00135" Screen
	When In EOL00135 I select "<Selection1>" 
	And In EOL03401 I Select Holder as "<TransNumber1>" "<SearchName>"
		And In EOL03401 I Add/Modify Event Election Details as "<DisposalChoice>" "<ExerciseUnits>" "<PartialUnits>" "<PymtMthd>" "<CurrencyCode>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<ExerciseBal1>" "<ExerciseBal2>" "<CurrentBal1>" "<CurrentBal2>" "<TotEventUnits1>" "<TotExerciseUnits1>" "<TotCurrentBal1>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem1>"
		And In EOL03401 I Select Holder as "<TransNumber2>" "<SearchName>"
		And In EOL03401 I Add/Modify Event Election Details as "<CDisposalChoice>" "<CExerciseUnits>" "<CPartialUnits>" "<CPymtMthd>" "<CCurrencyCode>" "<CRegisterCode1>" "<CRegisterCode2>" "<CCertID1>" "<CCertID2>" "<CEventUnits1>" "<CEventUnits2>" "<CExerciseBal1>" "<CExerciseBal2>" "<CCurrentBal1>" "<CCurrentBal2>" "<CTotEventUnits>" "<CTotExerciseUnits>" "<CTotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<CLine1>" "<CLine2>" "<CLine3>" "<CLine4>" "<CLine5>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem3>"
		And In EOL03407 I Delete Event details as "<TransNumber3>" "<SearchName>" "<CDisposalChoice>" "<CDisposalChoiceDesc>" "<CPymtMthd>" "<CPymtMthdDesc>" "<CRegisterCode1>" "<CRegisterCode2>" "<CCertID1>" "<CCertID2>" "<CEventUnits1>" "<CEventUnits2>" "<CExerciseBal1>" "<CExerciseBal2>" "<CCurrentBal1>" "<CCurrentBal2>" "<CTotEventUnits>" "<CTotExerciseUnits>" "<CTotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | SelectionInd1 | SelectionInd2 | SelectionInd3 | SelectionInd4 | SelectionInd8 | SelectionInd9 | SelectionInd10 | 2SelectionInd1 | 2SelectionInd2 | 2SelectionInd3 | TotEventUnits | TotCurrentBal | Selection1 | TransNumber1 | DisposalChoice | ExerciseUnits | PartialUnits | PymtMthd | CurrencyCode | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | ExerciseBal1 | ExerciseBal2 | CurrentBal1 | CurrentBal2 | TotEventUnits1 | TotExerciseUnits1 | TotCurrentBal1 | Action1 | LocateArgument | SchemeName                   | Line1                                                                                                                           | Line2                                                                                                                           | Line3                                                                                                                           | Line4                                                                                                                           | Line5                                                                                                                           | TransNumber2 | CDisposalChoice | CExerciseUnits | CPartialUnits | CPymtMthd | CCurrencyCode | CRegisterCode1 | CRegisterCode2 | CCertID1   | CCertID2   | CEventUnits1 | CEventUnits2 | CExerciseBal1 | CExerciseBal2 | CCurrentBal1 | CCurrentBal2 | CTotEventUnits | CTotExerciseUnits | CTotCurrentBal | CLine1                                                                                                                          | CLine2                                                                                                                          | CLine3                                                                                                                          | CLine4                                                                                                                          | CLine5                                                                                                                          | TransNumber3 | CPymtMthdDesc             | MenuItem1 | CDisposalChoiceDesc | MenuItem3 | DLine1                                                                           | DLine2                                                                           | DLine3                                                                           | DLine4                                                                           | DLine5                                                                           |
	| Test1 | DEP       | 5           | UPD       | ADD      | 8451234     | I0030238648 | Y             | Y             | Y             | Y             | Y             | Y             | Y              | Y              | Y              | Y              | 597           | 597           | ELA        | 8451235      | A              |               |              | C        |              | 11A           | 11A           | 20110712EM | 20110712EP | 282         | 24          |              |              |             |             | 597            |                   |                | ESEH    | /DEP           | DEFERRED EMP SHARE PLAN - AU | V/EV3  11A  EP   01/01/2020  12/06/2012  Current   Received    Not Actioned    E      Sell All            Local Cheque          | V/EV3  11A  EP   01/01/2020  11/05/2012  Current   Received    Not Actioned    E      Sell All            Local Cheque          | V/EV3  11A  EP   01/01/2020  13/04/2012  Current   Received    Not Actioned    E      Sell All            Local Cheque          | V/EV3  11A  EP   01/01/2020  13/03/2012  Current   Received    Not Actioned    E      Sell All            Local Cheque          | V/EV3  11A  EP   01/01/2020  13/02/2012  Current   Received    Not Actioned    E      Sell All            Local Cheque          | 8451236      | P               |                | 300           | D         |               | 11A            | 11A            | 20110712EM | 20110712EP | 282          | 24           |               |               | 282          | 18           | 597            |                   | 300            | V/EV3  11A  EP   01/01/2020  12/06/2012  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  11A  EP   01/01/2020  11/05/2012  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  11A  EP   01/01/2020  13/04/2012  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  11A  EP   01/01/2020  13/03/2012  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  11A  EP   01/01/2020  13/02/2012  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | 8451237      | Direct Credit - Permanent | ELC       | Sell Partial        | ELD       | V/EV3  11A  EP   01/01/2020  12/06/2012  Current   Deleted     Not Actioned    E | V/EV3  11A  EP   01/01/2020  11/05/2012  Current   Deleted     Not Actioned    E | V/EV3  11A  EP   01/01/2020  13/04/2012  Current   Deleted     Not Actioned    E | V/EV3  11A  EP   01/01/2020  13/03/2012  Current   Deleted     Not Actioned    E | V/EV3  11A  EP   01/01/2020  13/02/2012  Current   Deleted     Not Actioned    E |
	| Test2 | DEP       | 5           | UPD       | ADD      | 855555      | I0100003643 | Y             | Y             | Y             | Y             | Y             | Y             | Y              | Y              | Y              | Y              | 3363          | 3363          | ELA        | 855556       | P              |               | 2000         | D        |              | 07A           | 07A           | 20070712EP | 20070725EM | 23          | 275         |              |              | 23          | 275         | 3363           |                   | 2000           | ESEH    | /DEP           | DEFERRED EMP SHARE PLAN - AU | V/EV3  12A  EP   01/01/2020  12/06/2013  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  12A  EP   01/01/2020  13/05/2013  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  12A  EP   01/01/2020  12/04/2013  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  12A  EP   01/01/2020  12/03/2013  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | V/EV3  12A  EP   01/01/2020  12/02/2013  Current   Received    Not Actioned    E      Sell Partial        Direct Credit         | 855557       | L               |                |               |           |               | 07A            | 07A            | 20070712EP | 20070725EM | 23           | 275          |               |               |              |              | 3363           |                   |                | V/EV3  12A  EP   01/01/2020  12/06/2013  Current   Received    Not Actioned    E      Leave in Plan                             | V/EV3  12A  EP   01/01/2020  13/05/2013  Current   Received    Not Actioned    E      Leave in Plan                             | V/EV3  12A  EP   01/01/2020  12/04/2013  Current   Received    Not Actioned    E      Leave in Plan                             | V/EV3  12A  EP   01/01/2020  12/03/2013  Current   Received    Not Actioned    E      Leave in Plan                             | V/EV3  12A  EP   01/01/2020  12/02/2013  Current   Received    Not Actioned    E      Leave in Plan                             | 855558       |                           | ELC       | Leave in Plan       | ELD       | V/EV3  12A  EP   01/01/2020  12/06/2013  Current   Deleted     Not Actioned    E | V/EV3  12A  EP   01/01/2020  13/05/2013  Current   Deleted     Not Actioned    E | V/EV3  12A  EP   01/01/2020  12/04/2013  Current   Deleted     Not Actioned    E | V/EV3  12A  EP   01/01/2020  12/03/2013  Current   Deleted     Not Actioned    E | V/EV3  12A  EP   01/01/2020  12/02/2013  Current   Deleted     Not Actioned    E |
	| Test3 | DEP       | 5           | UPD       | ADD      | 865555      | I0030238605 | Y             | Y             | Y             | Y             | Y             | Y             | Y              | Y              | Y              | Y              | 1021          | 1021          | ELA        | 865556       | C              |               |              | F        | USD          | 08A           | 08A           | 20081112EP | 20081117EM | 27          | 221         |              |              |             |             | 1021           |                   |                | ESEH    | /DEP           | DEFERRED EMP SHARE PLAN - AU | V/EV3  13A  EP   01/01/2020  12/02/2014  Current   Received    Not Actioned    E      Sell to Cover       Foreign Cheque    USD | V/EV3  13A  EP   01/01/2020  13/01/2014  Current   Received    Not Actioned    E      Sell to Cover       Foreign Cheque    USD | V/EV3  13A  EP   01/01/2020  12/12/2013  Current   Received    Not Actioned    E      Sell to Cover       Foreign Cheque    USD | V/EV3  13A  EP   01/01/2020  12/11/2013  Current   Received    Not Actioned    E      Sell to Cover       Foreign Cheque    USD | V/EV3  13A  EP   01/01/2020  14/10/2013  Current   Received    Not Actioned    E      Sell to Cover       Foreign Cheque    USD | 865557       | A               |                |               | F         | GBP           | 08A            | 08A            | 20081112EP | 20081117EM | 27           | 221          |               |               |              |              | 1021           |                   |                | V/EV3  13A  EP   01/01/2020  12/02/2014  Current   Received    Not Actioned    E      Sell All            Foreign Cheque    GBP | V/EV3  13A  EP   01/01/2020  13/01/2014  Current   Received    Not Actioned    E      Sell All            Foreign Cheque    GBP | V/EV3  13A  EP   01/01/2020  12/12/2013  Current   Received    Not Actioned    E      Sell All            Foreign Cheque    GBP | V/EV3  13A  EP   01/01/2020  12/11/2013  Current   Received    Not Actioned    E      Sell All            Foreign Cheque    GBP | V/EV3  13A  EP   01/01/2020  14/10/2013  Current   Received    Not Actioned    E      Sell All            Foreign Cheque    GBP | 865558       | Foreign Cheque            | ELC       | Sell All            | ELD       | V/EV3  13A  EP   01/01/2020  12/02/2014  Current   Deleted     Not Actioned    E | V/EV3  13A  EP   01/01/2020  13/01/2014  Current   Deleted     Not Actioned    E | V/EV3  13A  EP   01/01/2020  12/12/2013  Current   Deleted     Not Actioned    E | V/EV3  13A  EP   01/01/2020  12/11/2013  Current   Deleted     Not Actioned    E | V/EV3  13A  EP   01/01/2020  14/10/2013  Current   Deleted     Not Actioned    E |

@winformsTest
@CPU_AUTO
@40648
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 40648: 4_TAX. Update Holder Tax/International Assignee Details-Add/Delete-T Type Event
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL02901 I Add Event Tax Details as "<TransNumber>" "<SearchName>" "<UpdtAllCert>" "<WitholdingTaxRate>" "<WitholdingTaxCode>" "<MarketValueType>" "<ComplexHolderCode>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
		And I PressESC
	Then I expect to be in the "EOL00135" Screen
	When In EOL00135 I select "<Selection2>" 
		And In EOL02901 I Delete Event Tax Details as "<TransNumbe2>" "<SearchName>" "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DDetailLine1>" "<DDetailLine2>" "<DDetailLine3>" "<DDetailLine4>" "<DDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | UpdtAllCert | WitholdingTaxRate | WitholdingTaxCode | MarketValueType | ComplexHolderCode | WthldgTaxRate1 | WthldgTaxCode1 | MktValueType1 | CmplxHldrCode1 | WthldgTaxRate2 | WthldgTaxCode2 | MktValueType2 | CmplxHldrCode2 | Selection2 | TransNumbe2 | RegisterCode1 | CertID1    | RegisterCode2 | CertID2    | Action | LocateArgument | SchemeName                   | DDetailLine1                                                                            | DDetailLine2                                                                            | DDetailLine3                                                                            | DDetailLine4                                                                            | DDetailLine5                                                                            | Action1 | DLine1 | DLine2 | DLine3 | DLine4 | DLine5 |
	| Test1 | DEP       | 2           | UPD       | TAX      | 7777595     | I0030238605 | Y           | 45.000000         | AUS-RES           | F               |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | F             |                | DTX        | 7777566     | 13A           | 20130712EM | 13A           | 20130712EP | EETD   | /DEP           | DEFERRED EMP SHARE PLAN - AU | 13A  EP     12/02/2014  01/01/2020  TE1    T            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  TE1    T            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  TE1    T            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  TE1    T            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  TE1    T            0.000000                     No | ESEH    |        |        |        |        |        |
	| Test2 | DEP       | 2           | UPD       | TAX      | 8949566     | I0100007525 | N           |                   |                   |                 |                   | 45.000000      | AUS-RES        | F             |                | 45.000000      | AUS-RES        | M             |                | DTX        | 8775588     | 11A           | 20110712EM | 13A           | 20130712EM | EETD   | /DEP           | DEFERRED EMP SHARE PLAN - AU | 13A  EM     12/07/2013  01/01/2020  TE1    T            0.000000                     No | 11A  EM     12/07/2011  01/01/2020  TE1    T            0.000000                     No |                                                                                         |                                                                                         |                                                                                         | ESEH    |        |        |        |        |        |

@winformsTest
@CPU_AUTO
@41734
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41734: 1_Add/Change/Delete Holder Event-Exempt Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03301 I Add AESS Event details as "<TransNumber>" "<SearchName>" "<SelectionInd1>" "<SelectionInd2>" "<SelectionInd3>" "<SelectionInd4>" "<SelectionInd8>" "<SelectionInd9>" "<SelectionInd10>" "<2SelectionInd1>" "<2SelectionInd2>" "<2SelectionInd3>" "<TotEventUnits>" "<TotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DetailLine1>" "<DetailLine2>" "<DetailLine3>" "<DetailLine4>" "<DetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem1>"
		And In EOL03304 I Change AESS Event details as "<TransNumber1>" "<SearchName>" "<CSelectionInd1>" "<CSelectionInd2>" "<CSelectionInd3>" "<CSelectionInd4>" "<CSelectionInd8>" "<CSelectionInd9>" "<CSelectionInd10>" "<C2SelectionInd1>" "<C2SelectionInd2>" "<C2SelectionInd3>" "<CTotEventUnits>" "<CTotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<CDetailLine1>" "<CDetailLine2>" "<CDetailLine3>" "<CDetailLine4>" "<CDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<CLine1>" "<CLine2>" "<CLine3>" "<CLine4>" "<CLine5>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem2>"
		And In EOL03307 I Delete Event details as "<TransNumber2>" "<SearchName>" "<RegisterCode1>" "<RegisterCode2>" "<CertID1>" "<CertID2>" "<EventUnits1>" "<EventUnits2>" "<CurrentBal1>" "<CurrentBal2>" "<CTotEventUnits>" "<CTotCurrentBal>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DDetailLine1>" "<DDetailLine2>" "<DDetailLine3>" "<DDetailLine4>" "<DDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"


Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | SelectionInd1 | SelectionInd2 | SelectionInd3 | SelectionInd4 | SelectionInd8 | SelectionInd9 | SelectionInd10 | 2SelectionInd1 | 2SelectionInd2 | 2SelectionInd3 | TotEventUnits | TotCurrentBal | Action | LocateArgument | SchemeName                   | DetailLine1                                                                             | DetailLine2                                                                             | DetailLine3                                                                             | DetailLine4                                                                             | DetailLine5                                                                             | Action1 | Line1                                                                            | Line2                                                                            | Line3                                                                            | Line4                                                                            | Line5                                                                            | MenuItem1 | TransNumber1 | CSelectionInd1 | CSelectionInd2 | CSelectionInd3 | CSelectionInd4 | CSelectionInd8 | CSelectionInd9 | CSelectionInd10 | C2SelectionInd1 | C2SelectionInd2 | C2SelectionInd3 | CTotEventUnits | CTotCurrentBal | CDetailLine1                                                                            | CDetailLine2                                                                            | CDetailLine3                                                                            | CDetailLine4                                                                            | CDetailLine5                                                                            | CLine1                                                                           | CLine2                                                                           | CLine3                                                                           | CLine4                                                                           | CLine5                                                                           | MenuItem2 | TransNumber2 | RegisterCode1 | RegisterCode2 | CertID1    | CertID2    | EventUnits1 | EventUnits2 | CurrentBal1 | CurrentBal2 | DDetailLine1                                                                            | DDetailLine2                                                                            | DDetailLine3                                                                            | DDetailLine4                                                                            | DDetailLine5                                                                            | DLine1                                                                           | DLine2                                                                           | DLine3                                                                           | DLine4                                                                           | DLine5                                                                           |
	| Test1 | EXA       | 1           | UPD       | ADD      | 876655      | I0030277988 | Y             | Y             | Y             | Y             | Y             | Y             | Y              | Y              | Y              | Y              | 201           | 201           | EETD   | /EXA           | EXEMPT EMPLOYEE SHARE PLAN   | 13A  EP     12/02/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV5    V            0.000000                     No | ESEH    | V/EV5  13A  EP   01/01/2020  12/02/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  13/01/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/12/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/11/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  14/10/2013  Current   Not Recvd   Not Actioned    E | CHG       | 4452235      | N              | N              | N              | N              | N              | N              | N               | N               | N               | N               | 62             | 62             | 13A  EP     12/02/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV5    V            0.000000                     No | V/EV5  13A  EP   01/01/2020  12/02/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  13/01/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/12/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/11/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  14/10/2013  Current   Not Recvd   Not Actioned    E | DEL       | 4452236      | 12A           | 12A           | 20120912EP | 20121012EP | 5           | 5           | 5           | 5           | 13A  EP     12/02/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV5    V            0.000000                     No | V/EV5  13A  EP   01/01/2020  12/02/2014  Deleted   Deleted     Not Actioned    E | V/EV5  13A  EP   01/01/2020  13/01/2014  Deleted   Deleted     Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/12/2013  Deleted   Deleted     Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/11/2013  Deleted   Deleted     Not Actioned    E | V/EV5  13A  EP   01/01/2020  14/10/2013  Deleted   Deleted     Not Actioned    E |

@winformsTest
@CPU_AUTO
@41735
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41735: 2_TAX. Update Holder Tax/International Assignee Details-Add/Delete-V Type Event-Exempt Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00107 I Click on "event processing" Menu
		And In EOL00135 I Select Menu item as "<EventNumber>" "<Selection>" "<MenuItem>"
		And In EOL03301 I Add AESS Event details as "<TransNumber>" "<SearchName>" "<SelectionInd1>" "<SelectionInd2>" "<SelectionInd3>" "<SelectionInd4>" "<SelectionInd8>" "<SelectionInd9>" "<SelectionInd10>" "<2SelectionInd1>" "<2SelectionInd2>" "<2SelectionInd3>" "<TotEventUnits>" "<TotCurrentBal>"
		And I PressESC
	Then I expect to be in the "EOL00135" Screen
	When In EOL00135 I select "<Selection1>" 
	When In EOL02901 I Add Event Tax Details as "<TransNumber1>" "<SearchName>" "<UpdtAllCert>" "<WitholdingTaxRate>" "<WitholdingTaxCode>" "<MarketValueType>" "<ComplexHolderCode>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
		And I PressESC
	Then I expect to be in the "EOL00135" Screen
	When In EOL00135 I select "<Selection2>" 
		And In EOL02901 I Delete Event Tax Details as "<TransNumbe2>" "<SearchName>" "<RegisterCode1>" "<CertID1>" "<WthldgTaxRate1>" "<WthldgTaxCode1>" "<MktValueType1>" "<CmplxHldrCode1>" "<RegisterCode2>" "<CertID2>" "<WthldgTaxRate2>" "<WthldgTaxCode2>" "<MktValueType2>" "<CmplxHldrCode2>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS51 In should see Event Tax Details as "<ClassCode>" "<SchemeName>" "<DDetailLine1>" "<DDetailLine2>" "<DDetailLine3>" "<DDetailLine4>" "<DDetailLine5>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument>"
	Then In ENSESS40 I should see Event History Details as "<ClassCode>" "<SchemeName>" "<DLine1>" "<DLine2>" "<DLine3>" "<DLine4>" "<DLine5>"

Examples: 
	| Test  | ClassCode | EventNumber | Selection | MenuItem | TransNumber | SearchName  | SelectionInd1 | SelectionInd2 | SelectionInd3 | SelectionInd4 | SelectionInd8 | SelectionInd9 | SelectionInd10 | 2SelectionInd1 | 2SelectionInd2 | 2SelectionInd3 | TotEventUnits | TotCurrentBal | Selection1 | TransNumber1 | UpdtAllCert | WitholdingTaxRate | WitholdingTaxCode | MarketValueType | ComplexHolderCode | WthldgTaxRate1 | WthldgTaxCode1 | MktValueType1 | CmplxHldrCode1 | WthldgTaxRate2 | WthldgTaxCode2 | MktValueType2 | CmplxHldrCode2 | Selection2 | TransNumbe2 | RegisterCode1 | CertID1    | RegisterCode2 | CertID2    | Action | LocateArgument | SchemeName                 | DDetailLine1                                                                            | DDetailLine2                                                                            | DDetailLine3                                                                            | DDetailLine4                                                                            | DDetailLine5                                                                            | Action1 | DLine1                                                                           | DLine2                                                                           | DLine3                                                                           | DLine4                                                                           | DLine5                                                                           |
	| Test1 | EXA       | 1           | UPD       | ADD      | 689234      | I0030238605 | Y             | Y             | Y             | Y             | Y             | Y             | Y              |                |                |                | 511           | 511           | TAX        | 7351236      | Y           | 45.000000         | AUS-RES           | M               |                   | 45.000000      | AUS-RES        | M             |                | 45.000000      | AUS-RES        | M             |                | DTX        | 7751239     | 09A           | 20090828EM | 09A           | 20090914EP | EETD   | /EXA           | EXEMPT EMPLOYEE SHARE PLAN | 13A  EP     12/02/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV5    V            0.000000                     No | ESEH    | V/EV5  13A  EP   01/01/2020  12/02/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  13/01/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/12/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/11/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  14/10/2013  Current   Not Recvd   Not Actioned    E |
	| Test2 | EXA       | 1           | UPD       | ADD      | 665334      | I0030238206 | Y             | Y             | Y             | Y             | Y             | Y             | Y              |                |                |                | 418           | 418           | TAX        | 7351237      | N           |                   |                   |                 |                   | 40.000000      | AUS-RES        | M             |                | 45.000000      | AUS-RES        | V             |                | DTX        | 7751240     | 10A           | 20100712EM | 10A           | 20100712EP | EETD   | /EXA           | EXEMPT EMPLOYEE SHARE PLAN | 13A  EP     12/02/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     13/01/2014  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/12/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     12/11/2013  01/01/2020  EV5    V            0.000000                     No | 13A  EP     14/10/2013  01/01/2020  EV5    V            0.000000                     No | ESEH    | V/EV5  13A  EP   01/01/2020  12/02/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  13/01/2014  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/12/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  12/11/2013  Current   Not Recvd   Not Actioned    E | V/EV5  13A  EP   01/01/2020  14/10/2013  Current   Not Recvd   Not Actioned    E |

@winformsTest
@CPU_AUTO
@41938
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41938: 11_ESFRL. Forfeiture for Leavers_All
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL01301 I Perform Forfeiture Transaction as:
		| Selection   | TransNumber   | TransDate   | SearchName   | ForfUnits1   | ForfUnits2   | ForfUnits3   | ForfUnits4   | ForfUnits5   | ForfUnits6   | ForfUnits7   | ForfUnits8   | ForfUnits9   | ForfUnits10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | ForfUnits11   | ForfUnits22   | ForfUnits33   | ForfUnits44   | AvailUnitsT   | ForfUnitsT   |
		| <Selection> | <TransNumber> | <TransDate> | <SearchName> | <ForfUnits1> | <ForfUnits2> | <ForfUnits3> | <ForfUnits4> | <ForfUnits5> | <ForfUnits6> | <ForfUnits7> | <ForfUnits8> | <ForfUnits9> | <ForfUnits10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <ForfUnits11> | <ForfUnits22> | <ForfUnits33> | <ForfUnits44> | <AvailUnitsT> | <ForfUnitsT> |

Examples: 
	| Test  | ClassCode | Selection | TransNumber | TransDate | SearchName  | ForfUnits1 | ForfUnits2 | ForfUnits3 | ForfUnits4 | ForfUnits5 | ForfUnits6 | ForfUnits7 | ForfUnits8 | ForfUnits9 | ForfUnits10 | AvailUnits1 | AvailUnits2 | ForfUnits11 | ForfUnits22 | AvailUnitsT | ForfUnitsT | AvailUnits3 | AvailUnits4 | ForfUnits33 | ForfUnits44 |
	| Test1 | DEP       | ESFRL     | 9923334     |           | I0030278305 | 148        |            |            |            |            |            |            |            |            |             | 148         |             | 148         |             | 148         | 148        |             |             |             |             |

@winformsTest
@CPU_AUTO
@41939
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41939: 12_ESFRL. Forfeiture for Leavers_Partial
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL01301 I Perform Forfeiture Transaction as:
		| Selection   | TransNumber   | TransDate    | SearchName   | ForfUnits1   | ForfUnits2   | ForfUnits3   | ForfUnits4   | ForfUnits5   | ForfUnits6   | ForfUnits7   | ForfUnits8   | ForfUnits9   | ForfUnits10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | ForfUnits11   | ForfUnits22   | ForfUnits33   | ForfUnits44   | AvailUnitsT   | ForfUnitsT   |
		| <Selection> | <TransNumber1> | <TransDate> | <SearchName> | <ForfUnits1> | <ForfUnits2> | <ForfUnits3> | <ForfUnits4> | <ForfUnits5> | <ForfUnits6> | <ForfUnits7> | <ForfUnits8> | <ForfUnits9> | <ForfUnits10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <ForfUnits11> | <ForfUnits22> | <ForfUnits33> | <ForfUnits44> | <AvailUnitsT> | <ForfUnitsT> |
		And I PressESC
	Then I expect to be in the "EOL00119" Screen
	When In EOL00119 I continue with the following details:
	| Selection   |
	| <Selection1> |
	When In EOL00401 I continue with the following details:
	| TransNumber    | TotalUnits   | RvsalRunNumber   | RvsalTransNumber   | TotalMoney   |
	| <TransNumber> | <TotalUnits> | <RvsalRunNumber> | <RvsalTransNumber> | <TotalMoney> |
Examples: 
	| Test  | ClassCode | Selection | TransNumber1 | TransDate | SearchName  | ForfUnits1 | ForfUnits2 | ForfUnits3 | ForfUnits4 | ForfUnits5 | ForfUnits6 | ForfUnits7 | ForfUnits8 | ForfUnits9 | ForfUnits10 | AvailUnits1 | AvailUnits2 | ForfUnits11 | ForfUnits22 | AvailUnitsT | ForfUnitsT | Selection1 | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney | AvailUnits3 | AvailUnits4 | ForfUnits33 | ForfUnits44 |
	| Test1 | DEP       | ESFRL     | 9923335      |           | I0030237803 | 200        |            |            |            |            |            |            |            |            |             | 338         |             | 200         |             | 338         | 200        | ESRVF      | 9923338     | 200        | 4408           | 9923335          |            |             |             |             |             |

@winformsTest
@CPU_AUTO
@41896
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41896: 07_ESFRT. Performance Test Failure Forfeiture_EP, EM, EB, EN_All
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL01301 I Perform Forfeiture Transaction as:
		| Selection   | TransNumber   | TransDate   | SearchName   | ForfUnits1   | ForfUnits2   | ForfUnits3   | ForfUnits4   | ForfUnits5   | ForfUnits6   | ForfUnits7   | ForfUnits8   | ForfUnits9   | ForfUnits10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | ForfUnits11   | ForfUnits22   | ForfUnits33   | ForfUnits44   | AvailUnitsT   | ForfUnitsT   |
		| <Selection> | <TransNumber> | <TransDate> | <SearchName> | <ForfUnits1> | <ForfUnits2> | <ForfUnits3> | <ForfUnits4> | <ForfUnits5> | <ForfUnits6> | <ForfUnits7> | <ForfUnits8> | <ForfUnits9> | <ForfUnits10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <ForfUnits11> | <ForfUnits22> | <ForfUnits33> | <ForfUnits44> | <AvailUnitsT> | <ForfUnitsT> |
		And I PressESC
	Then I expect to be in the "EOL00119" Screen
	When In EOL00119 I continue with the following details:
	| Selection   |
	| <Selection1> |
	When In EOL00401 I continue with the following details:
	| TransNumber    | TotalUnits   | RvsalRunNumber   | RvsalTransNumber   | TotalMoney   |
	| <TransNumber1> | <TotalUnits> | <RvsalRunNumber> | <RvsalTransNumber> | <TotalMoney> |
Examples: 
	| Test  | ClassCode | Selection | TransNumber | TransDate | SearchName  | ForfUnits1 | ForfUnits2 | ForfUnits3 | ForfUnits4 | ForfUnits5 | ForfUnits6 | ForfUnits7 | ForfUnits8 | ForfUnits9 | ForfUnits10 | AvailUnits1 | AvailUnits2 | AvailUnits3 | AvailUnits4 | ForfUnits11 | ForfUnits22 | ForfUnits33 | ForfUnits44 | AvailUnitsT | ForfUnitsT | Selection1 | TransNumber1 | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney |
	| Test1 | DEP       | ESFRT     | 9923346     |           | I0100007762 | 125        | 120        | 510        | 6320       | 2100       | 4521       | 2310       | 287        | 406        | 297         | 7075        | 8931        | 990         | 210         | 7075        | 8931        | 990         | 210         | 18027       | 18027      | ESRVF      | 9923347      | 18027      |                | 9923346          |            |

@winformsTest
@CPU_AUTO
@41936
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41936: 09_ESTOC. Termination of Contract_EP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL01401 I continue with the following details:
		| Selection   | RegisterType   | RegisterCode   | TransNumber   | TransDate   | SearchName   | SearchUsan   | SavingsAmount   | InterestAmount   | ChequeAmount   |
		| <Selection> | <RegisterType> | <RegisterCode> | <TransNumber> | <TransDate> | <SearchName> | <SearchUsan> | <SavingsAmount> | <InterestAmount> | <ChequeAmount> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
	When In EOL00119 I continue with the following details:
	| Selection   |
	| <Selection1> |
	When In EOL00401 I continue with the following details:
	| TransNumber    | TotalUnits   | RvsalRunNumber   | RvsalTransNumber   | TotalMoney   |
	| <TransNumber1> | <TotalUnits> | <RvsalRunNumber> | <RvsalTransNumber> | <TotalMoney> |


Examples: 
	| Test  | ClassCode | Selection | RegisterType | RegisterCode | TransNumber | TransDate | SearchName  | SearchUsan | SavingsAmount | InterestAmount | ChequeAmount | Selection1 | TransNumber1 | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney |
	| Test1 | DEP       | ESTOC     | EP           | 13A          | 9923348     |           | I0030238486 |            | 6.31          | 0.00           | 6.31         | ESRVQ      | 9923349      |            |                | 9923348          | 6.31       |

@winformsTest
@CPU_AUTO
@41887
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41887: 01_ESFRE Employee Requested Forfeiture
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL01301 I Perform Forfeiture Transaction as:
		| Selection   | TransNumber   | TransDate   | SearchName   | ForfUnits1   | ForfUnits2   | ForfUnits3   | ForfUnits4   | ForfUnits5   | ForfUnits6   | ForfUnits7   | ForfUnits8   | ForfUnits9   | ForfUnits10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | ForfUnits11   | ForfUnits22   | ForfUnits33   | ForfUnits44   | AvailUnitsT   | ForfUnitsT   |
		| <Selection> | <TransNumber> | <TransDate> | <SearchName> | <ForfUnits1> | <ForfUnits2> | <ForfUnits3> | <ForfUnits4> | <ForfUnits5> | <ForfUnits6> | <ForfUnits7> | <ForfUnits8> | <ForfUnits9> | <ForfUnits10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <ForfUnits11> | <ForfUnits22> | <ForfUnits33> | <ForfUnits44> | <AvailUnitsT> | <ForfUnitsT> |
		And I PressESC
	Then I expect to be in the "EOL00119" Screen
	When In EOL00119 I continue with the following details:
	| Selection   |
	| <Selection1> |
	When In EOL00401 I continue with the following details:
	| TransNumber    | TotalUnits   | RvsalRunNumber   | RvsalTransNumber   | TotalMoney   |
	| <TransNumber1> | <TotalUnits> | <RvsalRunNumber> | <RvsalTransNumber> | <TotalMoney> |
Examples: 
	| Test              | ClassCode | Selection | TransNumber | TransDate | SearchName  | ForfUnits1 | ForfUnits2 | ForfUnits3 | ForfUnits4 | ForfUnits5 | ForfUnits6 | ForfUnits7 | ForfUnits8 | ForfUnits9 | ForfUnits10 | AvailUnits1 | AvailUnits2 | AvailUnits3 | AvailUnits4 | ForfUnits11 | ForfUnits22 | ForfUnits33 | ForfUnits44 | AvailUnitsT | ForfUnitsT | Selection1 | TransNumber1 | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney |
	| Test1-DEP-All     | DEP       | ESFRE     | 9923337     |           | I0030280334 | 1000       | 1000       | 338        | 247        | 1000       | 28         | 25         | 24         | 25         | 24          | 2000        | 585         | 1000        | 428         | 2000        | 585         | 1000        | 428         | 4013        | 4013       | ESRVF      | 9923339      | 4013       |                | 9923337          |            |
	| Test2-DEP-Partial | DEP       | ESFRE     | 9923340     |           | I0100003422 | 1000       | 1000       | 1000       | 1000       | 1000       | 1000       | 1000       | 1000       | 188        | 24          | 10200       | 5800        | 1391        | 6500        | 4000        | 4000        | 1140        | 6500        | 25841       | 17590      | ESRVF      | 9923341      | 17590      |                | 9923340          |            |
	| Test3-EXA-All     | EXA       | ESFRE     | 9923350     |           | I0030234171 | 57         | 56         | 67         | 49         | 4          | 4          | 5          | 5          | 7          | 6           | 229         | 209         |             |             | 229         | 209         |             |             | 438         | 438        | ESRVF      | 9923351      | 438        |                | 9923350          |            |
	| Test4-EXA-Partial | EXA       | ESFRE     | 9923352     |           | I0030281730 | 10         | 1          | 1          | 1          | 1          | 1          | 1          | 1          | 1          | 1           | 49          | 30          |             |             | 10          | 8           |             |             | 79          | 18         | ESRVF      | 9923353      | 18         |                | 9923352          |            |

@winformsTest
@CPU_AUTO
@41892
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 41892: 04_ESFRC. Company Requested Forfeiture
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL01301 I Perform Forfeiture Transaction as:
		| Selection   | TransNumber   | TransDate   | SearchName   | ForfUnits1   | ForfUnits2   | ForfUnits3   | ForfUnits4   | ForfUnits5   | ForfUnits6   | ForfUnits7   | ForfUnits8   | ForfUnits9   | ForfUnits10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | ForfUnits11   | ForfUnits22   | ForfUnits33   | ForfUnits44   | AvailUnitsT   | ForfUnitsT   |
		| <Selection> | <TransNumber> | <TransDate> | <SearchName> | <ForfUnits1> | <ForfUnits2> | <ForfUnits3> | <ForfUnits4> | <ForfUnits5> | <ForfUnits6> | <ForfUnits7> | <ForfUnits8> | <ForfUnits9> | <ForfUnits10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <ForfUnits11> | <ForfUnits22> | <ForfUnits33> | <ForfUnits44> | <AvailUnitsT> | <ForfUnitsT> |
		And I PressESC
	Then I expect to be in the "EOL00119" Screen
	When In EOL00119 I continue with the following details:
	| Selection   |
	| <Selection1> |
	When In EOL00401 I continue with the following details:
	| TransNumber    | TotalUnits   | RvsalRunNumber   | RvsalTransNumber   | TotalMoney   |
	| <TransNumber1> | <TotalUnits> | <RvsalRunNumber> | <RvsalTransNumber> | <TotalMoney> |
Examples: 
	| Test              | ClassCode | Selection | TransNumber | TransDate | SearchName  | ForfUnits1 | ForfUnits2 | ForfUnits3 | ForfUnits4 | ForfUnits5 | ForfUnits6 | ForfUnits7 | ForfUnits8 | ForfUnits9 | ForfUnits10 | AvailUnits1 | AvailUnits2 | AvailUnits3 | AvailUnits4 | ForfUnits11 | ForfUnits22 | ForfUnits33 | ForfUnits44 | AvailUnitsT | ForfUnitsT | Selection1 | TransNumber1 | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney |
	| Test1-DEP-All     | DEP       | ESFRC     | 9923342     |           | I0100002493 | 2100       | 1020       | 4100       | 5100       | 4120       | 3200       | 1500       | 6200       | 339        | 338         | 12320       | 15020       | 924         | 1000        | 12320       | 15020       | 924         | 1000        | 30070       | 30070      | ESRVF      | 9923343      | 30070      |                | 9923342          |            |
	| Test2-DEP-Partial | DEP       | ESFRC     | 9923344     |           | I0030279042 | 200        | 200        | 200        | 200        | 200        | 200        | 200        | 200        | 200        | 200         | 7483        | 8321        | 585         | 210         | 800         | 600         | 400         | 200         | 17026       | 2427       | ESRVF      | 9923345      | 2427       |                | 9923344          |            |
	| Test3-EXA-Partial | EXA       | ESFRC     | 9923354     |           | I0030249283 | 50         | 2          | 2          | 2          | 2          | 2          | 2          | 2          | 2          | 2           | 67          | 54          |             |             | 50          | 31          |             |             | 121         | 81         | ESRVF      | 9923355      | 81         |                | 9923354          |            |


@winformsTest
@CPU_AUTO
@41951
@EP_EmployeePlanProcessing
#AESS Plan
# Need to Add data after Praveen finish his data setup
Scenario Outline: Test Case 41951: 01_ESPAY ESS Payment Manual_EP_Deferred
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "payments" Menu
		When In EOL01901 I continue with the following details:
		| RegisterType   | RegisterCode   | Selection   | TransNumber   | PaymentFrequency   | AccumPeriod   | PaymentNumber   | PaymentStatus   | Eol01901ReceiptCurrency   | PaymentDate   | PaymentAmount   | EmployerPymtAmt   | Eol01901ExchangeRate   | SearchName   |
		| <RegisterType> | <RegisterCode> | <Selection> | <TransNumber> | <PaymentFrequency> | <AccumPeriod> | <PaymentNumber> | <PaymentStatus> | <Eol01901ReceiptCurrency> | <PaymentDate> | <PaymentAmount> | <EmployerPymtAmt> | <Eol01901ExchangeRate> | <SearchName> |
Examples: 
	| Test  | ClassCode | RegisterType | RegisterCode | Selection | TransNumber | PaymentFrequency | AccumPeriod | PaymentNumber | PaymentStatus | Eol01901ReceiptCurrency | PaymentDate | PaymentAmount | EmployerPymtAmt | Eol01901ExchangeRate | SearchName |
	| Test1 | DEP       | EP           | 13A          | MAN       |             |                  |             |               |               |                         |             |               |                 |                      |            |

@winformsTest
@CPU_AUTO
@42876
@EP_EmployeePlanProcessing
#AESS Plan
Scenario Outline: Test Case 42876: 01_ESAWM - ESS Manual Award
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "awards" Menu
		And In EOL00901 I continue with the following details to Add Awards:
		| RegisterType   | RegisterCode   | Selection   | AppropDate   | TransNumber   | RetentionDate   | TaxRetentionDate   | TotalUnits   | SearchName   | TotalUnits1   | RegisterType1   | Units1   | Money1   | RetentionDate1   | TaxRetentionDate1   |
		| <RegisterType> | <RegisterCode> | <Selection> | <AppropDate> | <TransNumber> | <RetentionDate> | <TaxRetentionDate> | <TotalUnits> | <SearchName> | <TotalUnits1> | <RegisterType1> | <Units1> | <Money1> | <RetentionDate1> | <TaxRetentionDate1> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1   | DetailLine2   | DetailLine3   | DetailLine4   | DetailLine5   | DetailLine6   | DetailLine7   | DetailLine8   | DetailLine9   | DetailLine10   |
	| <SearchName> | <DetailLine1> | <DetailLine2> | <DetailLine3> | <DetailLine4> | <DetailLine5> | <DetailLine6> | <DetailLine7> | <DetailLine8> | <DetailLine9> | <DetailLine10> |


Examples: 
		| Test     | ClassCode | RegisterType | RegisterCode | Selection | AppropDate | TransNumber | RetentionDate | TaxRetentionDate | TotalUnits | SearchName  | TotalUnits1 | RegisterType1 | Units1 | Money1  | RetentionDate1 | TaxRetentionDate1 | Action | LocateArgument | DetailLine1                                                                               | DetailLine2 | DetailLine3                                                                                       | DetailLine4                                                                                       | DetailLine5                                                                                       | DetailLine6 | DetailLine7                                                                                       | DetailLine8 | DetailLine9 | DetailLine10 |
		| Test1-EM | DEP       | EM           | 13A          | AWM       | 12/07/2013 | 9923356     |               |                  | 100        | I0030057929 | 100         | Matching      | 100    | 1008.00 | Unchanged      | Unchanged         | ESHT   | /DEP           | 13A EM T 12/07/2013  None        None        12/07/2015      100   10.080000      1008.00 |             | * Register Type Totals                                                             MV at 21/04/15 | *                 Available  Unavailable    Reserved     Balance   Total Cost           12.700000 | *   EM                  100            0           0         100      1008.00             1270.00 |             | ** Plan Total           100            0           0         100*     1008.00*            1270.00 |             |             |              |
		| Test2-EB | DEP       | EB           | 13A          | AWM       | 12/07/2013 | 9923357     |               |                  | 100        | I0030234171 | 100         | Bonus         | 100    | 1080.00 | Unchanged      | Unchanged         | ESHT   | /DEP           | 13A EB T 12/07/2013  None        None        12/07/2014      100   10.800000      1080.00 |             | * Register Type Totals                                                             MV at 21/04/15 | *                 Available  Unavailable    Reserved     Balance   Total Cost           12.700000 | *   EB                  100            0           0         100      1080.00             1270.00 |             | ** Plan Total           100            0           0         100*     1080.00*            1270.00 |             |             |              |

@winformsTest
@CPU_AUTO
@41947
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 41947: 15_ESLVA. Leaver Processing-All
#Deferred Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL02201 I Perform Leaver Processing Transaction as:
		| Selection   | TransNumber   | TransDate   | SearchName   | Register1   | Register2   | Register3   | Register4   | Register5   | Register6   | Register7   | Register8   | Register9   | CertID1   | CertID2   | CertID3   | CertID4   | CertID5   | CertID6   | CertID7   | CertID8   | CertID9   | CurrBal1   | CurrBal2   | CurrBal3   | CurrBal4   | CurrBal5   | CurrBal6   | CurrBal7   | CurrBal8   | CurrBal9   | RelImm1   | RelImm2   | RelImm3   | RelImm4   | RelImm5   | RelImm6   | RelImm7   | RelImm8   | RelImm9   | MaintRest1   | MaintRest2   | MaintRest3   | MaintRest4   | MaintRest5   | MaintRest6   | MaintRest7   | MaintRest8   | MaintRest9   | ForfNow1   | ForfNow2   | ForfNow3   | ForfNow4   | ForfNow5   | ForfNow6   | ForfNow7   | ForfNow8   | ForfNow9   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | AvailUnits5   | AvailUnits6   | AvailUnits7   | AvailUnits8   | AvailUnits9   | AvailDate1   | AvailDate2   | AvailDate3   | AvailDate4   | AvailDate5   | AvailDate6   | AvailDate7   | AvailDate8   | AvailDate9   | RestEndDate1   | RestEndDate2   | RestEndDate3   | RestEndDate4   | RestEndDate5   | RestEndDate6   | RestEndDate7   | RestEndDate8   | RestEndDate9   | Register10   | CertID10   | CurrBal10   | RelImm10   | MaintRest10   | ForfNow10   | AvailUnits10   | AvailDate10   | RestEndDate10 |
		| <Selection> | <TransNumber> | <TransDate> | <SearchName> | <Register1> | <Register2> | <Register3> | <Register4> | <Register5> | <Register6> | <Register7> | <Register8> | <Register9> | <CertID1> | <CertID2> | <CertID3> | <CertID4> | <CertID5> | <CertID6> | <CertID7> | <CertID8> | <CertID9> | <CurrBal1> | <CurrBal2> | <CurrBal3> | <CurrBal4> | <CurrBal5> | <CurrBal6> | <CurrBal7> | <CurrBal8> | <CurrBal9> | <RelImm1> | <RelImm2> | <RelImm3> | <RelImm4> | <RelImm5> | <RelImm6> | <RelImm7> | <RelImm8> | <RelImm9> | <MaintRest1> | <MaintRest2> | <MaintRest3> | <MaintRest4> | <MaintRest5> | <MaintRest6> | <MaintRest7> | <MaintRest8> | <MaintRest9> | <ForfNow1> | <ForfNow2> | <ForfNow3> | <ForfNow4> | <ForfNow5> | <ForfNow6> | <ForfNow7> | <ForfNow8> | <ForfNow9> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <AvailUnits5> | <AvailUnits6> | <AvailUnits7> | <AvailUnits8> | <AvailUnits9> | <AvailDate1> | <AvailDate2> | <AvailDate3> | <AvailDate4> | <AvailDate5> | <AvailDate6> | <AvailDate7> | <AvailDate8> | <AvailDate9> | <RestEndDate1> | <RestEndDate2> | <RestEndDate3> | <RestEndDate4> | <RestEndDate5> | <RestEndDate6> | <RestEndDate7> | <RestEndDate8> | <RestEndDate9> | <Register10> | <CertID10> | <CurrBal10> | <RelImm10> | <MaintRest10> | <ForfNow10> | <AvailUnits10> | <AvailDate10> | <RestEndDate10> |
		And In EOL02204 I Perform Leaver Processing Transaction as:
		| Register1   | Register2   | Register3   | Register4   | Register5   | Register6   | Register7   | Register8   | Register9   | CertID1   | CertID2   | CertID3   | CertID4   | CertID5   | CertID6   | CertID7   | CertID8   | CertID9   | RelImm1   | RelImm2   | RelImm3   | RelImm4   | RelImm5   | RelImm6   | RelImm7   | RelImm8   | RelImm9   | MaintRest1   | MaintRest2   | MaintRest3   | MaintRest4   | MaintRest5   | MaintRest6   | MaintRest7   | MaintRest8   | MaintRest9   | ForfNow1   | ForfNow2   | ForfNow3   | ForfNow4   | ForfNow5   | ForfNow6   | ForfNow7   | ForfNow8   | ForfNow9   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | AvailUnits5   | AvailUnits6   | AvailUnits7   | AvailUnits8   | AvailUnits9   | RestEndDate1   | RestEndDate2   | RestEndDate3   | RestEndDate4   | RestEndDate5   | RestEndDate6   | RestEndDate7   | RestEndDate8   | RestEndDate9   | AvailDate1   | AvailDate2   | AvailDate3   | AvailDate4   | AvailDate5   | AvailDate6   | AvailDate7   | AvailDate8   | AvailDate9   | Register10   | CertID10   | CurrBal10   | RelImm10   | MaintRest10   | ForfNow10   | AvailUnits10   | AvailDate10   | RestEndDate10 |
		| <Register1> | <Register2> | <Register3> | <Register4> | <Register5> | <Register6> | <Register7> | <Register8> | <Register9> | <CertID1> | <CertID2> | <CertID3> | <CertID4> | <CertID5> | <CertID6> | <CertID7> | <CertID8> | <CertID9> | <RelImm1> | <RelImm2> | <RelImm3> | <RelImm4> | <RelImm5> | <RelImm6> | <RelImm7> | <RelImm8> | <RelImm9> | <MaintRest1> | <MaintRest2> | <MaintRest3> | <MaintRest4> | <MaintRest5> | <MaintRest6> | <MaintRest7> | <MaintRest8> | <MaintRest9> | <ForfNow1> | <ForfNow2> | <ForfNow3> | <ForfNow4> | <ForfNow5> | <ForfNow6> | <ForfNow7> | <ForfNow8> | <ForfNow9> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <AvailUnits5> | <AvailUnits6> | <AvailUnits7> | <AvailUnits8> | <AvailUnits9> | <RestEndDate1> | <RestEndDate2> | <RestEndDate3> | <RestEndDate4> | <RestEndDate5> | <RestEndDate6> | <RestEndDate7> | <RestEndDate8> | <RestEndDate9> | <AvailDate1> | <AvailDate2> | <AvailDate3> | <AvailDate4> | <AvailDate5> | <AvailDate6> | <AvailDate7> | <AvailDate8> | <AvailDate9> | <Register10> | <CertID10> | <CurrBal10> | <RelImm10> | <MaintRest10> | <ForfNow10> | <AvailUnits10> | <AvailDate10> | <RestEndDate10> |  
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1   | DetailLine2   | DetailLine3   | DetailLine4   | DetailLine5   | DetailLine6   | DetailLine7   | DetailLine8   | DetailLine9   | DetailLine10   |
	| <SearchName> | <DetailLine1> | <DetailLine2> | <DetailLine3> | <DetailLine4> | <DetailLine5> | <DetailLine6> | <DetailLine7> | <DetailLine8> | <DetailLine9> | <DetailLine10> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1    | DetailLine2    | DetailLine3    | DetailLine4    | DetailLine5    | DetailLine6    | DetailLine7    | DetailLine8    | DetailLine9    | DetailLine10    |
	| <SearchName> | <DetailLine1a> | <DetailLine2a> | <DetailLine3a> | <DetailLine4a> | <DetailLine5a> | <DetailLine6a> | <DetailLine7a> | <DetailLine8a> | <DetailLine9a> | <DetailLine10a> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1    | DetailLine2    | DetailLine3    | DetailLine4    | DetailLine5    | DetailLine6    | DetailLine7    | DetailLine8    | DetailLine9    | DetailLine10    |
	| <SearchName> | <DetailLine1b> | <DetailLine2b> | <DetailLine3b> | <DetailLine4b> | <DetailLine5b> | <DetailLine6b> | <DetailLine7b> | <DetailLine8b> | <DetailLine9b> | <DetailLine10b> |


Examples: 
		| Test  | ClassCode | Selection | TransNumber | TransDate | SearchName  | Register1 | Register2 | Register3 | Register4 | Register5 | Register6 | Register7 | Register8 | Register9 | CertID1    | CertID2    | CertID3    | CertID4    | CertID5    | CertID6    | CertID7    | CertID8    | CertID9    | CurrBal1 | CurrBal2 | CurrBal3 | CurrBal4 | CurrBal5 | CurrBal6 | CurrBal7 | CurrBal8 | CurrBal9 | RelImm1 | RelImm2 | RelImm3 | RelImm4 | RelImm5 | RelImm6 | RelImm7 | RelImm8 | RelImm9 | MaintRest1 | MaintRest2 | MaintRest3 | MaintRest4 | MaintRest5 | MaintRest6 | MaintRest7 | MaintRest8 | MaintRest9 | ForfNow1 | ForfNow2 | ForfNow3 | ForfNow4 | ForfNow5 | ForfNow6 | ForfNow7 | ForfNow8 | ForfNow9 | AvailUnits1 | AvailUnits2 | AvailUnits3 | AvailUnits4 | AvailUnits5 | AvailUnits6 | AvailUnits7 | AvailUnits8 | AvailUnits9 | AvailDate1 | AvailDate2 | AvailDate3 | AvailDate4 | AvailDate5 | AvailDate6 | AvailDate7 | AvailDate8 | AvailDate9 | RestEndDate1 | RestEndDate2 | RestEndDate3 | RestEndDate4 | RestEndDate5 | RestEndDate6 | RestEndDate7 | RestEndDate8 | RestEndDate9 | Action | LocateArgument | DetailLine1                                                                               | DetailLine2                                                                               | DetailLine3                                                                               | DetailLine4                                                                               | DetailLine5                                                                               | DetailLine6                                                                               | DetailLine7                                                                               | DetailLine8                                                                               | DetailLine9                                                                               | DetailLine10                                                                              | Action1 | LocateArgument1 | DetailLine1a                                                                              | DetailLine2a                                                                              | DetailLine3a                                                                              | DetailLine4a                                                                              | DetailLine5a                                                                              | DetailLine6a                                                                              | DetailLine7a                                                                              | DetailLine8a                                                                              | DetailLine9a                                                                              | DetailLine10a | DetailLine1b | DetailLine2b                                                                                      | DetailLine3b                                                                                      | DetailLine4b                                                                                      | DetailLine5b                                                                                      | DetailLine6b                                                                                      | DetailLine7b                                                                                      | DetailLine8b                                                                                      | DetailLine9b | DetailLine10b                                                                                     | Register10 | CertID10 | CurrBal10 | RelImm10 | MaintRest10 | ForfNow10 | AvailUnits10 | AvailDate10 | RestEndDate10 |
		| Test1 | DEP       | ESLVA     | 9993357     |           | I0030284101 | 11A       | 13A       | 13A       | 13A       | 13A       | 13A       | 13A       | 13A       | 13A       | 20110712EF | 20130712EP | 20130812EP | 20130912EP | 20131014EP | 20131112EP | 20131212EP | 20140113EP | 20140212EP | 1000     | 22       | 22       | 23       | 23       | 21       | 33       | 20       | 20       | 1000    | 22      | 22      | 23      | 23      | 21      | 33      | 20      | 20      |            |            |            |            |            |            |            |            |            |          |          |          |          |          |          |          |          |          |             |             |             |             |             |             |             |             |             |            |            |            |            |            |            |            |            |            | 12/07/2019   | 12/07/2020   | 12/07/2020   | 12/07/2020   | 12/07/2020   | 12/07/2020   | 12/07/2020   | 12/07/2020   | 12/07/2020   | ESHT   | /DEP           | 10A EF T 12/07/2010  12/07/2013  12/07/2013  None           3100   10.000000     31000.00 | 11A EF T 12/07/2011  12/07/2019  12/07/2014  None           1000   10.000000     10000.00 | 11B EB T 12/07/2011  None        None        12/07/2012      450   10.800000      4860.00 | 11B EN T 12/07/2011  None        None        None            102   10.000000      1020.00 | 11A EM T 13/02/2012  13/02/2014  13/02/2014  13/02/2014      186    8.040000      1495.44 | 11A EP T 13/02/2012  13/02/2013  13/02/2013  13/02/2013       37    8.020000       296.74 | 11A EP T 13/03/2012  13/02/2013  13/02/2013  13/02/2013       37    8.150000       301.55 | 11A EP T 13/04/2012  13/02/2013  13/02/2014  13/02/2013       34    8.640000       293.76 | 11A EP T 11/05/2012  13/02/2013  13/02/2014  13/02/2013       37    8.310000       307.47 | 11A EP T 12/06/2012  13/02/2013  13/02/2014  13/02/2013       39    7.670000       299.13 | M       |                 | 12A EB T 12/07/2012  None        None        12/07/2013      620   10.800000      6696.00 | 13A EP   12/07/2013  12/07/2020  12/07/2020  None             22   10.390000       228.58 | 13A EP   12/08/2013  12/07/2020  12/07/2020  None             22   10.260000       225.72 | 13A EP   12/09/2013  12/07/2020  12/07/2020  None             23   10.230000       235.29 | 13A EP   14/10/2013  12/07/2020  12/07/2020  None             23    9.940000       228.62 | 13A EP   12/11/2013  12/07/2020  12/07/2020  None             21   10.890000       228.69 | 13A EP   12/12/2013  12/07/2020  12/07/2020  None             33   10.640000       351.12 | 13A EP   13/01/2014  12/07/2020  12/07/2020  None             20   11.380000       227.60 | 13A EP   12/02/2014  12/07/2020  12/07/2020  None             20   11.640000       232.80 |               |              | * Register Type Totals                                                             MV at 21/04/15 | *                 Available  Unavailable    Reserved     Balance   Total Cost           12.700000 | *   EF                 4100            0           0        4100     41000.00            52070.00 | *   EM                  186            0           0         186      1495.44             2362.20 | *   EP                  368            0           0         368      3457.07             4673.60 | *   EB                 1070            0           0        1070     11556.00            13589.00 | *   EN                  102            0           0         102      1020.00             1295.40 |              | ** Plan Total          5826            0           0        5826*    58528.51*           73990.20 |            |          |           |          |             |           |              |             |               |

@winformsTest
@CPU_AUTO
@41947
@EP_EmployeePlanProcessing
@FullSmokeTest
Scenario Outline: Test Case 41947: 15_ESLVA. Leaver Processing-Partial
#Deferred Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00113 I click on "forfeitures and terminations" Menu
		And In EOL02201 I Perform Leaver Processing Transaction as:
		| Selection   | TransNumber   | TransDate   | SearchName   | Register1   | Register2   | Register3   | Register4   | Register5   | Register6   | Register7   | Register8   | Register9   | Register10   | CertID1   | CertID2   | CertID3   | CertID4   | CertID5   | CertID6   | CertID7   | CertID8   | CertID9   | CertID10   | CurrBal1   | CurrBal2   | CurrBal3   | CurrBal4   | CurrBal5   | CurrBal6   | CurrBal7   | CurrBal8   | CurrBal9   | CurrBal10   | RelImm1   | RelImm2   | RelImm3   | RelImm4   | RelImm5   | RelImm6   | RelImm7   | RelImm8   | RelImm9   | RelImm10   | MaintRest1   | MaintRest2   | MaintRest3   | MaintRest4   | MaintRest5   | MaintRest6   | MaintRest7   | MaintRest8   | MaintRest9   | MaintRest10   | ForfNow1   | ForfNow2   | ForfNow3   | ForfNow4   | ForfNow5   | ForfNow6   | ForfNow7   | ForfNow8   | ForfNow9   | ForfNow10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | AvailUnits5   | AvailUnits6   | AvailUnits7   | AvailUnits8   | AvailUnits9   | AvailUnits10   | AvailDate1   | AvailDate2   | AvailDate3   | AvailDate4   | AvailDate5   | AvailDate6   | AvailDate7   | AvailDate8   | AvailDate9   | AvailDate10   | RestEndDate1   | RestEndDate2   | RestEndDate3   | RestEndDate4   | RestEndDate5   | RestEndDate6   | RestEndDate7   | RestEndDate8   | RestEndDate9   | RestEndDate10   |
		| <Selection> | <TransNumber> | <TransDate> | <SearchName> | <Register1> | <Register2> | <Register3> | <Register4> | <Register5> | <Register6> | <Register7> | <Register8> | <Register9> | <Register10> | <CertID1> | <CertID2> | <CertID3> | <CertID4> | <CertID5> | <CertID6> | <CertID7> | <CertID8> | <CertID9> | <CertID10> | <CurrBal1> | <CurrBal2> | <CurrBal3> | <CurrBal4> | <CurrBal5> | <CurrBal6> | <CurrBal7> | <CurrBal8> | <CurrBal9> | <CurrBal10> | <RelImm1> | <RelImm2> | <RelImm3> | <RelImm4> | <RelImm5> | <RelImm6> | <RelImm7> | <RelImm8> | <RelImm9> | <RelImm10> | <MaintRest1> | <MaintRest2> | <MaintRest3> | <MaintRest4> | <MaintRest5> | <MaintRest6> | <MaintRest7> | <MaintRest8> | <MaintRest9> | <MaintRest10> | <ForfNow1> | <ForfNow2> | <ForfNow3> | <ForfNow4> | <ForfNow5> | <ForfNow6> | <ForfNow7> | <ForfNow8> | <ForfNow9> | <ForfNow10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <AvailUnits5> | <AvailUnits6> | <AvailUnits7> | <AvailUnits8> | <AvailUnits9> | <AvailUnits10> | <AvailDate1> | <AvailDate2> | <AvailDate3> | <AvailDate4> | <AvailDate5> | <AvailDate6> | <AvailDate7> | <AvailDate8> | <AvailDate9> | <AvailDate10> | <RestEndDate1> | <RestEndDate2> | <RestEndDate3> | <RestEndDate4> | <RestEndDate5> | <RestEndDate6> | <RestEndDate7> | <RestEndDate8> | <RestEndDate9> | <RestEndDate10> |
		And In EOL02203 I Perform Leaver Processing Transaction as:
		| Register1    | Register2    | Register3    | Register4    | Register5    | Register6    | Register7    | Register8    | Register9    | Register10    | CertID1    | CertID2    | CertID3    | CertID4    | CertID5    | CertID6    | CertID7    | CertID8    | CertID9    | CertID10    | CurrBal1    | CurrBal2    | CurrBal3    | CurrBal4    | CurrBal5    | CurrBal6    | CurrBal7    | CurrBal8    | CurrBal9    | CurrBal10    | RelImm1    | RelImm2    | RelImm3    | RelImm4    | RelImm5    | RelImm6    | RelImm7    | RelImm8    | RelImm9    | RelImm10    | MaintRest1    | MaintRest2    | MaintRest3    | MaintRest4    | MaintRest5    | MaintRest6    | MaintRest7    | MaintRest8    | MaintRest9    | MaintRest10    | ForfNow1    | ForfNow2    | ForfNow3    | ForfNow4    | ForfNow5    | ForfNow6    | ForfNow7    | ForfNow8    | ForfNow9    | ForfNow10    | AvailUnits1    | AvailUnits2    | AvailUnits3    | AvailUnits4    | AvailUnits5    | AvailUnits6    | AvailUnits7    | AvailUnits8    | AvailUnits9    | AvailUnits10    | AvailDate1    | AvailDate2    | AvailDate3    | AvailDate4    | AvailDate5    | AvailDate6    | AvailDate7    | AvailDate8    | AvailDate9    | AvailDate10    | RestEndDate1    | RestEndDate2    | RestEndDate3    | RestEndDate4    | RestEndDate5    | RestEndDate6    | RestEndDate7    | RestEndDate8    | RestEndDate9    | RestEndDate10    | Register11    | CertID11    | CurrBal11    | RelImm11    | MaintRest11    | ForfNow11    | AvailUnits11    | AvailDate11    | RestEndDate11    |
		| <Register1a> | <Register2a> | <Register3a> | <Register4a> | <Register5a> | <Register6a> | <Register7a> | <Register8a> | <Register9a> | <Register10a> | <CertID1a> | <CertID2a> | <CertID3a> | <CertID4a> | <CertID5a> | <CertID6a> | <CertID7a> | <CertID8a> | <CertID9a> | <CertID10a> | <CurrBal1a> | <CurrBal2a> | <CurrBal3a> | <CurrBal4a> | <CurrBal5a> | <CurrBal6a> | <CurrBal7a> | <CurrBal8a> | <CurrBal9a> | <CurrBal10a> | <RelImm1a> | <RelImm2a> | <RelImm3a> | <RelImm4a> | <RelImm5a> | <RelImm6a> | <RelImm7a> | <RelImm8a> | <RelImm9a> | <RelImm10a> | <MaintRest1a> | <MaintRest2a> | <MaintRest3a> | <MaintRest4a> | <MaintRest5a> | <MaintRest6a> | <MaintRest7a> | <MaintRest8a> | <MaintRest9a> | <MaintRest10a> | <ForfNow1a> | <ForfNow2a> | <ForfNow3a> | <ForfNow4a> | <ForfNow5a> | <ForfNow6a> | <ForfNow7a> | <ForfNow8a> | <ForfNow9a> | <ForfNow10a> | <AvailUnits1a> | <AvailUnits2a> | <AvailUnits3a> | <AvailUnits4a> | <AvailUnits5a> | <AvailUnits6a> | <AvailUnits7a> | <AvailUnits8a> | <AvailUnits9a> | <AvailUnits10a> | <AvailDate1a> | <AvailDate2a> | <AvailDate3a> | <AvailDate4a> | <AvailDate5a> | <AvailDate6a> | <AvailDate7a> | <AvailDate8a> | <AvailDate9a> | <AvailDate10a> | <RestEndDate1a> | <RestEndDate2a> | <RestEndDate3a> | <RestEndDate4a> | <RestEndDate5a> | <RestEndDate6a> | <RestEndDate7a> | <RestEndDate8a> | <RestEndDate9a> | <RestEndDate10a> | <Register11a> | <CertID11a> | <CurrBal11a> | <RelImm11a> | <MaintRest11a> | <ForfNow11a> | <AvailUnits11a> | <AvailDate11a> | <RestEndDate11a> |
		And In EOL02204 I Perform Leaver Processing Transaction as:
		| Register1   | Register2   | Register3   | Register4   | Register5   | Register6   | Register7   | Register8   | Register9   | Register10   | CertID1   | CertID2   | CertID3   | CertID4   | CertID5   | CertID6   | CertID7   | CertID8   | CertID9   | CertID10   | RelImm1   | RelImm2   | RelImm3   | RelImm4   | RelImm5   | RelImm6   | RelImm7   | RelImm8   | RelImm9   | RelImm10   | MaintRest1   | MaintRest2   | MaintRest3   | MaintRest4   | MaintRest5   | MaintRest6   | MaintRest7   | MaintRest8   | MaintRest9   | MaintRest10   | ForfNow1   | ForfNow2   | ForfNow3   | ForfNow4   | ForfNow5   | ForfNow6   | ForfNow7   | ForfNow8   | ForfNow9   | ForfNow10   | AvailUnits1   | AvailUnits2   | AvailUnits3   | AvailUnits4   | AvailUnits5   | AvailUnits6   | AvailUnits7   | AvailUnits8   | AvailUnits9   | AvailUnits10   | RestEndDate1   | RestEndDate2   | RestEndDate3   | RestEndDate4   | RestEndDate5   | RestEndDate6   | RestEndDate7   | RestEndDate8   | RestEndDate9   | RestEndDate10   | AvailDate1   | AvailDate2   | AvailDate3   | AvailDate4   | AvailDate5   | AvailDate6   | AvailDate7   | AvailDate8   | AvailDate9   | AvailDate10 |
		| <Register1> | <Register2> | <Register3> | <Register4> | <Register5> | <Register6> | <Register7> | <Register8> | <Register9> | <Register10> | <CertID1> | <CertID2> | <CertID3> | <CertID4> | <CertID5> | <CertID6> | <CertID7> | <CertID8> | <CertID9> | <CertID10> | <RelImm1> | <RelImm2> | <RelImm3> | <RelImm4> | <RelImm5> | <RelImm6> | <RelImm7> | <RelImm8> | <RelImm9> | <RelImm10> | <MaintRest1> | <MaintRest2> | <MaintRest3> | <MaintRest4> | <MaintRest5> | <MaintRest6> | <MaintRest7> | <MaintRest8> | <MaintRest9> | <MaintRest10> | <ForfNow1> | <ForfNow2> | <ForfNow3> | <ForfNow4> | <ForfNow5> | <ForfNow6> | <ForfNow7> | <ForfNow8> | <ForfNow9> | <ForfNow10> | <AvailUnits1> | <AvailUnits2> | <AvailUnits3> | <AvailUnits4> | <AvailUnits5> | <AvailUnits6> | <AvailUnits7> | <AvailUnits8> | <AvailUnits9> | <AvailUnits10> | <RestEndDate1> | <RestEndDate2> | <RestEndDate3> | <RestEndDate4> | <RestEndDate5> | <RestEndDate6> | <RestEndDate7> | <RestEndDate8> | <RestEndDate9> | <RestEndDate10> | <AvailDate1> | <AvailDate2> | <AvailDate3> | <AvailDate4> | <AvailDate5> | <AvailDate6> | <AvailDate7> | <AvailDate8> | <AvailDate9> | AvailDate10 |
		And In EOL02204 I Perform Leaver Processing Transaction as:
		| Register1    | Register2    | Register3    | Register4    | Register5    | Register6    | Register7    | Register8    | Register9    | Register10    | CertID1    | CertID2    | CertID3    | CertID4    | CertID5    | CertID6    | CertID7    | CertID8    | CertID9    | CertID10    | RelImm1    | RelImm2    | RelImm3    | RelImm4    | RelImm5    | RelImm6    | RelImm7    | RelImm8    | RelImm9    | RelImm10    | MaintRest1    | MaintRest2    | MaintRest3    | MaintRest4    | MaintRest5    | MaintRest6    | MaintRest7    | MaintRest8    | MaintRest9    | MaintRest10    | ForfNow1    | ForfNow2    | ForfNow3    | ForfNow4    | ForfNow5    | ForfNow6    | ForfNow7    | ForfNow8    | ForfNow9    | ForfNow10    | AvailUnits1    | AvailUnits2    | AvailUnits3    | AvailUnits4    | AvailUnits5    | AvailUnits6    | AvailUnits7    | AvailUnits8    | AvailUnits9    | AvailUnits10    | RestEndDate1    | RestEndDate2    | RestEndDate3    | RestEndDate4    | RestEndDate5   | RestEndDate6    | RestEndDate7    | RestEndDate8    | RestEndDate9    | RestEndDate10    | AvailDate1    | AvailDate2    | AvailDate3    | AvailDate4    | AvailDate5    | AvailDate6    | AvailDate7    | AvailDate8    | AvailDate9    | AvailDate10    |
		| <Register1a> | <Register2a> | <Register3a> | <Register4a> | <Register5a> | <Register6a> | <Register7a> | <Register8a> | <Register9a> | <Register10a> | <CertID1a> | <CertID2a> | <CertID3a> | <CertID4a> | <CertID5a> | <CertID6a> | <CertID7a> | <CertID8a> | <CertID9a> | <CertID10a> | <RelImm1a> | <RelImm2a> | <RelImm3a> | <RelImm4a> | <RelImm5a> | <RelImm6a> | <RelImm7a> | <RelImm8a> | <RelImm9a> | <RelImm10a> | <MaintRest1a> | <MaintRest2a> | <MaintRest3a> | <MaintRest4a> | <MaintRest5a> | <MaintRest6a> | <MaintRest7a> | <MaintRest8a> | <MaintRest9a> | <MaintRest10a> | <ForfNow1a> | <ForfNow2a> | <ForfNow3a> | <ForfNow4a> | <ForfNow5a> | <ForfNow6a> | <ForfNow7a> | <ForfNow8a> | <ForfNow9a> | <ForfNow10a> | <AvailUnits1a> | <AvailUnits2a> | <AvailUnits3a> | <AvailUnits4a> | <AvailUnits5a> | <AvailUnits6a> | <AvailUnits7a> | <AvailUnits8a> | <AvailUnits9a> | <AvailUnits10a> | <RestEndDate1a> | <RestEndDate2a> | <RestEndDate3a> | <RestEndDate4a> | <RestEndDate5a>| <RestEndDate6a> | <RestEndDate7a> | <RestEndDate8a> | <RestEndDate9a> | <RestEndDate10a> | <AvailDate1a> | <AvailDate2a> | <AvailDate3a> | <AvailDate4a> | <AvailDate5a> | <AvailDate6a> | <AvailDate7a> | <AvailDate8a> | <AvailDate9a> | <AvailDate10a> |
		And In EOL02204 I Perform Leaver Processing Transaction as:
		| Register1    | Register2    | Register3    | Register4    | Register5    | Register6    | Register7    | Register8    | Register9    | Register10    | CertID1    | CertID2    | CertID3    | CertID4    | CertID5    | CertID6    | CertID7    | CertID8    | CertID9    | CertID10    | RelImm1    | RelImm2    | RelImm3    | RelImm4    | RelImm5    | RelImm6    | RelImm7    | RelImm8    | RelImm9    | RelImm10    | MaintRest1    | MaintRest2    | MaintRest3    | MaintRest4    | MaintRest5    | MaintRest6    | MaintRest7    | MaintRest8    | MaintRest9    | MaintRest10    | ForfNow1    | ForfNow2    | ForfNow3    | ForfNow4    | ForfNow5    | ForfNow6    | ForfNow7    | ForfNow8    | ForfNow9    | ForfNow10    | AvailUnits1    | AvailUnits2    | AvailUnits3    | AvailUnits4    | AvailUnits5    | AvailUnits6    | AvailUnits7    | AvailUnits8    | AvailUnits9    | AvailUnits10    | RestEndDate1    | RestEndDate2    | RestEndDate3    | RestEndDate4    | RestEndDate5    | RestEndDate6    | RestEndDate7    | RestEndDate8    | RestEndDate9    | RestEndDate10    | AvailDate1    | AvailDate2    | AvailDate3    | AvailDate4    | AvailDate5    | AvailDate6    | AvailDate7    | AvailDate8    | AvailDate9    | AvailDate10    |
		| <Register1b> | <Register2b> | <Register3b> | <Register4b> | <Register5b> | <Register6b> | <Register7b> | <Register8b> | <Register9b> | <Register10b> | <CertID1b> | <CertID2b> | <CertID3b> | <CertID4b> | <CertID5b> | <CertID6b> | <CertID7b> | <CertID8b> | <CertID9b> | <CertID10b> | <RelImm1b> | <RelImm2b> | <RelImm3b> | <RelImm4b> | <RelImm5b> | <RelImm6b> | <RelImm7b> | <RelImm8b> | <RelImm9b> | <RelImm10b> | <MaintRest1b> | <MaintRest2b> | <MaintRest3b> | <MaintRest4b> | <MaintRest5b> | <MaintRest6b> | <MaintRest7b> | <MaintRest8b> | <MaintRest9b> | <MaintRest10b> | <ForfNow1b> | <ForfNow2b> | <ForfNow3b> | <ForfNow4b> | <ForfNow5b> | <ForfNow6b> | <ForfNow7b> | <ForfNow8b> | <ForfNow9b> | <ForfNow10b> | <AvailUnits1b> | <AvailUnits2b> | <AvailUnits3b> | <AvailUnits4b> | <AvailUnits5b> | <AvailUnits6b> | <AvailUnits7b> | <AvailUnits8b> | <AvailUnits9b> | <AvailUnits10b> | <RestEndDate1b> | <RestEndDate2b> | <RestEndDate3b> | <RestEndDate4b> | <RestEndDate5b> | <RestEndDate6b> | <RestEndDate7b> | <RestEndDate8b> | <RestEndDate9b> | <RestEndDate10b> | <AvailDate1b> | <AvailDate2b> | <AvailDate3b> | <AvailDate4b> | <AvailDate5b> | <AvailDate6b> | <AvailDate7b> | <AvailDate8b> | <AvailDate9b> | <AvailDate10b> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1   | DetailLine2   | DetailLine3   | DetailLine4   | DetailLine5   | DetailLine6   | DetailLine7   | DetailLine8   | DetailLine9   | DetailLine10   |
	| <SearchName> | <DetailLine1> | <DetailLine2> | <DetailLine3> | <DetailLine4> | <DetailLine5> | <DetailLine6> | <DetailLine7> | <DetailLine8> | <DetailLine9> | <DetailLine10> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1    | DetailLine2    | DetailLine3    | DetailLine4    | DetailLine5    | DetailLine6    | DetailLine7    | DetailLine8    | DetailLine9    | DetailLine10    |
	| <SearchName> | <DetailLine1a> | <DetailLine2a> | <DetailLine3a> | <DetailLine4a> | <DetailLine5a> | <DetailLine6a> | <DetailLine7a> | <DetailLine8a> | <DetailLine9a> | <DetailLine10a> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1    | DetailLine2    | DetailLine3    | DetailLine4    | DetailLine5    | DetailLine6    | DetailLine7    | DetailLine8    | DetailLine9    | DetailLine10    |
	| <SearchName> | <DetailLine1b> | <DetailLine2b> | <DetailLine3b> | <DetailLine4b> | <DetailLine5b> | <DetailLine6b> | <DetailLine7b> | <DetailLine8b> | <DetailLine9b> | <DetailLine10b> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1    | DetailLine2    | DetailLine3    | DetailLine4    | DetailLine5    | DetailLine6    | DetailLine7    | DetailLine8    | DetailLine9    | DetailLine10    |
	| <SearchName> | <DetailLine1c> | <DetailLine2c> | <DetailLine3c> | <DetailLine4c> | <DetailLine5c> | <DetailLine6c> | <DetailLine7c> | <DetailLine8c> | <DetailLine9c> | <DetailLine10c> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS11 I verify the following details:
	| SearchName   | DetailLine1    | DetailLine2    | DetailLine3    | DetailLine4    | DetailLine5    | DetailLine6    | DetailLine7    | DetailLine8    | DetailLine9    | DetailLine10    |
	| <SearchName> | <DetailLine1d> | <DetailLine2d> | <DetailLine3d> | <DetailLine4d> | <DetailLine5d> | <DetailLine6d> | <DetailLine7d> | <DetailLine8d> | <DetailLine9d> | <DetailLine10d> |


Examples: 
		| Test    | ClassCode | Selection | TransNumber | TransDate | SearchName  | Register1 | Register2 | Register3 | Register4 | Register5 | Register6 | Register7 | Register8 | Register9 | Register10 | CertID1    | CertID2    | CertID3    | CertID4    | CertID5    | CertID6    | CertID7    | CertID8    | CertID9    | CertID10   | CurrBal1 | CurrBal2 | CurrBal3 | CurrBal4 | CurrBal5 | CurrBal6 | CurrBal7 | CurrBal8 | CurrBal9 | CurrBal10 | RelImm1 | RelImm2 | RelImm3 | RelImm4 | RelImm5 | RelImm6 | RelImm7 | RelImm8 | RelImm9 | RelImm10 | MaintRest1 | MaintRest2 | MaintRest3 | MaintRest4 | MaintRest5 | MaintRest6 | MaintRest7 | MaintRest8 | MaintRest9 | MaintRest10 | ForfNow1 | ForfNow2 | ForfNow3 | ForfNow4 | ForfNow5 | ForfNow6 | ForfNow7 | ForfNow8 | ForfNow9 | ForfNow10 | AvailUnits1 | AvailUnits2 | AvailUnits3 | AvailUnits4 | AvailUnits5 | AvailUnits6 | AvailUnits7 | AvailUnits8 | AvailUnits9 | AvailUnits10 | AvailDate1 | AvailDate2 | AvailDate3 | AvailDate4 | AvailDate5 | AvailDate6 | AvailDate7 | AvailDate8 | AvailDate9 | AvailDate10 | RestEndDate1 | RestEndDate2 | RestEndDate3 | RestEndDate4 | RestEndDate5 | RestEndDate6 | RestEndDate7 | RestEndDate8 | RestEndDate9 | RestEndDate10 | Register1a | Register2a | Register3a | Register4a | Register5a | Register6a | Register7a | Register8a | Register9a | Register10a | CertID1a   | CertID2a   | CertID3a   | CertID4a   | CertID5a   | CertID6a   | CertID7a   | CertID8a   | CertID9a   | CertID10a  | CurrBal1a | CurrBal2a | CurrBal3a | CurrBal4a | CurrBal5a | CurrBal6a | CurrBal7a | CurrBal8a | CurrBal9a | CurrBal10a | RelImm1a | RelImm2a | RelImm3a | RelImm4a | RelImm5a | RelImm6a | RelImm7a | RelImm8a | RelImm9a | RelImm10a | MaintRest1a | MaintRest2a | MaintRest3a | MaintRest4a | MaintRest5a | MaintRest6a | MaintRest7a | MaintRest8a | MaintRest9a | MaintRest10a | ForfNow1a | ForfNow2a | ForfNow3a | ForfNow4a | ForfNow5a | ForfNow6a | ForfNow7a | ForfNow8a | ForfNow9a | ForfNow10a | AvailUnits1a | AvailUnits2a | AvailUnits3a | AvailUnits4a | AvailUnits5a | AvailUnits6a | AvailUnits7a | AvailUnits8a | AvailUnits9a | AvailUnits10a | AvailDate1a | AvailDate2a | AvailDate3a | AvailDate4a | AvailDate5a | AvailDate6a | AvailDate7a | AvailDate8a | AvailDate9a | AvailDate10a | RestEndDate1a | RestEndDate2a | RestEndDate3a | RestEndDate4a | RestEndDate5a | RestEndDate6a | RestEndDate7a | RestEndDate8a | RestEndDate9a | RestEndDate10a | Register11a | CertID11a  | CurrBal11a | RelImm11a | MaintRest11a | ForfNow11a | AvailUnits11a | AvailDate11a | RestEndDate11a | Register1b | Register2b | Register3b | Register4b | Register5b | Register6b | Register7b | Register8b | Register9b | Register10b | CertID1b   | CertID2b | CertID3b | CertID4b | CertID5b | CertID6b | CertID7b | CertID8b | CertID9b | CertID10b | RelImm1b | RelImm2b | RelImm3b | RelImm4b | RelImm5b | RelImm6b | RelImm7b | RelImm8b | RelImm9b | RelImm10b | MaintRest1b | MaintRest2b | MaintRest3b | MaintRest4b | MaintRest5b | MaintRest6b | MaintRest7b | MaintRest8b | MaintRest9b | MaintRest10b | ForfNow1b | ForfNow2b | ForfNow3b | ForfNow4b | ForfNow5b | ForfNow6b | ForfNow7b | ForfNow8b | ForfNow9b | ForfNow10b | AvailUnits1b | AvailUnits2b | AvailUnits3b | AvailUnits4b | AvailUnits5b | AvailUnits6b | AvailUnits7b | AvailUnits8b | AvailUnits9b | AvailUnits10b | AvailDate1b | AvailDate2b | AvailDate3b | AvailDate4b | AvailDate5b | AvailDate6b | AvailDate7b | AvailDate8b | AvailDate9b | AvailDate10b | RestEndDate1b | RestEndDate2b | RestEndDate3b | RestEndDate4b | RestEndDate5b | RestEndDate6b | RestEndDate7b | RestEndDate8b | RestEndDate9b | RestEndDate10b | Action | LocateArgument | DetailLine1                                                                               | DetailLine2                                                                               | DetailLine3                                                                               | DetailLine4                                                                               | DetailLine5                                                                               | DetailLine6                                                                               | DetailLine7                                                                               | DetailLine8                                                                               | DetailLine9                                                                               | DetailLine10                                                                              | Action1 | LocateArgument1 | DetailLine1a                                                                              | DetailLine2a                                                                              | DetailLine3a                                                                              | DetailLine4a                                                                              | DetailLine5a                                                                              | DetailLine6a                                                                              | DetailLine7a                                                                              | DetailLine8a                                                                              | DetailLine9a                                                                              | DetailLine10a                                                                             | DetailLine1b                                                                              | DetailLine2b                                                                              | DetailLine3b                                                                              | DetailLine4b                                                                              | DetailLine5b                                                                              | DetailLine6b                                                                              | DetailLine7b                                                                              | DetailLine8b                                                                              | DetailLine9b                                                                              | DetailLine10b                                                                             | DetailLine1c                                                                              | DetailLine2c | DetailLine3c                                                                                      | DetailLine4c                                                                                      | DetailLine5c                                                                                      | DetailLine6c                                                                                      | DetailLine7c                                                                                      | DetailLine8c                                                                                      | DetailLine9c                                                                                      | DetailLine10c | DetailLine1d | DetailLine2d                                                                                      | DetailLine3d | DetailLine4d | DetailLine5d | DetailLine6d | DetailLine7d | DetailLine8d | DetailLine9d | DetailLine10d |
		| Partial | DEP       | ESLVA     | 9993358     |           | I0030272480 | 11A       | 12A       | 12A       | 12A       | 12A       | 12A       | 12A       | 12A       | 12A       | 12A        | 20110712EF | 20120712EP | 20120810EP | 20120912EP | 20121012EP | 20121113EP | 20121212EP | 20130114EP | 20130212EP | 20130312EP | 2100     | 33       | 31       | 29       | 30       | 29       | 28       | 26       | 25       | 23        | 1000    | 10      | 10      | 10      | 10      | 29      | 28      | 26      | 25      | 23       |            |            |            |            |            |            |            |            |            |             | 1100     | 23       | 21       | 19       | 20       |          |          |          |          |           |             |             |             |             |             |             |             |             |             |              |            |            |            |            |            |            |            |            |            |             | 12/07/2019   | 12/07/2014   | 12/07/2014   | 12/07/2014   | 12/07/2014   | 12/07/2014   | 12/07/2014   | 12/07/2014   | 12/07/2014   | 12/07/2014    | 12A        | 12A        | 12A        | 13A        | 13A        | 13A        | 13A        | 13A        | 13A        | 13A         | 20130412EP | 20130513EP | 20130612EP | 20130712EP | 20130812EP | 20130912EP | 20131014EP | 20131112EP | 20131212EP | 20140113EP | 25        | 24        | 24        | 24        | 24        | 24        | 26        | 23        | 23        | 22         | 25       | 24       | 24       | 24       | 24       | 24       | 26       | 23       | 23       | 22        |             |             |             |             |             |             |             |             |             |              |           |           |           |           |           |           |           |           |           |            |              |              |              |              |              |              |              |              |              |               |             |             |             |             |             |             |             |             |             |              |               |               |               |               |               |               |               |               |               |                | 13A         | 20140212EP | 21         | 21        |              |            |               |              | 12/07/2015     | 13A        |            |            |            |            |            |            |            |            |             | 20140212EP |          |          |          |          |          |          |          |          |           | 21       |          |          |          |          |          |          |          |          |           |             |             |             |             |             |             |             |             |             |              |           |           |           |           |           |           |           |           |           |            |              |              |              |              |              |              |              |              |              |               |             |             |             |             |             |             |             |             |             |              | 12/07/2015    |               |               |               |               |               |               |               |               |                | ESHT   | /DEP           | 10A EF T 12/07/2010  12/07/2013  12/07/2013  None           1200   10.000000     12000.00 | 11A EF T 12/07/2011  12/07/2019  12/07/2014  None           1000   10.000000     10000.00 | 11B EB T 12/07/2011  None        None        12/07/2012      650   10.800000      7020.00 | 11B EN T 12/07/2011  None        None        None            450   10.000000      4500.00 | 11A EM T 13/02/2012  13/02/2014  13/02/2014  13/02/2014      373    8.040000      2998.92 | 11A EP T 13/02/2012  13/02/2013  13/02/2013  13/02/2013       74    8.020000       593.48 | 11A EP T 13/03/2012  13/02/2013  13/02/2013  13/02/2013       74    8.150000       603.10 | 11A EP T 13/04/2012  13/02/2013  13/02/2014  13/02/2013       69    8.640000       596.16 | 11A EP T 11/05/2012  13/02/2013  13/02/2014  13/02/2013       73    8.310000       606.63 | 11A EP T 12/06/2012  13/02/2013  13/02/2014  13/02/2013       78    7.670000       598.26 | M       |                 | 12A EB T 12/07/2012  None        None        12/07/2013      520   10.800000      5616.00 | 12A EP T 12/07/2012  12/07/2014  12/07/2014  12/07/2013       10    7.360000        73.60 | 12A EP T 10/08/2012  12/07/2014  12/07/2014  10/08/2013       10    8.150000        81.50 | 12A EP T 12/09/2012  12/07/2014  12/07/2014  12/09/2013       10    8.660000        86.60 | 12A EP T 12/10/2012  12/07/2014  12/07/2014  12/10/2013       10    8.350000        83.50 | 12A EP T 13/11/2012  12/07/2014  12/07/2014  13/11/2013       29    8.680000       251.72 | 12A EP T 12/12/2012  12/07/2014  12/07/2014  12/12/2013       28    8.700000       243.60 | 12A EP T 14/01/2013  12/07/2014  12/07/2014  14/01/2014       26    9.670000       251.42 | 12A EP T 12/02/2013  12/07/2014  12/07/2014  12/02/2014       25   10.130000       253.25 | 12A EP T 12/03/2013  12/07/2014  12/07/2014  12/03/2014       23   10.790000       248.17 | 12A EP T 12/04/2013  12/07/2014  12/07/2014  12/04/2014       25   10.160000       254.00 | 12A EP T 13/05/2013  12/07/2014  12/07/2014  13/05/2014       24   10.440000       250.56 | 12A EP T 12/06/2013  12/07/2014  12/07/2014  12/06/2014       24   10.240000       245.76 | 13A EP   12/07/2013  12/07/2015  12/07/2015  None             24   10.390000       249.36 | 13A EP   12/08/2013  12/07/2015  12/07/2015  None             24   10.260000       246.24 | 13A EP   12/09/2013  12/07/2015  12/07/2015  None             24   10.230000       245.52 | 13A EP   14/10/2013  12/07/2015  12/07/2015  None             26    9.940000       258.44 | 13A EP   12/11/2013  12/07/2015  12/07/2015  None             23   10.890000       250.47 | 13A EP   12/12/2013  12/07/2015  12/07/2015  None             23   10.640000       244.72 | 13A EP   13/01/2014  12/07/2015  12/07/2015  None             22   11.380000       250.36 | 13A EP   12/02/2014  12/07/2015  12/07/2015  None             21   11.640000       244.44 |              | * Register Type Totals                                                             MV at 21/04/15 | *                 Available  Unavailable    Reserved     Balance   Total Cost           12.700000 | *   EF                 2200            0           0        2200     22000.00            27940.00 | *   EM                  373            0           0         373      2998.92             4737.10 | *   EP                  799            0           0         799      7310.86            10147.30 | *   EB                 1170            0           0        1170     12636.00            14859.00 | *   EN                  450            0           0         450      4500.00             5715.00 |               |              | ** Plan Total          4992            0           0        4992*    49445.78*           63398.40 |              |              |              |              |              |              |              |               |

@winformsTest
@WES_AUTO
@59795
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 59795: 01_PAY_Payment
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO" 
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection>" 
		And In EOL01901 I Add Manual Payment Details as "<TransNumber>" "<PaymentDate>" "<PaymentAmount>" "<SearchName>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |


Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | PaymentDate | PaymentAmount | SearchName  | Action | LocateArgument | Line1                            | Line2                                                                                | Line3                                                                                | Line4                                                                                | Line5                                                                                | Line6                                                                                | Line7                                                                                | Line8                                                                                | Line9                                                                                | Line10                                                      |
	| Test1 | LAS       | 03A          | RMN       | 9442358     | 23/06/2015  | 100.00        | I0030126408 | ESLB   | /LAS           | LAS EMPLOYEE SHARE PLAN AU LOANS | 97B 0000004014 12/12/1997          0       6165.00           0.00     No           0 | 98A 0000004015 11/12/1998          0       6445.00           0.00     No           0 | 99A 0000004016 14/01/2000          0       6315.00           0.00     No           0 | 00A 0000004009 24/01/2001        486       8960.00           0.00     Yes          0 | 01A 0000004010 13/12/2001        292       9105.00         970.12     No           0 | 02A 0000004011 13/12/2002        292       8166.00         364.12     No           0 | 03A 0000004012 19/12/2003        112       2991.36         355.08     No           0 | 04A 0000004013 03/12/2004         77       2977.26        1348.73     No           0 | *Plan Total             1259*     51124.62*       3038.05 * |

@winformsTest
@WES_AUTO
@59970
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 59970: 01_AMN_Manual_Adhoc_Payment
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO" 
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection>" 
		And In EOL01901 I Add Manual Payment Details as "<TransNumber>" "<PaymentDate>" "<PaymentAmount>" "<SearchName>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |


Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | PaymentDate | PaymentAmount | SearchName  | Action | LocateArgument | Line1                            | Line2                                                                                | Line3                                                                                | Line4                                                                                | Line5                                                                                | Line6                                                                                | Line7                                                       | Line8 | Line9 | Line10 |
	| Test1 | LAS       | 02B          | RMN       | 9442368     | 23/06/2015  | 100.00        | I3900021754 | ESLB   | /LAS           | LAS EMPLOYEE SHARE PLAN AU LOANS | 01A 0000048840 13/12/2001          0       9105.00           0.00     Yes          0 | 01B 0000048841 13/12/2001        960      29985.80        3202.76     No           0 | 02A 0000048842 13/12/2002        292       8166.00         364.12     No           0 | 02B 0000048843 13/12/2002       7844     219992.04        9786.94     No           0 | 03A 0000048844 19/12/2003        226       2991.36         455.08     No           0 | *Plan Total             9322*    270240.20*      13808.90 * |       |       |        |

@winformsTest
@WES_AUTO
@59973
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 59998: 01_RVM_Payment_Reversal
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection>" 
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1    | Line2    | Line3    | Line4    | Line5    | Line6    | Line7    | Line8    | Line9    | Line10    |
	| <Line1a> | <Line2a> | <Line3a> | <Line4a> | <Line5a> | <Line6a> | <Line7a> | <Line8a> | <Line9a> | <Line10a> |


Examples: 
	| Test  | ClassCode | MenuItem | RegisterCode | Selection | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney | Action | LocateArgument | SearchName  | Line1                            | Line2                                                                                | Line3                                                                                | Line4                                                                                | Line5                                                                                | Line6                                                                                | Line7                                                                                | Line8                                                                                | Line9                                                                                | Line10                                                                               | Action1 | LocateArgument1 | Line1a                                                      | Line2a | Line3a | Line4a | Line5a | Line6a | Line7a | Line8a | Line9a | Line10a |
	| Test1 | LAS       | PAY      | 03A          | RVM       | 9332370     |            | 6016           | 55872109         | 99.68      | ESLB   | /LAS           | I0030145691 | LAS EMPLOYEE SHARE PLAN AU LOANS | 97B 0000004626 12/12/1997          0       6165.00           0.00     No           0 | 98A 0000004627 11/12/1998          0       6445.00           0.00     No           0 | 99A 0000004628 14/01/2000          0       6315.00           0.00     No           0 | 00A 0000004620 24/01/2001          0       8960.00           0.00     No           0 | 00B 0000004621 24/01/2001        866      15984.64           0.00     Yes          0 | 01A 0000004622 13/12/2001        292       9105.00         970.12     No           0 | 01B 0000004623 13/12/2001       5437     169990.35       18164.14     No           0 | 02A 0000004624 13/12/2002        292       8166.00         364.12     No           0 | 03A 0000004625 19/12/2003        112       2991.36         554.76     No           0 | M       |                 | *Plan Total             6999*    234122.35*      20053.14 * |        |        |        |        |        |        |        |        |         |

@winformsTest
@WES_AUTO
@59973
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 59973: 01_IMN_Manual_Interest_Payment
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO" 
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection>" 
		And In EOL01901 I Add Manual Payment Details as "<TransNumber>" "<PaymentDate>" "<PaymentAmount>" "<SearchName>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1    | Line2    | Line3    | Line4    | Line5    | Line6    | Line7    | Line8    | Line9    | Line10    |
	| <Line1a> | <Line2a> | <Line3a> | <Line4a> | <Line5a> | <Line6a> | <Line7a> | <Line8a> | <Line9a> | <Line10a> |
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "payments" Menu
		And In EOL01901 I go to manual Payments Menu "<RegisterCode>" "<Selection1>" 
		And In EOL00401 I continue with the following details:
		| TransNumber    | TotalUnits   | RvsalRunNumber   | RvsalTransNumber   | TotalMoney   |
		| <TransNumber1> | <TotalUnits> | <RvsalRunNumber> | <RvsalTransNumber> | <TotalMoney> |
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1    | Line2    | Line3    | Line4    | Line5    | Line6    | Line7    | Line8    | Line9    | Line10    |
	| <Line1b> | <Line2b> | <Line3b> | <Line4b> | <Line5b> | <Line6b> | <Line7b> | <Line8b> | <Line9b> | <Line10b> |
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1    | Line2    | Line3    | Line4    | Line5    | Line6    | Line7    | Line8    | Line9    | Line10    |
	| <Line1c> | <Line2c> | <Line3c> | <Line4c> | <Line5c> | <Line6c> | <Line7c> | <Line8c> | <Line9c> | <Line10c> |
	
Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | PaymentDate | PaymentAmount | SearchName  | Action | LocateArgument | Line1                            | Line2                                                                                | Line3                                                                                | Line4                                                                                | Line5                                                                                | Line6                                                                                | Line7                                                                                | Line8                                                                                | Line9                                                                                | Line10                                                                               | Action1 | LocateArgument1 | Line1a                                                                               | Line2a                                                                               | Line3a                                                                               | Line4a                                                      | Line5a | Line6a | Line7a | Line8a | Line9a | Line10a | Selection1 | TransNumber1 | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney | Line1b                           | Line2b                                                                               | Line3b                                                                               | Line4b                                                                               | Line5b                                                                               | Line6b                                                                               | Line7b                                                                               | Line8b                                                                               | Line9b                                                                               | Line10b                                                                              | Line1c                                                                               | Line2c                                                                               | Line3c                                                                               | Line4c                                                      | Line5c | Line6c | Line7c | Line8c | Line9c | Line10c |
	| Test1 | LAS       | 02B          | IMN       | 9332369     | 23/06/2015  | 100.00        | I0030186958 | ESLB   | /LAS           | LAS EMPLOYEE SHARE PLAN AU LOANS | 97B 0000006048 12/12/1997          0       6165.00           0.00     No           0 | 98A 0000006049 11/12/1998          0       6445.00           0.00     No           0 | 98B 0000006050 11/12/1998          0      15996.49           0.00     Yes          0 | 99A 0000006051 14/01/2000          0       6315.00           0.00     Yes          0 | 99B 0000006052 14/01/2000          0      15989.58           0.00     Yes          0 | 00A 0000006041 24/01/2001          0       8960.00           0.00     Yes          0 | 00B 0000006042 24/01/2001          0      15984.64           0.00     Yes          0 | 01A 0000006043 13/12/2001        292       9105.00         970.12     No           0 | 01B 0000006044 13/12/2001        768      23976.50        2558.78     No           0 | M       |                 | 02A 0000006045 13/12/2002        292       8166.00         364.12     No           0 | 02B 0000006046 13/12/2002       4635     129975.50        5940.60     No           0 | 03A 0000006047 19/12/2003        112       2991.36         455.08     No           0 | *Plan Total             6099*    250070.07*      10288.70 * |        |        |        |        |        |         | IRV        | 9332371      |            | 6121           | 9332369          | 100.00     | LAS EMPLOYEE SHARE PLAN AU LOANS | 97B 0000006048 12/12/1997          0       6165.00           0.00     No           0 | 98A 0000006049 11/12/1998          0       6445.00           0.00     No           0 | 98B 0000006050 11/12/1998          0      15996.49           0.00     Yes          0 | 99A 0000006051 14/01/2000          0       6315.00           0.00     Yes          0 | 99B 0000006052 14/01/2000          0      15989.58           0.00     Yes          0 | 00A 0000006041 24/01/2001          0       8960.00           0.00     Yes          0 | 00B 0000006042 24/01/2001          0      15984.64           0.00     Yes          0 | 01A 0000006043 13/12/2001        292       9105.00         970.12     No           0 | 01B 0000006044 13/12/2001        768      23976.50        2558.78     No           0 | 02A 0000006045 13/12/2002        292       8166.00         364.12     No           0 | 02B 0000006046 13/12/2002       4635     129975.50        5840.60     No           0 | 03A 0000006047 19/12/2003        112       2991.36         455.08     No           0 | *Plan Total             6099*    250070.07*      10188.70 * |        |        |        |        |        |         |

@winformsTest
@WES_AUTO
@59973
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 60211: 01_ESRVW. Reconstruction Down Reversal
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO" 
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "reconstruction reversal processing" Menu
		And In EOL00401 I go to reconstruction reversal Menu
		 | RegisterCode   | Selection   |
		 | <RegisterCode> | <Selection> |
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |

Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney | SearchName  | Action | LocateArgument | Line1                            | Line2                                                                                | Line3                                                                                | Line4                                                                                | Line5                                                                                | Line6                                                                                | Line7                                                       | Line8 | Line9 | Line10 |
	| Test1 | LAS       | 01B          | ESRVW     | 9332380     | 494        | 5607           | 46928584         |            | I0030553420 | ESLB   | /LAS           | LAS EMPLOYEE SHARE PLAN AU LOANS | 01A 0000029531 13/12/2001          0       9105.00           0.00     No           0 | 01B 0000029532 13/12/2001        974      14992.90        1097.38     No           0 | 02A 0000029533 13/12/2002        292       8166.00         364.12     No           0 | 03A 0000029534 19/12/2003        112       2991.36         455.08     No           0 | 03B 0000029535 19/12/2003        778      20992.00        3206.58     No           0 | *Plan Total             2156*     56247.26*       5123.16 * |       |       |        |

@winformsTest
@WES_AUTO
@60212
@EP_EmployeePlanProcessing
Scenario Outline: Test Case 60212: 01_ESRVX_Reconstruction_Up_Reversal
#Loan Plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "WES_AUTO" 
		And I go to the Employee Scheme Processing Menu "<ClassCode>"
		And In EOL00123 I Click on "reconstruction reversal processing" Menu
		And In EOL00401 I go to reconstruction reversal Menu
		 | RegisterCode   | Selection   |
		 | <RegisterCode> | <Selection> |
		And In EOL00401 I perform Reversal Transaction as "<TransNumber>" "<TotalUnits>" "<RvsalRunNumber>" "<RvsalTransNumber>" "<TotalMoney>"
	Given I have connected to WinForms	
	When In SELCOY01 I select the company: "WES_AUTO"
		And I go to the Enquiry system and Search <SearchName>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS19 I should see Loan Balance details as 
	| Line1   | Line2   | Line3   | Line4   | Line5   | Line6   | Line7   | Line8   | Line9   | Line10   |
	| <Line1> | <Line2> | <Line3> | <Line4> | <Line5> | <Line6> | <Line7> | <Line8> | <Line9> | <Line10> |

Examples: 
	| Test  | ClassCode | RegisterCode | Selection | TransNumber | TotalUnits | RvsalRunNumber | RvsalTransNumber | TotalMoney | SearchName  | Action | LocateArgument | Line1                            | Line2                                                                                | Line3                                                                                | Line4                                                                                | Line5                                                                                | Line6                                                                                | Line7                                                       | Line8 | Line9 | Line10 |
	| Test1 | LAS       | 01B          | ESRVX     | 9332381     | 3837       | 5939           | 52994896         |            | I0030548833 | ESLB   | /LAS           | LAS EMPLOYEE SHARE PLAN AU LOANS | 01A 0000028967 13/12/2001          0       9105.00           0.00     No           0 | 01B 0000028968 13/12/2001          0     119973.55           0.00     Yes          0 | 02A 0000028969 13/12/2002        292       8166.00         364.12     No           0 | 03A 0000028970 19/12/2003        112       2991.36         455.08     No           0 | 03B 0000028971 19/12/2003        962      25977.60        3971.42     No           0 | *Plan Total             1366*    166213.51*       4790.62 * |       |       |        |

