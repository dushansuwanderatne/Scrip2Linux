using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CFS06100

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CFS06100", "FormName");
		//Fields


        public static WinFormsField CshareCode1 = new WinFormsField("CSHARE-CODE1", "CshareCode1");
        public static WinFormsField RecordLength1 = new WinFormsField("RECORD-LENGTH1", "RecordLength1");
        public static WinFormsField BlockFactor1 = new WinFormsField("BLOCK-FACTOR1", "BlockFactor1");
        public static WinFormsField TapeLabel1 = new WinFormsField("TAPE-LABEL1", "TapeLabel1");
        public static WinFormsField CshareCode2 = new WinFormsField("CSHARE-CODE2", "CshareCode2");
        public static WinFormsField RecordLength2 = new WinFormsField("RECORD-LENGTH2", "RecordLength2");
        public static WinFormsField BlockFactor2 = new WinFormsField("BLOCK-FACTOR2", "BlockFactor2");
        public static WinFormsField TapeLabel2 = new WinFormsField("TAPE-LABEL2", "TapeLabel2");
    }
}
