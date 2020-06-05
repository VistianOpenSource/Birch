using System;
using System.Reactive;

namespace Birch.Components
{
    /// <summary>
    /// Cache the result of a layout and ensure it isn't used again.
    /// </summary>
    public class Fix :DependsUpon<Unit>
    {
        public Fix(Func<IElement> viewComponent) : base(Unit.Default, unit => viewComponent())
        {
        }
    }
}