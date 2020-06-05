using System.Text;
using Birch.Metrics.Layout;

namespace Birch.Hosts
{
    /// <summary>
    /// Base class for a <see cref="HostEnvironmentBuilder"/>
    /// </summary>
    public abstract class HostEnvironmentBuilder : IEnvironmentBuilderComponent<HostEnvironment>
    {
        public abstract void Apply(HostEnvironment settings);
    }
}
