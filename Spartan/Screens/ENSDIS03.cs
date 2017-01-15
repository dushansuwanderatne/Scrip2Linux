using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSDIS03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSDIS03", "FormName");
		//Fields


        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TinFormatted = new WinFormsField("TIN-FORMATTED", "TinFormatted");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderNameAddress = new WinFormsField("HOLDER-NAME-ADDRESS", "HolderNameAddress");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField TransCode = new WinFormsField("TRANS-CODE", "TransCode");
        public static WinFormsField OrigRefNumberX = new WinFormsField("ORIG-REF-NUMBER-X", "OrigRefNumberX");
        public static WinFormsField OrigPayMethod = new WinFormsField("ORIG-PAY-METHOD", "OrigPayMethod");
        public static WinFormsField ReplRefNumberX = new WinFormsField("REPL-REF-NUMBER-X", "ReplRefNumberX");
        public static WinFormsField OrigNettAmount = new WinFormsField("ORIG-NETT-AMOUNT", "OrigNettAmount");
        public static WinFormsField ReplPayMethod = new WinFormsField("REPL-PAY-METHOD", "ReplPayMethod");
        public static WinFormsField ReplNettAmount = new WinFormsField("REPL-NETT-AMOUNT", "ReplNettAmount");
        public static WinFormsField OrigPayAccount = new WinFormsField("ORIG-PAY-ACCOUNT", "OrigPayAccount");
        public static WinFormsField ReplPayAccount = new WinFormsField("REPL-PAY-ACCOUNT", "ReplPayAccount");
        public static WinFormsField UserID = new WinFormsField("USER-ID", "UserID");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDesc = new WinFormsField("TRANS-DESC", "TransDesc");
        public static WinFormsField Comment1 = new WinFormsField("COMMENT1", "Comment1");
        public static WinFormsField Comment2 = new WinFormsField("COMMENT2", "Comment2");
        public static WinFormsField PullLocationCode = new WinFormsField("PULL-LOCATION-CODE", "PullLocationCode");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
