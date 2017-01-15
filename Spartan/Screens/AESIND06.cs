using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class AESIND06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("AESIND06", "FormName");
		//Fields


        public static WinFormsField Identifier = new WinFormsField("IDENTIFIER", "Identifier");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField Region = new WinFormsField("REGION", "Region");
        public static WinFormsField Quantity = new WinFormsField("QUANTITY", "Quantity");
        public static WinFormsField UnitPrice = new WinFormsField("UNIT-PRICE", "UnitPrice");
        public static WinFormsField TotalValue = new WinFormsField("TOTAL-VALUE", "TotalValue");
        public static WinFormsField DescriptionLine = new WinFormsField("DESCRIPTION-LINE", "DescriptionLine");
        public static WinFormsField LastChgDate = new WinFormsField("LAST-CHG-DATE", "LastChgDate");
        public static WinFormsField LastChgMsgid = new WinFormsField("LAST-CHG-MSGID", "LastChgMsgid");
        public static WinFormsField LastChgName = new WinFormsField("LAST-CHG-NAME", "LastChgName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Count = new WinFormsField("COUNT", "Count");
        public static WinFormsField Locate = new WinFormsField("LOCATE", "Locate");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
