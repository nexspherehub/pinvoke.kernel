namespace PInvoke.Kernel.Enumerations;

[System.Flags]
public enum SystemErrorCodes : uint
{
  AlreadyAssigned = 0x55,
  AlreadyExists   = 0xB7,

  AutoDataSegmentExceeds64K = 0xC7,
  AtomicLocksNotSupported   = 0xAE,
  AdapterHardwareError      = 0x39,
  AccessDenied              = 0x5,
  ArenaTrashed              = 0x7,

  // @

  BadNetworkResponse  = 0x3A,
  BadRemoteAdapter    = 0x3C,
  BadThreadIdAddr     = 0x9F,
  BadEnvironment      = 0xA,
  BadNetworkName      = 0x43,
  BadDriverLevel      = 0x77,
  BadDevicePath       = 0x14A,
  BadExeFormat        = 0xC1,
  BadArguments        = 0xA0,
  BadFileType         = 0xDE,
  BadPathname         = 0xA1,
  BadDevType          = 0x42,
  BadNetPath          = 0x35,
  BadCommand          = 0x16,
  BadLength           = 0x18,
  BadFormat           = 0xB,
  BadUnit             = 0x14,
  BadPipe             = 0xE6,

  BufferOverflow  = 0x6F,
  BrokenPipe      = 0x6D,
  BusyDrive       = 0x8E,
  Busy            = 0xAA,

  // @

  CompressedFileNotSupported  = 0x14F,
  CyclicRedundancyCheck       = 0x17,
  CallNotImplemented          = 0x78,
  CheckoutRequired            = 0xDD,
  ChildNotComplete            = 0x81,
  CurrentDirectory            = 0x10,
  CannotCopy                  = 0x10A,

  CancelViolation = 0xAD,
  CannotMake      = 0x52,

  // @

  DirectoryNotSupported = 0x150,
  DirectoryNotEmpty     = 0x91,
  DirectoryNotRoot      = 0x90,
  Directory             = 0x10B,

  DiskResourcesExhausted  = 0x13A,
  DiskTooFragmented       = 0x12E,
  DiskChange              = 0x6B,
  DiskFull                = 0x70,

  DeviceFeatureNotSupported = 0x13C,
  DeviceSupportInProgress   = 0xAB,
  DeviceUnreachable         = 0x141,
  DeviceNoResources         = 0x142,
  DeviceNotExist            = 0x37,

  DataChecksumError = 0x143,
  DeletePending     = 0x12F,

  DynlinkFromInvalidRing  = 0xC4,
  DuplicatePrivileges     = 0x137,
  DirectAccessHandle      = 0x82,
  DuplicateName           = 0x34,
  DriveLocked             = 0x6C,
  Discarded               = 0x9D,

  // @

  ExtendedAttributeListInconsistent = 0xFF,
  ExtendedAttributesNotSupported    = 0x11A,
  ExtendedAttributeFileCorrupt      = 0x114,
  ExtendedAttributesDidntFit        = 0x113,
  ExtendedAttributeTableFull        = 0x115,

  ExeCannotModifyStrongSignedBinary = 0xDA,
  ExeCannotModifySignedBinary       = 0xD9,
  ExeMachineTypeMismatch            = 0xD8,
  ExeMarkedInvalid                  = 0xC0,

  EnvironmentVariableNotFound = 0xCB,
  ExclusiveSemAlreadyOwned    = 0x65,

  // @

  FileLevelTrimNotSupported = 0x146,
  FileCheckedOut            = 0xDC,
  FileNotFound              = 0x2,
  FileTooLarge              = 0xDF,
  FileExists                = 0x50,

  FailNoActionReboot  = 0x15E,
  FailShutdown        = 0x15F,
  FailRestart         = 0x160,

  FilenameExcedRange  = 0xCE,
  FormsAuthRequired   = 0xE0,
  FailInt24           = 0x53,

  // @

  GenFailure = 0x1F,

  // @

  HandleEndOfFile = 0x26,
  HandleDiskFull  = 0x27,

  // @

  InvalidAtInterruptTime  = 0x68,
  InvalidTargetHandle     = 0x72,
  InvalidVerifySwitch     = 0x76,
  InvalidParameter        = 0x57,
  InvalidCategory         = 0x75,
  InvalidPassword         = 0x56,
  InvalidFunction         = 0x1,
  InvalidAccess           = 0xC,
  InvalidHandle           = 0x6,
  InvalidBlock            = 0x9,
  InvalidDrive            = 0xF,
  InvalidData             = 0xD,

  InvalidExtendedAttributeHandle  = 0x116,
  InvalidExtendedAttributeName    = 0xFE,
  InvalidFieldInParameterList     = 0x148,
  InvalidStartingCodeSegment      = 0xBC,
  InvalidCentralAccessPolicy      = 0x140,
  InvalidExceptionHandler         = 0x136,
  InvalidOpLockProtocol           = 0x12D,
  InvalidSegmentNumber            = 0xB4,
  InvalidExeSignature             = 0xBF,
  InvalidStackSegment             = 0xBD,
  InvalidSignalNumber             = 0xD1,
  InvalidMinallocSize             = 0xC3,
  InvalidListFormat               = 0x99,
  InvalidFlagNumber               = 0xBA,
  InvalidModuleType               = 0xBE,
  InvalidSegmentDPL               = 0xC6,
  InvalidEventCount               = 0x97,
  InvalidLockRange                = 0x133,
  InvalidAddress                  = 0x1E7,
  InvalidOrdinal                  = 0xB6,
  InvalidToken                    = 0x13B,
  InvalidLevel                    = 0x7C,
  InvalidName                     = 0x7B,

  IsSubstTarget = 0x95,
  IsJoinTarget  = 0x85,
  IsSubstPath   = 0x92,
  IsJoinPath    = 0x93,
  IsSubsted     = 0x87,
  IsJoined      = 0x86,

  IncompatibleWithGlobalShortNameRegistrySetting  = 0x130,
  IntermixedKernelExtendedAttributeOperation      = 0x144,
  ImageSubsystemNotPresent                        = 0x134,
  IteratedDataExceeds64K                          = 0xC2,
  InFloopInRelocChain                             = 0xCA,
  InsufficientBuffer                              = 0x7A,
  IoplNotEnabled                                  = 0xC5,

  // @

  JoinToSubst = 0x8C,
  JoinToJoin  = 0x8A,

  // @

  LockViolation = 0x21,
  LabelTooLong  = 0x9A,
  LockFailed    = 0xA7,
  Locked        = 0xD4,

  // @

  MetaExpansionTooLong  = 0xD0,
  MemoryMidNotFound     = 0x13D,
  ModuleNotFound        = 0x7E,
  MoreData              = 0xEA,

  MaxSessionsReached  = 0x161,
  MaxThreadsReached   = 0xA4,

  // @

  NotAllowedOnSystemFile  = 0x139,
  NotRedundantStorage     = 0x14D,
  NotReadFromCopy         = 0x151,
  NotEnoughMemory         = 0x8,
  NotSameDevice           = 0x11,
  NotSupported            = 0x32,
  NotSubsted              = 0x89,
  NotDosDisk              = 0x1A,
  NotLocked               = 0x9E,
  NotJoined               = 0x88,
  NotOwner                = 0x120,
  NotReady                = 0x15,

  NetworkAccessDenied = 0x41,
  NetworkNameDeleted  = 0x40,
  NetworkWriteFault   = 0x58,
  NetworkBusy         = 0x36,

  NoMoreSearchHandles = 0x71,
  NoRangesProcessed   = 0x138,
  NoVolumeLabel       = 0x7D,
  NoSignalSent        = 0xCD,
  NoSpoolSpace        = 0x3E,
  NoMoreFiles         = 0x12,
  NoMoreItems         = 0x103,
  NoProcSlots         = 0x59,
  NoData              = 0xE8,

  NotificationGuidAlreadyDefined  = 0x135,
  NestingNotAllowed               = 0xD7,
  NegativeSeek                    = 0x83,

  // @

  OutOfStructures = 0x54,
  OutOfMemory     = 0xE,
  OutOfPaper      = 0x1C,

  OffsetAlignmentViolation  = 0x147,
  OperationInProgress       = 0x149,
  OpLockNotGranted          = 0x12C,
  OpenFailed                = 0x6E,

  // @

  PipeNotConnected  = 0xE9,
  PipeLocal         = 0xE5,
  PipeBusy          = 0xE7,

  PrinterQueueFull  = 0x3D,
  PrintCancelled    = 0x3F,

  ProcedureNotFound = 0x7F,
  PartialCopy       = 0x12B,

  PathNotFound = 0x3,
  PathBusy     = 0x94,

  ProcessModeAlreadyBackground  = 0x192,
  ProcessModeNotBackground      = 0x193,

  // @

  ResidentFileNotSupported  = 0x14E,
  RequestNotAccepted        = 0x47,
  RedirectPaused            = 0x48,
  RemoteNotList             = 0x33,

  RelocChainXeedsSegmentLimit = 0xC9,
  Ring2SegmentMustBeMovable   = 0xC8,
  Ring2StackInUse             = 0xCF,
  ReadFault                   = 0x1E,

  // @

  ShortNamesNotEnabledOnVolume  = 0x131,
  SecurityStreamIsInconsistent  = 0x132,
  SessionDisconnected           = 0xF0,
  ScrubDataDisabled             = 0x14C,
  SectorNotFound                = 0x1B,
  ScopeNotFound                 = 0x13E,
  SignalRefused                 = 0x9C,
  SignalPending                 = 0xA2,
  SubstToSubst                  = 0x8B,
  SubstToJoin                   = 0x8D,
  SystemTrace                   = 0x96,
  SameDrive                     = 0x8F,

  SharingBufferExceeded = 0x24,
  SharingViolation      = 0x20,
  SharingPaused         = 0x46,

  SemOwnerDied  = 0x69,
  SemUserLimit  = 0x6A,
  SemNotFound   = 0xBB,
  SemTimeout    = 0x79,
  SemIsSet      = 0x66,

  SeekOnDevice  = 0x84,
  Seek          = 0x19,

  Success = 0x0,

  // @

  TooManySemRequests  = 0x67,
  TooManyDescriptors  = 0x14B,
  TooManySemaphores   = 0x64,
  TooManyMuxWaiters   = 0x98,
  TooManyOpenFiles    = 0x4,
  TooManyCommands     = 0x38,
  TooManySession      = 0x45,
  TooManyModules      = 0xD6,
  TooManyPosts        = 0x12A,
  TooManyNames        = 0x44,
  TooManyTcbs         = 0x9B,

  ThreadModeAlreadyBackground = 0x190,
  ThreadModeNotBackground     = 0x191,
  Thread1Inactive             = 0xD2,

  // @

  UnexpectedNetworkError  = 0x3B,
  UndefinedScope          = 0x13F,

  // @

  VirusInfected = 0xE1,
  VirusDeleted  = 0xE2,

  // @

  WaitNoChildren  = 0x80,
  WriteProtect    = 0x13,
  WaitTimeout     = 0x102,
  WriteFault      = 0x1D,
  WrongDisk       = 0x22,
}