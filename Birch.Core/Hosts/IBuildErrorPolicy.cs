using System;
using Birch.Components;

namespace Birch.Hosts
{
    /// <summary>
    /// Specification of the error policy to be employed by build hosts.
    /// </summary>

    public interface IBuildErrorPolicy
    {
        void Handle(BuildHostInstance buildHostInstance,Exception exception);
    }
}