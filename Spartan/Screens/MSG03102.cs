using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG03102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG03102", "FormName");
		//Fields


        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField DateTime = new WinFormsField("DATE-TIME", "DateTime");
        public static WinFormsField TopicDesc = new WinFormsField("TOPIC-DESC", "TopicDesc");
        public static WinFormsField AsxID = new WinFormsField("ASX-ID", "AsxID");
        public static WinFormsField ReadMessage = new WinFormsField("READ-MESSAGE", "ReadMessage");
    }
}
