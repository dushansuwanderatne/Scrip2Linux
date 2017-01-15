using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRD240RB

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRD240RB", "FormName");
		//Fields
        public static WinFormsField SellTOCover = new WinFormsField("SELL-TO-COVER", "SellTOCover");
        public static WinFormsField SellPartialCert = new WinFormsField("SELL-PARTIAL-CERT", "SellPartialCert");
        public static WinFormsField RemainingBalOption = new WinFormsField("REMAINING-BAL-OPTION", "RemainingBalOption");
        public static WinFormsField RemainingBalHin = new WinFormsField("REMAINING-BAL-HIN", "RemainingBalHin");
        public static WinFormsField RemainingBalCert = new WinFormsField("REMAINING-BAL-CERT", "RemainingBalCert");
        public static WinFormsField RemainingBalTran = new WinFormsField("REMAINING-BAL-TRAN", "RemainingBalTran");
        public static WinFormsField RemainingBalClass = new WinFormsField("REMAINING-BAL-CLASS", "RemainingBalClass");
        public static WinFormsField RemainingBalReg = new WinFormsField("REMAINING-BAL-REG", "RemainingBalReg");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
