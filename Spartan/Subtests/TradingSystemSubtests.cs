using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Renci.SshNet;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;


namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class TradingSystemSubtests
    {
        private static string SaleType;
        private static string JobNumber;
        private static string Class;
        private static string TradingID;
        private static string TransNumber;
        public static string TradeID;
        


        public TradingSystemSubtests()
        {
            this._WinFormsTestSteps = new WinFormsTestSteps();
            this.ReportingTestSteps = new ReportingTestSteps();
        }

        public WinFormsTestSteps _WinFormsTestSteps { get; set; }
        public ReportingTestSteps ReportingTestSteps { get; set; }
        /*
        [BeforeFeature("Trading")]
        public void IRestoreCompany()
        {
            _WinFormsTestSteps.GivenIHaveConnectedToVMSAndRestoreCompany();
        }
         */

        [BeforeScenario("TCC_MultiCert_Y")]
        public void MultiCert_TCC_Setups()
        {
            _WinFormsTestSteps.IGoToControlCodeMenu("Company Options");

        }



        [Given(@"I am on the System Menu")]
        public void GivenIAmOnTheSystemMenu()
        {
            _WinFormsTestSteps.ExpectToBeInTheScreen("MNS00101");
        }



        [When(@"In TRDMNU01 I click on: ""(.*)"" within the Trading System Menu")]
        public void ClickOnWithinTheTradingSystemMenu(string menuOption)
        {
            //_WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU01");
            switch (menuOption.ToLower())
            {
                case "sales":
                    TRDMNU01.MenuItemSal.ClickField();
                    break;

                case "purchases":
                    TRDMNU01.MenuItemPur.ClickField();
                    break;

                case "transfers":
                    TRDMNU01.MenuItemTrf.ClickField();
                    break;

                case "session totals":
                    TRDMNU01.MenuItemST.ClickField();
                    break;

                case "exit trading system":
                    TRDMNU01.MenuItemEX.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In TRDMNU02 I enter ""(.*)"" in the Trade Control Code Selection")]
        public void EnterInTheTradeControlCodeSelection(string tradeControlCode)
        {
            TRDMNU02.Selection.SetValue(tradeControlCode);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRDMNU03 I click on: ""(.*)"" within the Trading System Options Menu")]
        public void ClickOnWithinTheTradingSystemOptionsMenu(string menuOption)
        {
            //_WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
            switch (menuOption.ToLower())
            {
                case "create new order":
                    TRDMNU03.MenuItemNO.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "postal transaction entry":
                    TRDMNU03.MenuItemPT.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "change order status":
                    TRDMNU03.MenuItemCO.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "generate output":
                    TRDMNU03.MenuItemGO.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    //TRDMNU03.OrderNumber.SetValue("TEST");
                    //TRDMNU03.OperatorInitials.SetValue("NFD");
                    //Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "force bulk settlement":
                    TRDMNU03.MenuItemFS.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "transaction enquiry":
                    TRDMNU03.MenuItemTE.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "settle order":
                    TRDMNU03.MenuItemSO.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "apply exercise transaction":
                    TRDMNU03.MenuItemAX.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                case "order enquiry":
                    TRDMNU03.MenuItemOE.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    break;

                default:
                    break;
            }
        }

        [Then(@"In TRD00201 I expect WinForms to show Trade Code as: ""(.*)"" within the Create New Trade Form")]
        public void ExpectWinFormsToShowTradeCodeAsWithinTheCreateNewTradeForm(string tradeCode)
        {
            if (tradeCode.Trim() != TRD00201.TradingCode.GetValue())
            {
                Console.WriteLine("Expected and actual values do not match. Trade Code:" + tradeCode);
            }
        }

        [When(@"In TRDMNU03 I go to Postal Transaction Entry screen")]
        public void GoToPostalTransactionEntryScreen()
        {
            ClickOnWithinTheTradingSystemOptionsMenu("Postal Transaction Entry");
            //EnterUniqueTradeIdWithinTheTradingIdSearch();
        }

        [When(@"I go to the Trading system Sales and trade control code ""(.*)""")]
        public void GoToTheTradingSystemSalesAndTradeControlCode(string tradeControlCode)
        {
            _WinFormsTestSteps.ClickWithinTheSystemMenu("Trading System");
            ClickOnWithinTheTradingSystemMenu("Sales");
            EnterInTheTradeControlCodeSelection(tradeControlCode);
        }

        [When(@"I go to the Trading system Transfers and trade control code ""(.*)""")]
        public void WhenIGoToTheTradingSystemTransfersAndTradeControlCode(string tradeControlCode)
        {
            _WinFormsTestSteps.ClickWithinTheSystemMenu("Trading System");
            ClickOnWithinTheTradingSystemMenu("Transfers");
            EnterInTheTradeControlCodeSelection(tradeControlCode);
        }


        [When(@"In TRD24000 I Add Trade Control Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24000AddTradeControlDetails(string TradingCode, string TradeType, string TradeDescription, string CurrentFlag, string ClassCode, string InvTradeInd, string EventBulkInd, string SettlementAction, string SettlementPeriod, string SettlementRegime, string MinimumDeal, string MaximumDeal, string RecordMoneyORUnits, string CutOffHH, string CutOffMM, string CalcReqInd, string ContactDetails)
        {
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24000");
            TRD24000.Action.SetValue("A");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            TRD24000.TradingCode.SetValue(TradingCode);
            TRD24000.TradeType.SetValue(TradeType);
            TRD24000.TradeDescription.SetValue(TradeDescription);
            TRD24000.CurrentFlag.SetValue(CurrentFlag);
            TRD24000.ClassCode.SetValue(ClassCode);

            if (TradeType == "S")
            {
                TRD24000.TradeType.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRD24000.InvTradeInd.SetValue(InvTradeInd);
            }

            TRD24000.EventBulkInd.SetValue(EventBulkInd);
            TRD24000.SettlementAction.SetValue(SettlementAction);
            TRD24000.SettlementPeriod.SetValue(SettlementPeriod);
            TRD24000.SettlementRegime.SetValue(SettlementRegime);
            TRD24000.MinimumDeal.SetValue(MinimumDeal);
            TRD24000.MaximumDeal.SetValue(MaximumDeal);
            TRD24000.RecordMoneyORUnits.SetValue(RecordMoneyORUnits);
            TRD24000.CutOffHH.SetValue(CutOffHH);
            TRD24000.CutOffMM.SetValue(CutOffMM);
            TRD24000.CutOffMM.SetValue(CutOffMM);
            TRD24000.CalcReqInd.SetValue(CalcReqInd);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRD24006 I Add Trade Control Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24006AddTradeControlDetails(string CounterpartyReqd, string CounterpartyClass, string CounterpartyRegister, string CounterTrantypeCode, string CounterHolderID, string ONMarketTradeInd, string DPBrokerCode, string DPTradeAccount, string DPConnectionTO, string RealTimeTrading, string DPOrderType)
        {
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24006");
            TRD24006.CounterpartyReqd.SetValue(CounterpartyReqd);

            if (CounterpartyReqd == "Y")
            {
                TRD24006.CounterpartyReqd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRD24006.CounterpartyClass.SetValue(CounterpartyClass);
                TRD24006.CounterpartyRegister.SetValue(CounterpartyRegister);
                TRD24006.CounterTrantypeCode.SetValue(CounterTrantypeCode);
                TRD24006.CounterHolderID.SetValue(CounterHolderID);
            }

            TRD24006.ONMarketTradeInd.SetValue(ONMarketTradeInd);

            if (ONMarketTradeInd == "M" || ONMarketTradeInd == "O")
            {
                TRD24006.ONMarketTradeInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRD24006.DPBrokerCode.SetValue(DPBrokerCode);
                TRD24006.DPTradeAccount.SetValue(DPTradeAccount);
                TRD24006.DPConnectionTO.SetValue(DPConnectionTO);
            }

            TRD24006.RealTimeTrading.SetValue(RealTimeTrading);
            TRD24006.DPOrderType.SetValue(DPOrderType);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24002");
            TRD24006.CounterHolderID.ValidateFieldValue(CounterHolderID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24003");
        }

        [When(@"In TRD24003 I Add Trade Control Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24003AddTradeControlDetails(string DispExecVenueInd, string GenerateAdvices, string GenerateCertificates, string OnlineEntryInd, string ExternalExercise, string WebInterfaceInd, string AuditInd, string AuditSettlingTrans, string AllowCorporateBodies, string AllowPurchaseResidue, string AllowReturnMail, string AllowDeceased, string AllowPartialSell, string AllowSellTOCover, string Trd24003TaxResidualInd, string AllowCertPartSell, string AllowSellSelected, string AllowFullSell, string AllowForeignResident)
        {
            TRD24003.DispExecVenueInd.SetValue(DispExecVenueInd);
            TRD24003.GenerateAdvices.SetValue(GenerateAdvices);
            TRD24003.GenerateCertificates.SetValue(GenerateCertificates);
            if (TRD24003.OnlineEntryInd.Exists() ==true)
                TRD24003.OnlineEntryInd.SetValue(OnlineEntryInd);
            if (TRD24003.ExternalExercise.Exists() == true)
                TRD24003.ExternalExercise.SetValue(ExternalExercise);
            TRD24003.WebInterfaceInd.SetValue(WebInterfaceInd);
            TRD24003.AuditInd.SetValue(AuditInd);
            TRD24003.AuditSettlingTrans.SetValue(AuditSettlingTrans);
            TRD24003.AllowCorporateBodies.SetValue(AllowCorporateBodies);
            TRD24003.AllowReturnMail.SetValue(AllowReturnMail);
            TRD24003.AllowDeceased.SetValue(AllowDeceased);
            TRD24003.AllowPartialSell.SetValue(AllowPartialSell);

            string Type = TRD24003.TradeType.GetValue();
            if (Type == "S")
            {
                TRD24003.AllowSellTOCover.SetValue(AllowSellTOCover);
                TRD24003.AllowPurchaseResidue.SetValue(AllowPurchaseResidue);
                if (AllowSellTOCover == "Y")
                {
                    TRD24003.AllowSellTOCover.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    TRD24003.Trd24003TaxResidualInd.SetValue(Trd24003TaxResidualInd);
                }
            }

            TRD24003.AllowCertPartSell.SetValue(AllowCertPartSell);

            if (TRD24003.AllowSellSelected.Exists())
            {
                TRD24003.AllowSellSelected.SetValue(AllowSellSelected);
            }

            TRD24003.AllowFullSell.SetValue(AllowFullSell);
            TRD24003.AllowForeignResident.SetValue(AllowForeignResident);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            if (AllowSellTOCover == "Y")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRD240RB");
            }
            else
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24004");
            }
        }

        [When(@"In TRD240RB I Add Trade Control Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD240RBAddTradeControlDetails(string AllowSellTOCover, string RemainingBalOption1, string RemainingBalTran1, string RemainingBalClass1, string RemainingBalReg1, string RemainingBalOption2, string RemainingBalTran2, string RemainingBalClass2, string RemainingBalReg2)
        {
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (FormName == "TRD240RB")
            {
                TRD240RB.SellTOCover.ValidateFieldValue(AllowSellTOCover);
                TRD240RB.RemainingBalOption.SetValue(1, RemainingBalOption1);
                TRD240RB.RemainingBalTran.SetValue(1, RemainingBalTran1);
                TRD240RB.RemainingBalClass.SetValue(1, RemainingBalClass1);
                TRD240RB.RemainingBalReg.SetValue(1, RemainingBalReg1);
                TRD240RB.RemainingBalOption.SetValue(2, RemainingBalOption2);
                TRD240RB.RemainingBalTran.SetValue(2, RemainingBalTran2);
                TRD240RB.RemainingBalClass.SetValue(2, RemainingBalClass2);
                TRD240RB.RemainingBalReg.SetValue(2, RemainingBalReg2);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24004");
            }
        }

        [When(@"In TRD24004 I Add Trade Control Details1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24004AddTradeControlDetails1(string GrossRounding, string ReconciliationCode, string CashManagementReqd, string PayAccountNumber, string ValidPayMethod1, string ValidPayMethod2, string ValidPayMethod3, string ExistPayDirCred, string PermPayDirCred, string TempPayDirCred, string ValidPayMethod4, string ExistPayWire, string PermPayWire, string TempPayWire, string ValidPayMethod5, string RemitTaxPayrollInd, string RemitEmpPayrollInd, string WorldlinkNumber, string PayrollDependentInd)
        {
            TRD24004.GrossRounding.SetValue(GrossRounding);
            TRD24004.ReconciliationCode.SetValue(ReconciliationCode);
            TRD24004.CashManagementReqd.SetValue(CashManagementReqd);
            TRD24004.PayAccountNumber.SetValue(PayAccountNumber);
            TRD24004.ValidPayMethod1.SetValue(ValidPayMethod1);
            TRD24004.ValidPayMethod2.SetValue(ValidPayMethod2);
            TRD24004.ValidPayMethod3.SetValue(ValidPayMethod3);

            if (ValidPayMethod3 == "Y")
            {
                TRD24004.ValidPayMethod3.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRD24004.ExistPayDirCred.SetValue(ExistPayDirCred);
                TRD24004.PermPayDirCred.SetValue(PermPayDirCred);
                TRD24004.TempPayDirCred.SetValue(TempPayDirCred);
            }

            TRD24004.ValidPayMethod4.SetValue(ValidPayMethod4);

            if (ValidPayMethod4 == "Y")
            {
                TRD24004.ValidPayMethod4.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRD24004.ExistPayWire.SetValue(ExistPayWire);
                TRD24004.PermPayWire.SetValue(PermPayWire);
                TRD24004.TempPayWire.SetValue(TempPayWire);
            }

            TRD24004.ValidPayMethod5.SetValue(ValidPayMethod5);

            if (ValidPayMethod5 == "Y")
            {
                TRD24004.ValidPayMethod5.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRD24004.RemitEmpPayrollInd.SetValue(RemitEmpPayrollInd);
                TRD24004.PayrollDependentInd.SetValue(PayrollDependentInd);
            }

            TRD24004.RemitTaxPayrollInd.SetValue(RemitTaxPayrollInd);
            TRD24004.WorldlinkNumber.SetValue(WorldlinkNumber);
        }

        [When(@"In TRD24004 I Add Trade Control Details2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24004AddTradeControlDetails2(string DefaultPaymentMethd, string DefaultPayCurrency, string PaymentCurrency1, string PaymentCurrency2, string PaymentCurrency3, string GenerateTrdtpeInd, string GenerateFlatFile, string BuildPaymentsInd, string LoanPayAccount, string LoanRegBreakupReqd)
        {
            String ClassCode = TRD24004.ClassCode.GetValue();
            if (ClassCode == "ELA")
            {
                TRD24004.LoanPayAccount.SetValue(LoanPayAccount);
                TRD24004.LoanRegBreakupReqd.SetValue(LoanRegBreakupReqd);
            }

            TRD24004.DefaultPaymentMethd.SetValue(DefaultPaymentMethd);
            TRD24004.DefaultPayCurrency.SetValue(DefaultPayCurrency);
            TRD24004.PaymentCurrency.SetValue(1, PaymentCurrency1);
            TRD24004.PaymentCurrency.SetValue(2, PaymentCurrency2);
            TRD24004.PaymentCurrency.SetValue(3, PaymentCurrency3);
            TRD24004.GenerateTrdtpeInd.SetValue(GenerateTrdtpeInd);
            TRD24004.GenerateFlatFile.SetValue(GenerateFlatFile);
            TRD24004.BuildPaymentsInd.SetValue(BuildPaymentsInd);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24009");
        }

        [When(@"In TRD24004 I Add Transfer Trade Control Details as ""(.*)"" ""(.*)""")]
        public void TRD24004AddTransferTradeControlDetails(string GrossRounding, string DefaultPayCurrency)
        {
            TRD24004.GrossRounding.SetValue(GrossRounding);
            TRD24004.DefaultPayCurrency.SetValue(DefaultPayCurrency);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24009");
        }

        [When(@"In TRD24009 I Add Trade Control Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24009AddTradeControlDetails(string SmsInd1, string SmsInd2, string SmsInd3, string SmsInd4, string EmailInd1, string EmailInd2, string EmailInd3, string EmailInd4, string EmailCompanySpec1, string EmailCompanySpec2, string EmailCompanySpec3, string EmailCompanySpec4)
        {
            TRD24009.SmsInd1.SetValue(SmsInd1);
            TRD24009.SmsInd2.SetValue(SmsInd2);
            TRD24009.SmsInd3.SetValue(SmsInd3);
            TRD24009.SmsInd4.SetValue(SmsInd4);
            TRD24009.EmailInd1.SetValue(EmailInd1);
            TRD24009.EmailInd2.SetValue(EmailInd2);
            TRD24009.EmailInd3.SetValue(EmailInd3);
            TRD24009.EmailInd4.SetValue(EmailInd4);
            TRD24009.EmailCompanySpec1.SetValue(EmailCompanySpec1);
            TRD24009.EmailCompanySpec2.SetValue(EmailCompanySpec2);
            TRD24009.EmailCompanySpec3.SetValue(EmailCompanySpec3);
            TRD24009.EmailCompanySpec4.SetValue(EmailCompanySpec4);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24007");
        }

        [When(@"In TRD24009 I Verify Trade Control Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24009VerifyTradeControlDetails(string SmsInd1, string SmsInd2, string SmsInd3, string SmsInd4, string EmailInd1, string EmailInd2, string EmailInd3, string EmailInd4, string EmailCompanySpec1, string EmailCompanySpec2, string EmailCompanySpec3, string EmailCompanySpec4)
        {
            TRD24009.SmsInd1.ValidateFieldValue(SmsInd1);
            TRD24009.SmsInd2.ValidateFieldValue(SmsInd2);
            TRD24009.SmsInd3.ValidateFieldValue(SmsInd3);
            TRD24009.SmsInd4.ValidateFieldValue(SmsInd4);
            TRD24009.EmailInd1.ValidateFieldValue(EmailInd1);
            TRD24009.EmailInd2.ValidateFieldValue(EmailInd2);
            TRD24009.EmailInd3.ValidateFieldValue(EmailInd3);
            TRD24009.EmailInd4.ValidateFieldValue(EmailInd4);
            TRD24009.EmailCompanySpec1.ValidateFieldValue(EmailCompanySpec1);
            TRD24009.EmailCompanySpec2.ValidateFieldValue(EmailCompanySpec2);
            TRD24009.EmailCompanySpec3.ValidateFieldValue(EmailCompanySpec3);
            TRD24009.EmailCompanySpec4.ValidateFieldValue(EmailCompanySpec4);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD24007");
        }

        [When(@"In TRD24007 I Add Trade Control Details1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24007AddTradeControlDetails1(string ChargeDesc9, string ChargeCode9, string ChargePaidBY9, string ChargeWaived9, string ChargeDesc10, string ChargeCode10, string ChargePaidBY10, string ChargeWaived10, string ChargeDesc11, string ChargeCode11, string ChargePaidBY11, string ChargeWaived11, string ChargeDesc12, string ChargeCode12, string ChargePaidBY12, string ChargeWaived12, string ChargeDesc1, string ChargeDesc2)
        {
            TRD24007.ChargeDesc9.ValidateFieldValue(ChargeDesc9);
            TRD24007.ChargeDesc10.ValidateFieldValue(ChargeDesc10);
            TRD24007.ChargeDesc11.ValidateFieldValue(ChargeDesc11);
            TRD24007.ChargeDesc12.ValidateFieldValue(ChargeDesc12);
            TRD24007.ChargeDesc1.ValidateFieldValue(ChargeDesc1);
            TRD24007.ChargeDesc2.ValidateFieldValue(ChargeDesc2);

            TRD24007.ChargeCode9.SetValue(ChargeCode9);
            TRD24007.ChargeCode10.SetValue(ChargeCode10);
            TRD24007.ChargeCode11.SetValue(ChargeCode11);
            TRD24007.ChargeCode12.SetValue(ChargeCode12);
            TRD24007.ChargePaidBY9.SetValue(ChargePaidBY9);
            TRD24007.ChargePaidBY10.SetValue(ChargePaidBY10);
            TRD24007.ChargePaidBY11.SetValue(ChargePaidBY11);
            TRD24007.ChargePaidBY12.SetValue(ChargePaidBY12);
            TRD24007.ChargeWaived9.SetValue(ChargeWaived9);
            TRD24007.ChargeWaived10.SetValue(ChargeWaived10);
            TRD24007.ChargeWaived11.SetValue(ChargeWaived11);
            TRD24007.ChargeWaived12.SetValue(ChargeWaived12);
        }

        [When(@"In TRD24007 I Add Trade Control Details2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD24007AddTradeControlDetails2(string ChargeCode1, string ChargePaidBY1, string ChargeWaived1, string ChargeCode2, string ChargePaidBY2, string ChargeWaived2, string ChargeCode3, string ChargePaidBY3, string ChargeWaived3, string ChargeCode4, string ChargePaidBY4, string ChargeWaived4, string ChargeCode5, string ChargePaidBY5, string ChargeWaived5, string ChargeDesc3, string ChargeDesc4, string ChargeDesc5)
        {
            TRD24007.ChargeCode1.SetValue(ChargeCode1);
            TRD24007.ChargePaidBY1.SetValue(ChargePaidBY1);
            TRD24007.ChargeWaived1.SetValue(ChargeWaived1);
            TRD24007.ChargeCode2.SetValue(ChargeCode2);
            TRD24007.ChargePaidBY2.SetValue(ChargePaidBY2);
            TRD24007.ChargeWaived2.SetValue(ChargeWaived2);
            TRD24007.ChargeCode3.SetValue(ChargeCode3);
            TRD24007.ChargePaidBY3.SetValue(ChargePaidBY3);
            TRD24007.ChargeWaived3.SetValue(ChargeWaived3);
            TRD24007.ChargeCode4.SetValue(ChargeCode4);
            TRD24007.ChargePaidBY4.SetValue(ChargePaidBY4);
            TRD24007.ChargeWaived4.SetValue(ChargeWaived4);
            TRD24007.ChargeCode5.SetValue(ChargeCode5);
            TRD24007.ChargePaidBY5.SetValue(ChargePaidBY5);
            TRD24007.ChargeWaived5.SetValue(ChargeWaived5);

            TRD24007.ChargeDesc3.ValidateFieldValue(ChargeDesc3);
            TRD24007.ChargeDesc4.ValidateFieldValue(ChargeDesc4);
            TRD24007.ChargeDesc5.ValidateFieldValue(ChargeDesc5);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("BILCTL99");
        }

        [When(@"In TRD24007 I Add Transfer Trade Control Details as ""(.*)"" ""(.*)""")]
        public void TRD24007AddTransferTradeControlDetails(string ChargeDesc5, string ChargeCode5)
        {
            TRD24007.ChargeCode5.SetValue(ChargeCode5);
            TRD24007.ChargeDesc5.ValidateFieldValue(ChargeDesc5);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("BILCTL99");
        }

        [When(@"In TRS00501 I Add Postal Transaction Entry details as ""(.*)""")]
        public void TRS00501AddPostalTransactionEntryDetails(string SearchName)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("postal transaction entry");
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (formName == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00501");
            TRS00501.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00502");
        }

        [When(@"In TRDMNU03 I select Postal Transaction Entry")]
        public void TRDMNU03IselectPostalTransactionEntry()
        {
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
            ClickOnWithinTheTradingSystemOptionsMenu("postal transaction entry");
        }

        [When(@"In TRDSCH01 I select the first Trading ID")]
        public void TRDSCH01IselectthefirstTradingID()
        {
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDSCH01");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"I transmit to TRS00701 to enter Postal Transaction Entry Details as ""(.*)"" ""(.*)""")]
        [When(@"In TRS00701 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)""")]
        public void TRS00701AddPostalTransactionEntryDetails(string TransNumber1, string SearchName)
        {
            TRDMNU03IselectPostalTransactionEntry();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "TRDSCH01")
            {
                TRDSCH01IselectthefirstTradingID();
            }
            else
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(10);
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00701");
            if (TransNumber1 == "")
            {
                TRS00701.SearchName.SetValue(SearchName);
            }
            else
            {
                TRS00701.TransNumber.SetValue(TransNumber1);
                TRS00701.SearchName.SetValue(SearchName);
            }
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRS00502 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00502AddPostalTransactionEntryDetails(string SellOption, string Units, string PaymentMethod, string PrefCurrency, string NotificationReqdInd, string Balance, string AvailBalance)
        {
            Class = TRS00502.ClassCode.GetValue();
            TRS00502.SellOption.SetValue(SellOption);
            if (SellOption == "P")
            {
                TRS00502.SellOption.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRS00502.Units.SetValue(Units);
            }
            TRS00502.PaymentMethod.SetValue(PaymentMethod);
            TRS00502.PrefCurrency.SetValue(PrefCurrency);
            TRS00502.NotificationReqdInd.SetValue(NotificationReqdInd);

            TRS00502.Balance.ValidateFieldValue(Balance);
            TRS00502.AvailBalance.ValidateFieldValue(AvailBalance);
            SaleType = TRS00502.SellOption.GetValue();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            if (PaymentMethod == "D")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00511");
            }
            else if (PaymentMethod == "W")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00511");
            }
            else if (SaleType == "S")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00507");
            }
            else
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00511");
            }
        }

        [When(@"In TRS00702 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00702AddPostalTransactionEntryDetails(string SellOption, string RemainingBalInd, string PaymentMethod, string PrefCurrency, string NotificationReqdInd, string Balance, string AvailBalance)
        {
            if (TRS00702.SellOption.Exists() == true)
            {
                TRS00702.SellOption.SetValue(SellOption);
                if (SellOption == "P" || SellOption == "C")
                {
                    TRS00702.RemainingBalInd.SetValue(RemainingBalInd);

                }

                TRS00702.PaymentMethod.SetValue(PaymentMethod);
                if (PaymentMethod == "C")
                {
                    TRS00702.PaymentMethod.ClickField();
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    TRS00702.PrefCurrency.SetValue(PrefCurrency);
                }

                TRS00702.NotificationReqdInd.SetValue(NotificationReqdInd);

                TRS00702.Balance.ValidateFieldValue(Balance);
                TRS00702.AvailBalance.ValidateFieldValue(AvailBalance);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();


                if (PaymentMethod == "D")
                {
                    _WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();


                }
                else if (PaymentMethod == "W")
                {
                    _WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

                }
            }
            else if (TRS00702.TransferOption.Exists() == true)
            {
                TRS00702.TransferOption.SetValue(SellOption);
                TRS00702.RemainingBalInd.SetValue(RemainingBalInd);
                if (TRS00702.PaymentMethod.Exists() == true)
                {
                    TRS00702.PaymentMethod.SetValue(PaymentMethod);
                }
                if (TRS00702.PrefCurrency.Exists() == true)
                {
                    TRS00702.PrefCurrency.SetValue(PrefCurrency);
                }
                TRS00702.NotificationReqdInd.SetValue(NotificationReqdInd);
                TRS00702.Balance.ValidateFieldValue(Balance);
                TRS00702.AvailBalance.ValidateFieldValue(AvailBalance);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00707");
        }



        [When(@"In TRS00707 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInTRSIAddPostalTransactionEntryDetailsAs(string SellAll01, string ExerciseUnits01, string Units01, string SellAll02, string ExerciseUnits02, string Units02, string SellAll03, string ExerciseUnits03, string Units03, string SellAll04, string ExerciseUnits04, string Units04)
        {
            if (TRS00707.SellAll01.Exists() == true)
            {
                if (SellAll01 != "")
                {
                    TRS00707.SellAll01.SetValue(SellAll01);
                }

            }
            if (TRS00707.Exercise01.Exists() == true)
            {
                if (ExerciseUnits01 != "")
                {
                    TRS00707.Exercise01.SetValue(ExerciseUnits01);
                }
            }
            if (TRS00707.Units01.Exists() == true)
            {
                if (Units01 != "")
                {
                    TRS00707.Units01.SetValue(Units01);
                }

            }
            if (TRS00707.SellAll02.Exists() == true)
            {
                if (SellAll02 != "")
                {
                    TRS00707.SellAll02.SetValue(SellAll02);
                }

            }
            if (TRS00707.Exercise02.Exists() == true)
            {
                if (ExerciseUnits02 != "")
                {
                    TRS00707.Exercise02.SetValue(ExerciseUnits02);
                }
            }
            if (TRS00707.Units02.Exists() == true)
            {
                if (Units02 != "")
                {
                    TRS00707.Units02.SetValue(Units02);
                }
            }
            if (TRS00707.SellAll03.Exists() == true)
            {
                if (SellAll03 != "")
                {
                    TRS00707.SellAll03.SetValue(SellAll03);
                }
            }
            if (TRS00707.Exercise03.Exists() == true)
            {
                if (ExerciseUnits03 != "")
                {
                    TRS00707.Exercise03.SetValue(ExerciseUnits03);
                }
            }
            if (TRS00707.Units03.Exists() == true)
            {
                if (Units03 != "")
                {
                    TRS00707.Units03.SetValue(Units03);
                }
            }
            if (TRS00707.SellAll04.Exists() == true)
            {
                if (SellAll04 != "")
                {
                    TRS00707.SellAll04.SetValue(SellAll04);
                }
            }
            if (TRS00707.Exercise04.Exists() == true)
            {
                if (ExerciseUnits04 != "")
                {
                    TRS00707.Exercise04.SetValue(ExerciseUnits04);
                }
            }
            if (TRS00707.Units04.Exists() == true)
            {
                if (Units04 != "")
                {
                    TRS00707.Units04.SetValue(Units04);
                }
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();


        }


        [When(@"In TRS00702 I Add Batch Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00702AddBatchPostalTransactionEntryDetails(string ExerciseUnits, string SellOption, string Units, string RemainingBalInd, string PaymentMethod, string PrefCurrency, string NotificationReqdInd, string Balance, string AvailBalance)
        {
            TRS00702.SellOption.SetValue(SellOption);
            if (SellOption == "P" || SellOption == "C")
            {
                TRS00702.RemainingBalInd.SetValue(RemainingBalInd);
            }

            TRS00702.PaymentMethod.SetValue(PaymentMethod);
            if (PaymentMethod == "C")
            {
                TRS00702.PaymentMethod.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRS00702.PrefCurrency.SetValue(PrefCurrency);
            }

            TRS00702.NotificationReqdInd.SetValue(NotificationReqdInd);

            TRS00702.Balance.ValidateFieldValue(Balance);
            TRS00702.AvailBalance.ValidateFieldValue(AvailBalance);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            if (PaymentMethod == "D")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00707");
            }
            else if (PaymentMethod == "W")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00707");
            }
            if (SellOption == "P")
            {
                //TRS00507.SellAll01.SetValue(SellAll01);
                TRS00507.EXERCISE01.SetValue(ExerciseUnits);
                TRS00507.Units01.SetValue(Units);
            }
            else
            {
                TRS00507.EXERCISE01.SetValue(ExerciseUnits);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRS00511 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)""")]
        public void TRS00511AddPostalTransactionEntryDetails(string DurationType, string EstMarketValue)
        {
            TRS00511.DurationType.SetValue(DurationType);
            TRS00511.EstMarketValue.SetValue(EstMarketValue);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRS00504 I Verify Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00504VerifyPostalTransactionEntryDetails(string UnitsSell, string EstMarketValue, string MarketValue, string PurchResidueAmt, string FederalTaxWithheld, string LoanAmt, string ChargeAmount1, string ChargeAmount2, string ChargeAmount3, string TotalGst, string EstimatedProceeds)
        {
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00504");
            TRS00504.UnitsSell.ValidateFieldValue(UnitsSell);
            TRS00504.EstMarketValue.ValidateFieldValue(EstMarketValue);
            TRS00504.MarketValue.ValidateFieldValue(MarketValue);
            TRS00504.PurchResidueAmt.ValidateFieldValue(PurchResidueAmt);
            TRS00504.FederalTaxWithheld.ValidateFieldValue(FederalTaxWithheld);
            TRS00504.LoanAmt.ValidateFieldValue(LoanAmt);
            TRS00504.ChargeAmount.ValidateFieldValue(1, ChargeAmount1);
            TRS00504.ChargeAmount.ValidateFieldValue(2, ChargeAmount2);
            TRS00504.ChargeAmount.ValidateFieldValue(3, ChargeAmount3);
            TRS00504.TotalGst.ValidateFieldValue(TotalGst);
            TRS00504.EstimatedProceeds.ValidateFieldValue(EstimatedProceeds);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRS00704 I Verify Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00704VerifyPostalTransactionEntryDetails(string UnitsExercise, string UnitsSell, string EstMarketValue, string MarketValue, string PurchResidueAmt, string FederalTaxWithheld, string OptionCost, string ChargeAmount1, string ChargeAmount2, string ChargeAmount3, string TotalGst, string EstimatedProceeds)
        {
            TRS00704.UnitsExercise.ValidateFieldValue(UnitsExercise);
            TRS00704.UnitsSell.ValidateFieldValue(UnitsSell);
            TRS00704.EstMarketValue.ValidateFieldValue(EstMarketValue);
            TRS00704.MarketValue.ValidateFieldValue(MarketValue);
            TRS00704.PurchResidueAmt.ValidateFieldValue(PurchResidueAmt);
            TRS00704.FederalTaxWithheld.ValidateFieldValue(FederalTaxWithheld);
            TRS00704.OptionCost.ValidateFieldValue(OptionCost);
            TRS00704.ChargeAmount.ValidateFieldValue(1, ChargeAmount1);
            TRS00704.ChargeAmount.ValidateFieldValue(2, ChargeAmount2);
            TRS00704.ChargeAmount.ValidateFieldValue(3, ChargeAmount3);
            TRS00704.TotalGst.ValidateFieldValue(TotalGst);
            TRS00704.EstimatedProceeds.ValidateFieldValue(EstimatedProceeds);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00703");
        }

        [When(@"In TRS00512 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)""")]
        public void TRS00512AddPostalTransactionEntryDetails(string OverrideEmailInd, string EmailAddress)
        {
            TRS00512.OverrideEmailInd.SetValue(OverrideEmailInd);

            if (OverrideEmailInd == "Y")
            {
                TRS00512.OverrideEmailInd.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRS00512.EmailAddress.SetValue(EmailAddress);
            }
            else if (OverrideEmailInd == "N")
            {
                TRS00512.EmailAddress.ValidateFieldValue(EmailAddress);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRS00503 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)""")]
        public void TRS00503AddPostalTransactionEntryDetails(string ConfirmUnits, string ConfirmWarningFlag5)
        {
            if (TRS00503.ConfirmUnits.Exists() == true)
            {
                TRS00503.ConfirmUnits.SetValue(ConfirmUnits);
            }
            if (TRS00503.ConfirmWarningFlag5.Exists() == true)
            {
                TRS00503.ConfirmWarningFlag5.SetValue(ConfirmWarningFlag5);
            }
            if (TRS00503.ConfirmForeign.Exists() == true)
            {
                TRS00503.ConfirmForeign.SetValue("Y");
            }
            if (TRS00503.ConfirmReturnMail.Exists() == true)
            {
                TRS00503.ConfirmReturnMail.SetValue("Y");
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "TRS00508")
            {
                TradingID = TRS00508.TradingID.GetValue();
                TransNumber = TRS00508.TransNumber.GetValue();
            }

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }

        [When(@"In TRS00703 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00703AddPostalTransactionEntryDetails(string ExerciseUnits, string ConfirmUnits, string ConfirmWarningFlag5)
        {

            if (TRS00703.ConfirmForeign.Exists() == true)
            {
                TRS00703.ConfirmForeign.SetValue("Y");
            }
            if (TRS00703.ConfirmWarningFlag5.Exists() == true)
            {
                TRS00703.ConfirmWarningFlag5.SetValue(ConfirmWarningFlag5);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "TRS00708")
            {
                TradingID = TRS00708.TradingID.GetValue();
                TransNumber = TRS00708.TransNumber.GetValue();
            }
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }

        [When(@"In TRD00401 I Change Order Status to ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD00401ChangeOrderStatusTo(string MenuSelection, string ConfirmStatus, string TradeDate, string TradeTimeHH, string TradeTimeMM, string SettlementDate, string FinalPrice)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("change order status");
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00401");
            TRD00401.MenuSelection.SetValue(MenuSelection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "TRD004TF")
            {
                TRD004TF.ConfirmFunds.SetValue("Y");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00402");
            TRD00402.ConfirmStatus.SetValue(ConfirmStatus);
            TRD00402.TradeDate.SetValue(TradeDate);
            TRD00402.TradeTimeHH.SetValue(TradeTimeHH);
            TRD00402.TradeTimeMM.SetValue(TradeTimeMM);
            if (TRD00402.SettlementDate.Exists() == true)
            {
                TRD00402.SettlementDate.SetValue(SettlementDate);
            }
            TRD00402.FinalPrice.SetValue(FinalPrice);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00403");
            if (TRD00403.ConfirmSettleDate.Exists() == true)
            {
                TRD00403.ConfirmSettleDate.SetValue(SettlementDate);
            }
            TRD00403.ConfirmFinalPrice.SetValue(FinalPrice);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD004CS");
        }

        [When(@"In TRD00401 I Change Transfer Order Status to ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInTRDIChangeTOrderStatusTo(string MenuSelection, string ConfirmStatus, string TradeDate, string TradeTimeHH, string TradeTimeMM, string FinalPrice)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("change order status");
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00401");
            TRD00401.MenuSelection.SetValue(MenuSelection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "TRD004TF")
            {
                TRD004TF.ConfirmFunds.SetValue("Y");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00402");
            TRD00402.ConfirmStatus.SetValue(ConfirmStatus);
            TRD00402.TradeDate.SetValue(TradeDate);
            TRD00402.TradeTimeHH.SetValue(TradeTimeHH);
            TRD00402.TradeTimeMM.SetValue(TradeTimeMM);
            TRD00402.FinalPrice.SetValue(FinalPrice);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00405");
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }



        [When(@"In TRD00401 I Change Batch Order Status to ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInTRDIChangeBatchOrderStatusTo(string MenuSelection, string ConfirmStatus, string TradeDate, string TradeTimeHH, string TradeTimeMM, string SettlementDate, string FinalPrice)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("change order status");
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00401");
            TRD00401.MenuSelection.SetValue(MenuSelection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00402");
            TRD00402.ConfirmStatus.SetValue(ConfirmStatus);
            TRD00402.TradeDate.SetValue(TradeDate);
            TRD00402.TradeTimeHH.SetValue(TradeTimeHH);
            TRD00402.TradeTimeMM.SetValue(TradeTimeMM);
            TRD00402.SettlementDate.SetValue(SettlementDate);
            TRD00402.FinalPrice.SetValue(FinalPrice);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "TRD00406")
            {
                TRD00406.DurationType.SetValue("1");
                TRD00406.SuppressOrmsMessage.SetValue("Y");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00403");
            if (TRD00403.ConfirmSettleDate.Exists() == true)
            {
                TRD00403.ConfirmSettleDate.SetValue(SettlementDate);
            }
            if (TRD00403.CnfrmChngdReuters.Exists() == true)
            {
                TRD00403.CnfrmChngdReuters.SetValue("Y");
            }
            TRD00403.ConfirmFinalPrice.SetValue(FinalPrice);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00405");
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }


        [When(@"In TRD00401 I Apply Exercise Transaction as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD00401ApplyExerciseTransaction(string MenuSelection2, string ConfirmStatus2, string TradeDate, string TradeTimeHH, string TradeTimeMM, string SettlementDate, string FinalPrice)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(20);
            ClickOnWithinTheTradingSystemOptionsMenu("apply exercise transaction");
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00401");
            TRD00401.MenuSelection.SetValue(MenuSelection2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00402");
            TRD00402.ConfirmStatus.SetValue(ConfirmStatus2);
            TRD00402.SettlementDate.SetValue(SettlementDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00405");
            TradingID = TRD00405.TradingID.GetValue();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }

        [Then(@"In TRD004CS I Verify Change Order Status details1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD004CSVerifyChangeOrderStatusDetails1(string UnitsTraded, string TotalCost, string FinalPrice, string TradePrice, string PriceATAudit, string GrossAmount, string PurchaseResidue, string HolderCharges1, string LoanAmount, string OptionCost, string Gst, string TaxWithheld, string NettAmount, string ChargeAmount01, string ChargeAmount02, string ChargeAmount03, string ChargeAmount04, string ChargeAmount05, string ChargeAmount06)
        {
            TRD004CS.UnitsTraded.ValidateFieldValue(UnitsTraded);
            TRD004CS.TotalCost.ValidateFieldValue(TotalCost);
            TRD004CS.FinalPrice.ValidateFieldValue(FinalPrice);
            TRD004CS.TradePrice.ValidateFieldValue(TradePrice);
            TRD004CS.PriceATAudit.ValidateFieldValue(PriceATAudit);
            TRD004CS.GrossAmount.ValidateFieldValue(GrossAmount);
            TRD004CS.PurchaseResidue.ValidateFieldValue(PurchaseResidue);
            TRD004CS.HolderCharges1.ValidateFieldValue(HolderCharges1);
            TRD004CS.LoanAmount.ValidateFieldValue(LoanAmount);
            TRD004CS.OptionCost.ValidateFieldValue(OptionCost);
            TRD004CS.Gst.ValidateFieldValue(Gst);
            TRD004CS.TaxWithheld.ValidateFieldValue(TaxWithheld);
            TRD004CS.NettAmount.ValidateFieldValue(NettAmount);
            TRD004CS.ChargeAmount.ValidateFieldValue(1, ChargeAmount01);
            TRD004CS.ChargeAmount.ValidateFieldValue(2, ChargeAmount02);
            TRD004CS.ChargeAmount.ValidateFieldValue(3, ChargeAmount03);
            TRD004CS.ChargeAmount.ValidateFieldValue(4, ChargeAmount04);
            TRD004CS.ChargeAmount.ValidateFieldValue(5, ChargeAmount05);
            TRD004CS.ChargeAmount.ValidateFieldValue(6, ChargeAmount06);
        }

        [Then(@"In TRD004CS I Verify Change Order Status details2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD004CSVerifyChangeOrderStatusDetails2(string LocalChqCount, string LocalChqNettAmount, string ForeignChqCount, string ForeignChqNettAmt, string WireCount, string WireNettAmount, string DirectBankingCount, string DirectBankNettAmt, string EmployerCount, string EmployerNettAmount, string CompanyCharges, string CompanyTax, string HolderCharges, string HolderTax, string ReportCharges, string ReportTax, string BankType, string BranchNumber, string AccountNumber)
        {
            TRD004CS.LocalChqCount.ValidateFieldValue(LocalChqCount);
            TRD004CS.LocalChqNettAmount.ValidateFieldValue(LocalChqNettAmount);
            TRD004CS.ForeignChqCount.ValidateFieldValue(ForeignChqCount);
            TRD004CS.ForeignChqNettAmt.ValidateFieldValue(ForeignChqNettAmt);
            TRD004CS.WireCount.ValidateFieldValue(WireCount);
            TRD004CS.WireNettAmount.ValidateFieldValue(WireNettAmount);
            TRD004CS.DirectBankingCount.ValidateFieldValue(DirectBankingCount);
            TRD004CS.DirectBankNettAmt.ValidateFieldValue(DirectBankNettAmt);
            TRD004CS.EmployerCount.ValidateFieldValue(EmployerCount);
            TRD004CS.EmployerNettAmount.ValidateFieldValue(EmployerNettAmount);
            TRD004CS.CompanyCharges.ValidateFieldValue(CompanyCharges);
            TRD004CS.CompanyTax.ValidateFieldValue(CompanyTax);
            TRD004CS.HolderCharges.ValidateFieldValue(HolderCharges);
            TRD004CS.HolderTax.ValidateFieldValue(HolderTax);
            TRD004CS.ReportCharges.ValidateFieldValue(ReportCharges);
            TRD004CS.ReportTax.ValidateFieldValue(ReportTax);
            TRD004CS.BankType.ValidateFieldValue(BankType);
            TRD004CS.BranchNumber.ValidateFieldValue(BranchNumber);
            TRD004CS.AccountNumber.ValidateFieldValue(AccountNumber);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }

        [Then(@"In TRDSCHCS I Verify Transaction Enquiry details1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRDSCHCSVerifyTransactionEnquiryDetails1(string UnitsTraded, string TotalCost, string FinalPrice, string PriceATAudit, string GrossAmount, string PurchaseResidue, string HolderCharges1, string LoanAmount, string OptionCost, string Gst, string TaxWithheld, string NettAmount, string ChargeAmount01, string ChargeAmount02, string ChargeAmount03, string ChargeAmount04, string ChargeAmount05, string ChargeAmount06)
        {
            TRDSCH02.ActionM.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDSCHCS");

            TRDSCHCS.UnitsTraded.ValidateFieldValue(UnitsTraded);
            TRDSCHCS.TotalCost.ValidateFieldValue(TotalCost);
            TRDSCHCS.FinalPrice.ValidateFieldValue(FinalPrice);
            TRDSCHCS.PriceATAudit.ValidateFieldValue(PriceATAudit);
            TRDSCHCS.GrossAmount.ValidateFieldValue(GrossAmount);
            TRDSCHCS.PurchaseResidue.ValidateFieldValue(PurchaseResidue);
            TRDSCHCS.HolderCharges1.ValidateFieldValue(HolderCharges1);
            TRDSCHCS.LoanAmount.ValidateFieldValue(LoanAmount);
            TRDSCHCS.OptionCost.ValidateFieldValue(OptionCost);
            TRDSCHCS.Gst.ValidateFieldValue(Gst);
            TRDSCHCS.TaxWithheld.ValidateFieldValue(TaxWithheld);
            TRDSCHCS.NettAmount.ValidateFieldValue(NettAmount);
            TRDSCHCS.ChargeAmount.ValidateFieldValue(1, ChargeAmount01);
            TRDSCHCS.ChargeAmount.ValidateFieldValue(2, ChargeAmount02);
            TRDSCHCS.ChargeAmount.ValidateFieldValue(3, ChargeAmount03);
            TRDSCHCS.ChargeAmount.ValidateFieldValue(4, ChargeAmount04);
            TRDSCHCS.ChargeAmount.ValidateFieldValue(5, ChargeAmount05);
            TRDSCHCS.ChargeAmount.ValidateFieldValue(6, ChargeAmount06);
        }

        [Then(@"In TRDSCHCS I Verify Transaction Enquiry details2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRDSCHCSVerifyTransactionEnquiryDetails2(string LocalChqCount, string LocalChqNettAmount, string ForeignChqCount, string ForeignChqNettAmt, string WireCount, string WireNettAmount, string DirectBankingCount, string DirectBankNettAmt, string EmployerCount, string EmployerNettAmount, string CompanyCharges, string CompanyTax, string HolderCharges, string HolderTax, string ReportCharges, string ReportTax, string BankType, string BranchNumber, string AccountNumber)
        {
            TRDSCHCS.LocalChqCount.ValidateFieldValue(LocalChqCount);
            TRDSCHCS.LocalChqNettAmount.ValidateFieldValue(LocalChqNettAmount);
            TRDSCHCS.ForeignChqCount.ValidateFieldValue(ForeignChqCount);
            TRDSCHCS.ForeignChqNettAmt.ValidateFieldValue(ForeignChqNettAmt);
            TRDSCHCS.WireCount.ValidateFieldValue(WireCount);
            TRDSCHCS.WireNettAmount.ValidateFieldValue(WireNettAmount);
            TRDSCHCS.DirectBankingCount.ValidateFieldValue(DirectBankingCount);
            TRDSCHCS.DirectBankNettAmt.ValidateFieldValue(DirectBankNettAmt);
            TRDSCHCS.EmployerCount.ValidateFieldValue(EmployerCount);
            TRDSCHCS.EmployerNettAmount.ValidateFieldValue(EmployerNettAmount);
            TRDSCHCS.CompanyCharges.ValidateFieldValue(CompanyCharges);
            TRDSCHCS.CompanyTax.ValidateFieldValue(CompanyTax);
            TRDSCHCS.HolderCharges.ValidateFieldValue(HolderCharges);
            TRDSCHCS.HolderTax.ValidateFieldValue(HolderTax);
            TRDSCHCS.ReportCharges.ValidateFieldValue(ReportCharges);
            TRDSCHCS.ReportTax.ValidateFieldValue(ReportTax);
            TRDSCHCS.BankType.ValidateFieldValue(BankType);
            TRDSCHCS.BranchNumber.ValidateFieldValue(BranchNumber);
            TRDSCHCS.AccountNumber.ValidateFieldValue(AccountNumber);
        }

        [When(@"In TRD00101 I Run the Generate Output Job as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD00101RunTheGenerateOutputJob(string PaymentAccount1, string OrderNO, string Ident, string ClassCode, string NbrTrades, string TradeGrossAmount, string TradeFrom, string TradeTO, string SettlementFrom, string SettlementTO)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(20);
            ClickOnWithinTheTradingSystemOptionsMenu("generate output");
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(20);
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00101");
            TRD00101.PaymentAccount.ValidateFieldValue(PaymentAccount1);
            TRD00101.ClassCode.ValidateFieldValue(ClassCode);
            TRD00101.NbrTrades.ValidateFieldValue(NbrTrades);
            TRD00101.TradeGrossAmount.ValidateFieldValue(TradeGrossAmount);
            TRD00101.SettlementFrom.SetValue(SettlementFrom);
            TRD00101.SettlementTO.SetValue(SettlementTO);
            TradeID = TRD00101.TradeFrom.GetValue();
            TRD00101.OrderNO.SetValue(OrderNO);
            TRD00101.Ident.SetValue(Ident);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(20);
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00102");
            ReportingTestSteps.ReportJobNumber = TRD00102.JobNODec.GetValue();
            ReportingTestSteps.ReportPrintFileName = TradeID;
            ReportingTestSteps.TradingReport = true;
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(20);
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }


        [When(@"In TRD00101 I Run the Exempt Generate Output Job as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD00101RunTheExemptGenerateOutputJob(string PaymentAccount1, string OrderNO, string Ident, string ClassCode, string NbrTrades, string TradeGrossAmount, string TradeFrom, string TradeTO, string SettlementFrom, string SettlementTO)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("generate output");
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00101");
            TRD00101.PaymentAccount.ValidateFieldValue(PaymentAccount1);
            TRD00101.ClassCode.ValidateFieldValue(ClassCode);
            TRD00101.NbrTrades.ValidateFieldValue(NbrTrades);
            TRD00101.TradeGrossAmount.ValidateFieldValue(TradeGrossAmount);
            TRD00101.SettlementFrom.SetValue(SettlementFrom);
            TRD00101.SettlementTO.SetValue(SettlementTO);
            //TradeID = TRD00101.TradeFrom.GetValue();
            TRD00101.OrderNO.SetValue(OrderNO);
            TRD00101.Ident.SetValue(Ident);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(30);
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00102");
            JobNumber = TRD00102.JobNODec.GetValue();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }



        [When(@"In TRD00401 I Force Settle the Order as ""(.*)"" ""(.*)""")]
        public void TRD00401ForceSettleTheOrder(string MenuSelection1, string ConfirmStatus1)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(20);
            ClickOnWithinTheTradingSystemOptionsMenu("force bulk settlement");
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            if (formname == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00401");
            TRD00401.MenuSelection.SetValue(MenuSelection1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00402");
            TRD00402.ConfirmStatus.SetValue(ConfirmStatus1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00405");
            TradingID = TRD00405.TradingID.GetValue();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }

        [Then(@"In TRS01010 I Verify Transaction Enquiry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS01010VerifyTransactionEnquiryDetails(string TradingID, string Status, string Price, string ClassCode, string TransCount, string TransTotal, string MoneyTotal, string SettlementDate, string ApplyTaxInd, string PaymentMethod, string PaymentMethodDesc, string Currency, string SellUnits, string OrderType, string TradeUnits, string TradeMoney)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("transaction enquiry");
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "TRDSCH01")
            {
                TradingID = TRDSCH01.TradingID.GetValue(1);
                TRDSCH01.Status.ValidateFieldValue(1, Status);
                TRDSCH01.Price.ValidateFieldValue(1, Price);
                TRDSCH01.ClassCode.ValidateFieldValue(1, ClassCode);
                TRDSCH01.TransCount.ValidateFieldValue(1, TransCount);
                TRDSCH01.TransTotal.ValidateFieldValue(1, TransTotal);
                TRDSCH01.MoneyTotal.ValidateFieldValue(1, MoneyTotal);
                TRDSCH01.SettlementDate.ValidateFieldValue(1, SettlementDate);
                TRDSCH01.ApplyTaxInd.ValidateFieldValue(1, ApplyTaxInd);
                TRDSCH01.Selection.SetValue(TradingID);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS01010");
            TRS01010.TradingID.ValidateFieldValue(TradingID);
            TRS01010.StatusDesc.ValidateFieldValue(Status);
            TRS01010.TradeCount.ValidateFieldValue(TransCount);
            TRS01010.TradeUnits.ValidateFieldValue(TransTotal);
            TRS01010.TradeMoney.ValidateFieldValue(MoneyTotal);
            TRS01010.TransUnits.ValidateFieldValue(TradeUnits);
            try
            {
                TRS01010.TransMoney.ValidateFieldValue(TradeMoney);
            }
            catch (Exception e)
            {
                Console.WriteLine("TransMoney fix is yet to be fixed. Raised a PBI in the backlog", e.Message);
            }
            TRS01010.PaymentMethod.ValidateFieldValue(PaymentMethod);
            TRS01010.PaymentMethodDesc.ValidateFieldValue(PaymentMethodDesc);
            TRS01010.Currency.ValidateFieldValue(Currency);
            TRS01010.SellUnits.ValidateFieldValue(SellUnits);
            TRS01010.OrderType.ValidateFieldValue(OrderType);

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");

        }




        [Then(@"In TRDSCH02 I Verify Transaction Enquiry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRDSCH02VerifyTransactionEnquiryDetails(string TradingID, string BulkType, string BulkTypeDesc, string StatusDesc, string TotalCount, string OrderTransUnits, string TotalMoney, string TradeDate, string ReqdSettlementDate, string ActualSettlementDate, string FinalPrice, string ReconciliationCode, string CshtrnReference, string MinimumDeal, string MaximumDeal, string CutOffTime, string CounterpartyClass, string CounterRegisterCode, string OrderType)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("order enquiry");
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "TRDSCH01")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDSCH02");
            //TRDSCH02.TradingID.ValidateFieldValue(TradingID);
            TRDSCH02.BulkType.ValidateFieldValue(BulkType);
            TRDSCH02.BulkTypeDesc.ValidateFieldValue(BulkTypeDesc);
            TRDSCH02.StatusDesc.ValidateFieldValue(StatusDesc);
            TRDSCH02.TotalCount.ValidateFieldValue(TotalCount);
            TRDSCH02.OrderTransUnits.ValidateFieldValue(OrderTransUnits);
            TRDSCH02.TotalMoney.ValidateFieldValue(TotalMoney);
            if (TRDSCH02.TradeDate.Exists() == true)
            {
                TRDSCH02.TradeDate.ValidateFieldValue(TradeDate);
            }
            TRDSCH02.ReqdSettlementDate.ValidateFieldValue(ReqdSettlementDate);
            TRDSCH02.ActualSettlementDate.ValidateFieldValue(ActualSettlementDate);
            TRDSCH02.FinalPrice.ValidateFieldValue(FinalPrice);
            if (TRDSCH02.ReconciliationCode.Exists() == true)
            {
                TRDSCH02.ReconciliationCode.ValidateFieldValue(ReconciliationCode);
            }
            //TRDSCH02.CshtrnReference.ValidateFieldValue(CshtrnReference);
            TRDSCH02.MinimumDeal.ValidateFieldValue(MinimumDeal);
            TRDSCH02.MaximumDeal.ValidateFieldValue(MaximumDeal);
            if (TRDSCH02.CutOffTime.Exists() == true)
            {
                TRDSCH02.CutOffTime.ValidateFieldValue(CutOffTime);
            }
            if (TRDSCH02.CounterpartyClass.Exists() == true)
            {
                TRDSCH02.CounterpartyClass.ValidateFieldValue(CounterpartyClass);
            }
            if (TRDSCH02.CounterRegisterCode.Exists() == true)
            {
                TRDSCH02.CounterRegisterCode.ValidateFieldValue(CounterRegisterCode);
            }
            if (TRDSCH02.OrderType.Exists() == true)
            {
                TRDSCH02.OrderType.ValidateFieldValue(OrderType);
            }

        }

        [Then(@"In TRS00711 I Verify Certificate Selection details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00711VerifyCertificateSelectionDetails(string CertID1, string Register1, string OptionPrice1, string CertBalance1, string AvailBal1, string CertID2, string Register2, string OptionPrice2, string CertBalance2, string AvailBal2)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formname = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formname == "TRS00711")
            {
                TRS00711.CertID.ValidateFieldValue(1, CertID1);
                TRS00711.Register.ValidateFieldValue(1, Register1);
                TRS00711.OptionPrice.ValidateFieldValue(1, OptionPrice1);
                TRS00711.CertBalance.ValidateFieldValue(1, CertBalance1);
                TRS00711.AvailBal.ValidateFieldValue(1, AvailBal1);
                TRS00711.CertID.ValidateFieldValue(2, CertID2);
                TRS00711.Register.ValidateFieldValue(2, Register2);
                TRS00711.OptionPrice.ValidateFieldValue(2, OptionPrice2);
                TRS00711.CertBalance.ValidateFieldValue(2, CertBalance2);
                TRS00711.AvailBal.ValidateFieldValue(2, AvailBal2);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00702");
            }
        }

        [When(@"In TRS00513 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00513AddPostalTransactionEntryDetails(string Cover01, string Cover02, string Cover03, string Cover04, string Cover05, string Cover06, string Cover07, string Cover08, string Cover09, string Cover10, string Cover11, string Cover12, string Cover13, string Cover14, string Cover15)
        {
            if (SaleType == "C")
            {
                switch (Class.ToLower())
                {
                    case "ela":
                        TRS00513.Cover01.SetValue(Cover01);
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        break;

                    case "ats":
                        TRS00513.Cover01.SetValue(Cover01);
                        TRS00513.Cover02.SetValue(Cover02);
                        TRS00513.Cover03.SetValue(Cover03);
                        TRS00513.Cover04.SetValue(Cover04);
                        TRS00513.Cover05.SetValue(Cover05);
                        TRS00513.Cover06.SetValue(Cover06);
                        TRS00513.Cover07.SetValue(Cover07);
                        TRS00513.Cover07.ClickField();
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        break;

                    case "eso":
                        TRS00513.Cover01.SetValue(Cover01);
                        TRS00513.Cover02.SetValue(Cover02);
                        TRS00513.Cover03.SetValue(Cover03);
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        break;

                    default:
                        break;
                }
            }
        }

        [When(@"In TRS00507 I Add Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00507AddPostalTransactionEntryDetails(string SellAll01, string Units01, string SellAll02, string Units02, string SellAll03, string Units03, string SellAll04, string Units04, string SellAll05, string Units05, string SellAll06, string Units06, string SellAll07, string Units07, string SellAll08, string Units08, string SellAll09, string Units09)
        {
            if (SaleType == "S")
            {
                switch (Class.ToLower())
                {
                    case "ela":
                        TRS00507.SellAll01.SetValue(SellAll01);
                        TRS00507.Units01.SetValue(Units01);
                        if (SellAll02.Trim() != "")
                        {
                            TRS00507.SellAll02.SetValue(SellAll02);
                        }
                        if (Units02.Trim() != "")
                        {
                            TRS00507.Units02.SetValue(Units02);
                        }
                        if (SellAll03.Trim() != "")
                        {
                            TRS00507.SellAll03.SetValue(SellAll03);
                        }
                        if (Units03.Trim() != "")
                        {
                            TRS00507.Units03.SetValue(Units03);
                        }
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        break;
                    case "ats":
                        TRS00507.SellAll01.SetValue(SellAll01);
                        TRS00507.Units01.SetValue(Units01);
                        TRS00507.SellAll02.SetValue(SellAll02);
                        TRS00507.Units02.SetValue(Units02);
                        TRS00507.SellAll03.SetValue(SellAll03);
                        TRS00507.Units03.SetValue(Units03);
                        TRS00507.SellAll04.SetValue(SellAll04);
                        TRS00507.Units04.SetValue(Units04);
                        TRS00507.SellAll05.SetValue(SellAll05);
                        TRS00507.Units05.SetValue(Units05);
                        TRS00507.SellAll06.SetValue(SellAll06);
                        TRS00507.Units06.SetValue(Units06);
                        TRS00507.SellAll07.SetValue(SellAll07);
                        TRS00507.Units07.SetValue(Units07);
                        TRS00507.SellAll08.SetValue(SellAll08);
                        TRS00507.Units08.SetValue(Units08);
                        TRS00507.SellAll09.SetValue(SellAll09);
                        TRS00507.Units09.SetValue(Units09);
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        break;
                    case "eso":
                        TRS00507.SellAll01.SetValue(SellAll01);
                        TRS00507.Units01.SetValue(Units01);
                        TRS00507.SellAll02.SetValue(SellAll02);
                        TRS00507.Units02.SetValue(Units02);
                        TRS00507.SellAll03.SetValue(SellAll03);
                        TRS00507.Units03.SetValue(Units03);
                        Spartan.Core.WinForms.WinFormsDriver.Transmit();
                        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                        break;
                }

            }

        }

        [When(@"In TRD00201 I create a New Order as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRD00201CreateANewOrder(string TradeDate, string SettlementDate, string ApplyTax)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("create new order");
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00201");
            TRD00201.TradeDate.SetValue(TradeDate);
            TRD00201.SettlementDate.SetValue(SettlementDate);
            TRD00201.ApplyTax.SetValue(ApplyTax);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00202");
            TRD00202.SettleDateConfirm.SetValue(SettlementDate);
            TRD00202.SettleConfirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRD00204");
            TradingID = TRD00204.TradingID.GetValue();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRDMNU03");
        }

        [When(@"In TRS00501 I Add Batch Postal Transaction Entry details as ""(.*)"" ""(.*)""")]
        public void TRS00501AddBatchPostalTransactionEntryDetails(string TransNumber, string SearchName)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("postal transaction entry");
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00501");
            TRS00501.TransNumber.SetValue(TransNumber);
            TRS00501.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00502");
        }

        [When(@"In TRS00701 I Add Batch Postal Transaction Entry details as ""(.*)"" ""(.*)""")]
        public void TRS00701AddBatchPostalTransactionEntryDetails(string TransNumber, string SearchName)
        {
            ClickOnWithinTheTradingSystemOptionsMenu("postal transaction entry");
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00701");
            TRS00501.TransNumber.SetValue(TransNumber);
            TRS00501.SearchName.SetValue(SearchName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("TRS00702");
        }

        [When(@"In TRS00502 I Add Batch Postal Transaction Entry details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void TRS00502AddBatchPostalTransactionEntryDetails(string SellOption, string Units, string PaymentMethod, string PrefCurrency, string NotificationReqdInd, string Balance, string AvailBalance)
        {
            Class = TRS00502.ClassCode.GetValue();
            TRS00502.SellOption.SetValue(SellOption);
            if (SellOption == "P")
            {
                TRS00502.SellOption.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRS00502.Units.SetValue(Units);
            }
            TRS00502.PaymentMethod.SetValue(PaymentMethod);

            if (PaymentMethod == "C")
            {
                TRS00502.PaymentMethod.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                TRS00502.PrefCurrency.SetValue(PrefCurrency);
            }
            TRS00502.NotificationReqdInd.SetValue(NotificationReqdInd);

            TRS00502.Balance.ValidateFieldValue(Balance);
            TRS00502.AvailBalance.ValidateFieldValue(AvailBalance);
            SaleType = TRS00502.SellOption.GetValue();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            if (PaymentMethod == "D")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else if (PaymentMethod == "W")
            {
                _WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        //Dushan commented this : duplicate binding 
        //[When(@"I go to the Employee Scheme Processing Menu ""(.*)""")]
        //public void GoToTheEmployeeSchemeProcessingMenu(string ClassCode)
        //{
        //    _WinFormsTestSteps.ClickWithinTheSystemMenu("employee plan processing");
        //    ClickOnEOL00126EmployeeSchemeProcessingMenu("employee scheme processing");
        //    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //    while (!EOL00101.ClassCode.GetValue().ToUpper().Split('\r', '\n').Contains(ClassCode))
        //    {
        //        EOL00101.Selection.SetValue("NXT");
        //        Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //        Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //        _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00101");
        //    }

        //    EOL00101.Selection.SetValue(ClassCode);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();

        //}

        //Dushan commented this : duplicate binding
        //public void ClickOnEOL00126EmployeeSchemeProcessingMenu(string Selection)
        //{
        //    switch (Selection.ToLower())
        //    {
        //        case "employee scheme processing":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00126.MenuItemEsp.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00101");
        //            break;

        //        default:
        //            break;
        //    }
        //}





        //[When(@"I go to the Grant Options Menu for ""(.*)""")]
        //public void IGoToTheGrantOptionsMenu(string MenuItem)
        //{
        //    EOL00107ClickOnMenu("grant options");
        //    EOL00137.Selection.SetValue(MenuItem);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
        //}


        //[When(@"In EOL00107 I Click on ""(.*)"" Menu")]
        //public void EOL00107ClickOnMenu(string Selection)
        //{
        //    switch (Selection.ToLower())
        //    {
        //        case "grant options":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00107.MenuItemGrt.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00137");
        //            break;

        //        case "leaver processing":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00107.MenuItemLvp.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00131");
        //            break;

        //        case "lapse cancellation processing":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00107.MenuItemLpc.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00132");
        //            break;

        //        case "ess option exercise reversal":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00107.MenuItemRve.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00137");
        //            break;

        //        case "event processing":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00107.MenuItemEvt.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00133");
        //            break;

        //        default:
        //            break;
        //    }
        //}

        [Then(@"I go the Main Menu From Trading System")]
        public void ThenIGoTheMainMenuFromTradingSystem()
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            while (!fName.Equals("TRDMNU01"))
            {
                Spartan.Core.WinForms.WinFormsDriver.PressESC();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            }
            TRDMNU01.MenuItemEX.ClickField();
            _WinFormsTestSteps.ExpectToBeInTheScreen("MNS00101");

        }




        //[When(@"I go to the Manual Grant of Options Menu ""(.*)""")]
        //public void WhenIGoToTheManualGrantOfOptionsMenu(string RegisterCode)
        //{
        //    while (!EOL00103.RegisterCode.GetValue().ToUpper().Split('\r', '\n').Contains(RegisterCode))
        //    {
        //        EOL00103.Selection.SetValue("NXT");
        //        Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //        _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00103");
        //    }

        //    EOL00103.Selection.SetValue(RegisterCode);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00109");
        //    ClickOnEOL00109EmployeeGrantProcessingMenu("manual grant of options");
        //}


        //public void ClickOnEOL00109EmployeeGrantProcessingMenu(string Selection)
        //{
        //    switch (Selection.ToLower())
        //    {
        //        case "manual grant of options":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00109.MenuItemGrt.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00116");
        //            break;

        //        case "reversal of grant":
        //            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //            EOL00109.MenuItemRva.ClickField();
        //            _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00401");
        //            break;

        //        default:
        //            break;
        //    }
        //}




        //[When(@"In EOL00901 I Add Grant details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void EOL00901AddGrantDetails(string AppropDate, string TransNumber, string TotalUnits, string GrantCountry, string SearchName)
        //{
        //    EOL00116.AppropDate.SetValue(AppropDate);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
        //    EOL00901.TransNumber.SetValue(TransNumber);
        //    EOL00901.TotalUnits.SetValue(TotalUnits);
        //    EOL00901.GrantCountry.SetValue(GrantCountry);
        //    EOL00901.SearchName.SetValue(SearchName);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //    Spartan.Core.WinForms.WinFormsDriver.HardWait(5);
        //    string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
        //    if (fName.Trim() == "ONLSCH02")
        //    {
        //        ONLSCH02.Action.SetValue("U");
        //        Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    }
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00905");
        //}


        //[When(@"In EOL00135 I Select Menu item as ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void EOL00135SelectMenuItem(string EventNumber, string Selection, string MenuItem)
        //{
        //    EOL00133.Selection.SetValue(EventNumber);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00134");
        //    EOL00134.Selection.SetValue(Selection);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00135");
        //    EOL00135.Selection.SetValue(MenuItem);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //}



        //[When(@"In EOL02901 I Add Event Tax Details for I type as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void EOL02901AddEventTaxDetailsForIType(string TransNumber, string SearchName, string UpdtAllCert, string WitholdingTaxRate, string RegisterCode1, string CertID1, string WthldgTaxRate1, string RegisterCode2, string CertID2, string WthldgTaxRate2)
        //{
        //    EOL02901.TransNumber.SetValue(TransNumber);
        //    EOL02901.SearchName.SetValue(SearchName);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        //    Spartan.Core.WinForms.WinFormsDriver.HardWait(5);
        //    string fName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
        //    if (fName.Trim() == "ONLSCH02")
        //    {
        //        ONLSCH02.Action.SetValue("U");
        //        Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    }

        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL02905");

        //    EOL02905.UpdtAllCert.SetValue(UpdtAllCert);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();

        //    if (UpdtAllCert == "Y")
        //    {
        //        _WinFormsTestSteps.ExpectToBeInTheScreen("EOL02903");
        //        EOL02903.WitholdingTaxRate.SetValue(WitholdingTaxRate);
        //        EOL02903.WitholdingTaxCode.SetValue("AUS-RES");
        //        EOL02903.MarketValueType.SetValue("M");

        //    }
        //    else
        //    {
        //        _WinFormsTestSteps.ExpectToBeInTheScreen("EOL02902");
        //        EOL02902.WthldgTaxRate1.SetValue(WthldgTaxRate1);
        //        EOL02902.WthldgTaxRate2.SetValue(WthldgTaxRate2);
        //    }
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL02904");

        //    /*EOL02904.RegisterCode.ValidateFieldValue(1, RegisterCode1);
        //    EOL02904.RegisterCode.ValidateFieldValue(2, RegisterCode2);
        //    EOL02904.CertID.ValidateFieldValue(1, CertID1);
        //    EOL02904.CertID.ValidateFieldValue(2, CertID2);
        //    EOL02904.WitholdingTaxRate1.ValidateFieldValue(WthldgTaxRate1);
        //    EOL02904.WitholdingTaxRate1.ValidateFieldValue(WthldgTaxRate2);*/
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL02901");
        //}







        //[Then(@"In EOL00905 I should see Buyer details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void EOL00905ShouldSeeBuyerDetails(string ClassCode, string RegisterCode, string RegisterDesc, string RegisterType1, string Units1, string Money1)
        //{
        //    EOL00905.TotalUnits.ValidateFieldValue(Units1);
        //    EOL00905.ClassCode.ValidateFieldValue(ClassCode);
        //    EOL00905.RegisterCode.ValidateFieldValue(RegisterCode);
        //    EOL00905.RegisterDesc.ValidateFieldValue(RegisterDesc);
        //    EOL00905.RegisterType1.ValidateFieldValue(RegisterType1);
        //    EOL00905.Units1.ValidateFieldValue(Units1);
        //    EOL00905.Money1.ValidateFieldValue(Money1);
        //    Spartan.Core.WinForms.WinFormsDriver.Transmit();
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("EOL00901");
        //}



        //[Then(@"In ENSESS24 I should see Options Balance as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void ShouldSeeOptionsBalance(string Plan, string PlanDesc, string Line1, string Line2, string Line3, string Line4)
        //{
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS24");
        //    ENSESS24.SchemeCode.ValidateFieldValue(Plan);
        //    ENSESS24.SchemeName.ValidateFieldValue(PlanDesc);
        //    ENSESS24.DetailLine.ValidateFieldValue(1, Line1);
        //    ENSESS24.DetailLine.ValidateFieldValue(2, Line2);
        //    ENSESS24.DetailLine.ValidateFieldValue(3, Line3);
        //    ENSESS24.DetailLine.ValidateFieldValue(4, Line4);
        //}


        //[Then(@"In ENSESS25 I should see Options Balance as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void ShouldSeeOptionsBalance(string Plan, string PlanDesc, string Line1, string Line2, string Line3)
        //{
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS25");
        //    ENSESS25.SchemeCode.ValidateFieldValue(Plan);
        //    ENSESS25.SchemeName.ValidateFieldValue(PlanDesc);
        //    ENSESS25.DetailLine.ValidateFieldValue(1, Line1);
        //    ENSESS25.DetailLine.ValidateFieldValue(2, Line2);
        //    ENSESS25.DetailLine.ValidateFieldValue(3, Line3);
        //}


        //[Then(@"In ENSESS26 I should see Future Vesting Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void ShouldSeeFutureVestingDetails(string Plan, string PlanDesc, string Line1, string Line2, string Line3, string Line4)
        //{
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS26");
        //    ENSESS26.SchemeCode.ValidateFieldValue(Plan);
        //    ENSESS26.SchemeName.ValidateFieldValue(PlanDesc);
        //    ENSESS26.DetailLine.ValidateFieldValue(1, Line1);
        //    ENSESS26.DetailLine.ValidateFieldValue(2, Line2);
        //    ENSESS26.DetailLine.ValidateFieldValue(3, Line3);
        //    ENSESS26.DetailLine.ValidateFieldValue(4, Line4);
        //}


        //[Then(@"In ENSESS51 In should see Event Tax Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void ENSESS51ShouldSeeEventTaxDetails(string ClassCode, string SchemeName, string DetailLine1, string DetailLine2, string DetailLine3, string DetailLine4, string DetailLine5)
        //{
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS51");
        //    ENSESS51.SchemeCode.ValidateFieldValue(ClassCode);
        //    ENSESS51.SchemeName.ValidateFieldValue(SchemeName);
        //    ENSESS51.DetailLine.ValidateFieldValue(1, DetailLine1);
        //    ENSESS51.DetailLine.ValidateFieldValue(2, DetailLine2);
        //    ENSESS51.DetailLine.ValidateFieldValue(3, DetailLine3);
        //    ENSESS51.DetailLine.ValidateFieldValue(4, DetailLine4);
        //    ENSESS51.DetailLine.ValidateFieldValue(5, DetailLine5);
        //}



        //[Then(@"In ENSESS40 I should see Event History Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        //public void ENSESS40ShouldSeeEventHistoryDetails(string ClassCode, string SchemeName, string Line1, string Line2, string Line3, string Line4, string Line5)
        //{
        //    _WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS40");
        //    ENSESS40.SchemeCode.ValidateFieldValue(ClassCode);
        //    ENSESS40.SchemeName.ValidateFieldValue(SchemeName);
        //    ENSESS40.DetailLine.ValidateFieldValue(1, Line1);
        //    ENSESS40.DetailLine.ValidateFieldValue(2, Line2);
        //    ENSESS40.DetailLine.ValidateFieldValue(3, Line3);
        //    ENSESS40.DetailLine.ValidateFieldValue(4, Line4);
        //    ENSESS40.DetailLine.ValidateFieldValue(5, Line5);
        //}


        [When(@"In HKS01516 I set the Multi-Cert Flag to ""(.*)""")]
        public void WhenInHKSISetTheMulti_CertFlagTo(string multiCertFlagValue)
        {
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            _WinFormsTestSteps.ExpectToBeInTheScreen("HKS01516");
            HKS01516.MultiCertExercises.SetValue(multiCertFlagValue);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "HKS01597")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            HKS00101.Selection.SetValue("EX");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In TRD24000 I select the Trade Control Code ""(.*)""")]
        public void WhenInTRDISelectTheTradeControlCode(string tradeControlCode)
        {
            TRD24000.Action.SetValue("S");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            TRD24000.SearchTradingCode.SetValue(tradeControlCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }


        [When(@"In TRD24001 I perform a Change in TCC")]
        public void WhenInTRDIPerformAChangeInTCC(Table table)
        {
            TRD24001.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            TRD24006.ONMarketTradeInd.SetValue(table.Rows[0]["OnMarketTrade"]);
            TRD24006.DPBrokerCode.SetValue(table.Rows[0]["BrokerCode"]);
            TRD24006.DPTradeAccount.SetValue(table.Rows[0]["BrokerAccountID"]);
            TRD24006.DPConnectionTO.SetValue(table.Rows[0]["ConnectionCode"]);
            TRD24006.RealTimeTrading.SetValue(table.Rows[0]["RealTimeTrading"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            TRD24003.EstimateUnitsTopup.SetValue(table.Rows[0]["TopupPercentage"]);
            if (TRD24003.AllowSellSelected.Exists())
            {
                TRD24003.AllowSellSelected.SetValue(table.Rows[0]["SellSelected"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            TRD240RB.RemainingBalOption.SetValue(table.Rows[0]["Option"]);
            TRD240RB.RemainingBalTran.SetValue(table.Rows[0]["TranType"]);
            TRD240RB.RemainingBalClass.SetValue(table.Rows[0]["ClassCode"]);
            TRD240RB.RemainingBalReg.SetValue(table.Rows[0]["RegCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            TRD24004.WorldlinkNumber.SetValue(table.Rows[0]["WorldLinkNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            HKS00101.MenuItemEX.ClickField();
        }




        [When(@"In TRD24001 I perform a Change for On Market Trade ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and Top Up ""(.*)"", ""(.*)"" and Remaining Balance Options ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and World Link Number ""(.*)""")]
        public void WhenInTRDIPerformAChangeForOnMarketTradeAndTopUpAndRemainingBalanceOptionsAndWorldLinkNumber(string OnMarketTrade, string BrokerCode, string BrokerAccountID, string ConnectionCode, string RealTimeTrading, string Percentage, string SellSelected, string Option, string TranType, string ClassCode, string RegCode, string WorldLinkNumber)
        {
            TRD24001.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            TRD24006.ONMarketTradeInd.SetValue(OnMarketTrade);
            TRD24006.DPBrokerCode.SetValue(BrokerCode);
            TRD24006.DPTradeAccount.SetValue(BrokerAccountID);
            TRD24006.DPConnectionTO.SetValue(ConnectionCode);
            TRD24006.RealTimeTrading.SetValue(RealTimeTrading);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            TRD24003.EstimateUnitsTopup.SetValue(Percentage);
            if (TRD24003.AllowSellSelected.Exists())
            {
                TRD24003.AllowSellSelected.SetValue(SellSelected);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            TRD240RB.RemainingBalOption.SetValue(Option);
            TRD240RB.RemainingBalTran.SetValue(TranType);
            TRD240RB.RemainingBalClass.SetValue(ClassCode);
            TRD240RB.RemainingBalReg.SetValue(RegCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            TRD24004.WorldlinkNumber.SetValue(WorldLinkNumber);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            HKS00101.MenuItemEX.ClickField();

        }


        [When(@"In TRD24001 I perform a Change for Remaining Balance Options ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInTRDIPerformAChangeForRemainingBalanceOptions(string Option, string TranType, string ClassCode, string RegCode)
        {
            TRD24001.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            TRD240RB.RemainingBalOption.SetValue(Option);
            TRD240RB.RemainingBalTran.SetValue(TranType);
            TRD240RB.RemainingBalClass.SetValue(ClassCode);
            TRD240RB.RemainingBalReg.SetValue(RegCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            HKS00101.MenuItemEX.ClickField();
        }

    }
}