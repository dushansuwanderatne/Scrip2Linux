using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDJSD20

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDJSD20", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField RecType = new WinFormsField("REC-TYPE", "RecType");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderJntID = new WinFormsField("HOLDER-JNT-ID", "HolderJntID");
        public static WinFormsField SubType = new WinFormsField("SUB-TYPE", "SubType");
        public static WinFormsField HldjsdKey0 = new WinFormsField("HLDJSD-KEY0", "HldjsdKey0");
    }
}
