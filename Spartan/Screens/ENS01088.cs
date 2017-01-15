using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01088

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01088", "FormName");
		//Fields
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
