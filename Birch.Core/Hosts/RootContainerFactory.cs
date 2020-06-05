using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Delegate to create the root <see cref="IStatefulContainer"/> given the build environment and layout context
    /// </summary>
    /// <param name="buildEnvironment"></param>
    /// <param name="layoutContext"></param>
    /// <returns></returns>
    public delegate IStatefulContainer RootContainerFactory(BuildEnvironment buildEnvironment, LayoutContext layoutContext);
}
