using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00901

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00901", "FormName");
		//Fields


        public static WinFormsField SearchedFilename = new WinFormsField("SEARCHED-FILENAME", "SearchedFilename");
        public static WinFormsField DisplayFilename = new WinFormsField("DISPLAY-FILENAME", "DisplayFilename");
        public static WinFormsField NumberOFPayments = new WinFormsField("NUMBER-OF-PAYMENTS", "NumberOFPayments");
        public static WinFormsField ValueOFPayments = new WinFormsField("VALUE-OF-PAYMENTS", "ValueOFPayments");
        public static WinFormsField DateCreated = new WinFormsField("DATE-CREATED", "DateCreated");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchFilename = new WinFormsField("SEARCH-FILENAME", "SearchFilename");
        public static WinFormsField SystemInfoDate5 = new WinFormsField("SYSTEM-INFO-DATE-5", "9", "9");
    }
}
