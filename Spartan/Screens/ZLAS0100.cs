using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ZLAS0100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ZLAS0100", "FormName");
		//Fields


        public static WinFormsField AsxCode = new WinFormsField("ASX-CODE", "AsxCode");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField OrderNumber = new WinFormsField("ORDER-NUMBER", "OrderNumber");
        public static WinFormsField DateFrom = new WinFormsField("DATE-FROM", "DateFrom");
        public static WinFormsField DateTO = new WinFormsField("DATE-TO", "DateTO");
        public static WinFormsField LowPrice = new WinFormsField("LOW-PRICE", "LowPrice");
        public static WinFormsField HighPrice = new WinFormsField("HIGH-PRICE", "HighPrice");
        public static WinFormsField HighVolume = new WinFormsField("HIGH-VOLUME", "HighVolume");
        public static WinFormsField Colour = new WinFormsField("COLOUR", "Colour");
        public static WinFormsField Copies = new WinFormsField("COPIES", "Copies");
        public static WinFormsField CshareTOPrint = new WinFormsField("CSHARE-TO-PRINT", "CshareTOPrint");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
