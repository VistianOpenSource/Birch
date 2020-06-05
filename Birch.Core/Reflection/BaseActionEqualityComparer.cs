using System.Reflection;

namespace Birch.Reflection
{
    /// <summary>
    /// Base class for Action equality comparer . 
    /// </summary>
    public abstract class BaseActionEqualityComparer
    {
        /// <summary>
        /// The default mode for how anonymous actions should be compared. True implies that we should compare by type.
        /// </summary>
        public static bool DefaultCompareAnonymousByType = false;

        protected BaseActionEqualityComparer(bool? compareAnonymousByType=false)
        {
            CompareAnonymousByType = compareAnonymousByType??DefaultCompareAnonymousByType;
        }

        /// <summary>
        /// Get whether should be comparing anonymous types used type or not
        /// </summary>
        protected bool CompareAnonymousByType { get; }

        /// <summary>
        /// Are the two provided methods anonymous?
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        protected bool AreAnonymous(MethodInfo x, MethodInfo y)
        {
            return x.IsAnonymous() && y.IsAnonymous();
        }
    }
}