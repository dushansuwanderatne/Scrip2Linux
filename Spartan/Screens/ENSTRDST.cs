using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ENSTRDST

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ENSTRDST", "FormName");
		//Fields


        public static WinFormsField SequenceNumber = new WinFormsField("SEQUENCE-NUMBER", "SequenceNumber");
        public static WinFormsField FinalFlag = new WinFormsField("FINAL-FLAG", "FinalFlag");
        public static WinFormsField DateSent = new WinFormsField("DATE-SENT", "DateSent");
        public static WinFormsField TimeSent = new WinFormsField("TIME-SENT", "TimeSent");
        public static WinFormsField OrderType = new WinFormsField("ORDER-TYPE", "OrderType");
        public static WinFormsField DurationType = new WinFormsField("DURATION-TYPE", "DurationType");
        public static WinFormsField LimitPrice = new WinFormsField("LIMIT-PRICE", "LimitPrice");
        public static WinFormsField Duration = new WinFormsField("DURATION", "Duration");
        public static WinFormsField ApplyTax = new WinFormsField("APPLY-TAX", "ApplyTax");
        public static WinFormsField OrdStatusNotifyDtl = new WinFormsField("ORD-STATUS-NOTIFY-DTL", "OrdStatusNotifyDtl");
        public static WinFormsField TranTypeCode = new WinFormsField("TRAN-TYPE-CODE", "TranTypeCode");
        public static WinFormsField Msgid = new WinFormsField("MSGID", "Msgid");
        public static WinFormsField Date = new WinFormsField("DATE", "Date");
        public static WinFormsField Time = new WinFormsField("TIME", "Time");
        public static WinFormsField MoreTOComeInd = new WinFormsField("MORE-TO-COME-IND", "MoreTOComeInd");
        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField LocateArgument = new WinFormsField("LOCATE-ARGUMENT", "LocateArgument");
        public static WinFormsField OrderStatus = new WinFormsField("ORDER-STATUS", "OrderStatus");
        public static WinFormsField OrdStatusNotifyTyp = new WinFormsField("ORD-STATUS-NOTIFY-TYP", "OrdStatusNotifyTyp");
    }
}
