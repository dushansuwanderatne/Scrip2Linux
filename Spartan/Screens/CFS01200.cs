using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS01200

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS01200", "FormName");
		//Fields


        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField ProcessName = new WinFormsField("PROCESS-NAME", "ProcessName");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField EventNumber = new WinFormsField("EVENT-NUMBER", "EventNumber");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField FileUfd = new WinFormsField("FILE-UFD", "FileUfd");
        public static WinFormsField ProcessDesc40 = new WinFormsField("PROCESS-DESC-40", "ProcessDesc40");
        public static WinFormsField ProcessInformation = new WinFormsField("PROCESS-INFORMATION", "ProcessInformation");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
        public static WinFormsField DateCreated = new WinFormsField("DATE-CREATED", "DateCreated");
        public static WinFormsField TimeCreated = new WinFormsField("TIME-CREATED", "TimeCreated");
        public static WinFormsField DateTOBEProcessed = new WinFormsField("DATE-TO-BE-PROCESSED", "DateTOBEProcessed");
        public static WinFormsField Count = new WinFormsField("COUNT", "Count");
        public static WinFormsField Units = new WinFormsField("UNITS", "Units");
        public static WinFormsField ActualCount = new WinFormsField("ACTUAL-COUNT", "ActualCount");
        public static WinFormsField ActualUnits = new WinFormsField("ACTUAL-UNITS", "ActualUnits");
        public static WinFormsField CreatingFlag = new WinFormsField("CREATING-FLAG", "CreatingFlag");
        public static WinFormsField ProcessingFlag = new WinFormsField("PROCESSING-FLAG", "ProcessingFlag");
        public static WinFormsField RunProcessed = new WinFormsField("RUN-PROCESSED", "RunProcessed");
        public static WinFormsField DateProcessed = new WinFormsField("DATE-PROCESSED", "DateProcessed");
        public static WinFormsField TimeProcessed = new WinFormsField("TIME-PROCESSED", "TimeProcessed");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchCompanyUfd = new WinFormsField("SEARCH-COMPANY-UFD", "SearchCompanyUfd");
        public static WinFormsField SearchProcessName = new WinFormsField("SEARCH-PROCESS-NAME", "SearchProcessName");
        public static WinFormsField SearchEventNumber = new WinFormsField("SEARCH-EVENT-NUMBER", "SearchEventNumber");
    }
}
