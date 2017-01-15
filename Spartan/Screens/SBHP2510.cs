using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP2510

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP2510", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField CentreCode = new WinFormsField("CENTRE-CODE", "CentreCode");
        public static WinFormsField CentreCodeDesc = new WinFormsField("CENTRE-CODE-DESC", "CentreCodeDesc");
        public static WinFormsField EmployeeGrade = new WinFormsField("EMPLOYEE-GRADE", "EmployeeGrade");
        public static WinFormsField EmployeeGradeDesc = new WinFormsField("EMPLOYEE-GRADE-DESC", "EmployeeGradeDesc");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
