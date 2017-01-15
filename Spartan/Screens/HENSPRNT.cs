using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSPRNT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSPRNT", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Listing of registry transactions", "Listingofregistrytransactions");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Listing of payment transactions", "Listingofpaymenttransactions");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  FAST Statement", "FASTStatement");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Marking History Statement", "MarkingHistoryStatement");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
