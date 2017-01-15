using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SFLT0106

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SFLT0106", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField NumberTrans = new WinFormsField("NUMBER-TRANS", "NumberTrans");
        public static WinFormsField StartTrans = new WinFormsField("START-TRANS", "StartTrans");
        public static WinFormsField EndTrans = new WinFormsField("END-TRANS", "EndTrans");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
    }
}
