using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS24002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS24002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField CounterHolderID = new WinFormsField("COUNTER-HOLDER-ID", "CounterHolderID");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderPostcode = new WinFormsField("HOLDER-POSTCODE", "HolderPostcode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
