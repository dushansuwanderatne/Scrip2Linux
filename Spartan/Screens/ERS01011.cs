using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ERS01011

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ERS01011", "FormName");
		//Fields
        public static WinFormsField EmpCommMethodsInd = new WinFormsField("EMP-COMM-METHODS-IND", "EmpCommMethodsInd");
        public static WinFormsField StaticASATRunNum = new WinFormsField("STATIC-AS-AT-RUN-NUM", "StaticASATRunNum");
        public static WinFormsField CostCentreInd = new WinFormsField("COST-CENTRE-IND", "CostCentreInd");
        public static WinFormsField EmpStatChgInd = new WinFormsField("EMP-STAT-CHG-IND", "EmpStatChgInd");
        public static WinFormsField LevrPckSentDateInd = new WinFormsField("LEVR-PCK-SENT-DATE-IND", "LevrPckSentDateInd");
        public static WinFormsField BlkoutRstrctdInd = new WinFormsField("BLKOUT-RSTRCTD-IND", "BlkoutRstrctdInd");
        public static WinFormsField BlkoutRstrctdCdeInd = new WinFormsField("BLKOUT-RSTRCTD-CDE-IND", "BlkoutRstrctdCdeInd");
        public static WinFormsField SubPayrollIDInd = new WinFormsField("SUB-PAYROLL-ID-IND", "SubPayrollIDInd");
        public static WinFormsField LeaverCodeInd = new WinFormsField("LEAVER-CODE-IND", "LeaverCodeInd");
        public static WinFormsField EmpUniqueIDInd = new WinFormsField("EMP-UNIQUE-ID-IND", "EmpUniqueIDInd");
        public static WinFormsField GspEmployeeInd = new WinFormsField("GSP-EMPLOYEE-IND", "GspEmployeeInd");
    }
}
