using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN45

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN45", "FormName");
		//Fields


        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
        public static WinFormsField Directory = new WinFormsField("DIRECTORY", "Directory");
        public static WinFormsField Nbr = new WinFormsField("NBR", "Nbr");
    }
}
