using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Used for the creation of stateful containers 
    /// </summary>
    public class BuildEnvironment
    {
        /// <summary>
        /// Get the associated <see cref="BuildOwner"/>
        /// </summary>
        public BuildOwner BuildOwner { get;  }

        public BuildEnvironment(BuildOwner buildOwner)
        {
            BuildOwner = buildOwner;
        }

        /// <summary>
        /// For a <see cref="StatefulContainer{TModel}"/> register it within the <see cref="ModelBag"/>
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="statefulContainer"></param>
        /// <returns></returns>
        public BuildContext CreateContext<TModel>(IStatefulContainer<TModel> statefulContainer) 
        {
            var context =  BuildContext.Create(BuildOwner);

            BuildOwner.ModelBag.Register<IStatefulContainer<TModel>,TModel>(statefulContainer,context);

            return context;
        }
    }
}