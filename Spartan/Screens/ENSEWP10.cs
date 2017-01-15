using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP10", "FormName");
		//Fields


        public static WinFormsField Billing = new WinFormsField("BILLING", "Billing");
        public static WinFormsField Address = new WinFormsField("ADDRESS", "Address");
        public static WinFormsField SearchType = new WinFormsField("SEARCH-TYPE", "SearchType");
        public static WinFormsField More = new WinFormsField("MORE", "More");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField MultiBook = new WinFormsField("MULTI-BOOK", "MultiBook");
        public static WinFormsField State = new WinFormsField("STATE", "State");
        public static WinFormsField Location = new WinFormsField("LOCATION", "Location");
        public static WinFormsField Street = new WinFormsField("STREET", "Street");
        public static WinFormsField Book = new WinFormsField("BOOK", "Book");
    }
}
