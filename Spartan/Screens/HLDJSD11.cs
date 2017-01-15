using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDJSD11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDJSD11", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField RecType = new WinFormsField("REC-TYPE", "RecType");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderJntID = new WinFormsField("HOLDER-JNT-ID", "HolderJntID");
        public static WinFormsField SubType = new WinFormsField("SUB-TYPE", "SubType");
        public static WinFormsField HldjsdKey0 = new WinFormsField("HLDJSD-KEY0", "HldjsdKey0");
        public static WinFormsField IrlBenAddrLine = new WinFormsField("IRL-BEN-ADDR-LINE", "IrlBenAddrLine");
        public static WinFormsField IrlBenAddrPC = new WinFormsField("IRL-BEN-ADDR-PC", "IrlBenAddrPC");
    }
}
