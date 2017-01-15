using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class JOBSUB05

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("JOBSUB05", "FormName");
		//Fields
        public static WinFormsField MenuItemH = new WinFormsField("MENU-ITEM-H", "H. AUTO PRINT, Here on your printer", "AUTOPRINT,Hereonyourprinter");
        public static WinFormsField MenuItemN = new WinFormsField("MENU-ITEM-N", "N. NO AUTO PRINT, Print manually", "NOAUTOPRINT,Printmanually");
        public static WinFormsField MenuItemB = new WinFormsField("MENU-ITEM-B", "B. Print at Bureau", "PrintatBureau");
        public static WinFormsField MenuItemM = new WinFormsField("MENU-ITEM-M", "M. Print at Mailing House", "PrintatMailingHouse");
        public static WinFormsField AutoSpool = new WinFormsField("AUTO-SPOOL", "AutoSpool");
        public static WinFormsField Microfiche = new WinFormsField("MICROFICHE", "Microfiche");
        public static WinFormsField ProduceTape = new WinFormsField("PRODUCE-TAPE", "ProduceTape");
        public static WinFormsField TapeFormat = new WinFormsField("TAPE-FORMAT", "TapeFormat");
        public static WinFormsField ExportTOXmlrptInd = new WinFormsField("EXPORT-TO-XMLRPT-IND", "ExportTOXmlrptInd");
        public static WinFormsField DssAutoInsertInd = new WinFormsField("DSS-AUTO-INSERT-IND", "DssAutoInsertInd");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
    }
}
