using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Auto)]
public record struct KeyEventRecord
{
  [FieldOffset(0)] public bool KeyDown;
  [FieldOffset(1)] public ushort RepeatCount;
  [FieldOffset(3)] public VirtualKey VirtualKeyCode;
  [FieldOffset(5)] public ushort VirtualScanCode;
  [FieldOffset(7)] public char UnicodeChar;
  [FieldOffset(7)] public char AsciiChar;
  [FieldOffset(9)] public ModifierKeyState ControlKeyState;
}