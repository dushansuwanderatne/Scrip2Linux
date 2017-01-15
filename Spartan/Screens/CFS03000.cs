using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS03000
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("CFS03000", "FormName");
        //Fields
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField PreSort = new WinFormsField("PRE-SORT", "PreSort");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField BarcodePreSort = new WinFormsField("BARCODE-PRE-SORT", "BarcodePreSort");
        public static WinFormsField BarcodePresortDesc = new WinFormsField("BARCODE-PRESORT-DESC", "BarcodePresortDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}