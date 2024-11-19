using System.Runtime.InteropServices;
using System.Text;

namespace PInvoke.Kernel;

public static partial class Kernel
{
  [DllImport(DllName, EntryPoint = "AddConsoleAlias", CharSet = CharSet.Unicode,SetLastError = true)]
  public static extern bool AddConsoleAlias(
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder source,
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder target,
    [In, MarshalAs(UnmanagedType.LPWStr)] StringBuilder executableName
  );

  // @
  
  [DllImport(DllName, EntryPoint = "AllocConsole", SetLastError = true)]
  public static extern bool AllocConsole();

  // @

  [DllImport(DllName, EntryPoint = "AttachConsole", SetLastError = true)]
  public static extern bool AttachConsole([In] uint processId);
}