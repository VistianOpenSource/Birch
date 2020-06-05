using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CodedUIExperiment.Models;
using CodedUIExperiment.Views;
using CodedUIExperiment.ViewModels;
using Xamarin.Forms.Internals;

namespace CodedUIExperiment.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [Preserve(AllMembers = true)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Item)layout.BindingContext;
            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            // can we disable add item until shown ?
            //AddToolbar.
            //AddToolbar.
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.IsBusy = true;
        }
    }

    public interface IPrimitiveComponent
    {

    }

    public interface IViewElementHolder:INotifyPropertyChanged
    {
        IPrimitiveComponent  ViewElement { get; set; }
    }

    public class ViewElementHolder : IViewElementHolder
    {
        private IPrimitiveComponent _viewElement;

        public ViewElementHolder(IPrimitiveComponent viewElement)
        {
            _viewElement = viewElement;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public IPrimitiveComponent ViewElement
        {
            get => _viewElement;
            set
            {
                if (_viewElement != value)
                {
                    _viewElement = value;
                    PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(ViewElement)));
                }
            }
        }
    }


    // so we will assume its an observable collection...


    public static class BindableHelpers
    {

    }


    public class ViewElementDataTemplate:DataTemplate
    {
        // so, this function, how do 

        public ViewElementDataTemplate(Type type) : base(() => Setup(type))
        {
        }

        private static BindableObject Setup(Type type)
        {
            // we create the type of object - , in this case, we would be using a transaction like rv

            // this is the creation phase, here we would need to transaction for actually creating the view...

            // this is where the initial shadow view is created...

            // we need to create the initial shadow view here...

            var bo = (BindableObject) Activator.CreateInstance(type);

            var dtbh = new DataTemplateBindingHelper(bo);
            
            bo.BindingContextChanged += (sender, args) => dtbh.OnBindingContextChanged(bo);

            return bo;
        }
    }

    public class ViewElementDataTemplateSelector : DataTemplateSelector
    {
        // we need a cache of the type to the ViewElementDataTemplate
        private Dictionary<Type,ViewElementDataTemplate> _cache = new Dictionary<Type, ViewElementDataTemplate>();


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            // item must be a IViewElementHolder

            var veh = item as IViewElementHolder;
            var targetType = veh.ViewElement.GetType();

            if (!_cache.TryGetValue(targetType, out var template))
            {
                template = new ViewElementDataTemplate(targetType);
            }

            return template;
        }
    }
}