using System.ComponentModel.DataAnnotations;

namespace FileUploadExample.Models
{
    public class Product
    {
        [Key]
        public int ProcuctId { get; set; }

        public string Title { get; set; }

        public string PhotoUrl { get; set; }
    }

    public class CreateProductViewModel
    {
        [Required]
        public string Title { get; set; }
        
        public IFormFile ProductPhoto { get; set; }
    }
}
