using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0503", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField BulkID = new WinFormsField("BULK-ID", "BulkID");
        public static WinFormsField SessionUnits = new WinFormsField("SESSION-UNITS", "SessionUnits");
        public static WinFormsField SessionCount = new WinFormsField("SESSION-COUNT", "SessionCount");
        public static WinFormsField BulkTotal = new WinFormsField("BULK-TOTAL", "BulkTotal");
        public static WinFormsField BulkDesc = new WinFormsField("BULK-DESC", "BulkDesc");
        public static WinFormsField RequiredUnits = new WinFormsField("REQUIRED-UNITS", "RequiredUnits");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField TranDesc = new WinFormsField("TRAN-DESC", "TranDesc");
        public static WinFormsField TranTypeParent = new WinFormsField("TRAN-TYPE-PARENT", "TranTypeParent");
        public static WinFormsField CertID1 = new WinFormsField("CERT-ID-1", "CertID1");
        public static WinFormsField CertID2 = new WinFormsField("CERT-ID-2", "CertID2");
        public static WinFormsField CertID3 = new WinFormsField("CERT-ID-3", "CertID3");
        public static WinFormsField CertID4 = new WinFormsField("CERT-ID-4", "CertID4");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
