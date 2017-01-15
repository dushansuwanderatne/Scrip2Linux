using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS17001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS17001", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField IssspCloneID = new WinFormsField("ISSSP-CLONE-ID", "IssspCloneID");
        public static WinFormsField IssspClone4 = new WinFormsField("ISSSP-CLONE-4", "IssspClone4");
        public static WinFormsField CertfCloneID = new WinFormsField("CERTF-CLONE-ID", "CertfCloneID");
        public static WinFormsField CertfClone4 = new WinFormsField("CERTF-CLONE-4", "CertfClone4");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
