using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FsEngineeringTest1.Models
{
    public class Jokes
    {
        [NotMapped]
        public string [] categories { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime  created  { get; set; }
        public string  icon_url{ get; set; }
        [Key]
        public string id { get; set; } = string.Empty;
        [Column(TypeName = "DateTime")]
        public DateTime  updated_at { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string  url { get; set; }
        [Column(TypeName = "NVARCHAR(2500)")]
        public string value { get; set; }



    }
}
