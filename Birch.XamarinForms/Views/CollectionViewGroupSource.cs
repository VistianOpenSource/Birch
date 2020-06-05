using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Birch.Components;

namespace Birch.Views
{
    public class CollectionViewGroupSource:ObservableCollection<PrimitiveHolder>
    {
        private readonly PrimitiveHolder _groupHeader;

        public CollectionViewGroupSource(IEnumerable<PrimitiveHolder> collection):base(collection)
        {
            _groupHeader = new PrimitiveHolder();
        }

        public PrimitiveHolder GroupPrimitiveHolder => _groupHeader;

        public IPrimitive GroupHeader 
        {
            get => _groupHeader.Primitive;
            set => _groupHeader.Primitive = value;
        }

        public override string ToString()
        {
            return $"Children:{this.Count}";
        }
    }
}