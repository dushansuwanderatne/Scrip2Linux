using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SID00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SID00401", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SelCode = new WinFormsField("SEL-CODE", "SelCode");
        public static WinFormsField LinkFrom = new WinFormsField("LINK-FROM", "LinkFrom");
        public static WinFormsField MoveTO = new WinFormsField("MOVE-TO", "MoveTO");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Topic1 = new WinFormsField("TOPIC1", "Topic1");
        public static WinFormsField Topic2 = new WinFormsField("TOPIC2", "Topic2");
        public static WinFormsField Topic3 = new WinFormsField("TOPIC3", "Topic3");
        public static WinFormsField ReleaseDate = new WinFormsField("RELEASE-DATE", "ReleaseDate");
        public static WinFormsField RestrictFlag = new WinFormsField("RESTRICT-FLAG", "RestrictFlag");
    }
}
