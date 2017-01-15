using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSSOC01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSSOC01", "FormName");
		//Fields


        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField BlkoutRstrctdDesc = new WinFormsField("BLKOUT-RSTRCTD-DESC", "BlkoutRstrctdDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
