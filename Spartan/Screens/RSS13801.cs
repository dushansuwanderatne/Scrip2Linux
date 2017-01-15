using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS13801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS13801", "FormName");
		//Fields


        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyCode = new WinFormsField("COMPANY-CODE", "CompanyCode");
        public static WinFormsField FromDate = new WinFormsField("FROM-DATE", "FromDate");
        public static WinFormsField PendingReason = new WinFormsField("PENDING-REASON", "PendingReason");
        public static WinFormsField DocumentType = new WinFormsField("DOCUMENT-TYPE", "DocumentType");
        public static WinFormsField PendingStatus = new WinFormsField("PENDING-STATUS", "PendingStatus");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
