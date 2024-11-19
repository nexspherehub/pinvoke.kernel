using System.Runtime.InteropServices;
using System.Text;
using System;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "FillConsoleOutputAttribute", SetLastError = true)]
  public static extern bool FillConsoleOutputAttribute(
    [In] IntPtr consoleOutput,
    [In] CharacterAttributes attribute,
    [In] uint length,
    [In] Coordinate writeCoord,
    [Out] out uint numberOfAttrsWritten
  );

  // @

  [DllImport(DllName, EntryPoint = "FillConsoleOutputCharacter", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern bool FillConsoleOutputCharacter(
    [In] IntPtr consoleOutput,
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder character,
    [In] uint length,
    [In] Coordinate writeCoord,
    [Out] out uint numberOfCharsWritten
  );

  // @

  [DllImport(DllName, EntryPoint = "FlushConsoleInputBuffer", SetLastError = true)]
  public static extern bool FlushConsoleInputBuffer([In] IntPtr handleConsoleInput);

  // @

  [DllImport(DllName, EntryPoint = "FreeConsole", SetLastError = true)]
  public static extern void FreeConsole();
}