using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Jonas_Sage_Importer
{
    public class JonasImporterEnums
    {
        #region Public Enums
        public enum importSources
        {
            Sage = 0,
            Great_Plains = 1,
            CRM = 2
        }

        public enum greatPlainsImportTypes
        {
            [Description("Invoice (EPOS AR)")]
            Invoice_EposAR = 0,
            [Description("Invoices Posted to P+L (CSS DOWNLOAD)")]
            Invoices_Posted_to_P_L = 1,
            [Description("Outstanding Invoices")]
            Outstanding_Invoices = 2
        }

        public enum sageImportTypes
        {
            Invoice = 0,
            Sales_Order = 1
        }

        public enum crmImportTypes
        {
            Sales_Order = 0
        }
        #endregion
    }
}
