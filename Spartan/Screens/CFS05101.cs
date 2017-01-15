using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS05101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS05101", "FormName");
		//Fields


        public static WinFormsField SecurityGroup = new WinFormsField("SECURITY-GROUP", "SecurityGroup");
        public static WinFormsField SequenceNumber = new WinFormsField("SEQUENCE-NUMBER", "SequenceNumber");
        public static WinFormsField SecurableDesc = new WinFormsField("SECURABLE-DESC", "SecurableDesc");
        public static WinFormsField NavigationPath = new WinFormsField("NAVIGATION-PATH", "NavigationPath");
        public static WinFormsField WinformsFormName = new WinFormsField("WINFORMS-FORM-NAME", "WinformsFormName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField SearchSecType = new WinFormsField("SEARCH-SEC-TYPE", "SearchSecType");
        public static WinFormsField SearchSeqNumber = new WinFormsField("SEARCH-SEQ-NUMBER", "SearchSeqNumber");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
