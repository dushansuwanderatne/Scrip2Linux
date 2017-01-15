using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CNV03097

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CNV03097", "FormName");
		//Fields


        public static WinFormsField SelMigParams = new WinFormsField("SEL-MIG-PARAMS", "SelMigParams");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
    }
}
