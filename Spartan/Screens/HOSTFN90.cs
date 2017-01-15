using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN90

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN90", "FormName");
		//Fields


        public static WinFormsField PageNumber = new WinFormsField("PAGE-NUMBER", "PageNumber");
        public static WinFormsField LineLeft = new WinFormsField("LINE-LEFT", "LineLeft");
        public static WinFormsField LineRight = new WinFormsField("LINE-RIGHT", "LineRight");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField String = new WinFormsField("STRING", "String");
    }
}
