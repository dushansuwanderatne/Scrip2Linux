using System;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Configuration;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Renci.SshNet;
using NUnit;
using NUnit.Framework;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class PaymentSystemSubtests
    {
        private static string currentDateTime;
        private static string Timestamps = "";

        public PaymentSystemSubtests()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
            this.SSHManager = new SSHManager();
            this.ReportingTestSteps = new ReportingTestSteps();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }
        public SSHManager SSHManager { get; set; }

        public ReportingTestSteps ReportingTestSteps { get; set; }


        /// <param name="table">data table</param>
        [When(@"In DIS05010 I Enter Payment Automated Job Release details as:")]
        public void DIS05010EnterPaymentAutomatedJobReleaseDetails(Table table)
        {
            DIS05010.InputDividendCode.SetValue(1, table.Rows[0]["InputDividendCode"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIS05030");
        }

        /// <param name="table">data table</param>
        [When(@"In DIS05030 I Enter Payment Automated Job Release details as:")]
        public void DIS05030EnterPaymentAutomatedJobReleaseDetails(Table table)
        {
            if (DIS05030.Selection.Exists() == true)
            {
                DIS05030.Selection.SetValue(1, table.Rows[0]["Selection"]);
                WinFormsTestSteps.Transmit();

                switch (table.Rows[0]["Selection"].ToLower())
                {
                    case "apps":
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

                        if (formName == "DIS05040")
                        {
                            DIS05040.CostSharesKnownInd.SetValue(1, table.Rows[0]["CostSharesKnownInd"]);

                            if (table.Rows[0]["CostSharesKnownInd"] == "N")
                            {
                                DIS05040.CostSharesKnownInd.ClickField();
                                WinFormsTestSteps.PressTAB();
                                DIS05040.KnowBefPayDateInd.SetValue(1, table.Rows[0]["KnowBefPayDateInd"]);
                            }
                            WinFormsTestSteps.Transmit();
                            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                            formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                            if (formName == "DIS05050")
                            {
                                WinFormsTestSteps.Transmit();
                                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                            }

                        }

                        WinFormsTestSteps.ExpectToBeInTheScreen("DIS05080");

                        ReadAuthorisationRefFromdDivCtlFile(table);
                        DIS05080.AuthorisationRef.SetValue(currentDateTime);

                        WinFormsTestSteps.Transmit();
                        WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
                        break;

                    case "calc":
                        WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
                        formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

                        if (formName == "DIS05080")
                        {
                            DIS05080.AuthorisationRef.SetValue(currentDateTime);
                            WinFormsTestSteps.Transmit();
                            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        }


                            break;

                    case "allt":
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

                        if (formName == "DIS05070")
                        {
                            DIS05070.CostShares1.SetValue(1, table.Rows[0]["CostShares1"]);
                            if (DIS05070.CostShares2.Exists() == true)
                            {
                                DIS05070.CostShares2.SetValue(1, table.Rows[0]["CostShares2"]);
                            }

                            WinFormsTestSteps.Transmit();
                            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                            //DateTime thisDay = DateTime.Now;
                            //PlnAuthorisationRef = thisDay.ToString("HHmmdd");
                        }
                        if (formName == "DIS05060")
                        {
                            DIS05060.CostShares.SetValue(1, table.Rows[0]["CostShares"]);
                            WinFormsTestSteps.Transmit();
                            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        }
                   break;

                    case "buld":
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

                        if (formName == "DIS05080")
                        {
                            ReadAuthorisationRefFromPlanTotFile(table);
                            DIS05080.AuthorisationRef.SetValue(Timestamps);
                            WinFormsTestSteps.Transmit();
                        }
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                        if (formName == "DIS05090")
                        {
                            ReadAuthorisationRefFromPlanTotFile(table);
                            DIS05090.AuthorisationRef.SetValue(Timestamps);
                            WinFormsTestSteps.Transmit();
                            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                throw new Exception("Payment automated job release process is not complete");
            }

            /// <param name="table">data table</param>
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1001 I setup the Dividend Control Update as:")]
        public void DIVX1001SetupTheDividendControlUpdate(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1001");
            if (DIVX1001.More.Exists() ==true)  
             DIVX1001.More.SetValue(1, table.Rows[0]["More"]);

            DIVX1001.Preload.SetValue(1, table.Rows[0]["Preload"]);
            DIVX1001.InputDivCode.SetValue(1, table.Rows[0]["InputDivCode"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1020");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1005 I setup the Dividend Control Update as:")]
        public void DIVX1005SetupTheDividendControlUpdate(Table table)
        {
            DIVX1005.DividendDescription.SetValue(1, table.Rows[0]["DividendDescription"]);
            DIVX1005.CorporateAction.SetValue(1, table.Rows[0]["CorporateAction"]);
            DIVX1005.EmployeeDividend.SetValue(1, table.Rows[0]["EmployeeDividend"]);
            if (DIVX1005.ElectronicStatements.Exists() == true)
            {
                DIVX1005.ElectronicStatements.SetValue(1, table.Rows[0]["ElectronicStatements"]);
            }

            DIVX1005.MultiplePayments.SetValue(1, table.Rows[0]["MultiplePayments"]);
            if (table.Rows[0]["MultiplePayments"] == "Y")
            {
                DIVX1005.MultiplePayments.ClickField();
                WinFormsTestSteps.PressTAB();
                DIVX1005.NumberOFPayments.SetValue(1, table.Rows[0]["NumberOFPayments"]);
            }

            DIVX1005.AutomatedJobRelease.SetValue(1, table.Rows[0]["AutomatedJobRelease"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1008");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1008 I setup the Dividend Control Update as:")]
        public void DIVX1008SetupTheDividendControlUpdateAs(Table table)
        {
            DIVX1008.SubPay1.SetValue(1, table.Rows[0]["SubPay1"]);
            DIVX1008.PayTyp1.SetValue(1, table.Rows[0]["PayTyp1"]);

            DIVX1008.PayTyp1.ClickField();
            WinFormsTestSteps.PressTAB();
            if (DIVX1008.UseEarnInd1.Exists() == true)
                DIVX1008.UseEarnInd1.SetValue("N");
            if (DIVX1008.UseRptInd1.Exists() == true)
                DIVX1008.UseRptInd1.SetValue("N");


            if (DIVX1008.SubPay2.Exists() == true)
            {
                DIVX1008.SubPay2.SetValue(1, table.Rows[0]["SubPay2"]);
                DIVX1008.PayTyp2.SetValue(1, table.Rows[0]["PayTyp2"]);
            }
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1010");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1010 I setup the Dividend Control Update as:")]
        public void DIVX1010SetupTheDividendControlUpdate(Table table)
        {
            DIVX1010.BCRunNumber.SetValue(1, table.Rows[0]["BCRunNumber"]);
            //only for Interest
            if (DIVX1010.PaymentsPerYear.Exists() == true)
            {
                DIVX1010.PaymentsPerYear.SetValue(1, table.Rows[0]["PaymentsPerYear"]);
            }

            //Enter Todays Date
            DateTime thisDay = DateTime.Today.AddDays(1);
            string CurrentDate = thisDay.ToString("dd'/'MM'/'yyyy");
            //string TestDate = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            DIVX1010.PaymentDate.SetValue(1, CurrentDate);
            DIVX1010.ListDate.SetValue(1, CurrentDate);
            DIVX1010.BooksCloseDate.SetValue(1, CurrentDate);
            DIVX1010.PaidTODate.SetValue(1, CurrentDate);

            DIVX1010.XtrFilnam.SetValue(1, table.Rows[0]["XtrFilnam"]);
            DIVX1010.RoundOption.SetValue(1, table.Rows[0]["RoundOption"]);
            DIVX1010.RndMultiple.SetValue(1, table.Rows[0]["RndMultiple"]);

            if (DIVX1010.MandAllotment.Exists() == true)
            {
                DIVX1010.MandAllotment.SetValue(1, table.Rows[0]["MandAllotment"]);
                if (table.Rows[0]["MandAllotment"] == "Y")
                {
                    DIVX1010.MandAllotment.ClickField();
                    WinFormsTestSteps.PressTAB();
                    DIVX1010.PlanDomRuleInd.SetValue(1, table.Rows[0]["PlanDomRuleInd"]);
                    if (table.Rows[0]["PlanDomRuleInd"] == "Y")
                    {
                        DIVX1010.PlanDomRuleInd.ClickField();
                        WinFormsTestSteps.PressTAB();
                        DIVX1010.PlanTaxCodeRule.SetValue(1, table.Rows[0]["PlanTaxCodeRule"]);
                    }
                }
            }

            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1012");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1012 I setup the Dividend Control Update as:")]
        public void DIVX1012SetupTheDividendControlUpdate(Table table)
        {
            //Only for Interest
            if (DIVX1012.BrokenPeriod.Exists() == true)
            {
                DIVX1012.BrokenPeriod.SetValue("N");
            }
            //Only for Distribution
            if (DIVX1012.UnitDayCalc.Exists() == true)
            {
                DIVX1012.UnitDayCalc.SetValue("N");
            }

            DIVX1012.AtoEftLgePayApply.SetValue(1, table.Rows[0]["AtoEftLgePayApply"]);

            if (DIVX1012.DividendSourceApply.Exists() == true)
            {
                DIVX1012.DividendSourceApply.SetValue(1, table.Rows[0]["DividendSourceApply"]);
            }

            if (DIVX1012.DividendPlanApply.Exists() == true)
            {
                DIVX1012.DividendPlanApply.SetValue(1, table.Rows[0]["DividendPlanApply"]);
            }

            if (table.Rows[0]["DividendPlanApply"] == "Y")
            {
                DIVX1012.DividendPlanApply.ClickField();
                WinFormsTestSteps.PressTAB();
                DIVX1012.Selcat.SetValue(1, table.Rows[0]["Selcat1"]);
                DIVX1012.Selcat.SetValue(2, table.Rows[0]["Selcat2"]);
                DIVX1012.DividendPlan.SetValue(1, table.Rows[0]["DividendPlan1"]);
                DIVX1012.DividendPlan.SetValue(2, table.Rows[0]["DividendPlan2"]);
                DIVX1012.PlanHolderID.SetValue(1, table.Rows[0]["PlanHolderID"]);
                DIVX1012.DrpPrefOverBspInd.SetValue(1, table.Rows[0]["DrpPrefOverBspInd"]);

                DIVX1012.DeferBuild.SetValue(1, table.Rows[0]["DeferBuild"]);
                DIVX1012.BuildDeferDate.SetValue(1, table.Rows[0]["BuildDeferDate"]);
                DIVX1012.EomSelectionCode.SetValue(1, table.Rows[0]["EomSelectionCode"]);
            }
            else
            {
                DIVX1012.Selcls.SetValue(1, table.Rows[0]["Selcls1"]);
                DIVX1012.Selcls.SetValue(2, table.Rows[0]["Selcls2"]);
            }
            DIVX1012.Selreg1.SetValue(1, table.Rows[0]["Selreg11"]);
            DIVX1012.Selreg1.SetValue(2, table.Rows[0]["Selreg12"]);
            DIVX1012.HidTOPrint.SetValue(1, table.Rows[0]["HidTOPrint"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "DIVX1014")
            {
                DIVX1014.MultiTypePlansInd.SetValue("Y");
                WinFormsTestSteps.Transmit();
            }
            formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "DIVX1019")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1013");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1013 I setup the Dividend Control Update as:")]
        public void DIVX1013SetupTheDividendControlUpdate(Table table)
        {
            DIVX1013.ClsDsc1.SetValue(1, table.Rows[0]["ClsDsc1"]);
            if (DIVX1013.ClsDsc2.Exists() == true)
            {
                DIVX1013.ClsDsc2.SetValue(1, table.Rows[0]["ClsDsc2"]);
            }

            if (DIVX1013.IntNbrDays1.Exists() == true)
            {
                DIVX1013.IntNbrDays1.SetValue(1, table.Rows[0]["IntNbrDays1"]);
            }
            if (DIVX1013.IntNbrDays2.Exists() == true)
            {
                DIVX1013.IntNbrDays2.SetValue(1, table.Rows[0]["IntNbrDays2"]);
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "DIVX1016")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1020");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1016 I setup the Dividend Control Update as:")]
        public void DIVX1016SetupTheDividendControlUpdate(Table table)
        {
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "DIVX1016")
            {
                DIVX1016.LoanClass.ValidateFieldValue(1, table.Rows[0]["LoanClass1"]);
                DIVX1016.LoanClass.ValidateFieldValue(2, table.Rows[0]["LoanClass2"]);
                DIVX1016.Percentage.SetValue(1, table.Rows[0]["Percentage"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1020");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1019 I setup the Dividend Control Update as:")]
        public void DIVX1019SetupTheDividendControlUpdate(Table table)
        {
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "DIVX1019")
            {
                DIVX1019.ReduceRefClass.SetValue(1, table.Rows[0]["ReduceRefClass"]);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1013");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1020 I setup the Dividend Control Update as:")]
        public void DIVX1020SetupTheDividendControlUpdate(Table table)
        {
            DIVX1020.Option.SetValue(1, table.Rows[0]["Option"]);
            WinFormsTestSteps.Transmit();
            DateTime thisDay = DateTime.Now;
            currentDateTime = thisDay.ToString("HHmmdd");

            if (table.Rows[0]["Option"] == "IN")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1005");
            }
            else if (table.Rows[0]["Option"] == "D" || table.Rows[0]["Option"] == "B" || table.Rows[0]["Option"] == "Z")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1022");
            }
            else
            {
                //Exit
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1080");
                string ExtraDivCode = DIVX1080.ExtraDivCode.GetValue();
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1082");
                DIVX1082.OrderNumber.SetValue(ExtraDivCode);
                DIVX1082.OpsInitials.SetValue("NDF");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                var _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                if (_formName == "BILCTL99")
                  WinFormsTestSteps.Transmit();

                WinFormsTestSteps.ExpectToBeInTheScreen("SPS00101");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1022 I setup the Dividend Control Update as:")]
        public void DIVX1022SetupTheDividendControlUpdate(Table table)
        {
            DIVX1022.PaymentListingHead.SetValue(1, table.Rows[0]["PaymentListingHead"]);
            DIVX1022.PaymentSequence.SetValue(1, table.Rows[0]["PaymentSequence"]);
            DIVX1022.ChequeAdviceSeq.SetValue(1, table.Rows[0]["ChequeAdviceSeq"]);
            DIVX1022.ReturnMailApply.SetValue(1, table.Rows[0]["ReturnMailApply"]);
            if (table.Rows[0]["ReturnMailApply"] == "Y")
            {
                DIVX1022.ReturnMailApply.ClickField();
                WinFormsTestSteps.PressTAB();
                DIVX1022.UnissuedChqApply.SetValue(1, table.Rows[0]["UnissuedChqApply"]);
            }
            DIVX1022.TfnPrintFlag.SetValue(1, table.Rows[0]["TfnPrintFlag"]);
            DIVX1022.DeductionsApply.SetValue(1, table.Rows[0]["DeductionsApply"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1024");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1024 I setup the Dividend Control Update as:")]
        public void DIVX1024SetupTheDividendControlUpdate(Table table)
        {
            DIVX1024.TaxCtryCode.SetValue(1, table.Rows[0]["TaxCtryCode"]);
            DIVX1024.TaxHolderIdentifier.SetValue(1, table.Rows[0]["TaxHolderIdentifier"]);
            if (DIVX1024.OtherTaxCtryCode.Exists() == true)
            {
                DIVX1024.OtherTaxCtryCode.SetValue(1, table.Rows[0]["OtherTaxCtryCode"]);
                DIVX1024.OtherTaxHolderID.SetValue(1, table.Rows[0]["OtherTaxHolderID"]);
            }
            DIVX1024.FundDistTaxInd.SetValue(1, table.Rows[0]["FundDistTaxInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "DIVX1030")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1033");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1030 I setup the Dividend Control Update as:")]
        public void DIVX1030SetupTheDividendControlUpdate(Table table)
        {
            DIVX1030.Rn1.SetValue(1, table.Rows[0]["Rn1"]);
            if (DIVX1030.Rn2.Exists() == true)
            {
                DIVX1030.Rn2.SetValue(1, table.Rows[0]["Rn2"]);
            }
            if (DIVX1030.Rn3.Exists() == true)
            {
                DIVX1030.Rn3.SetValue(1, table.Rows[0]["Rn3"]);
            }
            if (DIVX1030.Rn4.Exists() == true)
            {
                DIVX1030.Rn4.SetValue(1, table.Rows[0]["Rn4"]);
            }
            if (DIVX1030.Rn5.Exists() == true)
            {
                DIVX1030.Rn5.SetValue(1, table.Rows[0]["Rn5"]);
            }
            if (DIVX1030.Rn6.Exists() == true)
            {
                DIVX1030.Rn6.SetValue(1, table.Rows[0]["Rn6"]);
            }
            //if (DIVX1030.Rn7.Exists() == true)
            //{
            //    DIVX1030.Rn7.SetValue(1, table.Rows[0]["Rn7"]);
            //}
            //if (DIVX1030.Rn8.Exists() == true)
            //{
            //    DIVX1030.Rn8.SetValue(1, table.Rows[0]["Rn8"]);
            //}
            //if (DIVX1030.Rn9.Exists() == true)
            //{
            //    DIVX1030.Rn9.SetValue(1, table.Rows[0]["Rn9"]);
            //}
            //if (DIVX1030.Rn10.Exists() == true)
            //{
            //    DIVX1030.Rn10.SetValue(1, table.Rows[0]["Rn10"]);
            //}
            //if (DIVX1030.Rn11.Exists() == true)
            //{
            //    DIVX1030.Rn11.SetValue(1, table.Rows[0]["Rn11"]);
            //}
            //if (DIVX1030.Rn12.Exists() == true)
            //{
            //    DIVX1030.Rn12.SetValue(1, table.Rows[0]["Rn12"]);
            //}
            //if (DIVX1030.Rn13.Exists() == true)
            //{
            //    DIVX1030.Rn13.SetValue(1, table.Rows[0]["Rn13"]);
            //}
            //if (DIVX1030.Rn14.Exists() == true)
            //{
            //    DIVX1030.Rn14.SetValue(1, table.Rows[0]["Rn14"]);
            //}
            //if (DIVX1030.Rn15.Exists() == true)
            //{
            //    DIVX1030.Rn15.SetValue(1, table.Rows[0]["Rn15"]);
            //}
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1031");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1031 I setup the Dividend Control Update as:")]
        public void DIVX1031SetupTheDividendControlUpdate(Table table)
        {
            DIVX1031.Seq1.SetValue(1, table.Rows[0]["Seq1"]);
            if (DIVX1031.Seq2.Exists() == true)
            {
                DIVX1031.Seq2.SetValue(1, table.Rows[0]["Seq2"]);
            }
            if (DIVX1031.Seq3.Exists() == true)
            {
                DIVX1031.Seq3.SetValue(1, table.Rows[0]["Seq3"]);
            }
            if (DIVX1031.Seq4.Exists() == true)
            {
                DIVX1031.Seq4.SetValue(1, table.Rows[0]["Seq4"]);
            }
            if (DIVX1031.Seq5.Exists() == true)
            {
                DIVX1031.Seq5.SetValue(1, table.Rows[0]["Seq5"]);
            }
            DIVX1031.Action.SetValue(1, table.Rows[0]["Action"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1038");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1039");
            DIVX1039.ChargeCode.SetValue(1, table.Rows[0]["ChargeCode"]);
            DIVX1039.ControlHolderID.SetValue(1, table.Rows[0]["ControlHolderID"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1031");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1033");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1033 I setup the Dividend Control Update as:")]
        public void DIVX1033SetupTheDividendControlUpdate(Table table)
        {
            DIVX1033.ClassCat2.ValidateFieldValue(1, table.Rows[0]["ClassCat2"]);
            DIVX1033.SubPayCode.ValidateFieldValue(1, table.Rows[0]["SubPayCode"]);
            DIVX1033.PaymentType.ValidateFieldValue(1, table.Rows[0]["PaymentType"]);
            DIVX1033.TypeDescription.ValidateFieldValue(1, table.Rows[0]["TypeDescription"]);
            DIVX1033.PaymentRateDesc1.SetValue(1, table.Rows[0]["PaymentRateDesc1"]);
            DIVX1033.PaymentRate1.SetValue(1, table.Rows[0]["PaymentRate1"]);
            DIVX1033.AdditionalRate1.SetValue(1, table.Rows[0]["AdditionalRate1"]);
            DIVX1033.ReportableRate1.SetValue(1, table.Rows[0]["ReportableRate1"]);
            DIVX1033.CompBrkdwnMethod.SetValue(1, table.Rows[0]["CompBrkdwnMethod"]);

            if (DIVX1033.PaymentRateDesc2.Exists() == true)
            {
                DIVX1033.PaymentRateDesc2.SetValue(1, table.Rows[0]["PaymentRateDesc2"]);
                DIVX1033.PaymentRate2.SetValue(1, table.Rows[0]["PaymentRate2"]);
                DIVX1033.AdditionalRate2.SetValue(1, table.Rows[0]["AdditionalRate2"]);
                DIVX1033.ReportableRate2.SetValue(1, table.Rows[0]["ReportableRate2"]);
                DIVX1033.CompBrkdwnMethod.SetValue(1, table.Rows[0]["CompBrkdwnMethod2"]);
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            //string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            //if (DIVX1033.ClassCat.Exists() == true)
            //{
            //    ClassCat = DIVX1033.ClassCat.GetValue();
            //}
            //if (formName == "DIVX1033" && ClassCat != table.Rows[0]["ClassCat2"])
            //{
            //    DIVX1033.PaymentRateDesc1.SetValue(1, table.Rows[0]["PaymentRateDesc2"]);
            //    DIVX1033.PaymentRate1.SetValue(1, table.Rows[0]["PaymentRate2"]);
            //    DIVX1033.AdditionalRate1.SetValue(1, table.Rows[0]["AdditionalRate2"]);
            //    DIVX1033.ReportableRate1.SetValue(1, table.Rows[0]["ReportableRate2"]);
            //    DIVX1033.CompBrkdwnMethod.SetValue(1, table.Rows[0]["CompBrkdwnMethod2"]);
            //    WinFormsTestSteps.Transmit();
            //}
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "DIVX1033")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1034");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1034 I setup the Dividend Control Update as:")]
        public void DIVX1034SetupTheDividendControlUpdate(Table table)
        {
            DIVX1034.Rn1.SetValue(1, table.Rows[0]["Rn1"]);
            DIVX1034.Rn2.SetValue(1, table.Rows[0]["Rn2"]);
            DIVX1034.Rn3.SetValue(1, table.Rows[0]["Rn3"]);
            DIVX1034.Rn4.SetValue(1, table.Rows[0]["Rn4"]);
            DIVX1034.Rn5.SetValue(1, table.Rows[0]["Rn5"]);
            DIVX1034.Rn6.SetValue(1, table.Rows[0]["Rn6"]);
            DIVX1034.Rn7.SetValue(1, table.Rows[0]["Rn7"]);
            DIVX1034.Rn8.SetValue(1, table.Rows[0]["Rn8"]);
            DIVX1034.Rn9.SetValue(1, table.Rows[0]["Rn9"]);
            DIVX1034.Rn10.SetValue(1, table.Rows[0]["Rn10"]);
            DIVX1034.Rn11.SetValue(1, table.Rows[0]["Rn11"]);
            DIVX1034.Rn12.SetValue(1, table.Rows[0]["Rn12"]);

            if (DIVX1034.Rn13.Exists() == true)
            {
                DIVX1034.Rn13.SetValue(1, table.Rows[0]["Rn13"]);
            }
            //if (DIVX1034.Rn14.Exists() == true) ---> the field is exist but hidden //Need to chnage this in future
            if (DIVX1034.DividendType.GetValue() != "I")
            {
                DIVX1034.Rn14.SetValue(1, table.Rows[0]["Rn14"]);
            }

            //if (DIVX1034.Rn15.Exists() == true) ---> the field is exist but hidden //Need to chnage this in future
            if (DIVX1034.DividendType.GetValue() != "I")
            {
                DIVX1034.Rn15.SetValue(1, table.Rows[0]["Rn15"]);
            }

            string SubPayCode = DIVX1034.SubPayCode.GetValue();
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (formname == "DIVX1034" && SubPayCode == table.Rows[0]["SubPayCodeX"])
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                SubPayCode = DIVX1034.SubPayCode.GetValue();
            }

            //WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1035");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1035 I setup the Dividend Control Update as:")]
        public void DIVX1035SetupTheDividendControlUpdate(Table table)
        {
            DIVX1035.ComponentRate1.SetValue(1, table.Rows[0]["ComponentRate1"]);
            if (DIVX1035.Group1.Exists() == true)
            {
                DIVX1035.Group1.SetValue(1, table.Rows[0]["Group1"]);
            }

            if (DIVX1035.InputGroup1.Exists() == true)
            {
                DIVX1035.InputGroup1.SetValue(1, table.Rows[0]["InputGroup1"]);
            }
            if (DIVX1035.Sequence1.Exists() == true)
            {
                DIVX1035.Sequence1.SetValue(1, table.Rows[0]["Sequence1"]);
            }

            if (DIVX1035.ComponentRate2.Exists() == true)
            {
                DIVX1035.ComponentRate2.SetValue(1, table.Rows[0]["ComponentRate2"]);
                if (DIVX1035.Group2.Exists() == true)
                {
                    DIVX1035.Group2.SetValue(1, table.Rows[0]["Group2"]);
                }
                if (DIVX1035.InputGroup2.Exists() == true)
                {
                    DIVX1035.InputGroup2.SetValue(1, table.Rows[0]["InputGroup2"]);
                }
                if (DIVX1035.Sequence2.Exists() == true)
                {
                    DIVX1035.Sequence2.SetValue(1, table.Rows[0]["Sequence2"]);
                }
            }

            if (DIVX1035.ComponentRate3.Exists() == true)
            {
                if (DIVX1035.ComponentRate3.Exists() == true)
                {
                    DIVX1035.ComponentRate3.SetValue(1, table.Rows[0]["ComponentRate3"]);
                }
                if (DIVX1035.Group3.Exists() == true)
                {
                    DIVX1035.Group3.SetValue(1, table.Rows[0]["Group3"]);
                }
                if (DIVX1035.InputGroup3.Exists() == true)
                {
                    DIVX1035.InputGroup3.SetValue(1, table.Rows[0]["InputGroup3"]);
                }
                if (DIVX1035.Sequence3.Exists() == true)
                {
                    DIVX1035.Sequence3.SetValue(1, table.Rows[0]["Sequence3"]);
                }
            }
            if (DIVX1035.ComponentRate4.Exists() == true)
            {
                if (DIVX1035.ComponentRate4.Exists() == true)
                {
                    DIVX1035.ComponentRate4.SetValue(1, table.Rows[0]["ComponentRate4"]);
                }
                if (DIVX1035.Group4.Exists() == true)
                {
                    DIVX1035.Group4.SetValue(1, table.Rows[0]["Group4"]);
                }
                if (DIVX1035.InputGroup4.Exists() == true)
                {
                    DIVX1035.InputGroup4.SetValue(1, table.Rows[0]["InputGroup4"]);
                }
                if (DIVX1035.Sequence4.Exists() == true)
                {
                    DIVX1035.Sequence4.SetValue(1, table.Rows[0]["Sequence4"]);
                }
            }
            if (DIVX1035.ComponentRate5.Exists() == true)
            {
                if (DIVX1035.ComponentRate5.Exists() == true)
                {
                    DIVX1035.ComponentRate5.SetValue(1, table.Rows[0]["ComponentRate5"]);
                }
                if (DIVX1035.Group5.Exists() == true)
                {
                    DIVX1035.Group5.SetValue(1, table.Rows[0]["Group5"]);
                }
                if (DIVX1035.InputGroup5.Exists() == true)
                {
                    DIVX1035.InputGroup5.SetValue(1, table.Rows[0]["InputGroup5"]);
                }
                if (DIVX1035.Sequence5.Exists() == true)
                {
                    DIVX1035.Sequence5.SetValue(1, table.Rows[0]["Sequence5"]);
                }
            }

            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formaName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formaName != "DIVX1035")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1040");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1040 I setup the Dividend Control Update as:")]
        public void DIVX1040SetupTheDividendControlUpdateAs(Table table)
        {
            DIVX1040.BaseCurrency.SetValue(1, table.Rows[0]["BaseCurrency"]);
            if (DIVX1040.DIDCApply.Exists() == true)
            {
                DIVX1040.DIDCApply.SetValue(1, table.Rows[0]["DIDCApply"]);
                DIVX1040.DcrProcessInd.SetValue(1, table.Rows[0]["DcrProcessInd"]);
                DIVX1040.FgnChqApplyInd.SetValue(1, table.Rows[0]["FgnChqApplyInd"]);
                if (table.Rows[0]["FgnChqApplyInd"] == "Y")
                {
                    DIVX1040.FgnChqApplyInd.ClickField();
                    WinFormsTestSteps.PressTAB();
                    DIVX1040.OrideFCThresInd.SetValue(1, table.Rows[0]["OrideFCThresInd"]);
                }
                DIVX1040.CoyNamePrint.SetValue(1, table.Rows[0]["CoyNamePrint"]);
                if (table.Rows[0]["OrideFCThresInd"] == "Y")
                {
                    DIVX1040.OrideFCThresInd.ClickField();
                    WinFormsTestSteps.PressTAB();
                    if (DIVX1040.OrideFCThresAmt.Exists() == true)
                    {
                        DIVX1040.OrideFCThresAmt.SetValue(1, table.Rows[0]["OrideFCThresAmt"]);
                    }
                }
                DIVX1040.DidcStartRef.SetValue(1, table.Rows[0]["DidcStartRef"]);
                DIVX1040.DISortFlag.SetValue(1, table.Rows[0]["DISortFlag"]);
                DIVX1040.DCTapeDate.SetValue(1, table.Rows[0]["DCTapeDate"]);
                DIVX1040.SeparateBulk.SetValue(1, table.Rows[0]["SeparateBulk"]);
                DIVX1040.ChequesApply.ValidateFieldValue(1, table.Rows[0]["ChequesApply"]);
            }

            DIVX1040.ChequesStartRef.SetValue(1, table.Rows[0]["ChequesStartRef"]);
            DIVX1040.TaxDescPrint.SetValue(1, table.Rows[0]["TaxDescPrint"]);
            DIVX1040.ChqNumPreprinted.SetValue(1, table.Rows[0]["ChqNumPreprinted"]);
            DIVX1040.MCApply.SetValue(1, table.Rows[0]["MCApply"]);
            if (table.Rows[0]["MCApply"] != "N")
            {
                DIVX1040.MCApply.ClickField();
                WinFormsTestSteps.PressTAB();
                DIVX1040.PaidCurrency.SetValue(1, table.Rows[0]["PaidCurrency"]);
                DIVX1040.MCAllConvRate.SetValue(1, table.Rows[0]["MCAllConvRate"]);
                DIVX1040.MCAllDesc.SetValue(1, table.Rows[0]["MCAllDesc"]);
                DIVX1040.NbrMultCurrency.SetValue(1, table.Rows[0]["NbrMultCurrency"]);
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1046");
                DIVX1046.MCCurrency.SetValue(1, table.Rows[0]["MCCurrency1"]);
                DIVX1046.MCConversionRate.SetValue(1, table.Rows[0]["MCConversionRate1"]);
                DIVX1046.MCConversionDesc.SetValue(1, table.Rows[0]["MCConversionDesc1"]);
                DIVX1046.DirectCreditApply.SetValue(1, table.Rows[0]["DirectCreditApply1"]);
                DIVX1046.DirectCreditApply.ClickField();
                WinFormsTestSteps.PressTAB();
                DIVX1046.MCDomCode.SetValue(1, table.Rows[0]["MCDomCode11"]);
                DIVX1046.MCDomCode.SetValue(2, table.Rows[0]["MCDomCode12"]);

                if (table.Rows[0]["DirectCreditApply1"] != "M")
                {
                    DIVX1046.ChequesApply.SetValue(1, table.Rows[0]["ChequesApply1"]);
                    if (table.Rows[0]["ChequesApply1"] == "Y")
                    {
                        DIVX1046.ChequesApply.ClickField();
                        WinFormsTestSteps.PressTAB();
                        DIVX1046.MCStartRefNumber.SetValue(1, table.Rows[0]["MCStartRefNumber1"]);
                        DIVX1046.MCChqNumPreprinted.SetValue(1, table.Rows[0]["MCChqNumPreprinted1"]);
                    }
                }
                WinFormsTestSteps.Transmit();

                if (Int32.Parse(table.Rows[0]["NbrMultCurrency"]) >= 2)
                {
                    WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1046");
                    DIVX1046.MCCurrency.SetValue(1, table.Rows[0]["MCCurrency2"]);
                    DIVX1046.MCConversionRate.SetValue(1, table.Rows[0]["MCConversionRate2"]);
                    DIVX1046.MCConversionDesc.SetValue(1, table.Rows[0]["MCConversionDesc2"]);
                    DIVX1046.DirectCreditApply.SetValue(1, table.Rows[0]["DirectCreditApply2"]);
                    DIVX1046.DirectCreditApply.ClickField();
                    WinFormsTestSteps.PressTAB();
                    DIVX1046.MCDomCode.SetValue(1, table.Rows[0]["MCDomCode21"]);
                    DIVX1046.MCDomCode.SetValue(2, table.Rows[0]["MCDomCode22"]);

                    if (table.Rows[0]["DirectCreditApply2"] != "M")
                    {
                        DIVX1046.ChequesApply.SetValue(1, table.Rows[0]["ChequesApply2"]);
                        if (table.Rows[0]["ChequesApply2"] == "Y")
                        {
                            DIVX1046.ChequesApply.ClickField();
                            WinFormsTestSteps.PressTAB();
                            DIVX1046.MCStartRefNumber.SetValue(1, table.Rows[0]["MCStartRefNumber2"]);
                            DIVX1046.MCChqNumPreprinted.SetValue(1, table.Rows[0]["MCChqNumPreprinted2"]);
                        }
                    }
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                }
            }
            else
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "DIVX1042" && formName != "DIVX1048")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1060");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1042 I setup the Dividend Control Update as:")]
        public void DIVX1042SetupTheDividendControlUpdate(Table table)
        {
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "DIVX1042")
            {
                DIVX1042.EmpHowPayCode.SetValue(1, table.Rows[0]["EmpHowPayCode"]);
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1060");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1048 I setup the Dividend Control Update as:")]
        public void DIVX1048SetupTheDividendControlUpdate(Table table)
        {
            DIVX1048.BulkCode.SetValue(1, table.Rows[0]["BulkCode"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1060");
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1050 I setup the Dividend Control Update as:")]
        public void DIVX1050SetupTheDividendControlUpdate(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "DIVX1050")
            {
                DIVX1050.PlanScalebackApply.SetValue(1, table.Rows[0]["PlanScalebackApply"]);
                DIVX1050.StatementScripSeq.SetValue(1, table.Rows[0]["StatementScripSeq"]);
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1052");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1052 I setup the Dividend Control Update as:")]
        public void DIVX1052SetupTheDividendControlUpdate(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "DIVX1052")
            {
                if (DIVX1052.CostShares.Exists() == true)
                {
                    DIVX1052.CostShares.SetValue(1, table.Rows[0]["CostShares"]);
                }
                if (DIVX1052.CatCostShare1.Exists() == true)
                {
                    DIVX1052.CatCostShare1.SetValue(1, table.Rows[0]["CatCostShare1"]);
                }
                if (DIVX1052.CatCostShare2.Exists() == true)
                {
                    DIVX1052.CatCostShare2.SetValue(1, table.Rows[0]["CatCostShare2"]);
                }

                DateTime thisDay = DateTime.Today.AddDays(1);
                string CurrentDate = thisDay.ToString("dd'/'MM'/'yyyy");
                DIVX1052.CertAllotDate.SetValue(CurrentDate);
                DIVX1052.PlanStartRef.SetValue(1, table.Rows[0]["PlanStartRef"]);

                if (DIVX1052.OverrideMnyClassInd.Exists() == true)
                {
                    DIVX1052.OverrideMnyClassInd.SetValue(1, table.Rows[0]["OverrideMnyClassInd"]);
                    if (table.Rows[0]["OverrideMnyClassInd"] == "Y")
                    {
                        DIVX1052.OverrideMnyClassInd.ClickField();
                        WinFormsTestSteps.PressTAB();
                        DIVX1052.OverrideMnyBFClass.SetValue(1, table.Rows[0]["OverrideMnyBFClass"]);
                        DIVX1052.OverrideMnyCFClass.SetValue(1, table.Rows[0]["OverrideMnyCFClass"]);
                    }
                }

                DIVX1052.MinPartOption.SetValue(1, table.Rows[0]["MinPartOption"]);
                DIVX1052.MaxRestriction.SetValue(1, table.Rows[0]["MaxRestriction"]);
                DIVX1052.TranTypeCode.SetValue(1, table.Rows[0]["TranTypeCode"]);
                DIVX1052.TradeRef.SetValue(1, table.Rows[0]["TradeRef"]);
                DIVX1052.DeductionCode.SetValue(1, table.Rows[0]["DeductionCode1"]);
                DIVX1052.DeductionCodeInd.SetValue(1, table.Rows[0]["DeductionCodeInd1"]);
                DIVX1052.DeductionCode.SetValue(2, table.Rows[0]["DeductionCode2"]);
                DIVX1052.DeductionCodeInd.SetValue(2, table.Rows[0]["DeductionCodeInd2"]);
                DIVX1052.DeductionCode.SetValue(3, table.Rows[0]["DeductionCode3"]);
                DIVX1052.DeductionCodeInd.SetValue(3, table.Rows[0]["DeductionCodeInd3"]);
                WinFormsTestSteps.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1020");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In DIVX1060 I setup the Dividend Control Update as:")]
        public void DIVX1060SetupTheDividendControlUpdate(Table table)
        {
            DIVX1060.BuildRequired.SetValue(1, table.Rows[0]["BuildRequired"]);
            WinFormsTestSteps.Transmit();
            if (table.Rows[0]["BuildRequired"] == "Y")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1062");
                DIVX1062.ReconAccount.SetValue(1, table.Rows[0]["ReconAccount"]);

                if (DIVX1062.PaymentAccount1.Exists() == true)
                {
                    DIVX1062.PaymentAccount1.SetValue(1, table.Rows[0]["PaymentAccount1"]);
                }
                if (DIVX1062.PaymentAccount2.Exists() == true)
                {
                    DIVX1062.PaymentAccount2.SetValue(1, table.Rows[0]["PaymentAccount2"]);
                }
                WinFormsTestSteps.Transmit();
                string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                if (formName == "DIVX1044")
                {
                    WinFormsTestSteps.Transmit();
                }
            }
        }

        /// <param name="table">data table</param>
        [When(@"In PAS01000 I setup the Payment Account Number Details as:")]
        public void PAS01000SetupThePaymentAccountNumberDetails(Table table)
        {
            PAS01000.Action.SetValue(1, table.Rows[0]["Action"]);
            PAS01000.Action.ClickField();
            WinFormsTestSteps.PressTAB();
            PAS01000.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            PAS01000.PaymentDesc.SetValue(1, table.Rows[0]["PaymentDesc"]);
            DateTime thisDay = DateTime.Today.AddDays(1);
            string CurrentDate = thisDay.ToString("dd'/'MM'/'yyyy");
            PAS01000.PaymentDate.SetValue(CurrentDate);
            PAS01000.PaymentType.SetValue(1, table.Rows[0]["PaymentType"]);
            if (table.Rows[0]["PaymentType"] == "D")
            {
                PAS01000.PaymentType.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01000.ImputationRate.SetValue(1, table.Rows[0]["ImputationRate"]);
                PAS01000.DualCurrency.SetValue(1, table.Rows[0]["DualCurrency"]);
                if (table.Rows[0]["DualCurrency"] == "Y")
                {
                    PAS01000.PaymentType.ClickField();
                    WinFormsTestSteps.PressTAB();
                    PAS01000.PaidCurrency.SetValue(1, table.Rows[0]["PaidCurrency"]);
                }
            }

            PAS01000.BaseCurrency.SetValue(1, table.Rows[0]["BaseCurrency"]);
            PAS01000.ReconBYCshare.SetValue(1, table.Rows[0]["ReconBYCshare"]);
            PAS01000.AccurateReconciled.SetValue(1, table.Rows[0]["AccurateReconciled"]);
            PAS01000.WebReporting.SetValue(1, table.Rows[0]["WebReporting"]);
            PAS01000.DissenterAccountInd.SetValue(1, table.Rows[0]["DissenterAccountInd"]);
            PAS01000.ReplaceAllowedInd.SetValue(1, table.Rows[0]["ReplaceAllowedInd"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01004");
        }

        /// <param name="table">data table</param>
        [When(@"In PAS01002 I setup the Payment Account Number Details as:")]
        public void PAS01002SetupThePaymentAccountNumberDetails(Table table)
        {
            PAS01002.AustTaxFlag.SetValue(1, table.Rows[0]["AustTaxFlag"]);
            PAS01002.FinancialYear.SetValue(1, table.Rows[0]["FinancialYear"]);
            if (table.Rows[0]["AustTaxFlag"] == "Y")
            {
                PAS01002.AustTaxFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01002.AiirConvRateAus.SetValue(1, table.Rows[0]["AiirConvRateAus"]);
                PAS01002.SubCoyCode.SetValue(1, table.Rows[0]["SubCoyCode"]);
                PAS01002.InvestmentType.SetValue(1, table.Rows[0]["InvestmentType"]);
            }
            PAS01002.NZTaxFlag.SetValue(1, table.Rows[0]["NZTaxFlag"]);
            if (table.Rows[0]["NZTaxFlag"] == "Y")
            {
                PAS01002.NZTaxFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01002.ConversionRateNZ.SetValue(1, table.Rows[0]["ConversionRateNZ"]);
            }
            PAS01002.GbrTaxFlag.SetValue(1, table.Rows[0]["GbrTaxFlag"]);
            if (table.Rows[0]["GbrTaxFlag"] == "Y")
            {
                PAS01002.GbrTaxFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01002.ConversionRateGbr.SetValue(1, table.Rows[0]["ConversionRateGbr"]);
            }
            PAS01002.USTaxFlag.SetValue(1, table.Rows[0]["USTaxFlag"]);
            if (table.Rows[0]["USTaxFlag"] == "Y")
            {
                PAS01002.USTaxFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01002.ConversionRateUS.SetValue(1, table.Rows[0]["ConversionRateUS"]);
                PAS01002.USTaxYear.SetValue(1, table.Rows[0]["USTaxYear"]);
            }
            PAS01002.IrlTaxFlag.SetValue(1, table.Rows[0]["IrlTaxFlag"]);
            if (table.Rows[0]["IrlTaxFlag"] == "Y")
            {
                PAS01002.IrlTaxFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01002.IrlTaxFlag.SetValue(1, table.Rows[0]["IrlTaxFlag"]);
                PAS01002.IrlTaxYear.SetValue(1, table.Rows[0]["IrlTaxYear"]);
            }
            PAS01002.ZafTaxFlag.SetValue(1, table.Rows[0]["ZafTaxFlag"]);
            if (table.Rows[0]["ZafTaxFlag"] == "Y")
            {
                PAS01002.IrlTaxFlag.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01002.ConversionRateZaf.SetValue(1, table.Rows[0]["ConversionRateZaf"]);
                PAS01002.ZafTaxYear.SetValue(1, table.Rows[0]["ZafTaxYear"]);
            }
            PAS01002.LastBatchChequeNbr.SetValue(1, table.Rows[0]["LastBatchChequeNbr"]);
            PAS01002.LastBatchChequeNbr.SetValue(1, table.Rows[0]["LastBatchChequeNbr"]);
            PAS01002.LastBankTapeNbr.SetValue(1, table.Rows[0]["LastBankTapeNbr"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01040");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01001");
        }

        /// <param name="table">data table</param>
        [When(@"In PAS01004 I setup the Payment Account Number Details as:")]
        public void PAS01004SetupThePaymentAccountNumberDetails(Table table)
        {
            PAS01004.LineSelectionX.SetValue(1, table.Rows[0]["LineSelectionXOC"]);
            PAS01004.LineSelectionX.SetValue(2, table.Rows[0]["LineSelectionXRC"]);
            PAS01004.LineSelectionX.SetValue(3, table.Rows[0]["LineSelectionOD"]);
            PAS01004.LineSelectionX.SetValue(4, table.Rows[0]["LineSelectionRD"]);
            PAS01004.LineSelectionX.SetValue(5, table.Rows[0]["LineSelectionFC"]);
            PAS01004.DcrReplaceType.SetValue(1, table.Rows[0]["DcrReplaceType"]);
            PAS01004.Action.SetValue(1, table.Rows[0]["Action1"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01004");
            WinFormsTestSteps.Transmit();

            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "PAS01080")
            {
                WinFormsTestSteps.Transmit();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01005");
        }

        /// <param name="table">data table</param>
        [When(@"In PAS01005 I setup the Payment Account Number Details as:")]
        public void PAS01005SetupThePaymentAccountNumberDetails(Table table)
        {
            PAS01005.UnclaimedMoneyReport.SetValue(1, table.Rows[0]["UnclaimedMoneyReport"]);
            PAS01005.DepartmentCode.SetValue(1, table.Rows[0]["DepartmentCode"]);
            if (table.Rows[0]["UnclaimedMoneyReport"] == "Y")
            {
                PAS01005.UnclaimedMoneyReport.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01005.UnclaimedMoniesFileRecipientType.SetValue(1, table.Rows[0]["UnclaimedMoniesFileRecipientType"]);
                PAS01005.PaymentAccountBalanced.SetValue(1, table.Rows[0]["PaymentAccountBalanced"]);
                PAS01005.ReportGroup.SetValue(1, table.Rows[0]["ReportGroup"]);
            }
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01002");
        }

        [When(@"In RSS25010 I Enter URR Parameter as:")]
        public void RSS25010EnterURRParameter(Table table)
        {
            RSS25010.NightlyRunInd.SetValue(1, table.Rows[0]["NightlyRunInd"]);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "RSS25020")
            {
                RSS25020.Action.SetValue(1, table.Rows[0]["Action"]);
                WinFormsTestSteps.Transmit();
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("JOBSUB03");
        }

        /// <param name="table">data table</param>
        [When(@"I update Payment Account Number Details as:")]
        public void UpdatePaymentAccountNumberDetails(Table table)
        {
            PAS01000.Action.SetValue(1, table.Rows[0]["Action"]);
            PAS01000.Action.ClickField();
            WinFormsTestSteps.PressTAB();
            PAS01000.ReinitiateSearch.SetValue(1, table.Rows[0]["ReinitiateSearch"]);
            WinFormsTestSteps.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01001");
            PAS01001.Action.SetValue(1, table.Rows[0]["Action1"]);
            WinFormsTestSteps.PressTAB();
            DateTime thisDay = DateTime.Today.AddDays(1);
            string CurrentDate = thisDay.ToString("dd'/'MM'/'yyyy");
            PAS01000.PaymentDate.SetValue(CurrentDate);
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "PAS01070")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01004");
            PAS01004.LineSelectionX.SetValue(1, table.Rows[0]["LineSelectionXOC"]);
            PAS01004.LineSelectionX.SetValue(2, table.Rows[0]["LineSelectionXRC"]);
            PAS01004.LineSelectionX.SetValue(3, table.Rows[0]["LineSelectionOD"]);
            PAS01004.LineSelectionX.SetValue(4, table.Rows[0]["LineSelectionRD"]);
            PAS01004.LineSelectionX.SetValue(5, table.Rows[0]["LineSelectionFC"]);
            PAS01004.DcrReplaceType.SetValue(1, table.Rows[0]["DcrReplaceType"]);
            PAS01004.Action.SetValue(1, table.Rows[0]["Action2"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01004");
            WinFormsTestSteps.Transmit();
            //WinFormsTestSteps.ExpectToBeInTheScreen("PAS01080");
            //WinFormsTestSteps.Transmit();
            //WinFormsTestSteps.ExpectToBeInTheScreen("PAS01005");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01001");
        }


        [When(@"In PAS01001 I change the payment account details as:")]
        public void PAS01001ChangeThePaymentAccountDetailsAs(Table table)
        {
            //WinFormsTestSteps.ExpectToBeInTheScreen("PAS01000");

            string ReinitiateSearch = table.Rows[0]["ReinitiateSearch"];
            string[] thisArray = ReinitiateSearch.Split(',');   
            List<string> myList = new List<string>();    
            myList.AddRange(thisArray);

            for (var i = 0; i < myList.Count; i++)
            {
                PAS01000.Action.SetValue("S");
                PAS01000.Action.ClickField();
                WinFormsTestSteps.PressTAB();
                PAS01000.ReinitiateSearch.SetValue(myList[i]);
                WinFormsTestSteps.Transmit();

                PAS01000.Action.SetValue("C");
                PAS01000.Action.ClickField();
                WinFormsTestSteps.PressTAB();
                WinFormsTestSteps.ExpectToBeInTheScreen("PAS01001");
                DateTime thisDay = DateTime.Today.AddDays(1);
                string CurrentDate = thisDay.ToString("dd'/'MM'/'yyyy");
                PAS01000.PaymentDate.SetValue(CurrentDate);
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                if (formName == "PAS01070")
                    WinFormsTestSteps.Transmit();

                WinFormsTestSteps.ExpectToBeInTheScreen("PAS01004");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                if (formName == "PAS01080")
                {
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                }

                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

                if (formName == "PAS01005")
                    WinFormsTestSteps.Transmit();

                WinFormsTestSteps.ExpectToBeInTheScreen("PAS01002");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                if (formName == "PAS01040")
                    WinFormsTestSteps.Transmit();

                WinFormsTestSteps.ExpectToBeInTheScreen("PAS01001");
            }





        }

        [When(@"In DIVX1010 I setup the Dividend parameters as:")]
        public void DIVX1010SetupTheDividendParametersAs(Table table)
        {
            //#### IN. Initial Payment Parameter Setup ####
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1005");
            DIVX1005.AutomatedJobRelease.SetValue(1, table.Rows[0]["AutomatedJobRelease"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1008");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1010");

            DateTime thisDay = DateTime.Today.AddDays(1);
            string CurrentDate = thisDay.ToString("dd'/'MM'/'yyyy");
            DIVX1010.PaymentDate.SetValue(CurrentDate);
            DIVX1010.ListDate.SetValue(CurrentDate);
            DIVX1010.BooksCloseDate.SetValue(CurrentDate);
            DIVX1010.PaidTODate.SetValue(CurrentDate);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1012");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1013");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            var _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (_formName == "DIVX1016")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1020");
        }

        [When(@"In DIVX1022 I setup the Dividend parameters as:")]
        public void DIVX1022SetupTheDividendParametersAs(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1022");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1024");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            var _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (_formName == "DIVX1030")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1030");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (_formName == "DIVX1031")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1031");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }


            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1033");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (_formName != "DIVX1034")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1034");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (_formName != "DIVX1035")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }


            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1035");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (_formName != "DIVX1040")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }
                        
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1040");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (_formName != "DIVX1060" && _formName != "DIVX1042" && _formName != "DIVX1048")
            {

                while (_formName != "DIVX1046")
                {
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                }

                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1046");
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                while (_formName == "DIVX1046")
                {
                    WinFormsTestSteps.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                }



                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                while (_formName != "DIVX1048")
                {
                    WinFormsTestSteps.Transmit();

                    _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                }
                WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1048");
                WinFormsTestSteps.Transmit();

            }

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (_formName == "DIVX1048")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            if (_formName == "DIVX1042")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while(_formName== "DIVX1060")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

   
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1062");
            WinFormsTestSteps.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (_formName != "DIVX1020")
            {
                WinFormsTestSteps.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                _formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1020");

        }

        [When(@"In DIVX1001 I delete the Dividend as:")]
        public void DeleteTheDividendAs(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1001");
            DIVX1001.Preload.SetValue("D");
            DIVX1001.InputDivCode.SetValue(1, table.Rows[0]["InputDivCode"]);
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1003");
            DIVX1003.ConfirmDelete.SetValue("Y");
            WinFormsTestSteps.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1001");
        }


        [When(@"I continue with the following details for Divdends in nhk_menu:")]
        public void ContinueWithTheFollowingDetailsForDivdendsInNhk_Menu(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
                BuildDividendsNhk_MenuVMS(table);
            else
                BuildDividendsNhk_MenuLinux(table);

            ReportingTestSteps.ReportRunTime = DateTime.Now;
        }


        public void BuildDividendsNhk_MenuVMS(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);
            
            SSHManager.SendShellCommand("sc " + currentCOY, host, new List<String>(), new List<String>());

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria1"]);
            failCriteria.Add(table.Rows[0]["VMSfailCriteria1"]);
            SSHManager.SendShellCommand("nhk_menu", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("ops", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sstp", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("div", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            var InputDivCode = table.Rows[0]["InputDivCode"];
            SSHManager.SendShellCommand(InputDivCode, host, passCriteria, failCriteria);

            SSHManager.SendShellCommand("S", host, new List<String>(), new List<String>());

            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.Disconnect();

        }


        public void BuildDividendsNhk_MenuLinux(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);

            SSHManager.SendShellCommand("sc " + currentCOY, host, new List<String>(), new List<String>());

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxpassCriteria1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("nhk", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("opsm", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxpassCriteria3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sstp", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxpassCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("div", host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxpassCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("REGN", host, passCriteria, failCriteria);

            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.SendShellCommand("", host, new List<String>(), new List<String>());
            SSHManager.Disconnect();


        }

        [When(@"I release Dividends jobs:")]
        public void ReleaseDividendsJobs(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
                ReleaseDividendsJobsVMS(table);
            else
                ReleaseDividendsJobsLinux(table);

        }

        public void ReleaseDividendsJobsVMS(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sc " + currentCOY, host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sd " + table.Rows[0]["DividendName"], host, passCriteria, failCriteria);

            //releasing DIV_SPLIT_REGN_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria3"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName1"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);


            //releasing DIV_CALC_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria4"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName2"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_CHEQUES_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria5"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName3"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_CHEQUES_REGN_D_USD_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria6"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName4"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_ADVICES_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria7"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName5"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_DCREDIT_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria8"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName6"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_NILMNY_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria9"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName7"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_RECN_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria10"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName8"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_RECN_REGN_D_USD_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria11"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName9"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_DIVLST_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria12"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName10"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_END_CALC_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria13"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName11"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_DIVBLD_REGN_D_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria14"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName12"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_PAY_COMBINE_REGN_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria15"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName13"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);

            //releasing DIV_DIVHIS_BUILD_REGN_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria16"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("js " + table.Rows[0]["VMSJobName14"], host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("1", host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteVMS(table);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("", host, passCriteria, failCriteria);
            
        }


        public void ReleaseDividendsJobsLinux(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            SSHManager.Connect(ref SSHManager.strTestCaseFailReason);

            List<String> passCriteria;
            List<String> failCriteria;

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria1"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("sc " + currentCOY, host, passCriteria, failCriteria);

            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["VMSpassCriteria2"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("cd " + table.Rows[0]["DividendName"], host, passCriteria, failCriteria);

            //relaseing div_split_regn_sad_a.sh
            var LinuxJobName1 = table.Rows[0]["VMSJobName1"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName1, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            // releasing div_calc_regn_d_sad_a.sh
            var LinuxJobName2 = table.Rows[0]["VMSJobName2"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName2, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_CHEQUES_REGN_D_SAD_A.COM
            var LinuxJobName3 = table.Rows[0]["VMSJobName3"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName3, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_CHEQUES_REGN_D_USD_SAD_A.COM
            var LinuxJobName4 = table.Rows[0]["VMSJobName4"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName4, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_ADVICES_REGN_D_SAD_A.COM
            var LinuxJobName5 = table.Rows[0]["VMSJobName5"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName5, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_DCREDIT_REGN_D_SAD_A.COM
            var LinuxJobName6 = table.Rows[0]["VMSJobName6"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName6, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_NILMNY_REGN_D_SAD_A.COM
            var LinuxJobName7 = table.Rows[0]["VMSJobName7"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName7, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_RECN_REGN_D_SAD_A.COM
            var LinuxJobName8 = table.Rows[0]["VMSJobName8"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName8, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_RECN_REGN_D_USD_SAD_A.COM
            var LinuxJobName9 = table.Rows[0]["VMSJobName9"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName9, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_DIVLST_REGN_D_SAD_A.COM
            var LinuxJobName10 = table.Rows[0]["VMSJobName10"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName10, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_END_CALC_REGN_D_SAD_A.COM
            var LinuxJobName11 = table.Rows[0]["VMSJobName11"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName11, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_DIVBLD_REGN_D_SAD_A.COM
            var LinuxJobName12 = table.Rows[0]["VMSJobName12"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName12, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_PAY_COMBINE_REGN_SAD_A.COM
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + table.Rows[0]["LinuxJobName13"], host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

            //releasing DIV_DIVHIS_BUILD_REGN_SAD_A.COM
            var LinuxJobName14 = table.Rows[0]["VMSJobName14"].ToLower().Replace("com", "sh");
            passCriteria = new List<String>();
            failCriteria = new List<String>();
            passCriteria.Add(table.Rows[0]["LinuxPassCriteria"]);
            failCriteria.Add(table.Rows[0]["failCriteria1"]);
            SSHManager.SendShellCommand("job submit " + LinuxJobName14, host, passCriteria, failCriteria);

            SSHManager.WaitForJobcompleteLinux(table);

        }


        public void ReadAuthorisationRefFromPlanTotFile(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                VMSReadAuthorisationRefFromPlanTotFile(table);
            }
            else
            {
                LinuxReadAuthorisationRefFromPlanTotFile(table);
            }
        }


        public void VMSReadAuthorisationRefFromPlanTotFile(Table table)
        {
            var ReportPrintFileName = "$PLNTOT_D.PRN";
            var currentCOY = table.Rows[0]["COY"];
            var divDir = table.Rows[0]["InputDivCode"];

            using (var sshClient = new SshClient("CSSHYC", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    char cs = (char)34;

                    String str = "pipe sc " + currentCOY + " && set def [.div" + divDir +"] && search " + ReportPrintFileName + " " + cs + "(DIPX50:" + cs;
                    var cmd = sshClient.RunCommand(str);
                    var output = cmd.Result;
                    Timestamps = output;

                    int start = Timestamps.IndexOf("DIPX50:\u001b") + 11;
                    int end = Timestamps.IndexOf(")", start);
                    Timestamps = Timestamps.Substring(start, end - start);
                    Timestamps = Timestamps.Replace(".", "").Replace(":", "");
                    Timestamps = Timestamps.Substring(0, 6);
                    Console.WriteLine("AuthorisationRef: "+Timestamps);
                    sshClient.Disconnect();
                }
            }



        }

        [When(@"I go to Dividend Control Update Menu")]
        public void GoToDividendControlUpdateMenu()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            MNS00101.SystemParameterSetups.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00101");
            SPS00101.MenuItemDiv.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00102");
            SPS00102.MenuItemDpp.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIVX1001");
        }

        [When(@"I go to Payment Automated job release Menu")]
        public void GoToPaymentAutomatedJobReleaseMenu()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            MNS00101.SystemParameterSetups.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00101");
            SPS00101.MenuItemDiv.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00102");
            SPS00102.MenuItemPjm.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("DIS05010");

        }

        [When(@"I release the Divhis Build and Pay Combine job as:")]
        public void ReleaseTheDivhisBuildAndPayCombineJob(Table table)
        {

            if (WinFormsTestSteps.Environment == "CSSHYC")
                ReleaseTheDivhisBuildAndPayCombineJobVMS(table);
            else
                ReleaseTheDivhisBuildAndPayCombineJobLinux(table);      
        }


        public void ReleaseTheDivhisBuildAndPayCombineJobVMS(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            string InputDivCode = table.Rows[0]["InputDivCode"];

            using (var sshClient = new SshClient("CSSHY2", "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    if (table.Rows[0]["PlnCombine"] == "Y")
                    {
                        //Release DIV_PLN_COMBINE Job
                        var cmd = sshClient.RunCommand("@scrip$com:jd132 j:DIV_PLN_COMBINE_" + InputDivCode + "_" + currentCOY + " s:DEFERRED");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        var jobNumber = output;

                        int start = jobNumber.IndexOf("BUILDQ1") + 7;
                        int end = jobNumber.IndexOf("DIV", start);
                        string result = jobNumber.Substring(start, end - start).Trim();
                        cmd = sshClient.RunCommand("set entry " + result + " /rel");

                        ReportingTestSteps.ReportJobNumber = result;
                        ReportingTestSteps.WaitForJobNumberVMS(table);
                    }

                    if (table.Rows[0].ContainsKey("PayCombine"))
                    {
                        if (table.Rows[0]["PayCombine"] == "Y")
                        {
                            //Release DIV_PAY_COMBINE Job

                            var cmd = sshClient.RunCommand("@scrip$com:jd132 j:DIV_PAY_COMBINE_" + InputDivCode + "_" + currentCOY + " s:DEFERRED");
                            var output = cmd.Result.Replace("/n/r", "").Trim();
                            var jobNumber = output;

                            int start = jobNumber.IndexOf("BUILDQ1") + 7;
                            int end = jobNumber.IndexOf("DIV", start);
                            string result = jobNumber.Substring(start, end - start).Trim();
                            cmd = sshClient.RunCommand("set entry " + result + " /rel");

                            ReportingTestSteps.ReportJobNumber = result;
                            ReportingTestSteps.WaitForJobNumberVMS(table);
                        }

                    }

                    if (table.Rows[0]["DivHisBuild"] == "Y")
                    {
                        //Release DIV_DIVHIS_BUILD Job

                        var cmd = sshClient.RunCommand("@scrip$com:jd132 j:DIV_DIVHIS_BUILD_" + InputDivCode + "_" + currentCOY + " s:DEFERRED");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        var jobNumber = output;

                        int start = jobNumber.IndexOf("BUILDQ1") + 7;
                        int end = jobNumber.IndexOf("DIV", start);
                        string result = jobNumber.Substring(start, end - start).Trim();
                        cmd = sshClient.RunCommand("set entry " + result + " /rel");

                        ReportingTestSteps.ReportJobNumber = result;
                        ReportingTestSteps.WaitForJobNumberVMS(table);
                    }
                 sshClient.Disconnect();
                }
            }
            
        }

        public void ReleaseTheDivhisBuildAndPayCombineJobLinux(Table table)
        {
            string host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
            {
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];
            }
            string currentCOY = table.Rows[0]["COY"];
            string InputDivCode = table.Rows[0]["InputDivCode"];

            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    if (table.Rows[0]["PlnCombine"] == "Y")
                    {
                        //Release DIV_PLN_COMBINE Job
                        var cmd = sshClient.RunCommand("job show --jobname div_pln_combine_"+InputDivCode+"_"+ currentCOY+ " --status pend");


                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        var jobNumber = output;

                        int start = jobNumber.IndexOf("buildq1") + 7;
                        int end = jobNumber.IndexOf("div", start);
                        string result = jobNumber.Substring(start, end - start).Trim();
                        cmd = sshClient.RunCommand("job release " + result);

                        ReportingTestSteps.ReportJobNumber = result;
                        ReportingTestSteps.WaitForJobNumberLinux(table);
                    }

                    if (table.Rows[0].ContainsKey("PayCombine"))
                    {
                        if (table.Rows[0]["PayCombine"] == "Y")
                        {
                            //Release DIV_PAY_COMBINE Job

                            var cmd = sshClient.RunCommand("job show --jobname div_pay_combine_" + InputDivCode + "_" + currentCOY + " --status pend");
                            var output = cmd.Result.Replace("/n/r", "").Trim();
                            var jobNumber = output;

                            int start = jobNumber.IndexOf("buildq1") + 7;
                            int end = jobNumber.IndexOf("div", start);
                            string result = jobNumber.Substring(start, end - start).Trim();
                            cmd = sshClient.RunCommand("job release " + result);

                            ReportingTestSteps.ReportJobNumber = result;
                            ReportingTestSteps.WaitForJobNumberLinux(table);
                        }
                    }
                    
                    if (table.Rows[0]["DivHisBuild"] == "Y")
                    {

                        //Release DIV_DIVHIS_BUILD Job

                        var cmd = sshClient.RunCommand("job show --jobname div_divhis_build_" + InputDivCode + "_" + currentCOY + " --status pend");
                        var output = cmd.Result.Replace("/n/r", "").Trim();
                        var jobNumber = output;

                        int start = jobNumber.IndexOf("buildq1") + 7;
                        int end = jobNumber.IndexOf("div", start);
                        string result = jobNumber.Substring(start, end - start).Trim();
                        cmd = sshClient.RunCommand("job release " + result);

                        ReportingTestSteps.ReportJobNumber = result;
                        ReportingTestSteps.WaitForJobNumberLinux(table);
                    }

                sshClient.Disconnect();
                }
            }
        }

        [When(@"I go to Define Payment Account menu")]
        public void GoToDefinePaymentAccountMenu()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            MNS00101.SystemParameterSetups.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00101");
            SPS00101.MenuItemDiv.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("SPS00102");
            SPS00102.MenuItemDfa.ClickField();
            WinFormsTestSteps.ExpectToBeInTheScreen("PAS01000");

        }

        public void LinuxReadAuthorisationRefFromPlanTotFile(Table table)
        {
            var ReportPrintFileName = "$plntot_d.prn";
            var currentCOY = table.Rows[0]["COY"];
            var DivCode = table.Rows[0]["InputDivCode"];
            var DivDir = currentCOY+"/div"+DivCode;

            char dq = (char)34;
            char sq = (char)39;

            var host = WinFormsTestSteps.Environment;
            if (host == null)
                host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];

            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    String str = "sc " + DivDir + " && grep " + dq + "(DIPX50" + dq + " " + sq + ReportPrintFileName + sq;
                    var cmd = sshClient.RunCommand(str);
                    var output = cmd.Result;
                    Timestamps = output;
                    int start = Timestamps.IndexOf("(DIPX50:") + 8;
                    int end = Timestamps.IndexOf(")", start);
                    Timestamps = Timestamps.Substring(start, end - start);
                    Timestamps = Timestamps.Replace(".", "").Replace(":", "");
                    Timestamps = Timestamps.Substring(0, 6);
                    Console.WriteLine("AuthorisationRef: " + Timestamps);

                    sshClient.Disconnect();
                }
            }

        }


        public void ReadAuthorisationRefFromdDivCtlFile(Table table)
        {
            if (WinFormsTestSteps.Environment == "CSSHYC")
            {
                //VMSReadAuthorisationRefFromdDivCtlFile(table);
                //DO NOTHING
            }
            else
            {
                LinuxReadAuthorisationRefFromdDivCtlFile(table);
            }
        }


        public void LinuxReadAuthorisationRefFromdDivCtlFile(Table table)
        {
            var ReportPrintFileName = "$divctl_xxxx.prn";
            var currentCOY = table.Rows[0]["COY"];
            var DivCode = table.Rows[0]["InputDivCode"];
            var PRNDir = currentCOY + "/prn";
            ReportPrintFileName = ReportPrintFileName.Replace("xxxx", DivCode);
            char dq = (char)34;
            char sq = (char)39;

            var host = WinFormsTestSteps.Environment;
            if (host == null)
                host = System.Environment.GetEnvironmentVariable("VMHOST");
            if (host == null)
                host = ConfigurationManager.AppSettings["DefaultWinformsNode"];

            using (var sshClient = new SshClient(host, "autotest01", "computershare"))
            {
                sshClient.Connect();
                if (sshClient.IsConnected == true)
                {
                    String str = "sc " + PRNDir + " && grep " + dq + "(DVXCTL:" + dq + " " + sq + ReportPrintFileName + sq;
                    var cmd = sshClient.RunCommand(str);
                    var output = cmd.Result;
                    currentDateTime = output;
                    int start = currentDateTime.IndexOf("(DVXCTL:") + 8;
                    int end = currentDateTime.IndexOf(")", start);
                    currentDateTime = currentDateTime.Substring(start, end - start);
                    currentDateTime = currentDateTime.Replace(".", "").Replace(":", "");
                    currentDateTime = currentDateTime.Substring(0, 6);
                    Console.WriteLine("AuthorisationRef: " + currentDateTime);

                    sshClient.Disconnect();
                }
            }
        }





    }
}