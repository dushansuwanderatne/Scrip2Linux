using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BSS02801

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BSS02801", "FormName");
		//Fields


        public static WinFormsField SystemInfoUser2 = new WinFormsField("SYSTEM-INFO-USER-2", "12", "12");
        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField HeaderDesc = new WinFormsField("HEADER-DESC", "HeaderDesc");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientDesc = new WinFormsField("CLIENT-DESC", "ClientDesc");
        public static WinFormsField Pa1Action = new WinFormsField("PA1-ACTION", "Pa1Action");
        public static WinFormsField Pa1Company = new WinFormsField("PA1-COMPANY", "Pa1Company");
        public static WinFormsField Pa11part = new WinFormsField("PA1-1PART", "Pa11part");
        public static WinFormsField Pa12part = new WinFormsField("PA1-2PART", "Pa12part");
        public static WinFormsField Pa13part = new WinFormsField("PA1-3PART", "Pa13part");
        public static WinFormsField Pa1Fstat = new WinFormsField("PA1-FSTAT", "Pa1Fstat");
        public static WinFormsField Pa1Sticky = new WinFormsField("PA1-STICKY", "Pa1Sticky");
        public static WinFormsField Pa1Plain = new WinFormsField("PA1-PLAIN", "Pa1Plain");
        public static WinFormsField Pa1GstExempt = new WinFormsField("PA1-GST-EXEMPT", "Pa1GstExempt");
        public static WinFormsField Pa2Action = new WinFormsField("PA2-ACTION", "Pa2Action");
        public static WinFormsField Pa2Company = new WinFormsField("PA2-COMPANY", "Pa2Company");
        public static WinFormsField Pa21part = new WinFormsField("PA2-1PART", "Pa21part");
        public static WinFormsField Pa22part = new WinFormsField("PA2-2PART", "Pa22part");
        public static WinFormsField Pa23part = new WinFormsField("PA2-3PART", "Pa23part");
        public static WinFormsField Pa2Fstat = new WinFormsField("PA2-FSTAT", "Pa2Fstat");
        public static WinFormsField Pa2Sticky = new WinFormsField("PA2-STICKY", "Pa2Sticky");
        public static WinFormsField Pa2Plain = new WinFormsField("PA2-PLAIN", "Pa2Plain");
        public static WinFormsField Pa2GstExempt = new WinFormsField("PA2-GST-EXEMPT", "Pa2GstExempt");
        public static WinFormsField Pa3Action = new WinFormsField("PA3-ACTION", "Pa3Action");
        public static WinFormsField Pa3Company = new WinFormsField("PA3-COMPANY", "Pa3Company");
        public static WinFormsField Pa31part = new WinFormsField("PA3-1PART", "Pa31part");
        public static WinFormsField Pa32part = new WinFormsField("PA3-2PART", "Pa32part");
        public static WinFormsField Pa33part = new WinFormsField("PA3-3PART", "Pa33part");
        public static WinFormsField Pa3Fstat = new WinFormsField("PA3-FSTAT", "Pa3Fstat");
        public static WinFormsField Pa3Sticky = new WinFormsField("PA3-STICKY", "Pa3Sticky");
        public static WinFormsField Pa3Plain = new WinFormsField("PA3-PLAIN", "Pa3Plain");
        public static WinFormsField Pa3GstExempt = new WinFormsField("PA3-GST-EXEMPT", "Pa3GstExempt");
        public static WinFormsField Pa4Action = new WinFormsField("PA4-ACTION", "Pa4Action");
        public static WinFormsField Pa4Company = new WinFormsField("PA4-COMPANY", "Pa4Company");
        public static WinFormsField Pa41part = new WinFormsField("PA4-1PART", "Pa41part");
        public static WinFormsField Pa42part = new WinFormsField("PA4-2PART", "Pa42part");
        public static WinFormsField Pa43part = new WinFormsField("PA4-3PART", "Pa43part");
        public static WinFormsField Pa4Fstat = new WinFormsField("PA4-FSTAT", "Pa4Fstat");
        public static WinFormsField Pa4Sticky = new WinFormsField("PA4-STICKY", "Pa4Sticky");
        public static WinFormsField Pa4Plain = new WinFormsField("PA4-PLAIN", "Pa4Plain");
        public static WinFormsField Pa4GstExempt = new WinFormsField("PA4-GST-EXEMPT", "Pa4GstExempt");
        public static WinFormsField Pa5Action = new WinFormsField("PA5-ACTION", "Pa5Action");
        public static WinFormsField Pa5Company = new WinFormsField("PA5-COMPANY", "Pa5Company");
        public static WinFormsField Pa51part = new WinFormsField("PA5-1PART", "Pa51part");
        public static WinFormsField Pa52part = new WinFormsField("PA5-2PART", "Pa52part");
        public static WinFormsField Pa53part = new WinFormsField("PA5-3PART", "Pa53part");
        public static WinFormsField Pa5Fstat = new WinFormsField("PA5-FSTAT", "Pa5Fstat");
        public static WinFormsField Pa5Sticky = new WinFormsField("PA5-STICKY", "Pa5Sticky");
        public static WinFormsField Pa5Plain = new WinFormsField("PA5-PLAIN", "Pa5Plain");
        public static WinFormsField Pa5GstExempt = new WinFormsField("PA5-GST-EXEMPT", "Pa5GstExempt");
        public static WinFormsField Pa6Action = new WinFormsField("PA6-ACTION", "Pa6Action");
        public static WinFormsField Pa6Company = new WinFormsField("PA6-COMPANY", "Pa6Company");
        public static WinFormsField Pa61part = new WinFormsField("PA6-1PART", "Pa61part");
        public static WinFormsField Pa62part = new WinFormsField("PA6-2PART", "Pa62part");
        public static WinFormsField Pa63part = new WinFormsField("PA6-3PART", "Pa63part");
        public static WinFormsField Pa6Fstat = new WinFormsField("PA6-FSTAT", "Pa6Fstat");
        public static WinFormsField Pa6Sticky = new WinFormsField("PA6-STICKY", "Pa6Sticky");
        public static WinFormsField Pa6Plain = new WinFormsField("PA6-PLAIN", "Pa6Plain");
        public static WinFormsField Pa6GstExempt = new WinFormsField("PA6-GST-EXEMPT", "Pa6GstExempt");
        public static WinFormsField Pa7Action = new WinFormsField("PA7-ACTION", "Pa7Action");
        public static WinFormsField Pa7Company = new WinFormsField("PA7-COMPANY", "Pa7Company");
        public static WinFormsField Pa71part = new WinFormsField("PA7-1PART", "Pa71part");
        public static WinFormsField Pa72part = new WinFormsField("PA7-2PART", "Pa72part");
        public static WinFormsField Pa73part = new WinFormsField("PA7-3PART", "Pa73part");
        public static WinFormsField Pa7Fstat = new WinFormsField("PA7-FSTAT", "Pa7Fstat");
        public static WinFormsField Pa7Sticky = new WinFormsField("PA7-STICKY", "Pa7Sticky");
        public static WinFormsField Pa7Plain = new WinFormsField("PA7-PLAIN", "Pa7Plain");
        public static WinFormsField Pa7GstExempt = new WinFormsField("PA7-GST-EXEMPT", "Pa7GstExempt");
        public static WinFormsField Pa8Action = new WinFormsField("PA8-ACTION", "Pa8Action");
        public static WinFormsField Pa8Company = new WinFormsField("PA8-COMPANY", "Pa8Company");
        public static WinFormsField Pa81part = new WinFormsField("PA8-1PART", "Pa81part");
        public static WinFormsField Pa82part = new WinFormsField("PA8-2PART", "Pa82part");
        public static WinFormsField Pa83part = new WinFormsField("PA8-3PART", "Pa83part");
        public static WinFormsField Pa8Fstat = new WinFormsField("PA8-FSTAT", "Pa8Fstat");
        public static WinFormsField Pa8Sticky = new WinFormsField("PA8-STICKY", "Pa8Sticky");
        public static WinFormsField Pa8Plain = new WinFormsField("PA8-PLAIN", "Pa8Plain");
        public static WinFormsField Pa8GstExempt = new WinFormsField("PA8-GST-EXEMPT", "Pa8GstExempt");
        public static WinFormsField Pa9Action = new WinFormsField("PA9-ACTION", "Pa9Action");
        public static WinFormsField Pa9Company = new WinFormsField("PA9-COMPANY", "Pa9Company");
        public static WinFormsField Pa91part = new WinFormsField("PA9-1PART", "Pa91part");
        public static WinFormsField Pa92part = new WinFormsField("PA9-2PART", "Pa92part");
        public static WinFormsField Pa93part = new WinFormsField("PA9-3PART", "Pa93part");
        public static WinFormsField Pa9Fstat = new WinFormsField("PA9-FSTAT", "Pa9Fstat");
        public static WinFormsField Pa9Sticky = new WinFormsField("PA9-STICKY", "Pa9Sticky");
        public static WinFormsField Pa9Plain = new WinFormsField("PA9-PLAIN", "Pa9Plain");
        public static WinFormsField Pa9GstExempt = new WinFormsField("PA9-GST-EXEMPT", "Pa9GstExempt");
        public static WinFormsField Pa10Action = new WinFormsField("PA10-ACTION", "Pa10Action");
        public static WinFormsField Pa10Company = new WinFormsField("PA10-COMPANY", "Pa10Company");
        public static WinFormsField Pa101part = new WinFormsField("PA10-1PART", "Pa101part");
        public static WinFormsField Pa102part = new WinFormsField("PA10-2PART", "Pa102part");
        public static WinFormsField Pa103part = new WinFormsField("PA10-3PART", "Pa103part");
        public static WinFormsField Pa10Fstat = new WinFormsField("PA10-FSTAT", "Pa10Fstat");
        public static WinFormsField Pa10Sticky = new WinFormsField("PA10-STICKY", "Pa10Sticky");
        public static WinFormsField Pa10Plain = new WinFormsField("PA10-PLAIN", "Pa10Plain");
        public static WinFormsField Pa10GstExempt = new WinFormsField("PA10-GST-EXEMPT", "Pa10GstExempt");
        public static WinFormsField Pa11Action = new WinFormsField("PA11-ACTION", "Pa11Action");
        public static WinFormsField Pa11Company = new WinFormsField("PA11-COMPANY", "Pa11Company");
        public static WinFormsField Pa111part = new WinFormsField("PA11-1PART", "Pa111part");
        public static WinFormsField Pa112part = new WinFormsField("PA11-2PART", "Pa112part");
        public static WinFormsField Pa113part = new WinFormsField("PA11-3PART", "Pa113part");
        public static WinFormsField Pa11Fstat = new WinFormsField("PA11-FSTAT", "Pa11Fstat");
        public static WinFormsField Pa11Sticky = new WinFormsField("PA11-STICKY", "Pa11Sticky");
        public static WinFormsField Pa11Plain = new WinFormsField("PA11-PLAIN", "Pa11Plain");
        public static WinFormsField Pa11GstExempt = new WinFormsField("PA11-GST-EXEMPT", "Pa11GstExempt");
        public static WinFormsField Pa12Action = new WinFormsField("PA12-ACTION", "Pa12Action");
        public static WinFormsField Pa12Company = new WinFormsField("PA12-COMPANY", "Pa12Company");
        public static WinFormsField Pa121part = new WinFormsField("PA12-1PART", "Pa121part");
        public static WinFormsField Pa122part = new WinFormsField("PA12-2PART", "Pa122part");
        public static WinFormsField Pa123part = new WinFormsField("PA12-3PART", "Pa123part");
        public static WinFormsField Pa12Fstat = new WinFormsField("PA12-FSTAT", "Pa12Fstat");
        public static WinFormsField Pa12Sticky = new WinFormsField("PA12-STICKY", "Pa12Sticky");
        public static WinFormsField Pa12Plain = new WinFormsField("PA12-PLAIN", "Pa12Plain");
        public static WinFormsField Pa12GstExempt = new WinFormsField("PA12-GST-EXEMPT", "Pa12GstExempt");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchCompany = new WinFormsField("SEARCH-COMPANY", "SearchCompany");
    }
}
