using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS10025

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("RSS10025", "FormName");
		//Fields


        public static WinFormsField MenuItem1 = new WinFormsField("MENU-ITEM-1", "1. Print Name & Address & Holder No. only", "PrintName&Address&HolderNo.only");
        public static WinFormsField MenuItem2 = new WinFormsField("MENU-ITEM-2", "2. Print Name & Address, Holder No. & Units", "PrintName&Address,HolderNo.&Units");
        public static WinFormsField MenuItem3 = new WinFormsField("MENU-ITEM-3", "3. Print Name & Address, Holder No., Units & Amount", "PrintName&Address,HolderNo.,Units&Amount");
        public static WinFormsField MenuItem4 = new WinFormsField("MENU-ITEM-4", "4. Print Name & Address, Holder No., Units & Certificate Details", "PrintName&Address,HolderNo.,Units&CertificateDetails");
        public static WinFormsField MenuItem5 = new WinFormsField("MENU-ITEM-5", "5. Print Name & Address, Holder No., Units & Date", "PrintName&Address,HolderNo.,Units&Date");
        public static WinFormsField MenuItem6 = new WinFormsField("MENU-ITEM-6", "6. Print Name & Address only", "PrintName&Addressonly");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField NoticeFormat = new WinFormsField("NOTICE-FORMAT", "NoticeFormat");
        public static WinFormsField SeparatedCls = new WinFormsField("SEPARATED-CLS", "SeparatedCls");
        public static WinFormsField Rate = new WinFormsField("RATE", "Rate");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Comment = new WinFormsField("COMMENT", "Comment");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
