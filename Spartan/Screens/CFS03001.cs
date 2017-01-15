using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03001
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("CFS03001", "FormName");
        //Fields
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField PreSort = new WinFormsField("PRE-SORT", "PreSort");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField BarcodePreSort = new WinFormsField("BARCODE-PRE-SORT", "BarcodePreSort");
        public static WinFormsField BarcodeDescription = new WinFormsField("BARCODE-DESCRIPTION", "BarcodeDescription");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
