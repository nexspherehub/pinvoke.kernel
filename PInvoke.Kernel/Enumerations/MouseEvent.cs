namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum MouseEvent : uint
{
  HorizontalWheeled = 0x0008,
  VerticalWheeled   = 0x0004,

  // @

  DoubleClick = 0x0002,
  Moved       = 0x0001,
}