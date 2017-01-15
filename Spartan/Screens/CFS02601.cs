using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02601

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02601", "FormName");
		//Fields


        public static WinFormsField OrigSystem = new WinFormsField("ORIG-SYSTEM", "OrigSystem");
        public static WinFormsField OrigSystemDesc = new WinFormsField("ORIG-SYSTEM-DESC", "OrigSystemDesc");
        public static WinFormsField PrintSuppressInd = new WinFormsField("PRINT-SUPPRESS-IND", "PrintSuppressInd");
        public static WinFormsField ApplicationCategory = new WinFormsField("APPLICATION-CATEGORY", "ApplicationCategory");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
