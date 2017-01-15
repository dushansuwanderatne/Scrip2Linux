using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSSTAT

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSSTAT", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Name, address, flags, warnings, etc", "Name,address,flags,warnings,etc");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Payee Instruction", "PayeeInstruction");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Notings", "Notings");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Static transactions for this holder", "Statictransactionsforthisholder");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5.  Display next six holders name/address", "Displaynextsixholdersname/address");
        public static WinFormsField MenuItem6 = new WinFormsField("MENU-ITEM-6", "6.  Display previous six holders name/addresses", "Displayprevioussixholdersname/addresses");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
