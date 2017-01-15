using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS11010
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("OLS11010", "FormName");
        //Fields
        public static WinFormsField WarningLit = new WinFormsField("WARNING-LIT", "WarningLit");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField Confirmation = new WinFormsField("CONFIRMATION", "Confirmation");
        public static WinFormsField MailFileName = new WinFormsField("MAIL-FILE-NAME", "MailFileName");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField FileNameBody = new WinFormsField("FILENAME-BODY", "FileNameBody");
    }
}