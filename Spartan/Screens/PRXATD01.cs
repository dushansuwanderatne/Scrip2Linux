using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PRXATD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PRXATD01", "FormName");
		//Fields


        public static WinFormsField PrxatdKey0 = new WinFormsField("PRXATD-KEY0", "PrxatdKey0");
        public static WinFormsField NomPersonCode = new WinFormsField("NOM-PERSON-CODE", "NomPersonCode");
        public static WinFormsField HolderIdentifier = new WinFormsField("HOLDER-IDENTIFIER", "HolderIdentifier");
        public static WinFormsField AtdType = new WinFormsField("ATD-TYPE", "AtdType");
        public static WinFormsField AtdNamkey = new WinFormsField("ATD-NAMKEY", "AtdNamkey");
        public static WinFormsField AtdNumber = new WinFormsField("ATD-NUMBER", "AtdNumber");
        public static WinFormsField GroupCode = new WinFormsField("GROUP-CODE", "GroupCode");
        public static WinFormsField AttendeeName = new WinFormsField("ATTENDEE-NAME", "AttendeeName");
        public static WinFormsField PresentYN = new WinFormsField("PRESENT-YN", "PresentYN");
        public static WinFormsField HolderTypeCode = new WinFormsField("HOLDER-TYPE-CODE", "HolderTypeCode");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField VersionNbr = new WinFormsField("VERSION-NBR", "VersionNbr");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
