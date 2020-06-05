using System.Threading.Channels;
using Birch.Compose;

namespace Birch.Tasks
{
    public class ChannelModelChangeQueue:IModelChangeQueue
    {
        private readonly ChannelWriter<ModelChange> _writer;

        public ChannelModelChangeQueue()
        {
            var channel = Channel.CreateUnbounded<ModelChange>();

            _writer = channel.Writer;
            Reader = channel.Reader;
        }

        public void Enqueue(ModelChange change)
        {
            _writer.WriteAsync(change);
        }

        public ChannelReader<ModelChange> Reader { get; }
    }
}