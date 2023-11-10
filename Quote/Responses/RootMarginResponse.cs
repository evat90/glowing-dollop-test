using System;
using System.Collections.Generic;
using System.Text;

namespace Quote.Responses
{
    public class RootMarginResponse
    {
        public int code { set; get; }
        public string messagge { set; get; }
        public MarginResponse data { set; get; }
    }
}
