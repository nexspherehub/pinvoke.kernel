using System.Runtime.InteropServices;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Explicit)]
public record struct InputRecord
{
  [FieldOffset(0)] public InputRecordEventType EventType;
  [FieldOffset(2)] public KeyEventRecord KeyEvent;
  [FieldOffset(2)] public MouseEventRecord MouseEvent;
  [FieldOffset(2)] public WindowBufferSizeRecord WindowBufferSizeEvent;
  [FieldOffset(2)] public MenuEventRecord MenuEvent;
  [FieldOffset(2)] public FocusEventRecord FocusEvent;
}
