using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HOSTFN54

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HOSTFN54", "FormName");
		//Fields


        public static WinFormsField HostfnName = new WinFormsField("HOSTFN-NAME", "HostfnName");
        public static WinFormsField PCName = new WinFormsField("PC-NAME", "PCName");
        public static WinFormsField Min = new WinFormsField("MIN", "Min");
        public static WinFormsField Filler = new WinFormsField("FILLER", "Filler");
    }
}
