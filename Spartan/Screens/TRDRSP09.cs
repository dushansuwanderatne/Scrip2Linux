using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class TRDRSP09

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("TRDRSP09", "FormName");
		//Fields


        public static WinFormsField FieldsReqdInd = new WinFormsField("FIELDS-REQD-IND", "FieldsReqdInd");
        public static WinFormsField FieldSepChar = new WinFormsField("FIELD-SEP-CHAR", "FieldSepChar");
        public static WinFormsField TextDelimReq = new WinFormsField("TEXT-DELIM-REQ", "TextDelimReq");
        public static WinFormsField TextDelimiter = new WinFormsField("TEXT-DELIMITER", "TextDelimiter");
    }
}
