
using GroceryList.Types;
using System.Collections.ObjectModel;

namespace GroceryList
{
    static class State
    {
        internal static ObservableCollection<Shopping_List_Entry> Shopping_Lists { get; set; } = new();


    }
}
