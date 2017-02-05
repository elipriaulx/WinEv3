using System;

namespace WinEv3.Core.Types
{
    [Flags]
    public enum OutputPortTypes : byte
    {
        A = 0x01,
        B = 0x02,
        C = 0x04,
        D = 0x08,
        All = 0x0F
    }
}
