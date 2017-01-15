using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField CommenceDate = new WinFormsField("COMMENCE-DATE", "CommenceDate");
        public static WinFormsField ContribType = new WinFormsField("CONTRIB-TYPE", "ContribType");
        public static WinFormsField ForeignCurrFlag = new WinFormsField("FOREIGN-CURR-FLAG", "ForeignCurrFlag");
        public static WinFormsField ForeignCurrDesc = new WinFormsField("FOREIGN-CURR-DESC", "ForeignCurrDesc");
        public static WinFormsField AmountINWordsFlag = new WinFormsField("AMOUNT-IN-WORDS-FLAG", "AmountINWordsFlag");
        public static WinFormsField PayrollTapeFlag = new WinFormsField("PAYROLL-TAPE-FLAG", "PayrollTapeFlag");
        public static WinFormsField PayrollTransType = new WinFormsField("PAYROLL-TRANS-TYPE", "PayrollTransType");
        public static WinFormsField EmpClassCode = new WinFormsField("EMP-CLASS-CODE", "EmpClassCode");
        public static WinFormsField EmpTaxCategory = new WinFormsField("EMP-TAX-CATEGORY", "EmpTaxCategory");
        public static WinFormsField EmpContribMin = new WinFormsField("EMP-CONTRIB-MIN", "EmpContribMin");
        public static WinFormsField EmpContribMult = new WinFormsField("EMP-CONTRIB-MULT", "EmpContribMult");
        public static WinFormsField EmpContribMaxInd = new WinFormsField("EMP-CONTRIB-MAX-IND", "EmpContribMaxInd");
        public static WinFormsField EmpContribMax = new WinFormsField("EMP-CONTRIB-MAX", "EmpContribMax");
        public static WinFormsField EmpMaxCFMoneyInd = new WinFormsField("EMP-MAX-CF-MONEY-IND", "EmpMaxCFMoneyInd");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
