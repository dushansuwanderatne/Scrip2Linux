using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDSST02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDSST02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TransCode = new WinFormsField("TRANS-CODE", "TransCode");
        public static WinFormsField TransDesc = new WinFormsField("TRANS-DESC", "TransDesc");
        public static WinFormsField Principal = new WinFormsField("PRINCIPAL", "Principal");
        public static WinFormsField Accrued = new WinFormsField("ACCRUED", "Accrued");
        public static WinFormsField Compounded = new WinFormsField("COMPOUNDED", "Compounded");
        public static WinFormsField Entries = new WinFormsField("ENTRIES", "Entries");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}