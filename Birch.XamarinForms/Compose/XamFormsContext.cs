using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Compose
{
    public class XamFormsContext:TransactionContext
    {
        public XamFormsContext(ShadowMapperFactory factory, BuildOwner buildOwner) : base(factory, buildOwner)
        {
        }

        protected XamFormsContext(TransactionContext transactionContext) : base(transactionContext)
        {
        }
    }
}
