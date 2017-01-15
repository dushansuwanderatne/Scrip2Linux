using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNV03099

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNV03099", "FormName");
		//Fields


        public static WinFormsField LineNumber1 = new WinFormsField("LINE-NUMBER-1", "LineNumber1");
        public static WinFormsField RecordType1 = new WinFormsField("RECORD-TYPE-1", "RecordType1");
        public static WinFormsField RecordTypeDesc1 = new WinFormsField("RECORD-TYPE-DESC-1", "RecordTypeDesc1");
        public static WinFormsField LNSelected = new WinFormsField("LN-SELECTED", "LNSelected");
    }
}
