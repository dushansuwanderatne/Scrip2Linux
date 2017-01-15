using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CALCTL02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CALCTL02", "FormName");
		//Fields


        public static WinFormsField ListingRequired = new WinFormsField("LISTING-REQUIRED", "ListingRequired");
        public static WinFormsField RepHeading = new WinFormsField("REP-HEADING", "RepHeading");
        public static WinFormsField ListCert = new WinFormsField("LIST-CERT", "ListCert");
        public static WinFormsField XtrFilname = new WinFormsField("XTR-FILNAME", "XtrFilname");
        public static WinFormsField ListProgName = new WinFormsField("LIST-PROG-NAME", "ListProgName");
        public static WinFormsField NbrHolders = new WinFormsField("NBR-HOLDERS", "NbrHolders");
        public static WinFormsField MoneyPaid = new WinFormsField("MONEY-PAID", "MoneyPaid");
        public static WinFormsField Units1 = new WinFormsField("UNITS1", "Units1");
        public static WinFormsField Units2 = new WinFormsField("UNITS2", "Units2");
        public static WinFormsField OtherAllotedUnits = new WinFormsField("OTHER-ALLOTED-UNITS", "OtherAllotedUnits");
        public static WinFormsField StartIntDate = new WinFormsField("START-INT-DATE", "StartIntDate");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField FlatFee = new WinFormsField("FLAT-FEE", "FlatFee");
        public static WinFormsField InterestClass = new WinFormsField("INTEREST-CLASS", "InterestClass");
        public static WinFormsField FlatFeeClass = new WinFormsField("FLAT-FEE-CLASS", "FlatFeeClass");
        public static WinFormsField StartNoticeNumber = new WinFormsField("START-NOTICE-NUMBER", "StartNoticeNumber");
        public static WinFormsField PreEncoded = new WinFormsField("PRE-ENCODED", "PreEncoded");
        public static WinFormsField NoticeProgName = new WinFormsField("NOTICE-PROG-NAME", "NoticeProgName");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField NoticeSequence = new WinFormsField("NOTICE-SEQUENCE", "NoticeSequence");
        public static WinFormsField ClassDescOutput = new WinFormsField("CLASS-DESC-OUTPUT", "ClassDescOutput");
        public static WinFormsField ReturnMail = new WinFormsField("RETURN-MAIL", "ReturnMail");
        public static WinFormsField LabelComments = new WinFormsField("LABEL-COMMENTS", "LabelComments");
        public static WinFormsField NoticeChkdgtOption = new WinFormsField("NOTICE-CHKDGT-OPTION", "NoticeChkdgtOption");
        public static WinFormsField SuppNoticeFormat = new WinFormsField("SUPP-NOTICE-FORMAT", "SuppNoticeFormat");
        public static WinFormsField EntCommonwealth = new WinFormsField("ENT-COMMONWEALTH", "EntCommonwealth");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField OpsInitials = new WinFormsField("OPS-INITIALS", "OpsInitials");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
