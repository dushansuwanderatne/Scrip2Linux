using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNV03006

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNV03006", "FormName");
		//Fields


        public static WinFormsField CompanyID = new WinFormsField("COMPANY-ID", "CompanyID");
        public static WinFormsField RecordType = new WinFormsField("RECORD-TYPE", "RecordType");
        public static WinFormsField ForeignCode = new WinFormsField("FOREIGN-CODE", "ForeignCode");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField ScripCodeX4 = new WinFormsField("SCRIP-CODE-X4", "ScripCodeX4");
        public static WinFormsField MigrateInd = new WinFormsField("MIGRATE-IND", "MigrateInd");
        public static WinFormsField DivRate = new WinFormsField("DIV-RATE", "DivRate");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompanyID = new WinFormsField("SEARCH-COMPANY-ID", "SearchCompanyID");
        public static WinFormsField SearchRecordType = new WinFormsField("SEARCH-RECORD-TYPE", "SearchRecordType");
        public static WinFormsField SearchForeignCode = new WinFormsField("SEARCH-FOREIGN-CODE", "SearchForeignCode");
        public static WinFormsField AddRecordType = new WinFormsField("ADD-RECORD-TYPE", "AddRecordType");
        public static WinFormsField Dummy = new WinFormsField("DUMMY", "Dummy");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
    }
}
