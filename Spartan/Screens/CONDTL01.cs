using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CONDTL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CONDTL01", "FormName");
		//Fields


        public static WinFormsField CondtlKey0 = new WinFormsField("CONDTL-KEY0", "CondtlKey0");
        public static WinFormsField ContactID = new WinFormsField("CONTACT-ID", "ContactID");
        public static WinFormsField ContactTypeCode = new WinFormsField("CONTACT-TYPE-CODE", "ContactTypeCode");
        public static WinFormsField ContactNameKey = new WinFormsField("CONTACT-NAME-KEY", "ContactNameKey");
        public static WinFormsField AddrLineCh1to30 = new WinFormsField("ADDR-LINE-CH1TO30", "AddrLineCh1to30");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
