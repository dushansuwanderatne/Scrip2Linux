using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class EOL00117

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("EOL00117", "FormName");
		//Fields


        public static WinFormsField UploadType = new WinFormsField("UPLOAD-TYPE", "UploadType");
        public static WinFormsField AppropDate = new WinFormsField("APPROP-DATE", "AppropDate");
    }
}
