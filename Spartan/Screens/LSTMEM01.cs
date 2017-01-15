using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSTMEM01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSTMEM01", "FormName");
		//Fields


        public static WinFormsField LstmemKey0 = new WinFormsField("LSTMEM-KEY0", "LstmemKey0");
        public static WinFormsField ListID = new WinFormsField("LIST-ID", "ListID");
        public static WinFormsField MemberType = new WinFormsField("MEMBER-TYPE", "MemberType");
        public static WinFormsField MemberIDH = new WinFormsField("MEMBER-ID-H", "MemberIDH");
        public static WinFormsField OrigSystem = new WinFormsField("ORIG-SYSTEM", "OrigSystem");
        public static WinFormsField Comments = new WinFormsField("COMMENTS", "Comments");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
