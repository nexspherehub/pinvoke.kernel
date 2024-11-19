using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct WindowBufferSizeRecord
{
  public Coordinate Size;
}
