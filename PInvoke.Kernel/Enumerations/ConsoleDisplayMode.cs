namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ConsoleDisplayMode : uint
{
  FullScreenHardware  = 0x02,
  FullScreen          = 0x01,
  Windowed            = 0x02,
}
