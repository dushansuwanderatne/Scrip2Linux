using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSSCH02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSSCH02", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField VsaTransferAllowedInd = new WinFormsField("VSA-TRANSFER-ALLOWED-IND", "VsaTransferAllowedInd");
        public static WinFormsField VsaJurisCodes = new WinFormsField("VSA-JURIS-CODES", "VsaJurisCodes");
        public static WinFormsField VsaXfrJurisCode = new WinFormsField("VSA-XFR-JURIS-CODE", "VsaXfrJurisCode");
        public static WinFormsField VsaClassCodes = new WinFormsField("VSA-CLASS-CODES", "VsaClassCodes");
    }
}
