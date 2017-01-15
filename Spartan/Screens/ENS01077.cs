using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENS01077

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENS01077", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Consideration = new WinFormsField("CONSIDERATION", "Consideration");
        public static WinFormsField CertShape = new WinFormsField("CERT-SHAPE", "CertShape");
        public static WinFormsField CrestFileSeq = new WinFormsField("CREST-FILE-SEQ", "CrestFileSeq");
        public static WinFormsField CrestFileSplit = new WinFormsField("CREST-FILE-SPLIT", "CrestFileSplit");
        public static WinFormsField CrestItemSeq = new WinFormsField("CREST-ITEM-SEQ", "CrestItemSeq");
        public static WinFormsField Certid1to10 = new WinFormsField("CERTID-1TO10", "Certid1to10");
        public static WinFormsField Certid11to20 = new WinFormsField("CERTID-11TO20", "Certid11to20");
        public static WinFormsField Certid21to30 = new WinFormsField("CERTID-21TO30", "Certid21to30");
    }
}
