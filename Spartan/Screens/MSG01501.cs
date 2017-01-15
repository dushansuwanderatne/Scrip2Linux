using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG01501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG01501", "FormName");
		//Fields


        public static WinFormsField ReportDesc = new WinFormsField("REPORT-DESC", "ReportDesc");
        public static WinFormsField FromDate = new WinFormsField("FROM-DATE", "FromDate");
        public static WinFormsField TODate = new WinFormsField("TO-DATE", "TODate");
        public static WinFormsField Role = new WinFormsField("ROLE", "Role");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField RoleOwnerEmail = new WinFormsField("ROLE-OWNER-EMAIL", "RoleOwnerEmail");
        public static WinFormsField ProduceUserGroups = new WinFormsField("PRODUCE-USER-GROUPS", "ProduceUserGroups");
        public static WinFormsField SuppressMail = new WinFormsField("SUPPRESS-MAIL", "SuppressMail");
        public static WinFormsField FileLocation = new WinFormsField("FILE-LOCATION", "FileLocation");
    }
}
