using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MAL10002

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MAL10002", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree1 = new WinFormsField("SYSTEM-INFO-FREE-1", "15", "15");
        public static WinFormsField PostcodeFlag = new WinFormsField("POSTCODE-FLAG", "PostcodeFlag");
        public static WinFormsField PCFrom1 = new WinFormsField("PC-FROM1", "PCFrom1");
        public static WinFormsField PCTo1 = new WinFormsField("PC-TO1", "PCTo1");
        public static WinFormsField PCFrom2 = new WinFormsField("PC-FROM2", "PCFrom2");
        public static WinFormsField PCTo2 = new WinFormsField("PC-TO2", "PCTo2");
        public static WinFormsField PCFrom3 = new WinFormsField("PC-FROM3", "PCFrom3");
        public static WinFormsField PCTo3 = new WinFormsField("PC-TO3", "PCTo3");
        public static WinFormsField PCFrom4 = new WinFormsField("PC-FROM4", "PCFrom4");
        public static WinFormsField PCTo4 = new WinFormsField("PC-TO4", "PCTo4");
        public static WinFormsField DomcodeFlag = new WinFormsField("DOMCODE-FLAG", "DomcodeFlag");
        public static WinFormsField DomCodes = new WinFormsField("DOM-CODES", "DomCodes");
        public static WinFormsField DhaFrom = new WinFormsField("DHA-FROM", "DhaFrom");
        public static WinFormsField DhaTO = new WinFormsField("DHA-TO", "DhaTO");
        public static WinFormsField CopiesFrom = new WinFormsField("COPIES-FROM", "CopiesFrom");
        public static WinFormsField CopiesTO = new WinFormsField("COPIES-TO", "CopiesTO");
        public static WinFormsField RlcFrom = new WinFormsField("RLC-FROM", "RlcFrom");
        public static WinFormsField RlcTO = new WinFormsField("RLC-TO", "RlcTO");
    }
}
