using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01022

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01022", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField CatClass1 = new WinFormsField("CAT-CLASS-1", "CatClass1");
        public static WinFormsField CatClass2 = new WinFormsField("CAT-CLASS-2", "CatClass2");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ButtClassDesc = new WinFormsField("BUTT-CLASS-DESC", "ButtClassDesc");
        public static WinFormsField ButtRateDesc = new WinFormsField("BUTT-RATE-DESC", "ButtRateDesc");
    }
}
