using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSEWP05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSEWP05", "FormName");
		//Fields


        public static WinFormsField MenuItemEnq = new WinFormsField("MENU-ITEM-ENQ", "ENQ.   Enquire on White Pages", "EnquireonWhitePages");
        public static WinFormsField MenuItemState = new WinFormsField("MENU-ITEM-STATE", "STATE. Change State", "ChangeState");
        public static WinFormsField MenuItemBook = new WinFormsField("MENU-ITEM-BOOK", "BOOK.  Select Books for Multi-Book enquiries", "SelectBooksforMulti-Bookenquiries");
        public static WinFormsField MenuItemBill = new WinFormsField("MENU-ITEM-BILL", "BILL.  Billing information", "Billinginformation");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField BooksSelected = new WinFormsField("BOOKS-SELECTED", "BooksSelected");
    }
}
