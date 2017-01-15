using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP1004

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP1004", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField CentreMismatchDesc = new WinFormsField("CENTRE-MISMATCH-DESC", "CentreMismatchDesc");
        public static WinFormsField CurrCentreCode = new WinFormsField("CURR-CENTRE-CODE", "CurrCentreCode");
        public static WinFormsField CurrCentreDesc = new WinFormsField("CURR-CENTRE-DESC", "CurrCentreDesc");
        public static WinFormsField NewCentreCode = new WinFormsField("NEW-CENTRE-CODE", "NewCentreCode");
        public static WinFormsField NewCentreDesc = new WinFormsField("NEW-CENTRE-DESC", "NewCentreDesc");
        public static WinFormsField GradeMismatchDesc = new WinFormsField("GRADE-MISMATCH-DESC", "GradeMismatchDesc");
        public static WinFormsField CurrEmpGrade = new WinFormsField("CURR-EMP-GRADE", "CurrEmpGrade");
        public static WinFormsField CurrEmpGradeDesc = new WinFormsField("CURR-EMP-GRADE-DESC", "CurrEmpGradeDesc");
        public static WinFormsField NewEmpGrade = new WinFormsField("NEW-EMP-GRADE", "NewEmpGrade");
        public static WinFormsField NewEmpGradeDesc = new WinFormsField("NEW-EMP-GRADE-DESC", "NewEmpGradeDesc");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
