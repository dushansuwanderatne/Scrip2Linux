using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ACC01050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ACC01050", "FormName");
		//Fields


        public static WinFormsField SubSystemID = new WinFormsField("SUB-SYSTEM-ID", "SubSystemID");
        public static WinFormsField SubSystemDesc = new WinFormsField("SUB-SYSTEM-DESC", "SubSystemDesc");
        public static WinFormsField PendingLine = new WinFormsField("PENDING-LINE", "PendingLine");
        public static WinFormsField TotNOPayments = new WinFormsField("TOT-NO-PAYMENTS", "TotNOPayments");
        public static WinFormsField TotMoneyPaid = new WinFormsField("TOT-MONEY-PAID", "TotMoneyPaid");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
