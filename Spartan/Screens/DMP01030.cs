using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DMP01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DMP01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Ast1 = new WinFormsField("AST1", "Ast1");
        public static WinFormsField RunNO = new WinFormsField("RUN-NO", "RunNO");
        public static WinFormsField RunDesc = new WinFormsField("RUN-DESC", "RunDesc");
        public static WinFormsField RunDate = new WinFormsField("RUN-DATE", "RunDate");
        public static WinFormsField Ast2 = new WinFormsField("AST2", "Ast2");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
