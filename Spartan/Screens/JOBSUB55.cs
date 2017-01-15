using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB55

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB55", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MailingHouse = new WinFormsField("MAILING-HOUSE", "MailingHouse");
        public static WinFormsField Eom = new WinFormsField("EOM", "Eom");
    }
}
