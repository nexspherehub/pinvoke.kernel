using System.Runtime.InteropServices;
using System.Text;
using System;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "GetLastError")]
  public static extern SystemErrorCodes GetLastError();

  // @

  [DllImport(DllName, EntryPoint = "GetLastError")]
  public static extern uint GetLastErrorCode();
  
  // @
  
  [DllImport(DllName, EntryPoint = "GenerateConsoleCtrlEvent", SetLastError = true)]
  public static extern bool GenerateConsoleCtrlEvent(
    [In] ControlEvent ctrlEvent,
    [In] uint processGroupId
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleAlias", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern uint GetConsoleAlias(
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpSource,
    [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder targetBuffer,
    [In] uint targetBufferLength,
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder executableName
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleAliases", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern uint GetConsoleAliases(
    [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder aliasBuffer,
    [In] uint aliasBufferLength,
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder executableName
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleAliasesLength", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern uint GetConsoleAliasesLength([In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpExeName);

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleAliasExes", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern uint GetConsoleAliasExecutables(
    [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder executableNameBuffer,
    [In] uint executableNameBufferLength
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleAliasExesLength", SetLastError = true)]
  public static extern uint GetConsoleAliasExecutablesLength();

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleCP", SetLastError = true)]
  public static extern uint GetConsoleCodePage();

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleCursorInfo", SetLastError = true)]
  public static extern bool GetConsoleCursorInfo(
    [In] IntPtr consoleOutput,
    [Out] out ConsoleCursorInformation consoleCursorInfo
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleDisplayMode", SetLastError = true)]
  public static extern bool GetConsoleDisplayMode([Out] out ConsoleDisplayMode lpModeFlags);

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleFontSize", SetLastError = true)]
  public static extern Coordinate GetConsoleFontSize(
    [In] IntPtr consoleOutput,
    [In] uint font
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleHistoryInfo", SetLastError = true)]
  public static extern bool GetConsoleHistoryInfo([Out] out ConsoleHistoryInformation consoleHistoryInfo);

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleMode", SetLastError = true)]
  public static extern bool GetConsoleMode(
    [In] IntPtr consoleHandle,
    [Out] out ConsoleMode mode
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleOriginalTitle", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern uint GetConsoleOriginalTitle(
    [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder consoleTitle,
    [In] uint size
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleOutputCP", SetLastError = true)]
  public static extern uint GetConsoleOutputCodePage();

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleProcessList", SetLastError = true)]
  public static extern uint GetConsoleProcessList(
    [Out] out IntPtr[] processList,
    [In] uint processCount
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleScreenBufferInfo", SetLastError = true)]
  public static extern bool GetConsoleScreenBufferInfo(
    [In] IntPtr consoleOutput,
    [Out] out ConsoleScreenBufferInformation consoleScreenBufferInfo
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleScreenBufferInfoEx", SetLastError = true)]
  public static extern bool GetConsoleScreenBufferInfoExtended(
    [In] IntPtr consoleOutput,
    [Out] out ConsoleScreenBufferInformationExtended consoleScreenBufferInfoEx
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleSelectionInfo", SetLastError = true)]
  public static extern bool GetConsoleSelectionInfo(
    [Out] out ConsoleSelectionInformation consoleSelectionInfo
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleTitle", CharSet = CharSet.Unicode, SetLastError = true)]
  public static extern bool GetConsoleTitle(
    [Out, MarshalAs(UnmanagedType.LPWStr)] out StringBuilder consoleTitle,
    [In] uint size
  );

  // @

  [DllImport(DllName, EntryPoint = "GetConsoleWindow", SetLastError = true)]
  public static extern IntPtr GetConsoleWindow();

  // @

  [DllImport(DllName, EntryPoint = "GetCurrentConsoleFont", SetLastError = true)]
  public static extern bool GetCurrentConsoleFont(
    [In] IntPtr consoleOutput,
    [In] bool maximumWindow,
    [Out] out ConsoleFontInformation consoleCurrentFont
  );

  // @

  [DllImport(DllName, EntryPoint = "GetCurrentConsoleFontEx", SetLastError = true)]
  public static extern bool GetCurrentConsoleFontExtended(
    [In] IntPtr consoleOutput,
    [In] bool maximumWindow,
    [Out] out ConsoleFontInformationExtended consoleCurrentFontExtended
  );

  // @

  [DllImport(DllName, EntryPoint = "GetLargestConsoleWindowSize", SetLastError = true)]
  public static extern Coordinate GetLargestConsoleWindowSize(
    [In] IntPtr consoleOutput
  );

  // @

  [DllImport(DllName, EntryPoint = "GetNumberOfConsoleInputEvents", SetLastError = true)]
  public static extern bool GetNumberOfConsoleInputEvents(
    [In] IntPtr consoleInput,
    [Out] out uint numberOfEvents
  );

  // @

  [DllImport(DllName, EntryPoint = "GetNumberOfConsoleMouseButtons", SetLastError = true)]
  public static extern bool GetNumberOfConsoleMouseButtons([Out] out uint numberOfMouseButtons);

  // @

  [DllImport(DllName, EntryPoint = "GetStdHandle", SetLastError = true)]
  public static extern IntPtr GetStdHandle([In] ConsoleStandardDevice stdHandle);
}