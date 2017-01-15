using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class BKS00203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("BKS00203", "FormName");
		//Fields


        public static WinFormsField FormatGroupCode = new WinFormsField("FORMAT-GROUP-CODE", "FormatGroupCode");
        public static WinFormsField ExportArea = new WinFormsField("EXPORT-AREA", "ExportArea");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField SelX = new WinFormsField("SEL-X", "SelX");
        public static WinFormsField PicselX = new WinFormsField("PICSEL-X", "PicselX");
    }
}
