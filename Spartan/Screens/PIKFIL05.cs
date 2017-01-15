using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PIKFIL05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PIKFIL05", "FormName");
		//Fields


        public static WinFormsField WildString = new WinFormsField("WILD-STRING", "WildString");
        public static WinFormsField FileSequence = new WinFormsField("FILE-SEQUENCE", "FileSequence");
    }
}
