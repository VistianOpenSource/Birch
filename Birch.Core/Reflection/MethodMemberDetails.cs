using System.Linq.Expressions;
using System.Reflection;

namespace Birch.Reflection
{
    public class MethodMemberDetails : MemberDetails
    {
        public MethodInfo MethodInfo { get; }

        public MethodMemberDetails(Expression expression) : base(expression)
        {
            var memberExpression = expression as MethodCallExpression;

            MethodInfo = (MethodInfo)memberExpression.Method;
        }
    }
}