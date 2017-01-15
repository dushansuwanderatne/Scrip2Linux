using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class ADM00604

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("ADM00604", "FormName");
		//Fields


        public static WinFormsField Project = new WinFormsField("PROJECT", "Project");
        public static WinFormsField NumberOFEntries = new WinFormsField("NUMBER-OF-ENTRIES", "NumberOFEntries");
        public static WinFormsField NumberPrimary = new WinFormsField("NUMBER-PRIMARY", "NumberPrimary");
        public static WinFormsField NumberRecords = new WinFormsField("NUMBER-RECORDS", "NumberRecords");
        public static WinFormsField NumberINUse = new WinFormsField("NUMBER-IN-USE", "NumberINUse");
        public static WinFormsField OverflowEntries = new WinFormsField("OVERFLOW-ENTRIES", "OverflowEntries");
        public static WinFormsField OverflowBuckets = new WinFormsField("OVERFLOW-BUCKETS", "OverflowBuckets");
        public static WinFormsField RebuildSuggestion = new WinFormsField("REBUILD-SUGGESTION", "RebuildSuggestion");
    }
}
