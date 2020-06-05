using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Birch.Views
{
    public class ListGroupChildrenSource:ObservableCollection<PrimitiveHolder>
    {
        private string _shortName;

        private string _longName;

        public ListGroupChildrenSource(IEnumerable<PrimitiveHolder> collection):base(collection)
        {
        }

        public string ShortName
        {
            get => _shortName;
            set
            {
                _shortName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(ShortName)));
            }
        }

        public string LongName
        {
            get => _longName;
            set
            {
                _longName = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(LongName)));
            }
        }

        public override string ToString()
        {
            return $"Short:{ShortName} Long:{LongName}  Children:{this.Count}";
        }
    }
}