using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ICRAMT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ICRAMT01", "FormName");
		//Fields


        public static WinFormsField IcramtKey0 = new WinFormsField("ICRAMT-KEY0", "IcramtKey0");
        public static WinFormsField CompanyRefX = new WinFormsField("COMPANY-REF-X", "CompanyRefX");
        public static WinFormsField GroupID = new WinFormsField("GROUP-ID", "GroupID");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField IcrType = new WinFormsField("ICR-TYPE", "IcrType");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField Amount = new WinFormsField("AMOUNT", "Amount");
        public static WinFormsField AmountReasonCode = new WinFormsField("AMOUNT-REASON-CODE", "AmountReasonCode");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField ToleranceEndDate = new WinFormsField("TOLERANCE-END-DATE", "ToleranceEndDate");
        public static WinFormsField DateLastChanged = new WinFormsField("DATE-LAST-CHANGED", "DateLastChanged");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
