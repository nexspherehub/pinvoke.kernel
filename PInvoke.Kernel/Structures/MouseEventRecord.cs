using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Sequential)]
public record struct MouseEventRecord
{
  public Coordinate MousePosition;
  public MouseButtonState ButtonState;
  public ModifierKeyState ControlKeyState;
  public MouseEvent EventFlags;
}
