using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLT01070

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLT01070", "FormName");
		//Fields


        public static WinFormsField PrintFileName = new WinFormsField("PRINT-FILE-NAME", "PrintFileName");
        public static WinFormsField ConfirmDeleteInd = new WinFormsField("CONFIRM-DELETE-IND", "ConfirmDeleteInd");
    }
}
