using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK01026

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK01026", "FormName");
		//Fields
        public static WinFormsField BlkoutRstrctdCode = new WinFormsField("BLKOUT-RSTRCTD-CODE", "BlkoutRstrctdCode");
        public static WinFormsField BlkoutRstrctdDesc = new WinFormsField("BLKOUT-RSTRCTD-DESC", "BlkoutRstrctdDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Action2nd = new WinFormsField("ACTION-2ND", "Action2nd");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
