using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01013

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01013", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TopUPIssNum = new WinFormsField("TOP-UP-ISS-NUM", "TopUPIssNum");
        public static WinFormsField TopUPHolders = new WinFormsField("TOP-UP-HOLDERS", "TopUPHolders");
        public static WinFormsField TopUPFlagNumber = new WinFormsField("TOP-UP-FLAG-NUMBER", "TopUPFlagNumber");
        public static WinFormsField TopUPFlagValue = new WinFormsField("TOP-UP-FLAG-VALUE", "TopUPFlagValue");
        public static WinFormsField TopUPCls = new WinFormsField("TOP-UP-CLS", "TopUPCls");
        public static WinFormsField Input = new WinFormsField("INPUT", "Input");
    }
}
