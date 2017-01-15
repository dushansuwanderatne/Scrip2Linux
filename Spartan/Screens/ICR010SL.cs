using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR010SL

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR010SL", "FormName");
		//Fields


        public static WinFormsField EnterProv = new WinFormsField("ENTER-PROV", "EnterProv");
        public static WinFormsField EnterCode = new WinFormsField("ENTER-CODE", "EnterCode");
        public static WinFormsField EnterDept = new WinFormsField("ENTER-DEPT", "EnterDept");
        public static WinFormsField EnterBranch = new WinFormsField("ENTER-BRANCH", "EnterBranch");
        public static WinFormsField EnterInitial = new WinFormsField("ENTER-INITIAL", "EnterInitial");
        public static WinFormsField EnterSurname = new WinFormsField("ENTER-SURNAME", "EnterSurname");
        public static WinFormsField AuthProv = new WinFormsField("AUTH-PROV", "AuthProv");
        public static WinFormsField AuthCode = new WinFormsField("AUTH-CODE", "AuthCode");
        public static WinFormsField AuthDept = new WinFormsField("AUTH-DEPT", "AuthDept");
        public static WinFormsField AuthBranch = new WinFormsField("AUTH-BRANCH", "AuthBranch");
        public static WinFormsField AuthInitial = new WinFormsField("AUTH-INITIAL", "AuthInitial");
        public static WinFormsField AuthSurname = new WinFormsField("AUTH-SURNAME", "AuthSurname");
    }
}
