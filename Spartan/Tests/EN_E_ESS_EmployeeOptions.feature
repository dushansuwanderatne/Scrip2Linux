Feature: EN_E_ESS_EmployeeOptions
	Ensure EN_E_ESS_EmployeeOptions functionality covered

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@CPU_AUTO
Scenario: View ESS Employee Details
	# Enquiry System -Action ED
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007428"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ED    |
			| Locate Argument |       |
	Then In ENSESS01 I should see the holder Employee Details as below:
		| Field           | Value       |
		| HIN             | I0100007428 |
		| Employee ID     | 0001018126  |
		| Preferred Name  | ECQFID NEDI |
		| Business Unit   | CTSG        |
		| Employee Status | E           |
		| Leaver Code     | EEE         |
		| Effective Date  | 12/07/2004  |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@17348
@CPU_AUTO
Scenario: Test Case 17348: 01_Employee Search (EA,ED,ES,ESS) -ES(EmployeeID)
	# Enquiry System -Action ES
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007428"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ES    |
			| Locate Argument |       |
		And In ENSESS06 I enter following employee details:
			| Field       | Value      |
			| HIN         |            |
			| Employee ID | 0001018126 |
			| Payroll ID  |            |
			| USAN        |            |
	Then In ENSESS01 I should see the holder Employee Details as below:
		| Field           | Value       |
		| HIN             | I0100007428 |
		| Employee ID     | 0001018126  |
		| Preferred Name  | ECQFID NEDI |
		| Business Unit   | CTSG        |
		| Employee Status | E           |
		| Leaver Code     | EEE         |
		| Effective Date  | 12/07/2004  |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@17348
@CPU_AUTO
Scenario:  Test Case 17348: 01_Employee Search (EA,ED,ES,ESS) -ES(EmployeeID-PayrollID)
	# Enquiry System -Action ES
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007428"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ES    |
			| Locate Argument |       |
		And In ENSESS06 I enter following employee details:
			| Field       | Value      |
			| HIN         |            |
			| Employee ID | 0001018126 |
			| Payroll ID  | CTSMTH     |
			| USAN        |            |
	Then In ENSESS01 I should see the holder Employee Details as below:
		| Field           | Value       |
		| HIN             | I0100007428 |
		| Employee ID     | 0001018126  |
		| Preferred Name  | ECQFID NEDI |
		| Business Unit   | CTSG        |
		| Employee Status | E           |
		| Leaver Code     | EEE         |
		| Effective Date  | 12/07/2004  |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@CPU_AUTO
Scenario: ESS Employee History
	# Enquiry System -Action EH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007428"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
	Then In ENS01043 I should see Employee Share Plan Summary as below:
			| Field  | Value                                                                  |
			| HIN    | I0100007428                                                            |
			| Line1  | DEP 02A M    1338/10457485/0001 03/06/2002 ESAWB/ESS AWARD BULK UPLOAD |
			| Line2  | M    4125/12338744/0001 12/03/2013 ESTRS/TRADING SYSTEM ESS SALES      |
			| Line3  | P    1336/10454762/0001 30/05/2002 ESASA/ESS ADD SAVINGS AMOUNT        |
			| Line4  | P    1336/10455612/0001 15/05/2002 ESPAY/ESS PAYMENT                   |
			| Line5  | P    1341/10456511/0001 04/06/2002 ESAWP/ESS PARTNERSHIP AWARD OF UNIT |
			| Line6  | P    1341/10456511/0002 04/06/2002 ESPUR/ESS PARTNERSHIP PURCHASE      |
			| Line7  | P    1369/10469253/0001 15/06/2002 ESPAY/ESS PAYMENT                   |
			| Line8  | P    1373/10470704/0001 04/07/2002 ESAWP/ESS PARTNERSHIP AWARD OF UNIT |
			| Line9  | P    1373/10470704/0002 04/07/2002 ESPUR/ESS PARTNERSHIP PURCHASE      |
			| Line10 | P    1385/10478458/0001 15/07/2002 ESPAY/ESS PAYMENT                   |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@CPU_AUTO
Scenario: ESS Employee Expand History -On
	# Enquiry System -Action LEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007428"
		And I enter the following details as the Locate action:
			| Field           | Value         |
			| Action          | LEH           |
			| Locate Argument | 1338/10457485 |
	Then In ENSESS05 I should see Employee Expand History "on" as below:
	 			| Field              | Value       |
	 			| On HIN             | I0100007428 |
	 			| On Class           | DEP         |
	 			| On Register        | 02A         |
	 			| On Certificate ID  | 20020603EM  |
	 			| On Units           | 1498        |
	 			| On Total Cost      | 2999.60     |
	 			| On Share Cost      | 2.002400    |
	 			| Off HIN            |             |
	 			| Off Class          |             |
	 			| Off Register       |             |
	 			| Off Certificate ID |             |
	 			| Off Units          |             |
	 			| Off Total Cost     |             |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@CPU_AUTO
Scenario: ESS Employee Expand History -Off
	# Enquiry System -Action LEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007428"
		And I enter the following details as the Locate action:
			| Field           | Value         |
			| Action          | LEH           |
			| Locate Argument | 4125/12338744 |
	Then In ENSESS05 I should see Employee Expand History "off" as below:
	 			| Field              | Value       |
	 			| On HIN             |             |
	 			| On Class           |             |
	 			| On Register        |             |
	 			| On Certificate ID  |             |
	 			| On Units           |             |
	 			| On Total Cost      |             |
	 			| On Share Cost      |             |
	 			| Off HIN            | I0100007428 |
	 			| Off Class          | DEP         |
	 			| Off Register       | 02A         |
	 			| Off Certificate ID | 20020603EM  |
	 			| Off Units          | 1158        |
	 			| Off Total Cost     | 2318.79     |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@CPU_AUTO
@17355
@FullSmokeTest
Scenario: Test Case 17355: 01_ESAH for Deferred & Exempt AESS plans
	# Enquiry System -Action ESAH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0030238249"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESAH  |
			| Locate Argument | /DEP  |
	Then In ENSESS15 I should see Payment Holding as below:
				| Field          | Value                                                                            |
				| HIN            | I0030238249                                                                      |
				| LeaverCode     | EEE                                                                              |
				| LeaverCodeDesc | E DEFAULT                                                                        |
				| Plan           | DEP                                                                              |
				| Plan Desc      | DEFERRED EMP SHARE PLAN - AU                                                     |
				| Line1          | 08A P  0000007115 Monthly      12       1    12       2000.00          0.00   No |
				| Line2          | 11A P  0000011703 Monthly      12       1    12       2000.00          0.00   No |
				| Line3          | 12A P  0000012886 Monthly      12       1    12       1500.00          6.52   No |
				| Line4          | 13A P  0000015609 Monthly       8       1     8       1500.00         11.25   No |
				| Line5          | *Plan Total           7000.00*        17.77 *                                    |
				| Line6          |                                                                                  |
				| Line7          |                                                                                  |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 2     |
			| Locate Argument |       |
	Then In ENSESS16 I should see ESS Payment Holding Extra Details as below:
			| Field               | Value    |
			| StoppedSaving       | No       |
			| NbrOfTimesRestarted | 0        |
			| ResidualInstruction | Rollover |
			| HoldingPeriodMonth  | 24       |
			| HoldingPeriodDay    | 0        |
			| TaxationPeriodMonth | 24       |
			| TaxationPeriodDay   | 0        |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESAH  |
			| Locate Argument | /EXA  |
	Then In ENSESS15 I should see Payment Holding as below:
				| Field          | Value                                                                            |
				| HIN            | I0030238249                                                                      |
				| LeaverCode     | EEE                                                                              |
				| LeaverCodeDesc | E DEFAULT                                                                        |
				| Plan           | EXA                                                                              |
				| Plan Desc      | EXEMPT EMPLOYEE SHARE PLAN                                                       |
				| Line1          | 09A P  0000008663 Monthly      10       1    10        500.00          0.00   No |
				| Line2          | 10A P  0000010056 Monthly      12       1    12       1000.00          0.00   No |
				| Line3          | 11A P  0000010897 Monthly      12       1    12        500.00          0.00   No |
				| Line4          | 12A P  0000013569 Monthly      12       1    12        500.00          4.78   No |
				| Line5          | 13A P  0000015615 Monthly       8       1     8        500.00          3.26   No |
				| Line6          | *Plan Total           3000.00*         8.04 *                                    |
				| Line7          |                                                                                  |

@winformsTest
@EnquiryTest
@EN_E_ESS_EmployeeOptions
@17356
@CPU_AUTO
Scenario: Test Case 17356: 02_ESAT for AESS plans (Deferred & Exempt)
	# Enquiry System -Action ESAT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0030238311"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESAT  |
			| Locate Argument | /EXA  |
	Then In ENSESS13 I should see Payment Transactions as below:
			| Field         | Value                                                                                         |
			| HIN           | I0030238311                                                                                   |
			| LeaveCode     | EEE                                                                                           |
			| LeaveCodeDesc | E DEFAULT                                                                                     |
			| Plan          | EXA                                                                                           |
			| Plan Desc     | EXEMPT EMPLOYEE SHARE PLAN                                                                    |
			| Line1         | 11A  0000010758 05/10/2012 ESRRP 4014/12238174/0001        2.23- R                            |
			| Line2         | 11A  0000010758 12/06/2012 ESPUR 3927/12154682/0002       46.02- C                            |
			| Line3         | 11A  0000010758 12/06/2012 ESPAY 3922/12151659/0001       41.63                           AUD |
			| Line4         | 11A  0000010758 11/05/2012 ESPUR 3904/12144139/0002       41.55- C                            |
			| Line5         | 11A  0000010758 10/05/2012 ESPAY 3899/12141053/0001       41.67                           AUD |
			| Line6         | 11A  0000010758 13/04/2012 ESPUR 3885/12132153/0002       43.20- C                            |
			| Line7         | 11A  0000010758 13/04/2012 ESPAY 3881/12130884/0001       41.67                           AUD |
			| Line8         | 11A  0000010758 13/03/2012 ESPUR 3864/12120883/0002       40.75- C                            |
			| Line9         | 11A  0000010758 08/03/2012 ESPAY 3851/12118195/0001       41.67                           AUD |
			| Line10        | 11A  0000010758 13/02/2012 ESPUR 3834/12072410/0002       40.10- C                            |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESAT  |
			| Locate Argument | /DEP  |
	Then In ENSESS13 I should see Payment Transactions as below:
			| Field         | Value                                                                                         |
			| HIN           | I0030238311                                                                                   |
			| LeaveCode     | EEE                                                                                           |
			| LeaveCodeDesc | E DEFAULT                                                                                     |
			| Plan          | DEP                                                                                           |
			| Plan Desc     | DEFERRED EMP SHARE PLAN - AU                                                                  |
			| Line1         | 11A  0000011522 12/07/2012 ESTRS 3947/12162684/0026        5.24-                              |
			| Line2         | 11A  0000011522 12/06/2012 ESPUR 3927/12153923/0002      207.09- C                            |
			| Line3         | 11A  0000011522 12/06/2012 ESPAY 3922/12153350/0001      208.26                           AUD |
			| Line4         | 11A  0000011522 11/05/2012 ESPUR 3904/12143370/0002      207.75- C                            |
			| Line5         | 11A  0000011522 10/05/2012 ESPAY 3899/12142676/0001      208.34                           AUD |
			| Line6         | 11A  0000011522 13/04/2012 ESPUR 3885/12131386/0002      207.36- C                            |
			| Line7         | 11A  0000011522 13/04/2012 ESPAY 3881/12129735/0001      208.34                           AUD |
			| Line8         | 11A  0000011522 13/03/2012 ESPUR 3864/12121548/0002      211.90- C                            |
			| Line9         | 11A  0000011522 08/03/2012 ESPAY 3851/12119909/0001      208.34                           AUD |
			| Line10        | 11A  0000011522 13/02/2012 ESPUR 3834/12071628/0002      208.52- C                            |
		When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 2     |
			| Locate Argument |       |
	Then In ENSESS14 I should see Transaction Details as below:
			| Field              | Value      |
			| Register           | 11A        |
			| USAN               | 11522      |
			| RegType            | EP         |
			| Run                | 3927       |
			| Tran               | 12153923   |
			| Sequesnce          | 2          |
			| Residue            | 5.24       |
			| TaxAmount          | 0.00       |
			| SharesAwarded      | 27         |
			| TranDate           | 12/06/2012 |
			| TranType           | ESPUR      |
			| TradeRef           |            |
			| PaymentAmount      | -207.09    |
			| AccumulationPeriod | 12         |
			| MarketValue        | 7.670000   |
			| UnmatchedShares    |            |   

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_E_ESS_EmployeeOptions
@FullSmokeTest
Scenario: ESS Award Details
	# Enquiry System -Action ESAP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007347"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESAP  |
			| Locate Argument | /EXA  |
	Then In ENSESS07 I should see Award Details as below:
			| Field     | Value                                                                                                  |
			| HIN       | I0100007347                                                                                            |
			| Plan      | EXA                                                                                                    |
			| Plan Desc | EXEMPT EMP SHARE PLAN - AU                                                                             |
			| Line1     | 04A EM   16/07/2004  16/07/2007  None        None              0    3.113122                       160 |
			| Line2     | 04A EP   16/07/2004  16/07/2007  None        None              0    3.113122                       160 |
			| Line3     | 13A EM   12/07/2013  12/07/2016  None        None            200   10.080000      2016.00          200 |
			| Line4     | ** Plan Total                                 200*                 2016.00*         520                |

@DataChange
@CPU_AUTO
@EN_E_ESS_EmployeeOptions
@17361
Scenario: Test Case 17361: 04_ESFR for Deferred and Loan plans-ATS
	# Enquiry System -Action ESFR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESFR  |
			| Locate Argument | /ATS  |
	Then In ENSESS12 I should see Forfeiture Details as below:
			| Field            | Value                     |
			| HIN              | I0033314515               |
			| Employee Status  | F                         |
			| Leaver Code      | FFF                       |
			| Plan             | ATS                       |
			| Plan Desc        | ABOVE TARGET SHARES (STI) |
			| Register         | 10A                       |
			| Certificate      | 20100602EB                |
			| Total Units      | 10                        |
			| Forfeiture Type  | L                         |
			| Forfeiture Units | 10                        |

@DataChange
@CPU_AUTO
@EN_E_ESS_EmployeeOptions
@17361
Scenario: Test Case 17361: 04_ESFR for Deferred and Loan plans-ELA
	# Enquiry System -Action ESFR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESFR  |
			| Locate Argument | /ELA  |
	Then In ENSESS12 I should see Forfeiture Details as below:
			| Field            | Value                          |
			| HIN              | I0033314515                    |
			| Employee Status  | F                              |
			| Leaver Code      | FFF                            |
			| Plan             | ELA                            |
			| Plan Desc        | STF SHARE OWNERSHIP PLAN(LOAN) |
			| Register         | 97A                            |
			| Certificate      | 19971114ER                     |
			| Total Units      | 252                            |
			| Forfeiture Type  |                                |
			| Forfeiture Units | 252                            |
@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17358
Scenario Outline: Test Case 17358: 03_ESAP for AESS and Loan plan
	# Enquiry System -Action ESAP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSESS07 I should see Award Details as "<Plan>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" 

Examples:  
		| Plan | Action | LocateArgument | Line1                                                                                                  | Line2                                                                                                  | Line3                                                                                                  | Line4                                                                                                  | Line5                                                                                                  | Line6                                                                                                  | Line7                                                                                                  | Line8                                                                                                  | Line9                                                                                   |
		| ESO  | ESAP   | /ESO           | 05A EF   19/09/2005  19/09/2008  19/09/2008  None              0   31.760000                        15 | 05C EF   15/12/2005  15/12/2008  15/12/2008  None              0   31.720000                        16 | 09A EF   11/12/2009  11/12/2012  11/12/2012  None              0   28.070000                        28 | 09B EF   11/12/2009  11/12/2012  11/12/2012  None            100   28.070000      2807.00          100 | 10A EF   15/12/2010  15/12/2018  15/12/2013  None              0   23.830000                        46 | 11A EF   14/12/2011  14/12/2014  14/12/2014  None              0   24.430000                        40 | 12A EF   12/12/2012  12/12/2015  12/12/2015  None              0   24.360000                        36 | 13A EF   11/12/2013  11/12/2016  11/12/2016  None              0   33.990000                        26 | ** Plan Total                                 100*                 2807.00*         307 |
		| ATS  | ESAP   | /ATS           | 05A EB   22/11/2005  22/11/2006  22/11/2006  22/11/2006        0   33.230000                        26 | 10A EB   02/06/2010  16/06/2018  02/06/2020  16/11/2010       10   28.920000       289.20           10 | ** Plan Total                                  10*                  289.20*          36                |                                                                                                        |                                                                                                        |                                                                                                        |                                                                                                        |                                                                                                        |                                                                                         |
		| ELA  | ESAP   | /ELA           | 97A ER   14/11/1997  15/09/2018  None        15/09/2018      252   20.710000      5218.92          252 | 98A ER   13/11/1998  14/11/1998  None        14/11/1998      283   23.050000      6523.15          283 | 99A ER   12/11/1999  13/11/1999  None        13/11/1999      198   24.010000      4753.98          198 | ** Plan Total                                 733*                16496.05*         733                |                                                                                                        |                                                                                                        |                                                                                                        |                                                                                                        |                                                                                         |  

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17358
Scenario Outline: Test Case 17358: 03_ESAP for Options and Performance Rights Plans
	# Enquiry System -Action ESAP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSESS23 I should see Grant Details as "<Plan>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" 

Examples:  
		| Plan | Action | LocateArgument | Line1                                                                                                                     | Line2                                                                                                                     | Line3                                                                                                                     | Line4                                                                                                                     |
		| OPT  | ESAP   | /OPT           | 21A EE   01/05/2014         HK Def   01/05/2014  01/01/2016 01/06/2020       10000     1.000000     10000.00        10000 | 21A EX   15/05/2014         HK Def   15/05/2014  01/01/2016 01/06/2020        1000     1.000000      1000.00         1000 | 7B1 EE   07/02/2007         Lvr Def  07/02/2007  07/02/2010 10/02/2000           0    40.910000         0.00           74 | 7B3 EE   07/02/2007         Lvr Def  07/02/2007  07/02/2012 10/02/2000           0    40.910000         0.00           73 |
		| PRS  | ESAP   | /PRS           | 7B1 EE   07/02/2007         Lvr Def  07/02/2007  07/02/2010 10/02/2000           0                      0.00           19 | 7B2 EE   07/02/2007         Lvr Def  07/02/2007  07/02/2011 10/02/2000           0                      0.00           18 | 7B3 EE   07/02/2007         Lvr Def  07/02/2007  07/02/2012 10/02/2000           0                      0.00           18 | ** Plan Total                                                   0*                     0.00*          55                  |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17366
@FullSmokeTest
Scenario: Test Case 17366: 01_Loan Action ESLB
	# Enquiry System -Action EESLB
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESLB  |
			| Locate Argument | /ELA  |
	Then In ENSESS19 I should see Loan Balance as below:
		| Field | Value                                                                                |
		| HIN   | I0033314515                                                                          |
		| Line1 | ELA STF SHARE OWNERSHIP PLAN(LOAN)                                                   |
		| Line2 | 97A 0000008515 14/11/1997        252          0.00           0.00     Yes          0 |
		| Line3 | 98A 0000008516 13/11/1998        283          0.00           0.00     Yes          0 |
		| Line4 | 99A 0000008517 12/11/1999        198          0.00           0.00     Yes          0 |
		| Line5 | *Plan Total              733*         0.00*          0.00 *                          |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS20 I should see Loan Extra details as below:
		| Field    | Value                                                          |
		| Plan     | ELA                                                            |
		| PlanDesc | STF SHARE OWNERSHIP PLAN(LOAN)                                 |
		| Reg      | 97A                                                            |
		| RegDesc  | 1997 AWARD                                                     |
		| Line1    | 14/11/1997 ESAWL  2186/38412100/0001         5216.40- 17607842 |
		| Line2    | 17/12/1997 ESDPY  2056/38412101/0001           98.78  17151858 |
		| Line3    | 22/07/1998 ESDPY  2241/38412102/0001           98.78  18220930 |
		| Line4    | 16/12/1998 ESDPY  2373/38412103/0001          133.56  19401866 |
		| Line5    | 21/07/1999 ESDPY  2551/38412104/0001          136.08  20592651 |
		| Line6    | 15/12/1999 ESDPY  2698/38412105/0001          146.16  22293330 |
		| Line7    | 05/07/2000 ESDPY  2867/38412106/0001          148.68  23290375 |
		| Line8    | 13/12/2000 ESDPY  3019/38412107/0001          161.28  26003648 |
		| Line9    | 04/07/2001 ESDPY  3191/38412108/0001          168.84  26717559 |
		| Line10   | 12/12/2001 ESDPY  3342/38412109/0001          171.36  28673749 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS05 I should see Employee Expand History "on" as below:
	 			| Field              | Value       |
	 			| On HIN             | I0033314515 |
	 			| On Class           | ELA         |
	 			| On Register        | 97A         |
	 			| On Certificate ID  | 19971114ER  |
	 			| On Units           | 252         |
	 			| On Total Cost      | 5218.92     |
	 			| On Share Cost      | 20.710000   |
	 			| Off HIN            |             |
	 			| Off Class          |             |
	 			| Off Register       |             |
	 			| Off Certificate ID |             |
	 			| Off Units          |             |
	 			| Off Total Cost     |             |
@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17367
Scenario: Test Case 17367: 02_Loan Action ESLT
	# Enquiry System -Action EESLT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the Locate action:
			| Field           | Value    |
			| Action          | ESLT     |
			| Locate Argument | /ELA/97A |
	Then In ENSESS20 I should see Loan Extra details as below:
		| Field    | Value                                                          |
		| Plan     | ELA                                                            |
		| PlanDesc | STF SHARE OWNERSHIP PLAN(LOAN)                                 |
		| Reg      | 97A                                                            |
		| RegDesc  | 1997 AWARD                                                     |
		| Line1    | 14/11/1997 ESAWL  2186/38412100/0001         5216.40- 17607842 |
		| Line2    | 17/12/1997 ESDPY  2056/38412101/0001           98.78  17151858 |
		| Line3    | 22/07/1998 ESDPY  2241/38412102/0001           98.78  18220930 |
		| Line4    | 16/12/1998 ESDPY  2373/38412103/0001          133.56  19401866 |
		| Line5    | 21/07/1999 ESDPY  2551/38412104/0001          136.08  20592651 |
		| Line6    | 15/12/1999 ESDPY  2698/38412105/0001          146.16  22293330 |
		| Line7    | 05/07/2000 ESDPY  2867/38412106/0001          148.68  23290375 |
		| Line8    | 13/12/2000 ESDPY  3019/38412107/0001          161.28  26003648 |
		| Line9    | 04/07/2001 ESDPY  3191/38412108/0001          168.84  26717559 |
		| Line10   | 12/12/2001 ESDPY  3342/38412109/0001          171.36  28673749 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS05 I should see Employee Expand History "on" as below:
	 			| Field              | Value       |
	 			| On HIN             | I0033314515 |
	 			| On Class           | ELA         |
	 			| On Register        | 97A         |
	 			| On Certificate ID  | 19971114ER  |
	 			| On Units           | 252         |
	 			| On Total Cost      | 5218.92     |
	 			| On Share Cost      | 20.710000   |
	 			| Off HIN            |             |
	 			| Off Class          |             |
	 			| Off Register       |             |
	 			| Off Certificate ID |             |
	 			| Off Units          |             |
	 			| Off Total Cost     |             |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17369
@FullSmokeTest
Scenario Outline: Test Case 17369: 01_ESOB for Option plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS24 I should see Options Balance as "<Plan>" "<PlanDesc>" "<Line1>" "<Line2>" "<Line3>" "<Line4>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 2     |
			| Locate Argument |       |
	Then In ENSESS25 I should see Vesting Transaction details as below "<Tran1>"

Examples: 
		| Plan | HIN         | Action | LocateArgument | PlanDesc                       | Line1                                                                                                                       | Line2                                                                                                                       | Line3                                                                                                                       | Line4                                                                                                                       | Tran1                                                                                                                           |
		| OPT  | I0033870752 | ESOB   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 7B1 EE   07/02/2007 HK Def          480           0           0           0           0           0           0         480 | 7B2 EE   07/02/2007 HK Def          480           0           0           0           0           0           0         480 | 7B3 EE   07/02/2007 HK Def          480           0           0           0           0           0           0         480 | 7C2 EE   07/02/2007 HK Def         1000        1000         569         431           0           0           0           0 | 7B2 EE  07/02/07     V69  VR6  HK Def         480  01/01   07/02/12           0           0           0         480           0 |
		| PRS  | I0033870752 | ESOB   | /PRS           | PERFORMANCE RIGHTS             | 15K EE   18/02/2015 HK Def         1000        1000        1000           0           0           0           0           0 | 7B1 EE   07/02/2007 HK Def          120           0           0           0           0           0           0         120 | 7B2 EE   07/02/2007 HK Def          120           0           0           0           0           0           0         120 | 7B3 EE   07/02/2007 HK Def          120           0           0           0           0           0           0         120 | 7B1 EE  07/02/07     VJ6  PJ6  HK Def         120  01/01   09/03/11           0           0         120           0           0 |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17370
Scenario Outline: Test Case 17370: 02_ESOT for Option plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS25 I should see Options Balance as "<Plan>" "<PlanDesc>" "<Line1>" "<Line2>" "<Line3>" 

Examples: 
		| Plan | HIN         | PlanDesc                       | Line1                                                                                                                           | Line2                                                                                                                           | Line3                                                                                                                           | Action | LocateArgument |
		| OPT  | I0033870752 | EXECUTIVE SHARE OPTION PLAN #2 | 7B1 EE  07/02/07     V68  P68  HK Def         480  01/01   09/03/11           0           0         480           0           0 | 7B2 EE  07/02/07     V69  VR6  HK Def         480  01/01   07/02/12           0           0           0         480           0 | 7B3 EE  07/02/07     V70  VR7  HK Def         480  01/01   07/02/12           0           0           0         480           0 | ESOT   | /OPT           |
		| PRS  | I0033870752 | PERFORMANCE RIGHTS             | 7B1 EE  07/02/07     VJ6  PJ6  HK Def         120  01/01   09/03/11           0           0         120           0           0 | 7B2 EE  07/02/07     VJ7  VT6  HK Def         120  01/01   07/02/12           0           0           0         120           0 | 7B3 EE  07/02/07     VJ8  VT7  HK Def         120  01/01   07/02/12           0           0           0         120           0 | ESOT   | /PRS           |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17370
#Need to get new Test Data
Scenario Outline: Test Case 17370: 02_ESOTF for Option plan
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS26 I should see Future Vesting Details as "<ClassCode>" "<PlanDesc>" "<Line1>" "<Line2>" "<Line3>" "<Line4>"

Examples: 
		| ClassCode | HIN         | PlanDesc                       | Line1                                                                                                         | Line2                                                  | Action | LocateArgument | Line3 | Line4 |
		| OPT       | I0033870752 | EXECUTIVE SHARE OPTION PLAN #2 | 7C2 EE   07/02/2007     V72  P72  HK Def        1000  01/      No Date            569 * Performance Test Req  | 23/02/2016           0           0        1000         | ESOTF  | /OPT           |       |       |
		| PRS       | I0033870752 | PERFORMANCE RIGHTS             | 15K EE   18/02/2015     W20  W20  HK Def        1000  01/01    21/12/2018           0           0           0 | 01/      No Date           1000 * Performance Test Req | ESOTF  | /PRS           |       |       |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17351
@FullSmokeTest
Scenario Outline: Test Case 19969:01_VWAP Dates and Prices
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | VWAP  |
			| Locate Argument |       |
		And In SELVWP00 I enter VWAP details as "<Class>" "<Date>"
		Then In SELVWP01 I should see VWAP details as "<Class>" "<ISIN>" "<Exchange>" "<Currency>" "<Date>" "<1DayVWAP>" "<MultiDayVWAP>" "<1DayTradeVolume>" "<ClosingPrice>"

Examples: 
		| VWAPDate | Class | Date       | ISIN         | Exchange | Currency | 1DayVWAP  | MultiDayVWAP | 1DayTradeVolume | ClosingPrice |
		| Date1    | ORD   | 04/01/2000 | AU000000NAB4 | ASX      | AUD      | 0.000000  | 22.806531    | 2852975         | 0.000000     |
		| Date2    | ORD   | 06/01/2014 | AU000000NAB4 | ASX      | AUD      | 34.578888 | 34.713326    | 1721511         | 34.550000    |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17352
Scenario Outline: Test Case 17352: 02_DATEC Dates and Prices
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DATEC |
			| Locate Argument |       |
		And In ENSESS28 I Enter Date range as "<FromDate>" "<ToDate>" "<NoOfMonths>" "<Days>"
	Then In ENSESS28 I should see date range as "<DateTo>" "<Months>" "<NoOfDays>"

Examples: 
		| DateRange  | FromDate | ToDate     | NoOfMonths | Days | DateTo     | Months | NoOfDays |
		| DateRange1 | 01012015 | 05/04/2015 |            |      | 05/04/2015 | 3      | 4        |
		| DateRange2 | 01012015 |            | 3          | 4    | 05/04/2015 | 3      | 4        |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17386
Scenario Outline: Test Case 17386: 01_ESLP Leavers
	#Action -ESLP
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS31 I should see Leaver Processing details as "<Plan>" "<PlanDesc>" "<Line1>" "<Line2>" "<Line3>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 2     |
			| Locate Argument |       |
	Then In ENSESS32 I should see Leaver processing extra details as "<Plan>" "<PlanDesc>" "<ExtraLine1>" "<ExtraLine2>" "<ExtraLine3>" "<ExtraLine4>"
	#When I enter the following details as the Locate action:
	#		| Field           | Value |
	#		| Action          | >     |
	#		| Locate Argument |       |
	#Then In ENSESS34 I should see Leaver Processing Popup details as "<PopupLine1>"

Examples: 
		| Plan | Action | LocateArgument | PlanDesc                       | Line1                                                                                | Line2                                                                                | Line3                                                                                | ExtraLine1                                                                                                                      | PopupLine1                                        | ExtraLine2 | ExtraLine3 | ExtraLine4 |
		| OPT  | ESLP   | /OPT           | EXECUTIVE SHARE OPTION PLAN #2 | 7B1 EE   07/02/2007  Lvr Def   08/05/2015   12/11/1999        Y     7650    00003265 | 7B2 EE   07/02/2007  Lvr Def   08/05/2015   12/11/1999        Y     7650    00003265 | 7B3 EE   07/02/2007  Lvr Def   08/05/2015   12/11/1999        Y     7650    00003265 | 7B2 EE   07/02/2007           0           0           0           0           0           0           0           0           0 | 0           0           0           0  10/02/2000 |            |            |            |
		| PRS  | ESLP   | /PRS           | PERFORMANCE RIGHTS             | 7B1 EE   07/02/2007  Lvr Def   08/05/2015   12/11/1999        N     7650    00036587 | 7B2 EE   07/02/2007  Lvr Def   08/05/2015   12/11/1999        N     7650    00036587 | 7B3 EE   07/02/2007  Lvr Def   08/05/2015   12/11/1999        N     7650    00036587 | 7B2 EE   07/02/2007           0           0           0           0           0           0           0           0           0 | 0           0           0           0  10/02/2000 |            |            |            |

@winformsTest
@EnquiryTest
@NAB_AUTO
@EN_E_ESS_EmployeeOptions
@17390
Scenario Outline: Test Case 17390: 02_Tax processing
	#Action -ESTR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESTR  |
			| Locate Argument |       |
		And In ENSESS54 I enter following details in the ESS Tax reporting Enquiry "<Class>" "<FY>"
	Then In ENSESS55 I should see ESS Tax Reporting as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS56 I should see ESS Tax Reporting Extra Details as "<Class>" "<FY>" "<ExtraLine1>"

Examples: 
		| Class | FY   | Line1                                                                                        | Line2                                                                                                     | Line3                                                                                                       | Line4                                                                                                     | Line5                                                                                                    | ExtraLine1                                                                                                       |
		| OPT   | 2014 | 0001 ET  OPT 2014 Original Generate  No  Generate   Generate  03/04/2014 15:36   No       No | 0002 ET  OPT 2014 Original Cancelled Yes Cancelled  Cancelled 29/04/2014 12:38   Yes      No  NABSRN.TEMP | 0003 ET  OPT 2014 Original Generate  Yes Generate   Generate  29/04/2014 13:18   No       No  NABIASRN.TEMP | 0004 ET  OPT 2014 Original Generate  No  Generate   Generate  07/05/2014 15:49   No       No  NABSRN.TEMP | 0005 ET  OPT 2014 Original Generate  No  Generate   Generate  07/05/2014 16:27   No       No  NABIA.TEMP | 0001 ET  OPT 2014 Original   SmiK 00003                                       2              2  03/04/2014 15:36 |
		| PRS   | 2014 | 0001 ET  PRS 2014 Original Generate  No  Generate   Generate  03/04/2014 15:42   No       No | 0002 ET  PRS 2014 Original Cancelled Yes Cancelled  Cancelled 29/04/2014 12:41   Yes      No  NABSRN.TEMP | 0003 ET  PRS 2014 Original Generate  Yes Generate   Generate  29/04/2014 13:19   No       No  NABIASRN.TEMP | 0004 ET  PRS 2014 Original Generate  No  Generate   Generate  07/05/2014 15:52   No       No  NABSRN.TEMP | 0005 ET  PRS 2014 Original Generate  No  Generate   Generate  07/05/2014 16:28   No       No  NABIA.TEMP | 0001 ET  PRS 2014 Original   SmiK 00003                                     108            108  03/04/2014 15:43 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17835
@FullSmokeTest
Scenario Outline: Test Case 17835: 01_ EETD Action to display forms ENSESS58, 51, 52 and 53
	#Action -EETD
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500007470"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EETD  |
			| Locate Argument |       |
	Then In ENSESS58 I should see Event tax Details as below:
			| Field | Value                                                          |
			| HIN   | I5500007470                                                    |
			| Line1 | DCP     04/03/2015  DC2    V          2009 DCP  TRANCHE 2 VEST |
			| Line2 |                                                                |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS51 I should see Event Tax Details as below:
			| Field    | Value                                                                                    |
			| Plan     | DCP                                                                                      |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                               |
			| Line1    | 09E  EX     23/09/2014  04/03/2015  DC2    V            0.000000                     Yes |
			| Line2    | 09E  EX     31/03/2014  04/03/2015  DC2    V            0.000000                     Yes |
			| Line3    | 09E  EX     23/09/2013  04/03/2015  DC2    V            0.000000                     Yes |
			| Line4    | 09E  EX     28/03/2013  04/03/2015  DC2    V            0.000000                     Yes |
			| Line5    | 09E  EX     24/09/2012  04/03/2015  DC2    V            0.000000                     Yes |
			| Line6    | 09E  EX     30/03/2012  04/03/2015  DC2    V            0.000000                     Yes |
	When I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENSESS52 I should see Event Tax Details as "<Plan>" "<PlanDesc>" "<Register>" "<RegType>" "<Line1>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then I expect to see error with text "No Additional Details available"
	#Then In ENSESS53 I should see Complex Holder Code as below:
	#		| Field    | Value                 |
	#		| Code     | ABC                   |
	#		| CodeDesc | COMPLEX HOLDER CODE 1 |						

Examples: 
		| RegType | Action | LocateArgument | Plan | PlanDesc                   | Register | Line1                                                                                         |
		| EX      | 6      |                | DCP  | DEFERRED COMPENSATION PLAN | 09E      | DC2     V        04/03/2015     0.000000                                                   No |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17837
Scenario: Test Case 17837: 03_ Events ESREH with AESS Plan
	#Action -ESREH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030075161"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESREH |
			| Locate Argument | /DCP  |
	Then In ENSESS45 I should see Register Event History as below:
			| Field    | Value                                                                                                         |
			| HIN      | I0030075161                                                                                                   |
			| Plan     | DCP                                                                                                           |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                                                    |
			| Line1    | V/DC2  09E  EX   04/03/2015  23/09/2014           9           0           9             0                  No |
			| Line2    | V/DC2  09E  EX   04/03/2015  31/03/2014           7           0           7             0                  No |
			| Line3    | V/DC2  09E  EX   04/03/2015  23/09/2013           9           0           9             0                  No |
			| Line4    | V/DC2  09E  EX   04/03/2015  28/03/2013           5           0           5             0                  No |
			| Line5    | V/DC2  09E  EX   04/03/2015  24/09/2012          21           0          21             0                  No |
			| Line6    | V/DC2  09E  EX   04/03/2015  30/03/2012          14           0          14             0                  No |
			| Line7    | V/DC2  09E  EX   04/03/2015  23/09/2011          29           0          29             0                  No |
			| Line8    | V/DC2  09E  EX   04/03/2015  11/04/2011          24           0          24             0                  No |
			| Line9    | V/DC2  09E  EX   04/03/2015  22/09/2010          22           0          22             0                  No |
			| Line10   | V/DC2  09E  EX   04/03/2015  30/03/2010          18           0          18             0                  No |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS46 I should see Event Transaction Details as below:
			| Field        | Value                                                                                                          |
			| HIN          | I0030075161                                                                                                    |
			| Plan         | DCP                                                                                                            |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                                     |
			| EventType    | V                                                                                                              |
			| EventCode    | DC2                                                                                                            |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                                            |
			| Register     | 09E                                                                                                            |
			| RegisterType | EX                                                                                                             |
			| EventDate    | 04/03/2015                                                                                                     |
			| Certificate  | 20140923EX                                                                                                     |
			| Line1        | 04/03/2015     EVEVP        5113/10303371     10:06                                                     WINFRM |
			| Line2        | 04/03/2015     EVEVP        5113/10297719     08:16         9DCP0000005                                 SCRIP  |
			| Line3        | 04/03/2015     EVELC        5113/10297717     08:16                                                     SCRIP  |
			| Line4        | 12/02/2015     EVADD        5097/10147926     13:19                                                     SCRIP  | 
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 3     |
			| Locate Argument |       |
	Then In ENSESS43 I should see Static Transactions as below:
			| Field        | Value                                                                               |
			| HIN          | I0030075161                                                                         |
			| Plan         | DCP                                                                                 |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                          |
			| EventType    | V                                                                                   |
			| EventCode    | DC2                                                                                 |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                 |
			| Register     | 09E                                                                                 |
			| RegisterType | EX                                                                                  |
			| Certificate  | 20140923EX                                                                          |
			| Line1        | Before/           Not Recvd                                      0                0 |
			| Line2        | After /           Default           Exer-Hold All                9                0 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17839
Scenario: Test Case 17839: 04_ Events ESHV with AESS Plan_ENSESS49
	#Action -ESHV
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030075161"
		And I enter the following details as the Locate action:
			| Field           | Value                               |
			| Action          | ESHV                                |
			| Locate Argument | /DCP/09E/EX/V/DC2/04032015/23092014 |
	Then In ENSESS46 I should see Event Transaction Details as below:
			| Field        | Value                                                                                                          |
			| HIN          | I0030075161                                                                                                    |
			| Plan         | DCP                                                                                                            |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                                     |
			| EventType    | V                                                                                                              |
			| EventCode    | DC2                                                                                                            |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                                            |
			| Register     | 09E                                                                                                            |
			| RegisterType | EX                                                                                                             |
			| EventDate    | 04/03/2015                                                                                                     |
			| Certificate  | 20140923EX                                                                                                     |
			| Line1        | 04/03/2015     EVEVP        5113/10303371     10:06                                                     WINFRM |
			| Line2        | 04/03/2015     EVEVP        5113/10297719     08:16         9DCP0000005                                 SCRIP  |
			| Line3        | 04/03/2015     EVELC        5113/10297717     08:16                                                     SCRIP  |
			| Line4        | 12/02/2015     EVADD        5097/10147926     13:19                                                     SCRIP  | 
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS49 I should see Static Transactions as below:
			| Field       | Value                                                                      |
			| HIN         | I0030075161                                                                |
			| Plan        | DCP                                                                        |
			| PlanDesc    | DEFERRED COMPENSATION PLAN                                                 |
			| EventType   | V                                                                          |
			| EventCode   | DC2                                                                        |
			| EventDesc   | 2009 DCP  TRANCHE 2                                                        |
			| EventStatus | Current                                                                    |
			| Line1       | 09E     20140923EX                    9        Pending           Completed |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17839
Scenario: Test Case 17839: 04_ Events ESHV with AESS Plan_ENSESS43
	#Action -ESHV
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030075161"
		And I enter the following details as the Locate action:
			| Field           | Value                               |
			| Action          | ESHV                                |
			| Locate Argument | /DCP/09E/EX/V/DC2/04032015/23092014 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 3     |
			| Locate Argument |       |
	Then In ENSESS43 I should see Static Transactions as below:
			| Field        | Value                                                                               |
			| HIN          | I0030075161                                                                         |
			| Plan         | DCP                                                                                 |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                          |
			| EventType    | V                                                                                   |
			| EventCode    | DC2                                                                                 |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                 |
			| Register     | 09E                                                                                 |
			| RegisterType | EX                                                                                  |
			| Certificate  | 20140923EX                                                                          |
			| Line1        | Before/           Not Recvd                                      0                0 |
			| Line2        | After /           Default           Exer-Hold All                9                0 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17839
Scenario: Test Case 17839: 04_ Events ESHV with AESS Plan_ENSESS47
	#Action -ESHV
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030075161"
		And I enter the following details as the Locate action:
			| Field           | Value                               |
			| Action          | ESHV                                |
			| Locate Argument | /DCP/09E/EX/V/DC2/04032015/23092014 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 4     |
			| Locate Argument |       |
	Then In ENSESS47 I should see Static Transactions as below:
			| Field       | Value                                   |
			| HIN         | I0030075161                             |
			| Plan        | DCP                                     |
			| PlanDesc    | DEFERRED COMPENSATION PLAN              |
			| EventType   | V                                       |
			| EventCode   | DC2                                     |
			| EventDesc   | 2009 DCP  TRANCHE 2                     |
			| EventStatus | Current                                 |
			| Line1       | 09E     20140923EX                    9 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17841
Scenario: Test Case 17841: 05_ Events ESEH with AESS Plan_EVELC
	#Action -ESEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030075161"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESEH  |
			| Locate Argument | /DCP  |
	Then In ENSESS40 I should see Event History Details as below:
			| Field    | Value                                                                                               |
			| HIN      | I0030075161                                                                                         |
			| Plan     | DCP                                                                                                 |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                                          |
			| Line1    | V/DC2  09E  EX   04/03/2015  23/09/2014  Current   Default     Completed       E      Exer-Hold All |
			| Line2    | V/DC2  09E  EX   04/03/2015  31/03/2014  Current   Default     Completed       E      Exer-Hold All |
			| Line3    | V/DC2  09E  EX   04/03/2015  23/09/2013  Current   Default     Completed       E      Exer-Hold All |
			| Line4    | V/DC2  09E  EX   04/03/2015  28/03/2013  Current   Default     Completed       E      Exer-Hold All |
			| Line5    | V/DC2  09E  EX   04/03/2015  24/09/2012  Current   Default     Completed       E      Exer-Hold All |
			| Line6    | V/DC2  09E  EX   04/03/2015  30/03/2012  Current   Default     Completed       E      Exer-Hold All |
			| Line7    | V/DC2  09E  EX   04/03/2015  23/09/2011  Current   Default     Completed       E      Exer-Hold All |
			| Line8    | V/DC2  09E  EX   04/03/2015  11/04/2011  Current   Default     Completed       E      Exer-Hold All |
			| Line9    | V/DC2  09E  EX   04/03/2015  22/09/2010  Current   Default     Completed       E      Exer-Hold All |
			| Line10   | V/DC2  09E  EX   04/03/2015  30/03/2010  Current   Default     Completed       E      Exer-Hold All |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS45 I should see Register Event History as below:
			| Field    | Value                                                                                                         |
			| HIN      | I0030075161                                                                                                   |
			| Plan     | DCP                                                                                                           |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                                                    |
			| Line1    | V/DC2  09E  EX   04/03/2015  23/09/2014           9           0           9             0                  No |
			| Line2    | V/DC2  09E  EX   04/03/2015  31/03/2014           7           0           7             0                  No |
			| Line3    | V/DC2  09E  EX   04/03/2015  23/09/2013           9           0           9             0                  No |
			| Line4    | V/DC2  09E  EX   04/03/2015  28/03/2013           5           0           5             0                  No |
			| Line5    | V/DC2  09E  EX   04/03/2015  24/09/2012          21           0          21             0                  No |
			| Line6    | V/DC2  09E  EX   04/03/2015  30/03/2012          14           0          14             0                  No |
			| Line7    | V/DC2  09E  EX   04/03/2015  23/09/2011          29           0          29             0                  No |
			| Line8    | V/DC2  09E  EX   04/03/2015  11/04/2011          24           0          24             0                  No |
			| Line9    | V/DC2  09E  EX   04/03/2015  22/09/2010          22           0          22             0                  No |
			| Line10   | V/DC2  09E  EX   04/03/2015  30/03/2010          18           0          18             0                  No |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 5     |
			| Locate Argument |       |
	Then In ENSESS46 I should see Event Transaction Details as below:
			| Field        | Value                                                                                                          |
			| HIN          | I0030075161                                                                                                    |
			| Plan         | DCP                                                                                                            |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                                     |
			| EventType    | V                                                                                                              |
			| EventCode    | DC2                                                                                                            |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                                            |
			| Register     | 09E                                                                                                            |
			| RegisterType | EX                                                                                                             |
			| EventDate    | 04/03/2015                                                                                                     |
			| Certificate  | 20120924EX                                                                                                     |
			| Line1        | 04/03/2015     EVEVP        5113/10303363     10:06                                                     WINFRM |
			| Line2        | 04/03/2015     EVEVP        5113/10297707     08:16         9DCP0000005                                 SCRIP  |
			| Line3        | 04/03/2015     EVELC        5113/10297705     08:16                                                     SCRIP  |
			| Line4        | 12/02/2015     EVADD        5097/10147926     13:19                                                     SCRIP  |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 3     |
			| Locate Argument |       |			 
	Then In ENSESS43 I should see Static Transactions as below:
			| Field        | Value                                                                               |
			| HIN          | I0030075161                                                                         |
			| Plan         | DCP                                                                                 |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                          |
			| EventType    | V                                                                                   |
			| EventCode    | DC2                                                                                 |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                 |
			| Register     | 09E                                                                                 |
			| RegisterType | EX                                                                                  |
			| Certificate  | 20120924EX                                                                          |
			| Line1        | Before/           Not Recvd                                      0                0 |
			| Line2        | After /           Default           Exer-Hold All               21                0 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17841
Scenario: Test Case 17841: 05_ Events ESEH with AESS Plan_EVADD
	#Action -ESEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030075161"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESEH  |
			| Locate Argument | /DCP  |
	Then In ENSESS40 I should see Event History Details as below:
			| Field    | Value                                                                                               |
			| HIN      | I0030075161                                                                                         |
			| Plan     | DCP                                                                                                 |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                                          |
			| Line1    | V/DC2  09E  EX   04/03/2015  23/09/2014  Current   Default     Completed       E      Exer-Hold All |
			| Line2    | V/DC2  09E  EX   04/03/2015  31/03/2014  Current   Default     Completed       E      Exer-Hold All |
			| Line3    | V/DC2  09E  EX   04/03/2015  23/09/2013  Current   Default     Completed       E      Exer-Hold All |
			| Line4    | V/DC2  09E  EX   04/03/2015  28/03/2013  Current   Default     Completed       E      Exer-Hold All |
			| Line5    | V/DC2  09E  EX   04/03/2015  24/09/2012  Current   Default     Completed       E      Exer-Hold All |
			| Line6    | V/DC2  09E  EX   04/03/2015  30/03/2012  Current   Default     Completed       E      Exer-Hold All |
			| Line7    | V/DC2  09E  EX   04/03/2015  23/09/2011  Current   Default     Completed       E      Exer-Hold All |
			| Line8    | V/DC2  09E  EX   04/03/2015  11/04/2011  Current   Default     Completed       E      Exer-Hold All |
			| Line9    | V/DC2  09E  EX   04/03/2015  22/09/2010  Current   Default     Completed       E      Exer-Hold All |
			| Line10   | V/DC2  09E  EX   04/03/2015  30/03/2010  Current   Default     Completed       E      Exer-Hold All |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 5     |
			| Locate Argument |       |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 4     |
			| Locate Argument |       |			 
	Then In ENSESS47 I should see Static Transactions as below:
			| Field       | Value                                   |
			| HIN         | I0030075161                             |
			| Plan        | DCP                                     |
			| PlanDesc    | DEFERRED COMPENSATION PLAN              |
			| EventType   | V                                       |
			| EventCode   | DC2                                     |
			| EventDesc   | 2009 DCP  TRANCHE 2                     |
			| EventStatus | Current                                 |
			| Line1       | 09E     20120924EX                   21 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17842
Scenario: Test Case 17842: 06_ Events ESEH with AESS Plan_EVTAX
	#Action -ESEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500034124"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESEH  |
			| Locate Argument | /DCP  |
	Then In ENSESS40 I should see Event History Details as below:
			| Field    | Value                                                                                                                      |
			| HIN      | I5500034124                                                                                                                |
			| Plan     | DCP                                                                                                                        |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                                                                 |
			| Line1    | V/DC7  09N  EX   04/03/2015  23/09/2014  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line2    | V/DC7  09N  EX   04/03/2015  31/03/2014  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line3    | V/DC7  09N  EX   04/03/2015  23/09/2013  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line4    | V/DC7  09N  EX   04/03/2015  28/03/2013  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line5    | V/DC7  09N  EX   04/03/2015  24/09/2012  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line6    | V/DC7  09N  EX   04/03/2015  30/03/2012  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line7    | V/DC7  09N  EX   04/03/2015  23/09/2011  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line8    | V/DC7  09N  EX   04/03/2015  11/04/2011  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line9    | V/DC7  09N  EX   04/03/2015  22/09/2010  Current   Default     Completed       E      Exer-STC            Employer Payment |
			| Line10   | V/DC7  09N  EX   04/03/2015  30/03/2010  Current   Default     Completed       E      Exer-STC            Employer Payment |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS45 I should see Register Event History as below:
			| Field    | Value                                                                                                          |
			| HIN      | I5500034124                                                                                                    |
			| Plan     | DCP                                                                                                            |
			| PlanDesc | DEFERRED COMPENSATION PLAN                                                                                     |
			| Line1    | V/DC7  09N  EX   04/03/2015  23/09/2014         341           0         341             0                  Yes |
			| Line2    | V/DC7  09N  EX   04/03/2015  31/03/2014         249           0         249             0                  Yes |
			| Line3    | V/DC7  09N  EX   04/03/2015  23/09/2013         339           0         339             0                  Yes |
			| Line4    | V/DC7  09N  EX   04/03/2015  28/03/2013         188           0         188             0                  Yes |
			| Line5    | V/DC7  09N  EX   04/03/2015  24/09/2012         784           0         784             0                  Yes |
			| Line6    | V/DC7  09N  EX   04/03/2015  30/03/2012         501           0         501             0                  Yes |
			| Line7    | V/DC7  09N  EX   04/03/2015  23/09/2011        1071           0        1071             0                  Yes |
			| Line8    | V/DC7  09N  EX   04/03/2015  11/04/2011         873           0         873             0                  Yes |
			| Line9    | V/DC7  09N  EX   04/03/2015  22/09/2010         812           0         812             0                  Yes |
			| Line10   | V/DC7  09N  EX   04/03/2015  30/03/2010         660           0         660             0                  Yes |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS46 I should see Event Transaction Details as below:
			| Field        | Value                                                                                                          |
			| HIN          | I5500034124                                                                                                    |
			| Plan         | DCP                                                                                                            |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                                     |
			| EventType    | V                                                                                                              |
			| EventCode    | DC7                                                                                                            |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                                            |
			| Register     | 09N                                                                                                            |
			| RegisterType | EX                                                                                                             |
			| EventDate    | 04/03/2015                                                                                                     |
			| Certificate  | 20140923EX                                                                                                     |
			| Line1        | 04/03/2015     EVEVP        5113/10306376     15:28                                                     WINFRM |
			| Line2        | 04/03/2015     EVEVP        5113/10301476     08:53         5DCP0000009                                 SCRIP  |
			| Line3        | 04/03/2015     EVELC        5113/10301474     08:53                                                     SCRIP  |
			| Line4        | 02/03/2015     EVTAX        5110/00555359     08:38                                                     WINFRM |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 4     |
			| Locate Argument |       |			 
	Then In ENSESS50 I should see Static Transactions as below: 
			| Field        | Value                                                                                                                 |
			| HIN          | I5500034124                                                                                                           |
			| Plan         | DCP                                                                                                                   |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                                            |
			| Register     | 09N                                                                                                                   |
			| RegisterDesc | MIG REG                                                                                                               |
			| Certificate  | 20140923EX                                                                                                            |
			| Line1        | Before/   DC7     V    04/03/2015       0.000000                                                                   No |
			| Line2        | After/    DC7     V    04/03/2015       7.030000    INT-ASS     INTERNATIONAL ASSIGNEE                 V           No |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18076
Scenario: Test Case 18076: 01_EH Action corresponds to Balance transaction
	#Action -EH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500009472"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
	Then In ENS01043 I should see Employee Share Plan Summary as below:
			| Field  | Value                                                          |
			| HIN    | I5500009472                                                    |
			| Line1  | DCP 09A E    3835/10003974/0001 05/03/2010 *SGRM/GRANT         |
			| Line2  | E    4595/10003048/0001 04/03/2013 *SREX/EXERCISE              |
			| Line3  | E    5115/00954595/0001 06/03/2015 ESLVP/ESS LEAVER PROCESSING |
			| Line4  | E    5115/00954595/0002 06/03/2015 ESLVP/ESS LEAVER PROCESSING |
			| Line5  | E    5115/00955056/0001 06/03/2015 ESLRV/ESS LEAVER REVERSAL   |
			| Line6  | E    5115/00955056/0002 06/03/2015 ESLRV/ESS LEAVER REVERSAL   |
			| Line7  | E    5115/00955057/0001 06/03/2015 ESLVP/ESS LEAVER PROCESSING |
			| Line8  | E    5115/00955057/0002 06/03/2015 ESLVP/ESS LEAVER PROCESSING |
			| Line9  | E    5198/00004512/0001 05/03/2010 ESGRM/MANUAL GRANT          |
			| Line10 | E    5199/10405960/0001 04/09/2013 ESLAV/LAPSE - AUTO - VESTED |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS05 I should see Employee Expand History "on" as below:
	 			| Field              | Value       |
	 			| On HIN             | I5500009472 |
	 			| On Class           | DCP         |
	 			| On Register        | 09A         |
	 			| On Certificate ID  | 20100305EE  |
	 			| On Units           | 843         |
	 			| On Total Cost      |             |
	 			| On Share Cost      |             |
	 			| Off HIN            |             |
	 			| Off Class          |             |
	 			| Off Register       |             |
	 			| Off Certificate ID |             |
	 			| Off Units          |             |
	 			| Off Total Cost     |             |		
		
@winformsTest
@EnquiryTest			  
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18080
Scenario: Test Case 18080: 02.1_EH Action corresponds to EVELA, EVADD & EVTAX transactions
	#Action -EH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500006139"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 4     |
			| Locate Argument |       |
	Then In ENSESS43 I should see Static Transactions as below:
			| Field        | Value                                                                                          |
			| HIN          | I5500006139                                                                                    |
			| Plan         | DCP                                                                                            |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                     |
			| EventType    | V                                                                                              |
			| EventCode    | DC7                                                                                            |
			| EventDesc    | 2009 DCP  TRANCHE 2                                                                            |
			| Register     | 09N                                                                                            |
			| RegisterType | EE                                                                                             |
			| Certificate  | 20100305EE                                                                                     |
			| Line1        | Before/           Not Recvd                                      0                0            |
			| Line2        | After /           Received          Exer-Hold All            11629                0    Trf VSA |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 2     |
			| Locate Argument |       |
	Then In ENSESS47 I should see Static Transactions as below:
			| Field       | Value                                   |
			| HIN         | I5500006139                             |
			| Plan        | DCP                                     |
			| PlanDesc    | DEFERRED COMPENSATION PLAN              |
			| EventType   | V                                       |
			| EventCode   | DC7                                     |
			| EventDesc   | 2009 DCP  TRANCHE 2                     |
			| EventStatus | Current                                 |
			| Line1       | 09N     20100305EE                11629 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 3     |
			| Locate Argument |       |
	Then In ENSESS50 I should see Static Transactions as below: 
			| Field        | Value                                                                                                                 |
			| HIN          | I5500006139                                                                                                           |
			| Plan         | DCP                                                                                                                   |
			| PlanDesc     | DEFERRED COMPENSATION PLAN                                                                                            |
			| Register     | 09N                                                                                                                   |
			| RegisterDesc | MIG REG                                                                                                               |
			| Certificate  | 20100305EE                                                                                                            |
			| Line1        | Before/   DC7     V    04/03/2015       0.000000                                                                   No |
			| Line2        | After/    DC7     V    04/03/2015      47.000000    GBR-RES     UNITED KINGDOM RESIDENT                V           No |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18095
Scenario Outline: Test Case 18095: 02.2_EH Action corresponds to ESLVP transaction
	#Action -EH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 5     |
			| Locate Argument |       |
	Then In ENSESS32 I should see Leaver processing extra details as "<Plan>" "<PlanDesc>" "<ExtraLine1>" "<ExtraLine2>" "<ExtraLine3>" "<ExtraLine4>"

Examples: 
	| Action | LocateArgument | Plan | PlanDesc                       | ExtraLine1 | ExtraLine2 | ExtraLine3 | ExtraLine4 | ExtraLine5 |
	| EH     | /OPT           | OPT  | EXECUTIVE SHARE OPTION PLAN #2 |            |            |            |            |            |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18097
Scenario: Test Case 18097: 02.3_EH Action corresponds to ESLRV transaction
	#Action -EH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030041437"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 5     |
			| Locate Argument |       |
	Then In ENSESS04 I should see Static Transactions as below: 
			| Field       | Value       |
			| HIN         | I0030041437 |
			| Class       | DCP         |
			| Reg         | 09T         |
			| Certificate | 20100305EE  |
			| Date        | 06/03/2015  |
			| TType       | ESLRV       |
			| Run         | 5115        |
			| Trans       | 00955078    |
			| Sequence    | 1           |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18112
Scenario: Test Case 18112: 03.1_LEH Action & ESHT Action with AESS Plan
	# Enquiry System -Action LEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I8800303631"
		And I enter the following details as the Locate action:
			| Field           | Value         |
			| Action          | LEH           |
			| Locate Argument | 4089/10006074 |
	Then In ENSESS05 I should see Employee Expand History "on" as below:
	 			| Field              | Value       |
	 			| On HIN             | I8800303631 |
	 			| On Class           | DEA         |
	 			| On Register        | 10F         |
	 			| On Certificate ID  | 20110307EE  |
	 			| On Units           | 1916        |
	 			| On Total Cost      |             |
	 			| On Share Cost      |             |
	 			| Off HIN            |             |
	 			| Off Class          |             |
	 			| Off Register       |             |
	 			| Off Certificate ID |             |
	 			| Off Units          |             |
	 			| Off Total Cost     |             |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESHT  |
			| Locate Argument | /DEA  |
	Then I ENSESS03 I should see Plan Holder Totals as below:
	 			| Field    | Value                                                                                                  |
	 			| HIN      | I8800303631                                                                                            |
	 			| Plan     | DEA                                                                                                    |
	 			| PlanDesc | DEFERRED EQUITY PLAN                                                                                   |
	 			| Line1    | 10G EE    Lvr Def  07/03/2011  07/03/2011 06/03/2016  06/09/2016        1916                      0.00 |
	 			| Line2    | 10G EX    Lvr Def  11/04/2011  07/03/2011 06/03/2016  06/09/2016          75                      0.00 |
	 			| Line3    | 10G EX    Lvr Def  23/09/2011  07/03/2011 06/03/2016  06/09/2016          92                      0.00 |
	 			| Line4    | 10G EX    Lvr Def  30/03/2012  07/03/2011 06/03/2016  06/09/2016          43                      0.00 |
	 			| Line5    | 10G EX    Lvr Def  24/09/2012  07/03/2011 06/03/2016  06/09/2016          68                      0.00 |
	 			| Line6    | 10G EX    Lvr Def  28/03/2013  07/03/2011 06/03/2016  06/09/2016          16                      0.00 |
	 			| Line7    | 10G EX    Lvr Def  23/09/2013  07/03/2011 06/03/2016  06/09/2016          29                      0.00 |
	 			| Line8    | 10G EX    Lvr Def  31/03/2014  07/03/2011 06/03/2016  06/09/2016          22                      0.00 |
	 			| Line9    | 10G EX    Lvr Def  23/09/2014  07/03/2011 06/03/2016  06/09/2016          29                      0.00 |
	 			| Line10   | 10G EX    HK Def   13/04/2015  07/03/2011 06/03/2016  06/09/2016          38                      0.00 |
				

@winformsTest
@EnquiryTest
@CPU_AUTO
@EN_E_ESS_EmployeeOptions
@18113
Scenario: Test Case 18113: 03.2_ESHT Action with AESS Plan to display ENSESS11
	# Enquiry System -Action ESHT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007347"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESHT  |
			| Locate Argument | /DEP  |
	Then In ENSESS11 I should see Plan Holder Totals as below:
		| Field     | Value                                                                                     |
		| HIN       | I0100007347                                                                               |
		| Plan      | DEP                                                                                       |
		| Plan Desc | DEFERRED EMP SHARE PLAN - AU                                                              |
		| Line1     | 06A EP   13/11/2006  13/11/2007  13/11/2016  None              2    7.780000        15.56 |
		| Line2     | 06A EP   12/12/2006  12/12/2007  12/12/2016  None             38    8.800000       334.40 |
		| Line3     | 06A EP   12/01/2007  12/01/2008  12/01/2017  None             39    8.650000       337.35 |
		| Line4     | 06A EP   12/02/2007  12/02/2008  12/02/2017  None             35    9.450000       330.75 |
		| Line5     | 06A EP   12/03/2007  12/03/2008  12/03/2017  None             33    9.937390       327.93 |
		| Line6     | 06A EP   16/04/2007  16/04/2008  16/04/2017  None             32   10.490000       335.68 |
		| Line7     | 06A EP   14/05/2007  14/05/2008  14/05/2017  None             30   11.069360       332.08 |
		| Line8     | 06A EP   12/06/2007  12/06/2008  12/06/2017  None             30   11.130000       333.90 |
		| Line9     | 07A EP   12/07/2007  12/07/2008  12/07/2017  None             31   10.819500       335.40 |
		| Line10    | 07A EM   25/07/2007  25/07/2009  25/07/2017  25/07/2009      275   10.872800      2990.02 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 10    |
			| Locate Argument |       |
	Then In ENSESS21 I should see holder extra details as below:
		| Field               | Value      |
		| ForfeitureType      | Pro Rata   |
		| ForfeitureStartDate | 25/07/2007 |
		| ForfeitureEndDate   | 25/07/2009 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18120
Scenario: Test Case 18120: 03.4_ESHT Action with Loan Plan to display ENSESS18
	# Enquiry System -Action ESHT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500018480"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESHT  |
			| Locate Argument | /LNN  |
	Then In ENSESS18 I should see Plan Holder Totals as below:
		| Field     | Value                                                                                             |
		| HIN       | I5500018480                                                                                       |
		| Plan      | LNN                                                                                               |
		| Plan Desc | LOAN NON-TRUST NON RECOURSE                                                                       |
		| Line1     | NRL ER   01/12/2014  01/03/2015  None        01/03/2015    11131                     0.00         |
		| Line2     |                                                                                                   |
		| Line3     |                                                                                                   |
		| Line4     | *                 Available  Unavailable    Reserved     Balance    Total Bal           (Unavail) |
		| Line5     | *   ER                11131            0           0       11131     58738.86                0.00 |
		| Line6     |                                                                                                   |
		| Line7     | ** Plan Total         11131            0           0       11131*        0.00*               0.00 |
		| Line8     |                                                                                                   |
		| Line9     |                                                                                                   |
		| Line10    |                                                                                                   |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENSESS22 I should see holder extra details as below:
		| Field                | Value      |
		| ForfeitureType       | Leaver     |
		| ForfeitureStartDate  | 01/12/2014 |
		| ForfeitureEndDate    | 01/03/2015 |
		| ForfeiturePercentage | 100        |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@18139
Scenario: Test Case 18139: 02.4_EH Action corresponds to ESCVP transaction
	#Action -EH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I0030033582"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | EH    |
			| Locate Argument |       |
	Then In ENS01043 I should see Employee Share Plan Summary as below:
			| Field  | Value                                                                        |
			| HIN    | I0030033582                                                                  |
			| Line1  | DCP 09A E    5198/00000002/0001 09/06/2015 ESCVP/ESS CHANGE VEST HURDLE CODE |
			| Line2  | E    5198/00000002/0002 09/06/2015 ESCVP/ESS CHANGE VEST HURDLE CODE         |
			| Line3  | E    5198/00000003/0001 09/06/2015 ESCVP/ESS CHANGE VEST HURDLE CODE         |
			| Line4  | E    5198/00000454/0001 04/09/2013 ESVLU/LEAVER LAPSE - UNVESTED             |
			| Line5  | E    5198/00000454/0002 09/06/2015 ESLVP/ESS LEAVER PROCESSING               |
			| Line6  | E    5198/00000454/0003 09/06/2015 ESLVP/ESS LEAVER PROCESSING               |
			| Line7  | E    5198/00004513/0001 05/03/2010 ESGRM/MANUAL GRANT                        |
			| Line8  | E    5198/04567547/0001 09/06/2015 EVADD/ADD ESS EVENT DETAILS               |
			| Line9  | EBS BSP F    0863/10013221/0001 19/06/1998 *MAWM/EMPLOYEE PLAN ALLOTMENT     |
			| Line10 | F    0927/10013222/0001 17/09/1998 *MEPR/EMPLOYEE PLAN REVERSAL              |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
Then In ENSESS33 I should see ESS Static Transactions as below:
			| Field               | Value                                               |
			| Run                 | 5198                                                |
			| Tran                | 2                                                   |
			| Sequesnce           | 1                                                   |
			| TransactionType     | ESCVP                                               |
			| TransactionDesc     | ESS CHANGE VEST HURDLE CODE                         |
			| Name                | NOAKSI GJARSON IPAUT,                               |
			| Address1            | TEST AUTOMATION                                     |
			| Address2            | 36 KIJRI AVENUE                                     |
			| Postcode            | 2213                                                |
			| HIN                 | I0030033582                                         |
			| EmployeeID          | 0000094531                                          |
			| PayrollID           | ANZO                                                |
			| EmployeeStatus      | L                                                   |
			| EmpStatusDesc       | RESIGNATION                                         |
			| LeaverCode          | LLL                                                 |
			| LeavercodeDesc      | L DEFAULT                                           |
			| Plan                | DCP                                                 |
			| PlanDesc            | DEFERRED COMPENSATION PLAN                          |
			| Reg                 | 09A                                                 |
			| RegDesc             | 2009 DCP GHO - TRANCHE 1                            |
			| Cert                | 20100305EE                                          |
			| VertingDetailsLine1 | Before/       V01  035                   04/09/2013 |
			| VertingDetailsLine2 | After/             060                   04/09/2018 |

@winformsTest
@EnquiryTest
@QBE_AUTO
@EN_E_ESS_EmployeeOptions
@17843
Scenario: Test Case 17843: 07_ Events ESEH with AESS Plan - ENSESS42 Form
	#Action -ESEH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "QBE_AUTO"
		And I go to the Enquiry system for "I5500000661"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ESEH  |
			| Locate Argument | /DEA  |
	Then In ENSESS40 I should see Event History Details as below:
			| Field    | Value                                                                                                                           |
			| HIN      | I5500000661                                                                                                                     |
			| Plan     | DEA                                                                                                                             |
			| PlanDesc | DEFERRED EQUITY PLAN                                                                                                            |
			| Line1    | V/DE1  11A  EX   06/03/2015  23/09/2014  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line2    | V/DE1  11A  EX   06/03/2015  31/03/2014  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line3    | V/DE1  11A  EX   06/03/2015  23/09/2013  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line4    | V/DE1  11A  EX   06/03/2015  28/03/2013  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line5    | V/DE1  11A  EX   06/03/2015  24/09/2012  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line6    | V/DE1  11A  EX   06/03/2015  30/03/2012  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line7    | V/DE1  11A  EE   06/03/2015  07/03/2012  Current   Received    Completed       T      Exer-Sell All       Wire Payment      GBP |
			| Line8    |                                                                                                                                 |
			| Line9    |                                                                                                                                 |
			| Line10   |                                                                                                                                 |  
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENSESS42 I should see Account details as below:
			| Field        | Value                  |
			| AccountNbr1 | GB02BARC20414150205788 |
			| AccountNbr2 | GB02BARC20414150205788 |
			| AccountNbr3 | GB02BARC20414150205788 |
			| AccountNbr4 | GB02BARC20414150205788 |
			| AccountNbr5 | GB02BARC20414150205788 |
			| AccountNbr6 | GB02BARC20414150205788 |
			| AccountNbr7 | GB02BARC20414150205788 |
			| AccountName1 | S P BURNS              |
			| AccountName2 | S P BURNS              |
			| AccountName3 | S P BURNS              |
			| AccountName4 | S P BURNS              |
			| AccountName5 | S P BURNS              |
			| AccountName6 | S P BURNS              |
			| AccountName7 | S P BURNS              |
			| BankCode1    | BARCGB22               |
			| BankCode2    | BARCGB22               |
			| BankCode3    | BARCGB22               |
			| BankCode4    | BARCGB22               |
			| BankCode5    | BARCGB22               |
			| BankCode6    | BARCGB22               |
			| BankCode7    | BARCGB22               |