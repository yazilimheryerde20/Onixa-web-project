using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onixa.Entity.ComplexTypes
{
   public class ProductsLite
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public string MainImage { get; set; }
    }
}
