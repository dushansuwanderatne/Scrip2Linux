using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CRSCIR01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CRSCIR01", "FormName");
		//Fields


        public static WinFormsField CrscirKey0 = new WinFormsField("CRSCIR-KEY0", "CrscirKey0");
        public static WinFormsField Isin = new WinFormsField("ISIN", "Isin");
        public static WinFormsField CirclesDate = new WinFormsField("CIRCLES-DATE", "CirclesDate");
        public static WinFormsField CirclesTimestamp = new WinFormsField("CIRCLES-TIMESTAMP", "CirclesTimestamp");
        public static WinFormsField CirclesStatus = new WinFormsField("CIRCLES-STATUS", "CirclesStatus");
        public static WinFormsField Expected = new WinFormsField("EXPECTED", "Expected");
        public static WinFormsField Received = new WinFormsField("RECEIVED", "Received");
        public static WinFormsField Processed = new WinFormsField("PROCESSED", "Processed");
        public static WinFormsField NegativeHolderID = new WinFormsField("NEGATIVE-HOLDER-ID", "NegativeHolderID");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
    }
}
