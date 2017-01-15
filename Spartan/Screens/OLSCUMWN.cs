using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCUMWN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCUMWN", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SellCumWarning = new WinFormsField("SELL-CUM-WARNING", "SellCumWarning");
        public static WinFormsField BuyCumWarning = new WinFormsField("BUY-CUM-WARNING", "BuyCumWarning");
        public static WinFormsField TranTypes = new WinFormsField("TRAN-TYPES", "TranTypes");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
