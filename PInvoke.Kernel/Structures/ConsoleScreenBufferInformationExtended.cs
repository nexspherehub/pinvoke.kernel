using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Sequential)]
public record struct ConsoleScreenBufferInformationExtended
{
  public static uint cbSize = (uint)Marshal.SizeOf<ConsoleScreenBufferInformationExtended>();
  public Coordinate dwSize;
  public Coordinate dwCursorPosition;
  public CharacterAttributes wAttributes;
  public SmallRectangle srWindow;
  public Coordinate dwMaximumWindowSize;
  public ushort wPopupAttributes;
  public bool bFullscreenSupported;
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] public uint[] ColorTable;
}
