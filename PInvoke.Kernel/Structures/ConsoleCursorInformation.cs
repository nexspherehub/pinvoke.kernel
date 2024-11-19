using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct ConsoleCursorInformation
{
  public uint Size;
  public bool Visible;
}
