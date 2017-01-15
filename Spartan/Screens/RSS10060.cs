using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10060

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10060", "FormName");
		//Fields
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField Group = new WinFormsField("GROUP", "Group");
        public static WinFormsField GroupIDX = new WinFormsField("GROUP-ID-X", "GroupIDX");
        public static WinFormsField ClsgrpOutputOption = new WinFormsField("CLSGRP-OUTPUT-OPTION", "ClsgrpOutputOption");
        public static WinFormsField ComboDescription = new WinFormsField("COMBO-DESCRIPTION", "ComboDescription");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
