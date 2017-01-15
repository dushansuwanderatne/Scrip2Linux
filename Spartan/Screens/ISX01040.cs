using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01040", "FormName");
		//Fields


        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ClassReg = new WinFormsField("CLASS-REG", "ClassReg");
        public static WinFormsField ClassType = new WinFormsField("CLASS-TYPE", "ClassType");
    }
}
