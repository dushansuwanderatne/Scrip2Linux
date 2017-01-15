using System;
using System.Linq;
using NUnit.Framework;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class EmployeePlanProcessing
    {
        private static string RunNumber;
        private static string BulkID;
        public EmployeePlanProcessing()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }

        public static String GetRunNumber()
        {
            string value = "";
            try
            {
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                value = ENS01060.SystemInfoFree4.GetValue().Trim();
                RunNumber = value.Substring(0, 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail(ex.Message);
            }
            return RunNumber;
        }

        [When(@"In EOL01701 I Add ESS Employee Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""(.*)""")]
        public void AddESSEmployeeDetails(string TranNo, string EmployeeID, string EffectiveDate, string EmployeeStatus, string LeaverCode, string PayrollID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.SetValue(TranNo);
            EOL01701.PayrollID.SetValue(PayrollID);
            EOL01701.EmployeeNumber.SetValue(EmployeeID);
            EOL01701.EmployeeStatus.SetValue(EmployeeStatus);
            //EOL01701_SCRIPOnlineDataEntrySystemMENU.LeaverCode.SetValue(LeaverCode);
            EOL01701.EffectiveDate.SetValue(EffectiveDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL01701 I Add ESS Employee Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddESSEmployeeDetailsPart1(string TranNo, string PayrollID, string EmployeeID, string SubPayrollID, string GenerateEmpUniqueID, string EmpUniqueID, string StartDate, string TermDate, string TermDesc, string PreferredName, string EmployeeStatus, string LeaverCode, string EffectiveDate, string BirthDate, string AutoForfeit, string BlackoutInd, string BlackoutCode, string LocationCode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.SetValue(TranNo);
            EOL01701.PayrollID.SetValue(PayrollID);
            EOL01701.EmployeeNumber.SetValue(EmployeeID);
            EOL01701.SubPayrollID.SetValue(SubPayrollID);
            EOL01701.GenEmpUniqueID.SetValue(GenerateEmpUniqueID);
            EOL01701.EmployeeUniqueID.SetValue(EmpUniqueID);
            EOL01701.StartDate.SetValue(StartDate);
            EOL01701.TermDate.SetValue(TermDate);
            EOL01701.TermDesc.SetValue(TermDesc);
            EOL01701.PreferredName.SetValue(PreferredName);
            EOL01701.EmployeeStatus.SetValue(EmployeeStatus);
            EOL01701.LeaverCode.SetValue(LeaverCode);
            EOL01701.EffectiveDate.SetValue(EffectiveDate);
            EOL01701.BirthDate.SetValue(BirthDate);
            EOL01701.AutoForfeit.SetValue(AutoForfeit);
            EOL01701.BlkoutRstrctdInd.SetValue(BlackoutInd);
            EOL01701.BlkoutRstrctdCode.SetValue(BlackoutCode);
            EOL01701.LocationCode.SetValue(LocationCode);
        }

        [When(@"In EOL01701 I Add ESS Employee Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddESSEmployeeDetailsPart2(string BusinessUnit, string JobBand, string CostCentre, string EmpFlag1, string EmpFlag2, string Offers, string Statements, string SharePlanComm, string NoticeOfMeeting)
        {
            EOL01701.BusinessUnit.SetValue(BusinessUnit);
            EOL01701.JobBand.SetValue(JobBand);
            EOL01701.CostCentre.SetValue(CostCentre);
            EOL01701.EmployeeFlag1.SetValue(EmpFlag1);
            EOL01701.EmployeeFlag2.SetValue(EmpFlag2);
            EOL01701.EmpCommOffer.SetValue(Offers);
            EOL01701.EmpCommStmnt.SetValue(Statements);
            EOL01701.EmpCommAdhoc.SetValue(SharePlanComm);
            EOL01701.EmpCommMeeting.SetValue(NoticeOfMeeting);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL01701 I Change ESS Employee Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeESSEmployeeDetailsPart1(string NewTranNo, string NewPayrollID, string NewEmployeeID, string NewSubPayrollID, string NewGenerateEmpUniqueID, string NewEmpUniqueID, string NewStartDate, string NewTermDate, string NewTermDesc, string NewPreferredName, string NewEmployeeStatus, string NewLeaverCode, string NewEffectiveDate, string NewBirthDate, string NewAutoForfeit, string NewBlackoutInd, string NewBlackoutCode, string NewLocationCode)
        {
            EOL01701.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.SetValue(NewTranNo);
            EOL01701.PayrollID.SetValue(NewPayrollID);
            EOL01701.EmployeeNumber.SetValue(NewEmployeeID);
            EOL01701.SubPayrollID.SetValue(NewSubPayrollID);
            EOL01701.GenEmpUniqueID.SetValue(NewGenerateEmpUniqueID);
            EOL01701.EmployeeUniqueID.SetValue(NewEmpUniqueID);
            EOL01701.StartDate.SetValue(NewStartDate);
            EOL01701.TermDate.SetValue(NewTermDate);
            EOL01701.TermDesc.SetValue(NewTermDesc);
            EOL01701.PreferredName.SetValue(NewPreferredName);
            EOL01701.EmployeeStatus.SetValue(NewEmployeeStatus);
            EOL01701.LeaverCode.SetValue(NewLeaverCode);
            EOL01701.EffectiveDate.SetValue(NewEffectiveDate);
            EOL01701.BirthDate.SetValue(NewBirthDate);
            EOL01701.AutoForfeit.SetValue(NewAutoForfeit);
            EOL01701.BlkoutRstrctdInd.SetValue(NewBlackoutInd);
            EOL01701.BlkoutRstrctdCode.SetValue(NewBlackoutCode);
            EOL01701.LocationCode.SetValue(NewLocationCode);
        }

        [When(@"In EOL01701 I Change ESS Employee Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeESSEmployeeDetailsPart2(string NewBusinessUnit, string NewJobBand, string NewCostCentre, string NewEmpFlag1, string NewEmpFlag2, string NewOffers, string NewStatements, string NewSharePlanComm, string NewNoticeOfMeeting)
        {
            EOL01701.BusinessUnit.SetValue(NewBusinessUnit);
            EOL01701.JobBand.SetValue(NewJobBand);
            EOL01701.CostCentre.SetValue(NewCostCentre);
            EOL01701.EmployeeFlag1.SetValue(NewEmpFlag1);
            EOL01701.EmployeeFlag2.SetValue(NewEmpFlag2);
            EOL01701.EmpCommOffer.SetValue(NewOffers);
            EOL01701.EmpCommStmnt.SetValue(NewStatements);
            EOL01701.EmpCommAdhoc.SetValue(NewSharePlanComm);
            EOL01701.EmpCommMeeting.SetValue(NewNoticeOfMeeting);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL01701 I Change the Employee Static Details:")]
        public void ChangeTheEmployeeStaticDetails(Table EOStatic)
        {
            string TranNo = EOStatic.GetData("TranNo");
            string StartDate = EOStatic.GetData("StartDate");
            string PreferredName = EOStatic.GetData("PreferredName");
            //ExpectToBeInTheScreen("EOL01701");
            EOL01701.Action.SetValue("c");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EOL01701.TransNumber.SetValue(TranNo);
            EOL01701.StartDate.SetValue(StartDate);
            EOL01701.PreferredName.SetValue(PreferredName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            OLS00101.Selection.SetValue("EX");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            EOL00126.Selection.SetValue("EX");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00115 I click on ""(.*)"" as the Register type")]
        public void ClickOnAsTheRegisterType(string RegisterType)
        {
            /* switch (RegisterType.ToLower())
             {
                 case "EB":
                     EOL00115.MenUItemEB.ClickField();
                     break;

                 case "EF":
                     EOL00115.MenUItemEF.ClickField();
                     break;

                 default:
                     break;
             }
             Spartan.Core.WinForms.WinFormsDriver.Transmit();*/

            EOL00115.Selection.SetValue(RegisterType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        public void ClickOnEOL00109EmployeeGrantProcessingMenu(string Selection)
        {
            switch (Selection.ToLower())
            {
                case "manual grant of options":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00109.MenuItemGrt.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
                    break;

                case "reversal of grant":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00109.MenuItemRva.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
                    break;

                default:
                    break;
            }
        }

        public void ClickOnEOL00126EmployeeSchemeProcessingMenu(string Selection)
        {
            switch (Selection.ToLower())
            {
                case "employee scheme processing":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00126.MenuItemEsp.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00101");
                    break;

                default:
                    break;
            }
        }

        [When(@"In EOL00114 I Click on ""(.*)"" with in the Award processing sub menu")]
        public void ClickOnWithInTheAwardProcessingSubMenu(string AwardSelection)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00114");
            switch (AwardSelection.ToLower())
            {
                case "Health & Integrity Check":
                    EOL00114.MenuItemInt.ClickField();
                    break;

                case "Manual Award of Units":
                    EOL00114.MenuItemAwm.ClickField();
                    break;

                default:
                    break;
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00126 I click on ""(.*)"" within the EP system menu")]
        public void ClickOnWithinTheEPSystemMenu(string EPMenuOption)
        {
            //ExpectToBeInTheScreen("EOL00126");
            switch (EPMenuOption.ToLower())
            {
                case "Employee Scheme Processing":
                    EOL00126.MenuItemEsp.ClickField();
                    break;

                case "Employee Static Details Health Integrity":
                    EOL00126.MenuItemEhi.ClickField();
                    break;

                case "Exit Menu":
                    OLS00101.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00113 I click on ""(.*)"" with in the EP system menu")]
        public void ClickOnWithInTheEPSystemMenu(string EPSubMenu)
        {
            /*switch (EPSubMenu.ToLower())
            {
                case "Awards":
                    EOL00113.MenUItemAWD.ClickField();
                    break;

                case "Sales and Transfers":
                    EOL00113.MenUItemSAT.ClickField();
                    break;

                default:
                    break;
             }*/
            EOL00113.MenuItemAwd.SetValue(EPSubMenu);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL01701 I Delete ESS Employee Details as ""(.*)"" ""(.*)""")]
        public void DeleteESSEmployeeDetails(string NewTranNo1, string ConfirmDelete)
        {
            EOL01701.Action.SetValue("D");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.SetValue(NewTranNo1);
            EOL01701.Confirm.SetValue(ConfirmDelete);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [Then(@"In ENSESS19 I should see Loan Balance details as")]
        public void ENSESS19ShouldSeeLoanBalanceDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS19");
            ENSESS19.DetailLine.ValidateFieldValueContains(1, table.Rows[0]["Line1"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(2, table.Rows[0]["Line2"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(3, table.Rows[0]["Line3"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(4, table.Rows[0]["Line4"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(5, table.Rows[0]["Line5"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(6, table.Rows[0]["Line6"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(7, table.Rows[0]["Line7"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(8, table.Rows[0]["Line8"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(9, table.Rows[0]["Line9"]);
            ENSESS19.DetailLine.ValidateFieldValueContains(10, table.Rows[0]["Line10"]);
            // Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00107 I Click on ""(.*)"" Menu")]
        public void EOL00107ClickOnMenu(string Selection)
        {
            switch (Selection.ToLower())
            {
                case "grant options":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemGrt.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00137");
                    break;

                case "leaver processing":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemLvp.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00131");
                    break;

                case "lapse cancellation processing":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemLpc.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00132");
                    break;

                case "ess option exercise reversal":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemRve.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
                    break;

                case "event processing":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemEvt.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00133");
                    break;

                case "multiple grant health integrity":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemInm.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00501");
                    break;

                case "multiple grant bulk uploads":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00107.MenuItemUpm.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00601");
                    break;

                default:
                    break;
            }
        }

        [When(@"In EOL00113 I click on ""(.*)"" Menu")]
        public void EOL00113ClickOnMenu(string Selection)
        {
            switch (Selection.ToLower())
            {
                case "forfeitures and terminations":
                    EOL00113.MenuItemFat.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00119");
                    break;

                case "payments":
                    EOL00113.MenuItemPay.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
                    break;

                case "awards":
                    EOL00113.MenuItemAwd.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
                    break;

                case "releases":
                    EOL00113.MenuItemRel.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
                    break;

                case "multiple awards health integrity":
                    EOL00113.MenuItemInm.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00501");
                    break;

                case "multiple awards bulk uploads":
                    EOL00113.MenuItemUpm.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00601");
                    break;

                default:
                    break;
            }
        }

        /// <param name="table">data table</param>
        [When(@"In EOL00119 I continue with the following details:")]
        public void EOL00119ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00119");
            EOL00119.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00123 I Click on ""(.*)"" Menu")]
        public void EOL00123ClickOnMenu(string Selection)
        {
            switch (Selection.ToLower())
            {
                case "awards":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00123.MenuItemAwd.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
                    break;

                case "payments":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00123.MenuItemPay.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
                    break;

                case "reconstruction reversal processing":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00123.Selection.SetValue("REC");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
                    break;

                default:
                    break;
            }
        }

        [When(@"In EOL00132 I Click on ""(.*)"" Menu")]
        public void EOL00132ClickOnMenu(string Selection)
        {
            switch (Selection.ToLower())
            {
                case "lapse options employee initiated":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00132.MenuItemLpe.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL02801");
                    break;

                case "lapse options company initiated":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00132.MenuItemLpc.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL02801");
                    break;

                case "cancel options employee initiated":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00132.MenuItemCle.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL02801");
                    break;

                case "cancel options company initiated":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00132.MenuItemClc.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL02801");
                    break;

                case "lapsecancel options reversal":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    EOL00132.MenuItemRvl.ClickField();
                    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
                    break;

                default:
                    break;
            }
        }

        [When(@"In EOL00135 I select ""(.*)""")]
        public void EOL00135ISelect(string Selection1)
        {
            EOL00135.Selection.SetValue(Selection1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00135 I Select Menu item as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00135SelectMenuItem(string EventNumber, string Selection, string MenuItem)
        {
            EOL00133.Selection.SetValue(EventNumber);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00134");
            EOL00134.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00135");
            EOL00135.Selection.SetValue(MenuItem);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In EOL00401 I continue with the following details:")]
        public void EOL00401ContinueWithTheFollowingDetails(Table table)
        {
            EOL00401.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            if (EOL00401.TotalUnits.Exists() == true)
            {
                EOL00401.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            }
            else if (EOL00401.TotalMoney.Exists() == true)
            {
                EOL00401.TotalMoney.SetValue(1, table.Rows[0]["TotalMoney"]);
            }

            table.Rows[0]["RvsalRunNumber"] = GetRunNumber();
            EOL00401.RvsalRunNumber.SetValue(1, table.Rows[0]["RvsalRunNumber"]);
            EOL00401.RvsalTransNumber.SetValue(1, table.Rows[0]["RvsalTransNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00402");
            if (EOL00402.FromUnits.Exists() == true)
            {
                EOL00402.FromUnits.ValidateFieldValue(1, table.Rows[0]["TotalUnits"]);
            }
            else if (EOL00402.TotalMoney.Exists() == true)
            {
                EOL00402.TotalMoney.ValidateFieldValue(1, table.Rows[0]["TotalMoney"]);
            }

            EOL00402.Confirm.SetValue("R");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        /// <param name="table">data table</param>
        [When(@"In EOL00401 I go to reconstruction reversal Menu")]
        public void EOL00401GoToReconstructionReversalMenu(Table table)
        {
            while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(table.Rows[0]["RegisterCode"]))
            {
                EOL00103.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            }

            EOL00103.Selection.SetValue(1, table.Rows[0]["RegisterCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00128");
            EOL00128.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        [When(@"In EOL00401 I go to Reveral Transaction Menu ""(.*)"" ""(.*)""")]
        public void EOL00401GoToReveralTransactionMenu(string RegisterCode, string Selection)
        {
            EOL00103.Selection.SetValue(RegisterCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //ExpectToBeInTheScreen("EOL00124");
            EOL00124.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        [When(@"In EOL00401 I perform Exercise Reversal Transaction as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00401PerformExerciseReversalTransaction(string Selection, string RegisterCode, string TransNumber, string TotalUnits, string RvsalRunNumber, string RvsalTransNumber)
        {
            //EOL00137.Selection.SetValue(Selection);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();

            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            //while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(RegisterCode))
            //{
            //    EOL00103.Selection.SetValue("NXT");
            //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //    WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            //}

            //EOL00103.Selection.SetValue(RegisterCode);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
            EOL00401.TransNumber.SetValue(TransNumber);
            EOL00401.TotalUnits.SetValue(TotalUnits);
            EOL00401.RvsalRunNumber.SetValue(RvsalRunNumber);
            EOL00401.RvsalTransNumber.SetValue(RvsalTransNumber);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00402");
            EOL00402.TotalUnits.ValidateFieldValue(TotalUnits);
            EOL00402.Confirm.SetValue("R");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        [When(@"In EOL00401 I Perform Leaver Processing Reversal as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00401PerformLeaverProcessingReversal(string Selection, string TransNumber, string TotalUnits, string RvsalRunNumber, string RvsalTransNumber)
        {
            EOL00131.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
            EOL00401.TransNumber.SetValue(TransNumber);
            EOL00401.TotalUnits.SetValue(TotalUnits);
            EOL00401.RvsalRunNumber.SetValue(RvsalRunNumber);
            EOL00401.RvsalTransNumber.SetValue(RvsalTransNumber);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00402");
            EOL00402.Confirm.SetValue("R");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        [When(@"In EOL00401 I perform Reversal Transaction as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00401PerformReversalTransaction(string TransNumber, string TotalUnits, string RvsalRunNumber, string RvsalTransNumber, string TotalMoney)
        {
            EOL00401.TransNumber.SetValue(TransNumber);
            if (EOL00401.TotalUnits.Exists() == true)
            {
                EOL00401.TotalUnits.SetValue(TotalUnits);
            }
            else if (EOL00401.TotalMoney.Exists() == true)
            {
                EOL00401.TotalMoney.SetValue(TotalMoney);
            }

            EOL00401.RvsalRunNumber.SetValue(RvsalRunNumber);
            EOL00401.RvsalTransNumber.SetValue(RvsalTransNumber);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00402");
            if (EOL00402.FromUnits.Exists() == true)
            {
                EOL00402.FromUnits.ValidateFieldValue(TotalUnits);
            }
            else if (EOL00402.TotalMoney.Exists() == true)
            {
                EOL00402.TotalMoney.ValidateFieldValue(TotalMoney);
            }

            EOL00402.Confirm.SetValue("R");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        [When(@"In EOL00901 I Add Award details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00901AddAwardDetails(string RegisterCode, string Selection, string AppropDate, string TransNumber, string TotalMoney, string TotalUnits, string SearchName, string RegisterType1, string Units1, string Money1)
        {
            EOL00103.Selection.SetValue(RegisterCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00124");
            EOL00124.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
            EOL00116.AppropDate.SetValue(AppropDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
            EOL00901.TransNumber.SetValue(TransNumber);
            EOL00901.TotalMoney.SetValue(TotalMoney);
            EOL00901.TotalUnits.SetValue(TotalUnits);
            EOL00901.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00905");
            EOL00905.RegisterType1.ValidateFieldValue(RegisterType1);
            EOL00905.Units1.ValidateFieldValue(Units1);
            EOL00905.Money1.ValidateFieldValue(Money1);
            EOL00905.TotalUnits.ValidateFieldValue(TotalUnits);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
        }

        [When(@"In EOL00901 I Add Grant details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00901AddGrantDetails(string AppropDate, string TransNumber, string TotalUnits, string GrantCountry, string SearchName)
        {
            EOL00116.AppropDate.SetValue(AppropDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
            EOL00901.TransNumber.SetValue(TransNumber);
            EOL00901.TotalUnits.SetValue(TotalUnits);
            EOL00901.GrantCountry.SetValue(GrantCountry);
            EOL00901.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00905");
        }

        /// <param name="table">data table</param>
        [When(@"In EOL00901 I continue with the following details to Add Awards:")]
        public void EOL00901ContinueWithTheFollowingDetailsToAddAwards(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
            EOL00115.Selection.SetValue(1, table.Rows[0]["RegisterType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(table.Rows[0]["RegisterCode"]))
            {
                EOL00101.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            }

            EOL00103.Selection.SetValue(1, table.Rows[0]["RegisterCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00114");
            EOL00114.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
            EOL00116.AppropDate.SetValue(1, table.Rows[0]["AppropDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
            EOL00901.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL00901.RetentionDate.SetValue(1, table.Rows[0]["RetentionDate"]);
            EOL00901.TaxRetentionDate.SetValue(1, table.Rows[0]["TaxRetentionDate"]);
            EOL00901.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            EOL00901.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00905");

            EOL00905.TotalUnits.ValidateFieldValue(1, table.Rows[0]["TotalUnits1"]);
            EOL00905.RegisterType1.ValidateFieldValue(1, table.Rows[0]["RegisterType1"]);
            EOL00905.Units1.ValidateFieldValue(1, table.Rows[0]["Units1"]);
            EOL00905.Money1.ValidateFieldValue(1, table.Rows[0]["Money1"]);
            EOL00905.RetentionDate.ValidateFieldValue(1, table.Rows[0]["RetentionDate1"]);
            EOL00905.TaxRetentionDate.ValidateFieldValue(1, table.Rows[0]["TaxRetentionDate1"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"In EOL00905 I should see Buyer details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL00905ShouldSeeBuyerDetails(string ClassCode, string RegisterCode, string RegisterDesc, string RegisterType1, string Units1, string Money1)
        {
            EOL00905.TotalUnits.ValidateFieldValue(Units1);
            EOL00905.ClassCode.ValidateFieldValue(ClassCode);
            EOL00905.RegisterCode.ValidateFieldValue(RegisterCode);
            EOL00905.RegisterDesc.ValidateFieldValue(RegisterDesc);
            EOL00905.RegisterType1.ValidateFieldValue(RegisterType1);
            EOL00905.Units1.ValidateFieldValue(Units1);
            EOL00905.Money1.ValidateFieldValue(Money1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
        }

        /// <param name="table">data table</param>
        [When(@"In EOL01301 I Perform Forfeiture Transaction as:")]
        public void EOL01301PerformForfeitureTransaction(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00119");
            EOL00119.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01301");
            EOL01301.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL01301.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            EOL01301.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01302");
            EOL01302.ForfUnits1.SetValue(1, table.Rows[0]["ForfUnits1"]);
            if (EOL01302.ForfUnits2.Exists() == true)
            {
                EOL01302.ForfUnits2.SetValue(1, table.Rows[0]["ForfUnits2"]);
            }
            if (EOL01302.ForfUnits3.Exists() == true)
            {
                EOL01302.ForfUnits3.SetValue(1, table.Rows[0]["ForfUnits3"]);
            }
            if (EOL01302.ForfUnits4.Exists() == true)
            {
                EOL01302.ForfUnits4.SetValue(1, table.Rows[0]["ForfUnits4"]);
            }
            if (EOL01302.ForfUnits5.Exists() == true)
            {
                EOL01302.ForfUnits5.SetValue(1, table.Rows[0]["ForfUnits5"]);
            }
            if (EOL01302.ForfUnits6.Exists() == true)
            {
                EOL01302.ForfUnits6.SetValue(1, table.Rows[0]["ForfUnits6"]);
            }
            if (EOL01302.ForfUnits7.Exists() == true)
            {
                EOL01302.ForfUnits7.SetValue(1, table.Rows[0]["ForfUnits7"]);
            }
            if (EOL01302.ForfUnits8.Exists() == true)
            {
                EOL01302.ForfUnits8.SetValue(1, table.Rows[0]["ForfUnits8"]);
            }
            if (EOL01302.ForfUnits9.Exists() == true)
            {
                EOL01302.ForfUnits9.SetValue(1, table.Rows[0]["ForfUnits9"]);
            }
            if (EOL01302.ForfUnits10.Exists() == true)
            {
                EOL01302.ForfUnits10.SetValue(1, table.Rows[0]["ForfUnits10"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (FormName != "EOL01303")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
                FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }
            EOL01303.AvailUnits.ValidateFieldValue(1, table.Rows[0]["AvailUnits1"]);
            EOL01303.AvailUnits.ValidateFieldValue(2, table.Rows[0]["AvailUnits2"]);
            EOL01303.AvailUnits.ValidateFieldValue(3, table.Rows[0]["AvailUnits3"]);
            EOL01303.AvailUnits.ValidateFieldValue(4, table.Rows[0]["AvailUnits4"]);
            EOL01303.ForfUnits.ValidateFieldValue(1, table.Rows[0]["ForfUnits11"]);
            EOL01303.ForfUnits.ValidateFieldValue(2, table.Rows[0]["ForfUnits22"]);
            EOL01303.ForfUnits.ValidateFieldValue(3, table.Rows[0]["ForfUnits33"]);
            EOL01303.ForfUnits.ValidateFieldValue(4, table.Rows[0]["ForfUnits44"]);
            EOL01303.AvailUnitsT.ValidateFieldValue(1, table.Rows[0]["AvailUnitsT"]);
            EOL01303.ForfUnitsT.ValidateFieldValue(1, table.Rows[0]["ForfUnitsT"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In EOL01401 I continue with the following details:")]
        public void EOL01401ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00119");
            EOL00119.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
            EOL00115.Selection.SetValue(1, table.Rows[0]["RegisterType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            EOL00103.Selection.SetValue(1, table.Rows[0]["RegisterCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01401");
            EOL01401.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL01401.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            EOL01401.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            EOL01401.SearchUsan.SetValue(1, table.Rows[0]["SearchUsan"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01402");
            EOL01402.SavingsAmount.ValidateFieldValue(1, table.Rows[0]["SavingsAmount"]);
            EOL01402.InterestAmount.ValidateFieldValue(1, table.Rows[0]["InterestAmount"]);
            EOL01402.ChequeAmount.ValidateFieldValue(1, table.Rows[0]["ChequeAmount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01401");
        }

        [When(@"In EOL01901 I Add Manual Payment Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL01901AddManualPaymentDetails(string TransNumber, string PaymentDate, string PaymentAmount, string SearchName)
        {
            EOL01901.TransNumber.SetValue(TransNumber);
            EOL01901.PaymentDate.SetValue(PaymentDate);
            EOL01901.PaymentAmount.SetValue(PaymentAmount);
            EOL01901.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01902");
            EOL01902.TotalPayment.ValidateFieldValue(PaymentAmount);
            EOL01902.PaymentAmount.ValidateFieldValue(PaymentAmount);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01901");
        }

        /// <param name="table">data table</param>
        [When(@"In EOL01901 I continue with the following details:")]
        public void EOL01901ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
            EOL00115.Selection.SetValue(1, table.Rows[0]["RegisterType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(table.Rows[0]["RegisterCode"]))
            {
                EOL00101.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            }

            EOL00103.Selection.SetValue(1, table.Rows[0]["RegisterCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00120");
            EOL00120.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01901");

            EOL01901.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL01901.PaymentFrequency.SetValue(1, table.Rows[0]["PaymentFrequency"]);
            EOL01901.AccumPeriod.SetValue(1, table.Rows[0]["AccumPeriod"]);
            EOL01901.PaymentNumber.SetValue(1, table.Rows[0]["PaymentNumber"]);
            EOL01901.PaymentStatus.SetValue(1, table.Rows[0]["PaymentStatus"]);
            EOL01901.Eol01901ReceiptCurrency.SetValue(1, table.Rows[0]["Eol01901ReceiptCurrency"]);
            EOL01901.PaymentDate.SetValue(1, table.Rows[0]["PaymentDate"]);
            EOL01901.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            EOL01901.EmployerPymtAmt.SetValue(1, table.Rows[0]["EmployerPymtAmt"]);
            EOL01901.Eol01901ExchangeRate.SetValue(1, table.Rows[0]["Eol01901ExchangeRate"]);
            EOL01901.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL01901 I go to manual Payments Menu ""(.*)"" ""(.*)""")]
        public void EOL01901GoToManualPaymentsMenu(string RegisterCode, string Selection)
        {
            EOL00103.Selection.SetValue(RegisterCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00122");
            EOL00122.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "EOL00401")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL01901");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In EOL02201 I Perform Leaver Processing Transaction as:")]
        public void EOL02201PerformLeaverProcessingTransaction(Table table)
        {
            EOL00119.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02201");
            EOL02201.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL02201.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            EOL02201.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02202");
            EOL02202.Register.ValidateFieldValue(1, table.Rows[0]["Register1"]);
            EOL02202.Register.ValidateFieldValue(2, table.Rows[0]["Register2"]);
            EOL02202.Register.ValidateFieldValue(3, table.Rows[0]["Register3"]);
            EOL02202.Register.ValidateFieldValue(4, table.Rows[0]["Register4"]);
            EOL02202.Register.ValidateFieldValue(5, table.Rows[0]["Register5"]);
            EOL02202.Register.ValidateFieldValue(6, table.Rows[0]["Register6"]);
            EOL02202.Register.ValidateFieldValue(7, table.Rows[0]["Register7"]);
            EOL02202.Register.ValidateFieldValue(8, table.Rows[0]["Register8"]);
            EOL02202.Register.ValidateFieldValue(9, table.Rows[0]["Register9"]);

            EOL02202.CertID.ValidateFieldValue(1, table.Rows[0]["CertID1"]);
            EOL02202.CertID.ValidateFieldValue(2, table.Rows[0]["CertID2"]);
            EOL02202.CertID.ValidateFieldValue(3, table.Rows[0]["CertID3"]);
            EOL02202.CertID.ValidateFieldValue(4, table.Rows[0]["CertID4"]);
            EOL02202.CertID.ValidateFieldValue(5, table.Rows[0]["CertID5"]);
            EOL02202.CertID.ValidateFieldValue(6, table.Rows[0]["CertID6"]);
            EOL02202.CertID.ValidateFieldValue(7, table.Rows[0]["CertID7"]);
            EOL02202.CertID.ValidateFieldValue(8, table.Rows[0]["CertID8"]);
            EOL02202.CertID.ValidateFieldValue(9, table.Rows[0]["CertID9"]);

            EOL02202.CurrBal.ValidateFieldValue(1, table.Rows[0]["CurrBal1"]);
            EOL02202.CurrBal.ValidateFieldValue(2, table.Rows[0]["CurrBal2"]);
            EOL02202.CurrBal.ValidateFieldValue(3, table.Rows[0]["CurrBal3"]);
            EOL02202.CurrBal.ValidateFieldValue(4, table.Rows[0]["CurrBal4"]);
            EOL02202.CurrBal.ValidateFieldValue(5, table.Rows[0]["CurrBal5"]);
            EOL02202.CurrBal.ValidateFieldValue(6, table.Rows[0]["CurrBal6"]);
            EOL02202.CurrBal.ValidateFieldValue(7, table.Rows[0]["CurrBal7"]);
            EOL02202.CurrBal.ValidateFieldValue(8, table.Rows[0]["CurrBal8"]);
            EOL02202.CurrBal.ValidateFieldValue(9, table.Rows[0]["CurrBal9"]);

            EOL02202.RelImm1.SetValue(1, table.Rows[0]["RelImm1"]);
            EOL02202.RelImm2.SetValue(1, table.Rows[0]["RelImm2"]);
            EOL02202.RelImm3.SetValue(1, table.Rows[0]["RelImm3"]);
            EOL02202.RelImm4.SetValue(1, table.Rows[0]["RelImm4"]);
            EOL02202.RelImm5.SetValue(1, table.Rows[0]["RelImm5"]);
            EOL02202.RelImm6.SetValue(1, table.Rows[0]["RelImm6"]);
            EOL02202.RelImm7.SetValue(1, table.Rows[0]["RelImm7"]);
            EOL02202.RelImm8.SetValue(1, table.Rows[0]["RelImm8"]);
            EOL02202.RelImm9.SetValue(1, table.Rows[0]["RelImm9"]);

            EOL02202.MaintRest1.SetValue(1, table.Rows[0]["MaintRest1"]);
            EOL02202.MaintRest2.SetValue(1, table.Rows[0]["MaintRest2"]);
            EOL02202.MaintRest3.SetValue(1, table.Rows[0]["MaintRest3"]);
            EOL02202.MaintRest4.SetValue(1, table.Rows[0]["MaintRest4"]);
            EOL02202.MaintRest5.SetValue(1, table.Rows[0]["MaintRest5"]);
            EOL02202.MaintRest6.SetValue(1, table.Rows[0]["MaintRest6"]);
            EOL02202.MaintRest7.SetValue(1, table.Rows[0]["MaintRest7"]);
            EOL02202.MaintRest8.SetValue(1, table.Rows[0]["MaintRest8"]);
            EOL02202.MaintRest9.SetValue(1, table.Rows[0]["MaintRest9"]);

            EOL02202.ForfNow1.SetValue(1, table.Rows[0]["ForfNow1"]);
            EOL02202.ForfNow2.SetValue(1, table.Rows[0]["ForfNow2"]);
            EOL02202.ForfNow3.SetValue(1, table.Rows[0]["ForfNow3"]);
            EOL02202.ForfNow4.SetValue(1, table.Rows[0]["ForfNow4"]);
            EOL02202.ForfNow5.SetValue(1, table.Rows[0]["ForfNow5"]);
            EOL02202.ForfNow6.SetValue(1, table.Rows[0]["ForfNow6"]);
            EOL02202.ForfNow7.SetValue(1, table.Rows[0]["ForfNow7"]);
            EOL02202.ForfNow8.SetValue(1, table.Rows[0]["ForfNow8"]);
            EOL02202.ForfNow9.SetValue(1, table.Rows[0]["ForfNow9"]);

            EOL02202.AvailUnits1.SetValue(1, table.Rows[0]["AvailUnits1"]);
            EOL02202.AvailUnits2.SetValue(1, table.Rows[0]["AvailUnits2"]);
            EOL02202.AvailUnits3.SetValue(1, table.Rows[0]["AvailUnits3"]);
            EOL02202.AvailUnits4.SetValue(1, table.Rows[0]["AvailUnits4"]);
            EOL02202.AvailUnits5.SetValue(1, table.Rows[0]["AvailUnits5"]);
            EOL02202.AvailUnits6.SetValue(1, table.Rows[0]["AvailUnits6"]);
            EOL02202.AvailUnits7.SetValue(1, table.Rows[0]["AvailUnits7"]);
            EOL02202.AvailUnits8.SetValue(1, table.Rows[0]["AvailUnits8"]);
            EOL02202.AvailUnits9.SetValue(1, table.Rows[0]["AvailUnits9"]);

            EOL02202.AvailDate1.SetValue(1, table.Rows[0]["AvailDate1"]);
            EOL02202.AvailDate2.SetValue(1, table.Rows[0]["AvailDate2"]);
            EOL02202.AvailDate3.SetValue(1, table.Rows[0]["AvailDate3"]);
            EOL02202.AvailDate4.SetValue(1, table.Rows[0]["AvailDate4"]);
            EOL02202.AvailDate5.SetValue(1, table.Rows[0]["AvailDate5"]);
            EOL02202.AvailDate6.SetValue(1, table.Rows[0]["AvailDate6"]);
            EOL02202.AvailDate7.SetValue(1, table.Rows[0]["AvailDate7"]);
            EOL02202.AvailDate8.SetValue(1, table.Rows[0]["AvailDate8"]);
            EOL02202.AvailDate9.SetValue(1, table.Rows[0]["AvailDate9"]);

            EOL02202.RestEndDate.ValidateFieldValue(1, table.Rows[0]["RestEndDate1"]);
            EOL02202.RestEndDate.ValidateFieldValue(2, table.Rows[0]["RestEndDate2"]);
            EOL02202.RestEndDate.ValidateFieldValue(3, table.Rows[0]["RestEndDate3"]);
            EOL02202.RestEndDate.ValidateFieldValue(4, table.Rows[0]["RestEndDate4"]);
            EOL02202.RestEndDate.ValidateFieldValue(5, table.Rows[0]["RestEndDate5"]);
            EOL02202.RestEndDate.ValidateFieldValue(6, table.Rows[0]["RestEndDate6"]);
            EOL02202.RestEndDate.ValidateFieldValue(7, table.Rows[0]["RestEndDate7"]);
            EOL02202.RestEndDate.ValidateFieldValue(8, table.Rows[0]["RestEndDate8"]);
            EOL02202.RestEndDate.ValidateFieldValue(9, table.Rows[0]["RestEndDate9"]);

            if (EOL02202.RelImm10.Exists() == true)
            {
                EOL02202.Register.ValidateFieldValue(10, table.Rows[0]["Register10"]);
                EOL02202.CertID.ValidateFieldValue(10, table.Rows[0]["CertID10"]);
                EOL02202.CurrBal.ValidateFieldValue(10, table.Rows[0]["CurrBal10"]);
                EOL02202.RelImm10.SetValue(1, table.Rows[0]["RelImm10"]);
                EOL02202.MaintRest10.SetValue(1, table.Rows[0]["MaintRest10"]);
                EOL02202.ForfNow10.SetValue(1, table.Rows[0]["ForfNow10"]);
                EOL02202.AvailUnits10.SetValue(1, table.Rows[0]["AvailUnits10"]);
                EOL02202.AvailDate10.SetValue(1, table.Rows[0]["AvailDate10"]);
                EOL02202.RestEndDate.ValidateFieldValue(10, table.Rows[0]["RestEndDate10"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "EOL02203")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02204");
            }
        }

        /// <param name="table">data table</param>
        [When(@"In EOL02203 I Perform Leaver Processing Transaction as:")]
        public void EOL02203PerformLeaverProcessingTransaction(Table table)
        {
            EOL02203.Register.ValidateFieldValue(1, table.Rows[0]["Register1"]);
            EOL02203.Register.ValidateFieldValue(2, table.Rows[0]["Register2"]);
            EOL02203.Register.ValidateFieldValue(3, table.Rows[0]["Register3"]);
            EOL02203.Register.ValidateFieldValue(4, table.Rows[0]["Register4"]);
            EOL02203.Register.ValidateFieldValue(5, table.Rows[0]["Register5"]);
            EOL02203.Register.ValidateFieldValue(6, table.Rows[0]["Register6"]);
            EOL02203.Register.ValidateFieldValue(7, table.Rows[0]["Register7"]);
            EOL02203.Register.ValidateFieldValue(8, table.Rows[0]["Register8"]);
            EOL02203.Register.ValidateFieldValue(9, table.Rows[0]["Register9"]);

            EOL02203.CertID.ValidateFieldValue(1, table.Rows[0]["CertID1"]);
            EOL02203.CertID.ValidateFieldValue(2, table.Rows[0]["CertID2"]);
            EOL02203.CertID.ValidateFieldValue(3, table.Rows[0]["CertID3"]);
            EOL02203.CertID.ValidateFieldValue(4, table.Rows[0]["CertID4"]);
            EOL02203.CertID.ValidateFieldValue(5, table.Rows[0]["CertID5"]);
            EOL02203.CertID.ValidateFieldValue(6, table.Rows[0]["CertID6"]);
            EOL02203.CertID.ValidateFieldValue(7, table.Rows[0]["CertID7"]);
            EOL02203.CertID.ValidateFieldValue(8, table.Rows[0]["CertID8"]);
            EOL02203.CertID.ValidateFieldValue(9, table.Rows[0]["CertID9"]);

            EOL02203.CurrBal.ValidateFieldValue(1, table.Rows[0]["CurrBal1"]);
            EOL02203.CurrBal.ValidateFieldValue(2, table.Rows[0]["CurrBal2"]);
            EOL02203.CurrBal.ValidateFieldValue(3, table.Rows[0]["CurrBal3"]);
            EOL02203.CurrBal.ValidateFieldValue(4, table.Rows[0]["CurrBal4"]);
            EOL02203.CurrBal.ValidateFieldValue(5, table.Rows[0]["CurrBal5"]);
            EOL02203.CurrBal.ValidateFieldValue(6, table.Rows[0]["CurrBal6"]);
            EOL02203.CurrBal.ValidateFieldValue(7, table.Rows[0]["CurrBal7"]);
            EOL02203.CurrBal.ValidateFieldValue(8, table.Rows[0]["CurrBal8"]);
            EOL02203.CurrBal.ValidateFieldValue(9, table.Rows[0]["CurrBal9"]);

            EOL02203.RelImm1.SetValue(1, table.Rows[0]["RelImm1"]);
            EOL02203.RelImm2.SetValue(1, table.Rows[0]["RelImm2"]);
            EOL02203.RelImm3.SetValue(1, table.Rows[0]["RelImm3"]);
            EOL02203.RelImm4.SetValue(1, table.Rows[0]["RelImm4"]);
            EOL02203.RelImm5.SetValue(1, table.Rows[0]["RelImm5"]);
            EOL02203.RelImm6.SetValue(1, table.Rows[0]["RelImm6"]);
            EOL02203.RelImm7.SetValue(1, table.Rows[0]["RelImm7"]);
            EOL02203.RelImm8.SetValue(1, table.Rows[0]["RelImm8"]);
            EOL02203.RelImm9.SetValue(1, table.Rows[0]["RelImm9"]);

            EOL02203.MaintRest1.SetValue(1, table.Rows[0]["MaintRest1"]);
            EOL02203.MaintRest2.SetValue(1, table.Rows[0]["MaintRest2"]);
            EOL02203.MaintRest3.SetValue(1, table.Rows[0]["MaintRest3"]);
            EOL02203.MaintRest4.SetValue(1, table.Rows[0]["MaintRest4"]);
            EOL02203.MaintRest5.SetValue(1, table.Rows[0]["MaintRest5"]);
            EOL02203.MaintRest6.SetValue(1, table.Rows[0]["MaintRest6"]);
            EOL02203.MaintRest7.SetValue(1, table.Rows[0]["MaintRest7"]);
            EOL02203.MaintRest8.SetValue(1, table.Rows[0]["MaintRest8"]);
            EOL02203.MaintRest9.SetValue(1, table.Rows[0]["MaintRest9"]);

            EOL02203.ForfNow1.SetValue(1, table.Rows[0]["ForfNow1"]);
            EOL02203.ForfNow2.SetValue(1, table.Rows[0]["ForfNow2"]);
            EOL02203.ForfNow3.SetValue(1, table.Rows[0]["ForfNow3"]);
            EOL02203.ForfNow4.SetValue(1, table.Rows[0]["ForfNow4"]);
            EOL02203.ForfNow5.SetValue(1, table.Rows[0]["ForfNow5"]);
            EOL02203.ForfNow6.SetValue(1, table.Rows[0]["ForfNow6"]);
            EOL02203.ForfNow7.SetValue(1, table.Rows[0]["ForfNow7"]);
            EOL02203.ForfNow8.SetValue(1, table.Rows[0]["ForfNow8"]);
            EOL02203.ForfNow9.SetValue(1, table.Rows[0]["ForfNow9"]);

            EOL02203.AvailUnits1.SetValue(1, table.Rows[0]["AvailUnits1"]);
            EOL02203.AvailUnits2.SetValue(1, table.Rows[0]["AvailUnits2"]);
            EOL02203.AvailUnits3.SetValue(1, table.Rows[0]["AvailUnits3"]);
            EOL02203.AvailUnits4.SetValue(1, table.Rows[0]["AvailUnits4"]);
            EOL02203.AvailUnits5.SetValue(1, table.Rows[0]["AvailUnits5"]);
            EOL02203.AvailUnits6.SetValue(1, table.Rows[0]["AvailUnits6"]);
            EOL02203.AvailUnits7.SetValue(1, table.Rows[0]["AvailUnits7"]);
            EOL02203.AvailUnits8.SetValue(1, table.Rows[0]["AvailUnits8"]);
            EOL02203.AvailUnits9.SetValue(1, table.Rows[0]["AvailUnits9"]);

            EOL02203.AvailDate1.SetValue(1, table.Rows[0]["AvailDate1"]);
            EOL02203.AvailDate2.SetValue(1, table.Rows[0]["AvailDate2"]);
            EOL02203.AvailDate3.SetValue(1, table.Rows[0]["AvailDate3"]);
            EOL02203.AvailDate4.SetValue(1, table.Rows[0]["AvailDate4"]);
            EOL02203.AvailDate5.SetValue(1, table.Rows[0]["AvailDate5"]);
            EOL02203.AvailDate6.SetValue(1, table.Rows[0]["AvailDate6"]);
            EOL02203.AvailDate7.SetValue(1, table.Rows[0]["AvailDate7"]);
            EOL02203.AvailDate8.SetValue(1, table.Rows[0]["AvailDate8"]);
            EOL02203.AvailDate9.SetValue(1, table.Rows[0]["AvailDate9"]);

            EOL02203.RestEndDate.ValidateFieldValue(1, table.Rows[0]["RestEndDate1"]);
            EOL02203.RestEndDate.ValidateFieldValue(2, table.Rows[0]["RestEndDate2"]);
            EOL02203.RestEndDate.ValidateFieldValue(3, table.Rows[0]["RestEndDate3"]);
            EOL02203.RestEndDate.ValidateFieldValue(4, table.Rows[0]["RestEndDate4"]);
            EOL02203.RestEndDate.ValidateFieldValue(5, table.Rows[0]["RestEndDate5"]);
            EOL02203.RestEndDate.ValidateFieldValue(6, table.Rows[0]["RestEndDate6"]);
            EOL02203.RestEndDate.ValidateFieldValue(7, table.Rows[0]["RestEndDate7"]);
            EOL02203.RestEndDate.ValidateFieldValue(8, table.Rows[0]["RestEndDate8"]);
            EOL02203.RestEndDate.ValidateFieldValue(9, table.Rows[0]["RestEndDate9"]);

            if (EOL02203.RelImm10.Exists() == true)
            {
                EOL02203.Register.ValidateFieldValue(10, table.Rows[0]["Register10"]);
                EOL02203.CertID.ValidateFieldValue(10, table.Rows[0]["CertID10"]);
                EOL02203.CurrBal.ValidateFieldValue(10, table.Rows[0]["CurrBal10"]);
                EOL02203.RelImm10.SetValue(1, table.Rows[0]["RelImm10"]);
                EOL02203.MaintRest10.SetValue(1, table.Rows[0]["MaintRest10"]);
                EOL02203.ForfNow10.SetValue(1, table.Rows[0]["ForfNow10"]);
                EOL02203.AvailUnits10.SetValue(1, table.Rows[0]["AvailUnits10"]);
                EOL02203.AvailDate10.SetValue(1, table.Rows[0]["AvailDate10"]);
                EOL02203.RestEndDate.ValidateFieldValue(10, table.Rows[0]["RestEndDate10"]);
            }

            if (EOL02203.RelImm11.Exists() == true)
            {
                EOL02203.Register.ValidateFieldValue(11, table.Rows[0]["Register11"]);
                EOL02203.CertID.ValidateFieldValue(11, table.Rows[0]["CertID11"]);
                EOL02203.CurrBal.ValidateFieldValue(11, table.Rows[0]["CurrBal11"]);
                EOL02203.RelImm11.SetValue(1, table.Rows[0]["RelImm11"]);
                EOL02203.MaintRest11.SetValue(1, table.Rows[0]["MaintRest11"]);
                EOL02203.ForfNow11.SetValue(1, table.Rows[0]["ForfNow11"]);
                EOL02203.AvailUnits11.SetValue(1, table.Rows[0]["AvailUnits11"]);
                EOL02203.AvailDate11.SetValue(1, table.Rows[0]["AvailDate11"]);
                EOL02203.RestEndDate.ValidateFieldValue(11, table.Rows[0]["RestEndDate11"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02204");
        }

        /// <param name="table">data table</param>
        [When(@"In EOL02204 I Perform Leaver Processing Transaction as:")]
        public void EOL02204PerformLeaverProcessingTransaction(Table table)
        {
            EOL02204.Register.ValidateFieldValue(1, table.Rows[0]["Register1"]);
            EOL02204.Register.ValidateFieldValue(2, table.Rows[0]["Register2"]);
            EOL02204.Register.ValidateFieldValue(3, table.Rows[0]["Register3"]);
            EOL02204.Register.ValidateFieldValue(4, table.Rows[0]["Register4"]);
            EOL02204.Register.ValidateFieldValue(5, table.Rows[0]["Register5"]);
            EOL02204.Register.ValidateFieldValue(6, table.Rows[0]["Register6"]);
            EOL02204.Register.ValidateFieldValue(7, table.Rows[0]["Register7"]);
            EOL02204.Register.ValidateFieldValue(8, table.Rows[0]["Register8"]);
            EOL02204.Register.ValidateFieldValue(9, table.Rows[0]["Register9"]);
            EOL02204.CertID.ValidateFieldValue(1, table.Rows[0]["CertID1"]);
            EOL02204.CertID.ValidateFieldValue(2, table.Rows[0]["CertID2"]);
            EOL02204.CertID.ValidateFieldValue(3, table.Rows[0]["CertID3"]);
            EOL02204.CertID.ValidateFieldValue(4, table.Rows[0]["CertID4"]);
            EOL02204.CertID.ValidateFieldValue(5, table.Rows[0]["CertID5"]);
            EOL02204.CertID.ValidateFieldValue(6, table.Rows[0]["CertID6"]);
            EOL02204.CertID.ValidateFieldValue(7, table.Rows[0]["CertID7"]);
            EOL02204.CertID.ValidateFieldValue(8, table.Rows[0]["CertID8"]);
            EOL02204.CertID.ValidateFieldValue(9, table.Rows[0]["CertID9"]);

            EOL02204.RelImm.ValidateFieldValue(1, table.Rows[0]["RelImm1"]);
            EOL02204.RelImm.ValidateFieldValue(2, table.Rows[0]["RelImm2"]);
            EOL02204.RelImm.ValidateFieldValue(3, table.Rows[0]["RelImm3"]);
            EOL02204.RelImm.ValidateFieldValue(4, table.Rows[0]["RelImm4"]);
            EOL02204.RelImm.ValidateFieldValue(5, table.Rows[0]["RelImm5"]);
            EOL02204.RelImm.ValidateFieldValue(6, table.Rows[0]["RelImm6"]);
            EOL02204.RelImm.ValidateFieldValue(7, table.Rows[0]["RelImm7"]);
            EOL02204.RelImm.ValidateFieldValue(8, table.Rows[0]["RelImm8"]);
            EOL02204.RelImm.ValidateFieldValue(9, table.Rows[0]["RelImm9"]);

            EOL02204.MaintRest.ValidateFieldValue(1, table.Rows[0]["MaintRest1"]);
            EOL02204.MaintRest.ValidateFieldValue(2, table.Rows[0]["MaintRest2"]);
            EOL02204.MaintRest.ValidateFieldValue(3, table.Rows[0]["MaintRest3"]);
            EOL02204.MaintRest.ValidateFieldValue(4, table.Rows[0]["MaintRest4"]);
            EOL02204.MaintRest.ValidateFieldValue(5, table.Rows[0]["MaintRest5"]);
            EOL02204.MaintRest.ValidateFieldValue(6, table.Rows[0]["MaintRest6"]);
            EOL02204.MaintRest.ValidateFieldValue(7, table.Rows[0]["MaintRest7"]);
            EOL02204.MaintRest.ValidateFieldValue(8, table.Rows[0]["MaintRest8"]);
            EOL02204.MaintRest.ValidateFieldValue(9, table.Rows[0]["MaintRest9"]);

            EOL02204.ForfNow.ValidateFieldValue(1, table.Rows[0]["ForfNow1"]);
            EOL02204.ForfNow.ValidateFieldValue(2, table.Rows[0]["ForfNow2"]);
            EOL02204.ForfNow.ValidateFieldValue(3, table.Rows[0]["ForfNow3"]);
            EOL02204.ForfNow.ValidateFieldValue(4, table.Rows[0]["ForfNow4"]);
            EOL02204.ForfNow.ValidateFieldValue(5, table.Rows[0]["ForfNow5"]);
            EOL02204.ForfNow.ValidateFieldValue(6, table.Rows[0]["ForfNow6"]);
            EOL02204.ForfNow.ValidateFieldValue(7, table.Rows[0]["ForfNow7"]);
            EOL02204.ForfNow.ValidateFieldValue(8, table.Rows[0]["ForfNow8"]);
            EOL02204.ForfNow.ValidateFieldValue(9, table.Rows[0]["ForfNow9"]);

            EOL02204.AvailUnits.ValidateFieldValue(1, table.Rows[0]["AvailUnits1"]);
            EOL02204.AvailUnits.ValidateFieldValue(2, table.Rows[0]["AvailUnits2"]);
            EOL02204.AvailUnits.ValidateFieldValue(3, table.Rows[0]["AvailUnits3"]);
            EOL02204.AvailUnits.ValidateFieldValue(4, table.Rows[0]["AvailUnits4"]);
            EOL02204.AvailUnits.ValidateFieldValue(5, table.Rows[0]["AvailUnits5"]);
            EOL02204.AvailUnits.ValidateFieldValue(6, table.Rows[0]["AvailUnits6"]);
            EOL02204.AvailUnits.ValidateFieldValue(7, table.Rows[0]["AvailUnits7"]);
            EOL02204.AvailUnits.ValidateFieldValue(8, table.Rows[0]["AvailUnits8"]);
            EOL02204.AvailUnits.ValidateFieldValue(9, table.Rows[0]["AvailUnits9"]);

            EOL02204.AvailDate.ValidateFieldValue(1, table.Rows[0]["AvailDate1"]);
            EOL02204.AvailDate.ValidateFieldValue(2, table.Rows[0]["AvailDate2"]);
            EOL02204.AvailDate.ValidateFieldValue(3, table.Rows[0]["AvailDate3"]);
            EOL02204.AvailDate.ValidateFieldValue(4, table.Rows[0]["AvailDate4"]);
            EOL02204.AvailDate.ValidateFieldValue(5, table.Rows[0]["AvailDate5"]);
            EOL02204.AvailDate.ValidateFieldValue(6, table.Rows[0]["AvailDate6"]);
            EOL02204.AvailDate.ValidateFieldValue(7, table.Rows[0]["AvailDate7"]);
            EOL02204.AvailDate.ValidateFieldValue(8, table.Rows[0]["AvailDate8"]);
            EOL02204.AvailDate.ValidateFieldValue(9, table.Rows[0]["AvailDate9"]);

            EOL02204.RestEndDate.ValidateFieldValue(1, table.Rows[0]["RestEndDate1"]);
            EOL02204.RestEndDate.ValidateFieldValue(2, table.Rows[0]["RestEndDate2"]);
            EOL02204.RestEndDate.ValidateFieldValue(3, table.Rows[0]["RestEndDate3"]);
            EOL02204.RestEndDate.ValidateFieldValue(4, table.Rows[0]["RestEndDate4"]);
            EOL02204.RestEndDate.ValidateFieldValue(5, table.Rows[0]["RestEndDate5"]);
            EOL02204.RestEndDate.ValidateFieldValue(6, table.Rows[0]["RestEndDate6"]);
            EOL02204.RestEndDate.ValidateFieldValue(7, table.Rows[0]["RestEndDate7"]);
            EOL02204.RestEndDate.ValidateFieldValue(8, table.Rows[0]["RestEndDate8"]);
            EOL02204.RestEndDate.ValidateFieldValue(9, table.Rows[0]["RestEndDate9"]);

            EOL02204.Register.ValidateFieldValue(10, table.Rows[0]["Register10"]);
            EOL02204.CertID.ValidateFieldValue(10, table.Rows[0]["CertID10"]);
            EOL02204.RelImm.ValidateFieldValue(10, table.Rows[0]["RelImm10"]);
            EOL02204.MaintRest.ValidateFieldValue(10, table.Rows[0]["MaintRest10"]);
            EOL02204.ForfNow.ValidateFieldValue(10, table.Rows[0]["ForfNow10"]);
            EOL02204.AvailUnits.ValidateFieldValue(10, table.Rows[0]["AvailUnits10"]);
            //EOL02204.AvailDate.ValidateFieldValue(10, table.Rows[0]["AvailDate10"]);
            EOL02204.RestEndDate.ValidateFieldValue(10, table.Rows[0]["RestEndDate10"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName != "EOL02204")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02201");
            }
        }

        [When(@"In EOL02702 I perform Leaver Processing as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL02702PerformLeaverProcessing(string Selection, string TransNumber, string SearchName, string Confirm, string IgnoreBlackoutInd, string NOChangeUvst1, string CancelImmUvst1, string VestNbrUvst1, string VestDateUvst1, string NOChangeVst1, string CancelImmVst1, string ExpiryDate1, string NOChangeUvst2, string CancelImmUvst2, string VestNbrUvst2, string VestDateUvst2, string NOChangeVst2, string CancelImmVst2, string ExpiryDate2)
        {
            EOL00131.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02701");
            EOL02701.TransNumber.SetValue(TransNumber);
            EOL02701.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL027BA");
            EOL027BA.Confirm.SetValue(Confirm);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02702");
            EOL02702.IgnoreBlackoutInd.SetValue(IgnoreBlackoutInd);
            EOL02702.NOChangeUvst1.SetValue(NOChangeUvst1);
            EOL02702.CancelImmUvst1.SetValue(CancelImmUvst1);
            EOL02702.VestNbrUvst1.SetValue(VestNbrUvst1);
            EOL02702.VestDateUvst1.SetValue(VestDateUvst1);
            EOL02702.NOChangeVst1.SetValue(NOChangeVst1);
            EOL02702.CancelImmVst1.SetValue(CancelImmVst1);
            EOL02702.ExpiryDate1.SetValue(ExpiryDate1);

            if (EOL02702.NOChangeUvst2.Exists() == true)
            {
                EOL02702.NOChangeUvst2.SetValue(NOChangeUvst2);
                EOL02702.CancelImmUvst2.SetValue(CancelImmUvst2);
                EOL02702.VestNbrUvst2.SetValue(VestNbrUvst2);
                EOL02702.VestDateUvst2.SetValue(VestDateUvst2);
                EOL02702.NOChangeVst2.SetValue(NOChangeVst2);
                EOL02702.CancelImmVst2.SetValue(CancelImmVst2);
                EOL02702.ExpiryDate2.SetValue(ExpiryDate2);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02704");

            EOL02704.IgnoreBlackoutInd.ValidateFieldValue(IgnoreBlackoutInd);
            EOL02704.NOChangeUvst.ValidateFieldValue(1, NOChangeUvst1);
            EOL02704.CancelImmUvst.ValidateFieldValue(1, CancelImmUvst1);
            EOL02704.VestNbrUvst.ValidateFieldValue(1, VestNbrUvst1);
            EOL02704.VestDateUvst.ValidateFieldValue(1, VestDateUvst1);
            EOL02704.NOChangeVst.ValidateFieldValue(1, NOChangeVst1);
            EOL02704.CancelImmVst.ValidateFieldValue(1, CancelImmVst1);
            EOL02704.ExpiryDate.ValidateFieldValue(1, ExpiryDate1);
            EOL02704.NOChangeUvst.ValidateFieldValue(2, NOChangeUvst2);
            EOL02704.CancelImmUvst.ValidateFieldValue(2, CancelImmUvst2);
            EOL02704.VestNbrUvst.ValidateFieldValue(2, VestNbrUvst2);
            EOL02704.VestDateUvst.ValidateFieldValue(2, VestDateUvst2);
            EOL02704.NOChangeVst.ValidateFieldValue(2, NOChangeVst2);
            EOL02704.CancelImmVst.ValidateFieldValue(2, CancelImmVst2);
            EOL02704.ExpiryDate.ValidateFieldValue(2, ExpiryDate2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02701");
        }

        [When(@"In EOL02801 I Perform Options Lapse Transaction as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL02801PerformOptionsLapseTransaction(string TransNumber, string TransDate, string LapseCancelAll, string TotalUnits, string SearchName, string Unvested1, string Vested1, string Unvested2, string Vested2, string TotalUnvested, string TotalVested, string GrandTotal)
        {
            EOL02801.TransNumber.SetValue(TransNumber);
            EOL02801.TransDate.SetValue(TransDate);
            EOL02801.LapseCancelAll.SetValue(LapseCancelAll);

            if (LapseCancelAll == "N")
            {
                EOL02801.LapseCancelAll.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                EOL02801.TotalUnits.SetValue(TotalUnits);
            }

            EOL02801.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            if (LapseCancelAll == "N")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02802");
                EOL02802.Unvested1.SetValue(Unvested1);
                EOL02802.Vested1.SetValue(Vested1);
                EOL02802.Unvested2.SetValue(Unvested2);
                EOL02802.Vested2.SetValue(Vested2);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02803");
            EOL02803.TotalUnvested.ValidateFieldValue(TotalUnvested);
            EOL02803.TotalVested.ValidateFieldValue(TotalVested);
            EOL02803.GrandTotal.ValidateFieldValue(GrandTotal);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02801");
        }

        [When(@"In EOL02901 I Add Event Tax Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL02901AddEventTaxDetails(string TransNumber, string SearchName, string UpdtAllCert, string WitholdingTaxRate, string WitholdingTaxCode, string MarketValueType, string ComplexHolderCode, string WthldgTaxRate1, string WthldgTaxCode1, string MktValueType1, string CmplxHldrCode1, string WthldgTaxRate2, string WthldgTaxCode2, string MktValueType2, string CmplxHldrCode2)
        {
            EOL02901.TransNumber.SetValue(TransNumber);
            EOL02901.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02905");
            EOL02905.UpdtAllCert.SetValue(UpdtAllCert);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if (UpdtAllCert == "Y")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02903");
                EOL02903.WitholdingTaxRate.SetValue(WitholdingTaxRate);
                EOL02903.WitholdingTaxCode.SetValue(WitholdingTaxCode);
                EOL02903.MarketValueType.SetValue(MarketValueType);
                EOL02903.ComplexHolderCode.SetValue(ComplexHolderCode);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            else
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02902");
                EOL02902.WthldgTaxRate1.SetValue(WthldgTaxRate1);
                EOL02902.WthldgTaxCode1.SetValue(WthldgTaxCode1);
                EOL02902.MktValueType1.SetValue(MktValueType1);
                EOL02902.CmplxHldrCode1.SetValue(CmplxHldrCode1);
                EOL02902.WthldgTaxRate2.SetValue(WthldgTaxRate2);
                EOL02902.WthldgTaxCode2.SetValue(WthldgTaxCode2);
                EOL02902.MktValueType2.SetValue(MktValueType2);
                EOL02902.CmplxHldrCode2.SetValue(CmplxHldrCode2);

                string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                while (FormName != "EOL02904")
                {
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
                    FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
                }
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02904");
            string FormName1 = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (FormName1 != "EOL02901")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.HardWait(4);
                FormName1 = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02901");
        }

        [When(@"In EOL02901 I Add Event Tax Details for I type as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL02901AddEventTaxDetailsForIType(string TransNumber, string SearchName, string UpdtAllCert, string WitholdingTaxRate, string RegisterCode1, string CertID1, string WthldgTaxRate1, string RegisterCode2, string CertID2, string WthldgTaxRate2)
        {
            EOL02901.TransNumber.SetValue(TransNumber);
            EOL02901.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02905");

            EOL02905.UpdtAllCert.SetValue(UpdtAllCert);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if (UpdtAllCert == "Y")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02903");
                EOL02903.WitholdingTaxRate.SetValue(WitholdingTaxRate);
            }
            else
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL02902");
                EOL02902.WthldgTaxRate1.SetValue(WthldgTaxRate1);
                EOL02902.WthldgTaxRate2.SetValue(WthldgTaxRate2);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02904");

            EOL02904.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL02904.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL02904.CertID.ValidateFieldValue(1, CertID1);
            EOL02904.CertID.ValidateFieldValue(2, CertID2);
            EOL02904.WitholdingTaxRate1.ValidateFieldValue(WthldgTaxRate1);
            EOL02904.WitholdingTaxRate1.ValidateFieldValue(WthldgTaxRate2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02901");
        }

        [When(@"In EOL02901 I Delete Event Tax Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL02901DeleteEventTaxDetails(string TransNumber, string SearchName, string RegisterCode1, string CertID1, string WthldgTaxRate1, string WthldgTaxCode1, string MktValueType1, string CmplxHldrCode1, string RegisterCode2, string CertID2, string WthldgTaxRate2, string WthldgTaxCode2, string MktValueType2, string CmplxHldrCode2)
        {
            EOL02901.TransNumber.SetValue(TransNumber);
            EOL02901.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02906");
            EOL02906.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL02906.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL02906.CertID.ValidateFieldValue(1, CertID1);
            EOL02906.CertID.ValidateFieldValue(2, CertID2);
            EOL02906.WitholdingTaxRate.ValidateFieldValue(1, WthldgTaxRate1);
            EOL02906.WitholdingTaxRate.ValidateFieldValue(2, WthldgTaxRate2);
            EOL02906.WitholdingTaxCode.ValidateFieldValue(1, WthldgTaxCode1);
            EOL02906.WitholdingTaxCode.ValidateFieldValue(2, WthldgTaxCode2);
            EOL02906.MarketValueType.ValidateFieldValue(1, MktValueType1);
            EOL02906.MarketValueType.ValidateFieldValue(2, MktValueType2);

            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (FormName != "EOL02901")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.HardWait(4);
                FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02901");
        }

        [Then(@"In  EOL02904 I Verify Event Tax details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL02904VerifyEventTaxDetails(string RegisterCode1, string CertID1, string WthldgTaxRate1, string WthldgTaxCode1, string MktValueType1, string CmplxHldrCode1, string RegisterCode2, string CertID2, string WthldgTaxRate2, string WthldgTaxCode2, string MktValueType2, string CmplxHldrCode2)
        {
            EOL02904.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL02904.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL02904.CertID.ValidateFieldValue(1, CertID1);
            EOL02904.CertID.ValidateFieldValue(2, CertID2);
            EOL02904.WitholdingTaxRate1.ValidateFieldValue(WthldgTaxRate1);
            EOL02904.WitholdingTaxRate2.ValidateFieldValue(WthldgTaxRate2);
            EOL02904.WitholdingTaxCode.ValidateFieldValue(1, WthldgTaxCode1);
            EOL02904.WitholdingTaxCode.ValidateFieldValue(2, WthldgTaxCode2);
            EOL02904.MarketValueType.ValidateFieldValue(1, MktValueType1);
            EOL02904.MarketValueType.ValidateFieldValue(2, MktValueType2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL02901");
        }

        [When(@"In EOL03301 I Add AESS Event details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03301AddAESSEventDetails(string TransNumber, string SearchName, string SelectionInd1, string SelectionInd2, string SelectionInd3, string SelectionInd4, string SelectionInd8, string SelectionInd9, string SelectionInd10, string TwoSelectionInd1, string TwoSelectionInd2, string TwoSelectionInd3, string TotEventUnits, string TotCurrentBal)
        {
            EOL03301.TransNumber.SetValue(TransNumber);
            EOL03301.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03302");
            EOL03302.SelectionInd1.SetValue(SelectionInd1);
            EOL03302.SelectionInd2.SetValue(SelectionInd2);
            EOL03302.SelectionInd3.SetValue(SelectionInd3);
            EOL03302.SelectionInd4.SetValue(SelectionInd4);
            //NO field id'S for 5 6 and 7
            //EOL03302.SelectionInd5.SetValue(SelectionInd5);
            //EOL03302.SelectionInd6.SetValue(SelectionInd6);
            //EOL03302.SelectionInd7.SetValue(SelectionInd7);
            EOL03302.SelectionInd8.SetValue(SelectionInd8);
            EOL03302.SelectionInd9.SetValue(SelectionInd9);
            EOL03302.SelectionInd10.SetValue(SelectionInd10);

            //Next page -this will vary with the number of register the holder got
            //if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() != "EOL03303")
            //{
            //    if (EOL03302.SelectionInd1.Exists() == true)
            //    {
            //        EOL03302.SelectionInd1.SetValue(TwoSelectionInd1);
            //    }
            //    if (EOL03302.SelectionInd2.Exists() == true)
            //    {
            //        EOL03302.SelectionInd2.SetValue(TwoSelectionInd2);
            //    }
            //    if (EOL03302.SelectionInd2.Exists() == true)
            //    {
            //        EOL03302.SelectionInd3.SetValue(TwoSelectionInd3);
            //    }
            //}

            //while (Spartan.Core.WinForms.WinFormsDriver.GetFormName() != "EOL03303")
            //    {
            //        Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //    }

            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (FormName != "EOL03303")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
                FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03303");
            EOL03303.TotEventUnits.ValidateFieldValue(TotEventUnits);
            EOL03303.TotCurrentBal.ValidateFieldValue(TotCurrentBal);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03301");
        }

        [When(@"In EOL03301 I Add Event details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03301AddEventDetails(string EventNumber, string Selection, string Selection1, string TransNumber, string SearchName, string RegisterCode1, string RegisterCode2, string CertID1, string CertID2, string EventUnits1, string EventUnits2, string CurrentBal1, string CurrentBal2, string SelectionInd1, string SelectionInd2, string TotEventUnits, string TotCurrentBal, string TotEventUnits1, string TotCurrentBal1)
        {
            EOL00133.Selection.SetValue(EventNumber);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00134");
            EOL00134.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00135");
            EOL00135.Selection.SetValue(Selection1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03301");

            EOL03301.TransNumber.SetValue(TransNumber);
            EOL03301.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03302");

            EOL03302.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL03302.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL03302.CertID.ValidateFieldValue(1, CertID1);
            EOL03302.CertID.ValidateFieldValue(2, CertID2);
            EOL03302.EventUnits1.ValidateFieldValue(EventUnits1);
            EOL03302.EventUnits2.ValidateFieldValue(EventUnits2);
            EOL03302.CurrentBal.ValidateFieldValue(1, CurrentBal1);
            EOL03302.CurrentBal.ValidateFieldValue(2, CurrentBal2);
            EOL03302.TotEventUnits.ValidateFieldValue(TotEventUnits);
            EOL03302.TotCurrentBal.ValidateFieldValue(TotCurrentBal);
            EOL03302.SelectionInd1.SetValue(SelectionInd1);
            EOL03302.SelectionInd2.SetValue(SelectionInd2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03303");
            EOL03303.TotEventUnits.ValidateFieldValue(TotEventUnits1);
            EOL03303.TotCurrentBal.ValidateFieldValue(TotCurrentBal1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03301");
        }

        [When(@"In EOL03304 I Change AESS Event details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03304ChangeAESSEventDetails(string TransNumber1, string SearchName, string CSelectionInd1, string CSelectionInd2, string CSelectionInd3, string CSelectionInd4, string CSelectionInd8, string CSelectionInd9, string CSelectionInd10, string C2SelectionInd1, string C2SelectionInd2, string C2SelectionInd3, string CTotEventUnits, string CTotCurrentBal)
        {
            EOL03304.TransNumber.SetValue(TransNumber1);
            EOL03304.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03305");
            EOL03305.SelectionInd1.SetValue(CSelectionInd1);
            EOL03305.SelectionInd2.SetValue(CSelectionInd2);
            EOL03305.SelectionInd3.SetValue(CSelectionInd3);
            EOL03305.SelectionInd4.SetValue(CSelectionInd4);
            //NO field id'S for 5 6 and 7
            //EOL03302.SelectionInd5.SetValue(SelectionInd5);
            //EOL03302.SelectionInd6.SetValue(SelectionInd6);
            //EOL03302.SelectionInd7.SetValue(SelectionInd7);
            EOL03305.SelectionInd8.SetValue(CSelectionInd8);
            EOL03305.SelectionInd9.SetValue(CSelectionInd9);
            EOL03305.SelectionInd10.SetValue(CSelectionInd10);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //ExpectToBeInTheScreen("EOL03305");
            //EOL03305.SelectionInd1.SetValue(C2SelectionInd1);
            //EOL03305.SelectionInd2.SetValue(C2SelectionInd2);
            //EOL03305.SelectionInd3.SetValue(C2SelectionInd3);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //ExpectToBeInTheScreen("EOL03306");
            //EOL03306.TotEventUnits.ValidateFieldValue(CTotEventUnits);
            //EOL03306.TotCurrentBal.ValidateFieldValue(CTotCurrentBal);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //ExpectToBeInTheScreen("EOL03304");

            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (FormName != "EOL03306")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
                FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }

            EOL03306.TotEventUnits.ValidateFieldValue(CTotEventUnits);
            EOL03306.TotCurrentBal.ValidateFieldValue(CTotCurrentBal);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03304");
        }

        [When(@"In EOL03304 I Modify Event details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03304ModifyEventDetails(string TransNumber, string SearchName, string RegisterCode1, string RegisterCode2, string CertID1, string CertID2, string EventUnits1, string EventUnits2, string CurrentBal1, string CurrentBal2, string SelectionInd1, string SelectionInd2, string TotEventUnits, string TotCurrentBal, string TotEventUnits1, string TotCurrentBal1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03304");
            EOL03304.TransNumber.SetValue(TransNumber);
            EOL03304.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03305");

            EOL03305.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL03305.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL03305.CertID.ValidateFieldValue(1, CertID1);
            EOL03305.CertID.ValidateFieldValue(2, CertID2);
            EOL03305.EventUnits.ValidateFieldValue(1, EventUnits1);
            EOL03305.EventUnits.ValidateFieldValue(2, EventUnits2);
            EOL03305.CurrentBal.ValidateFieldValue(1, CurrentBal1);
            EOL03305.CurrentBal.ValidateFieldValue(2, CurrentBal2);
            EOL03305.TotEventUnits.ValidateFieldValue(TotEventUnits);
            EOL03305.TotCurrentBal.ValidateFieldValue(TotCurrentBal);
            EOL03305.SelectionInd1.SetValue(SelectionInd1);
            EOL03305.SelectionInd2.SetValue(SelectionInd2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03306");
            EOL03306.TotEventUnits.ValidateFieldValue(TotEventUnits1);
            EOL03306.TotCurrentBal.ValidateFieldValue(TotCurrentBal1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03304");
        }

        [When(@"In EOL03307 I Delete Event details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03307DeleteEventDetails(string TransNumber, string SearchName, string RegisterCode1, string RegisterCode2, string CertID1, string CertID2, string EventUnits1, string EventUnits2, string CurrentBal1, string CurrentBal2, string TotEventUnits, string TotCurrentBal)
        {
            EOL03307.TransNumber.SetValue(TransNumber);
            EOL03307.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03308");
            EOL03308.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL03308.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL03308.CertID.ValidateFieldValue(1, CertID1);
            EOL03308.CertID.ValidateFieldValue(2, CertID2);
            EOL03308.EventUnits.ValidateFieldValue(1, EventUnits1);
            EOL03308.EventUnits.ValidateFieldValue(2, EventUnits2);
            EOL03308.CurrentBal.ValidateFieldValue(1, CurrentBal1);
            EOL03308.CurrentBal.ValidateFieldValue(2, CurrentBal2);

            while (EOL03308.TotEventUnits.Exists() != true)
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

            EOL03308.TotEventUnits.ValidateFieldValue(TotEventUnits);
            EOL03308.TotCurrentBal.ValidateFieldValue(TotCurrentBal);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03307");
        }

        [When(@"In EOL03401 I Add/Modify Event Election Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03401AddModifyEventElectionDetails(string DisposalChoice, string ExerciseUnits, string PartialUnits, string PymtMthd, string CurrencyCode, string RegisterCode1, string RegisterCode2, string CertID1, string CertID2, string EventUnits1, string EventUnits2, string ExerciseBal1, string ExerciseBal2, string CurrentBal1, string CurrentBal2, string TotEventUnits, string TotExerciseUnits, string TotCurrentBal)
        {
            EOL03409.DisposalChoice.SetValue(DisposalChoice);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03402");
            EOL03402.DisposalChoice.ValidateFieldValue(DisposalChoice);

            if (DisposalChoice != "L")
            {
                if (EOL03402.ExerciseUnits.Exists() == true)
                {
                    EOL03402.ExerciseUnits.SetValue(ExerciseUnits);
                }

                if (DisposalChoice == "P")
                {
                    EOL03402.PartialUnits.SetValue(PartialUnits);
                }

                if (DisposalChoice != "T")
                {
                    EOL03402.PymtMthd.SetValue(PymtMthd);
                }

                if (PymtMthd == "F")
                {
                    EOL03402.PymtMthd.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    EOL03402.CurrencyCode.SetValue(CurrencyCode);
                }

                Spartan.Core.WinForms.WinFormsDriver.Transmit();

                if (PymtMthd == "D")
                {
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                }
                else if (PymtMthd == "W")
                {
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                }
            }
            else
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03403");
            EOL03403.DisposalChoice.ValidateFieldValue(DisposalChoice);
            EOL03403.PymtMthd.ValidateFieldValue(PymtMthd);
            EOL03403.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL03403.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL03403.CertID.ValidateFieldValue(1, CertID1);
            EOL03403.CertID.ValidateFieldValue(2, CertID2);
            EOL03403.EventUnits.ValidateFieldValue(1, EventUnits1);
            EOL03403.EventUnits.ValidateFieldValue(2, EventUnits2);
            EOL03403.ExerciseBal.ValidateFieldValue(1, ExerciseBal1);
            EOL03403.ExerciseBal.ValidateFieldValue(2, ExerciseBal2);
            EOL03403.CurrentBal.ValidateFieldValue(1, CurrentBal1);
            EOL03403.CurrentBal.ValidateFieldValue(2, CurrentBal2);

            while (EOL03403.TotEventUnits.Exists() != true)
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

            EOL03403.TotEventUnits.ValidateFieldValue(TotEventUnits);
            EOL03403.TotExerciseUnits.ValidateFieldValue(TotExerciseUnits);
            EOL03403.TotCurrentBal.ValidateFieldValue(TotCurrentBal);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03401");
        }

        [When(@"In EOL03401 I Select Holder as ""(.*)"" ""(.*)""")]
        public void EOL03401SelectHolder(string TransNumber, string SearchName)
        {
            EOL03401.TransNumber.SetValue(TransNumber);
            EOL03401.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03409");
        }

        [When(@"In EOL03407 I Delete Event details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EOL03407DeleteEventDetails(string TransNumber, string SearchName, string DisposalChoice, string DisposalChoiceDesc, string PymtMthd, string PymtMthdDesc, string RegisterCode1, string RegisterCode2, string CertID1, string CertID2, string EventUnits1, string EventUnits2, string ExerciseBal1, string ExerciseBal2, string CurrentBal1, string CurrentBal2, string TotEventUnits, string TotExerciseUnits, string TotCurrentBal)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03407");
            EOL03407.TransNumber.SetValue(TransNumber);
            EOL03407.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03408");
            EOL03408.DisposalChoice.ValidateFieldValue(DisposalChoice);
            EOL03408.DisposalChoiceDesc.ValidateFieldValue(DisposalChoiceDesc);
            EOL03408.PymtMthd.ValidateFieldValue(PymtMthd);
            EOL03408.PymtMthdDesc.ValidateFieldValue(PymtMthdDesc);
            EOL03408.RegisterCode.ValidateFieldValue(1, RegisterCode1);
            EOL03408.RegisterCode.ValidateFieldValue(2, RegisterCode2);
            EOL03408.CertID.ValidateFieldValue(1, CertID1);
            EOL03408.CertID.ValidateFieldValue(2, CertID2);
            EOL03408.EventUnits.ValidateFieldValue(1, EventUnits1);
            EOL03408.EventUnits.ValidateFieldValue(2, EventUnits2);
            EOL03408.ExerciseBal.ValidateFieldValue(1, ExerciseBal1);
            EOL03408.ExerciseBal.ValidateFieldValue(2, ExerciseBal2);
            EOL03408.CurrentBal.ValidateFieldValue(1, CurrentBal1);
            EOL03408.CurrentBal.ValidateFieldValue(2, CurrentBal2);

            while (EOL03408.TotEventUnits.Exists() != true)
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

            EOL03408.TotEventUnits.ValidateFieldValue(TotEventUnits);
            EOL03408.TotExerciseUnits.ValidateFieldValue(TotExerciseUnits);
            EOL03408.TotCurrentBal.ValidateFieldValue(TotCurrentBal);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL03407");
        }

        [Then(@"In EOL00901 I give units to the Holder:")]
        public void GiveUnitsToTheHolder(Table ManualAward)
        {
            string TranNo = ManualAward.GetData("TranchNo");
            string TotalUnits = ManualAward.GetData("TotalUnits");
            string HIN = ManualAward.GetData("HIN");

            EOL00901.TransNumber.SetValue(TranNo);
            EOL00901.TotalUnits.SetValue(TotalUnits);
            EOL00901.SearchName.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I go to the Employee Scheme Processing Menu ""(.*)""")]
        public void GoToTheEmployeeSchemeProcessingMenu(string ClassCode)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("employee plan processing");
            ClickOnEOL00126EmployeeSchemeProcessingMenu("employee scheme processing");
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            while (!EOL00101.ClassCode.GetValue().ToUpper().Split('\r', '\n').Contains(ClassCode))
            {
                EOL00101.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00101");
            }

            EOL00101.Selection.SetValue(ClassCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I go to the Reversal of Grant Menu ""(.*)""")]
        public void GoToTheReversalOfGrantMenu(string RegisterCode)
        {
            while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(RegisterCode))
            {
                EOL00103.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            }

            EOL00103.Selection.SetValue(RegisterCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00109");
            ClickOnEOL00109EmployeeGrantProcessingMenu("reversal of grant");
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        }

        [When(@"I go to the Grant Options Menu for ""(.*)""")]
        public void IGoToTheGrantOptionsMenu(string MenuItem)
        {
            EOL00107ClickOnMenu("grant options");
            EOL00137.Selection.SetValue(MenuItem);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
        }

        [When(@"In EOL00116 I select ""(.*)"" as the award date")]
        public void SelectAsTheAwardDate(string AwardDate)
        {
            EOL00116.AppropDate.SetValue(AwardDate);
            ///need to add the file name to convert?>>>
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"IN EOL00101 I select ""(.*)"" as the employee Plan")]
        public void SelectAsTheEmployeePlan(string PlanName)
        {
            EOL00101.Selection.SetValue(PlanName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00103 I Select ""(.*)"" as the Register code")]
        public void SelectAsTheRegisterCode(string RegisterCode)
        {
            EOL00103.Selection.SetValue(RegisterCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"In EOL01701 I should see ESS Employee Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""(.*)""")]
        [When(@"In EOL01701 I should see ESS Employee Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""(.*)""")]
        public void ShouldSeeESSEmployeeDetails(string EmployeeID, string EffectiveDate, string EmployeeStatus, string LeaverCode, string PayrollID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.PayrollID.ValidateFieldValue(PayrollID);
            EOL01701.EmployeeNumber.ValidateFieldValue(EmployeeID);
            EOL01701.EffectiveDate.ValidateFieldValue(EffectiveDate);
            EOL01701.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            EOL01701.LeaverCode.ValidateFieldValue(LeaverCode);
        }

        [Then(@"In EOL01701 I should see ESS Employee Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeESSEmployeeDetailsPart1(string TranNo, string PayrollID, string EmployeeID, string SubPayrollID, string GenerateEmpUniqueID, string EmpUniqueID, string StartDate, string TermDate, string TermDesc, string PreferredName, string EmployeeStatus, string LeaverCode, string EffectiveDate, string BirthDate, string AutoForfeit, string BlackoutInd, string BlackoutCode, string LocationCode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.ValidateFieldValue(TranNo);
            EOL01701.PayrollID.ValidateFieldValue(PayrollID);
            EOL01701.EmployeeNumber.ValidateFieldValue(EmployeeID);
            EOL01701.SubPayrollID.ValidateFieldValue(SubPayrollID);
            EOL01701.GenEmpUniqueID.ValidateFieldValue(GenerateEmpUniqueID);
            EOL01701.EmployeeUniqueID.ValidateFieldValue(EmpUniqueID);
            EOL01701.StartDate.ValidateFieldValue(StartDate);
            EOL01701.TermDate.ValidateFieldValue(TermDate);
            EOL01701.TermDesc.ValidateFieldValue(TermDesc);
            EOL01701.PreferredName.ValidateFieldValue(PreferredName);
            EOL01701.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            EOL01701.LeaverCode.ValidateFieldValue(LeaverCode);
            EOL01701.EffectiveDate.ValidateFieldValue(EffectiveDate);
            EOL01701.BirthDate.ValidateFieldValue(BirthDate);
            EOL01701.AutoForfeit.ValidateFieldValue(AutoForfeit);
            EOL01701.BlkoutRstrctdInd.ValidateFieldValue(BlackoutInd);
            EOL01701.LocationCode.ValidateFieldValue(LocationCode);

            if (BlackoutInd == "Y")
            {
                EOL01701.BlkoutRstrctdCode.ValidateFieldValue(BlackoutCode);
            }
        }

        [Then(@"In EOL01701 I should see ESS Employee Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeESSEmployeeDetailsPart2(string BusinessUnit, string JobBand, string CostCentre, string EmpFlag1, string EmpFlag2, string Offers, string Statements, string SharePlanComm, string NoticeOfMeeting)
        {
            EOL01701.BusinessUnit.ValidateFieldValue(BusinessUnit);
            EOL01701.JobBand.ValidateFieldValue(JobBand);
            EOL01701.CostCentre.ValidateFieldValue(CostCentre);
            EOL01701.EmployeeFlag1.ValidateFieldValue(EmpFlag1);
            EOL01701.EmployeeFlag2.ValidateFieldValue(EmpFlag2);
            EOL01701.EmpCommOffer.ValidateFieldValue(Offers);
            EOL01701.EmpCommStmnt.ValidateFieldValue(Statements);
            EOL01701.EmpCommAdhoc.ValidateFieldValue(SharePlanComm);
            EOL01701.EmpCommMeeting.ValidateFieldValue(NoticeOfMeeting);
        }

        [When(@"I go to the Manual Grant of Options Menu ""(.*)""")]
        public void WhenIGoToTheManualGrantOfOptionsMenu(string RegisterCode)
        {
            while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(RegisterCode))
            {
                EOL00103.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            }

            EOL00103.Selection.SetValue(RegisterCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00109");
            ClickOnEOL00109EmployeeGrantProcessingMenu("manual grant of options");
        }

        [When(@"In EOL01701 I Change ESS Employee Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""(.*)""")]
        public void WhenInEOLIChangeESSEmployeeDetailsAs(string ModifyType, string TranNo, string EmployeeID, string EffectiveDate, string EmployeeStatus, string LeaverCode, string PayrollID,string UpdateOption)
        {
            OLS01101.Action.SetValue(ModifyType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.SetValue(TranNo);
            EOL01701.PayrollID.SetValue(PayrollID);
            EOL01701.EmployeeNumber.SetValue(EmployeeID);
            EOL01701.EmployeeStatus.SetValue(EmployeeStatus);
            //EOL01701_SCRIPOnlineDataEntrySystemMENU.LeaverCode.SetValue(LeaverCode);
            EOL01701.EffectiveDate.SetValue(EffectiveDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In EOL00115 I select the Register Type as:")]
        public void EOL00115SelectTheRegisterType(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00115");
            EOL00115.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In EOL00103 I select the RegisterCode as:")]
        public void EOL00103SelectTheRegisterCode(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(table.Rows[0]["RegisterCode"]))
            {
                EOL00101.Selection.SetValue("NXT");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
            }

            EOL00103.Selection.SetValue(1, table.Rows[0]["RegisterCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            //WinFormsTestSteps.ExpectToBeInTheScreen("EOL00114");

        }

        [When(@"In EOL00114 I continue with the following values:")]
        public void EOL00114ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00114");
            EOL00114.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if ((table.Rows[0]["Selection"]).ToLower()== "asa")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
            }
            if (((table.Rows[0]["Selection"]).ToLower() == "int") || ((table.Rows[0]["Selection"]).ToLower() == "upl"))
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
            }
            //can add the other functionalities when needed

        }

        [When(@"In EOL00901 I Add Savings amount as:")]
        public void EOL00901AddSavingsAmount(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
            EOL00901.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL00901.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            EOL00901.TotalMoney.SetValue(1, table.Rows[0]["TotalMoney"]);

            if (EOL00901.TotalUnits.Exists()==true)
            {
                EOL00901.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            }

            EOL00901.PaymentFrequency.SetValue(1, table.Rows[0]["PaymentFrequency"]);
            if (EOL00901.ResidualInd.Exists() == true)
            {
                EOL00901.ResidualInd.SetValue(1, table.Rows[0]["ResidualInd"]);
            }
            if (EOL00901.GrantCountry.Exists() == true)
            {
                EOL00901.GrantCountry.SetValue(1, table.Rows[0]["GrantCountry"]);
            }
            if (EOL00901.RetentionDate.Exists() == true)
            {
                EOL00901.RetentionDate.SetValue(1, table.Rows[0]["RetentionDate"]);
            }
            if (EOL00901.TaxRetentionDate.Exists() == true)
            {
                EOL00901.TaxRetentionDate.SetValue(1, table.Rows[0]["TaxRetentionDate"]);
            }
            EOL00901.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "EOL00903")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

        }

        [When(@"In EOL00905 I continue with the following values:")]
        public void EOL00905ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00905");
            EOL00905.RegisterType1.ValidateFieldValue(1, table.Rows[0]["RegisterType1"]);
            EOL00905.Money1.ValidateFieldValue(1, table.Rows[0]["Money1"]);
            EOL00905.PaymentFrequency.ValidateFieldValue(1, table.Rows[0]["PaymentFrequency"]);

            if (EOL00905.RetentionDate.Exists()==true)
                EOL00905.RetentionDate.ValidateFieldValue(1, table.Rows[0]["RetentionDate"]);
            if (EOL00905.TaxRetentionDate.Exists() == true)
                EOL00905.TaxRetentionDate.ValidateFieldValue(1, table.Rows[0]["TaxRetentionDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
        }

        [When(@"In EOL00120 I continue with the following values:")]
        public void EOL00120ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00120");
            EOL00114.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In EOL01901 I Add Manual Payment as:")]
        public void EOL01901AddManualPayment(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01901");
            EOL01901.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            EOL01901.PaymentFrequency.SetValue(1, table.Rows[0]["PaymentFrequency"]);
            EOL01901.AccumPeriod.SetValue(1, table.Rows[0]["AccumPeriod"]);
            EOL01901.PaymentNumber.SetValue(1, table.Rows[0]["PaymentNumber"]);
            EOL01901.PaymentStatus.SetValue(1, table.Rows[0]["PaymentStatus"]);
            EOL01901.Eol01901ReceiptCurrency.SetValue(1, table.Rows[0]["Eol01901ReceiptCurrency"]);
            EOL01901.PaymentDate.SetValue(1, table.Rows[0]["PaymentDate"]);
            EOL01901.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            EOL01901.EmployerPymtAmt.SetValue(1, table.Rows[0]["EmployerPymtAmt"]);
            EOL01901.Eol01901ExchangeRate.SetValue(1, table.Rows[0]["Eol01901ExchangeRate"]);
            EOL01901.SearchName.SetValue(1, table.Rows[0]["SearchName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In EOL01902 I verify the following values:")]
        public void EOL01902VerifyTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01902");
            EOL01902.AccumPeriod.ValidateFieldValue(1, table.Rows[0]["AccumPeriod"]);
            EOL01902.PaymentNumber.ValidateFieldValue(1, table.Rows[0]["PaymentNumber"]);
            EOL01902.PaymentFrequency.ValidateFieldValue(1, table.Rows[0]["PaymentFrequency"]);
            EOL01902.RegisterType.ValidateFieldValue(1, table.Rows[0]["RegisterType"]);
            EOL01902.PaymentAmount.ValidateFieldValue(1, table.Rows[0]["PaymentAmount"]);
            EOL01902.Eol01902EmpBaseCurr.ValidateFieldValue(1, table.Rows[0]["Eol01902EmpBaseCurr"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01901");
        }

        [When(@"In EOL00106 I continue with the following values:")]
        public void EOL00106ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00106");
            EOL00106.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In EOLBLK05 I continue with the following values:")]
        public void EOLBLK05ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOLBLK05");

            if (EOLBLK05.PayFreq.Exists() == true)
            {
                EOLBLK05.PayFreq.SetValue(1, table.Rows[0]["PayFreq1"]);
                EOLBLK05.AccumPeriodFrom.SetValue(1, table.Rows[0]["AccumPeriodFrom1"]);
                EOLBLK05.AccumPeriodTO.SetValue(1, table.Rows[0]["AccumPeriodTO1"]);

                EOLBLK05.PayFreq.SetValue(2, table.Rows[0]["PayFreq2"]);
                EOLBLK05.AccumPeriodFrom.SetValue(2, table.Rows[0]["AccumPeriodFrom2"]);
                EOLBLK05.AccumPeriodTO.SetValue(2, table.Rows[0]["AccumPeriodTO2"]);
                EOLBLK05.PayFreq.SetValue(3, table.Rows[0]["PayFreq3"]);
                EOLBLK05.AccumPeriodFrom.SetValue(3, table.Rows[0]["AccumPeriodFrom3"]);
                EOLBLK05.AccumPeriodTO.SetValue(3, table.Rows[0]["AccumPeriodTO3"]);
            }

            EOLBLK05.ReleaseMode.SetValue(1, table.Rows[0]["ReleaseMode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "EOLBLK02")
            {
                EOLBLK02.Selection.SetValue("Y");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

        }

        [When(@"In EOLBLK04 I continue with the following values:")]
        public void EOLBLK04ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOLBLK04");
            EOLBLK04.ConfirmRelType.SetValue(1, table.Rows[0]["ConfirmRelType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In OLSBLK02 I continue with the following values:")]
        public void OLSBLK02ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSBLK02");
            OLSBLK02.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();            
        }

        [When(@"In OLSB0401 I change the Bulk Status as:")]
        public void OLSB0401ChangeTheBulkStatus(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0401");
            OLSB0401.MenuSelection.SetValue(1, table.Rows[0]["MenuSelection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLSB0402 I change the Bulk Status as:")]
        public void OLSB0402ChangeTheBulkStatus(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0402");
            if (table.Rows[0]["SettlementDate"] != "")
                OLSB0402.SettlementDate.SetValue(1, table.Rows[0]["SettlementDate"]);
            if (table.Rows[0]["TradeDate"] != "")
                OLSB0402.TradeDate.SetValue(1, table.Rows[0]["TradeDate"]);
            if (table.Rows[0]["TradeTime"] != "")
                OLSB0402.TradeTime.SetValue(1, table.Rows[0]["TradeTime"]);
            if (table.Rows[0]["IndicativePrice"] != "")
                OLSB0402.IndicativePrice.SetValue(1, table.Rows[0]["IndicativePrice"]);
            if (table.Rows[0]["FinalPrice"] != "")
                OLSB0402.FinalPrice.SetValue(1, table.Rows[0]["FinalPrice"]);
            if (table.Rows[0]["RegisterCode"] !="")
                OLSB0402.RegisterCode.SetValue(1, table.Rows[0]["RegisterCode"]);
            if (table.Rows[0]["ChargeCode1"] != "")
                OLSB0402.ChargeCode.SetValue(1, table.Rows[0]["ChargeCode1"]);
            if (table.Rows[0]["ChargeCode2"] != "")
                OLSB0402.ChargeCode.SetValue(2, table.Rows[0]["ChargeCode2"]);
            if (table.Rows[0]["ChargeCode3"] != "")
                OLSB0402.ChargeCode.SetValue(3, table.Rows[0]["ChargeCode3"]);
            if (table.Rows[0]["ChargeDesc1"] != "")
                OLSB0402.ChargeDesc.SetValue(1, table.Rows[0]["ChargeDesc1"]);
            if (table.Rows[0]["ChargeDesc2"] != "")
                OLSB0402.ChargeDesc.SetValue(2, table.Rows[0]["ChargeDesc2"]);
            if (table.Rows[0]["ChargeDesc3"] != "")
                OLSB0402.ChargeDesc.SetValue(3, table.Rows[0]["ChargeDesc3"]);

            OLSB0402.ConfirmStatus.SetValue(1, table.Rows[0]["ConfirmStatus"]);
            if (OLSB0402.AwardDate.Exists()==true)
                OLSB0402.AwardDate.SetValue(1, table.Rows[0]["AwardDate"]);
            
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLSB0403 I continue with the following values:")]
        public void OLSB0403ContinueWithTheFollowingValues(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "OLSB0403")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0403");
                if (OLSB0403.ConfirmSettlement.Exists() == true)
                {
                    OLSB0403.ConfirmSettlement.SetValue(1, table.Rows[0]["ConfirmSettlement"]);
                }
                if (OLSB0403.ConfirmFinalPrice.Exists() == true)
                {
                    OLSB0403.ConfirmFinalPrice.SetValue(1, table.Rows[0]["ConfirmFinalPrice"]);
                }
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "OLSB0405")
            {
                BulkID = OLSB0405.BulkID.GetValue();
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                WinFormsTestSteps.ExpectToBeInTheScreen("OLSBLK02");
            }

        }

        [Then(@"In OLSB0404 I verify the following values:")]
        [When(@"In OLSB0404 I verify the following values:")]
        public void OLSB0404VerifyTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0404");
            OLSB0404.TotalCount.ValidateFieldValue(1, table.Rows[0]["TotalCount"]);
            OLSB0404.TotalUnits.ValidateFieldValue(1, table.Rows[0]["TotalUnits"]);
            OLSB0404.SettlementDate.ValidateFieldValue(1, table.Rows[0]["SettlementDate"]);
            OLSB0404.FinalPrice.ValidateFieldValue(1, table.Rows[0]["FinalPrice"]);
            OLSB0404.UnitsCalc.ValidateFieldValue(1, table.Rows[0]["UnitsCalc"]);
            OLSB0404.CostOFShares.ValidateFieldValue(1, table.Rows[0]["CostOFShares"]);
            OLSB0404.TotalCost.ValidateFieldValue(1, table.Rows[0]["TotalCost"]);
            OLSB0404.ResidueKept.ValidateFieldValue(1, table.Rows[0]["ResidueKept"]);
            OLSB0404.ResidueRefunded.ValidateFieldValue(1, table.Rows[0]["ResidueRefunded"]);
            OLSB0404.TaxONCharges.ValidateFieldValue(1, table.Rows[0]["TaxONCharges"]);
            OLSB0404.AccumCharges.ValidateFieldValue(1, table.Rows[0]["AccumCharges"]);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSBLK02");
        }

        [When(@"In OLSB0105 I continue with the following values:")]
        public void OLSB0105ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0105");
            OLSB0105.BulkCurrency.SetValue(1, table.Rows[0]["BulkCurrency"]);
            OLSB0105.SettlementFrom.SetValue(1, table.Rows[0]["SettlementFrom"]);
            OLSB0105.SettlementTO.SetValue(1, table.Rows[0]["SettlementTO"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLSB0106 I continue with the following values:")]
        public void OLSB0106ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0106");
            OLSB0106.BulkID1.ValidateFieldValue(1, table.Rows[0]["BulkID1"]);
            OLSB0106.Currency1.ValidateFieldValue(1, table.Rows[0]["Currency1"]);
            OLSB0106.SettlementDate1.ValidateFieldValue(1, table.Rows[0]["SettlementDate1"]);
            OLSB0106.ProcessBulkInd1.SetValue(1, table.Rows[0]["ProcessBulkInd1"]);

            if (OLSB0106.BulkID2.Exists()==true)
            {
                OLSB0106.BulkID2.ValidateFieldValue(1, table.Rows[0]["BulkID2"]);
                OLSB0106.Currency2.ValidateFieldValue(1, table.Rows[0]["Currency2"]);
                OLSB0106.SettlementDate2.ValidateFieldValue(1, table.Rows[0]["SettlementDate2"]);
                OLSB0106.ProcessBulkInd2.SetValue(1, table.Rows[0]["ProcessBulkInd2"]);
            }

            if (OLSB0106.BulkID3.Exists() == true)
            {
                OLSB0106.BulkID3.ValidateFieldValue(1, table.Rows[0]["BulkID3"]);
                OLSB0106.Currency3.ValidateFieldValue(1, table.Rows[0]["Currency3"]);
                OLSB0106.SettlementDate3.ValidateFieldValue(1, table.Rows[0]["SettlementDate3"]);
                OLSB0106.ProcessBulkInd3.SetValue(1, table.Rows[0]["ProcessBulkInd3"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLSB0104 I verify the following values:")]
        public void OLSB0104VerifyTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0104");
            OLSB0104.HomeBankDesc.ValidateFieldValue(1, table.Rows[0]["HomeBankDesc"]);
            OLSB0104.AusTraceAccount.ValidateFieldValue(1, table.Rows[0]["AusTraceAccount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLSB0101 I continue with the following values:")]
        public void OLSB0101ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0101");
            OLSB0101.PaymentAccount.SetValue(1, table.Rows[0]["PaymentAccount"]);
            OLSB0101.OrderNO.SetValue(1, table.Rows[0]["OrderNO"]);
            OLSB0101.Ident.SetValue(1, table.Rows[0]["Ident"]);

            OLSB0101.NbrBulks.ValidateFieldValue(1, table.Rows[0]["NbrBulks"]);
            OLSB0101.SettlementFrom.ValidateFieldValue(1, table.Rows[0]["SettlementFrom"]);
            OLSB0101.SettlementTO.ValidateFieldValue(1, table.Rows[0]["SettlementTO"]);

            OLSB0101.PaymentDate.SetValue(1, table.Rows[0]["PaymentDate"]);
            OLSB0101.AddConvRateInd.SetValue(1, table.Rows[0]["AddConvRateInd"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB0102");
            ReportingTestSteps.ReportJobNumber = OLSB0102.JobNODec.GetValue();
        }

        [When(@"In BLKSCH01 I continue with the following values:")]
        public void BLKSCH01ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("BLKSCH01");
            BLKSCH01.BulkID.ValidateFieldValue(1,BulkID);
            BLKSCH01.Status.ValidateFieldValue(1, table.Rows[0]["Status"]);
            BLKSCH01.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);
            BLKSCH01.TransCount.ValidateFieldValue(1, table.Rows[0]["TransCount"]);
            BLKSCH01.TransTotal.ValidateFieldValue(1, table.Rows[0]["TransTotal"]);

            //string SystemInfoFree4 = BLKSCH01.SystemInfoFree4.GetValue();
            //String SystemDate = SystemInfoFree4.Substring(SystemInfoFree4.Length - 10).Replace("-", "/").Replace("2016", "16").Replace("2015", "15");
            //BLKSCH01.SettlementDate.ValidateFieldValue(SystemDate);

            BLKSCH01.Selection.SetValue(BulkID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In OLSB1010 I verify the following values:")]
        public void OLSB1010VerifyTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB1010");
            BLKSCH01.BulkID.ValidateFieldValue(1, BulkID);
            OLSB1010.StatusDesc.ValidateFieldValue(1, table.Rows[0]["StatusDesc"]);
            OLSB1010.BulkCount.ValidateFieldValue(1, table.Rows[0]["BulkCount"]);
            OLSB1010.BulkUnits.ValidateFieldValue(1, table.Rows[0]["BulkUnits"]);
            OLSB1010.TransUnits.ValidateFieldValue(1, table.Rows[0]["TransUnits"]);
            OLSB1010.BulkMoney.ValidateFieldValue(1, table.Rows[0]["BulkMoney"]);
            OLSB1010.TransMoney.ValidateFieldValue(1, table.Rows[0]["TransMoney"]);
            OLSB1010.TranTypeParent.ValidateFieldValue(1, table.Rows[0]["TranTypeParent"]);
            OLSB1010.HolderID.ValidateFieldValue(1, table.Rows[0]["HolderID"]);
            OLSB1010.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);

            string BulkUnits = OLSB1010.BulkCount.GetValue();
            if (int.Parse(BulkUnits) ==1)
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

        }

        [When(@"In BLKSCH02 I verify the following values:")]
        public void BLKSCH02VerifyTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("BLKSCH02");
            BLKSCH02.BulkType.ValidateFieldValue(1, table.Rows[0]["BulkType"]);
            BLKSCH02.BulkTypeDesc.ValidateFieldValue(1, table.Rows[0]["BulkTypeDesc"]);
            BLKSCH02.ClassCode.ValidateFieldValue(1, table.Rows[0]["ClassCode"]);
            BLKSCH02.TotalCount.ValidateFieldValue(1, table.Rows[0]["TotalCount"]);
            BLKSCH02.BulkTransUnits.ValidateFieldValue(1, table.Rows[0]["BulkTransUnits"]);
            BLKSCH02.BulkTransMoney.ValidateFieldValue(1, table.Rows[0]["BulkTransMoney"]);
            BLKSCH02.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);

            string SystemInfoFree4 = ENS01012.SystemInfoFree4.GetValue();
            String SystemDate = SystemInfoFree4.Substring(SystemInfoFree4.Length - 10).Replace("-", "/");
            BLKSCH02.SettlementDate.ValidateFieldValue(SystemDate);

            BLKSCH02.TradeDate.ValidateFieldValue(1, table.Rows[0]["TradeDate"]);
            BLKSCH02.TradeTime.ValidateFieldValue(1, table.Rows[0]["TradeTime"]);
            BLKSCH02.IndicativePrice.ValidateFieldValue(1, table.Rows[0]["IndicativePrice"]);
            BLKSCH02.FinalPrice.ValidateFieldValue(1, table.Rows[0]["FinalPrice"]);
            BLKSCH02.ActionM.SetValue(1, table.Rows[0]["ActionM"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In BLKSCH03 I verify the following values:")]
        public void BLKSCH03VerifyTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("BLKSCH03");
            BLKSCH03.FinalPrice.ValidateFieldValue(1, table.Rows[0]["FinalPrice"]);
            BLKSCH03.UnitsCalc.ValidateFieldValue(1, table.Rows[0]["UnitsCalc"]);
            BLKSCH03.CostOFShares.ValidateFieldValue(1, table.Rows[0]["CostOFShares"]);
            BLKSCH03.TotalCost.ValidateFieldValue(1, table.Rows[0]["TotalCost"]);
            BLKSCH03.ResidueKept.ValidateFieldValue(1, table.Rows[0]["ResidueKept"]);
            BLKSCH03.ResidueRefunded.ValidateFieldValue(1, table.Rows[0]["ResidueRefunded"]);
            BLKSCH03.PaymentAccount.ValidateFieldValue(1, table.Rows[0]["PaymentAccount"]);
            BLKSCH03.BankType.ValidateFieldValue(1, table.Rows[0]["BankType"]);
            BLKSCH03.BankCode.ValidateFieldValue(1, table.Rows[0]["BankCode"]);
            BLKSCH03.AccountNumber.ValidateFieldValue(1, table.Rows[0]["AccountNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In EOL00116 I continue with the following values:")]
        public void EOL00116ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
            EOL00116.AppropDate.SetValue(1, table.Rows[0]["AppropDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In EOL00501 I continue with the following values:")]
        public void EOL00501ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00501");
            EOL00501.InputFilename.SetValue(1, table.Rows[0]["InputFilename"]);
            EOL00501.NameSelection.SetValue(1, table.Rows[0]["NameSelection"]);
            EOL00501.PCSelection.SetValue(1, table.Rows[0]["PCSelection"]);
            EOL00501.AddressMatching.SetValue(1, table.Rows[0]["AddressMatching"]);
            EOL00501.AllowBlankAddress.SetValue(1, table.Rows[0]["AllowBlankAddress"]);

            if (EOL00501.UpdateAddrDetails.Exists() ==true)
                EOL00501.UpdateAddrDetails.SetValue(1, table.Rows[0]["UpdateAddrDetails"]);
            if (EOL00501.UpdateEmpDetails.Exists() == true)
                EOL00501.UpdateEmpDetails.SetValue(1, table.Rows[0]["UpdateEmpDetails"]);
            if (EOL00501.AutoGenEmpUnqID.Exists() == true)
                EOL00501.AutoGenEmpUnqID.SetValue(1, table.Rows[0]["AutoGenEmpUnqID"]);
            if (EOL00501.ClearEmpUnqID.Exists() == true)
                EOL00501.ClearEmpUnqID.SetValue(1, table.Rows[0]["ClearEmpUnqID"]);
            if (EOL00501.UpdateContactDets.Exists() == true)
                EOL00501.UpdateContactDets.SetValue(1, table.Rows[0]["UpdateContactDets"]);
            if (EOL00501.UploadTfn.Exists() == true)
                EOL00501.UploadTfn.SetValue(1, table.Rows[0]["UploadTfn"]);
            if (EOL00501.UpdateMandates.Exists() == true)
                EOL00501.UpdateMandates.SetValue(1, table.Rows[0]["UpdateMandates"]);
            if (EOL00501.UpdateDrp.Exists() == true)
                EOL00501.UpdateDrp.SetValue(1, table.Rows[0]["UpdateDrp"]);
            if (EOL00501.RunTrnedt.Exists() == true)
                EOL00501.RunTrnedt.SetValue(1, table.Rows[0]["RunTrnedt"]);
            if (EOL00501.CreateNewAccounts.Exists() == true)
                EOL00501.CreateNewAccounts.SetValue(1, table.Rows[0]["CreateNewAccounts"]);


            EOL00501.ReportFullTotals.SetValue(1, table.Rows[0]["ReportFullTotals"]);
            EOL00501.AutoFtpReportsInd.SetValue(1, table.Rows[0]["AutoFtpReportsInd"]);

            // #### create H & I timestamps ####
            /*string SystemInfoFree4 = EOL00501.SystemInfoFree4.GetValue();
            SystemInfoFree4 = SystemInfoFree4.Substring(SystemInfoFree4.Length - 10);
            string[] thisArray = SystemInfoFree4.Split('-');//<string1/string2/string3/--->     
            List<string> myList = new List<string>(); //make a new string list    
            myList.AddRange(thisArray);
            string formatted_date = myList[2] + myList[1] + myList[0];
            string CurrentTime = DateTime.Now.ToString("HH:mm:ss").Replace(":", "");
            string Timestamp = formatted_date + CurrentTime;
            Console.WriteLine(Timestamp); */

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();


        }

        [When(@"In EOL00601 I continue with the following values:")]
        public void EOL00601ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00601");
            EOL00601.Timestamp.SetValue(ReportingTestSteps.Timestamps);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00601");
            EOL00601.ReportFullTotals.SetValue(1, table.Rows[0]["ReportFullTotals"]);
            EOL00601.AutoFtpReportsInd.SetValue(1, table.Rows[0]["AutoFtpReportsInd"]);
            if (EOL00601.Confirm.Exists() ==true)
            EOL00601.Confirm.SetValue(1, table.Rows[0]["Confirm"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In EOL00602 I continue with the following values:")]
        public void EOL00602ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00602");
            EOL00602.ReportHeading.SetValue(1, table.Rows[0]["ReportHeading"]);
            EOL00602.ReportDate.SetValue(1, table.Rows[0]["ReportDate"]);
            EOL00602.ReportSequence.SetValue(1, table.Rows[0]["ReportSequence"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }


        [When(@"In OLSB1010 I continue with the following values:")]
        public void OLSB1010ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSB1010");
            OLSB1010.EnquiryAction.SetValue(1, table.Rows[0]["EnquiryAction"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In EOL00137 I select the Register Type as:")]
        public void EOL00137SelectTheRegisterType(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00137");
            EOL00137.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In EOL00109 I continue with the following values:")]
        public void EOL00109ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00109");
            EOL00109.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if (((table.Rows[0]["Selection"]).ToLower() == "int") || ((table.Rows[0]["Selection"]).ToLower() == "upl"))
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
            }
            //can add the other functionalities when needed
        }

        [When(@"In EOL00124 I continue with the following values:")]
        public void EOL00124ContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("EOL00124");
            EOL00124.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if (((table.Rows[0]["Selection"]).ToLower() == "int") || ((table.Rows[0]["Selection"]).ToLower() == "upl"))
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
            }
            //can add the other functionalities when needed


        }

        [When(@"In BLKSCH01 I Select the first bulk")]
        public void WhenInBLKSCHISelectTheFirstBulk(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("BLKSCH01");
            string BulkID = BLKSCH01.BulkID.GetValue(1);
            BLKSCH01.Selection.SetValue(BulkID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }


        [When(@"In BLKSCH01 I Select the bulk")]
        public void BLKSCH01SelectTheBulk(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("BLKSCH01");
            int BulkNo = Convert.ToInt32(table.Rows[0]["BulkNo"]);
            string BulkID = BLKSCH01.BulkID.GetValue(BulkNo);
            BLKSCH01.Selection.SetValue(BulkID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }





    }
}

