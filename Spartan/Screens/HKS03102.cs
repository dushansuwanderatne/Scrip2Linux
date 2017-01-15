using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS03102

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS03102", "FormName");
		//Fields


        public static WinFormsField IncludeExclude = new WinFormsField("INCLUDE-EXCLUDE", "IncludeExclude");
        public static WinFormsField DomCode1 = new WinFormsField("DOM-CODE-1", "DomCode1");
        public static WinFormsField DomCode2 = new WinFormsField("DOM-CODE-2", "DomCode2");
        public static WinFormsField DomCode3 = new WinFormsField("DOM-CODE-3", "DomCode3");
        public static WinFormsField DomCode4 = new WinFormsField("DOM-CODE-4", "DomCode4");
        public static WinFormsField DomCode5 = new WinFormsField("DOM-CODE-5", "DomCode5");
        public static WinFormsField TfnNoticeReqd = new WinFormsField("TFN-NOTICE-REQD", "TfnNoticeReqd");
        public static WinFormsField UrrAutoReduceLevel = new WinFormsField("URR-AUTO-REDUCE-LEVEL", "UrrAutoReduceLevel");
        public static WinFormsField UrrAutoWithdraw = new WinFormsField("URR-AUTO-WITHDRAW", "UrrAutoWithdraw");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
        public static WinFormsField NewElecsNotAlwInd = new WinFormsField("NEW-ELECS-NOT-ALW-IND", "NewElecsNotAlwInd");
        public static WinFormsField NewElecsOvrrideInd = new WinFormsField("NEW-ELECS-OVRRIDE-IND", "NewElecsOvrrideInd");
        public static WinFormsField DecdWithdrawInd = new WinFormsField("DECD-WITHDRAW-IND", "DecdWithdrawInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
