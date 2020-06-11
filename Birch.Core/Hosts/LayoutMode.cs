namespace Birch.Hosts
{
    /// <summary>
    /// How  a layout is performed
    /// </summary>
    public enum LayoutMode
    {
        Sync,           // all layouts should be perform synchronously
        FirstSync,      // only the first layout is done synchronously, the rest async
        Async           // all layouts are done asynchronously 
    };
}