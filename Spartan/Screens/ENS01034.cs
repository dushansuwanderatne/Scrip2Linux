using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01034

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01034", "FormName");
		//Fields
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField DateFirstHolder = new WinFormsField("DATE-FIRST-HOLDER", "DateFirstHolder");
        public static WinFormsField HolderONDate = new WinFormsField("HOLDER-ON-DATE", "HolderONDate");
        public static WinFormsField RunNumberPg1 = new WinFormsField("RUN-NUMBER-PG1", "RunNumberPg1");
        public static WinFormsField HldTransNumberPg1 = new WinFormsField("HLD-TRANS-NUMBER-PG1", "HldTransNumberPg1");
        public static WinFormsField TranDatePg1 = new WinFormsField("TRAN-DATE-PG1", "TranDatePg1");
        public static WinFormsField TranTypeCodePg1 = new WinFormsField("TRAN-TYPE-CODE-PG1", "TranTypeCodePg1");
        public static WinFormsField SlashPg1 = new WinFormsField("SLASH-PG1", "SlashPg1");
        public static WinFormsField TranTypeDescPg1 = new WinFormsField("TRAN-TYPE-DESC-PG1", "TranTypeDescPg1");
        public static WinFormsField ReferencePg1 = new WinFormsField("REFERENCE-PG1", "ReferencePg1");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SourcePg1 = new WinFormsField("SOURCE-PG1", "SourcePg1");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
