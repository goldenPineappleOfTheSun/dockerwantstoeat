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

public class ImageFieldCollection : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<string, ImageField>
 {
  private global::System.Runtime.InteropServices.SafeHandle swigCPtr;
  protected bool swigCMemOwn;

  internal ImageFieldCollection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(cPtr, false);
  }

  internal static global::System.Runtime.InteropServices.SafeHandle getCPtr(ImageFieldCollection obj) {
    return (obj == null) ? new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false) : obj.swigCPtr;
  }

  ~ImageFieldCollection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != null && swigCPtr.DangerousGetHandle() != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csSmartIdEnginePINVOKE.delete_ImageFieldCollection(swigCPtr.DangerousGetHandle());
        }
        swigCPtr = new global::Microsoft.Win32.SafeHandles.SafeWaitHandle(global::System.IntPtr.Zero, false);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public ImageField this[string key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(string key, out ImageField value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(ImageField);
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

  public global::System.Collections.Generic.ICollection<ImageField> Values {
    get {
      global::System.Collections.Generic.ICollection<ImageField> vals = new global::System.Collections.Generic.List<ImageField>();
      foreach (global::System.Collections.Generic.KeyValuePair<string, ImageField> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }
  
  public void Add(global::System.Collections.Generic.KeyValuePair<string, ImageField> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<string, ImageField> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<string, ImageField> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, ImageField>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, ImageField>[] array, int arrayIndex) {
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
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<string, ImageField>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, ImageField>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, ImageField>>.GetEnumerator() {
    return new ImageFieldCollectionEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ImageFieldCollectionEnumerator(this);
  }

  public ImageFieldCollectionEnumerator GetEnumerator() {
    return new ImageFieldCollectionEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ImageFieldCollectionEnumerator : global::System.Collections.IEnumerator, 
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, ImageField>>
  {
    private ImageFieldCollection collectionRef;
    private global::System.Collections.Generic.IList<string> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ImageFieldCollectionEnumerator(ImageFieldCollection collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<string>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<string, ImageField> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<string, ImageField>)currentObject;
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
        currentObject = new global::System.Collections.Generic.KeyValuePair<string, ImageField>(currentKey, collectionRef[currentKey]);
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
  

  public ImageFieldCollection() : this(csSmartIdEnginePINVOKE.new_ImageFieldCollection__SWIG_0(), true) {
  }

  public ImageFieldCollection(ImageFieldCollection other) : this(csSmartIdEnginePINVOKE.new_ImageFieldCollection__SWIG_1(ImageFieldCollection.getCPtr(other).DangerousGetHandle()), true) {
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = csSmartIdEnginePINVOKE.ImageFieldCollection_size(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public bool empty() {
    bool ret = csSmartIdEnginePINVOKE.ImageFieldCollection_empty(swigCPtr.DangerousGetHandle());
    return ret;
  }

  public void Clear() {
    csSmartIdEnginePINVOKE.ImageFieldCollection_Clear(swigCPtr.DangerousGetHandle());
  }

  private ImageField getitem(string key) {
    ImageField ret = new ImageField(csSmartIdEnginePINVOKE.ImageFieldCollection_getitem(swigCPtr.DangerousGetHandle(), key), false);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(string key, ImageField x) {
    csSmartIdEnginePINVOKE.ImageFieldCollection_setitem(swigCPtr.DangerousGetHandle(), key, ImageField.getCPtr(x).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(string key) {
    bool ret = csSmartIdEnginePINVOKE.ImageFieldCollection_ContainsKey(swigCPtr.DangerousGetHandle(), key);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(string key, ImageField val) {
    csSmartIdEnginePINVOKE.ImageFieldCollection_Add(swigCPtr.DangerousGetHandle(), key, ImageField.getCPtr(val).DangerousGetHandle());
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(string key) {
    bool ret = csSmartIdEnginePINVOKE.ImageFieldCollection_Remove(swigCPtr.DangerousGetHandle(), key);
    if (csSmartIdEnginePINVOKE.SWIGPendingException.Pending) throw csSmartIdEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = csSmartIdEnginePINVOKE.ImageFieldCollection_create_iterator_begin(swigCPtr.DangerousGetHandle());
    return ret;
  }

  private string get_next_key(global::System.IntPtr swigiterator) {
    string ret = csSmartIdEnginePINVOKE.ImageFieldCollection_get_next_key(swigCPtr.DangerousGetHandle(), swigiterator);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    csSmartIdEnginePINVOKE.ImageFieldCollection_destroy_iterator(swigCPtr.DangerousGetHandle(), swigiterator);
  }

}

}
