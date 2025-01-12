using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2b.EntityLayer
{
    internal class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }

    }
}
