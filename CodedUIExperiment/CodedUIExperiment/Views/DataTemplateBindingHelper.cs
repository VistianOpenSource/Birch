using System.ComponentModel;
using Xamarin.Forms;

namespace CodedUIExperiment.Views
{
    public class DataTemplateBindingHelper
    {
        private readonly BindableObject _bindableObject;

        private IViewElementHolder _current;

        private IViewElementHolder _next;


        public DataTemplateBindingHelper(BindableObject bindableObject)
        {
            _bindableObject = bindableObject;
        }

        public void OnBindingContextChanged(BindableObject bindableObject)
        {
            var next = bindableObject.BindingContext as IViewElementHolder;

            if (_current != null)
            {
                // now here we are assuming that we are going to have an element such that when it changes we will automatically
                // update the UI... I'm not sure this is the case...

                _current.PropertyChanged -= Current_PropertyChanged;
            }

            next.PropertyChanged += Current_PropertyChanged;

            // we now need to , update the shadow with the backing view
            // BUT we need to remember that the shadows could have some details contained within them related to
            // overall state for the associated view element so perhaps we need a list of shadows ?
        }

        public void Current_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(IViewElementHolder.ViewElement))
            {
                var next = (sender as IViewElementHolder);

                // so some updating here...

                _current = next;
            }
        }
    }
}