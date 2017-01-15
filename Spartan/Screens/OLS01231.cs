using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01231

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01231", "FormName");
		//Fields


        public static WinFormsField Explanation1 = new WinFormsField("EXPLANATION-1", "Explanation1");
        public static WinFormsField Explanation2 = new WinFormsField("EXPLANATION-2", "Explanation2");
        public static WinFormsField AddressLineEntered = new WinFormsField("ADDRESS-LINE-ENTERED", "AddressLineEntered");
        public static WinFormsField AddressLineReturned = new WinFormsField("ADDRESS-LINE-RETURNED", "AddressLineReturned");
        public static WinFormsField PostcodeEntered = new WinFormsField("POSTCODE-ENTERED", "PostcodeEntered");
        public static WinFormsField PostcodeReturned = new WinFormsField("POSTCODE-RETURNED", "PostcodeReturned");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
