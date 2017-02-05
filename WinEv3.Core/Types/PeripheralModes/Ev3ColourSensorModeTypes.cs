namespace WinEv3.Core.Types.PeripheralModes
{
    public enum Ev3ColourSensorModeTypes : byte
    {
        Reflective = 0x00,
        Ambient = 0x01,
        Colour = 0x02,
        ReflectiveRaw = 0x03,
        ReflectiveRgb = 0x04,
        Calibration = 0x05
    }
}
