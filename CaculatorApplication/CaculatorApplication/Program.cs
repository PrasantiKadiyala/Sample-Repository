using System;
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
      var result3 = MathLib.Math.Sub(4, 5);
      Console.WriteLine("The result of addition is {0}", result);
      Console.WriteLine("The result of multiplcation is {0}", result2);
    }
  }
}
