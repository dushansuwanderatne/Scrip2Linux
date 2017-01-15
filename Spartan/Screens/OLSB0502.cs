using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSB0502

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSB0502", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField AddressLines = new WinFormsField("ADDRESS-LINES", "AddressLines");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField AgentName = new WinFormsField("AGENT-NAME", "AgentName");
        public static WinFormsField RegisterCode = new WinFormsField("REGISTER-CODE", "RegisterCode");
        public static WinFormsField RegisterDesc = new WinFormsField("REGISTER-DESC", "RegisterDesc");
        public static WinFormsField CertsCreate = new WinFormsField("CERTS-CREATE", "CertsCreate");
        public static WinFormsField RequiredUnits = new WinFormsField("REQUIRED-UNITS", "RequiredUnits");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
