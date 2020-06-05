using Android.Widget;

namespace Birch.Views
{
    /// <summary>
    /// Structure used for the specification of layout rules for a <see cref="Android.Widget.RelativeLayout"/>
    /// </summary>
    public readonly struct LayoutRule
    {
        /// <summary>
        /// The actual rule
        /// </summary>
        public LayoutRules Verb { get; }

        /// <summary>
        /// The optional subject/control id
        /// </summary>
        public int? Subject { get; }

        public LayoutRule(LayoutRules verb, int? subject=default)
        {
            Verb = verb;
            Subject = subject;
        }

        public static implicit operator LayoutRule(LayoutRules rules) => new LayoutRule(rules);

        public static implicit operator LayoutRules(LayoutRule layoutRule) => layoutRule.Verb;
    }
}