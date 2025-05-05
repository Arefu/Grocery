using GroceryList.Types;
using GroceryList.Utility;
using GroceryList.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace GroceryList;

public partial class ShoppingListsPage : ContentPage
{
    
    public ShoppingListsPage()
    {
        InitializeComponent();
        var Context = (BindingContext as MyShoppingLists_ViewModel);
        Context.Shopping_Lists = Save_and_Load.LoadShoppingListAsync().Result;

        State.Shopping_Lists = Context.Shopping_Lists;
    }
  
    private async void OnClicked_AddShoppingList(object sender, EventArgs e)
    {
        var Context = (BindingContext as MyShoppingLists_ViewModel);
        string result = await DisplayPromptAsync(
            "New Shopping List",
            "Enter the name of the new shopping list:",
            "OK",
            "Cancel"
        );

        if (!string.IsNullOrWhiteSpace(result))
        {
            MyShoppingLists_ViewModel.Shopping_List_Entry List = new MyShoppingLists_ViewModel.Shopping_List_Entry()
            {
                Name = result,
                Created = DateTime.Now,
                LastModified = DateTime.Now,
                TotalItems = 0,
                Id = Guid.NewGuid(),
                Cost = 0
            };

            Context.AddToShoppingList(List);
        }

        await Save_and_Load.SaveShoppingListAsync(Context.Shopping_Lists);
    }
    private void OnTapped(object sender, EventArgs e)
    {
        Debug.WriteLine("Tapped!");
    }
    private async void OnTapped_ViewShoppingList(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is MyShoppingLists_ViewModel.Shopping_List_Entry shoppingList)
        {
            await Navigation.PushAsync(new MyShoppingListPage(shoppingList));
        }
    }
}
