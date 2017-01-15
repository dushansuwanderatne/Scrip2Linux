using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00201", "FormName");
		//Fields


        public static WinFormsField BankFormat = new WinFormsField("BANK-FORMAT", "BankFormat");
        public static WinFormsField BankFormatDesc = new WinFormsField("BANK-FORMAT-DESC", "BankFormatDesc");
        public static WinFormsField BankProgram = new WinFormsField("BANK-PROGRAM", "BankProgram");
        public static WinFormsField ExportDirectory = new WinFormsField("EXPORT-DIRECTORY", "ExportDirectory");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField SearchBankFormat = new WinFormsField("SEARCH-BANK-FORMAT", "SearchBankFormat");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BankFormatAvail = new WinFormsField("BANK-FORMAT-AVAIL", "BankFormatAvail");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
