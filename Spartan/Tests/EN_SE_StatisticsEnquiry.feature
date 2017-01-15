Feature: EN_SE_StatisticsEnquiry
	Ensure EN_SE_StatisticsEnquiry functionality covered

@winformsTest
@EnquiryTest
@DIV_A
@EN_SE_StatisticsEnquiry
@18471
Scenario Outline: Test Case 18471: 01_Options on the Statistic Enquiries form
	# Enquiry System -Action ART/DPID/RS/SBD/SBR/T40
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to Statistics Enquiry System
		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
	Then In ENS04020 I should see Statistics Enquiry details as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>" "<Line14>" "<Line15>" "<Line16>" "<Line17>" "<Line18>" "<Line19>"

Examples: 
		| Action | Line1                                                       | Line2                                                                          | Line3                                                                         | Line4                                                                         | Line5                                                                            | Line6                                                                         | Line7                                                                       | Line8                                                                       | Line9                                                                  | Line10                                                                   | Line11                                                                     | Line12                                                    | Line13                                                  | Line14                                                                   | Line15                                                         | Line16                                                         | Line17                                                          | Line18                                                           | Line19                                                        |
		| ART    | Do not change ANYTHING - Thank you :)           (3400/3524) | ANNUAL REPORT/RETURN MAIL TOTALS                   AS AT 26/03/10              | PUBLICATIONS TYPES               --POST- -EMAIL- --NONE- SC NOT- -TOTAL-      | PROVIDED                                                                      | COMPANY REPORTING                                                                | A ANNUAL REPORT                    101       0      67    7668    7836        | B ANNUAL REPORT                    127       0       7   11067   11201      | N ANNUAL REPORT                      0       0    1073    8525    9598      | INVALID ANNUAL REPORT FLAGS          0       0       0       5       5 | TOTALS FOR PERIODIC REPORTING        228       0    1147   27265   28640 | NOT IN USE3                            0       0       0   28640   28640   | RETURN MAIL HOLDERS                  244                  | WARNING: Report based on the following classes:..., *G9 |                                                                          |                                                                |                                                                |                                                                 |                                                                  |                                                               |
		| DPID   | Do not change ANYTHING - Thank you :)           (3400/3524) | DPID TOTALS REPORT                                 AS AT 26/03/10              | DPID ELIGIBLE    HOLDERS WITH DPID  HOLDERS WITH NO DPID                      | CHESS                        20968                   93                 20875 | NON-CHESS                     5614                   29                  5585    | TOTAL-HOLDERS                26582                  122                 26460 | SUCCESS RATE:            0.45%                                              | DPID ELIGIBLE    HOLDERS WITH DPID  HOLDERS WITH NO DPID                    | WARNING: Report based on the following classes:..., *G9                |                                                                          |                                                                            |                                                           |                                                         |                                                                          |                                                                |                                                                |                                                                 |                                                                  |                                                               |
		| SBR    | Do not change ANYTHING - Thank you :)           (3400/3524) | SECURITY HOLDERS BY REGISTER ACC/TOP UP ACCEPTANCE CLASS        AS AT 26/03/10 | REGISTER                  HOLDERS                    UNITS                    | Issuer           NSW                             2                  40,000    | TOTAL                                            2                  40,000       |                                                                               |                                                                             |                                                                             |                                                                        |                                                                          |                                                                            |                                                           |                                                         |                                                                          |                                                                |                                                                |                                                                 |                                                                  |                                                               |
		| T40    | Do not change ANYTHING - Thank you :)           (3400/3524) | TOP   1 SECURITY HOLDERS *G9/ALL CLASSES                    AS AT 26/03/10     | NAME                             UNITS AS AT  VARIANCE UNITS AS AT % I/C RANK | 8/09/08              26/03/10                                                 | *JP MORGAN NOMINEES AUSTRALIA         138460232          0  138460232  10.77   1 | *** REPORT TOTAL ***                 138460232             138460232  10.77   | ***  DIFFERENCE  ***                1146832076            1147061580  89.23 | ***        TOTAL ***                1285292308            1285521812 100.00 |                                                                        |                                                                          |                                                                            |                                                           |                                                         |                                                                          |                                                                |                                                                |                                                                 |                                                                  |                                                               |
		| RS     | Do not change ANYTHING - Thank you :)           (3400/3524) | RANGE OF SHARES *G9/ALL CLASSES                    AS AT 26/03/10              | RANGE            HOLDERS               UNITS         % I/C                    | 1 - 1000             3,538          2,231,473          0.17                   | 1001 - 5000            12,826         36,126,231          2.81                   | 5001 - 10000            6,114         45,627,898          3.55                | 10001 - 100000           5,711        154,525,229         12.02             | 100001 - OVER               451      1,047,010,981         81.45            | --------------------                                                   | ROUNDING DISCREPANCY                                             0.00    | TOTAL                         28,640      1,285,521,812        100.00      | LESS THAN M/P OF       1           0                  0   |                                                         | Cert         1 - 1000                 2                700          0.00 | 1001 - 5000                 0                  0          0.00 | 5001 - 10000                0                  0          0.00 | 10001 - 100000               0                  0          0.00 | 100001 - OVER                 0                  0          0.00 |                                                               |
		| SBD    | Do not change ANYTHING - Thank you :)           (3400/3524) | SECURITY HOLDERS BY DOMICILE ACC/TOP UP ACCEPTANCE CLASS        AS AT 26/03/10 | DOMICILE                  HOLDERS                    UNITS                    | VIC                             1                  20,000                     | ARG ARGENTINA                   1                  20,000                        | ---------------------------                                                   | LOCAL HOLDERS THIS CLASS            1                  20,000               | OVERSEAS HOLDERS THIS CLASS         1                  20,000               | CLASS TOTAL                         2                  40,000          |                                                                          | Issuer           VIC                             1                  20,000 | ARG ARGENTINA                   1                  20,000 |                                                         | LOCAL HOLDERS SUB TOTAL             1                  20,000            | OVERSEAS HOLDERS SUB TOTAL          1                  20,000  | ---------------------------                                    | LOCAL HOLDERS THIS CLASS            1                  20,000   | OVERSEAS HOLDERS THIS CLASS         1                  20,000    | CLASS TOTAL                         2                  40,000 |  

@winformsTest
@EnquiryTest
@DIV_A
@EN_SE_StatisticsEnquiry
@18478
Scenario Outline: Test Case 18478: 02_Statistic Enquiries - Search by a Class Code
	# Enquiry System -Action CRT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to Statistics Enquiry System
		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
	Then In ENS04020 I should see Class Statistics Enquiry details as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>"
	When In ENS04020 enter search string as "<Selection>" "<SearchString>"
	Then In ENS04020 I should see Class Statistics Enquiry details as "<Line1pg2>" "<Line2pg2>" "<Line3pg2>" "<Line4pg2>" "<Line5pg2>" "<Line6pg2>" "<Line7pg2>"
	When In ENS04020 enter search string as "<Selection1>" "<SearchString1>"
	Then In ENS04020 I should see Class Statistics Enquiry details as "<Line1pg3>" "<Line2pg3>" "<Line3pg3>" "<Line4pg3>" "<Line5pg3>" "<Line6pg3>" "<Line7pg3>"

Examples: 
		| Action | Line1                                                       | Line2                                                                   | Line3            | Line4                                  | Line5                                                  | Line6                                                  | Line7                                 | Selection | SearchString | Line1pg2                                                    | Line2pg2                                                                | Line3pg2         | Line4pg2                               | Line5pg2                                               | Line6pg2                                               | Line7pg2                              | Selection1 | SearchString1 | Line1pg3                                                    | Line2pg3                                                                | Line3pg3         | Line4pg3                               | Line5pg3                                               | Line6pg3                                               | Line7pg3                              |
		| CRT    | Do not change ANYTHING - Thank you :)           (3400/3524) | CLASS REGISTER TOTALS ACC/TOP UP ACCEPTANCE CLASS        AS AT 26/03/10 | NIL      CURRENT | REG  HOLDERS  HOLDERS  ---- UNITS ---- | Issuer        NSW         0         2           40,000 | TOTAL                     0         2           40,000 | CLASS HOLDER RECORDS                2 | F         |              | Do not change ANYTHING - Thank you :)           (3400/3524) | CLASS REGISTER TOTALS DA1/FULLY PAID ORDINARY SHARES     AS AT 26/03/10 | NIL      CURRENT | REG  HOLDERS  HOLDERS  ---- UNITS ---- | Issuer        NSW         0         2           20,000 | TOTAL                     0         2           20,000 | CLASS HOLDER RECORDS                2 | S          | ESC           | Do not change ANYTHING - Thank you :)           (3400/3524) | CLASS REGISTER TOTALS ESC/ESCROW CLASS EXP TBA BY CLIENT AS AT 26/03/10 | NIL      CURRENT | REG  HOLDERS  HOLDERS  ---- UNITS ---- | Issuer        NSW         1         1          203,730 | TOTAL                     1         1          203,730 | CLASS HOLDER RECORDS                2 |

@winformsTest
@EnquiryTest
@DIV_A
@EN_SE_StatisticsEnquiry
@18482
Scenario Outline: Test Case 18482: 03_IC Issued Capital Enquiry
	# Enquiry System -Action IC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to Statistics Enquiry System
		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
	Then In ENS04030 I should see Class codes as "<Class1>" "<Class2>" "<Class3>" "<Class4>" "<Class5>" "<Class6>" "<Class7>" "<Class8>" "<Class9>" "<Class10>" "<Class11>" "<Class12>" "<Class13>" "<Class14>" "<Class15>" "<Class16>" "<Class17>" "<Class18>" 
	Then In ENS04030 I should see Class Description codes as "<ClassDesc1>" "<ClassDesc2>" "<ClassDesc3>" "<ClassDesc4>" "<ClassDesc5>" "<ClassDesc6>" "<ClassDesc7>" "<ClassDesc8>" "<ClassDesc9>" "<ClassDesc10>" "<ClassDesc11>" "<ClassDesc12>" "<ClassDesc13>" "<ClassDesc14>" "<ClassDesc15>" "<ClassDesc16>" "<ClassDesc17>" "<ClassDesc18>" 
	Then In ENS04030 I should see EOM as "<EOM1>" "<EOM2>" "<EOM3>" "<EOM4>" "<EOM5>" "<EOM6>" "<EOM7>" "<EOM8>" "<EOM9>" "<EOM10>" "<EOM11>" "<EOM12>" "<EOM13>" "<EOM14>" "<EOM15>" "<EOM16>" "<EOM17>" "<EOM18>"
	Then In ENS04030 I should see Last Run as "<LastRun1>" "<LastRun2>" "<LastRun3>" "<LastRun4>" "<LastRun5>" "<LastRun6>" "<LastRun7>" "<LastRun8>" "<LastRun9>" "<LastRun10>" "<LastRun11>" "<LastRun12>" "<LastRun13>" "<LastRun14>" "<LastRun15>" "<LastRun16>" "<LastRun17>" "<LastRun18>"
	Then In ENS04030 I should see Current run as "<Current1>" "<Current2>" "<Current3>" "<Current4>" "<Current5>" "<Current6>" "<Current7>" "<Current8>" "<Current9>" "<Current10>" "<Current11>" "<Current12>" "<Current13>" "<Current14>" "<Current15>" "<Current16>" "<Current17>" "<Current18>"

Examples: 
		| Action | Class1 | Class2 | Class3 | Class4 | Class5 | Class6 | Class7 | Class8 | Class9 | Class10 | Class11 | Class12 | Class13 | Class14 | Class15 | Class16 | Class17 | Class18 | ClassDesc1 | ClassDesc2 | ClassDesc3 | ClassDesc4 | ClassDesc5 | ClassDesc6 | ClassDesc7 | ClassDesc8 | ClassDesc9 | ClassDesc10 | ClassDesc11 | ClassDesc12 | ClassDesc13 | ClassDesc14 | ClassDesc15 | ClassDesc16 | ClassDesc17 | ClassDesc18 | EOM1  | EOM2  | EOM3   | EOM4 | EOM5      | EOM6      | EOM7       | EOM8  | EOM9 | EOM10 | EOM11 | EOM12 | EOM13 | EOM14 | EOM15 | EOM16 | EOM17 | EOM18 | LastRun1 | LastRun2 | LastRun3 | LastRun4 | LastRun5  | LastRun6  | LastRun7   | LastRun8 | LastRun9 | LastRun10 | LastRun11 | LastRun12 | LastRun13 | LastRun14 | LastRun15 | LastRun16 | LastRun17 | LastRun18 | Current1 | Current2 | Current3 | Current4 | Current5  | Current6  | Current7   | Current8 | Current9 | Current10 | Current11 | Current12 | Current13 | Current14 | Current15 | Current16 | Current17 | Current18 |
		| IC     | ACC    | DA1    | ESC    | FP     |        |        |        |        |        |         | LON     |MAL      | OR1     | OR2     |OR3      |         |         |         | Issuer     | Issuer     | Issuer     | Cert       | Issuer     | Chess      | FP  Totals | Issuer     | Chess      | INT Totals  | Issuer      | Issuer      | Issuer      | Issuer      | Issuer      | Chess       | OR3 Totals  | Issuer      | 40000 | 20000 | 203730 | 400  | 268750920 | 914540698 | 1183292018 | 20000 | 80   | 20080 | 300   | 11    | 100   | 100   | 100   | 80    | 180   | 100   | 40000    | 20000    | 203730   | 400      | 268751080 | 914540698 | 1183292178 | 20000    | 80       | 20080     | 300       | 11        | 100       | 100       | 100       | 80        | 180       | 100       | 40000    | 20000    | 203730   | 400      | 268751080 | 914540698 | 1183292178 | 20000    | 80       | 20080     | 300       | 11        | 100       | 100       | 100       | 80        | 180       | 100       |

@winformsTest
@EnquiryTest
@DIV_A
@EN_SE_StatisticsEnquiry
@18482
Scenario Outline: Test Case 18482: 03_IC Issued Capital Enquiry -Forward
	# Enquiry System -Action IC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to Statistics Enquiry System
		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
	When In ENS04030 enter search string as "<Selection>" "<SearchString>"
	Then In ENS04030 I should see Class codes as "<Class1>" "<Class2>" "<Class3>" "<Class4>" "<Class5>" "<Class6>" "<Class7>" "<Class8>" "<Class9>" "<Class10>" "<Class11>" "<Class12>" "<Class13>" "<Class14>" "<Class15>" "<Class16>" "<Class17>" "<Class18>" 
	Then In ENS04030 I should see Class Description codes as "<ClassDesc1>" "<ClassDesc2>" "<ClassDesc3>" "<ClassDesc4>" "<ClassDesc5>" "<ClassDesc6>" "<ClassDesc7>" "<ClassDesc8>" "<ClassDesc9>" "<ClassDesc10>" "<ClassDesc11>" "<ClassDesc12>" "<ClassDesc13>" "<ClassDesc14>" "<ClassDesc15>" "<ClassDesc16>" "<ClassDesc17>" "<ClassDesc18>" 
	Then In ENS04030 I should see EOM as "<EOM1>" "<EOM2>" "<EOM3>" "<EOM4>" "<EOM5>" "<EOM6>" "<EOM7>" "<EOM8>" "<EOM9>" "<EOM10>" "<EOM11>" "<EOM12>" "<EOM13>" "<EOM14>" "<EOM15>" "<EOM16>" "<EOM17>" "<EOM18>"
	Then In ENS04030 I should see Last Run as "<LastRun1>" "<LastRun2>" "<LastRun3>" "<LastRun4>" "<LastRun5>" "<LastRun6>" "<LastRun7>" "<LastRun8>" "<LastRun9>" "<LastRun10>" "<LastRun11>" "<LastRun12>" "<LastRun13>" "<LastRun14>" "<LastRun15>" "<LastRun16>" "<LastRun17>" "<LastRun18>"
	Then In ENS04030 I should see Current run as "<Current1>" "<Current2>" "<Current3>" "<Current4>" "<Current5>" "<Current6>" "<Current7>" "<Current8>" "<Current9>" "<Current10>" "<Current11>" "<Current12>" "<Current13>" "<Current14>" "<Current15>" "<Current16>" "<Current17>" "<Current18>"

Examples: 
		| Action | Class1 | Class2 | Class3 | Class4 | Class5 | Class6 | Class7 | Class8 | Class9 | Class10 | Class11 | Class12 | Class13 | Class14 | Class15 | Class16 | Class17 | Class18 | ClassDesc1 | ClassDesc2 | ClassDesc3 | ClassDesc4 | ClassDesc5 | ClassDesc6 | ClassDesc7 | ClassDesc8 | ClassDesc9 | ClassDesc10 | ClassDesc11 | ClassDesc12 | ClassDesc13 | ClassDesc14 | ClassDesc15 | ClassDesc16 | ClassDesc17 | ClassDesc18 | EOM1 | EOM2 | EOM3 | EOM4 | EOM5 | EOM6 | EOM7 | EOM8 | EOM9 | EOM10 | EOM11 | EOM12 | EOM13    | EOM14 | EOM15    | EOM16    | EOM17    | EOM18    | LastRun1 | LastRun2 | LastRun3 | LastRun4 | LastRun5 | LastRun6 | LastRun7 | LastRun8 | LastRun9 | LastRun10 | LastRun11 | LastRun12 | LastRun13 | LastRun14 | LastRun15 | LastRun16 | LastRun17 | LastRun18 | Current1 | Current2 | Current3 | Current4 | Current5 | Current6 | Current7 | Current8 | Current9 | Current10 | Current11 | Current12 | Current13 | Current14 | Current15 | Current16 | Current17 | Current18 | Selection | SearchString |
		| IC     |        |        | OR5    |        |        | OR6    |        |        | OR7    |         |         |  ORD    |         |         |         |         | SPE     |         | Chess      | OR4 Totals | Issuer     | Chess      | OR5 Totals | Issuer     | Chess      | OR6 Totals | Issuer     | Chess       | OR7 Totals  | Cert        | Issuer      | NZL-N       | Chess       | ORD Totals  | Issuer      | Chess       | 80   | 180  | 100  | 80   | 180  | 100  | 80   | 180  | 200  | 80    | 280   | 300   | 45811707 | 300   | 11075116 | 56887423 | 33752523 | 11304527 | 80       | 180      | 100      | 80       | 180      | 100      | 80       | 180      | 200      | 80        | 280       | 2300      | 51292102  | 300       | 15049414  | 66344116  | 33752523  | 11304527  | 80       | 180      | 100      | 80       | 180      | 100      | 80       | 180      | 200      | 80        | 280       | 2300      | 51292102  | 300       | 15049414  | 66344116  | 33752523  | 11304527  | F         |              |

@winformsTest
@EnquiryTest
@DIV_A
@EN_SE_StatisticsEnquiry
@18482
Scenario Outline: Test Case 18482: 03_IC Issued Capital Enquiry -Search
	# Enquiry System -Action IC
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to Statistics Enquiry System
		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
	When In ENS04030 enter search string as "<Selection>" "<SearchString>"
	Then In ENS04030 I should see Class codes as "<Class1>" "<Class2>" "<Class3>" "<Class4>" "<Class5>" "<Class6>" "<Class7>" "<Class8>" "<Class9>" "<Class10>" "<Class11>" "<Class12>" "<Class13>" "<Class14>" "<Class15>" "<Class16>" "<Class17>" "<Class18>" 
	Then In ENS04030 I should see Class Description codes as "<ClassDesc1>" "<ClassDesc2>" "<ClassDesc3>" "<ClassDesc4>" "<ClassDesc5>" "<ClassDesc6>" "<ClassDesc7>" "<ClassDesc8>" "<ClassDesc9>" "<ClassDesc10>" "<ClassDesc11>" "<ClassDesc12>" "<ClassDesc13>" "<ClassDesc14>" "<ClassDesc15>" "<ClassDesc16>" "<ClassDesc17>" "<ClassDesc18>" 
	Then In ENS04030 I should see EOM as "<EOM1>" "<EOM2>" "<EOM3>" "<EOM4>" "<EOM5>" "<EOM6>" "<EOM7>" "<EOM8>" "<EOM9>" "<EOM10>" "<EOM11>" "<EOM12>" "<EOM13>" "<EOM14>" "<EOM15>" "<EOM16>" "<EOM17>" "<EOM18>"
	Then In ENS04030 I should see Last Run as "<LastRun1>" "<LastRun2>" "<LastRun3>" "<LastRun4>" "<LastRun5>" "<LastRun6>" "<LastRun7>" "<LastRun8>" "<LastRun9>" "<LastRun10>" "<LastRun11>" "<LastRun12>" "<LastRun13>" "<LastRun14>" "<LastRun15>" "<LastRun16>" "<LastRun17>" "<LastRun18>"
	Then In ENS04030 I should see Current run as "<Current1>" "<Current2>" "<Current3>" "<Current4>" "<Current5>" "<Current6>" "<Current7>" "<Current8>" "<Current9>" "<Current10>" "<Current11>" "<Current12>" "<Current13>" "<Current14>" "<Current15>" "<Current16>" "<Current17>" "<Current18>"

Examples: 
		| Action | Class1 | Class2 | Class3 | Class4 | Class5 | Class6 | Class7 | Class8 | Class9 | Class10 | Class11 | Class12 | Class13 | Class14 | Class15 | Class16 | Class17 | Class18 | ClassDesc1 | ClassDesc2 | ClassDesc3 | ClassDesc4 | ClassDesc5 | ClassDesc6 | ClassDesc7 | ClassDesc8 | ClassDesc9 | ClassDesc10 | ClassDesc11 | ClassDesc12 | ClassDesc13 | ClassDesc14 | ClassDesc15 | ClassDesc16 | ClassDesc17 | ClassDesc18 | EOM1 | EOM2 | EOM3 | EOM4     | EOM5     | EOM6     | EOM7     | EOM8     | EOM9     | EOM10 | EOM11 | EOM12 | EOM13 | EOM14 | EOM15 | EOM16 | EOM17 | EOM18 | LastRun1 | LastRun2 | LastRun3 | LastRun4 | LastRun5 | LastRun6 | LastRun7 | LastRun8 | LastRun9 | LastRun10 | LastRun11 | LastRun12 | LastRun13 | LastRun14 | LastRun15 | LastRun16 | LastRun17 | LastRun18 | Current1 | Current2 | Current3 | Current4 | Current5 | Current6 | Current7 | Current8 | Current9 | Current10 | Current11 | Current12 | Current13 | Current14 | Current15 | Current16 | Current17 | Current18 | Selection | SearchString |
		| IC     | ORZ    |        |        | OWC    |        |        | OWD    |        |        | SUE     |         |         |         |         |         |         |         |         | Issuer     | Chess      | ORZ Totals | Issuer     | Chess      | OWC Totals | Issuer     | Chess      | OWD Totals | Cert        | Issuer      | SUE Totals  |             |             |             |             |             |             | 4927 |      | 4927 | 32856908 | 10980556 | 43837464 | 32807101 | 11036283 | 43843384 | 40    | 510   | 550   |       |       |       |       |       |       | 4927     | 1000     | 5927     | 32856908 | 10980556 | 43837464 | 32807101 | 11036283 | 43843384 | 40        | 510       | 550       |           |           |           |           |           |           | 4927     | 1000     | 5927     | 32856908 | 10980556 | 43837464 | 32807101 | 11036283 | 43843384 | 40        | 510       | 550       |           |           |           |           |           |           | S         | ORZ          |

#@DIV_A
#@EN_SE_StatisticsEnquiry
#@18483
#Scenario Outline: Test Case 18483: 04_TS Transaction Summary Enquiry
#	# Enquiry System -Action TS
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And I go to Statistics Enquiry System
#		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
#	When In ENS04040 enter Transaction Summary Parameters as "<FromRun>" "<ToRun>" "<Class>"
#	Then In ENS04050 I should see Transaction Summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>" "<Line14>" "<Line15>" "<Line16>" "<Line17>" "<Line18>" "<Line19>"
#	When In ENS04050 enter search string as "<Selection>" "<SearchString>"
#	Then In ENS04050 I should see Transaction Summary as "<Line1pg2>" "<Line2pg2>" "<Line3pg2>" "<Line4pg2>" "<Line5pg2>" "<Line6pg2>" "<Line7pg2>" "<Line8pg2>" "<Line9pg2>" "<Line10pg2>" "<Line11pg2>" "<Line12pg2>" "<Line13pg2>" "<Line14pg2>" "<Line15pg2>" "<Line16pg2>" "<Line17pg2>" "<Line18pg2>" "<Line19pg2>"
#	When In ENS04050 enter search string as "<Selection1>" "<SearchString1>"
#	Then In ENS04050 I should see Transaction Summary as "<Line1pg3>" "<Line2pg3>" "<Line3pg3>" "<Line4pg3>" "<Line5pg3>" "<Line6pg3>" "<Line7pg3>" "<Line8pg3>" "<Line9pg3>" "<Line10pg3>" "<Line11pg3>" "<Line12pg3>" "<Line13pg3>" "<Line14pg3>" "<Line15pg3>" "<Line16pg3>" "<Line17pg3>" "<Line18pg3>" "<Line19pg3>"
#	When In ENS04050 enter search string as "<Selection2>" "<SearchString2>"
#	Then In ENS04050 I should see Transaction Summary as "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>" "<Line14>" "<Line15>" "<Line16>" "<Line17>" "<Line18>" "<Line19>"
#
#Examples: 
#		| Action | FromRun | ToRun | Class | Line1                                                    | Line2                      | Line3                                                     | Line4                                                     | Line5                                                             | Line6                | Line7                                                             | Line8                                                             | Line9                                                             | Line10                                                            | Line11                                                            | Line12                                                            | Line13                                                            | Line14                                                            | Line15                                                            | Line16                                                            | Line17                                                            | Line18                                                            | Line19                                                                  | Selection | SearchString | Line1pg2                                                          | Line2pg2                                                          | Line3pg2                                                          | Line4pg2                                                          | Line5pg2                                                          | Line6pg2                                                          | Line7pg2                                                          | Line8pg2                                                          | Line9pg2                                                          | Line10pg2                                                         | Line11pg2                                                         | Line12pg2                                                         | Line13pg2                                                         | Line14pg2                                                         | Line15pg2                                                         | Line16pg2                                                         | Line17pg2                                                         | Line18pg2                                                         | Line19pg2                                       | Selection1 | SearchString1 | Line1pg3                           | Line2pg3                                                             | Line3pg3                                           | Line4pg3                                                             | Line5pg3                                           | Line6pg3                                                             | Line7pg3                                           | Line8pg3                                           | Line9pg3                                           | Line10pg3                                          | Line11pg3                            | Line12pg3 | Line13pg3 | Line14pg3 | Line15pg3 | Line16pg3 | Line17pg3 | Line18pg3 | Line19pg3 | Selection2 | SearchString2 | 
#		| TS     | 3182    | 3192  |       | Do not change ANYTHING - Thank you :)        (3182/3192) | TRANSACTION SUMMARY REPORT |                                                           | -----------------------RUN DETAILS----------------------- | Run 3182 to 3192 Grand Totals                                     |                      |                                                                   | ******* All Classes *******               -------PROCESSED------- | NO             UNITS                                              |                                                                   | STANDARD TRANSFER FORM            #FTRF       2                 0 | GENERAL CORRESPONDENCE            #W007       3                 0 | ADDRESS REJECTION                 #W009       1                 0 | TELEPHONE ENQUIRY                 #W019       1                 0 | REINVESTMENT PLAN INSTRUCT        #W108       1                 0 | ACCOUNT MERGE                     #W116       2                 0 | DIVIDEND CORRESPONDENCE           #W159       1                 0 | MATERIAL REQUEST                  #W212       1                 0 |BUY BACK CANCELLATION             *BUYB       1           110,666        | F         |              | ISSUER SP TO CHESS TRANSFER       CTFIX       3               758 | CHESS TO ISSUER SP TRANSFER       CTFXI       3            43,480 | NAME & ADDRESS (ADD)              CXADD       3                 0 | NAME & ADDRESS (MODIFY)           CXAUD       5                 0 | DESTROYED CHEQUE                  DESCQ       1             7,000 | ISSUER ADJUSTMENT INCREASE        IAJUP       1           101,000 | MERGE HOLDER                      MERGE       1                 0 | NAME & ADDRESS (ADD)              NAADD       1                 0 | NAME & ADDRESS (CHANGE)           NACHG       2                 0 | NAME & ADDRESS (CORRECTION)       NACOR       1                 0 | CHESS NAME & ADDRESS IGNORE       NAIGN       1                 0 | PAYEE INSTRUCTION (ADD)           PIADD       4                 0 | PAYEE INSTRUCTION (CHANGE)        PICHG       2                 0 | PAYEE INSTRUCTION (DELETE)        PIDEL       3                 0 | PLAN INTENTION (HOLDER)           PLNIT       4                 0 | PAYMENT REPLACEMENT               REPLC       3                 0 | RETURNED CHEQUE                   RTNCQ       1             7,000 | TFN IGNORE FROM BROKER            TNIGN       4                 0 |                                                 | F          |               | -------TRANSACTION GROUPING------- | 1.  TRANSFERS                                    6            44,238 | 2.  PLACEMENTS                                   0 | 3.  OTHER TRANSACTIONS                          80           302,598 | 4.  NO CHANGE IN BENEFICIAL OWNERSHIP            0 | 5.  ADJUSTMENTS                                  2           211,666 | 6.  RE-ISSUES                                    0 | 7.  MARKINGS                                     0 | 8.  MISC                                         0 | 9.  ALLOTMENTS/ENTITLEMENTS                      0 | <<** END OF TRANSACTION SUMMARY **>> |           |           |           |           |           |           |           |           | S          | INT           | 

@winformsTest
@EnquiryTest
@DIV_A
@EN_SE_StatisticsEnquiry
@18659
Scenario Outline: Test Case 18659: 05_ Options
	# Enquiry System -Action T200/G200
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to Statistics Enquiry System
		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
	When In ENS04060 enter Class Code as "<Class>"
	Then In ENS04070 I should see Top200 Balance as "<Name1>" "<Name2>" "<Name3>" "<HIN1>" "<HIN2>" "<HIN3>" "<Units1>" "<Units2>" "<Units3>" "<IC1>" "<IC2>" "<IC3>" "<Rank1>" "<Rank2>" "<Rank3>"
	When I PressESC
	Then I expect to be in the "ENS04060" Screen
	When In ENS04060 enter Class Code as "<Class1>"
	Then In ENS04070 I should see Top200 Balance as "<Name1pg1>" "<Name2pg1>" "<Name3pg1>" "<HIN1pg1>" "<HIN2pg1>" "<HIN3pg1>" "<Units1pg1>" "<Units2pg1>" "<Units3pg1>" "<IC1pg1>" "<IC2pg1>" "<IC3pg1>" "<Rank1pg1>" "<Rank2pg1>" "<Rank3pg1>"
	When I Transmit
	Then In ENS04070 I should see Top200 Balance as "<Name1>" "<Name2>" "<Name3>" "<HIN1>" "<HIN2>" "<HIN3>" "<Units1>" "<Units2>" "<Units3>" "<IC1>" "<IC2>" "<IC3>" "<Rank1>" "<Rank2>" "<Rank3>"

Examples: 
		| Action | Class | Name1                      | Name2 | Name3                    | HIN1        | HIN2 | HIN3 | Units1 | Units2 | Units3 | IC1    | IC2 | IC3    | Rank1 | Rank2 | Rank3 | Class1 | Name1pg1           | Name2pg1          | Name3pg1 | HIN1pg1     | HIN2pg1     | HIN3pg1 | Units1pg1 | Units2pg1 | Units3pg1 | IC1pg1 | IC2pg1 | IC3pg1 | Rank1pg1 | Rank2pg1 | Rank3pg1 |
		| T200   | ESC   | GWOG        HOLDINGSPTYLTD |       |** TOTALS FOR CLASS ESC** | I0030001061 |      |      | 203730 |        | 203730 | 100.00 |     |100.00  | 1     |       |       |        | ADAK        RZBOWJ | ADFOHUKLO   CDEUH |          | I0030190157 | I0030135300 |         | 10000     | 10000     |           | 50.00  | 50.00  |        | 1        | 2        |          |
		| G200   | ESC   | GWOG        HOLDINGSPTYLTD |       |** TOTALS FOR CLASS ESC** | I0030001061 |      |      | 203730 |        | 203730 | 100.00 |     | 100.00 | 1     |       |       |        | ADAK        RZBOWJ | ADFOHUKLO   CDEUH |          | I0030190157 | I0030135300 |         | 10000     | 10000     |           | 50.00  | 50.00  |        | 1        | 2        |          |


#@Ignore
#@DIV_A
#@EN_SE_StatisticsEnquiry
#@18683
#Scenario Outline: Test Case 18683: 06_Error messages
#	# Enquiry System -Action T200/G200
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "DIV_A"
#		And I go to Statistics Enquiry System
#		And In ENS04010 I Select Statistic Enquiry action as "<Action>"
#	Then I expect to see error with text "Invalid option.  Please select one on menu."
#	When In ENS04010 I Select Statistic Enquiry action as "<Action1>"
#	Then I expect to be in the "ENS04040" Screen
#	When In ENS04040 enter Transaction Summary Parameters as "<FromRun>" "<ToRun>" "<Class>"
#	Then I expect to see error with text "Invalid class code, try again"
#	When I PressESC
#	Then I expect to be in the "ENS04010" Screen
#	When In ENS04010 I Select Statistic Enquiry action as "<Action2>"
#	Then I expect to be in the "ENS04060" Screen
#	When In ENS04060 enter Class Code as "<Class1>"
#	Then I expect to see error with text "Invalid class code, try again"
#	When I PressESC
#	Then I expect to be in the "ENS04010" Screen
#	When In ENS04010 I Select Statistic Enquiry action as "<Action3>"
#	Then I expect to be in the "ENS04060" Screen
#	When In ENS04060 enter Class Code as "<Class2>"
#	Then I expect to see error with text "Invalid class code, try again"
#
#Examples: 
#		| Test  | Action | Action1 | FromRun | ToRun | Class | Action2 | Class1 | Action3 | Class2 |
#		| Test1 | BBB    | TS      |         |       | CCC   | T200    | XXX    | G200    | PPP    |
#

