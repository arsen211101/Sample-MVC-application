using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Task.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Required]
        [Column("Description", TypeName = "nvarchar(200)")]
        public string Description { get; set; }

        [Required]
        [Column("Price", TypeName = "decimal")]
        public decimal Price { get; set; }


        [Column("CategoryId", TypeName = "int")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}
