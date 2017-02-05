namespace WinEv3.Core.Types
{
    public enum ReplyTypes : byte
    {
        DirectReply = 0x02,
        SystemReply = 0x03,
        DirectReplyError = 0x04,
        SystemReplyError = 0x05
    }
}
