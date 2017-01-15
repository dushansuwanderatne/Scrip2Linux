using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS06803

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS06803", "FormName");
		//Fields
        public static WinFormsField DeceasedHolderName = new WinFormsField("DECEASED-HOLDER-NAME", "DeceasedHolderName");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField TransDate = new WinFormsField("TRANS-DATE", "TransDate");
        public static WinFormsField DeceasedPackInd = new WinFormsField("DECEASED-PACK-IND", "DeceasedPackInd");
        public static WinFormsField AddressLine = new WinFormsField("ADDRESS-LINE", "AddressLine");
        public static WinFormsField HnaLine = new WinFormsField("HNA-LINE", "HnaLine");
        public static WinFormsField ThirdPtyPostcode = new WinFormsField("3RD-PTY-POSTCODE", "3rdPtyPostcode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField PoaDonorName1 = new WinFormsField("POA-DONOR-NAME1", "PoaDonorName1");
        public static WinFormsField PoaDonorDelete1 = new WinFormsField("POA-DONOR-DELETE1", "PoaDonorDelete1");
        public static WinFormsField PoaDonorName2 = new WinFormsField("POA-DONOR-NAME2", "PoaDonorName2");
        public static WinFormsField PoaDonorDelete2 = new WinFormsField("POA-DONOR-DELETE2", "PoaDonorDelete2");
        public static WinFormsField PoaDonorName3 = new WinFormsField("POA-DONOR-NAME3", "PoaDonorName3");
        public static WinFormsField PoaDonorDelete3 = new WinFormsField("POA-DONOR-DELETE3", "PoaDonorDelete3");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
