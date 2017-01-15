using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS09003
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS09003", "FormName");
        //Fields
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ChequeFormat = new WinFormsField("CHEQUE-FORMAT", "ChequeFormat");
        public static WinFormsField ChequeDate = new WinFormsField("CHEQUE-DATE", "ChequeDate");
        public static WinFormsField UpperComment = new WinFormsField("UPPER-COMMENT", "UpperComment");
        public static WinFormsField LowerComment = new WinFormsField("LOWER-COMMENT", "LowerComment");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
