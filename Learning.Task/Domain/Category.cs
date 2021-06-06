using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Task.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name", TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Required]
        [Column("CreationDate", TypeName = "DateTime")]
        public DateTime CreationDate { get; set; }
    }
}
