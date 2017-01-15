using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB90
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("JOBSUB90", "FormName");
        //Fields
        public static WinFormsField PrintID = new WinFormsField("PRINT-ID", "PrintID");
        public static WinFormsField DestPrinter = new WinFormsField("DEST-PRINTER", "DestPrinter");
        public static WinFormsField FormType = new WinFormsField("FORM-TYPE", "FormType");
        public static WinFormsField NumberCopies = new WinFormsField("NUMBER-COPIES", "NumberCopies");
        public static WinFormsField Microfiche = new WinFormsField("MICROFICHE", "Microfiche");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField TapeName = new WinFormsField("TAPE-NAME", "TapeName");
        public static WinFormsField Desc = new WinFormsField("DESC", "Desc");
        public static WinFormsField JobNO = new WinFormsField("JOB-NO", "JobNO");
        public static WinFormsField JobNODec = new WinFormsField("JOB-NO-DEC", "JobNODec");
        public static WinFormsField ParameterID = new WinFormsField("PARAMETER-ID", "ParameterID");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
        public static WinFormsField Accept = new WinFormsField("ACCEPT", "Accept");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
