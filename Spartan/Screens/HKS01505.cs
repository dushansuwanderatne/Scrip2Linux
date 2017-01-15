using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HKS01505

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HKS01505", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField ScripListNAFormat = new WinFormsField("SCRIP-LIST-NA-FORMAT", "ScripListNAFormat");
        public static WinFormsField ScripSeq = new WinFormsField("SCRIP-SEQ", "ScripSeq");
        public static WinFormsField BrokerAnalysisOpt = new WinFormsField("BROKER-ANALYSIS-OPT", "BrokerAnalysisOpt");
        public static WinFormsField PrintT200HldrNO = new WinFormsField("PRINT-T200-HLDR-NO", "PrintT200HldrNO");
        public static WinFormsField LikeHldrsIncChess = new WinFormsField("LIKE-HLDRS-INC-CHESS", "LikeHldrsIncChess");
        public static WinFormsField SignificantMoveInd = new WinFormsField("SIGNIFICANT-MOVE-IND", "SignificantMoveInd");
        public static WinFormsField MovementSelection = new WinFormsField("MOVEMENT-SELECTION", "MovementSelection");
        public static WinFormsField MovementLevel = new WinFormsField("MOVEMENT-LEVEL", "MovementLevel");
        public static WinFormsField SignificantSeq = new WinFormsField("SIGNIFICANT-SEQ", "SignificantSeq");
        public static WinFormsField IncEntrepotAcc = new WinFormsField("INC-ENTREPOT-ACC", "IncEntrepotAcc");
        public static WinFormsField HinTOPrint = new WinFormsField("HIN-TO-PRINT", "HinTOPrint");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
