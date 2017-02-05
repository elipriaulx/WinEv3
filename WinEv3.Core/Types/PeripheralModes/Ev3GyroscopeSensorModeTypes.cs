namespace WinEv3.Core.Types.PeripheralModes
{
    public enum Ev3GyroscopeSensorModeTypes : byte
    {
        Angle = 0x00,
        Rate = 0x01,
        Fas = 0x02,
        GandA = 0x03,
        Calibrate = 0x04
    }
}