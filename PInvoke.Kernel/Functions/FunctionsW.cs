using System.Runtime.InteropServices;
using System.Text;
using System;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "WriteConsole", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern bool WriteConsole(
    [In] IntPtr consoleOutput,
    [In, MarshalAs(UnmanagedType.LPTStr)] ref StringBuilder buffer,
    [In] uint numberOfCharsToWrite,
    [Out] out uint numberOfCharsWritten,
    [In] IntPtr reserved = default
  );

  // @

  [DllImport(DllName, EntryPoint = "WriteConsoleInput", SetLastError = true)]
  public static extern bool WriteConsoleInput(
    [In] IntPtr consoleInput,
    [In] ref InputRecord buffer,
    [In] uint length,
    [Out] out uint numberOfEventsWritten
  );

  // @

  [DllImport(DllName, EntryPoint = "WriteConsoleOutput", SetLastError = true)]
  public static extern bool WriteConsoleOutput(
    [In] IntPtr consoleOutput,
    [In] ref CharacterInformation[] buffer,
    [In] Coordinate bufferSize,
    [In] Coordinate bufferCoord,
    [In, Out] ref SmallRectangle writeRegion
  );

  // @

  [DllImport(DllName, EntryPoint = "WriteConsoleOutputAttribute", SetLastError = true)]
  public static extern bool WriteConsoleOutputAttribute(
    [In] IntPtr consoleOutput,
    [In] ref CharacterAttributes attribute,
    [In] uint length,
    [In] Coordinate writeCoord,
    [Out] out uint numberOfAttrsWritten
  );

  // @
  
  [DllImport(DllName, EntryPoint = "WriteConsoleOutputCharacter", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern bool WriteConsoleOutputCharacter(
    [In] IntPtr consoleOutput,
    [In, MarshalAs(UnmanagedType.LPTStr)] StringBuilder character,
    [In] uint length,
    [In] Coordinate writeCoord,
    [Out] out uint numberOfCharsWritten
  );
}