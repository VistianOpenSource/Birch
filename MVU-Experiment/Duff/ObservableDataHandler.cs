using System;
using System.Collections.Generic;
using System.Reactive.Linq;

namespace MVU_Experiment.Duff
{
    //public class ObservableDataHandler<TContext,TItem> : IBackingDataHandler<TContext,TItem> where TItem : class 
    //{
    //    private readonly IObservable<IViewComponent2> _observable;
    //    private readonly IDataConnector<TContext,IPrimitiveComponent> _connector;

    //    private MutationMap _mutationMap;
    //    private IDisposable _disposable;
    //    private List<IViewComponent2> _backingStore = new List<IViewComponent2>();

    //    public ObservableDataHandler(IObservable<IViewComponent2> observable, IDataConnector<TContext,IPrimitiveComponent> connector)
    //    {
    //        _observable = observable;
    //        _connector = connector;
    //    }

    //    public IDisposable Connect(TContext context)
    //    {
    //        var connection = _connector.Connect(context);

    //        //_mutationMap = new MutationMap(context.BuildOwner.ModelBag);

    //        return _observable.ObserveOn(HandlerScheduler.MainThreadScheduler). // need to listen on main scheduler
    //            Do(Add).Subscribe();
    //    }

    //    private void Add(IViewComponent2 component)
    //    {
    //        if (component.IsStateful())
    //        {
    //            _mutationMap.Update(component);
    //        }

    //        var lc = LayoutContext2.CreateFor(component);

    //        var primitive = component.Layout(lc); 
    //        _connector.Add(primitive);
    //        _backingStore.Add(component);
    //    }

    //    private void Update(int index, IViewComponent2 component)
    //    {
    //        var lc = LayoutContext2.CreateFor(component);
    //        //_connector[index] = component;
    //        var primitive = component.Layout(lc); 
    //        _connector.Replace(index,primitive);

    //        _backingStore[index] = component;
    //    }

    //    public void Update(TContext context,BasePrimitiveComponent<TItem> current, BasePrimitiveComponent<TItem> next)
    //    {
    //        for (var index = 0; index < _backingStore.Count; index++)
    //        {
    //            var component = _backingStore[index];

    //            if (component.IsStateful())
    //            {
    //                // its a stateful container, it could have been updated...
    //                // we need to compare the mutation id when the last item was grabbed 
    //                // to that which it is now...
    //                if (_mutationMap.IsUpdated(component))
    //                {
    //                    // this tells the backing store to propogate that this item has changed

    //                    Update(index,component);
    //                }
    //            }
    //        }
    //    }
    //}
}