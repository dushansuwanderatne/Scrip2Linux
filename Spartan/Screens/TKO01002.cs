using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TKO01002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TKO01002", "FormName");
		//Fields


        public static WinFormsField PreloadInd = new WinFormsField("PRELOAD-IND", "PreloadInd");
    }
}
