using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onixa.Entity.ComplexTypes
{
   public class MyBasket
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string MainImage { get; set; }
        public string Note { get; set; }
        public Nullable<int>  Project_ID { get; set; }
        public string Room_Name { get; set; }

    }
}
