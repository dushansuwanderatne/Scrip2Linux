using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CHSOUT01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CHSOUT01", "FormName");
		//Fields


        public static WinFormsField Msn = new WinFormsField("MSN", "Msn");
        public static WinFormsField MessageType = new WinFormsField("MESSAGE-TYPE", "MessageType");
        public static WinFormsField Version = new WinFormsField("VERSION", "Version");
        public static WinFormsField ProcessedFlag = new WinFormsField("PROCESSED-FLAG", "ProcessedFlag");
        public static WinFormsField Uic = new WinFormsField("UIC", "Uic");
        public static WinFormsField BitmapChar1 = new WinFormsField("BITMAP-CHAR1", "BitmapChar1");
        public static WinFormsField BitmapChar2 = new WinFormsField("BITMAP-CHAR2", "BitmapChar2");
        public static WinFormsField BitmapChar3 = new WinFormsField("BITMAP-CHAR3", "BitmapChar3");
        public static WinFormsField BitmapChar4 = new WinFormsField("BITMAP-CHAR4", "BitmapChar4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
