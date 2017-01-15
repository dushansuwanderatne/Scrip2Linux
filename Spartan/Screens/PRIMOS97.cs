using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS97

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS97", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Printer1 = new WinFormsField("PRINTER1", "Printer1");
        public static WinFormsField Printer2 = new WinFormsField("PRINTER2", "Printer2");
        public static WinFormsField Printer3 = new WinFormsField("PRINTER3", "Printer3");
        public static WinFormsField Printer4 = new WinFormsField("PRINTER4", "Printer4");
        public static WinFormsField Printer5 = new WinFormsField("PRINTER5", "Printer5");
        public static WinFormsField Printer6 = new WinFormsField("PRINTER6", "Printer6");
        public static WinFormsField Printer7 = new WinFormsField("PRINTER7", "Printer7");
        public static WinFormsField Printer8 = new WinFormsField("PRINTER8", "Printer8");
        public static WinFormsField Printer9 = new WinFormsField("PRINTER9", "Printer9");
        public static WinFormsField Printer10 = new WinFormsField("PRINTER10", "Printer10");
        public static WinFormsField CurrentPrinter = new WinFormsField("CURRENT-PRINTER", "CurrentPrinter");
    }
}
