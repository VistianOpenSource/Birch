using System;
using System.Reactive.Disposables;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Shadows;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace MVU_Experiment.RV
{
    /// <summary>
    /// Conduit to a <see cref="ShadowRecyclerViewAdapter"/> from a collection update.
    /// </summary>
    /// <remarks>
    /// The methods to perform updates will have come from a collection update operation, meaning that a transaction will be currently active, thus all changes
    /// to the underlying <see cref="ShadowRecyclerViewAdapter"/> need to be made using that transaction.
    /// </remarks>
    public class RecyclerViewAdapterConnector:IDataConnector<IPrimitive>
    {
        /// <summary>
        /// Static to determine whether we should log or not
        /// </summary>
        private static readonly bool IsLoggingEnabled = LoggingRules.For(Categories.Collections).Any;

        /// <summary>
        /// The actual adapter.
        /// </summary>
        public ShadowRecyclerViewAdapter Adapter { get;  }

        public RecyclerViewAdapterConnector(AndroidContext context)
        {
            Adapter = new ShadowRecyclerViewAdapter(context);
        }

        public void Insert(int index, IPrimitive item)
        {
            if (IsLoggingEnabled)
            {
                Logging.Instance.LogInformation("RecyclerViewAdapterConnector:Insert {index},item:{item}",index,item);
            }
            Transaction.Current.Add(() =>
            {
                Adapter.Insert(index, item);
            });
        }

        public void Move(int oldIndex, int newIndex)
        {
            if (IsLoggingEnabled)
            {
                Logging.Instance.LogInformation("RecyclerViewAdapterConnector:Move {from} to {to}",oldIndex,newIndex);
            }

            Transaction.Current.Add(() => { Adapter.Move(oldIndex, newIndex); });
        }

        public void Remove(int index,IPrimitive item)
        {
            if (IsLoggingEnabled)
            {
                Logging.Instance.LogInformation("RecyclerViewAdapterConnector:Remove {index}",index);
            }
            Transaction.Current.Add(() => {Adapter.Remove(index);});
        }

       
        public void Update(int index, IPrimitive current, IPrimitive next)
        {
            if (IsLoggingEnabled)
            {
                Logging.Instance.LogInformation("RecyclerViewAdapterConnector:Update {index},from:{current} to {next}",index,current,next);
            }

            Transaction.Current.Add(() => { Adapter.Update(index, current, next); });
        }
    }
}