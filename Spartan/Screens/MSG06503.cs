using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06503", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ChessExceptionInd = new WinFormsField("CHESS-EXCEPTION-IND", "ChessExceptionInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
