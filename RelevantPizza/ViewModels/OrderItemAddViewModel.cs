using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelevantPizza.Models;

namespace RelevantPizza.ViewModels
{
    public class OrderItemAddViewModel
    {
        public OrderItemType Type { get; set; }
        public decimal Price { get; set; }
        public int InventoryID { get; set; }
        public InventoryItemType InventoryItemType { get; set; }
        IEnumerable<InventoryItem> OrderItemDetails { get; set; }
        public IEnumerable<SelectListItem> InventoryList { get; set; }
    }
}
