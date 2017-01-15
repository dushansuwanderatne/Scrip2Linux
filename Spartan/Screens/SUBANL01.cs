using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SUBANL01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SUBANL01", "FormName");
		//Fields


        public static WinFormsField SubanlKey0 = new WinFormsField("SUBANL-KEY0", "SubanlKey0");
        public static WinFormsField LibraryName1 = new WinFormsField("LIBRARY-NAME-1", "LibraryName1");
        public static WinFormsField ModuleType = new WinFormsField("MODULE-TYPE", "ModuleType");
        public static WinFormsField Occurences1 = new WinFormsField("OCCURENCES-1", "Occurences1");
        public static WinFormsField LibraryName2 = new WinFormsField("LIBRARY-NAME-2", "LibraryName2");
        public static WinFormsField TotalTimeModule = new WinFormsField("TOTAL-TIME-MODULE", "TotalTimeModule");
        public static WinFormsField RealTimeModule = new WinFormsField("REAL-TIME-MODULE", "RealTimeModule");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
