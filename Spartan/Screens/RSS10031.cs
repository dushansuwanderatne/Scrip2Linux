using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10031

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10031", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1.  New Shareholder Notices", "NewShareholderNotices");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2.  Special Program", "SpecialProgram");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3.  Company CPL", "CompanyCPL");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField NewsholderFormat = new WinFormsField("NEWSHOLDER-FORMAT", "NewsholderFormat");
        public static WinFormsField ProxyReconReqd = new WinFormsField("PROXY-RECON-REQD", "ProxyReconReqd");
        public static WinFormsField SpecialProgram = new WinFormsField("SPECIAL-PROGRAM", "SpecialProgram");
        public static WinFormsField CompanyCplName = new WinFormsField("COMPANY-CPL-NAME", "CompanyCplName");
        public static WinFormsField SpecialOption = new WinFormsField("SPECIAL-OPTION", "SpecialOption");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
