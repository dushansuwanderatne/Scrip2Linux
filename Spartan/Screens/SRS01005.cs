using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS01005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS01005", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CurrentPassword = new WinFormsField("CURRENT-PASSWORD", "CurrentPassword");
        public static WinFormsField NewPassword1 = new WinFormsField("NEW-PASSWORD1", "NewPassword1");
        public static WinFormsField NewPassword2 = new WinFormsField("NEW-PASSWORD2", "NewPassword2");
        public static WinFormsField X25Passwd = new WinFormsField("X25-PASSWD", "X25Passwd");
        public static WinFormsField X25NewPasswd1 = new WinFormsField("X25-NEW-PASSWD1", "X25NewPasswd1");
        public static WinFormsField X25NewPasswd2 = new WinFormsField("X25-NEW-PASSWD2", "X25NewPasswd2");
    }
}
