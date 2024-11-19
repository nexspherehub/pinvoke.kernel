using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct Coordinate
{
  public short X;
  public short Y;
}
