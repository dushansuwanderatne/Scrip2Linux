Feature: HK_ESS_Setups

@winformsTest
@HK_ESS_Setups
@28329
@NAB2_AUTO
@FullSmokeTest
Scenario Outline: Test Case 28329: AESS Plan Setup -[Add/View]
	# Add Deferred and Exempt Plan Setup
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "Plan Setup" Option
		And In EHK01002 I Add Plan Setup Details as "<ClassCode>" "<SchemeType>" "<ClassDescription>"
		And In EHK01003 I Add ESS Plan Steup Details as "<FinalSecurity>" "<CountryOFTaxation>" "<PlanType>" "<TrusteeAccountID>" "<UnapAccountID>" "<BlkoutPeriodInd>" "<MatchWorkingClass>" "<MarketValueInd>" "<TaxTypeInd>" "<SingleCert>" "<ForfeitureType>" "<AutoForfeit>" "<DivReinvestment>" "<PlanConcept>" "<PlanCategory>" "<LeaverPackInd>" "<RetirementAge>"

Examples: 
	| Plan     | COY      | ClassCode | SchemeType | ClassDescription    | FinalSecurity | CountryOFTaxation | PlanType | TrusteeAccountID | UnapAccountID | BlkoutPeriodInd | MatchWorkingClass | MarketValueInd | TaxTypeInd | SingleCert | ForfeitureType | AutoForfeit | DivReinvestment | PlanConcept | PlanCategory | LeaverPackInd | RetirementAge |
	| Deferred | NAB2_AUTO | DEP       | A          | DEP AUTOMATION TEST | ORD           | AUS               | T        | I0035246321      | I0035505393   | Y               |                   | V              | D          | 99999999   | L              | Y           | I               | DRP         | 4            | Y             | 65            |
	| Exempt   | NAB2_AUTO | EXA       | A          | EXE AUTOMATION TEST | ORD           | AUS               | T        | I0035509801      | I0035611576   | Y               |                   | V              | X          | 99999999   | L              | Y           | I               | DRP         | 4            | Y             | 65            |

@winformsTest
@HK_ESS_Setups
@28332
@NAB2_AUTO
Scenario Outline: Test Case 28332: Executive Option Plan Setup -[Add/View]
	# Add Options and Rights Plan Setup
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "Plan Setup" Option
		And In EHK01002 I Add Plan Setup Details as "<ClassCode>" "<SchemeType>" "<ClassDescription>"
		And In EHK01005 I Add Executive Options Plan Steup Details as "<FinalSecurity>" "<CountryOFTaxation>" "<PlanType>" "<TrusteeAccountID>" "<UnapAccountID>" "<BlkoutPeriodInd>" "<MarketValueInd>" "<NilCostOptionInd>" "<PhantomOptionInd>" "<ONMktPurchInd>" "<VsaXferAllowedInd>" "<LeaverPackInd>" "<ExpiryNoticeINUrr>"

Examples: 
	| Plan    | COY      | ClassCode | SchemeType | ClassDescription    | FinalSecurity | CountryOFTaxation | PlanType | TrusteeAccountID | UnapAccountID | BlkoutPeriodInd | MarketValueInd | NilCostOptionInd | PhantomOptionInd | ONMktPurchInd | VsaXferAllowedInd | LeaverPackInd | ExpiryNoticeINUrr |
	| Options | NAB2_AUTO | OP1       | E          | OP1 AUTOMATION TEST | ORD           | AUS               | N        | I0035611584      | I0035683631   | N               | V              | N                | N                | N             | N                 | Y             | N                 |                
	| Rights  | NAB2_AUTO | OP2       | E          | OP2 AUTOMATION TEST | ORD           | AUS               | N        | I0035683640      | I0035683658   | N               | V              | Y                | Y                | N             | N                 | Y             | N                 |                

@winformsTest
@HK_ESS_Setups
@28331
@NAB2_AUTO
Scenario Outline: Test Case 28331: Loan Plan Setup -[Add/View]
	# Add Loan Plan Setup
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "Plan Setup" Option
		And In EHK01002 I Add Plan Setup Details as "<ClassCode>" "<SchemeType>" "<ClassDescription>"
		And In EHK01004 I Add Loan Plan Steup Details as "<FinalSecurity>" "<CountryOFTaxation>" "<PlanType>" "<TrusteeAccountID>" "<UnapAccountID>" "<BlkoutPeriodInd>" "<UseBlkoutCodeInd>" "<BlkoutCode>" "<MarketValueInd>" "<PaymentType1>" "<PaymentType2>" "<PaymentType3>" "<LoanDividendOption>" "<MaxLimitAmount>" "<LimitType>" "<LeaverPackInd>"

Examples: 
	| Plan | COY      | ClassCode | SchemeType | ClassDescription    | FinalSecurity | CountryOFTaxation | PlanType | TrusteeAccountID | UnapAccountID | BlkoutPeriodInd | UseBlkoutCodeInd | BlkoutCode | MarketValueInd | PaymentType1 | PaymentType2 | PaymentType3 | LoanDividendOption | MaxLimitAmount | LimitType | LeaverPackInd |
	| Loan | NAB2_AUTO | LON       | L          | LON AUTOMATION TEST | ORD           | AUS               | N        | I0035683674      | I0035683682   | Y               | Y                | 009        | V              | D            | C            | A            |                    |                |           | Y             |

@winformsTest
@HK_ESS_Setups
@28461
@NAB2_AUTO
Scenario Outline: Test Case 28461: AESS Award Setup (EB) -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "award setup" Option
		And In EHK010MN I Select "ATS" Plan
		And In EHK01008 I Add Award Setup Details as "<RegisterType2>"
		And In EHK01007 I Add ESS Award Setup Details1 as "<RegisterCode>" "<RegisterDescription>" "<UsingIndDatesInd>" "<RetentionPeriod>" "<RetentionPeriodDays>" "<TaxRetentionPeriod>" "<TaxRetentionPerDays>" "<FirstAwardDate>" "<UnitRounding>" "<MoneyRounding>" "<ReleaseOption1>" "<CalculateTaxInd>" "<BaseCurrency>" "<UsingMatchingInd>" "<UsingUnmatchedInd>" "<MatchingUpfrontInd>" 
		And In EHK01007 I Add ESS Award Setup Details2 as "<TaxReportableInd>" "<TaxStmtTypeInd>" "<LeaverSchedule>" "<ForfeitureType>" "<ForfProRataMethod>" "<ForfPeriodFrom1>" "<ForfPerFromDays>" "<ForfPeriodTO>" "<ForfPerTODays>" "<ForfPercentage>" "<SavingsCarrierInd>"

Examples: 
	| Register | COY       | RegisterType2 | RegisterCode | RegisterDescription | UsingIndDatesInd | RetentionPeriod | RetentionPeriodDays | TaxRetentionPeriod | TaxRetentionPerDays | FirstAwardDate | UnitRounding | MoneyRounding | ReleaseOption1 | CalculateTaxInd | BaseCurrency | UsingMatchingInd | UsingUnmatchedInd | MatchingUpfrontInd | TaxReportableInd | TaxStmtTypeInd | LeaverSchedule | ForfeitureType | ForfProRataMethod | ForfPeriodFrom1 | ForfPerFromDays | ForfPeriodTO | ForfPerTODays | ForfPercentage | SavingsCarrierInd |
	| EB       | NAB2_AUTO | B             | 12A          | 12A AUTOMATION TEST | N                | 12              | 0                   | 12                 | 0                   |                | D            | D             | M              | Y               | AUD          | N                | N                 | N                  | Y                | D              | GN3            | L              |                   |                 |                 | 12           |               | 100            | N                 |

@winformsTest
@HK_ESS_Setups
@28502
@NAB2_AUTO
@FullSmokeTest
Scenario Outline: Test Case 28502: Options Award Setup (EE) -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "award setup" Option
		And In EHK010MN I Select "OPT" Plan
		And In EHK01006 I Add Award Setup Details as "<RegisterCode>" "<RegisterDescription>" "<ExpiresAfterMonths>" "<ExpiresAfterDays>" "<UsingVestingInd>" "<UnitRounding>" "<MoneyRounding>" "<ReleaseOption1>" "<CalculateTaxInd>" "<BaseCurrency>" "<MinMaxType>" "<MinMoneyAmt>" "<MaxMoneyAmt>" "<RegisterType>" "<TaxReportableInd>" "<LeaverSchedule>"

Examples: 
	| Register | COY       | RegisterCode | RegisterDescription | ExpiresAfterMonths | ExpiresAfterDays | UsingVestingInd | UnitRounding | MoneyRounding | ReleaseOption1 | CalculateTaxInd | BaseCurrency | MinMaxType | MinMoneyAmt | MaxMoneyAmt | RegisterType | TaxReportableInd | LeaverSchedule |
	| EE       | NAB2_AUTO | 12A          | 12A AUTOMATION TEST | 95                 | 27               | Y               | D            | D             |                | Y               | AUD          | Y          |             |             | EE           | Y                | GEN            |
	
@winformsTest
@HK_ESS_Setups
@28905
@NAB2_AUTO
Scenario Outline: Test Case 28905: Loan Award Setup (ER) -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "award setup" Option
		And In EHK010MN I Select "ELA" Plan
		And In EHK01009 I Add Award Setup Details as "<RegisterCode>" "<RegisterDescription>" "<UsingIndDatesInd>" "<TermINMonths>" "<TermINDays>" "<RetentionPeriod>" "<RetentionPeriodDays>" "<MinAmount>" "<MaxAmount>" "<PaymentAccount>" "<RecourseInd>" "<MoneyRounding>" "<ReleaseOption1>" "<StatusType1>" "<BaseCurrency>" "<TaxReportableInd>" "<LeaverSchedule>"

Examples: 
	| Register | COY      | RegisterCode | RegisterDescription | UsingIndDatesInd | TermINMonths | TermINDays | RetentionPeriod | RetentionPeriodDays | MinAmount | MaxAmount | PaymentAccount | RecourseInd | MoneyRounding | ReleaseOption1 | StatusType1 | BaseCurrency | TaxReportableInd | LeaverSchedule |
	| ER       | NAB2_AUTO | 12A          | 12A AUTOMATION TEST | N                | 300          |            | 250             | 1                   | 0.00      | 999999.99 | ELA97          | N           | D             |                | R           | AUD          | Y                | GEN            |

@winformsTest
@HK_ESS_Setups
@28908
@NAB2_AUTO
Scenario Outline: Test Case 28908: AESS & Loan Plan Control Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "control setup" Option
		And In EHK010MN I Select Plan as "<Selection>"
		And In EHK01010 I Add Control Setup as "<RegisterCode>" "<StartDate>" "<UnitValue>" "<AwardExchangeRate>" "<SavingsCarrierInd>" "<RegisterType2>" "<ReportUpdateMode>" "<EnabledDisabledInd>" "<DisplayONWebInd>"

Examples: 
	| Plan | COY      | Selection | RegisterCode | StartDate  | UnitValue | AwardExchangeRate | SavingsCarrierInd | RegisterType2 | ReportUpdateMode | EnabledDisabledInd | DisplayONWebInd |
	| AESS | NAB2_AUTO | ATS       | 11C          | 22/11/2011 | 33.230000 |                   | N                 | B             | R                | Y                  | Y               |
	| Loan | NAB2_AUTO | ELA       | 11C          | 22/11/2011 | 33.230000 |                   | N                 | R             | R                | Y                  | Y               |

@winformsTest
@HK_ESS_Setups
@28909
@NAB2_AUTO
@FullSmokeTest
Scenario Outline: Test Case 28909: Options Plan Control Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "control setup" Option
		And In EHK010MN I Select "OPT" Plan
		And In EHK01012 I Add Control Setup as "<RegisterCode>" "<StartDate>" "<UnitValue>" "<EndDate>" "<AwardExchangeRate>" "<DisplayONWebInd>" "<RegisterType2>" "<ReportUpdateMode>" "<EnabledDisabledInd>" "<VestingCode>" "<VestingStartDate>" "<PerformanceHurdles>" "<PerformanceCode>"

Examples: 
	| Plan    | COY      | Selection | RegisterCode | StartDate  | UnitValue | EndDate | AwardExchangeRate | DisplayONWebInd | RegisterType2 | ReportUpdateMode | EnabledDisabledInd | VestingCode | VestingStartDate | PerformanceHurdles | PerformanceCode |
	| Options | NAB2_AUTO | OPT       | 11C          | 21/03/2003 | 30.460000 |         |                   | Y               | E             | R                | Y                  | V01         | 21/03/2003       | Y                  |                 |

@winformsTest
@HK_ESS_Setups
@29169
@NAB2_AUTO
Scenario Outline: Test Case 29169: AESS Plan Deduction Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "deduction setup" Option
		And In EHK010MN I Select "ATS" Plan
		And In EHK01016 I Add Deduction Setup as "<RegisterCode>" "<RegisterType>" "<PaymentFrequency>" "<AccumPeriod>" "<AccumStartDate>" "<AccumEndDate>" "<MaxNumberPayments>"

Examples: 
	| Plan | COY      | RegisterCode | RegisterType | PaymentFrequency | AccumPeriod | AccumStartDate | AccumEndDate | MaxNumberPayments |
	| AESS | NAB2_AUTO | 11A          | EB           | M                | 1           | 01/01/2011     | 01/01/2012   | 12                |

@winformsTest
@HK_ESS_Setups
@29172
@NAB2_AUTO
Scenario Outline: Test Case 29172: Blackout Restricted Codes and Blackout Schedule -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "blackout restricted codes" Option
		And In EHK01026 I Add Blackout Restricted Codes as "<BlkoutRstrctdCode>" "<BlkoutRstrctdDesc>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
	When I go to ESS "blackout schedule setup" Option
		And In EHK01025 I Add Blackout Schedule Setup as "<BlkoutCode>" "<BlkoutDescription>" "<BlkoutRstrctdCode>" "<BlkoutStartDate>" "<BlkoutEndDate>" "<SaleRestriction>" "<TransferRestriction>" "<AllowPendingCancel>" "<RestrictLimitOrders>"

Examples: 
	| COY      | BlkoutRstrctdCode | BlkoutRstrctdDesc        | BlkoutCode | BlkoutDescription    | BlkoutStartDate | BlkoutEndDate | SaleRestriction | TransferRestriction | AllowPendingCancel | RestrictLimitOrders |
	| NAB2_AUTO | DS                | TEST AUTOMATION BLACKOUT | DS1        | TEST AUTOMATION DS01 | 01/01/2015      | 01/01/2017    | S               | S                   | Y                  | Y                   |

@winformsTest
@HK_ESS_Setups
@29180
@NAB2_AUTO
Scenario Outline: Test Case 29180: Vesting Schedule Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "vesting schedule setup" Option
		And In EHK06000 I Add Vesting Schedule Parameters as "<LocateArgument>" "<VestingDescription>" "<VestingTermINMnths>" "<VestingTermINDays>" "<UnitRounding>" "<MnthsFromVestStart1>" "<DaysFromVestStar1>" "<VestingPercentage1>" "<VestingDate1>" "<MnthsFromVestStart2>" "<DaysFromVestStar2>" "<VestingPercentage2>" "<VestingDate2>" "<MnthsFromVestStart3>" "<DaysFromVestStar3>" "<VestingPercentage3>" "<VestingDate3>" "<Comments1>"

Examples: 
	| Test  | COY      | LocateArgument | VestingDescription      | VestingTermINMnths | VestingTermINDays | UnitRounding | MnthsFromVestStart1 | DaysFromVestStar1 | VestingPercentage1 | VestingDate1 | MnthsFromVestStart2 | DaysFromVestStar2 | VestingPercentage2 | VestingDate2 | MnthsFromVestStart3 | DaysFromVestStar3 | VestingPercentage3 | VestingDate3 | Comments1       |
	| Month | NAB2_AUTO | DS1            | TEST AUTOMATION VESTING | 48                 | 12                | D            | 12                  | 1                 | 25.00000           |              | 12                  | 1                 | 25.00000           |              | 12                  | 1                 | 50.00000           |              | TEST AUTOMATION |
	| Date  | NAB2_AUTO | DS2            | TEST AUTOMATION VESTING | 48                 | 12                | D            |                     |                   | 25.00000           | 01/01/2011   |                     |                   | 25.00000           | 01/01/2012   |                     |                   | 50.00000           | 01/01/2013   | TEST AUTOMATION |

@winformsTest
@HK_ESS_Setups
@29194
@NAB2_AUTO
Scenario Outline: Test Case 29194: Performance Hurdle Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "performance hurdle setup" Option
		And In EHK06010 I Add Performance Hurdle Setup as "<LocateVestCode>" "<LocateTrancheNbr>" "<LocatePerfCode>" "<PerformanceDesc>" "<TestDate1>" "<TestPercent1>" "<CancelUnv1>" "<TestDate2>" "<TestPercent2>" "<CancelUnv2>" "<VestingPercentage>"

Examples: 
	| COY      | LocateVestCode | LocateTrancheNbr | LocatePerfCode | PerformanceDesc             | TestDate1  | TestPercent1 | CancelUnv1 | TestDate2  | TestPercent2 | CancelUnv2 | VestingPercentage |
	| NAB2_AUTO | P01            | 1                | P01            | TEST AUTOMATION PERFORMANCE | 01/01/2010 | 50.00000     | N          | 01/01/2011 | 50.00000     | N          | 20.00000          |

@winformsTest
@HK_ESS_Setups
@29202
@NAB2_AUTO
Scenario Outline: Test Case 29202: AESS Plan Leaver Schedule Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "leaver schedule setup" Option
		And In EHK01039 I Add Leaver Schedule Setup as "<PlanType>"
		And In EHK01034 I Add AESS Leaver Schedule Setup as "<LeaverSchedule>" "<LeaverScheduleDesc>" "<LeaverCode>" "<EmployeeStatus>" "<LeaverEffectInd>" "<PhantomLeaverType>" "<RelsONEmpEndInd>" "<ForfImmInd>" "<AccelerateAvailInd>" "<AccelerateMonths>" "<AccelerateDays>" "<AccelFrmDateInd>" "<CommentsLine1>" "<LeaverCodeDesc>" "<EmpStatusDesc>"

Examples: 
	| LeaverEffectInd | COY      | PlanType | LeaverSchedule | LeaverScheduleDesc | LeaverCode | EmployeeStatus | PhantomLeaverType | RelsONEmpEndInd | ForfImmInd | AccelerateAvailInd | AccelerateMonths | AccelerateDays | AccelFrmDateInd | CommentsLine1   | LeaverCodeDesc | EmpStatusDesc              |
	| F               | NAB2_AUTO | A        | DDD            | TEST AUTOMATION    | DDD        | D              | G                 |                 |            |                    |                  |                |                 | TEST AUTOMATION | D DEFAULT      | DECEASED ESTATE            |
	| L               | NAB2_AUTO | A        | FFF            | TEST AUTOMATION    | FFF        | F              | G                 | Y               | N          | N                  | 0                | 0              |                 | TEST AUTOMATION | F DEFAULT      | FRAUD/MISCONDUCT/DISMISSED |

@winformsTest
@HK_ESS_Setups
@29203
@NAB2_AUTO
@FullSmokeTest
Scenario Outline: Test Case 29203: Loan Plan Leaver Schedule Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "leaver schedule setup" Option
		And In EHK01039 I Add Leaver Schedule Setup as "<PlanType>"
		And In EHK01035 I Add Loan Plan Leaver Schedule Setup as "<LeaverSchedule>" "<LeaverScheduleDesc>" "<LeaverCode>" "<EmployeeStatus>" "<CommentsLine1>" "<LeaverCodeDesc>" "<EmpStatusDesc>"

Examples: 
	| COY       | PlanType | LeaverSchedule | LeaverScheduleDesc | LeaverCode | EmployeeStatus | CommentsLine1   | LeaverCodeDesc | EmpStatusDesc |
	| NAB2_AUTO | L        | LLL            | TEST AUTOMATION    | LLL        | L              | TEST AUTOMATION | L DEFAULT      | RESIGNATION   |

@winformsTest
@HK_ESS_Setups
@29204
@NAB2_AUTO
Scenario Outline: Test Case 29204: Executive Options Plan Leaver Schedule Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "leaver schedule setup" Option
		And In EHK01039 I Add Leaver Schedule Setup as "<PlanType>"
		And In EHK01035 I Add Options Plan Leaver Schedule Setup as "<LeaverSchedule>" "<LeaverScheduleDesc>" "<LeaverCode>" "<EmployeeStatus>" "<OverrideExpiryInd>" "<UnvNOChgInd>" "<UnvCancelImmInd>" "<UnvAccelerateVstInd>" "<VstNOChgInd>" "<VstCancelImmInd>" "<VstIgnoreBlackout>" "<CommentsLine1>" "<LeaverCodeDesc>" "<EmpStatusDesc>" "<OverrideMonths>" "<OverrideDays>" "<OverrideFromDateInd>"

Examples: 
	| OverrideExpiryInd | COY      | PlanType | LeaverSchedule | LeaverScheduleDesc | LeaverCode | EmployeeStatus |  UnvNOChgInd | UnvCancelImmInd | UnvAccelerateVstInd | VstNOChgInd | VstCancelImmInd | VstIgnoreBlackout | CommentsLine1   | LeaverCodeDesc | EmpStatusDesc | OverrideMonths | OverrideDays | OverrideFromDateInd |
	| N                 | NAB2_AUTO | E        | LLL            | TEST AUTOMATION    | LLL        | L              |  N           | Y               | N                   | Y           | N               | N                 | TEST AUTOMATION | L DEFAULT      | RESIGNATION   |                |              |                     |
	| Y                 | NAB2_AUTO | E        | LLD            | TEST AUTOMATION    | LLL        | L              |  N           | Y               | N                   | Y           | N               | N                 | TEST AUTOMATION | L DEFAULT      | RESIGNATION   | 10             | 10           | E                   |

@winformsTest
@HK_ESS_Setups
@29313
@NAB2_AUTO
Scenario Outline: Test Case 29313: Leaver Description Code -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "leaver description code" Option
		And In EHK01037 I Add Leaver Description Codes as "<EmployeeStatus>" "<LeaverCode>" "<LeaverCodeDesc>" "<EmpStatusDesc>"

Examples: 
	| COY      | EmployeeStatus | LeaverCode | LeaverCodeDesc  | EmpStatusDesc    |
	| NAB2_AUTO | E              | DSS        | TEST AUTOMATION | CURRENT EMPLOYEE |

@winformsTest
@HK_ESS_Setups
@29315
@NAB2_AUTO
Scenario Outline: Test Case 29315: ESS Bank Details Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess bank details setup" Option	
		And In EHK01030 I Add ESS Direct Credit Code as "<AddKey>"
		And In EHK01032 I Add ESS Direct Credit Details as "<BulkPayDesc>" "<HomeBankDesc>" "<CemtexUserNum>" "<OverrideTranType>" "<PaymentDescription>" "<HeaderRemitterName>" "<TraceBsb1to3>" "<TraceBsb5to7>" "<TraceAccount>" "<TransRemitterName>" "<LodgementSuffix>" "<AusDirectCredtEft1>"

Examples: 
	| COY      | AddKey | BulkPayDesc     | HomeBankDesc | CemtexUserNum | OverrideTranType | PaymentDescription | HeaderRemitterName | TraceBsb1to3 | TraceBsb5to7 | TraceAccount | TransRemitterName | LodgementSuffix | AusDirectCredtEft1 |
	| NAB2_AUTO | 10     | TEST AUTOMATION | NAB          | 10            |                  | AUTOMATION         | TEST AUTOMATION    | 13           | 100          | 100100100    | TEST AUTOMATION   | 101010          | Y                  |

@HK_ESS_Setups
@29345
@NAB2_AUTO
Scenario Outline: Test Case 29345: Modify VWAP File -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "modify vwap file" Option	
		And In EHK01020 I Add Modify VWAP File as "<FinalSecurity>" "<VwapDate>" "<ExchangeCode>" "<OnedayVwap>" "<OnedayTradeVolume>" "<MultiDayVwap>" "<ClosingPrice>" "<ConversionRate>" "<MultiDayVwapDesc>" "<IsinNumber>" "<CurrencyCode>" "<TradingDayInd>" "<LastUpdatedBY>"

Examples: 
	| Test     | COY      | FinalSecurity | VwapDate   | ExchangeCode | OnedayVwap | OnedayTradeVolume | MultiDayVwap | ClosingPrice | ConversionRate | MultiDayVwapDesc | IsinNumber   | CurrencyCode | TradingDayInd | LastUpdatedBY |
	| FiveDay  | NAB2_AUTO  | ORD           | 07/10/2015 | ASX          | 33.446665  | 1904816           | 33.492343    | 33.560000    |                | (5 Day)          | AU000000NAB4 | AUD          | Y             | Auto Test01   |
	| SevenDay | NAB2_AUTO | ORD           | 29/06/2011 | ASX          | 33.446665  | 1904816           | 33.492343    | 33.560000    |                | (7 Day)          | AU000000NAB4 | AUD          | Y             | Auto Test01   |

@winformsTest
@HK_ESS_Setups
@29477
@NAB2_AUTO
Scenario Outline: Test Case 29477: Event Control -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess event control" Option
		And In EHK01013 I Add ESS Event Control Setup as "<EventType>" "<EventCode>" "<EventDescription>"

Examples: 
	| EventType | COY       | EventCode | EventDescription  |
	| V         | NAB2_AUTO | DD1       | TEST AUTOMATION V |
	| T         | NAB2_AUTO | DD2       | TEST AUTOMATION T |
	| I         | NAB2_AUTO | DD3       | TEST AUTOMATION I |

@winformsTest
@HK_ESS_Setups
@29475
@NAB2_AUTO
Scenario Outline: Test Case 29475: T Type Event Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess event setup" Option
		And In EHK01014 I Add ESS T Type Event Setup as "<EventType>" "<EventCode>" "<EventDate>" "<EvtPeriodSta>" "<EvtPeriodEnd>" "<EventCurrentInd>" "<EventClosedInd>" "<ClassCode>" "<RegisterCode1>" "<RegisterCode2>" "<RegisterType1>" "<RegisterType2>"

Examples: 
	| Plan    | EventType | COY      | EventCode | EventDate  | EvtPeriodSta | EvtPeriodEnd | EventCurrentInd | EventClosedInd | ClassCode | RegisterCode1 | RegisterCode2 | RegisterType1 | RegisterType2 |
	| Options | T         | NAB2_AUTO | DS5       | 01/01/2020 | 01/01/2013   | 30/03/2020   | Y               | N              | OPT       | 11C           |               |               |               |
	| AESS    | T         | NAB2_AUTO | DS8       | 01/01/2020 | 01/01/2013   | 30/03/2020   | Y               | N              | ATS       | 11A           |               | EB            |               |

@winformsTest
@HK_ESS_Setups
@29492
@NAB2_AUTO
@FullSmokeTest
Scenario Outline: Test Case 29492: V Type Options Plan Event Setup -[Add]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess event setup" Option
		And In EHK01014 I Add ESS Event Setup as "<EventType>" "<EventCode>" "<EventDate>" "<EvtPeriodSta>" "<EvtPeriodEnd>" "<EventCurrentInd>" "<EventClosedInd>" "<ClassCode>" "<RegisterCode1>" "<RegisterCode2>" "<RegisterType1>" "<RegisterType2>" "<IncludeLeaversInd>" "<IncldBlktHldrInd>" "<HolderSelctnInd>"
		And In EHK01045 I Add Options Event Setup as "<EvtNotificationDT>" "<EvtApplicationDT>" "<EvtCommMethod>" "<DefaultBulkType>" "<DefaultBulkCode>" "<DefaultXferCode>" "<TXRteAplcableInd>" "<DfltTaxDspslchoic>" "<TaxEventPointFlg>" "<EvtElctnPerdInd>" "<DfltPaytMethod>" "<DfltNtxDspslchoic>" "<DfltRblDspslchoic>"
		And In EHK01046 I Add ESS Event Setup1 as "<EvtElctnStaDT>" "<EvtElctnEndDT>" "<ElectnStartHH>" "<ElectnStartMM>" "<ElectnClosingHH>" "<EvtReconclStaDT>" "<EvtReconclEndDT>" "<NtaxDspslChoice1>" "<NtaxDspslChoice2>" "<NtaxDspslChoice3>" "<NtaxDspslChoice4>" "<NtaxDspslChoice5>" "<TaxDspslChoice1>" "<TaxDspslChoice2>" "<TaxDspslChoice3>" "<TaxDspslChoice4>" "<TaxDspslChoice5>"
		And In EHK01046 I Add ESS Event Setup2 as "<AlowdPaytMethod1>" "<AlowdPaytMethod2>" "<AlowdPaytMethod3>" "<AlowdPaytMethod4>" "<AlowdPaytMethod5>" "<NtxEXMethod1>" "<NtxEXMethod2>" "<TaxEXMethod1>" "<TaxEXMethod2>" "<WebElectionsInd>" "<TaxJurisdiction1>" "<TaxJurisdiction2>" "<CmplxTXScnrioInd>" "<ElectionConfInd>"

Examples: 
	| Plan    | EventType | COY       | EventCode | EventDate  | EvtPeriodSta | EvtPeriodEnd | EventCurrentInd | EventClosedInd | ClassCode | RegisterCode1 | RegisterCode2 | RegisterType1 | RegisterType2 | IncludeLeaversInd | IncldBlktHldrInd | HolderSelctnInd | EvtNotificationDT | EvtApplicationDT | EvtCommMethod | DefaultBulkType | DefaultBulkCode | DefaultXferCode | TXRteAplcableInd | DfltTaxDspslchoic | TaxEventPointFlg | EvtElctnPerdInd | DfltPaytMethod | DfltNtxDspslchoic | DfltRblDspslchoic | EvtElctnStaDT | EvtElctnEndDT | ElectnStartHH | ElectnStartMM | ElectnClosingHH | EvtReconclStaDT | EvtReconclEndDT | NtaxDspslChoice1 | NtaxDspslChoice2 | NtaxDspslChoice3 | NtaxDspslChoice4 | NtaxDspslChoice5 | TaxDspslChoice1 | TaxDspslChoice2 | TaxDspslChoice3 | TaxDspslChoice4 | TaxDspslChoice5 | AlowdPaytMethod1 | AlowdPaytMethod2 | AlowdPaytMethod3 | AlowdPaytMethod4 | AlowdPaytMethod5 | NtxEXMethod1 | NtxEXMethod2 | TaxEXMethod1 | TaxEXMethod2 | WebElectionsInd | TaxJurisdiction1 | TaxJurisdiction2 | CmplxTXScnrioInd | ElectionConfInd |
	| Options | V         | NAB2_AUTO | DS4       | 01/01/2020 | 01/01/2013   | 30/03/2020   | Y               | N              | OPT       | 03A           |               |               |               | Y                 | Y                | P               | 01/02/2013        | 01/01/2020       | E             | B               | DS01            | DS02            | Y                | C                 | V                | Y               | C              | L                 | C                 | 01/02/2013    | 31/12/2019    | 1             | 1             | 17              | 01/02/2019      | 31/12/2019      | A                | C                | T                | L                |                  | A               | C               | T               |                 |                 | C                | D                | E                | F                | W                | A            | P            | A            | P            | Y               |                  |                  | N                | N               |

@winformsTest
@HK_ESS_Setups
@29493
@NAB2_AUTO
Scenario Outline: Test Case 29493: V Type AESS Plan Event Setup -[Add]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess event setup" Option
		And In EHK01014 I Add ESS Event Setup as "<EventType>" "<EventCode>" "<EventDate>" "<EvtPeriodSta>" "<EvtPeriodEnd>" "<EventCurrentInd>" "<EventClosedInd>" "<ClassCode>" "<RegisterCode1>" "<RegisterCode2>" "<RegisterType1>" "<RegisterType2>" "<IncludeLeaversInd>" "<IncldBlktHldrInd>" "<HolderSelctnInd>"
		And In EHK01045 I Add AESS Event Setup as "<EvtNotificationDT>" "<EvtApplicationDT>" "<EvtCommMethod>" "<DefaultBulkCode>" "<TXRteAplcableInd>" "<DfltTaxDspslchoic>" "<EvtElctnPerdInd>" "<DfltPaytMethod>" "<DfltNtxDspslchoic>"
		And In EHK01046 I Add ESS Event Setup1 as "<EvtElctnStaDT>" "<EvtElctnEndDT>" "<ElectnStartHH>" "<ElectnStartMM>" "<ElectnClosingHH>" "<EvtReconclStaDT>" "<EvtReconclEndDT>" "<NtaxDspslChoice1>" "<NtaxDspslChoice2>" "<NtaxDspslChoice3>" "<NtaxDspslChoice4>" "<NtaxDspslChoice5>" "<TaxDspslChoice1>" "<TaxDspslChoice2>" "<TaxDspslChoice3>" "<TaxDspslChoice4>" "<TaxDspslChoice5>"
		And In EHK01046 I Add ESS Event Setup2 as "<AlowdPaytMethod1>" "<AlowdPaytMethod2>" "<AlowdPaytMethod3>" "<AlowdPaytMethod4>" "<AlowdPaytMethod5>" "<NtxEXMethod1>" "<NtxEXMethod2>" "<TaxEXMethod1>" "<TaxEXMethod2>" "<WebElectionsInd>" "<TaxJurisdiction1>" "<TaxJurisdiction2>" "<CmplxTXScnrioInd>" "<ElectionConfInd>"

Examples: 
	| Plan | EventType | COY      | EventCode | EventDate  | EvtPeriodSta | EvtPeriodEnd | EventCurrentInd | EventClosedInd | ClassCode | RegisterCode1 | RegisterCode2 | RegisterType1 | RegisterType2 | IncludeLeaversInd | IncldBlktHldrInd | HolderSelctnInd | EvtNotificationDT | EvtApplicationDT | EvtCommMethod | DefaultBulkCode | TXRteAplcableInd | DfltTaxDspslchoic | EvtElctnPerdInd | DfltPaytMethod | DfltNtxDspslchoic |EvtElctnStaDT | EvtElctnEndDT | ElectnStartHH | ElectnStartMM | ElectnClosingHH | EvtReconclStaDT | EvtReconclEndDT | NtaxDspslChoice1 | NtaxDspslChoice2 | NtaxDspslChoice3 | NtaxDspslChoice4 | NtaxDspslChoice5 | TaxDspslChoice1 | TaxDspslChoice2 | TaxDspslChoice3 | TaxDspslChoice4 | TaxDspslChoice5 | AlowdPaytMethod1 | AlowdPaytMethod2 | AlowdPaytMethod3 | AlowdPaytMethod4 | AlowdPaytMethod5 | NtxEXMethod1 | NtxEXMethod2 | TaxEXMethod1 | TaxEXMethod2 | WebElectionsInd | TaxJurisdiction1 | TaxJurisdiction2 | CmplxTXScnrioInd | ElectionConfInd |
	| AESS | V         | NAB2_AUTO | DS7       | 31/12/2020 | 01/02/2014   | 31/12/2020   | Y               | N              | ATS       | 05A           |               | EB            |               | Y                 | Y                | H               | 01/02/2014        | 31/12/2020       | B             | DS03            | Y                | A                 | Y               | C              | A                 |01/02/2014    | 25/12/2020    | 1             | 1             | 17              | 26/12/2020      | 27/12/2020      | A                | C                | P                |                  | L                | A               | C               | P               |                 |                 | C                | D                | E                | F                | W                | A            | P            | A            | P            | Y               |                  |                  | N                | N               |

@winformsTest
@HK_ESS_Setups
@29574
@NAB2_AUTO
Scenario Outline: Test Case 29574: ESS Provider Information Setup -[Add/View]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess provider information setup" Option
		And In EHK01038 I Add ESS Provider Information Setup as "<Abn>" "<BranchNumber>" "<ProviderNameLine1>" "<ProviderNameLine2>" "<TradingNameLine1>" "<TradingNameLine2>" "<PostalAddressLine1>" "<PostalAddressLine2>" "<PostalSuburb>" "<PostalState>" "<PostalPostcode>" "<PostalCountry>" "<AddressForNotices>" "<CommunicationMethod>" "<ProviderContactName>" "<ProviderPhoneNumber>" "<ProviderEmailID>" "<AuthorisedSignatory>"
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "ess provider information setup" Option
		And In EHK01038 I Verify ESS Provider Information Setup as "<Abn>" "<BranchNumber>" "<ProviderNameLine1>" "<ProviderNameLine2>" "<TradingNameLine1>" "<TradingNameLine2>" "<PostalAddressLine1>" "<PostalAddressLine2>" "<PostalSuburb>" "<PostalState>" "<PostalPostcode>" "<PostalCountry>" "<AddressForNotices>" "<CommunicationMethod>" "<ProviderContactName>" "<ProviderPhoneNumber>" "<ProviderEmailID>" "<AuthorisedSignatory>"

Examples: 
	| COY      | Abn         | BranchNumber | ProviderNameLine1     | ProviderNameLine2     | TradingNameLine1      | TradingNameLine2      | PostalAddressLine1 | PostalAddressLine2  | PostalSuburb | PostalState | PostalPostcode | PostalCountry | AddressForNotices | CommunicationMethod | ProviderContactName | ProviderPhoneNumber | ProviderEmailID               | AuthorisedSignatory |
	| NAB2_AUTO | 71005485825 | 1            | COMPUTERSHARE LIMITED | COMPUTERSHARE LIMITED | COMPUTERSHARE LIMITED | COMPUTERSHARE LIMITED | YARRA FALLS        | 452 JOHNSTON STREET | ABBOTSFORD   | VIC         | 3067           | AUSTRALIA     | S                 | P                   | LISA HEW            | 03 9415 5116        | lisa.hew@computershare.com.au | LISA HEW            |

@winformsTest
@HK_ESS_Setups
@29581
@NAB2_AUTO
Scenario Outline: Test Case 29581: VSA Jurisdiction Setup -[Add/View/Delete]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to ESS "vsa jurisdiction setup" Option
		And In EHK01040 I Add VSA Jurisdiction Setup as "<JurisdictionCode>" "<JurDescription>" "<SelectDomicileInd>" "<DomicileCodeL11>" "<DomicileCodeL12>" "<DomicileCodeL13>" "<DomicileCodeL14>" "<DomicileCodeL15>" "<DomicileCodeL16>" "<DomicileCodeL17>" "<DomicileCodeL18>" "<DomicileCodeL19>" "<DomicileCodeL110>" "<DomicileCodeL111>" "<DomicileCodeL21>" "<DomicileCodeL22>" "<DomicileCodeL23>"   
		And In EHK01040 I Delete VSA Jurisdiction Setup

Examples: 
	| Test    | COY       | JurisdictionCode | JurDescription | SelectDomicileInd | DomicileCodeL11 | DomicileCodeL12 | DomicileCodeL13 | DomicileCodeL14 | DomicileCodeL15 | DomicileCodeL16 | DomicileCodeL17 | DomicileCodeL18 | DomicileCodeL19 | DomicileCodeL110 | DomicileCodeL111 | DomicileCodeL21 | DomicileCodeL22 | DomicileCodeL23 |
	| Select  | NAB2_AUTO | VAA              | TEST VAA       | S                 | USA             | AFG             | ALB             | DZA             | ASM             | AND             | AGO             | AIA             | ATA             | ATG              | ARG              | ARM             |                 |                 |
	| Exclude | NAB2_AUTO | VAB              | TEST VAB       | E                 | USA             | GBR             | ALB             | DZA             | ASM             | AND             | AGO             | AIA             | ATA             | ATG              | ARG              | AUS             | NZL             | ARM             |
#	| All     | NAB2_AUTO | VAC              | TEST VAC       | A                 |                 |                 |                 |                 |                 |                 |                 |                 |                 |                  |                  |                 |                 |                 |

@winformsTest
@HK_ESS_Setups
@29678
@NAB2_AUTO
Scenario Outline: Test Case 29678: Trade Control Codes for Sales -[Add]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to "trading control codes" Control Code Menu
		And In TRD24000 I Add Trade Control Details as "<TradingCode>" "<TradeType>" "<TradeDescription>" "<CurrentFlag>" "<ClassCode>" "<InvTradeInd>" "<EventBulkInd>" "<SettlementAction>" "<SettlementPeriod>" "<SettlementRegime>" "<MinimumDeal>" "<MaximumDeal>" "<RecordMoneyORUnits>" "<CutOffHH>" "<CutOffMM>" "<CalcReqInd>" "<ContactDetails>"
		And In TRD24006 I Add Trade Control Details as "<CounterpartyReqd>" "<CounterpartyClass>" "<CounterpartyRegister>" "<CounterTrantypeCode>" "<CounterHolderID>" "<ONMarketTradeInd>" "<DPBrokerCode>" "<DPTradeAccount>" "<DPConnectionTO>" "<RealTimeTrading>" "<DPOrderType>"
		And In TRD24003 I Add Trade Control Details as "<DispExecVenueInd>" "<GenerateAdvices>" "<GenerateCertificates>" "<OnlineEntryInd>" "<ExternalExercise>" "<WebInterfaceInd>" "<AuditInd>" "<AuditSettlingTrans>" "<AllowCorporateBodies>" "<AllowPurchaseResidue>" "<AllowReturnMail>" "<AllowDeceased>" "<AllowPartialSell>" "<AllowSellTOCover>" "<Trd24003TaxResidualInd>" "<AllowCertPartSell>" "<AllowSellSelected>" "<AllowFullSell>" "<AllowForeignResident>"
		And In TRD240RB I Add Trade Control Details as "<AllowSellTOCover>" "<RemainingBalOption1>" "<RemainingBalTran1>" "<RemainingBalClass1>" "<RemainingBalReg1>" "<RemainingBalOption2>" "<RemainingBalTran2>" "<RemainingBalClass2>" "<RemainingBalReg2>"
		And In TRD24004 I Add Trade Control Details1 as "<GrossRounding>" "<ReconciliationCode>" "<CashManagementReqd>" "<PayAccountNumber>" "<ValidPayMethod1>" "<ValidPayMethod2>" "<ValidPayMethod3>" "<ExistPayDirCred>" "<PermPayDirCred>" "<TempPayDirCred>" "<ValidPayMethod4>" "<ExistPayWire>" "<PermPayWire>" "<TempPayWire>" "<ValidPayMethod5>" "<RemitTaxPayrollInd>" "<RemitEmpPayrollInd>" "<WorldlinkNumber>" "<PayrollDependentInd>"
		And In TRD24004 I Add Trade Control Details2 as "<DefaultPaymentMethd>" "<DefaultPayCurrency>" "<PaymentCurrency1>" "<PaymentCurrency2>" "<PaymentCurrency3>" "<GenerateTrdtpeInd>" "<GenerateFlatFile>" "<BuildPaymentsInd>" "<LoanPayAccount>" "<LoanRegBreakupReqd>"
		And In TRD24009 I Add Trade Control Details as "<SmsInd1>" "<SmsInd2>" "<SmsInd3>" "<SmsInd4>" "<EmailInd1>" "<EmailInd2>" "<EmailInd3>" "<EmailInd4>" "<EmailCompanySpec1>" "<EmailCompanySpec2>" "<EmailCompanySpec3>" "<EmailCompanySpec4>"
		And In TRD24007 I Add Trade Control Details1 as "<ChargeDesc9>" "<ChargeCode9>" "<ChargePaidBY9>" "<ChargeWaived9>" "<ChargeDesc10>" "<ChargeCode10>" "<ChargePaidBY10>" "<ChargeWaived10>" "<ChargeDesc11>" "<ChargeCode11>" "<ChargePaidBY11>" "<ChargeWaived11>" "<ChargeDesc12>" "<ChargeCode12>" "<ChargePaidBY12>" "<ChargeWaived12>" "<ChargeDesc1>" "<ChargeDesc2>"
		And In TRD24007 I Add Trade Control Details2 as "<ChargeCode1>" "<ChargePaidBY1>" "<ChargeWaived1>" "<ChargeCode2>" "<ChargePaidBY2>" "<ChargeWaived2>" "<ChargeCode3>" "<ChargePaidBY3>" "<ChargeWaived3>" "<ChargeCode4>" "<ChargePaidBY4>" "<ChargeWaived4>" "<ChargeCode5>" "<ChargePaidBY5>" "<ChargeWaived5>" "<ChargeDesc3>" "<ChargeDesc4>" "<ChargeDesc5>"
		And In BILCTL99 I Add Trade Control Details as "<ServiceProvider>" "<ServiceCode>"

Examples: 
	| Plan            | COY      | TradingCode | TradeType | TradeDescription    | CurrentFlag | ClassCode | InvTradeInd | EventBulkInd | SettlementAction | SettlementPeriod | SettlementRegime | MinimumDeal | MaximumDeal           | RecordMoneyORUnits | CutOffHH | CutOffMM | CalcReqInd | ContactDetails  | CounterpartyReqd | CounterpartyClass | CounterpartyRegister | CounterTrantypeCode | CounterHolderID | ONMarketTradeInd | DPBrokerCode | DPTradeAccount | DPConnectionTO | RealTimeTrading | DPOrderType | DispExecVenueInd | GenerateAdvices | GenerateCertificates | OnlineEntryInd | ExternalExercise | WebInterfaceInd | AuditInd | AuditSettlingTrans | AllowCorporateBodies | AllowPurchaseResidue | AllowReturnMail | AllowDeceased | AllowPartialSell | AllowSellTOCover | Trd24003TaxResidualInd | AllowCertPartSell | AllowSellSelected | AllowFullSell | AllowForeignResident | RemainingBalOption1 | RemainingBalTran1 | RemainingBalClass1 | RemainingBalReg1 | RemainingBalOption2 | RemainingBalTran2 | RemainingBalClass2 | RemainingBalReg2 | GrossRounding | ReconciliationCode | CashManagementReqd | PayAccountNumber | ValidPayMethod1 | ValidPayMethod2 | ValidPayMethod3 | ExistPayDirCred | PermPayDirCred | TempPayDirCred | ValidPayMethod4 | ExistPayWire | PermPayWire | TempPayWire | ValidPayMethod5 | RemitTaxPayrollInd | RemitEmpPayrollInd | WorldlinkNumber | PayrollDependentInd | DefaultPaymentMethd | DefaultPayCurrency | PaymentCurrency1 | PaymentCurrency2 | PaymentCurrency3 | GenerateTrdtpeInd | GenerateFlatFile | BuildPaymentsInd | SmsInd1 | SmsInd2 | SmsInd3 | SmsInd4 | EmailInd1 | EmailInd2 | EmailInd3 | EmailInd4 | EmailCompanySpec1 | EmailCompanySpec2 | EmailCompanySpec3 | EmailCompanySpec4 | ChargeDesc9 | ChargeCode9 | ChargePaidBY9 | ChargeWaived9 | ChargeDesc10   | ChargeCode10 | ChargePaidBY10 | ChargeWaived10 | ChargeDesc11 | ChargeCode11 | ChargePaidBY11 | ChargeWaived11 | ChargeDesc12   | ChargeCode12 | ChargePaidBY12 | ChargeWaived12 | ChargeDesc1 | ChargeDesc2 | ChargeCode1 | ChargePaidBY1 | ChargeWaived1 | ChargeCode2 | ChargePaidBY2 | ChargeWaived2 | ChargeCode3 | ChargePaidBY3 | ChargeWaived3 | ChargeCode4 | ChargePaidBY4 | ChargeWaived4 | ChargeCode5 | ChargePaidBY5 | ChargeWaived5 | ChargeDesc3 | ChargeDesc4  | ChargeDesc5       | ServiceProvider | ServiceCode | LoanPayAccount | LoanRegBreakupReqd |
	| AESS-Batch      | NAB2_AUTO | ATS3        | S         | TEST AUTOMATION ATS | Y           | ATS       | N           | N            | A                | 3                | AUS              | 1           | 99999999999999.999999 | W                  | 10       | 00       | Y          | TEST AUTOMATION | Y                | ORD               | VIC                  | BLKUP               | I0030153839     | M                |              |                |                | N               | M           | N                | N               | N                    | S              | N                | Y               | O        | N                  | W                    | N                    | W               | W             | Y                | Y                | P                      | Y                 | Y                 | Y             | W                    | C                   | ESTSC             | ORD                | VIC              |                     |                   |                    |                  | D             | ESSJBW             | Y                  | TSSAL            | Y               | Y               | Y               | Y               | Y              | Y              | Y               | Y            | Y           | Y           | Y               | N                  | N                  | 123451234       | N                   | C                   | AUD                |                  |                  |                  | Y                 | Y                | Y                | Y       | Y       | Y       | Y       | Y         | N         | N         | N         | N                 | N                 | N                 | N                 | Wire        | CWIR        | A             | N             | Direct Banking | CDCR         | A              | N              | Local Cheque | CLCQ         | A              | N              | Foreign Cheque | CFCQ         | A              | N              | Broker      | Commission  | CBRK        | A             | N             | CPMM        | A             | N             |             |               |               |             |               |               |             |               |               | Stamp Duty  | Handling fee | Miscellaneous Fee | CTS             | ******      |                |                    |
	| AESS-RealTime   | NAB2_AUTO | ATS4        | S         | TEST AUTOMATION ATS | Y           | ATS       | N           | N            | A                | 3                | AUS              | 1           | 99999999999999.999999 | W                  | 10       | 00       | Y          | TEST AUTOMATION | Y                | ORD               | VIC                  | BLKUP               | I0030153839     | M                |              |                |                | Y               | M           | N                | N               | N                    | S              | N                | Y               | N        | N                  | W                    | N                    | W               | W             | Y                | Y                | P                      | Y                 | Y                 | Y             | W                    | C                   | ESTSC             | ORD                | VIC              |                     |                   |                    |                  | D             | ESSJBW             | Y                  | TSSAL            | Y               | Y               | Y               | Y               | Y              | Y              | Y               | Y            | Y           | Y           | Y               | N                  | N                  | 123451234       | N                   | C                   | AUD                |                  |                  |                  | Y                 | Y                | Y                | Y       | Y       | Y       | Y       | Y         | N         | N         | N         | N                 | N                 | N                 | N                 | Wire        | CWIR        | A             | N             | Direct Banking | CDCR         | A              | N              | Local Cheque | CLCQ         | A              | N              | Foreign Cheque | CFCQ         | A              | N              | Broker      | Commission  | CBRK        | A             | N             | CPMM        | A             | N             |             |               |               |             |               |               |             |               |               | Stamp Duty  | Handling fee | Miscellaneous Fee | CTS             | ******      |                |                    |
	| Option-Batch    | NAB2_AUTO | OPT5        | S         | TEST AUTOMATION OPT | Y           | OPT       | N           | N            | A                | 3                | AUS              | 1           | 99999999999999.999999 | W                  | 10       | 00       | Y          | TEST AUTOMATION | Y                | ORD               | VIC                  | BLKUP               | I0030153839     | M                |              |                |                | N               | M           | N                | N               | N                    | S              | N                | Y               | O        | N                  | W                    | N                    | W               | W             | Y                | Y                | P                      | Y                 | Y                 | Y             | W                    | C                   | ESOXR             | ORD                | VIC              |                     |                   |                    |                  | D             | ESSJBW             | Y                  | TSSAL            | Y               | Y               | Y               | Y               | Y              | Y              | Y               | Y            | Y           | Y           | Y               | N                  | N                  | 123451234       | N                   | C                   | AUD                |                  |                  |                  | Y                 | Y                | Y                | Y       | Y       | Y       | Y       | Y         | N         | N         | N         | N                 | N                 | N                 | N                 | Wire        | CWIR        | A             | N             | Direct Banking | CDCR         | A              | N              | Local Cheque | CLCQ         | A              | N              | Foreign Cheque | CFCQ         | A              | N              | Broker      | Commission  | CBRK        | A             | N             | CPMM        | A             | N             |             |               |               |             |               |               |             |               |               | Stamp Duty  | Handling fee | Miscellaneous Fee | CTS             | ******      |                |                    |
	| Option-RealTime | NAB2_AUTO | OPT6        | S         | TEST AUTOMATION OPT | Y           | OPT       | N           | N            | A                | 3                | AUS              | 1           | 99999999999999.999999 | W                  | 10       | 00       | Y          | TEST AUTOMATION | Y                | ORD               | VIC                  | BLKUP               | I0030153839     | M                |              |                |                | Y               | M           | N                | N               | N                    | S              | N                | Y               | N        | N                  | W                    | N                    | W               | W             | Y                | Y                | P                      | Y                 | Y                 | Y             | W                    | C                   | ESOXR             | ORD                | VIC              |                     |                   |                    |                  | D             | ESSJBW             | Y                  | TSSAL            | Y               | Y               | Y               | Y               | Y              | Y              | Y               | Y            | Y           | Y           | Y               | N                  | N                  | 123451234       | N                   | C                   | AUD                |                  |                  |                  | Y                 | Y                | Y                | Y       | Y       | Y       | Y       | Y         | N         | N         | N         | N                 | N                 | N                 | N                 | Wire        | CWIR        | A             | N             | Direct Banking | CDCR         | A              | N              | Local Cheque | CLCQ         | A              | N              | Foreign Cheque | CFCQ         | A              | N              | Broker      | Commission  | CBRK        | A             | N             | CPMM        | A             | N             |             |               |               |             |               |               |             |               |               | Stamp Duty  | Handling fee | Miscellaneous Fee | CTS             | ******      |                |                    |
	| Loan-Batch      | NAB2_AUTO | ELA5        | S         | TEST AUTOMATION ELA | Y           | ELA       | N           | N            | A                | 3                | AUS              | 1           | 99999999999999.999999 | W                  | 10       | 00       | Y          | TEST AUTOMATION | Y                | ORD               | VIC                  | BLKUP               | I0030153839     | M                |              |                |                | N               | M           | N                | N               | N                    | S              | N                | N               | O        | N                  | W                    | N                    | W               | W             | Y                | Y                | P                      | Y                 | Y                 | Y             | W                    | C                   | ESTSC             | ORD                | VIC              |                     |                   |                    |                  | D             | ESSJBW             | Y                  | TSSAL            | Y               | Y               | Y               | Y               | Y              | Y              | Y               | Y            | Y           | Y           | Y               | N                  | N                  | 123451234       | N                   | C                   | AUD                |                  |                  |                  | Y                 | Y                | Y                | Y       | Y       | Y       | Y       | Y         | N         | N         | N         | N                 | N                 | N                 | N                 | Wire        | CWIR        | A             | N             | Direct Banking | CDCR         | A              | N              | Local Cheque | CLCQ         | A              | N              | Foreign Cheque | CFCQ         | A              | N              | Broker      | Commission  | CBRK        | A             | N             | CPMM        | A             | N             |             |               |               |             |               |               |             |               |               | Stamp Duty  | Handling fee | Miscellaneous Fee | CTS             | ******      |  ELA98         |    Y               |
	| Loan-Realtime   | NAB2_AUTO | ELA6        | S         | TEST AUTOMATION ELA | Y           | ELA       | N           | N            | A                | 3                | AUS              | 1           | 99999999999999.999999 | W                  | 10       | 00       | Y          | TEST AUTOMATION | Y                | ORD               | VIC                  | BLKUP               | I0030153839     | M                |              |                |                | Y               |             | N                | N               | N                    | S              | N                | Y               | N        | N                  | W                    | N                    | W               | W             | Y                | Y                | P                      | Y                 | Y                 | Y             | W                    | C                   | ESTSC             | ORD                | VIC              |                     |                   |                    |                  | D             | ESSJBW             | Y                  | TSSAL            | Y               | Y               | Y               | Y               | Y              | Y              | Y               | Y            | Y           | Y           | Y               | N                  | N                  | 123451234       | N                   | C                   | AUD                |                  |                  |                  | Y                 | Y                | Y                | Y       | Y       | Y       | Y       | Y         | N         | N         | N         | N                 | N                 | N                 | N                 | Wire        | CWIR        | A             | N             | Direct Banking | CDCR         | A              | N              | Local Cheque | CLCQ         | A              | N              | Foreign Cheque | CFCQ         | A              | N              | Broker      | Commission  | CBRK        | A             | N             | CPMM        | A             | N             |             |               |               |             |               |               |             |               |               | Stamp Duty  | Handling fee | Miscellaneous Fee | CTS             | ******      |  ELA98         |    Y               |

@winformsTest
@HK_ESS_Setups
@29757
@NAB2_AUTO
@FullSmokeTest
Scenario Outline: Test Case 29757: Trade Control Codes for AESS Transfer -[Add]
	Given I have connected to WinForms
	When In SELCOY01 I select the company as "<COY>"
		And I go to "trading control codes" Control Code Menu
		And In TRD24000 I Add Trade Control Details as "<TradingCode>" "<TradeType>" "<TradeDescription>" "<CurrentFlag>" "<ClassCode>" "<InvTradeInd>" "<EventBulkInd>" "<SettlementAction>" "<SettlementPeriod>" "<SettlementRegime>" "<MinimumDeal>" "<MaximumDeal>" "<RecordMoneyORUnits>" "<CutOffHH>" "<CutOffMM>" "<CalcReqInd>" "<ContactDetails>"
		And In TRD24003 I Add Trade Control Details as "<DispExecVenueInd>" "<GenerateAdvices>" "<GenerateCertificates>" "<OnlineEntryInd>" "<ExternalExercise>" "<WebInterfaceInd>" "<AuditInd>" "<AuditSettlingTrans>" "<AllowCorporateBodies>" "<AllowPurchaseResidue>" "<AllowReturnMail>" "<AllowDeceased>" "<AllowPartialSell>" "<AllowSellTOCover>" "<Trd24003TaxResidualInd>" "<AllowCertPartSell>" "<AllowSellSelected>" "<AllowFullSell>" "<AllowForeignResident>"
		And In TRD24004 I Add Transfer Trade Control Details as "<GrossRounding>" "<DefaultPayCurrency>"
		And In TRD24009 I Verify Trade Control Details as "<SmsInd1>" "<SmsInd2>" "<SmsInd3>" "<SmsInd4>" "<EmailInd1>" "<EmailInd2>" "<EmailInd3>" "<EmailInd4>" "<EmailCompanySpec1>" "<EmailCompanySpec2>" "<EmailCompanySpec3>" "<EmailCompanySpec4>"
		And In TRD24007 I Add Transfer Trade Control Details as "<ChargeDesc5>" "<ChargeCode5>"
		And In BILCTL99 I Add Trade Control Details as "<ServiceProvider>" "<ServiceCode>"

Examples: 
	| Plan | COY      | TradingCode | TradeType | TradeDescription    | CurrentFlag | ClassCode | InvTradeInd | EventBulkInd | SettlementAction | SettlementPeriod | SettlementRegime | MinimumDeal | MaximumDeal           | RecordMoneyORUnits | CutOffHH | CutOffMM | CalcReqInd | ContactDetails  | DispExecVenueInd | GenerateAdvices | GenerateCertificates | OnlineEntryInd | ExternalExercise | WebInterfaceInd | AuditInd | AuditSettlingTrans | AllowCorporateBodies | AllowPurchaseResidue | AllowReturnMail | AllowDeceased | AllowPartialSell | AllowSellTOCover | Trd24003TaxResidualInd | AllowCertPartSell | AllowSellSelected | AllowFullSell | AllowForeignResident | GrossRounding | DefaultPayCurrency | SmsInd1 | SmsInd2 | SmsInd3 | SmsInd4 | EmailInd1 | EmailInd2 | EmailInd3 | EmailInd4 | EmailCompanySpec1 | EmailCompanySpec2 | EmailCompanySpec3 | EmailCompanySpec4 | ChargeDesc5       | ChargeCode5 | ServiceProvider | ServiceCode |
	| AESS | NAB2_AUTO | ATS7        | T         | TEST AUTOMATION ATS | Y           | ATS       | N           | N            | A                | 1                | AUS              | 1           | 99999999999999.999999 | W                  | 00       | 00       | N          | TEST AUTOMATION | N                | N               | N                    | N              | N                | Y               | N        | N                  | W                    |                      | W               | W             | Y                |                  |                        | Y                 | Y                 | Y             | W                    | N             | AUD                | N       | N       | N       | N       | N         | N         | N         | N         | N                 | N                 | N                 | N                 | Miscellaneous Fee | CMXC        | CTS             | ******      |


















	