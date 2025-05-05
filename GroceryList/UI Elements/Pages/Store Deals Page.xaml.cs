using GroceryList.ViewModels;

namespace GroceryList
{

	public partial class StoreDealsPage : ContentPage
	{
		public StoreDealsPage()
		{
			InitializeComponent();
			var Context = (BindingContext as SelectStore_ViewModel);
			Context?.GetStoresAsync();
		}
    }
}