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

public class QuadrangleCollection : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<string, Quadrangle>
 {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal QuadrangleCollection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(QuadrangleCollection obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~QuadrangleCollection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_QuadrangleCollection(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public Quadrangle this[string key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(string key, out Quadrangle value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(Quadrangle);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get { 
      return false; 
    }
  }

  public global::System.Collections.Generic.ICollection<string> Keys {
    get {
      global::System.Collections.Generic.ICollection<string> keys = new global::System.Collections.Generic.List<string>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<Quadrangle> Values {
    get {
      global::System.Collections.Generic.ICollection<Quadrangle> vals = new global::System.Collections.Generic.List<Quadrangle>();
      foreach (global::System.Collections.Generic.KeyValuePair<string, Quadrangle> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }
  
  public void Add(global::System.Collections.Generic.KeyValuePair<string, Quadrangle> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<string, Quadrangle> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<string, Quadrangle> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, Quadrangle>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, Quadrangle>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<string> keyList = new global::System.Collections.Generic.List<string>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      string currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<string, Quadrangle>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, Quadrangle>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, Quadrangle>>.GetEnumerator() {
    return new QuadrangleCollectionEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new QuadrangleCollectionEnumerator(this);
  }

  public QuadrangleCollectionEnumerator GetEnumerator() {
    return new QuadrangleCollectionEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class QuadrangleCollectionEnumerator : global::System.Collections.IEnumerator, 
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, Quadrangle>>
  {
    private QuadrangleCollection collectionRef;
    private global::System.Collections.Generic.IList<string> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public QuadrangleCollectionEnumerator(QuadrangleCollection collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<string>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<string, Quadrangle> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<string, Quadrangle>)currentObject;
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
        string currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<string, Quadrangle>(currentKey, collectionRef[currentKey]);
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
  

  public QuadrangleCollection() : this(csSmartIdEnginePINVOKE.new_QuadrangleCollection__SWIG_0(), true) {
  }

  public QuadrangleCollection(QuadrangleCollection other) : this(csSmartIdEnginePINVOKE.new_QuadrangleCollection__SWIG_1(QuadrangleCollection.getCPtr(other).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = csSmartIdEnginePINVOKE.QuadrangleCollection_size(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public bool empty() {
    bool ret = csSmartIdEnginePINVOKE.QuadrangleCollection_empty(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public void Clear() {
    csSmartIdEnginePINVOKE.QuadrangleCollection_Clear(swigCPtr.DangerousGetHandle());
  }

  private Quadrangle getitem(string key) {
    Quadrangle ret = new Quadrangle(csSmartIdEnginePINVOKE.QuadrangleCollection_getitem(swigCPtr.DangerousGetHandle(), key), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(string key, Quadrangle x) {
    csSmartIdEnginePINVOKE.QuadrangleCollection_setitem(swigCPtr.DangerousGetHandle(), key, Quadrangle.getCPtr(x).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(string key) {
    bool ret = csSmartIdEnginePINVOKE.QuadrangleCollection_ContainsKey(swigCPtr.DangerousGetHandle(), key);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(string key, Quadrangle val) {
    csSmartIdEnginePINVOKE.QuadrangleCollection_Add(swigCPtr.DangerousGetHandle(), key, Quadrangle.getCPtr(val).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(string key) {
    bool ret = csSmartIdEnginePINVOKE.QuadrangleCollection_Remove(swigCPtr.DangerousGetHandle(), key);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = csSmartIdEnginePINVOKE.QuadrangleCollection_create_iterator_begin(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private string get_next_key(global::System.IntPtr swigiterator) {
    string ret = csSmartIdEnginePINVOKE.QuadrangleCollection_get_next_key(swigCPtr.DangerousGetHandle(), swigiterator);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    csSmartIdEnginePINVOKE.QuadrangleCollection_destroy_iterator(swigCPtr.DangerousGetHandle(), swigiterator);
  }

}

}