using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01061

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01061", "FormName");
		//Fields
        public static WinFormsField BspPendDate = new WinFormsField("BSP-PEND-DATE", "BspPendDate");
        public static WinFormsField BspPendRun = new WinFormsField("BSP-PEND-RUN", "BspPendRun");
        public static WinFormsField BspPendTrans = new WinFormsField("BSP-PEND-TRANS", "BspPendTrans");
        public static WinFormsField BspPendOpt = new WinFormsField("BSP-PEND-OPT", "BspPendOpt");
        public static WinFormsField BspPendLevel = new WinFormsField("BSP-PEND-LEVEL", "BspPendLevel");
        public static WinFormsField DrpPendDate = new WinFormsField("DRP-PEND-DATE", "DrpPendDate");
        public static WinFormsField DrpPendRun = new WinFormsField("DRP-PEND-RUN", "DrpPendRun");
        public static WinFormsField DrpPendTrans = new WinFormsField("DRP-PEND-TRANS", "DrpPendTrans");
        public static WinFormsField DrpPendOpt = new WinFormsField("DRP-PEND-OPT", "DrpPendOpt");
        public static WinFormsField DrpPendLevel = new WinFormsField("DRP-PEND-LEVEL", "DrpPendLevel");
    }
}
