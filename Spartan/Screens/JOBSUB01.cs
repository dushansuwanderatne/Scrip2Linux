using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB01", "FormName");
		//Fields


        public static WinFormsField System = new WinFormsField("SYSTEM", "System");
        public static WinFormsField SubSystem = new WinFormsField("SUB-SYSTEM", "SubSystem");
        public static WinFormsField Suffix = new WinFormsField("SUFFIX", "Suffix");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
