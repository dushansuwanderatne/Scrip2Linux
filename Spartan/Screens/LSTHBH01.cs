using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSTHBH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSTHBH01", "FormName");
		//Fields


        public static WinFormsField LsthbhKey0 = new WinFormsField("LSTHBH-KEY0", "LsthbhKey0");
        public static WinFormsField HintID = new WinFormsField("HINT-ID", "HintID");
        public static WinFormsField BehaviourCode = new WinFormsField("BEHAVIOUR-CODE", "BehaviourCode");
        public static WinFormsField RuleFlag = new WinFormsField("RULE-FLAG", "RuleFlag");
        public static WinFormsField TextData1 = new WinFormsField("TEXT-DATA-1", "TextData1");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
