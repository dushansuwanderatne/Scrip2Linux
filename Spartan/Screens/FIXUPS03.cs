using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIXUPS03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIXUPS03", "FormName");
		//Fields


        public static WinFormsField MenuItemBnkacc = new WinFormsField("MENU-ITEM-BNKACC", "BNKACC. Bank Account File", "BankAccountFile");
        public static WinFormsField MenuItemCprctl = new WinFormsField("MENU-ITEM-CPRCTL", "CPRCTL. Cheque Print Control File", "ChequePrintControlFile");
        public static WinFormsField MenuItemNombac = new WinFormsField("MENU-ITEM-NOMBAC", "NOMBAC. Nominated Bank Account", "NominatedBankAccount");
        public static WinFormsField MenuItemCprfil = new WinFormsField("MENU-ITEM-CPRFIL", "CPRFIL. Cheque Print File Totals", "ChequePrintFileTotals");
        public static WinFormsField MenuItemBacdet = new WinFormsField("MENU-ITEM-BACDET", "BACDET. Bank Account Details", "BankAccountDetails");
        public static WinFormsField MenuItemCprdet = new WinFormsField("MENU-ITEM-CPRDET", "CPRDET. Cheque Print Detail File", "ChequePrintDetailFile");
        public static WinFormsField MenuItemBachis = new WinFormsField("MENU-ITEM-BACHIS", "BACHIS. Bank Account History", "BankAccountHistory");
        public static WinFormsField MenuItemPndpay = new WinFormsField("MENU-ITEM-PNDPAY", "PNDPAY. Pending Payment", "PendingPayment");
        public static WinFormsField MenuItemPndstp = new WinFormsField("MENU-ITEM-PNDSTP", "PNDSTP. Pending Step", "PendingStep");
        public static WinFormsField MenuItemPndnot = new WinFormsField("MENU-ITEM-PNDNOT", "PNDNOT. Pending Note", "PendingNote");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit", "Exit");
    }
}
