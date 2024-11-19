namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum MouseButtonState : uint
{
  FromLeft1StButtonPressed  = 0x0001,
  FromLeft2NdButtonPressed  = 0x0004,
  FromLeft3RdButtonPressed  = 0x0008,
  FromLeft4ThButtonPressed  = 0x0010,
  RightmostButtonPressed    = 0x0002,
}