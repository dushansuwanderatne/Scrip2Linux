using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLS08503

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLS08503", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField TranType = new WinFormsField("TRAN-TYPE", "TranType");
        public static WinFormsField TranTypeDesc = new WinFormsField("TRAN-TYPE-DESC", "TranTypeDesc");
        public static WinFormsField SubMessageType = new WinFormsField("SUB-MESSAGE-TYPE", "SubMessageType");
        public static WinFormsField TransID = new WinFormsField("TRANS-ID", "TransID");
        public static WinFormsField DeliveringHin = new WinFormsField("DELIVERING-HIN", "DeliveringHin");
        public static WinFormsField SecurityCode = new WinFormsField("SECURITY-CODE", "SecurityCode");
        public static WinFormsField UnitQuantity = new WinFormsField("UNIT-QUANTITY", "UnitQuantity");
        public static WinFormsField MovementReason = new WinFormsField("MOVEMENT-REASON", "MovementReason");
        public static WinFormsField Register = new WinFormsField("REGISTER", "Register");
        public static WinFormsField PartReference = new WinFormsField("PART-REFERENCE", "PartReference");
        public static WinFormsField SuppReference = new WinFormsField("SUPP-REFERENCE", "SuppReference");
        public static WinFormsField OverrideBasis = new WinFormsField("OVERRIDE-BASIS", "OverrideBasis");
        public static WinFormsField ShareholderReference = new WinFormsField("SHAREHOLDER-REFERENCE", "ShareholderReference");
        public static WinFormsField GuaranteedForeign = new WinFormsField("GUARANTEED-FOREIGN", "GuaranteedForeign");
    }
}
