﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2021 by EMGU Corporation. All rights reserved.
//
//  Vector of Rect
//
//  This file is automatically generated, do not modify.
//----------------------------------------------------------------------------



using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Emgu.CV.Structure;

namespace Emgu.CV.Util
{
   /// <summary>
   /// Wrapped class of the C++ standard vector of Rect.
   /// </summary>
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfRect.DebuggerProxy))]
   public partial class VectorOfRect : Emgu.Util.UnmanagedObject, ISerializable
#if true
      , IInputOutputArray
#endif
   {
      private readonly bool _needDispose;
   
      static VectorOfRect()
      {
         CvInvoke.Init();
         Debug.Assert(Emgu.Util.Toolbox.SizeOf<Rectangle>() == SizeOfItemInBytes, "Size do not match");
      }

      /// <summary>
      /// Constructor used to deserialize runtime serialized object
      /// </summary>
      /// <param name="info">The serialization info</param>
      /// <param name="context">The streaming context</param>
      public VectorOfRect(SerializationInfo info, StreamingContext context)
         : this()
      {
         Push((Rectangle[])info.GetValue("RectArray", typeof(Rectangle[])));
      }
	  
      /// <summary>
      /// A function used for runtime serialization of the object
      /// </summary>
      /// <param name="info">Serialization info</param>
      /// <param name="context">Streaming context</param>
      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue("RectArray", ToArray());
      }

      /// <summary>
      /// Create an empty standard vector of Rect
      /// </summary>
      public VectorOfRect()
         : this(VectorOfRectCreate(), true)
      {
      }
	  
      internal VectorOfRect(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of Rect of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfRect(int size)
         : this( VectorOfRectCreateSize(size), true)
      {
      }
	  
      /// <summary>
      /// Create an standard vector of Rect with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
      public VectorOfRect(Rectangle[] values)
         :this()
      {
         Push(values);
      }
	  
      /// <summary>
      /// Push an array of value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(Rectangle[] value)
      {
         if (value.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
            VectorOfRectPushMulti(_ptr, handle.AddrOfPinnedObject(), value.Length);
            handle.Free();
         }
      }
      
      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfRect other)
      {
         VectorOfRectPushVector(_ptr, other);
      }
	  
      /// <summary>
      /// Convert the standard vector to an array of Rect
      /// </summary>
      /// <returns>An array of Rect</returns>
      public Rectangle[] ToArray()
      {
         Rectangle[] res = new Rectangle[Size];
         if (res.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(res, GCHandleType.Pinned);
            VectorOfRectCopyData(_ptr, handle.AddrOfPinnedObject());
            handle.Free();
         }
         return res;
      }

      /// <summary>
      /// Get the size of the vector
      /// </summary>
      public int Size
      {
         get
         {
            return VectorOfRectGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfRectClear(_ptr);
      }

      /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public IntPtr StartAddress
      {
         get
         {
            return VectorOfRectGetStartAddress(_ptr);
         }
      }
	  
      /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public Rectangle this[int index]
      {
         get
         {
            Rectangle result = new Rectangle();
            VectorOfRectGetItem(_ptr, index, ref result);
            return result;
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfRectRelease(ref _ptr);
      }

#if true
      /// <summary>
      /// Get the data as InputArray
      /// </summary>
      /// <returns>The input array </returns>
      public InputArray GetInputArray()
      {
         return new InputArray( cveInputArrayFromVectorOfRect(_ptr), this );
      }
	  
      /// <summary>
      /// Get the data as OutputArray
      /// </summary>
      /// <returns>The output array </returns>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cveOutputArrayFromVectorOfRect(_ptr), this );
      }

      /// <summary>
      /// Get the data as InputOutputArray
      /// </summary>
      /// <returns>The input output array </returns>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cveInputOutputArrayFromVectorOfRect(_ptr), this );
      }
#endif
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfRectSizeOfItemInBytes(); }
      }
	  
      internal class DebuggerProxy
      {
         private VectorOfRect _v;

         public DebuggerProxy(VectorOfRect v)
         {
            _v = v;
         }

         public Rectangle[] Values
         {
            get { return _v.ToArray(); }
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfRectCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfRectCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfRectRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfRectGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfRectCopyData(IntPtr v, IntPtr data);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfRectGetStartAddress(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfRectPushMulti(IntPtr v, IntPtr values, int count);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfRectPushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfRectClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfRectGetItem(IntPtr vec, int index, ref Rectangle element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfRectSizeOfItemInBytes();

#if true      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputArrayFromVectorOfRect(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveOutputArrayFromVectorOfRect(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputOutputArrayFromVectorOfRect(IntPtr vec);
#endif
   }
}


