using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Sequential)]
public record struct ConsoleScreenBufferInformation
{
  public Coordinate Size;
  public Coordinate CursorPosition;
  public CharacterAttributes Attributes;
  public SmallRectangle Window;
  public Coordinate MaximumWindowSize;
}
