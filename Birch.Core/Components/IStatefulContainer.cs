using System;
using System.Collections.Generic;
using System.Text;
using Birch.Compose;

namespace Birch.Components
{
    /// <summary>
    /// Specification of a stateful container, i.e. a <see cref="IComposite"/> which has state which persists
    /// across layouts. 
    /// </summary>
    /// <remarks>
    /// A <see cref="IStatefulContainer"/> also implements <see cref="IDisposable"/>, which is used
    /// when the view host is disposed off.
    /// No class implements this interface, but instead implements the generic form.
    /// </remarks>
    public interface IStatefulContainer:IComposite,IDisposable
    {
        BuildContext Context { get; }
    }
}
