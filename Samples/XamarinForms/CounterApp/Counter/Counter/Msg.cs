using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    public abstract class   Msg
    {
    }

    public class Msg<TContent>:Msg
    {
        public TContent Content { get; set; }

        public Msg(){}
        public Msg(TContent content) => Content = content;

        public static implicit operator TContent(Msg<TContent> msg) => msg.Content;
    }
}
