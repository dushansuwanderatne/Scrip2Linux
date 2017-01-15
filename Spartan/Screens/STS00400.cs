using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class STS00400

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("STS00400", "FormName");
		//Fields


        public static WinFormsField ClientGroup = new WinFormsField("CLIENT-GROUP", "ClientGroup");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField ClientDescription = new WinFormsField("CLIENT-DESCRIPTION", "ClientDescription");
        public static WinFormsField NumHolders = new WinFormsField("NUM-HOLDERS", "NumHolders");
        public static WinFormsField NumNilHolders = new WinFormsField("NUM-NIL-HOLDERS", "NumNilHolders");
        public static WinFormsField ClientType = new WinFormsField("CLIENT-TYPE", "ClientType");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchClientGroup = new WinFormsField("SEARCH-CLIENT-GROUP", "SearchClientGroup");
        public static WinFormsField SearchClientCode = new WinFormsField("SEARCH-CLIENT-CODE", "SearchClientCode");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
