﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the
// Error List, point to "Suppress Message(s)", and click
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "WinSCP.SessionException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "WinSCP.SessionLocalException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "WinSCP.SessionRemoteException")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.ElementLogReader.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Session.#Cleanup()")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames", Scope = "type", Target = "WinSCP.SynchronizationCriteria")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#Cleanup()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#Open(WinSCP.SessionOptions)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#WriteCommand(System.String)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SCP")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SCP", Scope = "namespace", Target = "WinSCP")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "WinSCP.Session.#Open(WinSCP.SessionOptions)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "WinSCP.SessionLocalException")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "WinSCP.SessionRemoteException")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "WinSCP.SessionException")]
[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.ChmodEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.CommandExecutionResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.FailedEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.FileOperationEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.FilePermissions")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.OperationEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.OperationResultBase")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.RemoteFileInfo")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.RemovalEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.RemovalOperationResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.Session")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.SessionException")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.SessionLocalException")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.SessionOptions")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.SessionRemoteException")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.SynchronizationResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.TouchEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.TransferEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.TransferOperationResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.TransferOptions")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.ChmodEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.CommandExecutionResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.FailedEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.FileOperationEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.OperationEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.OperationResultBase")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.RemoteFileInfo")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.RemovalEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.RemovalOperationResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.SessionException")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.SessionLocalException")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.SessionRemoteException")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.SynchronizationResult")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.TouchEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.TransferEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.TransferOperationResult")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "WinSCP.FailedEventHandler")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "WinSCP.FileTransferredEventHandler")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.RemoteDirectoryInfo")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.RemoteDirectoryInfo")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.RemoteFileInfoCollection")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "index", Scope = "member", Target = "WinSCP.ReadOnlyInteropCollectionHelper`1.#Item[System.Int32]")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "value", Scope = "member", Target = "WinSCP.ReadOnlyInteropCollectionHelper`1.#Item[System.Int32]")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.RemovalEventArgsCollection")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.SessionRemoteExceptionCollection")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.StringCollection")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.TransferEventArgsCollection")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#CheckVersion(System.String,System.Diagnostics.FileVersionInfo,System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#CheckVersions(System.String)")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "WinSCP.Logger.#WriteLine(System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Logger.#WriteEnvironmentInfo()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "WinSCP.OutputDataReceivedEventHandler")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#.ctor(WinSCP.Session,System.Boolean,System.String)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "WinSCP.ExeSessionProcess.#CreateEvent(System.String)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "WinSCP.ConsoleCommStruct.#_ptr")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "WinSCP.ExeSessionProcess.#InitializeConsole()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#InitializeChild()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#InitializeConsole()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#HasExited")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#ExitCode")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#Close()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ConsoleCommStruct.#Size")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ConsoleCommStruct.#.ctor(WinSCP.Session,Microsoft.Win32.SafeHandles.SafeFileHandle)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#CheckVersion(System.String,System.Diagnostics.FileVersionInfo)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2111:PointersShouldNotBeVisible", Scope = "member", Target = "WinSCP.SECURITY_ATTRIBUTES.#lpSecurityDescriptor")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "WinSCP.Job.#_handle")]
[assembly: SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "WinSCP.UnsafeNativeMethods.CloseHandle(System.IntPtr)", Scope = "member", Target = "WinSCP.Job.#Close()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Job.#.ctor()")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.OutputDataReceivedEventArgs")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1408:DoNotUseAutoDualClassInterfaceType", Scope = "type", Target = "WinSCP.OutputDataReceivedEventArgs")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#CheckVersion(System.String,System.Diagnostics.FileVersionInfo)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#.ctor(WinSCP.Session)")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "WinSCP.Session")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.Session.#System.Reflection.IReflect.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.ExeSessionProcess.#CheckVersion(System.String,System.Diagnostics.FileVersionInfo)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.Session.#Cleanup()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.Logger.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.SessionLogReader.#OpenLog()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.ExeSessionProcess.#Close()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.SessionLogReader.#LogContents()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.SessionLogReader.#LogContents()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.ElementLogReader.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#.ctor()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#Abort()")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#GetAssemblyFilePath()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.ExeSessionProcess.#AbortedOrExited()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.SessionLogReader.#DoRead()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.SessionLogReader.#Cleanup()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#GetTempPath()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Session.#SetupTempPath()")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.WriteLine(System.String)", Scope = "member", Target = "WinSCP.Logger.#GetAssemblyFilePath()")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "CPS", Scope = "member", Target = "WinSCP.FileTransferProgressEventArgs.#CPS")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.FileTransferProgressEventArgs")]
[assembly: SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Scope = "type", Target = "WinSCP.FileTransferProgressEventHandler")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#CreateFileMapping(Microsoft.Win32.SafeHandles.SafeFileHandle,System.IntPtr,System.Int32,System.Int32,System.Int32,System.String)", Justification = "Warning is bogus.")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#MapViewOfFile(Microsoft.Win32.SafeHandles.SafeFileHandle,System.Int32,System.UInt32,System.UInt32,System.UIntPtr)", Justification = "Warning is bogus.")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#UnmapViewOfFile(System.IntPtr)", Justification = "Warning is bogus.")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#CloseHandle(System.IntPtr)", Justification = "Warning is bogus.")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#CreateJobObject(System.IntPtr,System.String)", Justification = "Warning is bogus.")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#SetInformationJobObject(System.IntPtr,WinSCP.JobObjectInfoType,System.IntPtr,System.UInt32)", Justification = "Warning is bogus.")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1409:ComVisibleTypesShouldBeCreatable", Scope = "type", Target = "WinSCP.TransferResumeSupport")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#CreateCounters()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#WriteCounters()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Logger.#WriteProcesses()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#WriteProcesses()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Logger.#GetProcessStartTime(System.Diagnostics.Process)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#GetProcessStartTime(System.Diagnostics.Process)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Logger.#GetTotalProcessorTime(System.Diagnostics.Process)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "WinSCP.Logger.#GetTotalProcessorTime(System.Diagnostics.Process)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2217:DoNotMarkEnumsWithFlags", Scope = "type", Target = "WinSCP.FileMapAccess")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#CreateFileMapping(Microsoft.Win32.SafeHandles.SafeFileHandle,System.IntPtr,WinSCP.FileMapProtection,System.Int32,System.Int32,System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#MapViewOfFile(Microsoft.Win32.SafeHandles.SafeFileHandle,WinSCP.FileMapAccess,System.UInt32,System.UInt32,System.UIntPtr)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke", Scope = "member", Target = "WinSCP.ExeSessionProcess.#InitializeConsole()")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke", Scope = "member", Target = "WinSCP.ExeSessionProcess.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Job.#.ctor(WinSCP.Logger,System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.Logger.#LastWin32ErrorMessage()")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "WinSCP.Session.#GuardProcessWithJobInternal")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "WinSCP.Session.#TestHandlesClosedInternal")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#TryCreateEvent(System.String,System.Threading.EventWaitHandle&)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Runtime.InteropServices.SafeHandle.DangerousGetHandle", Scope = "member", Target = "WinSCP.ExeSessionProcess.#TryCreateEvent(System.String,System.Threading.EventWaitHandle&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.SessionOptions.#GetPassword(System.Security.SecureString)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Scope = "member", Target = "WinSCP.SessionOptions.#ParseUrl(System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess+NoopSafeHandle.#.ctor(System.IntPtr)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#CreateFileMapping(System.String)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#GetProcessWindowStation()")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#GetThreadDesktop(System.Int32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#GetCurrentThreadId()")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "WinSCP.ExeSessionProcess.#CreateFileMapping(System.String)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "WinSCP.Logger.#CreateCounters()")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "WinSCP.SessionLogReader.#LogContents()")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "WinSCP.Session.#SessionOptionsToSwitches(WinSCP.SessionOptions,System.Boolean,System.String&,System.String&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA5122:PInvokesShouldNotBeSafeCriticalFxCopRule", Scope = "member", Target = "WinSCP.UnsafeNativeMethods.#RegGetValue(System.UIntPtr,System.String,System.String,WinSCP.RegistryFlags,WinSCP.RegistryType&,System.IntPtr,System.UInt32&)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands", Scope = "member", Target = "WinSCP.ExeSessionProcess.#GetInstallationPath(Microsoft.Win32.RegistryHive,Microsoft.Win32.RegistryKey)")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "WinSCP.Logger.DoWriteLine(System.String)", Scope = "member", Target = "WinSCP.Logger.#WriteException(System.Exception)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#CombinePaths(System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#EscapeFileMask(System.String)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#TranslateRemotePathToLocal(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#TranslateLocalPathToRemote(System.String,System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#GetDirectoryName(System.String)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#AddDirectorySeparator(System.String)")]
[assembly: SuppressMessage("Microsoft.Interoperability", "CA1407:AvoidStaticMembersInComVisibleTypes", Scope = "member", Target = "WinSCP.RemotePath.#GetFileName(System.String)")]
