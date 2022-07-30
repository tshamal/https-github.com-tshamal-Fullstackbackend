using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FsEngineeringTest1.Models
{
    public class People
    {
        [Key]
        public int peopleId { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]
        public string name { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public double height { get; set; }
        public double mass { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string hair_color { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string skin_color { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string eye_color { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string birth_year { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string gender { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string homeworld { get; set; }
        // [Column(TypeName = "NVARCHAR(100)")]
        [NotMapped]
        public string[] films { get; set; }
        // [Column(TypeName = "NVARCHAR(100)")]
        [NotMapped]
        public string[] species { get; set; }
        [NotMapped]
        // [Column(TypeName = "NVARCHAR(100)")]
        public string[] vehicles{ get; set; }
      //  [Column(TypeName = "DateTime")]
        public DateTime  created  { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime edited { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
        public string url { get; set; }





    }
}
