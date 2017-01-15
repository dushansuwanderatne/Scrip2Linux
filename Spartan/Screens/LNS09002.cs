using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS09002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS09002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField OutputLinkType = new WinFormsField("OUTPUT-LINK-TYPE", "OutputLinkType");
        public static WinFormsField LinkDesc = new WinFormsField("LINK-DESC", "LinkDesc");
        public static WinFormsField PrintFileName = new WinFormsField("PRINT-FILE-NAME", "PrintFileName");
        public static WinFormsField InputLinkType = new WinFormsField("INPUT-LINK-TYPE", "InputLinkType");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
