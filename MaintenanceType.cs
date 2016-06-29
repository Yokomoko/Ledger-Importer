using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jonas_Sage_Importer
{
    public class MaintenanceType
    {
        [Key]
        [Column("MaintenanceType")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MaintenanceType1 { get; set; }

        [StringLength(20)]
        public string LongReference { get; set; }

        [StringLength(255)]
        public string MaintTypeDescription { get; set; }

        [StringLength(255)]
        public string ReportingDescription { get; set; }

        public short? JonasGroup { get; set; }
    }
}
