using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00401", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField BankFormat = new WinFormsField("BANK-FORMAT", "BankFormat");
        public static WinFormsField BankFormatDesc = new WinFormsField("BANK-FORMAT-DESC", "BankFormatDesc");
        public static WinFormsField SearchBankFormat = new WinFormsField("SEARCH-BANK-FORMAT", "SearchBankFormat");
        public static WinFormsField PropertyID = new WinFormsField("PROPERTY-ID", "PropertyID");
        public static WinFormsField PropertyName = new WinFormsField("PROPERTY-NAME", "PropertyName");
        public static WinFormsField PropertyValue = new WinFormsField("PROPERTY-VALUE", "PropertyValue");
        public static WinFormsField PropertyTypeDesc = new WinFormsField("PROPERTY-TYPE-DESC", "PropertyTypeDesc");
        public static WinFormsField PropertyChildID = new WinFormsField("PROPERTY-CHILD-ID", "PropertyChildID");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
