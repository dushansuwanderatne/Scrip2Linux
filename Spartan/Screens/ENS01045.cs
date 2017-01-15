using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01045

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01045", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField TinStatus = new WinFormsField("TIN-STATUS", "TinStatus");
        public static WinFormsField TinFormatted = new WinFormsField("TIN-FORMATTED", "TinFormatted");
        public static WinFormsField TinName = new WinFormsField("TIN-NAME", "TinName");
        public static WinFormsField TinType = new WinFormsField("TIN-TYPE", "TinType");
        public static WinFormsField TinExpiryDate = new WinFormsField("TIN-EXPIRY-DATE", "TinExpiryDate");
        public static WinFormsField HolderParentIdent = new WinFormsField("HOLDER-PARENT-IDENT", "HolderParentIdent");
        public static WinFormsField USTaxCode = new WinFormsField("US-TAX-CODE", "USTaxCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
