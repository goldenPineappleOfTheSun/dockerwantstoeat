//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace se.smartid {

public class Point : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal Point(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(Point obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~Point() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_Point(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Point() : this(csSmartIdEnginePINVOKE.new_Point__SWIG_0(), true) {
  }

  public Point(double x, double y) : this(csSmartIdEnginePINVOKE.new_Point__SWIG_1(x, y), true) {
  }

  public double x {
    set {
      csSmartIdEnginePINVOKE.Point_x_set(swigCPtr.DangerousGetHandle(), value);
    } 
    get {
      double ret = csSmartIdEnginePINVOKE.Point_x_get(swigCPtr.DangerousGetHandle());
      return ret;
    } 
  }

  public double y {
    set {
      csSmartIdEnginePINVOKE.Point_y_set(swigCPtr.DangerousGetHandle(), value);
    } 
    get {
      double ret = csSmartIdEnginePINVOKE.Point_y_get(swigCPtr.DangerousGetHandle());
      return ret;
    } 
  }

}

}