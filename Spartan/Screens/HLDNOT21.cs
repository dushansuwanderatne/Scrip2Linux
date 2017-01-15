using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDNOT21

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDNOT21", "FormName");
		//Fields


        public static WinFormsField HldnotKey0 = new WinFormsField("HLDNOT-KEY0", "HldnotKey0");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField NotingTypeCode = new WinFormsField("NOTING-TYPE-CODE", "NotingTypeCode");
        public static WinFormsField NotingNumber = new WinFormsField("NOTING-NUMBER", "NotingNumber");
        public static WinFormsField LCRunNumber = new WinFormsField("LC-RUN-NUMBER", "LCRunNumber");
        public static WinFormsField LCTransNumber = new WinFormsField("LC-TRANS-NUMBER", "LCTransNumber");
        public static WinFormsField NotingComment50 = new WinFormsField("NOTING-COMMENT50", "NotingComment50");
        public static WinFormsField NotingLine = new WinFormsField("NOTING-LINE", "NotingLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
