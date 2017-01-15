Feature: EN_E_DisplayActions
	
@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewHolderDetails
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Holder Details
	# Enquiry System -Action A
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                         |
			| HIN                 | I0100007550                   |
			| Type                | EMP                           |
			| Post Code           | 3023                          |
			| TAX Code            | USA                           |
			| TFN Desc            | Non-Res                       |
			| ABN Desc            | Non-Res                       |
			| Group               |                               |
			| Var field           | 1000                          |
			| Broker Code         | 60109                         |
			| Register            |                               |
			| Key Modifier        | 20000                         |
			| DPID                |                               |
			| Alternate ID        | 1250                          |
			| Key                 | RIXYE       KIXP        20000 |
			| Name                | MR KIXP RIXYE                 |
			| Address1            | 1 GIXRABISM DRIVE             |
			| Address2            | 2 GIXRABISM DRIVE             |
			| Address3            | 3 GIXRABISM DRIVE             |
			| Address4            | 4 GIXRABISM DRIVE             |
			| Address5            | GIOYPMIO VIC                  |
			| Deceased            | N                             |
			| Exception           |                               |
			| Suppress            | N                             |
			| Ret Mail            |                               |
			| A/Report            | R                             |
			| AR Nominated Text   | (Default)                     |
			| Birth Date          | 01/01/1982                    |
			| Stop Trade          | N                             |
			| Div Source          | D                             |
			| Residency           | D                             |
			| Var Flag1           | E                             |
			| Var Flag2           | R                             |
			| Var Flag3           |                               |
			| Var Flag4           | O                             |
			| Var Flag5           | 02                            |
			| Warning1            | Non standard tax rates        |
			| Warning2            | Payee instruction direct/bulk |
			| Warning3            | Holder Extra details present  |
			| Warning4            | No DPID allocated             |
			| Warning5            | ESS Participant               |
			| Warning6            | Shareholder Review            |
			| Restrict Class info | * NOTICE 03/03/2014 *         |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewHolderExtraDetails
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Holder Extra Details
	# Enquiry System -Action HE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | HE    |
			| Locate Argument |       |
	Then In ENS01020 I should see holder extra details as below:
			| Field           | Value                              |
			| Name Key        | RIXYE       KIXP        20000      |
			| HIN             | I0100007550                        |
			| Holder Type     | EMP                                |
			| Extra Holder ID | 300300                             |
			| Name            | MR KIXP RIXYE                      |
			| Address1        | 1 GIXRABISM DRIVE                  |
			| Address2        | 2 GIXRABISM DRIVE                  |
			| Address3        | 3 GIXRABISM DRIVE                  |
			| Address4        | 4 GIXRABISM DRIVE                  |
			| Address5        | GIOYPMIO VIC                       |
			| Home Tell       | 124456789                          |
			| Work Tell       | 124456789                          |
			| Fax             | 124456789                          |
			| Mobile          | 124456789                          |
			| Email           | KIXP.WECDU._test@computershare.com |
			| Return Email    |                                    |
			| Email Count     | 1                                  |
			| ABN1            |                                    |
			| ABN2            |                                    |
			| Type1           |                                    |
			| Type2           |                                    |
			| Flag1           | S                                  |
			| Flag1 Desc      | SPECIAL CIRCUMSTANCES              |
			| Flag2           | F                                  |
			| Flag2 Desc      | TEST F                             |
			| Flag3           | G                                  |
			| Flag3 Desc      | TEST G                             |
			| Flag4           | H                                  |
			| Flag4 Desc      | TEST H                             |
			| Flag5           | E2                                 |
			| Flag5 Desc      | AML CPM Trust Participant          |
			| Flag6           | I                                  |
			| Flag6 Desc      | TEST I                             |
			| Flag7           | J                                  |
			| Flag7 Desc      | TEST J                             |
			| Flag8           | K                                  |
			| Flag8 Desc      | TEST K                             |
			| Flag9           | L                                  |
			| Flag9 Desc      | TEST L                             |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewCertificates
@EN_E_DisplayActions
Scenario: View Certificates
	# Enquiry System -Action C
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | C     |
			| Locate Argument |       |
	Then In ENS01012 I should see Certificate details as below:
			| Field       | Value                                                                                |
			| HIN         | I0100007550                                                                          |
			| Page1 Line1 | DEP/DEFERRED EMP SHARE PLAN - AU                                                     |
			| Page1 Line2 | 02A 20020603EM   03/06/02          1498    02A 20020603EM   04/07/13           1498- |
			| Page1 Line3 | **** Total for 20020603EM                  0                                         |
			| Page2 Line1 | DEP/DEFERRED EMP SHARE PLAN - AU   Cont'd                                            |
			| Page2 Line2 | 02A 20021104EP   04/11/02           181    02A 20021104EP   04/07/13            181- |
			| Page2 Line3 | **** Total for 20021104EP                  0                                         |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewLastTranDetails
@EN_E_DisplayActions
Scenario: View Last Tran Details
	# Enquiry System -Action E
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | E     |
			| Locate Argument |       |
	#Then In ENS01042 I should see the Last Tran details as below:
	#		| Field   | Value                                   |
	#		| Cert 1  | 02A 20020603EM   04/06/02             0 | 04/07/13 ESTTS 4218/  964437          1498- |
	#		| Cert 12 | 02A 20030404EP   04/04/03             0 | 04/07/13 ESTTS 4218/  964437           269- |
	# could not use the ReadTable method
	Then In ENS01042 I should see the Last Tran details as "02A 20020603EM   04/06/02             0 | 04/07/13 ESTTS 4218/  964437          1498-" and "02A 20030404EP   04/04/03             0 | 04/07/13 ESTTS 4218/  964437           269-"

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewDividendHistory
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Dividend History
	# Enquiry System -Action DH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DH    |
			| Locate Argument |       |
	Then In ENSDIV01 I should see Dividend History as below:
			| Field        | Value         |
			| HIN          | I0100007550   |
			| Selection    | 1             |
			| Pay Date     | 24/05/2016    |
			| Pay Method   | DIRECT CREDIT |
			| Code         | DIV2          |
			| Pay Account  | PN002         |
			| Pay Type     | PAYMENT       |
			| Gross Amount | 245.00        |
			| Nett Amount  | 245.00        |
		When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 3     |
			| Locate Argument |       |
		Then In ENSSPLBP I should see Extra Dividend History as below:
			| Field           | Value                         |
			| Name Key        | RIXYE       KIXP        20000 |
			| HIN             | I0100007550                   |
			| Holder Type     | EMP                           |
			| Class           | EXA                           |
			| Regisrter       | 13A                           |
			| Cert Nbr        |                               |
			| Units           | 4                             |
			| Bulk ID         | EXP0001668                    |
			| Bulk Tran       | 12552678                      |
			| Trade Date      | 12/02/2014                    |
			| Settlement Date | 17/02/2014                    |
			| Price           | 11.64000                      |
			| Cost of Shares  | 46.56                         |
			| Charges         |                               |
			| Total Cost      | 46.56                         |
			| Amount Received | 49.82                         |
			| Residue Paid    |                               |
			| Residue Kept    | 3.26                          |
			| Commission      |                               |
			| Stamp Duty      |                               |
			| Other Charges   |                               |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewRegisterCertificates
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Register of Certificates
	# Enquiry System -Action R
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | R     |
			| Locate Argument | /DEP  |
	Then In ENS01013 I should see Register details as below:
			| Field | Value                                                                    |
			| HIN   | I0100007550                                                              |
			| Line1 | DEP/DEFERRED EMP SHARE PLAN - AU                                         |
			| Line2 | 02A 20020603EM   03/06/02 ESAWB 1338/10457471           1498             |
			| Line3 | 04/07/13 ESTTS 4218/  964437           1498-                      SCANAL |
			| Line4 | *Certificate Balance             0                                       |
			| Line5 | 02A 20020604EP   04/06/02 ESAWP 1341/10456518            210             |
			| Line6 | 04/07/13 ESTTS 4218/  964437            210-                      SCANAL |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | R19   |
			| Locate Argument | /DEP  |
	Then In ENS01013 I should see Register details as below:
			| Field | Value                                                                                    |
			| HIN   | I0100007550                                                                              |
			| Line1 | DEP/DEFERRED EMP SHARE PLAN - AU   (Cont'd)                                              |
			| Line2 | 13A 20130712EP   12/07/13 ESAWP 4228/12403605             40                       SCRIP |
			| Line3 | 13A 20130812EP   12/08/13 ESAWP 4249/12418775             40                       SCRIP |
			| Line4 | 13A 20130912EP   12/09/13 ESAWP 4283/12494657             41                       SCRIP |
			| Line5 | 13A 20131014EP   14/10/13 ESAWP 4306/12507171             42                       SCRIP |
			| Line6 | 13A 20131112EP   12/11/13 ESAWP 4326/12519870             38                       SCRIP |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewRegisterForCertificates
@EN_E_DisplayActions
Scenario: View Register of Certificates-RR
	# Enquiry System -Action RR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value                     |
			| Action          | RR                        |
			| Locate Argument | I0100007550/1338/10457471 |
	Then In ENS01016 I should see Register details as below:
			| Field | Value                                                        |
			| HIN   | I0100007550                                                  |
			| Line1 | DEP/DEFERRED EMP SHARE PLAN - AU                             |
			| Line2 | 02A 20020603EM   03/06/02 ESAWB 1338/10457471           1498 |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewStaticDetailsHistory
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Static Details History
	# Enquiry System -Action SH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | SH    |
			| Locate Argument |       |
	Then In ENS01034 I should see Static History as below:
			| Field            | Value                         |
			| NameKey          | RIXYE       KIXP        20000 |
			| HIN              | I0100007550                   |
			| Holder Type      | EMP                           |
			| Name             | MR KIXP RIXYE                 |
			| Address1         | 1 GIXRABISM DRIVE             |
			| Address2         | 2 GIXRABISM DRIVE             |
			| Address3         | 3 GIXRABISM DRIVE             |
			| Address4         | 4 GIXRABISM DRIVE             |
			| Address5         | GIOYPMIO VIC                  |
			| Date First SH    | 11/02/2000                    |
			| Date First On    | 13/02/2001                    |
			| Run              | 1253                          |
			| Tran No          | 84631                         |
			| Date             | 15/01/2002                    |
			| Transaction Code | NAFLG                         |
			| Transaction Desc | NAME & ADDRESS (FLAG CHANGE)  |
			| Reference        |                               |
			| Source           |                               |

@winformsTest
@EnquiryTest
@CPU_AUTO
@ViewPayeeInstructions
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Payee Instructions
	# Enquiry System -Action PI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
	 And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PI    |
			| Locate Argument |       |
	Then In ENS01002 I should see the holder payee Instructions as below:
				| Field          | Value                         |
				| Name Key       | RIXYE       KIXP        20000 |
				| HIN            | I0100007550                   |
				| Holder Type    | EMP                           |
				| Bank System    | 10                            |
				| BSB Code       | 033-080                       |
				| Account Number | 567990                        |
				| Account Name   | KIXP RIXYE                    |
				| Bank Address1  | WESTPAC BANKING CORPORATION   |
				| Bank Address2  | ST ALBANS VIC 3021            |
				| Name           | MR KIXP RIXYE                 |
				| Address1       | 1 GIXRABISM DRIVE             |
				| Address2       | 2 GIXRABISM DRIVE             |
				| Address3       | 3 GIXRABISM DRIVE             |
				| Address4       | 4 GIXRABISM DRIVE             |
				| Address5       | GIOYPMIO VIC                  |

@winformsTest
@EnquiryTest
@CPU_AUTO
@17325
@EN_E_DisplayActions
Scenario: Test Case 17325: 03_WR:Wire Instruction action
	# Enquiry System -Action WR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007525"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | WR    |
			| Locate Argument |       |
	Then In ENS01075 I should see Wire Instructions as below:
		| Field          | Value                  |
		| Name Key       | CABCOEYH    YDIKUB     |
		| HIN            | I0100007525            |
		| Holder Type    | EMP                    |
		| Country Code   | GB                     |
		| Country        | UNITED KINGDOM         |
		| Bank System    | 75                     |
		| Routing Code   | 01-00-53               |
		| Swift Code     | RBOSGB12345            |
		| Account Number | GB96MIDL40271522859882 |
		| Account Name   | AUTOMATION HOLDER      |
		| Currency Code  | GBP                    |
		| Currency       | BRITISH POUND          |
		| Name           | YDIKUB CABCOEYH,       |
		| Address1       | 3 UWBCUJAEM COURT      |
		| Address2       | RABC KIMV VIC          |
		| Postcode       | 3082                   |

@winformsTest
@EnquiryTest
@CPU_AUTO
@17133
@EN_E_DisplayActions
@FullSmokeTest
Scenario: Test Case 17133: 02_PD Action for Payment Details
	# Enquiry System -Action PD 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PD    |
			| Locate Argument |       |	
	Then In ENS01009 I should see Payment Details as below:
		| Field    | Value                                                                            |
		| Name Key | RIXYE       KIXP        20000                                                    |
		| HIN      | I0100007550                                                                      |
		| Name     | MR KIXP RIXYE                                                                    |
		| Address  | 1 GIXRABISM DRIVE                                                                |
		| PD Line1 | PN002/TEST PAYMENT ACCOUNT FOR DIVIDEND2       R:00000256D        245.00:Net     |
		| PD Line2 | 245.00:Frk           0.00:Unf          0.00:TCr 24/05/16 Client Rec              |
		| PD Line3 | PN001/PAYMENT ACCOUNT FOR DIVIDEND1            R:00000256D         49.00:Net     |
		| PD Line4 | 49.00:Frk           0.00:Unf          0.00:TCr 24/05/16 Presented                |
		| PD Line5 | EFA13/EMP FINDIV 14CPS 20%FRK RD26/8 PD17/9/13 R:00801493D       1250.34:Net     |
		| PD Line6 | 250.07:Frk        1000.27:Unf        107.17*TCr 17/09/13 Presented               |
		| PD Line7 | 13EDA/EMP INTDIV 14CPS 20%FRK RD25/2 PD19/3/13 R:00801554D       2408.56:Net     |
		| PD Line8 | 481.71:Frk        1926.85:Unf        206.45*TCr 19/03/13 Presented               |
		| PD Line9 | TOTAL        3952.90:Presented          0.00:Unpresented          0.00:Cancelled |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	Then In ENS01009 I should see Payment Details as below:
		| Field    | Value                                                                            |
		| Name Key | RIXYE       KIXP        20000                                                    |
		| HIN      | I0100007550                                                                      |
		| Name     | MR KIXP RIXYE                                                                    |
		| Address  | 1 GIXRABISM DRIVE                                                                |
		| PD Line1 | 12EDA/DEP/EXA FIN14CPS 60%FRK RD20/8 PD11/9/12 R:00801603D       2365.72:Net     |
		| PD Line2 | 1419.43:Frk         946.29:Unf        608.33*TCr 11/09/12 Presented              |
		| PD Line3 | EDA12/DEP/EXA INT14CPS 60%FRK RD2/3 PD23/3/12  R:00801539D       2261.14:Net     |
		| PD Line4 | 1356.68:Frk         904.46:Unf        581.43*TCr 23/03/12 Presented              |
		| PD Line5 | 11EDA/DEP/EXA FIN14CPS 60%FRK RD22/8 PD13/9/11 R:00801473D       2211.86:Net     |
		| PD Line6 | 1327.11:Frk         884.75:Unf        568.76*TCr 13/09/11 Presented              |
		| PD Line7 | EDA11/DEP/EXA INT14CPS 60%FRK RD21/2 PD15/3/11 R:00801398D       2122.96:Net     |
		| PD Line8 | 1273.78:Frk         849.18:Unf        545.91*TCr 15/03/11 Presented              |
		| PD Line9 | TOTAL       12914.58:Presented          0.00:Unpresented          0.00:Cancelled |				

@winformsTest
@EnquiryTest
@CPU_AUTO
@17134
@EN_E_DisplayActions
@FullSmokeTest
Scenario: Test Case 17134: 03_MJ Action for Manual Journal
	# Enquiry System -Action MJ
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007550"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | MJ    |
			| Locate Argument | FIN07 |
	Then In ENS01011 I should see Manual Journal as below:
			| Field                | Value                                                                                                           |
			| Name Key             | RIXYE       KIXP        20000                                                                                   |
			| HIN                  | I0100007550                                                                                                     |
			| Name                 | MR KIXP RIXYE                                                                                                   |
			| Address              | 1 GIXRABISM DRIVE                                                                                               |
			| Pay Account Number   | FIN07                                                                                                           |
			| Pay Account Desc     | EMP DIV DEP/EXA 9CUNF RD06/09 PD21/09/07                                                                        |
			| Transaction Details1 | 00801252D           2641/00658938 25/09/07  DCRFM/DIRECT CREDIT FAILURE (MANUAL)  S Nerpanda-----------(WINFRM) |
			| Transaction Details2 | 00801252D           2645/00623902 05/10/07  REDCR/REPLACE PAYMENT WITH DCREDIT    T Ackerly------------(WINFRM) |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | .     |
			| Locate Argument |       |
	Then In ENS01017 I should see payment details as below:
			| Field          | Value      |
			| BSB            | 033-080    |
			| Account Number | 567990     |
			| Account Name   | GIBK KIBCE |			

@winformsTest
@EnquiryTest		
@CPU_AUTO
@ViewNotingOptions
@EN_E_DisplayActions
@FullSmokeTest
Scenario: View Noting Options
	# Enquiry System -Action N
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to the Enquiry system for "I0100007525"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | N1    |
			| Locate Argument |       |	
	Then In ENS01021 I should see Notings as below:
		| Field        | Value              |
		| Noting Nuber | 1                  |
		| Run          | 4398               |
		| Tran         | 9080               |
		| Name Key     | CABCOEYH    YDIKUB |
		| HIN          | I0100007525        |
		| Holder Type  | EMP                |
		| Comment      | TEST NOTING1       |
		| Noting Line1 | NOTING1 LINE1      |
		| Noting Line2 | NOTING1 LINE2      |
		| Noting Line3 | NOTING1 LINE3      |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | N2    |
			| Locate Argument |       |
	Then In ENS01021 I should see Notings as below:
		| Field        | Value              |
		| Noting Nuber | 2                  |
		| Run          | 4398               |
		| Tran         | 9081               |
		| Name Key     | CABCOEYH    YDIKUB |
		| HIN          | I0100007525        |
		| Holder Type  | EMP                |
		| Comment      | TEST NOTING2       |
		| Noting Line1 | NOTING2 LINE1      |
		| Noting Line2 | NOTING2 LINE2      |
		| Noting Line3 | NOTING2 LINE3      |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16775GBR
@EN_E_DisplayActions
Scenario: Test Case 16775: GBR A action for Overseas and Local domiciles-GBR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0003784642"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                          |
			| HIN                 | C0003784642                    |
			| Type                | MAL                            |
			| Post Code           | GBR                            |
			| TAX Code            |                                |
			| TFN Desc            | Non-Res                        |
			| ABN Desc            | Non-Res                        |
			| Group               |                                |
			| Var field           |                                |
			| Broker Code         |                                |
			| Register            |                                |
			| Key Modifier        |                                |
			| DPID                |                                |
			| Alternate ID        |                                |
			| Key                 | WELLINGTON  JOHN               |
			| Name                | EST LATE JOHN WELLINGTON       |
			| Address1            | TEST AUTOMATION                |
			| Address2            | C/- CHARLES STANLEY & CO LTD   |
			| Address3            | 25 LUKE STREET                 |
			| Address4            | LONDON  EC2A 4AR               |
			| Address5            | UNITED KINGDOM                 |
			| Deceased            | Y                              |
			| Exception           |                                |
			| Suppress            | N                              |
			| Ret Mail            |                                |
			| A/Report            | N                              |
			| AR Nominated Text   | (Default)                      |
			| Birth Date          |                                |
			| Stop Trade          | N                              |
			| Div Source          | U                              |
			| Residency           |                                |
			| Var Flag1           |                                |
			| Var Flag2           |                                |
			| Var Flag3           |                                |
			| Var Flag4           |                                |
			| Var Flag5           |                                |
			| Warning1            | Overseas domicile              |
			| Warning2            | Deceased estate                |
			| Warning3            | Noting:D1                      |
			| Warning4            | Nil holding on trading classes |
			| Warning5            | No Annual Report               |
			| Warning6            |                                |
			| Restrict Class info |                                |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16775USA
@EN_E_DisplayActions
Scenario: Test Case 16775: USA A action for Overseas and Local domiciles-USA
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0030013930"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                          |
			| HIN                 | I0030013930                    |
			| Type                | ***                            |
			| Post Code           | USA                            |
			| TAX Code            |                                |
			| TFN Desc            | Non-Res                        |
			| ABN Desc            | Non-Res                        |
			| Group               |                                |
			| Var field           |                                |
			| Broker Code         | 60254                          |
			| Register            |                                |
			| Key Modifier        |                                |
			| DPID                |                                |
			| Alternate ID        |                                |
			| Key                 | ADKINS      THOMASEGGLES    ZZ |
			| Name                | MR THOMAS EGGLESTON ADKINS JR  |
			| Address1            | 8298 WOODGROVE ROAD            |
			| Address2            | JACKSONVILLE FL 32256          |
			| Address3            | UNITED STATES OF AMERICA       |
			| Address4            |                                |
			| Address5            | <* Merged on 20 Nov 2001    *> |
			| Deceased            | N                              |
			| Exception           |                                |
			| Suppress            | N                              |
			| Ret Mail            |                                |
			| A/Report            | N                              |
			| AR Nominated Text   | (Default)                      |
			| Birth Date          |                                |
			| Stop Trade          | Y                              |
			| Div Source          | D                              |
			| Residency           |                                |
			| Var Flag1           |                                |
			| Var Flag2           |                                |
			| Var Flag3           |                                |
			| Var Flag4           |                                |
			| Var Flag5           |                                |
			| Warning1            | Overseas domicile              |
			| Warning2            | Stop trade                     |
			| Warning3            | Nil holding on trading classes |
			| Warning4            | No Annual Report               |
			| Warning5            |                                |
			| Warning6            |                                |
			| Restrict Class info |                                |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16775NZL
@EN_E_DisplayActions
Scenario: Test Case 16775: NZL A action for Overseas and Local domiciles-NZL
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0030153839"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                         |
			| HIN                 | I0030153839                   |
			| Type                | STF                           |
			| Post Code           | NZL                           |
			| TAX Code            |                               |
			| TFN Desc            | Non-Res                       |
			| ABN Desc            | Non-Res                       |
			| Group               |                               |
			| Var field           |                               |
			| Broker Code         | 60254                         |
			| Register            |                               |
			| Key Modifier        |                               |
			| DPID                |                               |
			| Alternate ID        | 22620695                      |
			| Key                 | BEGEJ       JEANNELORRAI      |
			| Name                | MRS JEANNE LORRAINE BEGEJ     |
			| Address1            | TEST AUTOMATION               |
			| Address2            | CHRISTCHURCH                  |
			| Address3            | NEW ZEALAND                   |
			| Address4            |                               |
			| Address5            |                               |
			| Deceased            | N                             |
			| Exception           |                               |
			| Suppress            | N                             |
			| Ret Mail            |                               |
			| A/Report            | N                             |
			| AR Nominated Text   | (Default)                     |
			| Birth Date          |                               |
			| Stop Trade          | N                             |
			| Div Source          | D                             |
			| Residency           |                               |
			| Var Flag1           |                               |
			| Var Flag2           |                               |
			| Var Flag3           |                               |
			| Var Flag4           |                               |
			| Var Flag5           |                               |
			| Warning1            | Overseas domicile             |
			| Warning2            | Payee instruction direct/bulk |
			| Warning3            | Holder Extra details present  |
			| Warning4            | Communication Methods Present |
			| Warning5            | ESS Participant               |
			| Warning6            | No Annual Report              |
			| Restrict Class info |                               |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16775AU
@EN_E_DisplayActions
Scenario: Test Case 16775: AU A action for Overseas and Local domiciles-AU
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0030025105"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder details as below:
			| Field               | Value                         |
			| HIN                 | I0030025105                   |
			| Type                | MAL                           |
			| Post Code           | 3169                          |
			| TAX Code            |                               |
			| TFN Desc            | TFN quoted                    |
			| ABN Desc            | Not quoted                    |
			| Group               |                               |
			| Var field           |                               |
			| Broker Code         | 60254                         |
			| Register            |                               |
			| Key Modifier        |                               |
			| DPID                |                               |
			| Alternate ID        |                               |
			| Key                 | ALEVIZOS    STEVEN            |
			| Name                | MR STEVEN ALEVIZOS            |
			| Address1            | TEST AUTOMATION               |
			| Address2            | CLAYTON SOUTH VIC             |
			| Address3            |                               |
			| Address4            |                               |
			| Address5            |                               |
			| Deceased            | N                             |
			| Exception           |                               |
			| Suppress            | N                             |
			| Ret Mail            |                               |
			| A/Report            | N                             |
			| AR Nominated Text   | (Default)                     |
			| Birth Date          |                               |
			| Stop Trade          | N                             |
			| Div Source          | D                             |
			| Residency           |                               |
			| Var Flag1           |                               |
			| Var Flag2           |                               |
			| Var Flag3           |                               |
			| Var Flag4           |                               |
			| Var Flag5           |                               |
			| Warning1            | Payee instruction direct/bulk |
			| Warning2            | No DPID allocated             |
			| Warning3            | No Annual Report              |
			| Warning4            |                               |
			| Warning5            |                               |
			| Warning6            |                               |
			| Restrict Class info |                               |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16778
@EN_E_DisplayActions
Scenario Outline: Test Case 16778: 05_A Action for Holder warnings
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder "<Warning1>"  "<Warning2>"  "<Warning3>"  "<Warning4>" Warning details as below

Examples: 

		| HIN         | Warning1                       | Warning2                       | Warning3                       | Warning4                       |
		| I0035933662 | OUTSTANDING PAYMENT            | Overseas domicile              | Payee instruction direct/bulk  | No Annual Report               |
		| X0060458120 | Returned mail                  | Payee instruction direct/bulk  | Nil holding on trading classes | Holder Extra details present   |
		| X0051191323 | ** LIKE HOLDER PRESENT **      | Payee instruction direct/bulk  | Nil holding on trading classes | No Annual Report               |
		| I0032365906 | Stop trade                     | Nil holding on trading classes | No Annual Report               |                                |
		| X0008422991 | Payee instruction direct/bulk  | No Annual Report               |                                |                                |
		| I0032367470 | Payee instruction direct/bulk  | Plan participant               | Shareholder Review             |                                |
		| I0033516096 | Nil holding on trading classes | No Annual Report               |                                |                                |
		| I0040235558 | Stop trade                     | Nil holding on trading classes | No Annual Report               |                                |
		| I0030226810 | Payee instruction direct/bulk  | Noting:N1                      | Holder Extra details present   | Communication Methods Present  |
		| I0035894705 | OUTSTANDING PAYMENT            | Overseas domicile              | Payee instruction direct/bulk  | Nil holding on trading classes |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16860
@EN_E_DisplayActions
Scenario Outline: Test Case 16860: 01_A action for Different Holder Types
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
	Then In ENS01001 I should see holder "<Type>" Holder Type as below

Examples: 

		| HIN         | Type |
		| I0036279826 | JNT  |
		| X0053320112 | COY  |
		| I0035933662 | IND  |
		| I0035120696 | EMP  |
		| C0009876245 | NOM  |
		| I0030248864 | DEC  |
		| C0009909058 | FEM  |
		| I0033430833 | STF  |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16961
@EN_E_DisplayActions
@FullSmokeTest
Scenario Outline: Test Case 16961: 04_A action with Extra Details_Dot
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | A     |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | .     |
			| Locate Argument |       |
	Then In ENS01052 I should see NameAddress Extra Details as below "<HIN>" "<HolderOnDate>" "<HolderOffDate>" "<HolderAddedDate>" "<Version>" "<RunLastChange>" "<LastBalDump>" "<LastPaymentDump>" "<MergeTo>" "<MergeFrom>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENS01052 I should see NameAddress Extra Details as below "<HIN>" "<HolderOnDate>" "<HolderOffDate>" "<HolderAddedDate>" "<Version>" "<RunLastChange>" "<LastBalDump>" "<LastPaymentDump>" "<MergeTo>" "<MergeFrom>"

Examples: 

		| HIN         | HolderOnDate | HolderOffDate | HolderAddedDate | Version | RunLastChange | LastBalDump | LastPaymentDump | MergeTo     | MergeFrom |
		| I0900527993 | 08/06/2001   | 12/04/2005    | 09/06/2001      | 11      | 5284          | 0           | 3685            | I0034810389 |           |
		| X0021384631 | 18/09/2009   | 12/06/2014    | 06/09/2004      | 21      | 7650          | 6129        | 0               |             |           |

@winformsTest
@EnquiryTest
@NAB_AUTO
@16849
@EN_E_DisplayActions
Scenario: Test Case 16849: 01_H Action comparison
	# Enquiry System -Action H
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0036136464"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | H     |
			| Locate Argument |       |
	Then In ENS01007 I should see Holdings details as below:
			| Field        | Value                                                                   |
			| Name Key     | VALE        GNANA                                                       |
			| HIN          | I0036136464                                                             |
			| Holder Type  | IND                                                                     |
			| Post Code    | 3000                                                                    |
			| Tax Code     |                                                                         |
			| Group Code   |                                                                         |
			| Broker Code  | 60254                                                                   |
			| Key Modifier |                                                                         |
			| Alternate ID |                                                                         |
			| Var Field    |                                                                         |
			| Name         | GNANA VALE,                                                             |
			| Address1     | TEST AUTOMATION                                                         |
			| Address2     | OAKLEIGH SOUTH VIC                                                      |
			| Address3     |                                                                         |
			| Address4     |                                                                         |
			| Address5     |                                                                         |
			| Line1 Page1  | CEN/ENTITLEMENT CPS II 2013 VIC   99999999999               99999999999 |
			| Line2 Page1  | DAM/EMPLOYEE TRUST HELD SHA VIC            76                        76 |
			| Line3 Page1  | DBM/EMPLOYEE TRUST HELD SHA VIC           102                       102 |
			| Line4 Page1  | DCE/DUMMY EMP CLASS PROJECT VIC            76                        76 |
			| Line5 Page1  | DEM/EMPLOYEE TRUST HELD SHA VIC            76                        76 |
			| Line6 Page1  | DME/DUMMY EMP CLASS FOR NOT VIC            40                        40 |
			| Line1 Page2  | DUM/EMPLOYEE TRUST HELD SHA VIC            40                        40 |
			| Line2 Page2  | DXM/EMPLOYEE TRUST HELD SHA VIC            40                        40 |
			| Line3 Page2  | E11/NAB CAPITAL NOTES S/H O VIC   99999999999               99999999999 |
			| Line4 Page2  | EMP/EMP GROUP 4 RD BALANCE  VIC           132                       132 |
			| Line5 Page2  | ESO/EMPLOYEE SHARE OFFER    11A            40                        40 |
			| Line6 Page2  | 12A            36                        36                             |
			| Line7 Page2  | 13A            26                        26                             |
			| Line8 Page2  | 14A            30                        30                             |
			| Line9 Page2  | ESO/**** Class Total   **                 132                           |
			| Line10 Page2 | F14/EMPLOYEE TRUST HELD SHA VIC           102                       102 |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then I expect to see error with text "This option not available for this screen."

@winformsTest
@EnquiryTest
@NAB_AUTO
@16850
@EN_E_DisplayActions
Scenario: Test Case 16850: 02_C action comparison 'C'ertificate actions
	# Enquiry System -Action C
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0036136464"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | C     |
			| Locate Argument |       |
	Then In ENS01012 I should see Holder Certificate details as below:
			| Field  | Value                                        |
			| HIN    | I0036136464                                  |
			| Line1  | CEN/ENTITLEMENT CPS II 2013                  |
			| Line2  | VIC 24410266     04/11/13   99999999999      |
			| Line3  | **** Total for 24410266          99999999999 |
			| Line4  | DAM/EMPLOYEE TRUST HELD SHARES               |
			| Line5  | VIC UNCERTIF'D   14/11/13            76      |
			| Line6  | **** Total for UNCERTIF'D                 76 |
			| Line7  | DBM/EMPLOYEE TRUST HELD SHARES               |
			| Line8  | VIC UNCERTIF'D   19/05/14           102      |
			| Line9  | **** Total for UNCERTIF'D                102 |
			| Line10 | DCE/DUMMY EMP CLASS PROJECT MURRAY           |
			| Line11 | VIC 00007120     04/11/13            76      |
			| Line12 | **** Total for 00007120                   76 |
			| Line13 | DEM/EMPLOYEE TRUST HELD SHARES               |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	Then In ENS01012 I should see Holder Certificate details as below:
			| Field  | Value                                        |
			| HIN    | I0036136464                                  |
			| Line1  | DEM/EMPLOYEE TRUST HELD SHARES     Cont'd    |
			| Line2  | VIC UNCERTIF'D   06/06/13            76      |
			| Line3  | **** Total for UNCERTIF'D                 76 |
			| Line4  | DME/DUMMY EMP CLASS FOR NOTES ENT            |
			| Line5  | VIC 00021287     10/05/12            40      |
			| Line6  | **** Total for 00021287                   40 |
			| Line7  | DUM/EMPLOYEE TRUST HELD SHARES               |
			| Line8  | VIC UNCERTIF'D   16/11/12            40      |
			| Line9  | **** Total for UNCERTIF'D                 40 |
			| Line10 | DXM/EMPLOYEE TRUST HELD SHARES               |
			| Line11 | VIC UNCERTIF'D   07/06/12            40      |
			| Line12 | **** Total for UNCERTIF'D                 40 |
			| Line13 | E11/NAB CAPITAL NOTES S/H OFF ENT            |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then I expect to see error with text "This option not available for this screen."
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0036199024"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | C     |
			| Locate Argument |       |
	Then I expect to see error with text "This holder has no certificates."

@winformsTest
@EnquiryTest
@NAB_AUTO
@16851
@EN_E_DisplayActions
@FullSmokeTest
Scenario Outline: Test Case 16851: 03_R action comparison
	# Enquiry System -Action R
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01013 I should see Register details as "<HIN>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENS01013 I should see Register details as "<HIN>" "<Line1pg2>" "<Line2pg2>" "<Line3pg2>" "<Line4pg2>" "<Line5pg2>" "<Line6pg2>" "<Line7pg2>" "<Line8pg2>" "<Line9pg2>" "<Line10pg2>" "<Line11pg2>" "<Line12pg2>" "<Line13pg2>"
	When I enter the following details as the locatActions "<Action2>"  "<LocateArgument2>"
	Then In ENS01053 I should see Extra Register details as "<ExtraLine1>" "<ExtraLine2>" "<ExtraLine3>" "<ExtraLine4>" "<ExtraLine5>" "<ExtraLine6>"

Examples: 
	| HIN         | Action | LocateArgument | Line1                           | Line2                                                                                    | Line3                                        | Line4                              | Line5                              | Line6                                                        | Line7                                                        | Line8                                       | Line9                                                                    | Line10                             | Line11                                                                                    | Line12                         | Line13                                                                                   | Action1 | LocateArgument1 | Line1pg2                                    | Line2pg2                                                                                  | Line3pg2                           | Line4pg2                                                     | Line5pg2                                                     | Line6pg2                                                                | Line7pg2                           | Line8pg2                                                     | Line9pg2                                    | Line10pg2                          | Line11pg2                          | Line12pg2                  | Line13pg2                                                                                 | Action2 | LocateArgument2 | ExtraLine1            | ExtraLine2 | ExtraLine3            | ExtraLine4                                | ExtraLine5                                | ExtraLine6 |
	| I0036136464 | R      |                | CEN/ENTITLEMENT CPS II 2013     | VIC 24410266     04/11/13 ENTIT 7108/68439886              1                             | 04/11/13 ENTIT 7108/68439887    99999999998  | *Certificate Balance   99999999999 | **** Class Total ***   99999999999 | DAM/EMPLOYEE TRUST HELD SHARES                               | VIC UNCERTIF'D   14/11/13 ALLOT 7119/69163934             76 | DBM/EMPLOYEE TRUST HELD SHARES              | VIC UNCERTIF'D   19/05/14 ALLOT 7305/70680356            102             | DCE/DUMMY EMP CLASS PROJECT MURRAY | VIC 00007120     04/11/13 IAJUP 7107/83007120             76                       TRNTPE | DEM/EMPLOYEE TRUST HELD SHARES | VIC UNCERTIF'D   06/06/13 ALLOT 6973/66268130             76                             | M       |                 | DME/DUMMY EMP CLASS FOR NOTES ENT           | VIC 00021287     10/05/12 IAJUP 6605/ 8121287             40                       TRNTPE | DUM/EMPLOYEE TRUST HELD SHARES     | VIC UNCERTIF'D   16/11/12 ALLOT 6790/63164738             40 | DXM/EMPLOYEE TRUST HELD SHARES                               | VIC UNCERTIF'D   07/06/12 ALLOT 6643/61712604             40            | E11/NAB CAPITAL NOTES S/H OFF ENT  | VIC 41306129     12/02/15 ENTIT 7560/74047891              1 | 12/02/15 ENTIT 7560/74047892    99999999998 | *Certificate Balance   99999999999 | **** Class Total ***   99999999999 | EMP/EMP GROUP 4 RD BALANCE | VIC 00017092     12/02/15 IAJUP 7555/73003214            132                       TRNTPE | >       |                 | 60254                 | 60254      | 60254                 | 60254             BPAY/128999900413061295 | 60254             BPAY/128999900413061295 | 60254      |
   #| X0021384631 | R      |                | CZZ/DEC13 PLC NABZZ TO NABPB T1 | VIC UNCERTIF'D   13/12/13 CHSMU 7171/69716395            130                       CHESS | 17/12/13 @PBZZ 7179/69754602            130- | **** Class Total ***             0 | MNY/AUD MONEY CLASS                | *MR MONEY L/OVER 18/12/07 MNYIN 5244/43628480          28.85 | 10/07/08 MNYDN 5399/44849180          28.85-                 | 10/07/08 MNYIN 5399/44849181           6.59 | 19/02/09 MNYDN 5620/81003889           6.59-                      TRNTPE | *Certificate Balance          0.00 | **** Class Total ***          0.00                                                        | NIS/NATIONAL INCOME SECURITIES | VIC UNCERTIF'D   18/09/09 CHSMU 5811/53036629            325                       CHESS | M       |                 | NIS/NATIONAL INCOME SECURITIES     (Cont'd) | 24/06/13 CHSMD 6992/67154970            325-                      CHESS                   | **** Class Total ***             0 | PB /CONVERTIBLE PREFERENCE SHARE 2                           | VIC UNCERTIF'D   17/12/13 @PBZZ 7179/69754602            130 | 12/06/14 CHSMD 7332/71223347            130-                      CHESS | **** Class Total ***             0 |                                                              |                                             |                                    |                                    |                            |                                                                                           | >       |                 | E01736795        4064 | 4064       | E04002859        4064 |                                           |                                           |            |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17146
@EN_E_DisplayActions
Scenario Outline: Test Case 17146: 04_RR action compare-Test1
	# Enquiry System -Action R
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01016 I should see Register details as "<HIN>" "<Line1>" "<Line2>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENS01069 I should see Balance Transaction Extra Details as "<TransDate>" "<TransType>" "<OtherHID>" "<TradeRef>" "<BrokerCode>" "<AgentCode>" "<SubSystem>" "<Run>" "<Tran>" "<Class>" "<Register>" "<Units>"
	Then In ENS01069 I should see SLR Transaction Details as "<SLRDate>" "<WorkflowID>" "<OrigSystem>" "<ServiceProvider>" "<ServiceCode>" "<Branch>" "<Department>" "<MessageUserID>"
	Then In ENS01069 I should see Remittance Transaction Details as "<PaymentSource>" "<CustomerRef>" "<PaymentDate>" "<TraceNo>" "<SettlemtDate>" "<InputFile>" "<FileReceived>" "<FileProcessed>"

Examples: 
	| HIN         | Action | LocateArgument            | Line1                       | Line2                                                                                    | Action1 | LocateArgument1 | TransDate  | TransType | OtherHID  | TradeRef | BrokerCode | AgentCode | SubSystem | Run  | Tran     | Class | Register | Units    | SLRDate    | WorkflowID | OrigSystem | ServiceProvider | ServiceCode | Branch | Department | MessageUserID |  PaymentSource | CustomerRef        | PaymentDate | TraceNo               | SettlemtDate | InputFile                     | FileReceived | FileProcessed |
	| I0100000334 | RR     | I0100000334/7132/69186910 | CMN/MONEY CPS II OFFER 2013 | *MR 24572791ZB   22/11/13 RBPAY 7132/69186910       20000.00                             | 2       |                 | 22/11/2013 | RBPAY     | One Sided |          | 60254      |           | ISX0010   | 7132 | 69186910 | CMN   | *MR      | 20000.00 |            |            |            |                 |             |        |            |               |  BPAY          | 122489900245727913 | 21/11/2013  | CBA201311210241447264 | 21/11/2013   | BNKRMT_12248_2013112203300323 | Unknown      | 22/11/2013    |

@winformsTest
@EnquiryTest
@NAB_AUTO
@171462
@EN_E_DisplayActions
Scenario Outline: Test Case 17146: 04_RR action compare-Test2
	# Enquiry System -Action R
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01016 I should see Register details as "<HIN>" "<Line1>" "<Line2>"
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENS01069 I should see Balance Transaction Extra Details as "<TransDate>" "<TransType>" "<OtherHID>" "<TradeRef>" "<BrokerCode>" "<AgentCode>" "<SubSystem>" "<Run>" "<Tran>" "<Class>" "<Register>" "<Units>"
	Then In ENS01069 I should see SLR Transaction Details as "<SLRDate>" "<WorkflowID>" "<OrigSystem>" "<ServiceProvider>" "<ServiceCode>" "<Branch>" "<Department>" "<MessageUserID>"

Examples: 
	| HIN         | Action | LocateArgument            | Line1                       | Line2                                                                                    | Action1 | LocateArgument1 | TransDate  | TransType | OtherHID  | TradeRef | BrokerCode | AgentCode | SubSystem | Run  | Tran     | Class | Register | Units    | SLRDate    | WorkflowID | OrigSystem | ServiceProvider | ServiceCode | Branch | Department | MessageUserID |  
	| X0030264142 | RR     | X0030264142/6696/62298624 | ZZZ/SHAREHOLDER CARD        | VIC 00888774     30/07/12 CAPIN 6696/62298624              1                       SCRIP | 2       |                 | 30/07/2012 | CAPIN     | One Sided |          |            |           |           | 6696 | 62298624 | ZZZ   | VIC      | 1        | 28/07/2012 |            | SCRIP      | CIS             | ******      | MELY   | CISCL      | GreL 00001    |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17272
@EN_E_DisplayActions
Scenario: Test Case 17272: 01_HE:Holder Extra Details
	# Enquiry System -Action HE
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0070036916"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | HE    |
			| Locate Argument |       |
	Then In ENS01020 I should see holder extra details as below:
			| Field           | Value                        |
			| Name Key        | ST          TRANSACODE  TEST |
			| HIN             | I0070036916                  |
			| Holder Type     | DEC                          |
			| Extra Holder ID | 123456789                    |
			| Name            | ESTATE LATE TRANSACTION CODE |
			| Address1        | TEST AUTOMATION              |
			| Address2        | C/- 452 JHONSTON ST,         |
			| Address3        | ABBOTSFORD                   |
			| Address4        | MELBOURNE                    |
			| Address5        |                              |
			| Home Tell       | 03123456789                  |
			| Work Tell       | 03987654213                  |
			| Fax             | 03696854789                  |
			| Mobile          | 0430834786                   |
			| Email           | Test@computershare.com.au    |
			| Return Email    |                              |
			| Email Count     | 0                            |
			| ABN1            |                              |
			| ABN2            |                              |
			| Type1           |                              |
			| Type2           |                              |
			| Flag1           | AB                           |
			| Flag1 Desc      |                              |
			| Flag2           | W9                           |
			| Flag2 Desc      | USA SOCIAL SECURITY NUMBER   |
			| Flag3           | EF                           |
			| Flag3 Desc      |                              |
			| Flag4           | Y                            |
			| Flag4 Desc      |                              |
			| Flag5           | E1                           |
			| Flag5 Desc      | AML CPM Plan Participant     |
			| Flag6           | FG                           |
			| Flag6 Desc      |                              |
			| Flag7           | AP                           |
			| Flag7 Desc      | LH ID WITHIN RE-CON CAMPAIGN |
			| Flag8           | TR                           |
			| Flag8 Desc      |                              |
			| Flag9           | N                            |
			| Flag9 Desc      | PRIVACY OPT OUT              |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENS01024 I should see holder communication Methods as below:
			| Field               | Value                        |
			| Publication1        | NO METHODS SET ON COYCOM FOR |
			| Publication1 Method | NAB_AUTO                     |
			| Publication2        |                              |
			| Publication2 Method |                              |
			| Publication3        |                              |
			| Publication3 Method |                              |
			| Publication4        |                              |
			| Publication4 Method |                              |
			| Publication5        |                              |
			| Publication5 Method |                              |
			| Publication6        |                              |
			| Publication6 Method |                              |
			| Publication7        |                              |
			| Publication7 Method |                              |
			| Publication8        |                              |
			| Publication8 Method |                              |
			| Publication9        |                              |
			| Publication9 Method |                              |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17277
@EN_E_DisplayActions
Scenario Outline: Test Case 17277: 02_SH:Static Detail History action
	# Enquiry System -Action SH
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	#When I change the service provider
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | SH    |
			| Locate Argument |       |
	Then In ENS01034 I should see Static History Details as below "<Run1>" "<Tran1>" "<Date1>" "<TranCode1>" "<TranDesc1>" "<Reference1>" "<Source1>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |	
	Then In ENS01035 I should see Static History as below "<Run1Pg2>" "<Tran1Pg2>" "<Date1Pg2>" "<TranCode1Pg2>" "<TranDesc1Pg2>" "<Reference1Pg2>" "<Source1Pg2>"	

Examples: 

		| HIN         | Run1 | Tran1  | Date1      | TranCode1 | TranDesc1           | Reference1 | Source1 | Run1Pg2 | Tran1Pg2 | Date1Pg2   | TranCode1Pg2 | TranDesc1Pg2                   | Reference1Pg2 | Source1Pg2 |
		| I0070036916 | 7646 | 321456 | 11/05/2015 | EMADD     | EMAIL ADDRESS (ADD) |            | WINFRM  | 7646    | 326547   | 11/05/2015 | EIADD        | EIS EMPLOYEE ADD               |               | WINFRM     |
		| I0070036924 | 7646 | 254687 | 11/05/2015 | UIADD     | US TAX STATUS (ADD) |            | WINFRM  | 7647    | 324335   | 15/05/2015 | UGAUD        | US TAX STATUS GENERL (AUD MOD) |               | WINFRM     |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17288_02
@EN_E_DisplayActions
Scenario Outline: Test Case 17288: 02_All Noting Menu/Option action-PowerOfAttorney
	# Enquiry System -Action N/D/P
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009913176"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | N     |
			| Locate Argument |       |	
	Then In ENS01021 I should see Noting Menu as below:
		| Field | Value                          |
		| HIN   | C0009913176                    |
		| P1    | P1. Power of Attorney (1)      |
		| P2    | P2. Power of Attorney (2)      |
		| P3    | P3. Power of Attorney (3)      |
		| D1    | D1. Deceased Estate noting (1) |
		| D2    | D2. Deceased Estate noting (2) |
		| D3    | D3. Deceased Estate noting (3) |
		| D4    | D4. Deceased Estate noting (4) |
		| D5    | D5. Deceased Estate noting (5) |
		| N1    | N1. Free format noting (1)     |
		| N2    | N2. Free format noting (2)     |
		| N3    | N3. Free format noting (3)     |
		| N4    | N4. Free format noting (4)     |
		| N5    | N5. Free format noting (5)     |
	When I enter the following details as the Locate action "<Action>" "<LocateArgument>"				
	Then In  ENS01003 I should see holder Power Of Attorney details Part1 as "<PANotingNbr>" "<Register>" "<DonorName1>" "<DonorName2>" "<PowerDated>" "<PowerNoted>" "<Attorney1>" "<Attorney2>" "<Attorney3>" "<Attorney4>" "<Jointly>" "<Severally>" "<AnyTwo>"
	Then In  ENS01003 I should see holder Power Of Attorney details Part2 as "<Others1>" "<Others2>" "<Buy>" "<Sell>" "<Vote>" "<AppointSubstitute>" "<StampedIn>" "<Comment1>" "<Comment2>" "<LodgedBy>" "<Run>" "<tran>"

Examples: 
		| Action | LocateArgument | PANotingNbr | Register | DonorName1 | DonorName2 | PowerDated | PowerNoted | Attorney1  | Attorney2  | Attorney3  | Attorney4  | Jointly | Severally | AnyTwo | Others1    | Others2    | Buy | Sell | Vote | AppointSubstitute | StampedIn | Comment1   | Comment2   | LodgedBy   | Run  | tran   |
		| P1     |                | 1           |          | 123        | PHIL HUGES | 19/05/2015 | 19/05/2015 | PHIL HUGES | PHIL HUGES | PHIL HUGES | PHIL HUGES | Y       | Y         | Y      | PHIL HUGES | PHIL HUGES | Y   | Y    | Y    | Y                 |           | PHIL HUGES | PHIL HUGES | PHIL HUGES | 7650 | 46464 |
		| P2     |                | 2           | VIC      | PHIL HUGES | PHIL HUGES | 19/05/2015 | 19/05/2015 | PHIL HUGES | PHIL HUGES | PHIL HUGES | PHIL HUGES | Y       | Y         | Y      | PHIL HUGES | PHIL HUGES | Y   | Y    | Y    | Y                 |           | PHIL HUGES | PHIL HUGES | PHIL HUGES | 7647 | 582456 |
		| P3     |                | 3           | VIC      | PHIL HUGES | PHIL HUGES | 19/05/2015 | 19/05/2015 | PHIL HUGES | PHIL HUGES | PHIL HUGES | PHIL HUGES | Y       | Y         | Y      | PHIL HUGES | PHIL HUGES | Y   | Y    | Y    | Y                 |           | PHIL HUGES | PHIL HUGES | PHIL HUGES | 7647 | 986542 |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17288_03
@EN_E_DisplayActions
Scenario Outline: Test Case 17288: 03_All Noting Menu/Option action-Noting
	# Enquiry System -Action N/D/P
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009913176"
	When I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01006 I should see Noting details as "<NotingNbr>" "<Key>" "<HIN>" "<Type>" "<Comment>" "<Noting1>" "<Noting2>" "<Noting3>" "<Noting4>" "<Noting5>" "<Noting6>" "<Noting7>" "<Noting8>" "<Run>" "<Tran>"
	
Examples: 
		| Action | LocateArgument | NotingNbr | Key                    | HIN         | Type | Comment  | Noting1           | Noting2                        | Noting3           | Noting4           | Noting5           | Noting6           | Noting7           | Noting8           | Run  | Tran   |
		| N1     |                | 1         | 1           ARSHADTEST | C0009913176 | IND  | NOTING 1 | THIS IS NOTING 1. | THIS IS NOTING 1.              | THIS IS NOTING 1. | THIS IS NOTING 1. | THIS IS NOTING 1. | THIS IS NOTING 1. | THIS IS NOTING 1. | THIS IS NOTING 1. | 7647 | 12345  |
		| N2     |                | 2         | 1           ARSHADTEST | C0009913176 | IND  | NOTING 2 | THIS IS NOTING 2  | THIS IS NOTING 2               | THIS IS NOTING 2  | THIS IS NOTING 2  | THIS IS NOTING 2  | THIS IS NOTING 2  | THIS IS NOTING 2  | THIS IS NOTING 2  | 7647 | 123456 |
		| N3     |                | 3         | 1           ARSHADTEST | C0009913176 | IND  |          | THIS IS NOTING 3  | syed_syed@computershare.com.au | THIS IS NOTING 3  | THIS IS NOTING 3  | THIS IS NOTING 3  | THIS IS NOTING 3  | THIS IS NOTING 3  | THIS IS NOTING 3  | 7655 | 4167473|
		| N4     |                | 4         | 1           ARSHADTEST | C0009913176 | IND  | NOTING 4 | THIS IS NOTING 4  | THIS IS NOTING 4               | THIS IS NOTING 4  | THIS IS NOTING 4  | THIS IS NOTING 4  | THIS IS NOTING 4  | THIS IS NOTING 4  | THIS IS NOTING 4  | 7647 | 654322 |
		| N5     |                | 5         | 1           ARSHADTEST | C0009913176 | IND  | NOTING 5 | THIS IS NOTING 5  | THIS IS NOTING 5               | THIS IS NOTING 5  | THIS IS NOTING 5  | THIS IS NOTING 5  | THIS IS NOTING 5  | THIS IS NOTING 5  | THIS IS NOTING 5  | 7647 | 654323 |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17288_04
@EN_E_DisplayActions
Scenario Outline: Test Case 17288: 04_All Noting Menu/Option action-Deceased Estate Noting
	# Enquiry System -Action N/D/P
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009913176"
	When I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENS01005 I should see holder Deceased Estate Notings Part1 as "<NotingNbr>" "<Key>" "<Register>" "<DeceasedName>" "<Run>" "<Tran>" "<HIN>" "<Type>" "<DOD>" "<DeathCertSighted>" "<Willdated>" "<SmallEstate>" "<Sighted>" "<ProbategrantedIn>" "<ProbateOnDate>"
	Then In ENS01005 I should see holder Deceased Estate Notings Part2 as  "<ProbateSightedDate>" "<ResealedIn>" "<ResealedOnDate>" "<1071B>" "<121A>" "<ConfirmationofID>" "<Exors1>" "<Exors2>" "<Exors3>" "<Comment1>" "<Comment2>" "<Comment3>" "<Lodged>" 

Examples: 
		| Action | LocateArgument | NotingNbr | Key                    | Register | DeceasedName | Run  | Tran   | HIN         | Type | DOD        | DeathCertSighted | Willdated  | SmallEstate | Sighted    | ProbategrantedIn | ProbateOnDate | ProbateSightedDate | ResealedIn | ResealedOnDate | 1071B    | 121A | ConfirmationofID | Exors1             | Exors2             | Exors3             | Comment1           | Comment2           | Comment3           | Lodged             |
		| D1     |                | 1         | 1           ARSHADTEST | VIC      | PHIL HUGES   | 7647 | 654324 | C0009913176 | IND  | 19/05/2015 | 19/05/2015       | 19/05/2015 | Y           | 19/05/2015 | VICTORIA         | 19/05/2015    | 19/05/2015         | VICTORIA   | 19/05/2015     | 19052015 | Y    | Y                | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 |
		| D2     |                | 2         | 1           ARSHADTEST | VIC      | PHIL HUGES   | 7647 | 654325 | C0009913176 | IND  | 19/05/2015 | 19/05/2015       | 19/05/2015 | Y           | 19/05/2015 | VICTORIA         | 19/05/2015    | 19/05/2015         | VICTORIA   | 19/05/2015     | 19052015 | Y    | Y                | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 |
		| D3     |                | 3         | 1           ARSHADTEST | VIC      | PHIL HUGES   | 7647 | 654326 | C0009913176 | IND  | 19/05/2015 | 19/05/2015       | 19/05/2015 | Y           | 19/05/2015 | VICTORIA         | 19/05/2015    | 19/05/2015         | VICTORIA   | 19/05/2015     | 19052015 | Y    | Y                | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 |
		| D4     |                | 4         | 1           ARSHADTEST | VIC      | PHIL HUGES   | 7647 | 654789 | C0009913176 | IND  | 19/05/2015 | 19/05/2015       | 19/05/2015 | Y           | 19/05/2015 | VICTORIA         | 19/05/2015    | 19/05/2015         | VICTORIA   | 19/05/2015     | 19052015 | Y    | Y                | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 |
		| D5     |                | 5         | 1           ARSHADTEST | VIC      | PHIL HUGES   | 7647 | 654790 | C0009913176 | IND  | 19/05/2015 | 19/05/2015       | 19/05/2015 | Y           | 19/05/2015 | VICTORIA         | 19/05/2015    | 19/05/2015         | VICTORIA   | 19/05/2015     | 19052015 | Y    | Y                | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 | DECEASED ESTATE D1 |



#@DIV_A

#	Then in ENS01066 I should see holder Charity Election details as below:
#			| Field       | Value                |
#			| Key         | 10A         TEST     |
#			| HIN         | I0000001333          |
#			| Type        | IND                  |
#			| Name1       | Mr Test 10A          |
#			| Name2       | Mrs Vibveful Adakw & |
#			| Class       | ORD                  |
#			| Level       | 100                  |
#			| CharityCode | ALZH10               |
#			| Date        | 25/02/2014           |
#			| Tran        | 1231                 |
#		And I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | >     |
#			| Locate Argument |       |
#		Then In SELCHA01 I should see Select Charity codes as below:
#			| Field         | Value                           |
#			| CharityCode1  | ALZH10                          |
#			| Code1Desc     | Alzheimer's Australia           |
#			| CharityCode2  | AMIN10                          |
#			| Code2Desc     | Amnesty International Australia |
#			| Code3Desc     | Barnardos Australia             |
#			| CharityCode4  | BBDR10                          |
#			| Code4Desc     | beyondblue                      |
#			| CharityCode5  | BEAR10                          |
#			| Code5Desc     | Bear Cottage                    |
#			| CharityCode6  | BENS10                          |
#			| Code6Desc     | The Benevolent Society          |
#			| CharityCode7  | BHST10                          |
#			| Code7Desc     | Brotherhood of St Laurence      |
#			| CharityCode8  | BSTV30                          |
#			| Code8Desc     | Berry Street Victoria           |
#			| CharityCode9  | CANC10                          |
#			| Code9Desc     | The Cancer Council Australia    |
#			| CharityCode10 | CANT10                          |
#			| Code10Desc    | CanTeen                         |
#		And I close Winforms

@winformsTest
@EnquiryTest
@DIV_A
@17296
@EN_E_DisplayActions
Scenario: Test Case 17296: 05_CA:Custodian Access
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system for "X0035061240"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | CA    |
			| Locate Argument |       |
		Then In ENS010CA I should see Custodian Access Codes as below:
			| Field      | Value                      |
			| AccessCode | SC2                        |
			| Name       | TESTING TFS 263925 - STATS |	

@winformsTest
@EnquiryTest
@NAB_AUTO
@17305_1
@EN_E_DisplayActions
@FullSmokeTest
Scenario: Test Case 17305: 01_PI: Payment Instruction action -Local
	# Enquiry System -Action PI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0070036916"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PI    |
			| Locate Argument |       |
	Then In ENS01002 I should see the holder payee Instructions as below:
				| Field          | Value                        |
				| Name Key       | ST          TRANSACODE  TEST |
				| HIN            | I0070036916                  |
				| Holder Type    | DEC                          |
				| Bank System    | 10                           |
				| BSB Code       | 105-090                      |
				| Account Number | 123456789                    |
				| Account Name   | BRANDON O'CONNOR             |
				| Bank Address1  | ST GEORGE BANK LTD           |
				| Bank Address2  | HINDLEY-BANK STREET          |
				| Name           | ESTATE LATE TRANSACTION CODE |
				| Address1       | TEST AUTOMATION              |
				| Address2       | C/- 452 JHONSTON ST,         |
				| Address3       | ABBOTSFORD                   |
				| Address4       | MELBOURNE                    |
				| Address5       |                              |
@winformsTest
@EnquiryTest
@NAB_AUTO
@17305_2
@EN_E_DisplayActions
Scenario: Test Case 17305: 02_PI: Payment Instruction action -Foreign
	# Enquiry System -Action PI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
	 And I go to the Enquiry system for "I0070036924"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | PI    |
			| Locate Argument |       |
	Then In ENS01002 I should see the holder payee Instructions as below:
				| Field          | Value                        |
				| Name Key       | 2           TRANSACODE  TEST |
				| HIN            | I0070036924                  |
				| Holder Type    | IND                          |
				| Bank System    | 30                           |
				| BSB Code       | 40-05-15                     |
				| Account Number | 12345678                     |
				| Account Name   | ARSHAD SYED                  |
				| Bank Address1  | MIDLAND BANK PLC             |
				| Bank Address2  | P O BOX 181                  |
				| Name           | TRANSACTION CODE TEST 2,     |
				| Address1       | TEST AUTOMATION              |
				| Address2       | ABBOTSFORD                   |
				| Address3       |                              |
				| Address4       |                              |
				| Address5       |                              |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17320_01
@EN_E_DisplayActions
Scenario Outline: Test Case 17320: 01_DI: Dividend Intention action
	# Enquiry System -Action DI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DI    |
			| Locate Argument |       |
	Then In ENS01060 I should see holder Dividend Intention Details as "<HIN>" "<Type>" "<BSP1>" "<BSP2>" "<DivSource>" "<DRP1>" "<DRP2>" "<DRP3>" "<DRP4>" "<DRP5>"

Examples: 
		| HIN         | Type | BSP1                                                                         | BSP2                                   | DivSource | DRP1                                                                         | DRP2                                                                         | DRP3 | DRP4                                                                         | DRP5                                   | 
		| I0030731859 | IND  | BSP1  1   BSP                                                              Y | BSP2  2   EMP PP BSP   NON PARTICIPANT | D         | DRP1  1   DRP          29/03/94            0922     87609    F             N | DRP2  2   EMP PP DRP   29/03/94  22/03/95  1231   1086956    W             N |      | DRP4  4   EMP DRP      19/05/15            7647    256478    P         20  N | DRP5  5   RBP          NON PARTICIPANT |
		| I0035861173 | IND  | BSP1  1   BSP          NON PARTICIPANT                                       | BSP2  2   EMP PP BSP   NON PARTICIPANT | D         | DRP1  1   DRP                              0000         0                  Y | DRP2  2   EMP PP DRP   NON PARTICIPANT                                       |      | DRP4  4   EMP DRP      NON PARTICIPANT                                       | DRP5  5   RBP          NON PARTICIPANT | 

@winformsTest
@EnquiryTest
@NAB_AUTO
@17320_02
@EN_E_DisplayActions
@FullSmokeTest
Scenario Outline: Test Case 17320: 02_DI: Dividend Intention action and Extra Details
	# Enquiry System -Action DI
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0030731859"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | DI    |
			| Locate Argument |       |
	Then In ENS01060 I should see holder Dividend Intention Details as "<HIN>" "<Type>" "<BSP1>" "<BSP2>" "<DivSource>" "<DRP1>" "<DRP2>" "<DRP3>" "<DRP4>" "<DRP5>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | >     |
			| Locate Argument |       |
	Then In ENS01061 I should see holder Extra Dividend Intentions as below:
			| Field    | Value    |
			| BSPDate  | 19/05/15 |
			| BSPRun   | 7647     |
			| BSPTran  | 695213   |
			| BSPOpt   | P        |
			| BSPLevel | 30       |

Examples: 
		| HIN         | Type | BSP1                                                                         | BSP2                                   | DivSource | DRP1                                                                         | DRP2                                                                         | DRP3 | DRP4                                                                         | DRP5                                   |
		| I0030731859 | IND  | BSP1  1   BSP                                                              Y | BSP2  2   EMP PP BSP   NON PARTICIPANT | D         | DRP1  1   DRP          29/03/94            0922     87609    F             N | DRP2  2   EMP PP DRP   29/03/94  22/03/95  1231   1086956    W             N |      | DRP4  4   EMP DRP      19/05/15            7647    256478    P         20  N | DRP5  5   RBP          NON PARTICIPANT |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17343
@EN_E_DisplayActions
Scenario Outline: Test Case 17343: 01_AS:Acceptance Status action
	# Enquiry System -Action AS
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
	When I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSACC01 I should see Acceptance Status Summary details as "<HIN>" "<Line1>" "<Line2>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 2     |
			| Locate Argument |       |
	Then In ENSACC02 I should see detail Acceptance Status History details as "<HIN>" "<Reference>" "<Run>" "<Date>" "<EntitledUnits>" "<OverrideUnits>" "<AcceptedUnits>" "<EntitlementBalance>" "<AdditionalUnits>" "<TotalMoney>" "<AcceptanceStatus>" "<Source>"

Examples:
	| HIN         | Action | LocateArgument | Line1                                                                                                                      | Line2                                                                                                                               | Reference | Run  | Date     | EntitledUnits | OverrideUnits | AcceptedUnits | EntitlementBalance | AdditionalUnits | TotalMoney | AcceptanceStatus | Source |
	| I0035493034 | AS     | I0035493034    | ISX0010 NAB REMITTENCE TEST                                   Classes - E4 ,A4 ,M4 ,O4          Historical Record 30/05/15 | 44450353             63                       0          63           0           0.00   Not Accepted            0.00          0.00 | 44450353  | 7649 | 20/05/15 | 63            |               | 0             | 63                 | 0               | 0.00       | Not Accepted     | ENTBLD |
	| X0050420248 | AS     | X0050420248    | ISX0010 NAB REMITTENCE TEST                                   Classes - E4 ,A4 ,M4 ,O4          Historical Record 30/05/15 | 44450361            328                       0         328           0           0.00   Not Accepted            0.00          0.00 | 44450361  | 7649 | 20/05/15 | 328           |               | 0             | 328                | 0               | 0.00       | Not Accepted     | ENTBLD |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17344
@EN_E_DisplayActions
Scenario Outline: Test Case 17344: 02_PM:Pending Money action
	# Enquiry System -Action PM
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system and Search <HIN>
	When I enter the following details as the Locate action "<Action>" "<LocateArgument>"
	Then In ENSACC03 I should see Pending Money Summary details as "<HIN>" "<Line1>" "<Line2>"

Examples:
	| HIN         | Action | LocateArgument | Line1                       | Line2                                                             |
	| I0035493034 | PM     | I0035493034    | ISX0010 NAB REMITTENCE TEST | 44450353         21/05/15                  63.00             LKBX |
	| X0050420248 | PM     | X0050420248    | ISX0010 NAB REMITTENCE TEST | 44450361         21/05/15                 328.00             LKBX |

@winformsTest
@EnquiryTest
@DIV_A
@17124
@EN_E_DisplayActions
Scenario Outline: Test Case 17124: 01_IR Action for IRL tax details
	# Enquiry System -Action IR
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system for "I0010024978"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | IR    |
			| Locate Argument |       |
	Then In ENS01041 I should see IRL Taxpayer details Part1 as "<Key>" "<HIN>" "<HolderType>" "<TaxCode>" "<MailNameAddress1>" "<MailNameAddress2>" "<MailNameAddress3>" "<MailPostcode>" "<SCRIPNameAddress1>" "<SCRIPNameAddress22>" "<SCRIPNameAddress3>" "<SCRIPPostcode>" "<BenificialNameAddress1>" "<BenificialNameAddress2>" "<BenificialNameAddress3>" "<BenificialPostcode>"
		And In ENS01041 I should see IRL Taxpayer details Part2 as "<EntryType>" "<TaxNameAddress1>" "<TaxNameAddress2>" "<TaxNameAddress3>" "<TaxPostcode>" "<SigCapacityType>" "<SigCapacity>" "<DWTExpiry>" "<CertStatus>" "<CertStatusDesc>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | FIR   |
			| Locate Argument |       |
	Then In ENS01041 I should see IRL Taxpayer details Part1 as "<Key>" "<HIN>" "<HolderType>" "<TaxCode>" "<MailNameAddress1>" "<MailNameAddress2>" "<MailNameAddress3>" "<MailPostcode>" "<SCRIPNameAddress1>" "<SCRIPNameAddress22>" "<SCRIPNameAddress3>" "<SCRIPPostcode>" "<BenificialNameAddress1>" "<BenificialNameAddress2>" "<BenificialNameAddress3>" "<BenificialPostcode>"
		And In ENS01041 I should see IRL Taxpayer details Part2 as "<EntryType1>" "<TaxNameAddress1>" "<TaxNameAddress2>" "<TaxNameAddress3>" "<TaxPostcode>" "<SigCapacityType1>" "<SigCapacity1>" "<DWTExpiry>" "<CertStatus>" "<CertStatusDesc>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | FIR   |
			| Locate Argument |       |
	Then In ENS01041 I should see IRL Taxpayer details Part1 as "<Key>" "<HIN>" "<HolderType>" "<TaxCode>" "<MailNameAddress1>" "<MailNameAddress2>" "<MailNameAddress3>" "<MailPostcode>" "<SCRIPNameAddress1>" "<SCRIPNameAddress22>" "<SCRIPNameAddress3>" "<SCRIPPostcode>" "<BenificialNameAddress1>" "<BenificialNameAddress2>" "<BenificialNameAddress3>" "<BenificialPostcode>"
		And In ENS01041 I should see IRL Taxpayer details Part2 as "<EntryType1>" "<TaxNameAddress1>" "<TaxNameAddress2>" "<TaxNameAddress3>" "<TaxPostcode>" "<SigCapacityType1>" "<SigCapacity1>" "<DWTExpiry>" "<CertStatus>" "<CertStatusDesc>"
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | BIR   |
			| Locate Argument |       |
	Then In ENS01041 I should see IRL Taxpayer details Part1 as "<Key>" "<HIN>" "<HolderType>" "<TaxCode>" "<MailNameAddress1>" "<MailNameAddress2>" "<MailNameAddress3>" "<MailPostcode>" "<SCRIPNameAddress1>" "<SCRIPNameAddress22>" "<SCRIPNameAddress3>" "<SCRIPPostcode>" "<BenificialNameAddress1>" "<BenificialNameAddress2>" "<BenificialNameAddress3>" "<BenificialPostcode>"
		And In ENS01041 I should see IRL Taxpayer details Part2 as "<EntryType1>" "<TaxNameAddress1>" "<TaxNameAddress2>" "<TaxNameAddress3>" "<TaxPostcode>" "<SigCapacityType1>" "<SigCapacity1>" "<DWTExpiry>" "<CertStatus>" "<CertStatusDesc>"	
		
Examples: 
		| Key                     | HIN         | HolderType | TaxCode | MailNameAddress1        | MailNameAddress2 | MailNameAddress3 | MailPostcode | SCRIPNameAddress1       | SCRIPNameAddress2 | SCRIPNameAddress3 | SCRIPPostcode | BenificialNameAddress1  | BenificialNameAddress2 | BenificialNameAddress3 | BenificialPostcode | EntryType | TaxNameAddress1         | TaxNameAddress2 | TaxNameAddress3  | TaxPostcode | SigCapacityType | SigCapacity | DWTExpiry  | CertStatus | CertStatusDesc | EntryType1 | SigCapacityType1 | SigCapacity1   | SCRIPNameAddress22 |
		| ADFOHUKLO   CIFOHECIFGH | I0010024978 | IND        | AFG     | CIFOHE CIFGH ADFOHUKLO, | PO BOX 583       | CAIGH DAFGUJ NSW | IRL          | CIFOHE CIFGH ADFOHUKLO, | PO BOX 583        | CAIGH DAFGUJ NSW  | IRL           | CIFOHE CIFGH ADFOHUKLO, | PO BOX 583             | CAIGH DAFGUJ NSW       | IRL                | IND       | CIFOHE CIFGH ADFOHUKLO, | PO BOX 583      | CAIGH DAFGUJ NSW | IRL         | IND             | INDIVIDUAL  | 31/12/2018 | CRT        | CERTIFIED      | COY        | PUB              | PUBLIC OFFICER | TEST AUTOMATION    |

@winformsTest
@EnquiryTest
@NAB_AUTO
@17125
@EN_E_DisplayActions
Scenario: Test Case 17125: 02_ZA Action for ZAF tax details
	# Enquiry System -Action ZA
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0070036932"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | ZA    |
			| Locate Argument |       |
	Then  In ENS0104Z I should see ZAF Tax Payer details as below:
			| Field                  | Value                        |
			| Key                    | 3           TRANSACODE  TEST |
			| HIN                    | I0070036932                  |
			| InternalStatus         | REJ                          |
			| InternalStatusDesc     | REJECTED                     |
			| CustodianRef           | SAM                          |
			| TaxDomocile            | ZAF                          |
			| TradingName1           | TRANSACTION CODE TEST 3,     |
			| TradingName2           | TRANSACTION CODE TEST 3,     |
			| SCRIPNameAddress1      | TRANSACTION CODE TEST 3,     |
			| SCRIPNameAddress2      | TEST AUTOMATION             |
			| SCRIPNameAddress3      | ABBOTSFORD                   |
			| SCRIPPostcode          | 3000                         |
			| NaturePerson           | I                            |
			| NaturePersonDesc       | INDIVIDUAL                   |
			| ResNameAddress1        | TRANSACTION CODE TEST 3,     |
			| ResNameAddress2        | 452 JHONSTON ST,             |
			| ResNameAddress3        | ABBOTSFORD                   |
			| ResNameAddress4        | ABBOTSFORD                   |
			| ResNameAddress5        | ABBOTSFORD                   |
			| ResNameAddress6        | ABBOTSFORD                   |
			| ResPostcode            | 3000                         |
			| TaxRef                 | Quoted                       |
			| RefType                | TFN                          |
			| IdNo                   | 123456                       |
			| IdType                 | 001                          |
			| DateOfBirth            | 11/12/1985                   |
			| Phone                  | 0430834786                   |
			| Email                  | ARSHAD.SYED@YAHOO.COM        |
			| DeclarationName        | SYED ARSHAD                  |
			| DeclarationCapaciy     | BEN                          |
			| DeclarationCapaciyDesc | BENEFICIAL OWNER             |
			| Date                   | 11/05/2015                   |
			| PostalNameAddress1     | TRANSACTION CODE TEST 3,     |
			| PostalNameAddress2     | 452 JHONSTON ST,             |
			| PostalNameAddress3     | ABBOTSFORD                   |
			| PostalNameAddress4     | ABBOTSFORD                   |
			| PostalNameAddress5     | ABBOTSFORD                   |
			| PostalNameAddress6     | ABBOTSFORD                   |
			| PostalPostcode         | 3000                         |
			| ExemptionCode          | A                            |
			| ExemptionCodeDesc      | Resident Company             |
			| CountryOfPassport      | AUS                          |
			| CertStatus             | UNC                          |
			| CertStatusDesc         | UNCERTIFIED                  |
			| UndertakingName        | JHON                         |
			| UndertakingCapacty     | BEN                          |
			| UndertakingCapactyDesc | BENEFICIAL OWNER             |
			| UndertakingDate        | 11/05/2015                   |
			| SignatureDate          | 11/05/2015                   |

@winformsTest
@EnquiryTest
@DIV_A
@17127
@EN_E_DisplayActions
Scenario: Test Case 17127: 04_US/UT Action for US tax details for a holder having no controlling person/Beneficial owner
	# Enquiry System -Action UT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system for "I0000001333"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | UT    |
			| Locate Argument |       |
	Then In ENTUSA01 I should see US Tax Payer General Details as below:
			| Field             | Value                        |
			| Key               | 10A         TEST             |
			| HIN               | I0000001333                  |
			| Type              | IND                          |
			| WorstCaseInvestor | 1                            |
			| CuringStatus      |                              |
			| AccountType       | I                            |
			| PreExisting       | N                            |
			| USIndicia         | N                            |
			| USTaxCode         | AUS                          |
			| FATCAStatus       | 27                           |
			| ValueStatus       |                              |
			| NameAddress1      | Mr Test 10A                  |
			| NameAddress2      | TEST AUTOMATION              |
			| NameAddress3      | <ADAKW YIXOWQ RABIDGAPM A/C> |
			| NameAddress4      | PO BOX 4887                  |
			| NameAddress5      | NORTH RLFKIQ NSW 2059        |
			| NameAddress6      |                              |
			| Line              | NAME                         |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then I ENTUSA03 I should see US Tax payer Investor Details as below:
			| Key               | 10A         TEST                 |
			| HIN               | I0000001333                      |
			| Type              | IND                              |
			| WorstCaseInvestor | 1                                |
			| CuringStatus      |                                  |
			| AccountType       | I                                |
			| PreExisting       | N                                |
			| USIndicia         | N                                |
			| USTaxCode         | AUS                              |
			| FATCAStatus       | 27                               |
			| ValueStatus       |                                  |
			| NameAddress1      | Mr Test 10A                      |
			| NameAddress2      | TEST AUTOMATION                  |
			| NameAddress3      | <ADAKW YIXOWQ RABIDGAPM A/C>     |
			| NameAddress4      | PO BOX 4887                      |
			| NameAddress5      | NORTH RLFKIQ NSW 2059            |
			| NameAddress6      |                                  |
			| JntAccountType    | I                                |
			| Name              | NAME                             |
			| TINStatus         | 11                               |
			| TIN               |                                  |
			| InvUSTaxCode      | AUS                              |
			| FatcaStatus       | 27                               |
			| ConBenLit         | No Controlling persons available |

@winformsTest
@EnquiryTest
@DIV_A
@17128
@EN_E_DisplayActions
Scenario: Test Case 17128: 05_US/UT Action for US tax details for a holder having controlling person/Beneficial owner
	# Enquiry System -Action UT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "DIV_A"
		And I go to the Enquiry system for "X0017702912"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | UT    |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | C     |
			| Locate Argument |       |
	Then In ENTUSA04 I should see US Tax Payer Controlling Persons summary as below:
			| Field             | Value                          |
			| Key               | ADFGUJKL    CIFGOJDIFG  ADFGUJ |
			| HIN               | X0017702912                    |
			| Type              | JNT                            |
			| WorstCaseInvestor | 1                              |
			| CuringStatus      | N                              |
			| AccountType       | E                              |
			| PreExisting       | P                              |
			| USIndicia         | N                              |
			| USTaxCode         | AUS                            |
			| FATCAStatus       | 10                             |
			| ValueStatus       |                                |
			| NameAddress1      | MR CIFGOJ DIFG CAFUHJ          |
			| NameAddress2      | TEST AUTOMATION                     |
			| NameAddress3      | MRS CIFHEJIL CIEGH ADFGUJKL    |
			| NameAddress4      | <ADFGUJKL CIFOHJ CEFOH A/C>,   |
			| NameAddress5      | PO BOX 5617                    |
			| NameAddress6      | CAIGH CIFOHJIL VIC             |
			| InvName           | TEST INVESTOR 211              |
			| WC                | *                              |
			| InvestorType      | E                              |
			| TINStatus         | 18                             |
			| FATCA             | 10                             |
			| InvCntrl          | 1                              |
			| CntName           | TEST INVESTOR 211              |
			| CntCountry        | AUS                            |
			| CntCitizenship    | AUS                            |
			| CntCntrl          | Beneficial                     |
	When I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | 1     |
			| Locate Argument |       |
	Then In ENTUSA05 I should see US Tax Payer Controlling persons details as below:
			| Field             | Value                          |
			| Key               | ADFGUJKL    CIFGOJDIFG  ADFGUJ |
			| HIN               | X0017702912                    |
			| Type              | JNT                            |
			| WorstCaseInvestor | 1                              |
			| CuringStatus      | N                              |
			| AccountType       | E                              |
			| PreExisting       | P                              |
			| USIndicia         | N                              |
			| USTaxCode         | AUS                            |
			| FATCAStatus       | 10                             |
			| ValueStatus       |                                |
			| NameAddress1      | MR CIFGOJ DIFG CAFUHJ          |
			| NameAddress2      | TEST AUTOMATION                |
			| NameAddress3      | MRS CIFHEJIL CIEGH ADFGUJKL    |
			| NameAddress4      | <ADFGUJKL CIFOHJ CEFOH A/C>,   |
			| NameAddress5      | PO BOX 5617                    |
			| NameAddress6      | CAIGH CIFOHJIL VIC             |
			| InvName           | TEST INVESTOR 211              |
			| WC                | *                              |
			| InvestorType      | E                              |
			| TINStatus         | 18                             |
			| FATCA             | 10                             |
			| InvCntrl          | 1                              |
			| CntName           | TEST INVESTOR 211              |
			| CntAddress1       | ADDRESS LINE 1                 |
			| CntAddress2       | ADDRESS LINE 2                 |
			| CntAddress3       | ADDRESS LINE 3                 |
			| CntAddress4       | ADDRESS LINE 4                 |
			| CntAddress5       | ADDRESS LINE 5                 |
			| CntlPostCode      | 3190                           |
			| CntCountry        | AUS                            |
			| CntCitizenship    | AUS                            |
			| CntTaxIdentifier  | Not Quoted                     |
			| CntTIN            |                                |
			| CntUSTaxCode      | AUS                            |
			| CntGINN-P1        | 06FJHZ                         |
			| CntGINN-P2        | 99999                          |
			| CntGINN-P3        | SL                             |
			| CntGINN-P4        | 036                            |
			| CntDateofBirth    | No date                        |
			| CntTINStatus      | 18                             |
			| FatcaStatus       | 10                             |
			| CntW8ExpiryDate   | 31/12/2018                     |
			| GINNException     |                                |

@winformsTest
@EnquiryTest	
@NAB_AUTO
@17985
@EN_E_DisplayActions
Scenario: Test Case 17985: 01_Main Menu
	# Enquiry System -Action SL
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And In MNS00101 I click on: "Enquiry System" within the System Menu
	Then I expect to be in the "ENS00101" Screen
	When In ENS00101 I click on: "exit enquiry" within the Enquiry System Menu
	Then I expect to be in the "MNS00101" Screen
	When I enter following details in Service Level Reporting Details:
			| Field          | Value  |
			| ServiceProvide |        |
			| ServiceCode    | SPECLS |
	Then In SELPRV01 I should see Select Service Provide details as below:
			| Field         | Value                           |
			| Provider1     | ***                             |
			| Provider1Desc | Unknown service provider        |
			| Provider2     | CAS                             |
			| Provider2Desc | Computershare Analytics         |
			| Provider3     | CDS                             |
			| Provider3Desc | Computershare Document Services |
			| Provider4     | CIS                             |
			| Provider4Desc | Computershare Investor Services |
			| Provider5     | CPM                             |
			| Provider5Desc | Computershare Plan Managers     |
			| Provider6     | CRM                             |
			| Provider6Desc | CRM                             |
			| Provider7     | CSL                             |
			| Provider7Desc | Computershare Limited           |
	When I enter following details in Service Level Reporting Details:
			| Field          | Value |
			| ServiceProvide | CAS   |
			| ServiceCode    |       |
	Then In SELSRV01 I should see Select Service Provide details as below:
			| Field        | Value           |
			| Service1     | ******          |
			| Service1Desc | unknown service |
			| Service2     |                 |
			| Service2Desc |                 |

@winformsTest
@EnquiryTest
@NAB_AUTO
@18148
@EN_E_DisplayActions
Scenario: Test Case 18148: 01_Email Addresses (LEML Action)
	# Enquiry System -Action LEML
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value                     |
			| Action          | LEML                      |
			| Locate Argument | TEST@COMPUTERSHARE.COM.AU |
	Then In ENS01039 I should see multiple holder details for supplied email as below:
			| Field         | Value                        |
			| EmailInput    | TEST@COMPUTERSHARE.COM.AU    |
			| HIN1          | I0070036916                  |
			| HIN2          | I0070036924                  |
			| HIN3          | I0070036932                  |
			| HIN4          | X0054356552                  |
			| NameLine1     | ESTATE LATE TRANSACTION CODE |
			| NameLine2     | TRANSACTION CODE TEST 2,     |
			| NameLine3     | TRANSACTION CODE TEST 3,     |
			| NameLine4     | A & G ROBERTS PTY LTD        |
			| AddressLine1  | TEST AUTOMATION              |
			| AddressLine2  | TEST AUTOMATION             |
			| AddressLine3  | TEST AUTOMATION             |
			| AddressLine4  | TEST AUTOMATION              |
			| PostcodeLine1 | 3000                         |
			| PostcodeLine2 | 3000                         |
			| PostcodeLine3 | 3000                         |
			| PostcodeLine4 | 3205                         |

@winformsTest
@EnquiryTest			
@CPU_AUTO
@18165
@EN_E_DisplayActions
Scenario: Test Case 18165: 01_Company Notice and Comms (NOT action)
	# Enquiry System -Action NOT
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "CPU_AUTO"
		And I go to Holder Enquiry System
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | NOT   |
			| Locate Argument |       |
	Then In ENS01050 I should see Company Notice as below:
			| Field         | Value                             |
			| BookCloseDate | 03/03/2014                        |
			| NoticeLine1   | **** AUTOMATION TEST COMPANY **** |
			| NoticeLine2   | DO NOT MAKE ANY CHANGES           |
			| NoticeLine3   | CONTACT SAM JOUBRAN               |

@winformsTest
@EnquiryTest
@NAB_AUTO
@18422_01
@EN_E_DisplayActions
Scenario Outline: Test Case 18422: 01_Certs with Last Txn Details
	# Enquiry System -Action E EB EC EM EMB ECB
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009906408"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01042 I should see Certificate Details as "<HIN>" "<Line1>" "<Line2Part1>" "<Line3Part1>" "<Line4Part1>" "<Line5Part1>" "<Line6Part1>" "<Line7Part1>" "<Line8Part1>" "<Line9Part1>" "<Line10Part1>" "<Line11Part1>" "<Line12Part1>" "<Line13Part1>"
		And In ENS01042 I should see Certificate Details as "<HIN>" "<Line1>" "<Line2Part2>" "<Line3Part2>" "<Line4Part2>" "<Line5Part2>" "<Line6Part2>" "<Line7Part2>" "<Line8Part2>" "<Line9Part2>" "<Line10Part2>" "<Line11Part2>" "<Line12Part2>" "<Line13Part2>"
		
Examples: 
		| Action | LocateArgument | HIN         | Line1                        | Line2Part1                              | Line3Part1                              | Line4Part1                              | Line5Part1                              | Line6Part1                              | Line7Part1                              | Line8Part1                              | Line9Part1                              | Line10Part1                             | Line11Part1                             | Line12Part1                             | Line13Part1                             | Line2Part2                                  | Line3Part2                                 | Line4Part2                                  | Line5Part2                                 | Line6Part2                                 | Line7Part2                                 | Line8Part2                                 | Line9Part2                                 | Line10Part2                                | Line11Part2                                | Line12Part2                                | Line13Part2                                |
		| E      |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00000001     08/05/15             0 | VIC 00123456ST01 16/06/15             2 | VIC 00123456ST02 16/06/15             2 | VIC 00123456ST03 16/06/15             2 | VIC 00123456ST04 16/06/15             2 | VIC 00123456ST05 16/06/15             2 | VIC 00123456ST06 16/06/15             2 | VIC 00123456ST07 16/06/15             2 | VIC 00123456ST08 16/06/15             2 | VIC 00123456ST09 16/06/15             2 | VIC 00123456ST10 16/06/15             2 | VIC 00123456ST11 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555           100- | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| EB     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00123456ST01 16/06/15             2 | VIC 00123456ST02 16/06/15             2 | VIC 00123456ST03 16/06/15             2 | VIC 00123456ST04 16/06/15             2 | VIC 00123456ST05 16/06/15             2 | VIC 00123456ST06 16/06/15             2 | VIC 00123456ST07 16/06/15             2 | VIC 00123456ST08 16/06/15             2 | VIC 00123456ST09 16/06/15             2 | VIC 00123456ST10 16/06/15             2 | VIC 00123456ST11 16/06/15             2 | VIC 00123456ST12 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| EC     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00000001     08/05/15             0 | CAC/ACCEPTANCE CPS II 2013              | VIC 00000001     08/05/15             0 | CEN/ENTITLEMENT CPS II 2013             | VIC 00100003     08/05/15           350 | DAM/EMPLOYEE TRUST HELD SHARES          | VIC 00000001     08/05/15           100 | DIM/EMPLOYEE TRUST HELD SHARES          | VIC 00000001     08/05/15           100 | F14/EMPLOYEE TRUST HELD SHARES          | VIC 00000001     08/05/15           100 | ORD/ORDINARY FULLY PAID SHARES          | 16/06/15 MRKNG 7650/ 5555555           100- | CAC/ACCEPTANCE CPS II 2013                 | 16/06/15 MRKNG 7650/ 1111111           100- | CEN/ENTITLEMENT CPS II 2013                | 08/05/15 CAPIN 7650/  258988           200 | DAM/EMPLOYEE TRUST HELD SHARES             | 08/05/15 CAPIN 7650/  258993           100 | DIM/EMPLOYEE TRUST HELD SHARES             | 08/05/15 CAPIN 7650/  258994           100 | F14/EMPLOYEE TRUST HELD SHARES             | 08/05/15 CAPIN 7650/  258995           100 | ORD/ORDINARY FULLY PAID SHARES             |
		| EM     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00123456ST01 16/06/15             2 | VIC 00123456ST02 16/06/15             2 | VIC 00123456ST03 16/06/15             2 | VIC 00123456ST04 16/06/15             2 | VIC 00123456ST05 16/06/15             2 | VIC 00123456ST06 16/06/15             2 | VIC 00123456ST07 16/06/15             2 | VIC 00123456ST08 16/06/15             2 | VIC 00123456ST09 16/06/15             2 | VIC 00123456ST10 16/06/15             2 | VIC 00123456ST11 16/06/15             2 | VIC 00123456ST12 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| EMB    |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00123456ST01 16/06/15             2 | VIC 00123456ST02 16/06/15             2 | VIC 00123456ST03 16/06/15             2 | VIC 00123456ST04 16/06/15             2 | VIC 00123456ST05 16/06/15             2 | VIC 00123456ST06 16/06/15             2 | VIC 00123456ST07 16/06/15             2 | VIC 00123456ST08 16/06/15             2 | VIC 00123456ST09 16/06/15             2 | VIC 00123456ST10 16/06/15             2 | VIC 00123456ST11 16/06/15             2 | VIC 00123456ST12 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2  | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| ECB    |                | C0009906408 | CEN/ENTITLEMENT CPS II 2013  | VIC 00100003     08/05/15           350 | DAM/EMPLOYEE TRUST HELD SHARES          | VIC 00000001     08/05/15           100 | DIM/EMPLOYEE TRUST HELD SHARES          | VIC 00000001     08/05/15           100 | F14/EMPLOYEE TRUST HELD SHARES          | VIC 00000001     08/05/15           100 | ORD/ORDINARY FULLY PAID SHARES          | VIC  A296042     08/05/15           100 | ZZZ/SHAREHOLDER CARD                    | VIC 00954563     08/05/15           100 |                                         | 08/05/15 CAPIN 7650/  258988           200  | DAM/EMPLOYEE TRUST HELD SHARES             | 08/05/15 CAPIN 7650/  258993           100  | DIM/EMPLOYEE TRUST HELD SHARES             | 08/05/15 CAPIN 7650/  258994           100 | F14/EMPLOYEE TRUST HELD SHARES             | 08/05/15 CAPIN 7650/  258995           100 | ORD/ORDINARY FULLY PAID SHARES             | 08/05/15 CTIND 7653/ 6666666             0 | ZZZ/SHAREHOLDER CARD                       | 08/05/15 CAPIN 7650/  258991           100 |                                            |                                                  

@winformsTest
@EnquiryTest
@NAB_AUTO
@17277_02
@EN_E_DisplayActions
Scenario Outline: Test Case 18422: 02_Certs with Last Txn Details-more option
	# Enquiry System -Action E EB EC EM EMB ECB
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009906408"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	Then In ENS01042 I should see Certificate Details as "<HIN>" "<Line1>" "<Line2Part1>" "<Line3Part1>" "<Line4Part1>" "<Line5Part1>" "<Line6Part1>" "<Line7Part1>" "<Line8Part1>" "<Line9Part1>" "<Line10Part1>" "<Line11Part1>" "<Line12Part1>" "<Line13Part1>"
		And In ENS01042 I should see Certificate Details as "<HIN>" "<Line1>" "<Line2Part2>" "<Line3Part2>" "<Line4Part2>" "<Line5Part2>" "<Line6Part2>" "<Line7Part2>" "<Line8Part2>" "<Line9Part2>" "<Line10Part2>" "<Line11Part2>" "<Line12Part2>" "<Line13Part2>"
		
Examples: 
		| Action | LocateArgument | HIN         | Line1                                     | Line2Part1                              | Line3Part1                              | Line4Part1                              | Line5Part1                              | Line6Part1                              | Line7Part1                              | Line8Part1                              | Line9Part1                              | Line10Part1                             | Line11Part1                             | Line12Part1                             | Line13Part1                             | Line2Part2                                 | Line3Part2                                 | Line4Part2                                 | Line5Part2                                 | Line6Part2                                 | Line7Part2                                 | Line8Part2                                 | Line9Part2                                 | Line10Part2                                | Line11Part2                                | Line12Part2                                | Line13Part2                                |
		| E      |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST12 16/06/15             2 | VIC 00123456ST13 16/06/15             2 | VIC 00123456ST14 16/06/15             2 | VIC 00123456ST15 16/06/15             2 | VIC 00123456ST16 16/06/15             2 | VIC 00123456ST17 16/06/15             2 | VIC 00123456ST18 16/06/15             2 | VIC 00123456ST19 16/06/15             2 | VIC 00123456ST20 16/06/15             2 | VIC 00123456ST21 16/06/15             2 | VIC 00123456ST22 16/06/15             2 | VIC 00123456ST23 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| EB     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST13 16/06/15             2 | VIC 00123456ST14 16/06/15             2 | VIC 00123456ST15 16/06/15             2 | VIC 00123456ST16 16/06/15             2 | VIC 00123456ST17 16/06/15             2 | VIC 00123456ST18 16/06/15             2 | VIC 00123456ST19 16/06/15             2 | VIC 00123456ST20 16/06/15             2 | VIC 00123456ST21 16/06/15             2 | VIC 00123456ST22 16/06/15             2 | VIC 00123456ST23 16/06/15             2 | VIC 00123456ST24 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| EC     |                | C0009906408 | ORD/ORDINARY FULLY PAID SHARES     Cont'd | VIC  A296042     08/05/15           100 | ZZZ/SHAREHOLDER CARD                    | VIC 00954563     08/05/15           100 |                                         |                                         |                                         |                                         |                                         |                                         |                                         |                                         |                                         | 08/05/15 CTIND 7653/ 6666666             0 | ZZZ/SHAREHOLDER CARD                       | 08/05/15 CAPIN 7650/  258991           100 |                                            |                                            |                                            |                                            |                                            |                                            |                                            |                                            |                                            |
		| EM     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST13 16/06/15             2 | VIC 00123456ST14 16/06/15             2 | VIC 00123456ST15 16/06/15             2 | VIC 00123456ST16 16/06/15             2 | VIC 00123456ST17 16/06/15             2 | VIC 00123456ST18 16/06/15             2 | VIC 00123456ST19 16/06/15             2 | VIC 00123456ST20 16/06/15             2 | VIC 00123456ST21 16/06/15             2 | VIC 00123456ST22 16/06/15             2 | VIC 00123456ST23 16/06/15             2 | VIC 00123456ST24 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |
		| EMB    |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST13 16/06/15             2 | VIC 00123456ST14 16/06/15             2 | VIC 00123456ST15 16/06/15             2 | VIC 00123456ST16 16/06/15             2 | VIC 00123456ST17 16/06/15             2 | VIC 00123456ST18 16/06/15             2 | VIC 00123456ST19 16/06/15             2 | VIC 00123456ST20 16/06/15             2 | VIC 00123456ST21 16/06/15             2 | VIC 00123456ST22 16/06/15             2 | VIC 00123456ST23 16/06/15             2 | VIC 00123456ST24 16/06/15             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 | 16/06/15 MRKNG 7650/ 5555555             2 |  

@winformsTest
@EnquiryTest
@NAB_AUTO
@18464_01
@EN_E_DisplayActions
Scenario Outline: Test Case 18464: 01_Certificate Options actions
	# Enquiry System -Action CB CC CM CMB CCB
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009906408"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then In ENS01012 I should see Certificate details as "<HIN>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>"

Examples: 
		| Action | LocateArgument | HIN         | Line1                        | Line2                                                                               | Line3                                                                               | Line4                                                                               | Line5                                                                               | Line6                                                                               | Line7                                                                               | Line8                                                                               | Line9                                                                               | Line10                                                                              | Line11                                                                              | Line12                                                                              | Line13                                                                              |
		| CB     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00123456ST01 16/06/15             2    VIC 00123456ST02 16/06/15              2 | VIC 00123456ST03 16/06/15             2    VIC 00123456ST04 16/06/15              2 | VIC 00123456ST05 16/06/15             2    VIC 00123456ST06 16/06/15              2 | VIC 00123456ST07 16/06/15             2    VIC 00123456ST08 16/06/15              2 | VIC 00123456ST09 16/06/15             2    VIC 00123456ST10 16/06/15              2 | VIC 00123456ST11 16/06/15             2    VIC 00123456ST12 16/06/15              2 | VIC 00123456ST13 16/06/15             2    VIC 00123456ST14 16/06/15              2 | VIC 00123456ST15 16/06/15             2    VIC 00123456ST16 16/06/15              2 | VIC 00123456ST17 16/06/15             2    VIC 00123456ST18 16/06/15              2 | VIC 00123456ST19 16/06/15             2    VIC 00123456ST20 16/06/15              2 | VIC 00123456ST21 16/06/15             2    VIC 00123456ST22 16/06/15              2 | VIC 00123456ST23 16/06/15             2    VIC 00123456ST24 16/06/15              2 |
		| CC     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00000001     08/05/15             0                                             | CAC/ACCEPTANCE CPS II 2013                                                          | VIC 00000001     08/05/15             0                                             | CEN/ENTITLEMENT CPS II 2013                                                         | VIC 00100003     08/05/15           350                                             | DAM/EMPLOYEE TRUST HELD SHARES                                                      | VIC 00000001     08/05/15           100                                             | DIM/EMPLOYEE TRUST HELD SHARES                                                      | VIC 00000001     08/05/15           100                                             | F14/EMPLOYEE TRUST HELD SHARES                                                      | VIC 00000001     08/05/15           100                                             | ORD/ORDINARY FULLY PAID SHARES                                                      |
		| CM     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00123456ST01 16/06/15             2    VIC 00123456ST02 16/06/15              2 | VIC 00123456ST03 16/06/15             2    VIC 00123456ST04 16/06/15              2 | VIC 00123456ST05 16/06/15             2    VIC 00123456ST06 16/06/15              2 | VIC 00123456ST07 16/06/15             2    VIC 00123456ST08 16/06/15              2 | VIC 00123456ST09 16/06/15             2    VIC 00123456ST10 16/06/15              2 | VIC 00123456ST11 16/06/15             2    VIC 00123456ST12 16/06/15              2 | VIC 00123456ST13 16/06/15             2    VIC 00123456ST14 16/06/15              2 | VIC 00123456ST15 16/06/15             2    VIC 00123456ST16 16/06/15              2 | VIC 00123456ST17 16/06/15             2    VIC 00123456ST18 16/06/15              2 | VIC 00123456ST19 16/06/15             2    VIC 00123456ST20 16/06/15              2 | VIC 00123456ST21 16/06/15             2    VIC 00123456ST22 16/06/15              2 | VIC 00123456ST23 16/06/15             2    VIC 00123456ST24 16/06/15              2 |
		| CMB    |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS | VIC 00123456ST01 16/06/15             2    VIC 00123456ST02 16/06/15              2 | VIC 00123456ST03 16/06/15             2    VIC 00123456ST04 16/06/15              2 | VIC 00123456ST05 16/06/15             2    VIC 00123456ST06 16/06/15              2 | VIC 00123456ST07 16/06/15             2    VIC 00123456ST08 16/06/15              2 | VIC 00123456ST09 16/06/15             2    VIC 00123456ST10 16/06/15              2 | VIC 00123456ST11 16/06/15             2    VIC 00123456ST12 16/06/15              2 | VIC 00123456ST13 16/06/15             2    VIC 00123456ST14 16/06/15              2 | VIC 00123456ST15 16/06/15             2    VIC 00123456ST16 16/06/15              2 | VIC 00123456ST17 16/06/15             2    VIC 00123456ST18 16/06/15              2 | VIC 00123456ST19 16/06/15             2    VIC 00123456ST20 16/06/15              2 | VIC 00123456ST21 16/06/15             2    VIC 00123456ST22 16/06/15              2 | VIC 00123456ST23 16/06/15             2    VIC 00123456ST24 16/06/15              2 |
		| CCB    |                | C0009906408 | CEN/ENTITLEMENT CPS II 2013  | VIC 00100003     08/05/15           350                                             | DAM/EMPLOYEE TRUST HELD SHARES                                                      | VIC 00000001     08/05/15           100                                             | DIM/EMPLOYEE TRUST HELD SHARES                                                      | VIC 00000001     08/05/15           100                                             | F14/EMPLOYEE TRUST HELD SHARES                                                      | VIC 00000001     08/05/15           100                                             | ORD/ORDINARY FULLY PAID SHARES                                                      | VIC  A296042     08/05/15           100 1                                           | ZZZ/SHAREHOLDER CARD                                                                | VIC 00954563     08/05/15           100                                             |                                                                                     |

@winformsTest
@EnquiryTest
@NAB_AUTO
@18464_02
@EN_E_DisplayActions
Scenario Outline: Test Case 18464: 01_Certificate Options actions_more option
	# Enquiry System -Action CB CC CM CMB CCB
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "C0009906408"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And I enter the following details as the Locate action:
			| Field           | Value |
			| Action          | M     |
			| Locate Argument |       |
	Then In ENS01012 I should see Certificate details as "<HIN>" "<Line1>" "<Line2>" "<Line3>" "<Line4>" "<Line5>" "<Line6>" "<Line7>" "<Line8>" "<Line9>" "<Line10>" "<Line11>" "<Line12>" "<Line13>"

Examples: 
		| Action | LocateArgument | HIN         | Line1                                     | Line2                                                                               | Line3                                                                               | Line4                                                                               | Line5                                                                               | Line6                                                                               | Line7                                                                               | Line8                                                                               | Line9                                                                               | Line10                                                                              | Line11                                                                              | Line12                                                                              | Line13                                                                              |
		| CB     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST25 16/06/15             2    VIC 00123456ST26 16/06/15              2 | VIC 00123456ST27 16/06/15             2    VIC 00123456ST28 16/06/15              2 | VIC 00123456ST29 16/06/15             2    VIC 00123456ST30 16/06/15              2 | VIC 00123456ST31 16/06/15             2    VIC 00123456ST32 16/06/15              2 | VIC 00123456ST33 16/06/15             2    VIC 00123456ST34 16/06/15              2 | VIC 00123456ST35 16/06/15             2    VIC 00123456ST36 16/06/15              2 | VIC 00123456ST37 16/06/15             2    VIC 00123456ST38 16/06/15              2 | VIC 00123456ST39 16/06/15             2    VIC 00123456ST40 16/06/15              2 | VIC 00123456ST41 16/06/15             2    VIC 00123456ST42 16/06/15              2 | VIC 00123456ST43 16/06/15             2    VIC 00123456ST44 16/06/15              2 | VIC 00123456ST45 16/06/15             2    VIC 00123456ST46 16/06/15              2 | VIC 00123456ST47 16/06/15             2    VIC 00123456ST48 16/06/15              2 |
		| CC     |                | C0009906408 | ORD/ORDINARY FULLY PAID SHARES     Cont'd | VIC  A296042     08/05/15           100 1                                           | ZZZ/SHAREHOLDER CARD                                                                | VIC 00954563     08/05/15           100                                             |                                                                                     |                                                                                     |                                                                                     |                                                                                     |                                                                                     |                                                                                     |                                                                                     |                                                                                     |                                                                                     |
		| CM     |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST25 16/06/15             2    VIC 00123456ST26 16/06/15              2 | VIC 00123456ST27 16/06/15             2    VIC 00123456ST28 16/06/15              2 | VIC 00123456ST29 16/06/15             2    VIC 00123456ST30 16/06/15              2 | VIC 00123456ST31 16/06/15             2    VIC 00123456ST32 16/06/15              2 | VIC 00123456ST33 16/06/15             2    VIC 00123456ST34 16/06/15              2 | VIC 00123456ST35 16/06/15             2    VIC 00123456ST36 16/06/15              2 | VIC 00123456ST37 16/06/15             2    VIC 00123456ST38 16/06/15              2 | VIC 00123456ST39 16/06/15             2    VIC 00123456ST40 16/06/15              2 | VIC 00123456ST41 16/06/15             2    VIC 00123456ST42 16/06/15              2 | VIC 00123456ST43 16/06/15             2    VIC 00123456ST44 16/06/15              2 | VIC 00123456ST45 16/06/15             2    VIC 00123456ST46 16/06/15              2 | VIC 00123456ST47 16/06/15             2    VIC 00123456ST48 16/06/15              2 |
		| CMB    |                | C0009906408 | A11/ISX0011 ACCEPTANCE CLASS       Cont'd | VIC 00123456ST25 16/06/15             2    VIC 00123456ST26 16/06/15              2 | VIC 00123456ST27 16/06/15             2    VIC 00123456ST28 16/06/15              2 | VIC 00123456ST29 16/06/15             2    VIC 00123456ST30 16/06/15              2 | VIC 00123456ST31 16/06/15             2    VIC 00123456ST32 16/06/15              2 | VIC 00123456ST33 16/06/15             2    VIC 00123456ST34 16/06/15              2 | VIC 00123456ST35 16/06/15             2    VIC 00123456ST36 16/06/15              2 | VIC 00123456ST37 16/06/15             2    VIC 00123456ST38 16/06/15              2 | VIC 00123456ST39 16/06/15             2    VIC 00123456ST40 16/06/15              2 | VIC 00123456ST41 16/06/15             2    VIC 00123456ST42 16/06/15              2 | VIC 00123456ST43 16/06/15             2    VIC 00123456ST44 16/06/15              2 | VIC 00123456ST45 16/06/15             2    VIC 00123456ST46 16/06/15              2 | VIC 00123456ST47 16/06/15             2    VIC 00123456ST48 16/06/15              2 |


#@ignore
#@NAB_AUTO
#@18399
#@EN_E_DisplayActions
#Scenario: Test Case 18399: 01_Extract Options (SEF and X actions)
#	# Enquiry System -Action A
#	Given I have connected to WinForms
#	When In SELCOY01 I select the company: "NAB_AUTO"
#		And I go to Holder Enquiry System
#		And I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | SEF   |
#			| Locate Argument |       |
#	Then I expect to be in the "ENS01086" Screen
#	When In ENS01086 I Enter Surfix as "123"
#	Then I expect to be in the "ENS01087" Screen
#	When I Transmit
#	Then I expect to be in the "ENS01090" Screen
#		And I enter the following details as the Locate action:
#			| Field           | Value       |
#			| Action          | S           |
#			| Locate Argument | C0009913176 |
#	When I enter the following details as the Locate action:
#			| Field           | Value |
#			| Action          | X     |
#			| Locate Argument |       |
#	Then In ENS01088 I should see Update extract details as below:
#			| Field       | Value        |
#			| HIN         | C0009913176  |
#			| ExtractFile | X.XTRACT.123 |
#	When I Transmit
#	Then I expect to be in the "ENS01001" Screen
#		And I close Winforms
#	When I have connected to the Backend
#	Then I compare the new Temp file "DATADISK65:[COMPANY.NAB_AUTO]XTRACT_123.TEMP;1" with Base file "DATADISK65:[COMPANY.NAB_AUTO.REPORTS]XTRACT_123.TEMP;1" in VMS
#	And In VMS I expect to see the following:
#              | Pass Criteria                          | Timeout  |
#              | Number of difference sections found: 0 | 00:00:50 |
#              | Number of difference records found: 0  | 00:00:50 |

@winformsTest
@EnquiryTest
@NAB_AUTO
@20770_01
@EN_E_DisplayActions
Scenario Outline: Test Case 20770_01: 01_US Tax Enquiry - LS Action-Test1
	# Enquiry System -Action LS 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0034317747"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSSUS03 I should see Static Transaction details as "<Tran>" "<TranDesc>" "<OldName>" "<OldAddress1>" "<OldAddress2>" "<OldAddress3>" "<OldPostcode>" "<OldCountry>" "<OldTIN>" "<NewName>" "<NewAddress1>" "<NewAddress2>" "<NewAddress3>" "<NewPostcode>" "<NewCountry>" "<NewTIN>" 

Examples: 
	| LocateArgument | Action | Action1 | LocateArgument1 | Tran  | TranDesc               | OldName       | OldAddress1 | OldAddress2 | OldAddress3 | OldPostcode | OldCountry | OldTIN      | NewName       | NewAddress1 | NewAddress2 | NewAddress3 | NewPostcode | NewCountry | NewTIN      |
	| I0034317747    | S      | LS      | 7652/9877       | UICHG | US TAX STATUS (CHANGE) | MARY MARGARET | 1234        | BOURKE ST   | MELBOURNE   | 3000        | AUS        | *******-129 | MARY MARGARET | 123         | BOURKE ST   | MELBOURNE   | 3000        | AUS        | *******-129 |


@DataChange
@NAB_AUTO
@20770_02
@EN_E_DisplayActions
Scenario Outline: Test Case 20770_02: 01_US Tax Enquiry - LS Action-Test2
	# Enquiry System -Action LS 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0034317747"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
		And I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then In ENSSTM34 I should see Static Transaction details as "<Run>" "<Tran>" "<Date>" "<TranCode>" "<TranDesc>" "<Reference>"
	#Need to Chnage Test Data
Examples: 
	| LocateArgument | Action | Action1 | LocateArgument1 | Run  | Tran    | Date       | TranCode | TranDesc                       | Reference  |
	| I0034317747    | S      | LS      |                 | 7655 | 4167473 | 14/07/2015 | INFCH    | FREE FORM INFORMATION (CHANGE) | WEB_ACCESS |

@winformsTest
@EnquiryTest
@NAB_AUTO
@20825
@EN_E_DisplayActions
Scenario Outline: Test Case 20825: 02_US Tax Enquiry - Dividend History
	# Enquiry System -Action LS 
	Given I have connected to WinForms
	When In SELCOY01 I select the company: "NAB_AUTO"
		And I go to the Enquiry system for "I0033314515"
		And I enter the following details as the locatActions "<Action>"  "<LocateArgument>"
	Then I expect to be in the "ENSDIV01" Screen
	When I enter the following details as the locatActions "<Action1>"  "<LocateArgument1>"
	Then I expect to be in the "ENSDIV02" Screen
	When I enter the following details as the locatActions "<Action2>"  "<LocateArgument1>"
	Then In ENSDIV20 I should see US Tax Details as "<Res>"


Examples: 
	| Action | LocateArgument | Action1 | LocateArgument1 | Action2 | Res          |
	| DH     | I0033314515    | 1       |                 | >       | Non-resident |
