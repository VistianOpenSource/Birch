using System.Linq.Expressions;

namespace Birch.Reflection
{
    public abstract class MemberDetails
    {
        protected MemberDetails(Expression expression)
        {
            Expression = expression;
        }

        /// <summary>
        /// Get the expression associated with the member.
        /// </summary>
        public Expression Expression { get;  }
    }
}