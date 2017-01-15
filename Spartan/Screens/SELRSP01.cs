using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELRSP01
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("SELRSP01", "FormName");
        //Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField LN = new WinFormsField("LN", "LN");
        public static WinFormsField File = new WinFormsField("FILE", "File");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
    }
}
