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
      Calc calculator = new Calc(2, 3);
      var result = calculator.Operations();
      Console.WriteLine("The result is :{0}", result);
    }
  }
}
