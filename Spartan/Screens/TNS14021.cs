using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14021", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField FromDate = new WinFormsField("FROM-DATE", "FromDate");
        public static WinFormsField TODate = new WinFormsField("TO-DATE", "TODate");
    }
}
