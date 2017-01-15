using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CCT01510

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CCT01510", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OriginTranID = new WinFormsField("ORIGIN-TRAN-ID", "OriginTranID");
        public static WinFormsField ProcessingTimestamp = new WinFormsField("PROCESSING-TIMESTAMP", "ProcessingTimestamp");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField ExerciseDate = new WinFormsField("EXERCISE-DATE", "ExerciseDate");
        public static WinFormsField ReceivingHin = new WinFormsField("RECEIVING-HIN", "ReceivingHin");
        public static WinFormsField ReducingHldBal = new WinFormsField("REDUCING-HLD-BAL", "ReducingHldBal");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField NewHldBalance = new WinFormsField("NEW-HLD-BALANCE", "NewHldBalance");
        public static WinFormsField UnitQuantityB = new WinFormsField("UNIT-QUANTITY-B", "UnitQuantityB");
        public static WinFormsField IncreasingHldBal = new WinFormsField("INCREASING-HLD-BAL", "IncreasingHldBal");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
