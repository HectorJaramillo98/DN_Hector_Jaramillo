using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exercise.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public int Stock { get; set; }
    }
}
