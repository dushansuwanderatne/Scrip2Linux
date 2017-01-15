using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS02401

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS02401", "FormName");
		//Fields


        public static WinFormsField ServiceProvider = new WinFormsField("SERVICE-PROVIDER", "ServiceProvider");
        public static WinFormsField ProviderDesc = new WinFormsField("PROVIDER-DESC", "ProviderDesc");
        public static WinFormsField ServiceCode = new WinFormsField("SERVICE-CODE", "ServiceCode");
        public static WinFormsField ServiceDesc = new WinFormsField("SERVICE-DESC", "ServiceDesc");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Action1st = new WinFormsField("ACTION-1ST", "Action1st");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField SearchProvider = new WinFormsField("SEARCH-PROVIDER", "SearchProvider");
        public static WinFormsField SearchService = new WinFormsField("SEARCH-SERVICE", "SearchService");
    }
}
