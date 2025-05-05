using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GroceryList.ViewModels
{
    public class MyShoppingLists_ViewModel : INotifyPropertyChanged
    {
        public class Shopping_List_Entry : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler? PropertyChanged;
            protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            private string _Name;
            private Guid _Id;
            private DateTime _Created;
            private DateTime _LastModified;
            private int _TotalItems;
            private int _Cost;

            public string Name
            {
                get => _Name;

                set
                {
                    if (_Name != value)
                    {
                        _Name = value;
                        NotifyPropertyChanged(nameof(_Name));
                    }
                }
            }
            public Guid Id
            {
                get => _Id;
                set
                {
                    if (_Id != value)
                    {
                        _Id = value;
                        NotifyPropertyChanged(nameof(_Id));
                    }
                }
            }
            public DateTime Created
            {
                get => _Created; set
                {
                    if (_Created != value)
                    {
                        _Created = value;
                        NotifyPropertyChanged(nameof(_Created));
                    }
                }
            }
            public DateTime LastModified
            {
                get => _LastModified; set
                {
                    if (_LastModified != value)
                    {
                        _LastModified = value;
                        NotifyPropertyChanged(nameof(_LastModified));
                    }
                }
            }
            public int TotalItems
            {
                get => _TotalItems; set
                {
                    if (_TotalItems != TotalItems)
                        _TotalItems = TotalItems;
                    NotifyPropertyChanged(nameof(_TotalItems));
                }
            }
            public int Cost
            {
                get => _Cost; set
                {
                    if (_Cost != value)
                        _Cost = value;
                    NotifyPropertyChanged(nameof(_Cost));
                }
            }

            public Shopping_List_Entry()
            {
                _Name = string.Empty;
                _Id = Guid.Empty;
                _Created = DateTime.MinValue;
                _LastModified = DateTime.MaxValue;
                _TotalItems = 0;
                _Cost = 0;
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Shopping_List_Entry> _Shopping_Lists;
        public ObservableCollection<Shopping_List_Entry> Shopping_Lists
        {
            get => _Shopping_Lists; set
            {
                if (_Shopping_Lists != value)
                    _Shopping_Lists = value;
                NotifyPropertyChanged(nameof(_Shopping_Lists));
                NotifyPropertyChanged(nameof(Shopping_Lists));
            }
        }

        public void AddToShoppingList(Shopping_List_Entry Entry)
        {
            Shopping_Lists.Add(Entry);
            NotifyPropertyChanged(nameof(Shopping_Lists));
            NotifyPropertyChanged(nameof(_Shopping_Lists));
        }

        public MyShoppingLists_ViewModel()
        {
            _Shopping_Lists = [];
        }
    }
}
