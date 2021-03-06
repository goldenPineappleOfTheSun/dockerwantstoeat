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

public class ResultReporterInterface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal ResultReporterInterface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(ResultReporterInterface obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~ResultReporterInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_ResultReporterInterface(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void SnapshotRejected() {
    if (SwigDerivedClassHasMethod("SnapshotRejected", swigMethodTypes0)) csSmartIdEnginePINVOKE.ResultReporterInterface_SnapshotRejectedSwigExplicitResultReporterInterface(swigCPtr.DangerousGetHandle()); else csSmartIdEnginePINVOKE.ResultReporterInterface_SnapshotRejected(swigCPtr.DangerousGetHandle());
  }

  public virtual void FeedbackReceived(ProcessingFeedback processing_feedback) {
    if (SwigDerivedClassHasMethod("FeedbackReceived", swigMethodTypes1)) csSmartIdEnginePINVOKE.ResultReporterInterface_FeedbackReceivedSwigExplicitResultReporterInterface(swigCPtr.DangerousGetHandle(), ProcessingFeedback.getCPtr(processing_feedback).DangerousGetHandle()); else csSmartIdEnginePINVOKE.ResultReporterInterface_FeedbackReceived(swigCPtr.DangerousGetHandle(), ProcessingFeedback.getCPtr(processing_feedback).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void DocumentMatched(MatchResultVector match_results) {
    if (SwigDerivedClassHasMethod("DocumentMatched", swigMethodTypes2)) csSmartIdEnginePINVOKE.ResultReporterInterface_DocumentMatchedSwigExplicitResultReporterInterface(swigCPtr.DangerousGetHandle(), MatchResultVector.getCPtr(match_results).DangerousGetHandle()); else csSmartIdEnginePINVOKE.ResultReporterInterface_DocumentMatched(swigCPtr.DangerousGetHandle(), MatchResultVector.getCPtr(match_results).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void DocumentSegmented(SegmentationResultVector segmentation_results) {
    if (SwigDerivedClassHasMethod("DocumentSegmented", swigMethodTypes3)) csSmartIdEnginePINVOKE.ResultReporterInterface_DocumentSegmentedSwigExplicitResultReporterInterface(swigCPtr.DangerousGetHandle(), SegmentationResultVector.getCPtr(segmentation_results).DangerousGetHandle()); else csSmartIdEnginePINVOKE.ResultReporterInterface_DocumentSegmented(swigCPtr.DangerousGetHandle(), SegmentationResultVector.getCPtr(segmentation_results).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SnapshotProcessed(RecognitionResult recog_result) {
    csSmartIdEnginePINVOKE.ResultReporterInterface_SnapshotProcessed(swigCPtr.DangerousGetHandle(), RecognitionResult.getCPtr(recog_result).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SessionEnded() {
    if (SwigDerivedClassHasMethod("SessionEnded", swigMethodTypes5)) csSmartIdEnginePINVOKE.ResultReporterInterface_SessionEndedSwigExplicitResultReporterInterface(swigCPtr.DangerousGetHandle()); else csSmartIdEnginePINVOKE.ResultReporterInterface_SessionEnded(swigCPtr.DangerousGetHandle());
  }

  public ResultReporterInterface() : this(csSmartIdEnginePINVOKE.new_ResultReporterInterface(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("SnapshotRejected", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateResultReporterInterface_0(SwigDirectorSnapshotRejected);
    if (SwigDerivedClassHasMethod("FeedbackReceived", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateResultReporterInterface_1(SwigDirectorFeedbackReceived);
    if (SwigDerivedClassHasMethod("DocumentMatched", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateResultReporterInterface_2(SwigDirectorDocumentMatched);
    if (SwigDerivedClassHasMethod("DocumentSegmented", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateResultReporterInterface_3(SwigDirectorDocumentSegmented);
    if (SwigDerivedClassHasMethod("SnapshotProcessed", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateResultReporterInterface_4(SwigDirectorSnapshotProcessed);
    if (SwigDerivedClassHasMethod("SessionEnded", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateResultReporterInterface_5(SwigDirectorSessionEnded);
    csSmartIdEnginePINVOKE.ResultReporterInterface_director_connect(swigCPtr.DangerousGetHandle(), swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    bool hasDerivedMethod = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(this.GetType()).IsSubclassOf(typeof(ResultReporterInterface));
    return hasDerivedMethod;
  }

  private void SwigDirectorSnapshotRejected() {
    SnapshotRejected();
  }

  private void SwigDirectorFeedbackReceived(global::System.IntPtr processing_feedback) {
    FeedbackReceived(new ProcessingFeedback(processing_feedback, false));
  }

  private void SwigDirectorDocumentMatched(global::System.IntPtr match_results) {
    DocumentMatched(new MatchResultVector(match_results, false));
  }

  private void SwigDirectorDocumentSegmented(global::System.IntPtr segmentation_results) {
    DocumentSegmented(new SegmentationResultVector(segmentation_results, false));
  }

  private void SwigDirectorSnapshotProcessed(global::System.IntPtr recog_result) {
    SnapshotProcessed(new RecognitionResult(recog_result, false));
  }

  private void SwigDirectorSessionEnded() {
    SessionEnded();
  }

  public delegate void SwigDelegateResultReporterInterface_0();
  public delegate void SwigDelegateResultReporterInterface_1(global::System.IntPtr processing_feedback);
  public delegate void SwigDelegateResultReporterInterface_2(global::System.IntPtr match_results);
  public delegate void SwigDelegateResultReporterInterface_3(global::System.IntPtr segmentation_results);
  public delegate void SwigDelegateResultReporterInterface_4(global::System.IntPtr recog_result);
  public delegate void SwigDelegateResultReporterInterface_5();

  private SwigDelegateResultReporterInterface_0 swigDelegate0;
  private SwigDelegateResultReporterInterface_1 swigDelegate1;
  private SwigDelegateResultReporterInterface_2 swigDelegate2;
  private SwigDelegateResultReporterInterface_3 swigDelegate3;
  private SwigDelegateResultReporterInterface_4 swigDelegate4;
  private SwigDelegateResultReporterInterface_5 swigDelegate5;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(ProcessingFeedback) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(MatchResultVector) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(SegmentationResultVector) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(RecognitionResult) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] {  };
}

}
