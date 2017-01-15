using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10028
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS10028", "FormName");
        //Fields
        public static WinFormsField MenuItemA = new WinFormsField("MENU-ITEM-A", "A. Alpha", "Alpha");
        public static WinFormsField MenuItemP = new WinFormsField("MENU-ITEM-P", "P. Postcode", "Postcode");
        public static WinFormsField MenuItemD = new WinFormsField("MENU-ITEM-D", "D. Descending", "Descending");
        public static WinFormsField MenuItemS = new WinFormsField("MENU-ITEM-S", "S. Special Pre-Sort Plan", "SpecialPre-SortPlan");
        public static WinFormsField MenuItemH = new WinFormsField("MENU-ITEM-H", "H. Holder Number", "HolderNumber");
        public static WinFormsField MenuItemB = new WinFormsField("MENU-ITEM-B", "B. Special Barcode Pre-Sort Plan", "SpecialBarcodePre-SortPlan");
        public static WinFormsField MenuItemX = new WinFormsField("MENU-ITEM-X", "X. Alpha Within Aust (Overseas at end)", "AlphaWithinAust(Overseasatend)");
        public static WinFormsField ReportHeading = new WinFormsField("REPORT-HEADING", "ReportHeading");
        public static WinFormsField ReportDate = new WinFormsField("REPORT-DATE", "ReportDate");
        public static WinFormsField RunNumberFrom = new WinFormsField("RUN-NUMBER-FROM", "RunNumberFrom");
        public static WinFormsField RunNumberTO = new WinFormsField("RUN-NUMBER-TO", "RunNumberTO");
        public static WinFormsField ASATRun = new WinFormsField("AS-AT-RUN", "ASATRun");
        public static WinFormsField ReportSeq = new WinFormsField("REPORT-SEQ", "ReportSeq");
        public static WinFormsField CutoffPoint = new WinFormsField("CUTOFF-POINT", "CutoffPoint");
        public static WinFormsField ReturnMailATEnd = new WinFormsField("RETURN-MAIL-AT-END", "ReturnMailATEnd");
        public static WinFormsField ProduceEmailList = new WinFormsField("PRODUCE-EMAIL-LIST", "ProduceEmailList");
        public static WinFormsField FurtherSequencing = new WinFormsField("FURTHER-SEQUENCING", "FurtherSequencing");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}