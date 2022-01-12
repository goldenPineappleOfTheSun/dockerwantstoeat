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

public class MatchResultVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<MatchResult>
 {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal MatchResultVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(MatchResultVector obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~MatchResultVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_MatchResultVector(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MatchResultVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MatchResult element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public MatchResult this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(MatchResult[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(MatchResult[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, MatchResult[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<MatchResult> global::System.Collections.Generic.IEnumerable<MatchResult>.GetEnumerator() {
    return new MatchResultVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new MatchResultVectorEnumerator(this);
  }

  public MatchResultVectorEnumerator GetEnumerator() {
    return new MatchResultVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class MatchResultVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<MatchResult>
  {
    private MatchResultVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public MatchResultVectorEnumerator(MatchResultVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public MatchResult Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (MatchResult)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    csSmartIdEnginePINVOKE.MatchResultVector_Clear(swigCPtr.DangerousGetHandle());
  }

  public void Add(MatchResult x) {
    csSmartIdEnginePINVOKE.MatchResultVector_Add(swigCPtr.DangerousGetHandle(), MatchResult.getCPtr(x).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = csSmartIdEnginePINVOKE.MatchResultVector_size(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private uint capacity() {
    uint ret = csSmartIdEnginePINVOKE.MatchResultVector_capacity(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private void reserve(uint n) {
    csSmartIdEnginePINVOKE.MatchResultVector_reserve(swigCPtr.DangerousGetHandle(), n);
  }

  public MatchResultVector() : this(csSmartIdEnginePINVOKE.new_MatchResultVector__SWIG_0(), true) {
  }

  public MatchResultVector(MatchResultVector other) : this(csSmartIdEnginePINVOKE.new_MatchResultVector__SWIG_1(MatchResultVector.getCPtr(other).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public MatchResultVector(int capacity) : this(csSmartIdEnginePINVOKE.new_MatchResultVector__SWIG_2(capacity), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private MatchResult getitemcopy(int index) {
    MatchResult ret = new MatchResult(csSmartIdEnginePINVOKE.MatchResultVector_getitemcopy(swigCPtr.DangerousGetHandle(), index), true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private MatchResult getitem(int index) {
    MatchResult ret = new MatchResult(csSmartIdEnginePINVOKE.MatchResultVector_getitem(swigCPtr.DangerousGetHandle(), index), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, MatchResult val) {
    csSmartIdEnginePINVOKE.MatchResultVector_setitem(swigCPtr.DangerousGetHandle(), index, MatchResult.getCPtr(val).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(MatchResultVector values) {
    csSmartIdEnginePINVOKE.MatchResultVector_AddRange(swigCPtr.DangerousGetHandle(), MatchResultVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public MatchResultVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.MatchResultVector_GetRange(swigCPtr.DangerousGetHandle(), index, count);
    MatchResultVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new MatchResultVector(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, MatchResult x) {
    csSmartIdEnginePINVOKE.MatchResultVector_Insert(swigCPtr.DangerousGetHandle(), index, MatchResult.getCPtr(x).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, MatchResultVector values) {
    csSmartIdEnginePINVOKE.MatchResultVector_InsertRange(swigCPtr.DangerousGetHandle(), index, MatchResultVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    csSmartIdEnginePINVOKE.MatchResultVector_RemoveAt(swigCPtr.DangerousGetHandle(), index);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    csSmartIdEnginePINVOKE.MatchResultVector_RemoveRange(swigCPtr.DangerousGetHandle(), index, count);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public static MatchResultVector Repeat(MatchResult value, int count) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.MatchResultVector_Repeat(MatchResult.getCPtr(value).DangerousGetHandle(), count);
    MatchResultVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new MatchResultVector(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    csSmartIdEnginePINVOKE.MatchResultVector_Reverse__SWIG_0(swigCPtr.DangerousGetHandle());
  }

  public void Reverse(int index, int count) {
    csSmartIdEnginePINVOKE.MatchResultVector_Reverse__SWIG_1(swigCPtr.DangerousGetHandle(), index, count);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, MatchResultVector values) {
    csSmartIdEnginePINVOKE.MatchResultVector_SetRange(swigCPtr.DangerousGetHandle(), index, MatchResultVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

}

}