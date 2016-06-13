namespace Jonas_Sage_Importer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleLedgerExtended")]
    public partial class SaleLedgerExtended
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long UniqueID { get; set; }

        [StringLength(30)]
        public string CustRef { get; set; }

        [StringLength(50)]
        public string CustName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GL { get; set; }

        [StringLength(255)]
        public string GLDescription { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? Day { get; set; }

        [StringLength(50)]
        public string InvoiceNo { get; set; }

        public string ItemDescription { get; set; }

        public short? JonasGroup { get; set; }

        [StringLength(255)]
        public string JonasGroupName { get; set; }

        public short? MaintenanceType { get; set; }

        [StringLength(255)]
        public string MaintTypeDescription { get; set; }

        [StringLength(255)]
        public string ReportingDescription { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string EntryType { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal QtyValue { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal NetValue { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal TaxValue { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal GrossValue { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal ProfitValue { get; set; }

        [StringLength(20)]
        public string CustOrderNo { get; set; }

        [StringLength(50)]
        public string ImportType { get; set; }
    }
}
