using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT0911

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT0911", "FormName");
		//Fields


        public static WinFormsField WarningLine = new WinFormsField("WARNING-LINE", "WarningLine");
        public static WinFormsField ReasonLine = new WinFormsField("REASON-LINE", "ReasonLine");
        public static WinFormsField UpdateTfn = new WinFormsField("UPDATE-TFN", "UpdateTfn");
        public static WinFormsField UpdateDcb = new WinFormsField("UPDATE-DCB", "UpdateDcb");
        public static WinFormsField UpdateExt = new WinFormsField("UPDATE-EXT", "UpdateExt");
        public static WinFormsField TfnDcbExtLoaded = new WinFormsField("TFN-DCB-EXT-LOADED", "TfnDcbExtLoaded");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
