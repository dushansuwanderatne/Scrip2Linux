using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS03501

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS03501", "FormName");
		//Fields
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ActionClass = new WinFormsField("ACTION-CLASS", "ActionClass");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ParticipationOption = new WinFormsField("PARTICIPATION-OPTION", "ParticipationOption");
        public static WinFormsField ParticipationLevel = new WinFormsField("PARTICIPATION-LEVEL", "ParticipationLevel");
        public static WinFormsField CharityCode = new WinFormsField("CHARITY-CODE", "CharityCode");
        public static WinFormsField ApplicationDate = new WinFormsField("APPLICATION-DATE", "ApplicationDate");
        public static WinFormsField LastChangeDate = new WinFormsField("LAST-CHANGE-DATE", "LastChangeDate");
        public static WinFormsField StatusDescription = new WinFormsField("STATUS DESCRIPTION", "StatusDescription");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
