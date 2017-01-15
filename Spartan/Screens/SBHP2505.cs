using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SBHP2505

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SBHP2505", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField UnitsExercised = new WinFormsField("UNITS-EXERCISED", "UnitsExercised");
        public static WinFormsField MaxExercised = new WinFormsField("MAX-EXERCISED", "MaxExercised");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
