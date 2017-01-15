using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class REMUPD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("REMUPD01", "FormName");
		//Fields


        public static WinFormsField Initials = new WinFormsField("INITIALS", "Initials");
        public static WinFormsField Password = new WinFormsField("PASSWORD", "Password");
        public static WinFormsField Description = new WinFormsField("DESCRIPTION", "Description");
        public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        public static WinFormsField RemoteID = new WinFormsField("REMOTE-ID", "RemoteID");
        //public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        //public static WinFormsField RemoteID = new WinFormsField("REMOTE-ID", "RemoteID");
        //public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        //public static WinFormsField RemoteID = new WinFormsField("REMOTE-ID", "RemoteID");
        //public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        //public static WinFormsField RemoteID = new WinFormsField("REMOTE-ID", "RemoteID");
        //public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        //public static WinFormsField RemoteID = new WinFormsField("REMOTE-ID", "RemoteID");
        //public static WinFormsField NodeName = new WinFormsField("NODE-NAME", "NodeName");
        //public static WinFormsField RemoteID = new WinFormsField("REMOTE-ID", "RemoteID");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Search = new WinFormsField("SEARCH", "Search");
        public static WinFormsField Delete = new WinFormsField("DELETE", "Delete");
    }
}
