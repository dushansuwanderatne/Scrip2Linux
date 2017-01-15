using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSCRTFO

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSCRTFO", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField TranType1 = new WinFormsField("TRAN-TYPE-1", "TranType1");
        public static WinFormsField TranTypeFlag1 = new WinFormsField("TRAN-TYPE-FLAG-1", "TranTypeFlag1");
        public static WinFormsField TranType2 = new WinFormsField("TRAN-TYPE-2", "TranType2");
        public static WinFormsField TranTypeFlag2 = new WinFormsField("TRAN-TYPE-FLAG-2", "TranTypeFlag2");
        public static WinFormsField TranType3 = new WinFormsField("TRAN-TYPE-3", "TranType3");
        public static WinFormsField TranTypeFlag3 = new WinFormsField("TRAN-TYPE-FLAG-3", "TranTypeFlag3");
    }
}
