using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS06001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS06001", "FormName");
		//Fields


        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField CompanyUfd = new WinFormsField("COMPANY-UFD", "CompanyUfd");
        public static WinFormsField RecordLength = new WinFormsField("RECORD-LENGTH", "RecordLength");
        public static WinFormsField BlockFactor = new WinFormsField("BLOCK-FACTOR", "BlockFactor");
        public static WinFormsField TapeBpi = new WinFormsField("TAPE-BPI", "TapeBpi");
        public static WinFormsField TapeLabel = new WinFormsField("TAPE-LABEL", "TapeLabel");
        public static WinFormsField TapeFormat = new WinFormsField("TAPE-FORMAT", "TapeFormat");
        public static WinFormsField CshareCode = new WinFormsField("CSHARE-CODE", "CshareCode");
        public static WinFormsField FileLayoutName = new WinFormsField("FILE-LAYOUT-NAME", "FileLayoutName");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchFileName = new WinFormsField("SEARCH-FILE-NAME", "SearchFileName");
        public static WinFormsField SearchClientCode = new WinFormsField("SEARCH-CLIENT-CODE", "SearchClientCode");
        public static WinFormsField SearchCompanyUfd = new WinFormsField("SEARCH-COMPANY-UFD", "SearchCompanyUfd");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
