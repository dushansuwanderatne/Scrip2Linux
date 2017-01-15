using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOMADD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOMADD01", "FormName");
		//Fields


        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Type = new WinFormsField("TYPE", "Type");
        public static WinFormsField RestrictionType = new WinFormsField("RESTRICTION-TYPE", "RestrictionType");
    }
}
