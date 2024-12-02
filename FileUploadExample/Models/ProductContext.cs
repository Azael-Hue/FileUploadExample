using Microsoft.EntityFrameworkCore;

namespace FileUploadExample.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
