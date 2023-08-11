using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]//primary key
        public int Id { get; set; }
        [Required]//not null
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
