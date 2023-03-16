using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_for
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int sum = 0;

      // 1~100의 합
      for (int i = 1; i <= 100; i++)
        sum += i;
      Console.WriteLine("1~100의 합 : {0}", sum);

      // 1~100의 홀수의 합
      sum = 0;
      for (int i = 1; i <= 100; i++)
        if (i % 2 == 1)
          sum += i;

      Console.WriteLine("1~100의 홀수의 합 : {0}", sum);

      double rSum = 0;
      for (int i = 1; i <= 100; i++)
        rSum += 1.0 / i;
      Console.WriteLine("1~100의 역수의 합 : {0}", rSum);

      Console.Write("구구단의 단을 입력 : ");
      int x = int.Parse(Console.ReadLine());

      for(int i=1; i<= 9; i++)
        Console.WriteLine("{0} x {1} = {2}", x, i, x*i);

      // 47. n의 m 승 구하기 = n을 m번 곱한다
      Console.Write("n 입력 : ");
      int n = int.Parse(Console.ReadLine());

      Console.Write("m 입력 : ");
      int m = int.Parse(Console.ReadLine());

      int exp = 1;
      for (int i = 1; i <= m; i++)
        exp *= n;
      Console.WriteLine("{0}의 {1}승은 {2}", n, m, exp);

      // 팩토리얼(k! = 1*2*3*...*k)
      Console.Write("구하고자 하는 팩토리얼 수를 입력 : ");
      int k = int.Parse(Console.ReadLine());
      int f = 1;
      for (int i = 1; i <= k; i++)
        f *= i;
      Console.WriteLine("{0} 팩토리얼은 {1}", k, f);

    }
  }
}
