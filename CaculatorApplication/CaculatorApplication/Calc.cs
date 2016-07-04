using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorApplication
{
  public class Calc
  {
    public int operand1;
    public int operand2;
    /// <summary>
    /// Constructor
    /// </summary>
    public Calc(int a , int b)
    {
      operand1 = a;
      operand2 = b;
      Console.WriteLine("This is Calc app");
    }
    public int Operations()
    {
      int result;
      Console.WriteLine("Please select the opeartor: 1) Add 2) Sub 3) Mult");     
      var op = Console.Read();
      switch(op)
      {
        case 1: result = MathLib.Math.Add(operand1, operand2);
          break;
        case 2: result = MathLib.Math.Sub(operand1, operand2);
          break;
        case 3: result = MathLib.Math.Mul(operand1, operand2);
          break;        
      }
      return result;
    }

  }
}
