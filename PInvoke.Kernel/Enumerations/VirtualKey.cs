namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum VirtualKey : ushort
{
  MiddleMouseButton = 0x04,
  RightMouseButton  = 0x02,
  LeftMouseButton   = 0x01,

  // @

  XButton1 = 0x05,
  XButton2 = 0x06,

  // @

  Backspace = 0x08,
  Control   = 0x11,
	Capital   = 0x14,
  Cancel    = 0x03,
  Escape    = 0x1B,
  Return    = 0x0D,
	Space     = 0x20,
  Shift     = 0x10,
  Clear     = 0x0C,
  Tab       = 0x09,

  // @

  ImeModeChange = 0x1F,
  ImeNonConvert = 0x1D,
  ImeConvert    = 0x1C,
  ImeProcess    = 0xE5,
  ImeHangul     = 0x15,
  ImeAccept     = 0x1E,
  ImeJunja      = 0x17,
  ImeFinal      = 0x18,
  ImeHanja      = 0x19,
  ImeKanji      = 0x19,
  ImeKana       = 0x15,
  ImeOff        = 0x1A,
  ImeOn         = 0x16,

  // @

  Prior = 0x21,
  Next  = 0x22,
  Home  = 0x24,
  End   = 0x23,

  // @

  Right = 0x27,
  Left  = 0x25,
  Down  = 0x28,
  Up    = 0x26,

  // @

  Snapshot  = 0x2C,
	NumLock   = 0x90,
  Execute   = 0x2B,
  Select    = 0x29,
  Insert    = 0x2D,
  Delete    = 0x2E,
	Scroll    = 0x91,
	Sleep     = 0x5F,
  Print     = 0x2A,
  Help      = 0x2F,
	Apps      = 0x5D,

	// @

  RightWindows  = 0x5C,
	LeftWindows   = 0x5B,

	// @

	Numpad0 = 0x60,
  Numpad1 = 0x61,
  Numpad2 = 0x62,
  Numpad3 = 0x63,
  Numpad4 = 0x64,
  Numpad5 = 0x65,
  Numpad6 = 0x66,
  Numpad7 = 0x67,
  Numpad8 = 0x68,
  Numpad9 = 0x69,

  // @

  Separator = 0x6C,
  Multiply  = 0x6A,
  Subtract  = 0x6D,
  Decimal   = 0x6E,
  Divide    = 0x6F,
  Add       = 0x6B,

  // @

  F1  = 0x70,
  F2  = 0x71,
  F3  = 0x72,
  F4  = 0x73,
  F5  = 0x74,
  F6  = 0x75,
  F7  = 0x76,
  F8  = 0x77,
  F9  = 0x78,
  F10 = 0x79,
  F11 = 0x7A,
  F12 = 0x7B,
  F13 = 0x7C,
  F14 = 0x7D,
  F15 = 0x7E,
  F16 = 0x7F,
  F17 = 0x80,
  F18 = 0x81,
  F19 = 0x82,
  F20 = 0x83,
  F21 = 0x84,
  F22 = 0x85,
  F23 = 0x86,
  F24 = 0x87,

  // @

  RightShift  = 0xA1,
  LeftShift   = 0xA0,

  // @

  RightControl  = 0xA3,
  LeftControl   = 0xA2,

  // @

  RightMenu = 0xA5,
  LeftMenu  = 0xA4,
	Menu      = 0x12,

	// @

	BrowserFavorites  = 0xAB,
  BrowserForward    = 0xA7,
  BrowserRefresh    = 0xA8,
  BrowserSearch     = 0xAA,
  BrowserBack       = 0xA6,
  BrowserStop       = 0xA9,
  BrowserHome       = 0xAC,

  // @

  VolumeMute  = 0xAD,
  VolumeDown  = 0xAE,
  VolumeUp    = 0xAF,

  // @

  MediaNextTrack  = 0xB0,
  MediaPrevTrack  = 0xB1,
  MediaPlayPause  = 0xB3,
  MediaStop       = 0xB2,

  // @

  LaunchMediaSelect = 0xB5,
  LaunchMail        = 0xB4,
  LaunchApp1        = 0xB6,
  LaunchApp2        = 0xB7,

  // @

  OemPeriod = 0xBE,
  OemClear  = 0xFE,
  OemComma  = 0xBC,
  OemMinus  = 0xBD,
  OemPlus   = 0xBB,
  Oem102    = 0xE2,
  Oem1      = 0xBA,
  Oem2      = 0xBF,
  Oem3      = 0xC0,
  Oem4      = 0xDB,
  Oem5      = 0xDC,
  Oem6      = 0xDD,
  Oem7      = 0xDE,
  Oem8      = 0xDF,

  // @

  EraseEndOfFile  = 0xF9,
  Packet          = 0xE7,
  CrSel           = 0xF7,
  ExSel           = 0xF8,
  Attn            = 0xF6,
	Zoom            = 0xFB,
  Pa1             = 0xFD,

  // @

	Pause = 0x13,
  Play = 0xFA,

  // @

  Number0 = 0x30,
  Number1 = 0x31,
  Number2 = 0x32,
  Number3 = 0x33,
  Number4 = 0x34,
  Number5 = 0x35,
  Number6 = 0x36,
  Number7 = 0x37,
  Number8 = 0x38,
  Number9 = 0x39,

  // @

  A = 0x41,
  B = 0x42,
  C = 0x43,
  D = 0x44,
  E = 0x45,
  F = 0x46,
  G = 0x47,
  H = 0x48,
  I = 0x49,
  J = 0x4A,
  K = 0x4B,
  L = 0x4C,
  M = 0x4D,
  N = 0x4E,
  O = 0x4F,
  P = 0x50,
  Q = 0x51,
  R = 0x52,
  S = 0x53,
  T = 0x54,
  U = 0x55,
  V = 0x56,
  W = 0x57,
  X = 0x58,
  Y = 0x59,
  Z = 0x5A,
}