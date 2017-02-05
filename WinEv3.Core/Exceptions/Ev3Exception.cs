using System;

namespace WinEv3.Core.Exceptions
{
    public class WinEv3Exception : Exception
    {
        public WinEv3Exception() {}

        public WinEv3Exception(string message) : base(message) {}

        public WinEv3Exception(string message, Exception inner) : base(message, inner) {}
    }
}
