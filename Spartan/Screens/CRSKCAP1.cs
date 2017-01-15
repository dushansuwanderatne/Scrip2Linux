using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSKCAP1

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSKCAP1", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        public static WinFormsField Literal = new WinFormsField("LITERAL", "Literal");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField ActionType = new WinFormsField("ACTION-TYPE", "ActionType");
        public static WinFormsField ActionNbr = new WinFormsField("ACTION-NBR", "ActionNbr");
        public static WinFormsField ActionStatus = new WinFormsField("ACTION-STATUS", "ActionStatus");
        public static WinFormsField ActionDesc = new WinFormsField("ACTION-DESC", "ActionDesc");
        public static WinFormsField ReceivingAgentID = new WinFormsField("RECEIVING-AGENT-ID", "ReceivingAgentID");
        public static WinFormsField GeneratesClaims = new WinFormsField("GENERATES-CLAIMS", "GeneratesClaims");
        public static WinFormsField Transformed = new WinFormsField("TRANSFORMED", "Transformed");
        public static WinFormsField EXDate = new WinFormsField("EX-DATE", "EXDate");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        //public static WinFormsField Date = new WinFormsField("DATE", "Date");
        //public static WinFormsField Date = new WinFormsField("DATE", "Date");
    }
}
