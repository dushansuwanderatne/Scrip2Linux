using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06301

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06301", "FormName");
		//Fields


        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField FromDate = new WinFormsField("FROM-DATE", "FromDate");
        public static WinFormsField AsxHeader = new WinFormsField("ASX-HEADER", "AsxHeader");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField High = new WinFormsField("HIGH", "High");
        public static WinFormsField Low = new WinFormsField("LOW", "Low");
        public static WinFormsField Close = new WinFormsField("CLOSE", "Close");
        public static WinFormsField Diff = new WinFormsField("DIFF", "Diff");
        public static WinFormsField Vol = new WinFormsField("VOL", "Vol");
        public static WinFormsField Trans = new WinFormsField("TRANS", "Trans");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
