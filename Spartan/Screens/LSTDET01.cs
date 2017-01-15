using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSTDET01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSTDET01", "FormName");
		//Fields


        public static WinFormsField LstdetKey0 = new WinFormsField("LSTDET-KEY0", "LstdetKey0");
        public static WinFormsField ListID = new WinFormsField("LIST-ID", "ListID");
        public static WinFormsField ListName = new WinFormsField("LIST-NAME", "ListName");
        public static WinFormsField ListType = new WinFormsField("LIST-TYPE", "ListType");
        public static WinFormsField Hint = new WinFormsField("HINT", "Hint");
        public static WinFormsField BusinessUnit = new WinFormsField("BUSINESS-UNIT", "BusinessUnit");
        public static WinFormsField OwnerName = new WinFormsField("OWNER-NAME", "OwnerName");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField EnteredListName = new WinFormsField("ENTERED-LIST-NAME", "EnteredListName");
        public static WinFormsField OrigSystem = new WinFormsField("ORIG-SYSTEM", "OrigSystem");
        public static WinFormsField AuditUserIdentifier = new WinFormsField("AUDIT-USER-IDENTIFIER", "AuditUserIdentifier");
        public static WinFormsField AuditDate = new WinFormsField("AUDIT-DATE", "AuditDate");
        public static WinFormsField AuditTime = new WinFormsField("AUDIT-TIME", "AuditTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
