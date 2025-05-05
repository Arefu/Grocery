using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GroceryList.ViewModels
{
    class ItemSearcher_ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _SearchedProduct;
        public string SearchedProduct
        {
            get => _SearchedProduct;
            set
            {
                if (_SearchedProduct != value)
                {
                    _SearchedProduct = value;
                    NotifyPropertyChanged(nameof(_SearchedProduct));
                    if (value.Length > 3)
                    {
                        PerformSearchAsync(SearchedProduct);
                    }
                }
            }
        }

        private Org.OpenAPITools.Model.SearchForProduct200Response _Products;
        public Org.OpenAPITools.Model.SearchForProduct200Response Products
        {
            get => _Products;
            set
            {
                if (_Products != value)
                {
                    _Products = value;
                    NotifyPropertyChanged(nameof(_Products));
                }
            }
        }

        private ObservableCollection<Org.OpenAPITools.Model.SearchForProduct200ResponseProductsInner> _returnedProduct;
        public ObservableCollection<Org.OpenAPITools.Model.SearchForProduct200ResponseProductsInner> ReturnedProduct
        {
            get => _returnedProduct;
            set
            {
                if (_returnedProduct != value)
                {
                    _returnedProduct = value;
                    NotifyPropertyChanged(nameof(ReturnedProduct));
                }
            }
        }

        internal async void PerformSearchAsync(string Query)
        {
            Products = await State.ShopApi.SearchForProductAsync(State.PreferredStore, Query, []);
            ReturnedProduct = new ObservableCollection<Org.OpenAPITools.Model.SearchForProduct200ResponseProductsInner>(Products.Products);
        }

        public ItemSearcher_ViewModel()
        {
            _SearchedProduct = String.Empty;
            _Products = new Org.OpenAPITools.Model.SearchForProduct200Response();
            _returnedProduct = new ObservableCollection<Org.OpenAPITools.Model.SearchForProduct200ResponseProductsInner>();
        }
    }
}
