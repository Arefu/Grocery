using GroceryList.Types;
using GroceryList.Utility;
using System.Collections.ObjectModel;

namespace GroceryList;

public partial class ShoppingListsPage : ContentPage
{
    public ObservableCollection<Shopping_List_Entry> Shopping_Lists { get; set; } = new();
    public ShoppingListsPage()
    {
        InitializeComponent();
        Shopping_Lists = Save_and_Load.LoadShoppingListAsync().Result;
        State.Shopping_Lists = Shopping_Lists;
        BindingContext = this;
    }
  
    private async void OnClicked_AddShoppingList(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync(
            "New Shopping List",
            "Enter the name of the new shopping list:",
            "OK",
            "Cancel"
        );

        if (!string.IsNullOrWhiteSpace(result))
        {
            Shopping_List_Entry List = new Shopping_List_Entry()
            {
                Name = result,
                Created = DateTime.Now,
                LastModified = DateTime.Now,
                TotalItems = 0,
                Id = Guid.NewGuid(),
                Cost = 0
            };

            Shopping_Lists.Add(List);
        }

        await Save_and_Load.SaveShoppingListAsync(Shopping_Lists);
    }

    private async void OnTapped_ViewShoppingList(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Shopping_List_Entry shoppingList)
        {
            await Navigation.PushAsync(new ShoppingListViewPage(shoppingList));
        }
    }
}
