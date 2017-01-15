using System;
using SCRIPAU.Automation.Screens;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Subtests
{
    [Binding]
    public class OnlineSystemSubtests
    {
        public OnlineSystemSubtests()
        {
            WinFormsTestSteps = new WinFormsTestSteps();
        }

        public static WinFormsTestSteps WinFormsTestSteps { get; set; }

        [BeforeFeature("setup_feature")]
        public static void BeforeAppFeature()
        {
            WinFormsTestSteps = new WinFormsTestSteps();
            WinFormsTestSteps.LogInToWinForms();
            WinFormsTestSteps.ISelectTheCompany("ANZ_AUTO");
            ChangeRunDate3();
        }
        public static void ChangeRunDate3()
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("housekeeping system");
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00101");
            HKS00101.MenuItemInt.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("HKS00200");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            string RunDate1 = HKS00201.RunDate1Input.GetValue();
            string RunDate3 = HKS00201.RunDate3Input.GetValue();
            if (RunDate3 == "")
            {
                HKS00201.RunDate3Input.SetValue(RunDate1);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                string PasswordOutput = HKS00201.PasswordOutput.GetValue();
                HKS00201.PasswordInput.SetValue(PasswordOutput);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }


        }


        [When(@"In OLS01301 I Add Bulk Payment Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddBulkPaymentInstructions(string TranNO, string InstructionType, string BankSystem, string AccountName)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
            OLS01301.TransNbrI.SetValue(TranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01301.BulkPaySystem.SetValue(BankSystem);
            OLS01301.PayeeAccountName.SetValue(AccountName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01403 I Add Deceased Estate Noting Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddDeceasedEstateNotingDetailsPart1(string TranNO, string Register, string DeceasedName, string DateOfDeath, string DeathCertSighted, string WillDated, string WillSightedDate, string SmallEstate, string ProbateGrantedIn, string ProbateGrantedOn, string ProbateightedDate, string ReSealedIn, string ReSealedOn, string Sec183, string Sec121A, string ConfirmationID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01403");
            OLS01403.TransNbrI.SetValue(TranNO);
            OLS01403.Register.SetValue(Register);
            OLS01403.DeceasedNameLine.SetValue(DeceasedName);
            OLS01403.DeathDate.SetValue(DateOfDeath);
            OLS01403.DeathSightedDate.SetValue(DeathCertSighted);
            OLS01403.WillDate.SetValue(WillDated);
            OLS01403.WillSightedDate.SetValue(WillSightedDate);
            OLS01403.StatDecHeldFlag.SetValue(SmallEstate);
            OLS01403.ProbateGrantedIN.SetValue(ProbateGrantedIn);
            OLS01403.ProbateGrantedDate.SetValue(ProbateGrantedOn);
            OLS01403.ProbateSightedDate.SetValue(ProbateightedDate);
            OLS01403.ResealedIN.SetValue(ReSealedIn);
            OLS01403.ResealedDate.SetValue(ReSealedOn);
            OLS01403.Sec183State.SetValue(Sec183);
            OLS01403.SightedInd121a.SetValue(Sec121A);
            OLS01403.ConfirmIDInd.SetValue(ConfirmationID);
        }

        [When(@"In OLS01403 I Add Deceased Estate Noting Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddDeceasedEstateNotingDetailsPart2(string Executor1, string Executor2, string Executor3, string Comment1, string Comment2, string Comment3, string Lodged)
        {
            OLS01403.Executor.SetValue(1, Executor1);
            OLS01403.Executor.SetValue(2, Executor2);
            OLS01403.DutyComment.SetValue(Executor3);
            OLS01403.NotingComment70.SetValue(1, Comment1);
            OLS01403.NotingComment70.SetValue(2, Comment2);
            OLS01403.NotingComment70.SetValue(3, Comment3);
            OLS01403.LodgedBYCommentX.SetValue(Lodged);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01403 I Add Deceased Estate Noting Update Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddDeceasedEstateNotingUpdatePart1(string Register, string DeceasedName, string DateOfDeath, string DeathCertSighted, string WillDated, string WillSightedDate, string SmallEstate, string ProbateGrantedIn, string ProbateGrantedOn, string ProbateightedDate, string ReSealedIn, string ReSealedOn, string Sec183, string Sec121A, string ConfirmationID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01403");
            OLS01403.Register.SetValue(Register);
            OLS01403.DeceasedNameLine.SetValue(DeceasedName);
            OLS01403.DeathDate.SetValue(DateOfDeath);
            OLS01403.DeathSightedDate.SetValue(DeathCertSighted);
            OLS01403.WillDate.SetValue(WillDated);
            OLS01403.WillSightedDate.SetValue(WillSightedDate);
            OLS01403.StatDecHeldFlag.SetValue(SmallEstate);
            OLS01403.ProbateGrantedIN.SetValue(ProbateGrantedIn);
            OLS01403.ProbateGrantedDate.SetValue(ProbateGrantedOn);
            OLS01403.ProbateSightedDate.SetValue(ProbateightedDate);
            OLS01403.ResealedIN.SetValue(ReSealedIn);
            OLS01403.ResealedDate.SetValue(ReSealedOn);
            OLS01403.Sec183State.SetValue(Sec183);
            OLS01403.SightedInd121a.SetValue(Sec121A);
            OLS01403.ConfirmIDInd.SetValue(ConfirmationID);
        }

        [When(@"In OLS06807 I add Deceased Estate Pack Selection options as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddDeceasedEstatePackSelectionOptions(string PaymentInstructions, string LocateHoldings, string SpecificPOA, string SRNUnknown, string TFNUpdated, string ConfirmOfID, string LegalName, string NoTradingBlock, string ValueDOD, string CGTInfo, string TransactionHistory, string DivHistory, string PaymentReceived, string DateFirstShareholder, string LegalsMet, string OPSRequested)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06807");
            OLS06807.PayInstructionInd.SetValue(PaymentInstructions);
            OLS06807.LocateHoldings.SetValue(LocateHoldings);
            OLS06807.SpecificPoaReqd.SetValue(SpecificPOA);
            OLS06807.SrnUnknown.SetValue(SRNUnknown);
            OLS06807.TfnRecorded.SetValue(TFNUpdated);
            OLS06807.ConfirmIDReq.SetValue(ConfirmOfID);
            OLS06807.LegalName.SetValue(LegalName);
            OLS06807.PrintTradingBlock.SetValue(NoTradingBlock);
            OLS06807.DodValueInd.SetValue(ValueDOD);
            OLS06807.CgtInd.SetValue(CGTInfo);
            OLS06807.TransHistYears.SetValue(TransactionHistory);
            OLS06807.PaymentHistYears.SetValue(DivHistory);
            OLS06807.PaymentReceivedInd.SetValue(PaymentReceived);
            OLS06807.DateFirstRegInd.SetValue(DateFirstShareholder);
            OLS06807.LegalsMet.SetValue(LegalsMet);
            OLS06807.OspRequestedInd.SetValue(OPSRequested);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01301 I Add Foreign Cheque Instructions as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddForeignChequeInstructions(string TranNO, string InstructionType, string Currency)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
            OLS01301.TransNbrI.SetValue(TranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01301.RequiredCurrency.SetValue(Currency);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS06805 I add Forwarding Address Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddForwardingAddressDetails(string YourReference, string Dear, string ForwardingAddress1, string ForwardingAddress2, string ForwardingAddress3, string ForwardingAddress4, string ForwardingAddress5, string ForwardingAddress6, string ForwardingPostcode, string OverrideEstateSize)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06805");
            OLS06805.YourReference.SetValue(YourReference);
            OLS06805.Salutation.SetValue(Dear);
            OLS06805.FIAddressLine.SetValue(1, ForwardingAddress1);
            OLS06805.FIAddressLine.SetValue(2, ForwardingAddress2);
            OLS06805.FIAddressLine.SetValue(3, ForwardingAddress3);
            OLS06805.FIAddressLine.SetValue(4, ForwardingAddress4);
            OLS06805.FIAddressLine.SetValue(5, ForwardingAddress5);
            OLS06805.FIAddressLine.SetValue(6, ForwardingAddress6);
            OLS06805.FIPostcode.SetValue(ForwardingPostcode);
            OLS06805.OveEstateSizeInd.SetValue(OverrideEstateSize);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01801 I Add Holder Extra Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddHolderExtraDetails(string Tran, string ExtraHolderID, string HomeTell, string WorkTell, string Fax, string Mobile, string Email, string ReturnedEmail, string EmailFailCount, string Flag1, string Flag2, string Flag3, string Flag4, string Flag5, string Flag6, string Flag7, string Flag8, string Flag9)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01801");
            OLS01801.TransNbrI.SetValue(Tran);
            OLS01801.HolderExtraID.SetValue(ExtraHolderID);
            OLS01801.HomePhone.SetValue(HomeTell);
            OLS01801.WorkPhone.SetValue(WorkTell);
            OLS01801.FaxNumber.SetValue(Fax);
            OLS01801.MobilePhone.SetValue(Mobile);
            OLS01801.Email.SetValue(Email);
            OLS01801.EmailReturnDate.SetValue(ReturnedEmail);
            OLS01801.EmailFailCount.SetValue(EmailFailCount);
            OLS01801.EWFlag1.SetValue(Flag1);
            OLS01801.EWFlag2.SetValue(Flag2);
            OLS01801.EWFlag3.SetValue(Flag3);
            OLS01801.EWFlag4.SetValue(Flag4);
            OLS01801.EWFlag5.SetValue(Flag5);
            OLS01801.EWFlag6.SetValue(Flag6);
            OLS01801.EWFlag7.SetValue(Flag7);
            OLS01801.EWFlag8.SetValue(Flag8);
            OLS01801.EWFlag9.SetValue(Flag9);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS06803 I add New Registered Address Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddNewRegisteredAddressDetails(string DeceasedEstatePack, string Address1, string Address2, string Address3, string Address4, string Address5, string ThirdPartyPostcode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06803");
            OLS06803.DeceasedPackInd.SetValue(DeceasedEstatePack);

            String HIN = OLS06803.HolderIdentifier.GetValue();
            String Type = OLS06803.HolderTypeCode.GetValue();
            if (!HIN.Contains("X") || Type != "JNT")
            {
                OLS06803.AddressLine.SetValue(1, Address1);
                OLS06803.AddressLine.SetValue(2, Address2);
                OLS06803.AddressLine.SetValue(3, Address3);
                OLS06803.AddressLine.SetValue(4, Address4);
                //OLS06803.AddressLine.SetValue(5, Address5);
                OLS06803.ThirdPtyPostcode.SetValue(ThirdPartyPostcode);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01404 I Add Noting Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddNotingDetails(string TranNO, string Comment, string NotingLine1, string NotingLine2, string NotingLine3, string NotingLine4, string NotingLine5, string NotingLine6, string NotingLine7, string NotingLine8)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01404");
            OLS01404.TransNbrI.SetValue(TranNO);
            OLS01404.NotingComment50.SetValue(Comment);
            OLS01404.NotingLine.SetValue(1, NotingLine1);
            OLS01404.NotingLine.SetValue(2, NotingLine2);
            OLS01404.NotingLine.SetValue(3, NotingLine3);
            OLS01404.NotingLine.SetValue(4, NotingLine4);
            OLS01404.NotingLine.SetValue(5, NotingLine5);
            OLS01404.NotingLine.SetValue(6, NotingLine6);
            OLS01404.NotingLine.SetValue(7, NotingLine7);
            OLS01404.NotingLine.SetValue(8, NotingLine8);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
        }

        [When(@"In OLS01303 I Add Payee Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddPayeeInstructions(string TranNO, string InstructionType, string BSB1, string BSB2, string AccountNbr, string AccountName, string NZBank, string NZBranch, string NZAccountNbr, string NZSuffix, string SortCode1, string SortCode2, string SortCode3, string RoutingNbr, string AccountType)
        {
            OLS01301.TransNbrI.SetValue(TranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            switch (InstructionType.ToLower())
            {
                case "a":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01303");
                    OLS01303.BankCodeAus1to3.SetValue(BSB1);
                    OLS01303.BankCodeAus4to6.SetValue(BSB2);
                    OLS01303.BankAccountAusNum.SetValue(AccountNbr);
                    OLS01303.PayeeAccountName.SetValue(AccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "n":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01304");
                    OLS01304.BankCodeNzl1to2.SetValue(NZBank);
                    OLS01304.BankCodeNzl3to6.SetValue(NZBranch);
                    OLS01304.BankAccountNzl1to7.SetValue(NZAccountNbr);
                    OLS01304.BankAccountNzl8to10.SetValue(NZSuffix);
                    OLS01304.PayeeAccountName.SetValue(AccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "g":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01306");
                    OLS01306.BankCodeGbr1to2.SetValue(SortCode1);
                    OLS01306.BankCodeGbr3to4.SetValue(SortCode2);
                    OLS01306.BankCodeGbr5to6.SetValue(SortCode3);
                    OLS01306.BankAccountGbrNum.SetValue(AccountNbr);
                    OLS01306.PayeeAccountName.SetValue(AccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "u":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01305");
                    OLS01305.BankCodeUsa.SetValue(RoutingNbr);
                    OLS01305.BankAccountUsa.SetValue(AccountNbr);
                    OLS01305.BankAccountType.SetValue(AccountType);
                    OLS01305.PayeeAccountName.SetValue(AccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    break;
            }
        }

        [When(@"In OLS01401 I Add Power of Attorney Noting Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddPowerOfAttorneyNotingDetailsPart1(string TranNO, string Register1, string Register2, string Donorname1, string Donorname2, string Attorneys1, string Attorneys2, string Attorneys3, string Attorneys4, string Attorneys5, string Powerdated, string PowerNoted, string Jointly, string Severally, string AnyTwo, string Other1, string Other2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01401");
            OLS01401.TransNbrI.SetValue(TranNO);
            OLS01401.Reg.SetValue(1, Register1);
            OLS01401.Reg.SetValue(2, Register2);
            OLS01401.DonorNameLine.SetValue(1, Donorname1);
            OLS01401.DonorNameLine.SetValue(2, Donorname2);
            OLS01401.AttorneysName.SetValue(1, Attorneys1);
            OLS01401.AttorneysName.SetValue(2, Attorneys2);
            OLS01401.AttorneysName.SetValue(3, Attorneys3);
            OLS01401.AttorneysName.SetValue(4, Attorneys4);
            OLS01401.AttorneysName.SetValue(5, Attorneys5);
            OLS01401.PowerDated.SetValue(Powerdated);
            OLS01401.PowerNoted.SetValue(PowerNoted);
            OLS01401.AtsJointlyFlag.SetValue(Jointly);
            OLS01401.AtsSeverallyFlag.SetValue(Severally);
            OLS01401.AtsAnytwoFlag.SetValue(AnyTwo);
            OLS01401.AtsOtherComment.SetValue(1, Other1);
            OLS01401.AtsOtherComment.SetValue(2, Other2);
        }

        [When(@"In OLS01401 I Add Power of Attorney Noting Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddPowerOfAttorneyNotingDetailsPart2(string Buy, string Sell, string Vote, string AppointSubstitute, string StampedIn, string Comment1, string Comment2, string LodgedBy)
        {
            OLS01401.PptBuyFlag.SetValue(Buy);
            OLS01401.PptSellFlag.SetValue(Sell);
            OLS01401.PptVoteFlag.SetValue(Vote);
            OLS01401.PptAppsubFlag.SetValue(AppointSubstitute);
            OLS01401.StampedINComment.SetValue(StampedIn);
            OLS01401.NotingComment70.SetValue(1, Comment1);
            OLS01401.NotingComment70.SetValue(2, Comment2);
            OLS01401.LodgedBYComment.SetValue(LodgedBy);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01301 I Add Third Party Payee Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddThirdPartyPayeeInstructions(string TranNO, string InstructionType, string PayeeeAddress1, string PayeeeAddress2, string PayeeeAddress3, string PayeeeAddress4, string PayeeeAddress5, string PayeeeAddress6, string PayeePostcode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
            OLS01301.TransNbrI.SetValue(TranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            OLS01301.InstructionType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.PayeeAddressLine.SetValue(1, PayeeeAddress1);
            OLS01301.PayeeAddressLine.SetValue(2, PayeeeAddress2);
            OLS01301.PayeeAddressLine.SetValue(3, PayeeeAddress3);
            OLS01301.PayeeAddressLine.SetValue(4, PayeeeAddress4);
            OLS01301.PayeeAddressLine.SetValue(5, PayeeeAddress5);
            OLS01301.PayeeAddressLine.SetValue(6, PayeeeAddress6);
            OLS01301.Postcode.SetValue(PayeePostcode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS06801 I Add Unconfirmed Deceased details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddUnconfirmedDeceasedDetails(string Tran, string TranDate, string HolderStatus)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06801");
            OLS06801.TransNumber.SetValue(Tran);
            OLS06801.TransDate.SetValue(TranDate);
            OLS06801.UnknownStatus1.SetValue(HolderStatus);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS04204 I add Wire Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void AddWireInstructions(string Tran, string CountryCode, string SWIFTCode, string AccountNumber, string AccountName, string PaymentCurrency, string BankCode, string BankName, string BankAddress1, string BankAddress2, string BankAddress3, string BankAddress4, string Phone)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
            OLS04201.TransNbrI.SetValue(Tran);
            OLS04201.CountryCode.SetValue(CountryCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04204");

            OLS04204.SwiftCode.SetValue(SWIFTCode);
            OLS04204.AccountNumber.SetValue(AccountNumber);
            OLS04204.AccountName.SetValue(AccountName);
            OLS04204.CurrencyCode.SetValue(PaymentCurrency);
            OLS04204.BankAddressLine.SetValue(1, BankName);
            OLS04204.BankAddressLine.SetValue(2, BankAddress1);
            OLS04204.BankAddressLine.SetValue(3, BankAddress2);
            OLS04204.BankAddressLine.SetValue(4, BankAddress3);
            OLS04204.BankAddressLine.SetValue(5, BankAddress4);

            if (CountryCode != "US" || CountryCode != "TW")
            {
                OLS04204.BankCode.SetValue(BankCode);
            }

            if (CountryCode == "TW")
            {
                OLS04204.ContactNumber.SetValue(Phone);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(); //cannot use this method as we are using this binding for negative and positive tests //DS
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "OLS04210")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
        }

        [When(@"In BLKSCH01 I enter the selection as ""(.*)""")]
        public void BLKSCH01EnterTheSelection(string Selection)
        {
            BLKSCH01.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01301 I Change Bulk Payment Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeBulkPaymentInstructions(string ChangeModify, string NewTranNO, string InstructionType, string NewBankSystem, string NewAccountName)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
            OLS01301.Action.SetValue(ChangeModify);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.TransNbrI.SetValue(NewTranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.BulkPaySystem.SetValue(NewBankSystem);
            OLS01301.PayeeAccountName.SetValue(NewAccountName);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01403 I Change Deceased Estate Noting Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeDeceasedEstateNotingDetailsPart1(string NewTranNO, string NewRegister, string NewDeceasedName, string NewDateOfDeath, string NewDeathCertSighted, string NewWillDated, string NewWillSightedDate, string NewSmallEstate, string NewProbateGrantedIn, string NewProbateGrantedOn, string NewProbateightedDate, string NewReSealedIn, string NewReSealedOn, string NewSec183, string NewSec121A, string NewConfirmationID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01403");
            OLS01403.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01403.TransNbrI.SetValue(NewTranNO);
            OLS01403.Register.SetValue(NewRegister);
            OLS01403.DeceasedNameLine.SetValue(NewDeceasedName);
            OLS01403.DeathDate.SetValue(NewDateOfDeath);
            OLS01403.DeathSightedDate.SetValue(NewDeathCertSighted);
            OLS01403.WillDate.SetValue(NewWillDated);
            OLS01403.WillSightedDate.SetValue(NewWillSightedDate);
            OLS01403.StatDecHeldFlag.SetValue(NewSmallEstate);
            OLS01403.ProbateGrantedIN.SetValue(NewProbateGrantedIn);
            OLS01403.ProbateGrantedDate.SetValue(NewProbateGrantedOn);
            OLS01403.ProbateSightedDate.SetValue(NewProbateightedDate);
            OLS01403.ResealedIN.SetValue(NewReSealedIn);
            OLS01403.ResealedDate.SetValue(NewReSealedOn);
            OLS01403.Sec183State.SetValue(NewSec183);
            OLS01403.SightedInd121a.SetValue(NewSec121A);
            OLS01403.ConfirmIDInd.SetValue(NewConfirmationID);
        }

        [When(@"In OLS01403 I Change Deceased Estate Noting Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeDeceasedEstateNotingDetailsPart2(string NewExecutor1, string NewExecutor2, string NewExecutor3, string NewComment1, string NewComment2, string NewComment3, string NewLodged)
        {
            OLS01403.Executor.SetValue(1, NewExecutor1);
            OLS01403.Executor.SetValue(2, NewExecutor2);
            OLS01403.DutyComment.SetValue(NewExecutor3);
            OLS01403.NotingComment70.SetValue(1, NewComment1);
            OLS01403.NotingComment70.SetValue(2, NewComment2);
            OLS01403.NotingComment70.SetValue(3, NewComment3);
            OLS01403.LodgedBYCommentX.SetValue(NewLodged);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01403 I change Deceased Estate Noting TranNo as ""(.*)""")]
        public void ChangeDeceasedEstateNotingTranNo(string Tran)
        {
            OLS01403.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01403.TransNbrI.SetValue(Tran);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01610 I Change FIN details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeFINDetails(string Tran, string OldFIN, string NewFIN, string ValidateFIN)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01610");
            OLS01610.TransNumber.SetValue(Tran);
            OLS01610.OldPin.SetValue(OldFIN);
            OLS01610.NewPin.SetValue(NewFIN);
            OLS01610.ValidateNewFin.SetValue(ValidateFIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01301 I Change Foreign Cheque Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeForeignChequeInstructions(string ChangeModify, string NewTranNO, string InstructionType, string NewCurrency)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
            OLS01301.Action.SetValue(ChangeModify);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.TransNbrI.SetValue(NewTranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.RequiredCurrency.SetValue(NewCurrency);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01901 I Change Holder Choices as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeHolderChoices(string Tran, string Action, string NewHolderChoice1, string NewHolderChoice2, string NewHolderChoice3, string NewHolderChoice4, string NewHolderChoice5, string NewHolderChoice6, string NewHolderChoice7, string NewHolderChoice8, string NewHolderChoice9)
        {
            OLS01901.Action.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01901.TransNbrI.SetValue(Tran);
            OLS01901.Method1.SetValue(NewHolderChoice1);
            OLS01901.Method2.SetValue(NewHolderChoice2);
            OLS01901.Method3.SetValue(NewHolderChoice3);
            OLS01901.Method4.SetValue(NewHolderChoice4);
            OLS01901.Method5.SetValue(NewHolderChoice5);
            OLS01901.Method6.SetValue(NewHolderChoice6);
            OLS01901.Method7.SetValue(NewHolderChoice7);
            OLS01901.Method8.SetValue(NewHolderChoice8);
            OLS01901.Method9.SetValue(NewHolderChoice9);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01201 I Change Holder details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeHolderDetails(string ModifyType, string Tran, string Type, string Postcode, string Taxcode, string Group, string VarField, string BrokerCode, string KeyModifier, string AlternateID, string Name, string Address1, string Address2, string Address3, string Address4, string Address5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01201");
            OLS01201.Action.SetValue(ModifyType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01201.TransNbrI.SetValue(Tran);
            OLS01201.HolderTypeCode.SetValue(Type);
            OLS01201.AusPostcode.SetValue(Postcode);
            OLS01201.HolderOtherTaxCode.SetValue(Taxcode);
            OLS01201.HolderGroupCode.SetValue(Group);
            OLS01201.VariableField.SetValue(VarField);
            if (OLS01201.BrokerCode.Exists()==true)
            {
                OLS01201.BrokerCode.SetValue(BrokerCode);
            }

            OLS01201.HolderKeyModifier.SetValue(KeyModifier);
            OLS01201.HolderAlternateID.SetValue(AlternateID);
            OLS01201.HnaLineCh1to30R.SetValue(1, Name);
            OLS01201.HnaLineCh1to30R.SetValue(2, Address1);
            OLS01201.HnaLineCh1to30R.SetValue(3, Address2);
            OLS01201.HnaLineCh1to30R.SetValue(4, Address3);
            OLS01201.HnaLineCh1to30R.SetValue(5, Address4);
            OLS01201.HnaLineCh1to30R.SetValue(6, Address5);
        }

        [When(@"I change holder extra details as below:")]
        public void ChangeHolderExtraDetails(Table data)
        {
            string TranNo = data.GetData("Tran No");
            string HomeTel = data.GetData("Home");
            string WorkTel = data.GetData("Work");
            string Mobile = data.GetData("Mobile");
            string Email = data.GetData("Email");

            WinFormsTestSteps.ClickOnWithInTheStaticDetailUpdatemMenu("holder extra details");
            OLS01801.Action.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01801.TransNbrI.SetValue(TranNo);
            OLS01801.HomePhone.SetValue(HomeTel);
            OLS01801.WorkPhone.SetValue(WorkTel);
            OLS01801.MobilePhone.SetValue(Mobile);
            OLS01801.Email.SetValue(Email);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();

            OLS00101.MenuItemEX.ClickField();
        }

        [When(@"In OLS01801 I Change Holder Extra Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeHolderExtraDetails(string ModifyType, string Tran, string ExtraHolderID, string HomeTell, string WorkTell, string Fax, string Mobile, string Email, string ReturnedEmail, string EmailFailCount, string Flag1, string Flag2, string Flag3, string Flag4, string Flag5, string Flag6, string Flag7, string Flag8, string Flag9)
        {
            OLS01801.Action.SetValue(ModifyType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01801");
            OLS01801.TransNbrI.SetValue(Tran);
            OLS01801.HolderExtraID.SetValue(ExtraHolderID);
            OLS01801.HomePhone.SetValue(HomeTell);
            OLS01801.WorkPhone.SetValue(WorkTell);
            OLS01801.FaxNumber.SetValue(Fax);
            OLS01801.MobilePhone.SetValue(Mobile);
            OLS01801.Email.SetValue(Email);
            OLS01801.EmailReturnDate.SetValue(ReturnedEmail);
            OLS01801.EmailFailCount.SetValue(EmailFailCount);
            OLS01801.EWFlag1.SetValue(Flag1);
            OLS01801.EWFlag2.SetValue(Flag2);
            OLS01801.EWFlag3.SetValue(Flag3);
            OLS01801.EWFlag4.SetValue(Flag4);
            OLS01801.EWFlag5.SetValue(Flag5);
            OLS01801.EWFlag6.SetValue(Flag6);
            OLS01801.EWFlag7.SetValue(Flag7);
            OLS01801.EWFlag8.SetValue(Flag8);
            OLS01801.EWFlag9.SetValue(Flag9);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I change holder name and address details as below:")]
        public void ChangeHolderNameAndAddress(Table data)
        {
            string TranNo = data.GetData("Tran No");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string PostCode = data.GetData("Post Code");

            //ClickOnWithInTheStaticDetailUpdatemMenu("name and address changes");
            OLS01201.ActionB.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01201.TransNbrI.SetValue(TranNo);
            OLS01201.HnaLineCh1to30R.SetValue(1, Name);
            OLS01201.HnaLineCh1to30R.SetValue(2, Address1);
            OLS01201.HnaLineCh1to30R.SetValue(3, Address2);
            OLS01201.HnaLineCh1to30R.SetValue(4, Address3);
            OLS01201.AusPostcode.SetValue(PostCode);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01210");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I change holder payee instructions as below:")]
        public void ChangeHolderPayeeInstructions(Table data)
        {
            string TranNo = data.GetData("Tran No");
            string Type = data.GetData("Type");
            string BSB1 = data.GetData("BSB1");
            string BSB2 = data.GetData("BSB2");
            string AccountNumber = data.GetData("Account Number");
            string AccountName = data.GetData("Account Name");

            WinFormsTestSteps.ClickOnWithInTheStaticDetailUpdatemMenu("payee instructions");

            OLS01301.Action.SetValue("M");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.TransNbrI.SetValue(TranNo);
            OLS01301.InstructionType.SetValue(Type);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01303");

            OLS01303.BankCodeAus1to3.SetValue(BSB1);
            OLS01303.BankCodeAus4to6.SetValue(BSB2);
            OLS01303.BankAccountAusNum.SetValue(AccountNumber);
            OLS01303.PayeeAccountName.SetValue(AccountName);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            OLS00101.MenuItemEX.ClickField();
        }

        [When(@"In OLS01404 I Change Noting as ""(.*)""")]
        public void ChangeNoting(string NewTranNO)
        {
            OLS01404.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01401.TransNbrI.SetValue(NewTranNO);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01404 I Change Noting Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeNotingDetails(string NewTranNO, string NewComment, string NewNotingLine1, string NewNotingLine2, string NewNotingLine3, string NewNotingLine4, string NewNotingLine5, string NewNotingLine6, string NewNotingLine7, string NewNotingLine8)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01404");
            OLS01404.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01404.TransNbrI.SetValue(NewTranNO);
            OLS01404.NotingComment50.SetValue(NewComment);
            OLS01404.NotingLine.SetValue(1, NewNotingLine1);
            OLS01404.NotingLine.SetValue(2, NewNotingLine2);
            OLS01404.NotingLine.SetValue(3, NewNotingLine3);
            OLS01404.NotingLine.SetValue(4, NewNotingLine4);
            OLS01404.NotingLine.SetValue(5, NewNotingLine5);
            OLS01404.NotingLine.SetValue(6, NewNotingLine6);
            OLS01404.NotingLine.SetValue(7, NewNotingLine7);
            OLS01404.NotingLine.SetValue(8, NewNotingLine8);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
        }

        [When(@"In OLS01303 I Change Payee Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangePayeeInstructions(string ChangeModify, string NewTranNO, string InstructionType, string NewBSB1, string NewBSB2, string NewAccountNbr, string NewAccountName, string NewNZBank, string NewNZBranch, string NewNZAccountNbr, string NewNZSuffix, string NewSortCode1, string NewSortCode2, string NewSortCode3, string NewRoutingNbr, string NewAccountType)
        {
            OLS01301.Action.SetValue(ChangeModify);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.TransNbrI.SetValue(NewTranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            switch (InstructionType.ToLower())
            {
                case "a":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01303");
                    OLS01303.BankCodeAus1to3.SetValue(NewBSB1);
                    OLS01303.BankCodeAus4to6.SetValue(NewBSB2);
                    OLS01303.BankAccountAusNum.SetValue(NewAccountNbr);
                    OLS01303.PayeeAccountName.SetValue(NewAccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "n":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01304");
                    OLS01304.BankCodeNzl1to2.SetValue(NewNZBank);
                    OLS01304.BankCodeNzl3to6.SetValue(NewNZBranch);
                    OLS01304.BankAccountNzl1to7.SetValue(NewNZAccountNbr);
                    OLS01304.BankAccountNzl8to10.SetValue(NewNZSuffix);
                    OLS01304.PayeeAccountName.SetValue(NewAccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "g":
                    OLS01306.BankCodeGbr1to2.SetValue(NewSortCode1);
                    OLS01306.BankCodeGbr3to4.SetValue(NewSortCode2);
                    OLS01306.BankCodeGbr5to6.SetValue(NewSortCode3);
                    OLS01306.BankAccountGbrNum.SetValue(NewAccountNbr);
                    OLS01306.PayeeAccountName.SetValue(NewAccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "u":
                    WinFormsTestSteps.ExpectToBeInTheScreen("OLS01305");
                    OLS01305.BankCodeUsa.SetValue(NewRoutingNbr);
                    OLS01305.BankAccountUsa.SetValue(NewAccountNbr);
                    OLS01305.BankAccountType.SetValue(NewAccountType);
                    OLS01305.PayeeAccountName.SetValue(NewAccountName);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    break;
            }
        }

        [When(@"In OLS01401 I Change Power of Attorney Noting Details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangePowerOfAttorneyNotingDetailsPart1(string NewTranNO, string NewRegister1, string NewRegister2, string NewDonorname1, string NewDonorname2, string NewAttorneys1, string NewAttorneys2, string NewAttorneys3, string NewAttorneys4, string NewAttorneys5, string NewPowerdated, string NewPowerNoted, string NewJointly, string NewSeverally, string NewAnyTwo, string NewOther1, string NewOther2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01401");
            OLS01401.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01401.TransNbrI.SetValue(NewTranNO);
            OLS01401.Reg.SetValue(1, NewRegister1);
            OLS01401.Reg.SetValue(2, NewRegister2);
            OLS01401.DonorNameLine.SetValue(1, NewDonorname1);
            OLS01401.DonorNameLine.SetValue(2, NewDonorname2);
            OLS01401.AttorneysName.SetValue(1, NewAttorneys1);
            OLS01401.AttorneysName.SetValue(2, NewAttorneys2);
            OLS01401.AttorneysName.SetValue(3, NewAttorneys3);
            OLS01401.AttorneysName.SetValue(4, NewAttorneys4);
            OLS01401.AttorneysName.SetValue(5, NewAttorneys5);
            OLS01401.PowerDated.SetValue(NewPowerdated);
            OLS01401.PowerNoted.SetValue(NewPowerNoted);
            OLS01401.AtsJointlyFlag.SetValue(NewJointly);
            OLS01401.AtsSeverallyFlag.SetValue(NewSeverally);
            OLS01401.AtsAnytwoFlag.SetValue(NewAnyTwo);
            OLS01401.AtsOtherComment.SetValue(1, NewOther1);
            OLS01401.AtsOtherComment.SetValue(2, NewOther2);
        }

        [When(@"In OLS01401 I Change Power of Attorney Noting Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangePowerOfAttorneyNotingDetailsPart2(string NewBuy, string NewSell, string NewVote, string NewAppointSubstitute, string NewStampedIn, string NewComment1, string NewComment2, string NewLodgedBy)
        {
            OLS01401.PptBuyFlag.SetValue(NewBuy);
            OLS01401.PptSellFlag.SetValue(NewSell);
            OLS01401.PptVoteFlag.SetValue(NewVote);
            OLS01401.PptAppsubFlag.SetValue(NewAppointSubstitute);
            OLS01401.StampedINComment.SetValue(NewStampedIn);
            OLS01401.NotingComment70.SetValue(1, NewComment1);
            OLS01401.NotingComment70.SetValue(2, NewComment2);
            OLS01401.LodgedBYComment.SetValue(NewLodgedBy);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01401 I change Power of Attorney Noting TranNo as ""(.*)""")]
        public void ChangePowerOfAttorneyNotingTranNo(string Tran)
        {
            OLS01401.Action.SetValue("C");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01401.TransNbrI.SetValue(Tran);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01301 I Change Third Party Payee Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeThirdPartyPayeeInstructions(string ChangeModify, string NewTranNO, string InstructionType, string NewPayeeeAddress1, string NewPayeeeAddress2, string NewPayeeeAddress3, string NewPayeeeAddress4, string NewPayeeeAddress5, string NewPayeeeAddress6, string NewPayeePostcode)
        {
            OLS01301.Action.SetValue(ChangeModify);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01301");
            OLS01301.TransNbrI.SetValue(NewTranNO);
            OLS01301.InstructionType.SetValue(InstructionType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01301.PayeeAddressLine.SetValue(1, NewPayeeeAddress1);
            OLS01301.PayeeAddressLine.SetValue(2, NewPayeeeAddress2);
            OLS01301.PayeeAddressLine.SetValue(3, NewPayeeeAddress3);
            OLS01301.PayeeAddressLine.SetValue(4, NewPayeeeAddress4);
            OLS01301.PayeeAddressLine.SetValue(5, NewPayeeeAddress5);
            OLS01301.PayeeAddressLine.SetValue(6, NewPayeeeAddress6);
            OLS01301.Postcode.SetValue(NewPayeePostcode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS04204 I Change Wire Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ChangeWireInstructions(string ChangeModify, string NewTran, string NewCountryCode, string NewSWIFTCode, string NewAccountNumber, string NewAccountName, string NewPaymentCurrency, string NewBankCode, string NewBankName, string NewBankAddress1, string NewBankAddress2, string NewBankAddress3, string NewBankAddress4, string Phone)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
            OLS04201.Action.SetValue(ChangeModify);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS04201.TransNbrI.SetValue(NewTran);
            OLS04201.CountryCode.SetValue(NewCountryCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04204");

            OLS04204.SwiftCode.SetValue(NewSWIFTCode);
            OLS04204.AccountNumber.SetValue(NewAccountNumber);
            OLS04204.AccountName.SetValue(NewAccountName);
            OLS04204.CurrencyCode.SetValue(NewPaymentCurrency);
            OLS04204.BankAddressLine.SetValue(1, NewBankName);
            OLS04204.BankAddressLine.SetValue(2, NewBankAddress1);
            OLS04204.BankAddressLine.SetValue(3, NewBankAddress2);
            OLS04204.BankAddressLine.SetValue(4, NewBankAddress3);
            OLS04204.BankAddressLine.SetValue(5, NewBankAddress4);

            if (NewCountryCode != "US" || NewCountryCode != "TW")
            {
                OLS04204.BankCode.SetValue(NewBankCode);
            }

            if (NewCountryCode == "TW")
            {
                OLS04204.ContactNumber.SetValue(Phone);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04210");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS15001 I Click on: ""(.*)"" with in the payment transactions menu")]
        public void ClickOnWithInThePaymentTransactionsMenu(string MenuOption)
        {
            //ExpectToBeInTheScreen("OLS15001");
            switch (MenuOption.ToLower())
            {
                case "payment cheque transactions":
                    Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                    OLS15001.MenuItemPay.ClickField();
                    break;

                case "pending payment maintenance":
                    OLS15001.MenuItemPpm.ClickField();
                    break;

                case "review approvals":
                    OLS15001.MenuItemRap.ClickField();
                    break;

                default:
                    break;
            }
        }

        [When(@"In OLS01801 I Delete Holder Extra Details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DeleteHolderExtraDetails(string NewModifyType, string NewTran, string ConfirmDelete)
        {
            OLS01801.Action.SetValue(NewModifyType);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01801");
            OLS01801.TransNbrI.SetValue(NewTran);
            OLS01801.Confirm.SetValue(ConfirmDelete);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01404 I Delete Noting Details as ""(.*)""")]
        public void DeleteNotingDetails(string NewTranNO1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01404");
            OLS01404.Action.SetValue("D");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01404.TransNbrI.SetValue(NewTranNO1);
            OLS01404.Confirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01303 I Delete Payee Instructions ""(.*)""")]
        public void DeletePayeeInstructions(string NewTranNO1)
        {
            OLS01301.Action.SetValue("D");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01301.TransNbrI.SetValue(NewTranNO1);
            OLS01301.Confirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01401 I Delete Power of Attorney Noting Details as ""(.*)""")]
        public void DeletePowerOfAttorneyNotingDetails(string NewTranNO1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01401");
            OLS01401.Action.SetValue("D");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01401.TransNbrI.SetValue(NewTranNO1);
            OLS01401.Confirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS04204 I Delete Wire Instructions as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void DeleteWireInstructions(string ChangeModify, string NewTran, string ConfirmDelete)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04201");
            OLS04201.Action.SetValue(ChangeModify);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS04201.Confirm.SetValue(ConfirmDelete);
            OLS04201.TransNbrI.SetValue(NewTran);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01102 I enter action to update Employee Details as ""(.*)""")]
        public void EnterActionToUpdateEmployeeDetails(string UpdateED)
        {
            //ExpectToBeInTheScreen("OLS01102");
            OLS01102.Action.SetValue("u");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01102.UpdateOption.SetValue(UpdateED);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLSB0701 I enter Bulk Transaction Report details as below:")]
        public void EnterBulkTransactionReportDetailsAs(Table data)
        {
            string SharePriceFrom = data.GetData("SharePriceFrom");
            string SharePriceTo = data.GetData("SharePriceTo");
            string SharePriceInterval = data.GetData("SharePriceInterval");
            string MaxUnits = data.GetData("MaxUnits");

            OLSB0701.SharePriceFrom.SetValue(SharePriceFrom);
            OLSB0701.SharePriceTO.SetValue(SharePriceTo);
            OLSB0701.SharePriceInt.SetValue(SharePriceInterval);
            OLSB0701.MaxNbrUnits.SetValue(MaxUnits);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03502 I Enter Charity Details as ""(.*)"" ""(.*)""")]
        public void EnterCharityDetails(string Tran, string ParticipationOption)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03502");
            OLS03502.TransNbrI.SetValue(Tran);
            OLS03502.ParticipationOption.SetValue(ParticipationOption);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01210 I enter confirmation details as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterConfirmationDetails(string UpdateTFN, string UpdateExtraDetails, string UpdateEmpDetails)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01210");
            if (OLS01210.UpdateTfn.Exists()==true)
            {
                OLS01210.UpdateTfn.SetValue(UpdateTFN);
            }

            OLS01210.UpdateExt.SetValue(UpdateExtraDetails);
            OLS01210.UpdateEmp.SetValue(UpdateEmpDetails);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (FormName == "OLS01231")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            if (FormName == "NCGUPD01")
            {
                NCGUPD01.Confirm.SetValue("R");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

        }

        [When(@"In OLS01630 I Enter CSN FIN Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterCSNFINDetails(string Tran, string HIN, string LoadFIN, string ValidateFIN)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01630");
            OLS01630.TransNumber.SetValue(Tran);
            //OLS01630.HolderIdentifier.SetValue(HIN);
            OLS01630.LoadFin.SetValue(LoadFIN);
            OLS01630.ValidateFin.SetValue(ValidateFIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01101 I enter following details as the update option as below:")]
        public void EnterfollowingDetailsAsTheUpdateOption(Table data)
        {
            //ExpectToBeInTheScreen("OLS01101"); -this method is used in other forms
            string Action = data.GetData("Action");
            string UpdateOption = data.GetData("UpdateOption");

            switch (Action.ToLower())
            {
                case "s":
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLS01101.SearchData.SetValue(UpdateOption);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "u":
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLS01101.UpdateOption.SetValue(UpdateOption);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;
            }
        }

        [When(@"In OLS01102 I enter following details as the update option ""(.*)"" ""(.*)""")]
        [When(@"In OLS01101 I enter following details as the update option ""(.*)"" ""(.*)""")]
        public void EnterFollowingDetailsAsTheUpdateOption(string Action, string UpdateOption)
        {
            //ExpectToBeInTheScreen("OLS01101");
            switch (Action.ToLower())
            {
                case "s":
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLS01101.SearchData.SetValue(UpdateOption);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();

                    break;

                case "u":
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLS01101.UpdateOption.SetValue(UpdateOption);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;
            }
        }

        [When(@"In OLS01202 I enter Holder details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterHolderDetails(string HIN, string Type, string Postcode, string Taxcode, string Group, string VarField, string BrokerCode, string KeyModifier, string AlternateID, string Name, string Address1, string Address2, string Address3, string Address4, string Address5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01202");
            OLS01202.HolderIdentifier.SetValue(HIN);
            OLS01202.HolderTypeCode.SetValue(Type);
            OLS01202.AusPostcode.SetValue(Postcode);
            OLS01202.HolderOtherTaxCode.SetValue(Taxcode);
            OLS01202.HolderGroupCode.SetValue(Group);
            OLS01202.VariableField.SetValue(VarField);
            OLS01202.BrokerCode.SetValue(BrokerCode);
            OLS01202.HolderKeyModifier.SetValue(KeyModifier);
            OLS01202.HolderAlternateID.SetValue(AlternateID);
            OLS01202.HnaLineCh1to30R.SetValue(1, Name);
            OLS01202.HnaLineCh1to30R.SetValue(2, Address1);
            OLS01202.HnaLineCh1to30R.SetValue(3, Address2);
            OLS01202.HnaLineCh1to30R.SetValue(4, Address3);
            OLS01202.HnaLineCh1to30R.SetValue(5, Address4);
            OLS01202.HnaLineCh1to30R.SetValue(6, Address5);
        }

        [When(@"In OLS01202 I enter Holder Flags details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void EnterHolderFlagsDetailAs(string Deceased, string Exception, string Suppress, string RetMail, string AReport, string RefID, string BirthDate, string StopTrade, string HVFFlag1, string HVFFlag2, string HVFFlag3, string HVFFlag4, string HVFFlag5)
        {
            OLS01201.Array1.SetValue(1, Deceased);
            OLS01201.Array1.SetValue(2, Exception);
            OLS01201.Array1.SetValue(3, Suppress);
            OLS01201.MailUnclaimedDate.SetValue(RetMail);
            OLS01201.HstAnnualReport.SetValue(AReport);
            OLS01201.ReferenceID.SetValue(RefID);
            OLS01202.BirthDate.SetValue(1, BirthDate);
            OLS01201.HstStopTrade.SetValue(StopTrade);
            OLS01201.HvfFlag.SetValue(1, HVFFlag1);
            OLS01201.HvfFlag.SetValue(2, HVFFlag2);
            OLS01201.HvfFlag.SetValue(3, HVFFlag3);
            OLS01201.HvfFlag.SetValue(4, HVFFlag4);
            OLS01201.HvfFlag.SetValue(5, HVFFlag5);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLSB0602 I enter Report Type as ""(.*)""")]
        public void EnterReportType(string ReportType)
        {
            OLSB0602.ReportType.SetValue(ReportType);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01403 enter Transaction number as ""(.*)""")]
        public void EnterTransactionNumber(string Tran)
        {
            OLS01403.TransNbrI.SetValue(Tran);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01620 I Generate new FIN as ""(.*)"" ""(.*)""")]
        public void GenerateNewFIN(string Tran, string GenerateFIN)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01620");
            OLS01620.TransNumber.SetValue(Tran);
            OLS01620.Confirm.SetValue(GenerateFIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I Go to Static Details update Menu")]
        public void GoToStaticDetailsUpdateMenu()
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("online data entry system");
            WinFormsTestSteps.ClickOnWithInTheOnlineDataEnterySystemMenu("static detail");
            OLS01101.Action.SetValue("U");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I go to the Static Details Menu")]
        public void GoToTheStaticDetailsMenu()
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("online data entry system");
            WinFormsTestSteps.ClickOnWithInTheOnlineDataEnterySystemMenu("static detail");
        }

        [When(@"In HCC00101 I enter the selection as ""(.*)""")]
        public void IEnterTheSelection(string Selection)
        {
            HCC00101.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01230 I enter update")]
        public void IEnterUpdate()
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01230");
            OLS01230.Update.SetValue("UPDATE");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"IN OLSCRTSA I continue with the following details:")]
        public void NOLSCRTSAContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (formName == "OLSCNXWN")
                Spartan.Core.WinForms.WinFormsDriver.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTSA");
            OLSCRTSA.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLSCRTSA.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLSCRTSA.SellClass.SetValue(1, table.Rows[0]["SellClass"]);
            OLSCRTSA.SellReference.SetValue(1, table.Rows[0]["SellReference"]);
            OLSCRTSA.SellBroker.SetValue(1, table.Rows[0]["SellBroker"]);
            if (table.Rows[0]["TransDate"] != "")
            {
                OLSCRTSA.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            }

            OLSCRTSA.SellSbn.SetValue(1, table.Rows[0]["SellSbn"]);
            //OLSCRTSA.TransNumber.SetValue(1, table.Rows[0]["SellSbn"]);
            OLSCRTSA.SellSearchName.SetValue(1, table.Rows[0]["SellSearchName"]);
            OLSCRTSA.SellCertID.SetValue(1, table.Rows[0]["SellCertID"]);
            OLSCRTSA.SellHolderID.SetValue(1, table.Rows[0]["SellHolderID"]);
            OLSCRTSA.SellReg.SetValue(1, table.Rows[0]["SellReg"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTTA");
        }

        [Then(@"In OLS01102 I should see Holder Address Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void OLS01102ShouldSeeHolderAddressDetails(string Name, string Address1, string Address2, string Address3, string Address4, string Address5)
        {
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(1, Name);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(2, Address1);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(3, Address2);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(4, Address3);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(5, Address4);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(6, Address5);
        }

        [Then(@"In OLS01102 I should see Holder Flags as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void OLS01102ShouldSeeHolderFlags(string Deceased, string Exception, string Suppress, string StopTrade, string RetMail, string ARReport, string BirthDate, string HVFFlag1, string HVFFlag2, string HVFFlag3, string HVFFlag4, string HVFFlag5)
        {
            OLS01102.Array1.ValidateFieldValue(1, Deceased);
            OLS01102.Array1.ValidateFieldValue(2, Exception);
            //OLS01102.Array1.ValidateFieldValue(2, Suppress);
            OLS01102.HstStopTrade.ValidateFieldValue(StopTrade);
            OLS01102.MailUnclaimedDate.ValidateFieldValue(RetMail);
            OLS01102.ARStatusDescription.ValidateFieldValue(ARReport);
            OLS01102.BirthDate.ValidateFieldValue(BirthDate);
            OLS01102.HvfFlag.ValidateFieldValue(1, HVFFlag1);
            OLS01102.HvfFlag.ValidateFieldValue(2, HVFFlag2);
            OLS01102.HvfFlag.ValidateFieldValue(3, HVFFlag3);
            OLS01102.HvfFlag.ValidateFieldValue(4, HVFFlag4);
            OLS01102.HvfFlag.ValidateFieldValue(5, HVFFlag5);
        }

        [Then(@"In OLS01102 I should see Holder Static Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void OLS01102ShouldSeeHolderStaticDetails(string Key, string HIN, string Type, string Postcode, string DPID, string Group, string BrokerCode, string VarField, string Register, string TaxCode, string KeyModifier, string AlternateID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
            OLS01102.HolderNameKey.ValidateFieldValue(Key);
            OLS01102.HolderIdentifier.ValidateFieldValue(HIN);
            OLS01102.HolderTypeCode.ValidateFieldValue(Type);
            OLS01102.AusPostcode.ValidateFieldValue(Postcode);
            OLS01102.HolderGroupCode.ValidateFieldValue(Group);
            OLS01102.VariableField.ValidateFieldValue(VarField);
            OLS01102.HolderOtherTaxCode.ValidateFieldValue(TaxCode);
            OLS01102.HolderKeyModifier.ValidateFieldValue(KeyModifier);
            OLS01102.HolderAlternateID.ValidateFieldValue(AlternateID);

            if (Postcode != "NZL")
            {
                OLS01102.Dpid.ValidateFieldValue(DPID);
            }

            if (!HIN.Contains("C"))
            {
                OLS01102.BrokerCode.ValidateFieldValue(BrokerCode);
                OLS01102.FastRegister.ValidateFieldValue(Register);
            }
        }

        [Then(@"In OLS01102 I should see Holder Warning as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void OLS01102ShouldSeeHolderWarning(string Warning1, string Warning2, string Warning3, string Warning4, string Warning5)
        {
            OLS01102.Warnings.ValidateFieldValue(1, Warning1);
            OLS01102.Warnings.ValidateFieldValue(2, Warning2);
            OLS01102.Warnings.ValidateFieldValue(3, Warning3);
            OLS01102.Warnings.ValidateFieldValue(4, Warning4);
            OLS01102.Warnings.ValidateFieldValue(5, Warning5);
        }

        /// <param name="table">data table</param>
        [Then(@"In OLS01102 I confirm the following details")]
        public void OLS01102StaticDetailSearchNameAndAddressDisplay(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
            //Validate Values
            OLS01102.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["HolderIdentifier"]);
            OLS01102.HolderTypeCode.ValidateFieldValue(1, table.Rows[0]["HolderTypeCode"]);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(1, table.Rows[0]["HnaLineCh1to30R"]);
            OLS01102.AusPostcode.ValidateFieldValue(1, table.Rows[0]["AusPostcode"]);
            OLS01102.HolderOtherTaxCode.ValidateFieldValue(1, table.Rows[0]["HolderOtherTaxCode"]);
            OLS01102.Dpid.ValidateFieldValue(1, table.Rows[0]["Dpid"]);
            OLS01102.HolderGroupCode.ValidateFieldValue(1, table.Rows[0]["HolderGroupCode"]);
            OLS01102.VariableField.ValidateFieldValue(1, table.Rows[0]["VariableField"]);
            OLS01102.BrokerCode.ValidateFieldValue(1, table.Rows[0]["BrokerCode"]);
            OLS01102.FastRegister.ValidateFieldValue(1, table.Rows[0]["FastRegister"]);
            OLS01102.HolderKeyModifier.ValidateFieldValue(1, table.Rows[0]["HolderKeyModifier"]);
            OLS01102.HolderAlternateID.ValidateFieldValue(1, table.Rows[0]["HolderAlternateId"]);
            OLS01102.Warnings.ValidateFieldValue(1, table.Rows[0]["Warnings"]);
            OLS01102.Array1.ValidateFieldValue(1, table.Rows[0]["Array1Ln14"]);
            OLS01102.Array1.ValidateFieldValue(2, table.Rows[0]["Array1Ln16"]);
            OLS01102.HstStopTrade.ValidateFieldValue(1, table.Rows[0]["HstStopTrade"]);
            OLS01102.HvfFlag.ValidateFieldValue(1, table.Rows[0]["HvfFlag1"]);
            OLS01102.HvfFlag.ValidateFieldValue(2, table.Rows[0]["HvfFlag2"]);
            OLS01102.ResidencyInd.ValidateFieldValue(1, table.Rows[0]["ResidencyInd"]);
            OLS01102.MailUnclaimedDate.ValidateFieldValue(1, table.Rows[0]["MailUnclaimedDate"]);
            OLS01102.ARStatusDescription.ValidateFieldValue(1, table.Rows[0]["ArStatusDescription"]);
            OLS01102.BirthDate.ValidateFieldValue(1, table.Rows[0]["BirthDate"]);
            OLS01102.Action.ValidateFieldValue(1, table.Rows[0]["Action"]);
            OLS01102.UpdateOption.ValidateFieldValue(1, table.Rows[0]["UpdateOption"]);
            OLS01102.Confirm.ValidateFieldValue(1, table.Rows[0]["Confirm"]);
            OLS01102.SearchData.ValidateFieldValue(1, table.Rows[0]["SearchData"]);
            OLS01102.SystemInfoFree6.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree6"]);
            OLS01102.SystemInfoFree4.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree4"]);
            OLS01102.SystemInfoFree7.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree7"]);
            OLS01102.SystemInfoFree5.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree5"]);
        }

        [Then(@"In OLS01103 I should see Holder Address Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void OLS01103ShouldSeeHolderAddressDetails(string Key, string HIN, string Type, string Name, string Address1, string Address2, string Address3, string Address4, string Address5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01103");
            OLS01103.HolderNameKey.ValidateFieldValue(Key);
            OLS01103.HolderIdentifier.ValidateFieldValue(HIN);
            OLS01103.HolderTypeCode.ValidateFieldValue(Type);
            OLS01103.HnaLine.ValidateFieldValue(1, Name);
            OLS01103.HnaLine.ValidateFieldValue(2, Address1);
            OLS01103.HnaLine.ValidateFieldValue(3, Address2);
            OLS01103.HnaLine.ValidateFieldValue(4, Address3);
            OLS01103.HnaLine.ValidateFieldValue(5, Address4);
            OLS01103.HnaLine.ValidateFieldValue(6, Address5);
        }

        [Then(@"In OLS01103 I should see Holder Warnings as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void OLS01103ShouldSeeHolderWarnings(string Warning1, string Warning2, string Warning3, string Warning4, string Warning5)
        {
            OLS01103.Warnings.ValidateFieldValue(1, Warning1);
            OLS01103.Warnings.ValidateFieldValue(2, Warning2);
            OLS01103.Warnings.ValidateFieldValue(3, Warning3);
            OLS01103.Warnings.ValidateFieldValue(4, Warning4);
            OLS01103.Warnings.ValidateFieldValue(5, Warning5);
        }

        /// <param name="table">data table</param>
        [When(@"IN OLS03001 I continue with the following details:")]
        public void OLS03001ContinueWithTheFollowingDetails(Table table)
        {
            OLS03001.TranNumber.SetValue(1, table.Rows[0]["TranNumber"]);
            OLS03001.FromNameKey.SetValue(1, table.Rows[0]["FromNameKey"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.HardWait(2);
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(); //cannot use waituntilready method as this binding is used in Positive and negative tests
            if (Spartan.Core.WinForms.WinFormsDriver.GetFormName() != "OLS03001")
            {
                WinFormsTestSteps.ExpectToBeInTheScreen("OLS03002");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                WinFormsTestSteps.ExpectToBeInTheScreen("OLS03001");
            }
        }

        [When(@"In OLS03501 I Enter Action Details as ""(.*)"" ""(.*)""")]
        public void OLS03501EnterActionDetails(string Action, string ActionClass)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03501");
            OLS03501.Action.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS03501.ActionClass.SetValue(ActionClass);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In OLS06801 I enter or confirm the following details")]
        public void OLS06801UpdateDeceasedStatus(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06801");
            //SetValues
            OLS06801.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            if (OLS06801.KnownStatus1.Exists() == true)
                OLS06801.KnownStatus1.SetValue(1, table.Rows[0]["KnownStatus1"]);
            if (OLS06801.KnownStatus2.Exists() == true)
                OLS06801.KnownStatus2.SetValue(1, table.Rows[0]["KnownStatus2"]);
            //Validate Values
            OLS06801.HnaLine.ValidateFieldValue(1, table.Rows[0]["NameAndAddress"]);
            OLS06801.TransDate.ValidateFieldValue(DateTime.Now.ToString("dd/MM/yyyy"));
            OLS06801.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["HolderIdentifier"]);
            OLS06801.Warnings.ValidateFieldValue(1, table.Rows[0]["Warnings"]);
            OLS06801.HolderTypeCode.ValidateFieldValue(1, table.Rows[0]["HolderType"]);
            OLS06801.HolderNameKey.ValidateFieldValue(1, table.Rows[0]["HolderNameKey"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS068CS");
        }

        [When(@"In OLS06801 I enter or confirm the following details for second JNT holder")]
        public void OLS06801IEnterOrConfirmTheFollowingDetailsForSecondJNTHolder(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06801");
            //SetValues
            OLS06801.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            if (OLS06801.KnownStatus1.Exists() == true)
                OLS06801.KnownStatus1.SetValue(1, table.Rows[0]["KnownStatus1"]);
            if (OLS06801.KnownStatus2.Exists() == true)
                OLS06801.KnownStatus2.SetValue(1, table.Rows[0]["KnownStatus2"]);
            //Validate Values
            OLS06801.HnaLine.ValidateFieldValue(1, table.Rows[0]["NameAndAddress"]);
            OLS06801.TransDate.ValidateFieldValue(DateTime.Now.ToString("dd/MM/yyyy"));
            OLS06801.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["HolderIdentifier"]);
            OLS06801.Warnings.ValidateFieldValue(1, table.Rows[0]["Warnings"]);
            OLS06801.HolderTypeCode.ValidateFieldValue(1, table.Rows[0]["HolderType"]);
            OLS06801.HolderNameKey.ValidateFieldValue(1, table.Rows[0]["HolderNameKey"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS068CS");
        }


        /// <param name="table">data table</param>
        [When(@"In OLS068CS I confirm the following details")]
        public void OLS068CSUpdateDeceasedStatusConfirmationScreen(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS068CS");
            //Validate Values
            OLS068CS.TransNumber.ValidateFieldValue(1, table.Rows[0]["TransNumber"]);
            OLS068CS.OrigHnaLine.ValidateFieldValue(1, table.Rows[0]["NameAndAddress"]);
            OLS068CS.TransDate.ValidateFieldValue(DateTime.Now.ToString("dd/MM/yyyy"));
            OLS068CS.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["HolderIdentifier"]);
            OLS068CS.Actions.ValidateFieldValue(1, table.Rows[0]["Actions"]);
            OLS068CS.HolderTypeCode.ValidateFieldValue(1, table.Rows[0]["HolderType"]);
            OLS068CS.DeceasedHolderName.ValidateFieldValue(1, table.Rows[0]["DeceasedHolderName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
        }

        /// <param name="table">data table</param>
        [When(@"In OLS11001 I continue with the following details:")]
        public void OLS11001IContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11001");
            if (table.Rows[0]["RecnRequired"] == "Y")
            {
                OLS11001.RecnRequired.SetValue(1, table.Rows[0]["RecnRequired"]);
                OLS11001.RecnRequired.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                OLS11001.FilenameBody.SetValue(1, table.Rows[0]["FileName"]);
            }
            else
            {
                OLS11001.RecnRequired.SetValue(1, table.Rows[0]["RecnRequired"]);
            }

            if (table.Rows[0]["ChequeFormat"] == "D")
            {
                OLS11001.ChequeFormat.SetValue(1, table.Rows[0]["ChequeFormat"]);
                OLS11001.ChequeFormat.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                OLS11001.FinaliseFileInd.SetValue(1, table.Rows[0]["FinaliseFileInd"]);
            }
            else if (table.Rows[0]["ChequeFormat"] == "S")
            {
                OLS11001.ChequeFormat.SetValue(1, table.Rows[0]["ChequeFormat"]);
                OLS11001.ChequeFormat.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                OLS11001.Origin.SetValue(1, table.Rows[0]["Origin"]);
            }

            else
            {
                OLS11001.ChequeFormat.SetValue(1, table.Rows[0]["ChequeFormat"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In OLS11002 I continue with the following details:")]
        public void OLS11002ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11002");
            OLS11002.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS11002.ReplacementDate.SetValue(1, table.Rows[0]["ReplacementDate"]);
            OLS11002.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS11002.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS11002.PayOrigRef.SetValue(1, table.Rows[0]["PayOrigRef"]);
            OLS11002.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [Then(@"In OLS11004 I confirm the following details")]
        public void OLS11004StaticDetailSearchNameAndAddressDisplay(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11004");
            //Validate Values
            OLS11004.TranTypeCode.ValidateFieldValue(1, table.Rows[0]["TranTypeCode"]);
            OLS11004.TranTypeDesc.ValidateFieldValue(1, table.Rows[0]["TranTypeDesc"]);
            OLS11004.TranTypeParent.ValidateFieldValue(1, table.Rows[0]["TranTypeParent"]);
            OLS11004.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["HolderIdentifier"]);
            //OLS11004.AddrLine.ValidateFieldValue(1, table.Rows[0]["AddrLine"]);
            OLS11004.DividendCode.ValidateFieldValue(1, table.Rows[0]["DividendCode"]);
            OLS11004.PaymentDate.ValidateFieldValue(1, table.Rows[0]["PaymentDate"]);
            //OLS11004.BulkID.ValidateFieldValue(1, table.Rows[0]["BulkID"]);
            OLS11004.SubPaymentCode.ValidateFieldValue(1, table.Rows[0]["SubPaymentCode"]);
            OLS11004.SubpGrossAmt.ValidateFieldValue(1, table.Rows[0]["SubpGrossAmt"]);
            //OLS11004.SubpTaxAmt.ValidateFieldValue(1, table.Rows[0]["SubpTaxAmt"]);
            OLS11004.SubpNettAmt.ValidateFieldValue(1, table.Rows[0]["SubpNettAmt"]);
            OLS11004.TotGrossAmt.ValidateFieldValue(1, table.Rows[0]["TotGrossAmt"]);
            OLS11004.TotNettAmt.ValidateFieldValue(1, table.Rows[0]["TotNettAmt"]);
            //OLS11004.TotTaxAmt.ValidateFieldValue(1, table.Rows[0]["TotTaxAmt"]);
            //OLS11004.Confirmation.ValidateFieldValue(1, table.Rows[0]["Confirmation"]);
            OLS11004.PaymentTypeDesc.ValidateFieldValue(1, table.Rows[0]["PaymentTypeDesc"]);
            //OLS11004.SubpErrorMessage.ValidateFieldValue(1, table.Rows[0]["SubpErrorMessage"]);
            //OLS11004.ConvNettAmt.ValidateFieldValue(1, table.Rows[0]["ConvNettAmt"]);
            //OLS11004.SubpOtaxAmt.ValidateFieldValue(1, table.Rows[0]["SubpOtaxAmt"]);
            //OLS11004.TotOtaxAmt.ValidateFieldValue(1, table.Rows[0]["TotOtaxAmt"]);
            OLS11004.BankCode.ValidateFieldValue(1, table.Rows[0]["BankCode"]);
            OLS11004.AccountNumber.ValidateFieldValue(1, table.Rows[0]["AccountNumber"]);
            //OLS11004.SystemInfoFree6.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree6"]);
            //OLS11004.SystemInfoFree7.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree7"]);
            //OLS11004.SystemInfoFree4.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree4"]);
            //OLS11004.SystemInfoFree5.ValidateFieldValue(1, table.Rows[0]["SystemInfoFree5"]);
        }

        [When(@"In OLS11010 I continue with the ""(.*)"" action")]
        public void OLS11010ContinueWithTheFollowingAction(string Option)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11010");
            switch (Option.ToLower())
            {
                case "transmit":
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                case "escape":
                    Spartan.Core.WinForms.WinFormsDriver.PressESC();
                    break;

                default:
                    break;
            }
        }

        [When(@"In OLSB1010 I enter the Action details as below:")]
        public void OLSB1010EnterTheActionDetails(Table data)
        {
            string Action = data.GetData("Action");
            string TranNo = data.GetData("TranNo");

            switch (Action.ToLower())
            {
                case "s":
                    OLSB1010.EnquiryAction.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLSB1010.SearchTransNbr.SetValue(TranNo);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    OLSB1010.EnquiryAction.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;
            }
        }

        [When(@"In OLSBLK01 I enter the selection as ""(.*)""")]
        public void OLSBLK01EnterTheSelection(string Selection)
        {
            OLSBLK01.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLSBLK02 I enter the selection as ""(.*)""")]
        public void OLSBLK02EnterTheSelection(string Selection)
        {
            OLSBLK02.Selection.SetValue(Selection);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"IN OLSCRTBF I continue with the following details:")]
        public void OLSCRTBFContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTBF");
            if (OLSCRTBF.TransferUnits.Exists() == true)
            {
                OLSCRTBF.TransferUnits.SetValue(1, table.Rows[0]["TransferUnits"]);
            }
            if (OLSCRTBF.BuyTransDate.Exists() == true)
            {
                OLSCRTBF.BuyTransDate.SetValue(1, table.Rows[0]["BuyTransDate"]);
            }
            if (OLSCRTBF.BuyCertID.Exists() == true)
            {
                OLSCRTBF.BuyCertID.SetValue(1, table.Rows[0]["BuyCertID"]);
            }
            if (OLSCRTBF.BuyInstructions.Exists() == true)
            {
                OLSCRTBF.BuyInstructions.SetValue(1, table.Rows[0]["BuyInstructions1"]);
                OLSCRTBF.BuyInstructions.SetValue(2, table.Rows[0]["BuyInstructions2"]);
                OLSCRTBF.BuyInstructions.SetValue(3, table.Rows[0]["BuyInstructions3"]);
                OLSCRTBF.BuyInstructions.SetValue(4, table.Rows[0]["BuyInstructions4"]);
                OLSCRTBF.BuyInstructions.SetValue(5, table.Rows[0]["BuyInstructions5"]);
            }
            if (OLSCRTBF.BuySplitNbr1to5.Exists() == true)
            {
                OLSCRTBF.BuySplitNbr1to5.SetValue(1, table.Rows[0]["BuySplitNbr1to51"]);
                OLSCRTBF.BuySplitNbr1to5.SetValue(2, table.Rows[0]["BuySplitNbr1to52"]);
                OLSCRTBF.BuySplitNbr1to5.SetValue(3, table.Rows[0]["BuySplitNbr1to53"]);
            }
            if (OLSCRTBF.BuySplitUnits1to5.Exists() == true)
            {
                OLSCRTBF.BuySplitUnits1to5.SetValue(1, table.Rows[0]["BuySplitUnits1to51"]);
                OLSCRTBF.BuySplitUnits1to5.SetValue(2, table.Rows[0]["BuySplitUnits1to52"]);
                OLSCRTBF.BuySplitUnits1to5.SetValue(3, table.Rows[0]["BuySplitUnits1to53"]);
            }

            if (OLSCRTBF.HoldBalance.Exists() == true)
            {
                OLSCRTBF.HoldBalance.SetValue(1, table.Rows[0]["HoldBalance"]);
            }
            if (OLSCRTBF.MarkingNumber.Exists() == true)
            {
                OLSCRTBF.MarkingNumber.SetValue(1, table.Rows[0]["MarkingNumber"]);
            }
            if (OLSCRTBF.ReissueBal.Exists() == true)
            {
                OLSCRTBF.ReissueBal.SetValue(1, table.Rows[0]["ReissueBal"]);
            }
            if (OLSCRTBF.ReissTOSellBroker.Exists() == true)
            {
                OLSCRTBF.ReissTOSellBroker.SetValue(1, table.Rows[0]["ReissTOSellBroker"]);
            }
            if (OLSCRTBF.UncertBuyReg.Exists() == true)
            {
                OLSCRTBF.UncertBuyReg.SetValue(1, table.Rows[0]["UncertBuyReg"]);
            }


            Spartan.Core.WinForms.WinFormsDriver.Transmit();
           // Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FormName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (FormName == "OLSCUMWN")
            {
                OLSCUMWN.Continue.SetValue("Y");
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }

           // Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            //WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTSA");
        }

        /// <param name="table">data table</param>
        [When(@"IN OLSCRTTA I continue with the following details:")]
        public void OLSCRTTAContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTTA");
            OLSCRTTA.BuyClass.SetValue(1, table.Rows[0]["BuyClass"]);
            OLSCRTTA.BuyBroker.SetValue(1, table.Rows[0]["BuyBroker"]);
            OLSCRTTA.BuySbn.SetValue(1, table.Rows[0]["BuySbn"]);
            OLSCRTTA.BuyReg.SetValue(1, table.Rows[0]["BuyReg"]);
            if (OLSCRTTA.BuyReference.Exists() == true)
            {
                OLSCRTTA.BuyReference.SetValue(1, table.Rows[0]["BuyReference"]);
            }

            OLSCRTTA.BuySearchName.SetValue(1, table.Rows[0]["BuySearchName"]);
            if (table.Rows[0]["SellCert1"] !="")
            {
                OLSCRTTA.SellCert.SetValue(1, table.Rows[0]["SellCert1"]);
                OLSCRTTA.SellCert.SetValue(2, table.Rows[0]["SellCert2"]);
                OLSCRTTA.SellCert.SetValue(3, table.Rows[0]["SellCert3"]);
            }
            if (table.Rows[0]["SellUnits1"] != "")
            {
                OLSCRTTA.SellUnits.SetValue(1, table.Rows[0]["SellUnits1"]);
                OLSCRTTA.SellUnits.SetValue(2, table.Rows[0]["SellUnits2"]);
                OLSCRTTA.SellUnits.SetValue(3, table.Rows[0]["SellUnits3"]);
            }
            if (table.Rows[0]["SellDate1"] !="")
            {
                OLSCRTTA.SellDate.SetValue(1, table.Rows[0]["SellDate1"]);
                OLSCRTTA.SellDate.SetValue(2, table.Rows[0]["SellDate2"]);
                OLSCRTTA.SellDate.SetValue(3, table.Rows[0]["SellDate3"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTBF");
        }

        /// <param name="table">data table</param>
        [When(@"IN OLSCRTUU I continue with the following details:")]
        public void OLSCRTUUContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTUU");
            OLSCRTUU.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLSCRTUU.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);

            if (OLSCRTUU.BuyClass.Exists()== true)
            {
                OLSCRTUU.BuyClass.SetValue(1, table.Rows[0]["BuyClass"]);
                OLSCRTUU.BuySbn.SetValue(1, table.Rows[0]["BuySbn"]);
                OLSCRTUU.BuySearchName.SetValue(1, table.Rows[0]["BuySearchName"]);
                OLSCRTUU.BuyReference.SetValue(1, table.Rows[0]["BuyReference"]);
                OLSCRTUU.BuyBroker.SetValue(1, table.Rows[0]["BuyBroker"]);
                OLSCRTUU.BuyTransDate.SetValue(1, table.Rows[0]["BuyTransDate"]);

            }
            else
            {
                OLSCRTUU.SellClass.SetValue(1, table.Rows[0]["BuyClass"]);
                OLSCRTUU.SellSbn.SetValue(1, table.Rows[0]["BuySbn"]);
                OLSCRTUU.SellSearchName.SetValue(1, table.Rows[0]["BuySearchName"]);
                OLSCRTUU.SellReference.SetValue(1, table.Rows[0]["BuyReference"]);
                OLSCRTUU.SellBroker.SetValue(1, table.Rows[0]["BuyBroker"]);
                OLSCRTUU.TransDate.SetValue(1, table.Rows[0]["BuyTransDate"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        /// <param name="table">data table</param>
        [When(@"IN OLSCRTUX I continue with the following details:")]
        public void OLSCRTUXContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTUX");
            OLSCRTUX.ConfirmUnits.SetValue(1, table.Rows[0]["ConfirmUnits"]);
            if (OLSCRTUX.UncertBuyReg.Exists() == true)
                OLSCRTUX.UncertBuyReg.SetValue(1, table.Rows[0]["BuyReg"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In Online Data Entry System I enter search option as ""(.*)"" ""(.*)""")]
        public void OnlineDataEntrySystemIEnterSearchOptionAs(string Action, string UpdateOption)
        {
            //ExpectToBeInTheScreen("OLS01101");
            switch (Action.ToLower())
            {
                case "s":
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLS01101.SearchData.SetValue(UpdateOption);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();

                    break;

                case "u":
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                    OLS01101.UpdateOption.SetValue(UpdateOption);

                    if (OLS01101.Confirm.Exists()==true)
                    {
                        OLS01101.Confirm.SetValue("Y");
                    }
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;

                default:
                    OLS01101.Action.SetValue(Action);
                    Spartan.Core.WinForms.WinFormsDriver.Transmit();
                    break;
            }
        }

        [When(@"I search ""(.*)"" in Static Details update Menu")]
        public void SearchInStaticDetailsUpdateMenu(string holderID)
        {
            WinFormsTestSteps.ClickWithinTheSystemMenu("online data entry system");
            WinFormsTestSteps.ClickOnWithInTheOnlineDataEnterySystemMenu("static detail");
            OLS01101.Action.SetValue("S");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01101.SearchData.SetValue(holderID);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            OLS01101.Action.SetValue("U");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"OLS01101 I Search the Holder ""(.*)""")]
        public void SearchTheHolder(string HIN)
        {
            OLS01101.Action.SetValue("S");
            OLS01101.SearchData.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"OLS01101 I Search the Holder as ""(.*)""")]
        public void SearchTheHolderAs(string HIN)
        {
            //ExpectToBeInTheScreen("OLS01101");
            OLS01101.Action.SetValue("S");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01101.SearchData.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        /// <param name="table">data table</param>
        [When(@"In SELTRN20 I continue with the following details:")]
        public void SELTRN20ContinueWithTheFollowingDetails(Table table)
        {
            SELTRN20.SelCode.SetValue(1, table.Rows[0]["SelCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            //WinFormsTestSteps.ExpectToBeInTheScreen("OLS03001");
        }

        [Then(@"In OLS03501 I should see Charity Election Change details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeCharityElectionChangeDetails(string ActionClass, string ParticipationOption, string ParticipationLevel, string CharityCode, string ApplicationDate, string LastChangeDate, string Status)
        {
            //ApplicationDate = Spartan.Core.WinForms.WinFormsDriver.CurrentDate();

            //Need to add current date in new Spatan Frmaework
            //LastChangeDate = Spartan.Core.WinForms.WinFormsDriver.CurrentDate();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03501");
            OLS03501.ClassCode.ValidateFieldValue(1, ActionClass);
            OLS03501.ParticipationOption.ValidateFieldValue(1, ParticipationOption);
            OLS03501.ParticipationLevel.ValidateFieldValue(1, ParticipationLevel);
            OLS03501.CharityCode.ValidateFieldValue(1, CharityCode);
            OLS03501.ApplicationDate.ValidateFieldValue(1, ApplicationDate);
            OLS03501.LastChangeDate.ValidateFieldValue(1, LastChangeDate);
            OLS03501.StatusDescription.ValidateFieldValue(1, Status);
        }

        [Then(@"In OLS03501 I should see Charity Election Update details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeCharityElectionUpdateDetails(string ActionClass, string ParticipationOption, string ParticipationLevel, string CharityCode, string ApplicationDate, string LastChangeDate, string Status)
        {
            //Need to add current date in new Spatan Frmaework
            //ApplicationDate = Spartan.Core.WinForms.WinFormsDriver.CurrentDate();
            //LastChangeDate = Spartan.Core.WinForms.WinFormsDriver.CurrentDate();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03501");
            OLS03502.ClassCode.ValidateFieldValue(1, ActionClass);
            OLS03501.ParticipationOption.ValidateFieldValue(1, ParticipationOption);
            OLS03501.ParticipationLevel.ValidateFieldValue(1, ParticipationLevel);
            OLS03501.CharityCode.ValidateFieldValue(1, CharityCode);
            OLS03501.ApplicationDate.ValidateFieldValue(1, ApplicationDate);
            OLS03501.LastChangeDate.ValidateFieldValue(1, LastChangeDate);
            OLS03502.StatusDescription.ValidateFieldValue(1, Status);
        }

        [Then(@"In OLS03502 I Should see Charity Election Update Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeCharityElectionUpdateDetails(string ActionClass, string ParticipationOption, string ParticipationLevel, string CharityCode, string ApplicationDate, string LastChangeDate)
        {
            //Need to add current date in new Spatan Frmaework
            //ApplicationDate = Spartan.Core.WinForms.WinFormsDriver.CurrentDate();
            //LastChangeDate = Spartan.Core.WinForms.WinFormsDriver.CurrentDate();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03502");
            OLS03502.ClassCode.ValidateFieldValue(ActionClass);
            OLS03502.ParticipationOption.ValidateFieldValue(ParticipationOption);
            OLS03502.ParticipationLevel.ValidateFieldValue(1, ParticipationLevel);
            OLS03502.CharityCode.ValidateFieldValue(1, CharityCode);
            OLS03502.ApplicationDate.ValidateFieldValue(ApplicationDate);
            OLS03502.LastChangeDate.ValidateFieldValue(LastChangeDate);
        }

        [Then(@"In OLS01112 I should see Deceased Estate Noting details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDeceasedEstateNotingDetails(string DeceasedName, string DateOfDeath, string ProbateGrantedIn, string ProbateGrantedOn, string ProbateightedDate, string ReSealedIn, string ReSealedOn, string Sec183, string Executor1, string Executor2, string Executor3, string DeathCertSighted, string WillDated, string WillSightedDate, string SmallEstate, string Comment1, string Comment2, string Comment3, string Lodged)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01112");
            OLS01112.DeceasedNameLine.ValidateFieldValue(DeceasedName);
            OLS01112.DeathDate.ValidateFieldValue(DateOfDeath);
            OLS01112.ProbateGrantedIN.ValidateFieldValue(ProbateGrantedIn);
            OLS01112.ProbateGrantedDate.ValidateFieldValue(ProbateGrantedOn);
            OLS01112.ProbateSightedDate.ValidateFieldValue(ProbateightedDate);
            OLS01112.ResealedIN.ValidateFieldValue(ReSealedIn);
            OLS01112.ResealedDate.ValidateFieldValue(ReSealedOn);
            OLS01112.Sec183State.ValidateFieldValue(Sec183);
            OLS01112.Executor.ValidateFieldValue(1, Executor1);
            OLS01112.Executor.ValidateFieldValue(2, Executor1);
            OLS01112.DutyComment.ValidateFieldValue(Executor3);
            OLS01112.DeathSightedDate.ValidateFieldValue(DeathCertSighted);
            OLS01112.WillSightedDate.ValidateFieldValue(WillDated);
            OLS01112.WillSightedDate.ValidateFieldValue(WillSightedDate);
            OLS01112.StatDecHeldFlag.ValidateFieldValue(SmallEstate);
            OLS01112.NotingComment70.ValidateFieldValue(1, Comment1);
            OLS01112.NotingComment70.ValidateFieldValue(2, Comment2);
            OLS01112.NotingComment70.ValidateFieldValue(3, Comment3);
            OLS01112.LodgedBYComment.ValidateFieldValue(Lodged);
        }

        [Then(@"In OLS06807 I should see Deceased Estate Pack Selection options as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeDeceasedEstatePackSelectionOptions(string Probate, string DeathCert, string Will, string Reseal, string A121, string B1071, string SmallEstate1, string ConfirmID)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06807");
            OLS06807.Probate.ValidateFieldValue(Probate);
            OLS06807.DeathCert.ValidateFieldValue(DeathCert);
            OLS06807.Will.ValidateFieldValue(Will);
            OLS06807.ResealProb.ValidateFieldValue(Reseal);
            OLS06807.a121.ValidateFieldValue(A121);
            OLS06807.b1071.ValidateFieldValue(B1071);
            OLS06807.SmallEst.ValidateFieldValue(SmallEstate1);
            OLS06807.ConfirmID.ValidateFieldValue(ConfirmID);
        }

        [Then(@"In OLS01103 I should see Holder Bulk Payment Instructions as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderBulkPaymentInstructions(string BankSystem, string AccountName, string PayeeAddress)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01103");
            OLS01103.BulkPaySystem.ValidateFieldValue(BankSystem);
            OLS01103.PayeeAccountName.ValidateFieldValue(AccountName);
            OLS01103.PayeeAddressLine.ValidateFieldValue(PayeeAddress);
        }

        [Then(@"In OLS01801 I should see Holder Extra Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderExtraDetails(string ExtraHolderID, string HomeTell, string WorkTell, string Fax, string Mobile, string Email, string Flag1, string Flag2, string Flag3, string Flag4, string Flag5, string Flag6, string Flag7, string Flag8, string Flag9)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01801");
            OLS01801.HolderExtraID.ValidateFieldValue(ExtraHolderID);
            OLS01801.HomePhone.ValidateFieldValue(HomeTell);
            OLS01801.WorkPhone.ValidateFieldValue(WorkTell);
            OLS01801.FaxNumber.ValidateFieldValue(Fax);
            OLS01801.MobilePhone.ValidateFieldValue(Mobile);
            OLS01801.Email.ValidateFieldValue(Email);
            OLS01801.EWFlag1.ValidateFieldValue(Flag1);
            OLS01801.EWFlag2.ValidateFieldValue(Flag2);
            OLS01801.EWFlag3.ValidateFieldValue(Flag3);
            OLS01801.EWFlag4.ValidateFieldValue(Flag4);
            OLS01801.EWFlag5.ValidateFieldValue(Flag5);
            OLS01801.EWFlag6.ValidateFieldValue(Flag6);
            OLS01801.EWFlag7.ValidateFieldValue(Flag7);
            OLS01801.EWFlag8.ValidateFieldValue(Flag8);
            OLS01801.EWFlag9.ValidateFieldValue(Flag9);
        }

        [Then(@"In OLS01801 I should see Holder Extra Details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderExtraDetailsPart2(string ReturnedEmail, string EmailFailCount, string Flag1Desc, string Flag2Desc, string Flag3Desc, string Flag4Desc, string Flag5Desc, string Flag6Desc, string Flag7Desc, string Flag8Desc, string Flag9Desc)
        {
            OLS01801.EmailReturnDate.ValidateFieldValue(ReturnedEmail);
            OLS01801.EmailFailCount.ValidateFieldValue(EmailFailCount);
            OLS01801.EWFlagDesc1.ValidateFieldValue(Flag1Desc);
            OLS01801.EWFlagDesc2.ValidateFieldValue(Flag2Desc);
            OLS01801.EWFlagDesc3.ValidateFieldValue(Flag3Desc);
            OLS01801.EWFlagDesc4.ValidateFieldValue(Flag4Desc);
            OLS01801.EWFlagDesc5.ValidateFieldValue(Flag5Desc);
            OLS01801.EWFlagDesc6.ValidateFieldValue(Flag6Desc);
            OLS01801.EWFlagDesc7.ValidateFieldValue(Flag7Desc);
            OLS01801.EWFlagDesc8.ValidateFieldValue(Flag8Desc);
            OLS01801.EWFlagDesc9.ValidateFieldValue(Flag9Desc);
        }

        [Then(@"In OLS01103 I should see Holder Payee Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderPayeeDetails(string PayeeAddress1, string PayeeAddress2, string PayeeAddress3, string PayeeAddress4, string PayeeAddress5, string PayeeAddress6, string PayeePostcode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01103");
            OLS01103.PayeeAddressLine.ValidateFieldValue(1, PayeeAddress1);
            OLS01103.PayeeAddressLine.ValidateFieldValue(2, PayeeAddress2);
            OLS01103.PayeeAddressLine.ValidateFieldValue(3, PayeeAddress3);
            OLS01103.PayeeAddressLine.ValidateFieldValue(4, PayeeAddress4);
            OLS01103.PayeeAddressLine.ValidateFieldValue(5, PayeeAddress5);
            OLS01103.PayeeAddressLine.ValidateFieldValue(6, PayeeAddress6);
        }

        [Then(@"In OLS01102 I should see Holder Static Details below:")]
        public void ShouldSeeHolderStaticDetails(Table data)
        {
            string Key = data.GetData("Key");
            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");
            string Address3 = data.GetData("Address3");
            string Address4 = data.GetData("Address4");
            string Postcode = data.GetData("Postcode");

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
            OLS01102.HolderNameKey.ValidateFieldValue(Key);
            OLS01102.HolderIdentifier.ValidateFieldValue(HIN);
            OLS01102.HolderTypeCode.ValidateFieldValue(Type);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(1, Name);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(2, Address1);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(3, Address2);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(4, Address3);
            OLS01102.HnaLineCh1to30R.ValidateFieldValue(5, Address4);
            OLS01102.AusPostcode.ValidateFieldValue(Postcode);
        }

        [Then(@"In OLS01102 I should see Holder UD Static details as ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderUDStaticDetails(string Type, string Deceased)
        {
            OLS01102.HolderTypeCode.ValidateFieldValue(Type);
            OLS01102.Array1.ValidateFieldValue(1, Deceased);
        }

        [Then(@"In OLS01106 I should see Holder Wire Instructions as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeHolderWireInstructions(string CountryCode, string SWIFTCode, string AccountNumber, string AccountName, string PaymentCurrency, string BankCode, string BankName, string BankAddress1, string BankAddress2, string BankAddress3, string BankAddress4)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01106");
            OLS01106.CountryCode.ValidateFieldValue(CountryCode);
            OLS01106.SwiftCode.ValidateFieldValue(SWIFTCode);
            OLS01106.AccountNumber.ValidateFieldValue(AccountNumber);
            OLS01106.AccountName.ValidateFieldValue(AccountName);
            OLS01106.CurrencyCode.ValidateFieldValue(PaymentCurrency);
            OLS01106.BankAddressLine.ValidateFieldValue(1, BankName);
            OLS01106.BankAddressLine.ValidateFieldValue(2, BankAddress1);
            OLS01106.BankAddressLine.ValidateFieldValue(3, BankAddress2);
            OLS01106.BankAddressLine.ValidateFieldValue(4, BankAddress3);
            OLS01106.BankAddressLine.ValidateFieldValue(5, BankAddress4);

            if (CountryCode != "US" || CountryCode != "TW")
            {
                OLS01106.BankCode.ValidateFieldValue(BankCode);
            }
        }

        [Then(@"In OLS01113 I should see Noting details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeNotingDetails(string NotingNbr, string HIN, string Comment, string NotingLine1, string NotingLine2, string NotingLine3, string NotingLine4, string NotingLine5, string NotingLine6, string NotingLine7, string NotingLine8)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01113");
            OLS01113.NotingNumber.ValidateFieldValue(NotingNbr);
            OLS01113.HolderIdentifier.ValidateFieldValue(HIN);
            OLS01113.NotingComment50.ValidateFieldValue(Comment);
            OLS01113.NotingLine.ValidateFieldValue(1, NotingLine1);
            OLS01113.NotingLine.ValidateFieldValue(2, NotingLine2);
            OLS01113.NotingLine.ValidateFieldValue(3, NotingLine3);
            OLS01113.NotingLine.ValidateFieldValue(4, NotingLine4);
            OLS01113.NotingLine.ValidateFieldValue(5, NotingLine5);
            OLS01113.NotingLine.ValidateFieldValue(6, NotingLine6);
            OLS01113.NotingLine.ValidateFieldValue(7, NotingLine7);
            OLS01113.NotingLine.ValidateFieldValue(8, NotingLine8);
        }

        [Then(@"In OLS01104 I should see Notings Display menu as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeNotingsDisplayMenu(string P1, string P2, string P3, string D1, string D2, string D3, string D4, string D5, string N1, string N2, string N3, string N4, string N5)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01104");
            OLS01104.MenuItemP1.ValidateFieldValue(P1);
            OLS01104.MenuItemP2.ValidateFieldValue(P2);
            OLS01104.MenuItemP3.ValidateFieldValue(P3);
            OLS01104.MenuItemD1.ValidateFieldValue(D1);
            OLS01104.MenuItemD2.ValidateFieldValue(D2);
            OLS01104.MenuItemD3.ValidateFieldValue(D3);
            OLS01104.MenuItemD4.ValidateFieldValue(D4);
            OLS01104.MenuItemD5.ValidateFieldValue(D5);
            OLS01104.MenuItemN1.ValidateFieldValue(N1);
            OLS01104.MenuItemN2.ValidateFieldValue(N2);
            OLS01104.MenuItemN3.ValidateFieldValue(N3);
            OLS01104.MenuItemN4.ValidateFieldValue(N4);
            OLS01104.MenuItemN5.ValidateFieldValue(N5);
        }

        [Then(@"In OLS01103 I should see Payee Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePayeeDetails(string BankSystem, string BSB, string AccountNbr, string AccountName, string PayeeAddress1, string PayeeAddress2, string PayeeAddress3, string PayeeAddress4)
        {
            OLS01103.BulkPaySystem.ValidateFieldValue(BankSystem);
            OLS01103.BankCode.ValidateFieldValue(BSB);
            OLS01103.AccountNumberOutput.ValidateFieldValue(AccountNbr);
            OLS01103.PayeeAccountName.ValidateFieldValue(AccountName);
            OLS01103.PayeeAddressLine.ValidateFieldValue(1, PayeeAddress1);
            OLS01103.PayeeAddressLine.ValidateFieldValue(2, PayeeAddress2);
            OLS01103.PayeeAddressLine.ValidateFieldValue(3, PayeeAddress3);
            OLS01103.PayeeAddressLine.ValidateFieldValue(4, PayeeAddress4);
        }

        [Then(@"In OLS01110 I should see Power of Attorney Noting details Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePowerOfAttorneyNotingDetailsPart1(string Donorname1, string Donorname2, string Attorneys1, string Attorneys2, string Attorneys3, string Attorneys4, string Attorneys5, string Powerdated, string PowerNoted, string Jointly, string Severally, string AnyTwo, string Other1, string Other2)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01110");
            OLS01110.DonorNameLine.ValidateFieldValue(1, Donorname1);
            OLS01110.DonorNameLine.ValidateFieldValue(2, Donorname2);
            //OLS01110.AttorneysName.ValidateFieldValue(0, Attorneys1);
            OLS01110.AttorneysName.ValidateFieldValue(1, Attorneys2);
            OLS01110.AttorneysName.ValidateFieldValue(2, Attorneys3);
            OLS01110.AttorneysName.ValidateFieldValue(3, Attorneys4);
            OLS01110.AttorneysName.ValidateFieldValue(5, Attorneys5);
            OLS01110.PowerDated.ValidateFieldValue(Powerdated);
            OLS01110.PowerNoted.ValidateFieldValue(PowerNoted);
            OLS01110.AtsJointlyFlag.ValidateFieldValue(Jointly);
            OLS01110.AtsSeverallyFlag.ValidateFieldValue(Severally);
            OLS01110.AtsAnytwoFlag.ValidateFieldValue(AnyTwo);
            OLS01110.AtsOtherComment.ValidateFieldValue(1, Other1);
            OLS01110.AtsOtherComment.ValidateFieldValue(2, Other2);
        }

        [Then(@"In OLS01110 I should see Power of Attorney Noting details Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeePowerOfAttorneyNotingDetailsPart2(string Buy, string Sell, string Vote, string AppointSubstitute, string StampedIn, string Comment1, string Comment2, string LodgedBy)
        {
            OLS01110.PptBuyFlag.ValidateFieldValue(Buy);
            OLS01110.PptSellFlag.ValidateFieldValue(Sell);
            OLS01110.PptVoteFlag.ValidateFieldValue(Vote);
            OLS01110.PptAppsubFlag.ValidateFieldValue(AppointSubstitute);
            OLS01110.StampedINComment.ValidateFieldValue(StampedIn);
            OLS01110.NotingComment70.ValidateFieldValue(1, Comment1);
            OLS01110.NotingComment70.ValidateFieldValue(2, Comment2);
            OLS01110.LodgedBYComment.ValidateFieldValue(LodgedBy);
        }

        [Then(@"In OLS01901 I should see Shareholder Communication Methods Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)")]
        public void ShouldSeeShareholderCommunicationMethodsPart1(string HIN, string Mobile, string Email, string EmailReturnedDate, string PostalMailReturned, string PublicationDessc1, string PublicationDessc2, string PublicationDessc3, string PublicationDessc4, string PublicationDessc5, string PublicationDessc6, string PublicationDessc7, string PublicationDessc8, string PublicationDessc9)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01901");
            OLS01901.HolderIdentifier.ValidateFieldValue(HIN);
            OLS01901.MobilePhone.ValidateFieldValue(Mobile);
            OLS01901.EmailAddress.ValidateFieldValue(Email);
            OLS01901.EmailReturned.ValidateFieldValue(EmailReturnedDate);
            OLS01901.PostalReturned.ValidateFieldValue(PostalMailReturned);
            OLS01901.CommMethodDesc.ValidateFieldValue(1, PublicationDessc1);
            OLS01901.CommMethodDesc.ValidateFieldValue(2, PublicationDessc2);
            OLS01901.CommMethodDesc.ValidateFieldValue(3, PublicationDessc3);
            OLS01901.CommMethodDesc.ValidateFieldValue(4, PublicationDessc4);
            OLS01901.CommMethodDesc.ValidateFieldValue(5, PublicationDessc5);
            OLS01901.CommMethodDesc.ValidateFieldValue(6, PublicationDessc6);
            OLS01901.CommMethodDesc.ValidateFieldValue(7, PublicationDessc7);
            OLS01901.CommMethodDesc.ValidateFieldValue(8, PublicationDessc8);
            OLS01901.CommMethodDesc.ValidateFieldValue(9, PublicationDessc9);
        }

        [Then(@"In OLS01901 I should see Shareholder Communication Methods Part2 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeShareholderCommunicationMethodsPart2(string CommunicationMethods1, string CommunicationMethods2, string CommunicationMethods3, string CommunicationMethods4, string CommunicationMethods5, string CommunicationMethods6, string CommunicationMethods7, string CommunicationMethods8, string CommunicationMethods9, string HolderChoice1, string HolderChoice2, string HolderChoice3, string HolderChoice4, string HolderChoice5, string HolderChoice6, string HolderChoice7, string HolderChoice8, string HolderChoice9)
        {
            OLS01901.CommMethodValues.ValidateFieldValue(1, CommunicationMethods1);
            OLS01901.CommMethodValues.ValidateFieldValue(2, CommunicationMethods2);
            OLS01901.CommMethodValues.ValidateFieldValue(3, CommunicationMethods3);
            OLS01901.CommMethodValues.ValidateFieldValue(4, CommunicationMethods4);
            OLS01901.CommMethodValues.ValidateFieldValue(5, CommunicationMethods5);
            OLS01901.CommMethodValues.ValidateFieldValue(6, CommunicationMethods6);
            OLS01901.CommMethodValues.ValidateFieldValue(7, CommunicationMethods7);
            OLS01901.CommMethodValues.ValidateFieldValue(8, CommunicationMethods8);
            OLS01901.CommMethodValues.ValidateFieldValue(9, CommunicationMethods9);
            OLS01901.Method1.ValidateFieldValue(HolderChoice1);
            OLS01901.Method2.ValidateFieldValue(HolderChoice2);
            OLS01901.Method3.ValidateFieldValue(HolderChoice3);
            OLS01901.Method4.ValidateFieldValue(HolderChoice4);
            OLS01901.Method5.ValidateFieldValue(HolderChoice5);
            OLS01901.Method6.ValidateFieldValue(HolderChoice6);
            OLS01901.Method7.ValidateFieldValue(HolderChoice7);
            OLS01901.Method8.ValidateFieldValue(HolderChoice8);
            OLS01901.Method9.ValidateFieldValue(HolderChoice9);
        }

        [Then(@"In OLS01120 I should see Static Details menu options Notings as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeStaticDetailsMenuOptionsNotings(string D1, string D2, string D3, string D4, string D5, string P1, string P2, string P3, string N1, string N2, string N3, string N4, string N5)
        {
            OLS01120.MenuItemD1.ValidateFieldValue(D1);
            OLS01120.MenuItemD2.ValidateFieldValue(D2);
            OLS01120.MenuItemD3.ValidateFieldValue(D3);
            OLS01120.MenuItemD4.ValidateFieldValue(D4);
            OLS01120.MenuItemD5.ValidateFieldValue(D5);
            OLS01120.MenuItemP1.ValidateFieldValue(P1);
            OLS01120.MenuItemP2.ValidateFieldValue(P2);
            OLS01120.MenuItemP3.ValidateFieldValue(P3);
            OLS01120.MenuItemN1.ValidateFieldValue(N1);
            OLS01120.MenuItemN2.ValidateFieldValue(N2);
            OLS01120.MenuItemN3.ValidateFieldValue(N3);
            OLS01120.MenuItemN4.ValidateFieldValue(N4);
            OLS01120.MenuItemN5.ValidateFieldValue(N5);
        }

        [Then(@"In OLS01120 I should see Static Details menu options Part2 as ""(.*)""")]
        public void ShouldSeeStaticDetailsMenuOptionsPart2(string UpdateOption)
        {
            switch (UpdateOption.ToLower())
            {
                case "sc":
                    OLS01120.MenuItemSC.ValidateFieldValue(UpdateOption);
                    break;

                case "fc":
                    OLS01120.MenuItemFC.ValidateFieldValue(UpdateOption);
                    break;

                case "fg":
                    OLS01120.MenuItemFG.ValidateFieldValue(UpdateOption);
                    break;

                case "cy":
                    OLS01120.MenuItemCY.ValidateFieldValue(UpdateOption);
                    break;

                case "fl":
                    OLS01120.MenuItemFL.ValidateFieldValue(UpdateOption);
                    break;

                default:
                    break;
            }
        }

        [Then(@"In OLS068CS I should see Unconfirmed Deceased Static Changes Summary as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ShouldSeeUnconfirmedDeceasedStaticChangesSummary(string StaticAction1, string StaticAction2, string StaticAction3, string StaticAction4, string StaticAction5, string StaticAction6, string NewAddress1, string NewAddress2, string Address1, string Address2, string Address3, string Address4, string ThirdPartyPostcode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS068CS");

            String HIN = OLS06803.HolderIdentifier.GetValue();
            String Type = OLS06803.HolderTypeCode.GetValue();

            OLS068CS.Actions.ValidateFieldValue(1, StaticAction1);
            OLS068CS.Actions.ValidateFieldValue(2, StaticAction2);
            OLS068CS.Actions.ValidateFieldValue(3, StaticAction3);
            OLS068CS.Actions.ValidateFieldValue(4, StaticAction4);
            OLS068CS.Actions.ValidateFieldValue(5, StaticAction5);
            OLS068CS.Actions.ValidateFieldValue(6, StaticAction6);

            if (!HIN.Contains("X") || (Type != "JNT" && !HIN.Contains("X")) || (Type != "DEC" && !HIN.Contains("X")))
            {
                OLS068CS.NewHnaLine.ValidateFieldValue(1, NewAddress1);
                OLS068CS.NewHnaLine.ValidateFieldValue(2, NewAddress2);
                OLS068CS.NewHnaLine.ValidateFieldValue(3, Address1);
                OLS068CS.NewHnaLine.ValidateFieldValue(4, Address2);
                OLS068CS.NewHnaLine.ValidateFieldValue(5, Address3);
                OLS068CS.NewPostcode.ValidateFieldValue(ThirdPartyPostcode);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03502 I Terminate the Charity Election Details as ""(.*)""")]
        public void TerminateTheCharityElectionDetails(string NewTran1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03502");
            OLS03502.Action.SetValue("T");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS03502.TransNbrI.SetValue(NewTran1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01202 I enter holder details as below:")]
        [Then(@"In OLS01202 I enter holder details as below:")]
        public void ThenInOLSIEnterHolderDetailsAsbelow(Table data)
        {
            WinFormsTestSteps.ClickOnWithInTheStaticDetailUpdatemMenu("add holder");

            string HIN = data.GetData("HIN");
            string Type = data.GetData("Type");
            string PostCode = data.GetData("Post Code");
            string BrokerCode = data.GetData("Broker Code");
            string Name = data.GetData("Name");
            string Address1 = data.GetData("Address1");
            string Address2 = data.GetData("Address2");

            OLS01202.HolderIdentifier.SetValue(HIN);
            OLS01202.HolderTypeCode.SetValue(Type);
            OLS01202.AusPostcode.SetValue(PostCode);
            OLS01202.BrokerCode.SetValue(BrokerCode);
            OLS01202.HnaLineCh1to30R.SetValue(1, Name);
            OLS01202.HnaLineCh1to30R.SetValue(2, Address1);
            OLS01202.HnaLineCh1to30R.SetValue(3, Address2);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01210");

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();

            OLS00101.MenuItemEX.ClickField();
        }

        [Then(@"In OLS01120 I should see Static Details menu options Part1 as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenInOLSIShouldSeeStaticDetailsMenuOptionsPartAs(string AH, string NA, string HE, string UD, string CD, string PI, string WR, string ED, string VP, string UX, string IR, string ZA)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01120");
            OLS01120.MenuItemAH.ValidateFieldValue(AH);
            OLS01120.MenuItemNA.ValidateFieldValue(NA);
            OLS01120.MenuItemHE.ValidateFieldValue(HE);
            OLS01120.MenuItemUD.ValidateFieldValue(UD);
            OLS01120.MenuItemCD.ValidateFieldValue(CD);
            OLS01120.MenuItemPI.ValidateFieldValue(PI);
            OLS01120.MenuItemWR.ValidateFieldValue(WR);
            OLS01120.MenuItemED.ValidateFieldValue(ED);
            OLS01120.MenuItemVP.ValidateFieldValue(VP);
            OLS01120.MenuItemUX.ValidateFieldValue(UX);
            OLS01120.MenuItemIR.ValidateFieldValue(IR);
            OLS01120.MenuItemZA.ValidateFieldValue(ZA);
        }

        [When(@"In OLS03502 I Update Charity Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void UpdateCharityDetails(string Tran, string ParticipationOption, string ParticipationLevel, string CharityCode)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03502");
            OLS03502.TransNbrI.SetValue(Tran);
            OLS03502.ParticipationOption.SetValue(ParticipationOption);
            OLS03502.ParticipationLevel.SetValue(1, ParticipationLevel);
            OLS03502.CharityCode.SetValue(1, CharityCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I update Employee Details ""(.*)"" as below:")]
        public void UpdateEmployeeDetails(string ChangeED, Table data)
        {
            string Action = data.GetData("Action");
            string TranNo = data.GetData("Tran No");

            WinFormsTestSteps.ClickOnWithInTheStaticDetailUpdatemMenu("employee details");
            EOL01701.Action.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            EOL01701.TransNumber.SetValue(TranNo);

            switch (ChangeED.ToLower())
            {
                case "employee status":

                    string EmpStatus = data.GetData("Emp Status");
                    string LeaverCode = data.GetData("Leaver Code");
                    string EffectiveDate = data.GetData("Effective Date");

                    EOL01701.EmployeeStatus.SetValue(EmpStatus);
                    EOL01701.LeaverCode.SetValue(LeaverCode);
                    EOL01701.EffectiveDate.SetValue(EffectiveDate);

                    break;

                case "employee id":

                    string EmployeeID = data.GetData("Employee ID");
                    string StartDate = data.GetData("Start Date");
                    string PrefName = data.GetData("Preferred Name");
                    string BirthDate = data.GetData("Birth Date");
                    string BusinessUnit = data.GetData("Business Unit");

                    EOL01701.EmployeeNumber.SetValue(EmployeeID);
                    EOL01701.StartDate.SetValue(StartDate);
                    EOL01701.PreferredName.SetValue(PrefName);
                    EOL01701.BirthDate.SetValue(BirthDate);
                    EOL01701.BusinessUnit.SetValue(BusinessUnit);

                    break;

                default:
                    break;
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            OLS00101.MenuItemEX.ClickField();
        }

        [When(@"I update wire instructions add below:")]
        public void UpdateWireInstructions(Table data)
        {
            string TranNo = data.GetData("Tran No");
            string Country = data.GetData("Country");
            string SWIFTCode = data.GetData("SWIFT Code");
            string AccountNumber = data.GetData("Account Number");
            string AccountName = data.GetData("Account Name");
            string Currency = data.GetData("Payment Currency");
            string BankCode = data.GetData("Bank Code");
            string BankName = data.GetData("Bank Name");
            string BankAddress1 = data.GetData("Bank Address1");
            string BankAddress2 = data.GetData("Bank Address2");

            WinFormsTestSteps.ClickOnWithInTheStaticDetailUpdatemMenu("overseas wire instructions");

            OLS04201.TransNbrI.SetValue(TranNo);
            OLS04201.CountryCode.SetValue(Country);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04204");

            OLS04204.SwiftCode.SetValue(SWIFTCode);
            OLS04204.AccountNumber.SetValue(AccountNumber);
            OLS04204.AccountName.SetValue(AccountName);
            OLS04204.CurrencyCode.SetValue(Currency);
            OLS04204.BankCode.SetValue(BankCode);
            OLS04204.BankAddressLine.SetValue(1, BankName);
            OLS04204.BankAddressLine.SetValue(2, BankAddress1);
            OLS04204.BankAddressLine.SetValue(3, BankAddress2);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS04210");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            OLS00101.MenuItemEX.ClickField();
        }

        [When(@"In OLS03502 I Change the Charity Election Details as ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenInOLSIChangeTheCharityElectionDetailsAs(string Action, string NewTran, string NewParticipationOption, string NewParticipationLevel, string NewCharityCode)
        {
            OLS03502.Action.SetValue(Action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03502");
            OLS03502.TransNbrI.SetValue(NewTran);
            OLS03502.ParticipationOption.SetValue(NewParticipationOption);
            OLS03502.ParticipationLevel.SetValue(1, NewParticipationLevel);
            OLS03502.CharityCode.SetValue(1, NewCharityCode);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01403 I Delete Deceased Estate Noting Details as ""(.*)""")]
        public void WhenInOLSIDeleteDeceasedEstateNotingDetailsAs(string NewTranNO1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01403");
            OLS01403.Action.SetValue("D");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01404.TransNbrI.SetValue(NewTranNO1);
            OLS01404.Confirm.SetValue("Y");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"I update the ""(.*)"" Dividend Intention as below:")]
        public void WhenIUpdateTheDividendIntentionAsbelow(string divIntention, Table data)
        {
            string HIN = data.GetData("HIN");
            string TranNo = data.GetData("Tran No");
            string TranDate = data.GetData("Tran Date");
            string DRPOption = data.GetData("DRP Option");

            OLS01511.Action.SetValue("S");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01511.SearchData.SetValue(HIN);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01511");
            OLS01511.HolderIdentifier.ValidateFieldValue(HIN);

            OLS01511.Action.SetValue("U");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

            OLS01501.TransNumber.SetValue(TranNo);
            OLS01501.Date.SetValue(TranDate);
            OLS01501.DrpOpt5.SetValue(DRPOption);

            if (divIntention == "partial")
            {
                string DRPLevel = data.GetData("DRP Level");
                OLS01501.DrpLev5.SetValue(DRPLevel);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01511");
            Spartan.Core.WinForms.WinFormsDriver.PressESC();
            OLS00101.MenuItemEX.ClickField();
        }

        [When(@"OLS01101 I Search the holder as ""(.*)""")]
        public void WhenOLSISearchTheHolderAs(string SearchData)
        {
            OLS01101.Action.SetValue("S");
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            OLS01101.SearchData.SetValue(SearchData);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"IN OLSCRTTC I continue with the following details:")]
        public void OLSCRTTCContinueWithTheFollowingDetails(Table table)
        {
            OLSCRTTC.SellCert.SetValue(1, table.Rows[0]["SellCert1"]);
            OLSCRTTC.SellCert.SetValue(2, table.Rows[0]["SellCert2"]);
            OLSCRTTC.SellCert.SetValue(3, table.Rows[0]["SellCert3"]);
            OLSCRTTC.SellCert.SetValue(4, table.Rows[0]["SellCert4"]);
            if (table.Rows[0].ContainsKey("SellCert5"))
                OLSCRTTC.SellCert.SetValue(5, table.Rows[0]["SellCert5"]);
            if (table.Rows[0].ContainsKey("SellCert6"))
                OLSCRTTC.SellCert.SetValue(6, table.Rows[0]["SellCert6"]);
            if (table.Rows[0].ContainsKey("SellCert7"))
                OLSCRTTC.SellCert.SetValue(7, table.Rows[0]["SellCert7"]);
            if (table.Rows[0].ContainsKey("SellCert8"))
                OLSCRTTC.SellCert.SetValue(8, table.Rows[0]["SellCert8"]);
            if (table.Rows[0].ContainsKey("SellCert9"))
                OLSCRTTC.SellCert.SetValue(9, table.Rows[0]["SellCert9"]);
            if (table.Rows[0].ContainsKey("SellUnits1"))
                OLSCRTTC.SellUnits.SetValue(1, table.Rows[0]["SellUnits1"]);
            if (table.Rows[0].ContainsKey("SellUnits2"))
                OLSCRTTC.SellUnits.SetValue(2, table.Rows[0]["SellUnits2"]);
            if (table.Rows[0].ContainsKey("SellUnits3"))
                OLSCRTTC.SellUnits.SetValue(3, table.Rows[0]["SellUnits3"]);
            if (table.Rows[0].ContainsKey("SellUnits4"))
                OLSCRTTC.SellUnits.SetValue(4, table.Rows[0]["SellUnits4"]);
            if (table.Rows[0].ContainsKey("SellUnits5"))
                OLSCRTTC.SellUnits.SetValue(5, table.Rows[0]["SellUnits5"]);
            if (table.Rows[0].ContainsKey("SellUnits6"))
                OLSCRTTC.SellUnits.SetValue(6, table.Rows[0]["SellUnits6"]);
            if (table.Rows[0].ContainsKey("SellUnits7"))
                OLSCRTTC.SellUnits.SetValue(7, table.Rows[0]["SellUnits7"]);
            if (table.Rows[0].ContainsKey("SellUnits8"))
                OLSCRTTC.SellUnits.SetValue(8, table.Rows[0]["SellUnits8"]);
            if (table.Rows[0].ContainsKey("SellUnits9"))
                OLSCRTTC.SellUnits.SetValue(9, table.Rows[0]["SellUnits9"]);

            if (OLSCRTTC.BuyReg.Exists() == true)
            {
                OLSCRTTC.BuyReg.SetValue(1, table.Rows[0]["BuyReg"]);
                OLSCRTTC.BuyBroker.SetValue(1, table.Rows[0]["BuyBroker"]);
                OLSCRTTC.BuySearchName.SetValue(1, table.Rows[0]["BuySearchName"]);

            }

            if (OLSCRTTC.BuyReference.Exists()==true)
            {
                OLSCRTTC.BuyReference.SetValue(1, table.Rows[0]["BuyReference"]);
            }
            
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
           //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN OLSCRTUU I continue with the following values:")]
        public void OLSCRTUUContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTUU");
            OLSCRTUU.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLSCRTUU.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);

            if (OLSCRTUU.SellClass.Exists()==true)
            {
                OLSCRTUU.SellClass.SetValue(1, table.Rows[0]["SellClass"]);
                OLSCRTUU.SellSbn.SetValue(1, table.Rows[0]["SellSbn"]);
                OLSCRTUU.SellSearchName.SetValue(1, table.Rows[0]["SellSearchName"]);
                OLSCRTUU.SellReference.SetValue(1, table.Rows[0]["SellReference"]);
                OLSCRTUU.SellBroker.SetValue(1, table.Rows[0]["SellBroker"]);
            }

            if (OLSCRTUU.BuySbn.Exists() == true)
            {
                OLSCRTUU.BuySbn.SetValue(1, table.Rows[0]["BuySbn"]);
                OLSCRTUU.BuySearchName.SetValue(1, table.Rows[0]["BuySearchName"]);
                OLSCRTUU.BuyReference.SetValue(1, table.Rows[0]["BuyReference"]);
                OLSCRTUU.BuyBroker.SetValue(1, table.Rows[0]["BuyBroker"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In OLSCRTFI I continue with the following details:")]
        public void OLSCRTFIContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTFI");
            OLSCRTFI.BuyFwdInstruction.SetValue(1, table.Rows[0]["BuyFwdInstruction1"]);
            OLSCRTFI.BuyFwdInstruction.SetValue(2, table.Rows[0]["BuyFwdInstruction2"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"IN OLSCRTTU I continue with the following values:")]
        public void OLSCRTTUContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTTU");
            OLSCRTTU.SellCert.SetValue(1, table.Rows[0]["SellCert1"]);
            OLSCRTTU.SellCert.SetValue(2, table.Rows[0]["SellCert2"]);
            OLSCRTTU.SellUnits.SetValue(1, table.Rows[0]["SellUnits1"]);
            OLSCRTTU.SellUnits.SetValue(2, table.Rows[0]["SellUnits2"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN OLSCRTBF I continue with the following values:")]
        public void OLSCRTBFContinueWithTheFollowingValues(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTBF");
            if (OLSCRTBF.TransferUnits.Exists()== true)
            {
                OLSCRTBF.TransferUnits.SetValue(1, table.Rows[0]["TransferUnits"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN OLSCRTSC I continue with the following details:")]
        public void OLSCRTSCContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTSC");
            OLSCRTSC.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLSCRTSC.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLSCRTSC.SellClass.SetValue(1, table.Rows[0]["SellClass"]);
            OLSCRTSC.SellCertID.SetValue(1, table.Rows[0]["SellCertID"]);
            OLSCRTSC.SellHolderID.SetValue(1, table.Rows[0]["SellHolderID"]);
            OLSCRTSC.SellReg.SetValue(1, table.Rows[0]["SellReg"]);
            if (OLSCRTSC.SellBroker.Exists()==true)
            {
                OLSCRTSC.SellBroker.SetValue(1, table.Rows[0]["SellBroker"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"IN OLSCRTRE I continue with the following details:")]
        public void OLSCRTREContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTRE");
            OLSCRTRE.BuyInstructions.SetValue(1, table.Rows[0]["BuyInstructions1A"]);
            OLSCRTRE.BuyInstructions.SetValue(2, table.Rows[0]["BuyInstructions2A"]);
            OLSCRTRE.BuyInstructions.SetValue(3, table.Rows[0]["BuyInstructions3A"]);
            OLSCRTRE.BuyInstructions.SetValue(4, table.Rows[0]["BuyInstructions4A"]);
            OLSCRTRE.BuyInstructions.SetValue(5, table.Rows[0]["BuyInstructions5A"]);

            OLSCRTRE.BuySplitNbr1to5.SetValue(1, table.Rows[0]["BuySplitNbr1to51A"]);
            OLSCRTRE.BuySplitNbr1to5.SetValue(2, table.Rows[0]["BuySplitNbr1to52A"]);
            OLSCRTRE.BuySplitNbr1to5.SetValue(3, table.Rows[0]["BuySplitNbr1to53A"]);
            OLSCRTRE.BuySplitNbr1to5.SetValue(4, table.Rows[0]["BuySplitNbr1to54A"]);
            OLSCRTRE.BuySplitNbr1to5.SetValue(5, table.Rows[0]["BuySplitNbr1to55A"]);

            OLSCRTRE.BuySplitUnits1to5.SetValue(1, table.Rows[0]["BuySplitUnits1to51A"]);
            OLSCRTRE.BuySplitUnits1to5.SetValue(2, table.Rows[0]["BuySplitUnits1to52A"]);
            OLSCRTRE.BuySplitUnits1to5.SetValue(3, table.Rows[0]["BuySplitUnits1to53A"]);
            OLSCRTRE.BuySplitUnits1to5.SetValue(4, table.Rows[0]["BuySplitUnits1to54A"]);
            OLSCRTRE.BuySplitUnits1to5.SetValue(5, table.Rows[0]["BuySplitUnits1to55A"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN OLSCRTSP I continue with the following details:")]
        public void OLSCRTSPContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTSP");
            OLSCRTSP.BuySplitNumber.SetValue(1, table.Rows[0]["BuySplitNumber1"]);
            OLSCRTSP.BuySplitNumber.SetValue(2, table.Rows[0]["BuySplitNumber2"]);
            OLSCRTSP.BuySplitNumber.SetValue(3, table.Rows[0]["BuySplitNumber3"]);
            OLSCRTSP.BuySplitNumber.SetValue(4, table.Rows[0]["BuySplitNumber4"]);
            OLSCRTSP.BuySplitNumber.SetValue(5, table.Rows[0]["BuySplitNumber5"]);
            OLSCRTSP.BuySplitNumber.SetValue(6, table.Rows[0]["BuySplitNumber6"]);

            OLSCRTSP.BuySplitUnits.SetValue(1, table.Rows[0]["BuySplitUnits1"]);
            OLSCRTSP.BuySplitUnits.SetValue(2, table.Rows[0]["BuySplitUnits2"]);
            OLSCRTSP.BuySplitUnits.SetValue(3, table.Rows[0]["BuySplitUnits3"]);
            OLSCRTSP.BuySplitUnits.SetValue(4, table.Rows[0]["BuySplitUnits4"]);
            OLSCRTSP.BuySplitUnits.SetValue(5, table.Rows[0]["BuySplitUnits5"]);
            OLSCRTSP.BuySplitUnits.SetValue(6, table.Rows[0]["BuySplitUnits6"]);

            OLSCRTSP.BuyInstructions.SetValue(1, table.Rows[0]["BuyInstructions1"]);
            OLSCRTSP.BuyInstructions.SetValue(2, table.Rows[0]["BuyInstructions2"]);
            OLSCRTSP.BuyInstructions.SetValue(3, table.Rows[0]["BuyInstructions3"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN OLSCRTWH I continue with the following details:")]
        public void OLSCRTWHContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTWH");
            OLSCRTWH.Action.SetValue(1, table.Rows[0]["Action"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS02701 I continue with the following details:")]
        public void OLS02701ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02701");
            OLS02701.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS02701.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLS02701.SellClass.SetValue(1, table.Rows[0]["SellClass"]);
            OLS02701.SellReg.SetValue(1, table.Rows[0]["SellReg"]);
            OLS02701.SellBroker.SetValue(1, table.Rows[0]["SellBroker"]);
            OLS02701.SellCertID.SetValue(1, table.Rows[0]["SellCertID"]);
            OLS02701.SellHolderID.SetValue(1, table.Rows[0]["SellHolderID"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS02702 I continue with the following details:")]
        public void OLS02702ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02702");
            OLS02702.SellCert.SetValue(1, table.Rows[0]["SellCert1"]);
            OLS02702.SellCert.SetValue(2, table.Rows[0]["SellCert2"]);
            OLS02702.SellCert.SetValue(3, table.Rows[0]["SellCert3"]);
            OLS02702.SellUnits.SetValue(1, table.Rows[0]["SellUnits1"]);
            OLS02702.SellUnits.SetValue(2, table.Rows[0]["SellUnits2"]);
            OLS02702.SellUnits.SetValue(3, table.Rows[0]["SellUnits3"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS02703 I continue with the following details:")]
        public void OLS02703ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02703");
            OLS02703.BuyTradeReference.SetValue(1, table.Rows[0]["BuyTradeReference"]);
            OLS02703.BuySplitNumber.SetValue(1, table.Rows[0]["BuySplitNumber1"]);
            OLS02703.BuySplitNumber.SetValue(2, table.Rows[0]["BuySplitNumber2"]);
            OLS02703.BuySplitNumber.SetValue(3, table.Rows[0]["BuySplitNumber3"]);
            OLS02703.BuySplitNumber.SetValue(4, table.Rows[0]["BuySplitNumber4"]);
            OLS02703.BuySplitNumber.SetValue(5, table.Rows[0]["BuySplitNumber5"]);
            OLS02703.BuySplitUnits.SetValue(1, table.Rows[0]["BuySplitUnits1"]);
            OLS02703.BuySplitUnits.SetValue(2, table.Rows[0]["BuySplitUnits2"]);
            OLS02703.BuySplitUnits.SetValue(3, table.Rows[0]["BuySplitUnits3"]);
            OLS02703.BuySplitUnits.SetValue(4, table.Rows[0]["BuySplitUnits4"]);
            OLS02703.BuySplitUnits.SetValue(5, table.Rows[0]["BuySplitUnits5"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"IN OLS00101 I continue with the following details:")]
        public void OLS00101ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS00101");
            OLS00101.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN SESTOT01 I continue with the following details:")]
        public void SESTOT01ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("SESTOT01");
            SESTOT01.Option.SetValue(1, table.Rows[0]["Option"]);

            if (table.Rows[0]["Option"] != "r")
            {
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                SESTOT01.SessionNumber.SetValue(1, table.Rows[0]["SessionNumber"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"IN RUNSTS01 I continue with the following details:")]
        public void RUNSTS01ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("RUNSTS01");
            RUNSTS01.RunDate1.ValidateFieldValue(1, table.Rows[0]["RunDate1"]);
            RUNSTS01.Class.ValidateFieldValue(1, table.Rows[0]["Class1"]);
            RUNSTS01.Class.ValidateFieldValue(2, table.Rows[0]["Class2"]);
            RUNSTS01.Class.ValidateFieldValue(3, table.Rows[0]["Class3"]);
            RUNSTS01.Class.ValidateFieldValue(4, table.Rows[0]["Class4"]);
            RUNSTS01.Class.ValidateFieldValue(5, table.Rows[0]["Class5"]);

            RUNSTS01.Desc.ValidateFieldValue(1, table.Rows[0]["Desc1"]);
            RUNSTS01.Desc.ValidateFieldValue(2, table.Rows[0]["Desc2"]);
            RUNSTS01.Desc.ValidateFieldValue(3, table.Rows[0]["Desc3"]);
            RUNSTS01.Desc.ValidateFieldValue(4, table.Rows[0]["Desc4"]);
            RUNSTS01.Desc.ValidateFieldValue(5, table.Rows[0]["Desc5"]);

            RUNSTS01.Constant1.ValidateFieldValue(1, table.Rows[0]["Constant11"]);
            RUNSTS01.Constant1.ValidateFieldValue(2, table.Rows[0]["Constant12"]);
            RUNSTS01.Constant1.ValidateFieldValue(3, table.Rows[0]["Constant13"]);
            RUNSTS01.Constant1.ValidateFieldValue(4, table.Rows[0]["Constant14"]);
            RUNSTS01.Constant1.ValidateFieldValue(5, table.Rows[0]["Constant15"]);

            RUNSTS01.Ranges.ValidateFieldValue(1, table.Rows[0]["Ranges1"]);
            RUNSTS01.Ranges.ValidateFieldValue(2, table.Rows[0]["Ranges2"]);
            RUNSTS01.Ranges.ValidateFieldValue(3, table.Rows[0]["Ranges3"]);
            RUNSTS01.Ranges.ValidateFieldValue(4, table.Rows[0]["Ranges4"]);
            RUNSTS01.Ranges.ValidateFieldValue(5, table.Rows[0]["Ranges5"]);
        }

        [When(@"IN SESTOT01 I verify the following details:")]
        public void SESTOT01VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("SESTOT01");
            SESTOT01.SystemInfoFree4.ValidateFieldValueContains(1, table.Rows[0]["SessionNumber"]);
        }

        [When(@"In OLS01201 I Change Holder Name as:")]
        public void OLS01201ChangeHolderName(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01201");
            OLS01201.ActionB.SetValue(1, table.Rows[0]["Action3"]);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            OLS01201.TransNbrI.SetValue(1, table.Rows[0]["TransNbrI"]);
            OLS01201.HnaLineCh1to30R.SetValue(1, table.Rows[0]["HnaLineCh1to30R"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01102");
        }

        [When(@"IN SESTOT02 I verify with the following details:")]
        public void SESTOT02VerifyWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("SESTOT02");
            SESTOT02.TransCode.ValidateFieldValue(1, table.Rows[0]["TransCode1"]);
            SESTOT02.TransCode.ValidateFieldValue(2, table.Rows[0]["TransCode2"]);
            SESTOT02.TransDesc.ValidateFieldValue(1, table.Rows[0]["TransDesc1"]);
            SESTOT02.TransDesc.ValidateFieldValue(2, table.Rows[0]["TransDesc2"]);
            SESTOT02.Units.ValidateFieldValue(1, table.Rows[0]["Units1"]);
            SESTOT02.Units.ValidateFieldValue(2, table.Rows[0]["Units2"]);
            SESTOT02.Entries.ValidateFieldValue(1, table.Rows[0]["Entries1"]);
            SESTOT02.Entries.ValidateFieldValue(2, table.Rows[0]["Entries2"]);
        }

        [When(@"In OLS03601 I continue with the following details:")]
        public void OLS03601ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03601");
            OLS03601.TranNumber.SetValue(1, table.Rows[0]["TranNumber"]);
            OLS03601.SellClass.SetValue(1, table.Rows[0]["SellClass"]);
            OLS03601.SellReg.SetValue(1, table.Rows[0]["SellReg"]);
            OLS03601.SellBroker.SetValue(1, table.Rows[0]["SellBroker"]);
            OLS03601.SellCertID.SetValue(1, table.Rows[0]["SellCertID"]);
            OLS03601.SellHolderID.SetValue(1, table.Rows[0]["SellHolderID"]);
            OLS03601.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS03602 I continue with the following details:")]
        public void OLS03602ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03602");
            if (OLS03602.SellCert.Exists()==true)
            {
                OLS03602.SellCert.SetValue(1, table.Rows[0]["SellCert1"]);
                OLS03602.SellCert.SetValue(2, table.Rows[0]["SellCert2"]);
                OLS03602.SellCert.SetValue(3, table.Rows[0]["SellCert3"]);
                OLS03602.SellCert.SetValue(4, table.Rows[0]["SellCert4"]);
                OLS03602.SellCert.SetValue(5, table.Rows[0]["SellCert5"]);
            }

            OLS03602.SellInd.SetValue(1, table.Rows[0]["SellInd"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLSCRTBA I continue with the following details:")]
        public void OLSCRTBAContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FromName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (FromName == "OLSCNXWN")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTBA");
            OLSCRTBA.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLSCRTBA.LodgeDate.SetValue(1, table.Rows[0]["LodgeDate"]);
            OLSCRTBA.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLSCRTBA.BuyClass.SetValue(1, table.Rows[0]["BuyClass"]);
            OLSCRTBA.BuyBroker.SetValue(1, table.Rows[0]["BuyBroker"]);
            OLSCRTBA.BuySearchName.SetValue(1, table.Rows[0]["BuySearchName"]);
            OLSCRTBA.BuyReference.SetValue(1, table.Rows[0]["BuyReference"]);
            OLSCRTBA.BuyTransDate.SetValue(1, table.Rows[0]["BuyTransDate"]);
            OLSCRTBA.BuySbn.SetValue(1, table.Rows[0]["BuySbn"]);
            OLSCRTBA.BuyReg.SetValue(1, table.Rows[0]["BuyReg"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In ONLSCH02 I continue with the following details:")]
        public void ONLSCH02ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ONLSCH02");
            ONLSCH02.Action.SetValue(1, table.Rows[0]["Action"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS15001 I continue with the following details:")]
        public void OLS15001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS15001");
            OLS15001.Selection.SetValue(1, table.Rows[0]["Selection"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10201 I continue with the following details:")]
        public void OLS10201ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10201");
            OLS10201.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10202 I continue with the following details:")]
        public void OLS10202ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10202");
            OLS10202.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10202.Amount1.SetValue(1, table.Rows[0]["Amount1"]);
            if (OLS10202.Amount2.Exists() == true)
            {
                OLS10202.Amount2.SetValue(1, table.Rows[0]["Amount2"]);
            }

            OLS10202.WitholdTax.SetValue(1, table.Rows[0]["WitholdTax"]);
            OLS10202.WHTaxInd.SetValue(1, table.Rows[0]["WHTaxInd"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10203 I continue with the following details:")]
        public void OLS10203ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10203");
            OLS10203.CalcNett.ValidateFieldValue(1, table.Rows[0]["CalcNett"]);
            if (OLS10203.CalcDual.Exists() == true)
            {
                OLS10203.CalcDual.ValidateFieldValue(1, table.Rows[0]["CalcDual"]);
            }
            if (OLS10203.Calc1.Exists() == true)
            {
                OLS10203.Calc1.ValidateFieldValue(1, table.Rows[0]["Calc1"]);
            }
            if (OLS10203.Calc2.Exists() == true)
            {
                OLS10203.Calc2.ValidateFieldValue(1, table.Rows[0]["Calc2"]);
            }
            if (OLS10203.Calc3.Exists() == true)
            {
                OLS10203.Calc3.ValidateFieldValue(1, table.Rows[0]["Calc3"]);
            }

            OLS10203.Confirmation.SetValue(1, table.Rows[0]["Confirmation"]);

            if (table.Rows[0]["Confirmation"] =="Y")
            {
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                OLS10203.HolderNameKey.SetValue(1, table.Rows[0]["HolderNameKey"]);
            }

           
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10204 I continue with the following details:")]
        public void OLS10204ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10204");
            OLS10204.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS10204.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10204.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            if (OLS10204.Currency.Exists() ==true)
            {
                OLS10204.Currency.SetValue(1, table.Rows[0]["Currency"]);
            }

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }


        [When(@"In OLS10301 I continue with the following details:")]
        public void OLS10301ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10301");
            OLS10301.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS10301.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10301.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10301.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10301.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            OLS10301.NewHolderNameKey.SetValue(1, table.Rows[0]["NewHolderNameKey"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10302 I continue with the following details:")]
        public void OLS10302ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10302");
            OLS10302.TransNumber.ValidateFieldValue(1, table.Rows[0]["TransNumber"]);
            OLS10302.PayAccountNumber.ValidateFieldValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10302.PaymentMethod.ValidateFieldValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10302.PayRefNumber.ValidateFieldValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10302.PaymentAmount.ValidateFieldValue(1, table.Rows[0]["PaymentAmount"]);
            OLS10302.NewHolderIdentifier.ValidateFieldValue(1, table.Rows[0]["NewHolderNameKey"]);
            OLS10302.PayOrigHolderIdent.ValidateFieldValue(1, table.Rows[0]["PayOrigHolderIdent"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In OLS10701 I continue with the following details:")]
        public void OLS10701ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10701");
            OLS10701.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS10701.TransDate.SetValue(1, table.Rows[0]["TransDate"]);
            OLS10701.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10701.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10701.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10704 I continue with the following details:")]
        public void OLS10704ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10704");
            OLS10704.NewGrossAmount.SetValue(1, table.Rows[0]["NewGrossAmount"]);
            OLS10704.GrossAmount.ValidateFieldValue(1, table.Rows[0]["GrossAmount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10702 I continue with the following details:")]
        public void OLS10702ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10702");
            OLS10702.NewFranked.SetValue(1, table.Rows[0]["NewFranked"]);
            OLS10702.NewUnfranked.SetValue(1, table.Rows[0]["NewUnfranked"]);
            OLS10702.NewWitholdTax.SetValue(1, table.Rows[0]["NewWitholdTax"]);
            OLS10702.NewWHTaxInd.SetValue(1, table.Rows[0]["NewWHTaxInd"]);
            OLS10702.Franked.ValidateFieldValue(1, table.Rows[0]["Franked"]);
            OLS10702.Unfranked.ValidateFieldValue(1, table.Rows[0]["Unfranked"]);
            OLS10702.WitholdTax.ValidateFieldValue(1, table.Rows[0]["WitholdTax"]);
            OLS10702.WHTaxInd.ValidateFieldValue(1, table.Rows[0]["WHTaxInd"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS10001 I continue with the following details:")]
        public void OLS10001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10001");
            OLS10001.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10001.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            OLS10001.PresentedDate.SetValue(1, table.Rows[0]["PresentedDate"]);
            OLS10001.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10001.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10001.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS10501 I continue with the following details:")]
        public void OLS10501ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10501");
            OLS10501.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS10501.CancelledDate.SetValue(1, table.Rows[0]["CancelledDate"]);
            OLS10501.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10501.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10501.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10501.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }


        [When(@"In OLS10601 I continue with the following details:")]
        public void OLS10601ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10601");
            OLS10601.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS10601.ReversedDate.SetValue(1, table.Rows[0]["ReversedDate"]);
            OLS10601.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10601.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS10601.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10601.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS10401 I continue with the following details:")]
        public void OLS10401ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS10401");
            OLS10401.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS10401.ReversedDate.SetValue(1, table.Rows[0]["ReversedDate"]);
            OLS10401.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS10401.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS10401.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            if (table.Rows[0]["PaymentMethod"] != "")
            {
                OLS10401.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11901 I continue with the following details:")]
        public void OLS11901ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11901");
            OLS11901.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS11901.FailedDate.SetValue(1, table.Rows[0]["FailedDate"]);
            OLS11901.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS11901.PayRefNumber.SetValue(1, table.Rows[0]["PayRefNumber"]);
            OLS11901.PaymentAmt.SetValue(1, table.Rows[0]["PaymentAmt"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11903 I verify with the following details:")]
        public void OLS11903VerifyWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11903");
            OLS11903.SubPaymentCode.ValidateFieldValue(1, table.Rows[0]["SubPaymentCode"]);
            OLS11903.PaymentTypeDesc.ValidateFieldValue(1, table.Rows[0]["PaymentTypeDesc"]);
            OLS11903.SubpGrossAmt.ValidateFieldValue(1, table.Rows[0]["SubpGrossAmt"]);
            OLS11903.SubpTaxAmt.ValidateFieldValue(1, table.Rows[0]["SubpTaxAmt"]);
            OLS11903.SubpDednAmt.ValidateFieldValue(1, table.Rows[0]["SubpDednAmt"]);
            OLS11903.SubpNettAmt.ValidateFieldValue(1, table.Rows[0]["SubpNettAmt"]);
            OLS11903.TotGrossAmt.ValidateFieldValue(1, table.Rows[0]["TotGrossAmt"]);
            OLS11903.TotTaxAmt.ValidateFieldValue(1, table.Rows[0]["TotTaxAmt"]);
            OLS11903.TotDednAmt.ValidateFieldValue(1, table.Rows[0]["TotDednAmt"]);
            OLS11903.TotNettAmt.ValidateFieldValue(1, table.Rows[0]["TotNettAmt"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11902 I verify with the following details:")]
        public void OLS11902VerifyWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11902");
            OLS11902.TotGross.ValidateFieldValue(1, table.Rows[0]["TotGross"]);
            OLS11902.TotNett.ValidateFieldValue(1, table.Rows[0]["TotNett"]);
            OLS11902.TotTaxAmt.ValidateFieldValue(1, table.Rows[0]["TotTaxAmt"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11601 I continue with the following details:")]
        public void OLS11601ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11601");
            OLS11601.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS11601.PayAccountNumber.SetValue(1, table.Rows[0]["PayAccountNumber"]);
            OLS11601.PaymentMethod.SetValue(1, table.Rows[0]["PaymentMethod"]);
            OLS11601.PayOrigRef.SetValue(1, table.Rows[0]["PayOrigRef"]);
            OLS11601.PaymentAmount.SetValue(1, table.Rows[0]["PaymentAmount"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11603 I verify with the following details:")]
        public void OLS11601VerifyWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11603");
            OLS11603.SubPaymentCode.ValidateFieldValue(1, table.Rows[0]["SubPaymentCode"]);
            OLS11603.PaymentTypeDesc.ValidateFieldValue(1, table.Rows[0]["PaymentTypeDesc"]);
            OLS11603.SubpGrossAmt.ValidateFieldValue(1, table.Rows[0]["SubpGrossAmt"]);
            OLS11603.SubpTaxAmt.ValidateFieldValue(1, table.Rows[0]["SubpTaxAmt"]);
            OLS11603.SubpDednAmt.ValidateFieldValue(1, table.Rows[0]["SubpDednAmt"]);
            OLS11603.SubpNettAmt.ValidateFieldValue(1, table.Rows[0]["SubpNettAmt"]);
            OLS11603.TotGrossAmt.ValidateFieldValue(1, table.Rows[0]["TotGrossAmt"]);
            OLS11603.TotTaxAmt.ValidateFieldValue(1, table.Rows[0]["TotTaxAmt"]);
            OLS11603.TotDednAmt.ValidateFieldValue(1, table.Rows[0]["TotDednAmt"]);
            OLS11603.TotNettAmt.ValidateFieldValue(1, table.Rows[0]["TotNettAmt"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11602 I verify the following details:")]
        public void OLS11602VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11602");
            OLS11602.Class.ValidateFieldValue(1, table.Rows[0]["Class"]);
            OLS11602.ClassCatUnits.ValidateFieldValue(1, table.Rows[0]["ClassCatUnits"]);
            OLS11602.GrossAmt1.ValidateFieldValue(1, table.Rows[0]["GrossAmt1"]);
            OLS11602.GrossAmt2.ValidateFieldValue(1, table.Rows[0]["GrossAmt2"]);
            OLS11602.ImputedCredit.ValidateFieldValue(1, table.Rows[0]["ImputedCredit"]);
            OLS11602.TotalGross.ValidateFieldValue(1, table.Rows[0]["TotalGross"]);
            OLS11602.TotGross.ValidateFieldValue(1, table.Rows[0]["TotGross"]);
            OLS11602.TotNett.ValidateFieldValue(1, table.Rows[0]["TotNett"]);
            OLS11602.TotTaxAmt.ValidateFieldValue(1, table.Rows[0]["TotTaxAmt"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11699 I continue with the following details:")]
        public void OLS11699ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11699");
            OLS11699.ConfirmContinue.SetValue(1, table.Rows[0]["ConfirmContinue"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11010 I verify the following details:")]
        public void OLS11010VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11010");
            OLS11010.WarningLit.ValidateFieldValue(1, table.Rows[0]["WarningLit"]);
            OLS11010.FileName.ValidateFieldValue(1, table.Rows[0]["FileName1"]);
            OLS11010.MailFileName.ValidateFieldValue(1, table.Rows[0]["MailFileName"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS11004 I verify the following details:")]
        public void OLS11004VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS11004");
            OLS11004.DividendCode.ValidateFieldValue(1, table.Rows[0]["DividendCode"]);
            OLS11004.PaymentDate.ValidateFieldValue(1, table.Rows[0]["PaymentDate"]);
            OLS11004.SubPaymentCode.ValidateFieldValue(1, table.Rows[0]["SubPaymentCode"]);
            OLS11004.PaymentTypeDesc.ValidateFieldValue(1, table.Rows[0]["PaymentTypeDesc"]);
            OLS11004.SubpGrossAmt.ValidateFieldValue(1, table.Rows[0]["SubpGrossAmt"]);
            OLS11004.SubpTaxAmt.ValidateFieldValue(1, table.Rows[0]["SubpTaxAmt"]);
            OLS11004.SubpOtaxAmt.ValidateFieldValue(1, table.Rows[0]["SubpOtaxAmt"]);
            OLS11004.SubpNettAmt.ValidateFieldValue(1, table.Rows[0]["SubpNettAmt"]);
            OLS11004.TotGrossAmt.ValidateFieldValue(1, table.Rows[0]["TotGrossAmt"]);
            OLS11004.TotTaxAmt.ValidateFieldValue(1, table.Rows[0]["TotTaxAmt"]);
            OLS11004.TotOtaxAmt.ValidateFieldValue(1, table.Rows[0]["TotOtaxAmt"]);
            OLS11004.TotNettAmt.ValidateFieldValue(1, table.Rows[0]["TotNettAmt"]);
            OLS11004.BankCode.ValidateFieldValue(1, table.Rows[0]["BankCode"]);
            OLS11004.AccountNumber.ValidateFieldValue(1, table.Rows[0]["AccountNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        [When(@"In OLS03301 I continue with the following details:")]
        public void OLS03301ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03301");
            OLS03301.TranNumber.SetValue(1, table.Rows[0]["TranNumber"]);
            OLS03301.FromNameKey.SetValue(1, table.Rows[0]["FromNameKey"]);
            OLS03301.FromCertID.SetValue(1, table.Rows[0]["FromCertID"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS03302 I continue with the following details:")]
        public void OLS03302ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03302");

            if (OLS03302.Action.Exists() == true)
            {
                OLS03302.Action.SetValue(1, table.Rows[0]["Action"]);
                OLS03302.Action.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            }
            OLS03302.TONameKey.SetValue(1, table.Rows[0]["TONameKey"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            //Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

        }

        [When(@"In OLS03303 I continue with the following details:")]
        public void OLS03303ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03303");
            OLS03303.Action.SetValue(1, table.Rows[0]["Action1"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(120);
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03301");
        }

        [Then(@"In ENS01003 I verify the following details:")]
        public void ENS01003VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01003");
            ENS01003.NotingNumber.ValidateFieldValue(1, table.Rows[0]["NotingNumber"]);
            ENS01003.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);
            ENS01003.PowerDated.ValidateFieldValue(1, table.Rows[0]["PowerDated"]);
            ENS01003.PowerNoted.ValidateFieldValue(1, table.Rows[0]["PowerNoted"]);
            ENS01003.AtsJointlyFlag.ValidateFieldValue(1, table.Rows[0]["AtsJointlyFlag"]);
            ENS01003.AtsSeverallyFlag.ValidateFieldValue(1, table.Rows[0]["AtsSeverallyFlag"]);
            ENS01003.AtsAnytwoFlag.ValidateFieldValue(1, table.Rows[0]["AtsAnytwoFlag"]);
            ENS01003.PptBuyFlag.ValidateFieldValue(1, table.Rows[0]["PptBuyFlag"]);
            ENS01003.PptSellFlag.ValidateFieldValue(1, table.Rows[0]["PptSellFlag"]);
            ENS01003.PptVoteFlag.ValidateFieldValue(1, table.Rows[0]["PptVoteFlag"]);
            ENS01003.PptAppsubFlag.ValidateFieldValue(1, table.Rows[0]["PptAppsubFlag"]);
            ENS01003.StampedINComment.ValidateFieldValue(1, table.Rows[0]["StampedINComment"]);
            ENS01003.LodgedBYComment.ValidateFieldValue(1, table.Rows[0]["LodgedBYComment"]);
        }


        [Then(@"In ENS01060 I verify the following details:")]
        public void ENS01060VerifyTheFollowingDetails(Table table)
        {
            //need to get the current date for the transaction. speckflow test is written on 18/05/16
            DateTime today = DateTime.Today;
            var CurrentDate = today.ToString("dd/MM/yyyy");

            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01060");
            ENS01060.BspLine.ValidateFieldValueContains(1, table.Rows[0]["BspLine1"].Replace("18/05/16", CurrentDate));
            ENS01060.BspLine.ValidateFieldValueContains(2, table.Rows[0]["BspLine2"].Replace("18/05/16", CurrentDate));
            ENS01060.BspLine.ValidateFieldValueContains(3, table.Rows[0]["BspLine3"].Replace("18/05/16", CurrentDate));
            ENS01060.BspLine.ValidateFieldValueContains(4, table.Rows[0]["BspLine4"].Replace("18/05/16", CurrentDate));
            ENS01060.BspLine.ValidateFieldValueContains(5, table.Rows[0]["BspLine5"].Replace("18/05/16", CurrentDate));
            ENS01060.SourceOption.ValidateFieldValue(1, table.Rows[0]["SourceOption"]);
            ENS01060.DrpLine.ValidateFieldValueContains(1, table.Rows[0]["DrpLine1"].Replace("18/05/16", CurrentDate));
            ENS01060.DrpLine.ValidateFieldValueContains(2, table.Rows[0]["DrpLine2"].Replace("18/05/16", CurrentDate));
            ENS01060.DrpLine.ValidateFieldValueContains(3, table.Rows[0]["DrpLine3"].Replace("18/05/16", CurrentDate));
            ENS01060.DrpLine.ValidateFieldValueContains(4, table.Rows[0]["DrpLine4"].Replace("18/05/16", CurrentDate));
            ENS01060.DrpLine.ValidateFieldValueContains(5, table.Rows[0]["DrpLine5"].Replace("18/05/16", CurrentDate));
        }

        [Then(@"In ENS01001 I verify the following Name details:")]
        public void ENS01001VerifyTheFollowingNameDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01001");
            ENS01001.HnaLine.ValidateFieldValue(1, table.Rows[0]["HnaLine1"]);
            ENS01001.HnaLine.ValidateFieldValue(2, table.Rows[0]["HnaLine2"]);
            ENS01001.HnaLine.ValidateFieldValue(3, table.Rows[0]["HnaLine3"]);
            ENS01001.HnaLine.ValidateFieldValue(4, table.Rows[0]["HnaLine4"]);
            ENS01001.HnaLine.ValidateFieldValue(5, table.Rows[0]["HnaLine5"]);
            ENS01001.HnaLine.ValidateFieldValue(6, table.Rows[0]["HnaLine6"]);
            ENS01001.HnaLine.ValidateFieldValue(7, table.Rows[0]["HnaLine7"]);
            ENS01001.HnaLine.ValidateFieldValue(8, table.Rows[0]["HnaLine8"]);
        }

        [Then(@"In ENSESS25 I verify the following details:")]
        public void ENSESS25VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENSESS25");
            ENSESS25.DetailLine.ValidateFieldValue(1, table.Rows[0]["DetailLine1"]);
            ENSESS25.DetailLine.ValidateFieldValue(2, table.Rows[0]["DetailLine2"]);
            ENSESS25.DetailLine.ValidateFieldValue(3, table.Rows[0]["DetailLine3"]);
            ENSESS25.DetailLine.ValidateFieldValue(4, table.Rows[0]["DetailLine4"]);
            ENSESS25.DetailLine.ValidateFieldValue(5, table.Rows[0]["DetailLine5"]);
            ENSESS25.DetailLine.ValidateFieldValue(6, table.Rows[0]["DetailLine6"]);
            ENSESS25.DetailLine.ValidateFieldValue(7, table.Rows[0]["DetailLine7"]);
            ENSESS25.DetailLine.ValidateFieldValue(8, table.Rows[0]["DetailLine8"]);
            ENSESS25.DetailLine.ValidateFieldValue(9, table.Rows[0]["DetailLine9"]);
            ENSESS25.DetailLine.ValidateFieldValue(10, table.Rows[0]["DetailLine10"]);
        }


        [When(@"In OLS03705 I continue with the following details:")]
        public void OLS03705ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03705");
            OLS03705.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            OLS03705.RunNumber.SetValue(1, table.Rows[0]["RunNumber"]);
            OLS03705.TransferNumber.SetValue(1, table.Rows[0]["TransferNumber"]);
            OLS03705.BuyORSell.SetValue(1, table.Rows[0]["BuyORSell"]);
            OLS03705.OldBrokerCode.SetValue(1, table.Rows[0]["OldBrokerCode"]);
            OLS03705.NewBrokerCode.SetValue(1, table.Rows[0]["NewBrokerCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03706 I verify the following details:")]
        public void OLS03706VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03706");
            OLS03706.ClassCode.ValidateFieldValue(1, table.Rows[0]["ClassCode"]);
            OLS03706.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);
            OLS03706.TransferNumber.ValidateFieldValue(1, table.Rows[0]["TransferNumber"]);
            OLS03706.CBrokerCode.ValidateFieldValue(1, table.Rows[0]["CBrokerCode"]);
            OLS03706.NBrokerCode.ValidateFieldValue(1, table.Rows[0]["NBrokerCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In ENS01053 I verify the following details:")]
        public void ENS01053VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("ENS01053");
            ENS01053.ExtraCertDetails.ValidateFieldValue(1, table.Rows[0]["ExtraCertDetails1"]);
            ENS01053.ExtraCertDetails.ValidateFieldValueContains(2, table.Rows[0]["ExtraCertDetails2"]);
            ENS01053.ExtraCertDetails.ValidateFieldValue(3, table.Rows[0]["ExtraCertDetails3"]);
            ENS01053.ExtraCertDetails.ValidateFieldValue(4, table.Rows[0]["ExtraCertDetails4"]);
            ENS01053.ExtraCertDetails.ValidateFieldValue(5, table.Rows[0]["ExtraCertDetails5"]);
        }

        [When(@"In OLS03707 I continue with the following details:")]
        public void OLS03707ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03707");
            OLS03707.HolderNumber.SetValue(1, table.Rows[0]["HolderNumber"]);
            OLS03707.RunNumber.SetValue(1, table.Rows[0]["RunNumber"]);
            OLS03707.TransferNumber.SetValue(1, table.Rows[0]["TransferNumber"]);
            OLS03707.BuyORSell.SetValue(1, table.Rows[0]["BuyORSell"]);
            OLS03707.CurTranDate.SetValue(1, table.Rows[0]["CurTranDate"]);
            OLS03707.NewTranDate.SetValue(1, table.Rows[0]["NewTranDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03708 I verify the following details:")]
        public void OLS03708VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03708");
            OLS03708.ClassCode.ValidateFieldValue(1, table.Rows[0]["ClassCode"]);
            OLS03708.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);
            OLS03708.TransferNumber.ValidateFieldValue(1, table.Rows[0]["TransferNumber"]);
            OLS03708.CurTranDate.ValidateFieldValue(1, table.Rows[0]["CurTranDate"]);
            OLS03708.NewTranDate.ValidateFieldValue(1, table.Rows[0]["NewTranDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03703 I continue with the following details:")]
        public void OLS03703ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03703");
            OLS03703.HolderNumber.SetValue(1, table.Rows[0]["HolderNumber"]);
            OLS03703.RunNumber.SetValue(1, table.Rows[0]["RunNumber"]);
            OLS03703.TransferNumber.SetValue(1, table.Rows[0]["TransferNumber"]);
            OLS03703.BuyORSell.SetValue(1, table.Rows[0]["BuyORSell"]);
            OLS03703.TradeReference.SetValue(1, table.Rows[0]["TradeReference"]);
            OLS03703.NewTradeReference.SetValue(1, table.Rows[0]["NewTradeReference"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03704 I verify the following details:")]
        public void OLS03704VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03704");
            OLS03704.ClassCode.ValidateFieldValue(1, table.Rows[0]["ClassCode"]);
            OLS03704.RegisterCode.ValidateFieldValue(1, table.Rows[0]["RegisterCode"]);
            OLS03704.TransferNumber.ValidateFieldValue(1, table.Rows[0]["TransferNumber"]);
            OLS03704.CTradeReference.ValidateFieldValue(1, table.Rows[0]["CTradeReference"]);
            OLS03704.NTradeReference.ValidateFieldValue(1, table.Rows[0]["NTradeReference"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03801 I continue with the following details:")]
        public void OLS03801ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03801");
            OLS03801.FromHolderID.SetValue(1, table.Rows[0]["FromHolderID"]);
            OLS03801.PaymentDate.SetValue(1, table.Rows[0]["PaymentDate"]);
            OLS03801.DividendCode.SetValue(1, table.Rows[0]["DividendCode"]);
            OLS03801.DividendSource.SetValue(1, table.Rows[0]["DividendSource"]);
            OLS03801.PayMethod.SetValue(1, table.Rows[0]["PayMethod"]);
            OLS03801.ReferenceNumber.SetValue(1, table.Rows[0]["ReferenceNumber"]);
            OLS03801.TOHolderID.SetValue(1, table.Rows[0]["TOHolderID"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03802 I verify the following details:")]
        public void OLS03802VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03802");
            OLS03802.PaymentDate.ValidateFieldValue(1, table.Rows[0]["PaymentDate"]);
            OLS03802.DividendCode.ValidateFieldValue(1, table.Rows[0]["DividendCode"]);
            OLS03802.DividendSource.ValidateFieldValue(1, table.Rows[0]["DividendSource"]);
            OLS03802.PayMethod.ValidateFieldValue(1, table.Rows[0]["PayMethod"]);
            OLS03802.ReferenceNumber.ValidateFieldValue(1, table.Rows[0]["ReferenceNumber"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03402 I continue with the following details:")]
        public void OLS03402ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03402");
            OLS03402.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS03402.FromNameKey.SetValue(1, table.Rows[0]["FromNameKey"]);
            OLS03402.ClassCode.SetValue(1, table.Rows[0]["ClassCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        [When(@"In OLS03405 I continue with the following details:")]
        public void OLS03405ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03405");
            OLS03405.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["FromNameKey"]);
            OLS03405.ClassCode.ValidateFieldValue(1, table.Rows[0]["ClassCode"]);
            OLS03405.OldRegisterCode.ValidateFieldValue(1, table.Rows[0]["OldRegisterCode"]);
            OLS03405.OldRegisterDesc.ValidateFieldValue(1, table.Rows[0]["OldRegisterDesc"]);
            OLS03405.NewRegisterCode.SetValue(1, table.Rows[0]["NewRegisterCode"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS03408 I verify the following details:")]
        public void OLS03408VerifyTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03408");
            OLS03408.HolderIdentifier.ValidateFieldValue(1, table.Rows[0]["FromNameKey"]);
            OLS03408.ClassCode.ValidateFieldValue(1, table.Rows[0]["ClassCode"]);
            OLS03408.CRegisterCode.ValidateFieldValue(1, table.Rows[0]["OldRegisterCode"]);
            OLS03408.CRegisterDesc.ValidateFieldValue(1, table.Rows[0]["OldRegisterDesc"]);
            OLS03408.NRegisterCode.ValidateFieldValue(1, table.Rows[0]["NewRegisterCode"]);
            OLS03408.NRegisterDesc.ValidateFieldValue(1, table.Rows[0]["NRegisterDesc"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady(180);
        }

        [When(@"In OLS01511 I continue with the following details:")]
        public void OLS01511ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01511");
            OLS01511.Action.SetValue(1, table.Rows[0]["Action"]);

            if (table.Rows[0]["Action"] == "s")
            {
                OLS01511.Action.ClickField();
                Spartan.Core.WinForms.WinFormsDriver.PressTAB();
                OLS01511.SearchData.SetValue(1, table.Rows[0]["SearchData"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS01501 I continue with the following details:")]
        public void OLS01501ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS01501");
            OLS01501.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS01501.Date.SetValue(1, table.Rows[0]["Date"]);

            if (OLS01501.BspOpt1.Exists() ==true)
            {
                OLS01501.BspOpt1.SetValue(1, table.Rows[0]["BspOpt1"]);
            }
            if (OLS01501.BspOpt2.Exists() == true)
            {
                OLS01501.BspOpt2.SetValue(1, table.Rows[0]["BspOpt2"]);
            }
            if (OLS01501.BspOpt3.Exists() == true)
            {
                OLS01501.BspOpt3.SetValue(1, table.Rows[0]["BspOpt3"]);
            }
            if (OLS01501.BspOpt4.Exists() == true)
            {
                OLS01501.BspOpt4.SetValue(1, table.Rows[0]["BspOpt4"]);
            }
            if (OLS01501.BspOpt5.Exists() == true)
            {
                OLS01501.BspOpt5.SetValue(1, table.Rows[0]["BspOpt5"]);
            }
            if (OLS01501.BspLev1.Exists() == true)
            {
                OLS01501.BspLev1.SetValue(1, table.Rows[0]["BspLev1"]);
            }
            if (OLS01501.BspLev2.Exists() == true)
            {
                OLS01501.BspLev2.SetValue(1, table.Rows[0]["BspLev2"]);
            }
            if (OLS01501.BspLev3.Exists() == true)
            {
                OLS01501.BspLev3.SetValue(1, table.Rows[0]["BspLev3"]);
            }
            if (OLS01501.BspLev4.Exists() == true)
            {
                OLS01501.BspLev4.SetValue(1, table.Rows[0]["BspLev4"]);
            }
            if (OLS01501.BspLev5.Exists() == true)
            {
                OLS01501.BspLev5.SetValue(1, table.Rows[0]["BspLev5"]);
            }
            if (OLS01501.DrpOpt1.Exists() == true)
            {
                OLS01501.DrpOpt1.SetValue(1, table.Rows[0]["DrpOpt1"]);
            }
            if (OLS01501.DrpOpt2.Exists() == true)
            {
                OLS01501.DrpOpt2.SetValue(1, table.Rows[0]["DrpOpt2"]);
            }
            if (OLS01501.DrpOpt3.Exists() == true)
            {
                OLS01501.DrpOpt3.SetValue(1, table.Rows[0]["DrpOpt3"]);
            }
            if (OLS01501.DrpOpt4.Exists() == true)
            {
                OLS01501.DrpOpt4.SetValue(1, table.Rows[0]["DrpOpt4"]);
            }
            if (OLS01501.DrpOpt5.Exists() == true)
            {
                OLS01501.DrpOpt5.SetValue(1, table.Rows[0]["DrpOpt5"]);
            }
            if (OLS01501.DrpLev1.Exists() == true)
            {
                OLS01501.DrpLev1.SetValue(1, table.Rows[0]["DrpLev1"]);
            }
            if (OLS01501.DrpLev2.Exists() == true)
            {
                OLS01501.DrpLev2.SetValue(1, table.Rows[0]["DrpLev2"]);
            }
            if (OLS01501.DrpLev3.Exists() == true)
            {
                OLS01501.DrpLev3.SetValue(1, table.Rows[0]["DrpLev3"]);
            }
            if (OLS01501.DrpLev4.Exists() == true)
            {
                OLS01501.DrpLev4.SetValue(1, table.Rows[0]["DrpLev4"]);
            }
            if (OLS01501.DrpLev5.Exists() == true)
            {
                OLS01501.DrpLev5.SetValue(1, table.Rows[0]["DrpLev5"]);
            }
            OLS01501.SourceOption.SetValue(1, table.Rows[0]["SourceOption"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS01502 I continue with the following details:")]
        public void OLS01502ContinueWithTheFollowingDetails(Table table)
        {
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            string FromName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();

            if (FromName == "OLS01502")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
            }
        }

        [When(@"In OLS05001 I continue with the following details:")]
        public void OLS05001ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS05001");
            OLS05001.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS05001.LodgeDate.SetValue(1, table.Rows[0]["LodgeDate"]);
            OLS05001.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLS05001.BuyPlan.SetValue(1, table.Rows[0]["BuyPlan"]);
            OLS05001.Buyer.SetValue(1, table.Rows[0]["Buyer"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS05002 I continue with the following details:")]
        public void OLS05002ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS05002");
            OLS05002.BuyPlan.ValidateFieldValue(1, table.Rows[0]["BuyPlan"]);
            OLS05002.BuyPlanDesc.ValidateFieldValue(1, table.Rows[0]["BuyPlanDesc"]);
            OLS05002.BuyClass.ValidateFieldValue(1, table.Rows[0]["BuyClass"]);
            OLS05002.BuyClassDesc.ValidateFieldValue(1, table.Rows[0]["BuyClassDesc"]);
            OLS05002.BuyDate.SetValue(1, table.Rows[0]["BuyDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        [When(@"In OLS05101 I continue with the following details:")]
        public void OLS05101ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS05101");
            OLS05101.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS05101.LodgeDate.SetValue(1, table.Rows[0]["LodgeDate"]);
            OLS05101.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLS05101.SellPlan.SetValue(1, table.Rows[0]["SellPlan"]);
            OLS05101.Seller.SetValue(1, table.Rows[0]["Seller"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS05102 I continue with the following details:")]
        public void OLS05102ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS05102");
            OLS05102.SellPlan.ValidateFieldValue(1, table.Rows[0]["SellPlan"]);
            OLS05102.SellPlanDesc.ValidateFieldValue(1, table.Rows[0]["SellPlanDesc"]);
            OLS05102.SellClass.ValidateFieldValue(1, table.Rows[0]["SellClass"]);
            OLS05102.SellClassDesc.ValidateFieldValue(1, table.Rows[0]["SellClassDesc"]);
            OLS05102.SellHolderID.ValidateFieldValue(1, table.Rows[0]["Seller"]);
            OLS05102.SellDate.SetValue(1, table.Rows[0]["SellDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS05501 I continue with the following details:")]
        public void OLS05501ContinueWithTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS05501");
            OLS05501.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS05501.LodgeDate.SetValue(1, table.Rows[0]["LodgeDate"]);
            OLS05501.TotalUnits.SetValue(1, table.Rows[0]["TotalUnits"]);
            OLS05501.BuyClass.SetValue(1, table.Rows[0]["BuyClass"]);
            OLS05501.Buyer.SetValue(1, table.Rows[0]["Buyer"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"In OLS05502 I continue with the following details:")]
        public void WOLS05502ContinueWithTheFollowingDetails(Table table)
        {

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS05502");
            OLS05502.BuyClass.ValidateFieldValue(1, table.Rows[0]["BuyClass"]);
            OLS05502.BuyClassDesc.ValidateFieldValue(1, table.Rows[0]["BuyClassDesc"]);
            OLS05502.BuyHolderID.ValidateFieldValue(1, table.Rows[0]["Buyer"]);
            OLS05502.BuyDate.SetValue(1, table.Rows[0]["BuyDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
        }

        [When(@"IN OLSCRTUX I continue with the following details Swati:")]
        public void WhenINOLSCRTUXIContinueWithTheFollowingDetailsSwati(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTUX");
            OLSCRTUX.ConfirmUnits.SetValue(1, table.Rows[0]["ConfirmUnits"]);
            if (OLSCRTUX.UncertBuyReg.Exists()==true)
            {
                OLSCRTUX.UncertBuyReg.SetValue(1, table.Rows[0]["UncertBuyReg"]);
            }
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In EOL01701 I Change ESS Employee Details as:")]
        public void EOL01701ChangeESSEmployeeDetailsAs(Table table)
        {
            EOL01701.Action.SetValue(1, table.Rows[0]["Action"]);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("EOL01701");
            EOL01701.TransNumber.SetValue(1, table.Rows[0]["TranNo"]);
            EOL01701.PayrollID.SetValue(1, table.Rows[0]["PayrollID"]);
            EOL01701.EmployeeNumber.SetValue(1, table.Rows[0]["EmployeeID"]);
            EOL01701.EmployeeStatus.SetValue(1, table.Rows[0]["EmployeeStatus"]);
            EOL01701.EffectiveDate.SetValue(1, table.Rows[0]["EffectiveDate"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS06801 I enter below for negative tests")]
        public void OLS06801IEnterBelowForNegativeTests(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS06801");
            //SetValues
            OLS06801.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            if (OLS06801.KnownStatus1.Exists() == true)
                OLS06801.KnownStatus1.SetValue(1, table.Rows[0]["KnownStatus1"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();

        }

        [When(@"In OLS02901 I enter Nature Of Person as follows")]
        public void  OLSI02901EnterNatureOfPersonAsFollows(Table table )
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
            OLS02901.INNatureOFPerson.SetValue(1, table.Rows[0]["INNatureOFPerson"]);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
            
        }

        [When(@"In OLS02901 I enter all the following details")]
        public void OLS02901EnterAllTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");

            OLS02901.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);

            if (table.Rows[0]["IntermediaryInd"] != "") 
            OLS02901.IntermediaryInd.SetValue(1, table.Rows[0]["IntermediaryInd"]);

            if (table.Rows[0]["CustodianReference"] != "")
                OLS02901.CustodianReference.SetValue(1, table.Rows[0]["CustodianReference"]);

            if (table.Rows[0]["OtherStatus"] != "")
                OLS02901.OtherStatus.SetValue(1, table.Rows[0]["OtherStatus"]);

            if (table.Rows[0]["TaxCode"] != "")
                OLS02901.TaxCode.SetValue(1, table.Rows[0]["TaxCode"]);

            if (table.Rows[0]["TradingName1"] != "")
                OLS02901.TradingName1.SetValue(1, table.Rows[0]["TradingName1"]);

            if (table.Rows[0]["BenAddrName"] != "")
                OLS02901.BenAddrLine.SetValue(1, table.Rows[0]["BenAddrName"]);

            if (table.Rows[0]["BenAddrLine1"] != "")
                OLS02901.BenAddrLine.SetValue(2, table.Rows[0]["BenAddrLine1"]);

            if (table.Rows[0]["BenAddrLine2"] != "")
                 OLS02901.BenAddrLine.SetValue(3, table.Rows[0]["BenAddrLine2"]);

            if (table.Rows[0]["BenAddrLine3"] != "")
                OLS02901.BenAddrLine.SetValue(4, table.Rows[0]["BenAddrLine3"]);

            if (table.Rows[0]["BenAddrLine4"] != "")
                OLS02901.BenAddrLine.SetValue(5, table.Rows[0]["BenAddrLine4"]);

            if (table.Rows[0]["BenAddrLine5"] != "")
                OLS02901.BenAddrLine.SetValue(6, table.Rows[0]["BenAddrLine5"]);

            if (table.Rows[0]["TaxReference"] != "")
                OLS02901.TaxReference.SetValue(1, table.Rows[0]["TaxReference"]);

            if (table.Rows[0]["TaxRefType"] != "")
                OLS02901.TaxRefType.SetValue(1, table.Rows[0]["TaxRefType"]);
 
            if (table.Rows[0]["IDReference"] != "")
                OLS02901.IDReference.SetValue(1, table.Rows[0]["IDReference"]);

            if (table.Rows[0]["IDReferenceType"] != "")
                OLS02901.IDReferenceType.SetValue(1, table.Rows[0]["IDReferenceType"]);

            if (table.Rows[0]["DateBirth"] != "")
                OLS02901.DateBirth.SetValue(1, table.Rows[0]["DateBirth"]);

            if (table.Rows[0]["Phone"] != "")
                OLS02901.Phone.SetValue(1, table.Rows[0]["Phone"]);

            if (table.Rows[0]["Email"] != "")
                OLS02901.Email.SetValue(1, table.Rows[0]["Email"]);
            if (table.Rows[0]["RetName"] != "")
                OLS02901.RetLine.SetValue(1, table.Rows[0]["RetName"]);

            if (table.Rows[0]["RetLine1"] != "")
                OLS02901.RetLine.SetValue(2, table.Rows[0]["RetLine1"]);

            if (table.Rows[0]["RetLine2"] != "")
                OLS02901.RetLine.SetValue(3, table.Rows[0]["RetLine2"]);

            if (table.Rows[0]["RetLine3"] != "")
                OLS02901.RetLine.SetValue(4, table.Rows[0]["RetLine3"]);

            if (table.Rows[0]["RetLine4"] != "")
                OLS02901.RetLine.SetValue(5, table.Rows[0]["RetLine4"]);


            if (table.Rows[0]["RetLine5"] != "")
                OLS02901.RetLine.SetValue(6, table.Rows[0]["RetLine5"]);

            if (table.Rows[0]["RetAddrPC"] != "")
                OLS02901.RetAddrPC.SetValue(1, table.Rows[0]["RetAddrPC"]);


            if (table.Rows[0]["ExemptionCode"] != "")
                OLS02901.ExemptionCode.SetValue(1, table.Rows[0]["ExemptionCode"]);

            if (table.Rows[0]["CtryOFIssue"] != "")
                OLS02901.CtryOFIssue.SetValue(1, table.Rows[0]["CtryOFIssue"]);

            if (table.Rows[0]["CertStatus"] != "")
                OLS02901.CertStatus.SetValue(1, table.Rows[0]["CertStatus"]);


            if (table.Rows[0]["DecName"] != "")
                OLS02901.DecName.SetValue(1, table.Rows[0]["DecName"]);

            if (table.Rows[0]["DecCapCode"] != "")
                OLS02901.DecCapCode.SetValue(1, table.Rows[0]["DecCapCode"]);

            if (table.Rows[0]["DecDate"] != "")
                OLS02901.DecDate.SetValue(1, table.Rows[0]["DecDate"]);


            if (table.Rows[0]["UndName"] != "")
                OLS02901.UndName.SetValue(1, table.Rows[0]["UndName"]);
            if (table.Rows[0]["UndCapCode"] != "")
                OLS02901.UndCapCode.SetValue(1, table.Rows[0]["UndCapCode"]);
            if (table.Rows[0]["UndDate"] != "")
                OLS02901.UndDate.SetValue(1, table.Rows[0]["UndDate"]);
            if (table.Rows[0]["SigDate"] != "")
                OLS02901.SigDate.SetValue(1, table.Rows[0]["SigDate"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
        }


        [Then(@"In OLS02901 I verify TaxReference")]
        public void OLS02901IVerifyTaxReference(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");

            if (table.Rows[0]["TaxReference"] != "")
                OLS02901.TaxReference.ValidateFieldValue("Quoted");

        }

        [When(@"In OLS02901 I enter ""(.*)""")]
        public void OLS02901IEnter(string updateionAction)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
            OLS02901.Action.SetValue(1, updateionAction);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
        }

        [When(@"In OLS02901 I update all the following details")]
        public void WhenInOLSIUpdateAllTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
            OLS02901.TransNumber.SetValue(1, table.Rows[0]["UpdateTransNumber"]);
            OLS02901.IntermediaryInd.SetValue(1, table.Rows[0]["NewIntermediaryInd"]);
            OLS02901.CustodianReference.SetValue(1, table.Rows[0]["NewCustodianRef"]);
            OLS02901.OtherStatus.SetValue(1, table.Rows[0]["NewInternalStatus"]);
            OLS02901.TradingName1.SetValue(1, table.Rows[0]["NewTradingName"]);
            OLS02901.BenAddrLine.SetValue(2, table.Rows[0]["NewBenAdrLine1"]);


            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
        }


        [Then(@"In OLS02901 I verify following")]
        public void OLS02901IVerifyFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");

            if (table.Rows[0]["NewCustodianRef"] != "")
                OLS02901.CustodianReference.ValidateFieldValue(table.Rows[0]["NewCustodianRef"]);

        }

        [When(@"In OLS02901 I confirm the deleteion with ""(.*)"" ""(.*)""")]
        public void OLS02901IConfirmTheDeleteionWith(string transnumber, string confirmDelete)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
            OLS02901.TransNumber.SetValue(1,  transnumber);
            OLS02901.ConfirmDelete.SetValue(1, confirmDelete);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");

        }


        [Then(@"I Verify No ZAF details available for the holder")]
        public void ThenIVerifyNoZAFDetailsAvailableForTheHolder()
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02901");
            OLS02901.INNatureOFPerson.ValidateExists();

        }


        [When(@"In OLS02801 I enter Enity Type ""(.*)""")]
        public void OLS02801IEnterEnityType(string p1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
            OLS02801.INEntityType.SetValue(1,p1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");

        }



        [When(@"In OLS02801 I enter all the following details")]
        public void OLS02801IEnterAllTheFollowingDetails(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
             OLS02801.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);

            if (table.Rows[0]["IntermediaryInd"] != "")
                OLS02801.IntermediaryInd.SetValue(1, table.Rows[0]["IntermediaryInd"]);

            if (table.Rows[0]["CustodianReference"] != "")
                OLS02801.CustodianReference.SetValue(1, table.Rows[0]["CustodianReference"]);

            if (table.Rows[0]["OtherStatus"] != "")
                OLS02801.OtherStatus.SetValue(1, table.Rows[0]["OtherStatus"]);

            if (table.Rows[0]["TaxCode"] != "")
                OLS02801.TaxCode.SetValue(1, table.Rows[0]["TaxCode"]);

            if (table.Rows[0]["MailAddrName"] != "")
                OLS02801.MailAddrLine.SetValue(1, table.Rows[0]["MailAddrName"]);

            if (table.Rows[0]["MailAddrLine1"] != "")
                OLS02801.MailAddrLine.SetValue(2, table.Rows[0]["MailAddrLine1"]);

            if (table.Rows[0]["MailAddrLine2"] != "")
                OLS02801.MailAddrLine.SetValue(3, table.Rows[0]["MailAddrLine2"]);

            if (table.Rows[0]["MailAddrLine3"] != "")
                OLS02801.MailAddrLine.SetValue(4, table.Rows[0]["MailAddrLine3"]);

            if (table.Rows[0]["MailAddrLine4"] != "")
                OLS02801.MailAddrLine.SetValue(5, table.Rows[0]["MailAddrLine4"]);

            if (table.Rows[0]["MailAddrLine5"] != "")
                OLS02801.MailAddrLine.SetValue(6, table.Rows[0]["MailAddrLine5"]);

            if (table.Rows[0]["MailAddrPostcode"] != "")
                OLS02801.MailAddrPostcode.SetValue(1, table.Rows[0]["MailAddrPostcode"]);

            if (table.Rows[0]["BenAddrName"] != "")
                OLS02801.BenAddrLine.SetValue(1, table.Rows[0]["BenAddrName"]);

            if (table.Rows[0]["BenAddrLine1"] != "")
                OLS02801.BenAddrLine.SetValue(2, table.Rows[0]["BenAddrLine1"]);

            if (table.Rows[0]["BenAddrLine2"] != "")
                OLS02801.BenAddrLine.SetValue(3, table.Rows[0]["BenAddrLine2"]);

            if (table.Rows[0]["BenAddrLine3"] != "")
                OLS02801.BenAddrLine.SetValue(4, table.Rows[0]["BenAddrLine3"]);

            if (table.Rows[0]["BenAddrLine4"] != "")
                OLS02801.BenAddrLine.SetValue(5, table.Rows[0]["BenAddrLine4"]);

            if (table.Rows[0]["BenAddrLine5"] != "")
                OLS02801.BenAddrLine.SetValue(6, table.Rows[0]["BenAddrLine5"]);

            if (table.Rows[0]["BenAddrPC"] != "")
                OLS02801.MailAddrPostcode.SetValue(1, table.Rows[0]["BenAddrPC"]);

            if (table.Rows[0]["RetName"] != "")
                OLS02801.RetLine.SetValue(1, table.Rows[0]["RetName"]);

            if (table.Rows[0]["RetLine1"] != "")
                OLS02801.RetLine.SetValue(2, table.Rows[0]["RetLine1"]);

            if (table.Rows[0]["RetLine2"] != "")
                OLS02801.RetLine.SetValue(3, table.Rows[0]["RetLine2"]);

            if (table.Rows[0]["RetLine3"] != "")
                OLS02801.RetLine.SetValue(4, table.Rows[0]["RetLine3"]);

            if (table.Rows[0]["RetLine4"] != "")
                OLS02801.RetLine.SetValue(5, table.Rows[0]["RetLine4"]);

            if (table.Rows[0]["RetLine5"] != "")
                OLS02801.RetLine.SetValue(6, table.Rows[0]["RetLine5"]);

            if (table.Rows[0]["RetAddrPC"] != "")
                OLS02801.RetAddrPC.SetValue(1, table.Rows[0]["RetAddrPC"]);

            if (table.Rows[0]["TaxReference"] != "")
                OLS02801.TaxReference.SetValue(1, table.Rows[0]["TaxReference"]);

            if (table.Rows[0]["TaxRefType"] != "")
                OLS02801.TaxRefType.SetValue(1, table.Rows[0]["TaxRefType"]);

            if (table.Rows[0]["DateBirth"] != "")
                OLS02801.DateBirth.SetValue(1, table.Rows[0]["DateBirth"]);

            if (table.Rows[0]["PrevName"] != "")
                OLS02801.PrevName.SetValue(1, table.Rows[0]["PrevName"]);

            if (table.Rows[0]["DwtExpiryCcyy"] != "")
                OLS02801.DwtExpiryCcyy.SetValue(1, table.Rows[0]["DwtExpiryCcyy"]);

            if (table.Rows[0]["SigName"] != "")
                OLS02801.SigName.SetValue(1, table.Rows[0]["SigName"]);

            if (table.Rows[0]["SigCapType"] != "")
                OLS02801.SigCapType.SetValue(1, table.Rows[0]["SigCapType"]);

            if (table.Rows[0]["SigDate"] != "")
                OLS02801.SigDate.SetValue(1, table.Rows[0]["SigDate"]);

            if (table.Rows[0]["SigPhone"] != "")
                OLS02801.SigPhone.SetValue(1, table.Rows[0]["SigPhone"]);

            if (table.Rows[0]["CertStatus"] != "")
                OLS02801.CertStatus.SetValue(1, table.Rows[0]["CertStatus"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");

        }

        [Then(@"In OLS02801 I verify TaxReference")]
        public void OLS02801IVerifyTaxReference(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");

            if (table.Rows[0]["TaxReference"] != "")
                OLS02801.TaxReference.ValidateFieldValue("Quoted");

        }

        [When(@"In OLS02801 I update all the following details")]
        public void OLS02801IUpdateAllTheFollowingDetails(Table  table)
        {


            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
            OLS02801.TransNumber.SetValue(1, table.Rows[0]["UpdateTransNumber"]);


            if (table.Rows[0]["NewPrevName"] != "")
                OLS02801.PrevName.SetValue(1, table.Rows[0]["NewPrevName"]);

            if (table.Rows[0]["NewSigCapType"] != "")
                OLS02801.SigCapType.SetValue(1, table.Rows[0]["NewSigCapType"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
        }



        [Then(@"In OLS02801 I verify following after update")]
        public void OLS02801IVerifyFollowingAfterUpdate(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");

            if (table.Rows[0]["NewPrevName"] != "")
                OLS02801.PrevName.ValidateFieldValue(table.Rows[0]["NewPrevName"]);

            if (table.Rows[0]["NewSigCapType"] != "")
                OLS02801.SigCapType.ValidateFieldValue(table.Rows[0]["NewSigCapType"]);

        }


        [Then(@"In OLS02801 I enter ""(.*)""")]
        [When(@"In OLS02801 I enter ""(.*)""")]
        public void OLS02801IEnter(string deleteAction)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
            OLS02801.Action.SetValue(1, deleteAction);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
        }

        [When(@"In OLS02801 I confirm the deleteion with ""(.*)"" ""(.*)""")]
        public void OLS02801IConfirmTheDeleteionWith(string transnumber, string confirmDelete)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
            OLS02801.TransNumber.SetValue(1, transnumber);
            OLS02801.ConfirmDelete.SetValue(1, confirmDelete);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");  

        }

        [Then(@"I Verify No IRL details available for the holder")]
        public void IVerifyNoIRLDetailsAvailableForTheHolder()
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");
            OLS02801.INEntityType.ValidateExists();
        }



        [Then(@"In OLS02801 I verify following")]
        public void OLS02801IVerifyFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS02801");

                OLS02801.IntermediaryInd.ValidateFieldValue(1, table.Rows[0]["IntermediaryInd"]);
                OLS02801.CustodianReference.ValidateFieldValue(1, table.Rows[0]["CustodianReference"]);
                OLS02801.OtherStatus.ValidateFieldValue(1, table.Rows[0]["OtherStatus"]);
                OLS02801.TaxCode.ValidateFieldValue(1, table.Rows[0]["TaxCode"]);
                OLS02801.MailAddrLine.ValidateFieldValue(1, table.Rows[0]["MailAddrName"]);
                OLS02801.MailAddrLine.ValidateFieldValue(2, table.Rows[0]["MailAddrLine1"]);
                OLS02801.MailAddrLine.ValidateFieldValue(3, table.Rows[0]["MailAddrLine2"]);
                OLS02801.MailAddrLine.ValidateFieldValue(4, table.Rows[0]["MailAddrLine3"]);
                OLS02801.MailAddrLine.ValidateFieldValue(5, table.Rows[0]["MailAddrLine4"]);
                OLS02801.MailAddrLine.ValidateFieldValue(6, table.Rows[0]["MailAddrLine5"]);
                OLS02801.MailAddrPostcode.ValidateFieldValue(1, table.Rows[0]["MailAddrPostcode"]);
                OLS02801.BenAddrLine.ValidateFieldValue(1, table.Rows[0]["BenAddrName"]);
                OLS02801.BenAddrLine.ValidateFieldValue(2, table.Rows[0]["BenAddrLine1"]);
                OLS02801.BenAddrLine.ValidateFieldValue(3, table.Rows[0]["BenAddrLine2"]);
                OLS02801.BenAddrLine.ValidateFieldValue(4, table.Rows[0]["BenAddrLine3"]);
                OLS02801.BenAddrLine.ValidateFieldValue(5, table.Rows[0]["BenAddrLine4"]);
                OLS02801.BenAddrLine.ValidateFieldValue(6, table.Rows[0]["BenAddrLine5"]);
                OLS02801.MailAddrPostcode.ValidateFieldValue(1, table.Rows[0]["BenAddrPC"]);
                OLS02801.RetLine.ValidateFieldValue(1, table.Rows[0]["RetName"]);
                OLS02801.RetLine.ValidateFieldValue(2, table.Rows[0]["RetLine1"]);
                OLS02801.RetLine.ValidateFieldValue(3, table.Rows[0]["RetLine2"]);
                OLS02801.RetLine.ValidateFieldValue(4, table.Rows[0]["RetLine3"]);
                OLS02801.RetLine.ValidateFieldValue(5, table.Rows[0]["RetLine4"]);
                OLS02801.RetLine.ValidateFieldValue(6, table.Rows[0]["RetLine5"]);
                OLS02801.RetAddrPC.ValidateFieldValue(1, table.Rows[0]["RetAddrPC"]);
                OLS02801.TaxReference.ValidateFieldValue(1, table.Rows[0]["TaxReference"]);
                OLS02801.TaxRefType.ValidateFieldValue(1, table.Rows[0]["TaxRefType"]);
                OLS02801.DateBirth.ValidateFieldValue(1, table.Rows[0]["DateBirth"]);
                OLS02801.PrevName.ValidateFieldValue(1, table.Rows[0]["PrevName"]);
                OLS02801.DwtExpiryCcyy.ValidateFieldValue(1, table.Rows[0]["DwtExpiryCcyy"]);
                OLS02801.SigName.ValidateFieldValue(1, table.Rows[0]["SigName"]);
                OLS02801.SigCapType.ValidateFieldValue(1, table.Rows[0]["SigCapType"]);
                OLS02801.SigDate.ValidateFieldValue(1, table.Rows[0]["SigDate"]);
                OLS02801.SigPhone.ValidateFieldValue(1, table.Rows[0]["SigPhone"]);
                OLS02801.CertStatus.ValidateFieldValue(1, table.Rows[0]["CertStatus"]);

        }

        [When(@"In OLSCRTWS I continue with ""(.*)""")]
        public void InOLSCRTWSIContinueWith(string p0)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTWS");
            OLSCRTWS.Confirm.SetValue(1, p0);
            WinFormsTestSteps.ExpectToBeInTheScreen("OLSCRTUU");

        }

        [When(@"In OLS03102 I enter action ""(.*)""")]
        public void InOLS03102IEnterAction(string action)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03102");
            OLS03102.Action.SetValue(1, action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03103");
            
        }

        [When(@"In OLS03101 I enter action ""(.*)""")]
        public void InOLS03101IEnterAction(string action)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03101");
            OLS03102.Action.SetValue(1, action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03103");

        }



        [When(@"In OLS03103 I continue with following")]
        public void InOLS03103IContinueWithFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03103");

            if (table.Rows[0]["TransNbrI"] != "")
                OLS03103.TransNbrI.SetValue(1, table.Rows[0]["TransNbrI"]);

            

            if (table.Rows[0]["InvAccountType"] != "")
                OLS03103.InvAccountType.SetValue(1, table.Rows[0]["InvAccountType"]);

            OLS03103.InvAccountType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            if (table.Rows[0]["InvName"] != "")
                OLS03103.InvName.SetValue(1, table.Rows[0]["InvName"]);

            if (table.Rows[0]["InvTinStatus"] != "")
                OLS03103.InvTinStatus.SetValue(1, table.Rows[0]["InvTinStatus"]);

            if (table.Rows[0]["InvTin"] != "")
                OLS03103.InvTin.SetValue(1, table.Rows[0]["InvTin"]);

            if (table.Rows[0]["InvUSTaxCode"] != "")
                OLS03103.InvUSTaxCode.SetValue(1, table.Rows[0]["InvUSTaxCode"]);

            if (table.Rows[0]["W8ExpiryDate"] != "")
                OLS03103.W8ExpiryDate.SetValue(1, table.Rows[0]["W8ExpiryDate"]);
            
            if (table.Rows[0]["InvChapter3"] != "")
                OLS03103.InvChapter3.SetValue(1, table.Rows[0]["InvChapter3"]);

            if (table.Rows[0]["InvChapter4"] != "")
                OLS03103.InvChapter4.SetValue(1, table.Rows[0]["InvChapter4"]);

            if (table.Rows[0]["InvBirthDate"] != "")
                OLS03103.InvBirthDate.SetValue(1, table.Rows[0]["InvBirthDate"]);

            if (table.Rows[0]["InvCountryIncorp"] != "")
                OLS03103.InvCountryIncorp.SetValue(1, table.Rows[0]["InvCountryIncorp"]);

               if (table.Rows[0]["InvForeignTaxID"] != "")
                OLS03103.InvForeignTaxID.SetValue(1, table.Rows[0]["InvForeignTaxID"]);

            if (table.Rows[0]["InvCountryIncorp"] != "")
                OLS03103.InvCountryIncorp.SetValue(1, table.Rows[0]["InvCountryIncorp"]);

            if (table.Rows[0]["InvAddress1"] != "")
                OLS03103.InvAddress1.SetValue(1, table.Rows[0]["InvAddress1"]);

            if (table.Rows[0]["InvAddress2"] != "")
                OLS03103.InvAddress2.SetValue(1, table.Rows[0]["InvAddress2"]);

            if (table.Rows[0]["InvGiinP1"] != "")
                OLS03103.InvGiinP1.SetValue(1, table.Rows[0]["InvGiinP1"]);

            if (table.Rows[0]["InvGiinP2"] != "")
                OLS03103.InvGiinP2.SetValue(1, table.Rows[0]["InvGiinP2"]);

            if (table.Rows[0]["InvGiinP3"] != "")
                OLS03103.InvGiinP3.SetValue(1, table.Rows[0]["InvGiinP3"]);

            if (table.Rows[0]["InvGiinP4"] != "")
                OLS03103.InvGiinP4.SetValue(1, table.Rows[0]["InvGiinP4"]);

            if (table.Rows[0]["InvGiinException"] != "")
                OLS03103.InvGiinException.SetValue(1, table.Rows[0]["InvGiinException"]);

            if (table.Rows[0]["AddBen"] != "")
                OLS03103.AddBen.SetValue(1, table.Rows[0]["AddBen"]);
          
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();

            string currentScreenName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (currentScreenName == "OLS03197")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }

        }

        [When(@"In OLS03102 I verfiy following for row ""(.*)""")]
        public void InOLS03102IVerfiyFollowingForRow(int rowNo, Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03102");
            OLS03102.InvName.ValidateFieldValue(rowNo, table.Rows[0]["InvName"]);
            OLS03102.InvType.ValidateFieldValue(rowNo, table.Rows[0]["InvType"]);
            OLS03102.InvTinStatus.ValidateFieldValue(rowNo, table.Rows[0]["InvTinStatus"]);
            OLS03102.InvW8Exp.ValidateFieldValue(rowNo, table.Rows[0]["InvW8Exp"]);
            OLS03102.InvChpt3.ValidateFieldValue(rowNo, table.Rows[0]["InvChpt3"]);
            OLS03102.InvChpt4.ValidateFieldValue(rowNo, table.Rows[0]["InvChpt4"]);
            
        }

        [When(@"In OLS03103 I enter action ""(.*)""")]
        public void InOLS03103IEnterAction(string action)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03103");
            OLS03103.Action.SetValue(1, action);
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03103");
         }

        [When(@"In OLS03103 I confirm deletion with TransactionNo ""(.*)""")]
        public void InOLS03103IConfirmDeletionWithTransactionNo(string tranNo)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03103");
            OLS03103.Confirm.SetValue(1, "Y");
            OLS03103.TransNbrI.SetValue(1, tranNo);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03102");
        }


        [When(@"In OLS03104 I enter action ""(.*)""")]
        public void InOLS3104IEnterAction(string p1)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03104");
            OLS03104.Action.SetValue(1, p1);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
        }

        [When(@"In OLS03105 I continue with following")]
        public void InOLS03105IContinueWithFollowing(Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03105");

            if (table.Rows[0]["CntAccountType"] != "")
                OLS03105.CntAccountType.SetValue(1, table.Rows[0]["CntAccountType"]);

            OLS03105.CntAccountType.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            if (table.Rows[0]["CntName"] != "")
                OLS03105.CntName.SetValue(1, table.Rows[0]["CntName"]);

            if (table.Rows[0]["CntAddressLine1"] != "")
                OLS03105.CntAddressLine.SetValue(1, table.Rows[0]["CntAddressLine1"]);

            if (table.Rows[0]["CntAddressLine2"] != "")
                OLS03105.CntAddressLine.SetValue(2, table.Rows[0]["CntAddressLine2"]);

            if (table.Rows[0]["CntAddressLine3"] != "")
                OLS03105.CntAddressLine.SetValue(3, table.Rows[0]["CntAddressLine3"]);

            if (table.Rows[0]["CntAddressLine4"] != "")
                OLS03105.CntAddressLine.SetValue(4, table.Rows[0]["CntAddressLine4"]);

            if (table.Rows[0]["CntPostcode"] != "")
                OLS03105.CntPostcode.SetValue(1, table.Rows[0]["CntPostcode"]);

            if (table.Rows[0]["Country"] != "")
                OLS03105.Country.SetValue(1, table.Rows[0]["Country"]);

            if (table.Rows[0]["TinStatus"] != "")
                OLS03105.TinStatus.SetValue(1, table.Rows[0]["TinStatus"]);

            if (table.Rows[0]["Ols03105CntTin"] != "")
                OLS03105.Ols03105CntTin.SetValue(1, table.Rows[0]["Ols03105CntTin"]);

            if (table.Rows[0]["USTaxCode"] != "")
                OLS03105.USTaxCode.SetValue(1, table.Rows[0]["USTaxCode"]);

            if (table.Rows[0]["Ols03105CntW8ExpDate"] != "")
                OLS03105.Ols03105CntW8ExpDate.SetValue(1, table.Rows[0]["Ols03105CntW8ExpDate"]);

            if (table.Rows[0]["Ols03105CntChpt3"] != "")
                OLS03105.Ols03105CntChpt3.SetValue(1, table.Rows[0]["Ols03105CntChpt3"]);

            if (table.Rows[0]["Ols03105CntChpt4"] != "")
                OLS03105.Ols03105CntChpt4.SetValue(1, table.Rows[0]["Ols03105CntChpt4"]);

            if (table.Rows[0]["Ols03105CntDobIncorp"] != "")
                OLS03105.Ols03105CntDobIncorp.SetValue(1, table.Rows[0]["Ols03105CntDobIncorp"]);
            
            if (table.Rows[0]["Ols03105CntCitizenship"] != "")
                OLS03105.Ols03105CntCitizenship.SetValue(1, table.Rows[0]["Ols03105CntCitizenship"]);

            if (table.Rows[0]["Ols03105CntTaxIdentifier"] != "")
                OLS03105.Ols03105CntTaxIdentifier.SetValue(1, table.Rows[0]["Ols03105CntTaxIdentifier"]);

            if (table.Rows[0]["Ols03105CntGiinP1"] != "")
                OLS03105.Ols03105CntGiinP1.SetValue(1, table.Rows[0]["Ols03105CntGiinP1"]);

            if (table.Rows[0]["CntGiinP2"] != "")
                OLS03105.CntGiinP2.SetValue(1, table.Rows[0]["CntGiinP2"]);

            if (table.Rows[0]["CntGiinP3"] != "")
                OLS03105.CntGiinP3.SetValue(1, table.Rows[0]["CntGiinP3"]);

            if (table.Rows[0]["CntGiinP4"] != "")
                OLS03105.CntGiinP4.SetValue(1, table.Rows[0]["CntGiinP4"]);

            if (table.Rows[0]["Ols03105CntGiinException"] != "")
                OLS03105.Ols03105CntGiinException.SetValue(1, table.Rows[0]["Ols03105CntGiinException"]);

            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            
            string currentScreenName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (currentScreenName == "OLS03197")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
        }

        [When(@"In OLS03104 I verfiy following for row ""(.*)""")]
        public void InOLS3104IVerfiyFollowingForRow(int rowNo, Table table)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03104");
            OLS03104.CntName.ValidateFieldValue(rowNo, table.Rows[0]["CntName"]);
            OLS03104.CntResCountry.ValidateFieldValue(rowNo, table.Rows[0]["CntResCountry"]);
            OLS03104.CntCtznCountry.ValidateFieldValue(rowNo, table.Rows[0]["CntCtznCountry"]);
            OLS03104.CntBen.ValidateFieldValue(rowNo, table.Rows[0]["CntBen"]);
        }


        [When(@"In OLS03105 I enter action ""(.*)"" ""(.*)""")]
        public void InOLS3105IEnterAction(string p1, string confirm)
        {
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS03105");
            OLS03105.Action.SetValue(1, p1);
            OLS03105.Action.ClickField();
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();

            if (confirm != "")
            {
                OLS03105.Ols03105Confirm.SetValue(1, confirm);
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }
            else
            { 
            Spartan.Core.WinForms.WinFormsDriver.PressTAB();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
                }
        }

        [When(@"In OLS08601 I continue with the following details:")]
        public void OLS08601ContinueWithTheFollowingDetails(Table table)
        {

            DateTime today = DateTime.Today;
            var CurrentDate = today.ToString("dd/MM/yyyy");

            WinFormsTestSteps.ExpectToBeInTheScreen("OLS08601");
            OLS08601.TransNumber.SetValue(1, table.Rows[0]["TransNumber"]);
            OLS08601.TotalMoney.SetValue(1, table.Rows[0]["TotalMoney"]);
            OLS08601.SubsystemCode.SetValue(1, table.Rows[0]["SubsystemCode"]);
            OLS08601.SubsystemID.SetValue(1, table.Rows[0]["SubsystemID"]);
            OLS08601.ClassCode.SetValue(1, table.Rows[0]["ClassCode"]);
            OLS08601.ReferenceNumber.SetValue(1, table.Rows[0]["ReferenceNumber"]);
            OLS08601.HolderIdentifier.SetValue(1, table.Rows[0]["HolderIdentifier"]);
            OLS08601.ControlAccInd.SetValue(1, table.Rows[0]["ControlAccInd"]);
            OLS08601.PaymentSource.SetValue(1, table.Rows[0]["PaymentSource"]);
            OLS08601.TransDate.SetValue(1, CurrentDate);
            OLS08601.CustomerRefNO.SetValue(1, table.Rows[0]["CustomerRefNO"]);
            OLS08601.PaymentDate.SetValue(1, CurrentDate);
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            WinFormsTestSteps.ExpectToBeInTheScreen("OLS08602");
            Spartan.Core.WinForms.WinFormsDriver.Transmit();
            Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            var formName = Spartan.Core.WinForms.WinFormsDriver.GetFormName();
            if (formName == "OLSACCSE")
            {
                Spartan.Core.WinForms.WinFormsDriver.Transmit();
                Spartan.Core.WinForms.WinFormsDriver.WaitUntilReady();
            }


            WinFormsTestSteps.ExpectToBeInTheScreen("OLS08601");


        }



    }

}


