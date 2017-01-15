using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS00202

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS00202", "FormName");
		//Fields


        public static WinFormsField PasswordOutput = new WinFormsField("PASSWORD-OUTPUT", "PasswordOutput");
        public static WinFormsField RunDate1Output = new WinFormsField("RUN-DATE1-OUTPUT", "RunDate1Output");
        public static WinFormsField RunDate1Desc = new WinFormsField("RUN-DATE1-DESC", "RunDate1Desc");
        public static WinFormsField RunDate2Output = new WinFormsField("RUN-DATE2-OUTPUT", "RunDate2Output");
        public static WinFormsField RunDate2Desc = new WinFormsField("RUN-DATE2-DESC", "RunDate2Desc");
        public static WinFormsField RunDate3Output = new WinFormsField("RUN-DATE3-OUTPUT", "RunDate3Output");
        public static WinFormsField RunDate3Desc = new WinFormsField("RUN-DATE3-DESC", "RunDate3Desc");
        public static WinFormsField PasswordInput = new WinFormsField("PASSWORD-INPUT", "PasswordInput");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
