using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CSM00100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CSM00100", "FormName");
		//Fields


        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField LotNumber = new WinFormsField("LOT-NUMBER", "LotNumber");
        public static WinFormsField Owner = new WinFormsField("OWNER", "Owner");
        public static WinFormsField ShortDescription = new WinFormsField("SHORT-DESCRIPTION", "ShortDescription");
        public static WinFormsField ExtraDetail = new WinFormsField("EXTRA-DETAIL", "ExtraDetail");
        public static WinFormsField ReservePrice = new WinFormsField("RESERVE-PRICE", "ReservePrice");
        public static WinFormsField SalePrice = new WinFormsField("SALE-PRICE", "SalePrice");
        public static WinFormsField SoldTO = new WinFormsField("SOLD-TO", "SoldTO");
        public static WinFormsField SaleNotes = new WinFormsField("SALE-NOTES", "SaleNotes");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCode = new WinFormsField("SEARCH-CODE", "SearchCode");
        public static WinFormsField SearchLotNumber = new WinFormsField("SEARCH-LOT-NUMBER", "SearchLotNumber");
    }
}
