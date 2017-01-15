using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSESS22

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSESS22", "FormName");
		//Fields
        public static WinFormsField Ensess22ForfeitureType1 = new WinFormsField("ENSESS22-FORFEITURE-TYPE-1", "Ensess22ForfeitureType1");
        public static WinFormsField Ensess22ForfStartDate1 = new WinFormsField("ENSESS22-FORF-START-DATE-1", "Ensess22ForfStartDate1");
        public static WinFormsField Ensess22ForfEndDate1 = new WinFormsField("ENSESS22-FORF-END-DATE-1", "Ensess22ForfEndDate1");
        public static WinFormsField Ensess22ForfPercentage1 = new WinFormsField("ENSESS22-FORF-PERCENTAGE-1", "Ensess22ForfPercentage1");
    }
}
