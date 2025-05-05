using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GroceryList.ViewModels
{
    class SelectStore_ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Org.OpenAPITools.Model.GetStores200Response _StoresResponse;
        public Org.OpenAPITools.Model.GetStores200Response StoresResponse
        {
            get => _StoresResponse;
            set
            {
                if (_StoresResponse != value)
                {
                    _StoresResponse= value;
                    NotifyPropertyChanged(nameof(_StoresResponse));
                }
            }
        }

        private ObservableCollection<Org.OpenAPITools.Model.GetStores200ResponseStoresInner> _Stores;
        public ObservableCollection<Org.OpenAPITools.Model.GetStores200ResponseStoresInner> Stores
        {
            get { return _Stores; }
            set
            {
                if (_Stores != value)
                {
                    var Region = SelectedRegion == "South Island" ? "SI" : "NI";

                    _Stores = value;
                    _Regions = Stores.Select(store => store.Region).Where(region => region == "NI" || region == "SI").Distinct().Select(region => region == "NI" ? "North Island" : "South Island").ToList();
                    _FilteredStores = new(Stores.Where(Store => Store.Region == Region));

                    NotifyPropertyChanged(nameof(Stores));
                    NotifyPropertyChanged(nameof(Regions));
                    NotifyPropertyChanged(nameof(FilteredStores));
                }
            }
        }

        private List<string> _Regions = new();
        public List<string> Regions
        {
            get => _Regions;
            set
            {
                _Regions = value;
                NotifyPropertyChanged(nameof(Regions));
            }
        }
        
        public string _SelectedRegion;
        public string SelectedRegion
        {
            get 
            { 
                return _SelectedRegion; 
            }
            set
            {
                if (value != _SelectedRegion)
                {
                    _SelectedRegion = value;

                    var Region = SelectedRegion == "South Island" ? "SI" : "NI";
                    _FilteredStores = new(Stores.Where(Store => Store.Region == Region));

                    NotifyPropertyChanged(nameof(FilteredStores));
                    NotifyPropertyChanged(nameof(SelectedRegion));
                }
            }
        }

        private ObservableCollection<Org.OpenAPITools.Model.GetStores200ResponseStoresInner> _FilteredStores;
        public ObservableCollection<Org.OpenAPITools.Model.GetStores200ResponseStoresInner> FilteredStores
        {
            get 
            {
                var Region = SelectedRegion == "South Island" ? "SI" : "NI";
                return new(Stores.Where(Store => Store.Region == Region));
            }
            set
            {
                var Region = SelectedRegion == "South Island" ? "SI" : "NI";
                _FilteredStores = new(value.Where(Store => Store.Region == Region));
                NotifyPropertyChanged(nameof(FilteredStores));
            }
        }


        internal async void GetStoresAsync()
        {
            StoresResponse = await State.ShopApi.GetStoresAsync();
            Stores = new ObservableCollection<Org.OpenAPITools.Model.GetStores200ResponseStoresInner>(StoresResponse.Stores);
            SelectedRegion = State.PreferredRegion == "SI" || string.IsNullOrEmpty(State.PreferredRegion) ? "South Island" : "North Island";
        }


        public SelectStore_ViewModel()
        {

        }
    }

}
