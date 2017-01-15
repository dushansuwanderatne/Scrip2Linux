using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNV03007

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNV03007", "FormName");
		//Fields


        public static WinFormsField CompanyID = new WinFormsField("COMPANY-ID", "CompanyID");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField ForeignCat = new WinFormsField("FOREIGN-CAT", "ForeignCat");
        public static WinFormsField ScripCat = new WinFormsField("SCRIP-CAT", "ScripCat");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompanyID = new WinFormsField("SEARCH-COMPANY-ID", "SearchCompanyID");
        public static WinFormsField SearchRecordType = new WinFormsField("SEARCH-RECORD-TYPE", "SearchRecordType");
        public static WinFormsField SearchForeignCode = new WinFormsField("SEARCH-FOREIGN-CODE", "SearchForeignCode");
        public static WinFormsField AddRecordType = new WinFormsField("ADD-RECORD-TYPE", "AddRecordType");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
