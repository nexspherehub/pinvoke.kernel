using System.Runtime.InteropServices;

namespace PInvoke.Kernel;
using PInvoke.Kernel.Enumerations;

public static class Callbacks
{
  public delegate bool HandlerRoutine([In] ControlEvent ctrlType);
}