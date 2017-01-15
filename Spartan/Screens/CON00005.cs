using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CON00005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CON00005", "FormName");
		//Fields


        public static WinFormsField CompanyName = new WinFormsField("COMPANY-NAME", "CompanyName");
        public static WinFormsField OldCode4 = new WinFormsField("OLD-CODE-4", "OldCode4");
        public static WinFormsField Nal = new WinFormsField("NAL", "Nal");
        public static WinFormsField NewCode5 = new WinFormsField("NEW-CODE-5", "NewCode5");
        public static WinFormsField GroupNameLine = new WinFormsField("GROUP-NAME-LINE", "GroupNameLine");
    }
}
