using Spartan.Core.WinForms.WinFormsObjects;
using TechTalk.SpecFlow;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class RSS23001
    {
        //Form Object
        public static WinFormsForm FormName = new WinFormsForm("RSS23001", "FormName");
        //Fields
        public static WinFormsField Client = new WinFormsField("CLIENT", "Client");
        public static WinFormsField Company = new WinFormsField("COMPANY", "Company");
        public static WinFormsField UserName = new WinFormsField("USER-NAME", "UserName");
        public static WinFormsField StartDate = new WinFormsField("START-DATE", "StartDate");
        public static WinFormsField EndDate = new WinFormsField("END-DATE", "EndDate");
        public static WinFormsField BillMM = new WinFormsField("BILL-MM", "BillMM");
        public static WinFormsField BillYY = new WinFormsField("BILL-YY", "BillYY");
        public static WinFormsField OrigSystem = new WinFormsField("ORIG-SYSTEM", "OrigSystem");
        public static WinFormsField ServProvider = new WinFormsField("SERV-PROVIDER", "ServProvider");
        public static WinFormsField ServCode = new WinFormsField("SERV-CODE", "ServCode");
        public static WinFormsField Department = new WinFormsField("DEPARTMENT", "Department");
        public static WinFormsField Branch = new WinFormsField("BRANCH", "Branch");
        public static WinFormsField TransCode = new WinFormsField("TRANS-CODE", "TransCode");
        public static WinFormsField BrokerCode = new WinFormsField("BROKER-CODE", "BrokerCode");
        public static WinFormsField AccessCode = new WinFormsField("ACCESS-CODE", "AccessCode");
        public static WinFormsField ReportType = new WinFormsField("REPORT-TYPE", "ReportType");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
