using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string    Name { get; set; }
        public string Category { get; set; }
        public int Cost{ get; set; }

        public Product( string name, string category,int c)
        {
            
            Name = name;
            Category = category;
            Cost = c;
        }
       
    }
}
