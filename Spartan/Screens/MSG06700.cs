using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class MSG06700

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("MSG06700", "FormName");
		//Fields


        public static WinFormsField MenuItemC = new WinFormsField("MENU-ITEM-C", "C. CHESS generated errors", "CHESSgeneratederrors");
        public static WinFormsField MenuItemR = new WinFormsField("MENU-ITEM-R", "R. Registry generated errors to CHESS", "RegistrygeneratederrorstoCHESS");
        public static WinFormsField MenuItemF = new WinFormsField("MENU-ITEM-F", "F. FASTER generated errors", "FASTERgeneratederrors");
        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Option = new WinFormsField("OPTION", "Option");
    }
}
