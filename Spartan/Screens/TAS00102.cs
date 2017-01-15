using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TAS00102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TAS00102", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ProjectCodeErr = new WinFormsField("PROJECT-CODE-ERR", "ProjectCodeErr");
        public static WinFormsField Line = new WinFormsField("LINE", "Line");
        public static WinFormsField ProjectCode = new WinFormsField("PROJECT-CODE", "ProjectCode");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField ChargeFlag = new WinFormsField("CHARGE-FLAG", "ChargeFlag");
        public static WinFormsField CurrentFlag = new WinFormsField("CURRENT-FLAG", "CurrentFlag");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
