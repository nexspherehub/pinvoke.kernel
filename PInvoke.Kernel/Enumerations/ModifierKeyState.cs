namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ModifierKeyState : uint
{
  ScrollLockOn  = 0x0040,
  CapsLockOn    = 0x0080,
  NumLockOn     = 0x0020,

  // @

  LeftCtrlPressed = 0x0008,
  LeftAltPressed  = 0x0002,
  
  // @

  RightCtrlPressed  = 0x0004,
  RightAltPressed   = 0x0001,

  // @
  
  ShiftPressed  = 0x0010,
  EnhancedKey   = 0x0100,
}
