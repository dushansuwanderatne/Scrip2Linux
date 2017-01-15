using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS06002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS06002", "FormName");
		//Fields


        public static WinFormsField HoldersExtracted = new WinFormsField("HOLDERS-EXTRACTED", "HoldersExtracted");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
