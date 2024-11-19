using System.Runtime.InteropServices;
using System;

namespace PInvoke.Kernel.Structures;
using PInvoke.Kernel.Enumerations;

[StructLayout(LayoutKind.Sequential)]
public record struct SecurityDescriptor
{
  public byte Revision;
  public byte Sbz1;
  public SecurityDescriptorControl Control;
  public IntPtr Owner;
  public IntPtr Group;
  public IntPtr Sacl;
  public IntPtr Dacl;
}
