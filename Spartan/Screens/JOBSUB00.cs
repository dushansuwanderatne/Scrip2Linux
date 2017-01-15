using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB00
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("JOBSUB00", "FormName");
        //Fields
        public static WinFormsField AfterUrr = new WinFormsField("AFTER-URR", "AfterUrr");
        public static WinFormsField SaveYN = new WinFormsField("SAVE-YN", "SaveYN");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
