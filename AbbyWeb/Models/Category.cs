using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category name must be between 3 and 50 characters long.")]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
    }
}