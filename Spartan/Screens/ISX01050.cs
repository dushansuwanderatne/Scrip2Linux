using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ISX01050

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ISX01050", "FormName");
		//Fields


        public static WinFormsField SpecProgReq = new WinFormsField("SPEC-PROG-REQ", "SpecProgReq");
        public static WinFormsField OutputProgName = new WinFormsField("OUTPUT-PROG-NAME", "OutputProgName");
        public static WinFormsField Layout = new WinFormsField("LAYOUT", "Layout");
        public static WinFormsField Format = new WinFormsField("FORMAT", "Format");
        public static WinFormsField LabelComments = new WinFormsField("LABEL-COMMENTS", "LabelComments");
        public static WinFormsField LayoutSeq = new WinFormsField("LAYOUT-SEQ", "LayoutSeq");
        public static WinFormsField RegDescOutput = new WinFormsField("REG-DESC-OUTPUT", "RegDescOutput");
        public static WinFormsField EntNumTOPrint = new WinFormsField("ENT-NUM-TO-PRINT", "EntNumTOPrint");
        public static WinFormsField CodingDetails = new WinFormsField("CODING-DETAILS", "CodingDetails");
        public static WinFormsField FastComments = new WinFormsField("FAST-COMMENTS", "FastComments");
        public static WinFormsField Continue = new WinFormsField("CONTINUE", "Continue");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
