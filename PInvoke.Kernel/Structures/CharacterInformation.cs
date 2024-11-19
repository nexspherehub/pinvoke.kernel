using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
public record struct CharacterInformation
{
  [FieldOffset(0)] public char UnicodeChar;
  [FieldOffset(0)] public char AsciiChar;
  [FieldOffset(2)] public CharacterAttributes Attributes;
}
