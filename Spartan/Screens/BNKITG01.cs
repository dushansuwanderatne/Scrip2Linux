using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BNKITG01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BNKITG01", "FormName");
		//Fields


        public static WinFormsField BnkitgKey0 = new WinFormsField("BNKITG-KEY0", "BnkitgKey0");
        public static WinFormsField BankType = new WinFormsField("BANK-TYPE", "BankType");
        public static WinFormsField FileType = new WinFormsField("FILE-TYPE", "FileType");
        public static WinFormsField BillerRefNbrX = new WinFormsField("BILLER-REF-NBR-X", "BillerRefNbrX");
        public static WinFormsField ExtraKeyData = new WinFormsField("EXTRA-KEY-DATA", "ExtraKeyData");
        public static WinFormsField ReceivedDate = new WinFormsField("RECEIVED-DATE", "ReceivedDate");
        public static WinFormsField ReceivedTime = new WinFormsField("RECEIVED-TIME", "ReceivedTime");
        public static WinFormsField TotalRecords = new WinFormsField("TOTAL-RECORDS", "TotalRecords");
        public static WinFormsField TotalAmount = new WinFormsField("TOTAL-AMOUNT", "TotalAmount");
        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField FileStatus = new WinFormsField("FILE-STATUS", "FileStatus");
        public static WinFormsField CreationDate = new WinFormsField("CREATION-DATE", "CreationDate");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
