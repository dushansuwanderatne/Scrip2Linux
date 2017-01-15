using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FLT01030

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FLT01030", "FormName");
		//Fields


        public static WinFormsField PreloadHstAnnualRpt = new WinFormsField("PRELOAD-HST-ANNUAL-RPT", "PreloadHstAnnualRpt");
        public static WinFormsField PreloadHvfFlag = new WinFormsField("PRELOAD-HVF-FLAG", "PreloadHvfFlag");
        public static WinFormsField PreloadVariableField = new WinFormsField("PRELOAD-VARIABLE-FIELD", "PreloadVariableField");
        public static WinFormsField PreloadHolderAltID = new WinFormsField("PRELOAD-HOLDER-ALT-ID", "PreloadHolderAltID");
        public static WinFormsField PreloadHldrExtraID = new WinFormsField("PRELOAD-HLDR-EXTRA-ID", "PreloadHldrExtraID");
        public static WinFormsField PreloadHomePhone = new WinFormsField("PRELOAD-HOME-PHONE", "PreloadHomePhone");
        public static WinFormsField PreloadWorkPhone = new WinFormsField("PRELOAD-WORK-PHONE", "PreloadWorkPhone");
        public static WinFormsField PreloadFaxNumber = new WinFormsField("PRELOAD-FAX-NUMBER", "PreloadFaxNumber");
        public static WinFormsField PreloadMobilePhone = new WinFormsField("PRELOAD-MOBILE-PHONE", "PreloadMobilePhone");
        public static WinFormsField PreloadEmailAddress = new WinFormsField("PRELOAD-EMAIL-ADDRESS", "PreloadEmailAddress");
        public static WinFormsField PreloadEWFlag = new WinFormsField("PRELOAD-EW-FLAG", "PreloadEWFlag");
        public static WinFormsField PreloadCommMethods = new WinFormsField("PRELOAD-COMM-METHODS", "PreloadCommMethods");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
