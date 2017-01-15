using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG09001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG09001", "FormName");
		//Fields


        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField GivenName = new WinFormsField("GIVEN-NAME", "GivenName");
        public static WinFormsField Initial = new WinFormsField("INITIAL", "Initial");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField Alias = new WinFormsField("ALIAS", "Alias");
        public static WinFormsField BelongGroup1 = new WinFormsField("BELONG-GROUP1", "BelongGroup1");
        public static WinFormsField BelongGroup2 = new WinFormsField("BELONG-GROUP2", "BelongGroup2");
        public static WinFormsField BelongGroup3 = new WinFormsField("BELONG-GROUP3", "BelongGroup3");
        public static WinFormsField ValidLoginNames1 = new WinFormsField("VALID-LOGIN-NAMES1", "ValidLoginNames1");
        public static WinFormsField ValidLoginNames2 = new WinFormsField("VALID-LOGIN-NAMES2", "ValidLoginNames2");
        public static WinFormsField ValidLoginNames3 = new WinFormsField("VALID-LOGIN-NAMES3", "ValidLoginNames3");
        public static WinFormsField ViewSumryScrnFlag = new WinFormsField("VIEW-SUMRY-SCRN-FLAG", "ViewSumryScrnFlag");
        public static WinFormsField ViewNewMsgsFlag = new WinFormsField("VIEW-NEW-MSGS-FLAG", "ViewNewMsgsFlag");
        public static WinFormsField SystemAdminFlag = new WinFormsField("SYSTEM-ADMIN-FLAG", "SystemAdminFlag");
        public static WinFormsField UsualLogin = new WinFormsField("USUAL-LOGIN", "UsualLogin");
        public static WinFormsField RealNode = new WinFormsField("REAL-NODE", "RealNode");
        public static WinFormsField AdminName = new WinFormsField("ADMIN-NAME", "AdminName");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField AdminPassword = new WinFormsField("ADMIN-PASSWORD", "AdminPassword");
    }
}
