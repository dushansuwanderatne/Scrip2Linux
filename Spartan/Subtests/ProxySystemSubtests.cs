using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class ProxySystemSubtests
    {
        public ProxySystemSubtests()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }

        /// <param name="table">data table</param>
        [When(@"In NOMSCH01 I continue with the following details:")]
        public void NOMSCH01ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("NOMSCH01");
            if (NOMSCH01.Action1st.Exists() == true)
            {
                NOMSCH01.Action1st.SetValue(1, table.Rows[0]["Action1st"]);
            }
            else if (NOMSCH01.Action.Exists() == true)
            {
                NOMSCH01.Action.SetValue(1, table.Rows[0]["Action1st"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            NOMSCH01.Code.SetValue(1, table.Rows[0]["Code"]);
            NOMSCH01.Name.SetValue(1, table.Rows[0]["Name"]);
            NOMSCH01.Status.SetValue(1, table.Rows[0]["Status"]);
            NOMSCH01.Type.SetValue(1, table.Rows[0]["Type"]);
            NOMSCH01.Current.SetValue(1, table.Rows[0]["Current"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00101 I enter proxy details:")]
        public void PXS00101EnterProxyDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00101");
            PXS00101.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00105");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In PXS00101 I select proxy details Menu:")]
        public void PXS00101SelectProxyDetailsMenu(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00101");
            PXS00101.Selection.SetValue(1, table.Rows[0]["Selection1"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00102 I continue with the following details:")]
        public void PXS00102ContinueWthTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00102");
            PXS00102.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00103 I continue with the following details:")]
        public void PXS00103ContinueWithThefollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00103");
            table.Rows[0]["PasswordInput"] = PXS00103.PasswordOutput.GetValue();
            PXS00103.PasswordInput.SetValue(1, table.Rows[0]["PasswordInput"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In PXS00106 I enter Proxy Details as ""(.*)"" ""(.*)""")]
        public void PXS00106EnterProxyDetails(string MeetingNumber, string Action)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("online proxy system");
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00106");
            PXS00106.MeetingNumber.SetValue(MeetingNumber);
            PXS00106.Action.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00107");
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00106 I Go to Proxy Meeting:")]
        public void PXS00106GoToProxyMeeting(Table table)
        {
            MNS00101.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00106");
            PXS00106.MeetingNumber.SetValue(1, table.Rows[0]["MeetingNumber"]);
            PXS00106.Action.SetValue(1, table.Rows[0]["Action"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00101");
        }

        [When(@"In PXS00107 I enter proxy Details as ""(.*)"" ""(.*)""")]
        public void PXS00107EnterProxyDetails(string MeetingHeading, string MeetingDate)
        {
            PXS00107.MeetingHeading.SetValue(MeetingHeading);
            PXS00107.MeetingDate.SetValue(MeetingDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00101");

            PXS00101.MeetingHeading.ValidateFieldValue(MeetingHeading);
            PXS00101.MeetingDate.ValidateFieldValue(MeetingDate);
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00109 I continue with the following:")]
        public void PXS00109ContinueWithTheFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00109");
            PXS00109.Confirm.SetValue(1, table.Rows[0]["Confirm1"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00113");
            PXS00113.FinalConfirm.SetValue(1, table.Rows[0]["FinalConfirm"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00201 I Change At Meeting details:")]
        public void PXS00201ChangeAtMeetingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00201");
            PXS00201.ATMeetingFlag.SetValue(1, table.Rows[0]["ATMeetingFlag1"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00201 I enter Proxy System Control Setup details:")]
        public void PXS00201EnterProxySystemControlSetupDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00201");
            PXS00201.ATMeetingFlag.SetValue(1, table.Rows[0]["ATMeetingFlag"]);
            PXS00201.Chairman.SetValue(1, table.Rows[0]["Chairman"]);
            PXS00201.NbrRes.SetValue(1, table.Rows[0]["NbrRes"]);
            PXS00201.SchemeMeetingInd.SetValue(1, table.Rows[0]["SchemeMeetingInd"]);
            PXS00201.InternetMeeting.SetValue(1, table.Rows[0]["InternetMeeting"]);
            if (table.Rows[0]["InternetMeeting"] == "Y")
            {
                PXS00201.AlgorithmNumber.SetValue(1, table.Rows[0]["AlgorithmNumber"]);
            }

            PXS00201.RemResOpenVotes.SetValue(1, table.Rows[0]["RemResOpenVotes"]);
            PXS00201.ClassVotesInd.SetValue(1, table.Rows[0]["ClassVotesInd"]);
            PXS00201.SameClasses.SetValue(1, table.Rows[0]["SameClasses"]);
            PXS00201.DirectVotingInd.SetValue(1, table.Rows[0]["DirectVotingInd"]);
            PXS00201.ProcessingCutoff.SetValue(1, table.Rows[0]["ProcessingCutoff"]);
            PXS00201.ManualProcessCutOff.SetValue(1, table.Rows[0]["ManualProcessCutOff"]);
            PXS00201.NomNotPresent.SetValue(1, table.Rows[0]["NomNotPresent"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00202 I enter Proxy System Control Setup details:")]
        public void PXS00202EnterProxySystemControlSetupDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00202");
            PXS00202.SpecialCondInd.ValidateFieldValue(1, table.Rows[0]["SpecialCondInd"]);
            if (table.Rows[0]["SpecialCondInd"] == "Y")
            {
                PXS00202.MinBalanceYN.SetValue(1, table.Rows[0]["MinBalanceYN"]);
                PXS00202.RunUpto.SetValue(1, table.Rows[0]["RunUpto"]);
                PXS00202.MaxVotesYN.SetValue(1, table.Rows[0]["MaxVotesYN"]);
                PXS00202.MaxVotes.SetValue(1, table.Rows[0]["MaxVotes"]);
                PXS00202.GroupApply.SetValue(1, table.Rows[0]["GroupApply"]);
            }

            PXS00202.SpecialCalcInd.ValidateFieldValue(1, table.Rows[0]["SpecialCalcInd"]);
            if (table.Rows[0]["SpecialCalcInd"] == "Y")
            {
                PXS00202.AllCalc.SetValue(1, table.Rows[0]["AllCalc"]);
            }

            PXS00202.CorpRepNotingNum.SetValue(1, table.Rows[0]["CorpRepNotingNum"]);
            PXS00202.PreEncodedNotInp.SetValue(1, table.Rows[0]["PreEncodedNotInp"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00203 I enter Proxy System Control Setup details:")]
        public void PXS00203EnterProxySystemControlSetupDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00203");
            PXS00203.IntermediaryOnlineProcessing.SetValue(1, table.Rows[0]["IntermediaryOnlineProcessing"]);
            if (table.Rows[0]["IntermediaryOnlineProcessing"] != "N")
            {
                PXS00203.ImoOverVoteProcessingCutOff.SetValue(1, table.Rows[0]["ImoOverVoteProcessingCutOff"]);
                PXS00203.ImoCosmosCompanyMeetingID.SetValue(1, table.Rows[0]["ImoCosmosCompanyMeetingID"]);
            }
            PXS00203.ActivateAutoScheduledJobs.SetValue(1, table.Rows[0]["ActivateAutoScheduledJobs"]);
            if (table.Rows[0]["ActivateAutoScheduledJobs"] == "Y")
            {
                PXS00203.ActivationFromDateRange.SetValue(1, table.Rows[0]["ActivationFromDateRange"]);
                PXS00203.ActivationTODateRange.SetValue(1, table.Rows[0]["ActivationTODateRange"]);

                PXS00203.AutoTopReport.SetValue(1, table.Rows[0]["AutoTopReport"]);
                if (table.Rows[0]["AutoTopReport"] == "Y")
                {
                    PXS00203.CutoffPoint.SetValue(1, table.Rows[0]["CutoffPoint"]);
                    PXS00203.EntitlementClasses.SetValue(1, table.Rows[0]["EntitlementClasses1"]);
                    PXS00203.EntitlementClasses.SetValue(2, table.Rows[0]["EntitlementClasses2"]);
                    PXS00203.EntitlementClasses.SetValue(3, table.Rows[0]["EntitlementClasses3"]);
                    PXS00203.EntitlementClassGroups.SetValue(1, table.Rows[0]["EntitlementClassGroups1"]);
                    PXS00203.EntitlementClassGroups.SetValue(2, table.Rows[0]["EntitlementClassGroups2"]);
                    PXS00203.EntitlementClassGroups.SetValue(3, table.Rows[0]["EntitlementClassGroups3"]);
                    PXS00203.EntitlementOtherClass.SetValue(1, table.Rows[0]["EntitlementOtherClass1"]);
                    PXS00203.EntitlementOtherClass.SetValue(2, table.Rows[0]["EntitlementOtherClass2"]);
                    PXS00203.EntitlementOtherClass.SetValue(3, table.Rows[0]["EntitlementOtherClass3"]);
                    PXS00203.AutoPalsavReport.SetValue(1, table.Rows[0]["AutoPalsavReport"]);
                }
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00211 I enter Proxy System Control Setup details:")]
        public void PXS00211EnterProxySystemControlSetupDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00211");
            PXS00211.BriefDesc.SetValue(1, table.Rows[0]["BriefDesc"]);

            PXS00211.LongDesc.SetValue(1, table.Rows[0]["LongDesc"]);
            PXS00211.VotingFrmDesc.SetValue(1, table.Rows[0]["VotingFrmDesc"]);
            PXS00211.ClassCode.SetValue(1, table.Rows[0]["ClassCode"]);
            PXS00211.ClassGroup.SetValue(1, table.Rows[0]["ClassGroup"]);
            PXS00211.ExcClass.SetValue(1, table.Rows[0]["ExcClass"]);

            PXS00211.OtherReqdInd.SetValue(1, table.Rows[0]["OtherReqdInd"]);
            if (table.Rows[0]["OtherReqdInd"] == "Y")
            {
                PXS00211.ClassCodeB.SetValue(1, table.Rows[0]["ClassCodeB1"]);
                PXS00211.ClassCodeB.SetValue(2, table.Rows[0]["ClassCodeB2"]);
                PXS00211.ClassCodeB.SetValue(3, table.Rows[0]["ClassCodeB3"]);
                PXS00211.ExcClassB.SetValue(1, table.Rows[0]["ExcClassB1"]);
                PXS00211.ExcClassB.SetValue(2, table.Rows[0]["ExcClassB2"]);
                PXS00211.ExcClassB.SetValue(3, table.Rows[0]["ExcClassB3"]);
                PXS00211.Rounding.SetValue(1, table.Rows[0]["Rounding"]);
            }

            PXS00211.ExcClassCodesInd.ValidateFieldValue(1, table.Rows[0]["ExcClassCodesInd"]);
            if (table.Rows[0]["ExcClassCodesInd"] == "Y")
            {
                PXS00211.ExcClassCode.SetValue(1, table.Rows[0]["ExcClassCode"]);
            }

            //PXS00211.RemResTickBox.SetValue(1, table.Rows[0]["RemResTickBox"]);
            PXS00211.NomOveRes.SetValue(1, table.Rows[0]["NomOveRes"]);
            if (PXS00211.UnitsUpdMethod.GetValue() != "A")
            {
                PXS00211.UnitsUpdMethod.SetValue(1, table.Rows[0]["UnitsUpdMethod"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00301 I Change Poll Resolution Update:")]
        public void PXS00301ChangePollResolutionUpdate(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00102");
            PXS00102.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            PXS00301.Consolidate.SetValue(1, table.Rows[0]["Consolidate"]);
            PXS00301.R1.SetValue(1, table.Rows[0]["R1"]);
            PXS00301.R2.SetValue(1, table.Rows[0]["R2"]);
            PXS00301.C1.SetValue(1, table.Rows[0]["C1"]);
            PXS00301.C2.SetValue(1, table.Rows[0]["C2"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00500 I run Post Close Registration Report:")]
        public void PXS00500CloseRegistrationReport(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00500");
            PXS00500.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            PXS00500.ReportType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            if (table.Rows[0]["ReportType"] != "T")
            {
                PXS00500.PrintHolderID.SetValue(1, table.Rows[0]["PrintHolderID"]);
                PXS00500.ReportSeq.SetValue(1, table.Rows[0]["ReportSeq"]);
                PXS00500.VotingLevel.SetValue(1, table.Rows[0]["VotingLevel"]);
            }
            PXS00500.Res1to20Dsc.SetValue(1, table.Rows[0]["Res1to20Dsc1"]);
            PXS00500.Res1to20Dsc.SetValue(2, table.Rows[0]["Res1to20Dsc2"]);
            if (PXS00500.VoteInd.Exists() == true)
            {
                PXS00500.VoteInd.SetValue(1, table.Rows[0]["VoteInd"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS00500 I run Pre Close Registration Report:")]
        public void PXS00500RunPreCloseRegistrationReport(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00500");
            PXS00500.ReportType.SetValue(1, table.Rows[0]["ReportType"]);
            PXS00500.ReportType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            if (table.Rows[0]["ReportType"] != "T")
            {
                PXS00500.PrintHolderID.SetValue(1, table.Rows[0]["PrintHolderID"]);
                PXS00500.ReportSeq.SetValue(1, table.Rows[0]["ReportSeq"]);
                PXS00500.VotingLevel.SetValue(1, table.Rows[0]["VotingLevel"]);
            }
            PXS00500.Res1to20Dsc.SetValue(1, table.Rows[0]["Res1to20Dsc1"]);
            PXS00500.Res1to20Dsc.SetValue(2, table.Rows[0]["Res1to20Dsc2"]);
            //if (PXS00500.VoteInd.Exists() == true)
            //{
            //    PXS00500.VoteInd.SetValue(1, table.Rows[0]["VoteInd"]);
            //}

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS01500 I Add Attendee list details:")]
        public void PXS01500AddAttendeeListDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS01500");
            PXS01500.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            switch (table.Rows[0]["Selection"].ToLower())
            {
                case "set":
                    WinFormsTestSteps.ExpectToBeInTheScreen("PXS01503");
                    PXS01503.AttendeeNum.SetValue(1, table.Rows[0]["AttendeeNum"]);
                    PXS01503.HolderName.SetValue(1, table.Rows[0]["HolderName"]);
                    break;

                case "net":
                    WinFormsTestSteps.ExpectToBeInTheScreen("PXS01502");
                    PXS01502.AttendeeNumber.SetValue(1, table.Rows[0]["AttendeeNumber"]);
                    PXS01502.AttendeeName.SetValue(1, table.Rows[0]["AttendeeName"]);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    PXS01507.Action.SetValue("U");

                    break;

                case "vet":
                    WinFormsTestSteps.ExpectToBeInTheScreen("PXS01501");
                    PXS01501.AttendeeNum.SetValue(1, table.Rows[0]["AttendeeNum"]);
                    PXS01501.AttendeeName.SetValue(1, table.Rows[0]["AttendeeName"]);
                    break;

                default:
                    break;
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS01500");
            //Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS01500 I continue with the following details:")]
        public void PXS01500ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS01500");
            PXS01500.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS01512 I Delete Entry:")]
        public void PXS01512DeleteEntry(Table table)
        {
            //ExpectToBeInTheScreen("PXS01500");
            //PXS01500.Selection.SetValue(1, table.Rows[0]["Selection"]);
            //Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS01512");
            PXS01512.AttendeeNumber.SetValue(1, table.Rows[0]["AttendeeNumber"]);
            PXS01512.AttendeeType.SetValue(1, table.Rows[0]["AttendeeType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS01513");
            PXS01513.Confirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS02001 I continue with the following details:")]
        public void PXS02001ContinueWithThefollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS02001");
            PXS02001.RefNum.SetValue(1, table.Rows[0]["RefNum"]);
            PXS02001.ProxyType.SetValue(1, table.Rows[0]["ProxyType"]);
            PXS02001.Holder.SetValue(1, table.Rows[0]["Holder"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            if (table.Rows[0]["ProxyType"] == "FAB")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("PXS02002");
                PXS02002.SPFlag.SetValue(1, table.Rows[0]["SPFlag"]);
                PXS02002.SPFlag.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                if (table.Rows[0]["SPFlag"] == "P")
                {
                    PXS02002.PerA.SetValue(1, table.Rows[0]["PerA"]);
                }
                PXS02002.Noma.SetValue(1, table.Rows[0]["Noma"]);
                PXS02002.Nomb.SetValue(1, table.Rows[0]["Nomb"]);
                PXS02002.FailingA.SetValue(1, table.Rows[0]["FailingA"]);
                PXS02002.R01.SetValue(1, table.Rows[0]["R01"]);
                PXS02002.R02.SetValue(1, table.Rows[0]["R02"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            else if (table.Rows[0]["ProxyType"] == "UNFA")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("PXS02003");
                PXS02003.Noma.SetValue(1, table.Rows[0]["Noma"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("PXS02501");
                PXS02501.For01.SetValue(1, table.Rows[0]["For01"]);
                PXS02501.For02.SetValue(1, table.Rows[0]["For02"]);
                PXS02501.Against01.SetValue(1, table.Rows[0]["Against01"]);
                PXS02501.Against02.SetValue(1, table.Rows[0]["Against02"]);
                PXS02501.OpenTicked01.SetValue(1, table.Rows[0]["OpenTicked01"]);
                PXS02501.OpenTicked02.SetValue(1, table.Rows[0]["OpenTicked02"]);
                PXS02501.Abstain01.SetValue(1, table.Rows[0]["Abstain01"]);
                PXS02501.Abstain02.SetValue(1, table.Rows[0]["Abstain02"]);
                PXS02501.Exclude01.SetValue(1, table.Rows[0]["Exclude01"]);
                PXS02501.Exclude02.SetValue(1, table.Rows[0]["Exclude02"]);
                PXS02501.ClassEntitlement.ValidateFieldValue(1, table.Rows[0]["ClassEntitlement"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() == "PXS02504")
                {
                    PXS02504.ResDesc.ValidateFieldValue(1, table.Rows[0]["ResDesc1"]);
                    PXS02504.ResDesc.ValidateFieldValue(2, table.Rows[0]["ResDesc2"]);
                    PXS02504.ClassEntitlement.ValidateFieldValue(1, table.Rows[0]["ClassEntitlement1"]);
                    PXS02504.ClassEntitlement.ValidateFieldValue(2, table.Rows[0]["ClassEntitlement2"]);
                    PXS02504.TotalEntered.ValidateFieldValue(1, table.Rows[0]["TotalEntered1"]);
                    PXS02504.TotalEntered.ValidateFieldValue(2, table.Rows[0]["TotalEntered2"]);
                    PXS02504.Difference.ValidateFieldValue(1, table.Rows[0]["Difference1"]);
                    PXS02504.Difference.ValidateFieldValue(2, table.Rows[0]["Difference2"]);
                    PXS02504.Description.ValidateFieldValue(1, table.Rows[0]["Description1"]);
                    PXS02504.Description.ValidateFieldValue(2, table.Rows[0]["Description2"]);
                    PXS02504.Confirm.SetValue(1, table.Rows[0]["Confirm"]);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                }
            }
        }

        /// <param name="table">data table</param>
        [When(@"In PXS02101 I Update Proxy transaction maintenance details:")]
        public void PXS02101UpdateProxyTransactionMaintenanceDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS02101");
            PXS02101.RefNum.SetValue(1, table.Rows[0]["RefNum"]);
            PXS02101.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            PXS02101.Action.SetValue(1, table.Rows[0]["Action"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if (table.Rows[0]["Action"] == "C")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("PXS02102");
                PXS02102.SPFlag.SetValue(1, table.Rows[0]["SPFlag"]);
                PXS02102.Noma.SetValue(1, table.Rows[0]["Noma"]);
                PXS02102.PerA.SetValue(1, table.Rows[0]["PerA"]);
                PXS02102.Nomb.SetValue(1, table.Rows[0]["Nomb"]);
                PXS02102.FailingA.SetValue(1, table.Rows[0]["FailingA"]);
                PXS02102.R01.SetValue(1, table.Rows[0]["R01"]);
                PXS02102.R02.SetValue(1, table.Rows[0]["R02"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            else
            {
                PXS02102.Confirm.SetValue("Y");
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS03600 I Add Poll Voting Entry:")]
        public void PXS03600AddPollVotingEntry(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS00102");
            PXS00102.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS03600");
            PXS03600.EntryType.SetValue(1, table.Rows[0]["EntryType"]);
            PXS03600.SearchType.SetValue(1, table.Rows[0]["SearchType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            if (table.Rows[0]["SearchType"] == "N")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("PXS03701");
                PXS03701.AtdNumber.SetValue(1, table.Rows[0]["AtdNumber"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("PXS03702");
            }
            else
            {
                PXS03601.Action.SetValue(1, table.Rows[0]["Action"]);
                PXS03601.Action.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                PXS03601.Search.SetValue(1, table.Rows[0]["Search"]);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                PXS03601.Action.SetValue("U");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            PXS03702.For01.SetValue(1, table.Rows[0]["For01"]);
            PXS03702.For02.SetValue(1, table.Rows[0]["For02"]);
            PXS03702.Against01.SetValue(1, table.Rows[0]["Against01"]);
            PXS03702.Against02.SetValue(1, table.Rows[0]["Against02"]);
            PXS03702.Abstain01.SetValue(1, table.Rows[0]["Abstain01"]);
            PXS03702.Abstain02.SetValue(1, table.Rows[0]["Abstain02"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS03800 I continue with the following details:")]
        public void PXS03800ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS03800");
            PXS03800.SearchType.SetValue(1, table.Rows[0]["SearchType"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS03801 I continue with the following details:")]
        public void PXS03801ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS03801");
            PXS03801.Action.SetValue(1, table.Rows[0]["Action"]);
            PXS03801.Action.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            PXS03801.Search.SetValue(1, table.Rows[0]["Search"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            PXS03801.Action.SetValue(1, table.Rows[0]["Action1"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS03802");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In PXS04001 I verify the Proxy Holder Vote Details as:")]
        public void PXS04001VerifyTheProxyHolderVoteDetailsAs(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS04001");
            PXS04001.Action.SetValue(1, table.Rows[0]["Action"]);
            PXS04001.Action.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            PXS04001.HolderSearchKey.SetValue(1, table.Rows[0]["HolderSearchKey"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS04001");
            PXS04001.NomPersonA.ValidateFieldValue(1, table.Rows[0]["NomPersonA"]);
            if (PXS04001.NomPersonB.Exists() == true)
            {
                PXS04001.NomPersonB.ValidateFieldValue(1, table.Rows[0]["NomPersonB"]);
            }
            if (PXS04001.PercentA.Exists() == true)
            {
                PXS04001.PercentA.ValidateFieldValue(1, table.Rows[0]["PercentA"]);
            }

            PXS04001.ResolutionLine.ValidateFieldValue(4, table.Rows[0]["ResolutionLine1"]);
            PXS04001.ResolutionLine.ValidateFieldValue(5, table.Rows[0]["ResolutionLine2"]);
        }

        /// <param name="table">data table</param>
        [When(@"In PXS04501 I verify Proxy Attendee details:")]
        public void PXS04501VerifyProxyAttendeeDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("PXS04501");
            PXS04501.Action.SetValue(1, table.Rows[0]["Action"]);
            PXS04501.Action.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            PXS04501.HolderSearchKey.SetValue(1, table.Rows[0]["HolderSearchKey"]);
            PXS04501.HolderSearchHin.SetValue(1, table.Rows[0]["HolderSearchHin"]);
            PXS04501.SearchNomCode.SetValue(1, table.Rows[0]["SearchNomCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            PXS04501.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["HolderIdentifier"]);
            PXS04501.StatusLit.ValidateFieldValue(1, table.Rows[0]["StatusLit"]);
            PXS04501.NomPersonCode.ValidateFieldValue(1, table.Rows[0]["NomPersonCode"]);
            PXS04501.AtdType.ValidateFieldValue(1, table.Rows[0]["AtdType"]);
            PXS04501.AtdNumber.ValidateFieldValue(1, table.Rows[0]["AtdNumber"]);
            PXS04501.GroupCode.ValidateFieldValue(1, table.Rows[0]["GroupCode"]);
            PXS04501.PresentYN.ValidateFieldValue(1, table.Rows[0]["PresentYN"]);
            PXS04501.ResolutionLine.ValidateFieldValue(1, table.Rows[0]["ResolutionLine1"]);
            PXS04501.ResolutionLine.ValidateFieldValue(2, table.Rows[0]["ResolutionLine2"]);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }
    }
}