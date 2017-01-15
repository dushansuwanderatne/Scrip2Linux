using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS002WN

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS002WN", "FormName");
		//Fields


        public static WinFormsField BooksCloseWarn = new WinFormsField("BOOKS-CLOSE-WARN", "BooksCloseWarn");
        public static WinFormsField Arrow = new WinFormsField("ARROW", "Arrow");
        public static WinFormsField Date1Warning = new WinFormsField("DATE1-WARNING", "Date1Warning");
        public static WinFormsField Date2Warning = new WinFormsField("DATE2-WARNING", "Date2Warning");
        public static WinFormsField Date3Warning = new WinFormsField("DATE3-WARNING", "Date3Warning");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
