using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;


namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PXS00211
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("PXS00211", "FormName");
        //Fields
        public static WinFormsField MeetingNumber = new WinFormsField("MEETING-NUMBER", "MeetingNumber");
        public static WinFormsField ProxyDescription = new WinFormsField("PROXY-DESCRIPTION", "ProxyDescription");
        public static WinFormsField MeetingDate = new WinFormsField("MEETING-DATE", "MeetingDate");
        public static WinFormsField PageNum = new WinFormsField("PAGE-NUM", "PageNum");
        public static WinFormsField ResolutionNum = new WinFormsField("RESOLUTION-NUM", "ResolutionNum");
        public static WinFormsField BriefDesc = new WinFormsField("BRIEF-DESC", "BriefDesc");
        public static WinFormsField LongDesc = new WinFormsField("LONG-DESC", "LongDesc");
        public static WinFormsField VotingFrmDesc = new WinFormsField("VOTING-FRM-DESC", "VotingFrmDesc");
        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassGroup = new WinFormsField("CLASS-GROUP", "ClassGroup");
        public static WinFormsField ExcClass = new WinFormsField("EXC-CLASS", "ExcClass");
        public static WinFormsField OtherReqdInd = new WinFormsField("OTHER-REQD-IND", "OtherReqdInd");
        public static WinFormsField ClassCodeB = new WinFormsField("CLASS-CODE-B", "ClassCodeB");
        public static WinFormsField ExcClassB = new WinFormsField("EXC-CLASS-B", "ExcClassB");
        public static WinFormsField Rounding = new WinFormsField("ROUNDING", "Rounding");
        public static WinFormsField ExcClassCodesInd = new WinFormsField("EXC-CLASS-CODES-IND", "ExcClassCodesInd");
        public static WinFormsField ExcClassCode = new WinFormsField("EXC-CLASS-CODE", "ExcClassCode");
        public static WinFormsField RemResTickBox = new WinFormsField("REM-RES-TICK-BOX", "RemResTickBox");
        public static WinFormsField NomOveRes = new WinFormsField("NOM-OVE-RES", "NomOveRes");
        public static WinFormsField UnitsIssuedOS = new WinFormsField("UNITS-ISSUED-OS", "UnitsIssuedOS");
        public static WinFormsField UnitsUpdMethod = new WinFormsField("UNITS-UPD-METHOD", "UnitsUpdMethod");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoDate2 = new WinFormsField("SYSTEM-INFO-DATE-2", "6", "6");
        public static WinFormsField SystemInfoTime1 = new WinFormsField("SYSTEM-INFO-TIME-1", "1", "1");
        public static WinFormsField SystemInfoTermNbr = new WinFormsField("SYSTEM-INFO-TERM-NBR", "13", "13");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
    }
}
