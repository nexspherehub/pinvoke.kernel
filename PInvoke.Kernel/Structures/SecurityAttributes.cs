using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct SecurityAttributes
{
  public static uint Length = (uint)Marshal.SizeOf<SecurityAttributes>();
  public SecurityDescriptor SecurityDescriptor;
  public bool InheritHandle;
}
