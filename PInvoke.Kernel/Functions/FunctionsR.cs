using System.Runtime.InteropServices;
using System.Text;
using System;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "ReadConsole", SetLastError = true)]
  public static extern bool ReadConsole(
    [In] IntPtr consoleInput,
    [Out] out byte[] buffer,
    [In] uint numberOfCharsToRead,
    [Out] out uint numberOfCharsRead,
    [In] ref ReadConsoleControl inputControl
  );

  // @

  [DllImport(DllName, EntryPoint = "ReadConsoleInput", SetLastError = true)]
  public static extern bool ReadConsoleInput(
    [In] IntPtr consoleInput,
    [Out] out InputRecord buffer,
    [In] uint length,
    [Out] out uint numberOfEventsRead
  );

  // @

  [DllImport(DllName, EntryPoint = "ReadConsoleInputEx", SetLastError = true)]
  public static extern bool ReadConsoleInputExtended(
    [In] IntPtr consoleInput,
    [Out] out InputRecord buffer,
    [In] uint length,
    [Out] out uint numberOfEventsRead,
    [In] ConsoleReadingBehavior flags
  );

  // @

  [DllImport(DllName, EntryPoint = "ReadConsoleOutput", SetLastError = true)]
  public static extern bool ReadConsoleOutput(
    [In] IntPtr consoleOutput,
    [Out] out CharacterInformation buffer,
    [In] Coordinate bufferSize,
    [In] Coordinate bufferCoord,
    [In, Out] ref SmallRectangle readRegion
  );

  // @

  [DllImport(DllName, EntryPoint = "ReadConsoleOutputAttribute", SetLastError = true)]
  public static extern bool ReadConsoleOutputAttribute(
    [In] IntPtr consoleOutput,
    [Out] out CharacterAttributes attribute,
    [In] uint length,
    [In] Coordinate readCoord,
    [Out] out uint numberOfAttrsRead
  );

  // @

  [DllImport(DllName, EntryPoint = "ReadConsoleOutputCharacter", CharSet = CharSet.Auto, SetLastError = true)]
  public static extern bool ReadConsoleOutputCharacter(
    [In] IntPtr consoleOutput,
    [Out, MarshalAs(UnmanagedType.LPTStr)] out StringBuilder character,
    [In] uint length,
    [In] Coordinate readCoord,
    [Out] out uint numberOfCharsRead
  );

  // @

  [DllImport(DllName, EntryPoint = "ResizePseudoConsole", SetLastError = true)]
  public static extern ResultHandle ResizePseudoConsole(
    [In] IntPtr handlePseudoConsole,
    [In] Coordinate size
  );
}