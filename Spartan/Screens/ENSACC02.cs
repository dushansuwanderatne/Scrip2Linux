using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSACC02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSACC02", "FormName");
		//Fields
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Subsystem = new WinFormsField("SUBSYSTEM", "Subsystem");
        public static WinFormsField ApplicationID = new WinFormsField("APPLICATION-ID", "ApplicationID");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TimestampDate = new WinFormsField("TIMESTAMP-DATE", "TimestampDate");
        public static WinFormsField EntitledUnits = new WinFormsField("ENTITLED-UNITS", "EntitledUnits");
        public static WinFormsField OverrideUnits = new WinFormsField("OVERRIDE-UNITS", "OverrideUnits");
        public static WinFormsField AcceptedUnits = new WinFormsField("ACCEPTED-UNITS", "AcceptedUnits");
        public static WinFormsField EntitledBal = new WinFormsField("ENTITLED-BAL", "EntitledBal");
        public static WinFormsField AdditionalUnits = new WinFormsField("ADDITIONAL-UNITS", "AdditionalUnits");
        public static WinFormsField TotalMoney = new WinFormsField("TOTAL-MONEY", "TotalMoney");
        public static WinFormsField AccStatusSdesc = new WinFormsField("ACC-STATUS-SDESC", "AccStatusSdesc");
        public static WinFormsField LatestTransSource = new WinFormsField("LATEST-TRANS-SOURCE", "LatestTransSource");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
