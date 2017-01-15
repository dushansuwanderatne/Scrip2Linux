using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13003
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS13003", "FormName");
        //Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Companies = new WinFormsField("COMPANIES", "Companies");
        public static WinFormsField OutputFormat = new WinFormsField("OUTPUT-FORMAT", "OutputFormat");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
    }
}
