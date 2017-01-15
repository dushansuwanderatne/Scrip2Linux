using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG00101

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG00101", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField GivenName = new WinFormsField("GIVEN-NAME", "GivenName");
        public static WinFormsField Initial = new WinFormsField("INITIAL", "Initial");
        public static WinFormsField Surname = new WinFormsField("SURNAME", "Surname");
        public static WinFormsField Alias = new WinFormsField("ALIAS", "Alias");
        public static WinFormsField BelongGroup1 = new WinFormsField("BELONG-GROUP1", "BelongGroup1");
        public static WinFormsField BelongGroup2 = new WinFormsField("BELONG-GROUP2", "BelongGroup2");
        public static WinFormsField BelongGroup3 = new WinFormsField("BELONG-GROUP3", "BelongGroup3");
        public static WinFormsField BelongGroup4 = new WinFormsField("BELONG-GROUP4", "BelongGroup4");
        public static WinFormsField SendGroup1 = new WinFormsField("SEND-GROUP1", "SendGroup1");
        public static WinFormsField SendGroup2 = new WinFormsField("SEND-GROUP2", "SendGroup2");
        public static WinFormsField SendGroup3 = new WinFormsField("SEND-GROUP3", "SendGroup3");
        public static WinFormsField SendGroup4 = new WinFormsField("SEND-GROUP4", "SendGroup4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
