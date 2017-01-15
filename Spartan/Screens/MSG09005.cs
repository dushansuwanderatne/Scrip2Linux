using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG09005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG09005", "FormName");
		//Fields


        public static WinFormsField GivenName = new WinFormsField("GIVEN-NAME", "GivenName");
        public static WinFormsField Initial = new WinFormsField("INITIAL", "Initial");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField HostUserName = new WinFormsField("HOST-USER-NAME", "HostUserName");
        public static WinFormsField Password1 = new WinFormsField("PASSWORD1", "Password1");
        public static WinFormsField Password2 = new WinFormsField("PASSWORD2", "Password2");
        public static WinFormsField DisableUser = new WinFormsField("DISABLE-USER", "DisableUser");
        public static WinFormsField AccessHourStart = new WinFormsField("ACCESS-HOUR-START", "AccessHourStart");
        public static WinFormsField AccessHourEnd = new WinFormsField("ACCESS-HOUR-END", "AccessHourEnd");
        public static WinFormsField AccessMon = new WinFormsField("ACCESS-MON", "AccessMon");
        public static WinFormsField AccessTue = new WinFormsField("ACCESS-TUE", "AccessTue");
        public static WinFormsField AccessWed = new WinFormsField("ACCESS-WED", "AccessWed");
        public static WinFormsField AccessThu = new WinFormsField("ACCESS-THU", "AccessThu");
        public static WinFormsField AccessFri = new WinFormsField("ACCESS-FRI", "AccessFri");
        public static WinFormsField AccessSat = new WinFormsField("ACCESS-SAT", "AccessSat");
        public static WinFormsField AccessSun = new WinFormsField("ACCESS-SUN", "AccessSun");
        public static WinFormsField AccountExpiration = new WinFormsField("ACCOUNT-EXPIRATION", "AccountExpiration");
        public static WinFormsField PasswordLifetime = new WinFormsField("PASSWORD-LIFETIME", "PasswordLifetime");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
