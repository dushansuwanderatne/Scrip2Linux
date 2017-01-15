using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01105

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01105", "FormName");
		//Fields


        public static WinFormsField OptionTerm = new WinFormsField("OPTION-TERM", "OptionTerm");
        public static WinFormsField ExtraDate1 = new WinFormsField("EXTRA-DATE1", "ExtraDate1");
        public static WinFormsField OptionExerciseAfter = new WinFormsField("OPTION-EXERCISE-AFTER", "OptionExerciseAfter");
        public static WinFormsField ExtraDate2 = new WinFormsField("EXTRA-DATE2", "ExtraDate2");
        public static WinFormsField ExtraDate3 = new WinFormsField("EXTRA-DATE3", "ExtraDate3");
        public static WinFormsField OptionIssueDate = new WinFormsField("OPTION-ISSUE-DATE", "OptionIssueDate");
        public static WinFormsField PerfStartDate = new WinFormsField("PERF-START-DATE", "PerfStartDate");
        public static WinFormsField OptionExerciseDate = new WinFormsField("OPTION-EXERCISE-DATE", "OptionExerciseDate");
        public static WinFormsField PercOptions = new WinFormsField("PERC-OPTIONS", "PercOptions");
        public static WinFormsField EXPeriodSTDate = new WinFormsField("EX-PERIOD-ST-DATE", "EXPeriodSTDate");
        public static WinFormsField ResgnExerciseMonths = new WinFormsField("RESGN-EXERCISE-MONTHS", "ResgnExerciseMonths");
        public static WinFormsField TrainsRunRecord = new WinFormsField("TRAINS-RUN-RECORD", "TrainsRunRecord");
        public static WinFormsField EXPeriodEndDate = new WinFormsField("EX-PERIOD-END-DATE", "EXPeriodEndDate");
        public static WinFormsField FirstMeasurementDate = new WinFormsField("FIRST-MEASUREMENT-DATE", "FirstMeasurementDate");
        public static WinFormsField OptionLapseDate = new WinFormsField("OPTION-LAPSE-DATE", "OptionLapseDate");
        public static WinFormsField OptionsProRata = new WinFormsField("OPTIONS-PRO-RATA", "OptionsProRata");
        public static WinFormsField AssocHistClass = new WinFormsField("ASSOC-HIST-CLASS", "AssocHistClass");
        public static WinFormsField ExercisePrice = new WinFormsField("EXERCISE-PRICE", "ExercisePrice");
        public static WinFormsField RoundingProRata = new WinFormsField("ROUNDING-PRO-RATA", "RoundingProRata");
        public static WinFormsField BonusAccrualRate = new WinFormsField("BONUS-ACCRUAL-RATE", "BonusAccrualRate");
        public static WinFormsField ObasisChsInd1 = new WinFormsField("OBASIS-CHS-IND-1", "ObasisChsInd1");
        public static WinFormsField ObasisChsInd2 = new WinFormsField("OBASIS-CHS-IND-2", "ObasisChsInd2");
        public static WinFormsField ObasisChsInd3 = new WinFormsField("OBASIS-CHS-IND-3", "ObasisChsInd3");
        public static WinFormsField ObasisChsInd4 = new WinFormsField("OBASIS-CHS-IND-4", "ObasisChsInd4");
        public static WinFormsField ObasisChsInd5 = new WinFormsField("OBASIS-CHS-IND-5", "ObasisChsInd5");
        public static WinFormsField ObasisChsEXDate1 = new WinFormsField("OBASIS-CHS-EX-DATE-1", "ObasisChsEXDate1");
        public static WinFormsField ObasisChsEXDate2 = new WinFormsField("OBASIS-CHS-EX-DATE-2", "ObasisChsEXDate2");
        public static WinFormsField ObasisChsEXDate3 = new WinFormsField("OBASIS-CHS-EX-DATE-3", "ObasisChsEXDate3");
        public static WinFormsField ObasisChsEXDate4 = new WinFormsField("OBASIS-CHS-EX-DATE-4", "ObasisChsEXDate4");
        public static WinFormsField ObasisChsEXDate5 = new WinFormsField("OBASIS-CHS-EX-DATE-5", "ObasisChsEXDate5");
        public static WinFormsField ObasisChsRecDate1 = new WinFormsField("OBASIS-CHS-REC-DATE-1", "ObasisChsRecDate1");
        public static WinFormsField ObasisChsRecDate2 = new WinFormsField("OBASIS-CHS-REC-DATE-2", "ObasisChsRecDate2");
        public static WinFormsField ObasisChsRecDate3 = new WinFormsField("OBASIS-CHS-REC-DATE-3", "ObasisChsRecDate3");
        public static WinFormsField ObasisChsRecDate4 = new WinFormsField("OBASIS-CHS-REC-DATE-4", "ObasisChsRecDate4");
        public static WinFormsField ObasisChsRecDate5 = new WinFormsField("OBASIS-CHS-REC-DATE-5", "ObasisChsRecDate5");
        public static WinFormsField ObasisReg1 = new WinFormsField("OBASIS-REG-1", "ObasisReg1");
        public static WinFormsField ObasisReg2 = new WinFormsField("OBASIS-REG-2", "ObasisReg2");
        public static WinFormsField ObasisReg3 = new WinFormsField("OBASIS-REG-3", "ObasisReg3");
        public static WinFormsField ObasisReg4 = new WinFormsField("OBASIS-REG-4", "ObasisReg4");
        public static WinFormsField ObasisReg5 = new WinFormsField("OBASIS-REG-5", "ObasisReg5");
        public static WinFormsField TermInd1 = new WinFormsField("TERM-IND-1", "TermInd1");
        public static WinFormsField TermInd2 = new WinFormsField("TERM-IND-2", "TermInd2");
        public static WinFormsField TermInd3 = new WinFormsField("TERM-IND-3", "TermInd3");
        public static WinFormsField TermInd4 = new WinFormsField("TERM-IND-4", "TermInd4");
        public static WinFormsField TermInd5 = new WinFormsField("TERM-IND-5", "TermInd5");
        public static WinFormsField TermDate1 = new WinFormsField("TERM-DATE-1", "TermDate1");
        public static WinFormsField TermDate2 = new WinFormsField("TERM-DATE-2", "TermDate2");
        public static WinFormsField TermDate3 = new WinFormsField("TERM-DATE-3", "TermDate3");
        public static WinFormsField TermDate4 = new WinFormsField("TERM-DATE-4", "TermDate4");
        public static WinFormsField TermDate5 = new WinFormsField("TERM-DATE-5", "TermDate5");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField NominalVotingValue = new WinFormsField("NOMINAL-VOTING-VALUE", "NominalVotingValue");
        public static WinFormsField TOCumhisImm = new WinFormsField("TO-CUMHIS-IMM", "TOCumhisImm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
