using GroceryList.Types;
using GroceryList.Utility;

namespace GroceryList;

public partial class ShoppingListViewPage : ContentPage
{
    private readonly Guid _shoppingListId;

    public ShoppingListViewPage(Shopping_List_Entry list)
    {
        InitializeComponent();
        _shoppingListId = list.Id; 
    }


    public async void OnTextCompltedInInput_UserHasFinishedSearchingForItem(object sender, EventArgs e)
    {
       
    }

    public async void OnTextChangedInInput_UserHasSearchedForItem(object sender, TextChangedEventArgs e)
    {
       
    }
    public async void OnClicked_DeleteShoppingList(object sender, EventArgs e)
    {
        var result = await DisplayAlert("Delete Shopping List", "Are you sure you want to delete this shopping list?", "Yes", "No");
        if (result)
        {
            var shoppingListToRemove = State.Shopping_Lists.FirstOrDefault(list => list.Id == _shoppingListId);
            if (shoppingListToRemove != null)
            {
                State.Shopping_Lists.Remove(shoppingListToRemove);
            }

            await Save_and_Load.SaveShoppingListAsync(State.Shopping_Lists);

            await Navigation.PopAsync();
        }
    }
}
