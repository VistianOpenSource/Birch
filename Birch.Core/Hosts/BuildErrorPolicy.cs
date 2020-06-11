using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Abstract base of <see cref="IBuildErrorPolicy"/>
    /// </summary>
    /// <typeparam name="TInstance"></typeparam>
    public abstract class BuildErrorPolicy<TInstance> : IBuildErrorPolicy where TInstance : BuildHostInstance
    {
        public void Handle(BuildHostInstance buildHostInstance, Exception exception)
        {
            // reset the host
            buildHostInstance.Reset();

            // and now create an error host and assign that to the build host
            var errorHost = new DefaultErrorHost<TInstance>(buildHostInstance,LayoutErrorFormat,exception,
                LayoutContext.Create(buildHostInstance.BuildOwner.ModelBag, buildHostInstance.HostEnvironment.LayoutResolver),buildHostInstance.HostEnvironment.HostSettings);

            buildHostInstance.SetHost(errorHost);
        }

        public abstract IElement LayoutErrorFormat(TInstance buildHostInstance, Exception exception);
    }
}
