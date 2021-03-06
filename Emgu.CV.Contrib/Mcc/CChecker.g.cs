//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Mcc
{
   public static partial class MccInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern CChecker.TypeChart cveCCheckerGetTarget(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCCheckerSetTarget(
        IntPtr obj,  
        CChecker.TypeChart val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveCCheckerGetCost(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCCheckerSetCost(
        IntPtr obj,  
        float val);
     
   }

   public partial class CChecker
   {

     /// <summary>
     /// Target
     /// </summary>
     public CChecker.TypeChart Target
     {
        get { return MccInvoke.cveCCheckerGetTarget(_ptr); } 
        set { MccInvoke.cveCCheckerSetTarget(_ptr, value); }
     }
     
     /// <summary>
     /// Cost
     /// </summary>
     public float Cost
     {
        get { return MccInvoke.cveCCheckerGetCost(_ptr); } 
        set { MccInvoke.cveCCheckerSetCost(_ptr, value); }
     }
     
   }
}
