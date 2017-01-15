using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05310

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05310", "FormName");
		//Fields


        public static WinFormsField GivenName = new WinFormsField("GIVEN-NAME", "GivenName");
        public static WinFormsField Initial = new WinFormsField("INITIAL", "Initial");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField HostUserName = new WinFormsField("HOST-USER-NAME", "HostUserName");
        public static WinFormsField DisableUser = new WinFormsField("DISABLE-USER", "DisableUser");
        public static WinFormsField PasswordExpired = new WinFormsField("PASSWORD-EXPIRED", "PasswordExpired");
        public static WinFormsField AccountExpiration = new WinFormsField("ACCOUNT-EXPIRATION", "AccountExpiration");
        public static WinFormsField LastLogin = new WinFormsField("LAST-LOGIN", "LastLogin");
        public static WinFormsField LastPwdChange = new WinFormsField("LAST-PWD-CHANGE", "LastPwdChange");
        public static WinFormsField LoginFails = new WinFormsField("LOGIN-FAILS", "LoginFails");
    }
}
