using System;
using TechTalk.SpecFlow;
using Spartan.Core.WinForms.WinFormsObjects;
using Spartan.Core.WinForms;
using Spartan.Core;

namespace SCRIPAU.Automation.Screens
{
    [Binding]
    public class HLDJSD01

    {
		//Form Object
		public static WinFormsForm FormName = new WinFormsForm("HLDJSD01", "FormName");
		//Fields


        public static WinFormsField Action = new WinFormsField("ACTION", "Action");
        public static WinFormsField Confirm = new WinFormsField("CONFIRM", "Confirm");
        public static WinFormsField ReinitiateSearch = new WinFormsField("REINITIATE-SEARCH", "ReinitiateSearch");
        public static WinFormsField RecType = new WinFormsField("REC-TYPE", "RecType");
        public static WinFormsField HolderID = new WinFormsField("HOLDER-ID", "HolderID");
        public static WinFormsField HolderJntID = new WinFormsField("HOLDER-JNT-ID", "HolderJntID");
        public static WinFormsField SubType = new WinFormsField("SUB-TYPE", "SubType");
        public static WinFormsField HldjsdKey0 = new WinFormsField("HLDJSD-KEY0", "HldjsdKey0");
        public static WinFormsField IrlEntityType = new WinFormsField("IRL-ENTITY-TYPE", "IrlEntityType");
        public static WinFormsField IrlTaxReference = new WinFormsField("IRL-TAX-REFERENCE", "IrlTaxReference");
        public static WinFormsField IrlTaxRefType = new WinFormsField("IRL-TAX-REF-TYPE", "IrlTaxRefType");
        public static WinFormsField IrlDateBirth = new WinFormsField("IRL-DATE-BIRTH", "IrlDateBirth");
        public static WinFormsField IrlPrevName = new WinFormsField("IRL-PREV-NAME", "IrlPrevName");
        public static WinFormsField IrlSigName = new WinFormsField("IRL-SIG-NAME", "IrlSigName");
        public static WinFormsField IrlSigCapType = new WinFormsField("IRL-SIG-CAP-TYPE", "IrlSigCapType");
        public static WinFormsField IrlSigPhone = new WinFormsField("IRL-SIG-PHONE", "IrlSigPhone");
        public static WinFormsField IrlSigDate = new WinFormsField("IRL-SIG-DATE", "IrlSigDate");
        public static WinFormsField IrlCertFileRef = new WinFormsField("IRL-CERT-FILE-REF", "IrlCertFileRef");
        public static WinFormsField IrlCertDwtRef = new WinFormsField("IRL-CERT-DWT-REF", "IrlCertDwtRef");
        public static WinFormsField IrlCertStatus = new WinFormsField("IRL-CERT-STATUS", "IrlCertStatus");
        public static WinFormsField IrlDwtExpiryDT = new WinFormsField("IRL-DWT-EXPIRY-DT", "IrlDwtExpiryDT");
    }
}
