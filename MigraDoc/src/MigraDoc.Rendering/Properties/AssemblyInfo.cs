#region MigraDoc - Creating Documents on the Fly
//
// Copyright (c) 2001-2019 empira Software GmbH, Cologne Area (Germany)
//
// http://www.pdfsharp.com
// http://www.migradoc.com
// http://sourceforge.net/projects/pdfsharp
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MigraDoc.Rendering;

[assembly: System.Runtime.Versioning.SupportedOSPlatform("windows")]
[assembly: AssemblyTitle(VersionInfo.Title)]
[assembly: AssemblyDescription(VersionInfo.Description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(VersionInfo.Company)]
#if DEBUG
[assembly: AssemblyProduct(VersionInfo.Product + " (Debug Build)")]
#else
  [assembly: AssemblyProduct(VersionInfo.Product)]
#endif
[assembly: AssemblyCopyright(VersionInfo.Copyright)]
[assembly: AssemblyTrademark(VersionInfo.Trademark)]
[assembly: AssemblyVersion(VersionInfo.Version)]
[assembly: AssemblyCulture(VersionInfo.Culture)]

[assembly: ComVisible(false)]
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyName("")]
