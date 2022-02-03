using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Inventory
{
    public class SalesInventory
    {
        public int InventoryId { get; set; }

        public int SaleId { get; set; }
        Inventory Inventory { get; set; }

        Sale Sale { get; set; }

    }
}
