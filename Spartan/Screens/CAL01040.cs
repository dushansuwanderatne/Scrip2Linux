using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class CAL01040

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("CAL01040", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField DishonorClass = new WinFormsField("DISHONOR-CLASS", "DishonorClass");
        public static WinFormsField DishonorFlatFee = new WinFormsField("DISHONOR-FLAT-FEE", "DishonorFlatFee");
        public static WinFormsField StartIntDate = new WinFormsField("START-INT-DATE", "StartIntDate");
        public static WinFormsField InterestRate = new WinFormsField("INTEREST-RATE", "InterestRate");
        public static WinFormsField InterestClass = new WinFormsField("INTEREST-CLASS", "InterestClass");
        public static WinFormsField FlatFee = new WinFormsField("FLAT-FEE", "FlatFee");
        public static WinFormsField FlatFeeClass = new WinFormsField("FLAT-FEE-CLASS", "FlatFeeClass");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
