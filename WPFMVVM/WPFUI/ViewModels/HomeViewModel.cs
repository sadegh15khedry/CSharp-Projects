using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI.Models;

namespace WPFUI.ViewModels;

class HomeViewModel : Screen
{
    public BindableCollection<ShopingItem> Items { get; set; }
    
    public HomeViewModel()
    {
        Items = new BindableCollection<ShopingItem>();
        
        ShopingItem item = new ShopingItem(1,"phone",3000,"this is a phone");
        Items.Add(item);
        item = new ShopingItem(2, "laptop", 3000, "this is a phone");
        Items.Add(item);
        item = new ShopingItem(3, "Gpu", 3000, "this is a phone");
        Items.Add(item);
    }



}
