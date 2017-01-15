using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01001", "FormName");
		//Fields


        public static WinFormsField SourceError = new WinFormsField("SOURCE-ERROR", "SourceError");
        public static WinFormsField ErrorCode = new WinFormsField("ERROR-CODE", "ErrorCode");
        public static WinFormsField ErrorDescription = new WinFormsField("ERROR-DESCRIPTION", "ErrorDescription");
        public static WinFormsField ErrorAction = new WinFormsField("ERROR-ACTION", "ErrorAction");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchSourceError = new WinFormsField("SEARCH-SOURCE-ERROR", "SearchSourceError");
        public static WinFormsField SearchErrorCode = new WinFormsField("SEARCH-ERROR-CODE", "SearchErrorCode");
    }
}
