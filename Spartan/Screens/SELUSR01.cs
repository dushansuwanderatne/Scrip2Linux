using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELUSR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELUSR01", "FormName");
		//Fields


        public static WinFormsField ActionIndex = new WinFormsField("ACTION-INDEX", "ActionIndex");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField UserIdentifier = new WinFormsField("USER-IDENTIFIER", "UserIdentifier");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField UsualLogin = new WinFormsField("USUAL-LOGIN", "UsualLogin");
        public static WinFormsField UserNameConcat = new WinFormsField("USER-NAME-CONCAT", "UserNameConcat");
    }
}
