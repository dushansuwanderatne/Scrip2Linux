using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSSTM06

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSSTM06", "FormName");
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
        public static WinFormsField OldExtraID = new WinFormsField("OLD-EXTRA-ID", "OldExtraID");
        public static WinFormsField NewExtraID = new WinFormsField("NEW-EXTRA-ID", "NewExtraID");
        public static WinFormsField OldHomePH = new WinFormsField("OLD-HOME-PH", "OldHomePH");
        public static WinFormsField NewHomePH = new WinFormsField("NEW-HOME-PH", "NewHomePH");
        public static WinFormsField OldWorkPH = new WinFormsField("OLD-WORK-PH", "OldWorkPH");
        public static WinFormsField NewWorkPH = new WinFormsField("NEW-WORK-PH", "NewWorkPH");
        public static WinFormsField OldEWFlag = new WinFormsField("OLD-EW-FLAG", "OldEWFlag");
        public static WinFormsField NewEWFlag = new WinFormsField("NEW-EW-FLAG", "NewEWFlag");
        public static WinFormsField OldCommMethod = new WinFormsField("OLD-COMM-METHOD", "OldCommMethod");
        public static WinFormsField NewCommMethod = new WinFormsField("NEW-COMM-METHOD", "NewCommMethod");
        public static WinFormsField OldFaxNbr = new WinFormsField("OLD-FAX-NBR", "OldFaxNbr");
        public static WinFormsField NewFaxNbr = new WinFormsField("NEW-FAX-NBR", "NewFaxNbr");
        public static WinFormsField OldMobileNbr = new WinFormsField("OLD-MOBILE-NBR", "OldMobileNbr");
        public static WinFormsField NewMobileNbr = new WinFormsField("NEW-MOBILE-NBR", "NewMobileNbr");
        public static WinFormsField OldAbn = new WinFormsField("OLD-ABN", "OldAbn");
        public static WinFormsField OldAbnS = new WinFormsField("OLD-ABN-S", "OldAbnS");
        public static WinFormsField NewAbn = new WinFormsField("NEW-ABN", "NewAbn");
        public static WinFormsField NewAbnS = new WinFormsField("NEW-ABN-S", "NewAbnS");
        public static WinFormsField OldEmail1 = new WinFormsField("OLD-EMAIL-1", "OldEmail1");
        public static WinFormsField OldEmail2 = new WinFormsField("OLD-EMAIL-2", "OldEmail2");
        public static WinFormsField NewEmail1 = new WinFormsField("NEW-EMAIL-1", "NewEmail1");
        public static WinFormsField NewEmail2 = new WinFormsField("NEW-EMAIL-2", "NewEmail2");
        public static WinFormsField OldReturnDate = new WinFormsField("OLD-RETURN-DATE", "OldReturnDate");
        public static WinFormsField NewReturnDate = new WinFormsField("NEW-RETURN-DATE", "NewReturnDate");
        public static WinFormsField OldEmailFailCount = new WinFormsField("OLD-EMAIL-FAIL-COUNT", "OldEmailFailCount");
        public static WinFormsField NewEmailFailCount = new WinFormsField("NEW-EMAIL-FAIL-COUNT", "NewEmailFailCount");
        public static WinFormsField OldAmlStatus = new WinFormsField("OLD-AML-STATUS", "OldAmlStatus");
        public static WinFormsField OldAmlDate = new WinFormsField("OLD-AML-DATE", "OldAmlDate");
        public static WinFormsField NewAmlStatus = new WinFormsField("NEW-AML-STATUS", "NewAmlStatus");
        public static WinFormsField NewAmlDate = new WinFormsField("NEW-AML-DATE", "NewAmlDate");
        public static WinFormsField NewAmlTime = new WinFormsField("NEW-AML-TIME", "NewAmlTime");
        public static WinFormsField OldAmlTime = new WinFormsField("OLD-AML-TIME", "OldAmlTime");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField RestrictClassInfo = new WinFormsField("RESTRICT-CLASS-INFO", "RestrictClassInfo");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
