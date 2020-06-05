using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Metrics.Layout;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Birch.Hosts
{
    /// <summary>
    /// The environment under which build hosts operate.
    /// </summary>
    public sealed class HostEnvironment
    {
        /// <summary>
        /// Our Shadow factory
        /// </summary>
        public ShadowMapperFactory ShadowMapperFactory { get; set; }

        /// <summary>
        /// The error policy for handling errors during layout and commit
        /// </summary>
        public IBuildErrorPolicy ErrorPolicy { get; set; }

        /// <summary>
        /// The 'sink' for layout metrics output.
        /// </summary>
        public ILayoutMonitor LayoutMonitor { get; set; }

        /// <summary>
        /// Get the <see cref="LayoutResolver"/> used to resolving Layouts for <see cref="IComposite"/> instances
        /// </summary>
        public LayoutResolver LayoutResolver { get; set; }

        /// <summary>
        /// The options used for the layout engine
        /// </summary>
        public LayoutEngineOptions LayoutEngineOptions { get; set; }

        public HostEnvironment(ShadowMapperFactory shadowMapperFactory, IBuildErrorPolicy errorPolicy, ILayoutMonitor layoutMonitor,
            LayoutResolver layoutResolver, LayoutEngineOptions layoutEngineOptions)
        {
            ShadowMapperFactory = shadowMapperFactory;
            ErrorPolicy = errorPolicy;
            LayoutMonitor = layoutMonitor;
            LayoutResolver = layoutResolver;
            LayoutEngineOptions = layoutEngineOptions;
        }
    }
}