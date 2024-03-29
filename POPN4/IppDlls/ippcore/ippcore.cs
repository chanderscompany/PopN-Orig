/*
//
//                  INTEL CORPORATION PROPRIETARY INFORMATION
//     This software is supplied under the terms of a license agreement or
//     nondisclosure agreement with Intel Corporation and may not be copied
//     or disclosed except in accordance with the terms of that agreement.
//        Copyright(c) 2003-2010 Intel Corporation. All Rights Reserved.
//
//     Intel(R) Integrated Performance Primitives Using Intel(R) IPP 
//     in Microsoft* C# .NET for Windows* Sample
//
//  By downloading and installing this sample, you hereby agree that the
//  accompanying Materials are being provided to you under the terms and
//  conditions of the End User License Agreement for the Intel(R) Integrated
//  Performance Primitives product previously accepted by you. Please refer
//  to the file ippEULA.rtf located in the root directory of your Intel(R) IPP
//  product installation for more information.
//
*/

// generated automatically on Tue Jan 27 11:23:16 2009

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ipp {

//
// enums
//
//
// hidden or own structures
//
   [StructLayout(LayoutKind.Sequential)] public struct IppMsgCatalog {};

unsafe public class core {

#if( x64 )
   internal const string libname = "ippcoreem64t-6.1.dll";
#else
   internal const string libname = "ippcore-6.1.dll";
#endif


[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
void ippAlignPtr (  char *ptr, int alignBytes );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippEnableCpu (  IppCpuType cpu );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
void ippFree (  char *ptr );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
ulong ippGetCpuClocks (    );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippGetCpuFeatures (  ulong *pFeaturesMask, uint *pCpuidInfoRegs );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippGetCpuFreqMhz (  int *pMhz );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppCpuType ippGetCpuType (    );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname,EntryPoint="ippGetLibVersion")] public static extern
int* xippGetLibVersion(  );
public static IppLibraryVersion ippGetLibVersion( ) {
   return new IppLibraryVersion( xippGetLibVersion() );
}

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippGetMaxCacheSizeB (  int *pSizeByte );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippGetMessageStatusI18n (  IppMsgCatalog *pMsgCatalog, IppStatus StsCode, ushort *pMsg );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
int ippGetNumCoresOnDie (    );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippGetNumThreads (  int *pNumThr );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname,EntryPoint="ippGetStatusString")] public static extern
sbyte* xippGetStatusString (  IppStatus StsCode );
public static string ippGetStatusString( IppStatus StsCode ) {
   return new string(xippGetStatusString(StsCode));
}

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippInit (    );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippInitCpu (  IppCpuType cpu );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
void ippMalloc (  int length );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippMessageCatalogCloseI18n (  IppMsgCatalog *pMsgCatalog );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippMessageCatalogOpenI18n (  IppMsgCatalog **pMsgCatalog );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippSetDenormAreZeros (  int value );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippSetFlushToZero (  int value, uint *pUMask );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippSetNumThreads (  int numThr );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippStaticInit (    );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
IppStatus ippStaticInitCpu (  IppCpuType cpu );

[SuppressUnmanagedCodeSecurityAttribute()]
[DllImport(ipp.core.libname)] public static extern
uint ippStatusToMessageIdI18n (  IppStatus StsCode );
};
};
