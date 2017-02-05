namespace WinEv3.Core.Types
{
    public enum PeripheralTypes
    {
        NxtTouch = 0x01,
        NxtLight = 0x02,
        NxtSound = 0x03,
        NxtColour = 0x04,
        NxtUltrasonic = 0x05,
        NxtTemperature = 0x06,
        Ev3LargeMotor = 0x07,
        Ev3MediumMotor = 0x08,
        Ev3Touch = 0x10,
        Ev3Colour = 0x1D,
        Ev3Ultrasonic = 0x1E,
        Ev3Gyroscope = 0x20,
        Ev3Infrared = 0x22,
        Ev3Initializing = 0x7D,
        EmptyPort = 0x7E,
        IncorrectPort = 0x7F,
        Unknown = 0xFF
    }
}
