using System.Runtime.InteropServices;
using System.Text;
using System;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "ScrollConsoleScreenBuffer", SetLastError = true)]
  public static extern bool ScrollConsoleScreenBuffer(
    [In] IntPtr consoleOutput,
    [In] ref SmallRectangle scrollRectangle,
    [In] ref SmallRectangle clipRectangle,
    [In] Coordinate destinationOrigin,
    [In] ref CharacterInformation fill
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleActiveScreenBuffer", SetLastError = true)]
  public static extern bool SetConsoleActiveScreenBuffer([In] IntPtr consoleOutput);

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleCP", SetLastError = true)]
  public static extern bool SetConsoleCodePage([In] uint codePageId);

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleCtrlHandler", SetLastError = true)]
  public static extern bool SetConsoleCtrlHandler(
    [In] Callbacks.HandlerRoutine handlerRoutine,
    [In] bool add
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleCursorInfo", SetLastError = true)]
  public static extern bool SetConsoleCursorInformation(
    [In] IntPtr consoleOutput,
    [In] ref ConsoleCursorInformation consoleCursorInfo
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleCursorPosition", SetLastError = true)]
  public static extern bool SetConsoleCursorPosition(
    [In] IntPtr consoleOutput,
    [In] Coordinate cursorPosition
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleDisplayMode", SetLastError = true)]
  public static extern bool SetConsoleDisplayMode(
    [In] IntPtr consoleOutput,
    [In] ConsoleDisplayMode flags,
    [Out] out Coordinate newScreenBufferDimensions
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleHistoryInfo", SetLastError = true)]
  public static extern bool SetConsoleHistoryInformation([In] ConsoleHistoryInformation consoleHistoryInfo);

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleMode", SetLastError = true)]
  public static extern bool SetConsoleMode(
    [In] IntPtr consoleHandle,
    [In] ConsoleMode mode
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleOutputCP", SetLastError = true)]
  public static extern bool SetConsoleOutputCodePage([In] uint codePageId);

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleScreenBufferInfoEx", SetLastError = true)]
  public static extern bool SetConsoleScreenBufferInfoExtended(
    [In] IntPtr consoleOutput,
    [In] ConsoleScreenBufferInformationExtended consoleScreenBufferInfoExtended
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleScreenBufferSize", SetLastError = true)]
  public static extern bool SetConsoleScreenBufferSize(
    [In] IntPtr consoleOutput,
    [In] Coordinate size
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleTextAttribute", SetLastError = true)]
  public static extern bool SetConsoleTextAttribute(
    [In] IntPtr consoleOutput,
    [In] CharacterAttributes wAttributes
  );

  // @
  
  [DllImport(
    DllName, EntryPoint = "SetConsoleTitle",
    CharSet = CharSet.Unicode, SetLastError = true
  )]
  public static extern bool SetConsoleTitle(
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder consoleTitle
  );

  // @

  [DllImport(DllName, EntryPoint = "SetConsoleWindowInfo", SetLastError = true)]
  public static extern bool SetConsoleWindowInformation(
    [In] IntPtr consoleOutput,
    [In] bool absolute,
    [In] ref SmallRectangle consoleWindow
  );

  // @

  [DllImport(DllName, EntryPoint = "SetCurrentConsoleFontEx", SetLastError = true)]
  public static extern bool SetCurrentConsoleFontExtended(
    [In] IntPtr consoleOutput,
    [In] bool maximumWindow,
    [In] ref ConsoleFontInformationExtended consoleCurrentFontExtended
  );

  // @

  [DllImport(DllName, EntryPoint = "SetStdHandle", SetLastError = true)]
  public static extern bool SetStdHandle(
    [In] ConsoleStandardDevice stdHandle,
    [In] IntPtr handle
  );
}