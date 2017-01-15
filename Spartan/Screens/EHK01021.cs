using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01021

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01021", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField SchemeType = new WinFormsField("SCHEME-TYPE", "SchemeType");
        public static WinFormsField ClassDescription = new WinFormsField("CLASS-DESCRIPTION", "ClassDescription");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField VsaJurisCodes = new WinFormsField("VSA-JURIS-CODES", "VsaJurisCodes");
        public static WinFormsField VsaClassCodes = new WinFormsField("VSA-CLASS-CODES", "VsaClassCodes");
        public static WinFormsField Commit = new WinFormsField("COMMIT", "Commit");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
