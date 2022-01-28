using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Excercise.Model
{
    public class GetSales
    {
        public int IdUser { get; set; }
        public int IdInventory { get; set; }
        public int Amount { get; set; }
    }
}
