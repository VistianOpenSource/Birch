using System.Linq.Expressions;
using System.Reflection;

namespace Birch.Reflection
{
    public class PropertyMemberDetails : MemberDetails
    {
        public PropertyInfo PropertyInfo { get; }

        public PropertyMemberDetails(Expression expression) : base(expression)
        {
            var memberExpression = expression as MemberExpression;

            PropertyInfo = (PropertyInfo)memberExpression.Member;
        }
    }
}