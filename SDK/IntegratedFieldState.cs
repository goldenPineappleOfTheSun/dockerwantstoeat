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

public class IntegratedFieldState : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal IntegratedFieldState(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(IntegratedFieldState obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~IntegratedFieldState() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_IntegratedFieldState(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public IntegratedFieldState(bool is_terminal) : this(csSmartIdEnginePINVOKE.new_IntegratedFieldState__SWIG_0(is_terminal), true) {
  }

  public IntegratedFieldState() : this(csSmartIdEnginePINVOKE.new_IntegratedFieldState__SWIG_1(), true) {
  }

  public bool IsTerminal() {
    bool ret = csSmartIdEnginePINVOKE.IntegratedFieldState_IsTerminal(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public void SetIsTerminal(bool is_terminal) {
    csSmartIdEnginePINVOKE.IntegratedFieldState_SetIsTerminal(swigCPtr.DangerousGetHandle(), is_terminal);
  }

}

}