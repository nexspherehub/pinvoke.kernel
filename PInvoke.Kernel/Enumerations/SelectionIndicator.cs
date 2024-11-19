namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum SelectionIndicator : uint
{
  SelectionInProgress = 0x0001,
  SelectionNotEmpty   = 0x0002,
  NoSelection         = 0x0000,

  // @

  MouseSelection  = 0x0004,
  MouseDown       = 0x0008,
}