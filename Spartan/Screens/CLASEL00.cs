using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CLASEL00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CLASEL00", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "09", "09");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "03", "03");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ClassTable = new WinFormsField("CLASS-TABLE", "ClassTable");
        public static WinFormsField DescripTable = new WinFormsField("DESCRIP-TABLE", "DescripTable");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Descrip = new WinFormsField("DESCRIP", "Descrip");
        public static WinFormsField User1 = new WinFormsField("USER1", "User1");
        public static WinFormsField User2 = new WinFormsField("USER2", "User2");
        public static WinFormsField User3 = new WinFormsField("USER3", "User3");
        public static WinFormsField User4 = new WinFormsField("USER4", "User4");
        public static WinFormsField User5 = new WinFormsField("USER5", "User5");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
