using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ESSBOS00

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ESSBOS00", "FormName");
		//Fields


        public static WinFormsField BlkoutCode = new WinFormsField("BLKOUT-CODE", "BlkoutCode");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField BlkoutStartDate = new WinFormsField("BLKOUT-START-DATE", "BlkoutStartDate");
        public static WinFormsField BlkoutEndDate = new WinFormsField("BLKOUT-END-DATE", "BlkoutEndDate");
    }
}
