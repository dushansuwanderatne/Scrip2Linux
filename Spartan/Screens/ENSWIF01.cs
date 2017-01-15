using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSWIF01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSWIF01", "FormName");
		//Fields


        public static WinFormsField PayeeNbr = new WinFormsField("PAYEE-NBR", "PayeeNbr");
        public static WinFormsField PayeeName = new WinFormsField("PAYEE-NAME", "PayeeName");
    }
}
