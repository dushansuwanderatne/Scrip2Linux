using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SWOW0201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SWOW0201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TransactionDate = new WinFormsField("TRANSACTION-DATE", "TransactionDate");
        public static WinFormsField TransactionType2 = new WinFormsField("TRANSACTION-TYPE2", "TransactionType2");
        public static WinFormsField TransactionType1 = new WinFormsField("TRANSACTION-TYPE1", "TransactionType1");
        public static WinFormsField TransferClass = new WinFormsField("TRANSFER-CLASS", "TransferClass");
        public static WinFormsField HistoryClass = new WinFormsField("HISTORY-CLASS", "HistoryClass");
        public static WinFormsField OrdinaryClass = new WinFormsField("ORDINARY-CLASS", "OrdinaryClass");
        public static WinFormsField EmployeeClass = new WinFormsField("EMPLOYEE-CLASS", "EmployeeClass");
        public static WinFormsField ControlHolderID = new WinFormsField("CONTROL-HOLDER-ID", "ControlHolderID");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
