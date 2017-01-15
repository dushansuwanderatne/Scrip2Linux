using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS11

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS11", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField PrintFN = new WinFormsField("PRINT-FN", "PrintFN");
        public static WinFormsField CurrentPrinter = new WinFormsField("CURRENT-PRINTER", "CurrentPrinter");
        public static WinFormsField CurrentForm = new WinFormsField("CURRENT-FORM", "CurrentForm");
        public static WinFormsField PrintCopies = new WinFormsField("PRINT-COPIES", "PrintCopies");
        public static WinFormsField FromPage = new WinFormsField("FROM-PAGE", "FromPage");
        public static WinFormsField TOPage = new WinFormsField("TO-PAGE", "TOPage");
        public static WinFormsField Encrypt = new WinFormsField("ENCRYPT", "Encrypt");
        public static WinFormsField Rotate = new WinFormsField("ROTATE", "Rotate");
        public static WinFormsField Font = new WinFormsField("FONT", "Font");
        public static WinFormsField Size = new WinFormsField("SIZE", "Size");
        public static WinFormsField Left = new WinFormsField("LEFT", "Left");
        public static WinFormsField Right = new WinFormsField("RIGHT", "Right");
        public static WinFormsField UP = new WinFormsField("UP", "UP");
        public static WinFormsField Down = new WinFormsField("DOWN", "Down");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
