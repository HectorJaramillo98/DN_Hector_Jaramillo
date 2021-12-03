using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Customer
    {
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }

        public Customer(string Name, DateTime RegisterDate)
        {
            this.Name = Name;
            this.RegisterDate = RegisterDate;
        }
    }
}
