using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01504

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01504", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField CorpActionTypeID = new WinFormsField("CORP-ACTION-TYPE-ID", "CorpActionTypeID");
        public static WinFormsField EXDate = new WinFormsField("EX-DATE", "EXDate");
        public static WinFormsField ExerciseDate = new WinFormsField("EXERCISE-DATE", "ExerciseDate");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField ReducingHldBal = new WinFormsField("REDUCING-HLD-BAL", "ReducingHldBal");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
