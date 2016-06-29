using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jonas_Sage_Importer
{
    public class JonasType
    {
        [Key]
        [Column("JonasType", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short JonasType1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string JonasTypeDescription { get; set; }

        public short? JonasGroup { get; set; }
    }
}
