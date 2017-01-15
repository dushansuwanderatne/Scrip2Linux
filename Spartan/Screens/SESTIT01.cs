using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SESTIT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SESTIT01", "FormName");
		//Fields


        public static WinFormsField SestotKey0 = new WinFormsField("SESTOT-KEY0", "SestotKey0");
        public static WinFormsField TranListGroup = new WinFormsField("TRAN-LIST-GROUP", "TranListGroup");
        public static WinFormsField SessionNumber = new WinFormsField("SESSION-NUMBER", "SessionNumber");
        public static WinFormsField SessionTransCount = new WinFormsField("SESSION-TRANS-COUNT", "SessionTransCount");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField SessionTransUnits = new WinFormsField("SESSION-TRANS-UNITS", "SessionTransUnits");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
