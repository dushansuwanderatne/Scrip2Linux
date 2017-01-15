using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS01596

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS01596", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Domicile = new WinFormsField("DOMICILE", "Domicile");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Warning = new WinFormsField("WARNING", "Warning");
        public static WinFormsField Res1 = new WinFormsField("RES-1", "Res1");
        public static WinFormsField WfsShares1 = new WinFormsField("WFS-SHARES-1", "WfsShares1");
        public static WinFormsField Res2 = new WinFormsField("RES-2", "Res2");
        public static WinFormsField WfsShares2 = new WinFormsField("WFS-SHARES-2", "WfsShares2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
