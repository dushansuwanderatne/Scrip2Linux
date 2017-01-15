using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK06005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK06005", "FormName");
		//Fields


        public static WinFormsField TestNumber = new WinFormsField("TEST-NUMBER", "TestNumber");
        public static WinFormsField TestDate = new WinFormsField("TEST-DATE", "TestDate");
        public static WinFormsField TestPercent = new WinFormsField("TEST-PERCENT", "TestPercent");
        public static WinFormsField CancelUnv = new WinFormsField("CANCEL-UNV", "CancelUnv");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
    }
}
