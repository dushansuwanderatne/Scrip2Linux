using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTGR

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTGR", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField BadDeliveryReason = new WinFormsField("BAD-DELIVERY-REASON", "BadDeliveryReason");
        public static WinFormsField ErrorLines = new WinFormsField("ERROR-LINES", "ErrorLines");
    }
}
