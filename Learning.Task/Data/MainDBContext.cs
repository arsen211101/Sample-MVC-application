using Learning.Task.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Task.Data
{

    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options) { }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<Product> Product { get; set; }

    }

}
