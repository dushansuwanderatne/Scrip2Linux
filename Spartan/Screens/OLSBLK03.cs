using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSBLK03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSBLK03", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkCode = new WinFormsField("BULK-CODE", "BulkCode");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField FirstTransNbr = new WinFormsField("FIRST-TRANS-NBR", "FirstTransNbr");
        public static WinFormsField LastTransNbr = new WinFormsField("LAST-TRANS-NBR", "LastTransNbr");
        public static WinFormsField AdviceProgram = new WinFormsField("ADVICE-PROGRAM", "AdviceProgram");
        public static WinFormsField MenuAction = new WinFormsField("MENU-ACTION", "MenuAction");
        public static WinFormsField Dot = new WinFormsField("DOT", "Dot");
        public static WinFormsField MenuDesc = new WinFormsField("MENU-DESC", "MenuDesc");
        public static WinFormsField MenuSelection = new WinFormsField("MENU-SELECTION", "MenuSelection");
        public static WinFormsField FromTransNbr = new WinFormsField("FROM-TRANS-NBR", "FromTransNbr");
        public static WinFormsField TOTransNbr = new WinFormsField("TO-TRANS-NBR", "TOTransNbr");
        public static WinFormsField SelectAuditedTrans = new WinFormsField("SELECT-AUDITED-TRANS", "SelectAuditedTrans");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
