using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS00503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS00503", "FormName");
		//Fields


        public static WinFormsField MenuID = new WinFormsField("MENU-ID", "MenuID");
        public static WinFormsField MenuIDDup = new WinFormsField("MENU-ID-DUP", "MenuIDDup");
        public static WinFormsField IncExlTrans = new WinFormsField("INC-EXL-TRANS", "IncExlTrans");
        public static WinFormsField Trans00116 = new WinFormsField("TRANS-001-16", "Trans00116");
        public static WinFormsField Trans01732 = new WinFormsField("TRANS-017-32", "Trans01732");
        public static WinFormsField Trans03348 = new WinFormsField("TRANS-033-48", "Trans03348");
        public static WinFormsField Trans04960 = new WinFormsField("TRANS-049-60", "Trans04960");
        public static WinFormsField PageHeader = new WinFormsField("PAGE-HEADER", "PageHeader");
        public static WinFormsField EnqTransmit = new WinFormsField("ENQ-TRANSMIT", "EnqTransmit");
    }
}
