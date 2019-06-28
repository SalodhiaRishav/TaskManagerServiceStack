using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class MessageFormat<T>
    {
        public Boolean Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}
