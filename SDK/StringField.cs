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

public class StringField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal StringField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(StringField obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~StringField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_StringField(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public StringField() : this(csSmartIdEnginePINVOKE.new_StringField__SWIG_0(), true) {
  }

  public StringField(string name, OcrString value, bool is_accepted, double confidence, StringCollection attributes) : this(csSmartIdEnginePINVOKE.new_StringField__SWIG_1(name, OcrString.getCPtr(value).DangerousGetHandle(), is_accepted, confidence, StringCollection.getCPtr(attributes).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringField(string name, OcrString value, bool is_accepted, double confidence) : this(csSmartIdEnginePINVOKE.new_StringField__SWIG_2(name, OcrString.getCPtr(value).DangerousGetHandle(), is_accepted, confidence), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringField(string name, string value, bool is_accepted, double confidence, StringCollection attributes) : this(csSmartIdEnginePINVOKE.new_StringField__SWIG_3(name, value, is_accepted, confidence, StringCollection.getCPtr(attributes).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringField(string name, string value, bool is_accepted, double confidence) : this(csSmartIdEnginePINVOKE.new_StringField__SWIG_4(name, value, is_accepted, confidence), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetName() {
    string ret = csSmartIdEnginePINVOKE.StringField_GetName(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public OcrString GetValue() {
    OcrString ret = new OcrString(csSmartIdEnginePINVOKE.StringField_GetValue(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public string GetUtf8Value() {
    string ret = csSmartIdEnginePINVOKE.StringField_GetUtf8Value(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public bool IsAccepted() {
    bool ret = csSmartIdEnginePINVOKE.StringField_IsAccepted(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public double GetConfidence() {
    double ret = csSmartIdEnginePINVOKE.StringField_GetConfidence(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public StringVector GetAttributeNames() {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.StringField_GetAttributeNames(swigCPtr.DangerousGetHandle()), true);
    return ret;
  }

  public StringCollection GetAttributes() {
    StringCollection ret = new StringCollection(csSmartIdEnginePINVOKE.StringField_GetAttributes(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public bool HasAttribute(string attribute_name) {
    bool ret = csSmartIdEnginePINVOKE.StringField_HasAttribute(swigCPtr.DangerousGetHandle(), attribute_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetAttribute(string attribute_name) {
    string ret = csSmartIdEnginePINVOKE.StringField_GetAttribute(swigCPtr.DangerousGetHandle(), attribute_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}