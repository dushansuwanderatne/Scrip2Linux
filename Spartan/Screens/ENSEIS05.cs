using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEIS05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEIS05", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDesc = new WinFormsField("INV-DESC", "InvDesc");
        public static WinFormsField AllotPeriod = new WinFormsField("ALLOT-PERIOD", "AllotPeriod");
        public static WinFormsField DateContrib = new WinFormsField("DATE-CONTRIB", "DateContrib");
        public static WinFormsField RunNbr = new WinFormsField("RUN-NBR", "RunNbr");
        public static WinFormsField Slash = new WinFormsField("SLASH", "Slash");
        public static WinFormsField RefNbr = new WinFormsField("REF-NBR", "RefNbr");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField EmpContrib = new WinFormsField("EMP-CONTRIB", "EmpContrib");
        public static WinFormsField CoyContrib = new WinFormsField("COY-CONTRIB", "CoyContrib");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
