using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10048
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10048", "FormName");
        //Fields
        public static WinFormsField DetailRecordOutput = new WinFormsField("DETAIL-RECORD-OUTPUT", "DetailRecordOutput");
        public static WinFormsField Class = new WinFormsField("CLASS", "Class");
        public static WinFormsField RemittRefNumbers = new WinFormsField("REMITT-REF-NUMBERS", "RemittRefNumbers");
        public static WinFormsField GenerateRrn = new WinFormsField("GENERATE-RRN", "GenerateRrn");
        public static WinFormsField SlrDetails = new WinFormsField("SLR-DETAILS", "SlrDetails");
        public static WinFormsField SubRecTypeDetails = new WinFormsField("SUB-REC-TYPE-DETAILS", "SubRecTypeDetails");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", "6", "6");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}