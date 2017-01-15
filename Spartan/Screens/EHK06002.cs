using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK06002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK06002", "FormName");
		//Fields


        public static WinFormsField TrancheNumber = new WinFormsField("TRANCHE-NUMBER", "TrancheNumber");
        public static WinFormsField MnthsFromVestStart = new WinFormsField("MNTHS-FROM-VEST-START", "MnthsFromVestStart");
        public static WinFormsField DaysFromVestStart = new WinFormsField("DAYS-FROM-VEST-START", "DaysFromVestStart");
        public static WinFormsField VestingPercentage = new WinFormsField("VESTING-PERCENTAGE", "VestingPercentage");
        public static WinFormsField VestingDate = new WinFormsField("VESTING-DATE", "VestingDate");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
    }
}
