using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRS30

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRS30", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OrigNamekey = new WinFormsField("ORIG-NAMEKEY", "OrigNamekey");
        public static WinFormsField BuyerNamekey = new WinFormsField("BUYER-NAMEKEY", "BuyerNamekey");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
