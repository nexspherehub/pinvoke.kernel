namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum SecurityDescriptorControl : uint
{
  OwnerDefaulted  = 0x0001,
  GroupDefaulted  = 0x0002,

  // @
  
  DaclAutoInheritRequired = 0x0100,
  DaclAutoInherit         = 0x0400,
  DaclDefaulted           = 0x0008,
  DaclProtected           = 0x1000,
  DaclPresent             = 0x0004,

  // @

  SaclAutoInheritRequired = 0x0200,
  SaclAutoInherit         = 0x0800,
  SaclDefaulted           = 0x0020,
  SaclProtected           = 0x2000,
  SaclPresent             = 0x0010,

  // @

  ResourceManagerControlValid = 0x4000,
  SelfRelative                = 0x8000,
}