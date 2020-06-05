using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CodedUIExperiment.Models;
using CodedUIExperiment.Views;

namespace CodedUIExperiment.ViewModels
{

    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());


            AddItemCommand = new Command(async () =>
            {
                Inactive = false;
                //await Items.Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
                await Task.Delay(TimeSpan.FromSeconds(5));
                Inactive = true;

            }, () => this.Inactive);

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        public Command AddItemCommand { get; private set; }

        private bool _inactive = true;

        public bool Inactive { 
            get => _inactive;
            set {
                if (_inactive != value) {
                    _inactive = value;
                    AddItemCommand.ChangeCanExecute();
                    OnPropertyChanged ();
                }
            }
        }


        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}