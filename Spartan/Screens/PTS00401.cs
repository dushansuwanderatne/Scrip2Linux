using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00401", "FormName");
		//Fields


        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
    }
}
