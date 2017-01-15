using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ATODET01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ATODET01", "FormName");
		//Fields


        public static WinFormsField AtodetKey0 = new WinFormsField("ATODET-KEY0", "AtodetKey0");
        public static WinFormsField FinYear = new WinFormsField("FIN-YEAR", "FinYear");
        public static WinFormsField AtoStatus = new WinFormsField("ATO-STATUS", "AtoStatus");
        public static WinFormsField ReportFormat = new WinFormsField("REPORT-FORMAT", "ReportFormat");
        public static WinFormsField PaydscChangedInd = new WinFormsField("PAYDSC-CHANGED-IND", "PaydscChangedInd");
        public static WinFormsField AtoFileRef = new WinFormsField("ATO-FILE-REF", "AtoFileRef");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField FY = new WinFormsField("FY", "FY");
        public static WinFormsField Version = new WinFormsField("VERSION", "Version");
        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField Coy = new WinFormsField("COY", "Coy");
        public static WinFormsField AtoReplacementRef = new WinFormsField("ATO-REPLACEMENT-REF", "AtoReplacementRef");
        public static WinFormsField RecordsWritten = new WinFormsField("RECORDS-WRITTEN", "RecordsWritten");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
