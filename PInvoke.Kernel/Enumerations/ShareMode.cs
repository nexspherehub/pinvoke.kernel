namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ShareMode : long
{
  Write = 0x00000002,
  Read  = 0x00000001,
}
