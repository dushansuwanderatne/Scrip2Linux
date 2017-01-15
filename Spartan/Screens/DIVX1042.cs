using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1042

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1042", "FormName");
		//Fields


        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField EmpHowPayCode = new WinFormsField("EMP-HOW-PAY-CODE", "EmpHowPayCode");
        public static WinFormsField AdviceStartRef = new WinFormsField("ADVICE-START-REF", "AdviceStartRef");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
