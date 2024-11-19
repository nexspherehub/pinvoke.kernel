namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ControlEvent : uint
{
  CtrlShutdown  = 0x06,
  CtrlLogoff    = 0x05,
  CtrlClose     = 0x02,
  CtrlBreak     = 0x01,
  CtrlC         = 0x00,
}
