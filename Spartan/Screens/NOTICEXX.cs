using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class NOTICEXX

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("NOTICEXX", "FormName");
		//Fields


        public static WinFormsField MenuItemOK = new WinFormsField("MENU-ITEM-OK", "OK.  Proceed into SCRIP System", "ProceedintoSCRIPSystem");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX.  Exit from System", "ExitfromSystem");
    }
}
