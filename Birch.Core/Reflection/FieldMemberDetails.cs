using System.Linq.Expressions;
using System.Reflection;

namespace Birch.Reflection
{
    /// <summary>
    /// Represents a field type 
    /// </summary>
    public class FieldMemberDetails : MemberDetails
    {
        public FieldInfo FieldInfo {get;}

        public FieldMemberDetails(Expression expression) : base(expression)
        {
            var memberExpression = expression as MemberExpression;

            FieldInfo = (FieldInfo)memberExpression.Member;
        }
    }
}