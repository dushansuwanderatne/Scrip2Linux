using System;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class EnquirySystemSubtests
    {
        public static string Reference;

        public EnquirySystemSubtests()
        {
            this.WinFormsTestSteps = new WinFormsTestSteps();
        }

        public WinFormsTestSteps WinFormsTestSteps { get; set; }

        [Then(@"In ENS01001 class code filter display as ""(.*)""")]
        public void ClassCodeFilterDisplay(string Filter)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.RestrictClassInfo.ValidateFieldValue(Filter);
        }

        [Then(@"In ENS01090 class code filter display as ""(.*)""")]
        public void ClassCodeFilterDisplayAs(string ClassFilter)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01090");
            ENS01090.RestrictClassInfo.ValidateFieldValue(ClassFilter);
        }

        /// <param name="table">data table</param>
        [Then(@"In ENS01012 I should see Register details as:")]
        public void ENS01013ShouldSeeRegisterDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01012");
            ENS01012.CertificateLine.ValidateFieldValueContains(1, table.Rows[0]["CertificateLine1"]);

            string SystemInfoFree4 = ENS01012.SystemInfoFree4.GetValue();
            String SystemDate = SystemInfoFree4.Substring(SystemInfoFree4.Length - 10).Replace("-", "/").Replace("2016", "16").Replace("2015", "15");

            table.Rows[0]["CertificateLine2"] = table.Rows[0]["CertificateLine2"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine3"] = table.Rows[0]["CertificateLine3"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine4"] = table.Rows[0]["CertificateLine4"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine5"] = table.Rows[0]["CertificateLine5"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine6"] = table.Rows[0]["CertificateLine6"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine7"] = table.Rows[0]["CertificateLine7"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine8"] = table.Rows[0]["CertificateLine8"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine9"] = table.Rows[0]["CertificateLine9"].Replace("00/00/00", SystemDate);
            table.Rows[0]["CertificateLine10"] = table.Rows[0]["CertificateLine10"].Replace("00/00/00", SystemDate);

            ENS01012.CertificateLine.ValidateFieldValueContains(2, table.Rows[0]["CertificateLine2"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(3, table.Rows[0]["CertificateLine3"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(4, table.Rows[0]["CertificateLine4"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(5, table.Rows[0]["CertificateLine5"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(6, table.Rows[0]["CertificateLine6"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(7, table.Rows[0]["CertificateLine7"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(8, table.Rows[0]["CertificateLine8"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(9, table.Rows[0]["CertificateLine9"]);
            ENS01012.CertificateLine.ValidateFieldValueContains(10, table.Rows[0]["CertificateLine10"]);
        }

        /// <param name="table">data table</param>
        [Then(@"In ENS01013 I should see Register details as:")]
        public void ENS01013ShouldSeeRegisterDetailsAs(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01013");
            ENS01013.CertificateLine.ValidateFieldValue(1, table.Rows[0]["CertificateLine1"]);
            ENS01013.CertificateLine.ValidateFieldValue(2, table.Rows[0]["CertificateLine2"]);
            ENS01013.CertificateLine.ValidateFieldValue(3, table.Rows[0]["CertificateLine3"]);
            ENS01013.CertificateLine.ValidateFieldValue(4, table.Rows[0]["CertificateLine4"]);
            ENS01013.CertificateLine.ValidateFieldValue(5, table.Rows[0]["CertificateLine5"]);
            ENS01013.CertificateLine.ValidateFieldValue(6, table.Rows[0]["CertificateLine6"]);
            ENS01013.CertificateLine.ValidateFieldValue(7, table.Rows[0]["CertificateLine7"]);
            ENS01013.CertificateLine.ValidateFieldValue(8, table.Rows[0]["CertificateLine8"]);
            ENS01013.CertificateLine.ValidateFieldValue(9, table.Rows[0]["CertificateLine9"]);
            ENS01013.CertificateLine.ValidateFieldValue(10, table.Rows[0]["CertificateLine10"]);
        }

        [Then(@"In ENS01014 I should see Balance Transaction as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENS01014ShouldSeeBalanceTransaction(string SBN, string Line1, string Line2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01014");
            ENS01014.BrokerOff.ValidateFieldValue(SBN);
            ENS01014.Lines6.ValidateFieldValue(1, Line1);
            ENS01014.Lines6.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENS01017 I should see payment details as below:")]
        public void ENS01017IShouldSeePaymentDetailsAsBelow(Table data)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01017");
            string BSB = data.GetData("BSB");
            string AccountNumber = data.GetData("Account Number");
            string AccountName = data.GetData("Account Name");

            ENS01017.ExtraBankCode.ValidateFieldValue(BSB);
            ENS01017.ExtraAccountNO.ValidateFieldValue(AccountNumber);
            ENS01017.ExtraAccountName.ValidateFieldValue(AccountName);
        }

        /// <param name="table">data table</param>
        [Then(@"In ENS01035 I should see Static History as:")]
        public void ENS01035ShouldSeeStaticHistory(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01035");
            ENS01035.TranTypeCode.ValidateFieldValueContains(table.Rows[0]["TranTypeCode"]);
            ENS01035.TranTypeDesc.ValidateFieldValueContains(table.Rows[0]["TranTypeDesc"]);

            Reference = ENS01035.Reference.GetValue(4);
        }

        [Then(@"In ENS01042 I should see Certificate Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENS01042ShouldSeeCertificateDetails(string HIN, string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10, string Line11, string Line12, string Line13)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01042");
            ENS01042.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01042.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01042.CertificateLine.ValidateFieldValueContains(2, Line2);
            ENS01042.CertificateLine.ValidateFieldValueContains(3, Line3);
            ENS01042.CertificateLine.ValidateFieldValueContains(4, Line4);
            ENS01042.CertificateLine.ValidateFieldValueContains(5, Line5);
            ENS01042.CertificateLine.ValidateFieldValueContains(6, Line6);
            ENS01042.CertificateLine.ValidateFieldValueContains(7, Line7);
            ENS01042.CertificateLine.ValidateFieldValueContains(8, Line8);
            ENS01042.CertificateLine.ValidateFieldValueContains(9, Line9);
            ENS01042.CertificateLine.ValidateFieldValueContains(10, Line10);
            ENS01042.CertificateLine.ValidateFieldValueContains(11, Line11);
            ENS01042.CertificateLine.ValidateFieldValueContains(12, Line12);
            ENS01042.CertificateLine.ValidateFieldValueContains(13, Line13);
        }

        [Then(@"In ENS0106E I should see Chess Static Rejection Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENS0106EShouldSeeChessStaticRejectionDetails(string Broker, string TradeRef, string RejectReason, string TranType, string TranTypeDesc, string Run, string Trans, string BusDate, string SellHIN, string SellNameAddress, string Postcode, string Email)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS0106E");
            ENS0106E.BrokerCode.ValidateFieldValue(Broker);
            ENS0106E.TradeReference.ValidateFieldValue(TradeRef);
            ENS0106E.RejectMsg.ValidateFieldValue(RejectReason);
            ENS0106E.TranTypeCode.ValidateFieldValue(TranType);
            ENS0106E.TranTypeDesc.ValidateFieldValue(TranTypeDesc);
            ENS0106E.RunNumber.ValidateFieldValue(Run);
            ENS0106E.TransNumber.ValidateFieldValue(Trans);
            ENS0106E.BusinessDate.ValidateFieldValue(BusDate);
            ENS0106E.SellHolderID.ValidateFieldValue(SellHIN);
            ENS0106E.SellAddressLine.ValidateFieldValue(SellNameAddress);
            ENS0106E.SellPostcode.ValidateFieldValue(Postcode);
            ENS0106E.EmailAddressStd.ValidateFieldValue(Email);
        }

        [When(@"In ENS01082 I Enter Extract reference as ""(.*)""")]
        public void ENS01082EnterExtractReference(string Reference)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01082");
            ENS01082.Reference.SetValue(Reference);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENS04030 enter search string as ""(.*)"" ""(.*)""")]
        public void ENS04030EnterSearchString(string Selection, string SearchString)
        {
            switch (Selection.ToLower())
            {
                case "f":
                    ENS04030.Continue.SetValue(Selection);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "s":
                    ENS04030.Continue.SetValue(Selection);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    ENS04030.SearchClass.SetValue(SearchString);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    break;
            }
        }

        [When(@"In ENS04050 enter search string as ""(.*)"" ""(.*)""")]
        public void ENS04050EnterSearchString(string Selection, string SearchString)
        {
            switch (Selection.ToLower())
            {
                case "f":
                    ENS04050.Continue.SetValue(Selection);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "s":
                    ENS04050.Continue.SetValue(Selection);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    ENS04050.String.SetValue(SearchString);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    break;
            }
        }

        [Then(@"In ENSDIV20 I should see US Tax Details as ""(.*)""")]
        public void ENSDIVI20ShouldSeeUSTaxDetails(string Res)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV20");
            ENSDIV20.TaxResidency.ValidateFieldValue(Res);
        }

        [Then(@"I ENSESS03 I should see Plan Holder Totals as below:")]
        public void ENSESS03ShouldSeePlanHolderTotals(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS03");
            ENSESS03.HolderID.ValidateFieldValue(HIN);
            ENSESS03.SchemeCode.ValidateFieldValue(Plan);
            ENSESS03.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS03.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS03.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS03.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS03.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS03.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS03.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS03.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS03.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS03.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS03.DetailLine.ValidateFieldValue(10, Line10);
        }

        /// <param name="table">data table</param>
        [Then(@"In ENSESS11 I verify the following details:")]
        public void ENSESS11VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS11");
            ENSESS11.HolderID.ValidateFieldValue(1, table.Rows[0]["SearchName"]);
            ENSESS11.DetailLine.ValidateFieldValue(1, table.Rows[0]["DetailLine1"]);
            ENSESS11.DetailLine.ValidateFieldValue(2, table.Rows[0]["DetailLine2"]);
            ENSESS11.DetailLine.ValidateFieldValue(3, table.Rows[0]["DetailLine3"]);
            ENSESS11.DetailLine.ValidateFieldValue(4, table.Rows[0]["DetailLine4"]);
            ENSESS11.DetailLine.ValidateFieldValue(5, table.Rows[0]["DetailLine5"]);
            ENSESS11.DetailLine.ValidateFieldValue(6, table.Rows[0]["DetailLine6"]);
            ENSESS11.DetailLine.ValidateFieldValue(7, table.Rows[0]["DetailLine7"]);
            ENSESS11.DetailLine.ValidateFieldValue(8, table.Rows[0]["DetailLine8"]);
            ENSESS11.DetailLine.ValidateFieldValue(9, table.Rows[0]["DetailLine9"]);
            ENSESS11.DetailLine.ValidateFieldValue(10, table.Rows[0]["DetailLine10"]);
        }

        [Then(@"In ENSESS18 I should see Plan Holder Totals as below:")]
        public void ENSESS18ShouldSeePlanHolderTotals(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("Plan Desc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS18");
            ENSESS18.HolderID.ValidateFieldValue(HIN);
            ENSESS18.SchemeCode.ValidateFieldValue(Plan);
            ENSESS18.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS18.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS18.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS18.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS18.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS18.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS18.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS18.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS18.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS18.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS18.DetailLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"In ENSESS19 I should see Loan Balance details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSESS19ShouldSeeLoanBalanceDetails(string Line1, string Line2, string Line3, string Line4, string Line5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS19");
            ENSESS19.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS19.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS19.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS19.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS19.DetailLine.ValidateFieldValue(5, Line5);
        }

        [Then(@"In ENSESS20 I should see Loan Transactions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSESS20ShouldSeeLoanTransactions(string DLine1, string DLine2, string DLine3, string DLine4, string DLine5)
        {
            ENSESS20.DetailLine.ValidateFieldValue(1, DLine1);
            string Run = WinFormsTestSteps.GetRunNumber();
            DLine2 = DLine2.Replace("7849", Run);
            ENSESS20.DetailLine.ValidateFieldValue(2, DLine2);
            ENSESS20.DetailLine.ValidateFieldValue(3, DLine3);
            ENSESS20.DetailLine.ValidateFieldValue(4, DLine4);
            ENSESS20.DetailLine.ValidateFieldValue(5, DLine5);
        }

        [Then(@"In ENSESS22 I should see holder extra details as below:")]
        public void ENSESS22ShouldSeeHolderExtraDetails(Table data)
        {
            string ForfeitureType = data.GetData("ForfeitureType");
            string ForfeitureStartDate = data.GetData("ForfeitureStartDate");
            string ForfeitureEndDate = data.GetData("ForfeitureEndDate");
            string ForfeiturePercentage = data.GetData("ForfeiturePercentage");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS22");
            ENSESS22.Ensess22ForfeitureType1.ValidateFieldValue(ForfeitureType);
            ENSESS22.Ensess22ForfStartDate1.ValidateFieldValue(ForfeitureStartDate);
            ENSESS22.Ensess22ForfEndDate1.ValidateFieldValue(ForfeitureEndDate);
            ENSESS22.Ensess22ForfPercentage1.ValidateFieldValue(ForfeiturePercentage);
        }

        [Then(@"In ENSESS31 I should see Updated Leaver Processing details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSESS31ShouldSeeUpdatedLeaverProcessingDetails(string Plan, string PlanDesc, string Line1, string Line2, string Line3)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS31");
            ENSESS31.SchemeCode.ValidateFieldValue(Plan);
            ENSESS31.SchemeName.ValidateFieldValue(PlanDesc);
            string Run = WinFormsTestSteps.GetRunNumber();
            Line1 = Line1.Replace("7835", Run);
            Line2 = Line2.Replace("7835", Run);
            Line3 = Line3.Replace("7835", Run);

            ENSESS31.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS31.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS31.DetailLine.ValidateFieldValue(3, Line3);
        }

        [Then(@"In ENSESS33 I should see ESS Static Transactions as below:")]
        public void ENSESS33IshouldSeeESSStaticTransactions(Table data)
        {
            string Run = data.GetData("Run");
            string Tran = data.GetData("Tran");
            string Sequesnce = data.GetData("Sequesnce");
            string TransactionType = data.GetData("TransactionType");
            string TransactionDesc = data.GetData("TransactionDesc");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Postcode = data.GetData("Postcode");
            string HIN = data.GetData("HIN");
            string EmployeeID = data.GetData("EmployeeID");
            string EmployeeStatus = data.GetData("EmployeeStatus");
            string PayrollID = data.GetData("PayrollID");
            string EmpStatusDesc = data.GetData("EmpStatusDesc");
            string LeaverCode = data.GetData("LeaverCode");
            string LeavercodeDesc = data.GetData("LeavercodeDesc");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Reg = data.GetData("Reg");
            string RegDesc = data.GetData("RegDesc");
            string Cert = data.GetData("Cert");
            string VertingDetailsLine1 = data.GetData("VertingDetailsLine1");
            string VertingDetailsLine2 = data.GetData("VertingDetailsLine2");

            ENSESS33.RunNumber.ValidateFieldValue(Run);
            ENSESS33.TransNumber.ValidateFieldValue(Tran);
            ENSESS33.SequenceNumber.ValidateFieldValue(Sequesnce);
            ENSESS33.TranTypeCode.ValidateFieldValue(TransactionType);
            ENSESS33.TranTypeDesc.ValidateFieldValue(TransactionDesc);
            ENSESS33.NameAddress.ValidateFieldValue(1, Name);
            ENSESS33.NameAddress.ValidateFieldValue(2, Address1);
            ENSESS33.NameAddress.ValidateFieldValue(3, Address2);
            ENSESS33.Postcode.ValidateFieldValue(Postcode);
            ENSESS33.HolderID.ValidateFieldValue(HIN);
            ENSESS33.EmployeeNbr.ValidateFieldValue(EmployeeID);
            ENSESS33.PayrollID.ValidateFieldValue(PayrollID);
            ENSESS33.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            ENSESS33.EmployeeStatusDesc.ValidateFieldValue(EmpStatusDesc);
            ENSESS33.LeaverCode.ValidateFieldValue(LeaverCode);
            ENSESS33.LeaverCodeDesc.ValidateFieldValue(LeavercodeDesc);
            ENSESS33.SchemeCode.ValidateFieldValue(Plan);
            ENSESS33.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS33.RegisterCode.ValidateFieldValue(Reg);
            ENSESS33.RegisterDesc.ValidateFieldValue(RegDesc);
            ENSESS33.CertIdentifier.ValidateFieldValue(Cert);
            ENSESS33.DetailLine.ValidateFieldValue(1, VertingDetailsLine1);
            ENSESS33.DetailLine.ValidateFieldValue(2, VertingDetailsLine2);
        }

        [Then(@"In ENSESS40 I should see Event History Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSESS40ShouldSeeEventHistoryDetails(string ClassCode, string SchemeName, string Line1, string Line2, string Line3, string Line4, string Line5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS40");
            ENSESS40.SchemeCode.ValidateFieldValue(ClassCode);
            ENSESS40.SchemeName.ValidateFieldValue(SchemeName);
            ENSESS40.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS40.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS40.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS40.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS40.DetailLine.ValidateFieldValue(5, Line5);
        }

        [Then(@"In ENSESS43 I should see Static Transactions as below:")]
        public void ENSESS43ShouldSeeStaticTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string EventType = data.GetData("EventType");
            string EventCode = data.GetData("EventCode");
            string EventDesc = data.GetData("EventDesc");
            string Register = data.GetData("Register");
            string RegisterType = data.GetData("RegisterType");
            string Certificate = data.GetData("Certificate");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS43");
            ENSESS43.HolderID.ValidateFieldValue(HIN);
            ENSESS43.SchemeCode.ValidateFieldValue(Plan);
            ENSESS43.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS43.EventType.ValidateFieldValue(EventType);
            ENSESS43.EventCode.ValidateFieldValue(EventCode);
            ENSESS43.EventDesc.ValidateFieldValue(EventDesc);
            ENSESS43.RegisterCode.ValidateFieldValue(Register);
            ENSESS43.RegisterType.ValidateFieldValue(RegisterType);
            ENSESS43.CertificateID.ValidateFieldValue(Certificate);
            ENSESS43.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS43.DetailLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENSESS47 I should see Static Transactions as below:")]
        public void ENSESS47ShouldSeeStaticTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string EventType = data.GetData("EventType");
            string EventCode = data.GetData("EventCode");
            string EventDesc = data.GetData("EventDesc");
            string EventStatus = data.GetData("EventStatus");
            string Line1 = data.GetData("Line1");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS47");
            ENSESS47.HolderID.ValidateFieldValue(HIN);
            ENSESS47.SchemeCode.ValidateFieldValue(Plan);
            ENSESS47.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS47.EventType.ValidateFieldValue(EventType);
            ENSESS47.EventCode.ValidateFieldValue(EventCode);
            ENSESS47.EventDesc.ValidateFieldValue(EventDesc);
            ENSESS47.EventStatus.ValidateFieldValue(EventStatus);
            ENSESS47.DetailLine.ValidateFieldValue(Line1);
        }

        [Then(@"In ENSESS49 I should see Static Transactions as below:")]
        public void ENSESS49ShouldSeeStaticTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string EventType = data.GetData("EventType");
            string EventCode = data.GetData("EventCode");
            string EventDesc = data.GetData("EventDesc");
            string EventStatus = data.GetData("EventStatus");
            string Line1 = data.GetData("Line1");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS49");
            ENSESS49.HolderID.ValidateFieldValue(HIN);
            ENSESS49.SchemeCode.ValidateFieldValue(Plan);
            ENSESS49.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS49.EventType.ValidateFieldValue(EventType);
            ENSESS49.EventCode.ValidateFieldValue(EventCode);
            ENSESS49.EventDesc.ValidateFieldValue(EventDesc);
            ENSESS49.EventStatus.ValidateFieldValue(EventStatus);
            ENSESS49.DetailLine.ValidateFieldValue(Line1);
        }

        [Then(@"In ENSESS50 I should see Static Transactions as below:")]
        public void ENSESS50ShouldSeeStaticTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Register = data.GetData("Register");
            string RegisterDesc = data.GetData("RegisterDesc");
            string Certificate = data.GetData("Certificate");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS50");
            ENSESS50.HolderID.ValidateFieldValue(HIN);
            ENSESS50.SchemeCode.ValidateFieldValue(Plan);
            ENSESS50.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS50.RegisterCode.ValidateFieldValue(Register);
            ENSESS50.RegisterDesc.ValidateFieldValue(RegisterDesc);
            ENSESS50.CertificateID.ValidateFieldValue(Certificate);
            ENSESS50.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS50.DetailLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENSESS51 I should see Event Tax Details as below:")]
        public void ENSESS51ShouldSeeEventTaxDetails(Table data)
        {
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS51");
            ENSESS51.SchemeCode.ValidateFieldValue(Plan);
            ENSESS51.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS51.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS51.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS51.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS51.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS51.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS51.DetailLine.ValidateFieldValue(6, Line6);
        }

        [Then(@"In ENSESS51 In should see Event Tax Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSESS51ShouldSeeEventTaxDetails(string ClassCode, string SchemeName, string DetailLine1, string DetailLine2, string DetailLine3, string DetailLine4, string DetailLine5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS51");
            ENSESS51.SchemeCode.ValidateFieldValue(ClassCode);
            ENSESS51.SchemeName.ValidateFieldValue(SchemeName);
            ENSESS51.DetailLine.ValidateFieldValue(1, DetailLine1);
            ENSESS51.DetailLine.ValidateFieldValue(2, DetailLine2);
            ENSESS51.DetailLine.ValidateFieldValue(3, DetailLine3);
            ENSESS51.DetailLine.ValidateFieldValue(4, DetailLine4);
            ENSESS51.DetailLine.ValidateFieldValue(5, DetailLine5);
        }

        [Then(@"In ENSESS52 I should see Event Tax Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSESS52ShouldSeeEventTaxDetails(string Plan, string PlanDesc, string Register, string RegType, string Line1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS52");
            ENSESS52.SchemeCode.ValidateFieldValue(Plan);
            ENSESS52.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS52.RegisterCode.ValidateFieldValue(Register);
            ENSESS52.RegisterType.ValidateFieldValue(RegType);
            ENSESS52.DetailLine.ValidateFieldValue(Line1);
        }

        [Then(@"In ENSESS58 I should see Event tax Details as below:")]
        public void ENSESS58ShouldSeeEventTaxDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS58");
            ENSESS58.HolderID.ValidateFieldValue(HIN);
            ENSESS58.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS58.DetailLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENS01024 I should see holder communication Methods as below:")]
        public void ENSIS01024houldSeeHolderCommunicationMethods(Table data)
        {
            string Publication1 = data.GetData("Publication1");
            string Publication1Method = data.GetData("Publication1 Method");
            string Publication2 = data.GetData("Publication2");
            string Publication2Method = data.GetData("Publication2 Method");
            string Publication3 = data.GetData("Publication3");
            string Publication3Method = data.GetData("Publication3 Method");
            string Publication4 = data.GetData("Publication4");
            string Publication4Method = data.GetData("Publication4 Method");
            string Publication5 = data.GetData("Publication5");
            string Publication5Method = data.GetData("Publication5 Method");
            string Publication6 = data.GetData("Publication6");
            string Publication6Method = data.GetData("Publication6 Method");
            string Publication7 = data.GetData("Publication7");
            string Publication7Method = data.GetData("Publication7 Method");
            string Publication8 = data.GetData("Publication8");
            string Publication8Method = data.GetData("Publication8 Method");
            string Publication9 = data.GetData("Publication9");
            string Publication9Method = data.GetData("Publication9 Method");

            ENS01024.Description.ValidateFieldValue(1, Publication1);
            ENS01024.Method.ValidateFieldValue(1, Publication1Method);
            ENS01024.Description.ValidateFieldValue(2, Publication2);
            ENS01024.Method.ValidateFieldValue(2, Publication2Method);
            ENS01024.Description.ValidateFieldValue(3, Publication3);
            ENS01024.Method.ValidateFieldValue(3, Publication3Method);
            ENS01024.Description.ValidateFieldValue(4, Publication4);
            ENS01024.Method.ValidateFieldValue(4, Publication4Method);
            ENS01024.Description.ValidateFieldValue(5, Publication5);
            ENS01024.Method.ValidateFieldValue(5, Publication5Method);
            ENS01024.Description.ValidateFieldValue(6, Publication6);
            ENS01024.Method.ValidateFieldValue(6, Publication6Method);
            ENS01024.Description.ValidateFieldValue(7, Publication7);
            ENS01024.Method.ValidateFieldValue(7, Publication7Method);
            ENS01024.Description.ValidateFieldValue(8, Publication8);
            ENS01024.Method.ValidateFieldValue(8, Publication8Method);
            ENS01024.Description.ValidateFieldValue(9, Publication9);
            ENS01024.Method.ValidateFieldValue(9, Publication9Method);
        }

        [When(@"In ENSPND01 I enter the following details as the Locate action:")]
        public void ENSPND01EnterTheFollowingDetailsAsTheLocateAction(Table data)
        {
            string Action = data.GetData("Action");
            string Step = data.GetData("Step");

            switch (Action.ToLower())
            {
                case "n":
                    ENSPND01.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    ENSPND01.SelStep.SetValue(Step);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    ENSPND01.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;
            }
        }

        [Then(@"In ENSSPLED I should see Dividend History Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSSPLEDIShouldSeeDividendHistoryPart1(string HIN, string Type, string EmpStatus, string PayrollID, string Class, string TotalUnits, string PayAccount, string Reference, string PayMethod, string BulkID, string BulkTran, string TradeDate, string SettleDate, string Price, string CostShares, string Charges, string TotalProceeds, string AmtPaid, string Commission)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSPLED");
            ENSSPLED.HolderIdentifier.ValidateFieldValue(HIN);
            ENSSPLED.HolderTypeCode.ValidateFieldValue(Type);
            ENSSPLED.EmpStatus.ValidateFieldValue(EmpStatus);
            ENSSPLED.PayrollID.ValidateFieldValue(PayrollID);
            ENSSPLED.ClassCode.ValidateFieldValue(Class);
            ENSSPLED.TotalUnits.ValidateFieldValue(TotalUnits);
            ENSSPLED.PayAccount.ValidateFieldValue(PayAccount);
            ENSSPLED.PayRefNumber.ValidateFieldValue(Reference);
            ENSSPLED.PayMethod.ValidateFieldValue(PayMethod);
            ENSSPLED.BulkID.ValidateFieldValue(BulkID);
            ENSSPLED.BulkReference.ValidateFieldValue(BulkTran);
            ENSSPLED.TradeDate.ValidateFieldValue(TradeDate);
            ENSSPLED.SettleDate.ValidateFieldValue(SettleDate);
            ENSSPLED.Price.ValidateFieldValue(Price);
            ENSSPLED.CostOFShares.ValidateFieldValue(CostShares);
            ENSSPLED.Charges.ValidateFieldValue(Charges);
            ENSSPLED.TotProceeds.ValidateFieldValue(TotalProceeds);
            ENSSPLED.AmountPaid.ValidateFieldValue(AmtPaid);
            ENSSPLED.Commission.ValidateFieldValue(Commission);
        }

        [Then(@"In ENSSPLED I should see Dividend History Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSSPLEDIShouldSeeDividendHistoryPart2(string Register1, string Register2, string Units1, string Units2, string Proceeds1, string Proceeds2, string Income1, string Income2)
        {
            ENSSPLED.RegisterCode.ValidateFieldValue(1, Register1);
            ENSSPLED.RegisterCode.ValidateFieldValue(2, Register2);
            ENSSPLED.Units.ValidateFieldValue(1, Units1);
            ENSSPLED.Units.ValidateFieldValue(2, Units2);
            ENSSPLED.Taxable.ValidateFieldValue(1, Income1);
            ENSSPLED.Taxable.ValidateFieldValue(2, Income2);
        }

        [Then(@"In ENSSTM01 I should see Static Transaction details as below:")]
        public void ENSSTM01IShouldSeeStaticTransactionDetails(Table data)
        {
            string OldName = data.GetData("OldName");
            string OldAddressLine1 = data.GetData("OldAddressLine1");
            string OldAddressLine2 = data.GetData("OldAddressLine2");
            string OldAddressLine3 = data.GetData("OldAddressLine3");
            string OldAddressLine4 = data.GetData("OldAddressLine4");
            string NewName = data.GetData("NewName");
            string NewAddressLine1 = data.GetData("NewAddressLine1");
            string NewAddressLine2 = data.GetData("NewAddressLine2");
            string NewAddressLine3 = data.GetData("NewAddressLine3");
            string NewAddressLine4 = data.GetData("NewAddressLine4");
            string OldPostcode = data.GetData("OldPostcode");
            string NewPostcode = data.GetData("NewPostcode");
            string OldGroup = data.GetData("OldGroup");
            string NewGroup = data.GetData("NewGroup");
            string OldBrokerCode = data.GetData("OldBrokerCode");
            string NewBrokerCode = data.GetData("NewBrokerCode");
            string OldAccessCode = data.GetData("OldAccessCode");
            string NewAccessCode = data.GetData("NewAccessCode");
            string OldKeyModifier = data.GetData("OldKeyModifier");
            string NewKeyModifier = data.GetData("NewKeyModifier");
            string OldVarField = data.GetData("OldVarField");
            string NewVarField = data.GetData("NewVarField");
            string OldReturnMail = data.GetData("OldReturnMail");
            string NewReturnMail = data.GetData("NewReturnMail");
            string OldAlternateID = data.GetData("OldAlternateID");
            string NewAlternateID = data.GetData("NewAlternateID");
            string OldTaxFile = data.GetData("OldTaxFile");
            string NewTaxFile = data.GetData("NewTaxFile");
            string OldBirthDay = data.GetData("OldBirthDay");
            string NewBirthDay = data.GetData("NewBirthDay");
            string OldHolderType = data.GetData("OldHolderType");
            string NewHolderType = data.GetData("NewHolderType");
            string OldTaxCode = data.GetData("OldTaxCode");
            string NewTaxCode = data.GetData("NewTaxCode");
            string OldRegister = data.GetData("OldRegister");
            string NewRegister = data.GetData("NewRegister");
            string OldABN = data.GetData("OldABN1");
            string NewABN = data.GetData("NewABN1");
            string OldDeceased = data.GetData("OldDeceased");
            string NewDeceased = data.GetData("NewDeceased");
            string NewException = data.GetData("NewException");
            string OldSuppress = data.GetData("OldSuppress");
            string NewSuppress = data.GetData("NewSuppress");
            string OldStopTrade = data.GetData("OldStopTrade");
            string NewStopTrade = data.GetData("NewStopTrade");
            string OldAReport = data.GetData("OldAReport");
            string NewAReport = data.GetData("NewAReport");
            string OldARNom = data.GetData("OldARNom");
            string NewARNom = data.GetData("NewARNom");
            string OldDivSource = data.GetData("OldDivSource");
            string NewDivSource = data.GetData("NewDivSource");
            string OldResidency = data.GetData("OldResidency");
            string NewResidency = data.GetData("NewResidency");
            string OldVarFlag1 = data.GetData("OldVarFlag1");
            string OldVarFlag2 = data.GetData("OldVarFlag2");
            string OldVarFlag3 = data.GetData("OldVarFlag3");
            string OldVarFlag4 = data.GetData("OldVarFlag4");
            string OldVarFlag5 = data.GetData("OldVarFlag5");
            string NewVarFlag1 = data.GetData("NewVarFlag1");
            string NewVarFlag2 = data.GetData("NewVarFlag2");
            string NewVarFlag3 = data.GetData("NewVarFlag3");
            string NewVarFlag4 = data.GetData("NewVarFlag4");
            string NewVarFlag5 = data.GetData("NewVarFlag5");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSTM01");

            ENSSTM01.HnaLine.ValidateFieldValue(1, OldName);
            ENSSTM01.HnaLine.ValidateFieldValue(2, OldAddressLine1);
            ENSSTM01.HnaLine.ValidateFieldValue(3, OldAddressLine2);
            ENSSTM01.HnaLine.ValidateFieldValue(4, OldAddressLine3);
            ENSSTM01.HnaLine.ValidateFieldValue(5, OldAddressLine4);

            ENSSTM01.AHnaLine.ValidateFieldValue(1, NewName);
            ENSSTM01.AHnaLine.ValidateFieldValue(2, NewAddressLine1);
            ENSSTM01.AHnaLine.ValidateFieldValue(3, NewAddressLine2);
            ENSSTM01.AHnaLine.ValidateFieldValue(4, NewAddressLine3);
            ENSSTM01.AHnaLine.ValidateFieldValue(5, NewAddressLine4);

            ENSSTM01.Postcode.ValidateFieldValue(OldPostcode);
            ENSSTM01.APostcode.ValidateFieldValue(NewPostcode);
            ENSSTM01.HolderGroupCode.ValidateFieldValue(OldGroup);
            ENSSTM01.AHldGroupCode.ValidateFieldValue(NewGroup);
            // ENSSTM01.OldBrokerCode.ValidateFieldValue(OldBrokerCode);
            ENSSTM01.ABrokerCode.ValidateFieldValue(NewBrokerCode);
            ENSSTM01.AccessCode.ValidateFieldValue(OldAccessCode);
            ENSSTM01.AAccessCode.ValidateFieldValue(NewAccessCode);
            ENSSTM01.HolderKeyModifier.ValidateFieldValue(OldKeyModifier);
            ENSSTM01.AHolderKeyModifier.ValidateFieldValue(NewKeyModifier);
            ENSSTM01.VariableField.ValidateFieldValue(OldVarField);
            ENSSTM01.AVariableField.ValidateFieldValue(NewVarField);
            ENSSTM01.MailUnclaimedDate.ValidateFieldValue(OldReturnMail);
            ENSSTM01.AMailUnclaimedDate.ValidateFieldValue(NewReturnMail);
            ENSSTM01.HolderAlternateID.ValidateFieldValue(OldAlternateID);
            ENSSTM01.AHolderAlternateID.ValidateFieldValue(NewAlternateID);
            ENSSTM01.TaxFileNumberDesc.ValidateFieldValue(OldTaxFile);
            ENSSTM01.ATfnDesc.ValidateFieldValue(NewTaxFile);
            ENSSTM01.BirthDate.ValidateFieldValue(OldBirthDay);
            ENSSTM01.ABirthDate.ValidateFieldValue(NewBirthDay);
            ENSSTM01.HolderTypeCode.ValidateFieldValue(OldHolderType);
            ENSSTM01.AHldTypeCode.ValidateFieldValue(NewHolderType);
            ENSSTM01.HolderOtherTaxCode.ValidateFieldValue(OldTaxCode);
            ENSSTM01.AHldOtherTaxCode.ValidateFieldValue(NewTaxCode);
            //ENSSTM01.OldRegister.ValidateFieldValue(OldRegister);
            ENSSTM01.AFastRegister.ValidateFieldValue(NewRegister);
            ENSSTM01.Abn.ValidateFieldValue(OldABN);
            ENSSTM01.AAbn.ValidateFieldValue(NewABN);
            ENSSTM01.HstDeceased.ValidateFieldValue(OldDeceased);
            ENSSTM01.AHstDeceased.ValidateFieldValue(NewDeceased);
            ENSSTM01.AHstException.ValidateFieldValue(NewException);
            ENSSTM01.HstSuppress.ValidateFieldValue(OldSuppress);
            ENSSTM01.AHstSuppress.ValidateFieldValue(NewSuppress);
            ENSSTM01.HstStopTrade.ValidateFieldValue(OldStopTrade);
            ENSSTM01.AHstStopTrade.ValidateFieldValue(NewStopTrade);
            ENSSTM01.HstAnnualReport.ValidateFieldValue(OldAReport);
            ENSSTM01.AHstAnnualReport.ValidateFieldValue(NewAReport);
            ENSSTM01.ARNominated.ValidateFieldValue(OldARNom);
            ENSSTM01.AARNominated.ValidateFieldValue(NewARNom);
            ENSSTM01.HstDivSournce.ValidateFieldValue(OldDivSource);
            ENSSTM01.AHstDivSournce.ValidateFieldValue(NewDivSource);
            ENSSTM01.ResidencyInd.ValidateFieldValue(OldResidency);
            ENSSTM01.AResidencyInd.ValidateFieldValue(NewResidency);
            ENSSTM01.HvfFlag.ValidateFieldValue(1, OldVarFlag1);
            ENSSTM01.AHvfFlag.ValidateFieldValue(1, NewVarFlag1);
            ENSSTM01.HvfFlag.ValidateFieldValue(2, OldVarFlag2);
            ENSSTM01.AHvfFlag.ValidateFieldValue(2, NewVarFlag2);
            ENSSTM01.HvfFlag.ValidateFieldValue(3, OldVarFlag3);
            ENSSTM01.AHvfFlag.ValidateFieldValue(3, NewVarFlag3);
            ENSSTM01.HvfFlag.ValidateFieldValue(4, OldVarFlag4);
            ENSSTM01.AHvfFlag.ValidateFieldValue(4, NewVarFlag4);
            ENSSTM01.HvfFlag.ValidateFieldValue(5, OldVarFlag5);
            ENSSTM01.AHvfFlag.ValidateFieldValue(5, NewVarFlag5);
        }

        [Then(@"In ENSSTM06 I should see Static Transaction details as below:")]
        public void ENSSTM06IShouldSeeStaticTransactionDetais(Table data)
        {
            string TranCode = data.GetData("TranCode");
            string TranDesc = data.GetData("TranDesc");
            string Run = data.GetData("Run");
            string TranNo = data.GetData("TranNo");
            string NameKey = data.GetData("NameKey");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("HolderType");
            string PostCode = data.GetData("PostCode");
            string NameAddress1 = data.GetData("NameAddress1");
            string OldExtraID = data.GetData("OldExtraID");
            string NewExtraID = data.GetData("NewExtraID");
            string OldHomePh = data.GetData("OldHomePh");
            string NewHomePh = data.GetData("NewHomePh");
            string OldWorkPh = data.GetData("OldWorkPh");
            string NewWorkPh = data.GetData("NewWorkPh");
            string OldFax = data.GetData("OldFax");
            string NewFax = data.GetData("NewFax");
            string OldMobile = data.GetData("OldMobile");
            string NewMobile = data.GetData("NewMobile");
            string OldAbn = data.GetData("OldAbn");
            string NewAbn = data.GetData("NewAbn");
            string OldEmail1 = data.GetData("OldEmail1");
            string NewEmail1 = data.GetData("NewEmail1");
            string OldReturnDate = data.GetData("OldReturnDate");
            string NewReturnDate = data.GetData("OldReturnDate");
            string OldAmlDate = data.GetData("OldAmlDate");
            string NewAmlDate = data.GetData("NewAmlDate");
            string OldAmlTime = data.GetData("OldAmlTime");
            string NewAmlTime = data.GetData("NewAmlTime");
            string OldAmlFlag1 = data.GetData("OldAmlFlag1");
            string NewAmlFlag1 = data.GetData("NewAmlFlag1");
            string OldAmlFlag2 = data.GetData("OldAmlFlag2");
            string NewAmlFlag2 = data.GetData("NewAmlFlag2");
            string OldAmlFlag3 = data.GetData("OldAmlFlag3");
            string NewAmlFlag3 = data.GetData("NewAmlFlag3");
            string OldAmlFlag4 = data.GetData("OldAmlFlag4");
            string NewAmlFlag4 = data.GetData("NewAmlFlag4");
            string OldAmlFlag5 = data.GetData("OldAmlFlag5");
            string NewAmlFlag5 = data.GetData("NewAmlFlag5");
            string OldAmlFlag6 = data.GetData("OldAmlFlag6");
            string NewAmlFlag6 = data.GetData("NewAmlFlag6");
            string OldAmlFlag7 = data.GetData("OldAmlFlag7");
            string NewAmlFlag7 = data.GetData("NewAmlFlag7");
            string OldAmlFlag8 = data.GetData("OldAmlFlag8");
            string NewAmlFlag8 = data.GetData("NewAmlFlag8");
            string OldAmlFlag9 = data.GetData("OldAmlFlag9");
            string NewAmlFlag9 = data.GetData("NewAmlFlag9");
            string OldCommMethod1 = data.GetData("OldCommMethod1");
            string NewCommMethod1 = data.GetData("NewCommMethod1");
            string OldCommMethod2 = data.GetData("OldCommMethod2");
            string NewCommMethod2 = data.GetData("NewCommMethod2");
            string OldCommMethod3 = data.GetData("OldCommMethod3");
            string NewCommMethod3 = data.GetData("NewCommMethod3");
            string OldCommMethod4 = data.GetData("OldCommMethod4");
            string NewCommMethod4 = data.GetData("NewCommMethod4");
            string OldCommMethod5 = data.GetData("OldCommMethod5");
            string NewCommMethod5 = data.GetData("NewCommMethod5");
            string OldCommMethod6 = data.GetData("OldCommMethod6");
            string NewCommMethod6 = data.GetData("NewCommMethod6");
            string OldCommMethod7 = data.GetData("OldCommMethod7");
            string NewCommMethod7 = data.GetData("NewCommMethod7");
            string OldCommMethod8 = data.GetData("OldCommMethod8");
            string NewCommMethod8 = data.GetData("NewCommMethod8");
            string OldCommMethod9 = data.GetData("OldCommMethod9");
            string NewCommMethod9 = data.GetData("NewCommMethod9");
            string OldCommMethod10 = data.GetData("OldCommMethod10");
            string NewCommMethod10 = data.GetData("NewCommMethod10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSTM06");
            ENSSTM06.TranTypeCode.ValidateFieldValue(TranCode);
            ENSSTM06.TranTypeDesc.ValidateFieldValue(TranDesc);
            ENSSTM06.RunNumber.ValidateFieldValue(Run);
            ENSSTM06.TransNumber.ValidateFieldValue(TranNo);
            ENSSTM06.HolderNameKey.ValidateFieldValue(NameKey);
            ENSSTM06.HolderIdentifier.ValidateFieldValue(HIN);
            ENSSTM06.HolderTypeCode.ValidateFieldValue(HolderType);
            ENSSTM06.Postcode.ValidateFieldValue(PostCode);
            ENSSTM06.HolderNameAddress1.ValidateFieldValue(NameAddress1);
            ENSSTM06.OldExtraID.ValidateFieldValue(OldExtraID);
            ENSSTM06.NewExtraID.ValidateFieldValue(NewExtraID);
            ENSSTM06.OldHomePH.ValidateFieldValue(OldHomePh);
            ENSSTM06.NewHomePH.ValidateFieldValue(NewHomePh);
            ENSSTM06.OldWorkPH.ValidateFieldValue(OldWorkPh);
            ENSSTM06.NewWorkPH.ValidateFieldValue(NewWorkPh);
            ENSSTM06.OldFaxNbr.ValidateFieldValue(OldFax);
            ENSSTM06.NewFaxNbr.ValidateFieldValue(NewFax);
            ENSSTM06.OldMobileNbr.ValidateFieldValue(OldMobile);
            ENSSTM06.NewMobileNbr.ValidateFieldValue(NewMobile);
            ENSSTM06.OldAbn.ValidateFieldValue(OldAbn);
            ENSSTM06.NewAbn.ValidateFieldValue(NewAbn);
            ENSSTM06.OldEmail1.ValidateFieldValue(OldEmail1);
            ENSSTM06.NewEmail1.ValidateFieldValue(NewEmail1);
            ENSSTM06.OldReturnDate.ValidateFieldValue(OldReturnDate);
            ENSSTM06.NewReturnDate.ValidateFieldValue(NewReturnDate);
            ENSSTM06.OldAmlDate.ValidateFieldValue(OldAmlDate);
            ENSSTM06.NewAmlDate.ValidateFieldValue(NewAmlDate);
            ENSSTM06.OldAmlTime.ValidateFieldValue(OldAmlTime);
            ENSSTM06.NewAmlTime.ValidateFieldValue(NewAmlTime);
            ENSSTM06.OldEWFlag.ValidateFieldValue(1, OldAmlFlag1);
            ENSSTM06.NewEWFlag.ValidateFieldValue(1, NewAmlFlag1);
            ENSSTM06.OldEWFlag.ValidateFieldValue(2, OldAmlFlag2);
            ENSSTM06.NewEWFlag.ValidateFieldValue(2, NewAmlFlag2);
            ENSSTM06.OldEWFlag.ValidateFieldValue(3, OldAmlFlag3);
            ENSSTM06.NewEWFlag.ValidateFieldValue(3, NewAmlFlag3);
            ENSSTM06.OldEWFlag.ValidateFieldValue(4, OldAmlFlag4);
            ENSSTM06.NewEWFlag.ValidateFieldValue(4, NewAmlFlag4);
            ENSSTM06.OldEWFlag.ValidateFieldValue(5, OldAmlFlag5);
            ENSSTM06.NewEWFlag.ValidateFieldValue(5, NewAmlFlag5);
            ENSSTM06.OldEWFlag.ValidateFieldValue(6, OldAmlFlag6);
            ENSSTM06.NewEWFlag.ValidateFieldValue(6, NewAmlFlag6);
            ENSSTM06.OldEWFlag.ValidateFieldValue(7, OldAmlFlag7);
            ENSSTM06.NewEWFlag.ValidateFieldValue(7, NewAmlFlag7);
            ENSSTM06.OldEWFlag.ValidateFieldValue(8, OldAmlFlag8);
            ENSSTM06.NewEWFlag.ValidateFieldValue(8, NewAmlFlag8);
            ENSSTM06.OldEWFlag.ValidateFieldValue(9, OldAmlFlag9);
            ENSSTM06.NewEWFlag.ValidateFieldValue(9, NewAmlFlag9);
            ENSSTM06.OldCommMethod.ValidateFieldValue(1, OldCommMethod1);
            ENSSTM06.NewCommMethod.ValidateFieldValue(1, NewCommMethod1);
            ENSSTM06.OldCommMethod.ValidateFieldValue(2, OldCommMethod2);
            ENSSTM06.NewCommMethod.ValidateFieldValue(2, NewCommMethod2);
            ENSSTM06.OldCommMethod.ValidateFieldValue(3, OldCommMethod3);
            ENSSTM06.NewCommMethod.ValidateFieldValue(3, NewCommMethod3);
            ENSSTM06.OldCommMethod.ValidateFieldValue(4, OldCommMethod4);
            ENSSTM06.NewCommMethod.ValidateFieldValue(4, NewCommMethod4);
            ENSSTM06.OldCommMethod.ValidateFieldValue(5, OldCommMethod5);
            ENSSTM06.NewCommMethod.ValidateFieldValue(5, NewCommMethod5);
            ENSSTM06.OldCommMethod.ValidateFieldValue(6, OldCommMethod6);
            ENSSTM06.NewCommMethod.ValidateFieldValue(6, NewCommMethod6);
            ENSSTM06.OldCommMethod.ValidateFieldValue(7, OldCommMethod7);
            ENSSTM06.NewCommMethod.ValidateFieldValue(7, NewCommMethod7);
            ENSSTM06.OldCommMethod.ValidateFieldValue(8, OldCommMethod8);
            ENSSTM06.NewCommMethod.ValidateFieldValue(8, NewCommMethod8);
            ENSSTM06.OldCommMethod.ValidateFieldValue(9, OldCommMethod9);
            ENSSTM06.NewCommMethod.ValidateFieldValue(9, NewCommMethod9);
            ENSSTM06.OldCommMethod.ValidateFieldValue(10, OldCommMethod10);
            ENSSTM06.NewCommMethod.ValidateFieldValue(10, NewCommMethod10);
        }

        [Then(@"In ENSSTM34 I should see Static Transaction details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSSTM34ShouldSeeStaticTransactionDetails(string Run, string Tran, string Date, string TranCode, string TranDesc, string Reference)
        {
            //need to add this method in Spartan Framework
            //Run = Spartan.Core.WinForms.WinFormsDriver.GetRunNumber("SYSTEM-INFO-FREE-4");
            //Tran = Spartan.Core.WinForms.WinFormsDriver.GetValue("TRANS-NUMBER");
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSTM34");
            ENSSTM34.RunNumber.ValidateFieldValue(Run);
            ENSSTM34.HldTransNumber.ValidateFieldValue(Tran);
            ENSSTM34.TranDate.ValidateFieldValue(Date);
            ENSSTM34.TranTypeCode.ValidateFieldValue(TranCode);
            ENSSTM34.TranTypeDesc.ValidateFieldValue(TranDesc);
            ENSSTM34.Reference.ValidateFieldValue(Reference);
        }

        [Then(@"In ENSSUS03 I should see Static Transaction details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSSUS03ShouldSeeStaticTransactionDetails(string Tran, string TranDesc, string OldName, string OldAddress1, string OldAddress2, string OldAddress3, string OldPostcode, string OldCountry, string OldTIN, string NewName, string NewAddress1, string NewAddress2, string NewAddress3, string NewPostcode, string NewCountry, string NewTIN)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSUS03");
            ENSSUS03.TranTypeCode.ValidateFieldValue(Tran);
            ENSSUS03.TranTypeDesc.ValidateFieldValue(TranDesc);
            ENSSUS03.OldAddrLine.ValidateFieldValue(1, OldName);
            ENSSUS03.OldAddrLine.ValidateFieldValue(2, OldAddress1);
            ENSSUS03.OldAddrLine.ValidateFieldValue(3, OldAddress2);
            ENSSUS03.OldAddrLine.ValidateFieldValue(4, OldAddress3);
            ENSSUS03.OldPostcode.ValidateFieldValue(OldPostcode);
            ENSSUS03.OldCountry.ValidateFieldValue(OldCountry);
            ENSSUS03.OldTin.ValidateFieldValue(OldTIN);
            ENSSUS03.NewAddrLine.ValidateFieldValue(1, NewName);
            ENSSUS03.NewAddrLine.ValidateFieldValue(2, NewAddress1);
            ENSSUS03.NewAddrLine.ValidateFieldValue(3, NewAddress2);
            ENSSUS03.NewAddrLine.ValidateFieldValue(4, NewAddress3);
            ENSSUS03.NewPostcode.ValidateFieldValue(NewPostcode);
            ENSSUS03.NewCountry.ValidateFieldValue(NewCountry);
            ENSSUS03.NewTin.ValidateFieldValue(NewTIN);
        }

        [When(@"In ENSTRDSH I Verify Trade History details2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSTRDSHVerifyTradeHistoryDetails(string PrefCurrency, string CurrencyDesc, string PaymentMethod1, string HolderCharges, string HolderTax, string CompanyCharges, string CompanyTax, string ReportCharges, string ReportTax, string TotalCharges, string GstTaxTotal, string BankCode, string PayeeAccountNumber, string AccountName, string RemainingBalance, string RemBalIndDesc, string TransfereeHolder, string TransfereeClass)
        {
            ENSTRDSH.CurrencyCode.ValidateFieldValue(PrefCurrency);
            ENSTRDSH.CurrencyDesc.ValidateFieldValue(CurrencyDesc);
            ENSTRDSH.PaymentMethod.ValidateFieldValue(PaymentMethod1);
            ENSTRDSH.TotalApplyHolder.ValidateFieldValue(HolderCharges);
            ENSTRDSH.GstTaxApply.ValidateFieldValue(HolderTax);
            ENSTRDSH.TotalPaidBYCoy.ValidateFieldValue(CompanyCharges);
            ENSTRDSH.GstTaxCompany.ValidateFieldValue(CompanyTax);
            ENSTRDSH.TotalReportOnly.ValidateFieldValue(ReportCharges);
            ENSTRDSH.GstTaxReport.ValidateFieldValue(ReportTax);
            ENSTRDSH.TotalCharges.ValidateFieldValue(TotalCharges);
            ENSTRDSH.GstTaxTotal.ValidateFieldValue(GstTaxTotal);

            if (ENSTRDSH.BankCode.Exists() == true)
            {
                ENSTRDSH.BankCode.ValidateFieldValue(BankCode);
                ENSTRDSH.PayeeAccountNumber.ValidateFieldValue(PayeeAccountNumber);
                ENSTRDSH.AccountName.ValidateFieldValue(AccountName);
            }

            if (ENSTRDSH.RemainingBalance.Exists() == true)
            {
                ENSTRDSH.RemainingBalance.ValidateFieldValue(RemainingBalance);
                ENSTRDSH.RemBalIndDesc.ValidateFieldValue(RemBalIndDesc);
                ENSTRDSH.TransfereeHolder.ValidateFieldValue(TransfereeHolder);
                ENSTRDSH.TransfereeClass.ValidateFieldValue(TransfereeClass);
            }
        }

        [When(@"In ENSTRDSH I Verify Trade History details1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ENSTRDSHVerifyTradeHistoryDetails1(string Units1, string UnitsSell, string FinalPrice, string GrossAmount, string PurchaseResidue, string LoanAmount, string OptionCost, string Gst, string TaxWithheld, string NettAmount, string ChargeAmount01, string ChargeAmount02, string ChargeAmount03, string ChargeAmount04, string ChargeAmount05, string ChargeAmount06, string PaymentDate, string PaymentAccount1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSTRDSH");
            ENSTRDSH.Units.ValidateFieldValue(Units1);
            ENSTRDSH.SoldUnits.ValidateFieldValue(UnitsSell);
            ENSTRDSH.Price.ValidateFieldValue(FinalPrice);
            ENSTRDSH.Gross.ValidateFieldValue(GrossAmount);
            ENSTRDSH.PurchRes.ValidateFieldValue(PurchaseResidue);
            ENSTRDSH.Loan.ValidateFieldValue(LoanAmount);
            ENSTRDSH.OptionCosts.ValidateFieldValue(OptionCost);
            ENSTRDSH.Gst.ValidateFieldValue(Gst);
            ENSTRDSH.WithholdingTax.ValidateFieldValue(TaxWithheld);
            ENSTRDSH.Nett.ValidateFieldValue(NettAmount);
            ENSTRDSH.Charge.ValidateFieldValue(1, ChargeAmount01);
            ENSTRDSH.Charge.ValidateFieldValue(2, ChargeAmount02);
            ENSTRDSH.Charge.ValidateFieldValue(3, ChargeAmount03);
            ENSTRDSH.Charge.ValidateFieldValue(4, ChargeAmount04);
            ENSTRDSH.Charge.ValidateFieldValue(5, ChargeAmount05);
            ENSTRDSH.Charge.ValidateFieldValue(6, ChargeAmount06);
            ENSTRDSH.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSTRDSH.PayAccountNumber.ValidateFieldValue(PaymentAccount1);
        }

        [When(@"In ENS04060 enter Class Code as ""(.*)""")]
        public void EnterClassCode(string Class)
        {
            ENS04060.Class.SetValue(Class);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENSPCE06 I enter country code as ""(.*)""")]
        public void EnterCountryCode(string Country)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE06");
            ENSPCE06.Country.SetValue(Country);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
        }

        [When(@"In ENSESS28 I Enter Date range as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterDateRange(string FromDate, string ToDate, string NoOfMonts, string Days)
        {
            ENSESS28.DateFrom.SetValue(FromDate);
            ENSESS28.DateTO.SetValue(ToDate);
            ENSESS28.NumberMths.SetValue(NoOfMonts);
            ENSESS28.NumberDays.SetValue(Days);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENSPCE01 I enter Display Option as ""(.*)"" ""(.*)""")]
        public void EnterDisplayOption(string Country, string DisplayOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE06");
            ENSPCE06.Country.SetValue(Country);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            ENSPCE01.Option.SetValue(DisplayOption);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
        }

        [When(@"In ENS01081 I Enter Extract reference as ""(.*)""")]
        public void EnterExtractReference(string Reference)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01081");
            ENS01081.Reference.SetValue(Reference);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In ENS01085 I continue with the following details:")]
        public void EnterFasterStatementExtractDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01085");
            if (table.Rows[0]["HolderIdentifier"] != "")
            {
                ENS01085.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            }
            if (table.Rows[0]["Destination"] != "")
            {
                ENS01085.Destination.SetValue(1, table.Rows[0]["Destination"]);
            }
            if (table.Rows[0]["Reference"] != "")
            {
                ENS01085.Reference.SetValue(1, table.Rows[0]["Reference"]);
            }
            if (table.Rows[0]["OpsInitials"] != "")
            {
                ENS01085.OpsInitials.SetValue(1, table.Rows[0]["OpsInitials"]);
            }
            if (table.Rows[0]["RunFrom"] != "")
            {
                ENS01085.RunFrom.SetValue(1, table.Rows[0]["RunFrom"]);
            }
            if (table.Rows[0]["RunTO"] != "")
            {
                ENS01085.RunTO.SetValue(1, table.Rows[0]["RunTO"]);
            }
            if (table.Rows[0]["ClassCode"] != "")
            {
                ENS01085.ClassCode.SetValue(1, table.Rows[0]["ClassCode"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENSESS54 I enter following details in the ESS Tax reporting Enquiry ""(.*)"" ""(.*)""")]
        public void EnterfollowingDetailsInTheESSTaxReportingEnquiry(string Class, string FY)
        {
            ENSESS54.ClassCode.SetValue(Class);
            ENSESS54.FinYear.SetValue(FY);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENSESS06 I enter following employee details:")]
        public void EnterfollowingEmployeeDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string EmpID = data.GetData("Employee ID");
            string PayrollID = data.GetData("Payroll ID");
            string USAN = data.GetData("USAN");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS06");
            ENSESS06.HolderID.SetValue(HIN);
            ENSESS06.EmployeeNbr.SetValue(EmpID);
            ENSESS06.PayrollID.SetValue(PayrollID);
            ENSESS06.ContractUsan.SetValue(USAN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENS01080 I enter Holding Print Extract details as ""(.*)""")]
        public void EnterHoldingPrintExtractDetails(string FormatType)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01080");
            ENS01080.Format.SetValue(FormatType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENS01084 I Enter Issuer Statement Extract details as ""(.*)"" ""(.*)""")]
        public void EnterIssuerStatementExtractDetails(string StatementDefinition, string Reference)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01084");
            ENS01084.Destination.SetValue(StatementDefinition);
            ENS01084.Reference.SetValue(Reference);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENS01089 I enter Marking Print Extract details as ""(.*)"" ""(.*)""")]
        public void EnterMarkingPrintExtractDetails(string Reference, string MarkingNbr)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01089");
            ENS01089.Reference.SetValue(Reference);
            ENS01089.MarkingNumber.SetValue(MarkingNbr);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I enter Postcode Enquiry System details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterPostcodeEnquirySystemDetails(string Country, string DisplayOption, string StartLocation, string State)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE06");
            ENSPCE06.Country.SetValue(Country);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE01");
            ENSPCE01.Option.SetValue(DisplayOption);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            switch (DisplayOption.ToLower())
            {
                case "dlas":

                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE02");
                    ENSPCE02.LULocation.SetValue(StartLocation);
                    if (ENSPCE02.LUState.Exists() == true)
                    {
                        ENSPCE02.LUState.SetValue(State);
                    }
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "dlpc":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE03");
                    ENSPCE03.LUPostcode.SetValue(StartLocation);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "dlps":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE04");
                    ENSPCE04.LUPresort.SetValue(StartLocation);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "dlbp":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE04");
                    ENSPCE04.LUBarcodePresort.SetValue(StartLocation);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    break;
            }
        }

        [When(@"In ENS04020 enter search string as ""(.*)"" ""(.*)""")]
        public void EnterSearchString(string Selection, string SearchString)
        {
            switch (Selection.ToLower())
            {
                case "f":
                    ENS04020.Continue.SetValue(Selection);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "s":
                    ENS04020.Continue.SetValue(Selection);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    ENS04020.String.SetValue(SearchString);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    break;
            }
        }

        [When(@"In ENS01086 I Enter Surfix as ""(.*)""")]
        public void EnterSurfix(string Surfix)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01086");
            ENS01086.XtractSuffix.SetValue(Surfix);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"I enter the following details as the Locate action ""(.*)"" ""(.*)""")]
        [When(@"I enter the following details as the Locate action ""(.*)"" ""(.*)""")]
        public void EnterTheDetailsAsTheLocateAction(string Action, string LocateArgument)
        {
            ENS01090.Action.SetValue(Action);
            ENS01090.LocateArgument.SetValue(LocateArgument);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"I enter the following details as the Locate action:")]
        [When(@"I enter the following details as the Locate action:")]
        public void EnterTheFollowingDetailsAsTheLocateAction(Table data)
        {
            string Action = data.GetData("Action");
            string LocateArgument = data.GetData("Locate Argument");

            ENS01090.Action.SetValue(Action);
            ENS01090.LocateArgument.SetValue(LocateArgument);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I enter the following details in Payment Enquiry as the Locate action:")]
        public void EnterTheFollowingDetailsInPaymentEnquiryAsTheLocateAction(Table data)
        {
            string Action = data.GetData("Action");
            string LocateArgument = data.GetData("Locate Argument");

            switch (Action.ToLower())
            {
                case "s":
                    ENS02000.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    ENS02000.ReinitiateSearch.SetValue(LocateArgument);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    ENS02000.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;
            }
        }

        [When(@"In ENS04040 enter Transaction Summary Parameters as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterTransactionSummaryParameters(string FromRun, string ToRun, string Class)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04040");
            ENS04040.FromRun.SetValue(FromRun);
            ENS04040.TORun.SetValue(ToRun);
            ENS04040.Class.SetValue(Class);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"In ENSTRDSH I expect to see the following in the Trade history screen for ""(.*)""")]
        public void ExpectToSeeTheFollowingInTheTradeHistoryScreenFor(string tranType, Table data)
        {
            string HolderID = data.GetData("Holder");
            string SellUnits = data.GetData("Sell Units");
            string FinalPrice = data.GetData("Final Price");
            string GrossAmount = data.GetData("Gross Amount");
            string Charges = data.GetData("Charges");
            string NetAmount = data.GetData("Net Amount");
            string PaymentDate = data.GetData("Payment Date");
            string Currency = data.GetData("Currency");
            string CurrencyDesc = data.GetData("Currency Desc");
            string TradeDate = data.GetData("Trade Date");
            string SettlementDate = data.GetData("Settlement Date");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSTRDSH");
            ENSTRDSH.HolderIdentifier.ValidateFieldValue(HolderID);
            ENSTRDSH.SoldUnits.ValidateFieldValue(SellUnits);
            ENSTRDSH.Price.ValidateFieldValue(FinalPrice);
            ENSTRDSH.Gross.ValidateFieldValue(GrossAmount);
            ENSTRDSH.TotalHolderCharges.ValidateFieldValue(Charges);
            ENSTRDSH.Nett.ValidateFieldValue(NetAmount);
            ENSTRDSH.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSTRDSH.CurrencyCode.ValidateFieldValue(Currency);
            ENSTRDSH.CurrencyDesc.ValidateFieldValue(CurrencyDesc);
            ENSTRDSH.TradeDate.ValidateFieldValue(TradeDate);
            ENSTRDSH.SettlementDate.ValidateFieldValue(SettlementDate);

            if (tranType == "sell to cover")
            {
                string RemainingBal = data.GetData("Rem Bal");
                string To = data.GetData("To");
                string TransferClass = data.GetData("Transfer Class");

                ENSTRDSH.RemainingBalance.ValidateFieldValue(RemainingBal);
                ENSTRDSH.RemBalIndDesc.ValidateFieldValue(To);
                ENSTRDSH.TransfereeClass.ValidateFieldValue(TransferClass);
            }

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [When(@"I go to Holder Enquiry System")]
        public void GoToHolderEnquirySystem()
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("enquiry system");
            WinFormsTestSteps.ClickOnWithinTheEnquirySystemMenu("holder enquiry system");
        }

        [Then(@"I go to the Enquiry system and Search (.*)")]
        [When(@"I go to the Enquiry system and Search (.*)")]
        public void GoToTheEnquirySystemAndSearch(string HIN)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("enquiry system");
            WinFormsTestSteps.ClickOnWithinTheEnquirySystemMenu("holder enquiry system");

            ENS01090.Action.SetValue("S");
            ENS01090.LocateArgument.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"I go to the Enquiry System and Search for the NewSRN as:")]
        public void GoToTheEnquirySystemAndSearchForTheNewSRN(Table table)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("enquiry system");
            WinFormsTestSteps.ClickOnWithinTheEnquirySystemMenu("holder enquiry system");

            ENS01090.Action.SetValue("S");
            table.Rows[0]["NewSRN"] = Reference;
            ENS01090.LocateArgument.SetValue(1, table.Rows[0]["NewSRN"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I go to the Enquiry system for ""(.*)""")]
        public void GoToTheEnquirySystemFor(string HIN)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("enquiry system");
            WinFormsTestSteps.ClickOnWithinTheEnquirySystemMenu("holder enquiry system");

            ENS01090.Action.SetValue("S");
            ENS01090.LocateArgument.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [Then(@"in ENS01090 I enter the following details as the Locate action:")]
        [When(@"in ENS01090 I enter the following details as the Locate action:")]
        public void InENS01090IEnterTheFollowingDetailsAsTheLocateAction(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01090");
            ENS01090.Action.SetValue(1, table.Rows[0]["Action"]);
            ENS01090.LocateArgument.SetValue(1, table.Rows[0]["LocateArgument"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I Search Postcode Enquiry System details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void SearchPostcodeEnquirySystemDetails(string Country, string DisplayOption, string StartLocation, string State)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE06");
            ENSPCE06.Country.SetValue(Country);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE01");
            ENSPCE01.Option.SetValue(DisplayOption);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            switch (DisplayOption.ToLower())
            {
                case "dlas":

                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE02");
                    ENSPCE02.LULocation.SetValue(StartLocation);
                    ENSPCE02.LUState.SetValue(State);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "dlpc":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE03");
                    ENSPCE03.LUPostcode.SetValue(StartLocation);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    break;

                case "dlps":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE04");
                    ENSPCE04.LUPresort.SetValue(StartLocation);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    break;

                case "dlbp":
                    WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE04");
                    ENSPCE04.LUBarcodePresort.SetValue(StartLocation);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    break;

                default:
                    break;
            }
        }

        [Then(@"In ENSACC01 I should see Acceptance Status Summary details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void SeeAcceptanceStatusSummaryDetails(string HIN, string Line1, string Line2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSACC01");
            ENSACC01.HolderIdentifier.ValidateFieldValue(HIN);
            ENSACC01.SummaryLine.ValidateFieldValue(1, Line1);
            ENSACC01.SummaryLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENS01061 I should see holder Extra Dividend Intentions as below:")]
        public void SeeHolderExtraDividendIntentions(Table data)
        {
            string BSPDate = data.GetData("BSPDate");
            string BSPRun = data.GetData("BSPRun");
            string BSPTran = data.GetData("BSPTran");
            string BSPOpt = data.GetData("BSPOpt");
            string BSPLevel = data.GetData("BSPLevel");
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01061");
            ENS01061.BspPendDate.ValidateFieldValue(BSPDate);
            ENS01061.BspPendRun.ValidateFieldValue(BSPRun);
            ENS01061.BspPendTrans.ValidateFieldValue(BSPTran);
            ENS01061.BspPendOpt.ValidateFieldValue(BSPOpt);
            ENS01061.BspPendLevel.ValidateFieldValue(BSPLevel);
        }

        [When(@"In ENS04010 I Select Statistic Enquiry action as ""(.*)""")]
        public void SelectStatisticEnquiryAction(string Action)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04010");
            ENS04010.SelectedOption.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
        }

        [When(@"In ENS01028 I set class code filter as below:")]
        public void SetClassCodeFilter(Table data)
        {
            string Class1 = data.GetData("Class Code1");
            string Class2 = data.GetData("Class Code2");
            string Class3 = data.GetData("Class Code3");
            string Class4 = data.GetData("Class Code4");

            ENS01028.ReqdFlag1.SetValue(Class1);
            ENS01028.ReqdFlag2.SetValue(Class2);
            ENS01028.ReqdFlag3.SetValue(Class3);
            ENS01028.ReqdFlag4.SetValue(Class4);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            while (formName != "ENS01090")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            }





        }

        [When(@"In ENS010HF I set holder filter as below:")]
        public void SetHolderFilter(Table data)
        {
            string Deceased = data.GetData("Deceased");
            string PlanElection = data.GetData("Plan Election");
            string JointHoldings = data.GetData("Joint Holdings");
            string DesignatedAccount = data.GetData("Designated Account");
            string Notings = data.GetData("Notings");

            ENS010HF.YN.SetValue(1, Deceased);
            ENS010HF.YN.SetValue(2, PlanElection);
            ENS010HF.JointHoldings.SetValue(JointHoldings);
            ENS010HF.DesignatedAccount.SetValue(DesignatedAccount);
            ENS010HF.HsyNoteFlag.SetValue(Notings);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENS01029 I set Run Range Filter as below:")]
        public void SetRunRangeFilter(Table data)
        {
            string RunFrom = data.GetData("Run From");
            string RunTo = data.GetData("Run To");

            ENS01029.RunFrom.SetValue(RunFrom);
            ENS01029.RunTO.SetValue(RunTo);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"I should not see Wire Instructions")]
        public void ShouldNotSeeWireInstructions()
        {
            ENS01001.Action.SetValue("WR");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ThenIExpectToSeeErrorWithText("There isn't a wire instruction for this holder.");

            Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In ENSESS42 I should see Account details as below:")]
        public void ShouldSeeAccountDetails(Table data)
        {
            string AccountNbr1 = data.GetData("AccountNbr1");
            string AccountNbr2 = data.GetData("AccountNbr2");
            string AccountNbr3 = data.GetData("AccountNbr3");
            string AccountNbr4 = data.GetData("AccountNbr4");
            string AccountNbr5 = data.GetData("AccountNbr5");
            string AccountNbr6 = data.GetData("AccountNbr6");
            string AccountNbr7 = data.GetData("AccountNbr7");
            string AccountName1 = data.GetData("AccountName1");
            string AccountName2 = data.GetData("AccountName2");
            string AccountName3 = data.GetData("AccountName3");
            string AccountName4 = data.GetData("AccountName4");
            string AccountName5 = data.GetData("AccountName5");
            string AccountName6 = data.GetData("AccountName6");
            string AccountName7 = data.GetData("AccountName7");
            string BankCode1 = data.GetData("BankCode1");
            string BankCode2 = data.GetData("BankCode2");
            string BankCode3 = data.GetData("BankCode3");
            string BankCode4 = data.GetData("BankCode4");
            string BankCode5 = data.GetData("BankCode5");
            string BankCode6 = data.GetData("BankCode6");
            string BankCode7 = data.GetData("BankCode7");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS42");
            ENSESS42.EventAccNumber.ValidateFieldValue(1, AccountNbr1);
            ENSESS42.EventAccNumber.ValidateFieldValue(2, AccountNbr2);
            ENSESS42.EventAccNumber.ValidateFieldValue(3, AccountNbr3);
            ENSESS42.EventAccNumber.ValidateFieldValue(4, AccountNbr4);
            ENSESS42.EventAccNumber.ValidateFieldValue(5, AccountNbr5);
            ENSESS42.EventAccNumber.ValidateFieldValue(6, AccountNbr6);
            ENSESS42.EventAccNumber.ValidateFieldValue(7, AccountNbr7);
            ENSESS42.EventAccName.ValidateFieldValue(1, AccountName1);
            ENSESS42.EventAccName.ValidateFieldValue(2, AccountName2);
            ENSESS42.EventAccName.ValidateFieldValue(3, AccountName3);
            ENSESS42.EventAccName.ValidateFieldValue(4, AccountName4);
            ENSESS42.EventAccName.ValidateFieldValue(5, AccountName5);
            ENSESS42.EventAccName.ValidateFieldValue(6, AccountName6);
            ENSESS42.EventAccName.ValidateFieldValue(7, AccountName7);
            ENSESS42.EventBankDetails.ValidateFieldValue(1, BankCode1);
            ENSESS42.EventBankDetails.ValidateFieldValue(2, BankCode2);
            ENSESS42.EventBankDetails.ValidateFieldValue(3, BankCode3);
            ENSESS42.EventBankDetails.ValidateFieldValue(4, BankCode4);
            ENSESS42.EventBankDetails.ValidateFieldValue(5, BankCode5);
            ENSESS42.EventBankDetails.ValidateFieldValue(6, BankCode6);
            ENSESS42.EventBankDetails.ValidateFieldValue(7, BankCode7);
        }

        [Then(@"In ENSESS07 I should see Award Details as below:")]
        public void ShouldSeeAwardDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("Plan Desc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS07");
            ENSESS07.HolderID.ValidateFieldValue(HIN);
            ENSESS07.SchemeCode.ValidateFieldValue(Plan);
            ENSESS07.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS07.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS07.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS07.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS07.DetailLine.ValidateFieldValue(4, Line4);
        }

        [Then(@"In ENSESS07 I should see Award Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeAwardDetails(string Plan, string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS07");
            ENSESS07.SchemeCode.ValidateFieldValue(Plan);
            ENSESS07.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS07.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS07.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS07.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS07.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS07.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS07.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS07.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS07.DetailLine.ValidateFieldValue(9, Line9);
        }

        [Then(@"In ENS01014 I should see Balance Transaction as below:")]
        public void ShouldSeeBalanceTransaction(Table data)
        {
            string Run = data.GetData("Run");
            string TranNo = data.GetData("Tran No");
            string TranCode = data.GetData("Tran Code");
            string TranDesc = data.GetData("Tran Desc");
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");

            ENS01014.RunNumber.ValidateFieldValue(Run);
            ENS01014.CrtTransNumber.ValidateFieldValue(TranNo);
            ENS01014.TranTypeCode.ValidateFieldValue(TranCode);
            ENS01014.TranTypeDesc.ValidateFieldValue(TranDesc);
            ENS01014.HolderIDOff.ValidateFieldValue(HIN);
            ENS01014.Lines6.ValidateFieldValue(1, Line1);
            ENS01014.Lines6.ValidateFieldValue(2, Line2);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENS01069 I should see Balance Transaction Extra Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeBalanceTransactionExtraDetails(string TransDate, string TransType, string OtherHID, string TradeRef, string BrokerCode, string AgentCode, string SubSystem, string Run, string Tran, string Class, string Register, string Units)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01069");
            ENS01069.TranDate.ValidateFieldValue(TransDate);
            ENS01069.TranTypeCode.ValidateFieldValue(TransType);
            ENS01069.TradingHolderID.ValidateFieldValue(OtherHID);
            ENS01069.TradeReference.ValidateFieldValue(TradeRef);
            ENS01069.BrokerCode.ValidateFieldValue(BrokerCode);
            ENS01069.AgentCode.ValidateFieldValue(AgentCode);
            //ENS01069.SubSystem.ValidateFieldValue(SubSystem);
            ENS01069.RunNumber.ValidateFieldValue(Run);
            ENS01069.CrtTransNumber.ValidateFieldValue(Tran);
            ENS01069.ClassCode.ValidateFieldValue(Class);
            ENS01069.RegisterCode.ValidateFieldValue(Register);
            ENS01069.Units.ValidateFieldValue(Units);
        }

        [Then(@"ENSPCE10 I should see BarcodePresort details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeBarcodePresortDetails(string BarcodePresort1, string BarcodePresort2, string BarcodePresort3, string BarcodePresort4, string BarcodePresort5, string BarcodePresort6, string BarcodePresort7, string BarcodePresort8, string BarcodePresort9, string BarcodePresort10, string BarcodePresort11, string BarcodePresort12, string BarcodePresort13, string BarcodePresort14, string BarcodePresort15, string BarcodePresort16)
        {
            ENSPCE10.BarcodePresort.ValidateFieldValue(1, BarcodePresort1);
            ENSPCE10.BarcodePresort.ValidateFieldValue(2, BarcodePresort2);
            ENSPCE10.BarcodePresort.ValidateFieldValue(3, BarcodePresort3);
            ENSPCE10.BarcodePresort.ValidateFieldValue(4, BarcodePresort4);
            ENSPCE10.BarcodePresort.ValidateFieldValue(5, BarcodePresort5);
            ENSPCE10.BarcodePresort.ValidateFieldValue(6, BarcodePresort6);
            ENSPCE10.BarcodePresort.ValidateFieldValue(7, BarcodePresort7);
            ENSPCE10.BarcodePresort.ValidateFieldValue(8, BarcodePresort8);
            ENSPCE10.BarcodePresort.ValidateFieldValue(9, BarcodePresort9);
            ENSPCE10.BarcodePresort.ValidateFieldValue(10, BarcodePresort10);
            ENSPCE10.BarcodePresort.ValidateFieldValue(11, BarcodePresort11);
            ENSPCE10.BarcodePresort.ValidateFieldValue(12, BarcodePresort12);
            ENSPCE10.BarcodePresort.ValidateFieldValue(13, BarcodePresort13);
            ENSPCE10.BarcodePresort.ValidateFieldValue(14, BarcodePresort14);
            ENSPCE10.BarcodePresort.ValidateFieldValue(15, BarcodePresort15);
            ENSPCE10.BarcodePresort.ValidateFieldValue(16, BarcodePresort16);
        }

        [Then(@"In ENS01012 I should see Certificate details as below:")]
        public void ShouldSeeCertificateDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Page1Line1 = data.GetData("Page1 Line1");
            string Page1Line2 = data.GetData("Page1 Line2");
            string Page1Line3 = data.GetData("Page1 Line3");
            string Page2Line1 = data.GetData("Page2 Line1");
            string Page2Line2 = data.GetData("Page2 Line2");
            string Page2Line3 = data.GetData("Page2 Line3");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01012");
            ENS01012.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01012.CertificateLine.ValidateFieldValue(1, Page1Line1);
            ENS01012.CertificateLine.ValidateFieldValue(2, Page1Line2);
            ENS01012.CertificateLine.ValidateFieldValue(3, Page1Line3);

            ENS01012.Action.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01012");
            ENS01012.CertificateLine.ValidateFieldValue(1, Page2Line1);
            ENS01012.CertificateLine.ValidateFieldValue(2, Page2Line2);
            ENS01012.CertificateLine.ValidateFieldValue(3, Page2Line3);
        }

        [Then(@"In ENS01012 I should see Certificate details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeCertificateDetails(string HIN, string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10, string Line11, string Line12, string Line13)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01012");
            ENS01012.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01012.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01012.CertificateLine.ValidateFieldValue(2, Line2);
            ENS01012.CertificateLine.ValidateFieldValue(3, Line3);
            ENS01012.CertificateLine.ValidateFieldValue(4, Line4);
            ENS01012.CertificateLine.ValidateFieldValue(5, Line5);
            ENS01012.CertificateLine.ValidateFieldValue(6, Line6);
            ENS01012.CertificateLine.ValidateFieldValue(7, Line7);
            ENS01012.CertificateLine.ValidateFieldValue(8, Line8);
            ENS01012.CertificateLine.ValidateFieldValue(9, Line9);
            ENS01012.CertificateLine.ValidateFieldValue(10, Line10);
            ENS01012.CertificateLine.ValidateFieldValue(11, Line11);
            ENS01012.CertificateLine.ValidateFieldValue(12, Line12);
            ENS01012.CertificateLine.ValidateFieldValue(13, Line13);
        }

        [Then(@"In ENSTRDSC I should see Certificate details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeCertificateDetails(string Register, string CertificateID, string Units, string AwardPrice, string FinalPrice, string GainLoss)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSTRDSC");
            ENSTRDSC.Register.ValidateFieldValue(Register);
            ENSTRDSC.CertID.ValidateFieldValue(CertificateID);
            ENSTRDSC.Units.ValidateFieldValue(Units);
            ENSTRDSC.AwardPrice.ValidateFieldValue(AwardPrice);
            ENSTRDSC.FinalPrice.ValidateFieldValue(FinalPrice);
            ENSTRDSC.GainLoss.ValidateFieldValue(GainLoss);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENS01042 I should see Certificate Details as Cert1 ""(.*)""  and Cert2 ""(.*)""")]
        public void ShouldSeeCertificateDetailsAs(string Cert1, string Cert2)
        {
            ENS01012.CertificateLine.ValidateFieldValue(2, Cert1);
            ENS01012.CertificateLine.ValidateFieldValue(3, Cert2);
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENS01072 I should see Chess Balance Rejection details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeChessBalanceRejectionDetailsPart1(string Broker, string TradeRef, string CertId, string OverrideBasis, string TranType, string TranTypeDesc, string Class, string ClassDesc, string TotalUnits, string TransferUnits, string RejectReason, string ForeignGuar, string MessageType, string MovementReason, string Register, string BusDate, string Security)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01072");
            ENS01072.BrokerCode.ValidateFieldValue(Broker);
            ENS01072.TradeReference.ValidateFieldValue(TradeRef);
            ENS01072.SellCertID.ValidateFieldValue(CertId);
            ENS01072.OverrideBasis.ValidateFieldValue(OverrideBasis);
            ENS01072.TranTypeCode.ValidateFieldValue(TranType);
            ENS01072.TranTypeDesc.ValidateFieldValue(TranTypeDesc);
            ENS01072.ClassCode.ValidateFieldValue(Class);
            ENS01072.ClassDesc.ValidateFieldValue(ClassDesc);
            ENS01072.TotalUnits.ValidateFieldValue(TotalUnits);
            ENS01072.TransferUnits.ValidateFieldValue(TransferUnits);
            ENS01072.RejectedReason.ValidateFieldValue(RejectReason);
            ENS01072.GuaranteedForeign.ValidateFieldValue(ForeignGuar);
            ENS01072.MsgType.ValidateFieldValue(MessageType);
            ENS01072.MovementReason.ValidateFieldValue(MovementReason);
            ENS01072.RegisterCode.ValidateFieldValue(Register);
            ENS01072.BusinessDate.ValidateFieldValue(BusDate);
            ENS01072.SecurityCode.ValidateFieldValue(Security);
        }

        [Then(@"In ENS01072 I should see Chess Balance Rejection details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeChessBalanceRejectionDetailsPart2(string SellHolder, string SellResidency, string SellAddress, string BuyHolder, string BuyResidency, string BuyAddress, string Message)
        {
            ENS01072.SellHolderID.ValidateFieldValue(SellHolder);
            ENS01072.SellerResidency.ValidateFieldValue(SellResidency);
            ENS01072.SellAddressLine.ValidateFieldValue(SellAddress);
            ENS01072.BuyHolderID.ValidateFieldValue(BuyHolder);
            ENS01072.BuyerResidency.ValidateFieldValue(BuyResidency);
            ENS01072.BuyAddressLine.ValidateFieldValue(1, BuyAddress);
            ENS01072.RejectMsg.ValidateFieldValue(Message);
        }

        [Then(@"In ENS01067 I should see Chess Static Rejection Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeChessStaticRejectionDetails(string Broker, string TradeRef, string RejectReason, string TranType, string TranTypeDesc, string Run, string Trans, string BusDate, string SellHIN, string SellNameAddress, string SellPostcode, string SellTaxCode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01067");
            ENS01067.BrokerCode.ValidateFieldValue(Broker);
            ENS01067.TradeReference.ValidateFieldValue(TradeRef);
            ENS01067.RejectMsg.ValidateFieldValue(RejectReason);
            ENS01067.TranTypeCode.ValidateFieldValue(TranType);
            ENS01067.TranTypeDesc.ValidateFieldValue(TranTypeDesc);
            ENS01067.RunNumber.ValidateFieldValue(Run);
            ENS01067.TransNumber.ValidateFieldValue(Trans);
            ENS01067.BusinessDate.ValidateFieldValue(BusDate);
            ENS01067.SellHolderID.ValidateFieldValue(SellHIN);
            ENS01067.SellAddressLine.ValidateFieldValue(SellNameAddress);
            ENS01067.SellPostcode.ValidateFieldValue(SellPostcode);
            ENS01067.HolderOtherTaxCode.ValidateFieldValue(SellTaxCode);
        }

        [Then(@"In ENS0106P I should see Chess Static Rejection Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeChessStaticRejectionDetails(string Broker, string TradeRef, string RejectReason, string RejectDesc, string TranType, string TranTypeDesc, string Run, string Trans, string BusDate, string SellHIN, string SellNameAddress, string BulkSystem, string BSB, string AccountNbr, string AccountName)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS0106P");
            ENS0106P.BrokerCode.ValidateFieldValue(Broker);
            ENS0106P.TradeReference.ValidateFieldValue(TradeRef);
            ENS0106P.RejectedReason.ValidateFieldValue(RejectReason);
            ENS0106P.RejectMsg.ValidateFieldValue(RejectDesc);
            ENS0106P.TranTypeCode.ValidateFieldValue(TranType);
            ENS0106P.TranTypeDesc.ValidateFieldValue(TranTypeDesc);
            ENS0106P.RunNumber.ValidateFieldValue(Run);
            ENS0106P.TransNumber.ValidateFieldValue(Trans);
            ENS0106P.BusinessDate.ValidateFieldValue(BusDate);
            ENS0106P.SellHolderID.ValidateFieldValue(SellHIN);
            ENS0106P.SellAddressLine.ValidateFieldValue(SellNameAddress);
            ENS0106P.BulkPaySystem.ValidateFieldValue(BulkSystem);
            ENS0106P.BankCode.ValidateFieldValue(BSB);
            ENS0106P.PayeeAccountNumber.ValidateFieldValue(AccountNbr);
            ENS0106P.PayeeAccountName.ValidateFieldValue(AccountName);
        }

        [Then(@"In ENS04030 I should see Class codes as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeClassCodes(string Class1, string Class2, string Class3, string Class4, string Class5, string Class6, string Class7, string Class8, string Class9, string Class10, string Class11, string Class12, string Class13, string Class14, string Class15, string Class16, string Class17, string Class18)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04030");
            ENS04030.Class.ValidateFieldValue(1, Class1);
            ENS04030.Class.ValidateFieldValue(2, Class2);
            ENS04030.Class.ValidateFieldValue(3, Class3);
            ENS04030.Class.ValidateFieldValue(4, Class4);
            ENS04030.Class.ValidateFieldValue(5, Class5);
            ENS04030.Class.ValidateFieldValue(6, Class6);
            ENS04030.Class.ValidateFieldValue(7, Class7);
            ENS04030.Class.ValidateFieldValue(8, Class8);
            ENS04030.Class.ValidateFieldValue(9, Class9);
            ENS04030.Class.ValidateFieldValue(10, Class10);
            ENS04030.Class.ValidateFieldValue(11, Class11);
            ENS04030.Class.ValidateFieldValue(12, Class12);
            ENS04030.Class.ValidateFieldValue(13, Class13);
            ENS04030.Class.ValidateFieldValue(14, Class14);
            ENS04030.Class.ValidateFieldValue(15, Class15);
            ENS04030.Class.ValidateFieldValue(16, Class16);
            ENS04030.Class.ValidateFieldValue(17, Class17);
            ENS04030.Class.ValidateFieldValue(18, Class18);
        }

        [Then(@"In ENS04030 I should see Class Description codes as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeClassDescriptionCodes(string ClassDesc1, string ClassDesc2, string ClassDesc3, string ClassDesc4, string ClassDesc5, string ClassDesc6, string ClassDesc7, string ClassDesc8, string ClassDesc9, string ClassDesc10, string ClassDesc11, string ClassDesc12, string ClassDesc13, string ClassDesc14, string ClassDesc15, string ClassDesc16, string ClassDesc17, string ClassDesc18)
        {
            ENS04030.Description.ValidateFieldValue(1, ClassDesc1);
            ENS04030.Description.ValidateFieldValue(2, ClassDesc2);
            ENS04030.Description.ValidateFieldValue(3, ClassDesc3);
            ENS04030.Description.ValidateFieldValue(4, ClassDesc4);
            ENS04030.Description.ValidateFieldValue(5, ClassDesc5);
            ENS04030.Description.ValidateFieldValue(6, ClassDesc6);
            ENS04030.Description.ValidateFieldValue(7, ClassDesc7);
            ENS04030.Description.ValidateFieldValue(8, ClassDesc8);
            ENS04030.Description.ValidateFieldValue(9, ClassDesc9);
            ENS04030.Description.ValidateFieldValue(10, ClassDesc10);
            ENS04030.Description.ValidateFieldValue(11, ClassDesc11);
            ENS04030.Description.ValidateFieldValue(12, ClassDesc12);
            ENS04030.Description.ValidateFieldValue(13, ClassDesc13);
            ENS04030.Description.ValidateFieldValue(14, ClassDesc14);
            ENS04030.Description.ValidateFieldValue(15, ClassDesc15);
            ENS04030.Description.ValidateFieldValue(16, ClassDesc16);
            ENS04030.Description.ValidateFieldValue(17, ClassDesc17);
            ENS04030.Description.ValidateFieldValue(18, ClassDesc18);
        }

        [Then(@"In ENS04020 I should see Class Statistics Enquiry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeClassStatisticsEnquiryDetails(string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04020");
            ENS04020.ScreenLine.ValidateFieldValue(1, Line1);
            ENS04020.ScreenLine.ValidateFieldValue(2, Line2);
            ENS04020.ScreenLine.ValidateFieldValue(3, Line3);
            ENS04020.ScreenLine.ValidateFieldValue(4, Line4);
            ENS04020.ScreenLine.ValidateFieldValue(5, Line5);
            ENS04020.ScreenLine.ValidateFieldValue(6, Line6);
            ENS04020.ScreenLine.ValidateFieldValue(7, Line7);
        }

        [Then(@"In ENS01050 I should see Company Notice as below:")]
        public void ShouldSeeCompanyNotice(Table data)
        {
            string BookCloseDate = data.GetData("BookCloseDate");
            string NoticeLine1 = data.GetData("NoticeLine1");
            string NoticeLine2 = data.GetData("NoticeLine2");
            string NoticeLine3 = data.GetData("NoticeLine3");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01050");
            ENS01050.BooksCloseDate.ValidateFieldValue(BookCloseDate);
            ENS01050.CompanyNoticeLine.ValidateFieldValue(1, NoticeLine1);
            ENS01050.CompanyNoticeLine.ValidateFieldValue(3, NoticeLine2);
            ENS01050.CompanyNoticeLine.ValidateFieldValue(5, NoticeLine3);
        }

        [Then(@"In ENSESS53 I should see Complex Holder Code as below:")]
        public void ShouldSeeComplexHolderCode(Table data)
        {
            string Code = data.GetData("Code");
            string CodeDesc = data.GetData("CodeDesc");

            ENSESS53.ComplexHolderCode.ValidateFieldValue(Code);
            ENSESS53.ComplexHolderDesc.ValidateFieldValue(CodeDesc);
        }

        [Then(@"In ENS04030 I should see Current run as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeCurrentRun(string Current1, string Current2, string Current3, string Current4, string Current5, string Current6, string Current7, string Current8, string Current9, string Current10, string Current11, string Current12, string Current13, string Current14, string Current15, string Current16, string Current17, string Current18)
        {
            ENS04030.Current.ValidateFieldValue(1, Current1);
            ENS04030.Current.ValidateFieldValue(2, Current2);
            ENS04030.Current.ValidateFieldValue(3, Current3);
            ENS04030.Current.ValidateFieldValue(4, Current4);
            ENS04030.Current.ValidateFieldValue(5, Current5);
            ENS04030.Current.ValidateFieldValue(6, Current6);
            ENS04030.Current.ValidateFieldValue(7, Current7);
            ENS04030.Current.ValidateFieldValue(8, Current8);
            ENS04030.Current.ValidateFieldValue(9, Current9);
            ENS04030.Current.ValidateFieldValue(10, Current10);
            ENS04030.Current.ValidateFieldValue(11, Current11);
            ENS04030.Current.ValidateFieldValue(12, Current12);
            ENS04030.Current.ValidateFieldValue(13, Current13);
            ENS04030.Current.ValidateFieldValue(14, Current14);
            ENS04030.Current.ValidateFieldValue(15, Current15);
            ENS04030.Current.ValidateFieldValue(16, Current16);
            ENS04030.Current.ValidateFieldValue(17, Current17);
            ENS04030.Current.ValidateFieldValue(18, Current18);
        }

        [Then(@"In ENS010CA I should see Custodian Access Codes as below:")]
        public void shouldSeeCustodianAccessCodes(Table data)
        {
            string AccessCode = data.GetData("AccessCode");
            string Name = data.GetData("Name");

            ENS010CA.AccessCode.ValidateFieldValue(AccessCode);
            ENS010CA.CustodianName.ValidateFieldValue(Name);
        }

        [Then(@"In ENSESS28 I should see date range as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDateRange(string DateTo, string Monts, string NoOfDays)
        {
            ENSESS28.DateTO.ValidateFieldValue(DateTo);
            ENSESS28.NumberMths.ValidateFieldValue(Monts);
            ENSESS28.NumberDays.ValidateFieldValue(NoOfDays);
        }

        [Then(@"In ENS01048 I should see Dealing History details as below:")]
        public void ShouldSeeDealingHistoryDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string DealingHis1 = data.GetData("Line1");
            string DealingHis2 = data.GetData("Line2");
            string DealingHis3 = data.GetData("Line3");
            string DealingHis4 = data.GetData("Line4");
            string DealingHis5 = data.GetData("Line5");

            ENS01048.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01048.HistoryLine.ValidateFieldValue(1, DealingHis1);
            ENS01048.HistoryLine.ValidateFieldValue(2, DealingHis2);
            ENS01048.HistoryLine.ValidateFieldValue(3, DealingHis3);
            ENS01048.HistoryLine.ValidateFieldValue(4, DealingHis4);
            ENS01048.HistoryLine.ValidateFieldValue(5, DealingHis5);
        }

        [Then(@"In ENSACC02 I should see detail Acceptance Status History details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDetailAcceptanceStatusHistoryDetails(string HIN, string Reference, string Run, string Date, string EntitledUnits, string OverrideUnits, string AcceptedUnits, string EntitlementBalance, string AdditionalUnits, string TotalMoney, string AcceptanceStatus, string Source)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSACC02");
            ENSACC02.HolderIdentifier.ValidateFieldValue(HIN);
            ENSACC02.ApplicationID.ValidateFieldValue(Reference);
            ENSACC02.RunNumber.ValidateFieldValue(Run);
            ENSACC02.TimestampDate.ValidateFieldValue(Date);
            ENSACC02.EntitledUnits.ValidateFieldValue(EntitledUnits);
            ENSACC02.OverrideUnits.ValidateFieldValue(OverrideUnits);
            ENSACC02.AcceptedUnits.ValidateFieldValue(AcceptedUnits);
            ENSACC02.EntitledBal.ValidateFieldValue(EntitlementBalance);
            ENSACC02.AdditionalUnits.ValidateFieldValue(AdditionalUnits);
            ENSACC02.AccStatusSdesc.ValidateFieldValue(AcceptanceStatus);
            ENSACC02.LatestTransSource.ValidateFieldValue(Source);
        }

        [Then(@"In ENSDIS01 I should see Disbursements details as below:")]
        public void ShouldSeeDisbursementsDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string Key = data.GetData("Key");
            string NameAddress1 = data.GetData("NameAddress1");
            string NameAddress2 = data.GetData("NameAddress2");
            string PI = data.GetData("PI");
            string Date = data.GetData("Date");
            string Method = data.GetData("Method");
            string Reference = data.GetData("Reference");
            string PaidAmount = data.GetData("PaidAmount");
            string PaidCurrency = data.GetData("PaidCurrency");
            string BaseCurrency = data.GetData("BaseCurrency");
            string Status = data.GetData("Status");
            string PressDate = data.GetData("PressDate");
            string PaymentAccount = data.GetData("PaymentAccount");
            string PayType = data.GetData("PayType");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIS01");
            ENSDIS01.HolderIdentifier.ValidateFieldValue(HIN);
            ENSDIS01.HolderTypeCode.ValidateFieldValue(Type);
            ENSDIS01.HolderNameKey.ValidateFieldValue(Key);
            ENSDIS01.HnaLine1.ValidateFieldValue(NameAddress1);
            ENSDIS01.HnaLine2.ValidateFieldValue(NameAddress2);
            //ENSDIS01.PI.ValidateFieldValue(PI);
            ENSDIS01.PaymentDate.ValidateFieldValue(1, Date);
            ENSDIS01.PaymentMethod.ValidateFieldValue(1, Method);
            ENSDIS01.RefNumberX.ValidateFieldValue(1, Reference);
            ENSDIS01.PaidAmount.ValidateFieldValue(1, PaidAmount);
            ENSDIS01.PaidCurrency.ValidateFieldValue(1, PaidCurrency);
            ENSDIS01.BaseCurrency.ValidateFieldValue(1, BaseCurrency);
            ENSDIS01.Status.ValidateFieldValue(1, Status);
            ENSDIS01.PresDate.ValidateFieldValue(1, PressDate);
            ENSDIS01.PaymentAccount.ValidateFieldValue(1, PaymentAccount);
            ENSDIS01.PaymentType.ValidateFieldValue(1, PayType);
        }

        [Then(@"In ENSDIS01 I should see Disbursements details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDisbursementsDetails(string Date, string Method, string Reference, string PaidAmount, string PaidCurrency, string BaseCurrency, string Status, string PaymentAccount, string PayType)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIS01");
            ENSDIS01.PaymentDate.ValidateFieldValue(1, Date);
            ENSDIS01.PaymentMethod.ValidateFieldValue(1, Method);
            ENSDIS01.RefNumberX.ValidateFieldValue(1, Reference);
            ENSDIS01.PaidAmount.ValidateFieldValue(1, PaidAmount);
            ENSDIS01.PaidCurrency.ValidateFieldValue(1, PaidCurrency);
            ENSDIS01.BaseCurrency.ValidateFieldValue(1, BaseCurrency);
            ENSDIS01.Status.ValidateFieldValue(1, Status);
            ENSDIS01.PaymentAccount.ValidateFieldValue(1, PaymentAccount);
            ENSDIS01.PaymentType.ValidateFieldValue(1, PayType);
        }

        [Then(@"In ENSDIS01 I should see Disbursements details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDisbursementsDetailsPart1(string Date1, string Date2, string Date3, string Date4, string Date5, string Method1, string Method2, string Method3, string Method4, string Method5, string Reference1, string Reference2, string Reference3, string Reference4, string Reference5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIS01");
            ENSDIS01.PaymentDate.ValidateFieldValue(1, Date1);
            ENSDIS01.PaymentDate.ValidateFieldValue(2, Date2);
            ENSDIS01.PaymentDate.ValidateFieldValue(3, Date3);
            ENSDIS01.PaymentDate.ValidateFieldValue(4, Date4);
            ENSDIS01.PaymentDate.ValidateFieldValue(5, Date5);
            ENSDIS01.PaymentMethod.ValidateFieldValue(1, Method1);
            ENSDIS01.PaymentMethod.ValidateFieldValue(2, Method2);
            ENSDIS01.PaymentMethod.ValidateFieldValue(3, Method3);
            ENSDIS01.PaymentMethod.ValidateFieldValue(4, Method4);
            ENSDIS01.PaymentMethod.ValidateFieldValue(5, Method5);
            ENSDIS01.RefNumberX.ValidateFieldValue(1, Reference1);
            ENSDIS01.RefNumberX.ValidateFieldValue(2, Reference2);
            ENSDIS01.RefNumberX.ValidateFieldValue(3, Reference3);
            ENSDIS01.RefNumberX.ValidateFieldValue(4, Reference4);
            ENSDIS01.RefNumberX.ValidateFieldValue(5, Reference5);
        }

        [Then(@"In ENSDIS01 I should see Disbursements details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDisbursementsDetailsPart2(string PaidAmount1, string PaidAmount2, string PaidAmount3, string PaidAmount4, string PaidAmount5, string PaidCurrency1, string PaidCurrency2, string PaidCurrency3, string PaidCurrency4, string PaidCurrency5, string BaseCurrency1, string BaseCurrency2, string BaseCurrency3, string BaseCurrency4, string BaseCurrency5)
        {
            ENSDIS01.PaidAmount.ValidateFieldValue(1, PaidAmount1);
            ENSDIS01.PaidAmount.ValidateFieldValue(2, PaidAmount2);
            ENSDIS01.PaidAmount.ValidateFieldValue(3, PaidAmount3);
            ENSDIS01.PaidAmount.ValidateFieldValue(4, PaidAmount4);
            ENSDIS01.PaidAmount.ValidateFieldValue(5, PaidAmount5);
            ENSDIS01.PaidCurrency.ValidateFieldValue(1, PaidCurrency1);
            ENSDIS01.PaidCurrency.ValidateFieldValue(2, PaidCurrency2);
            ENSDIS01.PaidCurrency.ValidateFieldValue(3, PaidCurrency3);
            ENSDIS01.PaidCurrency.ValidateFieldValue(4, PaidCurrency4);
            ENSDIS01.PaidCurrency.ValidateFieldValue(5, PaidCurrency5);
            ENSDIS01.BaseCurrency.ValidateFieldValue(1, BaseCurrency1);
            ENSDIS01.BaseCurrency.ValidateFieldValue(2, BaseCurrency2);
            ENSDIS01.BaseCurrency.ValidateFieldValue(3, BaseCurrency3);
            ENSDIS01.BaseCurrency.ValidateFieldValue(4, BaseCurrency4);
            ENSDIS01.BaseCurrency.ValidateFieldValue(5, BaseCurrency5);
        }

        [Then(@"In ENSDIS01 I should see Disbursements details Part3 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDisbursementsDetailsPart3(string Status1, string Status2, string Status3, string Status4, string Status5, string PaymentAccount1, string PaymentAccount2, string PaymentAccount3, string PaymentAccount4, string PaymentAccount5, string PayType1, string PayType2, string PayType3, string PayType4, string PayType5)
        {
            ENSDIS01.Status.ValidateFieldValue(1, Status1);
            ENSDIS01.Status.ValidateFieldValue(2, Status2);
            ENSDIS01.Status.ValidateFieldValue(3, Status3);
            ENSDIS01.Status.ValidateFieldValue(4, Status4);
            ENSDIS01.Status.ValidateFieldValue(5, Status5);
            ENSDIS01.PaymentAccount.ValidateFieldValue(1, PaymentAccount1);
            ENSDIS01.PaymentAccount.ValidateFieldValue(2, PaymentAccount2);
            ENSDIS01.PaymentAccount.ValidateFieldValue(3, PaymentAccount3);
            ENSDIS01.PaymentAccount.ValidateFieldValue(4, PaymentAccount4);
            ENSDIS01.PaymentAccount.ValidateFieldValue(5, PaymentAccount5);
            ENSDIS01.PaymentType.ValidateFieldValue(1, PayType1);
            ENSDIS01.PaymentType.ValidateFieldValue(2, PayType2);
            ENSDIS01.PaymentType.ValidateFieldValue(3, PayType3);
            ENSDIS01.PaymentType.ValidateFieldValue(4, PayType4);
            ENSDIS01.PaymentType.ValidateFieldValue(5, PayType5);
        }

        [Then(@"In ENSDIV01 I should see Dividend History as below:")]
        public void ShouldSeeDividendHistory(Table data)
        {
            string HIN = data.GetData("HIN");
            string Selection = data.GetData("Selection");
            string PayDate = data.GetData("Pay Date");
            string PayMethod = data.GetData("Pay Method");
            string Code = data.GetData("Code");
            string PayAccount = data.GetData("Pay Account");
            string PayType = data.GetData("Pay Type");
            string GrossAmount = data.GetData("Gross Amount");
            string NettAmount = data.GetData("Nett Amount");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV01");
            ENSDIV01.HolderIdentifier.ValidateFieldValue(HIN);
            ENSDIV01.PaymentDate.ValidateFieldValue(1, PayDate);
            ENSDIV01.PaymentMethod.ValidateFieldValue(1, PayMethod);
            ENSDIV01.DividendCode.ValidateFieldValue(1, Code);
            ENSDIV01.RecnAccount.ValidateFieldValue(1, PayAccount);
            ENSDIV01.DividendDesc.ValidateFieldValue(1, PayType);
            ENSDIV01.GrossAmount.ValidateFieldValue(1, GrossAmount);
            ENSDIV01.NettAmount.ValidateFieldValue(1, NettAmount);
        }

        [Then(@"In ENSDIV01 I should see Dividend History as below ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDividendHistory(string PayDate, string PayMethod, string Code, string PayAccount, string PayType, string GrossAmount, string NettAmount)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV01");
            ENSDIV01.PaymentDate.ValidateFieldValue(1, PayDate);
            ENSDIV01.PaymentMethod.ValidateFieldValue(1, PayMethod);
            ENSDIV01.DividendCode.ValidateFieldValue(1, Code);
            ENSDIV01.RecnAccount.ValidateFieldValue(1, PayAccount);
            ENSDIV01.DividendDesc.ValidateFieldValue(1, PayType);
            ENSDIV01.GrossAmount.ValidateFieldValue(1, GrossAmount);
            ENSDIV01.NettAmount.ValidateFieldValue(1, NettAmount);
        }

        [Then(@"In ENSDIV02 I should see Dividend History Brief as below:")]
        public void ShouldSeeDividendHistoryBrief(Table data)
        {
            string HIN = data.GetData("HIN");
            string PaymentCode = data.GetData("PaymentCode");
            string ASXCAType = data.GetData("ASXCAType");
            string DivDesc = data.GetData("DivDesc");
            string PaymentDate = data.GetData("PaymentDate");
            string Source = data.GetData("Source");
            string PayAccount = data.GetData("PayAccount");
            string ReferenceNbr = data.GetData("ReferenceNbr");
            string TaxCodeAUS = data.GetData("TaxCodeAUS");
            string TaxCode = data.GetData("TaxCode");
            string CalcCurrency = data.GetData("CalcCurrency");
            string Gross = data.GetData("Gross");
            string PaidCurreny = data.GetData("PaidCurreny");
            string PaymentDetail1 = data.GetData("PaymentDetail1");
            string PaymentDetail2 = data.GetData("PaymentDetail2");
            string PaymentDetail3 = data.GetData("PaymentDetail3");
            string PaymentDetail4 = data.GetData("PaymentDetail4");
            string PaymentDetail5 = data.GetData("PaymentDetail5");
            string PaymentDetail6 = data.GetData("PaymentDetail6");
            string PaymentDetail7 = data.GetData("PaymentDetail7");
            string SubPayCode = data.GetData("SubPayCode");
            string SubPaymentType = data.GetData("SubPaymentType");
            string SubPayDesc = data.GetData("SubPayDesc");
            string SubPayGross = data.GetData("SubPayGross");
            string SubPayTax = data.GetData("SubPayTax");
            string SubPayNett = data.GetData("SubPayNett");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV02");
            ENSDIV02.HolderIdentifier.ValidateFieldValue(HIN);
            ENSDIV02.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV02.DividendType.ValidateFieldValue(ASXCAType);
            ENSDIV02.DividendDesc.ValidateFieldValue(DivDesc);
            ENSDIV02.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSDIV02.DividendSource.ValidateFieldValue(Source);
            ENSDIV02.PayAccountNumber.ValidateFieldValue(PayAccount);
            ENSDIV02.ChequeNumber.ValidateFieldValue(ReferenceNbr);
            ENSDIV02.TaxOrideCode.ValidateFieldValue(TaxCodeAUS);
            ENSDIV02.OtherTaxOrideCode.ValidateFieldValue(TaxCode);
            ENSDIV02.CalcCurrency.ValidateFieldValue(CalcCurrency);
            ENSDIV02.Gross.ValidateFieldValue(Gross);
            ENSDIV02.PaidCurrCode.ValidateFieldValue(PaidCurreny);
            ENSDIV02.PayDetails.ValidateFieldValue(1, PaymentDetail1);
            ENSDIV02.PayDetails.ValidateFieldValue(2, PaymentDetail2);
            ENSDIV02.PayDetails.ValidateFieldValue(3, PaymentDetail3);
            ENSDIV02.PayDetails.ValidateFieldValue(4, PaymentDetail4);
            ENSDIV02.PayDetails.ValidateFieldValue(5, PaymentDetail5);
            ENSDIV02.PayDetails.ValidateFieldValue(6, PaymentDetail6);
            ENSDIV02.PayDetails.ValidateFieldValue(7, PaymentDetail7);
            ENSDIV02.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV02.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV02.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV02.SubPayGross.ValidateFieldValue(SubPayGross);
            ENSDIV02.SubPayTaxDeduct.ValidateFieldValue(SubPayTax);
            ENSDIV02.SubPayNett.ValidateFieldValue(SubPayNett);
        }

        [Then(@"In ENSDIV05 I should see Dividend History Class Components as below:")]
        public void ShouldSeeDividendHistoryClassComponents(Table data)
        {
            string HIN = data.GetData("HIN");
            string PaymentCode = data.GetData("PaymentCode");
            string Source = data.GetData("Source");
            string SubPayCode = data.GetData("SubPayCode");
            string PaymentAccount = data.GetData("PaymentAccount");
            string SubPaymentType = data.GetData("SubPaymentType");
            string SubPayDesc = data.GetData("SubPayDesc");
            string Class = data.GetData("Class");
            string CatCode = data.GetData("CatCode");
            string ASXCode = data.GetData("ASXCode");
            string ComponentDesc1 = data.GetData("ComponentDesc1");
            string ComponentAmount1 = data.GetData("ComponentAmount1");
            string ComponentDesc2 = data.GetData("ComponentDesc2");
            string ComponentAmount2 = data.GetData("ComponentAmount2");
            string ComponentDesc3 = data.GetData("ComponentDesc3");
            string ComponentAmount3 = data.GetData("ComponentAmount3");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV05");
            ENSDIV05.HolderIdentifier.ValidateFieldValue(HIN);
            ENSDIV05.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV05.IncomeSource.ValidateFieldValue(Source);
            ENSDIV05.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV05.SubPayAccCode.ValidateFieldValue(PaymentAccount);
            ENSDIV05.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV05.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV05.ClsCode.ValidateFieldValue(Class);
            ENSDIV05.CatCode.ValidateFieldValue(CatCode);
            ENSDIV05.SecAsxCode.ValidateFieldValue(ASXCode);
            ENSDIV05.ComponentDesc.ValidateFieldValue(1, ComponentDesc1);
            ENSDIV05.ComponentAmt.ValidateFieldValue(1, ComponentAmount1);
            ENSDIV05.ComponentDesc.ValidateFieldValue(2, ComponentDesc2);
            ENSDIV05.ComponentAmt.ValidateFieldValue(2, ComponentAmount2);
            ENSDIV05.ComponentDesc.ValidateFieldValue(3, ComponentDesc3);
            ENSDIV05.ComponentAmt.ValidateFieldValue(3, ComponentAmount3);
        }

        [Then(@"In ENSDIV05 I should see Dividend History Class Components as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDividendHistoryClassComponents(string PaymentCode, string Source, string SubPayCode, string PaymentAccount, string SubPaymentType, string SubPayDesc, string PaymentDate, string Class, string ClassDesc, string ComponentDesc1, string ComponentAmount1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV05");

            ENSDIV05.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV05.IncomeSource.ValidateFieldValue(Source);
            ENSDIV05.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV05.SubPayAccCode.ValidateFieldValue(PaymentAccount);
            ENSDIV05.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV05.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV05.ClsCode.ValidateFieldValue(Class);
            ENSDIV05.ComponentDesc.ValidateFieldValue(1, ComponentDesc1);
            ENSDIV05.ComponentAmt.ValidateFieldValue(1, ComponentAmount1);
        }

        [Then(@"In ENSDIV03 I should see Dividend History Component as below:")]
        public void ShouldSeeDividendHistoryComponent(Table data)
        {
            string HIN = data.GetData("HIN");
            string PaymentCode = data.GetData("PaymentCode");
            string Source = data.GetData("Source");
            string SubPayCode = data.GetData("SubPayCode");
            string SubPaymentType = data.GetData("SubPaymentType");
            string SubPayDesc = data.GetData("SubPayDesc");
            string PaymentAccount = data.GetData("PaymentAccount");
            string PaymentDate = data.GetData("PaymentDate");
            string ComponentDesc1 = data.GetData("ComponentDesc1");
            string ComponentAmount1 = data.GetData("ComponentAmount1");
            string ComponentDesc2 = data.GetData("ComponentDesc2");
            string ComponentAmount2 = data.GetData("ComponentAmount2");
            string ComponentDesc3 = data.GetData("ComponentDesc3");
            string ComponentAmount3 = data.GetData("ComponentAmount3");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV03");
            ENSDIV03.HolderIdentifier.ValidateFieldValue(HIN);
            ENSDIV03.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV03.IncomeSource.ValidateFieldValue(Source);
            ENSDIV03.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV03.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV03.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV03.SubPayAccCode.ValidateFieldValue(PaymentAccount);
            ENSDIV03.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSDIV03.ComponentDesc.ValidateFieldValue(1, ComponentDesc1);
            ENSDIV03.ComponentAmt.ValidateFieldValue(1, ComponentAmount1);
            ENSDIV03.ComponentDesc.ValidateFieldValue(2, ComponentDesc2);
            ENSDIV03.ComponentAmt.ValidateFieldValue(2, ComponentAmount2);
            ENSDIV03.ComponentDesc.ValidateFieldValue(3, ComponentDesc3);
            ENSDIV03.ComponentAmt.ValidateFieldValue(3, ComponentAmount3);
        }

        [Then(@"In ENSDIV03 I should see Dividend History Component as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDividendHistoryComponent(string PaymentCode, string Source, string SubPayCode, string SubPaymentType, string SubPayDesc, string PaymentAccount, string PaymentDate, string ComponentDesc1, string ComponentAmount1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV03");
            ENSDIV03.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV03.IncomeSource.ValidateFieldValue(Source);
            ENSDIV03.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV03.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV03.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV03.SubPayAccCode.ValidateFieldValue(PaymentAccount);
            ENSDIV03.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSDIV03.ComponentDesc.ValidateFieldValue(1, ComponentDesc1);
            ENSDIV03.ComponentAmt.ValidateFieldValue(1, ComponentAmount1);
        }

        [Then(@"In ENSDIV04 I should see Dividend Sub Payment Summary as below:")]
        public void ShouldSeeDividendSubPaymentSummary(Table data)
        {
            string HIN = data.GetData("HIN");
            string PaymentCode = data.GetData("PaymentCode");
            string Source = data.GetData("Source");
            string SubPayCode = data.GetData("SubPayCode");
            string PaymentAccount = data.GetData("PaymentAccount");
            string SubPaymentType = data.GetData("SubPaymentType");
            string SubPayDesc = data.GetData("SubPayDesc");
            string SubPaymentAccount = data.GetData("SubPaymentAccount");
            string PaymentDate = data.GetData("PaymentDate");
            string Class = data.GetData("Class");
            string CatCode = data.GetData("CatCode");
            string ASXCode = data.GetData("ASXCode");
            string DetailUnits = data.GetData("DetailUnits");
            string PaymentRate = data.GetData("PaymentRate");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV04");
            ENSDIV04.HolderIdentifier.ValidateFieldValue(HIN);
            ENSDIV04.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV04.IncomeSource.ValidateFieldValue(Source);
            ENSDIV04.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV04.SubPayAccCode.ValidateFieldValue(PaymentAccount);
            ENSDIV04.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV04.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV04.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSDIV04.ClsCode.ValidateFieldValue(Class);
            ENSDIV04.CatCode.ValidateFieldValue(CatCode);
            ENSDIV04.SecAsxCode.ValidateFieldValue(ASXCode);
            ENSDIV04.ClassUnits.ValidateFieldValue(DetailUnits);
            ENSDIV04.PaymentRate.ValidateFieldValue(PaymentRate);
        }

        [Then(@"In ENSDIV04 I should see Dividend Sub Payment Summary as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDividendSubPaymentSummary(string PaymentCode, string Source, string SubPayCode, string PaymentAccount, string SubPaymentType, string SubPayDesc, string PaymentDate, string Class, string DetailUnits, string PaymentRate)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV04");
            ENSDIV04.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV04.IncomeSource.ValidateFieldValue(Source);
            ENSDIV04.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV04.SubPayAccCode.ValidateFieldValue(PaymentAccount);
            ENSDIV04.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV04.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV04.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSDIV04.ClsCode.ValidateFieldValue(Class);
            ENSDIV04.ClassUnits.ValidateFieldValue(DetailUnits);
            ENSDIV04.PaymentRate.ValidateFieldValue(PaymentRate);
        }

        [Then(@"In ENS01040 I should see Duplicate Certificate details as below:")]
        public void ShouldSeeDuplicateCerificateDetails(Table data)
        {
            string SelectedCert = data.GetData("Selected Certificate");
            string CertLine1 = data.GetData("Certificate Line1");
            string CertLine2 = data.GetData("Certificate Line2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01040");
            ENS01040.SelectedCert.ValidateFieldValue(SelectedCert);
            ENS01040.DupCertLine.ValidateFieldValue(1, CertLine1);
            ENS01040.DupCertLine.ValidateFieldValue(2, CertLine2);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENS01040 I should see Duplicate Certificate details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDuplicateCerificateDetails(string CertID, string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01040");
            ENS01040.SelectedCert.ValidateFieldValue(CertID);
            ENS01040.DupCertLine.ValidateFieldValue(1, Line1);
            ENS01040.DupCertLine.ValidateFieldValue(2, Line2);
            ENS01040.DupCertLine.ValidateFieldValue(3, Line3);
            ENS01040.DupCertLine.ValidateFieldValue(4, Line4);
            ENS01040.DupCertLine.ValidateFieldValue(5, Line5);
            ENS01040.DupCertLine.ValidateFieldValue(6, Line6);
            ENS01040.DupCertLine.ValidateFieldValue(7, Line7);
            ENS01040.DupCertLine.ValidateFieldValue(8, Line8);
            ENS01040.DupCertLine.ValidateFieldValue(9, Line9);
            ENS01040.DupCertLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"In ENSESS05 I should see Employee Expand History ""(.*)"" as below:")]
        public void ShouldSeeEmployeeExpandHistory(string side, Table data)
        {
            string OnHIN = data.GetData("On HIN");
            string OnClass = data.GetData("On Class");
            string OnRegister = data.GetData("On Register");
            string OnCertID = data.GetData("On Certificate ID");
            string OnUnits = data.GetData("On Units");
            string OnTotalCost = data.GetData("On Total Cost");
            string OnShareCost = data.GetData("On Share Cost");
            string OffHIN = data.GetData("Off HIN");
            string OffClass = data.GetData("Off Class");
            string OffRegister = data.GetData("Off Register");
            string OffCertID = data.GetData("Off Certificate ID");
            string OffUnits = data.GetData("Off Units");
            string OffTotalCost = data.GetData("Off Total Cost");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS05");

            switch (side.ToLower())
            {
                case "on":

                    ENSESS05.ONHin.ValidateFieldValue(OnHIN);
                    ENSESS05.ONClass.ValidateFieldValue(OnClass);
                    ENSESS05.ONReg.ValidateFieldValue(OnRegister);
                    ENSESS05.ONCertID.ValidateFieldValue(OnCertID);
                    ENSESS05.ONUnitValue.ValidateFieldValue(OnUnits);
                    ENSESS05.ONValue.ValidateFieldValue(1, OnTotalCost);
                    ENSESS05.ONValue.ValidateFieldValue(2, OnShareCost);
                    break;

                case "off":

                    ENSESS05.OffHin.ValidateFieldValue(OffHIN);
                    ENSESS05.OffClass.ValidateFieldValue(OffClass);
                    ENSESS05.OffReg.ValidateFieldValue(OffRegister);
                    ENSESS05.OffCertID.ValidateFieldValue(OffCertID);
                    ENSESS05.OffUnitValue.ValidateFieldValue(OffUnits);
                    ENSESS05.OffValue.ValidateFieldValue(OffTotalCost);
                    break;

                default:
                    break;
            }
        }

        [Then(@"In ENS01043 I should see Employee Share Plan Summary as below:")]
        public void ShouldSeeEmployeeSharePlanSummary(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01043");
            ENS01043.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01043.EssLine.ValidateFieldValue(1, Line1);
            ENS01043.EssLine.ValidateFieldValue(2, Line2);
            ENS01043.EssLine.ValidateFieldValue(3, Line3);
            ENS01043.EssLine.ValidateFieldValue(4, Line4);
            ENS01043.EssLine.ValidateFieldValue(5, Line5);
            ENS01043.EssLine.ValidateFieldValue(6, Line6);
            ENS01043.EssLine.ValidateFieldValue(7, Line7);
            ENS01043.EssLine.ValidateFieldValue(8, Line8);
            ENS01043.EssLine.ValidateFieldValue(9, Line9);
            ENS01043.EssLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"In ENS04030 I should see EOM as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeEOM(string EOM1, string EOM2, string EOM3, string EOM4, string EOM5, string EOM6, string EOM7, string EOM8, string EOM9, string EOM10, string EOM11, string EOM12, string EOM13, string EOM14, string EOM15, string EOM16, string EOM17, string EOM18)
        {
            ENS04030.Eom.ValidateFieldValue(1, EOM1);
            ENS04030.Eom.ValidateFieldValue(2, EOM2);
            ENS04030.Eom.ValidateFieldValue(3, EOM3);
            ENS04030.Eom.ValidateFieldValue(4, EOM4);
            ENS04030.Eom.ValidateFieldValue(5, EOM5);
            ENS04030.Eom.ValidateFieldValue(6, EOM6);
            ENS04030.Eom.ValidateFieldValue(7, EOM7);
            ENS04030.Eom.ValidateFieldValue(8, EOM8);
            ENS04030.Eom.ValidateFieldValue(9, EOM9);
            ENS04030.Eom.ValidateFieldValue(10, EOM10);
            ENS04030.Eom.ValidateFieldValue(11, EOM11);
            ENS04030.Eom.ValidateFieldValue(12, EOM12);
            ENS04030.Eom.ValidateFieldValue(13, EOM13);
            ENS04030.Eom.ValidateFieldValue(14, EOM14);
            ENS04030.Eom.ValidateFieldValue(15, EOM15);
            ENS04030.Eom.ValidateFieldValue(16, EOM16);
            ENS04030.Eom.ValidateFieldValue(17, EOM17);
            ENS04030.Eom.ValidateFieldValue(18, EOM18);
        }

        [Then(@"In ENSESS16 I should see ESS Payment Holding Extra Details as below:")]
        public void ShouldSeeESSPaymentHoldingExtraDetails(Table data)
        {
            string StoppedSaving = data.GetData("StoppedSaving");
            string NbrOfTimesRestarted = data.GetData("NbrOfTimesRestarted");
            string ResidualInstruction = data.GetData("ResidualInstruction");
            string HoldingPeriodMonth = data.GetData("HoldingPeriodMonth");
            string HoldingPeriodDay = data.GetData("HoldingPeriodDay");
            string TaxationPeriodMonth = data.GetData("TaxationPeriodMonth");
            string TaxationPeriodDay = data.GetData("TaxationPeriodDay");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS16");
            ENSESS16.StoppedSaving.ValidateFieldValue(StoppedSaving);
            ENSESS16.NbrRestarts.ValidateFieldValue(NbrOfTimesRestarted);
            ENSESS16.ResidualInd.ValidateFieldValue(ResidualInstruction);
            ENSESS16.HoldEndPrdMths.ValidateFieldValue(HoldingPeriodMonth);
            ENSESS16.HoldEndPrdDays.ValidateFieldValue(HoldingPeriodDay);
            ENSESS16.TaxEndPrdMths.ValidateFieldValue(TaxationPeriodMonth);
            ENSESS16.TaxEndPrdDays.ValidateFieldValue(TaxationPeriodDay);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENSESS55 I should see ESS Tax Reporting as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeESSTaxReporting(string Line1, string Line2, string Line3, string Line4, string Line5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS55");
            ENSESS55.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS55.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS55.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS55.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS55.DetailLine.ValidateFieldValue(5, Line5);
        }

        [Then(@"In ENSESS56 I should see ESS Tax Reporting Extra Details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeESSTaxReportingExtraDetails(string Class, string FY, string ExtraLine1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS56");
            ENSESS56.ClassCodeParm.ValidateFieldValue(Class);
            ENSESS56.FinYearParm.ValidateFieldValue(FY);
            ENSESS56.DetailLine.ValidateFieldValue(1, ExtraLine1);
        }

        [Then(@"In ENSESS40 I should see Event History Details as below:")]
        public void ShouldSeeEventHistoryDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS40");
            ENSESS40.HolderID.ValidateFieldValue(HIN);
            ENSESS40.SchemeCode.ValidateFieldValue(Plan);
            ENSESS40.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS40.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS40.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS40.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS40.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS40.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS40.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS40.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS40.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS40.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS40.DetailLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"In ENSESS46 I should see Event Transaction Details as below:")]
        public void ShouldSeeEventTransactionDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string EventType = data.GetData("EventType");
            string EventCode = data.GetData("EventCode");
            string EventDesc = data.GetData("EventDesc");
            string Register = data.GetData("Register");
            string RegisterType = data.GetData("RegisterType");
            string EventDate = data.GetData("EventDate");
            string Certificate = data.GetData("Certificate");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS46");
            ENSESS46.HolderID.ValidateFieldValue(HIN);
            ENSESS46.SchemeCode.ValidateFieldValue(Plan);
            ENSESS46.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS46.EventType.ValidateFieldValue(EventType);
            ENSESS46.EventCode.ValidateFieldValue(EventCode);
            ENSESS46.EventDescription.ValidateFieldValue(EventDesc);
            ENSESS46.RegisterCode.ValidateFieldValue(Register);
            ENSESS46.RegisterType.ValidateFieldValue(RegisterType);
            ENSESS46.EventDate.ValidateFieldValue(EventDate);
            ENSESS46.CertificateID.ValidateFieldValue(Certificate);
            ENSESS46.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS46.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS46.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS46.DetailLine.ValidateFieldValue(4, Line4);
        }

        [Then(@"In ENSSPLBP I should see Extra Dividend History as below:")]
        public void ShouldSeeExtraDividendHistory(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string Class = data.GetData("Class");
            string Regisrter = data.GetData("Regisrter");
            string CertNbr = data.GetData("Cert Nbr");
            string Units = data.GetData("Units");
            string BulkID = data.GetData("Bulk ID");
            string BulkTran = data.GetData("Bulk Tran");
            string TradeDate = data.GetData("Trade Date");
            string SettlementDate = data.GetData("Settlement Date");
            string Price = data.GetData("Price");
            string ShareCost = data.GetData("Cost of Shares");
            string Charges = data.GetData("Charges");
            string TotalCost = data.GetData("Total Cost");
            string AmountReceived = data.GetData("Amount Received");
            string ResiduePaid = data.GetData("Residue Paid");
            string ResidueKept = data.GetData("Residue Kept");
            string Commission = data.GetData("Commission");
            string StampDuty = data.GetData("Stamp Duty");
            string OtherCharges = data.GetData("Other Charges");
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSPLBP");

            ENSSPLBP.HolderNameKey.ValidateFieldValue(NameKey);
            ENSSPLBP.HolderIdentifier.ValidateFieldValue(HIN);
            ENSSPLBP.HolderTypeCode.ValidateFieldValue(HolderType);
            ENSSPLBP.ClassCode.ValidateFieldValue(Class);
            ENSSPLBP.RegisterCode.ValidateFieldValue(Regisrter);
            ENSSPLBP.CertIdentifier.ValidateFieldValue(CertNbr);
            ENSSPLBP.Units.ValidateFieldValue(Units);
            ENSSPLBP.BulkID.ValidateFieldValue(BulkID);
            ENSSPLBP.BulkReference.ValidateFieldValue(BulkTran);
            ENSSPLBP.TradeDate.ValidateFieldValue(TradeDate);
            ENSSPLBP.SettleDate.ValidateFieldValue(SettlementDate);
            ENSSPLBP.Price.ValidateFieldValue(Price);
            ENSSPLBP.CostOFShares.ValidateFieldValue(ShareCost);
            ENSSPLBP.TotalCost.ValidateFieldValue(TotalCost);
            ENSSPLBP.AmountReceived.ValidateFieldValue(AmountReceived);
            ENSSPLBP.ResiduePaid.ValidateFieldValue(ResiduePaid);
            ENSSPLBP.ResidueKept.ValidateFieldValue(ResidueKept);
            ENSSPLBP.Commission.ValidateFieldValue(Commission);
            ENSSPLBP.StampDuty.ValidateFieldValue(StampDuty);
            ENSSPLBP.StampDuty.ValidateFieldValue(OtherCharges);

            Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In ENS01010 I should see Extra Payment Details as below:")]
        public void ShouldSeeExtraPaymentDetails(Table data)
        {
            string ExtraDetails1 = data.GetData("ExtraDetails1");
            string ExtraDetails2 = data.GetData("ExtraDetails2");
            ENS01010.ExtraDetails.ValidateFieldValue(1, ExtraDetails1);
            ENS01010.ExtraDetails.ValidateFieldValue(2, ExtraDetails2);
        }

        [Then(@"In ENS01053 I should see Extra Register details as below:")]
        public void ShouldSeeExtraRegisterDetails(Table data)
        {
            string Line1 = data.GetData("Line1");
            ENS01053.ExtraCertDetails.ValidateFieldValue(2, Line1);
        }

        [Then(@"In ENS01053 I should see Extra Register details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeExtraRegisterDetails(string ExtraLine1, string ExtraLine2, string ExtraLine3, string ExtraLine4, string ExtraLine5, string ExtraLine6)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01053");
            ENS01053.ExtraCertDetails.ValidateFieldValue(2, ExtraLine1);
            ENS01053.ExtraCertDetails.ValidateFieldValue(4, ExtraLine2);
            ENS01053.ExtraCertDetails.ValidateFieldValue(6, ExtraLine3);
            ENS01053.ExtraCertDetails.ValidateFieldValue(8, ExtraLine4);
            ENS01053.ExtraCertDetails.ValidateFieldValue(9, ExtraLine5);
            ENS01053.ExtraCertDetails.ValidateFieldValue(13, ExtraLine6);
        }

        [Then(@"In ENSESS12 I should see Forfeiture Details as below:")]
        public void ShouldSeeForfeitureDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("Plan Desc");
            string Register = data.GetData("Register");
            string CertificateID = data.GetData("Certificate");
            string TotalUnits = data.GetData("Total Units");
            string ForfeitureType = data.GetData("Forfeiture Type");
            string ForfeitureUnits = data.GetData("Forfeiture Units");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS12");

            ENSESS12.HolderIdentifier.ValidateFieldValue(HIN);
            ENSESS12.SchemeCode.ValidateFieldValue(Plan);
            ENSESS12.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS12.Reg.ValidateFieldValue(Register);
            ENSESS12.CertID.ValidateFieldValue(CertificateID);
            ENSESS12.AvailUnits.ValidateFieldValue(TotalUnits);
            ENSESS12.ForfType.ValidateFieldValue(ForfeitureType);
            ENSESS12.ForfUnits.ValidateFieldValue(ForfeitureUnits);
        }

        [Then(@"In ENSESS01 I should see full holder Employee Details as below:")]
        public void ShouldSeeFullHolderEmployeeDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Postcode = data.GetData("Postcode");
            string AutoForfeit = data.GetData("AutoForfeit");
            string BirthDate = data.GetData("BirthDate");
            string Leavercode = data.GetData("Leavercode");
            string LeaverCodeDesc = data.GetData("LeaverCodeDesc");
            string BlackoutRestricted = data.GetData("BlackoutRestricted");
            string BlackoutRestrictedCode = data.GetData("BlackoutRestrictedCode");
            string BlackoutRestrictedDesc = data.GetData("BlackoutRestrictedDesc");
            string PayrollID = data.GetData("PayrollID");
            string EmployeeID = data.GetData("EmployeeID");
            string SubPayrollID = data.GetData("SubPayrollID");
            string EmployeeUniqueID = data.GetData("EmployeeUniqueID");
            string EmployeeStatus = data.GetData("EmployeeStatus");
            string EmployeeStatusDesc = data.GetData("EmployeeStatusDesc");
            string EffectiveDate = data.GetData("EffectiveDate");
            string LeaverPack = data.GetData("LeaverPack");
            string LeaverPackSentDate = data.GetData("LeaverPackSentDate");
            string TerminationDate = data.GetData("TerminationDate");
            string TerminationDesc = data.GetData("TerminationDesc");
            string PreferredName = data.GetData("PreferredName");
            string LocationCode = data.GetData("LocationCode");
            string BusinessUnit = data.GetData("BusinessUnit");
            string JobBand = data.GetData("JobBand");
            string CostCentre = data.GetData("CostCentre");
            string EmployeeFlag1 = data.GetData("EmployeeFlag1");
            string EmployeeFlag2 = data.GetData("EmployeeFlag2");
            string GSPEmployee = data.GetData("GSPEmployee");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS01");
            ENSESS01.PayrollID.ValidateFieldValue(PayrollID);
            ENSESS01.EmployeeNumber.ValidateFieldValue(EmployeeID);
            ENSESS01.SubPayrollID.ValidateFieldValue(SubPayrollID);
            ENSESS01.EmployeeUniqueID.ValidateFieldValue(EmployeeUniqueID);
            ENSESS01.EmployeeStatus.ValidateFieldValue(EmployeeStatus);
            ENSESS01.StatusDescription.ValidateFieldValue(EmployeeStatusDesc);
            ENSESS01.EffectiveDate.ValidateFieldValue(EffectiveDate);
            ENSESS01.LeaverPack.ValidateFieldValue(LeaverPack);
            ENSESS01.LeaverPackSentDate.ValidateFieldValue(LeaverPackSentDate);
            ENSESS01.TermDate.ValidateFieldValue(TerminationDate);
            ENSESS01.TermDesc.ValidateFieldValue(TerminationDesc);
            //ENSESS01.StartDate.ValidateFieldValue(StartDate);
            ENSESS01.PreferredName.ValidateFieldValue(PreferredName);
            ENSESS01.LocationCode.ValidateFieldValue(LocationCode);
            ENSESS01.BusinessUnit.ValidateFieldValue(BusinessUnit);
            ENSESS01.JobBand.ValidateFieldValue(JobBand);
            ENSESS01.CostCentre.ValidateFieldValue(CostCentre);
            ENSESS01.EmployeeFlag1.ValidateFieldValue(EmployeeFlag1);
            ENSESS01.EmployeeFlag2.ValidateFieldValue(EmployeeFlag2);
            ENSESS01.HolderIdentifier.ValidateFieldValue(HIN);
            ENSESS01.HolderTypeCode.ValidateFieldValue(Type);
            ENSESS01.HnaLine.ValidateFieldValue(1, Name);
            ENSESS01.HnaLine.ValidateFieldValue(2, Address1);
            ENSESS01.HnaLine.ValidateFieldValue(3, Address2);
            ENSESS01.Postcode.ValidateFieldValue(Postcode);
            ENSESS01.AutoForfeitureInd.ValidateFieldValue(AutoForfeit);
            ENSESS01.BirthDate.ValidateFieldValue(BirthDate);
            ENSESS01.LeaverCode.ValidateFieldValue(Leavercode);
            ENSESS01.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
            ENSESS01.BlkoutRstrctdInd.ValidateFieldValue(BlackoutRestricted);
            ENSESS01.BlkoutRstrctdCode.ValidateFieldValue(BlackoutRestrictedCode);
            ENSESS01.BlkoutRstrctdDesc.ValidateFieldValue(BlackoutRestrictedDesc);
        }

        [Then(@"In ENSESS26 I should see Future Vesting Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeFutureVestingDetails(string Plan, string PlanDesc, string Line1, string Line2, string Line3, string Line4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS26");
            ENSESS26.SchemeCode.ValidateFieldValue(Plan);
            ENSESS26.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS26.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS26.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS26.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS26.DetailLine.ValidateFieldValue(4, Line4);
        }

        [Then(@"In ENS01012 I should see Holder Certificate details as below:")]
        public void ShouldSeeHolderCertificateDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");
            string Line11 = data.GetData("Line11");
            string Line12 = data.GetData("Line12");
            string Line13 = data.GetData("Line13");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01012");
            ENS01012.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01012.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01012.CertificateLine.ValidateFieldValue(2, Line2);
            ENS01012.CertificateLine.ValidateFieldValue(3, Line3);
            ENS01012.CertificateLine.ValidateFieldValue(4, Line4);
            ENS01012.CertificateLine.ValidateFieldValue(5, Line5);
            ENS01012.CertificateLine.ValidateFieldValue(6, Line6);
            ENS01012.CertificateLine.ValidateFieldValue(7, Line7);
            ENS01012.CertificateLine.ValidateFieldValue(8, Line8);
            ENS01012.CertificateLine.ValidateFieldValue(9, Line9);
            ENS01012.CertificateLine.ValidateFieldValue(10, Line10);
            ENS01012.CertificateLine.ValidateFieldValue(11, Line11);
            ENS01012.CertificateLine.ValidateFieldValue(12, Line12);
            ENS01012.CertificateLine.ValidateFieldValue(13, Line13);
        }

        [Then(@"in ENS01066 I should see holder Charity Election details as below:")]
        public void ShouldSeeHolderCharityElectionDetails(Table data)
        {
            string Key = data.GetData("Key");
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string Name1 = data.GetData("Name1");
            string Name2 = data.GetData("Name2");
            string Class = data.GetData("Class");
            string Option = data.GetData("Option");
            string Level = data.GetData("Level");
            string CharityCode = data.GetData("CharityCode");
            string Date = data.GetData("Date");
            string Run = data.GetData("Run");
            string Tran = data.GetData("Tran");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01066");
            ENS01066.HolderNameKey.ValidateFieldValue(Key);
            ENS01066.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01066.HolderTypeCode.ValidateFieldValue(Type);
            ENS01066.HnaLine.ValidateFieldValue(1, Name1);
            ENS01066.HnaLine.ValidateFieldValue(2, Name2);
            ENS01066.ClassCode.ValidateFieldValue(Class);
            ENS01066.ParticipationOption.ValidateFieldValue(Option);
            ENS01066.ParticipationLevel.ValidateFieldValue(Level);
            ENS01066.CharityCode.ValidateFieldValue(CharityCode);
            ENS01066.LastChangeDate.ValidateFieldValue(Date);
            ENS01066.LastChangeRun.ValidateFieldValue(Run);
        }

        [Then(@"In ENS01005 I should see holder Deceased Estate Notings Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderDeceasedEstateNotingsPart1(string NotingNbr, string Key, string Register, string DeceasedName, string Run, string Tran, string HIN, string Type, string DOD, string DeathCertSighted, string Willdated, string SmallEstate, string Sighted, string ProbategrantedIn, string ProbateOnDate)
        {
            //Run = Spartan.Core.WinForms.WinFormsDriver.GetRunNumber("SYSTEM-INFO-FREE-4");
            //Tran = Spartan.Core.WinForms.WinFormsDriver.GetRunNumber("LC-TRANS-NUMBER");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01005");
            ENS01005.NotingIdentifier.ValidateFieldValue(NotingNbr);
            ENS01005.HolderNameKey.ValidateFieldValue(Key);
            ENS01005.Register.ValidateFieldValue(Register);
            ENS01005.DeceasedNameLine.ValidateFieldValue(DeceasedName);
            //ENS01005.Run.ValidateFieldValue(Run);
            //ENS01005.Tran.ValidateFieldValue(Tran);
            ENS01005.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01005.HolderTypeCode.ValidateFieldValue(Type);
            ENS01005.DeathDate.ValidateFieldValue(DOD);
            ENS01005.DeathSightedDate.ValidateFieldValue(DeathCertSighted);
            ENS01005.StatDecHeldFlag.ValidateFieldValue(SmallEstate);
            ENS01005.WillSightedDate.ValidateFieldValue(Sighted);
            ENS01005.ProbateGrantedIN.ValidateFieldValue(ProbategrantedIn);
            ENS01005.ProbateGrantedDate.ValidateFieldValue(ProbateOnDate);
        }

        [Then(@"In ENS01005 I should see holder Deceased Estate Notings Part2 as  ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderDeceasedEstateNotingsPart2(string ProbateSightedDate, string ResealedIn, string ResealedOnDate, string Sec1071B, string Sec121A, string ConfirmationofID, string Exors1, string Exors2, string Exors3, string Comment1, string Comment2, string Comment3, string Lodged)
        {
            ENS01005.ProbateSightedDate.ValidateFieldValue(ProbateSightedDate);
            ENS01005.ResealedIN.ValidateFieldValue(ResealedIn);
            ENS01005.ResealedDate.ValidateFieldValue(ResealedOnDate);
            ENS01005.Sec183State.ValidateFieldValue(Sec1071B);
            ENS01005.A121SightedInd.ValidateFieldValue(Sec121A);
            ENS01005.ConfirmIDInd.ValidateFieldValue(ConfirmationofID);
            ENS01005.Executor.ValidateFieldValue(1, Exors1);
            ENS01005.Executor.ValidateFieldValue(2, Exors2);
            ENS01005.DutyComment.ValidateFieldValue(Exors3);
            ENS01005.NotingComment70.ValidateFieldValue(1, Comment1);
            ENS01005.NotingComment70.ValidateFieldValue(2, Comment2);
            ENS01005.NotingComment70.ValidateFieldValue(3, Comment3);
            ENS01005.LodgedBYComment.ValidateFieldValue(Lodged);
        }

        [Then(@"In ENS01001 I should see holder details as below:")]
        public void ShouldSeeHolderDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string PostCode = data.GetData("Post Code");
            string TaxCode = data.GetData("TAX Code");
            string TFNDesc = data.GetData("TFN Desc");
            string ABNDesc = data.GetData("ABN Desc");
            string GroupCode = data.GetData("Group");
            string Varfield = data.GetData("Var field");
            string BrokerCode = data.GetData("Broker Code");
            string KeyModifier = data.GetData("Key Modifier");
            string DPID = data.GetData("DPID");
            string AlternateID = data.GetData("Alternate ID");
            string Key = data.GetData("Key");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");
            string Deceased = data.GetData("Deceased");
            string Exception = data.GetData("Exception");
            string Suppress = data.GetData("Suppress");
            string RetMail = data.GetData("Ret Mail");
            string AReport = data.GetData("A/Report");
            string ARText = data.GetData("AR Nominated Text");
            string BirthDate = data.GetData("Birth Date");
            string StopTrade = data.GetData("Stop Trade");
            string DivSource = data.GetData("Div Source");
            string Residency = data.GetData("Residency");
            string VarFlag1 = data.GetData("Var Flag1");
            string VarFlag2 = data.GetData("Var Flag2");
            string VarFlag3 = data.GetData("Var Flag3");
            string VarFlag4 = data.GetData("Var Flag4");
            string VarFlag5 = data.GetData("Var Flag5");
            string Warning1 = data.GetData("Warning1");
            string Warning2 = data.GetData("Warning2");
            string Warning3 = data.GetData("Warning3");
            string Warning4 = data.GetData("Warning4");
            string Warning5 = data.GetData("Warning5");
            string Warning6 = data.GetData("Warning6");
            string RestrictInfo = data.GetData("Restrict Class info");

            ENS01001.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01001.HolderTypeCode.ValidateFieldValue(Type);
            ENS01001.Postcode.ValidateFieldValue(PostCode);
            ENS01001.HolderOtherTaxCode.ValidateFieldValue(TaxCode);
            ENS01001.TaxFileNumberDesc.ValidateFieldValue(TFNDesc);
            ENS01001.AbnDesc.ValidateFieldValue(ABNDesc);
            ENS01001.HolderGroupCode.ValidateFieldValue(GroupCode);
            ENS01001.VariableField.ValidateFieldValue(Varfield);
            ENS01001.HolderKeyModifier.ValidateFieldValue(KeyModifier);
            ENS01001.Dpid.ValidateFieldValue(DPID);
            ENS01001.HolderAlternateID.ValidateFieldValue(AlternateID);
            ENS01001.HolderNameKey.ValidateFieldValue(Key);
            ENS01001.HnaLine.ValidateFieldValue(2, Name);
            ENS01001.HnaLine.ValidateFieldValue(3, Address1);
            ENS01001.HnaLine.ValidateFieldValue(4, Address2);
            ENS01001.HnaLine.ValidateFieldValue(5, Address3);
            ENS01001.HnaLine.ValidateFieldValue(6, Address4);
            ENS01001.HnaLine.ValidateFieldValue(7, Address5);
            ENS01001.Array1.ValidateFieldValue(1, Deceased);
            ENS01001.Array1.ValidateFieldValue(2, Exception);
            ENS01001.Array1.ValidateFieldValue(3, Suppress);
            ENS01001.MailUnclaimedDate.ValidateFieldValue(RetMail);
            ENS01001.HstAnnualReport.ValidateFieldValue(AReport);
            ENS01001.ARNominatedTxt.ValidateFieldValue(ARText);
            ENS01001.BirthDate.ValidateFieldValue(BirthDate);
            ENS01001.HstStopTrade.ValidateFieldValue(StopTrade);
            ENS01001.HstDividendIntent.ValidateFieldValue(DivSource);
            //ENS01001.Residency.ValidateFieldValue(Residency);
            ENS01001.HvfFlag.ValidateFieldValue(1, VarFlag1);
            ENS01001.HvfFlag.ValidateFieldValue(2, VarFlag2);
            ENS01001.HvfFlag.ValidateFieldValue(3, VarFlag3);
            //ENS01001.HvfFlag.ValidateFieldValue(2, VarFlag4);
            //ENS01001.HvfFlag.ValidateFieldValue(3, VarFlag5);
            ENS01001.Warnings.ValidateFieldValue(1, Warning1);
            ENS01001.Warnings.ValidateFieldValue(2, Warning2);
            ENS01001.Warnings.ValidateFieldValue(3, Warning3);
            ENS01001.Warnings.ValidateFieldValue(4, Warning4);
            ENS01001.Warnings.ValidateFieldValue(5, Warning5);
            ENS01001.Warnings.ValidateFieldValue(6, Warning6);
            ENS01001.RestrictClassInfo.ValidateFieldValue(RestrictInfo);

            if (PostCode != "GBR")
            {
                ENS01001.BrokerCode.ValidateFieldValue(BrokerCode);
            }
        }

        [Then(@"In ENS01001 I should see holder details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderDetails(string HIN, string Type, string PostCode, string TFN, string ABN, string Name)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01001.HolderTypeCode.ValidateFieldValue(Type);
            ENS01001.Postcode.ValidateFieldValue(PostCode);
            ENS01001.TaxFileNumberDesc.ValidateFieldValue(TFN);
            ENS01001.AbnDesc.ValidateFieldValue(ABN);
            ENS01001.HnaLine.ValidateFieldValue(2, Name);
        }

        [Then(@"In ENS01036 I should see Holder details as HIN ""(.*)"" NameAddress ""(.*)"" Postcode ""(.*)""")]
        public void ShouldSeeHolderDetailsAs(string HIN, string NameAddress, string Postcode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01036");
            ENS01036.HolderIdentifier.ValidateFieldValue(1, HIN);
            ENS01036.HolderNameAddress.ValidateFieldValue(1, NameAddress);
            ENS01036.Postcode.ValidateFieldValue(1, Postcode);
        }

        [Then(@"In ENS01060 I should see holder Dividend Intention Details as below:")]
        public void ShouldSeeHolderDividendIntentionDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string DRPIntention = data.GetData("DRP Intention");
            //string DIVSourceDesc = data.GetData("DIV Source Desc");
            //string DIVSource = data.GetData("DIV Source");
            string Run = WinFormsTestSteps.GetRunNumber();
            DRPIntention = DRPIntention.Replace("4402", Run);

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01060");
            ENS01060.HolderIdentifier.ValidateFieldValue(HIN);
            //ENS01060.SourceDesc.ValidateFieldValue(DIVSourceDesc);
            //ENS01060.SourceOption.ValidateFieldValue(DIVSource);
            ENS01060.DrpLine.ValidateFieldValue(5, DRPIntention);
        }

        [Then(@"In ENS01060 I should see holder Dividend Intention Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderDividendIntentionDetails(string HIN, string Type, string BSP1, string BSP2, string DivSource, string DRP1, string DRP2, string DRP3, string DRP4, string DRP5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01060");
            ENS01060.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01060.HolderTypeCode.ValidateFieldValue(Type);
            ENS01060.BspLine.ValidateFieldValue(1, BSP1);
            ENS01060.BspLine.ValidateFieldValue(2, BSP2);
            ENS01060.SourceOption.ValidateFieldValue(DivSource);
            ENS01060.DrpLine.ValidateFieldValue(1, DRP1);
            ENS01060.DrpLine.ValidateFieldValue(2, DRP2);
            ENS01060.DrpLine.ValidateFieldValue(3, DRP3);
            ENS01060.DrpLine.ValidateFieldValue(4, DRP4);
            ENS01060.DrpLine.ValidateFieldValue(5, DRP5);
        }

        [Then(@"In ENSESS21 I should see holder extra details as below:")]
        public void ShouldSeeHolderExtraDetails(Table data)
        {
            string ForfeitureType = data.GetData("ForfeitureType");
            string ForfeitureStartDate = data.GetData("ForfeitureStartDate");
            string ForfeitureEndDate = data.GetData("ForfeitureEndDate");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS21");
            ENSESS21.Ensess21ForfeitureType1.ValidateFieldValue(ForfeitureType);
            ENSESS21.Ensess21ForfStartDate1.ValidateFieldValue(ForfeitureStartDate);
            ENSESS21.Ensess21ForfEndDate1.ValidateFieldValue(ForfeitureEndDate);
        }

        [Then(@"In ENS01001 I should see Holder ID ""(.*)"" as below")]
        public void ShouldSeeHolderID(string HolderID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.HolderIdentifier.ValidateFieldValue(HolderID);
        }

        [Then(@"In  ENS01003 I should see holder Power Of Attorney details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderPowerOfAttorneyDetailsPart1(string PANotingNbr, string Register, string DonorName1, string DonorName2, string PowerDated, string PowerNoted, string Attorney1, string Attorney2, string Attorney3, string Attorney4, string Jointly, string Severally, string AnyTwo)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01003");
            ENS01003.NotingNumber.ValidateFieldValue(PANotingNbr);
            ENS01003.RegisterCode.ValidateFieldValue(Register);
            ENS01003.DonorNameLine.ValidateFieldValue(1, DonorName1);
            ENS01003.DonorNameLine.ValidateFieldValue(2, DonorName2);
            ENS01003.PowerDated.ValidateFieldValue(PowerDated);
            ENS01003.PowerNoted.ValidateFieldValue(PowerNoted);
            ENS01003.AttorneysName.ValidateFieldValue(1, Attorney1);
            ENS01003.AttorneysName.ValidateFieldValue(2, Attorney2);
            ENS01003.AttorneysName.ValidateFieldValue(3, Attorney3);
            ENS01003.AttorneysName.ValidateFieldValue(4, Attorney4);

            ENS01003.AtsJointlyFlag.ValidateFieldValue(Jointly);
            ENS01003.AtsSeverallyFlag.ValidateFieldValue(Severally);
            ENS01003.AtsAnytwoFlag.ValidateFieldValue(AnyTwo);
        }

        [Then(@"In  ENS01003 I should see holder Power Of Attorney details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderPowerOfAttorneyDetailsPart2(string Others1, string Others2, string Buy, string Sell, string Vote, string AppointSubstitute, string StampedIn, string Comment1, string Comment2, string LodgedBy, string Run, string tran)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01003");
            ENS01003.AtsOtherComment.ValidateFieldValue(1, Others1);
            ENS01003.AtsOtherComment.ValidateFieldValue(2, Others2);
            ENS01003.PptBuyFlag.ValidateFieldValue(Buy);
            ENS01003.PptSellFlag.ValidateFieldValue(Sell);
            ENS01003.PptVoteFlag.ValidateFieldValue(Vote);
            ENS01003.PptAppsubFlag.ValidateFieldValue(AppointSubstitute);
            ENS01003.StampedINComment.ValidateFieldValue(StampedIn);
            ENS01003.NotingComment70.ValidateFieldValue(1, Comment1);
            ENS01003.NotingComment70.ValidateFieldValue(2, Comment2);
            ENS01003.LodgedBYComment.ValidateFieldValue(LodgedBy);
            ENS01003.LCRunNumber.ValidateFieldValue(Run);
            ENS01003.LCTransNumber.ValidateFieldValue(tran);
        }

        [Then(@"In ENS01001 I should see holder ""(.*)""  ""(.*)""  ""(.*)""  ""(.*)"" Warning details as below")]
        public void ShouldSeeHolderWarningDetails(string W1, string W2, string W3, string W4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.Warnings.ValidateFieldValue(1, W1);
            ENS01001.Warnings.ValidateFieldValue(2, W2);
            ENS01001.Warnings.ValidateFieldValue(3, W3);
            ENS01001.Warnings.ValidateFieldValue(4, W4);
        }

        [Then(@"In ENS01007 I should see Holdings details as below:")]
        public void ShouldSeeHoldingsDetails(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string PostCode = data.GetData("Post Code");
            string TaxCode = data.GetData("Tax Code");
            string GroupCode = data.GetData("Group Code");
            string BrokerCode = data.GetData("Broker Code");
            string KeyModifier = data.GetData("Key Modifier");
            string AlternateID = data.GetData("Alternate ID");
            string VarField = data.GetData("Var Field");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");
            string Line1Page1 = data.GetData("Line1 Page1");
            string Line2Page1 = data.GetData("Line2 Page1");
            string Line3Page1 = data.GetData("Line3 Page1");
            string Line4Page1 = data.GetData("Line4 Page1");
            string Line5Page1 = data.GetData("Line5 Page1");
            string Line6Page1 = data.GetData("Line6 Page1");
            string Line1Page2 = data.GetData("Line1 Page2");
            string Line2Page2 = data.GetData("Line2 Page2");
            string Line3Page2 = data.GetData("Line3 Page2");
            string Line4Page2 = data.GetData("Line4 Page2");
            string Line5Page2 = data.GetData("Line5 Page2");
            string Line6Page2 = data.GetData("Line6 Page2");
            string Line7Page2 = data.GetData("Line7 Page2");
            string Line8Page2 = data.GetData("Line8 Page2");
            string Line9Page2 = data.GetData("Line9 Page2");
            string Line10Page2 = data.GetData("Line10 Page2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01007");
            ENS01007.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01007.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01007.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS01007.Postcode.ValidateFieldValue(PostCode);
            ENS01007.HolderOtherTaxCode.ValidateFieldValue(TaxCode);
            ENS01007.HolderGroupCode.ValidateFieldValue(GroupCode);
            ENS01007.BrokerCode.ValidateFieldValue(BrokerCode);
            ENS01007.HolderKeyModifier.ValidateFieldValue(KeyModifier);
            ENS01007.HolderAlternateID.ValidateFieldValue(AlternateID);
            ENS01007.VariableField.ValidateFieldValue(VarField);
            ENS01007.AddressLine.ValidateFieldValue(2, Name);
            ENS01007.AddressLine.ValidateFieldValue(3, Address1);
            ENS01007.AddressLine.ValidateFieldValue(4, Address2);
            ENS01007.AddressLine.ValidateFieldValue(5, Address3);
            ENS01007.AddressLine.ValidateFieldValue(6, Address4);
            ENS01007.AddressLine.ValidateFieldValue(7, Address5);
            ENS01007.Last6Lines.ValidateFieldValue(1, Line1Page1);
            ENS01007.Last6Lines.ValidateFieldValue(2, Line2Page1);
            ENS01007.Last6Lines.ValidateFieldValue(3, Line3Page1);
            ENS01007.Last6Lines.ValidateFieldValue(4, Line4Page1);
            ENS01007.Last6Lines.ValidateFieldValue(5, Line5Page1);
            ENS01007.Last6Lines.ValidateFieldValue(6, Line6Page1);

            ENS01007.Action.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            //Need to fix this in the Spaaran framework
            //string errorText = "";
            //if (!Spartan.Core.WinForms.WinFormsDriver.HandleError(errorText))
            //{
            //    ExpectToBeInTheScreen("ENS01008");

            //    ENS01008.ClassLine.ValidateFieldValue(0, Line1Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(1, Line2Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(2, Line3Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(3, Line4Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(4, Line5Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(5, Line6Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(6, Line7Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(7, Line8Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(8, Line9Page2);
            //    ENS01008.ClassLine.ValidateFieldValue(9, Line10Page2);
            //}
        }

        [Then(@"In ENS01007 I should see Holdings details as below ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHoldingsDetails(string Line1, string Line2, string Line3, string Line4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01007");
            ENS01007.Last6Lines.ValidateFieldValue(1, Line1);
            ENS01007.Last6Lines.ValidateFieldValue(2, Line2);
            ENS01007.Last6Lines.ValidateFieldValue(3, Line3);
            ENS01007.Last6Lines.ValidateFieldValue(4, Line4);
        }

        [Then(@"In ENS01041 I should see IRL Taxpayer details as below:")]
        public void ShouldSeeIRLTaxpayerDetails(Table data)
        {
            string Key = data.GetData("Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("HolderType");
            string TaxCode = data.GetData("TaxCode");
            string MailNameAddress1 = data.GetData("MailNameAddress1");
            string MailNameAddress2 = data.GetData("MailNameAddress2");
            string MailNameAddress3 = data.GetData("MailNameAddress3");
            string MailPostcode = data.GetData("MailPostcode");
            string SCRIPNameAddress1 = data.GetData("SCRIPNameAddress1");
            string SCRIPNameAddress2 = data.GetData("SCRIPNameAddress2");
            string SCRIPNameAddress3 = data.GetData("SCRIPNameAddress3");
            string SCRIPPostcode = data.GetData("SCRIPPostcode");
            string BenificialNameAddress1 = data.GetData("BenificialNameAddress1");
            string BenificialNameAddress2 = data.GetData("BenificialNameAddress2");
            string BenificialNameAddress3 = data.GetData("BenificialNameAddress3");
            string BenificialPostcode = data.GetData("BenificialPostcode");
            string EntryType = data.GetData("EntryType");
            string TaxNameAddress1 = data.GetData("TaxNameAddress1");
            string TaxNameAddress2 = data.GetData("TaxNameAddress2");
            string TaxNameAddress3 = data.GetData("TaxNameAddress3");
            string TaxPostcode = data.GetData("TaxPostcode");
            string DateofBirth = data.GetData("DateofBirth");
            string SigCapacityType = data.GetData("SigCapacityType");
            string SigCapacity = data.GetData("SigCapacity");
            string DWTExpiry = data.GetData("DWTExpiry");
            string CertStatus = data.GetData("CertStatus");
            string CertStatusDesc = data.GetData("CertStatusDesc");

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS0104I");
            ENS0104I.HolderNameKey.ValidateFieldValue(Key);
            ENS0104I.HolderIdentifier.ValidateFieldValue(HIN);
            ENS0104I.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS0104I.MailAddrLine.ValidateFieldValue(1, MailNameAddress1);
            ENS0104I.MailAddrLine.ValidateFieldValue(2, MailNameAddress2);
            ENS0104I.MailAddrLine.ValidateFieldValue(3, MailNameAddress3);
            ENS0104I.MailAddrPCDom.ValidateFieldValue(MailPostcode);
            ENS0104I.ScripRegAddrLine.ValidateFieldValue(1, SCRIPNameAddress1);
            ENS0104I.ScripRegAddrLine.ValidateFieldValue(2, SCRIPNameAddress2);
            ENS0104I.ScripRegAddrLine.ValidateFieldValue(3, SCRIPNameAddress3);
            ENS0104I.ScripRegAddrPCDom.ValidateFieldValue(SCRIPPostcode);
            ENS0104I.BenAddrLine.ValidateFieldValue(1, BenificialNameAddress1);
            ENS0104I.BenAddrLine.ValidateFieldValue(2, BenificialNameAddress2);
            ENS0104I.BenAddrLine.ValidateFieldValue(3, BenificialNameAddress3);
            ENS0104I.BenAddrPCDom.ValidateFieldValue(BenificialPostcode);
            ENS0104I.EntityType.ValidateFieldValue(EntryType);
            ENS0104I.TaxAddrLine.ValidateFieldValue(1, TaxNameAddress1);
            ENS0104I.TaxAddrLine.ValidateFieldValue(2, TaxNameAddress2);
            ENS0104I.TaxAddrLine.ValidateFieldValue(3, TaxNameAddress3);
            ENS0104I.TaxAddrPCDom.ValidateFieldValue(TaxPostcode);
            //ENS01041.DateofBirth.ValidateFieldValue(DateofBirth);
            ENS0104I.SigCapType.ValidateFieldValue(SigCapacityType);
            ENS0104I.SigCapacity.ValidateFieldValue(SigCapacity);
            ENS0104I.DwtExpiryDT.ValidateFieldValue(DWTExpiry);
            ENS0104I.CertStatus.ValidateFieldValue(CertStatus);
            ENS0104I.CertStatusDesc.ValidateFieldValue(CertStatusDesc);
        }

        [Then(@"In ENS01041 I should see IRL Taxpayer details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeIRLTaxpayerDetailsPart1(string Key, string HIN, string HolderType, string TaxCode, string MailNameAddress1, string MailNameAddress2, string MailNameAddress3, string MailPostcode, string SCRIPNameAddress1, string SCRIPNameAddress2, string SCRIPNameAddress3, string SCRIPPostcode, string BenificialNameAddress1, string BenificialNameAddress2, string BenificialNameAddress3, string BenificialPostcode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS0104I");
            ENS0104I.HolderNameKey.ValidateFieldValue(Key);
            ENS0104I.HolderIdentifier.ValidateFieldValue(HIN);
            ENS0104I.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS0104I.MailAddrLine.ValidateFieldValue(1, MailNameAddress1);
            ENS0104I.MailAddrLine.ValidateFieldValue(2, MailNameAddress2);
            ENS0104I.MailAddrLine.ValidateFieldValue(3, MailNameAddress3);
            ENS0104I.MailAddrPCDom.ValidateFieldValue(MailPostcode);
            ENS0104I.ScripRegAddrLine.ValidateFieldValue(1, SCRIPNameAddress1);
            ENS0104I.ScripRegAddrLine.ValidateFieldValue(2, SCRIPNameAddress2);
            ENS0104I.ScripRegAddrLine.ValidateFieldValue(3, SCRIPNameAddress3);
            ENS0104I.ScripRegAddrPCDom.ValidateFieldValue(SCRIPPostcode);
            ENS0104I.BenAddrLine.ValidateFieldValue(1, BenificialNameAddress1);
            ENS0104I.BenAddrLine.ValidateFieldValue(2, BenificialNameAddress2);
            ENS0104I.BenAddrLine.ValidateFieldValue(3, BenificialNameAddress3);
            ENS0104I.BenAddrPCDom.ValidateFieldValue(BenificialPostcode);
        }

        [Then(@"In ENS01041 I should see IRL Taxpayer details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeIRLTaxpayerDetailsPart2(string EntryType, string TaxNameAddress1, string TaxNameAddress2, string TaxNameAddress3, string TaxPostcode, string SigCapacityType, string SigCapacity, string DWTExpiry, string CertStatus, string CertStatusDesc)
        {
            ENS0104I.EntityType.ValidateFieldValue(EntryType);
            ENS0104I.TaxAddrLine.ValidateFieldValue(1, TaxNameAddress1);
            ENS0104I.TaxAddrLine.ValidateFieldValue(2, TaxNameAddress2);
            ENS0104I.TaxAddrLine.ValidateFieldValue(3, TaxNameAddress3);
            ENS0104I.TaxAddrPCDom.ValidateFieldValue(TaxPostcode);
            //ENS01041.DateofBirth.ValidateFieldValue(DateofBirth);
            ENS0104I.SigCapType.ValidateFieldValue(SigCapacityType);
            ENS0104I.SigCapacity.ValidateFieldValue(SigCapacity);
            ENS0104I.DwtExpiryDT.ValidateFieldValue(DWTExpiry);
            ENS0104I.CertStatus.ValidateFieldValue(CertStatus);
            ENS0104I.CertStatusDesc.ValidateFieldValue(CertStatusDesc);
        }

        [Then(@"In ENS04030 I should see Last Run as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeLastRun(string LastRun1, string LastRun2, string LastRun3, string LastRun4, string LastRun5, string LastRun6, string LastRun7, string LastRun8, string LastRun9, string LastRun10, string LastRun11, string LastRun12, string LastRun13, string LastRun14, string LastRun15, string LastRun16, string LastRun17, string LastRun18)
        {
            ENS04030.LastRun.ValidateFieldValue(1, LastRun1);
            ENS04030.LastRun.ValidateFieldValue(2, LastRun2);
            ENS04030.LastRun.ValidateFieldValue(3, LastRun3);
            ENS04030.LastRun.ValidateFieldValue(4, LastRun4);
            ENS04030.LastRun.ValidateFieldValue(5, LastRun5);
            ENS04030.LastRun.ValidateFieldValue(6, LastRun6);
            ENS04030.LastRun.ValidateFieldValue(7, LastRun7);
            ENS04030.LastRun.ValidateFieldValue(8, LastRun8);
            ENS04030.LastRun.ValidateFieldValue(9, LastRun9);
            ENS04030.LastRun.ValidateFieldValue(10, LastRun10);
            ENS04030.LastRun.ValidateFieldValue(11, LastRun11);
            ENS04030.LastRun.ValidateFieldValue(12, LastRun12);
            ENS04030.LastRun.ValidateFieldValue(13, LastRun13);
            ENS04030.LastRun.ValidateFieldValue(14, LastRun14);
            ENS04030.LastRun.ValidateFieldValue(15, LastRun15);
            ENS04030.LastRun.ValidateFieldValue(16, LastRun16);
            ENS04030.LastRun.ValidateFieldValue(17, LastRun17);
            ENS04030.LastRun.ValidateFieldValue(18, LastRun18);
        }

        [Then(@"In ENSESS31 I should see Leaver Processing details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeLeaverProcessingDetails(string Plan, string PlanDesc, string Line1, string Line2, string Line3)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS31");
            ENSESS31.SchemeCode.ValidateFieldValue(Plan);
            ENSESS31.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS31.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS31.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS31.DetailLine.ValidateFieldValue(3, Line3);
        }

        [Then(@"In ENSESS32 I should see Leaver processing extra details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeLeaverProcessingExtraDetails(string Plan, string PlanDesc, string ExtraLine1, string ExtraLine2, string ExtraLine3, string ExtraLine4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS32");
            ENSESS32.SchemeCode.ValidateFieldValue(Plan);
            ENSESS32.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS32.DetailLine.ValidateFieldValue(1, ExtraLine1);
            ENSESS32.DetailLine.ValidateFieldValue(2, ExtraLine2);
            ENSESS32.DetailLine.ValidateFieldValue(3, ExtraLine3);
            ENSESS32.DetailLine.ValidateFieldValue(4, ExtraLine4);
        }

        [Then(@"In ENSESS34 I should see Leaver Processing Popup details as ""(.*)""")]
        public void ShouldSeeLeaverProcessingPopupDetails(string PopupLine1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS34");
            ENSESS34.PopupDetailLine.ValidateFieldValue(0, PopupLine1);
        }

        [Then(@"In ENSESS19 I should see Loan Balance as below:")]
        public void ShouldSeeLoanBalance(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS19");
            ENSESS19.HolderID.ValidateFieldValue(HIN);
            ENSESS19.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS19.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS19.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS19.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS19.DetailLine.ValidateFieldValue(5, Line5);
        }

        [Then(@"In ENSESS20 I should see Loan Extra details as below:")]
        public void ShouldSeeLoanExtraDetails(Table data)
        {
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Reg = data.GetData("Reg");
            string RegDesc = data.GetData("RegDesc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS20");
            ENSESS20.SchemeCode.ValidateFieldValue(Plan);
            ENSESS20.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS20.RegisterCode.ValidateFieldValue(Reg);
            ENSESS20.RegisterName.ValidateFieldValue(RegDesc);
            ENSESS20.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS20.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS20.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS20.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS20.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS20.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS20.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS20.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS20.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS20.DetailLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"In ENS01011 I should see Manual Journal as below:")]
        public void ShouldSeeManualJournal(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string Name = data.GetData("Name");
            string Address = data.GetData("Address");
            string PayAccountNbr = data.GetData("Pay Account Number");
            string PayAccountDesc = data.GetData("Pay Account Desc");
            string Tran1 = data.GetData("Transaction Details1");
            string Tran2 = data.GetData("Transaction Details2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01011");
            /* ENS01009.HolderNameKey.ValidateFieldValue(NameKey);
             ENS01009.HolderIdentifier.ValidateFieldValue(HIN);
             ENS01009.HnaLine1.ValidateFieldValue(Name);
             ENS01009.HnaLine2.ValidateFieldValue(Address);
             ENS01009.PayAccountNbr.ValidateFieldValue(PayAccountNbr);
             ENS01009.PayAccountDesc.ValidateFieldValue(PayAccountDesc);
             ENS01009.Line.ValidateFieldValue(0, Tran1);
             ENS01009.Line.ValidateFieldValue(1, Tran2); */
        }

        [Then(@"In ENS01011 I should see Manual Journal as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeManualJournal(string HIN, string PayAccountNbr, string PayAccountDesc, string Tran1, string Tran2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01011");
            ENS01011.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01011.PayAccountNumber.ValidateFieldValue(PayAccountNbr);
            ENS01011.PayAccountDesc.ValidateFieldValue(PayAccountDesc);
            ENS01011.Line.ValidateFieldValue(1, Tran1);
            ENS01011.Line.ValidateFieldValue(2, Tran2);
        }

        [Then(@"In ENS01052 I should see NameAddress Extra Details as below ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeNameAddressExtraDetails(string HIN, string HolderOnDate, string HolderOffDate, string HolderAddedDate, string Version, string RunLastChange, string LastBalDump, string LastPaymentDump, string MergeTo, string MergeFrom)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01052");
            ENS01052.HolderONDate.ValidateFieldValue(HolderOnDate);
            ENS01052.HolderOffDate.ValidateFieldValue(HolderOffDate);
            ENS01052.HolderAddedDate.ValidateFieldValue(HolderAddedDate);
            ENS01052.HolderVersionNbr.ValidateFieldValue(Version);
            ENS01052.RunLastChange.ValidateFieldValue(RunLastChange);
            ENS01052.HolderCrtDumprun.ValidateFieldValue(LastBalDump);
            ENS01052.HolderPayDumprun.ValidateFieldValue(LastPaymentDump);
            ENS01052.HolderTO.ValidateFieldValue(MergeTo);
            ENS01052.HolderFrom.ValidateFieldValue(MergeFrom);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENS01006 I should see Noting details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeNotingDetails(string NotingNbr, string Key, string HIN, string Type, string Comment, string Noting1, string Noting2, string Noting3, string Noting4, string Noting5, string Noting6, string Noting7, string Noting8, string Run, string Tran)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01006");
            ENS01006.NotingNumber.ValidateFieldValue(NotingNbr);
            ENS01006.HolderNameKey.ValidateFieldValue(Key);
            ENS01006.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01006.HolderTypeCode.ValidateFieldValue(Type);
            ENS01006.NotingComment50.ValidateFieldValue(Comment);
            ENS01006.NotingLine.ValidateFieldValue(1, Noting1);
            ENS01006.NotingLine.ValidateFieldValue(2, Noting2);
            ENS01006.NotingLine.ValidateFieldValue(3, Noting3);
            ENS01006.NotingLine.ValidateFieldValue(4, Noting4);
            ENS01006.NotingLine.ValidateFieldValue(5, Noting5);
            ENS01006.NotingLine.ValidateFieldValue(6, Noting6);
            ENS01006.NotingLine.ValidateFieldValue(7, Noting7);
            ENS01006.NotingLine.ValidateFieldValue(8, Noting8);
            ENS01006.LCRunNumber.ValidateFieldValue(Run);
            ENS01006.LCTransNumber.ValidateFieldValue(Tran);
        }

        [Then(@"In ENS01021 I should see Noting Menu as below:")]
        public void ShouldSeeNotingMenu(Table data)
        {
            string P1 = data.GetData("P1");
            string P2 = data.GetData("P2");
            string P3 = data.GetData("P3");
            string D1 = data.GetData("D1");
            string D2 = data.GetData("D2");
            string D3 = data.GetData("D3");
            string D4 = data.GetData("D4");
            string D5 = data.GetData("D5");
            string N1 = data.GetData("N1");
            string N2 = data.GetData("N2");
            string N3 = data.GetData("N3");
            string N4 = data.GetData("N4");
            string N5 = data.GetData("N5");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01021");
            ENS01021.MenuItemP1.ValidateFieldValue(P1);
            ENS01021.MenuItemP2.ValidateFieldValue(P2);
            ENS01021.MenuItemP3.ValidateFieldValue(P3);
            ENS01021.MenuItemD1.ValidateFieldValue(D1);
            ENS01021.MenuItemD2.ValidateFieldValue(D2);
            ENS01021.MenuItemD3.ValidateFieldValue(D3);
            ENS01021.MenuItemD4.ValidateFieldValue(D4);
            ENS01021.MenuItemD5.ValidateFieldValue(D5);
            ENS01021.MenuItemN1.ValidateFieldValue(N1);
            ENS01021.MenuItemN2.ValidateFieldValue(N2);
            ENS01021.MenuItemN3.ValidateFieldValue(N3);
            ENS01021.MenuItemN4.ValidateFieldValue(N4);
            ENS01021.MenuItemN5.ValidateFieldValue(N5);
        }

        [Then(@"In ENS01021 I should see Notings as below:")]
        public void ShouldSeeNotings(Table data)
        {
            string NotingNbr = data.GetData("Noting Nuber");
            string Run = data.GetData("Run");
            string Tran = data.GetData("Tran");
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string Comment = data.GetData("Comment");
            string Line1 = data.GetData("Noting Line1");
            string Line2 = data.GetData("Noting Line2");
            string Line3 = data.GetData("Noting Line3");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01006");
            ENS01006.LCRunNumber.ValidateFieldValue(Run);
            ENS01006.LCTransNumber.ValidateFieldValue(Tran);
            ENS01006.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01006.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01006.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS01006.NotingComment50.ValidateFieldValue(Comment);
            ENS01006.NotingLine.ValidateFieldValue(1, Line1);
            ENS01006.NotingLine.ValidateFieldValue(2, Line2);
            ENS01006.NotingLine.ValidateFieldValue(3, Line3);
        }

        [Then(@"In ENSESS24 I should see Options Balance as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeOptionsBalance(string Plan, string PlanDesc, string Line1, string Line2, string Line3, string Line4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS24");
            ENSESS24.SchemeCode.ValidateFieldValue(Plan);
            ENSESS24.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS24.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS24.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS24.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS24.DetailLine.ValidateFieldValue(4, Line4);
        }

        [Then(@"In ENSESS25 I should see Options Balance as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeOptionsBalance(string Plan, string PlanDesc, string Line1, string Line2, string Line3)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS25");
            ENSESS25.SchemeCode.ValidateFieldValue(Plan);
            ENSESS25.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS25.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS25.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS25.DetailLine.ValidateFieldValue(3, Line3);
        }

        [Then(@"In ENS01009 I should see Payment Details as below:")]
        public void ShouldSeePaymentDetails(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string Name = data.GetData("Name");
            string Address = data.GetData("Address");
            string PDLine1 = data.GetData("PD Line1");
            string PDLine2 = data.GetData("PD Line2");
            string PDLine3 = data.GetData("PD Line3");
            string PDLine4 = data.GetData("PD Line4");
            string PDLine5 = data.GetData("PD Line5");
            string PDLine6 = data.GetData("PD Line6");
            string PDLine7 = data.GetData("PD Line7");
            string PDLine8 = data.GetData("PD Line8");
            string PDLine9 = data.GetData("PD Line9");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01009");
            ENS01009.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01009.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01009.HnaLine1.ValidateFieldValue(Name);
            ENS01009.HnaLine2.ValidateFieldValue(Address);
            ENS01009.Line.ValidateFieldValue(1, PDLine1);
            ENS01009.Line.ValidateFieldValue(2, PDLine2);
            ENS01009.Line.ValidateFieldValue(4, PDLine3);
            ENS01009.Line.ValidateFieldValue(5, PDLine4);
            ENS01009.Line.ValidateFieldValue(7, PDLine5);
            ENS01009.Line.ValidateFieldValue(8, PDLine6);
            ENS01009.Line.ValidateFieldValue(10, PDLine7);
            ENS01009.Line.ValidateFieldValue(11, PDLine8);
            ENS01009.Line.ValidateFieldValue(13, PDLine9);
        }

        [Then(@"In ENS02001 I should see Payment Enquiry details as below:")]
        public void ShouldSeePaymentEnquiryDetails(Table data)
        {
            string PaymentAccountNbr = data.GetData("PaymentAccountNbr");
            string PaymentDesc = data.GetData("PaymentDesc");
            string OriginalGrossAmount = data.GetData("OriginalGrossAmount");
            string OriginalNettAmount = data.GetData("OriginalNettAmount");
            string LowReferenceNbr = data.GetData("LowReferenceNbr");
            string HighReferenceNbr = data.GetData("HighReferenceNbr");
            string NbrChqPresented = data.GetData("NbrChqPresented");
            string NbrChqCancelled = data.GetData("NbrChqCancelled");
            string NbrDcPresented = data.GetData("NbrDcPresented");
            string NbrDcUnissued = data.GetData("NbrDcUnissued");
            string NbrDcCancelled = data.GetData("NbrDcCancelled");
            string NbrTotalPresented = data.GetData("NbrTotalPresented");
            string NbrTotalUnissued = data.GetData("NbrTotalUnissued");
            string NbrTotalCancelled = data.GetData("NbrTotalCancelled");
            string NettChqPresented = data.GetData("NettChqPresented");
            string NettChqCancelled = data.GetData("NettChqCancelled");
            string NettDcPresented = data.GetData("NettDcPresented");
            string NettDcUnissued = data.GetData("NettDcUnissued");
            string NettDcCancelled = data.GetData("NettDcCancelled");
            string NettTotalPresented = data.GetData("NettTotalPresented");
            string NettTotalUnissued = data.GetData("NettTotalUnissued");
            string NettTotalCancelled = data.GetData("NettTotalCancelled");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS02001");
            ENS02001.PayAccountNumber.ValidateFieldValue(PaymentAccountNbr);
            ENS02001.PaymentDesc.ValidateFieldValue(PaymentDesc);
            ENS02001.GrossAmount.ValidateFieldValue(OriginalGrossAmount);
            ENS02001.NettAmount.ValidateFieldValue(OriginalNettAmount);
            ENS02001.LowRefNbr.ValidateFieldValue(LowReferenceNbr);
            ENS02001.HighRefNbr.ValidateFieldValue(HighReferenceNbr);
            ENS02001.NbrCQPresented.ValidateFieldValue(NbrChqPresented);
            ENS02001.NbrCQCancelled.ValidateFieldValue(NbrChqCancelled);
            ENS02001.NbrDCPresented.ValidateFieldValue(NbrDcPresented);
            ENS02001.NbrDCUnissued.ValidateFieldValue(NbrDcUnissued);
            ENS02001.NbrDCCancelled.ValidateFieldValue(NbrDcCancelled);
            ENS02001.TotalNbrPresented.ValidateFieldValue(NbrTotalPresented);
            ENS02001.TotalNbrUnissued.ValidateFieldValue(NbrTotalUnissued);
            ENS02001.TotalNbrCancelled.ValidateFieldValue(NbrTotalCancelled);
            ENS02001.NettCQPresented.ValidateFieldValue(NettChqPresented);
            ENS02001.NettCQCancelled.ValidateFieldValue(NettChqCancelled);
            ENS02001.NettDCPresented.ValidateFieldValue(NettDcPresented);
            ENS02001.NettDCUnissued.ValidateFieldValue(NettDcUnissued);
            ENS02001.NettDCCancelled.ValidateFieldValue(NettDcCancelled);
            ENS02001.TotalNettPresented.ValidateFieldValue(NettTotalPresented);
            ENS02001.TotalNettUnissued.ValidateFieldValue(NettTotalUnissued);
            ENS02001.TotalNettCancelled.ValidateFieldValue(NettTotalCancelled);
        }

        [Then(@"In ENSESS15 I should see Payment Holding as below:")]
        public void ShouldSeePaymentHolding(Table data)
        {
            string HIN = data.GetData("HIN");
            string LeaverCode = data.GetData("LeaverCode");
            string LeaverCodeDesc = data.GetData("LeaverCodeDesc");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("Plan Desc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS15");
            ENSESS15.HolderID.ValidateFieldValue(HIN);
            ENSESS15.LeaverCode.ValidateFieldValue(LeaverCode);
            ENSESS15.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
            ENSESS15.SchemeCode.ValidateFieldValue(Plan);
            ENSESS15.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS15.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS15.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS15.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS15.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS15.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS15.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS15.DetailLine.ValidateFieldValue(7, Line7);
        }

        [Then(@"In ENSPND01 I should see Payment Replacement Audit Dates as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePaymentReplacementAuditDates(string AuditDate1, string AuditDate2, string AuditDate3, string AuditDate4, string AuditDate5, string AuditDate6, string AuditDate7, string AuditDate8, string AuditDate9, string AuditDate10, string AuditDate11, string AuditDate12, string AuditDate13)
        {
            ENSPND01.AuditDate.ValidateFieldValue(1, AuditDate1);
            ENSPND01.AuditDate.ValidateFieldValue(2, AuditDate2);
            ENSPND01.AuditDate.ValidateFieldValue(3, AuditDate3);
            ENSPND01.AuditDate.ValidateFieldValue(4, AuditDate4);
            ENSPND01.AuditDate.ValidateFieldValue(5, AuditDate5);
            ENSPND01.AuditDate.ValidateFieldValue(6, AuditDate6);
            ENSPND01.AuditDate.ValidateFieldValue(7, AuditDate7);
            ENSPND01.AuditDate.ValidateFieldValue(8, AuditDate8);
            ENSPND01.AuditDate.ValidateFieldValue(9, AuditDate9);
            ENSPND01.AuditDate.ValidateFieldValue(10, AuditDate10);
            ENSPND01.AuditDate.ValidateFieldValue(11, AuditDate11);
            ENSPND01.AuditDate.ValidateFieldValue(12, AuditDate12);
            ENSPND01.AuditDate.ValidateFieldValue(13, AuditDate13);
        }

        [Then(@"In ENSPND01 I should see Payment Replacement Note Description as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePaymentReplacementNoteDescription(string Note1, string Note2, string Note3, string Note4, string Note5, string Note6, string Note7, string Note8, string Note9, string Note10, string Note11, string Note12, string Note13)
        {
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(1, Note1);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(2, Note2);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(3, Note3);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(4, Note4);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(5, Note5);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(6, Note6);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(7, Note7);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(8, Note8);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(9, Note9);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(10, Note10);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(11, Note11);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(12, Note12);
            ENSPND01.NoteTxtL1Ext.ValidateFieldValue(13, Note13);
        }

        [Then(@"In ENSPND02 I should see Payment Replacement Step Notes as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePaymentReplacementStepNotes(string HIN, string StepCode, string Notetext1, string Notetext2, string AuditUser, string AuditDate)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPND02");
            ENSPND02.HolderID.ValidateFieldValue(HIN);
            ENSPND02.StepCode.ValidateFieldValue(StepCode);
            ENSPND02.NoteTxt.ValidateFieldValue(1, Notetext1);
            ENSPND02.NoteTxt.ValidateFieldValue(2, Notetext2);
            ENSPND02.AuditDate.ValidateFieldValue(AuditDate);
        }

        [Then(@"In ENSPND01 I should see Payment Replacement Steps as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePaymentReplacementSteps(string Step1, string Step2, string Step3, string Step4, string Step5, string Step6, string Step7, string Step8, string Step9, string Step10, string Step11, string Step12, string Step13)
        {
            ENSPND01.StepCode.ValidateFieldValue(1, Step1);
            ENSPND01.StepCode.ValidateFieldValue(2, Step2);
            ENSPND01.StepCode.ValidateFieldValue(3, Step3);
            ENSPND01.StepCode.ValidateFieldValue(4, Step4);
            ENSPND01.StepCode.ValidateFieldValue(5, Step5);
            ENSPND01.StepCode.ValidateFieldValue(6, Step6);
            ENSPND01.StepCode.ValidateFieldValue(7, Step7);
            ENSPND01.StepCode.ValidateFieldValue(8, Step8);
            ENSPND01.StepCode.ValidateFieldValue(9, Step9);
            ENSPND01.StepCode.ValidateFieldValue(10, Step10);
            ENSPND01.StepCode.ValidateFieldValue(11, Step11);
            ENSPND01.StepCode.ValidateFieldValue(12, Step12);
            ENSPND01.StepCode.ValidateFieldValue(13, Step13);
        }

        [Then(@"In ENSPND01 I should see Payment Replacement Step Status as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePaymentReplacementStepStatus(string StepStatus1, string StepStatus2, string StepStatus3, string StepStatus4, string StepStatus5, string StepStatus6, string StepStatus7, string StepStatus8, string StepStatus9, string StepStatus10, string StepStatus11, string StepStatus12, string StepStatus13)
        {
            ENSPND01.StepStatusDesc.ValidateFieldValue(1, StepStatus1);
            ENSPND01.StepStatusDesc.ValidateFieldValue(2, StepStatus2);
            ENSPND01.StepStatusDesc.ValidateFieldValue(3, StepStatus3);
            ENSPND01.StepStatusDesc.ValidateFieldValue(4, StepStatus4);
            ENSPND01.StepStatusDesc.ValidateFieldValue(5, StepStatus5);
            ENSPND01.StepStatusDesc.ValidateFieldValue(6, StepStatus6);
            ENSPND01.StepStatusDesc.ValidateFieldValue(7, StepStatus7);
            ENSPND01.StepStatusDesc.ValidateFieldValue(8, StepStatus8);
            ENSPND01.StepStatusDesc.ValidateFieldValue(9, StepStatus9);
            ENSPND01.StepStatusDesc.ValidateFieldValue(10, StepStatus10);
            ENSPND01.StepStatusDesc.ValidateFieldValue(11, StepStatus11);
            ENSPND01.StepStatusDesc.ValidateFieldValue(12, StepStatus12);
            ENSPND01.StepStatusDesc.ValidateFieldValue(13, StepStatus13);
        }

        [Then(@"In ENSPND01 I should see Payment Replacement step summary as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePaymentReplacementStepSummary(string HIN, string PaymentAccount, string PayReference, string PayMethodTo, string PaidAmount, string PaidCurrency)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPND01");
            ENSPND01.HolderID.SetValue(HIN);
            ENSPND01.PayAccount.ValidateFieldValue(PaymentAccount);
            ENSPND01.PayReference.ValidateFieldValue(PayReference);
            ENSPND01.PayMethodTO.ValidateFieldValue(PayMethodTo);
            ENSPND01.PaidAmount.ValidateFieldValue(PaidAmount);
            ENSPND01.PaidCurrency.ValidateFieldValue(PaidCurrency);
        }

        [Then(@"In ENSESS13 I should see Payment Transactions as below:")]
        public void ShouldSeePaymentTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string LeaveCode = data.GetData("LeaveCode");
            string LeaveCodeDesc = data.GetData("LeaveCodeDesc");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("Plan Desc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS13");
            ENSESS13.HolderID.ValidateFieldValue(HIN);
            ENSESS13.LeaverCode.ValidateFieldValue(LeaveCode);
            ENSESS13.LeaverCodeDesc.ValidateFieldValue(LeaveCodeDesc);
            ENSESS13.SchemeCode.ValidateFieldValue(Plan);
            ENSESS13.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS13.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS13.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS13.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS13.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS13.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS13.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS13.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS13.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS13.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS13.DetailLine.ValidateFieldValue(10, Line10);
        }

        //}
        [Then(@"In ENSESS17 I should see Payroll Identifier Parameters as below:")]
        public void ShouldSeePayrollIdentifierParameters(Table data)
        {
            string PayrollID = data.GetData("PayrollID");
            string PayrollDesc = data.GetData("PayrollDesc");
            string PayeeName1 = data.GetData("PayeeName1");
            string PayeeName2 = data.GetData("PayeeName2");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");
            string Address6 = data.GetData("Address6");
            string Postcode = data.GetData("Postcode");

            ENSESS17.PayrollID.ValidateFieldValue(PayrollID);
            ENSESS17.PayrollDesc.ValidateFieldValue(PayrollDesc);
            ENSESS17.PayeeNameLine.ValidateFieldValue(1, PayeeName1);
            ENSESS17.PayeeNameLine.ValidateFieldValue(2, PayeeName2);
            ENSESS17.ContactName.ValidateFieldValue(Name);
            ENSESS17.AddressLines.ValidateFieldValue(1, Address1);
            ENSESS17.AddressLines.ValidateFieldValue(2, Address2);
            ENSESS17.AddressLines.ValidateFieldValue(3, Address3);
            ENSESS17.AddressLines.ValidateFieldValue(4, Address4);
            ENSESS17.AddressLines.ValidateFieldValue(5, Address5);
            ENSESS17.AddressLines.ValidateFieldValue(6, Address6);
            ENSESS17.AusPostcode.ValidateFieldValue(Postcode);
        }

        [Then(@"In ENS01062 I should see Pending Chess Transaction History as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePendingChessTransactionHistory(string HIN, string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10, string Line11, string Line12)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01062");
            ENS01062.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01062.Line.ValidateFieldValue(1, Line1);
            ENS01062.Line.ValidateFieldValue(2, Line2);
            ENS01062.Line.ValidateFieldValue(3, Line3);
            ENS01062.Line.ValidateFieldValue(4, Line4);
            ENS01062.Line.ValidateFieldValue(5, Line5);
            ENS01062.Line.ValidateFieldValue(6, Line6);
            ENS01062.Line.ValidateFieldValue(7, Line7);
            ENS01062.Line.ValidateFieldValue(8, Line8);
            ENS01062.Line.ValidateFieldValue(9, Line9);
            ENS01062.Line.ValidateFieldValue(10, Line10);
            ENS01062.Line.ValidateFieldValue(11, Line11);
            ENS01062.Line.ValidateFieldValue(12, Line12);
        }

        [Then(@"In ENSACC03 I should see Pending Money Summary details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePendingMoneySummaryDetails(string HIN, string Line1, string Line2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSACC03");
            ENSACC03.HolderIdentifier.ValidateFieldValue(HIN);
            ENSACC03.PendingLine.ValidateFieldValue(1, Line1);
            ENSACC03.PendingLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENSTRD47 I should see Pending Trading Transactions as below:")]
        public void ShouldSeePendingTradingTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string PendingTrade1 = data.GetData("Pending Trade1");

            ENSTRD47.HolderIdentifier.ValidateFieldValue(HIN);
            ENSTRD47.Line.ValidateFieldValue(1, PendingTrade1);
        }

        [Then(@"In ENS01047 I should see Pending Transactions as below:")]
        public void ShouldSeePendingTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string PendingTran = data.GetData("Pending Transaction");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01047");
            ENS01047.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01047.DealingLine.ValidateFieldValue(1, PendingTran);
        }

        [Then(@"In ENSESS11 I should see Plan Holder Totals as below:")]
        public void ShouldSeePlanHolderTotals(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("Plan Desc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS11");
            ENSESS11.HolderID.ValidateFieldValue(HIN);
            ENSESS11.SchemeCode.ValidateFieldValue(Plan);
            ENSESS11.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS11.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS11.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS11.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS11.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS11.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS11.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS11.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS11.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS11.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS11.DetailLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"ENSPCE10 I should see Postcode details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePostcodeDetails(string Postcode1, string Postcode2, string Postcode3, string Postcode4, string Postcode5, string Postcode6, string Postcode7, string Postcode8, string Postcode9, string Postcode10, string Postcode11, string Postcode12, string Postcode13, string Postcode14, string Postcode15, string Postcode16)
        {
            ENSPCE10.Postcode.ValidateFieldValue(1, Postcode1);
            ENSPCE10.Postcode.ValidateFieldValue(2, Postcode2);
            ENSPCE10.Postcode.ValidateFieldValue(3, Postcode3);
            ENSPCE10.Postcode.ValidateFieldValue(4, Postcode4);
            ENSPCE10.Postcode.ValidateFieldValue(5, Postcode5);
            ENSPCE10.Postcode.ValidateFieldValue(6, Postcode6);
            ENSPCE10.Postcode.ValidateFieldValue(7, Postcode7);
            ENSPCE10.Postcode.ValidateFieldValue(8, Postcode8);
            ENSPCE10.Postcode.ValidateFieldValue(9, Postcode9);
            ENSPCE10.Postcode.ValidateFieldValue(10, Postcode10);
            ENSPCE10.Postcode.ValidateFieldValue(11, Postcode11);
            ENSPCE10.Postcode.ValidateFieldValue(12, Postcode12);
            ENSPCE10.Postcode.ValidateFieldValue(13, Postcode13);
            ENSPCE10.Postcode.ValidateFieldValue(14, Postcode14);
            ENSPCE10.Postcode.ValidateFieldValue(15, Postcode15);
            ENSPCE10.Postcode.ValidateFieldValue(16, Postcode16);
        }

        [Then(@"In ENSPCE10 I should see Postcode Enquiry system details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePostcodeEnquirySystemDetailsPart1(string Country1, string Town1, string Town2, string Town3, string Town4, string Town5, string Town6, string Town7, string State1, string State2, string State3, string State4, string State5, string State6, string State7, string Postcode1, string Postcode2, string Postcode3, string Postcode4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE10");
            ENSPCE10.Country.ValidateFieldValue(Country1);
            ENSPCE10.Location.ValidateFieldValue(1, Town1);
            ENSPCE10.Location.ValidateFieldValue(2, Town2);
            ENSPCE10.Location.ValidateFieldValue(3, Town3);
            ENSPCE10.Location.ValidateFieldValue(4, Town4);
            ENSPCE10.Location.ValidateFieldValue(5, Town5);
            ENSPCE10.Location.ValidateFieldValue(6, Town6);
            ENSPCE10.Location.ValidateFieldValue(7, Town7);
            ENSPCE10.State.ValidateFieldValue(1, State1);
            ENSPCE10.State.ValidateFieldValue(2, State2);
            ENSPCE10.State.ValidateFieldValue(3, State3);
            ENSPCE10.State.ValidateFieldValue(4, State4);
            ENSPCE10.State.ValidateFieldValue(5, State5);
            ENSPCE10.State.ValidateFieldValue(6, State6);
            ENSPCE10.State.ValidateFieldValue(7, State7);
            ENSPCE10.Postcode.ValidateFieldValue(1, Postcode1);
            ENSPCE10.Postcode.ValidateFieldValue(2, Postcode2);
            ENSPCE10.Postcode.ValidateFieldValue(3, Postcode3);
            ENSPCE10.Postcode.ValidateFieldValue(4, Postcode4);
        }

        [Then(@"ENSPCE10 I should see Postcode Enquiry system details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePostcodeEnquirySystemDetailsPart2(string Postcode5, string Postcode6, string Postcode7, string Presort1, string Presort2, string Presort3, string Presort4, string Presort5, string Presort6, string Presort7, string BarcodePresort1, string BarcodePresort2, string BarcodePresort3, string BarcodePresort4, string BarcodePresort5, string BarcodePresort6, string BarcodePresort7)
        {
            ENSPCE10.Postcode.ValidateFieldValue(5, Postcode5);
            ENSPCE10.Postcode.ValidateFieldValue(6, Postcode6);
            ENSPCE10.Postcode.ValidateFieldValue(7, Postcode7);
            ENSPCE10.Presort.ValidateFieldValue(1, Presort1);
            ENSPCE10.Presort.ValidateFieldValue(2, Presort2);
            ENSPCE10.Presort.ValidateFieldValue(3, Presort3);
            ENSPCE10.Presort.ValidateFieldValue(4, Presort4);
            ENSPCE10.Presort.ValidateFieldValue(5, Presort5);
            ENSPCE10.Presort.ValidateFieldValue(6, Presort6);
            ENSPCE10.Presort.ValidateFieldValue(7, Presort7);
            ENSPCE10.BarcodePresort.ValidateFieldValue(1, BarcodePresort1);
            ENSPCE10.BarcodePresort.ValidateFieldValue(2, BarcodePresort2);
            ENSPCE10.BarcodePresort.ValidateFieldValue(3, BarcodePresort3);
            ENSPCE10.BarcodePresort.ValidateFieldValue(4, BarcodePresort4);
            ENSPCE10.BarcodePresort.ValidateFieldValue(5, BarcodePresort5);
            ENSPCE10.BarcodePresort.ValidateFieldValue(6, BarcodePresort6);
            ENSPCE10.BarcodePresort.ValidateFieldValue(7, BarcodePresort7);
        }

        [Then(@"ENSPCE10 I should see Presort details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePresortDetails(string Presort1, string Presort2, string Presort3, string Presort4, string Presort5, string Presort6, string Presort7, string Presort8, string Presort9, string Presort10, string Presort11, string Presort12, string Presort13, string Presort14, string Presort15, string Presort16)
        {
            ENSPCE10.Presort.ValidateFieldValue(1, Presort1);
            ENSPCE10.Presort.ValidateFieldValue(2, Presort2);
            ENSPCE10.Presort.ValidateFieldValue(3, Presort3);
            ENSPCE10.Presort.ValidateFieldValue(4, Presort4);
            ENSPCE10.Presort.ValidateFieldValue(5, Presort5);
            ENSPCE10.Presort.ValidateFieldValue(6, Presort6);
            ENSPCE10.Presort.ValidateFieldValue(7, Presort7);
            ENSPCE10.Presort.ValidateFieldValue(8, Presort8);
            ENSPCE10.Presort.ValidateFieldValue(9, Presort9);
            ENSPCE10.Presort.ValidateFieldValue(10, Presort10);
            ENSPCE10.Presort.ValidateFieldValue(11, Presort11);
            ENSPCE10.Presort.ValidateFieldValue(12, Presort12);
            ENSPCE10.Presort.ValidateFieldValue(13, Presort13);
            ENSPCE10.Presort.ValidateFieldValue(14, Presort14);
            ENSPCE10.Presort.ValidateFieldValue(15, Presort15);
            ENSPCE10.Presort.ValidateFieldValue(16, Presort16);
        }

        [Then(@"In ENS01013 I should see Register details as below:")]
        public void ShouldSeeRegisterDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01013");
            ENS01013.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01013.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01013.CertificateLine.ValidateFieldValue(2, Line2);
            ENS01013.CertificateLine.ValidateFieldValue(3, Line3);
            ENS01013.CertificateLine.ValidateFieldValue(4, Line4);
            ENS01013.CertificateLine.ValidateFieldValue(5, Line5);
            ENS01013.CertificateLine.ValidateFieldValue(6, Line6);
        }

        [Then(@"In ENS01013 I should see Register details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeRegisterDetails(string HIN, string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10, string Line11, string Line12, string Line13)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01013");
            ENS01013.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01013.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01013.CertificateLine.ValidateFieldValue(2, Line2);
            ENS01013.CertificateLine.ValidateFieldValue(3, Line3);
            ENS01013.CertificateLine.ValidateFieldValue(4, Line4);
            ENS01013.CertificateLine.ValidateFieldValue(5, Line5);
            ENS01013.CertificateLine.ValidateFieldValue(6, Line6);
            ENS01013.CertificateLine.ValidateFieldValue(7, Line7);
            ENS01013.CertificateLine.ValidateFieldValue(8, Line8);
            ENS01013.CertificateLine.ValidateFieldValue(9, Line9);
            ENS01013.CertificateLine.ValidateFieldValue(10, Line10);
            ENS01013.CertificateLine.ValidateFieldValue(11, Line11);
            ENS01013.CertificateLine.ValidateFieldValue(12, Line12);
            ENS01013.CertificateLine.ValidateFieldValue(13, Line13);
        }

        [Then(@"In ENS01016 I should see Register details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeRegisterDetails(string HIN, string Line1, string Line2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01016");
            ENS01016.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01016.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01016.CertificateLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENSESS45 I should see Register Event History as below:")]
        public void ShouldSeeRegisterEventHistory(Table data)
        {
            string HIN = data.GetData("HIN");
            string Plan = data.GetData("Plan");
            string PlanDesc = data.GetData("PlanDesc");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");
            string Line6 = data.GetData("Line6");
            string Line7 = data.GetData("Line7");
            string Line8 = data.GetData("Line8");
            string Line9 = data.GetData("Line9");
            string Line10 = data.GetData("Line10");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS45");
            ENSESS45.HolderID.ValidateFieldValue(HIN);
            ENSESS45.SchemeCode.ValidateFieldValue(Plan);
            ENSESS45.SchemeName.ValidateFieldValue(PlanDesc);
            ENSESS45.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS45.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS45.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS45.DetailLine.ValidateFieldValue(4, Line4);
            ENSESS45.DetailLine.ValidateFieldValue(5, Line5);
            ENSESS45.DetailLine.ValidateFieldValue(6, Line6);
            ENSESS45.DetailLine.ValidateFieldValue(7, Line7);
            ENSESS45.DetailLine.ValidateFieldValue(8, Line8);
            ENSESS45.DetailLine.ValidateFieldValue(9, Line9);
            ENSESS45.DetailLine.ValidateFieldValue(10, Line10);
        }

        [Then(@"In ENS01069 I should see Remittance Transaction Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeRemittanceTransactionDetails(string PaymentSource, string CustomerRef, string PaymentDate, string TraceNo, string SettlemtDate, string InputFile, string FileReceived, string FileProcessed)
        {
            ENS01069.APPaymentSource.ValidateFieldValue(PaymentSource);
            ENS01069.APRemittanceRefNO.ValidateFieldValue(CustomerRef);
            ENS01069.APPaymentDate.ValidateFieldValue(PaymentDate);
            ENS01069.APTraceNO.ValidateFieldValue(TraceNo);
            ENS01069.APBpaySettleDate.ValidateFieldValue(SettlemtDate);
            ENS01069.APFileName.ValidateFieldValue(InputFile);
            ENS01069.FileReceivedDate.ValidateFieldValue(FileReceived);
            ENS01069.FileProcessedDate.ValidateFieldValue(FileProcessed);
        }

        [Then(@"In ENSTRD57 I should see Reservation Extra Details as below:")]
        public void ShouldSeeReservationExtraDetails(Table data)
        {
            string ExtraLine1 = data.GetData("Line1");
            ENSTRD57.ExtraTradeDetails.ValidateFieldValue(1, ExtraLine1);
        }

        [Then(@"In ENS01033 I should see Six Holder names and Address as below:")]
        public void ShouldSeeSixHolderNamesAndAddress(Table data)
        {
            string HIN = data.GetData("HIN");
            string AddressLine1 = data.GetData("Address Line1");
            string AddressLine2 = data.GetData("Address Line2");
            string AddressLine3 = data.GetData("Address Line3");
            string AddressLine4 = data.GetData("Address Line4");
            string Postcode = data.GetData("Postcode");

            ENS01033.HolderIdentifier.ValidateFieldValue(1, HIN);
            ENS01033.HnaLine1.ValidateFieldValue(1, AddressLine1);
            ENS01033.HnaLine2.ValidateFieldValue(1, AddressLine2);
            ENS01033.HnaLine3.ValidateFieldValue(1, AddressLine3);
            ENS01033.HnaLine4.ValidateFieldValue(1, AddressLine4);
            ENS01033.Postcode.ValidateFieldValue(1, Postcode);
        }

        [Then(@"In ENS01069 I should see SLR Transaction Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeSLRTransactionDetails(string SLRDate, string WorkflowID, string OrigSystem, string ServiceProvider, string ServiceCode, string Branch, string Department, string MessageUserID)
        {
            ENS01069.SlrTransDate.ValidateFieldValue(SLRDate);
            ENS01069.SlrWorkflowID.ValidateFieldValue(WorkflowID);
            ENS01069.OrigSystem.ValidateFieldValue(OrigSystem);
            ENS01069.ServiceProvider.ValidateFieldValue(ServiceProvider);
            ENS01069.ServiceCode.ValidateFieldValue(ServiceCode);
            ENS01069.Branch.ValidateFieldValue(Branch);
            ENS01069.Department.ValidateFieldValue(Department);
            ENS01069.SlrMsgid.ValidateFieldValue(MessageUserID);
        }

        [Then(@"ENSPCE10 I should see State details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeStateDetails(string State1, string State2, string State3, string State4, string State5, string State6, string State7, string State8, string State9, string State10, string State11, string State12, string State13, string State14, string State15, string State16)
        {
            ENSPCE10.State.ValidateFieldValue(1, State1);
            ENSPCE10.State.ValidateFieldValue(2, State2);
            ENSPCE10.State.ValidateFieldValue(3, State3);
            ENSPCE10.State.ValidateFieldValue(4, State4);
            ENSPCE10.State.ValidateFieldValue(5, State5);
            ENSPCE10.State.ValidateFieldValue(6, State6);
            ENSPCE10.State.ValidateFieldValue(7, State7);
            ENSPCE10.State.ValidateFieldValue(8, State8);
            ENSPCE10.State.ValidateFieldValue(9, State9);
            ENSPCE10.State.ValidateFieldValue(10, State10);
            ENSPCE10.State.ValidateFieldValue(11, State11);
            ENSPCE10.State.ValidateFieldValue(12, State12);
            ENSPCE10.State.ValidateFieldValue(13, State13);
            ENSPCE10.State.ValidateFieldValue(14, State14);
            ENSPCE10.State.ValidateFieldValue(15, State15);
            ENSPCE10.State.ValidateFieldValue(16, State16);
        }

        [Then(@"In ENS01034 I should see Static History as below:")]
        public void ShouldSeeStaticHistory(Table data)
        {
            string NameKey = data.GetData("NameKey");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");
            string DateFirstSH = data.GetData("Date First SH");
            string DateFirstOn = data.GetData("Date First On");
            string Run = data.GetData("Run");
            string TranNo = data.GetData("Tran No");
            string Date = data.GetData("Date");
            string TranCode = data.GetData("Transaction Code");
            string TranDesc = data.GetData("Transaction Desc");
            string Reference = data.GetData("Reference");
            string Source = data.GetData("Source");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01034");

            ENS01034.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01034.HolderID.ValidateFieldValue(HIN);
            ENS01034.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS01034.DateFirstHolder.ValidateFieldValue(DateFirstSH);
            ENS01034.HolderONDate.ValidateFieldValue(DateFirstOn);
            ENS01034.AddressLine.ValidateFieldValue(1, Name);
            ENS01034.AddressLine.ValidateFieldValue(2, Address1);
            ENS01034.AddressLine.ValidateFieldValue(3, Address2);
            ENS01034.AddressLine.ValidateFieldValue(4, Address3);
            ENS01034.AddressLine.ValidateFieldValue(5, Address4);
            ENS01034.AddressLine.ValidateFieldValue(6, Address5);
            ENS01034.RunNumberPg1.ValidateFieldValue(1, Run);
            ENS01034.HldTransNumberPg1.ValidateFieldValue(1, TranNo);
            ENS01034.TranDatePg1.ValidateFieldValue(1, Date);
            ENS01034.TranTypeCodePg1.ValidateFieldValue(1, TranCode);
            ENS01034.TranTypeDescPg1.ValidateFieldValue(1, TranDesc);
            ENS01034.ReferencePg1.ValidateFieldValue(1, Reference);
            ENS01034.SourcePg1.ValidateFieldValue(1, Reference);

            Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In ENS01034 I should see Static History Details as below ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""(.*)""")]
        public void ShouldSeeStaticHistoryDetails(string Run1, string Tran1, string Date1, string TranCode1, string TranDesc1, string Reference1, string Source1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01034");
            ENS01034.RunNumberPg1.ValidateFieldValue(1, Run1);
            ENS01034.HldTransNumberPg1.ValidateFieldValue(1, Tran1);
            ENS01034.TranDatePg1.ValidateFieldValue(1, Date1);
            ENS01034.TranTypeCodePg1.ValidateFieldValue(1, TranCode1);
            ENS01034.TranTypeDescPg1.ValidateFieldValue(1, TranDesc1);
            //ENS01035.Reference.ValidateFieldValue(0, Reference1Pg2);
            ENS01034.SourcePg1.ValidateFieldValue(1, Source1);
        }

        [Then(@"In ENSSTM34 I should see Static Transaction details as below:")]
        public void ShouldSeeStaticTransactionDetails(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string HolderOnDate = data.GetData("Date first Shareholder");
            string DateFirstHolder = data.GetData("Date First");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");
            string Run = data.GetData("Run");
            string TranNo = data.GetData("Tran No");
            string TranDate = data.GetData("Tran Date");
            string TranCode = data.GetData("Tran Code");
            string TranDesc = data.GetData("Tran Desc");
            string Reference = data.GetData("Reference");

            ENSSTM34.HolderNameKey.ValidateFieldValue(NameKey);
            ENSSTM34.HolderID.ValidateFieldValue(HIN);
            ENSSTM34.HolderTypeCode.ValidateFieldValue(HolderType);
            ENSSTM34.HolderONDate.ValidateFieldValue(HolderOnDate);
            ENSSTM34.DateFirstHolder.ValidateFieldValue(DateFirstHolder);
            ENSSTM34.AddressLine.ValidateFieldValue(1, Name);
            ENSSTM34.AddressLine.ValidateFieldValue(2, Address1);
            ENSSTM34.AddressLine.ValidateFieldValue(3, Address2);
            ENSSTM34.AddressLine.ValidateFieldValue(4, Address3);
            ENSSTM34.AddressLine.ValidateFieldValue(5, Address4);
            ENSSTM34.AddressLine.ValidateFieldValue(6, Address5);
            ENSSTM34.RunNumber.ValidateFieldValue(Run);
            ENSSTM34.HldTransNumber.ValidateFieldValue(TranNo);
            ENSSTM34.TranDate.ValidateFieldValue(TranDate);
            ENSSTM34.TranTypeCode.ValidateFieldValue(TranCode);
            ENSSTM34.TranTypeDesc.ValidateFieldValue(TranDesc);
            ENSSTM34.Reference.ValidateFieldValue(Reference);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENSESS04 I should see Static Transactions as below:")]
        public void ShouldSeeStaticTransactions(Table data)
        {
            string HIN = data.GetData("HIN");
            string Class = data.GetData("Class");
            string Certificate = data.GetData("Certificate");
            string Date = data.GetData("Date");
            string TType = data.GetData("TType");
            string Run = data.GetData("Run");
            string Trans = data.GetData("Trans");
            string Sequence = data.GetData("Sequence");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS04");
            ENSESS04.HolderIdentifier.ValidateFieldValue(HIN);
            ENSESS04.Class.ValidateFieldValue(1, Class);
            ENSESS04.Cert.ValidateFieldValue(1, Certificate);
            ENSESS04.Date.ValidateFieldValue(1, Date);
            ENSESS04.Ttype.ValidateFieldValue(1, TType);
            ENSESS04.Run.ValidateFieldValue(1, Run);
            ENSESS04.Trans.ValidateFieldValue(1, Trans);
            ENSESS04.Seq.ValidateFieldValue(1, Sequence);
        }

        [Then(@"In ENS04020 I should see Statistics Enquiry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeStatisticsEnquiryDetails(string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10, string Line11, string Line12, string Line13, string Line14, string Line15, string Line16, string Line17, string Line18, string Line19)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04020");
            ENS04020.ScreenLine.ValidateFieldValue(1, Line1);
            ENS04020.ScreenLine.ValidateFieldValue(2, Line2);
            ENS04020.ScreenLine.ValidateFieldValue(3, Line3);
            ENS04020.ScreenLine.ValidateFieldValue(4, Line4);
            ENS04020.ScreenLine.ValidateFieldValue(5, Line5);
            ENS04020.ScreenLine.ValidateFieldValue(6, Line6);
            ENS04020.ScreenLine.ValidateFieldValue(7, Line7);
            ENS04020.ScreenLine.ValidateFieldValue(8, Line8);
            ENS04020.ScreenLine.ValidateFieldValue(9, Line9);
            ENS04020.ScreenLine.ValidateFieldValue(10, Line10);
            ENS04020.ScreenLine.ValidateFieldValue(11, Line11);
            ENS04020.ScreenLine.ValidateFieldValue(12, Line12);
            ENS04020.ScreenLine.ValidateFieldValue(13, Line13);
            ENS04020.ScreenLine.ValidateFieldValue(14, Line14);
            ENS04020.ScreenLine.ValidateFieldValue(15, Line15);
            ENS04020.ScreenLine.ValidateFieldValue(16, Line16);
            ENS04020.ScreenLine.ValidateFieldValue(17, Line17);
            ENS04020.ScreenLine.ValidateFieldValue(18, Line18);
            ENS04020.ScreenLine.ValidateFieldValue(19, Line19);
        }

        [Then(@"In ENS01001 I should see the holder Details as below:")]
        public void ShouldSeeTheHolderDetails(Table data)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            string HIN = data.GetData("From HIN");
            string MergeHINNote = data.GetData("Note");

            ENS01001.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01001.HnaLine.ValidateFieldValue(7, MergeHINNote);

            //Spartan.Core.WinForms.WinFormsDriver.PressESC();
            //Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        [Then(@"In ENSESS01 I should see the holder Employee Details as below:")]
        public void ShouldSeeTheHolderEmployeeDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string EmployeeID = data.GetData("Employee ID");
            string PrefName = data.GetData("Preferred Name");
            string BusinessUnit = data.GetData("Business Unit");
            string EmpStatus = data.GetData("Employee Status");
            string LeaverCode = data.GetData("Leaver Code");
            string EffectiveDate = data.GetData("Effective Date");

            ENS01001.Action.SetValue("ED");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            ENS01075.HolderIdentifier.ValidateFieldValue(HIN);
            EOL01701.EmployeeNumber.ValidateFieldValue(EmployeeID);
            EOL01701.PreferredName.ValidateFieldValue(PrefName);
            EOL01701.BusinessUnit.ValidateFieldValue(BusinessUnit);
            EOL01701.EmployeeStatus.ValidateFieldValue(EmpStatus);
            EOL01701.LeaverCode.ValidateFieldValue(LeaverCode);
            EOL01701.EffectiveDate.ValidateFieldValue(EffectiveDate);
        }

        [Then(@"In ENS01002 I should see the holder payee Instructions as below:")]
        public void ShouldSeeTheHolderPayeeInstructions(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string BankSystem = data.GetData("Bank System");
            string BSB = data.GetData("BSB Code");
            string AccountNumber = data.GetData("Account Number");
            string AccountName = data.GetData("Account Name");
            string BankAddress1 = data.GetData("Bank Address1");
            string BankAddress2 = data.GetData("Bank Address2");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");

            ENS01002.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01002.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01002.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS01002.BulkPaySystem.ValidateFieldValue(BankSystem);
            ENS01002.BankCode.ValidateFieldValue(BSB);
            ENS01002.PayeeAccountNumber.ValidateFieldValue(AccountNumber);
            ENS01002.PayeeAccountName.ValidateFieldValue(AccountName);
            ENS01002.PayeeAddrLine.ValidateFieldValue(1, BankAddress1);
            ENS01002.PayeeAddrLine.ValidateFieldValue(2, BankAddress2);
            ENS01002.HnaLine.ValidateFieldValue(1, Name);
            ENS01002.HnaLine.ValidateFieldValue(2, Address1);
            ENS01002.HnaLine.ValidateFieldValue(3, Address2);
            ENS01002.HnaLine.ValidateFieldValue(4, Address3);
            ENS01002.HnaLine.ValidateFieldValue(5, Address4);
            ENS01002.HnaLine.ValidateFieldValue(6, Address5);
        }

        [Then(@"In ENS01042 I should see the Last Tran details as ""(.*)"" and ""(.*)""")]
        public void ShouldSeeTheLastTranDetails(string Cert1, string Cert12)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01042");
            ENS01012.CertificateLine.ValidateFieldValue(2, Cert1);
            ENS01012.CertificateLine.ValidateFieldValue(13, Cert12);
            Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In ENS04070 I should see Top200 Balance as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTop200Balance(string Name1, string Name2, string Name3, string HIN1, string HIN2, string HIN3, string Units1, string Units2, string Units3, string IC1, string IC2, string IC3, string Rank1, string Rank2, string Rank3)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04070");
            ENS04070.Name.ValidateFieldValue(1, Name1);
            ENS04070.Name.ValidateFieldValue(2, Name2);
            ENS04070.Name.ValidateFieldValue(3, Name3);
            ENS04070.HolderID.ValidateFieldValue(1, HIN1);
            ENS04070.HolderID.ValidateFieldValue(2, HIN2);
            ENS04070.HolderID.ValidateFieldValue(3, HIN3);
            ENS04070.Units.ValidateFieldValue(1, Units1);
            ENS04070.Units.ValidateFieldValue(2, Units2);
            ENS04070.Units.ValidateFieldValue(3, Units3);
            ENS04070.Percentage.ValidateFieldValue(1, IC1);
            ENS04070.Percentage.ValidateFieldValue(2, IC2);
            ENS04070.Percentage.ValidateFieldValue(3, IC3);
            ENS04070.Rank.ValidateFieldValue(1, Rank1);
            ENS04070.Rank.ValidateFieldValue(2, Rank2);
            ENS04070.Rank.ValidateFieldValue(3, Rank3);
        }

        [Then(@"ENSPCE10 I should see Town details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTownDetails(string Country1, string Town1, string Town2, string Town3, string Town4, string Town5, string Town6, string Town7, string Town8, string Town9, string Town10, string Town11, string Town12, string Town13, string Town14, string Town15, string Town16)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSPCE10");
            ENSPCE10.Country.ValidateFieldValue(Country1);
            ENSPCE10.Location.ValidateFieldValue(1, Town1);
            ENSPCE10.Location.ValidateFieldValue(2, Town2);
            ENSPCE10.Location.ValidateFieldValue(3, Town3);
            ENSPCE10.Location.ValidateFieldValue(4, Town4);
            ENSPCE10.Location.ValidateFieldValue(5, Town5);
            ENSPCE10.Location.ValidateFieldValue(6, Town6);
            ENSPCE10.Location.ValidateFieldValue(7, Town7);
            ENSPCE10.Location.ValidateFieldValue(8, Town8);
            ENSPCE10.Location.ValidateFieldValue(9, Town9);
            ENSPCE10.Location.ValidateFieldValue(10, Town10);
            ENSPCE10.Location.ValidateFieldValue(11, Town11);
            ENSPCE10.Location.ValidateFieldValue(12, Town12);
            ENSPCE10.Location.ValidateFieldValue(13, Town13);
            ENSPCE10.Location.ValidateFieldValue(14, Town14);
            ENSPCE10.Location.ValidateFieldValue(15, Town15);
            ENSPCE10.Location.ValidateFieldValue(16, Town16);
        }

        [Then(@"In ENSTRDSH  I should see Trading History as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTradingHistory(string HIN, string Type, string ID, string Tran, string TradingStatus, string Units, string Money, string Class, string UnitsSold, string FinalPrice, string GrossAmount, string PurchaseRes, string Loan, string Options, string Charges, string GST, string TAX, string NetAmount)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSTRDSH");
            ENSTRDSH.HolderIdentifier.ValidateFieldValue(HIN);
            ENSTRDSH.HolderTypeCode.ValidateFieldValue(Type);
            ENSTRDSH.TradingID.ValidateFieldValue(ID);
            ENSTRDSH.TrdTransNumber.ValidateFieldValue(Tran);
            ENSTRDSH.TradingStatus.ValidateFieldValue(TradingStatus);
            ENSTRDSH.Units.ValidateFieldValue(Units);
            ENSTRDSH.Money.ValidateFieldValue(Money);
            ENSTRDSH.ClassCode.ValidateFieldValue(Class);
            ENSTRDSH.SoldUnits.ValidateFieldValue(UnitsSold);
            ENSTRDSH.Price.ValidateFieldValue(FinalPrice);
            ENSTRDSH.Gross.ValidateFieldValue(GrossAmount);
            ENSTRDSH.PurchRes.ValidateFieldValue(PurchaseRes);
            ENSTRDSH.Loan.ValidateFieldValue(Loan);
            ENSTRDSH.OptionCosts.ValidateFieldValue(Options);
            ENSTRDSH.TotalHolderCharges.ValidateFieldValue(Charges);
            ENSTRDSH.Gst.ValidateFieldValue(GST);
            ENSTRDSH.WithholdingTax.ValidateFieldValue(TAX);
            ENSTRDSH.Nett.ValidateFieldValue(NetAmount);
        }

        [Then(@"In ENSTRDSH  I should see Trading History Charge details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTradingHistoryChargeDetails(string TradeDate, string SettlementDate, string ChargeCode1, string ChargeCode2, string ChargeCode3, string ChargeCode4, string ChargeCode5, string ChargeCode6, string ChargeDesc1, string ChargeDesc2, string ChargeDesc3, string ChargeDesc4, string ChargeDesc5, string ChargeDesc6, string Charge1, string Charge2, string Charge3, string PaidByFlag1, string PaidByFlag2)
        {
            ENSTRDSH.TradeDate.ValidateFieldValue(TradeDate);
            ENSTRDSH.SettlementDate.ValidateFieldValue(SettlementDate);
            ENSTRDSH.ChargeCode.ValidateFieldValue(1, ChargeCode1);
            ENSTRDSH.ChargeCode.ValidateFieldValue(2, ChargeCode2);
            ENSTRDSH.ChargeCode.ValidateFieldValue(3, ChargeCode3);
            ENSTRDSH.ChargeCode.ValidateFieldValue(4, ChargeCode4);
            ENSTRDSH.ChargeCode.ValidateFieldValue(5, ChargeCode5);
            ENSTRDSH.ChargeCode.ValidateFieldValue(6, ChargeCode6);
            ENSTRDSH.ChargeDesc.ValidateFieldValue(1, ChargeDesc1);
            ENSTRDSH.ChargeDesc.ValidateFieldValue(2, ChargeDesc2);
            ENSTRDSH.ChargeDesc.ValidateFieldValue(3, ChargeDesc3);
            ENSTRDSH.ChargeDesc.ValidateFieldValue(4, ChargeDesc4);
            ENSTRDSH.ChargeDesc.ValidateFieldValue(5, ChargeDesc5);
            ENSTRDSH.ChargeDesc.ValidateFieldValue(6, ChargeDesc6);
            ENSTRDSH.Charge.ValidateFieldValue(1, Charge1);
            ENSTRDSH.Charge.ValidateFieldValue(2, Charge2);
            ENSTRDSH.Charge.ValidateFieldValue(5, Charge3);
            ENSTRDSH.PaidBYFlag.ValidateFieldValue(1, PaidByFlag1);
            ENSTRDSH.PaidBYFlag.ValidateFieldValue(2, PaidByFlag2);
        }

        [Then(@"In ENSTRDSH  I should see Trading History Payment details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTradingHistoryPaymentDetails(string PaymentDate, string PayRefNumber, string PaymentAccount, string CurrencyCode, string CurrencyDesc, string PaymentMethod, string BankCode, string AccountNbr, string AccountName)
        {
            ENSTRDSH.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSTRDSH.PayRefNumber.ValidateFieldValue(PayRefNumber);
            ENSTRDSH.PayAccountNumber.ValidateFieldValue(PaymentAccount);
            ENSTRDSH.CurrencyCode.ValidateFieldValue(CurrencyCode);
            ENSTRDSH.CurrencyDesc.ValidateFieldValue(CurrencyDesc);
            ENSTRDSH.PaymentMethod.ValidateFieldValue(PaymentMethod);

            if (PaymentMethod == "Direct Banking")
            {
                ENSTRDSH.BankCode.ValidateFieldValue(BankCode);
                ENSTRDSH.PayeeAccountNumber.ValidateFieldValue(AccountNbr);
                ENSTRDSH.AccountName.ValidateFieldValue(AccountName);
            }
        }

        [Then(@"In ENSTRDSH  I should see Trading History Remaining Balance Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTradingHistoryRemainingBalanceDetails(string RemBal, string RemBalDesc, string ToHolder, string TransferClass, string TransferReg, string TransferCertID)
        {
            if (RemBal != "")
            {
                ENSTRDSH.RemainingBalance.ValidateFieldValue(RemBal);
                ENSTRDSH.RemBalIndDesc.ValidateFieldValue(RemBalDesc);
                ENSTRDSH.TransfereeHolder.ValidateFieldValue(ToHolder);
                ENSTRDSH.TransfereeClass.ValidateFieldValue(TransferClass);
                ENSTRDSH.TransfereeRegister.ValidateFieldValue(TransferReg);
                ENSTRDSH.TransfereeCertID.ValidateFieldValue(TransferCertID);
            }
        }

        [Then(@"In ENSTRD48 I should see trading history summary as below:")]
        public void ShouldSeeTradingHistorySummary(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");
            string Line3 = data.GetData("Line3");
            string Line4 = data.GetData("Line4");
            string Line5 = data.GetData("Line5");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSTRD48");
            ENSTRD48.HolderIdentifier.ValidateFieldValue(HIN);
            ENSTRD48.HistoryLine.ValidateFieldValue(1, Line1);
            ENSTRD48.HistoryLine.ValidateFieldValue(2, Line2);
            ENSTRD48.HistoryLine.ValidateFieldValue(3, Line3);
            ENSTRD48.HistoryLine.ValidateFieldValue(4, Line4);
            ENSTRD48.HistoryLine.ValidateFieldValue(5, Line5);
        }

        [Then(@"In ENSTRD48 I should see trading history summary as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTradingHistorySummary(string Line1, string Line2, string Line3, string Line4, string Line5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSTRD48");
            //ENSTRD48.HistoryLine.ValidateFieldValue(1, Line1);
            ENSTRD48.HistoryLine.ValidateFieldValue(2, Line2);
            ENSTRD48.HistoryLine.ValidateFieldValue(3, Line3);
            ENSTRD48.HistoryLine.ValidateFieldValue(4, Line4);
            ENSTRD48.HistoryLine.ValidateFieldValue(5, Line5);
        }

        [Then(@"In ENSESS14 I should see Transaction Details as below:")]
        public void ShouldSeeTransactionDetails(Table data)
        {
            string Register = data.GetData("Register");
            string USAN = data.GetData("USAN");
            string RegType = data.GetData("RegType");
            string Run = data.GetData("Run");
            string Tran = data.GetData("Tran");
            string Sequesnce = data.GetData("Sequesnce");
            string Residue = data.GetData("Residue");
            string TaxAmount = data.GetData("TaxAmount");
            string SharesAwarded = data.GetData("SharesAwarded");
            string TranDate = data.GetData("TranDate");
            string TranType = data.GetData("TranType");
            string TradeRef = data.GetData("TradeRef");
            string PaymentAmount = data.GetData("PaymentAmount");
            string AccumulationPeriod = data.GetData("AccumulationPeriod");
            string MarketValue = data.GetData("MarketValue");
            string UnmatchedShares = data.GetData("UnmatchedShares");

            ENSESS14.Register.ValidateFieldValue(Register);
            ENSESS14.Usan.ValidateFieldValue(USAN);
            ENSESS14.RegType.ValidateFieldValue(RegType);
            ENSESS14.Run.ValidateFieldValue(Run);
            ENSESS14.Trans.ValidateFieldValue(Tran);
            ENSESS14.SeqNbr.ValidateFieldValue(Sequesnce);
            ENSESS14.Residue.ValidateFieldValue(Residue);
            ENSESS14.TaxAmount.ValidateFieldValue(TaxAmount);
            ENSESS14.Shares.ValidateFieldValue(SharesAwarded);
            ENSESS14.TransDate.ValidateFieldValue(TranDate);
            ENSESS14.TransType.ValidateFieldValue(TranType);
            ENSESS14.TradeRef.ValidateFieldValue(TradeRef);
            ENSESS14.PayAmt.ValidateFieldValue(PaymentAmount);
            ENSESS14.AccumPeriod.ValidateFieldValue(AccumulationPeriod);
            ENSESS14.MarketValue.ValidateFieldValue(MarketValue);
            ENSESS14.Unmatched.ValidateFieldValue(UnmatchedShares);
        }

        [Then(@"In ENS01063 I should see Transaction Extra Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTransactionExtraDetails(string ExtraLine1, string ExtraLine2, string ExtraLine3, string ExtraLine4, string ExtraLine5, string ExtraLine6, string ExtraLine7, string ExtraLine8)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01063");
            ENS01063.ExtraDetailLines.ValidateFieldValue(1, ExtraLine1);
            ENS01063.ExtraDetailLines.ValidateFieldValue(2, ExtraLine2);
            ENS01063.ExtraDetailLines.ValidateFieldValue(3, ExtraLine3);
            ENS01063.ExtraDetailLines.ValidateFieldValue(4, ExtraLine4);
            ENS01063.ExtraDetailLines.ValidateFieldValue(5, ExtraLine5);
            ENS01063.ExtraDetailLines.ValidateFieldValue(6, ExtraLine6);
            ENS01063.ExtraDetailLines.ValidateFieldValue(7, ExtraLine7);
            ENS01063.ExtraDetailLines.ValidateFieldValue(8, ExtraLine8);
        }

        [Then(@"In ENS04050 I should see Transaction Summary as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeTransactionSummary(string Line1, string Line2, string Line3, string Line4, string Line5, string Line6, string Line7, string Line8, string Line9, string Line10, string Line11, string Line12, string Line13, string Line14, string Line15, string Line16, string Line17, string Line18, string Line19)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS04050");
            ENS04050.ScreenLine.ValidateFieldValue(1, Line1);
            ENS04050.ScreenLine.ValidateFieldValue(2, Line2);
            ENS04050.ScreenLine.ValidateFieldValue(3, Line3);
            ENS04050.ScreenLine.ValidateFieldValue(4, Line4);
            ENS04050.ScreenLine.ValidateFieldValue(5, Line5);
            ENS04050.ScreenLine.ValidateFieldValue(6, Line6);
            ENS04050.ScreenLine.ValidateFieldValue(7, Line7);
            ENS04050.ScreenLine.ValidateFieldValue(8, Line8);
            ENS04050.ScreenLine.ValidateFieldValue(9, Line9);
            ENS04050.ScreenLine.ValidateFieldValue(10, Line10);
            ENS04050.ScreenLine.ValidateFieldValue(11, Line11);
            ENS04050.ScreenLine.ValidateFieldValue(12, Line12);
            ENS04050.ScreenLine.ValidateFieldValue(13, Line13);
            ENS04050.ScreenLine.ValidateFieldValue(14, Line14);
            ENS04050.ScreenLine.ValidateFieldValue(15, Line15);
            ENS04050.ScreenLine.ValidateFieldValue(16, Line16);
            ENS04050.ScreenLine.ValidateFieldValue(17, Line17);
            ENS04050.ScreenLine.ValidateFieldValue(18, Line18);
            ENS04050.ScreenLine.ValidateFieldValue(19, Line19);
        }

        [Then(@"In ENS01088 I should see Update extract details as below:")]
        public void ShouldSeeUpdateExtractDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string ExtractFile = data.GetData("ExtractFile");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01088");
            ENS01088.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01088.FileName.ValidateFieldValue(ExtractFile);
        }

        [Then(@"In ENTUSA05 I should see US Tax Payer Controlling persons details as below:")]
        public void ShouldSeeUSTaxPayerControllingPersonsDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string WorstCaseInvestor = data.GetData("WorstCaseInvestor");
            string CuringStatus = data.GetData("CuringStatus");
            string AccountType = data.GetData("AccountType");
            string PreExisting = data.GetData("PreExisting");
            string USIndicia = data.GetData("USIndicia");
            string USTaxCode = data.GetData("USTaxCode");
            string FATCAStatus = data.GetData("FATCAStatus");
            string ValueStatus = data.GetData("ValueStatus");
            string NameAddress1 = data.GetData("NameAddress1");
            string NameAddress2 = data.GetData("NameAddress2");
            string NameAddress3 = data.GetData("NameAddress3");
            string NameAddress4 = data.GetData("NameAddress4");
            string NameAddress5 = data.GetData("NameAddress5");
            string NameAddress6 = data.GetData("NameAddress6");
            string InvName = data.GetData("InvName");
            string WC = data.GetData("WC");
            string InvestorType = data.GetData("InvestorType");
            string TINStatus = data.GetData("TINStatus");
            string FATCA = data.GetData("FATCA");
            string InvCntrl = data.GetData("InvCntrl");
            string CntName = data.GetData("CntName");
            string CntAddress1 = data.GetData("CntAddress1");
            string CntAddress2 = data.GetData("CntAddress2");
            string CntAddress3 = data.GetData("CntAddress3");
            string CntAddress4 = data.GetData("CntAddress4");
            string CntAddress5 = data.GetData("CntAddress5");
            string CntlPostCode = data.GetData("CntlPostCode");
            string CntCountry = data.GetData("CntCountry");
            string CntCitizenship = data.GetData("CntCitizenship");
            string CntTaxIdentifier = data.GetData("CntTaxIdentifier");
            string CntTIN = data.GetData("CntTIN");
            string CntUSTaxCode = data.GetData("CntUSTaxCode");
            string CntGINNP1 = data.GetData("CntGINN-P1");
            string CntGINNP2 = data.GetData("CntGINN-P2");
            string CntGINNP3 = data.GetData("CntGINN-P3");
            string CntGINNP4 = data.GetData("CntGINN-P4");
            string CntDateofBirth = data.GetData("CntDateofBirth");
            string CntTINStatus = data.GetData("CntTINStatus");
            string FatcaStatus = data.GetData("FatcaStatus");
            string CntW8ExpiryDate = data.GetData("CntW8ExpiryDate");
            string GINNException = data.GetData("GINNException");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA05");
            ENTUSA05.HolderIdentifier.ValidateFieldValue(HIN);
            ENTUSA05.HolderTypeCode.ValidateFieldValue(Type);
            ENTUSA05.WorstCaseInvNbr.ValidateFieldValue(WorstCaseInvestor);
            //ENTUSA05.CuringStatus.ValidateFieldValue(CuringStatus);
            //ENTUSA05.WcaseAccountType.ValidateFieldValue(AccountType);
            //ENTUSA05.WcasePreExisting.ValidateFieldValue(PreExisting);
            //ENTUSA05.WcaseUSIndicia.ValidateFieldValue(USIndicia);
            ENTUSA05.WcaseUSTaxCode.ValidateFieldValue(USTaxCode);
            //ENTUSA05.WcaseChapter4Status.ValidateFieldValue(FATCAStatus);
            ENTUSA05.SysValueStatus.ValidateFieldValue(ValueStatus);
            ENTUSA05.HnaLine.ValidateFieldValue(1, NameAddress1);
            ENTUSA05.HnaLine.ValidateFieldValue(2, NameAddress2);
            ENTUSA05.HnaLine.ValidateFieldValue(3, NameAddress3);
            ENTUSA05.HnaLine.ValidateFieldValue(4, NameAddress4);
            ENTUSA05.HnaLine.ValidateFieldValue(5, NameAddress5);
            ENTUSA05.HnaLine.ValidateFieldValue(6, NameAddress6);
            ENTUSA05.InvName.ValidateFieldValue(InvName);
            ENTUSA05.WorstCaseInvInd.ValidateFieldValue(WC);
            ENTUSA05.InvType.ValidateFieldValue(InvestorType);
            ENTUSA05.InvTinStatus.ValidateFieldValue(TINStatus);
            ENTUSA05.InvChpt4.ValidateFieldValue(FATCA);
            //ENTUSA05.InvNumCntrols.ValidateFieldValue(InvCntrl);
            ENTUSA05.CntName.ValidateFieldValue(CntName);
            ENTUSA05.CntAddressLine.ValidateFieldValue(1, CntAddress1);
            ENTUSA05.CntAddressLine.ValidateFieldValue(2, CntAddress2);
            ENTUSA05.CntAddressLine.ValidateFieldValue(3, CntAddress3);
            ENTUSA05.CntAddressLine.ValidateFieldValue(4, CntAddress4);
            ENTUSA05.CntAddressLine.ValidateFieldValue(5, CntAddress5);
            ENTUSA05.CntPostcode.ValidateFieldValue(CntlPostCode);
            ENTUSA05.CntCountry.ValidateFieldValue(CntCountry);
            ENTUSA05.CntCitizenship.ValidateFieldValue(CntCitizenship);
            ENTUSA05.CntTaxIdentifier.ValidateFieldValue(CntTaxIdentifier);
            ENTUSA05.CntTin.ValidateFieldValue(CntTIN);
            ENTUSA05.CntUSTaxCode.ValidateFieldValue(CntUSTaxCode);
            ENTUSA05.CntGiinP1.ValidateFieldValue(CntGINNP1);
            ENTUSA05.CntGiinP2.ValidateFieldValue(CntGINNP2);
            ENTUSA05.CntGiinP3.ValidateFieldValue(CntGINNP3);
            ENTUSA05.CntGiinP4.ValidateFieldValue(CntGINNP4);
            ENTUSA05.CntDobIncorp.ValidateFieldValue(CntDateofBirth);
            ENTUSA05.CntTinStatus.ValidateFieldValue(CntTINStatus);
            ENTUSA05.CntChpt4.ValidateFieldValue(FatcaStatus);
            ENTUSA05.CntW8ExpDate.ValidateFieldValue(CntW8ExpiryDate);
            ENTUSA05.CntGiinException.ValidateFieldValue(GINNException);
        }

        [Then(@"In ENTUSA04 I should see US Tax Payer Controlling Persons summary as below:")]
        public void ShouldSeeUSTaxPayerControllingPersonsSummary(Table data)
        {
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string WorstCaseInvestor = data.GetData("WorstCaseInvestor");
            string CuringStatus = data.GetData("CuringStatus");
            string AccountType = data.GetData("AccountType");
            string PreExisting = data.GetData("PreExisting");
            string USIndicia = data.GetData("USIndicia");
            string USTaxCode = data.GetData("USTaxCode");
            string FATCAStatus = data.GetData("FATCAStatus");
            string ValueStatus = data.GetData("ValueStatus");
            string NameAddress1 = data.GetData("NameAddress1");
            string NameAddress2 = data.GetData("NameAddress2");
            string NameAddress3 = data.GetData("NameAddress3");
            string NameAddress4 = data.GetData("NameAddress4");
            string NameAddress5 = data.GetData("NameAddress5");
            string NameAddress6 = data.GetData("NameAddress6");
            string InvName = data.GetData("InvName");
            string WC = data.GetData("WC");
            string InvestorType = data.GetData("InvestorType");
            string TINStatus = data.GetData("TINStatus");
            string FATCA = data.GetData("FATCA");
            string InvCntrl = data.GetData("InvCntrl");
            string CntName = data.GetData("CntName");
            string CntCountry = data.GetData("CntCountry");
            string CntCitizenship = data.GetData("CntCitizenship");
            string CntCntrl = data.GetData("CntCntrl");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA04");
            ENTUSA04.HolderIdentifier.ValidateFieldValue(HIN);
            ENTUSA04.HolderTypeCode.ValidateFieldValue(Type);
            ENTUSA04.WorstCaseInvNbr.ValidateFieldValue(WorstCaseInvestor);
            //ENTUSA04.CuringStatus.ValidateFieldValue(CuringStatus);
            //ENTUSA04.WcaseAccountType.ValidateFieldValue(AccountType);
            //ENTUSA04.WcasePreExisting.ValidateFieldValue(PreExisting);
            //ENTUSA04.WcaseUSIndicia.ValidateFieldValue(USIndicia);
            ENTUSA04.WcaseUSTaxCode.ValidateFieldValue(USTaxCode);
            //ENTUSA04.WcaseChapter4Status.ValidateFieldValue(FATCAStatus);
            ENTUSA04.SysValueStatus.ValidateFieldValue(ValueStatus);
            ENTUSA04.HnaLine.ValidateFieldValue(1, NameAddress1);
            ENTUSA04.HnaLine.ValidateFieldValue(2, NameAddress2);
            ENTUSA04.HnaLine.ValidateFieldValue(3, NameAddress3);
            ENTUSA04.HnaLine.ValidateFieldValue(4, NameAddress4);
            ENTUSA04.HnaLine.ValidateFieldValue(5, NameAddress5);
            ENTUSA04.HnaLine.ValidateFieldValue(6, NameAddress6);
            ENTUSA04.InvName.ValidateFieldValue(InvName);
            ENTUSA04.WorstCaseInvInd.ValidateFieldValue(WC);
            ENTUSA04.InvType.ValidateFieldValue(InvestorType);
            ENTUSA04.InvTinStatus.ValidateFieldValue(TINStatus);
            ENTUSA04.InvChpt4.ValidateFieldValue(FATCA);
            //ENTUSA04.InvNumCntrols.ValidateFieldValue(InvCntrl);
            ENTUSA04.CntName.ValidateFieldValue(CntName);
            ENTUSA04.CntResCountry.ValidateFieldValue(CntCountry);
            ENTUSA04.CntCtznCountry.ValidateFieldValue(CntCitizenship);
            //ENTUSA04.CntBen.ValidateFieldValue(CntCntrl);
        }

        [Then(@"In ENTUSA01 I should see US Tax Payer General Details as below:")]
        public void ShouldSeeUSTaxPayerGeneralDetails(Table data)
        {
            string Key = data.GetData("Key");
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string WorstCaseInvestor = data.GetData("WorstCaseInvestor");
            string CuringStatus = data.GetData("CuringStatus");
            string AccountType = data.GetData("AccountType");
            string PreExisting = data.GetData("PreExisting");
            string USIndicia = data.GetData("USIndicia");
            string USTaxCode = data.GetData("USTaxCode");
            string FATCAStatus = data.GetData("FATCAStatus");
            string ValueStatus = data.GetData("ValueStatus");
            string NameAddress1 = data.GetData("NameAddress1");
            string NameAddress2 = data.GetData("NameAddress2");
            string NameAddress3 = data.GetData("NameAddress3");
            string NameAddress4 = data.GetData("NameAddress4");
            string NameAddress5 = data.GetData("NameAddress5");
            string NameAddress6 = data.GetData("NameAddress6");
            string Line = data.GetData("Line");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA01");
            ENTUSA01.HolderNameKey.ValidateFieldValue(Key);
            ENTUSA01.HolderIdentifier.ValidateFieldValue(HIN);
            ENTUSA01.HolderTypeCode.ValidateFieldValue(Type);
            ENTUSA01.WorstCaseInvNbr.ValidateFieldValue(WorstCaseInvestor);
            //ENTUSA01.CuringStatus.ValidateFieldValue(CuringStatus);
            ENTUSA01.WcaseAccountType.ValidateFieldValue(AccountType);
            //ENTUSA01.WcasePreExisting.ValidateFieldValue(PreExisting);
            //ENTUSA01.WcaseUSIndicia.ValidateFieldValue(USIndicia);
            ENTUSA01.WcaseUSTaxCode.ValidateFieldValue(USTaxCode);
            //ENTUSA01.WcaseChapter4Status.ValidateFieldValue(FATCAStatus);
            ENTUSA01.SysValueStatus.ValidateFieldValue(ValueStatus);
            ENTUSA01.HnaLine.ValidateFieldValue(1, NameAddress1);
            ENTUSA01.HnaLine.ValidateFieldValue(2, NameAddress2);
            ENTUSA01.HnaLine.ValidateFieldValue(3, NameAddress3);
            ENTUSA01.HnaLine.ValidateFieldValue(4, NameAddress4);
            ENTUSA01.HnaLine.ValidateFieldValue(5, NameAddress5);
            ENTUSA01.HnaLine.ValidateFieldValue(6, NameAddress6);
            ENTUSA01.InvName.ValidateFieldValue(1, Line);
        }

        [Then(@"I ENTUSA03 I should see US Tax payer Investor Details as below:")]
        public void ShouldSeeUSTaxPayerInvestorDetails(Table data)
        {
            //string Key = data.GetData("Key");
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string WorstCaseInvestor = data.GetData("WorstCaseInvestor");
            string CuringStatus = data.GetData("CuringStatus");
            string AccountType = data.GetData("AccountType");
            string PreExisting = data.GetData("PreExisting");
            string USIndicia = data.GetData("USIndicia");
            string USTaxCode = data.GetData("USTaxCode");
            string FATCAStatus = data.GetData("FATCAStatus");
            string ValueStatus = data.GetData("ValueStatus");
            string NameAddress1 = data.GetData("NameAddress1");
            string NameAddress2 = data.GetData("NameAddress2");
            string NameAddress3 = data.GetData("NameAddress3");
            string NameAddress4 = data.GetData("NameAddress4");
            string NameAddress5 = data.GetData("NameAddress5");
            string NameAddress6 = data.GetData("NameAddress6");
            string JntAccountType = data.GetData("JntAccountType");
            string Name = data.GetData("Name");
            string TINStatus = data.GetData("TINStatus");
            string TIN = data.GetData("TIN");
            string InvUSTaxCode = data.GetData("USTaxCode");
            string FatcaStatus = data.GetData("FatcaStatus");
            string ConBenLit = data.GetData("ConBenLit");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA03");
            //ENTUSA03.Key.ValidateFieldValue(Key);
            ENTUSA03.HolderIdentifier.ValidateFieldValue(HIN);
            ENTUSA03.HolderTypeCode.ValidateFieldValue(Type);
            ENTUSA03.WorstCaseInvNbr.ValidateFieldValue(WorstCaseInvestor);
            //ENTUSA03.CuringStatus.ValidateFieldValue(CuringStatus);
            //ENTUSA03.WcaseAccountType.ValidateFieldValue(AccountType);
            //ENTUSA03.WcasePreExisting.ValidateFieldValue(PreExisting);
            //ENTUSA03.WcaseUSIndicia.ValidateFieldValue(USIndicia);
            ENTUSA03.WcaseUSTaxCode.ValidateFieldValue(USTaxCode);
            //ENTUSA03.WcaseChapter4Status.ValidateFieldValue(FATCAStatus);
            ENTUSA03.SysValueStatus.ValidateFieldValue(ValueStatus);
            ENTUSA03.HnaLine.ValidateFieldValue(1, NameAddress1);
            ENTUSA03.HnaLine.ValidateFieldValue(2, NameAddress2);
            ENTUSA03.HnaLine.ValidateFieldValue(3, NameAddress3);
            ENTUSA03.HnaLine.ValidateFieldValue(4, NameAddress4);
            ENTUSA03.HnaLine.ValidateFieldValue(5, NameAddress5);
            ENTUSA03.HnaLine.ValidateFieldValue(6, NameAddress6);
            //ENTUSA03.JntAccountType.ValidateFieldValue(JntAccountType);
            ENTUSA03.InvName.ValidateFieldValue(Name);
            ENTUSA03.InvTinStatus.ValidateFieldValue(TINStatus);
            ENTUSA03.InvTin.ValidateFieldValue(TIN);
            ENTUSA03.InvUSTaxCode.ValidateFieldValue(InvUSTaxCode);
            //ENTUSA03.InvChpt4.ValidateFieldValue(FatcaStatus);
            ENTUSA03.ConBenLit.ValidateFieldValue(ConBenLit);
        }

        //[When(@"I Press F7")]
        //public void IPressF7()
        //{
        //    Spartan.Core.WinForms.WinFormsDriver.PressF7();
        [Then(@"In ENSESS25 I should see Vesting Transaction details as below ""(.*)""")]
        public void ShouldSeeVestingTransactionDetails(string Tran1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS25");
            ENSESS25.DetailLine.ValidateFieldValue(1, Tran1);
        }

        [Then(@"In ENS01075 I should see Wire Instructions as below:")]
        public void ShouldSeeWireInstructions(Table data)
        {
            string NameKey = data.GetData("Name Key");
            string HIN = data.GetData("HIN");
            string HolderType = data.GetData("Holder Type");
            string CountryCode = data.GetData("Country Code");
            string Country = data.GetData("Country");
            string BankSystem = data.GetData("Bank System");
            string RoutingCode = data.GetData("Routing Code");
            string SwiftCode = data.GetData("Swift Code");
            string AccountNumber = data.GetData("Account Number");
            string AccountName = data.GetData("Account Name");
            string CurrencyCode = data.GetData("Currency Code");
            string Currency = data.GetData("Currency");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Postcode = data.GetData("Postcode");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01075");

            ENS01075.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01075.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01075.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS01075.WRCountryCode.ValidateFieldValue(CountryCode);
            ENS01075.WRCountryName.ValidateFieldValue(Country);
            ENS01075.WRBulkPaySystem.ValidateFieldValue(BankSystem);
            ENS01075.WRBankCode.ValidateFieldValue(RoutingCode);
            ENS01075.WRSwiftCode.ValidateFieldValue(SwiftCode);
            ENS01075.WRAccountNumber.ValidateFieldValue(AccountNumber);
            ENS01075.WRAccountName.ValidateFieldValue(AccountName);
            ENS01075.WRCurrencyCode.ValidateFieldValue(CurrencyCode);
            ENS01075.WRCurrencyDesc.ValidateFieldValue(Currency);
            ENS01075.HnaLine.ValidateFieldValue(1, Name);
            ENS01075.HnaLine.ValidateFieldValue(2, Address1);
            ENS01075.HnaLine.ValidateFieldValue(3, Address2);
            ENS01075.Postcode.ValidateFieldValue(Postcode);
            Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In ENS0104Z I should see ZAF Tax Payer details as below:")]
        public void ShouldSeeZAFTaxPayerDetails(Table data)
        {
            string Key = data.GetData("Key");
            string HIN = data.GetData("HIN");
            string CustodianRef = data.GetData("CustodianRef");
            string InternalStatus = data.GetData("InternalStatus");
            string InternalStatusDesc = data.GetData("InternalStatusDesc");
            string TaxDomocile = data.GetData("TaxDomocile");
            string TradingName1 = data.GetData("TradingName1");
            string TradingName2 = data.GetData("TradingName2");
            string SCRIPNameAddress1 = data.GetData("SCRIPNameAddress1");
            string SCRIPNameAddress2 = data.GetData("SCRIPNameAddress2");
            string SCRIPNameAddress3 = data.GetData("SCRIPNameAddress3");
            string SCRIPPostcode = data.GetData("SCRIPPostcode");
            string NaturePerson = data.GetData("NaturePerson");
            string NaturePersonDesc = data.GetData("NaturePersonDesc");
            string ResNameAddress1 = data.GetData("ResNameAddress1");
            string ResNameAddress2 = data.GetData("ResNameAddress2");
            string ResNameAddress3 = data.GetData("ResNameAddress3");
            string ResNameAddress4 = data.GetData("ResNameAddress4");
            string ResNameAddress5 = data.GetData("ResNameAddress5");
            string ResNameAddress6 = data.GetData("ResNameAddress6");
            string ResPostcode = data.GetData("ResPostcode");
            string TaxRef = data.GetData("TaxRef");
            string RefType = data.GetData("RefType");
            string IdNo = data.GetData("IdNo");
            string IdType = data.GetData("IdType");
            string DateOfBirth = data.GetData("DateOfBirth");
            string Phone = data.GetData("Phone");
            string Email = data.GetData("Email");
            string DeclarationName = data.GetData("DeclarationName");
            string DeclarationCapaciy = data.GetData("DeclarationCapaciy");
            string DeclarationCapaciyDesc = data.GetData("DeclarationCapaciyDesc");
            string Date = data.GetData("Date");
            string PostalNameAddress1 = data.GetData("PostalNameAddress1");
            string PostalNameAddress2 = data.GetData("PostalNameAddress2");
            string PostalNameAddress3 = data.GetData("PostalNameAddress3");
            string PostalNameAddress4 = data.GetData("PostalNameAddress4");
            string PostalNameAddress5 = data.GetData("PostalNameAddress5");
            string PostalNameAddress6 = data.GetData("PostalNameAddress6");
            string PostalPostcode = data.GetData("PostalPostcode");
            string ExemptionCode = data.GetData("ExemptionCode");
            string ExemptionCodeDesc = data.GetData("ExemptionCodeDesc");
            string CountryOfPassport = data.GetData("CountryOfPassport");
            string CertStatus = data.GetData("CertStatus");
            string CertStatusDesc = data.GetData("CertStatusDesc");
            string UndertakingName = data.GetData("UndertakingName");
            string UndertakingCapacty = data.GetData("UndertakingCapacty");
            string UndertakingCapactyDesc = data.GetData("UndertakingCapactyDesc");
            string UndertakingDate = data.GetData("UndertakingDate");
            string SignatureDate = data.GetData("SignatureDate");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS0104Z");
            ENS0104Z.HolderNameKey.ValidateFieldValue(Key);
            ENS0104Z.HolderIdentifier.ValidateFieldValue(HIN);
            ENS0104Z.CustodianReference.ValidateFieldValue(CustodianRef);
            ENS0104Z.OtherStatus.ValidateFieldValue(InternalStatus);
            ENS0104Z.OtherStatusDesc.ValidateFieldValue(InternalStatusDesc);
            ENS0104Z.TaxCode.ValidateFieldValue(TaxDomocile);
            ENS0104Z.TradingName1.ValidateFieldValue(TradingName1);
            ENS0104Z.TradingName2.ValidateFieldValue(TradingName2);
            ENS0104Z.ScripRegAddrLine.ValidateFieldValue(1, SCRIPNameAddress1);
            ENS0104Z.ScripRegAddrLine.ValidateFieldValue(2, SCRIPNameAddress2);
            ENS0104Z.ScripRegAddrLine.ValidateFieldValue(3, SCRIPNameAddress3);
            ENS0104Z.ScripRegAddrPCDom.ValidateFieldValue(SCRIPPostcode);
            ENS0104Z.NaturePerson.ValidateFieldValue(NaturePerson);
            ENS0104Z.NaturePersonDesc.ValidateFieldValue(NaturePersonDesc);
            ENS0104Z.ResAddrLine.ValidateFieldValue(1, ResNameAddress1);
            ENS0104Z.ResAddrLine.ValidateFieldValue(2, ResNameAddress2);
            ENS0104Z.ResAddrLine.ValidateFieldValue(3, ResNameAddress3);
            ENS0104Z.ResAddrLine.ValidateFieldValue(4, ResNameAddress4);
            ENS0104Z.ResAddrLine.ValidateFieldValue(5, ResNameAddress5);
            ENS0104Z.ResAddrLine.ValidateFieldValue(6, ResNameAddress6);
            ENS0104Z.ResAddrPCDom.ValidateFieldValue(ResPostcode);
            ENS0104Z.TaxReference.ValidateFieldValue(TaxRef);
            ENS0104Z.TaxRefType.ValidateFieldValue(RefType);
            ENS0104Z.IDReference.ValidateFieldValue(IdNo);
            ENS0104Z.IDRefType.ValidateFieldValue(IdType);
            ENS0104Z.DateBirth.ValidateFieldValue(DateOfBirth);
            ENS0104Z.Phone.ValidateFieldValue(Phone);
            ENS0104Z.Email.ValidateFieldValue(Email);
            ENS0104Z.DecName.ValidateFieldValue(DeclarationName);
            ENS0104Z.DecCapCode.ValidateFieldValue(DeclarationCapaciy);
            ENS0104Z.DecDate.ValidateFieldValue(Date);
            ENS0104Z.PostAddrLine.ValidateFieldValue(1, PostalNameAddress1);
            ENS0104Z.PostAddrLine.ValidateFieldValue(2, PostalNameAddress2);
            ENS0104Z.PostAddrLine.ValidateFieldValue(3, PostalNameAddress3);
            ENS0104Z.PostAddrLine.ValidateFieldValue(4, PostalNameAddress4);
            ENS0104Z.PostAddrLine.ValidateFieldValue(5, PostalNameAddress5);
            ENS0104Z.PostAddrLine.ValidateFieldValue(6, PostalNameAddress6);
            ENS0104Z.PostAddrPCDom.ValidateFieldValue(PostalPostcode);
            ENS0104Z.ExemptionCode.ValidateFieldValue(ExemptionCode);
            ENS0104Z.ExemptionCodeDesc.ValidateFieldValue(ExemptionCodeDesc);
            ENS0104Z.CntryOFIssue.ValidateFieldValue(CountryOfPassport);
            ENS0104Z.CertStatus.ValidateFieldValue(CertStatus);
            ENS0104Z.CertStatusDesc.ValidateFieldValue(CertStatusDesc);
            ENS0104Z.UndName.ValidateFieldValue(UndertakingName);
            ENS0104Z.UndCapCode.ValidateFieldValue(UndertakingCapacty);
            ENS0104Z.UndCapDesc.ValidateFieldValue(UndertakingCapactyDesc);
            ENS0104Z.UndDate.ValidateFieldValue(UndertakingDate);
            ENS0104Z.SigDate.ValidateFieldValue(SignatureDate);
        }

        [Then(@"In ENSDIV02 I should see Dividend History Brief as\t""(.*)""\t""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""\t""(.*)"" ""(.*)""")]
        public void ThenInENSDIVIShouldSeeDividendHistoryBriefAs(string PaymentCode, string ASXCAType, string DivDesc, string PaymentDate, string Source, string PayAccount, string ReferenceNbr, string CalcCurrency, string Gross, string Net, string PaidCurreny, string PaymentDetail1, string SubPayCode, string SubPaymentType, string SubPayDesc, string SubPayGross, string SubPayNett)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIV02");
            ENSDIV02.DividendCode.ValidateFieldValue(PaymentCode);
            ENSDIV02.DividendType.ValidateFieldValue(ASXCAType);
            ENSDIV02.DividendDesc.ValidateFieldValue(DivDesc);
            ENSDIV02.PaymentDate.ValidateFieldValue(PaymentDate);
            ENSDIV02.DividendSource.ValidateFieldValue(Source);
            ENSDIV02.PayAccountNumber.ValidateFieldValue(PayAccount);
            ENSDIV02.ChequeNumber.ValidateFieldValue(ReferenceNbr);
            ENSDIV02.CalcCurrency.ValidateFieldValue(CalcCurrency);
            ENSDIV02.Gross.ValidateFieldValue(Gross);
            ENSDIV02.PaidCurrCode.ValidateFieldValue(PaidCurreny);
            ENSDIV02.PayDetails.ValidateFieldValue(1, PaymentDetail1);
            ENSDIV02.SubPayCode.ValidateFieldValue(SubPayCode);
            ENSDIV02.SubPayType.ValidateFieldValue(SubPaymentType);
            ENSDIV02.SubPayDesc.ValidateFieldValue(SubPayDesc);
            ENSDIV02.SubPayGross.ValidateFieldValue(SubPayGross);
            ENSDIV02.SubPayNett.ValidateFieldValue(SubPayNett);
        }

        [Then(@"In ENSESS23 I should see Grant Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenInENSESSIShouldSeeGrantDetailsAs(string Plan, string Line1, string Line2, string Line3, string Line4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS23");
            ENSESS07.SchemeCode.ValidateFieldValue(Plan);
            ENSESS07.DetailLine.ValidateFieldValue(1, Line1);
            ENSESS07.DetailLine.ValidateFieldValue(2, Line2);
            ENSESS07.DetailLine.ValidateFieldValue(3, Line3);
            ENSESS07.DetailLine.ValidateFieldValue(5, Line4);
        }

        [Then(@"In ENS01013 I should not see Register details")]
        public void ThenInENSIShouldNotSeeRegisterDetails()
        {
            ENS01001.Action.SetValue("R");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ThenIExpectToSeeErrorWithText("This holder has no register details.");
        }

        [Then(@"In ENS01020 I should see holder extra details as below:")]
        public void ThenInENSIShouldSeeHolderExtraDetailsAsBelow(Table data)
        {
            string HIN = data.GetData("HIN");
            string NameKey = data.GetData("Name Key");
            string HolderType = data.GetData("Holder Type");
            string ExtraHolderID = data.GetData("Extra Holder ID");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Address5 = data.GetData("Address5");
            string HomeTell = data.GetData("Home Tell");
            string WorkTell = data.GetData("Work Tell");
            string Fax = data.GetData("Fax");
            string Mobile = data.GetData("Mobile");
            string Email = data.GetData("Email");
            string ReturnEmail = data.GetData("Return Email");
            string EmailCount = data.GetData("Email Count");
            string ABN1 = data.GetData("ABN1");
            string ABN2 = data.GetData("ABN2");
            string Type1 = data.GetData("Type1");
            string Type2 = data.GetData("Type2");
            string Flag1 = data.GetData("Flag1");
            string Flag1Desc = data.GetData("Flag1 Desc");
            string Flag2 = data.GetData("Flag2");
            string Flag2Desc = data.GetData("Flag2 Desc");
            string Flag3 = data.GetData("Flag3");
            string Flag3Desc = data.GetData("Flag3 Desc");
            string Flag4 = data.GetData("Flag4");
            string Flag4Desc = data.GetData("Flag4 Desc");
            string Flag5 = data.GetData("Flag5");
            string Flag5Desc = data.GetData("Flag5 Desc");
            string Flag6 = data.GetData("Flag6");
            string Flag6Desc = data.GetData("Flag6 Desc");
            string Flag7 = data.GetData("Flag7");
            string Flag7Desc = data.GetData("Flag7 Desc");
            string Flag8 = data.GetData("Flag8");
            string Flag8Desc = data.GetData("Flag8 Desc");
            string Flag9 = data.GetData("Flag9");
            string Flag9Desc = data.GetData("Flag9 Desc");

            ENS01020.HolderNameKey.ValidateFieldValue(NameKey);
            ENS01020.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01020.HolderTypeCode.ValidateFieldValue(HolderType);
            ENS01020.HolderExtraID.ValidateFieldValue(ExtraHolderID);
            ENS01020.HnaLine.ValidateFieldValue(1, Name);
            ENS01020.HnaLine.ValidateFieldValue(2, Address1);
            ENS01020.HnaLine.ValidateFieldValue(3, Address2);
            ENS01020.HnaLine.ValidateFieldValue(4, Address3);
            ENS01020.HnaLine.ValidateFieldValue(5, Address4);
            ENS01020.HnaLine.ValidateFieldValue(6, Address5);
            ENS01020.HomePhone.ValidateFieldValue(HomeTell);
            ENS01020.WorkPhone.ValidateFieldValue(WorkTell);
            ENS01020.FaxNumber.ValidateFieldValue(Fax);
            ENS01020.MobilePhone.ValidateFieldValue(Mobile);
            ENS01020.Email.ValidateFieldValue(Email);
            ENS01020.EmailReturnDate.ValidateFieldValue(ReturnEmail);
            ENS01020.EmailFailCount.ValidateFieldValue(EmailCount);
            ENS01020.Abn1.ValidateFieldValue(ABN1);
            ENS01020.Abn2.ValidateFieldValue(ABN2);
            ENS01020.AbnSuffix1.ValidateFieldValue(Type1);
            ENS01020.AbnSuffix2.ValidateFieldValue(Type2);
            ENS01020.EWFlag1.ValidateFieldValue(Flag1);
            ENS01020.EWFlagDesc1.ValidateFieldValue(Flag1Desc);
            ENS01020.EWFlag2.ValidateFieldValue(Flag2);
            ENS01020.EWFlagDesc2.ValidateFieldValue(Flag2Desc);
            ENS01020.EWFlag3.ValidateFieldValue(Flag3);
            ENS01020.EWFlagDesc3.ValidateFieldValue(Flag3Desc);
            ENS01020.EWFlag4.ValidateFieldValue(Flag4);
            ENS01020.EWFlagDesc4.ValidateFieldValue(Flag4Desc);
            ENS01020.EWFlag5.ValidateFieldValue(Flag5);
            ENS01020.EWFlagDesc5.ValidateFieldValue(Flag5Desc);
            ENS01020.EWFlag6.ValidateFieldValue(Flag6);
            ENS01020.EWFlagDesc6.ValidateFieldValue(Flag6Desc);
            ENS01020.EWFlag7.ValidateFieldValue(Flag7);
            ENS01020.EWFlagDesc7.ValidateFieldValue(Flag7Desc);
            ENS01020.EWFlag8.ValidateFieldValue(Flag8);
            ENS01020.EWFlagDesc8.ValidateFieldValue(Flag8Desc);
            ENS01020.EWFlag9.ValidateFieldValue(Flag9);
            ENS01020.EWFlagDesc9.ValidateFieldValue(Flag9Desc);
        }

        [Then(@"In ENS01001 I should see holder ""(.*)"" Holder Type as below")]
        public void ThenInENSIShouldSeeHolderHolderTypeAsBelow(string Type)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.HolderTypeCode.ValidateFieldValue(Type);
        }

        [Then(@"In ENS01016 I should see Register details as below:")]
        public void ThenInENSIShouldSeeRegisterDetailsAsBelow(Table data)
        {
            string HIN = data.GetData("HIN");
            string Line1 = data.GetData("Line1");
            string Line2 = data.GetData("Line2");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01016");
            ENS01016.HolderIdentifier.ValidateFieldValue(HIN);
            ENS01016.CertificateLine.ValidateFieldValue(1, Line1);
            ENS01016.CertificateLine.ValidateFieldValue(2, Line2);
        }

        [Then(@"In ENS01035 I should see Static History as below ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenInENSIShouldSeeStaticHistoryAsBelowWINFRM(string Run1Pg2, string Tran1Pg2, string Date1Pg2, string TranCode1Pg2, string TranDesc1Pg2, string Reference1Pg2, string Source1Pg2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01035");
            ENS01035.RunNumber.ValidateFieldValue(1, Run1Pg2);
            ENS01035.HldTransNumber.ValidateFieldValue(1, Tran1Pg2);
            ENS01035.TranDate.ValidateFieldValue(1, Date1Pg2);
            ENS01035.TranTypeCode.ValidateFieldValue(1, TranCode1Pg2);
            ENS01035.TranTypeDesc.ValidateFieldValue(1, TranDesc1Pg2);
            //ENS01035.Reference.ValidateFieldValue(0, Reference1Pg2);
            ENS01035.Source.ValidateFieldValue(1, Source1Pg2);
        }

        [Then(@"In ENS01034 I should see Static History for holder ""(.*)"" as below:")]
        public void ThenInENSIShouldSeeStaticHistoryForHolderAsbelow(string HIN, Table data)
        {
            string TranCode = data.GetData("Transaction Code");
            string TranDesc = data.GetData("Transaction Desc");
            string Reference = data.GetData("Reference");
            string Source = data.GetData("Source");

            ENS01001.Action.SetValue("SH");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01034");

            ENS01035.Action.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01035");

            ENS01035.TranTypeCode.ValidateFieldValue(9, TranCode);
            ENS01035.TranTypeDesc.ValidateFieldValue(9, TranDesc);
            ENS01035.Reference.ValidateFieldValue(9, Reference);
            ENS01035.Source.ValidateFieldValue(9, Source);
            //Spartan.Core.WinForms.WinFormsDriver.Close();
        }

        [Then(@"In ENSSTM34 I should see Static Transaction details as below ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenInENSSTMIShouldSeeStaticTransactionDetailsAsBelow(string Run, string Tran, string Date, string TranCode, string TranDesc, string Reference)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSTM34");
            ENSSTM34.RunNumber.ValidateFieldValue(Run);
            ENSSTM34.HldTransNumber.ValidateFieldValue(Tran);
            ENSSTM34.TranDate.ValidateFieldValue(Date);
            ENSSTM34.TranTypeCode.ValidateFieldValue(TranCode);
            ENSSTM34.TranTypeDesc.ValidateFieldValue(TranDesc);
            ENSSTM34.Reference.ValidateFieldValue(Reference);
        }

        [Then(@"In ENSTRDSH  I should see Trading History Summary of Charges as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenInENSTRDSHIShouldSeeTradingHistorySummaryOfChargesAs(string PaidbyHolder, string GSTTaxApply, string PaidbyCoy, string ReportOnly, string TotalCharges, string TotalGST)
        {
            ENSTRDSH.TotalCharges.ValidateFieldValue(PaidbyHolder);
            ENSTRDSH.GstTaxApply.ValidateFieldValue(GSTTaxApply);
            ENSTRDSH.TotalPaidBYCoy.ValidateFieldValue(PaidbyCoy);
            ENSTRDSH.TotalReportOnly.ValidateFieldValue(ReportOnly);
            ENSTRDSH.TotalCharges.ValidateFieldValue(TotalCharges);
            ENSTRDSH.GstTaxTotal.ValidateFieldValue(TotalGST);
        }

        [Then(@"In ENS02002 I should see Dual Currency amounts as below:")]
        public void TShouldSeeDualCurrencyAmmounts(Table data)
        {
            string DualDcPresented = data.GetData("DualDcPresented");
            string DualDcCancelled = data.GetData("DualDcCancelled");
            string TotalDualPresented = data.GetData("TotalDualPresented");
            string TotalDualCancelled = data.GetData("TotalDualCancelled");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS02002");
            ENS02002.DualDCPresented.ValidateFieldValue(DualDcPresented);
            ENS02002.DualDCCancelled.ValidateFieldValue(DualDcCancelled);
            ENS02002.TotalDualPresented.ValidateFieldValue(TotalDualPresented);
            ENS02002.TotalDualCancelled.ValidateFieldValue(TotalDualCancelled);
        }

        [Then(@"In ENSEIS01 I should see EIS Employee details as below:")]
        public void TShouldSeeEISEmployeeDetails(Table data)
        {
            string HIN = data.GetData("HIN");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Domicile = data.GetData("Domicile");
            string EmpFlag1 = data.GetData("Employee Flag 1");
            string EmpFlag2 = data.GetData("Employee Flag 2");
            string GSP = data.GetData("GSP Employee");
            string LeaverCode = data.GetData("Leaver Code");
            string LeaverCodeDesc = data.GetData("Leaver Code Desc");
            string LeaverPack = data.GetData("Leaver Pack");
            string LeaverPackDate = data.GetData("Leaver Pack sent Date");
            string AutoForfeiture = data.GetData("Auto Forfeiture");
            string BlackoutInd = data.GetData("Blackout");
            string BlackoutCode = data.GetData("Blackout Code");
            string PayrollID = data.GetData("Payroll ID");
            string EmployeeID = data.GetData("Employee ID");
            string SubPayrollID = data.GetData("Sub Payroll ID");
            string EmpUniqueID = data.GetData("Emp Unique ID");
            string NINumber = data.GetData("NI Number");
            string PrefName = data.GetData("Pref Name");
            string BirthDate = data.GetData("Birth Date");
            string EmpStatus = data.GetData("Emp Status");
            string EmpStatusDesc = data.GetData("Emp Status Desc");
            string EffectiveDate = data.GetData("Effective Date");
            string LocationCode = data.GetData("Location Code");
            string BusinessUnit = data.GetData("Business Unit");
            string JobBand = data.GetData("Job Band");
            string CostCentre = data.GetData("Cost Centre");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENSEIS01");
            ENSEIS01.HolderIdentifier.ValidateFieldValue(HIN);
            ENSEIS01.HnaLine.ValidateFieldValue(1, Name);
            ENSEIS01.HnaLine.ValidateFieldValue(2, Address1);
            ENSEIS01.HnaLine.ValidateFieldValue(3, Address2);
            ENSEIS01.Postcode.ValidateFieldValue(Domicile);
            ENSEIS01.EmployeeFlag1.ValidateFieldValue(EmpFlag1);
            ENSEIS01.EmployeeFlag2.ValidateFieldValue(EmpFlag2);
            ENSEIS01.GspEmployeeInd.ValidateFieldValue(GSP);
            ENSEIS01.LeaverCode.ValidateFieldValue(LeaverCode);
            ENSEIS01.LeaverCodeDesc.ValidateFieldValue(LeaverCodeDesc);
            ENSEIS01.LeaverPack.ValidateFieldValue(LeaverPack);
            ENSEIS01.LeaverPackSentDT.ValidateFieldValue(LeaverPackDate);
            ENSEIS01.AutoForfeitureInd.ValidateFieldValue(AutoForfeiture);
            ENSEIS01.BlkoutRstrctdInd.ValidateFieldValue(BlackoutInd);
            ENSEIS01.BlkoutRstrctdCode.ValidateFieldValue(BlackoutCode);
            ENSEIS01.PayrollID.ValidateFieldValue(PayrollID);
            ENSEIS01.EmployeeNumber.ValidateFieldValue(EmployeeID);
            ENSEIS01.SubPayrollID.ValidateFieldValue(SubPayrollID);
            ENSEIS01.EmployeeUniqueID.ValidateFieldValue(EmpUniqueID);
            ENSEIS01.NationalInsNbr.ValidateFieldValue(NINumber);
            ENSEIS01.PreferredName.ValidateFieldValue(PrefName);
            ENSEIS01.BirthDate.ValidateFieldValue(BirthDate);
            ENSEIS01.EmployeeStatus.ValidateFieldValue(EmpStatus);
            ENSEIS01.StatusDescription.ValidateFieldValue(EmpStatusDesc);
            ENSEIS01.EffectiveDate.ValidateFieldValue(EffectiveDate);
            ENSEIS01.LocationCode.ValidateFieldValue(LocationCode);
            ENSEIS01.BusinessUnit.ValidateFieldValue(BusinessUnit);
            ENSEIS01.JobBand.ValidateFieldValue(JobBand);
            ENSEIS01.CostCentre.ValidateFieldValue(CostCentre);
        }

        [Then(@"In ENS01039 I should see multiple holder details for supplied email as below:")]
        public void TShouldSeemultipleHolderDetailsForSuppliedEmail(Table data)
        {
            string EmailInput = data.GetData("EmailInput");
            string HIN1 = data.GetData("HIN1");
            string HIN2 = data.GetData("HIN2");
            string HIN3 = data.GetData("HIN3");
            string HIN4 = data.GetData("HIN4");
            string NameLine1 = data.GetData("NameLine1");
            string NameLine2 = data.GetData("NameLine2");
            string NameLine3 = data.GetData("NameLine3");
            string NameLine4 = data.GetData("NameLine4");
            string AddressLine1 = data.GetData("AddressLine1");
            string AddressLine2 = data.GetData("AddressLine2");
            string AddressLine3 = data.GetData("AddressLine3");
            string AddressLine4 = data.GetData("AddressLine4");
            string PostcodeLine1 = data.GetData("PostcodeLine1");
            string PostcodeLine2 = data.GetData("PostcodeLine2");
            string PostcodeLine3 = data.GetData("PostcodeLine3");
            string PostcodeLine4 = data.GetData("PostcodeLine4");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01039");
            ENS01039.EmailInput.ValidateFieldValue(EmailInput);
            ENS01039.HolderIdentifier.ValidateFieldValue(1, HIN1);
            ENS01039.HolderIdentifier.ValidateFieldValue(2, HIN2);
            ENS01039.HolderIdentifier.ValidateFieldValue(3, HIN3);
            ENS01039.HolderIdentifier.ValidateFieldValue(4, HIN4);
            ENS01039.HnaLine1.ValidateFieldValue(1, NameLine1);
            ENS01039.HnaLine1.ValidateFieldValue(2, NameLine2);
            ENS01039.HnaLine1.ValidateFieldValue(3, NameLine3);
            ENS01039.HnaLine1.ValidateFieldValue(4, NameLine4);
            ENS01039.HnaLine2.ValidateFieldValue(1, AddressLine1);
            ENS01039.HnaLine2.ValidateFieldValue(2, AddressLine2);
            ENS01039.HnaLine2.ValidateFieldValue(3, AddressLine3);
            ENS01039.HnaLine2.ValidateFieldValue(4, AddressLine4);
            ENS01039.Postcode.ValidateFieldValue(1, PostcodeLine1);
            ENS01039.Postcode.ValidateFieldValue(2, PostcodeLine2);
            ENS01039.Postcode.ValidateFieldValue(3, PostcodeLine3);
            ENS01039.Postcode.ValidateFieldValue(4, PostcodeLine4);
        }

        [When(@"I enter the following details as the locatActions ""(.*)""  ""(.*)""")]
        public void WhenIEnterTheFollowingDetailsAsTheLocatActions(string Action, string LocateArgument)
        {
            ENS01090.Action.SetValue(Action);
            ENS01090.LocateArgument.SetValue(LocateArgument);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In ENS01001 I continue with the following details:")]
        public void WhenInENS01001IContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.Action.SetValue(1, table.Rows[0]["Action"]);
            if (table.Rows[0]["LocateArgument"] != "")
            {
                ENS01001.LocateArgument.SetValue(1, table.Rows[0]["LocateArgument"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In ENS02000 I Enter action ""(.*)""")]
        public void WhenInENSIEnterAction(string Action)
        {
            String AccountNumber = "";
            ENS02000.Action.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            AccountNumber = ENS02000.PayAccountNumber.GetValue();
            if (AccountNumber == "07REF")
            {
                throw new Exception("07REF");
            }
            ENS02000.PayAccountNumber.ValidateFieldValue("07REF");
            ENS02000.Action.ClickField();
        }

        [When(@"I view trading history for ""(.*)"" in ""(.*)"" Plan")]
        public void WhenIViewTradingHistroyForInPlan(string HolderID, string plan)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("enquiry system");
            WinFormsTestSteps.ClickOnWithinTheEnquirySystemMenu("holder enquiry system");

            ENS01090.Action.SetValue("S");
            ENS01090.LocateArgument.SetValue(HolderID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ENS01001.Action.SetValue("TH");
            ENS01001.LocateArgument.SetValue(plan);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            ENSTRD48.Action.SetValue("01");

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"In ENSDIS01 I should see following details:")]
        public void ENSDIS01ShouldSeeFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSDIS01");
            ENSDIS01.PaymentDate.ValidateFieldValue(1, table.Rows[0]["PaymentDate"]);
            ENSDIS01.PaymentMethod.ValidateFieldValue(1, table.Rows[0]["PaymentMethod"]);
            ENSDIS01.RefNumberX.ValidateFieldValue(1, table.Rows[0]["RefNumberX"]);
            ENSDIS01.PaidAmount.ValidateFieldValue(1, table.Rows[0]["PaidAmount"]);
            ENSDIS01.PaidCurrency.ValidateFieldValue(1, table.Rows[0]["PaidCurrency"]);
            ENSDIS01.BaseCurrency.ValidateFieldValue(1, table.Rows[0]["BaseCurrency"]);
            ENSDIS01.Status.ValidateFieldValue(1, table.Rows[0]["Status"]);
            ENSDIS01.PresDate.ValidateFieldValue(1, table.Rows[0]["PresDate"]);
            ENSDIS01.PaymentAccount.ValidateFieldValue(1, table.Rows[0]["PaymentAccount"]);
            ENSDIS01.PaymentType.ValidateFieldValue(1, table.Rows[0]["PaymentType"]);

        }

        [Then(@"In ENSSTM02 I should see Static Transaction details:")]
        public void ENSSTM02ShouldSeeStaticTransactionDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSSTM02");
            ENSSTM02.AfterDetails.ValidateFieldValue(1, table.Rows[0]["AfterDetails1"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(2, table.Rows[0]["AfterDetails2"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(3, table.Rows[0]["AfterDetails3"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(4, table.Rows[0]["AfterDetails4"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(5, table.Rows[0]["AfterDetails5"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(6, table.Rows[0]["AfterDetails6"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(7, table.Rows[0]["AfterDetails7"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(8, table.Rows[0]["AfterDetails8"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(9, table.Rows[0]["AfterDetails9"]);
            ENSSTM02.AfterDetails.ValidateFieldValue(10, table.Rows[0]["AfterDetails10"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(1, table.Rows[0]["BeforeDetails1"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(2, table.Rows[0]["BeforeDetails2"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(3, table.Rows[0]["BeforeDetails3"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(4, table.Rows[0]["BeforeDetails4"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(5, table.Rows[0]["BeforeDetails5"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(6, table.Rows[0]["BeforeDetails6"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(7, table.Rows[0]["BeforeDetails7"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(8, table.Rows[0]["BeforeDetails8"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(9, table.Rows[0]["BeforeDetails9"]);
            ENSSTM02.BeforeDetails.ValidateFieldValue(10, table.Rows[0]["BeforeDetails10"]);

        }

        [Then(@"In ENS01007 I should see Holding details as:")]
        public void ENS01007ShouldSeeHoldingDetailsAs(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01007");
            ENS01007.Last6Lines.ValidateFieldValue(1, table.Rows[0]["Last6Lines1"]);
            ENS01007.Last6Lines.ValidateFieldValue(2, table.Rows[0]["Last6Lines2"]);
            ENS01007.Last6Lines.ValidateFieldValue(3, table.Rows[0]["Last6Lines3"]);
            ENS01007.Last6Lines.ValidateFieldValue(4, table.Rows[0]["Last6Lines4"]);
            ENS01007.Last6Lines.ValidateFieldValue(5, table.Rows[0]["Last6Lines5"]);
        }

        [Then(@"In ENS01052 I verify the merge details:")]
        public void ENS01052VerifyTheMergeDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01052");
            ENS01052.HolderTO.ValidateFieldValue(1, table.Rows[0]["HolderTO"]);

        }


        [Then(@"In ENS01001 form I verify the following")]
        public void ENS01001FormIVerifyTheFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.HolderTypeCode.ValidateFieldValue(1, table.Rows[0]["HolderTypeCode"]);
            ENS01001.HstAnnualReport.ValidateFieldValue(1, table.Rows[0]["HstAnnualReport"]);
            ENS01001.HnaLine.ValidateFieldValue(2, table.Rows[0]["HnaLine"]);
            ENS01001.Array1.ValidateFieldValue(1, table.Rows[0]["Array1"]);
        }


        [Then(@"In ENS01001 form I verify US Tax warning at position ""(.*)"" value ""(.*)""")]
        public void ThenInENS01001FormIVerifyUSTaxWarningAtPositionValue(int position, string message)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.Warnings.ValidateFieldValue(position, message);
         

        }


        [Then(@"In ENS01001 I enter action ""(.*)""")]
        public void InENS01001IEnterAction(string p1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.Action.SetValue(1, p1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA01");
        }
        

        [Then(@"In  ENTUSA01 I verify the following investor details")]
        public void  InENTUSA01IVerifyTheFollowingInvestorDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA01");
            ENTUSA01.InvName.ValidateFieldValue(1, table.Rows[0]["InvName1"]);
            ENTUSA01.InvType.ValidateFieldValue(1, table.Rows[0]["InvType1"]);
            ENTUSA01.InvTinStatus.ValidateFieldValue(1, table.Rows[0]["InvTinStatus1"]);
            ENTUSA01.InvW8Exp.ValidateFieldValue(1, table.Rows[0]["InvW8Exp1"]);
            ENTUSA01.InvChpt3.ValidateFieldValue(1, table.Rows[0]["InvChpt31"]);
            ENTUSA01.InvChpt4.ValidateFieldValue(1, table.Rows[0]["InvChpt41"]);

            ENTUSA01.InvName.ValidateFieldValue(2, table.Rows[0]["InvName2"]);
            ENTUSA01.InvType.ValidateFieldValue(2, table.Rows[0]["InvType2"]);
            ENTUSA01.InvTinStatus.ValidateFieldValue(2, table.Rows[0]["InvTinStatus2"]);
            ENTUSA01.InvW8Exp.ValidateFieldValue(2, table.Rows[0]["InvW8Exp2"]);
            ENTUSA01.InvChpt3.ValidateFieldValue(2, table.Rows[0]["InvChpt32"]);
            ENTUSA01.InvChpt4.ValidateFieldValue(2, table.Rows[0]["InvChpt42"]);

            ENTUSA01.InvName.ValidateFieldValue(3, table.Rows[0]["InvName3"]);
            ENTUSA01.InvType.ValidateFieldValue(3, table.Rows[0]["InvType3"]);
            ENTUSA01.InvTinStatus.ValidateFieldValue(3, table.Rows[0]["InvTinStatus3"]);
            ENTUSA01.InvW8Exp.ValidateFieldValue(3, table.Rows[0]["InvW8Exp3"]);
            ENTUSA01.InvChpt3.ValidateFieldValue(3, table.Rows[0]["InvChpt33"]);
            ENTUSA01.InvChpt4.ValidateFieldValue(3, table.Rows[0]["InvChpt43"]);

            ENTUSA01.InvName.ValidateFieldValue(4, table.Rows[0]["InvName4"]);
            ENTUSA01.InvType.ValidateFieldValue(4, table.Rows[0]["InvType4"]);
            ENTUSA01.InvTinStatus.ValidateFieldValue(4, table.Rows[0]["InvTinStatus4"]);
            ENTUSA01.InvW8Exp.ValidateFieldValue(4, table.Rows[0]["InvW8Exp4"]);
            ENTUSA01.InvChpt3.ValidateFieldValue(4, table.Rows[0]["InvChpt34"]);
            ENTUSA01.InvChpt4.ValidateFieldValue(4, table.Rows[0]["InvChpt44"]);

        }

        [Then(@"In  ENTUSA01 I enter action ""(.*)""")]
        public void InENTUSA01IEnterAction(string p1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA01");
            ENTUSA01.Action.SetValue(1, p1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA03");
        }
        

        [Then(@"In ENTUSA03 I verify the following")]
        public void InENTUSA03IVerifyTheFollowing( Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA03");
            ENTUSA03.JntAccountType.ValidateFieldValue(1, table.Rows[0]["JntAccountTyp"]);
            ENTUSA03.InvName.ValidateFieldValue(1, table.Rows[0]["InvName"]);
            ENTUSA03.InvTinStatus.ValidateFieldValue(1, table.Rows[0]["InvTinStatus"]);
            ENTUSA03.InvTin.ValidateFieldValue(1, table.Rows[0]["InvTin"]);
            ENTUSA03.InvUSTaxCode.ValidateFieldValue(1, table.Rows[0]["InvUSTaxCode"]);
            ENTUSA03.InvChpt3.ValidateFieldValue(1, table.Rows[0]["InvChpt3"]);
            ENTUSA03.InvChpt4.ValidateFieldValue(1, table.Rows[0]["InvChpt4"]);
            ENTUSA03.InvBirthDate.ValidateFieldValue(1, table.Rows[0]["InvBirthDate"]);
            ENTUSA03.InvCountry.ValidateFieldValue(1, table.Rows[0]["InvCountry"]);
            ENTUSA03.InvTaxID.ValidateFieldValue(1, table.Rows[0]["InvTaxID"]);

            ENTUSA03.InvAddress1.ValidateFieldValue(1, table.Rows[0]["InvAddress1"]);
            ENTUSA03.InvAddress2.ValidateFieldValue(1, table.Rows[0]["InvAddress2"]);
            ENTUSA03.InvGiinP1.ValidateFieldValue(1, table.Rows[0]["InvGiinP1"]);
            ENTUSA03.InvGiinP2.ValidateFieldValue(1, table.Rows[0]["InvGiinP2"]);
            ENTUSA03.InvGiinP3.ValidateFieldValue(1, table.Rows[0]["InvGiinP3"]);
            ENTUSA03.InvGiinP4.ValidateFieldValue(1, table.Rows[0]["InvGiinP4"]);
            ENTUSA03.InvGiinException.ValidateFieldValue(1, table.Rows[0]["InvGiinException"]);

         }


        [Then(@"IN ENTUSA03 I press ESC")]
        public void INENTUSA03IPressESC()
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA03");
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA01");

        }

 
        [Then(@"In ENTUSA03 I enter ""(.*)""")]
        public void InENTUSA03IEnter(  string p1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA03");
            ENTUSA03.Action.SetValue(1, p1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [Then(@"I press ESC")]
        public void ThenIPressESC()
        {
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
        }

        
        [Then(@"In ENTUSA04 I enter ""(.*)""")]
        public void InENTUSA04IEnter(string p1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA04");
            ENTUSA04.Action.SetValue(1, p1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }


        [Then(@"In ENTUSA05 I verify the following")]
        public void InENTUSA05IVerifyTheFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENTUSA05");
            ENTUSA05.CntName.ValidateFieldValue(1, table.Rows[0]["CntName"]);
            ENTUSA05.CntAddressLine.ValidateFieldValue(1, table.Rows[0]["CntAddressLine1"]);
            ENTUSA05.CntAddressLine.ValidateFieldValue(2, table.Rows[0]["CntAddressLine2"]);
            ENTUSA05.CntAddressLine.ValidateFieldValue(3, table.Rows[0]["CntAddressLine3"]);
            ENTUSA05.CntAddressLine.ValidateFieldValue(4, table.Rows[0]["CntAddressLine4"]);
            ENTUSA05.CntPostcode.ValidateFieldValue(1, table.Rows[0]["CntPostcode"]);
            ENTUSA05.CntCitizenship.ValidateFieldValue(1, table.Rows[0]["CntCitizenship"]);
            ENTUSA05.CntTaxIdentifier.ValidateFieldValue(1, table.Rows[0]["CntTaxIdentifier"]);
            ENTUSA05.CntTin.ValidateFieldValue(1, table.Rows[0]["CntTin"]);
            ENTUSA05.CntDobIncorp.ValidateFieldValue(1, table.Rows[0]["CntDobIncorp"]);
            ENTUSA05.CntTinStatus.ValidateFieldValue(1, table.Rows[0]["CntTinStatus"]);
            ENTUSA05.CntChpt3.ValidateFieldValue(1, table.Rows[0]["CntChpt3"]);
            ENTUSA05.CntChpt4.ValidateFieldValue(1, table.Rows[0]["CntChpt4"]);
            ENTUSA05.CntUSTaxCode.ValidateFieldValue(1, table.Rows[0]["CntUSTaxCode"]);
            ENTUSA05.CntW8ExpDate.ValidateFieldValue(1, table.Rows[0]["CntW8ExpDate"]);


            ENTUSA05.CntGiinP1.ValidateFieldValue(1, table.Rows[0]["CntGiinP1"]);
            ENTUSA05.CntGiinP2.ValidateFieldValue(1, table.Rows[0]["CntGiinP2"]);
            ENTUSA05.CntGiinP3.ValidateFieldValue(1, table.Rows[0]["CntGiinP3"]);
            ENTUSA05.CntGiinP4.ValidateFieldValue(1, table.Rows[0]["CntGiinP4"]);
            ENTUSA05.CntGiinException.ValidateFieldValue(1, table.Rows[0]["CntGiinException"]);
 
         }




    }
}