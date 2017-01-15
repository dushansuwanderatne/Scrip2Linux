using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01038

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01038", "FormName");
		//Fields


        public static WinFormsField MenuAction = new WinFormsField("MENU-ACTION", "MenuAction");
        public static WinFormsField NumberX = new WinFormsField("NUMBER-X", "NumberX");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderNameAddress = new WinFormsField("HOLDER-NAME-ADDRESS", "HolderNameAddress");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
