using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class OLSUNP02

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("OLSUNP02", "FormName");
		//Fields


        public static WinFormsField BuyHolderID = new WinFormsField("BUY-HOLDER-ID", "BuyHolderID");
        public static WinFormsField BuyNal1Ch1to30 = new WinFormsField("BUY-NAL-1-CH1TO30", "BuyNal1Ch1to30");
        public static WinFormsField BuyNal2Ch1to30 = new WinFormsField("BUY-NAL-2-CH1TO30", "BuyNal2Ch1to30");
        public static WinFormsField BuyNal3Ch1to30 = new WinFormsField("BUY-NAL-3-CH1TO30", "BuyNal3Ch1to30");
        public static WinFormsField BuyNal4Ch1to30 = new WinFormsField("BUY-NAL-4-CH1TO30", "BuyNal4Ch1to30");
        public static WinFormsField BuyNal5Ch1to30 = new WinFormsField("BUY-NAL-5-CH1TO30", "BuyNal5Ch1to30");
        public static WinFormsField BuyNal6Ch1to30 = new WinFormsField("BUY-NAL-6-CH1TO30", "BuyNal6Ch1to30");
        public static WinFormsField BuyWarning1to3 = new WinFormsField("BUY-WARNING-1TO3", "BuyWarning1to3");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
    }
}
