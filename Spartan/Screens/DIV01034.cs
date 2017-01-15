using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01034

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01034", "FormName");
		//Fields


        public static WinFormsField EmpHowPayCode = new WinFormsField("EMP-HOW-PAY-CODE", "EmpHowPayCode");
        public static WinFormsField DidcStartRef = new WinFormsField("DIDC-START-REF", "DidcStartRef");
        public static WinFormsField EmpSpecialProgram = new WinFormsField("EMP-SPECIAL-PROGRAM", "EmpSpecialProgram");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
