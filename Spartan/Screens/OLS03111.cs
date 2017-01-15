using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03111

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03111", "FormName");
		//Fields


        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNbrI = new WinFormsField("TRANS-NBR-I", "TransNbrI");
        public static WinFormsField TransDateI = new WinFormsField("TRANS-DATE-I", "TransDateI");
        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField SysAccountType = new WinFormsField("SYS-ACCOUNT-TYPE", "SysAccountType");
        public static WinFormsField USTaxCode = new WinFormsField("US-TAX-CODE", "USTaxCode");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField PreExisting = new WinFormsField("PRE-EXISTING", "PreExisting");
        public static WinFormsField SysPreExisting = new WinFormsField("SYS-PRE-EXISTING", "SysPreExisting");
        public static WinFormsField IntermediaryID = new WinFormsField("INTERMEDIARY-ID", "IntermediaryID");
        public static WinFormsField CuringLevel = new WinFormsField("CURING-LEVEL", "CuringLevel");
        public static WinFormsField TinStatus = new WinFormsField("TIN-STATUS", "TinStatus");
        public static WinFormsField SysTinStatus = new WinFormsField("SYS-TIN-STATUS", "SysTinStatus");
        public static WinFormsField AddInvestors = new WinFormsField("ADD-INVESTORS", "AddInvestors");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
