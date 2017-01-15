using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS14020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS14020", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField CompCode1 = new WinFormsField("COMP-CODE-1", "CompCode1");
        public static WinFormsField CompCode2 = new WinFormsField("COMP-CODE-2", "CompCode2");
        public static WinFormsField CompCode3 = new WinFormsField("COMP-CODE-3", "CompCode3");
        public static WinFormsField CompCode4 = new WinFormsField("COMP-CODE-4", "CompCode4");
        public static WinFormsField CompCode5 = new WinFormsField("COMP-CODE-5", "CompCode5");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
