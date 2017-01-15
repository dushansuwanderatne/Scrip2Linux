using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CAL01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CAL01030", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField NoticeProgName = new WinFormsField("NOTICE-PROG-NAME", "NoticeProgName");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField StartNoticeNumber = new WinFormsField("START-NOTICE-NUMBER", "StartNoticeNumber");
        public static WinFormsField NoticeChkOption = new WinFormsField("NOTICE-CHK-OPTION", "NoticeChkOption");
        public static WinFormsField EntCommonwealth = new WinFormsField("ENT-COMMONWEALTH", "EntCommonwealth");
        public static WinFormsField SuppNoticeFormat = new WinFormsField("SUPP-NOTICE-FORMAT", "SuppNoticeFormat");
        public static WinFormsField PrintUnitLabel = new WinFormsField("PRINT-UNIT-LABEL", "PrintUnitLabel");
        public static WinFormsField NoticeSequence = new WinFormsField("NOTICE-SEQUENCE", "NoticeSequence");
        public static WinFormsField ReturnMailInd = new WinFormsField("RETURN-MAIL-IND", "ReturnMailInd");
        public static WinFormsField PrintClassDesc = new WinFormsField("PRINT-CLASS-DESC", "PrintClassDesc");
        public static WinFormsField LatePayments = new WinFormsField("LATE-PAYMENTS", "LatePayments");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
