using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DCRTLK10

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DCRTLK10", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TransType = new WinFormsField("TRANS-TYPE", "TransType");
        public static WinFormsField TransDesc = new WinFormsField("TRANS-DESC", "TransDesc");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField SeqNum = new WinFormsField("SEQ-NUM", "SeqNum");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
