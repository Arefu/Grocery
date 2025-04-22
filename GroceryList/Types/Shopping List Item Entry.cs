using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList.Types
{
    public class Shopping_List_Item_Entry
    {
        public string Name { get; set; }
        public DateTime LastPurchased { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
    }
}
