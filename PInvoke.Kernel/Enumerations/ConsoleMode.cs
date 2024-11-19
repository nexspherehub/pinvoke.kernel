namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ConsoleMode : uint
{
  EnableVirtualTerminalInput  = 0x0200,
  EnableProcessedInput        = 0x0001,
  EnableQuickEditMode         = 0x0040,
  EnableExtendedFlags         = 0x0080,
  EnableWindowInput           = 0x0008,
  EnableMouseInput            = 0x0010,
  EnableInsertMode            = 0x0020,
  EnableEchoInput             = 0x0004,
  EnableLineInput             = 0x0002,

  // @

  EnableVirtualTerminalProcessing = 0x0004,
  EnableWrapAtEndOfLineOutput     = 0x0002,
  DisableNewLineAutoReturn        = 0x0008,
  EnableLVBGridWorldWide          = 0x0010,
  EnableProcessedOutput           = 0x0001,
}
