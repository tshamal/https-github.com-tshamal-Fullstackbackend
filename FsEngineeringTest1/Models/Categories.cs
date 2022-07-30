
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FsEngineeringTest1.Models
{
    public class Categories
    {
        [Key]
        public int categoryId { get; set; }
        [Column(TypeName = "NVARCHAR(100)")]
       // [Index(nameof(), IsUnique = true)]

        // [Index(IsUnique = true)]
        public string  category{ get; set; }
        

    }
}
