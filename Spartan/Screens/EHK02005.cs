using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EHK02005

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EHK02005", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField InvProcess = new WinFormsField("INV-PROCESS", "InvProcess");
        public static WinFormsField InvDescription = new WinFormsField("INV-DESCRIPTION", "InvDescription");
        public static WinFormsField RTEmpRetainFlag = new WinFormsField("RT-EMP-RETAIN-FLAG", "RTEmpRetainFlag");
        public static WinFormsField VTEmpRetainFlag = new WinFormsField("VT-EMP-RETAIN-FLAG", "VTEmpRetainFlag");
        public static WinFormsField ITEmpRetainFlag = new WinFormsField("IT-EMP-RETAIN-FLAG", "ITEmpRetainFlag");
        public static WinFormsField RTVestRetainFlag = new WinFormsField("RT-VEST-RETAIN-FLAG", "RTVestRetainFlag");
        public static WinFormsField VTVestRetainFlag = new WinFormsField("VT-VEST-RETAIN-FLAG", "VTVestRetainFlag");
        public static WinFormsField ITVestRetainFlag = new WinFormsField("IT-VEST-RETAIN-FLAG", "ITVestRetainFlag");
        public static WinFormsField RTUnvestRetainFlag = new WinFormsField("RT-UNVEST-RETAIN-FLAG", "RTUnvestRetainFlag");
        public static WinFormsField VTUnvestRetainFlag = new WinFormsField("VT-UNVEST-RETAIN-FLAG", "VTUnvestRetainFlag");
        public static WinFormsField ITUnvestRetainFlag = new WinFormsField("IT-UNVEST-RETAIN-FLAG", "ITUnvestRetainFlag");
        public static WinFormsField WdlEmpRetainFlag = new WinFormsField("WDL-EMP-RETAIN-FLAG", "WdlEmpRetainFlag");
        public static WinFormsField WdlVestRetainFlag = new WinFormsField("WDL-VEST-RETAIN-FLAG", "WdlVestRetainFlag");
        public static WinFormsField WdlUnvestRetainFlg = new WinFormsField("WDL-UNVEST-RETAIN-FLG", "WdlUnvestRetainFlg");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
