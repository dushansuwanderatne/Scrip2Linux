using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SEP01504

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SEP01504", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField JHFlag = new WinFormsField("JH-FLAG", "JHFlag");
        public static WinFormsField JHName = new WinFormsField("JH-NAME", "JHName");
        public static WinFormsField JHSelected = new WinFormsField("JH-SELECTED", "JHSelected");
    }
}
