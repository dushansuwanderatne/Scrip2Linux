using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSUS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSUS01", "FormName");
		//Fields


        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField OldWorstCaseNbr = new WinFormsField("OLD-WORST-CASE-NBR", "OldWorstCaseNbr");
        public static WinFormsField NewWorstCaseNbr = new WinFormsField("NEW-WORST-CASE-NBR", "NewWorstCaseNbr");
        public static WinFormsField OldCuringStatus = new WinFormsField("OLD-CURING-STATUS", "OldCuringStatus");
        public static WinFormsField NewCuringStatus = new WinFormsField("NEW-CURING-STATUS", "NewCuringStatus");
        public static WinFormsField OldOrideAccType = new WinFormsField("OLD-ORIDE-ACC-TYPE", "OldOrideAccType");
        public static WinFormsField NewOrideAccType = new WinFormsField("NEW-ORIDE-ACC-TYPE", "NewOrideAccType");
        public static WinFormsField OldOridePreEXInd = new WinFormsField("OLD-ORIDE-PRE-EX-IND", "OldOridePreEXInd");
        public static WinFormsField NewOridePreEXInd = new WinFormsField("NEW-ORIDE-PRE-EX-IND", "NewOridePreEXInd");
        public static WinFormsField OldOrideTinStatus = new WinFormsField("OLD-ORIDE-TIN-STATUS", "OldOrideTinStatus");
        public static WinFormsField NewOrideTinStatus = new WinFormsField("NEW-ORIDE-TIN-STATUS", "NewOrideTinStatus");
        public static WinFormsField OldOrideUSIndicia = new WinFormsField("OLD-ORIDE-US-INDICIA", "OldOrideUSIndicia");
        public static WinFormsField NewOrideUSIndicia = new WinFormsField("NEW-ORIDE-US-INDICIA", "NewOrideUSIndicia");
        public static WinFormsField OldOrideUSTaxCode = new WinFormsField("OLD-ORIDE-US-TAX-CODE", "OldOrideUSTaxCode");
        public static WinFormsField NewOrideUSTaxCode = new WinFormsField("NEW-ORIDE-US-TAX-CODE", "NewOrideUSTaxCode");
        public static WinFormsField OldOrideTaxType = new WinFormsField("OLD-ORIDE-TAX-TYPE", "OldOrideTaxType");
        public static WinFormsField NewOrideTaxType = new WinFormsField("NEW-ORIDE-TAX-TYPE", "NewOrideTaxType");
        public static WinFormsField OldHolderParentID = new WinFormsField("OLD-HOLDER-PARENT-ID", "OldHolderParentID");
        public static WinFormsField NewHolderParentID = new WinFormsField("NEW-HOLDER-PARENT-ID", "NewHolderParentID");
        public static WinFormsField ScreenCount = new WinFormsField("SCREEN-COUNT", "ScreenCount");
        public static WinFormsField ScreenTotal = new WinFormsField("SCREEN-TOTAL", "ScreenTotal");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
