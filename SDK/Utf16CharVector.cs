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

public class Utf16CharVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<ushort>
 {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal Utf16CharVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(Utf16CharVector obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~Utf16CharVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_Utf16CharVector(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Utf16CharVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (ushort element in c) {
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

  public ushort this[int index]  {
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

  public void CopyTo(ushort[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(ushort[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, ushort[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<ushort> global::System.Collections.Generic.IEnumerable<ushort>.GetEnumerator() {
    return new Utf16CharVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new Utf16CharVectorEnumerator(this);
  }

  public Utf16CharVectorEnumerator GetEnumerator() {
    return new Utf16CharVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class Utf16CharVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<ushort>
  {
    private Utf16CharVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public Utf16CharVectorEnumerator(Utf16CharVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public ushort Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (ushort)currentObject;
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
    csSmartIdEnginePINVOKE.Utf16CharVector_Clear(swigCPtr.DangerousGetHandle());
  }

  public void Add(ushort x) {
    csSmartIdEnginePINVOKE.Utf16CharVector_Add(swigCPtr.DangerousGetHandle(), x);
  }

  private uint size() {
    uint ret = csSmartIdEnginePINVOKE.Utf16CharVector_size(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private uint capacity() {
    uint ret = csSmartIdEnginePINVOKE.Utf16CharVector_capacity(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private void reserve(uint n) {
    csSmartIdEnginePINVOKE.Utf16CharVector_reserve(swigCPtr.DangerousGetHandle(), n);
  }

  public Utf16CharVector() : this(csSmartIdEnginePINVOKE.new_Utf16CharVector__SWIG_0(), true) {
  }

  public Utf16CharVector(Utf16CharVector other) : this(csSmartIdEnginePINVOKE.new_Utf16CharVector__SWIG_1(Utf16CharVector.getCPtr(other).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Utf16CharVector(int capacity) : this(csSmartIdEnginePINVOKE.new_Utf16CharVector__SWIG_2(capacity), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private ushort getitemcopy(int index) {
    ushort ret = csSmartIdEnginePINVOKE.Utf16CharVector_getitemcopy(swigCPtr.DangerousGetHandle(), index);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private ushort getitem(int index) {
    ushort ret = csSmartIdEnginePINVOKE.Utf16CharVector_getitem(swigCPtr.DangerousGetHandle(), index);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, ushort val) {
    csSmartIdEnginePINVOKE.Utf16CharVector_setitem(swigCPtr.DangerousGetHandle(), index, val);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(Utf16CharVector values) {
    csSmartIdEnginePINVOKE.Utf16CharVector_AddRange(swigCPtr.DangerousGetHandle(), Utf16CharVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Utf16CharVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.Utf16CharVector_GetRange(swigCPtr.DangerousGetHandle(), index, count);
    Utf16CharVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Utf16CharVector(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, ushort x) {
    csSmartIdEnginePINVOKE.Utf16CharVector_Insert(swigCPtr.DangerousGetHandle(), index, x);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, Utf16CharVector values) {
    csSmartIdEnginePINVOKE.Utf16CharVector_InsertRange(swigCPtr.DangerousGetHandle(), index, Utf16CharVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    csSmartIdEnginePINVOKE.Utf16CharVector_RemoveAt(swigCPtr.DangerousGetHandle(), index);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    csSmartIdEnginePINVOKE.Utf16CharVector_RemoveRange(swigCPtr.DangerousGetHandle(), index, count);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public static Utf16CharVector Repeat(ushort value, int count) {
    global::System.IntPtr cPtr = csSmartIdEnginePINVOKE.Utf16CharVector_Repeat(value, count);
    Utf16CharVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Utf16CharVector(cPtr, true);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    csSmartIdEnginePINVOKE.Utf16CharVector_Reverse__SWIG_0(swigCPtr.DangerousGetHandle());
  }

  public void Reverse(int index, int count) {
    csSmartIdEnginePINVOKE.Utf16CharVector_Reverse__SWIG_1(swigCPtr.DangerousGetHandle(), index, count);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, Utf16CharVector values) {
    csSmartIdEnginePINVOKE.Utf16CharVector_SetRange(swigCPtr.DangerousGetHandle(), index, Utf16CharVector.getCPtr(values).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(ushort value) {
    bool ret = csSmartIdEnginePINVOKE.Utf16CharVector_Contains(swigCPtr.DangerousGetHandle(), value);
    return ret;
  }

  public int IndexOf(ushort value) {
    int ret = csSmartIdEnginePINVOKE.Utf16CharVector_IndexOf(swigCPtr.DangerousGetHandle(), value);
    return ret;
  }

  public int LastIndexOf(ushort value) {
    int ret = csSmartIdEnginePINVOKE.Utf16CharVector_LastIndexOf(swigCPtr.DangerousGetHandle(), value);
    return ret;
  }

  public bool Remove(ushort value) {
    bool ret = csSmartIdEnginePINVOKE.Utf16CharVector_Remove(swigCPtr.DangerousGetHandle(), value);
    return ret;
  }

}

}
