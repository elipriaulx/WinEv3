namespace WinEv3.Core.Types
{
    public enum SystemOperationTypes : byte
    {
        BeginDownload = 0x92,
        ContinueDownload = 0x93,
        CloseFileHandle = 0x98,
        CreateDirectory = 0x9B,
        DeleteFile = 0x9C
    }
}
