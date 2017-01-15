using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG05500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG05500", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField ClientCode = new WinFormsField("CLIENT-CODE", "ClientCode");
        public static WinFormsField GroupIdentifier = new WinFormsField("GROUP-IDENTIFIER", "GroupIdentifier");
        public static WinFormsField GroupDesc = new WinFormsField("GROUP-DESC", "GroupDesc");
        public static WinFormsField InterstateFlag = new WinFormsField("INTERSTATE-FLAG", "InterstateFlag");
        public static WinFormsField GroupParts1 = new WinFormsField("GROUP-PARTS-1", "GroupParts1");
        public static WinFormsField GroupParts2 = new WinFormsField("GROUP-PARTS-2", "GroupParts2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchGroupName = new WinFormsField("SEARCH-GROUP-NAME", "SearchGroupName");
        public static WinFormsField ConfirmDelete = new WinFormsField("CONFIRM-DELETE", "ConfirmDelete");
    }
}
