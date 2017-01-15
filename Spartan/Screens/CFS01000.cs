using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01000", "FormName");
		//Fields


        public static WinFormsField SourceError = new WinFormsField("SOURCE-ERROR", "SourceError");
        public static WinFormsField ErrorCode = new WinFormsField("ERROR-CODE", "ErrorCode");
        public static WinFormsField ErrorDescription = new WinFormsField("ERROR-DESCRIPTION", "ErrorDescription");
        public static WinFormsField ErrorAction = new WinFormsField("ERROR-ACTION", "ErrorAction");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchSourceError = new WinFormsField("SEARCH-SOURCE-ERROR", "SearchSourceError");
        public static WinFormsField SearchErrorCode = new WinFormsField("SEARCH-ERROR-CODE", "SearchErrorCode");
    }
}
