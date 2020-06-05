namespace Birch.Shadows
{
    /// <summary>
    /// Collection of extension methods for state manipulation.
    /// </summary>
    public static class IShadowExtensions
    {
        /// <summary>
        /// Set the value of an item to be retained in the state 
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="shadow"></param>
        /// <param name="value"></param>
        public static void Set<TValue>(this IShadow shadow,TValue value)
        {
            shadow.State.Set(string.Empty,value);
        }

        /// <summary>
        /// Set the value of an item to be stored in the state
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="shadow"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set<TValue>(this IShadow shadow,string key, TValue value)
        {
            shadow.State.Set(key,value);
        }

        /// <summary>
        /// Get the value of an item from state
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue Get<TValue>(this IShadow shadow)
        {
            return shadow.State.Get<TValue>();
        }

        /// <summary>
        /// Get the value of an item from state
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="shadow"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue Get<TValue>(this IShadow shadow,string key)
        {
            return shadow.State.Get<TValue>(key);
        }
    }
}