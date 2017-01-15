using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS05500
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS05500", "FormName");
        //Fields
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField Cls = new WinFormsField("CLS", "Cls");
        public static WinFormsField Grp = new WinFormsField("GRP", "Grp");
        public static WinFormsField Match = new WinFormsField("MATCH", "Match");
        public static WinFormsField UseInputFile = new WinFormsField("USE-INPUT-FILE", "UseInputFile");
        public static WinFormsField InputFilename = new WinFormsField("INPUT-FILENAME", "InputFilename");
        public static WinFormsField HT = new WinFormsField("HT", "HT");
        public static WinFormsField Companies = new WinFormsField("COMPANIES", "Companies");
        public static WinFormsField Postcode = new WinFormsField("POSTCODE", "Postcode");
        public static WinFormsField Uncertificated = new WinFormsField("UNCERTIFICATED", "Uncertificated");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}