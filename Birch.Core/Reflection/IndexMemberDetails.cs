using System.Linq.Expressions;

namespace Birch.Reflection
{
    public class IndexMemberDetails : MemberDetails
    {
        public IndexMemberDetails(Expression expression) : base(expression)
        {
        }
    }
}