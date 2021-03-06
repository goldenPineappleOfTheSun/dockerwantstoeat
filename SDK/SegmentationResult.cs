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

public class SegmentationResult : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal SegmentationResult(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(SegmentationResult obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~SegmentationResult() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_SegmentationResult(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SegmentationResult() : this(csSmartIdEnginePINVOKE.new_SegmentationResult__SWIG_0(), true) {
  }

  public SegmentationResult(QuadrangleCollection raw_fields_quadrangles, QuadrangleCollection raw_fields_template_quadrangles, bool accepted) : this(csSmartIdEnginePINVOKE.new_SegmentationResult__SWIG_1(QuadrangleCollection.getCPtr(raw_fields_quadrangles).DangerousGetHandle(), QuadrangleCollection.getCPtr(raw_fields_template_quadrangles).DangerousGetHandle(), accepted), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SegmentationResult(QuadrangleCollection raw_fields_quadrangles, QuadrangleCollection raw_fields_template_quadrangles) : this(csSmartIdEnginePINVOKE.new_SegmentationResult__SWIG_2(QuadrangleCollection.getCPtr(raw_fields_quadrangles).DangerousGetHandle(), QuadrangleCollection.getCPtr(raw_fields_template_quadrangles).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringVector GetRawFieldsNames() {
    StringVector ret = new StringVector(csSmartIdEnginePINVOKE.SegmentationResult_GetRawFieldsNames(swigCPtr.DangerousGetHandle()), true);
    return ret;
  }

  public bool HasRawFieldQuadrangle(string raw_field_name) {
    bool ret = csSmartIdEnginePINVOKE.SegmentationResult_HasRawFieldQuadrangle(swigCPtr.DangerousGetHandle(), raw_field_name);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Quadrangle GetRawFieldQuadrangle(string raw_field_name) {
    Quadrangle ret = new Quadrangle(csSmartIdEnginePINVOKE.SegmentationResult_GetRawFieldQuadrangle(swigCPtr.DangerousGetHandle(), raw_field_name), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QuadrangleCollection GetRawFieldQuadrangles() {
    QuadrangleCollection ret = new QuadrangleCollection(csSmartIdEnginePINVOKE.SegmentationResult_GetRawFieldQuadrangles(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public Quadrangle GetRawFieldTemplateQuadrangle(string raw_field_name) {
    Quadrangle ret = new Quadrangle(csSmartIdEnginePINVOKE.SegmentationResult_GetRawFieldTemplateQuadrangle(swigCPtr.DangerousGetHandle(), raw_field_name), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QuadrangleCollection GetRawFieldTemplateQuadrangles() {
    QuadrangleCollection ret = new QuadrangleCollection(csSmartIdEnginePINVOKE.SegmentationResult_GetRawFieldTemplateQuadrangles(swigCPtr.DangerousGetHandle()), false);
    return ret;
  }

  public bool GetAccepted() {
    bool ret = csSmartIdEnginePINVOKE.SegmentationResult_GetAccepted(swigCPtr.DangerousGetHandle());
    return ret;
  }

}

}
