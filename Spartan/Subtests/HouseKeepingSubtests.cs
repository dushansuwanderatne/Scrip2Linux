using System;
using System.Linq;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class HouseKeepingSubtests
    {
        public HouseKeepingSubtests()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }

        [When(@"In EHK01001 I click on: ""(.*)"" within the System Menu")]
        public void ClickWithinTheESSHousekeepingMenu(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "plan setup":
                    EHK01001.MenuItemSch.ClickField();
                    break;

                case "housekeeping system":
                    MNS00101.HousekeepingSystem.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In EHK01002 I Add Plan Setup Details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01002AddPlanSetupDetails(string ClassCode, string SchemeType, string ClassDescription)
        {
            EHK01002.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01002.ClassCode.SetValue(ClassCode);
            EHK01002.SchemeType.SetValue(SchemeType);
            EHK01002.ClassDescription.SetValue(ClassDescription);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EHK01003 I Add ESS Plan Steup Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01003AddESSPlanSteupDetails(string FinalSecurity, string CountryOFTaxation, string PlanType, string TrusteeAccountID, string UnapAccountID, string BlkoutPeriodInd, string MatchWorkingClass, string MarketValueInd, string TaxTypeInd, string SingleCert, string ForfeitureType, string AutoForfeit, string DivReinvestment, string PlanConcept, string PlanCategory, string LeaverPackInd, string RetirementAge)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01003");
            EHK01003.FinalSecurity.SetValue(FinalSecurity);
            EHK01003.CountryOFTaxation.SetValue(CountryOFTaxation);
            EHK01003.PlanType.SetValue(PlanType);
            EHK01003.TrusteeAccountID.SetValue(TrusteeAccountID);
            EHK01003.UnapAccountID.SetValue(UnapAccountID);
            EHK01003.BlkoutPeriodInd.SetValue(BlkoutPeriodInd);
            EHK01003.MatchWorkingClass.SetValue(MatchWorkingClass);
            EHK01003.MarketValueInd.SetValue(MarketValueInd);

            EHK01003.TaxTypeInd.SetValue(TaxTypeInd);

            if (TaxTypeInd == "D")
            {
                EHK01003.TaxTypeInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EHK01003.ForfeitureType.SetValue(1, ForfeitureType);
                EHK01003.AutoForfeit.SetValue(AutoForfeit);
            }

            EHK01003.SingleCert.SetValue(SingleCert);
            EHK01003.DivReinvestment.SetValue(DivReinvestment);
            EHK01003.DivReinvestment.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            EHK01003.PlanConcept.SetValue(PlanConcept);
            EHK01003.PlanCategory.SetValue(PlanCategory);
            EHK01003.LeaverPackInd.SetValue(LeaverPackInd);
            EHK01003.RetirementAge.SetValue(RetirementAge);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01003");

            EHK01003.FinalSecurity.ValidateFieldValue(FinalSecurity);
            EHK01003.CountryOFTaxation.ValidateFieldValue(CountryOFTaxation);
            EHK01003.PlanType.ValidateFieldValue(PlanType);
            EHK01003.TrusteeAccountID.ValidateFieldValue(TrusteeAccountID);
            EHK01003.UnapAccountID.ValidateFieldValue(UnapAccountID);
            EHK01003.BlkoutPeriodInd.ValidateFieldValue(BlkoutPeriodInd);
            EHK01003.MatchWorkingClass.ValidateFieldValue(MatchWorkingClass);
            EHK01003.MarketValueInd.ValidateFieldValue(MarketValueInd);
            EHK01003.TaxTypeInd.ValidateFieldValue(TaxTypeInd);

            if (TaxTypeInd == "D")
            {
                EHK01003.ForfeitureType.ValidateFieldValue(1, ForfeitureType);
                EHK01003.AutoForfeit.ValidateFieldValue(AutoForfeit);
            }

            EHK01003.SingleCert.ValidateFieldValue(SingleCert);
            EHK01003.DivReinvestment.ValidateFieldValue(DivReinvestment);
            EHK01003.PlanConcept.ValidateFieldValue(PlanConcept);
            EHK01003.PlanCategory.ValidateFieldValue(PlanCategory);
            EHK01003.LeaverPackInd.ValidateFieldValue(LeaverPackInd);
            EHK01003.RetirementAge.ValidateFieldValue(RetirementAge);
        }

        [When(@"In EHK01004 I Add Loan Plan Steup Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01004AddLoanPlanSteupDetails(string FinalSecurity, string CountryOFTaxation, string PlanType, string TrusteeAccountID, string UnapAccountID, string BlkoutPeriodInd, string UseBlkoutCodeInd, string BlkoutCode, string MarketValueInd, string PaymentType1, string PaymentType2, string PaymentType3, string LoanDividendOption, string MaxLimitAmount, string LimitType, string LeaverPackInd)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01004");
            EHK01004.FinalSecurity.SetValue(FinalSecurity);
            EHK01004.CountryOFTaxation.SetValue(CountryOFTaxation);
            EHK01004.PlanType.SetValue(PlanType);
            EHK01004.TrusteeAccountID.SetValue(TrusteeAccountID);
            EHK01004.UnapAccountID.SetValue(UnapAccountID);

            EHK01004.BlkoutPeriodInd.SetValue(BlkoutPeriodInd);
            EHK01004.UseBlkoutCodeInd.SetValue(UseBlkoutCodeInd);
            if (UseBlkoutCodeInd == "Y")
            {
                EHK01004.UseBlkoutCodeInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EHK01004.BlkoutCode.SetValue(BlkoutCode);
            }

            EHK01004.MarketValueInd.SetValue(MarketValueInd);
            EHK01004.PaymentType.SetValue(1, PaymentType1);
            EHK01004.PaymentType.SetValue(2, PaymentType2);
            EHK01004.PaymentType.SetValue(3, PaymentType3);
            EHK01004.LoanDividendOption.SetValue(LoanDividendOption);
            EHK01004.MaxLimitAmount.SetValue(MaxLimitAmount);
            EHK01004.LimitType.SetValue(LimitType);
            EHK01004.LeaverPackInd.SetValue(LeaverPackInd);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01004");

            EHK01004.FinalSecurity.ValidateFieldValue(FinalSecurity);
            EHK01004.CountryOFTaxation.ValidateFieldValue(CountryOFTaxation);
            EHK01004.PlanType.ValidateFieldValue(PlanType);
            EHK01004.TrusteeAccountID.ValidateFieldValue(TrusteeAccountID);
            EHK01004.UnapAccountID.ValidateFieldValue(UnapAccountID);
            EHK01004.BlkoutPeriodInd.ValidateFieldValue(BlkoutPeriodInd);
            EHK01004.UseBlkoutCodeInd.ValidateFieldValue(UseBlkoutCodeInd);

            if (UseBlkoutCodeInd == "Y")
            {
                EHK01004.BlkoutCode.ValidateFieldValue(BlkoutCode);
            }

            EHK01004.MarketValueInd.ValidateFieldValue(MarketValueInd);
            EHK01004.PaymentType.ValidateFieldValue(1, PaymentType1);
            EHK01004.PaymentType.ValidateFieldValue(2, PaymentType2);
            EHK01004.PaymentType.ValidateFieldValue(3, PaymentType3);
            EHK01004.LoanDividendOption.ValidateFieldValue(LoanDividendOption);
            EHK01004.MaxLimitAmount.ValidateFieldValue(MaxLimitAmount);
            EHK01004.LimitType.ValidateFieldValue(LimitType);
            EHK01004.LeaverPackInd.ValidateFieldValue(LeaverPackInd);
        }

        [When(@"In EHK01005 I Add Executive Options Plan Steup Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01005AddExecutiveOptionsPlanSteupDetails(string FinalSecurity, string CountryOFTaxation, string PlanType, string TrusteeAccountID, string UnapAccountID, string BlkoutPeriodInd, string MarketValueInd, string NilCostOptionInd, string PhantomOptionInd, string ONMktPurchInd, string VsaXferAllowedInd, string LeaverPackInd, string ExpiryNoticeINUrr)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01005");
            EHK01005.FinalSecurity.SetValue(FinalSecurity);
            EHK01005.CountryOFTaxation.SetValue(CountryOFTaxation);
            EHK01005.PlanType.SetValue(PlanType);
            EHK01005.TrusteeAccountID.SetValue(TrusteeAccountID);
            EHK01005.UnapAccountID.SetValue(UnapAccountID);
            EHK01005.BlkoutPeriodInd.SetValue(BlkoutPeriodInd);
            EHK01005.MarketValueInd.SetValue(MarketValueInd);
            EHK01005.NilCostOptionInd.SetValue(NilCostOptionInd);
            EHK01005.PhantomOptionInd.SetValue(PhantomOptionInd);
            EHK01005.ONMktPurchInd.SetValue(ONMktPurchInd);
            EHK01005.VsaXferAllowedInd.SetValue(VsaXferAllowedInd);
            EHK01005.LeaverPackInd.SetValue(LeaverPackInd);
            EHK01005.ExpiryNoticeINUrr.SetValue(ExpiryNoticeINUrr);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01005");

            EHK01005.FinalSecurity.ValidateFieldValue(FinalSecurity);
            EHK01005.CountryOFTaxation.ValidateFieldValue(CountryOFTaxation);
            EHK01005.PlanType.ValidateFieldValue(PlanType);
            EHK01005.TrusteeAccountID.ValidateFieldValue(TrusteeAccountID);
            EHK01005.UnapAccountID.ValidateFieldValue(UnapAccountID);
            EHK01005.BlkoutPeriodInd.ValidateFieldValue(BlkoutPeriodInd);
            EHK01005.MarketValueInd.ValidateFieldValue(MarketValueInd);
            EHK01005.NilCostOptionInd.ValidateFieldValue(NilCostOptionInd);
            EHK01005.PhantomOptionInd.ValidateFieldValue(PhantomOptionInd);
            EHK01005.ONMktPurchInd.ValidateFieldValue(ONMktPurchInd);
            EHK01005.VsaXferAllowedInd.ValidateFieldValue(VsaXferAllowedInd);
            EHK01005.LeaverPackInd.ValidateFieldValue(LeaverPackInd);
            EHK01005.ExpiryNoticeINUrr.ValidateFieldValue(ExpiryNoticeINUrr);
        }

        [When(@"In EHK01006 I Add Award Setup Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01006AddAwardSetupDetails(string RegisterCode, string RegisterDescription, string ExpiresAfterMonths, string ExpiresAfterDays, string UsingVestingInd, string UnitRounding, string MoneyRounding, string ReleaseOption1, string CalculateTaxInd, string BaseCurrency, string MinMaxType, string MinMoneyAmt, string MaxMoneyAmt, string RegisterType, string TaxReportableInd, string LeaverSchedule)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01006");
            EHK01006.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01006.RegisterCode.SetValue(RegisterCode);
            EHK01006.RegisterDescription.SetValue(RegisterDescription);
            EHK01006.ExpiresAfterMonths.SetValue(ExpiresAfterMonths);
            EHK01006.ExpiresAfterDays.SetValue(ExpiresAfterDays);
            EHK01006.UsingVestingInd.SetValue(UsingVestingInd);
            EHK01006.UnitRounding.SetValue(UnitRounding);
            EHK01006.MoneyRounding.SetValue(MoneyRounding);
            EHK01006.ReleaseOption.SetValue(1, ReleaseOption1);
            EHK01006.CalculateTaxInd.SetValue(CalculateTaxInd);
            EHK01006.BaseCurrency.SetValue(BaseCurrency);
            EHK01006.MinMaxType.SetValue(MinMaxType);
            EHK01006.MinMoneyAmt.SetValue(MinMoneyAmt);
            EHK01006.MaxMoneyAmt.SetValue(MaxMoneyAmt);
            EHK01006.RegisterType.SetValue(RegisterType);
            EHK01006.TaxReportableInd.SetValue(TaxReportableInd);
            EHK01006.LeaverSchedule.SetValue(LeaverSchedule);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01006");

            EHK01006.RegisterCode.ValidateFieldValue(RegisterCode);
            EHK01006.RegisterDescription.ValidateFieldValue(RegisterDescription);
            EHK01006.ExpiresAfterMonths.ValidateFieldValue(ExpiresAfterMonths);
            EHK01006.ExpiresAfterDays.ValidateFieldValue(ExpiresAfterDays);
            EHK01006.UsingVestingInd.ValidateFieldValue(UsingVestingInd);
            EHK01006.UnitRounding.ValidateFieldValue(UnitRounding);
            EHK01006.MoneyRounding.ValidateFieldValue(MoneyRounding);
            EHK01006.ReleaseOption.ValidateFieldValue(1, ReleaseOption1);
            EHK01006.CalculateTaxInd.ValidateFieldValue(CalculateTaxInd);
            EHK01006.BaseCurrency.ValidateFieldValue(BaseCurrency);
            EHK01006.MinMaxType.ValidateFieldValue(MinMaxType);
            EHK01006.MinMoneyAmt.ValidateFieldValue(MinMoneyAmt);
            EHK01006.MaxMoneyAmt.ValidateFieldValue(MaxMoneyAmt);
            EHK01006.RegisterType.ValidateFieldValue(RegisterType);
            EHK01006.TaxReportableInd.ValidateFieldValue(TaxReportableInd);
            EHK01006.LeaverSchedule.ValidateFieldValue(LeaverSchedule);
        }

        [When(@"In EHK01007 I Add ESS Award Setup Details1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01007AddESSAwardSetupDetails1(string RegisterCode, string RegisterDescription, string UsingIndDatesInd, string RetentionPeriod, string RetentionPeriodDays, string TaxRetentionPeriod, string TaxRetentionPerDays, string FirstAwardDate, string UnitRounding, string MoneyRounding, string ReleaseOption1, string CalculateTaxInd, string BaseCurrency, string UsingMatchingInd, string UsingUnmatchedInd, string MatchingUpfrontInd)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01007");
            EHK01007.RegisterCode.SetValue(RegisterCode);
            EHK01007.RegisterDescription.SetValue(RegisterDescription);
            EHK01007.UsingIndDatesInd.SetValue(UsingIndDatesInd);
            EHK01007.RetentionPeriod.SetValue(RetentionPeriod);
            EHK01007.RetentionPeriodDays.SetValue(RetentionPeriodDays);
            EHK01007.TaxRetentionPeriod.SetValue(TaxRetentionPeriod);
            EHK01007.TaxRetentionPerDays.SetValue(TaxRetentionPerDays);
            EHK01007.FirstAwardDate.SetValue(FirstAwardDate);
            EHK01007.UnitRounding.SetValue(UnitRounding);
            EHK01007.MoneyRounding.SetValue(MoneyRounding);
            EHK01007.ReleaseOption.SetValue(ReleaseOption1);
            EHK01007.CalculateTaxInd.SetValue(CalculateTaxInd);
            EHK01007.BaseCurrency.SetValue(BaseCurrency);
            EHK01007.UsingMatchingInd.SetValue(UsingMatchingInd);
            EHK01007.UsingUnmatchedInd.SetValue(UsingUnmatchedInd);
            EHK01007.MatchingUpfrontInd.SetValue(MatchingUpfrontInd);
        }

        [When(@"In EHK01008 I Add Award Setup Details as ""(.*)""")]
        public void EHK01008AddAwardSetupDetails(string RegisterType2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01008");
            EHK01008.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01008.RegisterType2.SetValue(RegisterType2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EHK01009 I Add Award Setup Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01009AddAwardSetupDetails(string RegisterCode, string RegisterDescription, string UsingIndDatesInd, string TermINMonths, string TermINDays, string RetentionPeriod, string RetentionPeriodDays, string MinAmount, string MaxAmount, string PaymentAccount, string RecourseInd, string MoneyRounding, string ReleaseOption1, string StatusType1, string BaseCurrency, string TaxReportableInd, string LeaverSchedule)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01009");
            EHK01009.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01009.RegisterCode.SetValue(RegisterCode);
            EHK01009.RegisterDescription.SetValue(RegisterDescription);
            EHK01009.UsingIndDatesInd.SetValue(UsingIndDatesInd);
            EHK01009.TermINMonths.SetValue(TermINMonths);
            EHK01009.TermINDays.SetValue(TermINDays);
            EHK01009.RetentionPeriod.SetValue(RetentionPeriod);
            EHK01009.RetentionPeriodDays.SetValue(RetentionPeriodDays);
            EHK01009.MinAmount.SetValue(MinAmount);
            EHK01009.MaxAmount.SetValue(MaxAmount);
            EHK01009.PaymentAccount.SetValue(PaymentAccount);
            EHK01009.RecourseInd.SetValue(RecourseInd);
            EHK01009.MoneyRounding.SetValue(MoneyRounding);
            EHK01009.ReleaseOption.SetValue(1, ReleaseOption1);
            EHK01009.StatusType.SetValue(1, StatusType1);
            EHK01009.BaseCurrency.SetValue(BaseCurrency);
            EHK01009.TaxReportableInd.SetValue(TaxReportableInd);
            EHK01009.LeaverSchedule.SetValue(LeaverSchedule);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01009");
        }

        [When(@"In EHK01010 I Add Control Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01010AddControlSetup(string RegisterCode, string StartDate, string UnitValue, string AwardExchangeRate, string SavingsCarrierInd, string RegisterType2, string ReportUpdateMode, string EnabledDisabledInd, string DisplayONWebInd)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01010");
            EHK01006.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01010.RegisterCode.SetValue(RegisterCode);
            EHK01010.StartDate.SetValue(StartDate);
            EHK01010.UnitValue.SetValue(UnitValue);
            EHK01010.AwardExchangeRate.SetValue(AwardExchangeRate);
            EHK01010.RegisterType2.SetValue(RegisterType2);

            if (RegisterType2 == "B")
            {
                EHK01010.SavingsCarrierInd.SetValue(SavingsCarrierInd);
            }
            EHK01010.ReportUpdateMode.SetValue(ReportUpdateMode);
            EHK01010.EnabledDisabledInd.SetValue(EnabledDisabledInd);
            EHK01010.DisplayONWebInd.SetValue(DisplayONWebInd);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01010");

            EHK01010.RegisterCode.ValidateFieldValue(RegisterCode);
            EHK01010.StartDate.ValidateFieldValue(StartDate);
            EHK01010.UnitValue.ValidateFieldValue(UnitValue);
            EHK01010.AwardExchangeRate.ValidateFieldValue(AwardExchangeRate);
            EHK01010.RegisterType2.ValidateFieldValue(RegisterType2);

            if (RegisterType2 == "B")
            {
                EHK01010.SavingsCarrierInd.ValidateFieldValue(SavingsCarrierInd);
            }

            EHK01010.ReportUpdateMode.ValidateFieldValue(ReportUpdateMode);
            EHK01010.EnabledDisabledInd.ValidateFieldValue(EnabledDisabledInd);
            EHK01010.DisplayONWebInd.ValidateFieldValue(DisplayONWebInd);
        }

        [When(@"In EHK01012 I Add Control Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01012AddControlSetup(string RegisterCode, string StartDate, string UnitValue, string EndDate, string AwardExchangeRate, string DisplayONWebInd, string RegisterType2, string ReportUpdateMode, string EnabledDisabledInd, string VestingCode, string VestingStartDate, string PerformanceHurdles, string PerformanceCode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01012");
            EHK01012.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01012.RegisterCode.SetValue(RegisterCode);
            EHK01012.StartDate.SetValue(StartDate);
            EHK01012.UnitValue.SetValue(UnitValue);
            EHK01012.EndDate.SetValue(EndDate);
            EHK01012.AwardExchangeRate.SetValue(AwardExchangeRate);
            EHK01012.DisplayONWebInd.SetValue(DisplayONWebInd);
            EHK01012.RegisterType2.SetValue(RegisterType2);
            EHK01012.ReportUpdateMode.SetValue(ReportUpdateMode);
            EHK01012.EnabledDisabledInd.SetValue(EnabledDisabledInd);
            EHK01012.VestingCode.SetValue(VestingCode);
            EHK01012.VestingStartDate.SetValue(VestingStartDate);
            EHK01012.PerformanceHurdles.SetValue(PerformanceHurdles);

            if (PerformanceHurdles == "Y")
            {
                EHK01012.PerformanceHurdles.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EHK01012.PerformanceCode.SetValue(PerformanceCode);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01012");

            EHK01012.RegisterCode.ValidateFieldValue(RegisterCode);
            EHK01012.StartDate.ValidateFieldValue(StartDate);
            EHK01012.UnitValue.ValidateFieldValue(UnitValue);
            EHK01012.EndDate.ValidateFieldValue(EndDate);
            EHK01012.AwardExchangeRate.ValidateFieldValue(AwardExchangeRate);
            EHK01012.DisplayONWebInd.ValidateFieldValue(DisplayONWebInd);
            EHK01012.RegisterType2.ValidateFieldValue(RegisterType2);
            EHK01012.ReportUpdateMode.ValidateFieldValue(ReportUpdateMode);
            EHK01012.EnabledDisabledInd.ValidateFieldValue(EnabledDisabledInd);
            EHK01012.VestingCode.ValidateFieldValue(VestingCode);
            EHK01012.VestingStartDate.ValidateFieldValue(VestingStartDate);
            EHK01012.PerformanceHurdles.ValidateFieldValue(PerformanceHurdles);

            if (PerformanceHurdles == "Y")
            {
                EHK01012.PerformanceCode.ValidateFieldValue(PerformanceCode);
            }
        }

        [When(@"In EHK01013 I Add ESS Event Control Setup as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01013AddESSEventControlSetup(string EventType, string EventCode, string EventDescription)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01013");
            EHK01013.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01013.EventType.SetValue(EventType);
            EHK01013.EventCode.SetValue(EventCode);
            EHK01013.EventDescription.SetValue(EventDescription);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01013");
            EHK01013.EventType.ValidateFieldValue(EventType);
            EHK01013.EventCode.ValidateFieldValue(EventCode);
            EHK01013.EventDescription.ValidateFieldValue(EventDescription);
        }

        [When(@"In EHK01014 I Add ESS Event Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01014AddESSEventSetup(string EventType, string EventCode, string EventDate, string EvtPeriodSta, string EvtPeriodEnd, string EventCurrentInd, string EventClosedInd, string ClassCode, string RegisterCode1, string RegisterCode2, string RegisterType1, string RegisterType2, string IncludeLeaversInd, string IncldBlktHldrInd, string HolderSelctnInd)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01014");
            EHK01014.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01014.EventType.SetValue(EventType);
            EHK01014.EventType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            EHK01014.EventCode.SetValue(EventCode);
            EHK01014.EventDate.SetValue(EventDate);
            EHK01014.EvtPeriodSta.SetValue(EvtPeriodSta);
            EHK01014.EvtPeriodEnd.SetValue(EvtPeriodEnd);
            EHK01014.EventCurrentInd.SetValue(EventCurrentInd);
            EHK01014.EventClosedInd.SetValue(EventClosedInd);
            EHK01014.ClassCode.SetValue(ClassCode);
            EHK01014.RegisterCode.SetValue(1, RegisterCode1);
            EHK01014.RegisterCode.SetValue(2, RegisterCode2);
            EHK01014.RegisterType.SetValue(1, RegisterType1);
            EHK01014.RegisterType.SetValue(2, RegisterType2);

            if (EventType == "V")
            {
                EHK01014.IncludeLeaversInd.SetValue(IncludeLeaversInd);
                EHK01014.IncldBlktHldrInd.SetValue(IncldBlktHldrInd);
                EHK01014.HolderSelctnInd.SetValue(HolderSelctnInd);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01045");

            EHK01045.EventType.ValidateFieldValue(EventType);
            EHK01045.EventCode.ValidateFieldValue(EventCode);
            EHK01045.EventDate.ValidateFieldValue(EventDate);
            EHK01045.EvtPeriodSta.ValidateFieldValue(EvtPeriodSta);
            EHK01045.EvtPeriodEnd.ValidateFieldValue(EvtPeriodEnd);
            EHK01045.EventCurrentInd.ValidateFieldValue(EventCurrentInd);
            EHK01045.EventClosedInd.ValidateFieldValue(EventClosedInd);
        }

        [When(@"In EHK01014 I Add ESS T Type Event Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01014AddESSTTypeEventSetup(string EventType, string EventCode, string EventDate, string EvtPeriodSta, string EvtPeriodEnd, string EventCurrentInd, string EventClosedInd, string ClassCode, string RegisterCode1, string RegisterCode2, string RegisterType1, string RegisterType2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01014");
            EHK01014.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            EHK01014.EventType.SetValue(EventType);
            EHK01014.EventCode.SetValue(EventCode);
            EHK01014.EventDate.SetValue(EventDate);
            EHK01014.EvtPeriodSta.SetValue(EvtPeriodSta);
            EHK01014.EvtPeriodEnd.SetValue(EvtPeriodEnd);
            EHK01014.EventCurrentInd.SetValue(EventCurrentInd);
            EHK01014.EventClosedInd.SetValue(EventClosedInd);
            EHK01014.ClassCode.SetValue(ClassCode);
            EHK01014.RegisterCode.SetValue(1, RegisterCode1);
            EHK01014.RegisterCode.SetValue(2, RegisterCode2);
            EHK01014.RegisterType.SetValue(1, RegisterType1);
            EHK01014.RegisterType.SetValue(2, RegisterType2);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01014");

            EHK01014.EventType.ValidateFieldValue(EventType);
            EHK01014.EventCode.ValidateFieldValue(EventCode);
            EHK01014.EventDate.ValidateFieldValue(EventDate);
            EHK01014.EvtPeriodSta.ValidateFieldValue(EvtPeriodSta);
            EHK01014.EvtPeriodEnd.ValidateFieldValue(EvtPeriodEnd);
            EHK01014.EventCurrentInd.ValidateFieldValue(EventCurrentInd);
            EHK01014.EventClosedInd.ValidateFieldValue(EventClosedInd);
            EHK01014.ClassCode.ValidateFieldValue(ClassCode);
            EHK01014.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EHK01014.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EHK01014.RegisterType.ValidateFieldValue(1, RegisterType1);
            EHK01014.RegisterType.ValidateFieldValue(2, RegisterType2);
        }

        [When(@"In EHK01016 I Add Deduction Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01016AddDeductionSetup(string RegisterCode, string RegisterType, string PaymentFrequency, string AccumPeriod, string AccumStartDate, string AccumEndDate, string MaxNumberPayments)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01016");
            EHK01016.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01016.RegisterCode.SetValue(RegisterCode);
            EHK01016.RegisterType.SetValue(RegisterType);
            EHK01016.PaymentFrequency.SetValue(PaymentFrequency);
            EHK01016.AccumPeriod.SetValue(AccumPeriod);
            EHK01016.AccumStartDate.SetValue(AccumStartDate);
            EHK01016.AccumEndDate.SetValue(AccumEndDate);
            EHK01016.MaxNumberPayments.SetValue(MaxNumberPayments);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01016");

            EHK01016.RegisterCode.ValidateFieldValue(RegisterCode);
            EHK01016.RegisterType.ValidateFieldValue(RegisterType);
            EHK01016.PaymentFrequency.ValidateFieldValue(PaymentFrequency);
            EHK01016.AccumPeriod.ValidateFieldValue(AccumPeriod);
            EHK01016.AccumStartDate.ValidateFieldValue(AccumStartDate);
            EHK01016.AccumEndDate.ValidateFieldValue(AccumEndDate);
            EHK01016.MaxNumberPayments.ValidateFieldValue(MaxNumberPayments);
        }

        [When(@"In EHK01020 I Add Modify VWAP File as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01020AddModifyVWAPFile(string FinalSecurity, string VwapDate, string ExchangeCode, string OnedayVwap, string OnedayTradeVolume, string MultiDayVwap, string ClosingPrice, string ConversionRate, string MultiDayVwapDesc, string IsinNumber, string CurrencyCode, string TradingDayInd, string LastUpdatedBY)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01020");
            EHK01037.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            EHK01020.FinalSecurity.SetValue(FinalSecurity);
            EHK01020.VwapDate.SetValue(VwapDate);
            EHK01020.ExchangeCode.SetValue(ExchangeCode);
            EHK01020.OnedayVwap.SetValue(OnedayVwap);
            EHK01020.OnedayTradeVolume.SetValue(OnedayTradeVolume);
            EHK01020.MultiDayVwap.SetValue(MultiDayVwap);
            EHK01020.ClosingPrice.SetValue(ClosingPrice);
            EHK01020.ConversionRate.SetValue(ConversionRate);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01020");

            EHK01020.FinalSecurity.ValidateFieldValue(FinalSecurity);
            EHK01020.VwapDate.ValidateFieldValue(VwapDate);
            EHK01020.ExchangeCode.ValidateFieldValue(ExchangeCode);
            EHK01020.OnedayVwap.ValidateFieldValue(OnedayVwap);
            EHK01020.OnedayTradeVolume.ValidateFieldValue(OnedayTradeVolume);
            EHK01020.MultiDayVwap.ValidateFieldValue(MultiDayVwap);
            EHK01020.ClosingPrice.ValidateFieldValue(ClosingPrice);
            EHK01020.ConversionRate.ValidateFieldValue(ConversionRate);
            EHK01020.MultiDayVwapDesc.ValidateFieldValue(MultiDayVwapDesc);
            EHK01020.IsinNumber.ValidateFieldValue(IsinNumber);
            EHK01020.CurrencyCode.ValidateFieldValue(CurrencyCode);
            EHK01020.TradingDayInd.ValidateFieldValue(TradingDayInd);
            EHK01020.LastUpdatedBY.ValidateFieldValue(LastUpdatedBY);
        }

        [When(@"In EHK01025 I Add Blackout Schedule Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01025AddBlackoutScheduleSetup(string BlkoutCode, string BlkoutDescription, string BlkoutRstrctdCode, string BlkoutStartDate, string BlkoutEndDate, string SaleRestriction, string TransferRestriction, string AllowPendingCancel, string RestrictLimitOrders)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01025");
            EHK01026.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            EHK01025.BlkoutCode.SetValue(BlkoutCode);
            EHK01025.BlkoutDescription.SetValue(BlkoutDescription);
            EHK01025.BlkoutRstrctdCode.SetValue(BlkoutRstrctdCode);
            EHK01025.BlkoutStartDate.SetValue(BlkoutStartDate);
            EHK01025.BlkoutEndDate.SetValue(BlkoutEndDate);
            EHK01025.SaleRestriction.SetValue(SaleRestriction);
            EHK01025.TransferRestriction.SetValue(TransferRestriction);
            EHK01025.AllowPendingCancel.SetValue(AllowPendingCancel);
            EHK01025.RestrictLimitOrders.SetValue(RestrictLimitOrders);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01025");

            EHK01025.BlkoutCode.ValidateFieldValue(BlkoutCode);
            EHK01025.BlkoutDescription.ValidateFieldValue(BlkoutDescription);
            EHK01025.BlkoutRstrctdCode.ValidateFieldValue(BlkoutRstrctdCode);
            EHK01025.BlkoutStartDate.ValidateFieldValue(BlkoutStartDate);
            EHK01025.BlkoutEndDate.ValidateFieldValue(BlkoutEndDate);
            EHK01025.SaleRestriction.ValidateFieldValue(SaleRestriction);
            EHK01025.TransferRestriction.ValidateFieldValue(TransferRestriction);
            EHK01025.AllowPendingCancel.ValidateFieldValue(AllowPendingCancel);
            EHK01025.RestrictLimitOrders.ValidateFieldValue(RestrictLimitOrders);
        }

        [When(@"In EHK01026 I Add Blackout Restricted Codes as ""(.*)"" ""(.*)""")]
        public void EHK01026AddBlackoutRestrictedCodes(string BlkoutRstrctdCode, string BlkoutRstrctdDesc)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01026");
            EHK01026.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01026.BlkoutRstrctdCode.SetValue(BlkoutRstrctdCode);
            EHK01026.BlkoutRstrctdDesc.SetValue(BlkoutRstrctdDesc);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01026");
        }

        [When(@"In EHK01030 I Add ESS Direct Credit Code as ""(.*)""")]
        public void EHK01030AddESSDirectCreditCode(string AddKey)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01030");
            EHK01030.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01030.AddKey.SetValue(AddKey);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EHK01032 I Add ESS Direct Credit Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01032AddESSDirectCreditDetails(string BulkPayDesc, string HomeBankDesc, string CemtexUserNum, string OverrideTranType, string PaymentDescription, string HeaderRemitterName, string TraceBsb1to3, string TraceBsb5to7, string TraceAccount, string TransRemitterName, string LodgementSuffix, string AusDirectCredtEft1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01032");
            EHK01032.BulkPayDesc.SetValue(BulkPayDesc);
            EHK01032.HomeBankDesc.SetValue(HomeBankDesc);
            EHK01032.CemtexUserNum.SetValue(CemtexUserNum);
            EHK01032.OverrideTranType.SetValue(OverrideTranType);
            EHK01032.PaymentDescription.SetValue(PaymentDescription);
            EHK01032.HeaderRemitterName.SetValue(HeaderRemitterName);
            EHK01032.TraceBsb1to3.SetValue(TraceBsb1to3);
            EHK01032.TraceBsb5to7.SetValue(TraceBsb5to7);
            EHK01032.TraceAccount.SetValue(TraceAccount);
            EHK01032.TransRemitterName.SetValue(TransRemitterName);
            EHK01032.LodgementSuffix.SetValue(LodgementSuffix);
            EHK01032.AusDirectCredtEft1.SetValue(AusDirectCredtEft1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01030");

            EHK01030.BulkPayDesc.ValidateFieldValue(BulkPayDesc);
            EHK01030.HomeBankDesc.ValidateFieldValue(HomeBankDesc);
            EHK01030.CemtexUserNum.ValidateFieldValue(CemtexUserNum);
            EHK01030.OverrideTranType.ValidateFieldValue(OverrideTranType);
            EHK01030.PaymentDescription.ValidateFieldValue(PaymentDescription);
            EHK01030.HeaderRemitterName.ValidateFieldValue(HeaderRemitterName);
            EHK01030.TraceBsb1to3.ValidateFieldValue(TraceBsb1to3);
            EHK01030.TraceBsb5to7.ValidateFieldValue(TraceBsb5to7);
            EHK01030.TraceAccount.ValidateFieldValue(TraceAccount);
            EHK01030.TransRemitterName.ValidateFieldValue(TransRemitterName);
            EHK01030.LodgementSuffix.ValidateFieldValue(LodgementSuffix);
            EHK01030.AusDirectCredtEft1.ValidateFieldValue(AusDirectCredtEft1);
        }

        [When(@"In EHK01034 I Add AESS Leaver Schedule Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01034AddAESSLeaverScheduleSetup(string LeaverSchedule, string LeaverScheduleDesc, string LeaverCode, string EmployeeStatus, string LeaverEffectInd, string PhantomLeaverType, string RelsONEmpEndInd, string ForfImmInd, string AccelerateAvailInd, string AccelerateMonths, string AccelerateDays, string AccelFrmDateInd, string CommentsLine1, string LeaverCodeDesc, string EmpStatusDesc)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01034");
            EHK01034.LeaverSchedule.SetValue(LeaverSchedule);
            EHK01034.LeaverScheduleDesc.SetValue(LeaverScheduleDesc);
            EHK01034.LeaverCode.SetValue(LeaverCode);
            EHK01034.EmployeeStatus.SetValue(EmployeeStatus);
            EHK01034.LeaverEffectInd.SetValue(LeaverEffectInd);
            EHK01034.CommentsLine1.SetValue(CommentsLine1);
            EHK01034.PhantomLeaverType.SetValue(PhantomLeaverType);

            if (LeaverEffectInd == "L")
            {
                EHK01034.LeaverEffectInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EHK01034.RelsONEmpEndInd.SetValue(RelsONEmpEndInd);
                EHK01034.ForfImmInd.SetValue(ForfImmInd);
                EHK01034.AccelerateAvailInd.SetValue(AccelerateAvailInd);
                EHK01034.AccelerateMonths.SetValue(AccelerateMonths);
                EHK01034.AccelerateDays.SetValue(AccelerateDays);
                EHK01034.AccelFrmDateInd.SetValue(AccelFrmDateInd);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01034");
            EHK01034.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
            EHK01034.EmpStatusDesc.ValidateFieldValue(EmpStatusDesc);
            EHK01034.LeaverSchedule.ValidateFieldValue(LeaverSchedule);
            EHK01034.LeaverScheduleDesc.ValidateFieldValue(LeaverScheduleDesc);
            EHK01034.LeaverCode.ValidateFieldValue(LeaverCode);
            EHK01034.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            EHK01034.LeaverEffectInd.ValidateFieldValue(LeaverEffectInd);
            EHK01034.CommentsLine1.ValidateFieldValue(CommentsLine1);
            EHK01034.PhantomLeaverType.ValidateFieldValue(PhantomLeaverType);

            if (LeaverEffectInd == "L")
            {
                EHK01034.RelsONEmpEndInd.ValidateFieldValue(RelsONEmpEndInd);
                EHK01034.ForfImmInd.ValidateFieldValue(ForfImmInd);
                EHK01034.AccelerateAvailInd.ValidateFieldValue(AccelerateAvailInd);
                EHK01034.AccelerateMonths.ValidateFieldValue(AccelerateMonths);
                EHK01034.AccelerateDays.ValidateFieldValue(AccelerateDays);
                EHK01034.AccelFrmDateInd.ValidateFieldValue(AccelFrmDateInd);
            }
        }

        [When(@"In EHK01035 I Add Loan Plan Leaver Schedule Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01034AddLoanPlanLeaverScheduleSetup(string LeaverSchedule, string LeaverScheduleDesc, string LeaverCode, string EmployeeStatus, string CommentsLine1, string LeaverCodeDesc, string EmpStatusDesc)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01035");
            EHK01035.LeaverSchedule.SetValue(LeaverSchedule);
            EHK01035.LeaverScheduleDesc.SetValue(LeaverScheduleDesc);
            EHK01035.LeaverCode.SetValue(LeaverCode);
            EHK01035.EmployeeStatus.SetValue(EmployeeStatus);
            EHK01035.CommentsLine1.SetValue(CommentsLine1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01035");
            EHK01035.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
            EHK01035.EmpStatusDesc.ValidateFieldValue(EmpStatusDesc);
            EHK01035.LeaverSchedule.ValidateFieldValue(LeaverSchedule);
            EHK01035.LeaverScheduleDesc.ValidateFieldValue(LeaverScheduleDesc);
            EHK01035.LeaverCode.ValidateFieldValue(LeaverCode);
            EHK01035.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            EHK01035.CommentsLine1.ValidateFieldValue(CommentsLine1);
        }

        [When(@"In EHK01037 I Add Leaver Description Codes as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01037AddLeaverDescriptionCodes(string EmployeeStatus, string LeaverCode, string LeaverCodeDesc, string EmpStatusDesc)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01037");
            EHK01037.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01037.EmployeeStatus.SetValue(EmployeeStatus);
            EHK01037.LeaverCode.SetValue(LeaverCode);
            EHK01037.LeaverCodeDesc.SetValue(LeaverCodeDesc);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01037");
            EHK01037.EmpStatusDesc.ValidateFieldValue(EmpStatusDesc);
            EHK01037.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            EHK01037.LeaverCode.ValidateFieldValue(LeaverCode);
            EHK01037.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
        }

        [When(@"In EHK01038 I Add ESS Provider Information Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01038AddESSProviderInformationSetup(string Abn, string BranchNumber, string ProviderNameLine1, string ProviderNameLine2, string TradingNameLine1, string TradingNameLine2, string PostalAddressLine1, string PostalAddressLine2, string PostalSuburb, string PostalState, string PostalPostcode, string PostalCountry, string AddressForNotices, string CommunicationMethod, string ProviderContactName, string ProviderPhoneNumber, string ProviderEmailID, string AuthorisedSignatory)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01038");
            EHK01038.Abn.SetValue(Abn);

            //ESS Provide information Stores in SCRIP-CNTROL. Therefore we cannot restore the company and Add the ESS Provide information again.
            //Hardcoding BranchNumber value to Do a Change everytime.
            String CurrentBranchNumber = EHK01038.BranchNumber.GetValue();
            switch (CurrentBranchNumber.ToLower())
            {
                case "1":
                    EHK01038.BranchNumber.SetValue("2");
                    break;

                case "2":
                    EHK01038.BranchNumber.SetValue("1");
                    break;

                default:
                    EHK01038.BranchNumber.SetValue(BranchNumber);
                    break;
            }

            EHK01038.ProviderNameLine.SetValue(1, ProviderNameLine1);
            EHK01038.ProviderNameLine.SetValue(2, ProviderNameLine2);
            EHK01038.TradingNameLine.SetValue(1, TradingNameLine1);
            EHK01038.TradingNameLine.SetValue(2, TradingNameLine2);
            EHK01038.PostalAddressLine.SetValue(1, PostalAddressLine1);
            EHK01038.PostalAddressLine.SetValue(2, PostalAddressLine2);
            EHK01038.PostalSuburb.SetValue(PostalSuburb);
            EHK01038.PostalState.SetValue(PostalState);
            EHK01038.PostalPostcode.SetValue(PostalPostcode);
            EHK01038.PostalCountry.SetValue(PostalCountry);
            EHK01038.AddressForNotices.SetValue(AddressForNotices);
            EHK01038.CommunicationMethod.SetValue(CommunicationMethod);
            EHK01038.ProviderContactName.SetValue(ProviderContactName);
            if (EHK01038.ProviderPhoneNumber.Exists()==true)
            {
                EHK01038.ProviderPhoneNumber.SetValue(ProviderPhoneNumber);
            }

            EHK01038.ProviderEmailID.SetValue(ProviderEmailID);
            EHK01038.AuthorisedSignatory.SetValue(AuthorisedSignatory);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01001");
        }

        [When(@"In EHK01038 I Verify ESS Provider Information Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01038VerifyESSProviderInformationSetup(string Abn, string BranchNumber, string ProviderNameLine1, string ProviderNameLine2, string TradingNameLine1, string TradingNameLine2, string PostalAddressLine1, string PostalAddressLine2, string PostalSuburb, string PostalState, string PostalPostcode, string PostalCountry, string AddressForNotices, string CommunicationMethod, string ProviderContactName, string ProviderPhoneNumber, string ProviderEmailID, string AuthorisedSignatory)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01038");
            EHK01038.Abn.ValidateFieldValue(Abn);
            //EHK01038.BranchNumber.ValidateFieldValue(BranchNumber);
            EHK01038.ProviderNameLine.ValidateFieldValue(1, ProviderNameLine1);
            EHK01038.ProviderNameLine.ValidateFieldValue(2, ProviderNameLine2);
            EHK01038.TradingNameLine.ValidateFieldValue(1, TradingNameLine1);
            EHK01038.TradingNameLine.ValidateFieldValue(2, TradingNameLine2);
            EHK01038.PostalAddressLine.ValidateFieldValue(1, PostalAddressLine1);
            EHK01038.PostalAddressLine.ValidateFieldValue(2, PostalAddressLine2);
            EHK01038.PostalSuburb.ValidateFieldValue(PostalSuburb);
            EHK01038.PostalState.ValidateFieldValue(PostalState);
            EHK01038.PostalPostcode.ValidateFieldValue(PostalPostcode);
            EHK01038.PostalCountry.ValidateFieldValue(PostalCountry);
            EHK01038.AddressForNotices.ValidateFieldValue(AddressForNotices);
            EHK01038.CommunicationMethod.ValidateFieldValue(CommunicationMethod);
            EHK01038.ProviderContactName.ValidateFieldValue(ProviderContactName);
            if (EHK01038.ProviderPhoneNumber.Exists() == true)
            {
                EHK01038.ProviderPhoneNumber.ValidateFieldValue(ProviderPhoneNumber);
            }
            EHK01038.ProviderEmailID.ValidateFieldValue(ProviderEmailID);
            EHK01038.AuthorisedSignatory.ValidateFieldValue(AuthorisedSignatory);
        }

        [When(@"In EHK01039 I Add Leaver Schedule Setup as ""(.*)""")]
        public void EHK01039AddLeaverScheduleSetup(string PlanType)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01039");
            EHK01039.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01039.PlanType.SetValue(PlanType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EHK01040 I Add VSA Jurisdiction Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01040AddVSAJurisdictionSetup(string JurisdictionCode, string JurDescription, string SelectDomicileInd, string DomicileCodeL11, string DomicileCodeL12, string DomicileCodeL13, string DomicileCodeL14, string DomicileCodeL15, string DomicileCodeL16, string DomicileCodeL17, string DomicileCodeL18, string DomicileCodeL19, string DomicileCodeL110, string DomicileCodeL111, string DomicileCodeL21, string DomicileCodeL22, string DomicileCodeL23)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01040");
            EHK01040.Action1st.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            EHK01040.JurisdictionCode.SetValue(JurisdictionCode);
            EHK01040.JurDescription.SetValue(JurDescription);
            EHK01040.SelectDomicileInd.SetValue(SelectDomicileInd);

            if (SelectDomicileInd != "A")
            {
                EHK01040.SelectDomicileInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EHK01040.DomicileCodeL1.SetValue(1, DomicileCodeL11);
                EHK01040.DomicileCodeL1.SetValue(2, DomicileCodeL12);
                EHK01040.DomicileCodeL1.SetValue(3, DomicileCodeL13);
                EHK01040.DomicileCodeL1.SetValue(4, DomicileCodeL14);
                EHK01040.DomicileCodeL1.SetValue(5, DomicileCodeL15);
                EHK01040.DomicileCodeL1.SetValue(6, DomicileCodeL16);
                EHK01040.DomicileCodeL1.SetValue(7, DomicileCodeL17);
                EHK01040.DomicileCodeL1.SetValue(8, DomicileCodeL18);
                EHK01040.DomicileCodeL1.SetValue(9, DomicileCodeL19);
                EHK01040.DomicileCodeL1.SetValue(10, DomicileCodeL110);
                EHK01040.DomicileCodeL1.SetValue(11, DomicileCodeL111);
                EHK01040.DomicileCodeL2.SetValue(1, DomicileCodeL21);
                EHK01040.DomicileCodeL2.SetValue(2, DomicileCodeL22);
                EHK01040.DomicileCodeL2.SetValue(3, DomicileCodeL23);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01040");

            EHK01040.JurisdictionCode.ValidateFieldValue(JurisdictionCode);
            EHK01040.JurDescription.ValidateFieldValue(JurDescription);
            EHK01040.SelectDomicileInd.ValidateFieldValue(SelectDomicileInd);

            if (SelectDomicileInd != "A")
            {
                EHK01040.DomicileCodeL1.ValidateFieldValue(1, DomicileCodeL11);
                EHK01040.DomicileCodeL1.ValidateFieldValue(2, DomicileCodeL12);
                EHK01040.DomicileCodeL1.ValidateFieldValue(3, DomicileCodeL13);
                EHK01040.DomicileCodeL1.ValidateFieldValue(4, DomicileCodeL14);
                EHK01040.DomicileCodeL1.ValidateFieldValue(5, DomicileCodeL15);
                EHK01040.DomicileCodeL1.ValidateFieldValue(6, DomicileCodeL16);
                EHK01040.DomicileCodeL1.ValidateFieldValue(7, DomicileCodeL17);
                EHK01040.DomicileCodeL1.ValidateFieldValue(8, DomicileCodeL18);
                EHK01040.DomicileCodeL1.ValidateFieldValue(9, DomicileCodeL19);
                EHK01040.DomicileCodeL1.ValidateFieldValue(10, DomicileCodeL110);
                EHK01040.DomicileCodeL1.ValidateFieldValue(11, DomicileCodeL111);
                EHK01040.DomicileCodeL2.ValidateFieldValue(1, DomicileCodeL21);
                EHK01040.DomicileCodeL2.ValidateFieldValue(2, DomicileCodeL22);
                EHK01040.DomicileCodeL2.ValidateFieldValue(3, DomicileCodeL23);
            }
        }

        [When(@"In EHK01040 I Delete VSA Jurisdiction Setup")]
        public void EHK01040DeleteVSAJurisdictionSetup()
        {
            EHK01040.Action.SetValue("D");
            EHK01040.Action.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK01040.Confirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EHK01045 I Add AESS Event Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01045AddAESSEventSetup(string EvtNotificationDT, string EvtApplicationDT, string EvtCommMethod, string DefaultBulkCode, string TXRteAplcableInd, string DfltTaxDspslchoic, string EvtElctnPerdInd, string DfltPaytMethod, string DfltNtxDspslchoic)
        {
            EHK01045.EvtNotificationDT.SetValue(EvtNotificationDT);
            EHK01045.EvtApplicationDT.SetValue(EvtApplicationDT);
            EHK01045.EvtCommMethod.SetValue(EvtCommMethod);
            EHK01045.DefaultBulkCode.SetValue(DefaultBulkCode);

            EHK01045.TXRteAplcableInd.SetValue(TXRteAplcableInd);
            EHK01045.TXRteAplcableInd.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            if (TXRteAplcableInd == "Y")
            {
                EHK01045.DfltTaxDspslchoic.SetValue(DfltTaxDspslchoic);
            }

            EHK01045.DfltTaxDspslchoic.SetValue(DfltTaxDspslchoic);
            EHK01045.EvtElctnPerdInd.SetValue(EvtElctnPerdInd);
            EHK01045.DfltPaytMethod.SetValue(DfltPaytMethod);
            EHK01045.DfltNtxDspslchoic.SetValue(DfltNtxDspslchoic);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01046");
        }

        [When(@"In EHK01045 I Add Options Event Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01045AddOptionsEventSetup(string EvtNotificationDT, string EvtApplicationDT, string EvtCommMethod, string DefaultBulkType, string DefaultBulkCode, string DefaultXferCode, string TXRteAplcableInd, string DfltTaxDspslchoic, string TaxEventPointFlg, string EvtElctnPerdInd, string DfltPaytMethod, string DfltNtxDspslchoic, string DfltRblDspslchoic)
        {
            EHK01045.EvtNotificationDT.SetValue(EvtNotificationDT);
            EHK01045.EvtApplicationDT.SetValue(EvtApplicationDT);
            EHK01045.EvtCommMethod.SetValue(EvtCommMethod);

            EHK01045.DefaultBulkType.SetValue(DefaultBulkType);
            EHK01045.DefaultBulkType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            switch (DefaultBulkType.ToLower())
            {
                case "b":
                    EHK01045.DefaultBulkCode.SetValue(DefaultBulkCode);
                    EHK01045.DefaultXferCode.SetValue(DefaultXferCode);
                    break;

                case "s":
                    EHK01045.DefaultBulkCode.SetValue(DefaultBulkCode);
                    break;

                case "t":
                    EHK01045.DefaultXferCode.SetValue(DefaultXferCode);
                    break;

                default:
                    break;
            }

            EHK01045.TXRteAplcableInd.SetValue(TXRteAplcableInd);
            EHK01045.TXRteAplcableInd.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            if (TXRteAplcableInd == "Y")
            {
                EHK01045.DfltTaxDspslchoic.SetValue(DfltTaxDspslchoic);
            }

            EHK01045.TaxEventPointFlg.SetValue(TaxEventPointFlg);
            EHK01045.EvtElctnPerdInd.SetValue(EvtElctnPerdInd);
            EHK01045.DfltPaytMethod.SetValue(DfltPaytMethod);
            EHK01045.DfltNtxDspslchoic.SetValue(DfltNtxDspslchoic);
            EHK01045.DfltRblDspslchoic.SetValue(DfltRblDspslchoic);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01046");
        }

        [When(@"In EHK01046 I Add ESS Event Setup1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK01046AddESSEventSetup(string EvtElctnStaDT, string EvtElctnEndDT, string ElectnStartHH, string ElectnStartMM, string ElectnClosingHH, string EvtReconclStaDT, string EvtReconclEndDT, string NtaxDspslChoice1, string NtaxDspslChoice2, string NtaxDspslChoice3, string NtaxDspslChoice4, string NtaxDspslChoice5, string TaxDspslChoice1, string TaxDspslChoice2, string TaxDspslChoice3, string TaxDspslChoice4, string TaxDspslChoice5)
        {
            EHK01046.EvtElctnStaDT.SetValue(EvtElctnStaDT);
            EHK01046.EvtElctnEndDT.SetValue(EvtElctnEndDT);
            EHK01046.ElectnStartHH.SetValue(ElectnStartHH);
            EHK01046.ElectnStartMM.SetValue(ElectnStartMM);
            EHK01046.ElectnClosingHH.SetValue(ElectnClosingHH);
            EHK01046.EvtReconclStaDT.SetValue(EvtReconclStaDT);
            EHK01046.EvtReconclEndDT.SetValue(EvtReconclEndDT);
            EHK01046.NtaxDspslChoice.SetValue(1, NtaxDspslChoice1);
            EHK01046.NtaxDspslChoice.SetValue(2, NtaxDspslChoice2);
            EHK01046.NtaxDspslChoice.SetValue(3, NtaxDspslChoice3);
            EHK01046.NtaxDspslChoice.SetValue(4, NtaxDspslChoice4);
            EHK01046.NtaxDspslChoice.SetValue(5, NtaxDspslChoice5);
            EHK01046.TaxDspslChoice.SetValue(1, TaxDspslChoice1);
            EHK01046.TaxDspslChoice.SetValue(2, TaxDspslChoice2);
            EHK01046.TaxDspslChoice.SetValue(3, TaxDspslChoice3);
            EHK01046.TaxDspslChoice.SetValue(4, TaxDspslChoice4);
            EHK01046.TaxDspslChoice.SetValue(5, TaxDspslChoice5);
        }

        [When(@"In EHK010MN I Select ""(.*)"" Plan")]
        public void EHK010MNISelectPlan(string Selection)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK010MN");
            while (!EHK010MN.ClassCode.GetValue().ToUpper().Split('\r', '\n').Contains(Selection))
            {
                EOL00101.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EHK010MN");
            }

            EHK010MN.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EHK06000 I Add Vesting Schedule Parameters as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK06000AddVestingScheduleParameters(string LocateArgument, string VestingDescription, string VestingTermINMnths, string VestingTermINDays, string UnitRounding, string MnthsFromVestStart1, string DaysFromVestStar1, string VestingPercentage1, string VestingDate1, string MnthsFromVestStart2, string DaysFromVestStar2, string VestingPercentage2, string VestingDate2, string MnthsFromVestStart3, string DaysFromVestStar3, string VestingPercentage3, string VestingDate3, string Comments1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK06000");
            EHK06000.Action.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK06000.LocateArgument.SetValue(LocateArgument);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK06001");
            EHK06001.VestingDescription.SetValue(VestingDescription);
            EHK06001.VestingTermINMnths.SetValue(VestingTermINMnths);
            EHK06001.VestingTermINDays.SetValue(VestingTermINDays);
            EHK06001.UnitRounding.SetValue(UnitRounding);
            EHK06001.MnthsFromVestStart.SetValue(1, MnthsFromVestStart1);
            EHK06001.DaysFromVestStart.SetValue(1, DaysFromVestStar1);
            EHK06001.VestingPercentage.SetValue(1, VestingPercentage1);
            EHK06001.VestingDate.SetValue(1, VestingDate1);
            EHK06001.MnthsFromVestStart.SetValue(2, MnthsFromVestStart2);
            EHK06001.DaysFromVestStart.SetValue(2, DaysFromVestStar2);
            EHK06001.VestingPercentage.SetValue(2, VestingPercentage2);
            EHK06001.VestingDate.SetValue(2, VestingDate2);
            EHK06001.MnthsFromVestStart.SetValue(3, MnthsFromVestStart3);
            EHK06001.DaysFromVestStart.SetValue(3, DaysFromVestStar3);
            EHK06001.VestingPercentage.SetValue(3, VestingPercentage3);
            EHK06001.VestingDate.SetValue(3, VestingDate3);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK06001");

            EHK06001.VestingDescription.ValidateFieldValue(VestingDescription);
            EHK06001.VestingTermINMnths.ValidateFieldValue(VestingTermINMnths);
            EHK06001.VestingTermINDays.ValidateFieldValue(VestingTermINDays);
            EHK06001.UnitRounding.ValidateFieldValue(UnitRounding);
            EHK06001.MnthsFromVestStart.ValidateFieldValue(1, MnthsFromVestStart1);
            EHK06001.DaysFromVestStart.ValidateFieldValue(1, DaysFromVestStar1);
            EHK06001.VestingPercentage.ValidateFieldValue(1, VestingPercentage1);
            EHK06001.VestingDate.ValidateFieldValue(1, VestingDate1);
            EHK06001.MnthsFromVestStart.ValidateFieldValue(2, MnthsFromVestStart2);
            EHK06001.DaysFromVestStart.ValidateFieldValue(2, DaysFromVestStar2);
            EHK06001.VestingPercentage.ValidateFieldValue(2, VestingPercentage2);
            EHK06001.VestingDate.ValidateFieldValue(2, VestingDate2);
            EHK06001.MnthsFromVestStart.ValidateFieldValue(3, MnthsFromVestStart3);
            EHK06001.DaysFromVestStart.ValidateFieldValue(3, DaysFromVestStar3);
            EHK06001.VestingPercentage.ValidateFieldValue(3, VestingPercentage3);
            EHK06001.VestingDate.ValidateFieldValue(3, VestingDate3);
        }

        [When(@"In EHK06010 I Add Performance Hurdle Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EHK06010AddPerformanceHurdleSetup(string LocateVestCode, string LocateTrancheNbr, string LocatePerfCode, string PerformanceDesc, string TestDate1, string TestPercent1, string CancelUnv1, string TestDate2, string TestPercent2, string CancelUnv2, string VestingPercentage)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK06010");
            EHK06010.Action.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EHK06010.LocateVestCode.SetValue(LocateVestCode);
            EHK06010.LocateTrancheNbr.SetValue(LocateTrancheNbr);
            EHK06010.LocatePerfCode.SetValue(LocatePerfCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK06004");

            EHK06004.VestingPercentage.ValidateFieldValue(VestingPercentage);
            EHK06004.VestingCode.ValidateFieldValue(LocateVestCode);
            EHK06004.VestingTrancheNbr.ValidateFieldValue(LocateTrancheNbr);
            EHK06004.PerformanceCode.ValidateFieldValue(LocatePerfCode);

            EHK06004.PerformanceDesc.SetValue(PerformanceDesc);
            EHK06004.TestDate.SetValue(1, TestDate1);
            EHK06004.TestPercent.SetValue(1, TestPercent1);
            EHK06004.CancelUnv.SetValue(1, CancelUnv1);
            EHK06004.TestDate.SetValue(2, TestDate2);
            EHK06004.TestPercent.SetValue(2, TestPercent2);
            EHK06004.CancelUnv.SetValue(2, CancelUnv2);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK06004");

            EHK06004.PerformanceDesc.ValidateFieldValue(PerformanceDesc);
            EHK06004.TestDate.ValidateFieldValue(1, TestDate1);
            EHK06004.TestPercent.ValidateFieldValue(1, TestPercent1);
            EHK06004.CancelUnv.ValidateFieldValue(1, CancelUnv1);
            EHK06004.TestDate.ValidateFieldValue(2, TestDate2);
            EHK06004.TestPercent.ValidateFieldValue(2, TestPercent2);
            EHK06004.CancelUnv.ValidateFieldValue(2, CancelUnv2);
        }

        [When(@"I go to ESS ""(.*)"" Option")]
        public void GoToESSOption(string MenuOption)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("housekeeping system");
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00101");
            HKS00101.MenuItemCco.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("HCC00101");
            HCC00101.MenuItemCtl.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("HCC00102");
            HCC00102.MenuItemEss.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01001");

            switch (MenuOption.ToLower())
            {
                case "plan setup":
                    EHK01001.MenuOption.SetValue("SCH");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01002");
                    break;

                case "award setup":
                    EHK01001.MenuOption.SetValue("APR");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK010MN");
                    break;

                case "control setup":
                    EHK01001.MenuOption.SetValue("CTL");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK010MN");
                    break;

                case "deduction setup":
                    EHK01001.MenuOption.SetValue("DED");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK010MN");
                    break;

                case "blackout restricted codes":
                    EHK01001.MenuOption.SetValue("SOC");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01026");
                    break;

                case "blackout schedule setup":
                    EHK01001.MenuOption.SetValue("BOS");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01025");
                    break;

                case "vesting schedule setup":
                    EHK01001.MenuOption.SetValue("VST");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK06000");
                    break;

                case "performance hurdle setup":
                    EHK01001.MenuOption.SetValue("PHD");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK06010");
                    break;

                case "leaver schedule setup":
                    EHK01001.MenuOption.SetValue("LVS");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01039");
                    break;

                case "leaver description code":
                    EHK01001.MenuOption.SetValue("LDC");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01037");
                    break;

                case "ess bank details setup":
                    EHK01001.MenuOption.SetValue("DCB");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01030");
                    break;

                case "modify vwap file":
                    EHK01001.MenuOption.SetValue("VWP");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01020");
                    break;

                case "ess event control":
                    EHK01001.MenuOption.SetValue("EVC");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01013");
                    break;

                case "ess event setup":
                    EHK01001.MenuOption.SetValue("EVT");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01014");
                    break;

                case "ess provider information setup":
                    EHK01001.MenuOption.SetValue("EPI");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01038");
                    break;

                case "vsa jurisdiction setup":
                    EHK01001.MenuOption.SetValue("VSA");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EHK01040");
                    break;

                default:
                    break;
            }
        }

        [When(@"In EHK01007 I Add ESS Award Setup Details2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInEHKIAddESSAwardSetupDetails2(string TaxReportableInd, string TaxStmtTypeInd, string LeaverSchedule, string ForfeitureType, string ForfProRataMethod, string ForfPeriodFrom1, string ForfPerFromDays1, string ForfPeriodTO1, string ForfPerTODays1, string ForfPercentage1, string SavingsCarrierInd)
        {
            EHK01007.TaxReportableInd.SetValue(TaxReportableInd);
            EHK01007.TaxStmtTypeInd.SetValue(TaxStmtTypeInd);
            EHK01007.LeaverSchedule.SetValue(LeaverSchedule);
            EHK01007.ForfeitureType.SetValue(ForfeitureType);
            EHK01007.ForfProRataMethod.SetValue(ForfProRataMethod);
            EHK01007.ForfPeriodFrom.SetValue(1, ForfPeriodFrom1);
            EHK01007.ForfPerFromDays.SetValue(1, ForfPerFromDays1);
            EHK01007.ForfPeriodTO.SetValue(1, ForfPeriodTO1);
            EHK01007.ForfPerTODays.SetValue(1, ForfPerTODays1);
            EHK01007.ForfPercentage.SetValue(1, ForfPercentage1);
            EHK01007.SavingsCarrierInd.SetValue(SavingsCarrierInd);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01007");

            EHK01007.TaxReportableInd.ValidateFieldValue(TaxReportableInd);
            EHK01007.TaxStmtTypeInd.ValidateFieldValue(TaxStmtTypeInd);
            EHK01007.LeaverSchedule.ValidateFieldValue(LeaverSchedule);
            EHK01007.ForfeitureType.ValidateFieldValue(ForfeitureType);
            EHK01007.ForfProRataMethod.ValidateFieldValue(ForfProRataMethod);
            EHK01007.ForfPeriodFrom.ValidateFieldValue(1, ForfPeriodFrom1);
            EHK01007.ForfPerFromDays.ValidateFieldValue(1, ForfPerFromDays1);
            EHK01007.ForfPeriodTO.ValidateFieldValue(1, ForfPeriodTO1);
            EHK01007.ForfPerTODays.ValidateFieldValue(1, ForfPerTODays1);
            EHK01007.ForfPercentage.ValidateFieldValue(1, ForfPercentage1);
            EHK01007.SavingsCarrierInd.ValidateFieldValue(SavingsCarrierInd);
        }

        [When(@"In EHK01046 I Add ESS Event Setup2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInEHKIAddESSEventSetupAs(string AlowdPaytMethod1, string AlowdPaytMethod2, string AlowdPaytMethod3, string AlowdPaytMethod4, string AlowdPaytMethod5, string NtxEXMethod1, string NtxEXMethod2, string TaxEXMethod1, string TaxEXMethod2, string WebElectionsInd, string TaxJurisdiction1, string TaxJurisdiction2, string CmplxTXScnrioInd, string ElectionConfInd)
        {
            EHK01046.AlowdPaytMethod.SetValue(1, AlowdPaytMethod1);
            EHK01046.AlowdPaytMethod.SetValue(2, AlowdPaytMethod2);
            EHK01046.AlowdPaytMethod.SetValue(3, AlowdPaytMethod3);
            EHK01046.AlowdPaytMethod.SetValue(4, AlowdPaytMethod4);
            EHK01046.AlowdPaytMethod.SetValue(5, AlowdPaytMethod5);

            string EventCode = EHK01046.EventCode.GetValue();

            if (EventCode == "DS4")
            {
                EHK01046.NtxEXMethod.SetValue(1, NtxEXMethod1);
                EHK01046.NtxEXMethod.SetValue(2, NtxEXMethod2);
                EHK01046.TaxEXMethod.SetValue(1, TaxEXMethod1);
                EHK01046.TaxEXMethod.SetValue(2, TaxEXMethod2);
            }

            EHK01046.WebElectionsInd.SetValue(WebElectionsInd);
            EHK01046.WebElectionsInd.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            if (WebElectionsInd == "Y")
            {
                EHK01046.ElectionConfInd.SetValue(ElectionConfInd);
            }

            EHK01046.TaxJurisdiction.SetValue(1, TaxJurisdiction1);
            EHK01046.TaxJurisdiction.SetValue(2, TaxJurisdiction2);
            EHK01046.CmplxTXScnrioInd.SetValue(CmplxTXScnrioInd);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01014");
        }

        [When(@"In EHK01035 I Add Options Plan Leaver Schedule Setup as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInEHKIAddOptionsPlanLeaverScheduleSetupAs(string LeaverSchedule, string LeaverScheduleDesc, string LeaverCode, string EmployeeStatus, string OverrideExpiryInd, string UnvNOChgInd, string UnvCancelImmInd, string UnvAccelerateVstInd, string VstNOChgInd, string VstCancelImmInd, string VstIgnoreBlackout, string CommentsLine1, string LeaverCodeDesc, string EmpStatusDesc, string OverrideMonths, string OverrideDays, string OverrideFromDateInd)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01035");
            EHK01035.LeaverSchedule.SetValue(LeaverSchedule);
            EHK01035.LeaverScheduleDesc.SetValue(LeaverScheduleDesc);
            EHK01035.LeaverCode.SetValue(LeaverCode);
            EHK01035.EmployeeStatus.SetValue(EmployeeStatus);
            EHK01035.OverrideExpiryInd.SetValue(OverrideExpiryInd);

            if (OverrideExpiryInd == "Y")
            {
                EHK01035.OverrideExpiryInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EHK01035.OverrideMonths.SetValue(OverrideMonths);
                EHK01035.OverrideDays.SetValue(OverrideDays);
                EHK01035.OverrideFromDateInd.SetValue(OverrideFromDateInd);
            }

            EHK01035.UnvNOChgInd.SetValue(UnvNOChgInd);
            EHK01035.UnvCancelImmInd.SetValue(UnvCancelImmInd);
            EHK01035.UnvAccelerateVstInd.SetValue(UnvAccelerateVstInd);
            EHK01035.VstNOChgInd.SetValue(VstNOChgInd);
            EHK01035.VstCancelImmInd.SetValue(VstCancelImmInd);
            EHK01035.VstIgnoreBlackout.SetValue(VstIgnoreBlackout);
            EHK01035.CommentsLine1.SetValue(CommentsLine1);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK01035");
            EHK01035.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
            EHK01035.EmpStatusDesc.ValidateFieldValue(EmpStatusDesc);
            EHK01035.LeaverSchedule.ValidateFieldValue(LeaverSchedule);
            EHK01035.LeaverScheduleDesc.ValidateFieldValue(LeaverScheduleDesc);
            EHK01035.LeaverCode.ValidateFieldValue(LeaverCode);
            EHK01035.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            EHK01035.OverrideExpiryInd.ValidateFieldValue(OverrideExpiryInd);

            if (OverrideExpiryInd == "Y")
            {
                EHK01035.OverrideMonths.ValidateFieldValue(OverrideMonths);
                EHK01035.OverrideDays.ValidateFieldValue(OverrideDays);
                EHK01035.OverrideFromDateInd.ValidateFieldValue(OverrideFromDateInd);
            }

            EHK01035.UnvNOChgInd.ValidateFieldValue(UnvNOChgInd);
            EHK01035.UnvCancelImmInd.ValidateFieldValue(UnvCancelImmInd);
            EHK01035.UnvAccelerateVstInd.ValidateFieldValue(UnvAccelerateVstInd);
            EHK01035.VstNOChgInd.ValidateFieldValue(VstNOChgInd);
            EHK01035.VstCancelImmInd.ValidateFieldValue(VstCancelImmInd);
            EHK01035.VstIgnoreBlackout.ValidateFieldValue(VstIgnoreBlackout);
            EHK01035.CommentsLine1.ValidateFieldValue(CommentsLine1);
        }

        [When(@"In EHK010MN I Select Plan as ""(.*)""")]
        public void WhenInEHKMNISelectPlanAs(string Selection)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EHK010MN");
            EHK010MN.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In HKS01901 I removed Company notices")]
        public void WhenInHKSIRemovedCompanyNotices()
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS01901");
            HKS01901.BooksCloseDate.SetValue("");
            HKS01901.CompanyNoticeLine.SetValue(1, "");
            HKS01901.CompanyNoticeLine.SetValue(2, "");
            HKS01901.CompanyNoticeLine.SetValue(3, "");
            HKS01901.CompanyNoticeLine.SetValue(4, "");
            HKS01901.CompanyNoticeLine.SetValue(5, "");
            HKS01901.CompanyNoticeLine.SetValue(6, "");
            HKS01901.CompanyNoticeLine.SetValue(7, "");
            HKS01901.CompanyNoticeLine.SetValue(8, "");
            HKS01901.CompanyNoticeLine.SetValue(9, "");
            HKS01901.CompanyNoticeLine.SetValue(10, "");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In HKS00201 I changed add the RundateTwo")]
        public void HKS00201ChangedAddTheRundateTwo()
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("housekeeping system");
            HKS00101.MenuItemInt.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00200");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00201");
            var RunDate1Input= HKS00201.RunDate1Input.GetValue();
            HKS00201.RunDate2Input.SetValue(1,RunDate1Input);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (formName == "HKS002WN")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        

            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00202");
            var PasswordOutput =HKS00202.PasswordOutput.GetValue();
            HKS00202.PasswordInput.SetValue(1, PasswordOutput);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            while (formName != "HKS00101")
            {
                WinFormsTestSteps.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            }

            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00101");
            HKS00101.MenuItemEX.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("MNS00101");
           

        }



        [When(@"In housekeeping US Tax Reporting Obligation is set as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void InHousekeepingUSTaxReportingObligationIsSetAs(string p0 , string gin1, string gin2,string gin3, string gin4)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("housekeeping system");
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00101");
            HKS00101.MenuItemCco.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("HCC00101");
            HCC00101.MenuItemCtl.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("HCC00102");
            HCC00102.MenuItemCop.ClickField();

            var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            while (formName != "HKS01516")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("HKS01508");

            HKS01508.USTaxObligationCode.SetValue(1,p0);
            HKS01508.USTaxObligationCode.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            if (HKS01508.USTaxGiinP1.Exists())
            {
                HKS01508.USTaxGiinP1.SetValue(1, gin1);
                HKS01508.USTaxGiinP2.SetValue(1, gin2);
                HKS01508.USTaxGiinP3.SetValue(1, gin3);
                HKS01508.USTaxGiinP4.SetValue(1, gin4);

            }

            while (formName != "HCC00102")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            while (formName != "HKS00101")
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            HKS00101.MenuItemEX.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("MNS00101");
        
        }


    }
}