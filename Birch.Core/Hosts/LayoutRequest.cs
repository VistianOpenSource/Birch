using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Comprises a request for a layout host to perform a layout.
    /// </summary>
    public class LayoutRequest : ILayoutRequest
    {
        public LayoutContext LayoutContext { get; }

        public int MutationId { get; }

        public LayoutRequest(LayoutContext layoutContext, int mutationId)
        {
            LayoutContext = layoutContext;
            MutationId = mutationId;
        }
    }
}