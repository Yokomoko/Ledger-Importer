using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jonas_Sage_Importer
{
    public class Number
    {
        [Key]
        [Column("Number")]
        public short Number1 { get; set; }
    }
}
