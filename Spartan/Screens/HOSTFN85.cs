using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN85

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN85", "FormName");
		//Fields


        public static WinFormsField LN = new WinFormsField("LN", "LN");
        public static WinFormsField RunCode = new WinFormsField("RUN-CODE", "RunCode");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField FileSelected = new WinFormsField("FILE-SELECTED", "FileSelected");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
