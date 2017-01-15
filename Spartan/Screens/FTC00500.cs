using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FTC00500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FTC00500", "FormName");
		//Fields


        public static WinFormsField SystemInfoDate6 = new WinFormsField("SYSTEM-INFO-DATE-6", "10", "10");
        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField Round = new WinFormsField("ROUND", "Round");
        public static WinFormsField UserOrigin = new WinFormsField("USER-ORIGIN", "UserOrigin");
        public static WinFormsField CommentLine = new WinFormsField("COMMENT-LINE", "CommentLine");
    }
}
