using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN50

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN50", "FormName");
		//Fields


        public static WinFormsField Filename = new WinFormsField("FILENAME", "Filename");
        public static WinFormsField UserNumber = new WinFormsField("USER-NUMBER", "UserNumber");
        public static WinFormsField Program = new WinFormsField("PROGRAM", "Program");
        public static WinFormsField From1 = new WinFormsField("FROM1", "From1");
        public static WinFormsField To1 = new WinFormsField("TO1", "To1");
        public static WinFormsField From2 = new WinFormsField("FROM2", "From2");
        public static WinFormsField To2 = new WinFormsField("TO2", "To2");
        public static WinFormsField From3 = new WinFormsField("FROM3", "From3");
        public static WinFormsField To3 = new WinFormsField("TO3", "To3");
        public static WinFormsField From4 = new WinFormsField("FROM4", "From4");
        public static WinFormsField To4 = new WinFormsField("TO4", "To4");
        public static WinFormsField From5 = new WinFormsField("FROM5", "From5");
        public static WinFormsField To5 = new WinFormsField("TO5", "To5");
    }
}
