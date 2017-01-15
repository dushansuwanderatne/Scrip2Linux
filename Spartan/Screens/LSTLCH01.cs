using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class LSTLCH01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("LSTLCH01", "FormName");
		//Fields


        public static WinFormsField LstlchKey0 = new WinFormsField("LSTLCH-KEY0", "LstlchKey0");
        public static WinFormsField CharacteristicID = new WinFormsField("CHARACTERISTIC-ID", "CharacteristicID");
        public static WinFormsField ListID = new WinFormsField("LIST-ID", "ListID");
        public static WinFormsField TextData1 = new WinFormsField("TEXT-DATA-1", "TextData1");
        public static WinFormsField TextData2 = new WinFormsField("TEXT-DATA-2", "TextData2");
        public static WinFormsField NumData1 = new WinFormsField("NUM-DATA-1", "NumData1");
        public static WinFormsField NumData2 = new WinFormsField("NUM-DATA-2", "NumData2");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
