using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RUNHIS01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RUNHIS01", "FormName");
		//Fields


        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField RunDesc = new WinFormsField("RUN-DESC", "RunDesc");
        public static WinFormsField RunDate = new WinFormsField("RUN-DATE", "RunDate");
        public static WinFormsField RunType = new WinFormsField("RUN-TYPE", "RunType");
        public static WinFormsField RunCode = new WinFormsField("RUN-CODE", "RunCode");
        public static WinFormsField FileMmyy = new WinFormsField("FILE-MMYY", "FileMmyy");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
