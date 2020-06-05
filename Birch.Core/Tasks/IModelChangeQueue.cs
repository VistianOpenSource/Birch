using System.Threading.Channels;
using Birch.Compose;

namespace Birch.Tasks
{
    public interface IModelChangeQueue
    {
        void Enqueue(ModelChange change);
        ChannelReader<ModelChange> Reader { get; }
    }
}