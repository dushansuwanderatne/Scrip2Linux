using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS05100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS05100", "FormName");
		//Fields


        public static WinFormsField Vshare = new WinFormsField("VSHARE", "Vshare");
        public static WinFormsField Nvshare = new WinFormsField("NVSHARE", "Nvshare");
        public static WinFormsField NomPerson = new WinFormsField("NOM-PERSON", "NomPerson");
        public static WinFormsField Visitor = new WinFormsField("VISITOR", "Visitor");
        public static WinFormsField Total = new WinFormsField("TOTAL", "Total");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
