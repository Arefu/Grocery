using GroceryList.Utility;
using GroceryList.ViewModels;
using System.Diagnostics;

namespace GroceryList;

public partial class MyShoppingListPage : ContentPage
{
    private readonly Guid _shoppingListId;

    public MyShoppingListPage(MyShoppingLists_ViewModel.Shopping_List_Entry list)
    {
        InitializeComponent();
        _shoppingListId = list.Id;
    }
    public MyShoppingListPage()
    {
        InitializeComponent();
        _shoppingListId = Guid.NewGuid();
    }
    public void SearchBar_UserHasSearchedForItem(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue.Length > 3)
        {
            try
            {
                var Context = BindingContext as ItemSearcher_ViewModel;
                Context?.PerformSearchAsync(e.NewTextValue);
                Debug.WriteLine(ProductsReturnedFromSearch.SelectedItem);
            }
            catch
            {
                Debug.WriteLine("Failure in SearchBar_UserHasSearchedForItem (Context is NULL?)");
            }
        };

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

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        var Context = (Org.OpenAPITools.Model.SearchForProduct200ResponseProductsInner)ProductsReturnedFromSearch.SelectedItem;
        Debug.WriteLine(Context.Name);
    }
}
