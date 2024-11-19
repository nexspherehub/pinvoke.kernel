[nuget_package]: https://www.nuget.org/packages/NexSphereHub.PInvoke.Kernel/
[releases]: https://github.com/nexspherehub/pinvoke.kernel/releases
[dotnet_framework]: https://dotnet.microsoft.com/en-us/
[visual_studio]: https://visualstudio.microsoft.com/en-us/
[funders_hub]: https://foundershub.startups.microsoft.com/

<!-- ==> • <== -->

# 🌐 NexSphere Hub • PInvoke.Kernel

The **[PInvoke.Kernel][nuget_package]** library has been meticulously developed to enable developers to invoke
functions available in the Windows Kernel32 API. All functions, structures, and enumerations have been
systematically organized and implemented in accordance with the official Microsoft documentation.

✨ **Begin your experience immediately!** ✨

- Acquire the [official package via NuGet][nuget_package].
- Download the [latest version][releases].

## 📘 About the Kernel32 API

The **Kernel32** API constitutes a fundamental interface of the Windows operating system, providing essential
low-level functions for its operation. This API is responsible for critical operations, including, but not limited
to, memory management, thread and process manipulation, as well as control of input/output devices.

### Key Functionalities:

- **Memory Management**: Allocation and release of memory.
- **Process and Thread Manipulation**: Creation, control, and termination of processes and threads.
- **Device Control**: Handling of files, directories, and input/output devices.
- **Synchronization**: Implementation of synchronization functions, such as mutexes and events.

This API is indispensable for developers who require direct interaction with the core of the Windows
operating system.

## 🛠️ Compiling the Library

To compile the library using [Visual Studio][visual_studio], it is recommended to select the **"Release"** mode.
If you choose to use a different IDE, it is advisable to consult the specific documentation for the
[.NET Framework][dotnet_framework] to appropriately configure your development environment.

## 📦 Packaging the Library

To package the library, the use of the **`nuget`** terminal tool is essential, which can be obtained from the
official website or installed via WinGet (recommended option). After installation, navigate to the "NuGet"
directory and execute the command `nuget pack .` to initiate the packaging process.

> **Note**: It is crucial to compile the project before proceeding with the packaging.

## ❤️ Acknowledgments to Microsoft

We would like to express our sincere gratitude to Microsoft for welcoming us into their
**[Startups Founders Hub][funders_hub]** program. The resources provided have proven to be fundamental for the
advancement of our technologies and innovations.
