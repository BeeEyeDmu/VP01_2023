using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_format
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int x = 10, y=20;
      Console.WriteLine("Hello World!");
      // x = 10, y = 20
      Console.WriteLine("x = " + x + ", y = " + y);

      // 포맷으로 출력
      // 10 이하의 소수 : 2, 3, 5, 7
      Console.WriteLine("10 이하의 소수 : 2, 3, 5, 7");
      Console.WriteLine
        ("10 이하의 소수 : " + 2 + ", " + 3 + ", " + 5 + ", " + 7);
      Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}",
        2, 3, 5, 7);
      Console.WriteLine("10 이하의 소수 : {3}, {2}, {1}, {0}",
        2, 3, 5, 7);
      // printf("%d, %d, %d, %d", 2, 3, 5, 7);


    }
  }
}
