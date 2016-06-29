using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jonas_Sage_Importer
{
    [Table("Configuration")]
    public class Configuration
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Label { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ConfigSetting { get; set; }
    }
}
