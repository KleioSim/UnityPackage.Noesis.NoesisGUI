//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

internal class ExtendDictionaryIndexer : BaseComponent {
  internal new static ExtendDictionaryIndexer CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ExtendDictionaryIndexer(cPtr, cMemoryOwn);
  }

  internal ExtendDictionaryIndexer(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ExtendDictionaryIndexer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected ExtendDictionaryIndexer() {
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ExtendDictionaryIndexer(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}
