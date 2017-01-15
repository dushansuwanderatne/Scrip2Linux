using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELCOY01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELCOY01", "FormName");
		//Fields
        public static WinFormsField SelUfd = new WinFormsField("SEL-UFD", "SelUfd");
        public static WinFormsField CoynameFilter = new WinFormsField("COYNAME-FILTER", "CoynameFilter");
    }
}
