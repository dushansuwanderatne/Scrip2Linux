using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01103

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01103", "FormName");
		//Fields


        public static WinFormsField ClassCode = new WinFormsField("CLASS-CODE", "ClassCode");
        public static WinFormsField ClassDesc = new WinFormsField("CLASS-DESC", "ClassDesc");
        public static WinFormsField ScripIssueOption = new WinFormsField("SCRIP-ISSUE-OPTION", "ScripIssueOption");
        public static WinFormsField ClassScripFormat = new WinFormsField("CLASS-SCRIP-FORMAT", "ClassScripFormat");
        public static WinFormsField SysScripFormat = new WinFormsField("SYS-SCRIP-FORMAT", "SysScripFormat");
        public static WinFormsField ScripFormatLst2 = new WinFormsField("SCRIP-FORMAT-LST2", "ScripFormatLst2");
        public static WinFormsField ScripFormatLst3 = new WinFormsField("SCRIP-FORMAT-LST3", "ScripFormatLst3");
        public static WinFormsField CommentStructure = new WinFormsField("COMMENT-STRUCTURE", "CommentStructure");
        public static WinFormsField RestrictionsInd = new WinFormsField("RESTRICTIONS-IND", "RestrictionsInd");
        public static WinFormsField CommentLinesYN = new WinFormsField("COMMENT-LINES-YN", "CommentLinesYN");
        public static WinFormsField ForeignGroup = new WinFormsField("FOREIGN-GROUP", "ForeignGroup");
        public static WinFormsField AutoPrintScrip = new WinFormsField("AUTO-PRINT-SCRIP", "AutoPrintScrip");
        public static WinFormsField ForeignTotal = new WinFormsField("FOREIGN-TOTAL", "ForeignTotal");
        public static WinFormsField LostScripRequired = new WinFormsField("LOST-SCRIP-REQUIRED", "LostScripRequired");
        public static WinFormsField ForeignAssocClass = new WinFormsField("FOREIGN-ASSOC-CLASS", "ForeignAssocClass");
        public static WinFormsField IssueDateTOPrint = new WinFormsField("ISSUE-DATE-TO-PRINT", "IssueDateTOPrint");
        public static WinFormsField ForeignFasterClass = new WinFormsField("FOREIGN-FASTER-CLASS", "ForeignFasterClass");
        public static WinFormsField LostScripComment = new WinFormsField("LOST-SCRIP-COMMENT", "LostScripComment");
        public static WinFormsField ClassTradeMin = new WinFormsField("CLASS-TRADE-MIN", "ClassTradeMin");
        public static WinFormsField ClassTradeMax = new WinFormsField("CLASS-TRADE-MAX", "ClassTradeMax");
        public static WinFormsField ClassTradeMult = new WinFormsField("CLASS-TRADE-MULT", "ClassTradeMult");
        public static WinFormsField MarketableParcel = new WinFormsField("MARKETABLE-PARCEL", "MarketableParcel");
        public static WinFormsField SmvlstLevel = new WinFormsField("SMVLST-LEVEL", "SmvlstLevel");
        public static WinFormsField SpecialNotifInd = new WinFormsField("SPECIAL-NOTIF-IND", "SpecialNotifInd");
        public static WinFormsField FltBrkrClassInd = new WinFormsField("FLT-BRKR-CLASS-IND", "FltBrkrClassInd");
        public static WinFormsField ValidTop1000Ind = new WinFormsField("VALID-TOP1000-IND", "ValidTop1000Ind");
        public static WinFormsField InvalidRegCode = new WinFormsField("INVALID-REG-CODE", "InvalidRegCode");
        public static WinFormsField ClassTrade = new WinFormsField("CLASS-TRADE", "ClassTrade");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
