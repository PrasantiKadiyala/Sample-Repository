﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorApplication
{
  public class Program
  {
    static void Main(string[] args)
    {
      var result = MathLib.Math.Add(1, 2);
      var result2 = MathLib.Math.Mul(2, 3);
      Console.WriteLine("The result is {0}", result);
    }
  }
}
