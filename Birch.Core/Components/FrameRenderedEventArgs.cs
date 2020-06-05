using System;

namespace Birch.Components
{
    public class FrameRenderedEventArgs : EventArgs
    {
        public int TransactionCount { get; }

        public FrameRenderedEventArgs(int transactionCount)
        {
            TransactionCount = transactionCount;
        }
    }
}