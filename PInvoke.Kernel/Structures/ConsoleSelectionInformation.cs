using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Sequential)]
public record struct ConsoleSelectionInformation
{
  public SelectionIndicator Flags;
  public Coordinate SelectionAnchor;
  public SmallRectangle Selection;
}
