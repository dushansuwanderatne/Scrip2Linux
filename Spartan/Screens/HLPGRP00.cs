using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLPGRP00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLPGRP00", "FormName");
		//Fields


        public static WinFormsField Code1 = new WinFormsField("CODE-1", "Code1");
        public static WinFormsField Desc1 = new WinFormsField("DESC-1", "Desc1");
        public static WinFormsField Code2 = new WinFormsField("CODE-2", "Code2");
        public static WinFormsField Desc2 = new WinFormsField("DESC-2", "Desc2");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
