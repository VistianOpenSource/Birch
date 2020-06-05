using System;
using System.Collections.Generic;
using System.Text;
using Birch.Environment;

namespace Birch.Hosts
{
    public class Environment<TPlatform> where TPlatform:class,new()
    {
        public static TPlatform Platform { get; } = new TPlatform();


    }
}
