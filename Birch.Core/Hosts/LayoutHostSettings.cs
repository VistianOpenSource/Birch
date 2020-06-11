using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Birch.Hosts
{
    /// <summary>
    /// Settings to be used by layout hosts
    /// </summary>
    public sealed class LayoutHostSettings
    {
        /// <summary>
        /// The task scheduler for the layout and compare phases
        /// </summary>
        public TaskScheduler Layout { get; }

        /// <summary>
        /// The task scheduler for the commit phase, generally the UI 
        /// </summary>
        public TaskScheduler Commit { get; }

        /// <summary>
        /// How the layout is performed, sync, async or a mixture
        /// </summary>
        public LayoutMode Mode { get; }

        public LayoutHostSettings(TaskScheduler layout, TaskScheduler commit, LayoutMode mode=LayoutMode.FirstSync)
        {
            Layout = layout;
            Commit = commit;
            Mode = mode;
        }

        /// <summary>
        /// Create default settings with the current context being used as the commit <see cref="TaskScheduler"/>
        /// </summary>
        public static LayoutHostSettings Default => new LayoutHostSettings(TaskScheduler.Default,TaskScheduler.FromCurrentSynchronizationContext());
    }

    
}
