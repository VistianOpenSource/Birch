using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Specification of a layout request used with layout hosts.
    /// </summary>
    public interface ILayoutRequest
    {
        /// <summary>
        /// The context for the layout
        /// </summary>
        LayoutContext LayoutContext { get; }

        /// <summary>
        /// The mutation id associated with this layout
        /// </summary>
        int MutationId { get; }
    }
}