namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ConsoleReadingBehavior : ushort
{
  NoRemove  = 0x0001,
  NoWait    = 0x0002,
}
