using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SELCOY20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SELCOY20", "FormName");
		//Fields


        public static WinFormsField Ufd = new WinFormsField("UFD", "Ufd");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField SelUfd = new WinFormsField("SEL-UFD", "SelUfd");
        public static WinFormsField CoynameFilter = new WinFormsField("COYNAME-FILTER", "CoynameFilter");
    }
}
