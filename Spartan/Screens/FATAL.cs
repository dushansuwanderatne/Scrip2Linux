using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class FATAL

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("FATAL", "FormName");
		//Fields


        public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 9", "9");
        //public static WinFormsField SystemInfoUnknown = new WinFormsField("SYSTEM-INFO-UNKNOWN", " 4", "4");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField ErrorReason = new WinFormsField("ERROR-REASON", "ErrorReason");
        public static WinFormsField KeyNumber = new WinFormsField("KEY-NUMBER", "KeyNumber");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField FileUnit = new WinFormsField("FILE-UNIT", "FileUnit");
        public static WinFormsField UserNumber = new WinFormsField("USER-NUMBER", "UserNumber");
        public static WinFormsField IOStatus = new WinFormsField("IO-STATUS", "IOStatus");
        public static WinFormsField ProgramName = new WinFormsField("PROGRAM-NAME", "ProgramName");
        public static WinFormsField MidasCode = new WinFormsField("MIDAS-CODE", "MidasCode");
        public static WinFormsField UfdName = new WinFormsField("UFD-NAME", "UfdName");
        public static WinFormsField FileName = new WinFormsField("FILE-NAME", "FileName");
        public static WinFormsField LogID = new WinFormsField("LOG-ID", "LogID");
        public static WinFormsField OpenMode = new WinFormsField("OPEN-MODE", "OpenMode");
        public static WinFormsField FcbAction = new WinFormsField("FCB-ACTION", "FcbAction");
    }
}
