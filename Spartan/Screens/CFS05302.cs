using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS05302

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS05302", "FormName");
		//Fields


        public static WinFormsField ContactID = new WinFormsField("CONTACT-ID", "ContactID");
        public static WinFormsField ContactType = new WinFormsField("CONTACT-TYPE", "ContactType");
        public static WinFormsField ContactTypeDesc = new WinFormsField("CONTACT-TYPE-DESC", "ContactTypeDesc");
        public static WinFormsField AddrLineCh1to30 = new WinFormsField("ADDR-LINE-CH1TO30", "AddrLineCh1to30");
        public static WinFormsField AuditUser = new WinFormsField("AUDIT-USER", "AuditUser");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1 = new WinFormsField("ACTION-1", "Action1");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
