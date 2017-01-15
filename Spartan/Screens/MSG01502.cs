using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01502", "FormName");
		//Fields


        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField OutFromDate = new WinFormsField("OUT-FROM-DATE", "OutFromDate");
        public static WinFormsField OutTODate = new WinFormsField("OUT-TO-DATE", "OutTODate");
        public static WinFormsField OutUserName = new WinFormsField("OUT-USER-NAME", "OutUserName");
        public static WinFormsField OutRole = new WinFormsField("OUT-ROLE", "OutRole");
        public static WinFormsField OutClientCode = new WinFormsField("OUT-CLIENT-CODE", "OutClientCode");
        public static WinFormsField OutCompany = new WinFormsField("OUT-COMPANY", "OutCompany");
        public static WinFormsField OutProduceUserGrp = new WinFormsField("OUT-PRODUCE-USER-GRP", "OutProduceUserGrp");
        public static WinFormsField OutSuppressMail = new WinFormsField("OUT-SUPPRESS-MAIL", "OutSuppressMail");
        public static WinFormsField OutFileLocation = new WinFormsField("OUT-FILE-LOCATION", "OutFileLocation");
        public static WinFormsField OutReportDesc = new WinFormsField("OUT-REPORT-DESC", "OutReportDesc");
        public static WinFormsField OutRoleOwnerEmail = new WinFormsField("OUT-ROLE-OWNER-EMAIL", "OutRoleOwnerEmail");
    }
}
