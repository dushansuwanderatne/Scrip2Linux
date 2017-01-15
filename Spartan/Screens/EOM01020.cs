using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOM01020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOM01020", "FormName");
		//Fields


        public static WinFormsField TranORHolder = new WinFormsField("TRAN-OR-HOLDER", "TranORHolder");
        public static WinFormsField RunNbr = new WinFormsField("RUN-NBR", "RunNbr");
        public static WinFormsField TypeCode = new WinFormsField("TYPE-CODE", "TypeCode");
        public static WinFormsField ExcInc = new WinFormsField("EXC-INC", "ExcInc");
        public static WinFormsField Reason = new WinFormsField("REASON", "Reason");
        public static WinFormsField RunNbrH = new WinFormsField("RUN-NBR-H", "RunNbrH");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField ExcIncH = new WinFormsField("EXC-INC-H", "ExcIncH");
        public static WinFormsField ReasonH = new WinFormsField("REASON-H", "ReasonH");
    }
}
