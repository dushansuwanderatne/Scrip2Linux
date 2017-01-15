using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS01001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField InvestorNumber = new WinFormsField("INVESTOR-NUMBER", "InvestorNumber");
        public static WinFormsField LinkCount = new WinFormsField("LINK-COUNT", "LinkCount");
        public static WinFormsField InvestorNameKey = new WinFormsField("INVESTOR-NAME-KEY", "InvestorNameKey");
        public static WinFormsField MailingAddressLine = new WinFormsField("MAILING-ADDRESS-LINE", "MailingAddressLine");
        public static WinFormsField GlobalAddressLine = new WinFormsField("GLOBAL-ADDRESS-LINE", "GlobalAddressLine");
        public static WinFormsField MailingPostcode = new WinFormsField("MAILING-POSTCODE", "MailingPostcode");
        public static WinFormsField MailingDomicileCode = new WinFormsField("MAILING-DOMICILE-CODE", "MailingDomicileCode");
        public static WinFormsField GlobalPostcode = new WinFormsField("GLOBAL-POSTCODE", "GlobalPostcode");
        public static WinFormsField GlobalDomicileCode = new WinFormsField("GLOBAL-DOMICILE-CODE", "GlobalDomicileCode");
        public static WinFormsField PhoneNumber = new WinFormsField("PHONE-NUMBER", "PhoneNumber");
        public static WinFormsField ParticipantID = new WinFormsField("PARTICIPANT-ID", "ParticipantID");
        public static WinFormsField CrestMode = new WinFormsField("CREST-MODE", "CrestMode");
        public static WinFormsField DateAdded = new WinFormsField("DATE-ADDED", "DateAdded");
        public static WinFormsField AccountID = new WinFormsField("ACCOUNT-ID", "AccountID");
        public static WinFormsField StatementValue1 = new WinFormsField("STATEMENT-VALUE-1", "StatementValue1");
        public static WinFormsField StatementValue2 = new WinFormsField("STATEMENT-VALUE-2", "StatementValue2");
        public static WinFormsField StatementValue3 = new WinFormsField("STATEMENT-VALUE-3", "StatementValue3");
        public static WinFormsField StatementValue4 = new WinFormsField("STATEMENT-VALUE-4", "StatementValue4");
        public static WinFormsField StatementValue5 = new WinFormsField("STATEMENT-VALUE-5", "StatementValue5");
        public static WinFormsField HolderType = new WinFormsField("HOLDER-TYPE", "HolderType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
    }
}
