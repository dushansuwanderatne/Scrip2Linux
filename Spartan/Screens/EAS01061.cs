using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EAS01061

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EAS01061", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField EalctlNum = new WinFormsField("EALCTL-NUM", "EalctlNum");
        public static WinFormsField AllotDesc = new WinFormsField("ALLOT-DESC", "AllotDesc");
        public static WinFormsField AllotNum = new WinFormsField("ALLOT-NUM", "AllotNum");
        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
    }
}
