using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.Models;

class ShopingItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

    public string Description { get; set; }

    

    public ShopingItem(int id, string name, int price, string description)
    {
        Id = id;
        Name = name;
        Price = price;
        Description = description;
    }
}
