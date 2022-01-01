using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Assignment2.Models
{
    [Table("categories")]
    [Index(nameof(CategoryName), Name = "category_name")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Required]
        [Column("category_name")]
        [StringLength(15)]
        public string CategoryName { get; set; }
        [Column("description", TypeName = "ntext")]
        public string Description { get; set; }

        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
