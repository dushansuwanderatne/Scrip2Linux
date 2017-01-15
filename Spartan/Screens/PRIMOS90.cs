using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS90

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS90", "FormName");
		//Fields


        public static WinFormsField PageNumber = new WinFormsField("PAGE-NUMBER", "PageNumber");
        public static WinFormsField Lines = new WinFormsField("LINES", "Lines");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField String = new WinFormsField("STRING", "String");
    }
}
