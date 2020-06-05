using System.Diagnostics;
using Birch.Compose;
using Birch.Hosts;

namespace Birch.Components
{
    /// <summary>
    /// Base class for implementations of <see cref="IStatefulContainer"/>
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class StatefulContainer<TModel> : IStatefulContainer<TModel>,IInlineComposite
    {
        /// <summary>
        /// The associated <see cref="BuildContext"/>
        /// </summary>
        public BuildContext Context { get;  }

        /// <summary>
        /// Get the initial state this container has
        /// </summary>
        /// <returns></returns>
        public abstract TModel InitState();

        /// <summary>
        /// Create a stateful container
        /// </summary>
        /// <param name="environment"></param>
        protected StatefulContainer(BuildEnvironment environment)
        {
            Context = environment.CreateContext(this);
        }

        /// <summary>
        /// Perform the layout of this container.
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        public IPrimitive PerformLayout(LayoutContext layoutContext)
        {
            // Get the model to be used for the layout of this container
            var model = layoutContext.ModelBag.Get(this);

            return PerformLayout(layoutContext,model);
        }

        /// <summary>
        /// abstract method used for layout where the relevant model be passed in.
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected abstract IPrimitive PerformLayout(LayoutContext layoutContext,TModel model);

        /// <summary>
        /// Used for tidy up purposes.
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}