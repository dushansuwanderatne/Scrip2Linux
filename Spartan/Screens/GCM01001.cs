using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class GCM01001

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("GCM01001", "FormName");
		//Fields


        public static WinFormsField RunNumberX = new WinFormsField("RUN-NUMBER-X", "RunNumberX");
        public static WinFormsField SessionNumberX = new WinFormsField("SESSION-NUMBER-X", "SessionNumberX");
        public static WinFormsField RunDateX = new WinFormsField("RUN-DATE-X", "RunDateX");
        public static WinFormsField LocalJurisdiction = new WinFormsField("LOCAL-JURISDICTION", "LocalJurisdiction");
        public static WinFormsField RemoteJurisdiction = new WinFormsField("REMOTE-JURISDICTION", "RemoteJurisdiction");
        public static WinFormsField Email = new WinFormsField("EMAIL", "Email");
        public static WinFormsField ReconTimeHH = new WinFormsField("RECON-TIME-HH", "ReconTimeHH");
        public static WinFormsField ReconTimeMM = new WinFormsField("RECON-TIME-MM", "ReconTimeMM");
        public static WinFormsField ReconTimeSS = new WinFormsField("RECON-TIME-SS", "ReconTimeSS");
        public static WinFormsField ReconStatus = new WinFormsField("RECON-STATUS", "ReconStatus");
        public static WinFormsField LastReconDate = new WinFormsField("LAST-RECON-DATE", "LastReconDate");
        public static WinFormsField LastChangeDate = new WinFormsField("LAST-CHANGE-DATE", "LastChangeDate");
        public static WinFormsField LastTimeHH = new WinFormsField("LAST-TIME-HH", "LastTimeHH");
        public static WinFormsField LastTimeMM = new WinFormsField("LAST-TIME-MM", "LastTimeMM");
        public static WinFormsField LastTimeSS = new WinFormsField("LAST-TIME-SS", "LastTimeSS");
        public static WinFormsField LastUserID = new WinFormsField("LAST-USER-ID", "LastUserID");
        public static WinFormsField ActionFirst = new WinFormsField("ACTION-FIRST", "ActionFirst");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SearchLocal = new WinFormsField("SEARCH-LOCAL", "SearchLocal");
        public static WinFormsField SearchRemote = new WinFormsField("SEARCH-REMOTE", "SearchRemote");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
