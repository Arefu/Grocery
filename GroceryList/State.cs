
using GroceryList.Types;
using GroceryList.ViewModels;
using Microsoft.IdentityModel.JsonWebTokens;
using System.Collections.ObjectModel;

namespace GroceryList
{
    static class State
    {
        internal static ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry> Shopping_Lists { get; set; } = new();
        internal static JsonWebToken _AccessToken;
        internal static Guid _RefreshToken;

        internal static Org.OpenAPITools.Api.UsersApi UsersApi { get; set; }
        internal static Org.OpenAPITools.Api.ShopApi ShopApi { get; set; }

        internal static Guid PreferredStore = Guid.Parse("8cd700ae-d96f-4761-bd7a-805d6b93536d");
        internal static string PreferredRegion = "SI";
    }
}
