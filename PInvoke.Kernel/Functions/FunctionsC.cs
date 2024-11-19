using System.Runtime.InteropServices;
using System;
using Microsoft.Win32.SafeHandles;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;
using PInvoke.Kernel.Structures;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "ClosePseudoConsole", SetLastError = true)]
  public static extern void ClosePseudoConsole([In] IntPtr handlePseudoConsole);

  // @

  [DllImport(DllName, EntryPoint = "CreatePseudoConsole", SetLastError = true)]
  public static extern ResultHandle CreatePseudoConsole(
    [In] Coordinate size,
    [In] IntPtr handleInput,
    [In] IntPtr handleOutput,
    [In] PseudoConsoleCreationOption flags,
    [Out] out IntPtr handlePseudoConsole
  );
  
  // @
  
  [DllImport(DllName, EntryPoint = "CreateConsoleScreenBuffer", SetLastError = true)]
  public static extern SafeFileHandle CreateConsoleScreenBuffer(
    [In] AccessRights desiredAccess,
    [In] ShareMode shareMode,
    [In] ref SecurityAttributes securityAttributes,
    [In] uint flags,
    [In] IntPtr screenBufferData = default
  );
}