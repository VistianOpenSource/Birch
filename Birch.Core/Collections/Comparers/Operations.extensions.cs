using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Collections.Comparers
{
    public static class OperationsExtensions
    {
        /// <summary>
        /// Apply a sequence of <see cref="Operation{T}"/> to a specified list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="operations"></param>
        /// <param name="list"></param>
        public static void Apply<T>(this IReadOnlyList<Operation<T>> operations, IList<T> list)
        {
            operations.Apply(insert: (index, item) =>
            {
                if (index >= list.Count)
                {
                    list.Add(item);
                }
                else
                {
                    list.Insert(index,item);
                }
            },delete: (index, _) =>
            {
                list.RemoveAt(index);
                ;
            },update: (index, from, to) =>
            {
                list[index] = to;
            });
        }


        /// <summary>
        /// Given a list of <see cref="Operation{T}"/>, invoke actions for each operation type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="operations"></param>
        /// <param name="insert"></param>
        /// <param name="delete"></param>
        /// <param name="move"></param>
        /// <param name="update"></param>
        public static void Apply<T>(this IReadOnlyList<Operation<T>> operations,Action<int,T> insert=default,Action<int,T> delete=default,Action<int,int,T> move=default,Action<int,T,T> update=default)
        {
            static void NullInsert(int index, T item){ }
            static void NullDelete(int index, T item) { }
            static void NullMove(int fromIndex, int toIndex, T item) { }
            static void NullUpdate(int index,T from,T to){}

            insert ??= NullInsert;
            delete ??= NullDelete;
            move ??= NullMove;
            update ??= NullUpdate;

            foreach (var operation in operations)
            {
                switch (operation)
                {
                    case InsertOp<T> op:
                        insert(op.Index, op.Item);
                        break;
                    case DeleteOp<T> op:
                        delete(op.Index, op.Item);
                        break;
                    case MoveOp<T> op:
                        move(op.From, op.To, op.Item);
                        break;
                    case UpdateOp<T> op:
                        update(op.Index, op.FromItem, op.ToItem);
                        break;
                }
            }
        }

    }
}
