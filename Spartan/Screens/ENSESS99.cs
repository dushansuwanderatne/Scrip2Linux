using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS99

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS99", "FormName");
		//Fields


        public static WinFormsField FwdInstruction = new WinFormsField("FWD-INSTRUCTION", "FwdInstruction");
    }
}
