using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class SPP10000

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("SPP10000", "FormName");
		//Fields


        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SharePrice = new WinFormsField("SHARE-PRICE", "SharePrice");
        public static WinFormsField PriceDiscount = new WinFormsField("PRICE-DISCOUNT", "PriceDiscount");
        public static WinFormsField AllotmentDate = new WinFormsField("ALLOTMENT-DATE", "AllotmentDate");
        public static WinFormsField BooksCloseDate = new WinFormsField("BOOKS-CLOSE-DATE", "BooksCloseDate");
        public static WinFormsField ReturnMailApply = new WinFormsField("RETURN-MAIL-APPLY", "ReturnMailApply");
        public static WinFormsField StatementSeq = new WinFormsField("STATEMENT-SEQ", "StatementSeq");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
