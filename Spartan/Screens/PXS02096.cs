using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS02096

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS02096", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField UnderOver = new WinFormsField("UNDER-OVER", "UnderOver");
        public static WinFormsField ErrorDesc = new WinFormsField("ERROR-DESC", "ErrorDesc");
    }
}
