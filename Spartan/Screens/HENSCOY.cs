using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HENSCOY

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HENSCOY", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  Changing companies (Selecting company)", "Changingcompanies(Selectingcompany)");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Restricting enquiry to one class of shares", "Restrictingenquirytooneclassofshares");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Display the Company Notice", "DisplaytheCompanyNotice");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4.  Display run numbers and associated dates", "Displayrunnumbersandassociateddates");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5.  Restrict enquiry to an as at run or run range", "Restrictenquirytoanasatrunorrunrange");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
