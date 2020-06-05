using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birch.Compose;
using Foundation;
using UIKit;

namespace Birch.iOS.Compose
{
    public class IosContext:TransactionContext
    {
        public IosContext(ShadowMapperFactory mapperFactory,BuildOwner buildOwner) : base(mapperFactory,buildOwner)
        {
        }
    }
}