using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL004WN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL004WN", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TranOrigCode = new WinFormsField("TRAN-ORIG-CODE", "TranOrigCode");
        public static WinFormsField TranOtherCode = new WinFormsField("TRAN-OTHER-CODE", "TranOtherCode");
        public static WinFormsField OtherRunNumber = new WinFormsField("OTHER-RUN-NUMBER", "OtherRunNumber");
        public static WinFormsField OtherTransNumber = new WinFormsField("OTHER-TRANS-NUMBER", "OtherTransNumber");
        public static WinFormsField OtherRevType = new WinFormsField("OTHER-REV-TYPE", "OtherRevType");
        public static WinFormsField WarnContinue = new WinFormsField("WARN-CONTINUE", "WarnContinue");
    }
}
