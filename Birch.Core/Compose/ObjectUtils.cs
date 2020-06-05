using System;
using System.Collections.Generic;
using System.Text;
using Birch.Diagnostics;
using CloneExtensions;
using Microsoft.Extensions.Logging;

namespace Birch.Compose
{
    public static class ObjectUtils
    {
        /// <summary>
        /// Attempt to perform a clone of an object, with differing modes of cloning.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="cloneMode"></param>
        /// <param name="swallowErrors"></param>
        /// <returns></returns>
        public static T Clone<T>(T source,CloneMode cloneMode=CloneMode.Deep,bool swallowErrors=true)
        {
            // if not supposed to clone, just return the original item
            if (cloneMode == CloneMode.None)
            {
                return source;
            }

            T clone;

            // if the model is cloneable then we try and clone it
            if (source is ICloneable cloneableModel)
            {
                clone = (T) cloneableModel.Clone();
            }
            else
            {
                // right, we try and clone the object, this may or may not work...
                try
                {
                    clone = cloneMode switch
                    {
                        CloneMode.Deep => source.GetClone(),
                        CloneMode.Shallow => source.GetClone(CloningFlags.Shallow),
                        _ => source
                    };
                }
                catch (Exception exception)
                {
                    if (swallowErrors)
                    {
                        Logging.Instance.LogWarning(exception,"Object {model} failed to clone",source);
                    }
                    else
                    {
                        Logging.Instance.LogError(exception,"Object {model} failed to clone",source);
                        throw;
                    }

                    clone = source;
                }

            }

            return clone;
        }
    }
}
