using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AOS01012

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AOS01012", "FormName");
		//Fields


        public static WinFormsField AssociatedWith = new WinFormsField("ASSOCIATED-WITH", "AssociatedWith");
        public static WinFormsField AssociatedID = new WinFormsField("ASSOCIATED-ID", "AssociatedID");
        public static WinFormsField AssociatedDetail = new WinFormsField("ASSOCIATED-DETAIL", "AssociatedDetail");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField Region = new WinFormsField("REGION", "Region");
        public static WinFormsField Quantity = new WinFormsField("QUANTITY", "Quantity");
        public static WinFormsField UnitPrice = new WinFormsField("UNIT-PRICE", "UnitPrice");
        public static WinFormsField TotalValue = new WinFormsField("TOTAL-VALUE", "TotalValue");
        public static WinFormsField DescriptionLine = new WinFormsField("DESCRIPTION-LINE", "DescriptionLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
