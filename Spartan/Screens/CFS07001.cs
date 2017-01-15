using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS07001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS07001", "FormName");
		//Fields


        public static WinFormsField ConnectionCode = new WinFormsField("CONNECTION-CODE", "ConnectionCode");
        public static WinFormsField ConnectionDesc = new WinFormsField("CONNECTION-DESC", "ConnectionDesc");
        public static WinFormsField Destination = new WinFormsField("DESTINATION", "Destination");
        public static WinFormsField LoginName = new WinFormsField("LOGIN-NAME", "LoginName");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
        public static WinFormsField Queue = new WinFormsField("QUEUE", "Queue");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchConnection = new WinFormsField("SEARCH-CONNECTION", "SearchConnection");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
    }
}
