using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01304

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01304", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ExceptionValue = new WinFormsField("EXCEPTION-VALUE", "ExceptionValue");
        public static WinFormsField ExceptionDesc = new WinFormsField("EXCEPTION-DESC", "ExceptionDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField Exception = new WinFormsField("EXCEPTION", "Exception");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
