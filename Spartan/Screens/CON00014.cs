using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00014

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00014", "FormName");
		//Fields


        public static WinFormsField NewCode3 = new WinFormsField("NEW-CODE-3", "NewCode3");
        public static WinFormsField NewDesc = new WinFormsField("NEW-DESC", "NewDesc");
        public static WinFormsField OldCode1 = new WinFormsField("OLD-CODE-1", "OldCode1");
    }
}
