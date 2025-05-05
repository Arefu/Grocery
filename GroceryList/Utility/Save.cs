using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using GroceryList.Types;
using GroceryList.ViewModels;

namespace GroceryList.Utility
{
    static  class Save_and_Load
    {
        private const string FileName = "shopping_list.json";

        public static async Task<ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry>> LoadShoppingListAsync()
        {
            try
            {
                string filePath = Get_SpecialFolderPathForCurrentPlatform("GroceryList");

                if (!File.Exists(filePath))
                {
                    return new ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry>();
                }

                string json =  File.ReadAllText(filePath);
                var Json = JsonSerializer.Deserialize<ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry>>(json) ?? new ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry>();
                return Json;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading shopping list: {ex.Message}");
                return new ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry>();
            }
        }

        public static async Task SaveShoppingListAsync(ObservableCollection<MyShoppingLists_ViewModel.Shopping_List_Entry> shoppingLists)
        {
            try
            {
                string filePath = Get_SpecialFolderPathForCurrentPlatform("GroceryList");
                string json = JsonSerializer.Serialize(shoppingLists);
                await File.WriteAllTextAsync(filePath, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving shopping list: {ex.Message}");
            }
        }

        private static string Get_SpecialFolderPathForCurrentPlatform()
        {
#if ANDROID
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
#elif WINDOWS
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#else
            throw new PlatformNotSupportedException("Platform not supported");
#endif
            var Final = Path.Combine(path, FileName);

            if (Directory.Exists(Final) == false)
                Directory.CreateDirectory(new FileInfo(Final).Directory.FullName);
            return Final;
        }
        private static string Get_SpecialFolderPathForCurrentPlatform(string AppendedWith)
        {
#if ANDROID
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
#elif WINDOWS
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#else
            throw new PlatformNotSupportedException("Platform not supported");
#endif
            var Final = Path.Combine(path, AppendedWith, FileName);

            if (Directory.Exists(Final) == false)
                Directory.CreateDirectory(new FileInfo(Final).Directory.FullName);
            return Final;
        }
    }
}
