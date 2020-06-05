using System.Reactive.Concurrency;

namespace Birch.Compose
{
    /// <summary>
    /// Layout options for the layout engine of build hosts.
    /// </summary>
    public class LayoutEngineOptions
    {
        /// <summary>
        /// Get the scheduler to be used for the layout phase
        /// </summary>
        public IScheduler LayoutScheduler { get; }

        /// <summary>
        /// Get the scheduler to be used during the commit phase of layout
        /// </summary>
        public IScheduler CommitScheduler { get; }

        /// <summary>
        /// When performing layouts should we essentially only pass the state reflecting the current mutation level
        /// to the commit phase.
        /// </summary>
        public bool IgnoreOldMutations { get; }

        public LayoutEngineOptions(IScheduler layoutScheduler,IScheduler commitScheduler,bool ignoreOldMutations=true)
        {
            LayoutScheduler = layoutScheduler??Scheduler.Default;
            CommitScheduler = commitScheduler;
            IgnoreOldMutations = ignoreOldMutations;
        }
    }
}