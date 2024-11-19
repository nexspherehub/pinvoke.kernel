namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ConsoleStandardDevice : int
{
  OutputHandle  = -0x0B,
  InputHandle   = -0x0A,
  ErrorHandle   = -0x0C,
}