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

public class MouseWheelEventArgs : MouseEventArgs {
  private HandleRef swigCPtr;

  internal MouseWheelEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MouseWheelEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MouseWheelEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_MouseWheelEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    MouseWheelEventHandler handler_ = (MouseWheelEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new MouseWheelEventArgs(args, false));
    }
  }

  public int Delta {
    get {
      int ret = NoesisGUI_PINVOKE.MouseWheelEventArgs_Delta_get(swigCPtr);
      return ret;
    } 
  }

  public Orientation Orientation {
    get {
      Orientation ret = (Orientation)NoesisGUI_PINVOKE.MouseWheelEventArgs_Orientation_get(swigCPtr);
      return ret;
    } 
  }

  public MouseWheelEventArgs(object source, RoutedEvent arg1, int rotation, Orientation orientation) : this(NoesisGUI_PINVOKE.new_MouseWheelEventArgs__SWIG_0(Noesis.Extend.GetInstanceHandle(source), RoutedEvent.getCPtr(arg1), rotation, (int)orientation), true) {
  }

  public MouseWheelEventArgs(object source, RoutedEvent arg1, int rotation) : this(NoesisGUI_PINVOKE.new_MouseWheelEventArgs__SWIG_1(Noesis.Extend.GetInstanceHandle(source), RoutedEvent.getCPtr(arg1), rotation), true) {
  }

}

}
