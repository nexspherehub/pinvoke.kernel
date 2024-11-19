using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct SmallRectangle
{
  public short Left;
  public short Top;
  public short Right;
  public short Bottom;
}
