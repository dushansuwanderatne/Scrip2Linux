using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00305

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00305", "FormName");
		//Fields


        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField EndOFDocument = new WinFormsField("END-OF-DOCUMENT", "EndOFDocument");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField WordINLine = new WinFormsField("WORD-IN-LINE", "WordINLine");
        public static WinFormsField Percentage = new WinFormsField("PERCENTAGE", "Percentage");
    }
}
