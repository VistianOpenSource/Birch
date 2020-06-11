using Birch.Collections;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Metrics;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace Birch.Hosts
{
    /// <summary>
    /// Static class containing the common settings used.
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Settings for the logging
        /// </summary>

        public static void Logging(ILogger logger)
        {
            Diagnostics.Logging.Set(logger);
        }

        /// <summary>
        /// Settings for the default primary collection comparer.
        /// </summary>
        public static void PrimaryCollectionComparer(ICollectionComparer<IPrimitive> comparer)
        {
            PrimitiveCollectionComparer.SetDefault(comparer);
        }
        /// <summary>
        /// Settings for any logging rules.
        /// </summary>
        public static void LoggingRules(LoggingRulesList settings)
        {
            Diagnostics.LoggingRules.SetRules(settings);
        }

        /// <summary>
        /// Setup of layout metrics
        /// </summary>
        /// <param name="settings"></param>
        public static void LayoutMetrics(LayoutCompletedHandler settings)
        {
            Metrics.LayoutMetrics.Enabled = settings != null;
            if (settings != null)
            {
                Metrics.LayoutMetrics.LayoutCompleted += settings;
            }
        }

        /// <summary>
        /// Specify the transactional model to be used.
        /// </summary>
        /// <param name="model"></param>
        /// <remarks>
        /// Typically you wouldn't need to do this at all.</remarks>
        public static void TransactionModel(ITransactionModel model)
        {
            Birch.Transactions.TransactionModel.Current = model??new Threaded();
        }


    }
}