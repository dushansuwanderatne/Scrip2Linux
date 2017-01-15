using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06701

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06701", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SourceError = new WinFormsField("SOURCE-ERROR", "SourceError");
        public static WinFormsField ErrorCode = new WinFormsField("ERROR-CODE", "ErrorCode");
        public static WinFormsField ErrorDescription = new WinFormsField("ERROR-DESCRIPTION", "ErrorDescription");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchErrorCode = new WinFormsField("SEARCH-ERROR-CODE", "SearchErrorCode");
    }
}
