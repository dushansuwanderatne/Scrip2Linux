using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTFI

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTFI", "FormName");
		//Fields


        public static WinFormsField BuyFwdInstruction = new WinFormsField("BUY-FWD-INSTRUCTION", "BuyFwdInstruction");
    }
}
