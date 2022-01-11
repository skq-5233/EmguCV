﻿//----------------------------------------------------------------------------
//
//  Copyright (C) 2004-2021 by EMGU Corporation. All rights reserved.
//
//  Vector of Triangle2DF
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
   /// Wrapped class of the C++ standard vector of Triangle2DF.
   /// </summary>
   [Serializable]
   [DebuggerTypeProxy(typeof(VectorOfTriangle2DF.DebuggerProxy))]
   public partial class VectorOfTriangle2DF : Emgu.Util.UnmanagedObject, ISerializable
#if true
      , IInputOutputArray
#endif
   {
      private readonly bool _needDispose;
   
      static VectorOfTriangle2DF()
      {
         CvInvoke.Init();
         Debug.Assert(Emgu.Util.Toolbox.SizeOf<Triangle2DF>() == SizeOfItemInBytes, "Size do not match");
      }

      /// <summary>
      /// Constructor used to deserialize runtime serialized object
      /// </summary>
      /// <param name="info">The serialization info</param>
      /// <param name="context">The streaming context</param>
      public VectorOfTriangle2DF(SerializationInfo info, StreamingContext context)
         : this()
      {
         Push((Triangle2DF[])info.GetValue("Triangle2DFArray", typeof(Triangle2DF[])));
      }
	  
      /// <summary>
      /// A function used for runtime serialization of the object
      /// </summary>
      /// <param name="info">Serialization info</param>
      /// <param name="context">Streaming context</param>
      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
         info.AddValue("Triangle2DFArray", ToArray());
      }

      /// <summary>
      /// Create an empty standard vector of Triangle2DF
      /// </summary>
      public VectorOfTriangle2DF()
         : this(VectorOfTriangle2DFCreate(), true)
      {
      }
	  
      internal VectorOfTriangle2DF(IntPtr ptr, bool needDispose)
      {
         _ptr = ptr;
         _needDispose = needDispose;
      }

      /// <summary>
      /// Create an standard vector of Triangle2DF of the specific size
      /// </summary>
      /// <param name="size">The size of the vector</param>
      public VectorOfTriangle2DF(int size)
         : this( VectorOfTriangle2DFCreateSize(size), true)
      {
      }
	  
      /// <summary>
      /// Create an standard vector of Triangle2DF with the initial values
      /// </summary>
      /// <param name="values">The initial values</param>
      public VectorOfTriangle2DF(Triangle2DF[] values)
         :this()
      {
         Push(values);
      }
	  
      /// <summary>
      /// Push an array of value into the standard vector
      /// </summary>
      /// <param name="value">The value to be pushed to the vector</param>
      public void Push(Triangle2DF[] value)
      {
         if (value.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(value, GCHandleType.Pinned);
            VectorOfTriangle2DFPushMulti(_ptr, handle.AddrOfPinnedObject(), value.Length);
            handle.Free();
         }
      }
      
      /// <summary>
      /// Push multiple values from the other vector into this vector
      /// </summary>
      /// <param name="other">The other vector, from which the values will be pushed to the current vector</param>
      public void Push(VectorOfTriangle2DF other)
      {
         VectorOfTriangle2DFPushVector(_ptr, other);
      }
	  
      /// <summary>
      /// Convert the standard vector to an array of Triangle2DF
      /// </summary>
      /// <returns>An array of Triangle2DF</returns>
      public Triangle2DF[] ToArray()
      {
         Triangle2DF[] res = new Triangle2DF[Size];
         if (res.Length > 0)
         {
            GCHandle handle = GCHandle.Alloc(res, GCHandleType.Pinned);
            VectorOfTriangle2DFCopyData(_ptr, handle.AddrOfPinnedObject());
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
            return VectorOfTriangle2DFGetSize(_ptr);
         }
      }

      /// <summary>
      /// Clear the vector
      /// </summary>
      public void Clear()
      {
         VectorOfTriangle2DFClear(_ptr);
      }

      /// <summary>
      /// The pointer to the first element on the vector. In case of an empty vector, IntPtr.Zero will be returned.
      /// </summary>
      public IntPtr StartAddress
      {
         get
         {
            return VectorOfTriangle2DFGetStartAddress(_ptr);
         }
      }
	  
      /// <summary>
      /// Get the item in the specific index
      /// </summary>
      /// <param name="index">The index</param>
      /// <returns>The item in the specific index</returns>
      public Triangle2DF this[int index]
      {
         get
         {
            Triangle2DF result = new Triangle2DF();
            VectorOfTriangle2DFGetItem(_ptr, index, ref result);
            return result;
         }
      }

      /// <summary>
      /// Release the standard vector
      /// </summary>
      protected override void DisposeObject()
      {
         if (_needDispose && _ptr != IntPtr.Zero)
            VectorOfTriangle2DFRelease(ref _ptr);
      }

#if true
      /// <summary>
      /// Get the data as InputArray
      /// </summary>
      /// <returns>The input array </returns>
      public InputArray GetInputArray()
      {
         return new InputArray( cveInputArrayFromVectorOfTriangle2DF(_ptr), this );
      }
	  
      /// <summary>
      /// Get the data as OutputArray
      /// </summary>
      /// <returns>The output array </returns>
      public OutputArray GetOutputArray()
      {
         return new OutputArray( cveOutputArrayFromVectorOfTriangle2DF(_ptr), this );
      }

      /// <summary>
      /// Get the data as InputOutputArray
      /// </summary>
      /// <returns>The input output array </returns>
      public InputOutputArray GetInputOutputArray()
      {
         return new InputOutputArray( cveInputOutputArrayFromVectorOfTriangle2DF(_ptr), this );
      }
#endif
      
      /// <summary>
      /// The size of the item in this Vector, counted as size in bytes.
      /// </summary>
      public static int SizeOfItemInBytes
      {
         get { return VectorOfTriangle2DFSizeOfItemInBytes(); }
      }
	  
      internal class DebuggerProxy
      {
         private VectorOfTriangle2DF _v;

         public DebuggerProxy(VectorOfTriangle2DF v)
         {
            _v = v;
         }

         public Triangle2DF[] Values
         {
            get { return _v.ToArray(); }
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfTriangle2DFCreate();

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfTriangle2DFCreateSize(int size);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTriangle2DFRelease(ref IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfTriangle2DFGetSize(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTriangle2DFCopyData(IntPtr v, IntPtr data);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr VectorOfTriangle2DFGetStartAddress(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTriangle2DFPushMulti(IntPtr v, IntPtr values, int count);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTriangle2DFPushVector(IntPtr ptr, IntPtr otherPtr);
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTriangle2DFClear(IntPtr v);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void VectorOfTriangle2DFGetItem(IntPtr vec, int index, ref Triangle2DF element);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern int VectorOfTriangle2DFSizeOfItemInBytes();

#if true      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputArrayFromVectorOfTriangle2DF(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveOutputArrayFromVectorOfTriangle2DF(IntPtr vec);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern IntPtr cveInputOutputArrayFromVectorOfTriangle2DF(IntPtr vec);
#endif
   }
}


