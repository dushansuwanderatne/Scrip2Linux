using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MALADD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MALADD01", "FormName");
		//Fields


        public static WinFormsField ParticipantNumber = new WinFormsField("PARTICIPANT-NUMBER", "ParticipantNumber");
        public static WinFormsField MaladdKey1 = new WinFormsField("MALADD-KEY1", "MaladdKey1");
        public static WinFormsField TitleDescription = new WinFormsField("TITLE-DESCRIPTION", "TitleDescription");
        public static WinFormsField MaladdKey2 = new WinFormsField("MALADD-KEY2", "MaladdKey2");
        public static WinFormsField DateLastChanged = new WinFormsField("DATE-LAST-CHANGED", "DateLastChanged");
        public static WinFormsField DateAdded = new WinFormsField("DATE-ADDED", "DateAdded");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField Group1 = new WinFormsField("GROUP1", "Group1");
        public static WinFormsField Group2 = new WinFormsField("GROUP2", "Group2");
        public static WinFormsField RunLastChanged = new WinFormsField("RUN-LAST-CHANGED", "RunLastChanged");
        public static WinFormsField Copies = new WinFormsField("COPIES", "Copies");
        public static WinFormsField Company1 = new WinFormsField("COMPANY1", "Company1");
        public static WinFormsField Company2 = new WinFormsField("COMPANY2", "Company2");
        public static WinFormsField Company3 = new WinFormsField("COMPANY3", "Company3");
        public static WinFormsField Company4 = new WinFormsField("COMPANY4", "Company4");
        public static WinFormsField Company5 = new WinFormsField("COMPANY5", "Company5");
        public static WinFormsField Company6 = new WinFormsField("COMPANY6", "Company6");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
