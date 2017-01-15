using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSAMP01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSAMP01", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MemberNO = new WinFormsField("MEMBER-NO", "MemberNO");
        public static WinFormsField ShareholderID = new WinFormsField("SHAREHOLDER-ID", "ShareholderID");
        public static WinFormsField EntitlementNbr = new WinFormsField("ENTITLEMENT-NBR", "EntitlementNbr");
    }
}
