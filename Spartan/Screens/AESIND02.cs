using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AESIND02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AESIND02", "FormName");
		//Fields


        public static WinFormsField Identifier = new WinFormsField("IDENTIFIER", "Identifier");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField NotingAction = new WinFormsField("NOTING-ACTION", "NotingAction");
        public static WinFormsField Locate = new WinFormsField("LOCATE", "Locate");
        public static WinFormsField LastChgDate = new WinFormsField("LAST-CHG-DATE", "LastChgDate");
        public static WinFormsField LastChgMsgid = new WinFormsField("LAST-CHG-MSGID", "LastChgMsgid");
        public static WinFormsField LastChgName = new WinFormsField("LAST-CHG-NAME", "LastChgName");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
