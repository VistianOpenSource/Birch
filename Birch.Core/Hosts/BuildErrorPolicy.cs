using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;

namespace Birch.Hosts
{
    /// <summary>
    /// Abstract base of <see cref="IBuildErrorPolicy"/>
    /// </summary>
    /// <typeparam name="TInstance"></typeparam>
    public abstract class BuildErrorPolicy<TInstance> : IBuildErrorPolicy where TInstance:BuildHostInstance
    {
        public IElement LayoutErrorFormat(BuildHostInstance buildHostInstance, Exception exception)
        {
            return LayoutErrorFormat((TInstance) buildHostInstance, exception);
        }

        public void FatalError(BuildHostInstance buildHostInstance, Exception exception)
        {
            FatalError((TInstance) buildHostInstance, exception);
        }

        protected abstract IElement LayoutErrorFormat(TInstance hostInstance, Exception exception);

        protected abstract void FatalError(TInstance hostInstance, Exception exception);
    }
}
