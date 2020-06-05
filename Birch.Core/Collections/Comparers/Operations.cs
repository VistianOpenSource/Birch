using System;
using System.Collections.Generic;
using System.Linq;

namespace Birch.Collections.Comparers
{
    /// <summary>
    /// Base class for an operation on a list
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public abstract class Operation<T> : IEquatable<Operation<T>>
   {
       public abstract IEnumerable<int> GetIndices();

       public abstract IEnumerable<T> GetItems();

       public IEnumerable<object> Members
       {
           get
           {
               yield return Name;
               foreach (var item in GetIndices())
               {
                   yield return item;
               }
               foreach (var item in GetItems())
               {
                   yield return item;
               }
           }
       }

       public string Name => GetType().Name;

       public override bool Equals(object obj)
       {
           return Equals(obj as Operation<T>);
       }

       public override int GetHashCode()
       {
           unchecked
           {
               var res =0;

               foreach (var item in Members)
               {
                   res *= 397;

                   if (item != null)
                   {
                       res ^= item.GetHashCode();
                   }
               }
               return res;
           }
       }

       public override string ToString()
       {
           return string.Join(" ", Members);
       }

       public bool Equals(Operation<T> obj)
       {
           return (obj is { } op)
                  && (obj.GetType() == GetType())
                  && (op.Members.SequenceEqual(Members));
       }

       public static bool operator ==(Operation<T> o1, Operation<T> o2)
       {
           var isnull1 = ReferenceEquals(o1, null);
           var isnull2 = ReferenceEquals(o2, null);

           if (isnull1 && isnull2) return true;
           if (isnull1 || isnull2) return false;

           return o1.Equals(o2);
       }

       public static bool operator !=(Operation<T> o1, Operation<T> o2)
       {
           return !(o1 == o2);
       }
   }
}