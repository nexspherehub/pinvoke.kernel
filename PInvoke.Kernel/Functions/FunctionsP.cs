using System.Runtime.InteropServices;
using System;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "PeekConsoleInput", SetLastError = true)]
  public static extern bool PeekConsoleInput(
    [In] IntPtr consoleInput,
    [Out] out InputRecord buffer,
    [In] uint length,
    [Out] out uint numberOfEventsRead
  );
}