using System;
using Birch.Components;

namespace Birch.Compose
{
    /// <summary>
    /// Context from which the shadow mapping phase is executed with.
    /// </summary>
    public class TransactionContext:IShadowContext
    {
        /// <summary>
        /// The factory responsible for resolving a <see cref="IShadowMapper"/> from a <see cref="IPrimitive"/>
        /// </summary>
        public ShadowMapperFactory MapperFactory { get; set; }

        /// <summary>
        /// The associated <see cref="BuildOwner"/>
        /// </summary>
        public BuildOwner BuildOwner { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapperFactory"></param>
        /// <param name="buildOwner"></param>
        public TransactionContext(ShadowMapperFactory mapperFactory,BuildOwner buildOwner)
        {
            MapperFactory = mapperFactory;
            BuildOwner = buildOwner;
        }

        /// <summary>
        /// Cloning constructor
        /// </summary>
        /// <param name="transactionContext"></param>
        protected TransactionContext(TransactionContext transactionContext)
        {
            MapperFactory = transactionContext.MapperFactory;
            BuildOwner = transactionContext.BuildOwner;
        }
    }
}