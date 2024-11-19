using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;

[StructLayout(LayoutKind.Sequential)]
public struct ConsoleHistoryInformation
{
  public static uint Size = (uint)Marshal.SizeOf<ConsoleHistoryInformation>();
  public uint HistoryBufferSize;
  public uint NumberOfHistoryBuffers;
  public static uint Flags;
}
