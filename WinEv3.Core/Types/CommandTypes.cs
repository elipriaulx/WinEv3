namespace WinEv3.Core.Types
{
    public enum CommandTypes : byte
    {
        DirectReply = 0x00,
        DirectNoReply = 0x80,
        SystemReply = 0x01,
        SystemNoReply = 0x81
    }
}