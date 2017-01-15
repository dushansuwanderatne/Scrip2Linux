using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICR001S2

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICR001S2", "FormName");
		//Fields


        public static WinFormsField MenuOptionName = new WinFormsField("MENU-OPTION-NAME", "MenuOptionName");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField LineNumberX = new WinFormsField("LINE-NUMBER-X", "LineNumberX");
        public static WinFormsField GroupORClass = new WinFormsField("GROUP-OR-CLASS", "GroupORClass");
        public static WinFormsField GroupORClassInd = new WinFormsField("GROUP-OR-CLASS-IND", "GroupORClassInd");
        public static WinFormsField GroupORClassDesc = new WinFormsField("GROUP-OR-CLASS-DESC", "GroupORClassDesc");
        public static WinFormsField ClassAsxCode = new WinFormsField("CLASS-ASX-CODE", "ClassAsxCode");
        public static WinFormsField ReconType = new WinFormsField("RECON-TYPE", "ReconType");
        public static WinFormsField CurrFlag = new WinFormsField("CURR-FLAG", "CurrFlag");
        public static WinFormsField FirstDateRecon = new WinFormsField("FIRST-DATE-RECON", "FirstDateRecon");
        public static WinFormsField LastDateRecon = new WinFormsField("LAST-DATE-RECON", "LastDateRecon");
        public static WinFormsField ActionX = new WinFormsField("ACTION-X", "ActionX");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
