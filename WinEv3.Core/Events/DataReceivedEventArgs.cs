namespace WinEv3.Core.Events
{
    public class DataReceivedEventArgs : Ev3EventArgs
    {
        public byte[] Report { get; set; }
    }
}
