using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM07", "FormName");
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
        public static WinFormsField OldTinStatus = new WinFormsField("OLD-TIN-STATUS", "OldTinStatus");
        public static WinFormsField NewTinStatus = new WinFormsField("NEW-TIN-STATUS", "NewTinStatus");
        public static WinFormsField OldTinType = new WinFormsField("OLD-TIN-TYPE", "OldTinType");
        public static WinFormsField NewTinType = new WinFormsField("NEW-TIN-TYPE", "NewTinType");
        public static WinFormsField OldTinFormatted = new WinFormsField("OLD-TIN-FORMATTED", "OldTinFormatted");
        public static WinFormsField NewTinFormatted = new WinFormsField("NEW-TIN-FORMATTED", "NewTinFormatted");
        public static WinFormsField OldTinName = new WinFormsField("OLD-TIN-NAME", "OldTinName");
        public static WinFormsField NewTinName = new WinFormsField("NEW-TIN-NAME", "NewTinName");
        public static WinFormsField OldTinExpiryDate = new WinFormsField("OLD-TIN-EXPIRY-DATE", "OldTinExpiryDate");
        public static WinFormsField NewTinExpiryDate = new WinFormsField("NEW-TIN-EXPIRY-DATE", "NewTinExpiryDate");
        public static WinFormsField OldHolderParentID = new WinFormsField("OLD-HOLDER-PARENT-ID", "OldHolderParentID");
        public static WinFormsField NewHolderParentID = new WinFormsField("NEW-HOLDER-PARENT-ID", "NewHolderParentID");
        public static WinFormsField OldUSTaxCode = new WinFormsField("OLD-US-TAX-CODE", "OldUSTaxCode");
        public static WinFormsField NewUSTaxCode = new WinFormsField("NEW-US-TAX-CODE", "NewUSTaxCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
