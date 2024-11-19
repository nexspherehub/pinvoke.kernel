using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public record struct ConsoleFontInformationExtended
{
  public static uint Size = (uint)Marshal.SizeOf<ConsoleFontInformationExtended>();
  public uint Font;
  public Coordinate FontSize;
  public uint FontFamily;
  public uint FontWeight;
  [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string FaceName;
}
