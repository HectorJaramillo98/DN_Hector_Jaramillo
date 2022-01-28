using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exercise.Entities
{
    public class Sale
    {
        public int IdUser { get; set; }
        public int IdInventory { get; set; }
        public int Amount { get; set; }
    }
}
