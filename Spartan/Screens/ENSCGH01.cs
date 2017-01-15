using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSCGH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSCGH01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MemberNO = new WinFormsField("MEMBER-NO", "MemberNO");
        public static WinFormsField ShareholderID = new WinFormsField("SHAREHOLDER-ID", "ShareholderID");
    }
}
