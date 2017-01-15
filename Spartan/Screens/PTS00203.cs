using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class PTS00203

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("PTS00203", "FormName");
		//Fields


        public static WinFormsField SystemInfoFormName = new WinFormsField("SYSTEM-INFO-FORM-NAME", "14", "14");
        public static WinFormsField Code = new WinFormsField("CODE", "Code");
        public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Logged = new WinFormsField("LOGGED", "Logged");
        public static WinFormsField BY = new WinFormsField("BY", "BY");
        public static WinFormsField Notified = new WinFormsField("NOTIFIED", "Notified");
        //public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField Phone = new WinFormsField("PHONE", "Phone");
        public static WinFormsField Text = new WinFormsField("TEXT", "Text");
        public static WinFormsField Occurred = new WinFormsField("OCCURRED", "Occurred");
        public static WinFormsField Affected = new WinFormsField("AFFECTED", "Affected");
        public static WinFormsField Version = new WinFormsField("VERSION", "Version");
        //public static WinFormsField Name = new WinFormsField("NAME", "Name");
        public static WinFormsField SlotNumber = new WinFormsField("SLOT-NUMBER", "SlotNumber");
        public static WinFormsField Recurs = new WinFormsField("RECURS", "Recurs");
        public static WinFormsField Frequency = new WinFormsField("FREQUENCY", "Frequency");
        public static WinFormsField Delete = new WinFormsField("DELETE", "Delete");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
    }
}
