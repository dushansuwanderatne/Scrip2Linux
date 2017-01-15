using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOMSCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOMSCH01", "FormName");
		//Fields
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField PresentYN = new WinFormsField("PRESENT-YN", "PresentYN");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField RestrictionType = new WinFormsField("RESTRICTION-TYPE", "RestrictionType");
        public static WinFormsField Current = new WinFormsField("CURRENT", "Current");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchNomCode = new WinFormsField("SEARCH-NOM-CODE", "SearchNomCode");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
    }
}
