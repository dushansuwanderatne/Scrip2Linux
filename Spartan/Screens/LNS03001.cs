using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LNS03001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LNS03001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField LinkType = new WinFormsField("LINK-TYPE", "LinkType");
        public static WinFormsField LinkDescription = new WinFormsField("LINK-DESCRIPTION", "LinkDescription");
        public static WinFormsField NOLinks = new WinFormsField("NO-LINKS", "NOLinks");
        public static WinFormsField AddedFrom = new WinFormsField("ADDED-FROM", "AddedFrom");
        public static WinFormsField AddedTO = new WinFormsField("ADDED-TO", "AddedTO");
        public static WinFormsField PCFrom = new WinFormsField("PC-FROM", "PCFrom");
        public static WinFormsField PCTO = new WinFormsField("PC-TO", "PCTO");
        public static WinFormsField PCAddress = new WinFormsField("PC-ADDRESS", "PCAddress");
        public static WinFormsField UseInput = new WinFormsField("USE-INPUT", "UseInput");
        public static WinFormsField InputName = new WinFormsField("INPUT-NAME", "InputName");
        public static WinFormsField UseOutput = new WinFormsField("USE-OUTPUT", "UseOutput");
        public static WinFormsField OutputName = new WinFormsField("OUTPUT-NAME", "OutputName");
    }
}
