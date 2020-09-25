using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onixa.Entity.ComplexTypes
{
   public class Productimages
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> StartPoint { get; set; }
        public Nullable<bool> IsContinued { get; set; }
        public Nullable<int> UnıtInStock { get; set; }
        public Nullable<int> StartGivenMemberCount { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> Category_Id { get; set; }
        public string UserBy { get; set; }
        public string Path { get; set; }
    }
}
