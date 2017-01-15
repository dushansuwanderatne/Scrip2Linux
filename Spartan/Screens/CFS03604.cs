using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03604

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS03604", "FormName");
		//Fields


        public static WinFormsField ApproverName = new WinFormsField("APPROVER-NAME", "ApproverName");
        public static WinFormsField ApproverPassword = new WinFormsField("APPROVER-PASSWORD", "ApproverPassword");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
