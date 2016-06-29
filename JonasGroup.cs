using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jonas_Sage_Importer
{
    public class JonasGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short GroupNo { get; set; }

        [StringLength(255)]
        public string GroupName { get; set; }
    }
}
