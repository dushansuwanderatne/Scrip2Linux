using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10013

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10013", "FormName");
		//Fields


        public static WinFormsField AccountType = new WinFormsField("ACCOUNT-TYPE", "AccountType");
        public static WinFormsField SpecificType = new WinFormsField("SPECIFIC-TYPE", "SpecificType");
        public static WinFormsField HolderTypeFlag = new WinFormsField("HOLDER-TYPE-FLAG", "HolderTypeFlag");
        public static WinFormsField HolderTypeValues = new WinFormsField("HOLDER-TYPE-VALUES", "HolderTypeValues");
        public static WinFormsField HomePhone = new WinFormsField("HOME-PHONE", "HomePhone");
        public static WinFormsField WorkPhone = new WinFormsField("WORK-PHONE", "WorkPhone");
        public static WinFormsField FaxNumber = new WinFormsField("FAX-NUMBER", "FaxNumber");
        public static WinFormsField MobilePhone = new WinFormsField("MOBILE-PHONE", "MobilePhone");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
