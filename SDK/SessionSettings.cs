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

public class SessionSettings : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal SessionSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(SessionSettings obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~SessionSettings() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_SessionSettings(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual SessionSettings Clone() {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.SessionSettings_Clone(swigCPtr.DangerousGetHandle());
    SessionSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new SessionSettings(cPtr, true);
    return ret;
  }

  public StringVector GetEnabledDocumentTypes() {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.SessionSettings_GetEnabledDocumentTypes(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public void AddEnabledDocumentTypes(string doctype_mask) {
    csSmartIdEnginePINVOKE.SessionSettings_AddEnabledDocumentTypes(swigCPtr.DangerousGetHandle(), doctype_mask);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveEnabledDocumentTypes(string doctype_mask) {
    csSmartIdEnginePINVOKE.SessionSettings_RemoveEnabledDocumentTypes(swigCPtr.DangerousGetHandle(), doctype_mask);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetEnabledDocumentTypes(StringVector document_types) {
    csSmartIdEnginePINVOKE.SessionSettings_SetEnabledDocumentTypes(swigCPtr.DangerousGetHandle(), StringVector.getCPtr(document_types).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector2d GetSupportedDocumentTypes() {
    StringVector2d ret = new StringVector2d(csSmartIdEnginePINVOKE.SessionSettings_GetSupportedDocumentTypes(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public StringVector GetOptionNames() {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.SessionSettings_GetOptionNames(swigCPtr.DangerousGetHandle()), true);
    return ret;
  }

  public bool HasOption(string name) {
    bool ret = csSmartIdEnginePINVOKE.SessionSettings_HasOption(swigCPtr.DangerousGetHandle(), name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetOption(string name) {
    string ret = csSmartIdEnginePINVOKE.SessionSettings_GetOption(swigCPtr.DangerousGetHandle(), name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetOption(string name, string value) {
    csSmartIdEnginePINVOKE.SessionSettings_SetOption(swigCPtr.DangerousGetHandle(), name, value);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveOption(string name) {
    csSmartIdEnginePINVOKE.SessionSettings_RemoveOption(swigCPtr.DangerousGetHandle(), name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVectorCollection GetEnabledFieldNames() {
    StringVectorCollection ret = new StringVectorCollection(csSmartIdEnginePINVOKE.SessionSettings_GetEnabledFieldNames(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public void EnableField(string doctype, string field_name) {
    csSmartIdEnginePINVOKE.SessionSettings_EnableField(swigCPtr.DangerousGetHandle(), doctype, field_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void DisableField(string doctype, string field_name) {
    csSmartIdEnginePINVOKE.SessionSettings_DisableField(swigCPtr.DangerousGetHandle(), doctype, field_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetEnabledFields(string doctype, StringVector field_names) {
    csSmartIdEnginePINVOKE.SessionSettings_SetEnabledFields(swigCPtr.DangerousGetHandle(), doctype, StringVector.getCPtr(field_names).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector GetSupportedFieldNames(string doctype) {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.SessionSettings_GetSupportedFieldNames(swigCPtr.DangerousGetHandle(), doctype), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringVectorCollection GetEnabledForensicFieldNames() {
    StringVectorCollection ret = new StringVectorCollection(csSmartIdEnginePINVOKE.SessionSettings_GetEnabledForensicFieldNames(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public void EnableForensicField(string doctype, string field_name) {
    csSmartIdEnginePINVOKE.SessionSettings_EnableForensicField(swigCPtr.DangerousGetHandle(), doctype, field_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void DisableForensicField(string doctype, string field_name) {
    csSmartIdEnginePINVOKE.SessionSettings_DisableForensicField(swigCPtr.DangerousGetHandle(), doctype, field_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetEnabledForensicFields(string doctype, StringVector field_names) {
    csSmartIdEnginePINVOKE.SessionSettings_SetEnabledForensicFields(swigCPtr.DangerousGetHandle(), doctype, StringVector.getCPtr(field_names).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector GetSupportedForensicFieldNames(string doctype) {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.SessionSettings_GetSupportedForensicFieldNames(swigCPtr.DangerousGetHandle(), doctype), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetCurrentMode() {
    string ret = csSmartIdEnginePINVOKE.SessionSettings_GetCurrentMode(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public void SetCurrentMode(string mode) {
    csSmartIdEnginePINVOKE.SessionSettings_SetCurrentMode(swigCPtr.DangerousGetHandle(), mode);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector GetAvailableModes() {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.SessionSettings_GetAvailableModes(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

}

}