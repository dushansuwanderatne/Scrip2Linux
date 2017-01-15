using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBPC0103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBPC0103", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField EmployeeClass = new WinFormsField("EMPLOYEE-CLASS", "EmployeeClass");
        public static WinFormsField IssueClass = new WinFormsField("ISSUE-CLASS", "IssueClass");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField Sequence = new WinFormsField("SEQUENCE", "Sequence");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
