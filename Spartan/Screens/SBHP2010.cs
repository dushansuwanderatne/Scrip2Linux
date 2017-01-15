using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP2010

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP2010", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField IssueDate = new WinFormsField("ISSUE-DATE", "IssueDate");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
