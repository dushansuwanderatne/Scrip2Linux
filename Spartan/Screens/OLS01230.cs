using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS01230

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS01230", "FormName");
		//Fields
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField RegBrokerCode = new WinFormsField("REG-BROKER-CODE", "RegBrokerCode");
        public static WinFormsField ChsBrokerCode = new WinFormsField("CHS-BROKER-CODE", "ChsBrokerCode");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField ChessLine = new WinFormsField("CHESS-LINE", "ChessLine");
        public static WinFormsField HnaStdLine1 = new WinFormsField("HNA-STD-LINE-1", "HnaStdLine1");
        public static WinFormsField ChessStdLine1 = new WinFormsField("CHESS-STD-LINE-1", "ChessStdLine1");
        public static WinFormsField DiffLine1 = new WinFormsField("DIFF-LINE-1", "DiffLine1");
        public static WinFormsField HnaStdLine2 = new WinFormsField("HNA-STD-LINE-2", "HnaStdLine2");
        public static WinFormsField ChessStdLine2 = new WinFormsField("CHESS-STD-LINE-2", "ChessStdLine2");
        public static WinFormsField DiffLine2 = new WinFormsField("DIFF-LINE-2", "DiffLine2");
        public static WinFormsField ResidencyDifferences = new WinFormsField("RESIDENCY-DIFFERENCES", "ResidencyDifferences");
        public static WinFormsField Update = new WinFormsField("UPDATE", "Update");
    }
}
