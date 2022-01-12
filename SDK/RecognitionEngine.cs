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

public class RecognitionEngine : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal RecognitionEngine(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(RecognitionEngine obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~RecognitionEngine() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_RecognitionEngine(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RecognitionEngine(string config_path, bool lazy_configuration) : this(csSmartIdEnginePINVOKE.new_RecognitionEngine__SWIG_0(config_path, lazy_configuration), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public RecognitionEngine(string config_path) : this(csSmartIdEnginePINVOKE.new_RecognitionEngine__SWIG_1(config_path), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public RecognitionEngine(byte[] config_data, uint data_length, bool lazy_configuration) : this(csSmartIdEnginePINVOKE.new_RecognitionEngine__SWIG_2(config_data, data_length, lazy_configuration), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public RecognitionEngine(byte[] config_data, uint data_length) : this(csSmartIdEnginePINVOKE.new_RecognitionEngine__SWIG_3(config_data, data_length), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SessionSettings CreateSessionSettings() {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.RecognitionEngine_CreateSessionSettings(swigCPtr.DangerousGetHandle());
    SessionSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new SessionSettings(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RecognitionSession SpawnSession(SessionSettings session_settings, ResultReporterInterface result_reporter) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.RecognitionEngine_SpawnSession__SWIG_0(swigCPtr.DangerousGetHandle(), SessionSettings.getCPtr(session_settings).DangerousGetHandle(), ResultReporterInterface.getCPtr(result_reporter).DangerousGetHandle());
    RecognitionSession ret = (cPtr == global::System.IntPtr.Zero) ? null : new RecognitionSession(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RecognitionSession SpawnSession(SessionSettings session_settings) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.RecognitionEngine_SpawnSession__SWIG_1(swigCPtr.DangerousGetHandle(), SessionSettings.getCPtr(session_settings).DangerousGetHandle());
    RecognitionSession ret = (cPtr == global::System.IntPtr.Zero) ? null : new RecognitionSession(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string GetVersion() {
    string ret = csSmartIdEnginePINVOKE.RecognitionEngine_GetVersion();
    return ret;
  }

}

}