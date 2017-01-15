using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class UNC01060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("UNC01060", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TRSelcls1 = new WinFormsField("TR-SELCLS-1", "TRSelcls1");
        public static WinFormsField TRSelcls2 = new WinFormsField("TR-SELCLS-2", "TRSelcls2");
    }
}
