using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSUS03

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSUS03", "FormName");
		//Fields
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField RunNumber = new WinFormsField("RUN-NUMBER", "RunNumber");
        public static WinFormsField TransNumber = new WinFormsField("TRANS-NUMBER", "TransNumber");
        public static WinFormsField HolderNameKey = new WinFormsField("HOLDER-NAME-KEY", "HolderNameKey");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField HolderNameAddress1 = new WinFormsField("HOLDER-NAME-ADDRESS1", "HolderNameAddress1");
        public static WinFormsField HolderNameAddress2 = new WinFormsField("HOLDER-NAME-ADDRESS2", "HolderNameAddress2");
        public static WinFormsField InvestorNbr = new WinFormsField("INVESTOR-NBR", "InvestorNbr");
        public static WinFormsField ControllerNbr = new WinFormsField("CONTROLLER-NBR", "ControllerNbr");
        public static WinFormsField OldAddrLine = new WinFormsField("OLD-ADDR-LINE", "OldAddrLine");
        public static WinFormsField NewAddrLine = new WinFormsField("NEW-ADDR-LINE", "NewAddrLine");
        public static WinFormsField OldPostcode = new WinFormsField("OLD-POSTCODE", "OldPostcode");
        public static WinFormsField NewPostcode = new WinFormsField("NEW-POSTCODE", "NewPostcode");
        public static WinFormsField OldCountry = new WinFormsField("OLD-COUNTRY", "OldCountry");
        public static WinFormsField NewCountry = new WinFormsField("NEW-COUNTRY", "NewCountry");
        public static WinFormsField OldTin = new WinFormsField("OLD-TIN", "OldTin");
        public static WinFormsField NewTin = new WinFormsField("NEW-TIN", "NewTin");
        public static WinFormsField ScreenCount = new WinFormsField("SCREEN-COUNT", "ScreenCount");
        public static WinFormsField ScreenTotal = new WinFormsField("SCREEN-TOTAL", "ScreenTotal");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
