using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class REMENQ01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("REMENQ01", "FormName");
		//Fields


        public static WinFormsField MenuItemHelp = new WinFormsField("MENU-ITEM-HELP", "HELP. Help Information", "HelpInformation");
        public static WinFormsField MenuItemNZ = new WinFormsField("MENU-ITEM-NZ", "NZ.   New Zealand Clients", "NewZealandClients");
        public static WinFormsField MenuItemPer = new WinFormsField("MENU-ITEM-PER", "PER.  Perth Clients", "PerthClients");
        public static WinFormsField MenuItemSyd1 = new WinFormsField("MENU-ITEM-SYD1", "SYD1. Sydney Clients Machine 1", "SydneyClientsMachine1");
        public static WinFormsField MenuItemSyd2 = new WinFormsField("MENU-ITEM-SYD2", "SYD2.  Sydney Clients Machine 2", "SydneyClientsMachine2");
        public static WinFormsField MenuItemMel1 = new WinFormsField("MENU-ITEM-MEL1", "MEL1. Melbourne/Adelaide Clients 1", "Melbourne/AdelaideClients1");
        public static WinFormsField MenuItemMel2 = new WinFormsField("MENU-ITEM-MEL2", "MEL2.  Melbourne/Adelaide Clients 2", "Melbourne/AdelaideClients2");
        public static WinFormsField MenuItemMim = new WinFormsField("MENU-ITEM-MIM", "MIM.  MIM (Brisbane)", "MIM(Brisbane)");
        public static WinFormsField MenuItemBne = new WinFormsField("MENU-ITEM-BNE", "BNE.  Brisbane Clients", "BrisbaneClients");
        public static WinFormsField MenuItemProg = new WinFormsField("MENU-ITEM-PROG", "PROG. Development Machine", "DevelopmentMachine");
        public static WinFormsField MenuItemSure = new WinFormsField("MENU-ITEM-SURE", "SURE.  Sure Machine", "SureMachine");
        public static WinFormsField MenuItemEX = new WinFormsField("MENU-ITEM-EX", "EX. Exit Remote Access", "ExitRemoteAccess");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField Node = new WinFormsField("NODE", "Node");
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField Error1 = new WinFormsField("ERROR1", "Error1");
        public static WinFormsField Error2 = new WinFormsField("ERROR2", "Error2");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
