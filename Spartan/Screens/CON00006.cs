using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00006", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField GeneralDesc = new WinFormsField("GENERAL-DESC", "GeneralDesc");
        public static WinFormsField OldCode4 = new WinFormsField("OLD-CODE-4", "OldCode4");
        public static WinFormsField NewCode1X = new WinFormsField("NEW-CODE-1-X", "NewCode1X");
        public static WinFormsField NewCode2 = new WinFormsField("NEW-CODE-2", "NewCode2");
        public static WinFormsField NewDesc = new WinFormsField("NEW-DESC", "NewDesc");
    }
}
