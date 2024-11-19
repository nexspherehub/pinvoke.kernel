namespace PInvoke.Kernel.Enumerations
{
  [System.Flags]
  public enum ConsoleWindowEvent : int
  {
    StartApplication  = 0x4006,
    EndApplication    = 0x4007,

    // @

    UpdateRegion  = 0x4002,
    UpdateScroll  = 0x4004,
    UpdateSimple  = 0x4003,

    // @

    Layout  = 0x4005,
    Caret   = 0x4001,
  }
}
