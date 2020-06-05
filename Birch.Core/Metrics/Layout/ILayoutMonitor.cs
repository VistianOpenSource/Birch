namespace Birch.Metrics.Layout
{
    /// <summary>
    /// Specification of a monitor of <see cref="ILayoutEvent"/>
    /// </summary>
    public interface ILayoutMonitor
    {
        public void Record(ILayoutEvent layoutEvent);
    }
}