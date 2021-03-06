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

public class PointVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<Point>
 {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal PointVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(PointVector obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~PointVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_PointVector(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PointVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Point element in c) {
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

  public Point this[int index]  {
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

  public void CopyTo(Point[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Point[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Point[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<Point> global::System.Collections.Generic.IEnumerable<Point>.GetEnumerator() {
    return new PointVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new PointVectorEnumerator(this);
  }

  public PointVectorEnumerator GetEnumerator() {
    return new PointVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class PointVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Point>
  {
    private PointVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public PointVectorEnumerator(PointVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Point Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Point)currentObject;
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
    csSmartIdEnginePINVOKE.PointVector_Clear(swigCPtr.DangerousGetHandle());
  }

  public void Add(Point x) {
    csSmartIdEnginePINVOKE.PointVector_Add(swigCPtr.DangerousGetHandle(), Point.getCPtr(x).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = csSmartIdEnginePINVOKE.PointVector_size(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private uint capacity() {
    uint ret = csSmartIdEnginePINVOKE.PointVector_capacity(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private void reserve(uint n) {
    csSmartIdEnginePINVOKE.PointVector_reserve(swigCPtr.DangerousGetHandle(), n);
  }

  public PointVector() : this(csSmartIdEnginePINVOKE.new_PointVector__SWIG_0(), true) {
  }

  public PointVector(PointVector other) : this(csSmartIdEnginePINVOKE.new_PointVector__SWIG_1(PointVector.getCPtr(other).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public PointVector(int capacity) : this(csSmartIdEnginePINVOKE.new_PointVector__SWIG_2(capacity), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private Point getitemcopy(int index) {
    Point ret = new Point(csSmartIdEnginePINVOKE.PointVector_getitemcopy(swigCPtr.DangerousGetHandle(), index), true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Point getitem(int index) {
    Point ret = new Point(csSmartIdEnginePINVOKE.PointVector_getitem(swigCPtr.DangerousGetHandle(), index), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Point val) {
    csSmartIdEnginePINVOKE.PointVector_setitem(swigCPtr.DangerousGetHandle(), index, Point.getCPtr(val).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(PointVector values) {
    csSmartIdEnginePINVOKE.PointVector_AddRange(swigCPtr.DangerousGetHandle(), PointVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public PointVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.PointVector_GetRange(swigCPtr.DangerousGetHandle(), index, count);
    PointVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new PointVector(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Point x) {
    csSmartIdEnginePINVOKE.PointVector_Insert(swigCPtr.DangerousGetHandle(), index, Point.getCPtr(x).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, PointVector values) {
    csSmartIdEnginePINVOKE.PointVector_InsertRange(swigCPtr.DangerousGetHandle(), index, PointVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    csSmartIdEnginePINVOKE.PointVector_RemoveAt(swigCPtr.DangerousGetHandle(), index);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    csSmartIdEnginePINVOKE.PointVector_RemoveRange(swigCPtr.DangerousGetHandle(), index, count);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public static PointVector Repeat(Point value, int count) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.PointVector_Repeat(Point.getCPtr(value).DangerousGetHandle(), count);
    PointVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new PointVector(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    csSmartIdEnginePINVOKE.PointVector_Reverse__SWIG_0(swigCPtr.DangerousGetHandle());
  }

  public void Reverse(int index, int count) {
    csSmartIdEnginePINVOKE.PointVector_Reverse__SWIG_1(swigCPtr.DangerousGetHandle(), index, count);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, PointVector values) {
    csSmartIdEnginePINVOKE.PointVector_SetRange(swigCPtr.DangerousGetHandle(), index, PointVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
