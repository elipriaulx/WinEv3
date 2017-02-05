namespace WinEv3.Core.Types.PeripheralModes
{
    public enum Ev3UltrasonicSensorModeTypes : byte
    {
        Centimeters = 0x00,
        Inches = 0x01,
        Listen = 0x02,
        SiCentimeters = 0x03,
        SiInches = 0x04,
        DcCentimeters = 0x05,
        DcInches = 0x06
    }
}
