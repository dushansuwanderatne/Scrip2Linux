using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00500

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00500", "FormName");
		//Fields


        public static WinFormsField Keyword = new WinFormsField("KEYWORD", "Keyword");
        public static WinFormsField Status = new WinFormsField("STATUS", "Status");
        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField NumberStart = new WinFormsField("NUMBER-START", "NumberStart");
        public static WinFormsField NumberEnd = new WinFormsField("NUMBER-END", "NumberEnd");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        //public static WinFormsField Date = new WinFormsField("DATE", "Date");
    }
}
