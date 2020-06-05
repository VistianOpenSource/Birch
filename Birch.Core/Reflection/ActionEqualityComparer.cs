using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Birch.Reflection
{
    /// <summary>
    /// Equality comparer for actions with ability to compare either
    /// using the actual actions or its type.
    /// </summary>
    /// <remarks>
    /// The code can look to try and utilize the fact that invoked methods are
    /// anonymous and so are compared by type instead of instance.
    /// </remarks>
    public class ActionEqualityComparer:BaseActionEqualityComparer,IEqualityComparer<Action>
    {
        private static readonly IEqualityComparer<Action> DefaultEqualityComparer = EqualityComparer<Action>.Default;

        public ActionEqualityComparer()
        {
        }

        public bool Equals(Action x, Action y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return true;
            }

            if (ReferenceEquals(x, y))
            {
                return true;
            }

            return (CompareAnonymousByType && AreAnonymous(x.Method, y.Method)) ? (x.GetType() == y.GetType()):DefaultEqualityComparer.Equals(x,y);        }

        public int GetHashCode(Action obj)
        {
            return CompareAnonymousByType && obj.Method.IsAnonymous() ? obj.GetType().GetHashCode() : obj.GetHashCode();
        }
    }

    /// <summary>
    /// Equality comparer for actions with a single parameter ability to compare either
    /// using the actual actions or its type.
    /// </summary>
    /// <remarks>
    /// The code can look to try and utilize the fact that invoked methods are
    /// anonymous and so are compared by type instead of instance.
    /// </remarks>
    public class ActionEqualityComparer<TArg>:BaseActionEqualityComparer,IEqualityComparer<Action<TArg>>
    {
        private static readonly IEqualityComparer<Action<TArg>> DefaultEqualityComparer = EqualityComparer<Action<TArg>>.Default;

        public ActionEqualityComparer()
        {
        }

        public bool Equals(Action<TArg> x, Action<TArg> y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return true;
            }

            if (ReferenceEquals(x, y))
            {
                return true;
            }

            return (CompareAnonymousByType && AreAnonymous(x.Method, y.Method)) ? (x.GetType() == y.GetType()):DefaultEqualityComparer.Equals(x,y);
        }

        public int GetHashCode(Action<TArg> obj)
        {
            return CompareAnonymousByType && obj.Method.IsAnonymous() ? obj.GetType().GetHashCode() : obj.GetHashCode();
        }
    }

    /// <summary>
    /// Equality comparer for actions with two parameters with ability to compare either
    /// using the actual actions or its type.
    /// </summary>
    /// <remarks>
    /// The code can look to try and utilize the fact that invoked methods are
    /// anonymous and so are compared by type instead of instance.
    /// </remarks>
    public class ActionEqualityComparer<TArg1,TArg2>:BaseActionEqualityComparer,IEqualityComparer<Action<TArg1,TArg2>>
    {
        private static readonly IEqualityComparer<Action<TArg1,TArg2>> DefaultEqualityComparer = EqualityComparer<Action<TArg1,TArg2>>.Default;

        public ActionEqualityComparer()
        {
        }

        public bool Equals(Action<TArg1,TArg2> x, Action<TArg1,TArg2> y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return true;
            }

            if (ReferenceEquals(x, y))
            {
                return true;
            }

            return (CompareAnonymousByType && AreAnonymous(x.Method, y.Method)) ? (x.GetType() == y.GetType()):DefaultEqualityComparer.Equals(x,y);        }

        public int GetHashCode(Action<TArg1,TArg2> obj)
        {
            return CompareAnonymousByType && obj.Method.IsAnonymous() ? obj.GetType().GetHashCode() : obj.GetHashCode();
        }
    }
}