using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRIMOS54

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRIMOS54", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField PrimosName = new WinFormsField("PRIMOS-NAME", "PrimosName");
        public static WinFormsField PCName = new WinFormsField("PC-NAME", "PCName");
        public static WinFormsField Min = new WinFormsField("MIN", "Min");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
