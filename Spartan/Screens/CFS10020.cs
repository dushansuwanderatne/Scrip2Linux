using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS10020

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS10020", "FormName");
		//Fields


        public static WinFormsField DriverFile = new WinFormsField("DRIVER-FILE", "DriverFile");
        public static WinFormsField ClientInd = new WinFormsField("CLIENT-IND", "ClientInd");
        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField CoyInd = new WinFormsField("COY-IND", "CoyInd");
        public static WinFormsField Coy1 = new WinFormsField("COY1", "Coy1");
        public static WinFormsField Coy2 = new WinFormsField("COY2", "Coy2");
        public static WinFormsField ExistInd = new WinFormsField("EXIST-IND", "ExistInd");
        public static WinFormsField ExistFile = new WinFormsField("EXIST-FILE", "ExistFile");
        public static WinFormsField CoyTypeInd = new WinFormsField("COY-TYPE-IND", "CoyTypeInd");
        public static WinFormsField CoyType = new WinFormsField("COY-TYPE", "CoyType");
        public static WinFormsField CoyStatusInd = new WinFormsField("COY-STATUS-IND", "CoyStatusInd");
        public static WinFormsField CoyStatus = new WinFormsField("COY-STATUS", "CoyStatus");
        public static WinFormsField CoyNameInd = new WinFormsField("COY-NAME-IND", "CoyNameInd");
        public static WinFormsField CoyName = new WinFormsField("COY-NAME", "CoyName");
        public static WinFormsField OptimizedInd = new WinFormsField("OPTIMIZED-IND", "OptimizedInd");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
    }
}
