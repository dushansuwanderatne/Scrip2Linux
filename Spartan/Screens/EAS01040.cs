using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EAS01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EAS01040", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField AllotNum = new WinFormsField("ALLOT-NUM", "AllotNum");
        public static WinFormsField AllotDesc = new WinFormsField("ALLOT-DESC", "AllotDesc");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField ProcessType = new WinFormsField("PROCESS-TYPE", "ProcessType");
        public static WinFormsField AllotEmpPrice = new WinFormsField("ALLOT-EMP-PRICE", "AllotEmpPrice");
        public static WinFormsField AllotCoyPrice = new WinFormsField("ALLOT-COY-PRICE", "AllotCoyPrice");
        public static WinFormsField AllotUnits = new WinFormsField("ALLOT-UNITS", "AllotUnits");
        public static WinFormsField AllotCertDate = new WinFormsField("ALLOT-CERT-DATE", "AllotCertDate");
        public static WinFormsField AllotTransType = new WinFormsField("ALLOT-TRANS-TYPE", "AllotTransType");
        public static WinFormsField VestDate = new WinFormsField("VEST-DATE", "VestDate");
        public static WinFormsField VestTransType = new WinFormsField("VEST-TRANS-TYPE", "VestTransType");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
