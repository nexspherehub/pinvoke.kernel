using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct ConsoleFontInformation
{
  public uint Font;
  public Coordinate FontSize;
}
