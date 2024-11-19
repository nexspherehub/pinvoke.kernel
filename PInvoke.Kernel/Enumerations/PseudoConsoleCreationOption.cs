namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum PseudoConsoleCreationOption : uint
{
  InheritCursor = 0x01,
  Standard      = 0x00,
}
