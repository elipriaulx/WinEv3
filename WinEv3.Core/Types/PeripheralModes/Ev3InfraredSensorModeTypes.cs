namespace WinEv3.Core.Types.PeripheralModes
{
    public enum Ev3InfraredSensorModeTypes : byte
    {
        Proximity = 0x00,
        Seek = 0x01,
        Remote = 0x02,
        RemoteA = 0x03,
        SAlt = 0x04,
        Calibrate = 0x05
    }
}