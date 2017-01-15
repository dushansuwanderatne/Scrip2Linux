using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS01511

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PXS01511", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField MeetingHeading = new WinFormsField("MEETING-HEADING", "MeetingHeading");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Noma = new WinFormsField("NOMA", "Noma");
        public static WinFormsField R1Dsc = new WinFormsField("R1-DSC", "R1Dsc");
        public static WinFormsField R1f = new WinFormsField("R1F", "R1f");
        public static WinFormsField R1a = new WinFormsField("R1A", "R1a");
        public static WinFormsField Open1 = new WinFormsField("OPEN-1", "Open1");
        public static WinFormsField Abst1 = new WinFormsField("ABST-1", "Abst1");
        public static WinFormsField Excl1 = new WinFormsField("EXCL-1", "Excl1");
        public static WinFormsField R2Dsc = new WinFormsField("R2-DSC", "R2Dsc");
        public static WinFormsField R2f = new WinFormsField("R2F", "R2f");
        public static WinFormsField R2a = new WinFormsField("R2A", "R2a");
        public static WinFormsField Open2 = new WinFormsField("OPEN-2", "Open2");
        public static WinFormsField Abst2 = new WinFormsField("ABST-2", "Abst2");
        public static WinFormsField Excl2 = new WinFormsField("EXCL-2", "Excl2");
        public static WinFormsField R3Dsc = new WinFormsField("R3-DSC", "R3Dsc");
        public static WinFormsField R3f = new WinFormsField("R3F", "R3f");
        public static WinFormsField R3a = new WinFormsField("R3A", "R3a");
        public static WinFormsField Open3 = new WinFormsField("OPEN-3", "Open3");
        public static WinFormsField Abst3 = new WinFormsField("ABST-3", "Abst3");
        public static WinFormsField Excl3 = new WinFormsField("EXCL-3", "Excl3");
        public static WinFormsField R4Dsc = new WinFormsField("R4-DSC", "R4Dsc");
        public static WinFormsField R4f = new WinFormsField("R4F", "R4f");
        public static WinFormsField R4a = new WinFormsField("R4A", "R4a");
        public static WinFormsField Open4 = new WinFormsField("OPEN-4", "Open4");
        public static WinFormsField Abst4 = new WinFormsField("ABST-4", "Abst4");
        public static WinFormsField Excl4 = new WinFormsField("EXCL-4", "Excl4");
        public static WinFormsField R5Dsc = new WinFormsField("R5-DSC", "R5Dsc");
        public static WinFormsField R5f = new WinFormsField("R5F", "R5f");
        public static WinFormsField R5a = new WinFormsField("R5A", "R5a");
        public static WinFormsField Open5 = new WinFormsField("OPEN-5", "Open5");
        public static WinFormsField Abst5 = new WinFormsField("ABST-5", "Abst5");
        public static WinFormsField Excl5 = new WinFormsField("EXCL-5", "Excl5");
        public static WinFormsField R6Dsc = new WinFormsField("R6-DSC", "R6Dsc");
        public static WinFormsField R6f = new WinFormsField("R6F", "R6f");
        public static WinFormsField R6a = new WinFormsField("R6A", "R6a");
        public static WinFormsField Open6 = new WinFormsField("OPEN-6", "Open6");
        public static WinFormsField Abst6 = new WinFormsField("ABST-6", "Abst6");
        public static WinFormsField Excl6 = new WinFormsField("EXCL-6", "Excl6");
        public static WinFormsField R7Dsc = new WinFormsField("R7-DSC", "R7Dsc");
        public static WinFormsField R7f = new WinFormsField("R7F", "R7f");
        public static WinFormsField R7a = new WinFormsField("R7A", "R7a");
        public static WinFormsField Open7 = new WinFormsField("OPEN-7", "Open7");
        public static WinFormsField Abst7 = new WinFormsField("ABST-7", "Abst7");
        public static WinFormsField Excl7 = new WinFormsField("EXCL-7", "Excl7");
        public static WinFormsField R8Dsc = new WinFormsField("R8-DSC", "R8Dsc");
        public static WinFormsField R8f = new WinFormsField("R8F", "R8f");
        public static WinFormsField R8a = new WinFormsField("R8A", "R8a");
        public static WinFormsField Open8 = new WinFormsField("OPEN-8", "Open8");
        public static WinFormsField Abst8 = new WinFormsField("ABST-8", "Abst8");
        public static WinFormsField Excl8 = new WinFormsField("EXCL-8", "Excl8");
        public static WinFormsField R9Dsc = new WinFormsField("R9-DSC", "R9Dsc");
        public static WinFormsField R9f = new WinFormsField("R9F", "R9f");
        public static WinFormsField R9a = new WinFormsField("R9A", "R9a");
        public static WinFormsField Open9 = new WinFormsField("OPEN-9", "Open9");
        public static WinFormsField Abst9 = new WinFormsField("ABST-9", "Abst9");
        public static WinFormsField Excl9 = new WinFormsField("EXCL-9", "Excl9");
        public static WinFormsField R10Dsc = new WinFormsField("R10-DSC", "R10Dsc");
        public static WinFormsField R10f = new WinFormsField("R10F", "R10f");
        public static WinFormsField R10a = new WinFormsField("R10A", "R10a");
        public static WinFormsField Open10 = new WinFormsField("OPEN-10", "Open10");
        public static WinFormsField Abst10 = new WinFormsField("ABST-10", "Abst10");
        public static WinFormsField Excl10 = new WinFormsField("EXCL-10", "Excl10");
    }
}
