using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SRS02000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SRS02000", "FormName");
		//Fields


        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField MailingContact = new WinFormsField("MAILING-CONTACT", "MailingContact");
        public static WinFormsField MailingTitle = new WinFormsField("MAILING-TITLE", "MailingTitle");
        public static WinFormsField NOOFUsers = new WinFormsField("NO-OF-USERS", "NOOFUsers");
        public static WinFormsField SurePassword = new WinFormsField("SURE-PASSWORD", "SurePassword");
        public static WinFormsField NOAcceses = new WinFormsField("NO-ACCESES", "NOAcceses");
        public static WinFormsField SwitchBoardNO = new WinFormsField("SWITCH-BOARD-NO", "SwitchBoardNO");
        public static WinFormsField TotalTime = new WinFormsField("TOTAL-TIME", "TotalTime");
        public static WinFormsField FaxNO = new WinFormsField("FAX-NO", "FaxNO");
        public static WinFormsField TypeOFConnection = new WinFormsField("TYPE-OF-CONNECTION", "TypeOFConnection");
        public static WinFormsField NodeAddress = new WinFormsField("NODE-ADDRESS", "NodeAddress");
        public static WinFormsField DateRegSent = new WinFormsField("DATE-REG-SENT", "DateRegSent");
        public static WinFormsField X25Password = new WinFormsField("X25-PASSWORD", "X25Password");
        public static WinFormsField DateRegReceived = new WinFormsField("DATE-REG-RECEIVED", "DateRegReceived");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField BrokerSearch = new WinFormsField("BROKER-SEARCH", "BrokerSearch");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
