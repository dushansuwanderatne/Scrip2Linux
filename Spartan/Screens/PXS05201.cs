using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS05201

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS05201", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Res1to20 = new WinFormsField("RES-1TO20", "Res1to20");
        public static WinFormsField Res21to40 = new WinFormsField("RES-21TO40", "Res21to40");
        public static WinFormsField Res41to60 = new WinFormsField("RES-41TO60", "Res41to60");
        public static WinFormsField Res61to80 = new WinFormsField("RES-61TO80", "Res61to80");
        public static WinFormsField Res81to99 = new WinFormsField("RES-81TO99", "Res81to99");
    }
}
