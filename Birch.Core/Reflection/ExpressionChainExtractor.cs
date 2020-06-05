using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Birch.Reflection
{
    /// <summary>
    /// Breakdown expressions into a sequence of <see cref="MemberDetails"/> instances.
    /// </summary>
    public class ExpressionChainExtractor
    {
        private readonly ConcurrentDictionary<Expression, List<MemberDetails>> _memberDetailsCache = new ConcurrentDictionary<Expression, List<MemberDetails>>();
        public static ExpressionChainExtractor Default => new ExpressionChainExtractor();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<MemberDetails> Decode(Expression expression)
        {
            if (!_memberDetailsCache.TryGetValue(expression, out var chain))
            {
                chain = new List<MemberDetails>();

                var node = expression;

                while (node.NodeType != ExpressionType.Parameter)
                {
                    switch (node.NodeType)
                    {
                        case ExpressionType.Index:
                            var indexExpr = (IndexExpression)node;
                            if (indexExpr.Object.NodeType != ExpressionType.Parameter)
                            {
                                //     indexExpr.Update(Expression.Parameter(indexExpr.GetParent().Type), indexExpr.Arguments);
                            }

                            chain.Add(new IndexMemberDetails(indexExpr));

                            node = indexExpr.Object;
                            break;
                        case ExpressionType.MemberAccess:
                            var memberExpr = (MemberExpression)node;

                            if (memberExpr.Expression.NodeType != ExpressionType.Parameter)
                            {

                                //    memberExpr.Update(Expression.Parameter(memberExpr.GetParent().Type));
                            }

                            if (memberExpr.Member is PropertyInfo)
                            {
                                chain.Add(new PropertyMemberDetails(memberExpr));
                            }
                            else
                            {
                                chain.Add(new FieldMemberDetails(memberExpr));
                            }

                            node = memberExpr.Expression;

                            break;
                        case ExpressionType.Call:
                            var callExpr = (MethodCallExpression) node;
                            chain.Add(new MethodMemberDetails(callExpr));

                            node = callExpr.Object;
                            break;

                        default:
                            throw new NotSupportedException($"Unsupported expression type: '{node.NodeType}'");
                    }
                }

                chain.Reverse();

                _memberDetailsCache[expression] = chain;
            }

            return chain;
        }

    }
}