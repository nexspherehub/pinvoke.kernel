namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum CharacterAttributes : ushort
{
  ForegroundIntensity = 0x0008,
  ForegroundGreen     = 0x0002,
  ForegroundBlue      = 0x0001,
  ForegroundRed       = 0x0004,

  // @

  BackgroundIntensity = 0x0080,
  BackgroundGreen     = 0x0020,
  BackgroundBlue      = 0x0010,
  BackgroundRed       = 0x0040,

  // @

  CommonLVBTrailingByte = 0x0200,
  CommonLVBLeadingByte  = 0x0100,

  // @

  CommonGridRightVertical = 0x1000,
  CommonGridLeftVertical  = 0x0800,
  CommonGridHorizontal    = 0x0400,

  // @

  CommonLVBReverseVideo = 0x4000,
  CommonLVBUnderscore   = 0x8000,
}
