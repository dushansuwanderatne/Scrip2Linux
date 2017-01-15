using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB03", "FormName");
		//Fields
        public static WinFormsField OrderNO = new WinFormsField("ORDER-NO", "OrderNO");
        public static WinFormsField Ident = new WinFormsField("IDENT", "Ident");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField Release = new WinFormsField("RELEASE", "Release");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
