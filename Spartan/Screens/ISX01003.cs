using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01003

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01003", "FormName");
		//Fields


        public static WinFormsField CAEntClass = new WinFormsField("CA-ENT-CLASS", "CAEntClass");
        public static WinFormsField CAAccClass = new WinFormsField("CA-ACC-CLASS", "CAAccClass");
        public static WinFormsField CAMnyClass = new WinFormsField("CA-MNY-CLASS", "CAMnyClass");
        public static WinFormsField CAAdnClass = new WinFormsField("CA-ADN-CLASS", "CAAdnClass");
        public static WinFormsField CAAmyClass = new WinFormsField("CA-AMY-CLASS", "CAAmyClass");
        public static WinFormsField CAOvrClass = new WinFormsField("CA-OVR-CLASS", "CAOvrClass");
    }
}
