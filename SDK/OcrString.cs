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

public class OcrString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal OcrString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(OcrString obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~OcrString() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_OcrString(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public OcrString() : this(csSmartIdEnginePINVOKE.new_OcrString__SWIG_0(), true) {
  }

  public OcrString(OcrCharVector ocr_chars) : this(csSmartIdEnginePINVOKE.new_OcrString__SWIG_1(OcrCharVector.getCPtr(ocr_chars).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public OcrString(string utf8_string) : this(csSmartIdEnginePINVOKE.new_OcrString__SWIG_2(utf8_string), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public OcrCharVector GetOcrChars() {
    OcrCharVector ret = new OcrCharVector(csSmartIdEnginePINVOKE.OcrString_GetOcrChars(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public string GetUtf8String() {
    string ret = csSmartIdEnginePINVOKE.OcrString_GetUtf8String(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public Utf16CharVector GetUtf16String() {
    Utf16CharVector ret = new Utf16CharVector(csSmartIdEnginePINVOKE.OcrString_GetUtf16String(swigCPtr.DangerousGetHandle()), true);
    return ret;
  }

}

}