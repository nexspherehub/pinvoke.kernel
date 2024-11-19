namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum ResultHandle : uint
{
  Abort = 0x80004004,
  Fail  = 0x80004005,
  Ok    = 0x00000000,

  // @

  InvalidArgument = 0x80070057,
  AccessDenied    = 0x80070005,
	OutOfMemory     = 0x8007000E,
	Unexpected      = 0x8000FFFF,
	Pointer         = 0x80004003,
  Handle          = 0x80070006,

	// @

	NotImplemented  = 0x80004001,
  NoInterface     = 0x80004002,
}