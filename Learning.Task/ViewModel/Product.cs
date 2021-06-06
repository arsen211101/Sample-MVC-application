using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.Task.ViewModel
{
    public class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public List<Category> Category { get; set; }
    }
}
