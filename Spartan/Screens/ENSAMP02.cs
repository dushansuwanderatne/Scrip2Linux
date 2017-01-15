using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSAMP02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSAMP02", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField HolderID1 = new WinFormsField("HOLDER-ID-1", "HolderID1");
        public static WinFormsField HolderID2 = new WinFormsField("HOLDER-ID-2", "HolderID2");
        public static WinFormsField MemberNO1 = new WinFormsField("MEMBER-NO-1", "MemberNO1");
        public static WinFormsField MemberNO2 = new WinFormsField("MEMBER-NO-2", "MemberNO2");
        public static WinFormsField EntNO1 = new WinFormsField("ENT-NO-1", "EntNO1");
        public static WinFormsField EntNO2 = new WinFormsField("ENT-NO-2", "EntNO2");
        public static WinFormsField Name1 = new WinFormsField("NAME-1", "Name1");
        public static WinFormsField Name2 = new WinFormsField("NAME-2", "Name2");
        public static WinFormsField SearchMethod = new WinFormsField("SEARCH-METHOD", "SearchMethod");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
    }
}
