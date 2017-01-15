using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17002", "FormName");
		//Fields


        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField ExtractFile = new WinFormsField("EXTRACT-FILE", "ExtractFile");
        public static WinFormsField IsssrCloneID = new WinFormsField("ISSSR-CLONE-ID", "IsssrCloneID");
        public static WinFormsField IsssrClone4 = new WinFormsField("ISSSR-CLONE-4", "IsssrClone4");
        public static WinFormsField TransactionDate = new WinFormsField("TRANSACTION-DATE", "TransactionDate");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
