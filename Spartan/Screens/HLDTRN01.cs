using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDTRN01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDTRN01", "FormName");
		//Fields


        public static WinFormsField HldtrnKey0 = new WinFormsField("HLDTRN-KEY0", "HldtrnKey0");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HldtrnVersionNbr = new WinFormsField("HLDTRN-VERSION-NBR", "HldtrnVersionNbr");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField HldtrnRecordName = new WinFormsField("HLDTRN-RECORD-NAME", "HldtrnRecordName");
        public static WinFormsField HldTransNumber = new WinFormsField("HLD-TRANS-NUMBER", "HldTransNumber");
        public static WinFormsField HldtrnRecordNbr = new WinFormsField("HLDTRN-RECORD-NBR", "HldtrnRecordNbr");
        public static WinFormsField HldtrnImageNbr = new WinFormsField("HLDTRN-IMAGE-NBR", "HldtrnImageNbr");
        public static WinFormsField HldtrnExtra = new WinFormsField("HLDTRN-EXTRA", "HldtrnExtra");
        public static WinFormsField HldtrnImageCount = new WinFormsField("HLDTRN-IMAGE-COUNT", "HldtrnImageCount");
        public static WinFormsField RedefHldtrnRecLine1 = new WinFormsField("REDEF-HLDTRN-REC-LINE1", "RedefHldtrnRecLine1");
        public static WinFormsField RedefHldtrnRecImage = new WinFormsField("REDEF-HLDTRN-REC-IMAGE", "RedefHldtrnRecImage");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
