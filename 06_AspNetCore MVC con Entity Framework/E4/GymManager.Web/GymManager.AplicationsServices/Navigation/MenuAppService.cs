using GymManager.Core.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationsServices.Navigation
{
    public class MenuAppService : IMenuAppService
    {
        public List<UserMenuItem> GetMenu()
        {
            List<UserMenuItem> menu = new List<UserMenuItem>();

            menu.Add(new UserMenuItem
            {
                Name = "Home",
                DisplayName = "Home",
                Order = 0,
                Url = "/"
            });

            menu.Add(new UserMenuItem
            {
                Name = "Administration",
                DisplayName = "Administration",
                Order = 1,
                Url = "#",
                Items = new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name = "MembershipTypes",
                        DisplayName = "Membership Types",
                        Order = 0,
                        Url = "/MembershipTypes/"
                    },
                    new UserMenuItem
                    {
                        Name = "InventoryUnits",
                        DisplayName = "Inventory Units",
                        Order = 1,
                        Url = "/MembershipTypes/"
                    },
                    new UserMenuItem
                    {
                        Name = "EquipmentTypes",
                        DisplayName = "Equipment Types",
                        Order = 2,
                        Url = "/Equipment/"
                    },
                    new UserMenuItem
                    {
                        Name = "EquipmentInventory",
                        DisplayName = "Equipment Inventory",
                        Order = 3,
                        Url = "/EquipmentInventory/"
                    },
                    new UserMenuItem
                    {
                        Name = "UserManagement",
                        DisplayName = "Users",
                        Order = 4,
                        Url = "/Users/"
                    }
                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Store",
                DisplayName = "Store",
                Order = 2,
                Url = "#",
                Items = new List<UserMenuItem>
                {
                    new UserMenuItem
                    {
                        Name = "Shopping",
                        DisplayName = "Shopping",
                        Order = 0,
                        Url = "/Shopping/",
                    },
                    new UserMenuItem
                    {
                        Name = "ProductInventory",
                        DisplayName = "Product Inventory",
                        Order = 1,
                        Url = "/ProductInventory/",
                    },
                    new UserMenuItem
                    {
                        Name = "ProducTypes",
                        DisplayName = "Produc Types",
                        Order = 2,
                        Url = "/ProducTypes/",
                    },
                    new UserMenuItem
                    {
                        Name = "ProductCategories",
                        DisplayName = "Product Categories",
                        Order = 3,
                        Url = "/ProductCategories/",
                    }
                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Members",
                DisplayName = "Members",
                Order = 3,
                Url = "#",
                Items = new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name = "MemberManager",
                        DisplayName = "Managment",
                        Order = 0,
                        Url = "/Members/"
                    },
                    new UserMenuItem
                    {
                        Name = "MembershipRenewal",
                        DisplayName = "Membership Renewal",
                        Order = 1,
                        Url = "/Members/Renewal/"
                    },
                    new UserMenuItem
                    {
                        Name = "CheckIn",
                        DisplayName = "CheckIn",
                        Order = 2,
                        Url = "/Attendance/MemberIn/"
                    },
                    new UserMenuItem
                    {
                        Name = "CheckOut",
                        DisplayName = "CheckOut",
                        Order = 3,
                        Url = "/Attendance/MemberOut/"
                    }
                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Invoicing",
                DisplayName = "Invoicing",
                Order = 4,
                Url = "#",
                Items = new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name = "Invoice",
                        DisplayName = "Generate Invoice",
                        Order = 0,
                        Url = "/Invoicing/GenerateInvoice/"
                    }
                }
            });

            menu.Add(new UserMenuItem
            {
                Name = "Reports",
                DisplayName = "Reports",
                Order = 5,
                Url = "#",
                Items = new List<UserMenuItem>()
                {
                    new UserMenuItem
                    {
                        Name = "NewMembersReport",
                        DisplayName = "New Members",
                        Order = 0,
                        Url = "/Reports/NewMembers/"
                    },
                    new UserMenuItem
                    {
                        Name = "AttendanceReport",
                        DisplayName = "Attendance",
                        Order = 1,
                        Url = "/Reports/Attendance/"
                    },
                    new UserMenuItem
                    {
                        Name = "MembershipRenewalReport",
                        DisplayName = "Membership Renewal",
                        Order = 2,
                        Url = "/Reports/MembershipRenewal/"
                    }
                }
            });

            return menu;
        }
    }
}
