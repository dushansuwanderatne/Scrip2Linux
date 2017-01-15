using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSLSWP4

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSLSWP4", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Form = new WinFormsField("FORM", "Form");
        public static WinFormsField Count = new WinFormsField("COUNT", "Count");
        public static WinFormsField Investor = new WinFormsField("INVESTOR", "Investor");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField Line1 = new WinFormsField("LINE-1", "Line1");
        public static WinFormsField Line2 = new WinFormsField("LINE-2", "Line2");
        public static WinFormsField Line3 = new WinFormsField("LINE-3", "Line3");
        public static WinFormsField Line4 = new WinFormsField("LINE-4", "Line4");
        public static WinFormsField Line5 = new WinFormsField("LINE-5", "Line5");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField OFAddressee = new WinFormsField("OF-ADDRESSEE", "OFAddressee");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
    }
}
