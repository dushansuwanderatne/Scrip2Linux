using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIV01042

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIV01042", "FormName");
		//Fields


        public static WinFormsField ClassaRate = new WinFormsField("CLASSA-RATE", "ClassaRate");
        public static WinFormsField ClassbRate = new WinFormsField("CLASSB-RATE", "ClassbRate");
        public static WinFormsField SeparateUnf = new WinFormsField("SEPARATE-UNF", "SeparateUnf");
        public static WinFormsField ButtDesc = new WinFormsField("BUTT-DESC", "ButtDesc");
        public static WinFormsField RateDesc = new WinFormsField("RATE-DESC", "RateDesc");
    }
}
