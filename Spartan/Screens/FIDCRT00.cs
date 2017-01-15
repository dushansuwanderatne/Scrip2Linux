using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FIDCRT00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FIDCRT00", "FormName");
		//Fields


        public static WinFormsField FidcrtRec = new WinFormsField("FIDCRT-REC", "FidcrtRec");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}