using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public static class Math
    {
      /// <summary>
      /// Addition method
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      public static int Add(int a, int b)
      {
        var result = a + b;
        return result ;
      }      

      /// <summary>
      ///  Multiplication method
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      public static int Mul(int a , int b)
      {
        var result = a * b;
        return result;
      }

      /// <summary>
      /// Subtraction method
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <returns></returns>
      public static int Sub(int a , int b)
      {
        int result;
        if (a > b)
          result = a - b;
        else
          result = b - a;
        return result;        
      }
    }
}
