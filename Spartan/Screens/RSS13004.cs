using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13004", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField LabelType = new WinFormsField("LABEL-TYPE", "LabelType");
        public static WinFormsField CodePrint = new WinFormsField("CODE-PRINT", "CodePrint");
        public static WinFormsField FullDetail = new WinFormsField("FULL-DETAIL", "FullDetail");
    }
}
