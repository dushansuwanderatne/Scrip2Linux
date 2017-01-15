using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSBHP07

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSBHP07", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField HolderAddress1 = new WinFormsField("HOLDER-ADDRESS-1", "HolderAddress1");
        public static WinFormsField HolderAddress2 = new WinFormsField("HOLDER-ADDRESS-2", "HolderAddress2");
        public static WinFormsField DivCommute = new WinFormsField("DIV-COMMUTE", "DivCommute");
        public static WinFormsField Dip = new WinFormsField("DIP", "Dip");
        public static WinFormsField Bsp = new WinFormsField("BSP", "Bsp");
        public static WinFormsField BspLine = new WinFormsField("BSP-LINE", "BspLine");
        public static WinFormsField SourceDesc = new WinFormsField("SOURCE-DESC", "SourceDesc");
        public static WinFormsField SourceOption = new WinFormsField("SOURCE-OPTION", "SourceOption");
        public static WinFormsField DrpLine = new WinFormsField("DRP-LINE", "DrpLine");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
