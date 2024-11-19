using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Sequential)]
public record struct ReadConsoleControl
{
  public static uint Length = (uint)Marshal.SizeOf<ReadConsoleControl>();
  public uint InitialChars;
  public uint CtrlWakeupMask;
  public ModifierKeyState CtrlKeyState;
}
