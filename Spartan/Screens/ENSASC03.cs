using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSASC03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSASC03", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OrgNumber = new WinFormsField("ORG-NUMBER", "OrgNumber");
        public static WinFormsField OrgName1 = new WinFormsField("ORG-NAME1", "OrgName1");
        public static WinFormsField OrgName2 = new WinFormsField("ORG-NAME2", "OrgName2");
        public static WinFormsField OrgState = new WinFormsField("ORG-STATE", "OrgState");
        public static WinFormsField OrgStateNum = new WinFormsField("ORG-STATE-NUM", "OrgStateNum");
    }
}
