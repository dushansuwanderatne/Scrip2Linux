using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TNS01112

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TNS01112", "FormName");
		//Fields


        public static WinFormsField WarningGeneral = new WinFormsField("WARNING-GENERAL", "WarningGeneral");
        public static WinFormsField TfnWarn1 = new WinFormsField("TFN-WARN-1", "TfnWarn1");
        public static WinFormsField AbnWarn1 = new WinFormsField("ABN-WARN-1", "AbnWarn1");
        public static WinFormsField TfnWarn2 = new WinFormsField("TFN-WARN-2", "TfnWarn2");
        public static WinFormsField AbnWarn2 = new WinFormsField("ABN-WARN-2", "AbnWarn2");
        public static WinFormsField TfnWarn3 = new WinFormsField("TFN-WARN-3", "TfnWarn3");
        public static WinFormsField AbnWarn3 = new WinFormsField("ABN-WARN-3", "AbnWarn3");
        public static WinFormsField TfnWarn4 = new WinFormsField("TFN-WARN-4", "TfnWarn4");
        public static WinFormsField AbnWarn4 = new WinFormsField("ABN-WARN-4", "AbnWarn4");
        public static WinFormsField TfnWarn5 = new WinFormsField("TFN-WARN-5", "TfnWarn5");
        public static WinFormsField AbnWarn5 = new WinFormsField("ABN-WARN-5", "AbnWarn5");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
