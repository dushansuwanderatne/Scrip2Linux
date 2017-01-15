using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class DIVX1035

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("DIVX1035", "FormName");
		//Fields
        public static WinFormsField Selection = new WinFormsField("SELECTION", "Selection");
        public static WinFormsField DividendSource = new WinFormsField("DIVIDEND-SOURCE", "DividendSource");
        public static WinFormsField SourceDescription = new WinFormsField("SOURCE-DESCRIPTION", "SourceDescription");
        public static WinFormsField DividendCode = new WinFormsField("DIVIDEND-CODE", "DividendCode");
        public static WinFormsField SubPayCode = new WinFormsField("SUB-PAY-CODE", "SubPayCode");
        public static WinFormsField PaymentType = new WinFormsField("PAYMENT-TYPE", "PaymentType");
        public static WinFormsField TypeDesc = new WinFormsField("TYPE-DESC", "TypeDesc");
        public static WinFormsField ClassCat = new WinFormsField("CLASS-CAT", "ClassCat");
        public static WinFormsField CompNum = new WinFormsField("COMP-NUM", "CompNum");
        public static WinFormsField ClassCat2 = new WinFormsField("CLASS-CAT-2", "ClassCat2");
        public static WinFormsField Component = new WinFormsField("COMPONENT", "Component");
        public static WinFormsField ComponentRate1 = new WinFormsField("COMPONENT-RATE-1", "ComponentRate1");
        public static WinFormsField RateType = new WinFormsField("RATE-TYPE", "RateType");
        public static WinFormsField RateDescription = new WinFormsField("RATE-DESCRIPTION", "RateDescription");
        public static WinFormsField Group1 = new WinFormsField("GROUP-1", "Group1");
        public static WinFormsField InputGroup1 = new WinFormsField("INPUT-GROUP-1", "InputGroup1");
        public static WinFormsField Sequence1 = new WinFormsField("SEQUENCE-1", "Sequence1");
        public static WinFormsField ComponentRate2 = new WinFormsField("COMPONENT-RATE-2", "ComponentRate2");
        public static WinFormsField Group2 = new WinFormsField("GROUP-2", "Group2");
        public static WinFormsField InputGroup2 = new WinFormsField("INPUT-GROUP-2", "InputGroup2");
        public static WinFormsField Sequence2 = new WinFormsField("SEQUENCE-2", "Sequence2");
        public static WinFormsField ComponentRate3 = new WinFormsField("COMPONENT-RATE-3", "ComponentRate3");
        public static WinFormsField Group3 = new WinFormsField("GROUP-3", "Group3");
        public static WinFormsField InputGroup3 = new WinFormsField("INPUT-GROUP-3", "InputGroup3");
        public static WinFormsField Sequence3 = new WinFormsField("SEQUENCE-3", "Sequence3");
        public static WinFormsField ComponentRate4 = new WinFormsField("COMPONENT-RATE-4", "ComponentRate4");
        public static WinFormsField Group4 = new WinFormsField("GROUP-4", "Group4");
        public static WinFormsField InputGroup4 = new WinFormsField("INPUT-GROUP-4", "InputGroup4");
        public static WinFormsField Sequence4 = new WinFormsField("SEQUENCE-4", "Sequence4");
        public static WinFormsField ComponentRate5 = new WinFormsField("COMPONENT-RATE-5", "ComponentRate5");
        public static WinFormsField Group5 = new WinFormsField("GROUP-5", "Group5");
        public static WinFormsField InputGroup5 = new WinFormsField("INPUT-GROUP-5", "InputGroup5");
        public static WinFormsField Sequence5 = new WinFormsField("SEQUENCE-5", "Sequence5");
        public static WinFormsField ComponentRate6 = new WinFormsField("COMPONENT-RATE-6", "ComponentRate6");
        public static WinFormsField Group6 = new WinFormsField("GROUP-6", "Group6");
        public static WinFormsField InputGroup6 = new WinFormsField("INPUT-GROUP-6", "InputGroup6");
        public static WinFormsField Sequence6 = new WinFormsField("SEQUENCE-6", "Sequence6");
        public static WinFormsField ComponentRate7 = new WinFormsField("COMPONENT-RATE-7", "ComponentRate7");
        public static WinFormsField Group7 = new WinFormsField("GROUP-7", "Group7");
        public static WinFormsField InputGroup7 = new WinFormsField("INPUT-GROUP-7", "InputGroup7");
        public static WinFormsField Sequence7 = new WinFormsField("SEQUENCE-7", "Sequence7");
        public static WinFormsField ComponentRate8 = new WinFormsField("COMPONENT-RATE-8", "ComponentRate8");
        public static WinFormsField Group8 = new WinFormsField("GROUP-8", "Group8");
        public static WinFormsField InputGroup8 = new WinFormsField("INPUT-GROUP-8", "InputGroup8");
        public static WinFormsField Sequence8 = new WinFormsField("SEQUENCE-8", "Sequence8");
        public static WinFormsField ComponentRate9 = new WinFormsField("COMPONENT-RATE-9", "ComponentRate9");
        public static WinFormsField Group9 = new WinFormsField("GROUP-9", "Group9");
        public static WinFormsField InputGroup9 = new WinFormsField("INPUT-GROUP-9", "InputGroup9");
        public static WinFormsField Sequence9 = new WinFormsField("SEQUENCE-9", "Sequence9");
        public static WinFormsField ComponentRate10 = new WinFormsField("COMPONENT-RATE-10", "ComponentRate10");
        public static WinFormsField Group10 = new WinFormsField("GROUP-10", "Group10");
        public static WinFormsField InputGroup10 = new WinFormsField("INPUT-GROUP-10", "InputGroup10");
        public static WinFormsField Sequence10 = new WinFormsField("SEQUENCE-10", "Sequence10");
        public static WinFormsField ComponentRate11 = new WinFormsField("COMPONENT-RATE-11", "ComponentRate11");
        public static WinFormsField Group11 = new WinFormsField("GROUP-11", "Group11");
        public static WinFormsField InputGroup11 = new WinFormsField("INPUT-GROUP-11", "InputGroup11");
        public static WinFormsField Sequence11 = new WinFormsField("SEQUENCE-11", "Sequence11");
        public static WinFormsField ComponentRate12 = new WinFormsField("COMPONENT-RATE-12", "ComponentRate12");
        public static WinFormsField Group12 = new WinFormsField("GROUP-12", "Group12");
        public static WinFormsField InputGroup12 = new WinFormsField("INPUT-GROUP-12", "InputGroup12");
        public static WinFormsField Sequence12 = new WinFormsField("SEQUENCE-12", "Sequence12");
        public static WinFormsField ComponentRate13 = new WinFormsField("COMPONENT-RATE-13", "ComponentRate13");
        public static WinFormsField Group13 = new WinFormsField("GROUP-13", "Group13");
        public static WinFormsField InputGroup13 = new WinFormsField("INPUT-GROUP-13", "InputGroup13");
        public static WinFormsField Sequence13 = new WinFormsField("SEQUENCE-13", "Sequence13");
        public static WinFormsField ComponentRate14 = new WinFormsField("COMPONENT-RATE-14", "ComponentRate14");
        public static WinFormsField Group14 = new WinFormsField("GROUP-14", "Group14");
        public static WinFormsField InputGroup14 = new WinFormsField("INPUT-GROUP-14", "InputGroup14");
        public static WinFormsField Sequence14 = new WinFormsField("SEQUENCE-14", "Sequence14");
        public static WinFormsField ComponentRate15 = new WinFormsField("COMPONENT-RATE-15", "ComponentRate15");
        public static WinFormsField Group15 = new WinFormsField("GROUP-15", "Group15");
        public static WinFormsField InputGroup15 = new WinFormsField("INPUT-GROUP-15", "InputGroup15");
        public static WinFormsField Sequence15 = new WinFormsField("SEQUENCE-15", "Sequence15");
        public static WinFormsField Message = new WinFormsField("MESSAGE", "Message");
        public static WinFormsField DividendDescription = new WinFormsField("DIVIDEND-DESCRIPTION", "DividendDescription");
        public static WinFormsField SystemInfoFree6 = new WinFormsField("SYSTEM-INFO-FREE-6", "20", "20");
        public static WinFormsField SystemInfoFree4 = new WinFormsField("SYSTEM-INFO-FREE-4", "18", "18");
        public static WinFormsField SystemInfoFree7 = new WinFormsField("SYSTEM-INFO-FREE-7", "21", "21");
        public static WinFormsField SystemInfoFree5 = new WinFormsField("SYSTEM-INFO-FREE-5", "19", "19");
    }
}
