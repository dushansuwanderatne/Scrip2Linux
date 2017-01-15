using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10039
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10039", "FormName");
        //Fields
        public static WinFormsField ExtraIdentifier = new WinFormsField("EXTRA-IDENTIFIER", "ExtraIdentifier");
        public static WinFormsField HomePhone = new WinFormsField("HOME-PHONE", "HomePhone");
        public static WinFormsField WorkPhone = new WinFormsField("WORK-PHONE", "WorkPhone");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField MobilePhone = new WinFormsField("MOBILE-PHONE", "MobilePhone");
        public static WinFormsField Abn = new WinFormsField("ABN", "Abn");
        public static WinFormsField ExtraWarningFlags = new WinFormsField("EXTRA-WARNING-FLAGS", "ExtraWarningFlags");
        public static WinFormsField EmailAddress = new WinFormsField("EMAIL-ADDRESS", "EmailAddress");
        public static WinFormsField ReturnedEmail = new WinFormsField("RETURNED-EMAIL", "ReturnedEmail");
        public static WinFormsField CommMethods = new WinFormsField("COMM-METHODS", "CommMethods");
        public static WinFormsField UsePubCatDesc = new WinFormsField("USE-PUB-CAT-DESC", "UsePubCatDesc");
        public static WinFormsField SuppressCommMethod = new WinFormsField("SUPPRESS-COMM-METHOD", "SuppressCommMethod");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}