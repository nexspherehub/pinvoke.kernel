namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum InputRecordEventType : ushort
{
  WindowBufferSize  = 0x0004,
  Mouse             = 0x0002,
  Focus             = 0x0010,
  Menu              = 0x0008,
  Key               = 0x0001,
}
