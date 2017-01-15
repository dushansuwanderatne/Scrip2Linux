using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSACC22

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSACC22", "FormName");
		//Fields


        public static WinFormsField OPUPAmt = new WinFormsField("OP-UP-AMT", "OPUPAmt");
        public static WinFormsField AdditionalMoney = new WinFormsField("ADDITIONAL-MONEY", "AdditionalMoney");
        public static WinFormsField RunSlashTrans = new WinFormsField("RUN-SLASH-TRANS", "RunSlashTrans");
    }
}
