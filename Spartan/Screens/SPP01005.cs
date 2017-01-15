using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP01005", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField DomicileCode = new WinFormsField("DOMICILE-CODE", "DomicileCode");
        public static WinFormsField AccountName = new WinFormsField("ACCOUNT-NAME", "AccountName");
        public static WinFormsField BsbNbr = new WinFormsField("BSB-NBR", "BsbNbr");
        public static WinFormsField AccountNbr = new WinFormsField("ACCOUNT-NBR", "AccountNbr");
        public static WinFormsField DebitAmt = new WinFormsField("DEBIT-AMT", "DebitAmt");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
