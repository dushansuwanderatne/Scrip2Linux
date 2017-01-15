using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS03021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS03021", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField MovlstPrint = new WinFormsField("MOVLST-PRINT", "MovlstPrint");
        public static WinFormsField SmvlstLevel = new WinFormsField("SMVLST-LEVEL", "SmvlstLevel");
        public static WinFormsField SmvlstOrder = new WinFormsField("SMVLST-ORDER", "SmvlstOrder");
        public static WinFormsField VarianceOrder = new WinFormsField("VARIANCE-ORDER", "VarianceOrder");
        public static WinFormsField SubHinTOPrint = new WinFormsField("SUB-HIN-TO-PRINT", "SubHinTOPrint");
        public static WinFormsField FromRun = new WinFormsField("FROM-RUN", "FromRun");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
